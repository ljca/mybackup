<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%> <%
String path = request.getContextPath(); String basePath =
request.getScheme()+"://"+request.getServerName()+":"+request.getServerPort()+path+"/";
%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>无标题文档</title>
<link href="css/common.css" rel="stylesheet" type="text/css" />
<link href="css/style.css" rel="stylesheet" type="text/css" />
</head>

<body>
	<div class="wrap">
		<!-- main begin-->
		<div class="main">
			<div class="sidebar">
				<p>
					<img src="images/img1.jpg" width="443" height="314" alt="" />
				</p>
			</div>
			<div class="sidebarg">
				<form action="" method="post" target='_blank'>
					<div class="login">
						<dl>
							<dt class="blues">用户登陆</dt>
							<dd>
								<label for="name">用户名：</label><input type="text" class="inputh"
									value="常用邮箱" id="name" />
							</dd>
							<dd>
								<label for="password">密 码：</label><input type="text"
									class="inputh" value="密码" id="password" />
							</dd>
							<dd>
								<label class="lf" for="passwords">验证码：</label> <input
									type="text" class="inputh inputs lf" value="验证码" id="passwords" />
								<span class="wordp lf"><img src="images/img2.jpg"
									width="96" height="27" alt="" /></span> <span class="blues lf"><a
									href="" title="">看不清</a></span>
							</dd>
							<dd>
								<input name="" type="checkbox" id="rem_u" /> <span for="rem_u">下次自动登录</span>
							</dd>
							<dd class="buttom">
								<input name="" type="submit" value="登 录"
									class="spbg buttombg f14 lf" /> <input name="" type="submit"
									value="注 册" class="spbg buttombg f14 lf" /> <span
									class="blues  lf"><a href="" title="">忘记密码?</a></span>
								<div class="cl"></div>
							</dd>

						</dl>
					</div>
				</form>
			</div>
			<div class="cl"></div>
		</div>
		<!-- main end-->

		<!-- footer begin-->
	</div>
	<!--footer end-->

	</div>
</body>
</html>
