@ECHO OFF
cd D:\koulu\project
git init
git add .
git commit -m "first commit"
git branch -M main
git remote add origin https://github.com/teppo01/Assignments.git
git push -u origin main

pause