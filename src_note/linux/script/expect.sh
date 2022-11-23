#!/usr/bin/expect

spawn ./in_out.sh

expect "Enter your name: "

send "expect\n"

expect "Enter your age: "

send "50\n"

expect eof
