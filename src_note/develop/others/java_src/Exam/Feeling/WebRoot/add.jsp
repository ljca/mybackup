<%@ page language="java" import="java.util.*" pageEncoding="utf-8"%>
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

<title>记录心情</title>

<meta http-equiv="pragma" content="no-cache">
<meta http-equiv="cache-control" content="no-cache">
<meta http-equiv="expires" content="0">
<meta http-equiv="keywords" content="keyword1,keyword2,keyword3">
<meta http-equiv="description" content="This is my page">
<!--
	<link rel="stylesheet" type="text/css" href="styles.css">
	-->
<script type="text/javascript" src="js/jquery-1.8.3.js"></script>
<script type="text/javascript">
	<!--
	function check(){
	if(document.getElementById("title").value == ""){
	 alert("标题不能为空！");
	 return false;
	}else if(document.getElementById("date").value == ""){
   alert("日期不能为空！");
   return false;
   }else if(document.getElementById("content").value == ""){
	 alert("内容不能为空！");
	 return false;
	 <!--$("#type").val() == 0-->
	}else if(document.getElementById("type").selectedIndex == 0){
	 alert("请选择一个类别！");
	 return false;
	}
	return true;
	}
	//-->
</script>
</head>

<body>

	<form action="AddServlet" method="post" onsubmit="return check();">
		<div>
			<p>
				标题:&nbsp;&nbsp;<input type="text" name="title" id="title" size="30" />
			</p>
			<p>
				日期:&nbsp;&nbsp;<input type="text" name="date" id="date" size="30" />
			</p>
			<span>内容</span>
			<p>
				<textarea rows="10" cols="100" name="content" id="content"></textarea>
			</p>
			<p>
				类别:<select name="type" id="type">
					<option value="0">--请选择类别--</option>
					<option value="1">有感而发</option>
					<option value="2">杂七杂八</option>
					<option value="3">踩脚印</option>
				</select>
			</p>
			<p>
				<input type="submit" value="保存" />
			</p>
			<a href="QueryServlet">返回</a>
		</div>
	</form>
</body>
</html>
