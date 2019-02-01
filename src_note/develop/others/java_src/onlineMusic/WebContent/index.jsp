<?xml version="1.0" encoding="utf-8"?>
<%@ page language="java" import="java.lang.*,java.util.*" contentType="text/html;charset=utf-8" %>
<%
String path=request.getContextPath();
String basePath=request.getScheme()+"//"+request.getServerName()+":"+request.getServerPort()+path+"/";
out.print(basePath+"  "+path);
%>

<!DOCTYPE HTML PUBLIC "-//W3C/DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmls="http://www.w3.org/1999/xhtml" xml:lang="en">
  <head>
    <base href="<%=basePath%>" />

    <script type="text/javascript">
<!--

            //-->
    </script> 
  </head>

  <body>
  <div>
    <h6>Hello,Jsp!</h6>
    <a href="http://localhost:8282/tmp/WEB-INF/manage/user_control.jsp?id=1">用户账户</a>
  </div>
    
  <div>
   <a href="http://localhost:8282/tmp/index.xhtml">音乐测试页面</a>
  </div>
    </body>
</html>
