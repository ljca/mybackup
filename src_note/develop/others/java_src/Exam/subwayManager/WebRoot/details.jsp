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

<title>地铁信息详情</title>

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
  private int id;
  
  private String subwayName;
  
  private String startStation;
  
  private String endStation;
  
  private int stationNum;
  
  private String startTime;
  
  private int price;
 -->
<body>
<h3 align="center">地铁线路详细信息</h3>
	<table align="center">
		<tr>
			<th>线路名称</th>
			<td>${s.subwayName}</td>
		</tr>

		<tr>
			<th>始发站</th>
			<td>${s.startStation}</td>
		</tr>

		<tr>
			<th>终点站</th>
			<td>${s.endStation}</td>
		</tr>

		<tr>
			<th>途经站点数</th>
			<td>${s.stationNum}</td>
		</tr>

		<tr>
			<th>首车时间</th>
			<td>${s.startTime}</td>
		</tr>

		<tr>
			<th>票价(元)</th>
			<td>${s.price}</td>
		</tr>

		<tr>
			<td colspan="2" align="center"><a href="QueryServlet">返回首页</a></td>
		</tr>
	</table>
</body>
</html>
