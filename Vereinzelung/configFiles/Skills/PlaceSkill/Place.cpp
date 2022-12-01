#include <Place.h>
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
    */
    void placeSkill( UA_CRCL_PoseDataType const * const placePose,
					 UA_CRCL_FractionDataType const * const offset){
        // Copy the parameter in local variable
		UA_CRCL_PoseDataType pose = *placePose;
		const UA_CRCL_FractionDataType offset_local = *offset;

		// Create commands vector
		 std::vector<UA_CRCLCommandsParamsSetsUnionDataType> commands;

		// Create CRCL command data type that the plugin will be able to proces
		// This has to be one of the CRCL commands (not Primitive Data Type)
		UA_MoveToParamsSetDataType moveToPlace;
		UA_MoveToParamsSetDataType moveToAbovePlace;
		UA_SetEndeffectorParamsSetDataType close;
		UA_SetEndeffectorParamsSetDataType open;

		// Write the parameters in the CRCL command data type
		moveToAbovePlace.name = UA_STRING("moveToAbovePlace");
		moveToAbovePlace.moveStraight = false;
		moveToAbovePlace.endPosition = pose;
		moveToAbovePlace.endPosition.point.z = pose.point.z + offset_local.fraction;
		moveToAbovePlace.realTimeParameter = false;
	    moveToAbovePlace.realTimeParameterNodeID = UA_NODEID_NUMERIC( 5, 0 );

		moveToPlace.name = UA_STRING("moveToPlace");
		moveToPlace.moveStraight = false;
		moveToPlace.endPosition = pose;
		moveToPlace.realTimeParameter = false;
	    moveToPlace.realTimeParameterNodeID = UA_NODEID_NUMERIC( 5, 0 );

		close.name = UA_STRING("closeGripper");
		close.setting.fraction = 1; // TODO Check if 1 is realy closed!!!!

		open.name = UA_STRING("openGripper");
		open.setting.fraction = 0;

		// Create Unions of the commands to write to the samyCore
		UA_CRCLCommandsParamsSetsUnionDataType moveToAbovePlaceUnion;
	    moveToAbovePlaceUnion.switchField = UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_MOVETOPARAMSSET;
	    moveToAbovePlaceUnion.fields.moveToParamsSet = moveToAbovePlace;

		UA_CRCLCommandsParamsSetsUnionDataType moveToPlaceUnion;
	    moveToPlaceUnion.switchField = UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_MOVETOPARAMSSET;
	    moveToPlaceUnion.fields.moveToParamsSet = moveToPlace;

		UA_CRCLCommandsParamsSetsUnionDataType closeUnion;
	    closeUnion.switchField = UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_SETENDEFFECTORPARAMSSET;
	    closeUnion.fields.setEndeffectorParamsSet = close;

		UA_CRCLCommandsParamsSetsUnionDataType openUnion;
	    openUnion.switchField = UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_SETENDEFFECTORPARAMSSET;
	    openUnion.fields.setEndeffectorParamsSet = open;

		// Add commadns to the commands vector
	    commands.push_back( moveToAbovePlaceUnion );
		commands.push_back( moveToPlaceUnion );
		commands.push_back( openUnion );
		commands.push_back( moveToAbovePlaceUnion );


		setCommandsBuffer( commands ); /* Sets the buffer of commands to be executed by the robot to be the previously created vector 
		of commands "commands". It does not send them yet nor modifies the CommandsBuffer variable in the SAMYCore. 
		It sets the value in the internal class representing the robot 
		(this way commands can be accumulated without requesting yet the execution). */
        sendCommandsAndWait(); /*Writes the values currently stored for the robot in the CommandsBuffer node of the robot in the SAMYCore, 
		sets the node CommandStateBuffer to value PROCESSING_PENDING, and waits until the value of CommandStateBuffer is changed 
		(usually by the SAMYPlugin) either to PROCESSING_FAILED or to AWAITING. */
    }
}
