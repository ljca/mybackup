
<?php
$conf = parse_ini_file(realpath(dirname(__FILE__) .'/../config/config.ini')) or die("error: ");

$conn = mysqli_connect($conf['host'],$conf['user'],$conf['psk'],'test') or die("Connect Faild".mysqli_connect_error());

$sql = "select * from user_info";

#$result = mysqli_query($conn,$sql);
#var_dump(mysqli_num_rows($result));
#
echo "query result: </br>";
echo "<hr>";
$ifs=' | ';
/*
if(mysqli_num_rows($result) > 0){
  echo "id{$ifs}firstname{$ifs}lastname{$ifs}email{$ifs}reg_time<br>";
  while($row = mysqli_fetch_assoc($result)){
    echo $row['id'],$ifs,$row['firstname'],$ifs,$row['lastname'],$ifs,$row['email'],"<br>";
  }
  echo '<hr>';

}else echo "<br>no query results.<br>";
 */

if($rs = mysqli_query($conn,$sql)){
  if(mysqli_num_rows($rs) <= 0){
    echo "no results...<br>";
  }else{
    echo "second query result: <hr>";
    while($row = mysqli_fetch_array($rs)){
      echo $row['id'],$ifs,$row['user'],$ifs,$row['email'],$ifs,$row['comments'],"</br>";
    }
    echo "<hr/>";
  }
}

mysqli_free_result($rs);

mysqli_close($conn);

echo "close connection done.</br>";

?>
