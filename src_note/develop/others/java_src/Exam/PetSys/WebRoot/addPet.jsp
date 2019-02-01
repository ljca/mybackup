<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>
<%
String path = request.getContextPath();
String basePath = request.getScheme()+"://"+request.getServerName()+":"+request.getServerPort()+path+"/";
%>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
  <head>
    <base href="<%=basePath%>">
    
    <title>My JSP 'addPet.jsp' starting page</title>
    
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
  <form action="AddServlet" method="post">
   <table>
   <tr></tr>
   <tr><td>昵称:</td><td><input type="text" name="nickname" id="" size="30"/></td></tr>
   <tr><td>品种:</td><td>
   <select>
   <option>--请选择--</option>
   <option value="1">狗</option>
   <option value="2">猫</option>
   <option value="3">老鼠</option>
   <option value="4">鸟</option>
   </select>
   </td></tr>
   <tr><td>性别:</td>
   <td><input type="radio" name="sex" value="雌" />雌
   <td><input type="radio" name="sex" value="雄"/>雄
   </td></tr>
   <tr><td>出生日期:</td><td><input type="text" name="birth" id="" size="30"/></td></tr>
   <tr><td>宠物描述:</td>
   <td>
   <textarea rows="15" cols="900" name="description"></textarea>
   </td></tr>
   <tr><td><input type="submit"  value="提交" size="15"/></td>
   <td><input type="reset" value="重置" size="15"/></td></tr>
   </table> 
   </form>
  </body>
</html>
