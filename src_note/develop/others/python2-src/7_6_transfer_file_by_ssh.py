#!/usr/bin/env python2

from getpass import getpass
from fabric.connection import * #local,run,env,get,put,prompt,open

def remote_server():
    #env.hosts = ['127.0.0.1']
    #env.password = getpass('Enter you password: ')
    getpass('Enter your password: ')
    #env.home_folder = '/tmp'

def login():
    open()

    #open(command="cd %s" %env.home_folder)

def download_file():
    print "Checking local disk space..."
    local("df -sh")
    remote_path = prompt("Enter the remote hosts file path: ")
    local_path = prompt("Enter the localhosts file path: ")
    get(remote_path=remote_path,local_path=local_path)
    local("ls %s" %local_path)


def upload_file():
    print "Checking local disk space..."
    local("df -sh")
    local_path = prompt("Enter the localhosts file path: ")
    remote_path = prompt("Enter the remote hosts file path: ")
    put(remote_path=remote_path,local_path=local_path)
    run("ls %s" %remote_path)

