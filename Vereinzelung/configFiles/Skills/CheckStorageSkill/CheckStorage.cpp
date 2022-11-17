#include <CheckStorage.h>
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
    void checkStorageSkill( UA_UInt32 const * const dummy){

        std::vector<UA_CRCLCommandsParamsSetsUnionDataType> commands;

	    UA_GetStatusParamsSetDataType getStatus;
	    getStatus.name = UA_STRING( "GetStatus" );
	    getStatus.realTimeParameter = false;
	    getStatus.realTimeParameterNodeID = UA_NODEID_NUMERIC( 5, 0 );

	    UA_CRCLCommandsParamsSetsUnionDataType commandsUnion1;
	    commandsUnion1.switchField = UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_GETSTATUSPARAMSSET;
	    commandsUnion1.fields.getStatusParamsSet = getStatus;
        commands.emplace_back( commandsUnion1 );
        
        setCommandsBuffer( commands ); /* Sets the buffer of commands to be executed by the robot to be the previously created vector 
        of commands "commands". It does not send them yet nor modifies the CommandsBuffer variable in the SAMYCore. 
        It sets the value in the internal class representing the robot 
        (this way commands can be accumulated without requesting yet the execution). */
        sendCommandsAndWait(); /*Writes the values currently stored for the robot in the CommandsBuffer node of the robot in the SAMYCore, 
        sets the node CommandStateBuffer to value PROCESSING_PENDING, and waits until the value of CommandStateBuffer is changed 
        (usually by the SAMYPlugin) either to PROCESSING_FAILED or to AWAITING. */
    }
}
