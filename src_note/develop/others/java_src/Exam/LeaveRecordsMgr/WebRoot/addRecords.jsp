<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>
<%
  String path = request.getContextPath();
			String basePath = request.getScheme() + "://"
					+ request.getServerName() + ":" + request.getServerPort()
					+ path + "/";
%>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
<head>
<base href="<%=basePath%>">

<title>My JSP 'addRecords.jsp' starting page</title>

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
-->
</style>

<script type="text/javascript" src="js/jquery-1.8.3.js"></script>
<script type="text/javascript">
<!--
  $(function(){
    $("form").submit(function(){
      return checkNull();
    });
  });

  function checkNull(){
    if($("#name").val() == "" ){
      alert("名字不能为空");
      return false;
    }else if($("#time").val() == ""){
      return false;
    }else if($("#reason").val() == ""){
      return false;
    }
return true;
  }
//-->
</script>

</head>

<body>
  <div>
    <form action="AddServlet" method="post">
      <p>
        姓名:<input name="name" id="name" type="text" />
      </p>
      <p>
        请假时间：<input type="text" name="time" id="time" />
      </p>
      <p>
        请假原因：
        <textarea name="reason" id="reason" value=""></textarea>
      </p>
      <p>
        <input type="submit" value="提交" id="" /><input type="reset" value="清空" id="" />
      </p>
    </form>
  </div>
</body>
</html>
