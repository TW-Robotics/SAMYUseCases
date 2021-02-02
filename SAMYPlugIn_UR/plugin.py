from CRCLLib import crcl
from TransformLib import transform
import numpy


class RobotUnits():
    def __init__(self):
        # self.orientation = "Quaternion" Unterschiedliche anzahl an parametern selbst konvertieren
        self.referencePoint = "RobotBase"
        self.lengthUnit = "mm"
        self.speedUnit = "mm/s"
        self.accelUnit = "mm/s^2"


def set_length_unit(robot, command_id, unit):
    robot.lengthUnit = unit
    # send command status Done


def set_angle_units(robot, command_id, unit):
    robot.angleUnit = unit


def set_endeffector(robot, setting):
    if setting:
        robot.activate_gripper(robot)


def set_trans_speed(robot, transSpeed):
    pass


def set_trans_accel(robot, transAccel):
    pass


def set_workobject(robot, workobject_x, workobject_y, workobject_z,
                   workobject_xAxis_i, workobject_xAxis_j, workobject_xAxis_k,
                   workobject_zAxis_i, workobject_zAxis_j, workobject_zAxis_k):
    xaxis = numpy.array([workobject_xAxis_i, workobject_xAxis_j, workobject_xAxis_k])
    zaxis = numpy.array([workobject_zAxis_i, workobject_zAxis_j, workobject_zAxis_k])
    yaxis = numpy.cross(zaxis, xaxis)
    matrix = numpy.matrix([xaxis, yaxis, zaxis])
    euler = transform.matrix_to_euler(matrix, "sxyz")
    robot.robot_settings.workobject = ((workobject_x, workobject_y, workobject_z), euler)


# new version with all datafields as seperate parameters
def moveto(robot, commandID, moveStraight, endPosition_point_x, endPosition_point_y, endPosition_point_z,
            endPosition_xAxis_i, endPosition_xAxis_j, endPosition_xAxis_k,
            endPosition_zAxis_i, endPosition_zAxis_j, endPosition_zAxis_k):
    crcl_point = crcl.PointType(endPosition_point_x, endPosition_point_y, endPosition_point_z)
    crcl_u = crcl.VectorType(endPosition_xAxis_i, endPosition_xAxis_j, endPosition_xAxis_k)
    crcl_v = crcl.VectorType(endPosition_zAxis_i, endPosition_zAxis_j, endPosition_zAxis_k)
    pose_type = crcl.PoseType(crcl_point, crcl_u, crcl_v)
    pose = transform.get_pose_euler(pose_type)
    str_pose = str(pose)
    if moveStraight:
        robot.movel(commandID, pose, robot.robot_settings.transAccel, robot.robot_settings.transSpeed, 0)
    else:
        robot.movej_p(robot, commandID, pose, robot.robot_settings.rotAccel, robot.robot_settings.rotSpeed, 0, 0)
    robot.wait()
    print("Command with ID: " + str(commandID) + " is ready.")
    return str_pose

# old version with full struck as parameter
def movethroughto(robot, command_id, move_straight, waypoints, num_positions):
    x = 1
    if move_straight:
        for waypoint in waypoints:
            pose = transform.get_pose_euler(waypoint)
            if x == num_positions:
                robot.rob.movel(command_id, pose, robot.transAccel, robot.transSpeed, 0)
            else:
                robot.rob.movel(command_id, pose, robot.robot_settings.transAccel, robot.robot_settings.transSpeed, robot.robot_settings.radius)
            x += 1
    else:
        for waypoint in waypoints:
            pose = transform.get_pose_euler(waypoint)
            if x == num_positions:
                robot.rob.movej_p(command_id, pose, robot.transAccel, robot.transSpeed, 0, 0)
            else:
                robot.rob.movej_p(command_id, pose, robot.robot_settings.transAccel, robot.robot_settings.transSpeed, 0, robot.robot_settings.radius)
            x += 1
