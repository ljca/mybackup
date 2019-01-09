#!/usr/bin/env python2

import socket

def test_socket_mode():
    sk = socket.socket(socket.AF_INET,socket.SOCK_STREAM)
    sk.setblocking(1)
    sk.settimeout(0.5)
    sk.bind(("127.0.0.1",0))
    print "Server is Running on %s" %(str(sk.getsockname()))
    while True:
        sk.listen(1)
    #sk.close()


if __name__ == '__main__':
    test_socket_mode()
