<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>
<%
  String path = request.getContextPath();
			String basePath = request.getScheme() + "://"
					+ request.getServerName() + ":" + request.getServerPort()
					+ path + "/";
%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<base href="<%=basePath%>" />
<title>new document</title>
<meta name="generator" content="editplus" />
<meta name="author" content="" />
<meta name="keywords" content="" />
<meta name="description" content="" />
<style type="text/css">
<!--
-->
</style>
<script type="text/javascript" src="js/jquery-1.8.3.js"></script>
<script type="text/javascript">
<!--
  var xhr;
  function check(){
    /*   $.ajax({
     url:"AjaxServlet",
     type:"GET",
     success:function(){
     document.write("hello,ajax!")
     },
     error:function(){
     document.write('error')
     }}); */

    // $("#div").load("simple.xml");
    //$("#div").get("simple.xml","XML");
    if(window.XMLHttpRequest){
      xhr = new XMLHttpRequest();
    }else{
      xhr = new ActiveXObject("Microsoft.XMLHTTP");
    }
    if(xhr != null){
      //document.getElementById("div").innerHTML = "hello,Ajax!";
      var uname = document.getElementById("uname").value;//.getElementByID("uname");
      alert(uname);
      xhr.onreadystatechange = callBack;
      xhr.open("get","http://localhost:8080/Test/page/simple.xml",true); //AjaxServlet?uname="+uname,true);
      //xhr.setRequestHeader("Content-Type","application/x-www-form-urlencoded");
      //var data = "uname=admin";
      // req.setRequestHeader('X-Requested-With','XMLHttpRequest');
      xhr.send(null);
      //alert(xhr.readyState);
    }else{
      alert("Your Browser is not support XMLHttpRequset!");
    }
  }

  function callBack(){
    if(xhr.readyState == 4 && xhr.status == 200){
      //var result = xmlHttpRequest.responseText;
      //document.write("Welcome to the Ajax!");
      alert(xhr.responseText);
      //document.getElementByID("span_uname").innerHTML="UserName has used!";
      document.write("回调函数已被执行！");
    }
  }
//-->
</script>


</head>

<body>

  <form>
    <!-- UserName:<input type="text" name="" onBlur="javascript:checkUser();"/><div id="uname"><span id="span_uname"></span></div>
   PassWord:<input type="password" name=""/>
   <input type="submit" name="" value="Submit" /> -->
    <p>
      <input type="text" name="uname" id="uname" onblur="javascript:check();" />
    </p>
    <div id="div"></div>
    <input type="submit" value="Submit" />
  </form>
</body>
</html>
