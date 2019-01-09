#1525306217
paci rpmextract fastjar unzip unrar p7zip cdrkit html2text antiword unrtf 
#1525308613
sudo pacman -S fcitx{,-gtk2,-gtk3,-qt4,-qt5,-configtool,-fbterm}
#1525343573
sync;sync;sync;sync;sync;sync;sync;sync;sync;sync;sync;rs
#1525344887
paci bumblebee
#1525410623
sync;sync;sync;sync;sync;sync;sync;sync;sync;sync;sync;cs
#1525529205
git clone https://github.com/VundleVim/Vundle.vim.git ~/.vim/bundle/Vundle.vim
#1525591279
paci reflector
#1525591779
paci wgetpaste
#1525592329
paci alac celt daala faac faad2 flac libfdk-aac jasper lame a52dec libdca libde265 libdv libmpeg2 libmad libmpcdec opencore-amr schroedinger speex libtheora libvorbis libvpx wavpack x264 x265 xvidcore mac mpg123  fluidsynth
#1525592417
yaourt -S libfdk-aac daala-git alac-git neroaac 
#1525598980
sudo mkdir -pv /etc/systemd/system/getty@tty1.service.d
#1525598997
sudoe /etc/systemd/system/getty@tty1.service.d/noclear.conf
#1525610445
sudo grub-install --target=x86_64-efi --efi-directory=/boot/efi --bootloader-id=Arch --boot-directory=/boot/efi/EFI/Arch --compress="xz" --debug
#1525612054
sudo mount -o utf8=1,uid=$UID /dev/disk/by-label/LIN /media/tmp
#1525616994
paci hfsprogs shfs-utils 
#1525660500
sudo efibootmgr -c -l \\EFI\\rEFInd\\refind_grub.efi -u "shim.efi refind_x64.efi" 
#1525662757
sudo efibootmgr -b 2 -B
#1525664919
sudo efibootmgr -c -L "Windows Boot Manager" -l \\EFI\\Microsoft\\Boot\\bootmgfw.efi
#1525784086
paci docbook-xml docbook-xsl libxslt libxml2
#1525785285
xsltproc -o docbook.html /usr/share/xml/docbook/xsl-stylesheets-1.79.1/html/docbook.xsl docbook.xml 
#1525954463
cat /proc/sys/kernel/sysrq
#1525954494
su -c 'echo 1 > /proc/sys/kernel/sysrq'
#1526573377
sudo pacman -S base base-devel net-tools iw iproute2 wpa_supplicant dhcpcd
#1526574746
paci i3-wm i3status feh xcompmgr xfce4-terminal tilda xcursor-themes ntfs-3g mate-themes xfce4-screenshooter
#1526576704
paci pulseaudio-alsa  extra/pavucontrol dmenu
#1526576844
paci ffmpegthumbnailer poppler-glib libgsf libopenraw gvfs thunar-volman thunar-archive-plugin thunar-media-tags-plugin 
#1527497668
paci convmv
#1527502369
sudo modprobe ath9k ps_enable=1
#1527502836
cat /sys/module/ath9k/parameters/ps_enable 
#1527503486
cat /proc/sys/vm/laptop_mode 
#1527503502
sudo laptop_mode status
#1527503642
sudo hdparm -I /dev/sda | grep -i advanced
#1527503916
sudoe /etc/sysctl.d/100-swap.conf
#1527504462
su -c 'echo 1 > /sys/devices/system/cpu/intel_pstate/no_turbo'
#1527504584
sudo cpupower frequency-info
#1527504699
watch grep \"cpu MHz\" /proc/cpuinfo
#1527504819
paci thermald
#1527504848
sudo systemctl enable thermald.service 
#1527504984
sudo hdparm -S 
#1527506030
sensors-detect 
#1527506038
sudo sensors-detect 
#1527513535
find . ! -name "*.lrc"
#1527520342
date;screenfetch;sudo hddtemp /dev/sda
#1530428830
bpython
#1530440323
sudo pip2 install ntplib diesel nmap scapy netifaces netaddr pyopenssl pygeocoder pyyaml requests feedparser paramiko fabric  bottlenose construct SOAPpy supervisor
#1530441061
sudo pip2 install fabric
#1532236886
ssh root@101.201.68.238
#1532251682
sudo modprobe vmw_vmci vmmon
#1535531505
paci iagno quadrapassel gnome-chess
#1538492244
paci obexfs
#1538492414
obexfs -b 04:79:70:9B:2A:D5 /mnt
#1538573904
sudo sshfs tmp@192.168.43.191:/ /mnt -o compression=yes,uid=$UID,allow_other,port=10010
#1538990090
sudo iptables -A INPUT -d 192.168.43.1 -p tcp --dport 10010 -j ACCEPT 
#1538990150
sudo iptables -A FORWARD -d 192.168.43.1 -p tcp --dport 10010 -j ACCEPT 
#1538990172
sudo iptables -A FORWARD -d 192.168.43.1 -p tcp --dport 80 -j ACCEPT
#1538990203
sudo iptables -A FORWARD -d 192.168.43.1 -p tcp --dport 443 -j ACCEPT
#1538990294
sudo iptables -A INPUT -j LOG
#1538990311
sudo iptables -A FORWARD -j LOG
#1538991246
sudo iptables -A INPUT -p tcp --dport 1000:1024 -j REJECT
#1538991264
sudo iptables -A INPUT -p udp --dport 1000:1024 -j REJECT
#1539530785
sudo mount -t cifs //192.168.43.152/share /media/tmp -o credentials=/root/auth.smb,rw
#1539653053
sync;sync;sync;sync;sync;sync;sync;sync;sync;sync;sync;rs
#1539785094
sduo  systemctl disable netctl.service
#1540220887
crontab -e
#1540311135
sudo iscsiadm -m node -T iqn.2003-01.org.linux-iscsi.my.x8664:sn.7e2736922318 -p 192.168.43.152 --login 
#1540311437
sudo iscsiadm -m node -T iqn.2003-01.org.linux-iscsi.my.x8664:sn.7e2736922318 -u
#1540900997
cmake .. -DMYSQL_USER=mysql -DCMAKE_INSTALL_PREFIX=/usr/local/mysql -DINSTALL_DATADIR=/usr/local/mysql/data  -DDEFAULT_CHARSET=utf8 -DDEFAULT_COLLATION=utf8_general_ci -DEXTRA_CHARSETS=all -DWITH_EMBEDDED_SERVER=1 -DENABLED_LOCAL_INFILE=1 -DWITH_MYISAM_STORAGE_ENGINE=1 -DWITH_INNOBASE_STORAGE_ENGINE=1
#1540901182
cmake .. -DCMAKE_INSTALL_PREFIX=/usr/local/mysql -DMYSQL_DATADIR=/usr/local/mysql/data  -DDEFAULT_CHARSET=utf8 -DDEFAULT_COLLATION=utf8_general_ci -DEXTRA_CHARSETS=all -DWITH_EMBEDDED_SERVER=1 -DENABLED_LOCAL_INFILE=1 -DWITH_MYISAM_STORAGE_ENGINE=1 -DWITH_INNOBASE_STORAGE_ENGINE=1
#1540901642
CC=gcc-5 CXX=g++-5 cmake .. -DCMAKE_INSTALL_PREFIX=/usr/local/mysql -DSYSCONFDIR=/etc -DMYSQL_DATADIR=/usr/local/mysql/data  -DDEFAULT_CHARSET=utf8 -DDEFAULT_COLLATION=utf8_general_ci -DEXTRA_CHARSETS=all -DWITH_EMBEDDED_SERVER=1 -DENABLED_LOCAL_INFILE=1 -DWITH_MYISAM_STORAGE_ENGINE=1 -DWITH_INNOBASE_STORAGE_ENGINE=1
#1540903158
scripts/mysql_install_db --basedir=/usr/local/mysql --datadir=/usr/local/mysql/data --user=mysql --pid-file=/usr/local/mysql/data/mysqld.pid
#1540904462
CC=gcc-5 CXX=g++-5 cmake .. -DCMAKE_INSTALL_PREFIX=/usr/local/mysql -DINSTALL_BINDIR=/usr/local/bin -DINSTALL_SBINDIR=/usr/local/bin -DSYSCONFDIR=/etc -DMYSQL_DATADIR=/usr/local/mysql/data  -DDEFAULT_CHARSET=utf8 -DDEFAULT_COLLATION=utf8_general_ci -DEXTRA_CHARSETS=all -DWITH_EMBEDDED_SERVER=1 -DENABLED_LOCAL_INFILE=1 -DWITH_MYISAM_STORAGE_ENGINE=1 -DWITH_INNOBASE_STORAGE_ENGINE=1
#1540913701
CC=gcc-5 CXX=g++-5 cmake .. -DCMAKE_INSTALL_PREFIX=/opt/mysql -DSYSCONFDIR=/etc -DMYSQL_DATADIR=/opt/mysql/data  -DDEFAULT_CHARSET=utf8 -DDEFAULT_COLLATION=utf8_general_ci -DEXTRA_CHARSETS=all -DWITH_EMBEDDED_SERVER=1 -DENABLED_LOCAL_INFILE=1 -DWITH_MYISAM_STORAGE_ENGINE=1 -DWITH_INNOBASE_STORAGE_ENGINE=1
#1540913701
CC=gcc-5 CXX=g++-5 cmake .. -DCMAKE_INSTALL_PREFIX=/opt/mysql -DSYSCONFDIR=/etc -DMYSQL_DATADIR=/opt/mysql/data  -DDEFAULT_CHARSET=utf8 -DDEFAULT_COLLATION=utf8_general_ci -DEXTRA_CHARSETS=all -DWITH_EMBEDDED_SERVER=1 -DENABLED_LOCAL_INFILE=1 -DWITH_MYISAM_STORAGE_ENGINE=1 -DWITH_INNOBASE_STORAGE_ENGINE=1
#1542134689
paci compton
#1542551140
export QT_STYLE_OVERRIDE="gtk2"
