<?php
#
$file = fopen("/tmp/config.ini","r+"); #or exit("file is not exists!");

echo ftell($file),"<br>";
fwrite($file,"config = 'test'\n");
fseek($file,0,SEEK_END);
echo ftell($file),"<br>";
fwrite($file,"end = $__FILES__\n");

fclose($file);


$file = fopen("/tmp/config.ini","r"); #or exit("file is not exists!");
while(!feof($file)){
  echo fgets($file),"<br>";
}

fclose($file);


?>

