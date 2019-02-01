<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>
<%
String path = request.getContextPath();
String basePath = request.getScheme()+"://"+request.getServerName()+":"+request.getServerPort()+path+"/";
%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
  <head>
    <base href="<%=basePath%>">
    
    <title>My JSP 'index.jsp' starting page</title>
	<meta http-equiv="pragma" content="no-cache">
	<meta http-equiv="cache-control" content="no-cache">
	<meta http-equiv="expires" content="0">    
	<meta http-equiv="keywords" content="keyword1,keyword2,keyword3">
	<meta http-equiv="description" content="This is my page">
	<!--
	<link rel="stylesheet" type="text/css" href="styles.css">
	-->
	<style type="text/css">
	<!--
	table{border:1;}
	td{border:none;}
	-->
	</style>
	
  </head>
  
  <!-- 
  
   sid
 sname
 sgender
 sage
 saddress
 smail
   -->
  
  <body>
    <table cellpadding="8" border="1">
    <tr><th><h1>学员信息列表</h1></th></tr>
    <tr>
    <th>学员编号</th>
    <th>学员姓名</th>
    <th>学员性别</th>
    <th>学员年龄</th>
    <th>家庭住址</th>
    <th>Email</th>
    </tr>
    <c:forEach items="${list }" var="l">
    <tr>
    <td><a href="location.href='doUpdate.jsp?id=" >${l.sid }</a></td>
    <td>${l.sname }</td>
    <td>${l.sgender }</td>
    <td>${l.sage }</td>
    <td>${l.saddress }</td>
    <td>${l.smail }</td>
    </tr>
    </c:forEach>
    </table>
  </body>
</html>
