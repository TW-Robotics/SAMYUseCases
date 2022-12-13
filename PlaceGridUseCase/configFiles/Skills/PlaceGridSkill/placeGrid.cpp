#include <placeGrid.h>
#include <skillsScriptingAPI.h>
#include <functional>
#include <iostream>
#include <unistd.h>

extern "C"{ // This is important, since avoid name mangling of the symbols, so the SAMYCore can find the correct chunck of compiled assembly code
	/* The parameters that receives the function are the parameters exposed in the skill parametersSet of the SAMYCore. 
	When you click "Start" method of the matching skill, the values are read and passed as arguments of this function, and this function 
	is then executed from a thread.
	At the moment, arguments has to be constant pointers to constant data, aka TypeName const * const parameterName 
	(e.g. UA_UInt32 const * const param1). T
	his is due to the fact that libffi has problems handing unions and I cannot pass them by value correctly in a portable way. 
	I will try to fix this but I am not sure is possible.
	What you should do is just at the very beggining of the skill copy them into a value and then doing with them whatever you want. E.g.:

		void testFunction2( UA_UInt32 const * const param1, UA_UInt32 const * const param2 ){
		UA_UInt32 param1_v = *param1; // You can do whatevery you want with param1_v now
		UA_UInt32 param2_v = *param2; // You can do whatevery you want with param2_v now

    I am planning to write a compiler-preprocessor based on Clang for automating these stuff so you can write code without these artifacts, 
	but for the moment should be fine like this.
	This file is created automatically through the createStructure.py scrpt.
	*/
	void placeGridSkill(UA_CRCL_PoseDataType const * const startPose,
	 					UA_CRCL_PoseDataType const * const pickPose,
	  					UA_CRCL_FractionDataType const * const slotsX,
	  				 	UA_CRCL_FractionDataType const * const slotsY,
	    				UA_CRCL_FractionDataType const * const offsetX,
		 				UA_CRCL_FractionDataType const * const offsetY)
		{
			
		// Copy the parameter in local variables
		UA_CRCL_PoseDataType startPose_local = *startPose;
		UA_CRCL_PoseDataType pickPose_local = *pickPose;
		UA_CRCL_FractionDataType slotsX_local = *slotsX;
		UA_CRCL_FractionDataType slotsY_local = *offsetX;
		UA_CRCL_FractionDataType offsetX_local = *slotsY;
		UA_CRCL_FractionDataType offsetY_local = *offsetY;
			
		std::cout << "OffsetX: " << offsetX_local.fraction << " | OffsetY: " << offsetY_local.fraction << std::endl;
		std::cout << "slotsX: " << slotsX_local.fraction << " | slotsY: " << slotsY_local.fraction << std::endl;
		std::cout << "StartPose point x: " << startPose_local.point.x << std::endl;
		std::cout << "StartPose point y: " << startPose_local.point.y << std::endl;
		std::cout << "StartPose point z: " << startPose_local.point.z << std::endl;
		// Create commands vector
		std::vector<UA_CRCLCommandsParamsSetsUnionDataType> commands;

		// Create pick pose
		UA_MoveToParamsSetDataType moveToPick;
	    moveToPick.name = UA_STRING( "UA_MoveToParamsSetDataType" );
		moveToPick.realTimeParameter = false;
		moveToPick.realTimeParameterNodeID = UA_NODEID_NUMERIC( 5, 0 );
	  	moveToPick.moveStraight = true;
	    moveToPick.endPosition = pickPose_local;

		UA_CRCLCommandsParamsSetsUnionDataType moveToPickUnion;
	    moveToPickUnion.switchField = UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_MOVETOPARAMSSET;
	    moveToPickUnion.fields.moveToParamsSet = moveToPick;

		// Create above pick pose
		UA_MoveToParamsSetDataType moveToAbovePick;
	    moveToAbovePick.name = UA_STRING( "UA_MoveToParamsSetDataType" );
		moveToAbovePick.realTimeParameter = false;
		moveToAbovePick.realTimeParameterNodeID = UA_NODEID_NUMERIC( 5, 0 );
	  	moveToAbovePick.moveStraight = false;
	    moveToAbovePick.endPosition = pickPose_local;
		moveToAbovePick.endPosition.point.z += 0.05; // First move 5cm above the final start position

		UA_CRCLCommandsParamsSetsUnionDataType moveToAbovePickUnion;
	    moveToAbovePickUnion.switchField = UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_MOVETOPARAMSSET;
	    moveToAbovePickUnion.fields.moveToParamsSet = moveToAbovePick;

		// Create place pose
		UA_MoveToParamsSetDataType moveTo;
	    moveTo.name = UA_STRING( "UA_MoveToParamsSetDataType" );
		moveTo.realTimeParameter = false;
		moveTo.realTimeParameterNodeID = UA_NODEID_NUMERIC( 5, 0 );
	  	moveTo.moveStraight = true;
	    moveTo.endPosition = startPose_local;

		UA_CRCLCommandsParamsSetsUnionDataType moveToUnion;
	    moveToUnion.switchField = UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_MOVETOPARAMSSET;
	    moveToUnion.fields.moveToParamsSet = moveTo;
		
		// Create placeAbove pose
		UA_MoveToParamsSetDataType moveToAbove;
	    moveToAbove.name = UA_STRING( "UA_MoveToParamsSetDataType" );
		moveToAbove.realTimeParameter = false;
		moveToAbove.realTimeParameterNodeID = UA_NODEID_NUMERIC( 5, 0 );
	  	moveToAbove.moveStraight = false;
	    moveToAbove.endPosition = startPose_local;
		moveToAbove.endPosition.point.z += 0.05; // First move 5cm above the final start position

		UA_CRCLCommandsParamsSetsUnionDataType moveToAboveUnion;
	    moveToAboveUnion.switchField = UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_MOVETOPARAMSSET;
	    moveToAboveUnion.fields.moveToParamsSet = moveToAbove;

		// Create close set endeffector
		UA_SetEndeffectorParamsSetDataType close;
		close.name = UA_STRING("closeGripper");
		close.realTimeParameter = false;
		close.realTimeParameterNodeID = UA_NODEID_NUMERIC( 5, 0 );
		close.setting.fraction = 1.0; // TODO Check if 1 is realy closed!!!!
		close.setting.fractionMin = 0.0;
		close.setting.fractionMax = 1.0;

		UA_CRCLCommandsParamsSetsUnionDataType closeUnion;
	    closeUnion.switchField = UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_SETENDEFFECTORPARAMSSET;
	    closeUnion.fields.setEndeffectorParamsSet = close;

		// Create open set endeffector
		UA_SetEndeffectorParamsSetDataType open;
		open.name = UA_STRING("closeGripper");
		open.realTimeParameter = false;
		open.realTimeParameterNodeID = UA_NODEID_NUMERIC( 5, 0 );
		open.setting.fraction = 0.0; // TODO Check if 1 is realy closed!!!!
		open.setting.fractionMin = 0.0;
		open.setting.fractionMax = 1.0;

		UA_CRCLCommandsParamsSetsUnionDataType openUnion;
	    openUnion.switchField = UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_SETENDEFFECTORPARAMSSET;
	    openUnion.fields.setEndeffectorParamsSet = open;

		
		for ( int x = 0; x < slotsX_local.fraction; x++)
		{
			for ( int y = 0; y < slotsY_local.fraction;  y++) //
			{
				// Check if there is a box available to be picked up
				// Skipp for now
				std::cout << "Start adding commands" << std::endl;

				std::cout << "X: " << x << " | Y: " << y << std::endl;
				// edit the x and y variables of the point
				moveTo.endPosition.point.x = moveTo.endPosition.point.x + offsetX_local.fraction * x;
				moveTo.endPosition.point.y = moveTo.endPosition.point.y + offsetY_local.fraction * y;
				moveToUnion.fields.moveToParamsSet = moveTo;
				// edit the x and y variables of the point
				moveToAbove.endPosition.point.x = moveToAbove.endPosition.point.x + offsetX_local.fraction * x;
				moveToAbove.endPosition.point.y = moveToAbove.endPosition.point.y + offsetY_local.fraction * y;
				moveToAboveUnion.fields.moveToParamsSet = moveToAbove;

				std::cout << "moveTo x: " << moveTo.endPosition.point.x << " | moveTo y: " << moveTo.endPosition.point.y << std::endl;
				std::cout << "moveToAbove x: " << moveToAbove.endPosition.point.x << " | moveToAbove y: " << moveToAbove.endPosition.point.y << std::endl;

				commands.push_back(moveToAbovePickUnion);
				commands.push_back(openUnion);
				commands.push_back(moveToPickUnion);
				commands.push_back(closeUnion);
				commands.push_back(moveToAbovePickUnion);
				commands.push_back(moveToAboveUnion);
				commands.push_back(moveToUnion);
				commands.push_back(openUnion);
				commands.push_back(moveToAboveUnion);
				std::cout << "One set of commands added" << std::endl;

				//setCommandsBuffer( commands );
				//std::cout << "send commands and wait" << std::endl;
				//sendCommandsAndWait();
				//std::cout << "Finished processing one set of commands" << std::endl;
				//commands.clear();
			}
		}
		std::cout << "All commands added to buffer" << std::endl;
		setCommandsBuffer(commands);
		sendCommandsAndWait();
		std::cout << "Finished processing commands" << std::endl;

		}
}