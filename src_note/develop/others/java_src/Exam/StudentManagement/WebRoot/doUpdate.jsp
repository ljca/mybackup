<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>
<%
String path = request.getContextPath();
String basePath = request.getScheme()+"://"+request.getServerName()+":"+request.getServerPort()+path+"/";
%>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
  <head>
    <base href="<%=basePath%>">
    
    <title>My JSP 'doUpdate.jsp' starting page</title>
    
	<meta http-equiv="pragma" content="no-cache">
	<meta http-equiv="cache-control" content="no-cache">
	<meta http-equiv="expires" content="0">    
	<meta http-equiv="keywords" content="keyword1,keyword2,keyword3">
	<meta http-equiv="description" content="This is my page">
	<!--
	<link rel="stylesheet" type="text/css" href="styles.css">
	-->

  </head>
  
  <body>
    <form action="UpdateServlet" method="post">
    <table>
    <tr><td><h2>学员信息</h2></td></tr>
    <tr><td>学员姓名:</td>
    <td><input type="text" name="" size="30" id="stuname" /></td></tr>
    <tr><td>学员性别:</td>
    <td><input type="text" name="" size="30" id="stugender" /></td></tr>
    <tr><td>学员年龄:</td>
    <td><input type="text" name="" size="30" id="stuage" /></td></tr>
    <tr><td>家庭住址:</td>
    <td><input type="text" name="" size="30" id="stuaddr" /></td></tr>
    <tr><td>Email:</td>
    <td><input type="text" name="" size="30" id="stunmail" /></td></tr>
    <tr>
    <td><input type="submit" name="" size="15" value="提交" id="commit"/>
    <input type="reset" name="" size="15" value="重置" /></td></tr>
    </table>
    
    </form>
  </body>
</html>
