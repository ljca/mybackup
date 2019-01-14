echo -e "\e]P7ffffff"
mount -v --bind /dev /mnt/dev
mount -vt devpts devpts /mnt/dev/pts -o gid=5,mode=620
mount -vt proc proc /mnt/proc/
mount -vt tmpfs tmpfs /mnt/run
chroot /mnt /usr/bin/env -i HOME=/root TERM=
chroot /mnt /usr/bin/env -i HOME=/root TERM="$TERM" /bin/bash --login
chroot /mnt /usr/bin/env -i HOME=/root TERM="$TERM"  PS1="(chroot)\u:\w\\$ " /bin/bash --login
umount -v /mnt/dev/pts
umount -v /mnt/dev
umount /mnt/run
umount /mnt/{proc,sys}
umount -v /mnt/{proc,sys}
umount -v /mnt 
mount --bind -v /dev /mnt/dev
mount  -vt devpts devpts /mnt/dev/pts -o gid=5,mode=620
mount -vt proc proc /mnt/proc
mount -vt sysfs sysfs /mnt/sys
mount -vt tmpfs tmpfs /mnt/run
chroot /mnt /usr/bin/env -i HOME=/root TERM="$TERM" PS1='\u:\w\$ ' PATH=/bin/usr/bin:/sbin:/usr/sbin /bin/bash --login
umount -v /mnt/{dev/pts,dev,run,sys,proc}
mount -t ext4 -v /dev/sda7 /mnt
mount --bind -v /dev /mnt/dev&&mount  -vt devpts devpts /mnt/dev/pts -o gid=5,mode=620&&mount -vt proc proc /mnt/proc&&mount -vt sysfs sysfs /mnt/sys&&mount -vt tmpfs tmpfs /mnt/run
chroot /mnt /usr/bin/env -i HOME=/root TERM="$TERM" PS1='(chroot)\u:\w\$ ' PATH=/bin:/usr/bin:/sbin:/usr/sbin /bin/bash --login
umount -v /mnt/{dev/pts,dev,run,sys,proc}
chroot /mnt /usr/bin/env -i HOME=/root TERM="$TERM" PS1='\u:\w\$ ' PATH=/bin/usr/bin:/sbin:/usr/sbin /bin/bash --login
mount -t ext4 -v /dev/sda7 /mnt
mount --bind -v /dev /mnt/dev&&mount  -vt devpts devpts /mnt/dev/pts -o gid=5,mode=620&&mount -vt proc proc /mnt/proc&&mount -vt sysfs sysfs /mnt/sys&&mount -vt tmpfs tmpfs /mnt/run
chroot /mnt /usr/bin/env -i HOME=/root TERM="$TERM" PS1='(chroot)\u:\w\$ ' PATH=/bin:/usr/bin:/sbin:/usr/sbin /bin/bash --login
umount -v /mnt/{dev/pts,dev,run,sys,proc}
mount --bind -v /dev /mnt/dev&&mount  -vt devpts devpts /mnt/dev/pts -o gid=5,mode=620&&mount -vt proc proc /mnt/proc&&mount -vt sysfs sysfs /mnt/sys&&mount -vt tmpfs tmpfs /mnt/run
mount --bind -v /home /mnt/home
chroot /mnt /usr/bin/env -i HOME=/root TERM="$TERM" PS1='(chroot)\u:\w\$ ' PATH=/bin:/usr/bin:/sbin:/usr/sbin /bin/bash --login
umount -v /mnt/{dev/pts,dev,run,sys,proc,home,}
