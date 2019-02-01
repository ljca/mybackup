<%@page import="accp.test.entity.Fruit"%>
<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>
<%
String path = request.getContextPath();
String basePath = request.getScheme()+"://"+request.getServerName()+":"+request.getServerPort()+path+"/";
%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
  <head>
    <base href="<%=basePath%>">
    
    <title>My JSP 'fruitDescription.jsp' starting page</title>
    
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
  <h4>水果详情</h4>
  <table>
  <!--
  <tr><th>类别</th><td>${list2.type}</td></tr>
   <tr><th>品种</th><td>${list2.breed}</td></tr>
   <tr><th>产地</th><td>${list2.area}</td></tr>
   <tr><th>描述</th><td>${list2.description}</td></tr>
   -->

    <tr>
    <th>类别</th>
    <td>${f.type}</td>
    </tr>
    
    <tr>
    <th>品种</th>
    <td>${f.breed}</td>
    </tr>
    
    <tr>
    <th>产地</th>
    <td>${f.area}</td>
    </tr>
    
    <tr>
    <th>描述</th>
    <td>${f.brice}</td>
    </tr>
</table>
<a href="QueryServlet" style="float:right">返回</a>
  </body>
</html>