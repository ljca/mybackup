<?php
#$q = isset($_GET['key']) ? htmlspecialchars($_GET['key']) : '';
$q = isset($_GET['key']) ?: ;
if($q){
  if($q == 'runoob'){
    echo "<a href='http://www.runoob.com'>http://www.runoob.com</a> ";
  }else if($q == 'google'){
    echo "<a href='https://www.google.com/nrc'>https://www.google.com/nrc</a> ";
  }else if($q == 'baidu'){
    echo "<a href='https://www.baidu.com'>https://www.baidu.com</a> ";
  }else if($q == 'taobao'){
    echo "<a href='https://www.taobao.com'>https://www.taobao.com</a> ";
  }
  }else {
?>

<form action='' method='get'>
<select name='key'>
<option value=''>选择一个站点</option>
<option value='runoob'>菜鸟教程</option>
<option value='google'>Google</option>
<option value='baidu'>Baidu</option>
<option value='taobao'>淘宝</option>
</select>
<input type='submit' value='提交' />
</form>

<?php
  }
?>

