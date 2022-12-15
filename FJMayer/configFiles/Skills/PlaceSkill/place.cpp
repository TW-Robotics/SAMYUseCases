#include <place.h>
#include <skillsScriptingAPI.h>
#include <functional>
#include <iostream>

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
	void placeSkill(UA_CRCL_PoseDataType const * const placePose){
			
		// Copy the parameter in local variable
		UA_CRCL_PoseDataType placePose_local = *placePose;
			

		// Create commands vector
		std::vector<UA_CRCLCommandsParamsSetsUnionDataType> commands;


		UA_MoveToParamsSetDataType moveToAbove;
	    moveToAbove.name = UA_STRING( "UA_MoveToParamsSetDataType" );
		moveToAbove.realTimeParameter = false;
		moveToAbove.realTimeParameterNodeID = UA_NODEID_NUMERIC( 5, 0 );
	  	moveToAbove.moveStraight = false;
	    moveToAbove.endPosition = placePose_local;
		moveToAbove.endPosition.point.z += 0.05; // First move 5cm above the final pick position
		
		UA_CRCLCommandsParamsSetsUnionDataType moveToAboveUnion;
	    moveToAboveUnion.switchField = UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_MOVETOPARAMSSET;
	    moveToAboveUnion.fields.moveToParamsSet = moveToAbove;

		
		UA_MoveToParamsSetDataType moveTo;
	    moveTo.name = UA_STRING( "UA_MoveToParamsSetDataType" );
		moveTo.realTimeParameter = false;
		moveTo.realTimeParameterNodeID = UA_NODEID_NUMERIC( 5, 0 );
	  	moveTo.moveStraight = false;
	    moveTo.endPosition = placePose_local;
		
		UA_CRCLCommandsParamsSetsUnionDataType moveToUnion;
	    moveToUnion.switchField = UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_MOVETOPARAMSSET;
	    moveToUnion.fields.moveToParamsSet = moveTo;


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


		commands.push_back(moveToAboveUnion);
		commands.push_back(openUnion);
		commands.push_back(moveToUnion);
		commands.push_back(closeUnion);
		commands.push_back(moveToAboveUnion);


		setCommandsBuffer( commands ); /* Sets the buffer of commands to be executed by the robot to be the previously created vector 
		of commands "commands". It does not send them yet nor modifies the CommandsBuffer variable in the SAMYCore. 
		It sets the value in the internal class representing the robot 
		(this way commands can be accumulated without requesting yet the execution). */
		sendCommandsAndWait(); /*Writes the values currently stored for the robot in the CommandsBuffer node of the robot in the SAMYCore, 
		sets the node CommandStateBuffer to value PROCESSING_PENDING, and waits until the value of CommandStateBuffer is changed 
		(usually by the SAMYPlugin) either to PROCESSING_FAILED or to AWAITING. */
		}
}