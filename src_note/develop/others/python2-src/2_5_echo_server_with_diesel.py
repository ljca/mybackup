#!/bin/env python2

def test_socket_timeout():
    s = socket.socket(socket.AF_INET,socket.SOCK_STREAM)
    print "Default socket timeout: %s" %s.gettimeout()
    s.settimeout(100)
    print "Current socket timeout: %s" %s.gettimeout()

