<%@page import="cn.accp.dao.impl.NewsDaoImp"%>
<%@page import="cn.accp.entity.News"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
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

<!-- 
	private int nid;
	
	private int ntid;
	
	private String ntitle;
	
	private String nauthor;
	
	private Date ncreateDate;
	
	private String npicPath;
	
	private String ncontent;
	
	private Date nmodifyDate;
	
	private String nsummary;
 -->

  
  <body>
    <table>
    <% 
    String name = (String)request.getAttribute("name");
    //List list = (List)request.getAttribute("list");
    List<String> list2 = (List<String>)request.getAttribute("list2");
    %>
    <tr>
     <td>编号</td>
     <td>id</td>
     <td>新闻标题</td>
     <td>作者</td>
     <td>创建日期</td>
     <td>路径</td>
     <td>描述</td>
     <td>修改日期</td>
     <td>Others:${name}</td>
    </tr>
   <%
     for(String s : list2){
     %>
     <tr>
     <td><%=s %></td><br/>
     </tr>
    	 <%}%>
     
     <c:forEach items="${list}" var="n">
     <tr>
     <td>${n.nid }</td>
     <td>${n.ntid}</td>
     <td>${n.ntitle }</td>
     <td>${n.nauthor}</td>
     <td>${n.ncreateDate}</td>
     <td>${n.npicPath}</td>
     <td>${n.ncontent}</td>
     <td>${n.nmodifyDate}</td>
     <td>${n.nsummary}</td>
    </tr>
     </c:forEach>
    
    <%--
      for(int i=0;i<list.size();i++){
       News n = (News)list.get(i);
     %>
     <tr>
    <td><a href="#"><%=n.getNid() %></a></td>
    <td><a href="#"><%=n.getNtid() %></a></td>
    <td><a href="#"><%=n.getNtitle() %></a></td>
    <td><a href="#"><%=n.getNauthor() %></a></td>
    <td><a href="#"><%=n.getNcreateDate() %></a></td>
    <td><a href="#"><%=n.getNpicPath() %></a></td>
    <td><a href="#"><%=n.getNcontent() %></a></td>
    <td><a href="#"><%=n.getNmodifyDate() %></a></td>
    <td><a href="#"><%=n.getNsummary() %></a></td>
    </tr>
    <%} --%>
    </table>
  
  </body>
</html>
