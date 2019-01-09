#!/usr/bin/env python2

import socket

def print_machine_info():
    host_name = socket.gethostname()
    ip_address = socket.gethostbyname(host_name)
    print "Host name is : %s" % host_name
    print "Ip Adreess is : %s" % ip_address 

if __name__ == '__main__':
    print "__name__= %s"  %__name__
    print print_machine_info()
