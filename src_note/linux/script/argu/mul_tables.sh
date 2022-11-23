#!/bin/bash - 
for((i=1;i<10;i++));do
	for((j=1;j<=i;j++));do
		printf "%d X %d = %d  " $j $i $[i*j];
	done
	printf "\n";
done
