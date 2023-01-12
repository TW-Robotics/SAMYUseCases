#pragma once 
#include <cstdint>
#include <dylib.h>
#include <skillsScriptingAPI.h>

extern "C" {

	void gripperAttach(UA_CRCL_PoseDataType const * const pose);
    
}