#pragma once 
#include <cstdint>
#include <dylib.h>
#include <skillsScriptingAPI.h>

extern "C" {

	void moveToSkill(UA_CRCL_PoseDataType const * const goalPose,
	        UA_CRCL_ParameterSettingDataType const * const moveType);
    
}