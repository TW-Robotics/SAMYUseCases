#ifndef SAMYPLUGIN_TEMPLATE
#define SAMYPLUGIN_TEMPLATE

#include <crcl_opcua_nodeids.h>
#include <namespace_crcl_opcua_generated.h>
#include "Robot.h"

bool executeMoveToCommand(const UA_MoveToDataType* const moveTo, Robot* robot);

bool executeSetRobotParametersCommand(const UA_SetRobotParametersDataType* parameter, Robot* robot);

bool executeSetTransSpeedCommand(const UA_SetTransSpeedDataType* const transSpeed, Robot* robot);

bool executeInitCanonCommand(const UA_InitCanonDataType* const initCanon, Robot* robot);

bool executeEndCanonCommand( const UA_EndCanonDataType* const endCanon, Robot* robot);

bool executeSetEndEffectorCommand(const UA_SetEndEffectorDataType* const setEndEffector, Robot* robot);


#endif /*SAMYPLUGIN_TEMPLATE*/
