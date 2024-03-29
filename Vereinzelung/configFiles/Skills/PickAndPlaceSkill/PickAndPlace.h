#pragma once 
#include <cstdint>
#include <dylib.h>
#include <skillsScriptingAPI.h>

extern "C" {

	void pickAndPlaceSkill(UA_CRCL_PoseDataType const * const pickPose,
	        UA_CRCL_PoseDataType const * const placePose,
			UA_CRCL_PoseDataType const * const midPose,
	        UA_CRCL_FractionDataType const * const offset);
    
}