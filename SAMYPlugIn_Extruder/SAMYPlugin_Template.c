#include <SAMYPlugin_Template.h>
#include "Robot.h"

bool executeMoveToCommand(const UA_MoveToDataType* const moveTo, Robot* robot){
    return robot->moveExtruder(moveTo->endPosition.point.x);
}

bool executeSetRobotParametersCommand(const UA_SetRobotParametersDataType* parameter, Robot* robot){
    char* convert = (char*)UA_malloc(sizeof(char)
                                     *parameter->parameterSetting[0].parameterValue.length+1);
    memcpy(convert, parameter->parameterSetting[0].parameterValue.data,
            parameter->parameterSetting[0].parameterValue.length );
    convert[parameter->parameterSetting[0].parameterValue.length] = '\0';
    int temp = atoi(convert);
    free(convert);
    convert = (char*)UA_malloc(sizeof(char)
                                     *parameter->parameterSetting[1].parameterValue.length+1);
    memcpy(convert, parameter->parameterSetting[1].parameterValue.data,
            parameter->parameterSetting[1].parameterValue.length );
    convert[parameter->parameterSetting[1].parameterValue.length] = '\0';
    int cool = atoi(convert);
    if (robot->getCooling() != cool || robot->getTemperature() != temp){
        robot->setTemperature(temp);
        robot->setCooling(cool);
        robot->sendString();
        return robot->waitForExtruder();
    }
    return true;
}

bool executeSetTransSpeedCommand(const UA_SetTransSpeedDataType* const transSpeed, Robot* robot){
    //return extruder->setSpeed(transSpeed->transSpeed); // Is a UA_Extansion Object, need a double
    return true;
}

bool executeInitCanonCommand(const UA_InitCanonDataType* const initCanon, Robot* robot){
    return true;
}

bool executeEndCanonCommand(const UA_EndCanonDataType* const endCanon, Robot* robot){
    return true;
}

bool executeSetEndEffectorCommand(const UA_SetEndEffectorDataType* const setEndEffector, Robot* robot){
    return true;
}
