<?php
#$q = isset($_GET['key']) ? htmlspecialchars($_GET['key']) : '';
$q = isset($_POST['key']) ? $_POST['key'] : '';
if(is_array($q)){
  $sites = array(
    'runoob' => '菜鸟教程：http://www.runoob.com',
    'google' => '谷歌：https://www.google.com',
    'baidu' => '百度：https://www.baidu.com',
    'taobao' => '淘宝：https://www.taobao.com',
  );
  foreach($q as $val){
    echo $sites[$val] . PHP_EOL;
  }
}else {
?>

<form action='' method='post'>
<select multiple='multiple' name='key[]'>
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

