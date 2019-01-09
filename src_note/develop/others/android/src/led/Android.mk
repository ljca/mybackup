
LOCAL_PATH := $(call my-dir)
LOCAL_SRC_FILES := $(call all-subdir-java-files)
LOCAL_PACKAGE_NAME := Led
LOCAL_SHARED_LIBRARIES := libtiny4412led

include $(BUILD_PACKAGE)
