#!/usr/bin/env python2

import socket

def get_remote_machine_info():
    remote_host = 'www.python.org'
    try:
        print "IP address: %s" %socket.gethostbyname(remote_host)
    except socket.error,err_msg:
        print "%s: %s" %(remote_host,err_msg)

if __name__ == '__main__':
    get_remote_machine_info()


