<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>
<%
String path = request.getContextPath();
String basePath = request.getScheme()+"://"+request.getServerName()+":"+request.getServerPort()+path+"/";
%>
<%@taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
<head>
<base href="<%=basePath%>">

<title>地铁线路信息列表</title>
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
	td{border:none;width:700px;height: 25px;}
	-->
	</style>
	
	<script type="text/javascript" src="js/jquery-1.8.3.js"></script>
	<script type="text/javascript">
	<!--
	$(function(){
	$("tr:even").css({"background-color":"#efefef",border:"none"});
	$("tr td").css({"text-align":"center"});
	});
	
	//-->
	</script>
	
	
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
	<table>
	<tr><td colspan="4" align="right"><h1>地铁线路信息列表</h1></td></tr>
		<tr>
			<th>线路名称</th>
			<th>始发站</th>
			<th>终点站</th>
			<th>途经站点数</th>
		</tr>
		<c:forEach items="${list}" var="l">
			<tr>
				<td><a href="QueryServletByID?id=${l.id}">${l.subwayName}</a></td>
				<td>${l.startStation}</td>
				<td>${l.endStation}</td>
				<td>${l.stationNum}</td>
			</tr>
		</c:forEach>
	</table>
	
	<div>
	  <p><span>请选择一个始发站：</span>
	  <select>
	  <option>--请选择--</option>
	  <c:forEach items="${list}" var="x">
	  <option value="${x.id}">${x.startStation}</option>
	  </c:forEach>
	  </select>
	  </p>
	</div>
	
</body>
</html>
