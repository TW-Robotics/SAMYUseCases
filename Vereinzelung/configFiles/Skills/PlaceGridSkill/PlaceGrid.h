#pragma once 
#include <cstdint>
#include <dylib.h>
#include <skillsScriptingAPI.h>

extern "C" {

	void placeGridSkill(UA_CRCL_PoseDataType const * const startPose,
	        UA_CRCL_FractionDataType const * const offsetX,
	        UA_CRCL_FractionDataType const * const offsetY,
	        UA_CRCL_FractionDataType const * const counterX,
	        UA_CRCL_FractionDataType const * const counterY);
    
}