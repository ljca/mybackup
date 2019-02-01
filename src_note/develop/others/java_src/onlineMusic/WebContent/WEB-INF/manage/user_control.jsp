<?xml version="1.0" encoding="utf-8"?>
<%@ page language="java" import="" contentType="text/html;charset=utf-8" %>
<% 
String path=request.getContextPath();
String basePath=request.getScheme()+"//"+request.getServerName()+":"+request.getServerPort()+path+"/";

%>

<!DOCTYPE HTML PUBLIC >

<html xmlns="">
<head>
<base href="<%=basePath%>" />
<title></title>
<script type="text/javascript">
<!--


//-->
</script>
</head>
<body>

<%
 String user="kyzs";String psk="ylsllslala";
 session.setAttribute("user",user);
 response.sendRedirect("user_info.jsp");

%>

</body>
</html>
