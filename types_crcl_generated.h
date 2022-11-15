/* Generated from CRCL.Types.bsd with script /usr/local/share/open62541/tools/generate_datatypes.py * on host pop-os by user arbeit at 2022-11-03 09:51:19 */

#ifndef TYPES_CRCL_GENERATED_H_
#define TYPES_CRCL_GENERATED_H_

#ifdef UA_ENABLE_AMALGAMATION
#include "open62541.h"
#else
#include <open62541/types.h>
#include <open62541/types_generated.h>

#endif

_UA_BEGIN_DECLS


/**
 * Every type is assigned an index in an array containing the type descriptions.
 * These descriptions are used during type handling (copying, deletion,
 * binary encoding, ...). */
#define UA_TYPES_CRCL_COUNT 133
extern UA_EXPORT const UA_DataType UA_TYPES_CRCL[UA_TYPES_CRCL_COUNT];

/**
 * CRCL_StopConditionEnumDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 */
typedef enum {
    UA_CRCL_STOPCONDITIONENUMDATATYPE_IMMEDIATE = 0,
    UA_CRCL_STOPCONDITIONENUMDATATYPE_FAST = 1,
    UA_CRCL_STOPCONDITIONENUMDATATYPE_NORMAL = 2,
    __UA_CRCL_STOPCONDITIONENUMDATATYPE_FORCE32BIT = 0x7fffffff
} UA_CRCL_StopConditionEnumDataType;
UA_STATIC_ASSERT(sizeof(UA_CRCL_StopConditionEnumDataType) == sizeof(UA_Int32), enum_must_be_32bit);

#define UA_TYPES_CRCL_CRCL_STOPCONDITIONENUMDATATYPE 0

/**
 * CRCL_AngleUnitEnumDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^
 */
typedef enum {
    UA_CRCL_ANGLEUNITENUMDATATYPE_DEGREE = 0,
    UA_CRCL_ANGLEUNITENUMDATATYPE_RADIAN = 1,
    __UA_CRCL_ANGLEUNITENUMDATATYPE_FORCE32BIT = 0x7fffffff
} UA_CRCL_AngleUnitEnumDataType;
UA_STATIC_ASSERT(sizeof(UA_CRCL_AngleUnitEnumDataType) == sizeof(UA_Int32), enum_must_be_32bit);

#define UA_TYPES_CRCL_CRCL_ANGLEUNITENUMDATATYPE 1

/**
 * CRCL_ForceUnitEnumDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^
 */
typedef enum {
    UA_CRCL_FORCEUNITENUMDATATYPE_NEWTON = 0,
    UA_CRCL_FORCEUNITENUMDATATYPE_POUND = 1,
    UA_CRCL_FORCEUNITENUMDATATYPE_OUNCE = 2,
    __UA_CRCL_FORCEUNITENUMDATATYPE_FORCE32BIT = 0x7fffffff
} UA_CRCL_ForceUnitEnumDataType;
UA_STATIC_ASSERT(sizeof(UA_CRCL_ForceUnitEnumDataType) == sizeof(UA_Int32), enum_must_be_32bit);

#define UA_TYPES_CRCL_CRCL_FORCEUNITENUMDATATYPE 2

/**
 * CRCL_FractionDataType
 * ^^^^^^^^^^^^^^^^^^^^^
 * Fraction structure */
typedef struct {
    UA_Double fraction;
    UA_Double fractionMax;
    UA_Double fractionMin;
} UA_CRCL_FractionDataType;

#define UA_TYPES_CRCL_CRCL_FRACTIONDATATYPE 3

/**
 * CRCL_LengthUnitEnumDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^
 */
typedef enum {
    UA_CRCL_LENGTHUNITENUMDATATYPE_METER = 0,
    UA_CRCL_LENGTHUNITENUMDATATYPE_MILLIMETER = 1,
    UA_CRCL_LENGTHUNITENUMDATATYPE_INCH = 2,
    __UA_CRCL_LENGTHUNITENUMDATATYPE_FORCE32BIT = 0x7fffffff
} UA_CRCL_LengthUnitEnumDataType;
UA_STATIC_ASSERT(sizeof(UA_CRCL_LengthUnitEnumDataType) == sizeof(UA_Int32), enum_must_be_32bit);

#define UA_TYPES_CRCL_CRCL_LENGTHUNITENUMDATATYPE 4

/**
 * CRCL_DataThingDataType
 * ^^^^^^^^^^^^^^^^^^^^^^
 * Fraction structure */
typedef struct {
    UA_UInt32 id;
    UA_String name;
} UA_CRCL_DataThingDataType;

#define UA_TYPES_CRCL_CRCL_DATATHINGDATATYPE 5

/**
 * CRCL_PointDataType
 * ^^^^^^^^^^^^^^^^^^
 * CRCL 3D Point DataType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_Double x;
    UA_Double y;
    UA_Double z;
} UA_CRCL_PointDataType;

#define UA_TYPES_CRCL_CRCL_POINTDATATYPE 6

/**
 * CRCL_VectorDataType
 * ^^^^^^^^^^^^^^^^^^^
 * CRCL 3D Vector DataType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_Double i;
    UA_Double j;
    UA_Double k;
} UA_CRCL_VectorDataType;

#define UA_TYPES_CRCL_CRCL_VECTORDATATYPE 7

/**
 * CRCL_PoseDataType
 * ^^^^^^^^^^^^^^^^^
 * CRCL 3D Pose DataType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_CRCL_PointDataType point;
    UA_CRCL_VectorDataType xAxis;
    UA_CRCL_VectorDataType zAxis;
} UA_CRCL_PoseDataType;

#define UA_TYPES_CRCL_CRCL_POSEDATATYPE 8

/**
 * CRCL_TorqueUnitEnumDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^
 */
typedef enum {
    UA_CRCL_TORQUEUNITENUMDATATYPE_NEWTONMETER = 0,
    UA_CRCL_TORQUEUNITENUMDATATYPE_FOOTPOUND = 1,
    __UA_CRCL_TORQUEUNITENUMDATATYPE_FORCE32BIT = 0x7fffffff
} UA_CRCL_TorqueUnitEnumDataType;
UA_STATIC_ASSERT(sizeof(UA_CRCL_TorqueUnitEnumDataType) == sizeof(UA_Int32), enum_must_be_32bit);

#define UA_TYPES_CRCL_CRCL_TORQUEUNITENUMDATATYPE 9

/**
 * CRCL_TwistDataType
 * ^^^^^^^^^^^^^^^^^^
 * CRCL 3D Twist DataType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_CRCL_VectorDataType linearVelocity;
    UA_CRCL_VectorDataType angularVelocity;
} UA_CRCL_TwistDataType;

#define UA_TYPES_CRCL_CRCL_TWISTDATATYPE 10

/**
 * CRCL_WrenchDataType
 * ^^^^^^^^^^^^^^^^^^^
 * CRCL 3D Wrench DataType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_CRCL_VectorDataType force;
    UA_CRCL_VectorDataType moment;
} UA_CRCL_WrenchDataType;

#define UA_TYPES_CRCL_CRCL_WRENCHDATATYPE 11

/**
 * CRCL_PoseToleranceDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL PoseTolerance DataType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_Double xPointTolerance;
    UA_Double yPointTolerance;
    UA_Double zPointTolerance;
    UA_Double xAxisTolerance;
    UA_Double zAxisTolerance;
} UA_CRCL_PoseToleranceDataType;

#define UA_TYPES_CRCL_CRCL_POSETOLERANCEDATATYPE 12

/**
 * CRCL_ParameterSettingDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL ParameterSetting DataType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_String parameterName;
    UA_String parameterValue;
} UA_CRCL_ParameterSettingDataType;

#define UA_TYPES_CRCL_CRCL_PARAMETERSETTINGDATATYPE 13

/**
 * CRCL_RotAccelAbsoluteDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL RotAccelAbsolute DataType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_Double setting;
} UA_CRCL_RotAccelAbsoluteDataType;

#define UA_TYPES_CRCL_CRCL_ROTACCELABSOLUTEDATATYPE 14

/**
 * CRCL_RotAccelRelativeDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL RotAccelRelative DataType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_CRCL_FractionDataType fraction;
} UA_CRCL_RotAccelRelativeDataType;

#define UA_TYPES_CRCL_CRCL_ROTACCELRELATIVEDATATYPE 15

/**
 * CRCL_RotAccelDataType
 * ^^^^^^^^^^^^^^^^^^^^^
 * CRCL RotAccel DataType */
typedef enum {
    UA_CRCL_ROTACCELDATATYPESWITCH_NONE = 0,
    UA_CRCL_ROTACCELDATATYPESWITCH_ROTACCELABSOLUTEDATATYPE = 1,
    UA_CRCL_ROTACCELDATATYPESWITCH_ROTACCELRELATIVEDATATYPE = 2,
    __UA_CRCL_ROTACCELDATATYPESWITCH_FORCE32BIT = 0x7fffffff
} UA_CRCL_RotAccelDataTypeSwitch;
UA_STATIC_ASSERT(sizeof(UA_CRCL_RotAccelDataTypeSwitch) == sizeof(UA_Int32), enum_must_be_32bit);

typedef struct {
    UA_CRCL_RotAccelDataTypeSwitch switchField;
    union {
        UA_CRCL_RotAccelAbsoluteDataType rotAccelAbsoluteDataType;
        UA_CRCL_RotAccelRelativeDataType rotAccelRelativeDataType;
    } fields;
} UA_CRCL_RotAccelDataType;

#define UA_TYPES_CRCL_CRCL_ROTACCELDATATYPE 16

/**
 * CRCL_RotSpeedAbsoluteDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL RotSpeedAbsolute DataType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_Double setting;
} UA_CRCL_RotSpeedAbsoluteDataType;

#define UA_TYPES_CRCL_CRCL_ROTSPEEDABSOLUTEDATATYPE 17

/**
 * CRCL_RotSpeedRelativeDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL RotSpeedRelative DataType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_CRCL_FractionDataType fraction;
} UA_CRCL_RotSpeedRelativeDataType;

#define UA_TYPES_CRCL_CRCL_ROTSPEEDRELATIVEDATATYPE 18

/**
 * CRCL_RotSpeedDataType
 * ^^^^^^^^^^^^^^^^^^^^^
 * CRCL RotSpeedDataType DataType */
typedef enum {
    UA_CRCL_ROTSPEEDDATATYPESWITCH_NONE = 0,
    UA_CRCL_ROTSPEEDDATATYPESWITCH_ROTSPEEDABSOLUTEDATATYPE = 1,
    UA_CRCL_ROTSPEEDDATATYPESWITCH_ROTSPEEDRELATIVEDATATYPE = 2,
    __UA_CRCL_ROTSPEEDDATATYPESWITCH_FORCE32BIT = 0x7fffffff
} UA_CRCL_RotSpeedDataTypeSwitch;
UA_STATIC_ASSERT(sizeof(UA_CRCL_RotSpeedDataTypeSwitch) == sizeof(UA_Int32), enum_must_be_32bit);

typedef struct {
    UA_CRCL_RotSpeedDataTypeSwitch switchField;
    union {
        UA_CRCL_RotSpeedAbsoluteDataType rotSpeedAbsoluteDataType;
        UA_CRCL_RotSpeedRelativeDataType rotSpeedRelativeDataType;
    } fields;
} UA_CRCL_RotSpeedDataType;

#define UA_TYPES_CRCL_CRCL_ROTSPEEDDATATYPE 19

/**
 * CRCL_TransAccelAbsoluteDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL TransAccelAbsolute DataType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_Double setting;
} UA_CRCL_TransAccelAbsoluteDataType;

#define UA_TYPES_CRCL_CRCL_TRANSACCELABSOLUTEDATATYPE 20

/**
 * CRCL_TransAccelRelativeDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL TransAccelRelative DataType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_CRCL_FractionDataType fraction;
} UA_CRCL_TransAccelRelativeDataType;

#define UA_TYPES_CRCL_CRCL_TRANSACCELRELATIVEDATATYPE 21

/**
 * CRCL_TransAccelDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL TransAccel DataType  (relative or absolute) */
typedef enum {
    UA_CRCL_TRANSACCELDATATYPESWITCH_NONE = 0,
    UA_CRCL_TRANSACCELDATATYPESWITCH_TRANSACCELABSOLUTEDATATYPE = 1,
    UA_CRCL_TRANSACCELDATATYPESWITCH_TRANSACCELRELATIVEDATATYPE = 2,
    __UA_CRCL_TRANSACCELDATATYPESWITCH_FORCE32BIT = 0x7fffffff
} UA_CRCL_TransAccelDataTypeSwitch;
UA_STATIC_ASSERT(sizeof(UA_CRCL_TransAccelDataTypeSwitch) == sizeof(UA_Int32), enum_must_be_32bit);

typedef struct {
    UA_CRCL_TransAccelDataTypeSwitch switchField;
    union {
        UA_CRCL_TransAccelAbsoluteDataType transAccelAbsoluteDataType;
        UA_CRCL_TransAccelRelativeDataType transAccelRelativeDataType;
    } fields;
} UA_CRCL_TransAccelDataType;

#define UA_TYPES_CRCL_CRCL_TRANSACCELDATATYPE 22

/**
 * CRCL_TransSpeedAbsoluteDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL TransSpeedAbsolute DataType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_Double setting;
} UA_CRCL_TransSpeedAbsoluteDataType;

#define UA_TYPES_CRCL_CRCL_TRANSSPEEDABSOLUTEDATATYPE 23

/**
 * CRCL_TransSpeedRelativeDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL TransSpeedRelative DataType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_CRCL_FractionDataType fraction;
} UA_CRCL_TransSpeedRelativeDataType;

#define UA_TYPES_CRCL_CRCL_TRANSSPEEDRELATIVEDATATYPE 24

/**
 * CRCL_TransSpeedDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL TransSpeed DataType (relative or absolute) */
typedef enum {
    UA_CRCL_TRANSSPEEDDATATYPESWITCH_NONE = 0,
    UA_CRCL_TRANSSPEEDDATATYPESWITCH_TRANSSPEEDABSOLUTEDATATYPE = 1,
    UA_CRCL_TRANSSPEEDDATATYPESWITCH_TRANSSPEEDRELATIVEDATATYPE = 2,
    __UA_CRCL_TRANSSPEEDDATATYPESWITCH_FORCE32BIT = 0x7fffffff
} UA_CRCL_TransSpeedDataTypeSwitch;
UA_STATIC_ASSERT(sizeof(UA_CRCL_TransSpeedDataTypeSwitch) == sizeof(UA_Int32), enum_must_be_32bit);

typedef struct {
    UA_CRCL_TransSpeedDataTypeSwitch switchField;
    union {
        UA_CRCL_TransSpeedAbsoluteDataType transSpeedAbsoluteDataType;
        UA_CRCL_TransSpeedRelativeDataType transSpeedRelativeDataType;
    } fields;
} UA_CRCL_TransSpeedDataType;

#define UA_TYPES_CRCL_CRCL_TRANSSPEEDDATATYPE 25

/**
 * CRCL_ConfigureJointReportDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL ConfigureJointReportDataType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_Int32 jointNumber;
    UA_Boolean reportPosition;
    UA_Boolean reportTorqueOrForce;
    UA_Boolean reportVelocity;
} UA_CRCL_ConfigureJointReportDataType;

#define UA_TYPES_CRCL_CRCL_CONFIGUREJOINTREPORTDATATYPE 26

/**
 * CRCL_GuardLimitEnumDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^
 */
typedef enum {
    UA_CRCL_GUARDLIMITENUMDATATYPE_OVER_MAX = 0,
    UA_CRCL_GUARDLIMITENUMDATATYPE_UNDER_MIN = 1,
    UA_CRCL_GUARDLIMITENUMDATATYPE_INCREASE_OVER_LIMIT = 2,
    UA_CRCL_GUARDLIMITENUMDATATYPE_DECREASE_BEYOND_LIMIT = 3,
    __UA_CRCL_GUARDLIMITENUMDATATYPE_FORCE32BIT = 0x7fffffff
} UA_CRCL_GuardLimitEnumDataType;
UA_STATIC_ASSERT(sizeof(UA_CRCL_GuardLimitEnumDataType) == sizeof(UA_Int32), enum_must_be_32bit);

#define UA_TYPES_CRCL_CRCL_GUARDLIMITENUMDATATYPE 27

/**
 * CRCL_GuardDataType
 * ^^^^^^^^^^^^^^^^^^
 * CRCL GuardType DataType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_String sensorID;
    UA_String subField;
    UA_CRCL_GuardLimitEnumDataType limitType;
    UA_Double limitValue;
    UA_UInt32 recheckTimeMicroSeconds;
    UA_UInt32 checkCount;
    UA_UInt32 lastCheckTime;
    UA_Double lastCheckValue;
} UA_CRCL_GuardDataType;

#define UA_TYPES_CRCL_CRCL_GUARDDATATYPE 28

/**
 * CRCL_JointPositionToleranceSettingDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL JointPositionToleranceSettingDataType DataType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_Int32 jointNumber;
    UA_Double jointPositionTolerance;
} UA_CRCL_JointPositionToleranceSettingDataType;

#define UA_TYPES_CRCL_CRCL_JOINTPOSITIONTOLERANCESETTINGDATATYPE 29

/**
 * CRCL_JointPositionsTolerancesDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL CRCL_JointPositionsTolerancesDataType DataType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    size_t settingSize;
    UA_CRCL_JointPositionToleranceSettingDataType *setting;
} UA_CRCL_JointPositionsTolerancesDataType;

#define UA_TYPES_CRCL_CRCL_JOINTPOSITIONSTOLERANCESDATATYPE 30

/**
 * CRCL_PoseAndSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL PoseAndSet DataType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_CRCL_PointDataType point;
    UA_CRCL_VectorDataType xAxis;
    UA_CRCL_VectorDataType zAxis;
    UA_Boolean coordinated;
    UA_CRCL_TransSpeedDataType transSpeed;
    UA_CRCL_RotSpeedDataType rotSpeed;
    UA_CRCL_TransAccelDataType transAccel;
    UA_CRCL_RotAccelDataType rotAccel;
    UA_CRCL_PoseToleranceDataType poseTolerance;
} UA_CRCL_PoseAndSetDataType;

#define UA_TYPES_CRCL_CRCL_POSEANDSETDATATYPE 31

/**
 * CRCLCommandDataType
 * ^^^^^^^^^^^^^^^^^^^
 * Base CRCLCommand */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
} UA_CRCLCommandDataType;

#define UA_TYPES_CRCL_CRCLCOMMANDDATATYPE 32

/**
 * MiddleCommandDataType
 * ^^^^^^^^^^^^^^^^^^^^^
 * CRCL MiddleCommand */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
} UA_MiddleCommandDataType;

#define UA_TYPES_CRCL_MIDDLECOMMANDDATATYPE 33

/**
 * EndCanonDataType
 * ^^^^^^^^^^^^^^^^
 * CRCL EndCanonType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
} UA_EndCanonDataType;

#define UA_TYPES_CRCL_ENDCANONDATATYPE 34

/**
 * InitCanonDataType
 * ^^^^^^^^^^^^^^^^^
 * CRCL InitCanonType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
} UA_InitCanonDataType;

#define UA_TYPES_CRCL_INITCANONDATATYPE 35

/**
 * CRCL_JointForceTorqueDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL JointForceTorqueDataType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_Double setting;
    UA_Double changeRate;
} UA_CRCL_JointForceTorqueDataType;

#define UA_TYPES_CRCL_CRCL_JOINTFORCETORQUEDATATYPE 36

/**
 * CRCL_JointSpeedAccelDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL JointSpeedAccelDataType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_Double jointSpeed;
    UA_Double jointAccel;
} UA_CRCL_JointSpeedAccelDataType;

#define UA_TYPES_CRCL_CRCL_JOINTSPEEDACCELDATATYPE 37

/**
 * MoveToDataType
 * ^^^^^^^^^^^^^^
 * CRCL MoveTo */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
    UA_Boolean moveStraight;
    UA_CRCL_PoseDataType endPosition;
} UA_MoveToDataType;

#define UA_TYPES_CRCL_MOVETODATATYPE 38

/**
 * CloseToolChangerDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL CloseToolChanger MiddleCommand */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
} UA_CloseToolChangerDataType;

#define UA_TYPES_CRCL_CLOSETOOLCHANGERDATATYPE 39

/**
 * DwellDataType
 * ^^^^^^^^^^^^^
 * CRCL Dwell */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
    UA_Double dwellTime;
} UA_DwellDataType;

#define UA_TYPES_CRCL_DWELLDATATYPE 40

/**
 * GetStatusDataType
 * ^^^^^^^^^^^^^^^^^
 * CRCL GetStatus */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
} UA_GetStatusDataType;

#define UA_TYPES_CRCL_GETSTATUSDATATYPE 41

/**
 * MessageDataType
 * ^^^^^^^^^^^^^^^
 * CRCL Message */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
    UA_String message;
} UA_MessageDataType;

#define UA_TYPES_CRCL_MESSAGEDATATYPE 42

/**
 * MoveScrewDataType
 * ^^^^^^^^^^^^^^^^^
 * CRCL MoveScrew */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
    UA_CRCL_PoseDataType startPosition;
    UA_CRCL_PointDataType axisPoint;
    UA_Double axialDistanceFree;
    UA_Double axialDistanceScrew;
    UA_Double turn;
} UA_MoveScrewDataType;

#define UA_TYPES_CRCL_MOVESCREWDATATYPE 43

/**
 * MoveThroughToDataType
 * ^^^^^^^^^^^^^^^^^^^^^
 * CRCL MoveThroughTo */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
    UA_Boolean moveStraight;
    size_t waypointSize;
    UA_CRCL_PoseDataType *waypoint;
    UA_UInt32 numPositions;
} UA_MoveThroughToDataType;

#define UA_TYPES_CRCL_MOVETHROUGHTODATATYPE 44

/**
 * OpenToolChangerDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL OpenToolChanger */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
} UA_OpenToolChangerDataType;

#define UA_TYPES_CRCL_OPENTOOLCHANGERDATATYPE 45

/**
 * RunProgramDataType
 * ^^^^^^^^^^^^^^^^^^
 * CRCL RunProgram */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
    UA_String programText;
} UA_RunProgramDataType;

#define UA_TYPES_CRCL_RUNPROGRAMDATATYPE 46

/**
 * SetAngleUnitsDataType
 * ^^^^^^^^^^^^^^^^^^^^^
 * CRCL SetAngleUnits */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
    UA_CRCL_AngleUnitEnumDataType unitName;
} UA_SetAngleUnitsDataType;

#define UA_TYPES_CRCL_SETANGLEUNITSDATATYPE 47

/**
 * SetEndeffectorParametersDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL SetEndEffectorParameters */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
    size_t parameterSettingSize;
    UA_CRCL_ParameterSettingDataType *parameterSetting;
} UA_SetEndeffectorParametersDataType;

#define UA_TYPES_CRCL_SETENDEFFECTORPARAMETERSDATATYPE 48

/**
 * SetEndeffectorDataType
 * ^^^^^^^^^^^^^^^^^^^^^^
 * CRCL SetEndEffector */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
    UA_CRCL_FractionDataType setting;
} UA_SetEndeffectorDataType;

#define UA_TYPES_CRCL_SETENDEFFECTORDATATYPE 49

/**
 * SetEndPoseToleranceDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL SetEndPoseTolerance */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
    UA_CRCL_PoseToleranceDataType tolerance;
} UA_SetEndPoseToleranceDataType;

#define UA_TYPES_CRCL_SETENDPOSETOLERANCEDATATYPE 50

/**
 * SetForceUnitsDataType
 * ^^^^^^^^^^^^^^^^^^^^^
 * CRCL SetForceUnits */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
    UA_CRCL_ForceUnitEnumDataType unitName;
} UA_SetForceUnitsDataType;

#define UA_TYPES_CRCL_SETFORCEUNITSDATATYPE 51

/**
 * SetIntermediatePoseToleranceDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL SetIntermediatePoseTolerance */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
    UA_CRCL_PoseToleranceDataType tolerance;
} UA_SetIntermediatePoseToleranceDataType;

#define UA_TYPES_CRCL_SETINTERMEDIATEPOSETOLERANCEDATATYPE 52

/**
 * SetLengthUnitsDataType
 * ^^^^^^^^^^^^^^^^^^^^^^
 * CRCL SetLengthUnits */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
    UA_CRCL_LengthUnitEnumDataType unitName;
} UA_SetLengthUnitsDataType;

#define UA_TYPES_CRCL_SETLENGTHUNITSDATATYPE 53

/**
 * SetMotionCoordinationDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL SetMotionCoordination */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
    UA_Boolean coordinated;
} UA_SetMotionCoordinationDataType;

#define UA_TYPES_CRCL_SETMOTIONCOORDINATIONDATATYPE 54

/**
 * SetRobotParametersDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL SetRobotParameters */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
    size_t parameterSettingSize;
    UA_CRCL_ParameterSettingDataType *parameterSetting;
} UA_SetRobotParametersDataType;

#define UA_TYPES_CRCL_SETROBOTPARAMETERSDATATYPE 55

/**
 * SetTorqueUnitsDataType
 * ^^^^^^^^^^^^^^^^^^^^^^
 * CRCL SetLengthUnits */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
    UA_CRCL_TorqueUnitEnumDataType unitName;
} UA_SetTorqueUnitsDataType;

#define UA_TYPES_CRCL_SETTORQUEUNITSDATATYPE 56

/**
 * StopMotionDataType
 * ^^^^^^^^^^^^^^^^^^
 * CRCL StopMotion */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
    UA_CRCL_StopConditionEnumDataType stopCondition;
} UA_StopMotionDataType;

#define UA_TYPES_CRCL_STOPMOTIONDATATYPE 57

/**
 * ConfigureStatusReportDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL ConfigureStatusReport */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
    UA_Boolean reportJointStatuses;
    UA_Boolean reportPoseStatus;
    UA_Boolean reportGripperStatus;
    UA_Boolean reportSettingsStatus;
    UA_Boolean reportSensorsStatus;
    UA_Boolean reportGuardsStatus;
} UA_ConfigureStatusReportDataType;

#define UA_TYPES_CRCL_CONFIGURESTATUSREPORTDATATYPE 58

/**
 * EnableSensorDataType
 * ^^^^^^^^^^^^^^^^^^^^
 * CRCL EnableSensor */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
    UA_String sensorID;
    size_t sensorOptionSize;
    UA_CRCL_ParameterSettingDataType *sensorOption;
} UA_EnableSensorDataType;

#define UA_TYPES_CRCL_ENABLESENSORDATATYPE 59

/**
 * DisableSensorDataType
 * ^^^^^^^^^^^^^^^^^^^^^
 * CRCL DisableSensor */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
    UA_String sensorID;
} UA_DisableSensorDataType;

#define UA_TYPES_CRCL_DISABLESENSORDATATYPE 60

/**
 * EnableGripperDataType
 * ^^^^^^^^^^^^^^^^^^^^^
 * CRCL EnableGripper */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
    UA_String gripperName;
    size_t gripperOptionSize;
    UA_CRCL_ParameterSettingDataType *gripperOption;
} UA_EnableGripperDataType;

#define UA_TYPES_CRCL_ENABLEGRIPPERDATATYPE 61

/**
 * DisableGripperDataType
 * ^^^^^^^^^^^^^^^^^^^^^^
 * CRCL DisableGripper */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
    UA_String gripperName;
} UA_DisableGripperDataType;

#define UA_TYPES_CRCL_DISABLEGRIPPERDATATYPE 62

/**
 * EnableRobotParameterStatusDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL EnableRobotParameterStatus */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
    UA_String robotParameterName;
} UA_EnableRobotParameterStatusDataType;

#define UA_TYPES_CRCL_ENABLEROBOTPARAMETERSTATUSDATATYPE 63

/**
 * DisableRobotParameterStatusDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL DisableRobotParameterStatus */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
    UA_String robotParameterName;
} UA_DisableRobotParameterStatusDataType;

#define UA_TYPES_CRCL_DISABLEROBOTPARAMETERSTATUSDATATYPE 64

/**
 * SetDefaultJointPositionsTolerancesDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL SetEndPoseTolerance */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
    UA_CRCL_JointPositionsTolerancesDataType jointTolerances;
} UA_SetDefaultJointPositionsTolerancesDataType;

#define UA_TYPES_CRCL_SETDEFAULTJOINTPOSITIONSTOLERANCESDATATYPE 65

/**
 * SetRotAccelDataType
 * ^^^^^^^^^^^^^^^^^^^
 * CRCL SetRotAccel */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
    UA_CRCL_RotAccelDataType rotAccel;
} UA_SetRotAccelDataType;

#define UA_TYPES_CRCL_SETROTACCELDATATYPE 66

/**
 * SetTransAccelDataType
 * ^^^^^^^^^^^^^^^^^^^^^
 * CRCL SetTransAccel */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
    UA_CRCL_TransAccelDataType transAccel;
} UA_SetTransAccelDataType;

#define UA_TYPES_CRCL_SETTRANSACCELDATATYPE 67

/**
 * SetRotSpeedDataType
 * ^^^^^^^^^^^^^^^^^^^
 * CRCL SetRotSpeed */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
    UA_CRCL_RotSpeedDataType rotSpeed;
} UA_SetRotSpeedDataType;

#define UA_TYPES_CRCL_SETROTSPEEDDATATYPE 68

/**
 * SetTransSpeedDataType
 * ^^^^^^^^^^^^^^^^^^^^^
 * CRCL SetTransSpeed */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
    UA_CRCL_TransSpeedDataType transSpeed;
} UA_SetTransSpeedDataType;

#define UA_TYPES_CRCL_SETTRANSSPEEDDATATYPE 69

/**
 * ConfigureJointReportsDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL ConfigureJointReportsDataType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
    UA_Boolean resetAll;
    size_t configureJointReportSize;
    UA_CRCL_ConfigureJointReportDataType *configureJointReport;
} UA_ConfigureJointReportsDataType;

#define UA_TYPES_CRCL_CONFIGUREJOINTREPORTSDATATYPE 70

/**
 * CRCL_CommandStateEnumDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 */
typedef enum {
    UA_CRCL_COMMANDSTATEENUMDATATYPE_CRCL_DONE = 0,
    UA_CRCL_COMMANDSTATEENUMDATATYPE_CRCL_ERROR = 1,
    UA_CRCL_COMMANDSTATEENUMDATATYPE_CRCL_WORKING = 2,
    UA_CRCL_COMMANDSTATEENUMDATATYPE_CRCL_READY = 3,
    __UA_CRCL_COMMANDSTATEENUMDATATYPE_FORCE32BIT = 0x7fffffff
} UA_CRCL_CommandStateEnumDataType;
UA_STATIC_ASSERT(sizeof(UA_CRCL_CommandStateEnumDataType) == sizeof(UA_Int32), enum_must_be_32bit);

#define UA_TYPES_CRCL_CRCL_COMMANDSTATEENUMDATATYPE 71

/**
 * CRCL_CommandStatusDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL Status of a CRCL command */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_UInt32 statusID;
    UA_CRCL_CommandStateEnumDataType commandState;
    UA_String stateDescription;
    UA_String programmFile;
    UA_UInt32 programmIndex;
    UA_UInt32 programmLength;
    UA_UInt32 overridePercent;
} UA_CRCL_CommandStatusDataType;

#define UA_TYPES_CRCL_CRCL_COMMANDSTATUSDATATYPE 72

/**
 * CRCL_SensorStatusDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL State of a sensor */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_String sensorID;
    UA_UInt32 readCount;
    UA_UInt32 lastReadTime;
    size_t sensorParameterSettingSize;
    UA_CRCL_ParameterSettingDataType *sensorParameterSetting;
} UA_CRCL_SensorStatusDataType;

#define UA_TYPES_CRCL_CRCL_SENSORSTATUSDATATYPE 73

/**
 * CRCL_CountSensorStatusDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL State of a count sensor */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_String sensorID;
    UA_UInt32 readCount;
    UA_UInt32 lastReadTime;
    size_t sensorParameterSettingSize;
    UA_CRCL_ParameterSettingDataType *sensorParameterSetting;
    UA_UInt32 countValue;
} UA_CRCL_CountSensorStatusDataType;

#define UA_TYPES_CRCL_CRCL_COUNTSENSORSTATUSDATATYPE 74

/**
 * CRCL_OnOffSensorStatusDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL State of a OnOff sensor */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_String sensorID;
    UA_UInt32 readCount;
    UA_UInt32 lastReadTime;
    size_t sensorParameterSettingSize;
    UA_CRCL_ParameterSettingDataType *sensorParameterSetting;
    UA_Boolean on;
} UA_CRCL_OnOffSensorStatusDataType;

#define UA_TYPES_CRCL_CRCL_ONOFFSENSORSTATUSDATATYPE 75

/**
 * CRCL_ScalarSensorStatusDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL State of a scalar sensor */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_String sensorID;
    UA_UInt32 readCount;
    UA_UInt32 lastReadTime;
    size_t sensorParameterSettingSize;
    UA_CRCL_ParameterSettingDataType *sensorParameterSetting;
    UA_Double scalarValue;
} UA_CRCL_ScalarSensorStatusDataType;

#define UA_TYPES_CRCL_CRCL_SCALARSENSORSTATUSDATATYPE 76

/**
 * CRCL_ForceTorqueSensorStatusDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL State of a count sensor */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_String sensorID;
    UA_UInt32 readCount;
    UA_UInt32 lastReadTime;
    size_t sensorParameterSettingSize;
    UA_CRCL_ParameterSettingDataType *sensorParameterSetting;
    UA_Double fx;
    UA_Double fy;
    UA_Double fz;
    UA_Double tx;
    UA_Double ty;
    UA_Double tz;
} UA_CRCL_ForceTorqueSensorStatusDataType;

#define UA_TYPES_CRCL_CRCL_FORCETORQUESENSORSTATUSDATATYPE 77

/**
 * CRCL_SensorStatusesDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL State of a sensor */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    size_t onOffSensorStatusSize;
    UA_CRCL_OnOffSensorStatusDataType *onOffSensorStatus;
    size_t scalarSensorStatusSize;
    UA_CRCL_ScalarSensorStatusDataType *scalarSensorStatus;
    size_t countSensorStatusSize;
    UA_CRCL_CountSensorStatusDataType *countSensorStatus;
    size_t forceTorqueSensorStatusSize;
    UA_CRCL_ForceTorqueSensorStatusDataType *forceTorqueSensorStatus;
} UA_CRCL_SensorStatusesDataType;

#define UA_TYPES_CRCL_CRCL_SENSORSTATUSESDATATYPE 78

/**
 * CRCL_GripperStatusDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^
 * GripperStatus DataType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_String gripperName;
    size_t gripperOptionSize;
    UA_CRCL_ParameterSettingDataType *gripperOption;
    UA_Boolean holdingObject;
} UA_CRCL_GripperStatusDataType;

#define UA_TYPES_CRCL_CRCL_GRIPPERSTATUSDATATYPE 79

/**
 * CRCL_ParallelGripperStatusDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * GripperStatus DataType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_String gripperName;
    size_t gripperOptionSize;
    UA_CRCL_ParameterSettingDataType *gripperOption;
    UA_Boolean holdingObject;
    UA_Double seperation;
} UA_CRCL_ParallelGripperStatusDataType;

#define UA_TYPES_CRCL_CRCL_PARALLELGRIPPERSTATUSDATATYPE 80

/**
 * CRCL_ThreeFingerGripperStatusDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * GripperStatus DataType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_String gripperName;
    size_t gripperOptionSize;
    UA_CRCL_ParameterSettingDataType *gripperOption;
    UA_Boolean holdingObject;
    UA_CRCL_FractionDataType finger1Position;
    UA_CRCL_FractionDataType finger2Position;
    UA_CRCL_FractionDataType finger3Position;
    UA_Double finger1Force;
    UA_Double finger2Force;
    UA_Double finger3Force;
} UA_CRCL_ThreeFingerGripperStatusDataType;

#define UA_TYPES_CRCL_CRCL_THREEFINGERGRIPPERSTATUSDATATYPE 81

/**
 * CRCL_VacuumGripperStatusDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * GripperStatus DataType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_String gripperName;
    size_t gripperOptionSize;
    UA_CRCL_ParameterSettingDataType *gripperOption;
    UA_Boolean holdingObject;
    UA_Boolean isPowered;
} UA_CRCL_VacuumGripperStatusDataType;

#define UA_TYPES_CRCL_CRCL_VACUUMGRIPPERSTATUSDATATYPE 82

/**
 * CRCL_PoseStatusDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^
 * Pose Status DataType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_CRCL_PoseDataType pose;
    UA_CRCL_TwistDataType twist;
    UA_CRCL_WrenchDataType wrench;
    UA_String configuration;
} UA_CRCL_PoseStatusDataType;

#define UA_TYPES_CRCL_CRCL_POSESTATUSDATATYPE 83

/**
 * CRCL_JointLimitDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^
 * Pose Status DataType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 jointNumber;
    UA_Double jointMinPosition;
    UA_Double jointMaxPosition;
    UA_Double jointMaxTorqueOrForce;
    UA_Double jointMaxVelocity;
} UA_CRCL_JointLimitDataType;

#define UA_TYPES_CRCL_CRCL_JOINTLIMITDATATYPE 84

/**
 * CRCL_JointStatusDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^
 * Pose Status DataType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 jointNumber;
    UA_Double jointPosition;
    UA_Double jointTorqueOrForce;
    UA_Double jointVelocity;
} UA_CRCL_JointStatusDataType;

#define UA_TYPES_CRCL_CRCL_JOINTSTATUSDATATYPE 85

/**
 * CRCL_JointStatusesDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^
 * Pose Status DataType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    size_t jointStatusSize;
    UA_CRCL_JointStatusDataType *jointStatus;
} UA_CRCL_JointStatusesDataType;

#define UA_TYPES_CRCL_CRCL_JOINTSTATUSESDATATYPE 86

/**
 * CRCLCommandParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a CRCL Command. */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
} UA_CRCLCommandParamsSetDataType;

#define UA_TYPES_CRCL_CRCLCOMMANDPARAMSSETDATATYPE 87

/**
 * InitCanonParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of an Init Command (does not require parameters). */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
} UA_InitCanonParamsSetDataType;

#define UA_TYPES_CRCL_INITCANONPARAMSSETDATATYPE 88

/**
 * EndCanonParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of an EndCanon Command (does not require parameters). */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
} UA_EndCanonParamsSetDataType;

#define UA_TYPES_CRCL_ENDCANONPARAMSSETDATATYPE 89

/**
 * GetStatusParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a GetStatus Command (does not require parameters). */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
} UA_GetStatusParamsSetDataType;

#define UA_TYPES_CRCL_GETSTATUSPARAMSSETDATATYPE 90

/**
 * CloseToolChangerParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a CloseToolChanger Command (does not require parameters). */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
} UA_CloseToolChangerParamsSetDataType;

#define UA_TYPES_CRCL_CLOSETOOLCHANGERPARAMSSETDATATYPE 91

/**
 * OpenToolChangerParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a OpenToolChanger Command (does not require parameters). */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
} UA_OpenToolChangerParamsSetDataType;

#define UA_TYPES_CRCL_OPENTOOLCHANGERPARAMSSETDATATYPE 92

/**
 * MessageParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a Message Command. */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
    UA_String message;
} UA_MessageParamsSetDataType;

#define UA_TYPES_CRCL_MESSAGEPARAMSSETDATATYPE 93

/**
 * MoveToParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a MoveToCommand. */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
    UA_Boolean moveStraight;
    UA_CRCL_PoseDataType endPosition;
} UA_MoveToParamsSetDataType;

#define UA_TYPES_CRCL_MOVETOPARAMSSETDATATYPE 94

/**
 * MoveScrewParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a MoveScrew Command. */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
    UA_CRCL_PoseDataType startPosition;
    UA_CRCL_PointDataType axisPoint;
    UA_Double axialDistanceFree;
    UA_Double axialDistanceScrew;
    UA_Double turn;
} UA_MoveScrewParamsSetDataType;

#define UA_TYPES_CRCL_MOVESCREWPARAMSSETDATATYPE 95

/**
 * MoveThroughToParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a MoveThroughTo Command. */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
    UA_Boolean moveStraight;
    size_t waypointSize;
    UA_CRCL_PoseDataType *waypoint;
    UA_Int32 numPositions;
} UA_MoveThroughToParamsSetDataType;

#define UA_TYPES_CRCL_MOVETHROUGHTOPARAMSSETDATATYPE 96

/**
 * DwellParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a Dwell Command. */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
    UA_Double dwellTime;
} UA_DwellParamsSetDataType;

#define UA_TYPES_CRCL_DWELLPARAMSSETDATATYPE 97

/**
 * ConfigureJointReportsParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a ConfigureJointreports Command. */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
    UA_Boolean resetAll;
    size_t configureJointReportSize;
    UA_CRCL_ConfigureJointReportDataType *configureJointReport;
} UA_ConfigureJointReportsParamsSetDataType;

#define UA_TYPES_CRCL_CONFIGUREJOINTREPORTSPARAMSSETDATATYPE 98

/**
 * SetDefaultJointPositionsTolerancesParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a SetDefaultJointPositionsTolerances Command. */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
    UA_CRCL_JointPositionsTolerancesDataType jointTolerances;
} UA_SetDefaultJointPositionsTolerancesParamsSetDataType;

#define UA_TYPES_CRCL_SETDEFAULTJOINTPOSITIONSTOLERANCESPARAMSSETDATATYPE 99

/**
 * SetRobotParametersParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a SetRobotParameters Command. */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
    size_t parameterSettingSize;
    UA_CRCL_ParameterSettingDataType *parameterSetting;
} UA_SetRobotParametersParamsSetDataType;

#define UA_TYPES_CRCL_SETROBOTPARAMETERSPARAMSSETDATATYPE 100

/**
 * SetEndeffectorParametersParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a SetEndeffectorParameters Command. */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
    size_t parameterSettingSize;
    UA_CRCL_ParameterSettingDataType *parameterSetting;
} UA_SetEndeffectorParametersParamsSetDataType;

#define UA_TYPES_CRCL_SETENDEFFECTORPARAMETERSPARAMSSETDATATYPE 101

/**
 * SetEndeffectorParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a SetEndeffector Command. */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
    UA_CRCL_FractionDataType setting;
} UA_SetEndeffectorParamsSetDataType;

#define UA_TYPES_CRCL_SETENDEFFECTORPARAMSSETDATATYPE 102

/**
 * SetTransSpeedParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a SetTransSpeed Command. */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
    UA_CRCL_TransSpeedDataType transSpeed;
} UA_SetTransSpeedParamsSetDataType;

#define UA_TYPES_CRCL_SETTRANSSPEEDPARAMSSETDATATYPE 103

/**
 * SetTransAccelParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a SetTransAccel Command. */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
    UA_CRCL_TransAccelDataType transAccel;
} UA_SetTransAccelParamsSetDataType;

#define UA_TYPES_CRCL_SETTRANSACCELPARAMSSETDATATYPE 104

/**
 * SetRotSpeedParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a SetTransSpeed Command. */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
    UA_CRCL_RotSpeedDataType rotSpeed;
} UA_SetRotSpeedParamsSetDataType;

#define UA_TYPES_CRCL_SETROTSPEEDPARAMSSETDATATYPE 105

/**
 * SetRotAccelParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a SetRotAccel Command. */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
    UA_CRCL_RotAccelDataType rotAccel;
} UA_SetRotAccelParamsSetDataType;

#define UA_TYPES_CRCL_SETROTACCELPARAMSSETDATATYPE 106

/**
 * SetAngleUnitsParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a SetAngleUnits Command. */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
    UA_CRCL_AngleUnitEnumDataType unitName;
} UA_SetAngleUnitsParamsSetDataType;

#define UA_TYPES_CRCL_SETANGLEUNITSPARAMSSETDATATYPE 107

/**
 * SetEndPoseToleranceParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a SetEndPoseTolerance Command. */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
    UA_CRCL_PoseToleranceDataType tolerance;
} UA_SetEndPoseToleranceParamsSetDataType;

#define UA_TYPES_CRCL_SETENDPOSETOLERANCEPARAMSSETDATATYPE 108

/**
 * SetForceUnitsParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a SetForceUnits Command. */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
    UA_CRCL_ForceUnitEnumDataType unitName;
} UA_SetForceUnitsParamsSetDataType;

#define UA_TYPES_CRCL_SETFORCEUNITSPARAMSSETDATATYPE 109

/**
 * SetIntermediatePoseToleranceParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a SetIntermediatePoseTolerance Command. */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
    UA_CRCL_PoseToleranceDataType tolerance;
} UA_SetIntermediatePoseToleranceParamsSetDataType;

#define UA_TYPES_CRCL_SETINTERMEDIATEPOSETOLERANCEPARAMSSETDATATYPE 110

/**
 * SetLengthUnitsParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a SetLengthUnits Command. */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
    UA_CRCL_LengthUnitEnumDataType unitName;
} UA_SetLengthUnitsParamsSetDataType;

#define UA_TYPES_CRCL_SETLENGTHUNITSPARAMSSETDATATYPE 111

/**
 * SetMotionCoordinationParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a SetMotionCoordination Command. */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
    UA_Boolean coordinated;
} UA_SetMotionCoordinationParamsSetDataType;

#define UA_TYPES_CRCL_SETMOTIONCOORDINATIONPARAMSSETDATATYPE 112

/**
 * SetTorqueUnitsParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a SetTorqueUnits Command. */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
    UA_CRCL_TorqueUnitEnumDataType unitName;
} UA_SetTorqueUnitsParamsSetDataType;

#define UA_TYPES_CRCL_SETTORQUEUNITSPARAMSSETDATATYPE 113

/**
 * StopMotionParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a StopMotion Command. */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
    UA_CRCL_StopConditionEnumDataType stopCondition;
} UA_StopMotionParamsSetDataType;

#define UA_TYPES_CRCL_STOPMOTIONPARAMSSETDATATYPE 114

/**
 * ConfigureStatusReportParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a ConfigureStatusReport Command. */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
    UA_Boolean reportJointStatuses;
    UA_Boolean reportPoseStatus;
    UA_Boolean reportGripperStatus;
    UA_Boolean reportSettingsStatus;
    UA_Boolean reportSensorsStatus;
    UA_Boolean reportGuardsStatus;
} UA_ConfigureStatusReportParamsSetDataType;

#define UA_TYPES_CRCL_CONFIGURESTATUSREPORTPARAMSSETDATATYPE 115

/**
 * EnableSensorParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a EnableSensor Command. */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
    UA_String sensorID;
    size_t sensorOptionSize;
    UA_CRCL_ParameterSettingDataType *sensorOption;
} UA_EnableSensorParamsSetDataType;

#define UA_TYPES_CRCL_ENABLESENSORPARAMSSETDATATYPE 116

/**
 * DisableSensorParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a DisableSensor Command. */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
    UA_String sensorID;
} UA_DisableSensorParamsSetDataType;

#define UA_TYPES_CRCL_DISABLESENSORPARAMSSETDATATYPE 117

/**
 * EnableGripperParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a EnableGripper Command. */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
    UA_String gripperName;
    size_t gripperOptionSize;
    UA_CRCL_ParameterSettingDataType *gripperOption;
} UA_EnableGripperParamsSetDataType;

#define UA_TYPES_CRCL_ENABLEGRIPPERPARAMSSETDATATYPE 118

/**
 * DisableGripperParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a DisableGripper Command. */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
    UA_String gripperName;
} UA_DisableGripperParamsSetDataType;

#define UA_TYPES_CRCL_DISABLEGRIPPERPARAMSSETDATATYPE 119

/**
 * EnableRobotParameterStatusParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a EnableRobotParameterStatus Command. */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
    UA_String robotParameterName;
} UA_EnableRobotParameterStatusParamsSetDataType;

#define UA_TYPES_CRCL_ENABLEROBOTPARAMETERSTATUSPARAMSSETDATATYPE 120

/**
 * DisableRobotParameterStatusParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a DisableRobotParameterStatus Command. */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
    UA_String robotParameterName;
} UA_DisableRobotParameterStatusParamsSetDataType;

#define UA_TYPES_CRCL_DISABLEROBOTPARAMETERSTATUSPARAMSSETDATATYPE 121

/**
 * CRCLCommandsBufferState
 * ^^^^^^^^^^^^^^^^^^^^^^^
 */
typedef enum {
    UA_CRCLCOMMANDSBUFFERSTATE_PROCESSING_PENDING = 0,
    UA_CRCLCOMMANDSBUFFERSTATE_PROCESSING_RUNNING = 1,
    UA_CRCLCOMMANDSBUFFERSTATE_PROCESSING_FAILED = 2,
    UA_CRCLCOMMANDSBUFFERSTATE_AWAITING = 3,
    __UA_CRCLCOMMANDSBUFFERSTATE_FORCE32BIT = 0x7fffffff
} UA_CRCLCommandsBufferState;
UA_STATIC_ASSERT(sizeof(UA_CRCLCommandsBufferState) == sizeof(UA_Int32), enum_must_be_32bit);

#define UA_TYPES_CRCL_CRCLCOMMANDSBUFFERSTATE 122

/**
 * CRCL_JointDetailsDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL JointDetailsType */
typedef enum {
    UA_CRCL_JOINTDETAILSDATATYPESWITCH_NONE = 0,
    UA_CRCL_JOINTDETAILSDATATYPESWITCH_JOINTSPEEDACCEL = 1,
    UA_CRCL_JOINTDETAILSDATATYPESWITCH_JOINTFORCETORQUE = 2,
    __UA_CRCL_JOINTDETAILSDATATYPESWITCH_FORCE32BIT = 0x7fffffff
} UA_CRCL_JointDetailsDataTypeSwitch;
UA_STATIC_ASSERT(sizeof(UA_CRCL_JointDetailsDataTypeSwitch) == sizeof(UA_Int32), enum_must_be_32bit);

typedef struct {
    UA_CRCL_JointDetailsDataTypeSwitch switchField;
    union {
        UA_CRCL_JointSpeedAccelDataType jointSpeedAccel;
        UA_CRCL_JointForceTorqueDataType jointForceTorque;
    } fields;
} UA_CRCL_JointDetailsDataType;

#define UA_TYPES_CRCL_CRCL_JOINTDETAILSDATATYPE 123

/**
 * CRCL_ActuateJointDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCL ActuateJointType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_Int32 jointNumber;
    UA_Double jointPosition;
    UA_CRCL_JointDetailsDataType jointDetails;
} UA_CRCL_ActuateJointDataType;

#define UA_TYPES_CRCL_CRCL_ACTUATEJOINTDATATYPE 124

/**
 * ActuateJointsDataType
 * ^^^^^^^^^^^^^^^^^^^^^
 * CRCL ActuateJointsType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_UInt32 commandID;
    UA_Boolean realTimeCommand;
    UA_NodeId realTimeParameterNode;
    size_t guardSize;
    UA_CRCL_GuardDataType *guard;
    size_t actuateJointSize;
    UA_CRCL_ActuateJointDataType *actuateJoint;
    UA_CRCL_JointPositionsTolerancesDataType jointTolerances;
} UA_ActuateJointsDataType;

#define UA_TYPES_CRCL_ACTUATEJOINTSDATATYPE 125

/**
 * CRCL_SettingsStatusDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * GripperStatus DataType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_CRCL_AngleUnitEnumDataType angleUnitName;
    size_t endEffectorParameterSettingSize;
    UA_CRCL_ParameterSettingDataType *endEffectorParameterSetting;
    UA_CRCL_FractionDataType endEffectorSetting;
    UA_CRCL_ForceUnitEnumDataType forceUnitName;
    size_t jointLimitsSize;
    UA_CRCL_JointLimitDataType *jointLimits;
    UA_CRCL_PoseToleranceDataType intermediatePoseTolernace;
    UA_CRCL_LengthUnitEnumDataType lengthUnitName;
    UA_CRCL_PointDataType maxCartesianLimit;
    UA_CRCL_PointDataType minCartesianLimit;
    UA_Boolean motionCoorinated;
    UA_CRCL_PoseToleranceDataType poseTolerance;
    size_t robotParameterSettingSize;
    UA_CRCL_ParameterSettingDataType *robotParameterSetting;
    UA_CRCL_RotAccelAbsoluteDataType rotAccelAbsolute;
    UA_CRCL_RotAccelRelativeDataType rotAccelRelative;
    UA_CRCL_RotSpeedAbsoluteDataType rotSpeedAbsolute;
    UA_CRCL_RotSpeedRelativeDataType rotSpeedRelative;
    UA_CRCL_TorqueUnitEnumDataType torqueUnitName;
    UA_CRCL_TransAccelAbsoluteDataType transAccelAbsolute;
    UA_CRCL_TransAccelRelativeDataType transAccelRelative;
    UA_CRCL_TransSpeedAbsoluteDataType transSpeedAbsolute;
    UA_CRCL_TransSpeedRelativeDataType transSpeedRelative;
} UA_CRCL_SettingsStatusDataType;

#define UA_TYPES_CRCL_CRCL_SETTINGSSTATUSDATATYPE 126

/**
 * CRCLStatusDataType
 * ^^^^^^^^^^^^^^^^^^
 * Pose Status DataType */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    UA_CRCL_CommandStatusDataType commandStatus;
    UA_CRCL_JointStatusesDataType jointStatus;
    UA_CRCL_PoseStatusDataType poseStatus;
    UA_CRCL_GripperStatusDataType gripperStatus;
    UA_CRCL_SettingsStatusDataType settingsStatus;
    UA_CRCL_SensorStatusesDataType sensorStatuses;
} UA_CRCLStatusDataType;

#define UA_TYPES_CRCL_CRCLSTATUSDATATYPE 127

/**
 * CRCLCommandsUnionDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCLCommandsUnionDataType */
typedef enum {
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_NONE = 0,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_INITCANONCOMMAND = 1,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_ENDCANONCOMMAND = 2,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_MESSAGECOMMAND = 3,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_MOVETOCOMMAND = 4,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_MOVESCREWCOMMAND = 5,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_MOVETHROUGHTOCOMMAND = 6,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_DWELLCOMMAND = 7,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_ACTUATEJOINTSCOMMAND = 8,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_CONFIGUREJOINTREPORTSCOMMAND = 9,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_SETDEFAULTJOINTPOSITIONSTOLERANCESCOMMAND = 10,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_GETSTATUSCOMMAND = 11,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_CLOSETOOLCHANGERCOMMAND = 12,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_OPENTOOLCHANGERCOMMAND = 13,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_SETROBOTPARAMETERSCOMMAND = 14,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_SETENDEFFECTORPARAMETERSCOMMAND = 15,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_SETENDEFFECTORCOMMAND = 16,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_SETTRANSACCELCOMMAND = 17,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_SETTRANSSPEEDCOMMAND = 18,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_SETROTACCELCOMMAND = 19,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_SETROTSPEEDCOMMAND = 20,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_SETANGLEUNITSCOMMAND = 21,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_SETENDPOSETOLERANCECOMMAND = 22,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_SETFORCEUNITSCOMMAND = 23,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_SETINTERMEDIATEPOSETOLERANCECOMMAND = 24,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_SETLENGTHUNITSCOMMAND = 25,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_SETMOTIONCOORDINATIONCOMMAND = 26,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_SETTORQUEUNITSCOMMAND = 27,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_STOPMOTIONCOMMAND = 28,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_CONFIGURESTATUSREPORTCOMMAND = 29,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_ENABLESENSORCOMMAND = 30,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_DISABLESENSORCOMMAND = 31,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_ENABLEGRIPPERCOMMAND = 32,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_DISABLEGRIPPERCOMMAND = 33,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_ENABLEROBOTPARAMETERSTATUSCOMMAND = 34,
    UA_CRCLCOMMANDSUNIONDATATYPESWITCH_DISABLEROBOTPARAMETERSTATUSCOMMAND = 35,
    __UA_CRCLCOMMANDSUNIONDATATYPESWITCH_FORCE32BIT = 0x7fffffff
} UA_CRCLCommandsUnionDataTypeSwitch;
UA_STATIC_ASSERT(sizeof(UA_CRCLCommandsUnionDataTypeSwitch) == sizeof(UA_Int32), enum_must_be_32bit);

typedef struct {
    UA_CRCLCommandsUnionDataTypeSwitch switchField;
    union {
        UA_InitCanonDataType initCanonCommand;
        UA_EndCanonDataType endCanonCommand;
        UA_MessageDataType messageCommand;
        UA_MoveToDataType moveToCommand;
        UA_MoveScrewDataType moveScrewCommand;
        UA_MoveThroughToDataType moveThroughToCommand;
        UA_DwellDataType dwellCommand;
        UA_ActuateJointsDataType actuateJointsCommand;
        UA_ConfigureJointReportsDataType configureJointReportsCommand;
        UA_SetDefaultJointPositionsTolerancesDataType setDefaultJointPositionsTolerancesCommand;
        UA_GetStatusDataType getStatusCommand;
        UA_CloseToolChangerDataType closeToolChangerCommand;
        UA_OpenToolChangerDataType openToolChangerCommand;
        UA_SetRobotParametersDataType setRobotParametersCommand;
        UA_SetEndeffectorParametersDataType setEndeffectorParametersCommand;
        UA_SetEndeffectorDataType setEndeffectorCommand;
        UA_SetTransAccelDataType setTransAccelCommand;
        UA_SetTransSpeedDataType setTransSpeedCommand;
        UA_SetRotAccelDataType setRotAccelCommand;
        UA_SetRotSpeedDataType setRotSpeedCommand;
        UA_SetAngleUnitsDataType setAngleUnitsCommand;
        UA_SetEndPoseToleranceDataType setEndPoseToleranceCommand;
        UA_SetForceUnitsDataType setForceUnitsCommand;
        UA_SetIntermediatePoseToleranceDataType setIntermediatePoseToleranceCommand;
        UA_SetLengthUnitsDataType setLengthUnitsCommand;
        UA_SetMotionCoordinationDataType setMotionCoordinationCommand;
        UA_SetTorqueUnitsDataType setTorqueUnitsCommand;
        UA_StopMotionDataType stopMotionCommand;
        UA_ConfigureStatusReportDataType configureStatusReportCommand;
        UA_EnableSensorDataType enableSensorCommand;
        UA_DisableSensorDataType disableSensorCommand;
        UA_EnableGripperDataType enableGripperCommand;
        UA_DisableGripperDataType disableGripperCommand;
        UA_EnableRobotParameterStatusDataType enableRobotParameterStatusCommand;
        UA_DisableRobotParameterStatusDataType disableRobotParameterStatusCommand;
    } fields;
} UA_CRCLCommandsUnionDataType;

#define UA_TYPES_CRCL_CRCLCOMMANDSUNIONDATATYPE 128

/**
 * CRCLCommandsBufferDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCLProgramm */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    size_t crclCommandsSize;
    UA_CRCLCommandsUnionDataType *crclCommands;
} UA_CRCLCommandsBufferDataType;

#define UA_TYPES_CRCL_CRCLCOMMANDSBUFFERDATATYPE 129

/**
 * ActuateJointsParamsSetDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * Parameters of a ActuateJoints Command. */
typedef struct {
    UA_String name;
    UA_Boolean realTimeParameter;
    UA_NodeId realTimeParameterNodeID;
    size_t actuateJointSize;
    UA_CRCL_ActuateJointDataType *actuateJoint;
    UA_CRCL_JointPositionsTolerancesDataType jointTolerances;
} UA_ActuateJointsParamsSetDataType;

#define UA_TYPES_CRCL_ACTUATEJOINTSPARAMSSETDATATYPE 130

/**
 * CRCLCommandsParamsSetsUnionDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * CRCLCommandsParamsSetsUnionDataType */
typedef enum {
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_NONE = 0,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_INITCANONPARAMSSET = 1,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_ENDCANONPARAMSSET = 2,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_MESSAGEPARAMSSET = 3,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_MOVETOPARAMSSET = 4,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_MOVESCREWPARAMSSET = 5,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_MOVETHROUGHTOPARAMSSET = 6,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_DWELLPARAMSSET = 7,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_ACTUATEJOINTSPARAMSSET = 8,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_CONFIGUREJOINTREPORTSPARAMSSET = 9,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_SETDEFAULTJOINTPOSITIONSTOLERANCESPARAMSSET = 10,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_GETSTATUSPARAMSSET = 11,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_CLOSETOOLCHANGERPARAMSSET = 12,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_OPENTOOLCHANGERPARAMSSET = 13,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_SETROBOTPARAMETERSPARAMSSET = 14,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_SETENDEFFECTORPARAMETERSPARAMSSET = 15,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_SETENDEFFECTORPARAMSSET = 16,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_SETTRANSACCELPARAMSSET = 17,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_SETTRANSSPEEDPARAMSSET = 18,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_SETROTACCELPARAMSSET = 19,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_SETROTSPEEDPARAMSSET = 20,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_SETANGLEUNITSPARAMSSET = 21,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_SETENDPOSETOLERANCEPARAMSSET = 22,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_SETFORCEUNITSPARAMSSET = 23,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_SETINTERMEDIATEPOSETOLERANCEPARAMSSET = 24,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_SETLENGTHUNITSPARAMSSET = 25,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_SETMOTIONCOORDINATIONPARAMSSET = 26,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_SETTORQUEUNITSPARAMSSET = 27,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_STOPMOTIONPARAMSSET = 28,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_CONFIGURESTATUSREPORTPARAMSSET = 29,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_ENABLESENSORPARAMSSET = 30,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_DISABLESENSORPARAMSSET = 31,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_ENABLEGRIPPERPARAMSSET = 32,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_DISABLEGRIPPERPARAMSSET = 33,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_ENABLEROBOTPARAMETERSTATUSPARAMSSET = 34,
    UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_DISABLEROBOTPARAMETERSTATUSPARAMSSET = 35,
    __UA_CRCLCOMMANDSPARAMSSETSUNIONDATATYPESWITCH_FORCE32BIT = 0x7fffffff
} UA_CRCLCommandsParamsSetsUnionDataTypeSwitch;
UA_STATIC_ASSERT(sizeof(UA_CRCLCommandsParamsSetsUnionDataTypeSwitch) == sizeof(UA_Int32), enum_must_be_32bit);

typedef struct {
    UA_CRCLCommandsParamsSetsUnionDataTypeSwitch switchField;
    union {
        UA_InitCanonParamsSetDataType initCanonParamsSet;
        UA_EndCanonParamsSetDataType endCanonParamsSet;
        UA_MessageParamsSetDataType messageParamsSet;
        UA_MoveToParamsSetDataType moveToParamsSet;
        UA_MoveScrewParamsSetDataType moveScrewParamsSet;
        UA_MoveThroughToParamsSetDataType moveThroughToParamsSet;
        UA_DwellParamsSetDataType dwellParamsSet;
        UA_ActuateJointsParamsSetDataType actuateJointsParamsSet;
        UA_ConfigureJointReportsParamsSetDataType configureJointReportsParamsSet;
        UA_SetDefaultJointPositionsTolerancesParamsSetDataType setDefaultJointPositionsTolerancesParamsSet;
        UA_GetStatusParamsSetDataType getStatusParamsSet;
        UA_CloseToolChangerParamsSetDataType closeToolChangerParamsSet;
        UA_OpenToolChangerParamsSetDataType openToolChangerParamsSet;
        UA_SetRobotParametersParamsSetDataType setRobotParametersParamsSet;
        UA_SetEndeffectorParametersParamsSetDataType setEndeffectorParametersParamsSet;
        UA_SetEndeffectorParamsSetDataType setEndeffectorParamsSet;
        UA_SetTransAccelParamsSetDataType setTransAccelParamsSet;
        UA_SetTransSpeedParamsSetDataType setTransSpeedParamsSet;
        UA_SetRotAccelParamsSetDataType setRotAccelParamsSet;
        UA_SetRotSpeedParamsSetDataType setRotSpeedParamsSet;
        UA_SetAngleUnitsParamsSetDataType setAngleUnitsParamsSet;
        UA_SetEndPoseToleranceParamsSetDataType setEndPoseToleranceParamsSet;
        UA_SetForceUnitsParamsSetDataType setForceUnitsParamsSet;
        UA_SetIntermediatePoseToleranceParamsSetDataType setIntermediatePoseToleranceParamsSet;
        UA_SetLengthUnitsParamsSetDataType setLengthUnitsParamsSet;
        UA_SetMotionCoordinationParamsSetDataType setMotionCoordinationParamsSet;
        UA_SetTorqueUnitsParamsSetDataType setTorqueUnitsParamsSet;
        UA_StopMotionParamsSetDataType stopMotionParamsSet;
        UA_ConfigureStatusReportParamsSetDataType configureStatusReportParamsSet;
        UA_EnableSensorParamsSetDataType enableSensorParamsSet;
        UA_DisableSensorParamsSetDataType disableSensorParamsSet;
        UA_EnableGripperParamsSetDataType enableGripperParamsSet;
        UA_DisableGripperParamsSetDataType disableGripperParamsSet;
        UA_EnableRobotParameterStatusParamsSetDataType enableRobotParameterStatusParamsSet;
        UA_DisableRobotParameterStatusParamsSetDataType disableRobotParameterStatusParamsSet;
    } fields;
} UA_CRCLCommandsParamsSetsUnionDataType;

#define UA_TYPES_CRCL_CRCLCOMMANDSPARAMSSETSUNIONDATATYPE 131

/**
 * CRCLCommandsParamsSetsBufferDataType
 * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 * The array of CRCLCommandsParamsSets that allows instantiating CRCLCommands */
typedef struct {
    UA_UInt32 id;
    UA_String name;
    size_t crclCommandsParamsSetsSize;
    UA_CRCLCommandsParamsSetsUnionDataType *crclCommandsParamsSets;
} UA_CRCLCommandsParamsSetsBufferDataType;

#define UA_TYPES_CRCL_CRCLCOMMANDSPARAMSSETSBUFFERDATATYPE 132


_UA_END_DECLS

#endif /* TYPES_CRCL_GENERATED_H_ */
