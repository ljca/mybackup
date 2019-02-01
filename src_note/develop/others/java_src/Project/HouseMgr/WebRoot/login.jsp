<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
</head>
<body>
	<div>
		<form action="LoginServlet" method="post">
			用户类型:<select><option>普通用户</option>
				<option>管理员</option></select> 用户名:<input type="text" name="uname" id="" /> 密码:<input
				type="text" name="pwd" id="" /> 验证码:<input type="text" name="" id="" />
			<input type="submit" name="" value="提交" id="" /> <input type="reset"
				value="重置" id="" />
			<div>
				<p>
					<a href="/jsp/register.jsp">没有账户？点这里注册！</a>
				</p>
			</div>
		</form>
	</div>
</body>
</html>