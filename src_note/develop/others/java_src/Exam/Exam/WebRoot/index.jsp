<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>
<%
  String path = request.getContextPath();
			String basePath = request.getScheme() + "://"
					+ request.getServerName() + ":" + request.getServerPort()
					+ path + "/";
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
<!--
	<link rel="stylesheet" type="text/css" href="styles.css">
	-->
<style type="text/css">
<!--
table {
	border: black solid 1px;
}

td {
	border: none;
	width: 1000px;
	height: 35px;
}
-->
</style>
<script type="text/javascript" src="js/jquery-1.8.3.js"></script>
<script type="text/javascript">
<!--
	$(function() {
		$("tr:even").css("background-color", "#efefef");
	});

	-->
</script>

</head>

<body>
	<h1 align="center">查看所有</h1>
	<table>
		<tr>
			<th>编号</th>
			<th>国家/城市</th>
			<th>区域/景点</th>
			<th>旅游时间</th>
			<th>经历记录</th>
			<th>操作</th>
		</tr>

		<!-- 
  private int tourId;
  
  private String tourCity;
  
  private String tourPlace;
  
  private Date tourTime;
  
  private String tourNote;
  -->


		<c:forEach items="${list}" var="l">
			<tr>
				<td>${l.tourId}</td>
				<td>${l.tourCity}</td>
				<td>${l.tourPlace}</td>
				<td>${l.tourTime}</td>
				<td>${l.tourNote}</td>
				<td><a
					href="javascript:confirm('确认删除吗？')?location='DelServlet?id=${l.tourId}':location='QueryServlet'">删除</a>
				</td>
			</tr>
		</c:forEach>
	</table>
	<a href="addTour.jsp">新建旅游经历</a>
</body>
</html>
