sudo ntpdate time.nist.gov
sudo clock -w
sudo ifconfig eth0 192.168.1.10
./configure --enable-gui --enable-x11 --enable-gui --enable-menu --prefix=/usr/local 
ABI=32 ./configure --enable-cxx --prefix=/usr/local --docdir=/usr/local/share/doc/gmp-6.0
tar -xf mpfr-3.1.2.tar.xz 
cd mpfr-3.1.2/
patch -Np1 -i ../mpfr-3.1.2-upstream_fixes-3.patch 
./configure --prefix=/usr/local --enable-thread-safe --docdir=/usr/local/share/doc/mpfr-3.1
tar -xf mpc-1.0.2.tar.gz 
cd mpc-1.0.2/
./configure --prefix=/usr/local --docdir=/usr/local/share/doc/mpc-1.0.2
tar -xf isl-0.12.2.tar.bz2 
cd isl-0.12.2/
./configure --prefix=/usr/local --docdir=/usr/local/share/doc/isl-0.12
tar -xf cloog-0.18.1.tar.gz 
cd cloog-0.18.1/
./configure --prefix=/usr/local --with-isl=system  --docdir=/usr/local/share/doc/cloog-0.18.1
make && sudo make install
tar -xf gcc-4.9.2.tar.bz2 
cd gcc-4.9.2/
mkdir ../gcc-4.9.2-build
cd ../gcc-4.9.2-build/
SED=sed ../gcc-4.9.2/configure --prefix=/usr/local --enable-languages=c,c++ --disable-bootstrap --with-system-zlib
make && sudo make install 
sudo make install 
sudo ntpdate time.nist.gov
sudo clock -w
./configure --enable-gui --enable-x11 --enable-gui --enable-menu --prefix=/usr/local 
ABI=32 ./configure --enable-cxx --prefix=/usr/local --docdir=/usr/local/share/doc/gmp-6.0
tar -xf mpfr-3.1.2.tar.xz 
cd mpfr-3.1.2/
patch -Np1 -i ../mpfr-3.1.2-upstream_fixes-3.patch 
./configure --prefix=/usr/local --enable-thread-safe --docdir=/usr/local/share/doc/mpfr-3.1
tar -xf mpc-1.0.2.tar.gz 
cd mpc-1.0.2/
./configure --prefix=/usr/local --docdir=/usr/local/share/doc/mpc-1.0.2
tar -xf isl-0.12.2.tar.bz2 
cd isl-0.12.2/
./configure --prefix=/usr/local --docdir=/usr/local/share/doc/isl-0.12
tar -xf cloog-0.18.1.tar.gz 
cd cloog-0.18.1/
./configure --prefix=/usr/local --with-isl=system  --docdir=/usr/local/share/doc/cloog-0.18.1
make && sudo make install
tar -xf gcc-4.9.2.tar.bz2 
cd gcc-4.9.2/
mkdir ../gcc-4.9.2-build
cd ../gcc-4.9.2-build/
SED=sed ../gcc-4.9.2/configure --prefix=/usr/local --enable-languages=c,c++ --disable-bootstrap --with-system-zlib
make && sudo make install 
sudo make install 
