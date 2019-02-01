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
	table{ border:1px black solid; height: 30px;
	 width:800px;}
	  td{border:none;}
	-->
	</style>
	
	<script src="js/jquery-1.8.3.js" type="text/javascript"></script>
	<script>
	<!--
	
	-->
	</script>
	
  </head>
  
  <body>
    <table>
    <tr><td>品种<select>
    <option></option>
    </select></td>
    <td><input type="button" size="15" value="查询" /></td>
    <td><a href="addPet.jsp">新增宠物</a></td>
    </tr>
    
    <tr>
    <th>宠物昵称</th>
    <th>出生日期</th>
    <th>性别</th>
    </tr>
    
    <c:forEach items="${list }" var="l">
      <tr>
      <td>${l.petName }</td>
      <td>${l.birthday }</td>
      <td>${l.petSex }</td>
    </tr>
    </c:forEach>
    </table>
  </body>
  
</html>
