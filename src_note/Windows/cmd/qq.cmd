@echo off
cd C:\Program Files (x86)\Common Files\Tencent\QQProtect\Bin
:renx
ren QQProtect.exe QQProtect.exe.bak
:renb
ren QQProtect.exe.bak QQProtect.exe

if exist QQProtect.exe goto renx


