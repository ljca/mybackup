<%@ page language="java" import="java.util.*" pageEncoding="utf-8"%>
<%
  String path = request.getContextPath();
  String basePath = request.getScheme() + "://" + request.getServerName() + ":" + request.getServerPort() + path + "/";
%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
<head>
<base href="<%=basePath%>">

<title>My JSP 'detail.jsp' starting page</title>

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
* {
	margin: 0px auto;
	padding: 0px;
}

a {
	text-align: center;
	float:right;
}

div p {
	text-align: center;
}
-->
</style>

</head>

<body>
	<table align="center">
		<tr>
			<th>标题:</th>
			<td>${f.ftitle}</td>
		</tr>
		<tr>
			<th>内容:</th>
			<td>${f.fcontent}</td>
		</tr>
		<tr>
			<th>类别:</th>
			<td><c:if test="${f.ftype == 1}">有感而发</c:if> <c:if
					test="${f.ftype == 2}">杂七杂八</c:if> <c:if test="${f.ftype == 3}">踩脚印</c:if>
			</td>
		</tr>
		<tr>
			<th>日期:</th>
			<td>${f.fdate}</td>
		</tr>
	</table>
	<a href="QueryServlet">返回</a>
</body>
</html>
