LOCAL_PATH := $(call my-dir)
LOCAL_SRC_FILES := led4412.c
LOCAL_MODULE := libtiny4412led
LOCAL_SHARED_LIBRARIES := libc
#include $(BUILD_EXECUTABLE)
include $(BUILD_SHARED_LIBRARY)
