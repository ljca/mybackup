#!/bin/bash
echo -en "Enter password: "
stty -echo
read tmp
stty echo 
echo 
echo passsword is $tmp read.
unset tmp
