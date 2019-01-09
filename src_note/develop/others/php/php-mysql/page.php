<!DOCTYPE html>
<html>
  <head>
    <meta charset="utf-8" />
    <title>Charpter 1: PHP syntax!</title>
    <link type='text/css' rel='stylesheet' href='/css/style.css' />
  <script type='text/javascript'> 
  <!-- 
  //alert("javascript!");
  -->
    </script>
  </head>

  <body>
  </body>
</html>


<?php
$conf = parse_ini_file(realpath(dirname(__FILE__) .'/../config/config.ini')) or die("error: ");

$conn = mysqli_connect($conf['host'],$conf['user'],$conf['psk'],'test') or die("Connect Faild".mysqli_connect_error());

$tmp = mysqli_fetch_row(mysqli_query($conn,"select count(*) from user_info;"));

$count = intval($tmp[0]);
unset($tmp);

$page = isset($_GET['page']) ? $_GET['page'] : 1;
if($page == 0) $page = 1;
echo "共查询到 $count 条记录.<br>";

$pagesize = 3;

if($count == 0) $totalPage  = 0;
else if($count < $pagesize || $count == $pagesize) $totalPage = 1;
else if($count % $pagesize == 0) $totalPage = $count / $pagesize;
else $totalPage = ($count / $pagesize)+1;


$totalPage = ceil($count / $pagesize);

$tmp = ($page - 1) * $pagesize;

$sql = "select * from user_info limit " . $tmp . "," . $pagesize;

echo <<< EOF
  <table>
  <tr>
  <th>用户名</th>
   <th>E-mail</th>
   <th>备注</th>
   <th>删除</th>
   <th>更新</th>
   <th>添加</th>
  </tr>

EOF;

#echo "$sql<br>";
$rs = mysqli_query($conn,$sql);
#var_dump($rs);
while($row = mysqli_fetch_array($rs)){
  echo "<tr>";
  echo "<td>{$row['user']}</td>";
  echo "<td>{$row['email']}</td>";
  echo "<td>{$row['comments']}</td>";
  echo "<td><a href=\"javascript:confirm('确定删除吗？') ? location='delete.php?id={$row['id']}':location='page.php'\">删除 </a>";
?>
  <td><a href='javascript:location="update.php?id=<?php echo $row['id'] ?>"'>更新</a></td>
  <td><a href='add_user.php'>添加</a></td>
  </tr>

<?php
}
?>

</table>

<?php
/*<!--<td><a href="return confirm('确定删除吗')">删除</a></td>;-->*/

if($page > 1){
  echo "<p><a href='page.php?page=1'> 首页 </a> ";
  echo "<a href=page.php?page=" . ($page-1) . "> 上一页 </a> ";
}
if($page < $totalPage) {
  echo "<a href=page.php?page=" . ($page+1)."> 下一页 </a> ";
  echo "<a href=page.php?page=". $totalPage ."> 尾页</a> ";
}

echo " $page / $totalPage.</p>";

mysqli_free_result($rs);

mysqli_close($conn);
?>

