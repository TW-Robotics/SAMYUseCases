#!/bin/bash 

cd /usr/src/samy/configFiles/Skills/PlaceSkill/ && make -p build && cd build && cmake .. && make -j$((`nproc`-2)) &&  mv libplaceSkill.so.1.0 ../libplaceSkill.so && \
#cd /usr/src/samy/configFiles/Skills/CheckPalletSkill/ && make -p build && cd build && cmake .. && make -j$((`nproc`-2)) &&  mv libcheckPalletSkill.so.1.0 ../libcheckPalletSkill.so && \
cd /usr/src/samy/configFiles/Skills/MoveSkill/ && make -p build && cd build && cmake .. && make -j$((`nproc`-2)) &&  mv libmoveSkill.so.1.0 ../libmoveSkill.so && \
cd /usr/src/samy/configFiles/Skills/PickSkill/ && make -p build && cd build && cmake .. && make -j$((`nproc`-2)) &&  mv libpickSkill.so.1.0 ../libpickSkill.so && \
cd /usr/src/samy/configFiles/Skills/PlaceGridSkill/ && make -p build && cd build && cmake .. && make -j$((`nproc`-2)) &&  mv libplaceGridSkill.so.1.0 ../libplaceGridSkill.so && \
/usr/src/samy/build/SAMYCore /usr/src/samy/configFiles/SAMYCoreConfig.yaml