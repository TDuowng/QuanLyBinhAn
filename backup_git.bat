@echo off
cd /d D:\QLTP
git add .
git commit -m "Auto Backup - %date% %time%"
git push origin main
exit