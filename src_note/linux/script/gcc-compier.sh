#!/bin/bash 
[ -d $LFS/src/gcc-4.9.2 ] && cd $LFS/src/gcc-4.9.2
if [[ `pwd` = "$LFS/src/gcc-4.9.2" && -d gcc/config ]] ; then
for file in \
$(find gcc/config -name linux64.h -o -name linux.h -o -name sysv4.h)
do
 cp -uv $file{,.orig}
 sed -e 's@/lib\(64\)\?\(32\)\?/ld@/tools&@g' -e 's@/usr@/tools@g' $file.orig > $file
 echo '
#undef STANDARD_STARTFILE_PREFIX_1
#undef STANDARD_STARTFILE_PREFIX_2
#define STANDARD_STARTFILE_PREFIX_1 "/tools/lib/"
#define STANDARD_STARTFILE_PREFIX_2 ""' >> $file
  touch $file.orig
done
fi
sed -i '/k /prot/agcc_cv_libc_provides_ssp=yes' gcc/configure
