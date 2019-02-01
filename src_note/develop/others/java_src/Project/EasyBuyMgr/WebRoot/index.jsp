<%@ page language="java" import="java.util.*" pageEncoding="utf-8"%>
<%
  String path = request.getContextPath();
  String basePath = request.getScheme() + "://" + request.getServerName() + ":" + request.getServerPort() + path + "/";
%>
<!--  <%@ taglib uri="" prefix="c"%>-->
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
<script type="text/javascript" src="scripts/function.js"></script>
</head>
<body>
	<div id="welcomeImage">
		<img width="100%" height="150" src="images/banner.jpg" alt="welcome" />
	</div>
	<div id="header" class="wrap">
		<div id="logo">
			<img src="images/logo.gif" />
		</div>
		<div class="help">
			<a href="shopping.jsp" id="shoppingBag" class="shopping">购物车X件</a><a
				href="login.jsp">登录</a><a class="button" id="logout"
				href="javascript:void(0);">注销</a><a href="register.jsp">注册</a><a
				href="guestbook.jsp">留言</a><a href="manage/index.jsp">后台管理</a>
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
	<div id="main" class="wrap">
		<div class="lefter">
			<div class="box">
				<h2>商品分类</h2>
				<dl>
					<dt>图书音像</dt>
					<dd>
						<a href="product-list.jsp">图书</a>
					</dd>
					<dd>
						<a href="product-list.jsp">音乐</a>
					</dd>
					<dt>百货</dt>
					<dd>
						<a href="product-list.jsp">运动健康</a>
					</dd>
					<dd>
						<a href="product-list.jsp">服装</a>
					</dd>
					<dd>
						<a href="product-list.jsp">家居</a>
					</dd>
					<dd>
						<a href="product-list.jsp">美妆</a>
					</dd>
					<dd>
						<a href="product-list.jsp">母婴</a>
					</dd>
					<dd>
						<a href="product-list.jsp">食品</a>
					</dd>
					<dd>
						<a href="product-list.jsp">手机数码</a>
					</dd>
					<dd>
						<a href="product-list.jsp">家具首饰</a>
					</dd>
					<dd>
						<a href="product-list.jsp">手表饰品</a>
					</dd>
					<dd>
						<a href="product-list.jsp">鞋包</a>
					</dd>
					<dd>
						<a href="product-list.jsp">家电</a>
					</dd>
					<dd>
						<a href="product-list.jsp">电脑办公</a>
					</dd>
					<dd>
						<a href="product-list.jsp">玩具文具</a>
					</dd>
					<dd>
						<a href="product-list.jsp">汽车用品</a>
					</dd>
				</dl>
			</div>
			<div class="spacer"></div>
			<div class="last-view">
				<h2>最近浏览</h2>
				<dl class="clearfix">
					<dt>
						<img src="images/product/10_small.jpg" />
					</dt>
					<dd>
						<a href="product-view.jsp" target="_self">利仁2018M福满堂电饼铛 好用实惠</a><a
							href="product-view.jsp"></a>
					</dd>
					<dt>&nbsp;</dt>
					<dd>&nbsp;</dd>
				</dl>
			</div>
		</div>
		<div class="main">
			<div class="price-off">
				<div class="slideBox">
					<ul> <!-- id="slideBox"-->
						<li><img src="images/product/banner_1.jpg" /></li>
						<li><img src="images/product/banner_2.jpg" /></li>
						<li><img src="images/product/banner_3.jpg" /></li>
						<li><img src="images/product/banner_4.jpg" /></li>
					</ul>
				</div>
				<h2>商品列表</h2>
				<ul class="product clearfix">
					<c:forEach items="${page.productList}" var="l">
						<li>
							<dl>
								<dt>
								<a href="product-view.jsp" target="_self"><img src="images/product/${l.epFileName}" /></a>
								</dt>
								<dd class="title"><a href="product-view.jsp" target="_self">${l.epDescription}</a></dd>
								<dd class="price">￥${l.epPrice}</dd>
							</dl>
						</li>
					</c:forEach>
				</ul>
			</div>
			<div class="side">
				<div class="spacer"></div>
				<div class="news-list">
					<h4>新闻动态</h4>
					<ul>
						<li><a href="news-view.jsp" target="_self">抢钱啦</a></li>
						<li><a href="news-view.jsp" target="_self">抢钱啦</a></li>
						<li><a href="news-view.jsp" target="_self">抢钱啦</a></li>
						<li><a href="news-view.jsp" target="_self">抢钱啦</a></li>
						<li><a href="news-view.jsp" target="_self">抢钱啦</a></li>
						<li><a href="news-view.jsp" target="_self">抢钱啦</a></li>
						<li><a href="news-view.jsp" target="_self">抢钱啦</a></li>
						<li><a href="news-view.jsp" target="_self">抢钱啦</a></li>
						<li><a href="news-view.jsp" target="_self">抢钱啦</a></li>
						<li><a href="news-view.jsp" target="_self">抢钱啦</a></li>
					</ul>
				</div>
			</div>
			<div class="spacer clear"></div>
		</div>
	</div>
	<div id="footer">Copyright &copy; 2016 YL_HH_GG All Rights
		Reserved. 京ICP证1000001号</div>
</body>
</html>
