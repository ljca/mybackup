@echo off
net stop "VMware Workstation Server"
net stop "VMware DHCP Service"
net stop "VMware NAT Service"
net stop "VMware USB Arbitration Service"
net stop "VMware Authorization Service"

pause