<%@page import="cn.test.entity.Feeling"%>
<%@ page language="java" import="java.util.*" pageEncoding="utf-8"%>
<%
String path = request.getContextPath();
String basePath = request.getScheme()+"://"+request.getServerName()+":"+request.getServerPort()+path+"/";
%>
<%@ page isELIgnored="false"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
<head>
<base href="<%=basePath%>">

<title>心情日记</title>
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
	width: 800px;
	height: auto;
}
-->
</style>
<script type="text/javascript" src="js/jquery-1.8.3.js"></script>
<script type="text/javascript">
	<!--
	
	-->
	</script>

</head>

<body>
	<h2></h2>
	<a href="add.jsp">记录心情</a>
	<table>
		<tr align="center">
			<th>心情日记</th>
			<th>日记分类</th>
			<th>编写日期</th>
			<th>操作</th>
		</tr>

		<%--
    List<Feeling> list = (List<Feeling>)request.getAttribute("list");
    for(Feeling f : list){
   %>
   <tr>
   <td><%=f.getFtitle() %></td>
   <td><%=f.getFtype() %></td>
   <td><%=f.getFdate() %></td>
   </tr>
   <%} --%>

		<c:forEach items="${list}" var="l" varStatus="status">
			<tr
				<c:if test="${status.index % 2 == 0}">style="background-color:#efefef"</c:if>
				align="center">
				<td>${l.ftitle}</td>
				<td><c:if test="${l.ftype == 1}">有感而发</c:if> <c:if
						test="${l.ftype == 2}">杂七杂八</c:if> <c:if test="${l.ftype == 3}">踩脚印</c:if>
				</td>
				<td>${l.fdate}</td>
				<td><a href="QueryByIDServlet?id=${l.fid}">查看</a></td>
			</tr>
		</c:forEach>
	</table>

</body>
</html>
