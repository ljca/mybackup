<%@ page language="java" import="java.util.*" pageEncoding="utf-8"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"  %>
<%
String path = request.getContextPath();
String basePath = request.getScheme()+"://"+request.getServerName()+":"+request.getServerPort()+path+"/";
%>
<% List list = (List)request.getAttribute("list"); %>

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
<style type="text/css" >
<!--
table{
border:solid,1px,black;text-align: center;
}
 td{height: 50px;width: 600px;}  
-->
</style>
  </head>
  
  <body>

   <div>
   <h1 style="text-align:center;">标准信息列表</h1>
   <table>
   
   <tr><td style="align:right;">
   <input type="text" value="" size="30" name="" />&nbsp;&nbsp;
   <input type="button" value="提交检索" />&nbsp;&nbsp;
   <input type="button" value="新增标准" />&nbsp;&nbsp;
   <input type="button" value="删除标准" />
   </td></tr>
   
   <tr>
   <td><input type="checkbox" value="" name="" /></td>
   <td>标准号</td>
   <td>中文名称</td>
   <td>版本</td>
   <td>发布日期</td>
   <td>实施日期</td>
   <td>操作</td>
   </tr>
   
   <c:forEach items="${list}" var="s">
   <tr>
   <td><input type="checkbox" name="" value="" /></td>
   <td>${s.stdNum }</td> 
   <td>${s.zhname }</td>
   <td>${s.version }</td>
   <td>${s.releaseDate }</td>
   <td>${s.implDate}</td>
   <td><a href="#">下载</a><a href="#">修改</a></td>
   </tr>
   </c:forEach>  
  
<!--  
id
stdNum
zhname
version
keys
releaseDate
implDate
package
-->	
   </table>
   </div>
  </body>
</html>
