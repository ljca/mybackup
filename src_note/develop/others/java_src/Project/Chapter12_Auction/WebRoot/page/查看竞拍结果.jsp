<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>
<%
String path = request.getContextPath();
String basePath = request.getScheme()+"://"+request.getServerName()+":"+request.getServerPort()+path+"/";
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
  <div class="sale">
    <h1 class="lf">拍卖结束的商品</h1>
    <div class="right rulse">当前用户是：<span class="blue strong"><a href="#" title="张三">张三</a></span></div>
    <div class="cl"></div>
  </div>
<div class="items">
      <ul class="rows even strong">
        <li>名称</li>
        <li>开始时间</li>
        <li>结束时间</li>
        <li>起拍价</li>
        <li class="list-wd">成交价</li>
        <li class="borderno">买家</li>
      </ul>
      <ul class="rows">
        <li><a href="国书" title="">国书</a></li>
        <li>2010-01-20 12:30:30</li>
        <li>2010-09-08 12:30:30</li>
        <li>2,000</li>
        <li class="list-wd">5,000</li>
        <li class="borderno red"><a href="#">张三</a></li>
      </ul>
      <ul class="rows even">
        <li><a href="国书" title="">瓷器</a></li>
        <li>2010-01-20 12:30:30</li>
        <li>2010-09-08 12:30:30</li>
        <li>2,000</li>
        <li class="list-wd">5,000</li>
        <li class="borderno red"><a href="#">李四</a></li>
      </ul>
      <ul class="rows">
        <li><a href="国书" title="">国画</a></li>
        <li>2010-01-20 12:30:30</li>
        <li>2010-09-08 12:30:30</li>
        <li>2,000</li>
        <li class="list-wd">5,000</li>
        <li class="borderno red"><a href="#">王五</a></li>
      </ul>
      <ul class="rows even border-no">
        <li><a href="国书" title="">电器</a></li>
        <li>2010-01-20 12:30:30</li>
        <li>2010-09-08 12:30:30</li>
        <li>2,000</li>
        <li class="list-wd">5,000</li>
        <li class="borderno red"><a href="#">赵六</a></li>
      </ul>
  </div>
  <h1>拍卖中的商品</h1>
  <div class="items records">
      <ul class="rows even strong rowh"> 
        <li>名称</li>
        <li>开始时间</li>
        <li>结束时间</li>
        <li>起拍价</li>
        <li class="borderno record">出价记录</li>
<!--         <div class="cl"></div>
 -->      </ul>
    <ul class="rows">
        <li><a href="国书" title="">国书</a></li>
        <li>2010-01-20 12:30:30</li>
        <li>2010-09-08 12:30:30</li>
        <li>2,000</li>
        <li class="borderno blue record">
          <p>李四 400元</p>
          <p>张三 300元</p>
          <p>张晶 200元</p>
        </li>
<!--         <div class="cl"></div>
 -->      </ul>
      <ul class="rows even">
        <li><a href="国书" title="">瓷器</a></li>
        <li>2010-01-20 12:30:30</li>
        <li>2010-09-08 12:30:30</li>
        <li>2,000</li>
        <li class="borderno blue record">
          <p>李四 400元</p>
          <p>张三 300元</p>
          <p>张晶 200元</p>
        </li>
        <!-- <div class="cl"></div> -->
      </ul>
      <ul class="rows">
        <li><a href="国书" title="">国画</a></li>
        <li>2010-01-20 12:30:30</li>
        <li>2010-09-08 12:30:30</li>
        <li>2,000</li>
        <li class="borderno blue record">
          <p>李四 300元</p>
          <p>张三 200元</p>
          <p>张晶 100元</p>
        </li>
<!--         <div class="cl"></div>
 -->    </ul>
      <ul class="rows even border-no">
        <li><a href="国书" title="">电器</a></li>
        <li>2010-01-20 12:30:30</li>
        <li>2010-09-08 12:30:30</li>
        <li>2,000</li>
        <li class=" blue record">
          <p>李四 400元</p>
          <p>张三 400元</p>
          <p>张晶 100元</p>
        </li>
<!--         <div class="cl"></div> -->
      </ul>
  </div>
<!-- main end-->
</div>
</body>
</html>
