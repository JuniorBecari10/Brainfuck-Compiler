set /p "name=Nome do Commit: "

git add .
git commit -m "%name%"
git push -u origin main

exit
