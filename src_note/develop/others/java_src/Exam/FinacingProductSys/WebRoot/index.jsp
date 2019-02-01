<%@ page language="java" import="java.util.*" pageEncoding="utf-8"%>
<%
String path = request.getContextPath();
String basePath = request.getScheme()+"://"+request.getServerName()+":"+request.getServerPort()+path+"/";
%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>

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
	td{border:none;}
	-->
	</style>
	
	<script type="text/javascript">
	<!--
	-->
	</script>
  </head>
  
  <body>

    <table border="1" cellpadding="5">
    <tr><th>
    产品代码 <input type="text" value="" name="" size="30" id="id"/>
    风险等级<select name="" id="risk">
    <option selected="selected">请选择</option>
    <option>R1</option>
    <option>R2</option>
    <option>R3</option>
    </select>
    <input type="button" value="查询" name="" />
    <a href="#">新增理财信息</a>
    </th></tr>
    <tr>
    <th>产品代码</th>
    <th>风险等级</th>
    <th>预期收益</th>
    <th>发售起始日</th>
    <th>发售结束日</th>
    <th>产品到期日${l }</th>
    </tr>
    <!--
	Id
	Risk
	Income
	SaleStarting
	SaleEnd
	End
	-->
    <c:forEach items="${list }" var="l">
    <tr>
    <td>${l.id }</td>
    <td>${l.risk }</td>
    <td>${l.income }</td>
    <td>${l.saleStarting }</td>
    <td>${l.saleEnd }</td>
    <td>${l.end }</td>
    </tr>
    </c:forEach>
    </table>
  </body>
</html>
