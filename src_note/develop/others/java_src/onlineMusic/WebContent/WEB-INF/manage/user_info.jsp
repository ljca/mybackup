<?xml version="1.0" encoding="utf-8"?>
<%@ page language="java" import="java.lang.*" contentType="text/html;charset=utf=8" %>
<%

%>

<!DOCTYPE HTML PUBLIC>
<html xmlns="">
<haed>
<script type="text/javascript">
<!--


//-->
</script>
</head>
<body>
 <%
String tmp = (String)session.getAttribute("user");
 %>
 <div>
   <h5>欢迎您,<%=tmp%>!</h5>
 </div>
</body>
</html>
