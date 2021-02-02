"""@package docstring
Python library to control an UR robot through its TCP/IP interfaces
The library uses the RealTimeMonitor, the Dashboard interface and
the RealTimeDataExchange interface.

"""

from RobotLib import realmon
from RobotLib import exchangeData
from RobotLib import dashboard_server
from threading import Thread, Lock
import time
import logging
import math


class RobotSettings:

    def __init__(self):
        self.max_speed = 5.0 # m/s
        self.max_accel = 2.0  # m/s²
        self.max_rot_speed = 3.14
        self.max_rot_accel = 3.14

        self.lengthUnit = "meter"
        self.angleUnit = "radian"
        self.forceUnit = "newton"
        self.rotSpeed = 2.0
        self.rotAccel = 0.3
        self.transSpeed = 0.05
        self.transAccel = 0.2
        self.radius = 0.0
        self.workobject = [[0, 0.4, 0],[math.pi, 0, 0]]


class Robot(object):
    # This class represents the robot.

    def __init__(self, host):
        # Three objects are created. One for the Secondary Monitor interface,
        # one for the RTDE interface and one for the Dashboard interface
        # create a logger for the robot object
        self.logger = logging.getLogger(__name__)
        self.logger.setLevel(logging.INFO)
        fh = logging.StreamHandler()
        fh.setFormatter(logging.Formatter("%(levelname)s %(filename)s - %(message)s"))
        self.logger.addHandler(fh)

        self.host = host

        # create the socket connections to the robot
        self.real_mon = realmon.RealTimeMonitor(self.host)
        self.rtde = exchangeData.ExchangeData(self.host)
        logging.getLogger("rtde").setLevel(logging.WARNING)
        self.dash = dashboard_server.Dashboard(self.host)

        self.robot_settings = RobotSettings()

        self.logger.info("Connected")

    def send_command(self, line, command_id):
        self.real_mon.send(line)
        #self.send_status(self, command_id)

    def send_status(self, command_id):
        Thread(target=self.is_ready, args=(command_id,))

    def is_ready(self, command_id):
        # Waits for the robot to finish a command
        time.sleep(0.1)  # Wait a bit
        while 1:
            state = self.get_state()
            if state == "RUNNING": # Check if the robot State is still running
                time.sleep(0.16) # Wait before checking again
            else:
                pass
                # send status to publisher
        # When robot is not RUNNING anymore the command is finished.

    def wait(self):
        # Waits for the robot to finish a command
        time.sleep(0.1)  # Wait a bit
        while 1:
            state = self.get_state()
            if state == "RUNNING": # Check if the robot State is still running
                time.sleep(0.16) # Wait before checking again
            else:
                return "READY"
                # send status to publisher
        # When robot is not RUNNING anymore the command is finished.

    def close(self):
        # This function closes the connection to the Secondary Monitor
        # and to the RTDE Interface.

        self.stop = True  # Set the stop variable to stop the run_que thread
        self.rtde.close()  # Stop the connection to the rtde interface
        self.dash.close()  # Stop the connection to the dashboard interface
        self.real_mon.close()  # Stop the connection to the real mon interface

    def shutdown(self):
        # close the connection to the robot and turn it off
        #
        self.stop = True  # Set the stop variable to stop the run_que thread
        self.rtde.close()  # Stop the connection to the rtde interface
        self.real_mon.close()  # Stop the connection to the real mon interface
        self.dash.shutdown()  # Send the shutdown command to the robot
        # self.dash.close()

    def get_state(self):
        """ This function reads the runtime state of the robot.
            - STOPPING
            - STOPPED
            - RUNNING
            - PAUSING
            - PAUSED
            - RESUMING
            - RETRACTING
        """
        runtime_state = self.rtde.get_runtime_state()
        return runtime_state

    # =========================================================
    #                   Move commands
    # =========================================================

    def adjust_pose(self, pose):
        pose_new = []
        pose_new.append(pose[0] + self.robot_settings.workobject[0][0])
        pose_new.append(pose[1] + self.robot_settings.workobject[0][1])
        pose_new.append(pose[2] + self.robot_settings.workobject[0][2])
        pose_new.append(pose[3] + self.robot_settings.workobject[1][0])
        pose_new.append(pose[4] + self.robot_settings.workobject[1][1])
        pose_new.append(pose[5] + self.robot_settings.workobject[1][2])
        return pose_new

    def movel(self, command_id, pose: list, a, v, r=0):
        # The movel command moves the robot linear to the given pose.
        #    Input parameters:
        #        pose: The pose the robot moves to.
        #        a: constant acceleration of the TCP
        #        v: constant speed of the TCP
        #        r: radius within the robot stays when another move command follows.

        # adjust pose to workobject
        pose_new = self.adjust_pose(pose)

        line = "movel(p[{},{},{},{},{},{}], a={}, v={}, r={})\n".format(*pose_new, a, v, r)
        print("sending Movel")
        self.send_command(line, command_id)

    def movec(self, command_id, pose_via, pose_to, a, v, r=0, mode=0):
        # Move Circular: Move to position (circular in tool-space)
        #   TCP moves on the circular arc segment from current pose, through
        #   pose_via to pose_to. Accelerates to and moves with constant tool
        #   speed v. Use the mode parameter to define the orientation
        #   interpolation.
        #   Input parameter:
        #       pose_via
        #       pose_to
        #       a: constant acceleration of the TCP
        #       v: constant speed of the TCP
        # adjust pose to workobject
        pose_via_new = self.adjust_pose(pose_via)
        # adjust pose to workobject
        pose_to_new = self.adjust_pose(pose_to)

        data = [a, v, r, mode]
        line = "movec(p[{},{},{},{},{},{}], p[{},{},{},{},{},{}], a={}, v={}, r={}, mode={})\n".format(*pose_via_new,
                                                                                                       *pose_to_new, *data)
        self.send_command(line, command_id)

    def movej(self, command_id, q, a, v, t=0, r=0):
        # Move to position (linear in joint-space)
        #    Input Parameters:
        #        q: joint positions (q can also be specified as a pose, then
        #        inverse kinematics is used to calculate the corresponding
        #        joint positions)
        #        a: joint acceleration of leading axis [rad/s^2]
        #        v: joint speed of leading axis [rad/s]
        #        t: time [S]
        #        r: blend radius [m]

        line = "movej([{},{},{},{},{},{}], a={}, v={}, t={}, r={})\n".format(*q, a, v, t, r)
        self.send_command(line, command_id)

    def movej_p(self, command_id, pose, a, v, t=0, r=0):
        """ Move to position (linear in joint-space)
            Input Parameters:
                q: joint positions (q can also be specified as a pose, then
                inverse kinematics is used to calculate the corresponding
                joint positions)
                a: joint acceleration of leading axis [rad/s^2]
                v: joint speed of leading axis [rad/s]
                t: time [S]
                r: blend radius [m]
        """
        # adjust pose to workobject
        pose_new = self.adjust_pose(pose)
        line = "movej(p[{},{},{},{},{},{}], a={}, v={}, t={}, r={})\n".format(*pose_new, a, v, t, r)
        self.send_command( line, command_id)

    def movep(self, command_id, pose, a, v, r=0):
        """ Move Process
            Parameters
                pose: target pose (pose can also be specified as joint
                    positions, then forward kinematics is used to
                    calculate the corresponding pose)
                a: tool acceleration [m/s^2]
                v: tool speed [m/s]
                r: blend radius [m]
        """
        # adjust pose to workobject
        pose_new = self.adjust_pose(pose)
        line = "movep(p[{},{},{},{},{},{}], a={}, v={}, r={})\n".format(*pose_new, a, v, r)
        self.send_command(line, command_id)

    def servoc(self, command_id, pose, a, v, r=0):
        """ Servo Circular
            Parameters
                pose: target pose (pose can also be specified as joint
                    positions, then forward kinematics is used to
                    calculate the corresponding pose)
                a: tool acceleration [m/s^2]
                v: tool speed [m/s]
                r: blend radius (of target pose) [m]
        """
        # adjust pose to workobject
        pose_new = self.adjust_pose(pose)
        line = "servoc(p[{},{},{},{},{},{}], a={}, v={}, r={})\n".format(*pose_new, a, v, r)
        self.send_command(line, command_id)

    def dwell(self, command_id, dwell_time):
        """ Sleep for an amount of time.
            Input parameters:
                time: time the robot waits
        """
        line = "sleep({})\n".format(dwell_time)
        self.send_command(line, command_id)

    def stop_robot(self):
        self.dash.stop_program()

    # =========================================================
    #                   Data write commands
    # =========================================================
    def set_workobject(self, x, y, z, roll, pitch, yaw):
        self.robot_settings.workobject = [[x, y, z],[roll, pitch, yaw]]

    def set_tcp(self, command_id, tcp):
        """ set robot flange to tool tip transformation
            Input parameters:
                tcp: The pose of the tcp measured from the robot flange.
        """
        line = "set_tcp(p[{},{},{},{},{},{}])\n".format(*tcp)
        self.send_command(line, command_id)

    def set_analog_output(self, output, val):
        """ Write analog output.
            Input parameter:
                int output: Number of analog output (0 or 1)
                double val: Range from 0 to 1 corresponds 0 to 24V
        """
        data = self.rtde.send_object
        data.__dict__["standard_analog_output_%i" % output] = val
        self.rtde.con.send(data)

    def set_payload(self, command_id, m, cog):
        """ Set Payload mass and center of gravity. The va
            Input Parameters:
                m: mass in kilograms
                cog: Center of Gravity, a vector [CoGx, CoGy, CoGz]
                    specifying the displacement (in meters) from the
                    tool mount.
        """
        line = "set_payload({}, [{},{},{}])\n".format(m, *cog)
        self.send_command(line, command_id)

    def popup(self, msg):
        self.dash.popup(msg)

    # =========================================================
    #                   Data read commands
    # =========================================================

    # def get_data(self):
    #    """ This function reads one data object from the RTDE interface.
    #        What data is included depends on the configuration of the RTDE.
    #    """
    #    data = self.rtde._read()
    #    print(data)

    def get_actual_tcp(self):
        """ This function reads the actual TCP pose form the robot.
            It uses the RTDE interface.
            The pose refers to the base frame of the robot.
        """
        pose = self.rtde.get_actual_tcp()
        # adjust pose to workobject
        pose_new = []
        pose_new.append(pose[0] - self.robot_settings.workobject[0][0])
        pose_new.append(pose[1] - self.robot_settings.workobject[0][1])
        pose_new.append(pose[2] - self.robot_settings.workobject[0][2])
        pose_new.append(pose[3] - self.robot_settings.workobject[1][0])
        pose_new.append(pose[4] - self.robot_settings.workobject[1][1])
        pose_new.append(pose[5] - self.robot_settings.workobject[1][2])
        return pose_new

    def get_target_q(self):
        """ Gets the Joints angles for the targeted position.
        """
        return self.rtde.get_target_q()

    def get_actual_q(self):
        """ Gets the Joints angles for the actual position.
        """
        return self.rtde.get_actual_q()


    # =========================================================
    #                   Robotiq commands
    # =========================================================

    def activate_gripper(self, command_id, num=1):
        """ Activates the RobotIQ gripper. This function
            must be called before any other gripper command.
            Input parameter:
                num: Number of the gripper (1-4)
        """
        if 1 <= num <= 4:
            line = "rq_activate_and_wait({})\n".format(num)
            self.send_command(line, command_id)
        else:
            print("Gripper number must be between 1-4")

    def holds_object(self, command_id):
        time.sleep(7)
        bits = self.rtde.get_digital_output_bits()
        if bits & 16 == 16:
            print("Gripper is holding an object")
            return True
        else:
            print("Gripper is empty")
            return False

        # print("{0:b}".format(bits))

    def close_gripper(self, command_id):
        """ Moves the gripper to its fully closed position.
            Input parameter:
                num: Number of the gripper (1-4)
        """
        # if 1 <= num <= 4:
        line = "set_digital_out(3, True)\n"
        line2 = "sleep(6)\n"
        # line = "rq_close_and_wait({})\n".format(num)
        self.send_command(line, command_id)
        self.send_command(line2, command_id)
        # else:
        #    print("Gripper number must be between 1-4")

    def open_gripper(self, command_id):
        """ Moves the gripper to its fully opened position.
            Input parameter:
                num: Number of the gripper (1-4)
        """

        # line = "rq_open_and_wait({})\n".format(num)
        line = "set_digital_out(2, True)\n"
        line2 = "sleep(6)\n"
        self.send_command(line, command_id)
        self.send_command(line2, command_id)

    def move_gripper(self, command_id, position, num=1):
        """ Moves the gripper to the given position.
            Input parameter:
                position: Position the of the gripper in [mm]
                num: Number of the gripper (1-4)
        """
        # if 1 <= num <= 4:
        line = "rq_move_and_wait_mm({},{})\n".format(position, num)
        self.send_command(line, command_id)
        # else:
        #    print("Gripper number must be between 1-4")

    def set_gripper_force(self, command_id, force, num=1):
        """ Sets the gripping force.
            Input parameters:
                force: Value between 0 and 100. 0 = minimal force, 100 = maximal force.
                num: Number of the gripper (1-4)
        """
        if 1 <= num <= 4:
            line = "rq_set_force_norm({},{})\n".format(force, num)
            self.send_command(line, command_id)
        else:
            print("Gripper number must be between 1-4")

    def set_gripper_speed(self, command_id, speed, num=1):
        """ Sets the gripping force.
            Input parameters:
                force: Value between 0 and 100. 0 = minimal force, 100 = maximal force.
                num: Number of the gripper (1-4)
        """
        if 1 <= num <= 4:
            line = "rq_set_speed_norm({},{})\n".format(speed, num)
            self.send_command(line, command_id)
        else:
            print("Gripper number must be between 1-4")
