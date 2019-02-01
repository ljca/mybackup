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
	<!--
	<link rel="stylesheet" type="text/css" href="styles.css">
	-->
	
	<style>
	<!--	
	table{border:1px black solid;}
	td{width:800px;border:none;height:30px;}
	a #atten{float:right;}
	tr th{text-align:center;}
	-->
	</style>
	
	<script type="text/javascript" src="js/jquery-1.8.3.js"></script>
	<script type="text/javascript">
	<!--
	 $(function(){
	   $("tr:odd").css("background-color","#efefef");
	 });
	-->
	</script>
  </head>
 
 <!--
  private int id; //员工编号
  
  private String empName; //员工姓名
  
  private String dept; //所属部门
  
  private Date chkDate; //考勤日期
  
  private String status; //考勤状态
  -->
  
  <body>
    <table>
    <tr>
    <td>考勤记录信息</td>
    </tr>
    <tr>
    <th>员工姓名</th>
    <th>所属部门</th>
    <th>考勤日期</th>
    <th>考勤状态</th>
    </tr>
    <c:forEach items="${list}" var="l">
    <tr>
    <td>${l.empName}</td>
    <td>${l.dept}</td>
    <td>${l.chkDate}</td>
    <td>${l.status}</td>
    </tr>
    </c:forEach>
    
    </table>
    <a href="addAttence.jsp" id="atten">考勤登记</a>
  </body>
</html>
