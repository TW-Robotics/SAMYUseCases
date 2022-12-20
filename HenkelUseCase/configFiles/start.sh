#!/bin/bash 

cd /usr/src/samy/configFiles/Skills/PlaceSkill/ && make -p build && cd build && cmake .. && make -j$((`nproc`-2)) &&  mv libplaceSkill.so.1.0 ../libplaceSkill.so && \
cd /usr/src/samy/configFiles/Skills/MoveSkill/ && make -p build && cd build && cmake .. && make -j$((`nproc`-2)) &&  mv libmoveSkill.so.1.0 ../libmoveSkill.so && \
cd /usr/src/samy/configFiles/Skills/PickSkill/ && make -p build && cd build && cmake .. && make -j$((`nproc`-2)) &&  mv libpickSkill.so.1.0 ../libpickSkill.so && \
/usr/src/samy/build/SAMYCore /usr/src/samy/configFiles/SAMYCoreConfig.yaml