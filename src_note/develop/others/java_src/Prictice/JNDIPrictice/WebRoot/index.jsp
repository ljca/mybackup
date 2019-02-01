<%@page import="cn.jdbc.news.dao.BaseDao"%>
<%@page import="java.sql.Connection"%>
<%@ page import="javax.sql.DataSource" %>
<%@ page import="javax.naming.*" %>
<%@ page language="java" import="java.util.*" pageEncoding="utf-8"%>
<%
String path = request.getContextPath();
String basePath = request.getScheme()+"://"+request.getServerName()+":"+request.getServerPort()+path+"/";
%>

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
  </head>
  
  <body>
  <%--
     
       Context ctx = new InitialContext();
       String testjndi = (String)ctx.lookup("java:comp/env/tjndi");
       out.print(testjndi);
     --%>
     <%--
       Context ctx = new InitialContext();
       DataSource ds = (DataSource)ctx.lookup("java:comp/env/jdbc/news");
       Connection con = ds.getConnection();
      --%>
     
     <%
       BaseDao base = new BaseDao();
       Connection con = base.openConnection();
       if(null != con){
         out.print("连接建立成功！");
         base.closeCon();
       }else{
        out.print("连接建立失败！");
       }
      %>
     
     <br>
  </body>
</html>
