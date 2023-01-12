#!/bin/bash 

cd /usr/src/samy/configFiles/Skills/GripperAttach/ && make -p build && cd build && cmake .. && make -j$((`nproc`-2)) &&  mv libgripperAttach.so.1.0 ../libgripperAttach.so && \
cd /usr/src/samy/configFiles/Skills/GripperApproach/ && make -p build && cd build && cmake .. && make -j$((`nproc`-2)) &&  mv libgripperApproach.so.1.0 ../libgripperApproach.so && \
cd /usr/src/samy/configFiles/Skills/GetPose/ && make -p build && cd build && cmake .. && make -j$((`nproc`-2)) &&  mv libgetPose.so.1.0 ../libgetPose.so && \
cd /usr/src/samy/configFiles/Skills/MoveSkill/ && make -p build && cd build && cmake .. && make -j$((`nproc`-2)) &&  mv libmoveSkill.so.1.0 ../libmoveSkill.so && \
cd /usr/src/samy/configFiles/Skills/PickSkill/ && make -p build && cd build && cmake .. && make -j$((`nproc`-2)) &&  mv libpickSkill.so.1.0 ../libpickSkill.so && \
/usr/src/samy/build/SAMYCore /usr/src/samy/configFiles/SAMYCoreConfig.yaml