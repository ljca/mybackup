<!DOCTYPE html>
<html>
  <head>
    <meta charset="utf-8" />
    <title>PHP upload file.</title>
    <link type='text/css' rel='stylesheet' href='/css/style.css' />
  <script type='text/javascript'> 
  <!-- 
  //alert("javascript!");
  -->
    </script>
  </head>

  <body>

<?php

if($_FILES['file']['error']){
  echo "error: ",$_FILES['file']['error'],"<br>";
}else{
  #echo "location: ",$_FILES['file']['tmp_name'],"<br>";
}

if(file_exists("upload/".$_FILES['file']['name'])){
  echo "<script>alert('文件已经存在');</script>";
}else{
  move_uploaded_file($_FILES['file']['tmp_name'],"upload/".$_FILES['file']['name']);
  echo "<script>alert('上传成功');</script>";
  echo "file: ",$_FILES['file']['name'],"<br>";
  echo "type: ",$_FILES['file']['type'],"<br>";
  echo "size: ",$_FILES['file']['size'] / 1024,"<br>";
  echo "file locationis: upload/".$_FILES['file']['name'],"<br>";
}

?>

<form method="post" action="<?php echo $_SERVER['PHP_SELF']; ?>" enctype="multipart/form-data">
      <label>文件名：</label>
      <input type='file' name='file' />
      <input type='submit' value='上传' />
    </form>
  </body>
</html>
