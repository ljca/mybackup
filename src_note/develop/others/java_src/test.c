#include <stdio.h>
#include "Test.h"

//JNIEXPORT void JNICALL Java_Test_test(JNIEnv *env, jobject job){
void Java_Test_test(JNIEnv *env, jobject job){
	printf("this is java called c\n");
}
