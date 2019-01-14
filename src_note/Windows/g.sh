#!/bin/bash -

pushd /g
find DeveLop Tools system-tools -maxdepth 2 -type d >> ProgramFiles.list
cd Tools
#find Tools -maxdepth 1 -type f -name "*.exe" >> ProgramFiles.list
find ../system-tools/{BootTools,DiskTools} Tools Android/Android_Tools/{adb,imgBoot,odex_tools} vcodec/Win32 -maxdepth 1 -type f -name "*.exe" >> ../ProgramFiles.list

popd

