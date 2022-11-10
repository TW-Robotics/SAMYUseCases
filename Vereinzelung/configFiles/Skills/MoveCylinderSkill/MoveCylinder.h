#pragma once 

#include <cstdint>

#include <dylib.h>

#include <skillsScriptingAPI.h>

extern "C" {
        void moveCylinderFunction(UA_CRCL_ActuateJointDataType const * const joint);
} 