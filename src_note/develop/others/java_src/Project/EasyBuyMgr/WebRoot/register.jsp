<%@ page language="java" import="java.util.*" pageEncoding="utf-8"%>
<%
  String path = request.getContextPath();
  String basePath = request.getScheme() + "://" + request.getServerName() + ":" + request.getServerPort() + path + "/";
%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<base href="<%=basePath%>" />
<meta http-equiv="pragma" content="no-cache" />
<meta http-equiv="cache-control" content="no-cache" />
<meta http-equiv="expires" content="0" />
<meta http-equiv="keywords" content="keyword1,keyword2,keyword3" />
<meta http-equiv="description" content="This is my page" />
<title>易买网 - 首页</title>
<link type="text/css" rel="stylesheet" href="css/style.css" />
<script type="text/javascript" src="scripts/jquery-1.8.3.js"></script>
<script type="text/javascript"
	src="scripts/My97DatePicker/WdatePicker.js"></script>
<script type="text/javascript" src="scripts/function.js"></script>
</head>
<body>
	<div id="header" class="wrap">
		<div id="logo">
			<img src="images/logo.gif" />
		</div>
		<div class="help">
			<a href="shopping.jsp" class="shopping">购物车X件</a><a href="login.jsp">登录</a><a
				href="register.jsp">注册</a><a href="guestbook.jsp">留言</a><a
				href="manage/index.jsp">后台管理</a>
		</div>
		<div class="navbar">
			<ul class="clearfix">
				<li class="current"><a href="#">首页</a></li>
				<li><a href="#">图书</a></li>
				<li><a href="#">百货</a></li>
				<li><a href="#">品牌</a></li>
				<li><a href="#">促销</a></li>
			</ul>
		</div>
	</div>
	<div id="childNav">
		<div class="wrap">
			<ul class="clearfix">
				<li class="first"><a href="#">音乐</a></li>
				<li><a href="#">影视</a></li>
				<li><a href="#">少儿</a></li>
				<li><a href="#">动漫</a></li>
				<li><a href="#">小说</a></li>
				<li><a href="#">外语</a></li>
				<li><a href="#">数码相机</a></li>
				<li><a href="#">笔记本</a></li>
				<li><a href="#">羽绒服</a></li>
				<li><a href="#">秋冬靴</a></li>
				<li><a href="#">运动鞋</a></li>
				<li><a href="#">美容护肤</a></li>
				<li><a href="#">家纺用品</a></li>
				<li><a href="#">婴幼奶粉</a></li>
				<li><a href="#">饰品</a></li>
				<li class="last"><a href="#">Investor Relations</a></li>
			</ul>
		</div>
	</div>
	<div id="register" class="wrap">
		<div class="shadow">
			<em class="corner lb"></em> <em class="corner rt"></em>
			<div class="box">
				<h1>欢迎注册易买网</h1>
				<ul class="steps clearfix">
					<li class="current"><em></em>填写注册信息</li>
					<li class="last"><em></em>注册成功</li>
				</ul>
				<form id="regForm" method="post" action="reg-result.jsp">
					<table>
						<tr>
							<td class="field">用户名(*)：</td>
							<td><input class="text" type="text" name="userId"
								id="userId" maxlength="10" /> <span></span></td>
						</tr>
						<tr>
							<td class="field">真实姓名(*)：</td>
							<td><input class="text" type="text" name="userName" /><span></span></td>
						</tr>
						<tr>
							<td class="field">登录密码(*)：</td>
							<td><input class="text" type="password" id="password"
								name="password" /><span></span></td>
						</tr>
						<tr>
							<td class="field">确认密码(*)：</td>
							<td><input class="text" type="password"
								name="confirmPassword" /><span></span></td>
						</tr>
						<tr>
							<td class="field">性别(*)：</td>
							<td><input class="radio" type="radio" name="sex"
								value="male" checked="checked" /> 男性 <input class="radio"
								type="radio" name="sex" value="female" />女性
								<span></span></td>
						</tr>
						<tr>
							<td class="field">出生日期：</td>
							<td><input id="birthday" class="text" type="text"
								name="birthday" /><span></span></td>
						</tr>
						<tr>
							<td class="field">身份证：</td>
							<td><input class="text" type="text" name="identityCode" /><span></span></td>
						</tr>
						<tr>
							<td class="field">电子邮件：</td>
							<td><input class="text" type="text" name="email" /><span></span></td>
						</tr>
						<tr>
							<td class="field">手机(*)：</td>
							<td><input class="text" type="text" name="mobile" /><span></span></td>
						</tr>
						<tr>
							<td class="field">收货地址(*)：</td>
							<td><input class="text" type="text" name="address" /><span></span></td>
						</tr>
						<tr>
							<td></td>
							<td><label class="ui-green"><input type="submit"
									name="submit" value="提交注册" /></label></td>
						</tr>
					</table>
				</form>
			</div>
		</div>
		<div class="clear"></div>
	</div>
	<div id="footer">Copyright &copy; 2010 北大青鸟 All Rights Reserved.
		京ICP证1000001号</div>
</body>
</html>
