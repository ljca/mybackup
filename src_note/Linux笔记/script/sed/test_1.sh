#!/bin/bash 
tf=list
[ -f $tf ] && {
	sed 's/MA/Massachusetts/' $tf 
	sed 's/MA/, Massachusetts/' $tf 
	sed 's/ MA/, Massachusetts/' $tf 
	sed 's/ MA/,Massachusetts/' $tf 
	sed 's/ MA/,Massachuetts/;s/ PA/,Pennsylvania/' $tf 
	sed -e 's/ MA/,Massach/' -e 's/ PA/,Pennsyl/' $tf 
	sed '\
		s/ MA/,Massach/\
		s/ PA/,Pennslva/\
		s/ CA/,Caliifornia/' $tf
	unset tf;
}
