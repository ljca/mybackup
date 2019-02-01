<%@ page language="java" import="java.util.*" pageEncoding="utf-8"%>
<%
String path = request.getContextPath();
String basePath = request.getScheme()+"://"+request.getServerName()+":"+request.getServerPort()+path+"/";
%>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
  <head>
    <base href="<%=basePath%>">
    
    <title>My JSP 'login.jsp' starting page</title>
    
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
    <form action="index.jsp" method="post">
    用户名:<input type="text" value="" size="30" name="uname" />
    密码:<input type="password" value="" size="30" name="" />
    <input type="submit" name="" value="提交" />
    </form>
    
    <%
      String uname = request.getParameter("uname");
      request.setAttribute("uname", uname);
      
      Map m = new HashMap();
      m.put("one", "Yellow");
      m.put("two", "Black");
      request.setAttribute("m", m);
      //request.getRequestDispatcher("index.jsp").forward(request, response);
     %>
    
  </body>
</html>
