<%@page import="house.entity.House"%>
<%@page import="house.page.support.PageUtil"%>
<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>
<%
  String path = request.getContextPath();
			String basePath = request.getScheme() + "://"
					+ request.getServerName() + ":" + request.getServerPort()
					+ path + "/";
%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
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
<!--<link rel="stylesheet" type="text/css" href="styles.css">-->
<style type="text/css">
<!--
li {
	list-style: none;
}

#logo {
	float: left;
}

.search {
	/*clear: both;*/
	
}

dt {
	float: left;
}

#list,dd {
	clear: both;
}
//
-->
</style>

<script type="text/javascript" src="js/jquery-1.8.3.js"></script>
<script type="text/javascript">
<!--
  
//-->
</script>

</head>

<body>
  <div>
    <div>
      <!-- logo! -->
      <div id="logo">
        <img src="images/logo.gif" alt="" align="top">
      </div>
      <!-- 头部 -->
      <div class="search">
        <form action="" method="post">
          <input type="hidden" value="" /> <input type="text" name="" id="" placeholder="请输入关键字...." /> <input type="submit" value="搜索"> <select>
            <option value="">---房屋类型---</option>

          </select> <select>
            <option value="">---面积---</option>

          </select> <select>
            <option value="">---价格---</option>

          </select> <select>
            <option value="">---用户---</option>
          </select>
        </form>
      </div>
    </div>
    <!-- 房屋列表 -->
    <div id="house_list">
      <h3>租房系统</h3>
      <div>
        <div class="title"></div>
        <div class="defails">
          <c:forEach items="${page.list}" var="l">
            <div >
              <div >
                <img src="images/thumb_house.gif" /><a href="DefailServlet?id=${l.id}">${l.title}</a>
              </div>
              <ul>
                <li>房屋描述：${l.description}</Li>
                <li>联系电话：${l.users.telePhone}</li>
                <li>面积：${l.price}元/平方米</li>
              </ul>
            </div>
            <div>
              <dl>
                <dt>发布者：${l.users.name}</dt>
                <dt>房屋类型：${l.types.name}</dt>
                <dt>所属街道：${l.streets.name}</dt>
              </dl>
            </div>
          </c:forEach>
        </div>

      </div>
    </div>
    <!-- 底端 -->
    <div style="clear:both;">
      <a href="#">上一页</a><a href="#">下一页</a>当前页:【】|总【】页
    </div>

    <!-- 版权 -->
    <div></div>
  </div>
</body>
</html>
