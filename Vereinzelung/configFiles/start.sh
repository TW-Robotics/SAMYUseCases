#!/bin/bash
# Loop throug all Skill folders and check if there is a .cpp file and if yes run cmake

cd /usr/src/samy/configFiles/Skills/PlaceSkill/ && cd build && cmake .. && make -j7 &&  mv libplaceFunction.so.1.0 ../libplaceFunction.so && \
cd /usr/src/samy/configFiles/Skills/PickSkill/ && cd build && cmake .. && make -j7 &&  mv libpickFunction.so.1.0 ../libpickFunction.so && \
cd /usr/src/samy/configFiles/Skills/MoveToSkill/ && cd build && cmake .. && make -j7 &&  mv libmoveToFunction.so.1.0 ../libmoveToFunction.so && \
cd /usr/src/samy/configFiles/Skills/PickAndPlaceSkill/ && cd build && cmake .. && make -j7 &&  mv libpickAndPlaceFunction.so.1.0 ../libpickAndPlaceFunction.so && \
cd /usr/src/samy/configFiles/Skills/SetGripperSkill/ && cd build && cmake .. && make -j7 &&  mv libsetGripperFunction.so.1.0 ../libsetGripperFunction.so && \
cd /usr/src/samy/configFiles/Skills/CheckStorageSkill/ && cd build && cmake .. && make -j7 &&  mv libcheckStorageFunction.so.1.0 ../libcheckStorageFunction.so && \
cd /usr/src/samy/configFiles/Skills/MoveCylinderSkill/ && cd build && cmake .. && make -j7 &&  mv libmoveCylinderFunction.so.1.0 ../libmoveCylinderFunction.so && \
cd /usr/src/samy/configFiles/Skills/GetPoseSkill/ && cd build && cmake .. && make -j7 &&  mv libgetPoseFunction.so.1.0 ../libgetPoseFunction.so && \
/usr/src/samy/build/SAMYCore /usr/src/samy/configFiles/SAMYCoreConfig.yaml