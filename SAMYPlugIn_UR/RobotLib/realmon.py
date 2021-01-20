"""@package docstring
Python library to control an UR robot through its TCP/IP interface.

"""

import socket
import logging
import sys


class RealTimeMonitor(object):
    """ This class connects to the
        Primary Monitor interface of a UR Robot.
    """

    def __init__(self, host):
        """ Here the connection gets configured and established.
            First a socket is created and then the connection to the robot is started.
            Parameters:
                host: The IP address of the Robot
        """
        self.logger = logging.getLogger("sec_mon")
        self.host = host
        self.port = 30003
        self.real_socket = None

        try:
            self.real_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
            self.real_socket.connect((self.host, self.port))
        except:
            self.logger.error("No connection to Robot!")
            sys.exit()

    def send(self, msg):
        """ It takes a string and sends it to the Primary Monitor interface
            of the UR Robot.
            Parameters:
            msg: The string that is send to the Robot.
        """
        msg = msg.encode()
        try:
            self.real_socket.send(msg)
        except:
            print("No connection to Robot(RealMon)")

    def close(self):
        """ It closes the connection to the Primary Monitor interface.
        """
        self.real_socket.close()
