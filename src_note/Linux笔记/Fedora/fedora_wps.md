# fedora_wps
# wps for linux 启动错误:
> /wps: error while loading shared libraries: libpng12.so.0: cannot open shared object file: No such file or directory

系统缺少 png12 库
`dnf install -y libpng12`
