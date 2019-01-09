 #!/bin/bash
 tmp="/media/Others/Audio-Frequency/..............&/天边的眷恋.ape"
 echo 文件名:`basename $tmp`; echo 目录:`dirname $tmp`;
 echo 文件名:${tmp##*/};echo 目录名:${tmp%/*}
 unset tmp
