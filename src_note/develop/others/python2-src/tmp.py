#!/usr/bin/env python2

import sys
import socket
import argparse

def main():
    parser = argparse.ArgumentParser(description='Socket Error Examples')
    parser.add_argument('--host',action='store',dest='host',required=False)
    parser.add_argument('--port',action='store',dest='port',required=False)
    parser.add_argument('--file',action='store',dest='file',required=False)
    given_args = parser.parse_args()
    print "Args: %s" %given_args
    host = given_args.host
    port = given_argsp.port
    file_name = given_args.file
    try:
        s = socket.socket(socket.AF_INET,socket.SOCK_STREAM)
    except socket.error,e:
        print "Error:: %s" %e
        sys.exit(1)
        #############
    try:
        s.connect((host,port))
    except socket.gaierror,e:
        print "Address error connection to server: %s" %e
        sys.exit(1)
    except socket.error,e:
        print "connection error: %s" %e
        sys.exit(1)
        #############
    try:
        s.sendall("" %file_name)
    except socket.error,e:
        print "Error sending data: %s" %e
        sys.exit(1)

    while(1):
        try:
            buf = s.recv(2048)
        except socket.error,e:
            print "Error receiving data: %s" %e
            sys.exit(1)
        if not len(buf):
            break

        sys.stdout.write(buf)

if __name__ == '__main__':
    main()


