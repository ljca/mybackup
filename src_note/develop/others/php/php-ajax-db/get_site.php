<?php
#
$p = isset($_GET["p"]) ? intval($_GET["p"]) : '';

if(empty($p)){
  echo "请选择一个网站";
  exit;
}

echo " <table border='1'>
<tr border='0'>
<th>ID</th>
<th>网站名</th>
<th>网站 URL</th>
<th>Alexa 排名</th>
<th>国家代号</th>
</tr>";

if(!$conn = mysqli_connect("localhost","mysql","mysql?")) die("connect error: ".mysqli_error($conn));

mysqli_select_db($conn,"test");
$sql = "select * from websites where id = '". $p. "'";

$rs = mysqli_query($conn,$sql);

#if(){
#
#}

while($row = mysqli_fetch_array($rs)){
  echo "<tr border='0' width='100%'>";
  echo "<td>",$row['id'],"</td>";
  echo "<td>",$row['name'],"</td>";
  echo "<td>",$row['url'],"</td>";
  echo "<td>",$row['alexa'],"</td>";
  echo "<td>",$row['country'],"</td>";
  echo "</tr>";
}


echo "</table>";
mysqli_close($conn);

?>

