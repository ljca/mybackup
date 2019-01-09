<?php
$ini = parse_ini_file("config.ini");
print_r($ini);
echo "<br>";
foreach($ini as $val=>$value){
  echo $val,"：",$value,"<br>";
}
echo "<br>";


$ini = parse_ini_file("config.ini",true);
echo "<br>";
print_r($ini);
echo "<br>";

echo "User: ",$ini["info"]['user'],"<br>";
echo "Age: ",$ini["info"]['age'],"<br>";
echo "E-mail: ",$ini["info"]['e-mail'],"<br>";
echo "Tel: ",$ini["info"]['tel'],"<br>";

foreach($ini as $val){
  foreach($val as $var=>$value){
    echo $var,"：",$value,"<br>";
  }
}


?>
