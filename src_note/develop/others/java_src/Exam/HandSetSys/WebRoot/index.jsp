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
    
    <title>手机信息</title>
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
	table{border:black solid 1px;}
	td{border:none;width:500px;height:35px;}
	-->
	</style>
	
	<script type="text/javascript" src="js/jquery-1.8.3.js"></script>
	<script type="text/javascript">
	$(function(){
<!--
  $("tr:even").css("background-color","#efefef");
  });
  
//-->
</script>
  </head>
  
  <body>
 
    <table>
    <tr><td colspan="3" align="center"><h1>手机信息</h1></td></tr>
    <tr>
    <th>品牌型号</th>
    <th>参考报价</th>
    <th>操作</th>
    </tr>
    
    <c:forEach items="${list}" var="l">
    <tr>
    <td>${l.nameType}</td>
    <td>${l.price}</td>
    <td>
    <a href='QueryServletByID?id=${l.hsID}'>详情</a>
    <a href="javascript:confirm('确认要删除吗？')?location='DelServlet?id=${l.hsID}':location='QueryServlet'">删除</a>
    </td>    
    </tr>
    </c:forEach>
    
    </table>
  </body>
</html>
