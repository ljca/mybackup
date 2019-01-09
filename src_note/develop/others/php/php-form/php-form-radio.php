<?php
#$q = isset($_GET['key']) ? htmlspecialchars($_GET['key']) : '';
$q = isset($_GET['key']) ? $_GET['key'] : '';
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
<input type='radio' name='key' value='runoob' />Runoob
<input type='radio' name='key' value='google' />Google
<input type='radio' name='key' value='baidu' />Baidu
<input type='radio' name='key' value='taobao' />Taobao
<input type='submit' value='提交' />
</form>

<?php
  }
?>

