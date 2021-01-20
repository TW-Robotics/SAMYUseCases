#ifndef ROBOT_H
#define ROBOT_H

#include <open62541/plugin/log_stdout.h>
#include <open62541/server.h>
#include <open62541/server_config_default.h>
#ifdef USE_CPP
#include <iostream>
#endif // USE_CPP

#ifdef USE_PYTHON
#include <boost/python.hpp>
#include <boost/python/class.hpp>
#include <boost/python/implicit.hpp>
#include <boost/python/module.hpp>
#include <Python.h>

class Robot
{
public:
    Robot(std::string pathToPythonRobot_, std::string address_);
    void initRobot();
    boost::python::object pythonRobot;
    boost::python::object pythonPlugin;
    UA_Boolean online;
    UA_Boolean* running;

private:
    std::string address;
    std::string pathToPythonRobot;
};

#else

#ifdef USE_CPP

#include <boost/asio.hpp>
#include <future>

class RobotBase
{
public:
    RobotBase();
    ~RobotBase() = default;
    UA_Boolean online;
    UA_Boolean* running;
private:
    UA_String address;
};

// Put here your robot specific Code
class Robot : public RobotBase{
public:
    Robot();
    ~Robot() = default;
    bool moveExtruder(double position_);
    void setSpeed(double speed_); // for extrusion speed
    void setTemperature(int temperature_); // to set the temperature of the nozzle
    void setCooling(int cool_); // to set the speed for the part cooling fan
    int getCooling();
    int getTemperature();
    bool waitForExtruder(); // waits for the arduino to finish the command
    void sendString(); // generates a string from the private
                       // variables and sends it to the arduino.
                       // example ">M#F020.00#T200.00#ES040.00#<" F:Fan T:Temperature ES:Speed
    std::string recvString(); // To get data from the Extruder
    void disconnectArduino(); // closes the connection to Arduino

private:
    int cooling;
    int temperature;
    double speed;
    double position;
    int boud_rate;
    boost::asio::io_service io;
    boost::asio::serial_port serial;
};

// end of robot specific Code

#endif // USE_CPP

#endif // USE_PYTHON

#endif // ROBOT_H
