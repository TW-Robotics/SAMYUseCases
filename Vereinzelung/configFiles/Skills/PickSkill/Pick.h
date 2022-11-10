#pragma once 

#include <cstdint>

#include <dylib.h>

#include <skillsScriptingAPI.h>

extern "C" {
        void pickFunction( UA_CRCL_PoseDataType const * const pickPose,
                           UA_CRCL_FractionDataType const * const offset );
}
