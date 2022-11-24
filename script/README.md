# How to use the createStructure script

This script creates all files for a skill from a folder that contains a SklilConfig.yaml file.

- Copy the script into the skills folder in your config folder
- Create a folder with the name of the skill.
- Create the SkillConfig.yaml. Here is an example:
``` yaml
SAMYSkillConfig:
   SkillName: "PickSkill"
   Language: "C++"
   EntryFile: "Pick.cpp"
   EntryFunction: "pickFunction"
   Parameters: 
      - Name: "pickPose"
        DataType: UA_CRCL_PoseDataType
      - Name: "offset"
        DataType: UA_CRCL_FractionDataType
```
- Run the script with `python3 createStructure.py`
- Now add the logic of the skill to the entry function in the .cpp file

If you want to add a skill to a skill folder that already has skills in it, just rerun the script after creating the new folder and config file. The script will not overwrite any existing skills.

For an example of a finished SAMY project look at the `Vereinzelung` folder.