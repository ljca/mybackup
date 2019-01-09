<?php
$conn = null;

/*
try{
  $conf = parse_ini_file(realpath(dirname(__FILE__) .'/config/config.ini'));
  $conn = new mysqli($conf['host'],$conf['user'],$conf['psk'],$conf['db']);
  if(mysqli_connect_errno()) throw new Exception("Connect Error: ");
  else echo "connect mysql seccess!";
}catch(Exception $e){
  echo $e->getMessage();
}finally{
  $conn = null;
}
 */

#var_dump(__FILE__);
#echo "<br>";
#var_dump(dirname(__FILE__));
#echo "<br>";
#var_dump(realpath(dirname(__FILE__)));
#echo "<br>";
$conf = parse_ini_file(realpath(dirname(__FILE__) .'/../config/config.ini'));
#var_dump($conf);
#echo "<br>";
#var_dump(realpath(dirname(__FILE__)) . '/../config/config.ini');
#var_dump(realpath(dirname('/config/config.ini')));
#echo "<br>";
#exit;
$conn = mysqli_connect($conf['host'],$conf['user'],$conf['psk'],$conf['db']);

if($conn) echo "connect mysql sucess.</br>";
else  die("Connect Faild".mysqli_connect_error($conn));

$sql = "create table if not exists guests(
  id INT(6) UNSIGNED auto_increment primary key,
  firname varchar(30),
  lastname varchar(30) NOT NULL,
  email varchar(50),
  reg_date TIMESTAMP
)";

#echo "<br>";
#var_dump($rs = mysqli_query($conn,"show databases"));
#echo "<br>";
#var_dump($rs = mysqli_query($conn,"show tables from php"));
#echo "<br>";
mysqli_select_db("php");
#echo "<br>";
#var_dump($rs = mysqli_query($conn,"desc guests"));
#echo "<br>";
#var_dump($rs = mysqli_query($conn,"show columns from guests"));
#echo "<br>";
#var_dump($rs = mysqli_query($conn,"truncate table guests"));
#echo "<br>";

/*
if($rs = mysqli_query($conn,"select * from guests;")){
  foreach(mysqli_fetch_fields($rs) as $val){
    printf("%s|%d",$val->name,$val->max_length);
    echo "<br>";
  }
}
 */

$lines = mysqli_num_rows($rs);
$cols = mysqli_num_fields($rs);


if($rs = mysqli_query($conn,"desc guests")){

  #var_dump(mysqli_fetch_row($rs));
  #echo "<br>";
  /*
  for($i = 0;i < mysqli_num_rows($rs);$i++){ 
    echo $i,"<br>";
  }
   */
    while($row = mysqli_fetch_row($rs)){
      foreach($row as $val){
        printf("%s ",$val);
      }
      #echo "<br>";
      #var_dump($row);
      #echo "<br>";
      #printf("%s",$row[$i]);
      #printf("%s : %s",$row[0],$row[1]);
      echo "<br>";
    }
}


if($rs = mysqli_query($conn,"show databases;")){
  #echo mysqli_num_rows($rs),"<br>";
  #echo mysqli_num_fields($rs),"<br>";
  while($row = mysqli_fetch_row($rs)){
    #var_dump($row);
    printf("%s",$row[0]);
    echo "<br>";
  }
}

mysqli_free_result($rs);

mysqli_close($conn);

echo "close connection done.</br>";
exit;

if(mysqli_query($conn,$sql)) echo "create table done.</br>";
else echo "Error: ".mysql_error($conn);

echo "</br>";
## Insert data.
#$sql = "insert into guests(firstname,lastname,email) values('John','Doe','john@gmail.com')";
$sql = "insert into guests(firstname,lastname,email) values('Mary','Moe','mary@gmail.com');";
$sql .= "insert into guests(firstname,lastname,email) values('Gulie','Dooley','mary@gmail.com');";
$sql .= "insert into guests(firstname,lastname,email) values('Julie','Coe','julie@gmail.com')";

#if(mysqli_query($conn,$sql)) echo "insert data done.</br>";
if(mysqli_multi_query($conn,$sql)) echo "insert data done.</br>";
else echo "executeble insert sentence error: ".$sql.mysqli_error($conn);

echo "</br>";


?>
