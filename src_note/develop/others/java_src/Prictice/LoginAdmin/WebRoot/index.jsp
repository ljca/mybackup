
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
    <form action="control.jsp" method="post">
     <fieldset>
      <legend>管理员登录</legend>
        <p>用户名:<input type="text" name="uname" size="25" maxlength="255" /></p>
        <p>密码:<input type="password" name="upwd" size="25" maxlength="255" /></p>
        <p><input type="submit" name="" value=" 提交" /><input type="reset" name="" value="重置" /></p>
     </fieldset>
    </form>
    
        
  </body>
</html>
