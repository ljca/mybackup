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
<?php include("select.php");?>
<ul>
<li><a href='delete_user.php?id='+id>删除</a></li>
<li><a href='add_user.php'>添加用户</a></li>
<li><a href='update_user?id='+id>更新用户信息</a></li>
</ul>

  </body>
</html>
