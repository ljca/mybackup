wget -P ~/back  http://mirrors.yun-idc.com/epel/6/i386/epel-release-6-8.noarch.rpm
wget -P ~/back http://download.fedoraproject.org/pub/epel/6/i386/epel-release-6-8.noarch.rpm
sudo wget http://mirrors.aliyun.com/repo/epel-6.repo
sudo wget -O /etc/yum.repos.d/CentOS-Base.repo http://mirrors.aliyun.com/repo/Centos-6.repo

 sudo groupmod -g 501 kyzs 

sudo mkfs.ext4 -L "Raid0" /dev/md0 
sudo mount -t ext4 -v -o rw /dev/md0 /media/raid
sudo dmsetup status
cat /proc/mdstat 

sudo mount -t ext4 -v -o rw /dev/md0 /media/raid 
sudo chkconfig --level=2345 mdmonitor off 


sudo yum install dos2unix
sudo yum install zsh
sudo yum install bash-completion gromacs-bash  python-argcomplete python-optcomplete
sudo yum install autojump-zsh gromacs-zsh

git clone https://github.com/gmarik/vundle.git ~/.vim/bundle/Vundle
git clone https://github.com/terryma/vim-multiple-cursors.git
vim ~/.vimrc
git clone git://github.com/majutsushi/tagbar
git clone https://github.com/samlaudev/ConfigurationFiles
git clone https://github.com/eugeii/consolas-powerline-vim
git clone  https://github.com/edkolev/promptline.vim
git clone  https://github.com/edkolev/promptline.vim
git clone https://github.com/itchyny/lightline.vim
git clone https://github.com/Valloric/YouCompleteMe

sudo yum install automake gcc gcc-c++ kernel-devel cmake pythone-devel pythone3-devel 
sudo yum install python-devel python3-devel 
sudo python34-devel 
sudo yum install python34-devel 
git submodule update --init --recursive 
sudo yum install clang clang-devel 
./install.py --clang-completer
cd ~/.vim/bundle/YouCompleteMe/third_party/ycmd/clang_configives
./install.py --clang-completer
yum install clang clang-devel cmake llvm llvm-devel llvm-libs 
sudo yum install clang clang-devel cmake llvm llvm-devel llvm-libs 

cmake -G "Unix Makefiles" -DPATH_TO_LLVM_ROOT=/var/tmp/clang+llvm-3.9.0-i586-opensuse13.2 . ~/.vim/bundle/YouCompleteMe/third_party/ycmd/cpp
cmake -G "Unix Makefiles" -DUSE_SYSTEM_LIBCLANG=ON . ~/.vim/bundle/YouCompleteMe/third_party/ycmd/cpp
cmake --build . --target ycm_core --config Release 
cd ~/.vim/bundle/YouCompleteMe/third_party/ycmd/clang_configives
./install.py --clang-completer
yum install clang clang-devel cmake llvm llvm-devel llvm-libs 
sudo yum install clang clang-devel cmake llvm llvm-devel llvm-libs 
cmake -G "Unix Makefiles" -DPATH_TO_LLVM_ROOT=/var/tmp/clang+llvm-3.9.0-i586-opensuse13.2 . ~/.vim/bundle/YouCompleteMe/third_party/ycmd/cpp
cmake -G "Unix Makefiles" -DUSE_SYSTEM_LIBCLANG=ON . ~/.vim/bundle/YouCompleteMe/third_party/ycmd/cpp
cmake --build . --target ycm_core --config Release 
./contrib/download_prerequisites 

ABI=32 ./configure --prefix=/usr/local --enable-cxx --dordir=/usr/local/share/doc/gmp-6.0a
ABI=32 ./configure --prefix=/usr/local --enable-cxx --docdir=/usr/local/share/doc/gmp-6.0a
SED=sed ../gcc-4.9.2/configure --prefix=/usr/local --enable-languages=c,c++ --disable-bootstrap --with-system-zlib --enable-c++11
wget http://ftp.gnu.org/gnu/libc/glibc-2.17.tar.xz
tar -xf /media/others/Temp/lfs_sr/lfs-package/sources/glibc-2.17.tar.xz
wget ftp://ftp.vim/org/pub/vim/unix/vim-7.4.tar.bz2
sudo yum install python34 
sudo yum install python-devel
../configure --prefix=/usr --disable-profile --enable-add-ons --with-headers=/usr/include --with-binutils=/usr/bin 
make 

sudo yum install mysql mysql-devel mysql-libs mysql-server qt-mysql qt3-mysql qt5-mysql mysql++-devel  mysql++-manuals  mysql-utilities
sudo yum install qt-MySQL qtqt5-qtbase-mysql
sudo yum install mysql mysql-devel mysql-libs mysql-server qt-mysql qt3-mysql qt5-mysql mysql++-devel  mysql++-manuals  mysql-utilities
sudo yum install qt-MySQL qtqt5-qtbase-mysql
sudo yum install bash-completion gromacs-bash  python-argcomplete python-optcomplete;sudo yum install autojump-zsh gromacs-zsh;sudo yum install autojump-zsh gromacs-zsh
sudo yum install mysql mysql-devel mysql-libs mysql-server qt-mysql qt3-mysql qt5-mysql mysql++-devel  mysql++-manuals  mysql-utilities;sudo yum install qt-MySQL qtqt5-qtbase-mysql
sudo yum install libotf 
mysql_secure_installation 
sudo yum install bash-completion gromacs-bash  python-argcomplete python-optcomplete;sudo yum install autojump-zsh gromacs-zsh;sudo yum install autojump-zsh gromacs-zsh
sudo yum update 

ABI=32 ./configure --prefix=/usr/local --enable-cxx --docdir=/usr/local/share/doc/gmp-6.0
make html

tar -xf mpfr-3.1.2.tar.xz 
cd mpfr-3.1.2/
patch -Np1 -i ../mpfr-3.1.2-upstream_fixes-3.patch 
./configure --prefix=/usr/local --enable-thread-safe --docdir=/usr/local/share/doc/mpfr-3.1.2

tar -xf mpc-1.0.2.tar.gz 
cd mpc-1.0.2/
./configure --prefix=/usr/local --docdir=/usr/local/share/doc/mpc-1.0.2 

./configure --prefix=/usr/local --with-isl-prefix=/usr/local 
cd isl-0.12/
./configure --prefix=/usr/local  

tar -xf cloog-0.18.0.tar.gz 
./configure --prefix=/usr/local --docdir=/usr/local/share/doc/cloog-0.18.0 --with-isl=system
make 

tar -xf gcc-4.9.2.tar.bz2 
cd gcc-4.9.2/
mkdir -pv ../gcc-build
cd ../gcc-build/
SED=sed ../gcc-4.9.2/configure --prefix=/usr/local --enable-languages=c,c++ --disable-bootstrap --with-system-zlib 
make -j2 
sudo make install 

sudo yum install tftp{,-server}
/lib/libc.so.6 
ldd /bin/ls|grep glibc
ldd /bin/ls|grep libc
sudo yum install bash-completion
sudo yum install -y zsh tcsh mc
