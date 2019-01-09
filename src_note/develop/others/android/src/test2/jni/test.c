#include <jni.h>
#include <unistd.h>
#include <fcntl.h>

jint Java_test_android_Test_add(JNIEnv *env,jobject job,jint a,jint b)
{
	open("/data/tmp.txt",O_RDWR);
	return a + b;
}

jint Java_test_android_Test_sub(JNIEnv *env,jobject job,jint a,jint b)
{
	return a - b;
}
