#!/bin/bash
# Loop throug all Skill folders and check if there is a .cpp file and if yes run cmake

cd /usr/src/samy/configFiles/Skills/PlaceSkill/ && cd build && cmake .. && make -j7 &&  mv libplaceSkill.so.1.0 ../libplaceSkill.so && \
cd /usr/src/samy/configFiles/Skills/PickSkill/ && cd build && cmake .. && make -j7 &&  mv libpickSkill.so.1.0 ../libpickSkill.so && \
cd /usr/src/samy/configFiles/Skills/MoveToSkill/ && cd build && cmake .. && make -j7 &&  mv libmoveToSkill.so.1.0 ../libmoveToSkill.so && \
cd /usr/src/samy/configFiles/Skills/PickAndPlaceSkill/ && cd build && cmake .. && make -j7 &&  mv libpickAndPlaceSkill.so.1.0 ../libpickAndPlaceSkill.so && \
cd /usr/src/samy/configFiles/Skills/SetGripperSkill/ && cd build && cmake .. && make -j7 &&  mv libsetGripperSkill.so.1.0 ../libsetGripperSkill.so && \
cd /usr/src/samy/configFiles/Skills/CheckStorageSkill/ && cd build && cmake .. && make -j7 &&  mv libcheckStorageSkill.so.1.0 ../libcheckStorageSkill.so && \
cd /usr/src/samy/configFiles/Skills/MoveCylinderSkill/ && cd build && cmake .. && make -j7 &&  mv libmoveCylinderSkill.so.1.0 ../libmoveCylinderSkill.so && \
cd /usr/src/samy/configFiles/Skills/GetPoseSkill/ && cd build && cmake .. && make -j7 &&  mv libgetPoseSkill.so.1.0 ../libgetPoseSkill.so && \
cd /usr/src/samy/configFiles/Skills/PlaceGridSkill/ && cd build && cmake .. && make -j7 &&  mv libplaceGridSkill.so.1.0 ../libplaceGridSkill.so && \
/usr/src/samy/build/SAMYCore /usr/src/samy/configFiles/SAMYCoreConfig.yaml