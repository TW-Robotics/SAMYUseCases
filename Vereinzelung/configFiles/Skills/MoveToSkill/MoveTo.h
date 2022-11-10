#pragma once 

#include <cstdint>

#include <dylib.h>

#include <skillsScriptingAPI.h>

extern "C" {
        void moveToSkill( UA_CRCL_PoseDataType const * const goalPose);
} 