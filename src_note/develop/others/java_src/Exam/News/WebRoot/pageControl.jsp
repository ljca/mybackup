<%@page import="news.entity.News"%>
<%@page import="news.dao.impl.NewsDaoImp"%>
<%@page import="news.entity.Page"%>
<%@ page language="java" import="java.util.*" pageEncoding="utf-8"%>
<%
String path = request.getContextPath();
String basePath = request.getScheme()+"://"+request.getServerName()+":"+request.getServerPort()+path+"/";
%>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
  <head>
    <base href="<%=basePath%>">
    
    <title>My JSP 'pageControl.jsp' starting page</title>
    
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
     String pageIndex = request.getParameter("pageIndex");
     if(null == pageIndex){
       pageIndex = "1";
     }
     int currentNo = Integer.parseInt(pageIndex);
     Page pages = new Page();
     pages.setPageSize(20); // 每页显示记录
     pages.setTotalCount(new NewsDaoImp().getTotalCount()); // 获得新闻总记录数
     int totalpageCount = pages.getTotalPageCount(); //获得总页数
     if(currentNo < 1){
       currentNo = totalpageCount;
     }else if(currentNo > pages.getTotalPageCount()){
       currentNo = 1;
     }
     pages.setCurrpageNo(currentNo); //设置当前页面页码
     List<News> list = new NewsDaoImp().queryNews(pages.getPageSize(),pages.getCurrpageNo()); // 查询新闻记录
     pages.setNewsList(list);
    request.setAttribute("pages",pages);
    request.getRequestDispatcher("index.jsp").forward(request, response);
    %>
  </body>
</html>
