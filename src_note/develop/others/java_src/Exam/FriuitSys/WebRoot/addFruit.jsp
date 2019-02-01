<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>
<%
String path = request.getContextPath();
String basePath = request.getScheme()+"://"+request.getServerName()+":"+request.getServerPort()+path+"/";
%>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
  <head>
    <base href="<%=basePath%>">
    
    <title>My JSP 'addFruit.jsp' starting page</title>
    
	<meta http-equiv="pragma" content="no-cache">
	<meta http-equiv="cache-control" content="no-cache">
	<meta http-equiv="expires" content="0">    
	<meta http-equiv="keywords" content="keyword1,keyword2,keyword3">
	<meta http-equiv="description" content="This is my page">
	<!--
	<link rel="stylesheet" type="text/css" href="styles.css">
	-->
<script type="text/javascript" src="js/jquery-1.8.3.js"></script>
<script type="text/javascript">
<!--

function checkNul(){
if($("#typ").val() == ""){
alert("水果类型不允许为空！");
return false;
}
if($("#bree").val() == ""){
 alert("品种不允许为空！");
 return false;
 }
if($("#are").val() == ""){
 alert("产地不允许为空！");
 return false;
}
if($("#weigh").val() == ""){
 alert("总数量不允许为空！");
 return false;
}
if($("#pric").val() == ""){
 alert("单价不允许为空！");
 return false;
 }
 return true;
}

$(function(){
$("#test").submit(function(){
return checkNul();
  });
});
-->
</script>

  </head>
  
  <body>
  <form action="AddServlet" method="post" id="test">
    <p>水果类型:&nbsp;&nbsp;<input type="text" name="tye" id="typ" size="30" /></p>
    <p>品种:&nbsp;&nbsp;<input type="text" name="breed" id="bree" size="30" /></p>
    <p>产地:&nbsp;&nbsp;<input type="text" name="area" id="are" size="30" /></p>
    <p>描述:</p>
    <textarea rows="10" cols="100" name="brice"></textarea>
    <p>总数量(公斤):&nbsp;&nbsp;<input type="text" name="weights" id="weigh" size="30"></p>
    <p>单价(元/公斤):&nbsp;&nbsp;<input type="text" name="price" id="pric" size="30"></p>
    <input type="submit" style="height:35px;width:100px" value="提交" />&nbsp;&nbsp;
    <input type="reset" style="height:35px;width:100px" value="重置" />&nbsp;&nbsp;
    <input type="button" value="返回" style="height:35px;width:120px" 
    onclick="javascript:confirm('要离开吗？')?location.href='QueryServlet':'#'" />
    </form>
  </body>
</html>
