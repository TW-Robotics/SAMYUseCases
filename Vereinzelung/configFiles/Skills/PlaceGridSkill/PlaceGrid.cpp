#include <PlaceGrid.h>
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
	void placeGridSkill(UA_CRCL_PoseDataType const * const startPose, UA_CRCL_FractionDataType const * const offsetX, UA_CRCL_FractionDataType const * const offsetY, UA_CRCL_FractionDataType const * const counterX, UA_CRCL_FractionDataType const * const counterY){
			
		// Copy the parameter in local variable
		UA_CRCL_PoseDataType startPose_local = *startPose;
		UA_CRCL_FractionDataType offsetX_local = *offsetX;
		UA_CRCL_FractionDataType offsetY_local = *offsetY;
		UA_CRCL_FractionDataType counterX_local = *counterX;
		UA_CRCL_FractionDataType counterY_local = *counterY;
			

		// Create commands vector
		std::vector<UA_CRCLCommandsParamsSetsUnionDataType> commands;
		double offsetZ = 0.04;

		// Add a pose a little above the startPose to approch the place area
		UA_CRCL_PoseDataType poseAbove = *startPose;
		poseAbove.point.z += offsetZ;

		// Add the pose and offset it
		UA_CRCL_PoseDataType pose = *startPose;
		pose.point.x += offsetX_local.fraction * counterX_local.fraction;
		pose.point.y += offsetY_local.fraction * counterY_local.fraction;
		
		// Change the approach pose to be above the actual place pose
		poseAbove.point.x = pose.point.x;
		poseAbove.point.y = pose.point.y;

		// Create the moveTo command and add the poseAbove
	    UA_MoveToParamsSetDataType moveToPoseAbove;
	    moveToPoseAbove.name = UA_STRING( "UA_MoveToParamsSetDataType" );
	    moveToPoseAbove.realTimeParameterNodeID = UA_NODEID_NUMERIC( 5, 0 );
	    moveToPoseAbove.endPosition = poseAbove;
		moveToPoseAbove.realTimeParameter = false;
	    moveToPoseAbove.moveStraight = false;
		
		// Create the moveTo command and add the place pose
	    UA_MoveToParamsSetDataType moveToPose;
	    moveToPose.name = UA_STRING( "UA_MoveToParamsSetDataType" );
	    moveToPose.realTimeParameterNodeID = UA_NODEID_NUMERIC( 5, 0 );
	    moveToPose.endPosition = pose;
		moveToPose.realTimeParameter = false;
	    moveToPose.moveStraight = true;		
		
		// Create the SetEndeffector command for open and close
		UA_SetEndeffectorParamsSetDataType close;
		UA_SetEndeffectorParamsSetDataType open;
		
		close.name = UA_STRING("closeGripper");
		close.setting.fraction = 1; // TODO Check if 1 is realy closed!!!!

		open.name = UA_STRING("openGripper");
		open.setting.fraction = 0;


		UA_CRCLCommandsParamsSetsUnionDataType commandsPoseAbove;
	    commandsPoseAbove.switchField = UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_MOVETOPARAMSSET;
	    commandsPoseAbove.fields.moveToParamsSet = moveToPoseAbove;

		UA_CRCLCommandsParamsSetsUnionDataType commandsPose;
	    commandsPose.switchField = UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_MOVETOPARAMSSET;
	    commandsPose.fields.moveToParamsSet = moveToPose;

		UA_CRCLCommandsParamsSetsUnionDataType closeUnion;
	    closeUnion.switchField = UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_SETENDEFFECTORPARAMSSET;
	    closeUnion.fields.setEndeffectorParamsSet = close;

		UA_CRCLCommandsParamsSetsUnionDataType openUnion;
	    openUnion.switchField = UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_SETENDEFFECTORPARAMSSET;
	    openUnion.fields.setEndeffectorParamsSet = open;
		
		commands.emplace_back( commandsPoseAbove );
		commands.emplace_back( commandsPose );
		commands.emplace_back( openUnion );
		commands.emplace_back( commandsPoseAbove );


		setCommandsBuffer( commands ); /* Sets the buffer of commands to be executed by the robot to be the previously created vector 
		of commands "commands". It does not send them yet nor modifies the CommandsBuffer variable in the SAMYCore. 
		It sets the value in the internal class representing the robot 
		(this way commands can be accumulated without requesting yet the execution). */
		sendCommandsAndWait(); /*Writes the values currently stored for the robot in the CommandsBuffer node of the robot in the SAMYCore, 
		sets the node CommandStateBuffer to value PROCESSING_PENDING, and waits until the value of CommandStateBuffer is changed 
		(usually by the SAMYPlugin) either to PROCESSING_FAILED or to AWAITING. */
		}
}