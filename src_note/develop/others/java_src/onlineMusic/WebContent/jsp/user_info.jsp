<?xml version="1.0" encoding="utf-8"?>
<%@ page language="java" import="java.lang.*" contentType="text/html;charset=utf-8" %>
<%
String path=request.getContextPath();
String basePath=request.getScheme()+"//"+request.getServerName()+":"+request.getServerPort()+path+"/";
%>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/xhtml1-transitional.dtd">
<html xmls="http://www.w3.org/1999/xhtml">
<head>
  <base href="<%= basePath%>" />
<script type="text/javascript">
<!--


//-->
</script>
</head>
<body>
  <!-- 保存用户信息到会话中 -->

  <%-- 保存用户信息到会话中！ --%>
 <%
String tmp = (String)session.getAttribute("user");
String num = (String)session.getAttribute("id");
 %>
 <div>
   <h5>欢迎您,<%=tmp%>!您的id是<%=num%></h5>
   <a href="index.jsp">回到首页？</a>
 </div>
</body>
</html>
