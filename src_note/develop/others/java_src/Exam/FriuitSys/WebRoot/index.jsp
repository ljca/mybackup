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
    
    <title>My JSP 'index.jsp' starting page</title>
	<meta http-equiv="pragma" content="no-cache">
	<meta http-equiv="cache-control" content="no-cache">
	<meta http-equiv="expires" content="0">    
	<meta http-equiv="keywords" content="keyword1,keyword2,keyword3">
	<meta http-equiv="description" content="This is my page">

	<style type="text/css">
	<!--
	 table{border:1px solid black;}
   td{border:none;height:25px;width:800px;}
   -->
	</style>
	<script src="js/jquery-1.8.3.js" type="text/javascript"></script>
	<script type="text/javascript">
	<!--
	$(function(){
	  $("tr:even").css("background-color","#efefef");
	});
	-->
	</script>
	
  </head>
  
   <!-- FRUIT_ID TYPE BREED AREA BRICE WEIGHT PRICE -->
  <body>
     <table>
     <tr>
     <th>类别</th>
     <th>品种</th>
     <th>产地</th>
     <th>总重量(公斤)</th>
     <th>单价(元/公斤)</th>
     <th>操作</th>
     </tr>
     
     <c:forEach items="${list}" var="l">
     <tr>
     <td>${l.type}</td>
     <td>${l.breed}</td>
     <td>${l.area}</td>
     <td>${l.weight}</td>
     <td>${l.price}</td>
     <td><a href="QueryServletID?id=${l.fruitID}">详情</a>
        <a href="javascript:confirm('确定删除吗？')? location.href='DelServlet?id=${l.fruitID}':location.href='QueryServlet'">删除</a>
    <a href="addFruit.jsp">添加</a></td>
     </tr>
     
     </c:forEach>
     </table>
     
  </body>
</html>
