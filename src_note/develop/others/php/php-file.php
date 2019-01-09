<?php
#if(!fopen("welcome.txt","r+")) exit("Unable the file.");
#$file = $fopen("welcome.txt","w+") or exit("Unable the file");
#$fclose($file);
#echo $_SERVER["PHP_SELF"],"<br>";
#echo basename($_SERVER["PHP_SELF"]),"<br>";
#echo basename($_SERVER["PHP_SELF"],".php"),"<br>";

$file=basename($_SERVER["PHP_SELF"]);
if(file_exists($file)){
  echo "file: ",basename($file),"<br>";
  echo "size: ",filesize($file),"<br>";
  echo "type: ",filetype($file),"<br>";
  echo "path: ",realpath($file),"<br>";
  echo "stat: ","<br>";
  #var_dump(stat($file));
  echo count(stat($file)),"<br>";
  foreach(stat($file) as $val=>$value){
    echo $val,"：",$value,"<br>";
  }

  echo "=========== pathinfo =========== <br>";
  foreach(pathinfo($file) as $val=>$value){
    echo $val,": ",$value,"<br>";
  }
  #$f = fopen($file) or exit("Unable file");
}

  echo "/bin -> ",readlink("/bin"),"<br>";
echo var_dump(lstat("/bin")),"<br>";

#ftruncate($f,100);
#fclose($f);

?>
