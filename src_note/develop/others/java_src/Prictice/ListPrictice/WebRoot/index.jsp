<%@page import="me.test.ListTest"%>
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
	<style type="text/css">
	<!--
	  a{text-decoration:none;}
	  dt{text-align:center;}
	  dd{float:left;background:black;color:yellow;}
	-->
	</style>
  </head>
  
  <body>
  <div><dl>
  <dt>命令列表</dt>
  <%  
    List<String> lists = new ArrayList<String>();
    String[] cmdlist = new String[]{"cmd","sc","start","rd","mkdir","dir","move"};
    for(int i=0;i<cmdlist.length;i++){
    String x = cmdlist[i];
    lists.add(x);
     }
   %>
   <%
     for(int i =0;i<lists.size();i++){
      String x = lists.get(i);
    %>
      <a href="#"><%=x %></a>&nbsp;&nbsp;&nbsp;
    <%}%>
    </br>
    <%
    for(String s : cmdlist){
   %>
   <dd><a href="#" ><%=s %></a></dd>
   <%} %>
  </dl></div>
  <br>
  </body>
</html>
