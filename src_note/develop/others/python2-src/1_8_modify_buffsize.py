#!/usr/bin/env python2

import socket
SEND_BUF_SIZE = 4096
RECV_BUF_SIZE = 4096

def modify_bufsize():
    sk = socket.socket(socket.AF_INET,socket.SOCK_STREAM)
    print "bufsize[Befoce]: %d" %sk.getsockopt(socket.SOL_SOCKET,socket.SO_SNDBUF)
    sk.setsockopt(socket.SOL_TCP,socket.TCP_NODELAY,1)
    sk.setsockopt(socket.SOL_SOCKET,socket.SO_SNDBUF,SEND_BUF_SIZE)
    sk.setsockopt(socket.SOL_SOCKET,socket.SO_RCVBUF,RECV_BUF_SIZE)
    print "bufsize[After]: %d" %sk.getsockopt(socket.SOL_SOCKET,socket.SO_SNDBUF)
    sk.close()

if __name__ == '__main__':
    modify_bufsize()
