CC=gcc
tmp=/home/external/Share/android/tools/jdk6u43/include
#C_FLAGS=-I$(tmp) -I$(tmp)/linux -fPIC -shared
C_FLAGS=-I$(tmp)/{,linux} -fPIC -shared
c_src=person.c
libperson.so:
	$(CC) $(C_FLAGS) -o libperson.so $(c_src)
