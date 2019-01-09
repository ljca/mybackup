#!/usr/bin/python

"""
...............
"""

ACCOUNT = "lin"
PASSWD = "lin?"

print("input your account: ")
user_account = input()

print("input your password: ")
user_passwd = input()

if user_account == ACCOUNT and user_passwd == PASSWD:
    print("success!")
else:
    print("faild!")

