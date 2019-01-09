CXX=g++
default:mytest.h
	$(CXX) -c -o mytest.o mytest.cpp
	$(CXX) -c -o test.o test.cpp
	$(CXX) -o test test.o mytest.o
run:
	.\test
clean:
	rm -f *.o test

