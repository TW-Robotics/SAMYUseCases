#!/usr/bin/python3
import yaml
import jinja2
from jinja2 import Template
import os


def create_startsh(foldername):
	
	template="""
cd /usr/src/samy/configFiles/Skills/{{data}}/ && make -p build && cd build && cmake .. && make -j$((`nproc`-2)) &&  mv lib{{name}}.so.1.0 ../lib{{name}}.so && """
	out = Template(template)
	filepath = "../start.sh"
	try:
		start_file = open(filepath,"a")
		start_file.write(out.render(data = foldername[2:], name = foldername[2].lower() + foldername[3:]))
		start_file.write("\\")
		start_file.close
	except:
		print("You do not have permission to write in this folder!")

def create_cmake(foldername):
	template = """
# Always set the cmake min version.
cmake_minimum_required(VERSION 3.0)

set (PROJECT_VERSION "1.0")
set (LIBRARY_NAME "{{SAMYSkillConfig.SkillName[0].lower() + SAMYSkillConfig.SkillName[1:]}}")

set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

#set(CMAKE_RUNTIME_OUTPUT_DIRECTORY ${PROJECT_SOURCE_DIR})
#set(CMAKE_LIBRARY_OUTPUT_DIRECTORY ${PROJECT_SOURCE_DIR})

add_definitions(-w)
# Set the variable PROJ_NAME to whatever your library's name is, PROJECT_VERSION should be a version string like "0.1"
project({{foldername}} VERSION ${PROJECT_VERSION})

find_package(open62541 1.2 REQUIRED COMPONENTS FullNamespace)

# Create our library target
add_library(${LIBRARY_NAME} SHARED)

include_directories( ${CMAKE_CURRENT_SOURCE_DIR} )
# The following is generated at compile time of the SAMYCore in the root SAMYCore project folder. Allows including all the used headers by the SAMYCore_API, so we can use all the types, etc.
include("../../../SAMYCore_Library_includes.cmake")
include_SAMYCore_Library_headers()


target_sources(${LIBRARY_NAME}
  PUBLIC
  ${CMAKE_CURRENT_SOURCE_DIR}/{{SAMYSkillConfig.EntryFile}}
)

# This will name your output .so files "libsomething.1.0" which is pretty useful
set_target_properties(${LIBRARY_NAME}
    PROPERTIES
    PREFIX "lib" # It will add lib as prefix to the library
    VERSION ${PROJECT_VERSION}
    SOVERSION ${PROJECT_VERSION}
)

# Let's set compiler-specific flags
if (${CMAKE_CXX_COMPILER_ID} STREQUAL "GNU")
    # G++
    target_compile_options(${LIBRARY_NAME} PRIVATE -Wall -Wextra)
elseif(${CMAKE_CXX_COMPILER_ID} STREQUAL "MSVC")
    # MSVC
    target_compile_options(${LIBRARY_NAME} PRIVATE /EHsc /MTd /W2 /c)
    # Set the DLLEXPORT variable to export symbols
    target_compile_definitions(${LIBRARY_NAME} PRIVATE WIN_EXPORT)
endif()


target_link_libraries( ${LIBRARY_NAME} "${CMAKE_SOURCE_DIR}/../../../build/SAMYCore_Library.so.2.0")"""

	out = Template(template)
	filepath = "./" + str(foldername) + "/CMakeLists.txt"
	try:
		h_file = open(filepath, "w")
		h_file.write(out.render(yamldata))
		h_file.close
		print("created CMakeLists.txt file in " + foldername + " folder")
	except:
		print("You do not have permission to write in this folder!")


def create_h(foldername):
	
	template = """#pragma once 
#include <cstdint>
#include <dylib.h>
#include <skillsScriptingAPI.h>

extern "C" {

	void {{ SAMYSkillConfig.EntryFunction }}({% for x in SAMYSkillConfig.Parameters -%}{% if x.DataType[:2] != 'UA' %}UA_{% endif %}{{x.DataType}} const * const {{x.Name}}{% if not loop.last %},
	        {% endif %}{% endfor %});
    
}"""
	out = Template(template)
	filepath = "./" + str(foldername) + "/" + cpp_filename[:-4] + ".h"
	try:
		h_file = open(filepath, "w")
		h_file.write(out.render(yamldata))
		h_file.close
		print("created " + cpp_filename[:-4] +".h file")
	except:
		print("You do not have permission to write in this folder!")


def create_cpp(foldername):
	
	template = """#include <{{ SAMYSkillConfig.EntryFile[:-4] }}.h>
#include <skillsScriptingAPI.h>
#include <functional>
#include <iostream>

extern "C"{ // This is important, since avoid name mangling of the symbols, so the SAMYCore can find the correct chunck of compiled assembly code
	/* The parameters that receives the function are the parameters exposed in the skill parametersSet of the SAMYCore. 
	When you click "Start" method of the matching skill, the values are read and passed as arguments of this function, and this function 
	is then executed from a thread.
	At the moment, arguments has to be constant pointers to constant data, aka TypeName const * const parameterName 
	(e.g. UA_UInt32 const * const param1). T
	his is due to the fact that libffi has problems handing unions and I cannot pass them by value correctly in a portable way. 
	I will try to fix this but I am not sure is possible.
	What you should do is just at the very beggining of the skill copy them into a value and then doing with them whatever you want. E.g.:

		void testFunction2( UA_UInt32 const * const param1, UA_UInt32 const * const param2 ){
		UA_UInt32 param1_v = *param1; // You can do whatevery you want with param1_v now
		UA_UInt32 param2_v = *param2; // You can do whatevery you want with param2_v now

    I am planning to write a compiler-preprocessor based on Clang for automating these stuff so you can write code without these artifacts, 
	but for the moment should be fine like this.
	This file is created automatically through the createStructure.py scrpt.
	*/
	void {{ SAMYSkillConfig.EntryFunction }}({% for x in SAMYSkillConfig.Parameters -%}{% if x.DataType[:2] != 'UA' %}UA_{% endif %}{{x.DataType}} const * const {{x.Name}}{% if not loop.last %}, {% endif %}{% endfor %}){
			
		// Copy the parameter in local variable
		{% for x in SAMYSkillConfig.Parameters -%}
		{% if x.DataType[:2] != 'UA' %}UA_{% endif %}{{x.DataType}} {{x.Name}}_local = *{{x.Name}};
		{% endfor %}	

		// Create commands vector
		std::vector<UA_CRCLCommandsParamsSetsUnionDataType> commands;


		//### WRITE YOU CODE HERE ###//


		setCommandsBuffer( commands ); /* Sets the buffer of commands to be executed by the robot to be the previously created vector 
		of commands "commands". It does not send them yet nor modifies the CommandsBuffer variable in the SAMYCore. 
		It sets the value in the internal class representing the robot 
		(this way commands can be accumulated without requesting yet the execution). */
		sendCommandsAndWait(); /*Writes the values currently stored for the robot in the CommandsBuffer node of the robot in the SAMYCore, 
		sets the node CommandStateBuffer to value PROCESSING_PENDING, and waits until the value of CommandStateBuffer is changed 
		(usually by the SAMYPlugin) either to PROCESSING_FAILED or to AWAITING. */
		}
}"""
	out = Template(template)
	#print(out.render(yamldata))
	filepath = "./" + str(foldername) + "/" + cpp_filename
	try:
		cpp_file = open(filepath, "x")
		cpp_file.write(out.render(yamldata))
		cpp_file.close
		print("created " + cpp_filename +" file")
	except:
		print("You do not have permission to write in this folder!")

if __name__ == "__main__":
	
	cpp_filename = None
	subfolders = [ f.path for f in os.scandir(".") if f.is_dir() ]
	if not subfolders:
		print("No Subfolders found in this directory!")
	else:
		for f in subfolders:
			try:
				stream = open(f+'/SkillConfig.yaml', 'r')
			except:
				print("No Yaml file found in Subfolder" + f + "! Stopping...")
				break
			yamldata = yaml.safe_load(stream)
			yamldata['foldername']=f[2:]
			cpp_filename = yamldata["SAMYSkillConfig"]["EntryFile"]
			if cpp_filename[:-4] != f[2:]:
			    print("Warning: Folder " + f + " and C++ file " + cpp_filename + " do NOT have the same naming scheme!")
			create_h(f)
			create_cmake(f)
			cpp_path = "./" + str(f) + "/" + cpp_filename
			if os.path.exists(cpp_path):
				print("C++ file is already existing in Folder " + f + " ! No changes made!")
			else:
				create_cpp(f)
				stream.close()
		start_file = open("../start.sh","w")
		start_file.write("#!/bin/bash \n")
		start_file.close()
		for f in subfolders:
			cmake_path = str(f) + "/CMakeLists.txt"
			if os.path.exists(cmake_path):
				create_startsh(f)
			else:
				print("Folder " + f + " ignored! No CMakeLists.txt file found!")
			build_folder_path = str(f) + "/build"
			if os.path.exists(build_folder_path):
				print("Folder " + f + "/build has been found. Skipping")
			else:
				os.mkdir(build_folder_path)
				print("Directory: " + f + "/build created!")
		start_file = open("../start.sh","a")
		start_file.write("\n/usr/src/samy/build/SAMYCore /usr/src/samy/configFiles/SAMYCoreConfig.yaml")
		start_file.close()
		print("start.sh file in Folder ../ created")
	print("Good Bye! ...")
