#pragma once 

#include <cstdint>

#include <dylib.h>

#include <skillsScriptingAPI.h>

extern "C" {
        void placeFunction( UA_CRCL_PoseDataType const * const placePose, UA_CRCL_FractionDataType const * const offset );
} 
