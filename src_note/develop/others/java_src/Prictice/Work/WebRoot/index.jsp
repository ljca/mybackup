<%@ page language="java" import="java.util.*" pageEncoding="utf-8"%>
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
  </head>
  
  <body>
  <h2>工作笔记</h2>
  <span><a href="add.jsp">添加笔记</a></span>
   <table>
   <tr>
    <td>笔记标题</td>
    <td>笔记分类</td>
    <td>编写时间</td>
    <td>操作</td>
   </tr>
   <!-- 
   /*
	Id
	Title
	Content
	Date
	Type
	*
    -->
   
   <c:forEach items="${list }" var="l" varStatus="x">
   <tr 
   <c:if test="${x.index % 2 == 1 }"> style="background-color:#efefef;"</c:if>
   >
    <td>${l.title }</td>
    <td>${l.type }</td>
    <td>${l.date}</td>
    <td><a herf="#">查看</a></td>
   </tr>
   </c:forEach>
   
   </table>
  </body>
</html>
