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
<p>
<input type='checkbox' name='key[]' value='runoob' /> 菜鸟教程
<input type='checkbox' name='key[]' value='google' /> Google 
<input type='checkbox' name='key[]' value='baidu' /> 百度
<input type='checkbox' name='key[]' value='taobao' /> 淘宝 
<input type='submit' value='提交' />
</p>
</form>

<?php
  }
?>

