<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>
<%
  String path = request.getContextPath();
			String basePath = request.getScheme() + "://"
					+ request.getServerName() + ":" + request.getServerPort()
					+ path + "/";
%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>

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
a,#add {
	text-decoration: none;
	color: red;
}

a:hover {
	text-decoration: underline;
}

table {
	border: 1px black solid;
}

td {
	width: 800px;
	border: none;
	height: 30px;
}

tr th {
	text-align: center;
}
-->
</style>

<script type="text/javascript" src="js/jquery-1.8.3.js"></script>
<script type="text/javascript">
<!--
  $(function(){
    $("tr:odd").css("background-color","#efefef");
  });
// -->
</script>

</head>

<body>
  <%--   <div>
    <div>
      <a href="addRecords.jsp">添加请假记录</a>
      <h1>请假记录列表</h1>
      
    </div>
    <div>
      <c:forEach items="${leave}" var="l">
        <p>${l.id }</p>
        <p>${l.name }</p>
        <p>${l.time }</p>
        <p>${l.reason }</p>
        <a href="DelServlet?id=${l.id }">删除</a>
      </c:forEach>
    </div>
  </div> --%>

  <div>
    <a href="addRecords.jsp" id="add">添加记录</a>
    <h2>请假记录列表</h2>
  </div>

  <div>
    <table>
      <tr>
        <th>编号</th>
        <th>姓名</th>
        <th>请假时间</th>
        <th>请假原因</th>
        <th>操作</th>
      </tr>
      <c:forEach items="${leave}" var="l">
        <tr>
          <td>${l.id}</td>
          <td>${l.name}</td>
          <td>${l.time}</td>
          <td>${l.reason}</td>
          <td><a href="javascript:confirm('确定要删除吗？') ?
          location.href='DelSerlvet?id=${l.id}' : location.href='QueryServlet'">删除</a></td>
        </tr>
      </c:forEach>

    </table>
  </div>
</body>
</html>
