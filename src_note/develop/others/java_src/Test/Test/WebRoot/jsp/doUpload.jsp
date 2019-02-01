<%@page import="java.io.File"%>
<%@page import="org.apache.commons.fileupload.FileItem"%>
<%@page import="org.apache.commons.fileupload.disk.DiskFileItemFactory"%>
<%@page import="org.apache.commons.fileupload.FileItemFactory"%>
<%@page import="org.apache.commons.fileupload.servlet.ServletFileUpload"%>
<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>

<%
String path = request.getContextPath();
String basePath = request.getScheme()+"://"+request.getServerName()+":"+request.getServerPort()+path+"/";
%>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
  <head>
    <base href="<%=basePath%>">
    
    <title>My JSP 'doUpload.jsp' starting page</title>
    
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
  <%
    ServletFileUpload upload = new ServletFileUpload(new DiskFileItemFactory());
    if(ServletFileUpload.isMultipartContent(request)){
      List<FileItem> items = upload.parseRequest(request);
      Iterator<FileItem> iterator = items.iterator();
      while(iterator.hasNext()){
        FileItem item = (FileItem)iterator.next();
        if(item.isFormField()){
          //out.print(item.getString("utf-8"));
          out.print("xx");
        }else{
        //item.write(new File("I:\\temp.log"));
        //String x = item.getName();
          out.print(item.getName() + "大小" + item.getSize());
        }
      }
      out.flush();
      out.close();
    }
   %>
   <script type="text/javascript">alert("");</script>
  </body>
</html>
