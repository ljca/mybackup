# 当我在Gentoo上安装chromium的时候，遇到了下面的问题
```
!!! The ebuild selected to satisfy ">=media-video/ffmpeg-3:=" has unmet requirements.
- media-video/ffmpeg-3.2.6::gentoo USE="X alsa bzip2 encode gpl hardcoded-tables iconv mp3 network opengl postproc sdl threads truetype vorbis x264 xcb xvid zlib (-altivec) -amr -amrenc (-armv5te) (-armv6) (-armv6t2) (-armvfp) -bluray -bs2b -cdio -celt -chromaprint -cpudetection -debug -doc -ebur128 -fdk -flite -fontconfig -frei0r -fribidi -gcrypt -gme -gmp -gnutls -gsm -iec61883 -ieee1394 -jack -jpeg2k -kvazaar -ladspa -libass -libcaca -libilbc -librtmp -libsoxr -libv4l -lzma (-mipsdspr1) (-mipsdspr2) (-mipsfpu) (-mmal) -modplug (-neon) -nvenc -openal -openh264 -openssl -opus -oss -pic -pulseaudio -rubberband -samba -schroedinger -snappy -speex -ssh -static-libs -test -theora -twolame -v4l -vaapi -vdpau -vpx -wavpack -webp -x265 -zimg -zvbi" ABI_X86="(64) -32 (-x32)" CPU_FLAGS_X86="mmx sse sse2 -3dnow -3dnowext -aes -avx -avx2 -fma3 -fma4 -mmxext -sse3 -sse4_1 -sse4_2 -ssse3 -xop" FFTOOLS="aviocat cws2fws ffescape ffeval ffhash fourcc2pixfmt graph2dot ismindex pktdumper qt-faststart sidxindex trasher"

  The following REQUIRED_USE flag constraints are unsatisfied:
    cpu_flags_x86_sse? ( cpu_flags_x86_mmxext )

  The above constraints are a subset of the following complete expression:
    libv4l? ( v4l ) fftools_cws2fws? ( zlib ) test? ( encode ) postproc? ( gpl ) frei0r? ( gpl ) cdio? ( gpl ) samba? ( gpl ) encode? ( x264? ( gpl ) x265? ( gpl ) xvid? ( gpl ) X? ( !xcb? ( gpl ) ) ) cpu_flags_x86_avx2? ( cpu_flags_x86_avx ) cpu_flags_x86_fma4? ( cpu_flags_x86_avx ) cpu_flags_x86_fma3? ( cpu_flags_x86_avx ) cpu_flags_x86_xop? ( cpu_flags_x86_avx ) cpu_flags_x86_avx? ( cpu_flags_x86_sse4_2 ) cpu_flags_x86_aes? ( cpu_flags_x86_sse4_2 ) cpu_flags_x86_sse4_2? ( cpu_flags_x86_sse4_1 ) cpu_flags_x86_sse4_1? ( cpu_flags_x86_ssse3 ) cpu_flags_x86_ssse3? ( cpu_flags_x86_sse3 ) cpu_flags_x86_sse3? ( cpu_flags_x86_sse2 ) cpu_flags_x86_sse2? ( cpu_flags_x86_sse ) cpu_flags_x86_sse? ( cpu_flags_x86_mmxext ) cpu_flags_x86_mmxext? ( cpu_flags_x86_mmx ) cpu_flags_x86_3dnowext? ( cpu_flags_x86_3dnow ) cpu_flags_x86_3dnow? ( cpu_flags_x86_mmx )

(dependency required by "www-client/chromium-60.0.3112.78::gentoo[system-ffmpeg]" [ebuild])
(dependency required by "chromium" [argument])
```

然后我尝试：

```Bash
# 自动解决 USE 标记
emerge --autoumask-write --ask www-client/firefox
```

```Bash
# 并更新配置文件
etc-update #
dispatch-conf # 合并 USE 标记
```

