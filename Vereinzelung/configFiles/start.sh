#!/bin/bash 

cd /usr/src/samy/configFiles/Skills/GetPoseSkill/ && cd build && cmake .. && make -j$((`nproc`-2)) &&  mv libGetPoseSkill.so.1.0 ../libGetPoseSkill.so && \
cd /usr/src/samy/configFiles/Skills/MoveCylinderSkill/ && cd build && cmake .. && make -j$((`nproc`-2)) &&  mv libMoveCylinderSkill.so.1.0 ../libMoveCylinderSkill.so && \
cd /usr/src/samy/configFiles/Skills/MoveToSkill/ && cd build && cmake .. && make -j$((`nproc`-2)) &&  mv libMoveToSkill.so.1.0 ../libMoveToSkill.so && \
cd /usr/src/samy/configFiles/Skills/PickAndPlaceSkill/ && cd build && cmake .. && make -j$((`nproc`-2)) &&  mv libPickAndPlaceSkill.so.1.0 ../libPickAndPlaceSkill.so && \
cd /usr/src/samy/configFiles/Skills/SetGripperSkill/ && cd build && cmake .. && make -j$((`nproc`-2)) &&  mv libSetGripperSkill.so.1.0 ../libSetGripperSkill.so && \
cd /usr/src/samy/configFiles/Skills/PlaceSkill/ && cd build && cmake .. && make -j$((`nproc`-2)) &&  mv libPlaceSkill.so.1.0 ../libPlaceSkill.so && \
cd /usr/src/samy/configFiles/Skills/PickSkill/ && cd build && cmake .. && make -j$((`nproc`-2)) &&  mv libPickSkill.so.1.0 ../libPickSkill.so && \
cd /usr/src/samy/configFiles/Skills/CheckStorageSkill/ && cd build && cmake .. && make -j$((`nproc`-2)) &&  mv libCheckStorageSkill.so.1.0 ../libCheckStorageSkill.so && \
cd /usr/src/samy/configFiles/Skills/PlaceGridSkill/ && cd build && cmake .. && make -j$((`nproc`-2)) &&  mv libPlaceGridSkill.so.1.0 ../libPlaceGridSkill.so && \
/usr/src/samy/build/SAMYCore /usr/src/samy/configFiles/SAMYCoreConfig.yaml