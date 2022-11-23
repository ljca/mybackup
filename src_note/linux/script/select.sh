#!/bin/bash
echo select a number:
select e in {1..3};do
	case $e in
		1) echo select is $e;break;;
		2) echo select is $e;break;;
		3) echo select is $e;break;;
		*) echo select is valite;break;;
	esac
done;
unset e;
