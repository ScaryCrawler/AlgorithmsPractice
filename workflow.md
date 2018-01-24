# Git Process 


## Git flow

1.1 Master it is an actual branch without unfinished features, without experiments and trash. For every experiment, fix - your own branch.

1.2 Every feature should be implenented in standalone branches. 
If you need some unfinished functional from other branches - feel free to merge this branches without master branch.

1.3 Before merge you feature you should merge master into you finished branch and resolve all conflicts locally.

1.4 When your feature was finished and all conflicts was resolved you should to do pull request for code review and grant accept to merge you branch into master branch.

Pay attention: DO NOT USE fast-forward during the branches merge!


## About structure

1. For every new programming language you have to create new folder in root directory with name of choosen language.

2. For every new class of algorythm you need to create new subfolder/project/module with name of algorythms class or name of data structure wich you implement.

3. Architecture of you solution should be clear and understandable. It will be better if you will write you code with TDD approach if it is possible.
