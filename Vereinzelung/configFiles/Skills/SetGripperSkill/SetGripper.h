#pragma once 

#include <cstdint>

#include <dylib.h>

#include <skillsScriptingAPI.h>

extern "C" {
        void setGripperFunction( UA_CRCL_FractionDataType const * const setting);
} 