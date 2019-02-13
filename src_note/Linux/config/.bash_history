cat /proc/sys/kernel/sysrq
cat /proc/sys/vm/laptop_mode 
cat /sys/module/ath9k/parameters/ps_enable 
CC=gcc-5 CXX=g++-5 cmake .. -DCMAKE_INSTALL_PREFIX=/opt/mysql -DSYSCONFDIR=/etc -DMYSQL_DATADIR=/opt/mysql/data  -DDEFAULT_CHARSET=utf8 -DDEFAULT_COLLATION=utf8_general_ci -DEXTRA_CHARSETS=all -DWITH_EMBEDDED_SERVER=1 -DENABLED_LOCAL_INFILE=1 -DWITH_MYISAM_STORAGE_ENGINE=1 -DWITH_INNOBASE_STORAGE_ENGINE=1
CC=gcc-5 CXX=g++-5 cmake .. -DCMAKE_INSTALL_PREFIX=/usr/local/mysql -DINSTALL_BINDIR=/usr/local/bin -DINSTALL_SBINDIR=/usr/local/bin -DSYSCONFDIR=/etc -DMYSQL_DATADIR=/usr/local/mysql/data  -DDEFAULT_CHARSET=utf8 -DDEFAULT_COLLATION=utf8_general_ci -DEXTRA_CHARSETS=all -DWITH_EMBEDDED_SERVER=1 -DENABLED_LOCAL_INFILE=1 -DWITH_MYISAM_STORAGE_ENGINE=1 -DWITH_INNOBASE_STORAGE_ENGINE=1
CC=gcc-5 CXX=g++-5 cmake .. -DCMAKE_INSTALL_PREFIX=/usr/local/mysql -DSYSCONFDIR=/etc -DMYSQL_DATADIR=/usr/local/mysql/data  -DDEFAULT_CHARSET=utf8 -DDEFAULT_COLLATION=utf8_general_ci -DEXTRA_CHARSETS=all -DWITH_EMBEDDED_SERVER=1 -DENABLED_LOCAL_INFILE=1 -DWITH_MYISAM_STORAGE_ENGINE=1 -DWITH_INNOBASE_STORAGE_ENGINE=1
cmake .. -DCMAKE_INSTALL_PREFIX=/usr/local/mysql -DMYSQL_DATADIR=/usr/local/mysql/data  -DDEFAULT_CHARSET=utf8 -DDEFAULT_COLLATION=utf8_general_ci -DEXTRA_CHARSETS=all -DWITH_EMBEDDED_SERVER=1 -DENABLED_LOCAL_INFILE=1 -DWITH_MYISAM_STORAGE_ENGINE=1 -DWITH_INNOBASE_STORAGE_ENGINE=1
cmake .. -DMYSQL_USER=mysql -DCMAKE_INSTALL_PREFIX=/usr/local/mysql -DINSTALL_DATADIR=/usr/local/mysql/data  -DDEFAULT_CHARSET=utf8 -DDEFAULT_COLLATION=utf8_general_ci -DEXTRA_CHARSETS=all -DWITH_EMBEDDED_SERVER=1 -DENABLED_LOCAL_INFILE=1 -DWITH_MYISAM_STORAGE_ENGINE=1 -DWITH_INNOBASE_STORAGE_ENGINE=1
date;screenfetch;sudo hddtemp /dev/sda
export QT_STYLE_OVERRIDE="gtk2"
find . ! -name "*.lrc"
find ../video -type f -name "*.mp4";do 
find ../video -type f -name "*.mp4";do comm <(du -h $i) <(du -h `basename $i`);done
flac --keep-foreign-metadata -4 春笺.wav 
for d in $(for i in `find ../video/ -type f -size 0 -name "*.mp4"`;do basename $i;done|xargs);do cp -ibv "$d" ../video/1069/;done
for i in bk/*.{mht,MHT};do echo "${i%.*}";sed '11!d;/Content-Location/!d' "$i";echo "";done >> ubuntu_mht.md
for i in `file ~1/*.lrc|grep -i iso|cut -d: -f1`;do echo $i;done
for i in `find c-note -maxdepth 1 -type f -name "*.md"`;do echo "## [`sed '1!d;s/^# //' $i`]($i)" >> cx.md;done
for i in `find c-note -type f -name "*.md"`;do echo "## [`sed '1!d;s/^# //' $i`]($i)" >> develop.md;done
for i in `find . -maxdepth 1 -type f -name "*.md"|sed 's|\./||'`;do echo "## [`sed '1!d;s/^# //' $i`]($i)" >> linux.md;done
for i in  `find . -type f -name "*.md"`;do  mv -iv "$i" "`echo $i|sed 's/[ ]/_/g'`" 2> /dev/null;done
for i in `find . -type f -name "*.md"|sed 's|^\./||'`;do echo "+ [`sed '1!d;s|^# ||' $i`]($i)" >> files.md;done
for i in `find ../video/1069 -type f -name "*.mp4"`;do comm <(md5sum $i) <(md5sum  `basename $i`);done
for i in `find ../video -type f -name "*.mp4"`;do comm <(du -h $i) <(du -h `basename $i`);done
for i in *.{mht,MHT};do echo "${i%%.*}";sed '13!d;/Content-Location/!d' "$i";echo "";done >> genary_mht.md
for i in *.{mht,MHT};do sed '13!d;/Content-Location/!d' "$i" && echo "${i%%.*}";done >> "${i%%.*}.list"
git clone https://github.com/VundleVim/Vundle.vim.git ~/.vim/bundle/Vundle.vim
obexfs -b 04:79:70:9B:2A:D5 /mnt
paci alac celt daala faac faad2 flac libfdk-aac jasper lame a52dec libdca libde265 libdv libmpeg2 libmad libmpcdec opencore-amr schroedinger speex libtheora libvorbis libvpx wavpack x264 x265 xvidcore mac mpg123  fluidsynth
paci bumblebee
paci compton
paci convmv
paci docbook-xml docbook-xsl libxslt libxml2
paci ffmpegthumbnailer poppler-glib libgsf libopenraw gvfs thunar-volman thunar-archive-plugin thunar-media-tags-plugin 
paci hfsprogs shfs-utils 
paci i3-wm i3status feh xcompmgr xfce4-terminal tilda xcursor-themes ntfs-3g mate-themes xfce4-screenshooter
paci iagno quadrapassel gnome-chess
paci obexfs
paci pulseaudio-alsa  extra/pavucontrol dmenu
paci reflector
paci rpmextract fastjar unzip unrar p7zip cdrkit html2text antiword unrtf 
paci thermald
paci wgetpaste
QT_QPA_PLATFORMTHEME=qgnomeplatform qt5ct
QT_QPA_PLATFORMTHEME="qt5ct" qt5ct
scripts/mysql_install_db --basedir=/usr/local/mysql --datadir=/usr/local/mysql/data --user=mysql --pid-file=/usr/local/mysql/data/mysqld.pid
sduo  systemctl disable netctl.service
sed '1b\newline' tmp.txt 
sed -i-bk '/^##/{n;/^$/d}' 500道家常菜.md
sed -i-bk 's/Dawnrain:/Dawnrain：/' 500道家常菜.md
sed -i '/^$/{N;/^\n*$/D}' genary_mht.md
sed -i 's/\(\[.*\]\) *\(\[.*\]\)/\1\2/g' files.md
sed '/^$/{N;/^\n*$/D}' genary_mht.md|less
sed -r -i-bk '/^1/i> 做法：\n' 500道家常菜.md
sed -r -i-bk '/./,/^$/!d' 500道家常菜.md 
sed -r -i-bk 's/^Dawnrain:/> &\n\n/' 500道家常菜.md
sensors-detect 
setxkbmap -option "ctrl:nocaps"
setxkbmap -option "ctrl:swapcaps"
ssh root@101.201.68.238
su -c 'echo 1 > /proc/sys/kernel/sysrq'
su -c 'echo 1 > /sys/devices/system/cpu/intel_pstate/no_turbo'
sudo cpupower frequency-info
sudoe /etc/sysctl.d/100-swap.conf
sudoe /etc/systemd/system/getty@tty1.service.d/noclear.conf
sudo grub-install --target=x86_64-efi --efi-directory=/boot/efi --bootloader-id=boot --boot-directory=/boot/efi/EFI/boot --compress="xz" --debug
sudo efibootmgr -b 2 -B
sudo efibootmgr -c -l \\EFI\\rEFInd\\refind_grub.efi -u "shim.efi refind_x64.efi" 
sudo efibootmgr -c -L "Windows Boot Manager" -l \\EFI\\Microsoft\\Boot\\bootmgfw.efi
sudo hdparm -I /dev/sda | grep -i advanced
sudo hdparm -S 
sudo inotifywait -rmcq -d -e create,modify,move,moved_to,moved_from,delete /media/Others/Backup/myback -o inotifywait.log
sudo inotifywait -rmcq -e create,modify,move,moved_to,moved_from,delete /media/Others/Backup/myback -o inotifywait.log
sudo inotifywait -rmcq -e create,modify,move,move_to,move_from,delete /media/Others/Backup/myback -o inotifywait.log
sudo iptables -A FORWARD -d 192.168.43.1 -p tcp --dport 10010 -j ACCEPT 
sudo iptables -A FORWARD -d 192.168.43.1 -p tcp --dport 443 -j ACCEPT
sudo iptables -A FORWARD -d 192.168.43.1 -p tcp --dport 80 -j ACCEPT
sudo iptables -A FORWARD -j LOG
sudo iptables -A INPUT -d 192.168.43.1 -p tcp --dport 10010 -j ACCEPT 
sudo iptables -A INPUT -j LOG
sudo iptables -A INPUT -p tcp --dport 1000:1024 -j REJECT
sudo iptables -A INPUT -p udp --dport 1000:1024 -j REJECT
sudo iscsiadm -m node -T iqn.2003-01.org.linux-iscsi.my.x8664:sn.7e2736922318 -p 192.168.43.152 --login 
sudo iscsiadm -m node -T iqn.2003-01.org.linux-iscsi.my.x8664:sn.7e2736922318 -u
sudo laptop_mode status
sudo mkdir -pv /etc/systemd/system/getty@tty1.service.d
sudo modprobe ath9k ps_enable=1
sudo modprobe vmw_vmci vmmon
sudo mount -o utf8=1,uid=$UID /dev/disk/by-label/LIN /media/tmp
sudo mount -t cifs //192.168.43.152/share /media/tmp -o credentials=/root/auth.smb,rw
sudo mount -t vfat -o uid=$UID,utf8 /dev/sdb1 /media/tmp
sudo ntfsundelete /dev/sda9 -u -i `sudo ntfsundelete /dev/sda9 -m "*.mp4"|sed '1,2d;/^$/d;$d'|cut -d" " -f-1|xargs|tr ' ' ','` -d ./tmp
sudo pacman -S base base-devel net-tools iw iproute2 wpa_supplicant dhcpcd
sudo pacman -S fcitx{,-gtk2,-gtk3,-qt4,-qt5,-configtool,-fbterm}
sudo pip2 install fabric
sudo pip2 install ntplib diesel nmap scapy netifaces netaddr pyopenssl pygeocoder pyyaml requests feedparser paramiko fabric  bottlenose construct SOAPpy supervisor
sudo sensors-detect 
sudo sshfs tmp@192.168.43.191:/ /mnt -o compression=yes,uid=$UID,allow_other,port=10086
sudo systemctl enable thermald.service 
sync;sync;sync;sync;sync;sync;sync;sync;sync;sync;sync;cs
sync;sync;sync;sync;sync;sync;sync;sync;sync;sync;sync;rs
watch grep \"cpu MHz\" /proc/cpuinfo
xsltproc -o docbook.html /usr/share/xml/docbook/xsl-stylesheets-1.79.1/html/docbook.xsl docbook.xml 
yaourt -S libfdk-aac daala-git alac-git neroaac 
#1550066089
l
