<?php
echo("<h1>Charpter 3: PHP Sentences.</h1>");
echo("<h2>php echo sentences.</h2>");
print("<h2>php print sentences.</h2>");
echo "<p><strong>&nbsp;&nbsp;echo sentence 可以使用逗号,","连接多种不同类型的数据，print 不行；echo sentence 没有返回值，比 print 语句要快。print 语句总是返回 1。</strong></br></p>";
//echo "\$arr=array("Banana","Orange","Apple");"
$arr=array("Banana","Orange","Apple");

echo "<p>{$arr[0]}&nbsp;&nbsp;{$arr[1]}&nbsp;&nbsp;{$arr[2]}</p>";
echo "</br>";
echo "<p><a href='charpter2.php'>Pre</a> &nbsp;&nbsp;", "<a href='index.html'>首页</a>&nbsp;&nbsp;","<a href='charpter4.php'>Next</a>","</br></p>";
echo <<<EOF

<ul>
<li><a herf='https://www.google.com/ncr'>Google</a></li>
</ul>

EOF;

?>

