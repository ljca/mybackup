LOCAL_PATH	:=	$(call my-dir)
#LOCAL_SRC_FILES	:=	test/Tool.java
LOCAL_SRC_FILES	:=	$(call all-subdir-java-files)
LOCAL_MODULE	:=	tool

include $(BUILD_JAVA_LIBRARY)
