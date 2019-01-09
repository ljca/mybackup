@echo off
net start "VMare USB Arbitration Service"
net start "VMware Authorization Service"
net start "VMware Workstation Server"
net start "VMware DHCP Service"
net start "VMware NAT Service"

pause
start G:\Temp\Vmware\vmware.exe



