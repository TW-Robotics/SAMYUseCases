#include <Robot.h>

#ifdef USE_PYTHON

#include <iostream>

Robot::Robot(std::string pathToPythonRobot_, std::string address_):
    pathToPythonRobot(pathToPythonRobot_),
    address(address_)
{
    // Allow Python to load modules from the current directory.
    setenv("PYTHONPATH", pathToPythonRobot.c_str(), 1);
    // Initialize Python.
    Py_Initialize();
}

void Robot::initRobot()
{
    namespace python = boost::python;
    try
    {
        //std::cout << "Import Python module from " << pathToPythonRobot << std::endl;
        python::object robot_module = python::import("RobotLib");
        // Create an instance of Robot class as python object
        std::cout << "loading the robot object" << std::endl;
        python::object robot_object = robot_module.attr("Robot")(address);
        python::object plugin_object = python::import("plugin");
        std::cout << "Robot Object created" << std::endl;
        pythonRobot = robot_object;
        pythonPlugin = plugin_object;
    }
    catch (const boost::python::error_already_set&)
    {
        PyErr_Print();
        python::object empty;
        std::cout << "RobotObject is empty" << std::endl;
        pythonRobot = empty;
    }
}
#else
#ifdef USE_CPP

RobotBase::RobotBase(){}

Robot::Robot():
    cooling(0.0),
    temperature(0.0),
    speed(1.0),
    position(0.0),
    boud_rate(230400),
    io(),
    serial(io, "/dev/ttyACM0")
{
    // Start Serial connection with the arduino. TODO error handling
    serial.set_option(boost::asio::serial_port_base::baud_rate(boud_rate));
    usleep(3000000); // wait for the arduino to boot. 3s
    std::cout << "Connected to Arduino" << std::endl;
}

void Robot::sendString()
{
    char msg[40];
    snprintf(msg, sizeof(msg), ">M#F%03d#T%03d#ES%06.2f#EL%06.2f<",
                             cooling, temperature, speed, position);
    boost::asio::write(serial,boost::asio::buffer(msg,40));
    std::cout << msg << std::endl;
    std::cout << "String sended"<< std::endl;
    usleep(1000);
}

bool read_char(boost::asio::serial_port* serial){
    char c;//[20];
    for(;;){
        boost::asio::read(*serial, boost::asio::buffer(&c,1));
        if (c == 'D') break;
    }
    return true;
}

bool Robot::waitForExtruder(){
    std::future<bool> got_answer = std::async(read_char, &serial);

    std::cout << "Wait for answer" << std::endl;
    std::chrono::seconds span (40); // timeout for the arduino to send an answer
    //std::chrono::system_clock::time_point time = std::chrono::system_clock::now() + span;
    std::future_status status = got_answer.wait_for(span);
    if (status == std::future_status::timeout) return false;
    return true;
}

bool Robot::moveExtruder(double position_){
    position = position_;
    sendString();
    bool wait_status = waitForExtruder();
    std::cout << wait_status << std::endl;
    return true;
}

void Robot::setSpeed(double speed_){
    speed = speed_;
}

void Robot::setTemperature(int temp_){
    temperature = temp_;
    std::cout << "Temperature: " << std::to_string(temperature) << std::endl;
}

void Robot::setCooling(int cool_){
    cooling = cool_;
    std::cout << "FanSpeed: " << std::to_string(cooling) << std::endl;
}

int Robot::getCooling(){
    return cooling;
}

int Robot::getTemperature(){
    return temperature;
}

#else

#endif // USE_CPP

#endif // USE_PYTHON

