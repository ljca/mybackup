#include "person.h"
#include <stdio.h>

JNIEXPORT void JNICALL Java_person_test (JNIEnv *env, jobject job){
	printf("hello this is java called c\n");
}
