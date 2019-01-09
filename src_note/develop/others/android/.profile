# ~/.profile: executed by the command interpreter for login shells.
# This file is not read by bash(1), if ~/.bash_profile or ~/.bash_login
# exists.
# see /usr/share/doc/bash/examples/startup-files for examples.
# the files are located in the bash-doc package.

# the default umask is set in /etc/profile; for setting the umask
# for ssh logins, install and configure the libpam-umask package.
#umask 022

# if running bash
if [ -n "$BASH_VERSION" ]; then
    # include .bashrc if it exists
    if [ -f "$HOME/.bashrc" ]; then
	. "$HOME/.bashrc"
    fi
fi
# set PATH so it includes user's private bin if it exists
tmp=/home/external/Share/android
[ -d $tmp/tools/FriendlyARM/toolschain/4.5.1/bin ] && PATH=$PATH:$tmp/tools/FriendlyARM/toolschain/4.5.1/bin

[ -d $tmp/android-sdk-linux/tools ] && PATH=$PATH:$tmp/android-sdk-linux/tools

[ -d $tmp/android-4.2.2_r1/out/host/linux-x86/bin ] && PATH=$PATH:$tmp/android-4.2.2_r1/out/host/linux-x86/bin

export PATH
unset tmp
