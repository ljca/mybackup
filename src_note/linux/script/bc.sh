#!/bin/bash -

# echo "options;expressions"|bc
echo "scale=2;2.5*5*2"|bc

# var=`bc << EOF
# options
# stataments
# expressions
# EOF
# `

num1=2.5
num2=3.5
tmp=`bc << EOF
scale=4
a1 = ($num1*$num2)
a2 = ($num1)
a1 + a2
a1 * a2
EOF
`
echo $tmp

unset num1 num2 tmp
