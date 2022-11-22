#pragma once 
#include <cstdint>
#include <dylib.h>
#include <skillsScriptingAPI.h>

extern "C" {

	void pickSkill(UA_CRCL_PoseDataType const * const pickPose,
	        UA_CRCL_FractionDataType const * const offset);
    
}