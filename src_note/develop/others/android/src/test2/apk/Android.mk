LOCAL_PATH	:=	$(call my-dir)
LOCAL_SRC_FILES	:=	$(call all-subdir-java-files)
LOCAL_PACKAGE_NAME	:=	Test	
#LOCAL_JAVA_SHARED_LIBRARIES	:=
LOCAL_JAVA_LIBRARIES	:=	tool
include $(BUILD_PACKAGE)


#include $(CLEAR_VARS)
#LOCAL_JNI_SHARED_LIBRARIES	:=	libtest

#include $(LOCAL_PATH)/jni/Android.mk
