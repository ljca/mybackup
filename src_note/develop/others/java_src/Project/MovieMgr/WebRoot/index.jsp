<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>
<%
  String path = request.getContextPath();
  String basePath = request.getScheme() + "://" + request.getServerName() + ":" + request.getServerPort() + path + "/";
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
</head>
<!-- 
   private Integer id;
  private MovieType movietype;
  private String mname;
  private String mrole;
  private String mdirector;
  private Double mprice;
   -->

<body>
	<table>
		<tr>
			<th>电影名称</th>
			<th>主演</th>
			<th>导演</th>
			<th>电影票价</th>
		</tr>
		<c:forEach items="${list}" var="m">
			<tr>
				<%-- <td>${m.id}</td> --%>
				<td>${m.mname}</td>
				<td>${m.mdirector}</td>
				<td>${m.mrole}</td>
				<td>${m.mprice}</td>
			</tr>
		</c:forEach>
	</table>
</body>
</html>
