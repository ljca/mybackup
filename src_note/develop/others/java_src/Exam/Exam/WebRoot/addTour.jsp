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

<title>My JSP 'addTour.jsp' starting page</title>

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
	function check() {
		if (document.getElementById("city").value == "") {
			alert("国家/城市不能为空！");
			return false;
		} else if (document.getElementById("place").value == "") {
			alert("区域/景点不能为空！");
			return false;
		} else if (document.getElementById("time").value == "") {
			alert("旅游时间不能为空！");
			return false;
		} else if (document.getElementById("note").value == "") {
			alert("经历记录不能为空！");
			return false;
		}
		return true;

	}

	function check2() {
		if ($("#city").val() == "") {
			alert("国家/城市不能为空！");
			return false;
		}
		if ($("#place").val() == "") {
			alert("区域/景点不能为空！");
			return false;
		}
		if ($("#time").val() == "") {
			alert("旅游时间不能为空！");
			return false;
		}
		if ($("#note").val() == "") {
			alert("经历记录不能为空！");
			return false;
		}
		return true;

	}

	-->
</script>


</head>

<body>
	<div>
		<h1>保存旅游经历</h1>
		<form action="AddServlet" method="post" onsubmit="return check()">
			<p>
				国家/城市：&nbsp;&nbsp;<input type="text" name="city" size="35" id="city" />
			</p>
			<p>
				区域/景点：&nbsp;&nbsp;<input type="text" name="place" size="35"
					id="place" />
			</p>
			<p>
				旅游时间：&nbsp;&nbsp;<input type="text" name="time" size="35" id="time" />
			</p>
			<p>
				经历记录
				<textarea rows="15" cols="80" name="note" id="note"></textarea>
			</p>
			<p>
				<span><a href="QueryServlet">查看所有</a></span>
				<input type="submit" name="" value="提交" />
			</p>
		</form>
	</div>
</body>
</html>
