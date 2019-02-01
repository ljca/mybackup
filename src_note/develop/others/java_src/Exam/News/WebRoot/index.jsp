<%@page import="news.entity.Page"%>
<%@page import="news.entity.News"%>
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
     <table>
     <%Page pages = (Page)request.getAttribute("pages");
       if(pages == null){
         response.sendRedirect("pageControl.jsp?pageindex=1");
       }else{%>
      
      <%
        int totalPageCount = pages.getTotalPageCount();
        int pageIndex = pages.getCurrpageNo();
       %>
       
     <% for(News x : pages.getNewsList()){ %> 
      <tr>
     <td><%=x.getNid() %></td>
     <td><%=x.getNtitle() %></td>
     <td><%=x.getNcreatedate() %></td>
     </tr>
      <%} %>
     </table>
     
     当前页:[<%=pageIndex %>/<%=totalPageCount %>]
     
     <%-- if(pageIndex > 1){ --%>
     <a href="pageControl.jsp?pageIndex=1">首页</a>
      <a href="pageControl.jsp?pageIndex=<%=pageIndex-1 %>">上一页</a>
      <%--}--%>
      
      <%--if(pageIndex > totalPageCount){ --%>
     <a href="pageControl.jsp?pageIndex=<%=pageIndex+1 %>">下一页</a>
     <a href="pageControl.jsp?pageIndex=<%=totalPageCount%>">末页</a>
      <%--}--%>
      <% }%>
      
  </body>
</html>
