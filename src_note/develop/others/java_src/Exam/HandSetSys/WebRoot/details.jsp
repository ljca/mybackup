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
    
    <title>手机详情</title>
    
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
h1{text-align:center;}
td{width:700px;height:35px;}
-->

</style>

  </head>
 
  <body>
  <h1>${h.nameType}</h1>
    <table align="center">
    <tr>
    <th>参考报价</th>
    <td>${h.price}</td>
    </tr>
    
    <tr>
    <th>网络模式</th>
    <td>${h.networkMode}</td>
    </tr>
    <tr>
    <th>网络类型</th>
    <td>${h.networkType}</td>
    </tr>
    
    <tr>
    <th>外观设计</th>
    <td>${h.facade}</td>
    </tr>
    
    <tr>
    <th>主屏尺寸</th>
    <td>${h.screenSize}</td>
    </tr>
    
    <tr>
    <th>触摸屏</th>
    <td>${h.feelScreen}</td>
    </tr>
    </table>
        <a href='QueryServlet' style='float:right'>返回</a>
  </body>
</html>
