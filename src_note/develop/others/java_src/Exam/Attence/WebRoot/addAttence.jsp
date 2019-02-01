<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>
<%
String path = request.getContextPath();
String basePath = request.getScheme()+"://"+request.getServerName()+":"+request.getServerPort()+path+"/";
%>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
  <head>
    <base href="<%=basePath%>">
    
    <title>My JSP 'addEmp.jsp' starting page</title>
    
	<meta http-equiv="pragma" content="no-cache">
	<meta http-equiv="cache-control" content="no-cache">
	<meta http-equiv="expires" content="0">    
	<meta http-equiv="keywords" content="keyword1,keyword2,keyword3">
	<meta http-equiv="description" content="This is my page">
	<!--
	<link rel="stylesheet" type="text/css" href="styles.css">
	-->

<style>
<!--
table{border:black solid 1px;}
td{border:none;height:35px;}
-->
</style>

<script type="text/javascript" src="js/jquery-1.8.3.js"></script>
<script type="text/javascript">
<!--
function chkNull(){
var temp = /^\d{4}-\d{1,2}-\d{1,2}$/;
if($("name=name").val() == ""){
alert("姓名不能为空！");
return false;
}
if($("name=dept").val() == ""){
alert("所属部门不能为空！");
return false;
}
if($("name=chkdate").val() == ""){
alert("考勤日期不能为空！");
return false;
}
else if(temp.test($("name=chkdate").val())){
alert("日期格式应该为yyyy-mm-dd!");
return false;
}
if($("name=state").val() == ""){
alert("考勤状态不能为空！");
return false;
}
return true;
}

$(function(){
$("form").submit(function(){
return chkNull();
  });
});
-->
</script>
  </head>
  
  <body>
  <form action="AddServlet" method="post">
    <table>
    <tr><td style="text-align:center;">考勤记录信息表</td></tr>
    
    <tr>
    <td>姓名:</td>
    <td><input type="text" name="name" size="100%"/></td>
    </tr>
    
    <tr>
    <td>所属部门:</td>
    <td><input type="text" name="dept" size="100%" /></td>
    </tr>
    
    <tr>
    <td>考勤日期:</td>
    <td><input type="text" name="chkdate" size="100%" /></td>
    </tr>
    
    <tr>
    <td>考勤状态:</td><td><input type="text" name="state" size="100%" /></td>
    </tr>
    
    <tr>
    <td style="text-align:center;"><input type="submit" value="登记" style="height:35px;width:100px;"/>
    <input type="reset" value="重置" style="height:35px;width:100px;"/></td>
    </tr>

    </table>
    </form>
  </body>
</html>