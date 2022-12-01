#!/bin/bash 

cd /usr/src/samy/configFiles/Skills/GetPoseSkill/ && make -p build && cd build && cmake .. && make -j$((`nproc`-2)) &&  mv libgetPoseSkill.so.1.0 ../libgetPoseSkill.so && \
cd /usr/src/samy/configFiles/Skills/MoveCylinderSkill/ && make -p build && cd build && cmake .. && make -j$((`nproc`-2)) &&  mv libmoveCylinderSkill.so.1.0 ../libmoveCylinderSkill.so && \
cd /usr/src/samy/configFiles/Skills/PickAndPlaceSkill/ && make -p build && cd build && cmake .. && make -j$((`nproc`-2)) &&  mv libpickAndPlaceSkill.so.1.0 ../libpickAndPlaceSkill.so && \
cd /usr/src/samy/configFiles/Skills/SetGripperSkill/ && make -p build && cd build && cmake .. && make -j$((`nproc`-2)) &&  mv libsetGripperSkill.so.1.0 ../libsetGripperSkill.so && \
cd /usr/src/samy/configFiles/Skills/PlaceSkill/ && make -p build && cd build && cmake .. && make -j$((`nproc`-2)) &&  mv libplaceSkill.so.1.0 ../libplaceSkill.so && \
cd /usr/src/samy/configFiles/Skills/PickSkill/ && make -p build && cd build && cmake .. && make -j$((`nproc`-2)) &&  mv libpickSkill.so.1.0 ../libpickSkill.so && \
cd /usr/src/samy/configFiles/Skills/CheckStorageSkill/ && make -p build && cd build && cmake .. && make -j$((`nproc`-2)) &&  mv libcheckStorageSkill.so.1.0 ../libcheckStorageSkill.so && \
cd /usr/src/samy/configFiles/Skills/PlaceGridSkill/ && make -p build && cd build && cmake .. && make -j$((`nproc`-2)) &&  mv libplaceGridSkill.so.1.0 ../libplaceGridSkill.so && \
/usr/src/samy/build/SAMYCore /usr/src/samy/configFiles/SAMYCoreConfig.yaml