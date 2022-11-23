#!/bin/bash
type -a test &> /dev/null || function test()
{
	echo count=$# \$0=$0 \$1=$1 \$2=$2
} && unset -f test 
