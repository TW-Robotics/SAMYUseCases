#pragma once 
#include <cstdint>
#include <dylib.h>
#include <skillsScriptingAPI.h>

extern "C" {

	void moveCylinderSkill(UA_CRCL_ActuateJointDataType const * const joint);
    
}