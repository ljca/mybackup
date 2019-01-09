<?php

$conf = parse_ini_file(realpath(dirname(__FILE__) .'/../config/config.ini'));
$conn = mysqli_connect($conf['host'],$conf['user'],$conf['psk'],'test') or die("Connect Faild".mysqli_connect_error($conn));

?>

