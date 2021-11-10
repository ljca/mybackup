<link href="../../css/style.css" rel="stylesheet" type="text/css" />

# [rhythmcat](https://github.com/lazymonkey/rhythmcat)

> 依赖：

+ gstreamer0.10:
+ gstreamer0.10-bad:
+ gst-plugins-bad-0.10.23
+ gstreamer0.10-bad-plugins
+ gstreamer0.10-base:
+ gstreamer0.10-ffmpeg:
+ gstreamer0.10-good:
+ gstreamer0.10-good-plugins
+ gstreamer0.10-ugly:
+ gstreamer0.10-ugly-plugins-0.10.19


<details>

<summary>..... </summary>

```log
编译失败的gstremer0.10-good

In file included from /usr/include/glib-2.0/glib/gthread.h:32,
                 from /usr/include/glib-2.0/glib/gasyncqueue.h:32,
                 from /usr/include/glib-2.0/glib.h:32,
                 from /usr/include/gstreamer-0.10/gst/gst.h:27,
                 from gsttaglibmux.h:24,
                 from gstid3v2mux.h:24,
                 from gstid3v2mux.cc:51:
gstid3v2mux.cc: 在函数‘GType gst_id3v2_mux_get_type()’中:
/usr/include/glib-2.0/glib/gatomic.h:113:19: 错误：argument 2 of ‘__atomic_load’ must not be a pointer to a ‘volatile’ type
  113 |     __atomic_load (gapg_temp_atomic, &gapg_temp_newval, __ATOMIC_SEQ_CST); \
```


</details>
