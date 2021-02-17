#include <open62541/plugin/log_stdout.h>
#include <open62541/server.h>
#include <open62541/server_config_default.h>
/* Files namespace_foo_flt_generated.h and namespace_foo_flt_generated.c are created from FooFlt.NodeSet2.xml in the
 * /src_generated directory by CMake */

#include "SAMYRobot.h"
#include "Robot.h"
#include "SAMYPlugin_Template.h"

#include <signal.h>

const size_t array_size = 5;

UA_Boolean running = true;
static void stopHandler(int sign) {
    UA_LOG_INFO(UA_Log_Stdout, UA_LOGCATEGORY_SERVER, "received ctrl-c");
    running = false;
}

static void addFiveCRCLCommands( UA_Server* server ) {

    UA_InitCanonDataType initCanon;
    initCanon.id = 88776655;
    initCanon.name = UA_STRING("InitCanonCommand");
    initCanon.commandID = 1;
    initCanon.guardSize = 0;
    initCanon.guard = NULL;

    UA_VariableAttributes vattr0 = UA_VariableAttributes_default;
    vattr0.description = UA_LOCALIZEDTEXT("en-US", "InitCanonCommand added from code");
    vattr0.displayName = UA_LOCALIZEDTEXT("en-US", "InitCanonCommand");
    vattr0.dataType = UA_TYPES_CRCL_OPCUA[UA_TYPES_CRCL_OPCUA_INITCANONDATATYPE].typeId;
    vattr0.valueRank = UA_VALUERANK_SCALAR;
    UA_UInt32 myArrayDimensions[1] = {1};
    vattr0.value.arrayDimensions = myArrayDimensions;
    vattr0.value.arrayDimensionsSize = 1;

    UA_Variant_setScalar(&vattr0.value, &initCanon, &UA_TYPES_CRCL_OPCUA[UA_TYPES_CRCL_OPCUA_INITCANONDATATYPE]);

    UA_StatusCode ret0 = UA_Server_addVariableNode(server, UA_NODEID_NUMERIC(2, 111111),
                              UA_NODEID_NUMERIC(0, UA_NS0ID_OBJECTSFOLDER),
                              UA_NODEID_NUMERIC(0, UA_NS0ID_ORGANIZES),
                              UA_QUALIFIEDNAME(2, "InitCanonCommandFromCode"),
                              UA_NODEID_NUMERIC(0, UA_NS0ID_BASEDATAVARIABLETYPE), vattr0, NULL, NULL);

    if(ret0 == UA_STATUSCODE_GOOD){
        printf("\n InitCanon added succesfully \n");
    }
    else{
                printf("\n InitCanon added FAILED \n");
    }

    UA_CRCL_VectorDataType vectX;
    vectX.name =  UA_STRING("PoseVectorX");
    vectX.id = 9009;
    vectX.i = 1;
    vectX.j = 0;
    vectX.k = 0;

    UA_CRCL_VectorDataType vectZ;
    vectZ.name =  UA_STRING("PoseVectorZ");
    vectZ.id = 2468;
    vectX.i = 0;
    vectX.j = 0;
    vectX.k = 1;

   UA_CRCL_PointDataType point;
    point.name =  UA_STRING("Point");
    point.id = 19191;
    point.x = 4.5;
    point.y = 0;
    point.z = 0;

    UA_CRCL_PoseDataType pose;
    pose.name =  UA_STRING("PosePose");
    pose.xAxis = vectX;
    pose.zAxis = vectZ;
    pose.point = point;
    pose.id = 987654;
    pose.name =  UA_STRING("PoseName");

    UA_MoveToDataType moveTo1;
    moveTo1.id = 11223344;
    moveTo1.name = UA_STRING("moveTo1Command");
    moveTo1.commandID = 10101010;
    moveTo1.guardSize = 0;
    moveTo1.guard = NULL;
    moveTo1.moveStraight = true;
    moveTo1.endPosition = pose;

    UA_VariableAttributes vattr = UA_VariableAttributes_default;
    vattr.description = UA_LOCALIZEDTEXT("en-US", "MoveToCommand added from code");
    vattr.displayName = UA_LOCALIZEDTEXT("en-US", "MoveToCommand");
    vattr.dataType = UA_TYPES_CRCL_OPCUA[UA_TYPES_CRCL_OPCUA_MOVETODATATYPE].typeId;
    vattr.valueRank = UA_VALUERANK_SCALAR;
    vattr.value.arrayDimensions = myArrayDimensions;
    vattr.value.arrayDimensionsSize = 1;

    UA_Variant_setScalar(&vattr.value, &moveTo1, &UA_TYPES_CRCL_OPCUA[UA_TYPES_CRCL_OPCUA_MOVETODATATYPE]);

    UA_StatusCode ret = UA_Server_addVariableNode(server, UA_NODEID_NUMERIC(2, 222222),
                              UA_NODEID_NUMERIC(0, UA_NS0ID_OBJECTSFOLDER),
                              UA_NODEID_NUMERIC(0, UA_NS0ID_ORGANIZES),
                              UA_QUALIFIEDNAME(2, "MoveTo1CommandFromCode"),
                              UA_NODEID_NUMERIC(0, UA_NS0ID_BASEDATAVARIABLETYPE), vattr, NULL, NULL);

    if(ret == UA_STATUSCODE_GOOD){
        printf("\n MoveToCommand1 added succesfully \n");
    }
    else{
                printf("\n MoveToCommand1 added FAILEED \n");
    }


    //Adding second moveTo Command
        UA_StatusCode ret1 = UA_Server_addVariableNode(server, UA_NODEID_NUMERIC(2, 333333),
                              UA_NODEID_NUMERIC(0, UA_NS0ID_OBJECTSFOLDER),
                              UA_NODEID_NUMERIC(0, UA_NS0ID_ORGANIZES),
                              UA_QUALIFIEDNAME(2, "MoveTo2CommandFromCode"),
                              UA_NODEID_NUMERIC(0, UA_NS0ID_BASEDATAVARIABLETYPE), vattr, NULL, NULL);

    if(ret1 == UA_STATUSCODE_GOOD){
        printf("\n MoveToCommand1 added succesfully \n");
    }
    else{
                printf("\n MoveToCommand1 added FAILEED \n");
    }


        //Adding third moveTo Command
        UA_StatusCode ret2 = UA_Server_addVariableNode(server, UA_NODEID_NUMERIC(2, 444444),
                              UA_NODEID_NUMERIC(0, UA_NS0ID_OBJECTSFOLDER),
                              UA_NODEID_NUMERIC(0, UA_NS0ID_ORGANIZES),
                              UA_QUALIFIEDNAME(2, "MoveTo3CommandFromCode"),
                              UA_NODEID_NUMERIC(0, UA_NS0ID_BASEDATAVARIABLETYPE), vattr, NULL, NULL);

    if(ret2 == UA_STATUSCODE_GOOD){
        printf("\n MoveToCommand1 added succesfully \n");
    }
    else{
                printf("\n MoveToCommand1 added FAILEED \n");
    }


    //Adding endCanon command
        UA_InitCanonDataType endCanon;
    initCanon.id = 444555;
    initCanon.name = UA_STRING("EndCanonCommand");
    initCanon.commandID = 919191;
    initCanon.guardSize = 0;
    initCanon.guard = NULL;

    UA_VariableAttributes vattr2 = UA_VariableAttributes_default;
    vattr2.description = UA_LOCALIZEDTEXT("en-US", "EndCanonCommand added from code");
    vattr2.displayName = UA_LOCALIZEDTEXT("en-US", "EndCanonCommand");
    vattr2.dataType = UA_TYPES_CRCL_OPCUA[UA_TYPES_CRCL_OPCUA_ENDCANONDATATYPE].typeId;
    vattr2.valueRank = UA_VALUERANK_SCALAR;
    vattr2.value.arrayDimensions = myArrayDimensions;
    vattr2.value.arrayDimensionsSize = 1;

    UA_Variant_setScalar(&vattr2.value, &initCanon, &UA_TYPES_CRCL_OPCUA[UA_TYPES_CRCL_OPCUA_ENDCANONDATATYPE]);

    UA_StatusCode ret3 = UA_Server_addVariableNode(server, UA_NODEID_NUMERIC(2, 555555),
                              UA_NODEID_NUMERIC(0, UA_NS0ID_OBJECTSFOLDER),
                              UA_NODEID_NUMERIC(0, UA_NS0ID_ORGANIZES),
                              UA_QUALIFIEDNAME(2, "EndCanonCommandFromCode"),
                              UA_NODEID_NUMERIC(0, UA_NS0ID_BASEDATAVARIABLETYPE), vattr2, NULL, NULL);

    if(ret3 == UA_STATUSCODE_GOOD){
        printf("\n EndCanonCommand added succesfully \n");
    }
    else{
                printf("\n EndCanonCommand added FAILED \n");
    }

}

static void addCRCLSkill( UA_Server* server ){

            printf("\n addCRCLSkill      1       \n");

    UA_NodeId nodeID[5];
    nodeID[0] = UA_NODEID_NUMERIC(2, 111111);
    nodeID[1] = UA_NODEID_NUMERIC(2, 222222);
    nodeID[2] = UA_NODEID_NUMERIC(2, 333333);
    nodeID[3] = UA_NODEID_NUMERIC(2, 444444);
    nodeID[4] = UA_NODEID_NUMERIC(2, 555555);


    // Here is the string array.Size defined as a global here!

    UA_CRCLCommandsUnionDataType *commands = (UA_CRCLCommandsUnionDataType *) UA_Array_new(array_size, &UA_TYPES_CRCL_OPCUA[UA_TYPES_CRCL_OPCUA_CRCLCOMMANDSUNIONDATATYPE]);
    UA_CRCLSkillDataType skill;

    printf("\n addCRCLSkill      2       \n");

    UA_Variant variantRead;
    UA_Variant_init(&variantRead);

    UA_StatusCode statusRead = UA_STATUSCODE_GOOD;
    UA_NodeId commandType;

    for (int i=0; i<5; i++){
        statusRead = UA_Server_readDataType(server, nodeID[i], &commandType);
        statusRead = UA_Server_readValue(server, nodeID[i], &variantRead);

        if(commandType.identifierType == UA_NODEIDTYPE_NUMERIC &&
                    commandType.identifier.numeric == UA_TYPES_CRCL_OPCUA[UA_TYPES_CRCL_OPCUA_INITCANONDATATYPE].typeId.identifier.numeric  ){
         printf("\n   Loop InitCommand  \n");
             commands[i].switchField = UA_CRCLCOMMANDSUNIONDATATYPESWITCH_INITCANONCOMMAND;
             statusRead = UA_Server_readValue(server, nodeID[i], &variantRead);
             commands[i].fields.initCanonCommand = *((UA_InitCanonDataType*)variantRead.data);
             UA_Variant_clear(&variantRead);
        }else if(commandType.identifierType == UA_NODEIDTYPE_NUMERIC &&
                    commandType.identifier.numeric == UA_TYPES_CRCL_OPCUA[UA_TYPES_CRCL_OPCUA_MOVETODATATYPE].typeId.identifier.numeric  ){
         printf("\n   Loop MoveTo  \n");
             commands[i].switchField = UA_CRCLCOMMANDSUNIONDATATYPESWITCH_MOVETOCOMMAND;
             statusRead = UA_Server_readValue(server, nodeID[i], &variantRead);
             commands[i].fields.moveToCommand = *((UA_MoveToDataType*)variantRead.data);
             UA_Variant_clear(&variantRead);
        }else if(commandType.identifierType == UA_NODEIDTYPE_NUMERIC &&
                        commandType.identifier.numeric ==  UA_TYPES_CRCL_OPCUA[UA_TYPES_CRCL_OPCUA_CLOSETOOLCHANGERDATATYPE].typeId.identifier.numeric ){
         printf("\n   Loop CloseTool  \n");
             commands[i].switchField = UA_CRCLCOMMANDSUNIONDATATYPESWITCH_CLOSETOOLCHANGERCOMMAND;
             statusRead = UA_Server_readValue(server, nodeID[i], &variantRead);
             commands[i].fields.closeToolChangerCommand = *((UA_CloseToolChangerDataType*)variantRead.data);
             UA_Variant_clear(&variantRead);
        }else if(commandType.identifierType == UA_NODEIDTYPE_NUMERIC &&
                        commandType.identifier.numeric ==  UA_TYPES_CRCL_OPCUA[UA_TYPES_CRCL_OPCUA_DWELLDATATYPE].typeId.identifier.numeric ){
         printf("\n   Loop DwellCommand  \n");
             commands[i].switchField = UA_CRCLCOMMANDSUNIONDATATYPESWITCH_DWELLCOMMAND;
             statusRead = UA_Server_readValue(server, nodeID[i], &variantRead);
             commands[i].fields.dwellCommand = *((UA_DwellDataType*)variantRead.data);
             UA_Variant_clear(&variantRead);
        }else if(commandType.identifierType == UA_NODEIDTYPE_NUMERIC &&
                        commandType.identifier.numeric == UA_TYPES_CRCL_OPCUA[UA_TYPES_CRCL_OPCUA_GETSTATUSDATATYPE].typeId.identifier.numeric  ){
         printf("\n   Loop GetStatus  \n");
             commands[i].switchField = UA_CRCLCOMMANDSUNIONDATATYPESWITCH_GETSTATUSCOMMAND;
             statusRead = UA_Server_readValue(server, nodeID[i], &variantRead);
             commands[i].fields.getStatusCommand = *((UA_GetStatusDataType*)variantRead.data);
             UA_Variant_clear(&variantRead);
        }else if(commandType.identifierType == UA_NODEIDTYPE_NUMERIC &&
                        commandType.identifier.numeric ==  UA_TYPES_CRCL_OPCUA[UA_TYPES_CRCL_OPCUA_MESSAGEDATATYPE].typeId.identifier.numeric ){
         printf("\n   Loop MessageCommand  \n");
             commands[i].switchField = UA_CRCLCOMMANDSUNIONDATATYPESWITCH_MESSAGECOMMAND;
             statusRead = UA_Server_readValue(server, nodeID[i], &variantRead);
             commands[i].fields.messageCommand = *((UA_MessageDataType*)variantRead.data);
             UA_Variant_clear(&variantRead);
        }else if(commandType.identifierType == UA_NODEIDTYPE_NUMERIC &&
                        commandType.identifier.numeric == UA_TYPES_CRCL_OPCUA[UA_TYPES_CRCL_OPCUA_ENDCANONDATATYPE].typeId.identifier.numeric  ){
         printf("\n   Loop EndCanon  \n");
             commands[i].switchField = UA_CRCLCOMMANDSUNIONDATATYPESWITCH_ENDCANONCOMMAND;
             statusRead = UA_Server_readValue(server, nodeID[i], &variantRead);
             commands[i].fields.endCanonCommand = *((UA_EndCanonDataType*)variantRead.data);
             UA_Variant_clear(&variantRead);
        }

        if (statusRead == UA_STATUSCODE_GOOD){
            printf("\n addCRCLSkill READ FUNCIONOOOOOOOOOOOOOOOOO\n");
        }else{
            printf("\n addCRCLSkill READ NO CHUFLA\n");
        }
    }

    UA_VariableAttributes vattr = UA_VariableAttributes_default;
    skill.cRCLCommandsSize = array_size;
    skill.cRCLCommands = commands;
    skill.id = 777999777;
    skill.name = UA_STRING("skill name!");

    UA_Variant_setScalar(&vattr.value, &skill, &UA_TYPES_CRCL_OPCUA[UA_TYPES_CRCL_OPCUA_CRCLSKILLDATATYPE]);
    vattr.valueRank = UA_VALUERANK_ANY;
    UA_UInt32 myArrayDimensions[1] = {1};
    vattr.value.arrayDimensions = myArrayDimensions;
    vattr.value.arrayDimensionsSize = 1;
    vattr.displayName = UA_LOCALIZEDTEXT("locale","SKILL");
    vattr.dataType = UA_TYPES_CRCL_OPCUA[UA_TYPES_CRCL_OPCUA_CRCLSKILLDATATYPE].typeId;

    UA_StatusCode retval = UA_Server_addVariableNode(server,
                                       UA_NODEID_STRING(1, "SKILL"), // new node id
                                       UA_NODEID_NUMERIC(0, UA_NS0ID_OBJECTSFOLDER), // parent node
                                       UA_NODEID_NUMERIC(0, UA_NS0ID_ORGANIZES), // reference type
                                       UA_QUALIFIEDNAME(1, "SKILL"), // node browse name
                                       UA_NODEID_NUMERIC(0, UA_NS0ID_BASEDATAVARIABLETYPE),
                                       vattr, NULL, NULL);

    if( retval ==UA_STATUSCODE_GOOD){
    printf("\n Succesful addCRCLSkill added \n");
    }else{
    printf("\n addCRCLSkill addition FAILED! \n");
    }

}

static void addSAMYRobotNode( UA_Server* server ){

    UA_SAMYRobotDataType robot;
    robot.id = 989898;
    robot.name = UA_STRING("robotName 1");

    UA_PubSubIPAddresses pubSubAddresses;
    pubSubAddresses.iPAddress_Skill = UA_STRING("opc.udp://224.0.0.22:4840");
    pubSubAddresses.iPAddress_Status = UA_STRING("opc.udp://224.0.0.22:4840");
    robot.iPAddresses = pubSubAddresses;
    robot.online = UA_FALSE;
    robot.requested_Skill_Success = UA_FALSE;
    UA_Variant value;
    UA_Variant_init( &value );
    if(UA_Server_readValue( server, UA_NODEID_STRING(1, "SKILL"), &value )==UA_STATUSCODE_GOOD){
    printf("\n readCRCLSkill in addSAMYRobot succesful\n");
    }else{
    printf("\n readCRCLSkill in addSAMYRobot FAILED! \n");
    }
    UA_CRCLSkillDataType* skill;
    skill = (UA_CRCLSkillDataType*)value.data;
    robot.requested_Skill = *skill;

    printf("\n addSAMYRobot  2 \n");

    UA_VariableAttributes vattr = UA_VariableAttributes_default;

    printf("\n addSAMYRobot  3 \n");

    vattr.description = UA_LOCALIZEDTEXT("locale","SAMYRobot");
    vattr.valueRank = UA_VALUERANK_ANY;
    vattr.displayName = UA_LOCALIZEDTEXT("locale","SAMYRobot");
    vattr.dataType = UA_TYPES_CRCL_OPCUA[UA_TYPES_CRCL_OPCUA_SAMYROBOTDATATYPE].typeId;
    UA_UInt32 myArrayDimensions[1] = {1};
    vattr.value.arrayDimensions = myArrayDimensions;
    vattr.value.arrayDimensionsSize = 1;
    UA_Variant_setScalar(&vattr.value, &robot, &UA_TYPES_CRCL_OPCUA[UA_TYPES_CRCL_OPCUA_SAMYROBOTDATATYPE]);

    printf("\n addSAMYRobot  4 \n");

    UA_StatusCode retval = UA_Server_addVariableNode(server,
                                       UA_NODEID_STRING(1, "SAMYRobot"), // new node id
                                       UA_NODEID_NUMERIC(0, UA_NS0ID_OBJECTSFOLDER), // parent node
                                       UA_NODEID_NUMERIC(0, UA_NS0ID_ORGANIZES), // reference type
                                       UA_QUALIFIEDNAME(1, "SAMYRobot"), // node browse name
                                       UA_NODEID_NUMERIC(0, UA_NS0ID_BASEDATAVARIABLETYPE),
                                       vattr, NULL, NULL);

    if( retval ==UA_STATUSCODE_GOOD){
    printf("\n addSAMYRobot succesful\n");
    }else{
    printf("\n addSAMYRobot FAILED! \n");
    }
}

static void readSAMYRobotNode( UA_Server* server, Robot* extruder ){

    UA_Variant value;
    UA_Variant_init( &value );
    if(UA_Server_readValue( server, UA_NODEID_STRING(1, "SAMYRobot"), &value )==UA_STATUSCODE_GOOD){
    printf("\n readSAMYRobot succesful\n");
    }else{
    printf("\n readSAMYRobot FAILED! \n");
    }

    UA_SAMYRobotDataType robot;
    robot = (*(UA_SAMYRobotDataType*)value.data);

    for (int i=0; i<sizeof(robot.requested_Skill.cRCLCommands); i++){
        UA_CRCLCommandsUnionDataType* val = &(robot.requested_Skill.cRCLCommands[i]);
        printf("\n readSAMYRobot, COMMAND NUMBER %i \n", i);

        if(val->switchField == 0){
        printf("\n switchValue empty \n");
        }else if(val->switchField == UA_CRCLCOMMANDSUNIONDATATYPESWITCH_INITCANONCOMMAND){
            printf("\n readSAMYRobot, UA_CRCLCOMMANDSUNIONDATATYPESWITCH_INITCANONCOMMAND");
            UA_InitCanonDataType* canon = (UA_InitCanonDataType*)&(val->fields);
            printf("\n %i \n", canon->commandID);

        }else if( val->switchField == UA_CRCLCOMMANDSUNIONDATATYPESWITCH_MOVETOCOMMAND){
            UA_MoveToDataType* moveTo = (UA_MoveToDataType*)&(val->fields);
            executeMoveToCommand(moveTo, extruder);

        }else if(val->switchField == UA_CRCLCOMMANDSUNIONDATATYPESWITCH_DWELLCOMMAND){
        printf("\n a \n");
        }else if(val->switchField == UA_CRCLCOMMANDSUNIONDATATYPESWITCH_GETSTATUSCOMMAND){
        printf("\n a \n");
        }else if(val->switchField == UA_CRCLCOMMANDSUNIONDATATYPESWITCH_MESSAGECOMMAND){
        printf("\n a \n");
        }else if(val->switchField == UA_CRCLCOMMANDSUNIONDATATYPESWITCH_ENDCANONCOMMAND){
            printf("\n readSAMYRobot, UA_CRCLCOMMANDSUNIONDATATYPESWITCH_ENDCANONCOMMAND");
            UA_EndCanonDataType* canon = (UA_EndCanonDataType*)&(val->fields);
            printf("\n %i \n", canon->id);
            printf("\n %i \n", canon->commandID);
            printf("\n \n \n \n \n \n \n");
        }
    }
}


int main(int argc, char** argv) {
    UA_LOG_INFO(UA_Log_Stdout, UA_LOGCATEGORY_SERVER, "-1!");

    signal(SIGINT, stopHandler);
    signal(SIGTERM, stopHandler);
    UA_LOG_INFO(UA_Log_Stdout, UA_LOGCATEGORY_SERVER, "0!");

    UA_Server *server = UA_Server_new();
    UA_LOG_INFO(UA_Log_Stdout, UA_LOGCATEGORY_SERVER, "1!");

    UA_ServerConfig *config = UA_Server_getConfig(server);
    UA_ServerConfig_setDefault(config);
    UA_LOG_INFO(UA_Log_Stdout, UA_LOGCATEGORY_SERVER, "2!");

    /* Details about the connection configuration and handling are located in
     * the pubsub connection tutorial */
    config->pubsubTransportLayers =
        (UA_PubSubTransportLayer *) UA_calloc(2, sizeof(UA_PubSubTransportLayer));
    if(!config->pubsubTransportLayers) {
        UA_Server_delete(server);
        return EXIT_FAILURE;
    }
    config->pubsubTransportLayers[0] = UA_PubSubTransportLayerUDPMP();
    config->pubsubTransportLayersSize++;
#ifdef UA_ENABLE_PUBSUB_ETH_UADP
    config->pubsubTransportLayers[1] = UA_PubSubTransportLayerEthernet();
    config->pubsubTransportLayersSize++;
#endif

    UA_StatusCode retval = UA_STATUSCODE_GOOD;
    UA_LOG_INFO(UA_Log_Stdout, UA_LOGCATEGORY_SERVER, "3!");

    // create the robot object (extruder in this case)
    Robot robot;

    /* create nodes from nodeset */
    printf("namespace");
    if(namespace_crcl_opcua_generated(server) != UA_STATUSCODE_GOOD) {
        UA_LOG_ERROR(UA_Log_Stdout, UA_LOGCATEGORY_SERVER, "Could not add the crcl opcua nodeset. "
        "Check previous output for any error.");
        retval = UA_STATUSCODE_BADUNEXPECTEDERROR;
    } else {/*If custom namespace succesfully added*/

        UA_NodeId nodeToPublish = UA_NODEID_STRING(1, "SAMYRobot");
        addFiveCRCLCommands(server);
        addCRCLSkill(server);
        addSAMYRobotNode(server);


        //UA_Server_addRepeatedCallback( server, readSAMYRobotNode, NULL, 10000, NULL );
        SAMYRobot samyRobot;
        samyRobot.id = 4567; /* IT MUST BE A UNINT16 number, otherwise it changes the number when compiling due to overflow!!! Compile with pedantic?*/
        samyRobot.name = UA_STRING("FirstRobot");
        samyRobot.ipAddresses.iPAddress_Skill = UA_STRING("opc.udp://224.0.0.22:4840");
        samyRobot.ipAddresses.iPAddress_Status = UA_STRING("opc.udp://224.0.0.22:4840");
        samyRobot.SAMYRobotVariableNodeId = nodeToPublish;
        configureSAMYRobotPublisherUADP(&samyRobot, 100, 10);
        addSAMYRobotPublisherToServer(server, &samyRobot);

        readSAMYRobotNode(server, &robot);

        retval = UA_Server_run(server, &running);
    }

    UA_Server_delete(server);
    return retval == UA_STATUSCODE_GOOD ? EXIT_SUCCESS : EXIT_FAILURE;
}


