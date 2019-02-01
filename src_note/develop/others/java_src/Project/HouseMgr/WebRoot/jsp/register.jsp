<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>租房系统用户注册</title>
</head>
<body>
  <div>
    <div id="regester">
      <form action="RegisterServlet" method="post" id="user_register">
        <p>
          用户名：<input type="text" name="uname" id="" placeholder="请输入用户名...."/>
        </p>
        <p>
          密码：<input type="text" name="pwd" id="" placeholder="请输入密码..." />
        </p>
        <p>
          确认密码：<input type="text" name="re_pwd" id="" placeholder="确认密码..."/>
        </p>
<!--         <p>
          邮箱：<input type="text" name="mail" id="" placeholder="邮箱地址" />
        </p> -->
        <p>
          Telephone:<input type="text" name="tel" id="" placeholder="联系电话..." />
        </p>
<!--         <p>
          地址：<input type="text" name="addr" id="" placeholder="联系地址...." />
        </p> -->
        <p>
          <input type="submit" value="提交" /><input type="reset" value="重置">
        </p>
      </form>
    </div>
  </div>

</body>
</html>