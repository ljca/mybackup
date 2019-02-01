/**
 * Created with jing.zhao2013 Date: 13-7-30 Time: 下午4:03
 */
// cookie相关操作，不需要dom加载完成后运行，因此单独写
function setCookie(name,value){
  if(!name || !value)
    return;
  var Days = 30;// 默认30天
  var exp = new Date();
  exp.setTime(exp.getTime() + Days * 24 * 60 * 60 * 1000);
  document.cookie = name + "=" + encodeURIComponent(value) + ";expires=" + exp.toUTCString();
}
function getCookie(name){
  var arr = document.cookie.match(new RegExp("(^| )" + name + "=([^;]*)(;|$)"));
  if(arr != null)
    return decodeURIComponent(arr[2]);
  return null;
}
function delCookie(name){
  var exp = new Date();
  exp.setTime(exp.getTime() - 1);
  var cval = getCookie(name);
  if(!cval)
    document.cookie = name + "=" + cval + ";expires=" + exp.toUTCString();
}
// gobuy
function inArray(array,str){
  for(a in array){
    if(array[a] == str)
      return true;
  }
  return false;
}
function goBuy(id,price){
  var newCookie = "";
  var oldCookie = getCookie("product");
  if(oldCookie){
    if(inArray(oldCookie.split(","),id)){
      newCookie = oldCookie;
    }else{
      newCookie = id + "," + oldCookie;
    }
  }else{
    newCookie = id;
  }
  setCookie("product",newCookie);
  location.href = "Cart?action=add&entityId=" + id;
}
function goBuy2(id){
  var newCookie = "";
  var oldCookie = getCookie("product");
  if(oldCookie){
    if(inArray(oldCookie.split(","),id)){
      newCookie = oldCookie;
    }else{
      newCookie = id + "," + oldCookie;
    }
  }else{
    newCookie = id;
  }
  setCookie("product",newCookie);
  location.href = "Cart?action=addBuy&entityId=" + id;
}
// dom加载完后运行
$(function(){
  // 获取焦点方法
  function focusItem(dom){
    $(dom).parent().parent().addClass("current");
    var eBox = $(dom).parent().find("span");
    eBox.removeClass("error").text("");
  }
  // 失去焦点消除背景，且验证信息方法
  function checkItem(dom){
    $(dom).parent().parent().removeClass("current");
    var eBox = $(dom).parent().find("span");
    var name = $(dom).attr("name");
    var value = $(dom).val();
    var errorMessage = "", isError = true;
    switch(name){
    case "userId" :
      if(value == ""){
        errorMessage = "用户名不能为空";
      }else if(!/[a-zA-Z0-9]+/.test(value)){
        errorMessage = "用户名只能是英文字母或者数字";
      }else{
        isError = false;
      }
      break;
    case "userName" :
      if(value == ""){
        errorMessage = "真实姓名不能为空";
      }else if(value.length > 10){
        errorMessage = "真实姓名长度最长10个汉字";
      }else{
        isError = false;
      }
      break;
    case "password" :
      if(value == ""){
        errorMessage = "密码不能为空";
      }else{
        isError = false;
      }
      break;
    case "confirmPassword" :
      if(value == ""){
        errorMessage = "确认密码不能为空";
      }else if(value != $("#password").val()){
        errorMessage = "两次输入的密码不相同";
      }else{
        isError = false;
      }
      break;
    case "address" :
      if(value == ""){
        errorMessage = "地址不能为空";
      }else{
        isError = false;
      }
      break;
    case "birthday" :
      if((value != "") && !/\d{4}[-]\d{1,2}[-]\d{1,2}/.test(value)){
        errorMessage = "出生日期格式只能是yyyy-mm-dd";
      }else{
        isError = false;
      }
      break;
    case "identityCode" :
      if((value != "") && !/((\d{17}\w{1})|(\d{15}))/.test(value)){
        errorMessage = "身份证号码格式不正确";
      }else{
        isError = false;
      }
      break;
    case "email" :
      if((value != "") && !/^[a-z0-9]+\@([a-z0-9]+\.)+[a-z0-9]{2,4}$/i.test(value)){
        errorMessage = "邮件地址格式不正确";
      }else{
        isError = false;
      }
      break;
    case "mobile" :
      if((value == "") || !/\d{11}/.test(value)){
        errorMessage = "手机号码格式不正确";
      }else{
        isError = false;
      }
      break;
    case "productName" :
      if(value == ""){
        errorMessage = "名称不能为空";
      }else{
        isError = false;
      }
      break;
    case "productPrice" :
      if((value == "") || !(/^\d+(\.\d+)?$/.test(value))){
        errorMessage = "不能为空且只能为正数";
      }else{
        isError = false;
      }
      break;
    case "productNumber" :
      if((value == "") || !(/^[0-9]*[1-9][0-9]*$/.test(value))){
        errorMessage = "不能为空且只能为正整数";
      }else{
        isError = false;
      }
      break;
    case "photo" :
      if(value == ""){
        errorMessage = "不能为空";
      }else{
        isError = false;
      }
      break;
    case "content" :
      if(value == ""){
        errorMessage = "不能为空";
      }else if(value.length > 500){
        errorMessage = "字数不能大于500";
      }else{
        isError = false;
      }
      break;
    case "title" :
      if(value == ""){
        errorMessage = "不能为空";
      }else if(value.length > 20){
        errorMessage = "字数不能大于20";
      }else{
        isError = false;
      }
      break;
    default :
      isError = false;
      break;
    }
    if(isError){
      eBox.text(errorMessage);
      eBox.addClass("error");
      return false;
    }
    return true;
  }
  // 提交表单方法
  function checkForm(){
    var flag = true;
    $(this).find("input[class='text']").each(function(i,dom){
      if(!checkItem($(dom)))
        flag = false;
    })
    if(!checkItem($(this).find("input[name='productPrice']")))
      flag = false;
    if(!checkItem($(this).find("input[name='productNumber']")))
      flag = false;
    return flag;
  }
  // 添加商品
  $("#productAdd").find("input[class!='submit']").bind({
    focus:function(){
      focusItem(this)
    },
    blur:function(){
      checkItem(this)
    }});
  $("#productAdd").submit(checkForm);
  // 添加新闻验证
  $("#newsAdd").find("[class='text']").bind({
    focus:function(){
      focusItem(this)
    },
    blur:function(){
      checkItem(this)
    }});
  $("#newsAdd").submit(function(){
    var $self = $(this);
    var $title = $self.find("[name=title]");
    var $content = $self.find("textarea");
    if($title.val().length > 20){
      $title.next("span").addClass("error").html("不得多于20字");
    }
    if($content.val().length > 500){
      $content.next("span").addClass("error").html("不得多于500字");
    }
    if($title.val().length <= 20 && $title.text().length <= 500){
      return true;
    }
    return false;
  });
  // dom调用聚焦，失焦事件
  $("#userId").bind({
    focus:function(){
      focusItem(this)
    },
    blur:function(){
      checkItem(this)
    }});
  $("#password").bind({
    focus:function(){
      focusItem(this)
    },
    blur:function(){
      checkItem(this)
    }});
  // 日历
  $("#birthday").click(function(){
    WdatePicker({
      highLineWeekDay:true // 周末高亮
      ,
      readOnly:true // 只读，只可用控件input中 修改内容
      ,
      dateFmt:'yyyy-MM-dd'});
  });
  // 点击换验证码
  $("#changeCode").click(function(){
    $("#safeCode").attr("src","Number.jsp?id=" + Math.random());
  });
  // 注册页面验证
  $("#regForm").find("input[class='text']").bind({
    focus:function(){
      focusItem(this)
    },
    blur:function(){
      checkItem(this)
    }})
  // 表单提交事件
  $("#loginForm").submit(checkForm);
  $("#regForm").submit(checkForm);
  // 添加新地址事件
  $("#addr").click(function(){
    var val = $(this).val()
    if(val == "添加"){
      // location.href = "Cart?action=addAddress&address="+$("#addAddr").val();
      var addr = $("#addAddr").val();
      if(addr == ""){
        alert("地址不能为空");
        return;
      }
      var reg = new RegExp(/;|；/gi);
      if(reg.test(addr)){
        alert("地址不能有分号");
        return;
      }
      var flag = true;
      $(this).parent().find("input[name='address']").each(function(i,d){
        if($(d).next().text() == addr){
          flag = false;
        }
      })
      if(!flag){
        alert("地址不能相同");
        return;
      }
      $("#span").append('<br/><input name="address" type="radio" id="address0"/><span>' + addr + '</span>');
    }else{
      var span = $("#span").html('<input type="text" name="addAddr" id="addAddr"/>');
      $(this).val("添加");
    }
  });
  // 删除商品
  $(".delete").find("a").click(function(){
    var tr = $(this).parent().parent();
    if(confirm("确定要删除吗？")){
      var oldCookie = getCookie("product");
      if(oldCookie){
        var oldCookieArr = oldCookie.split(",");
        var newCookieArr = new Array();
        for(c in oldCookieArr){
          var cookie = parseInt(oldCookieArr[c]);
          if(cookie != id)
            newCookieArr.push(cookie);
        }
        var newCookie = newCookieArr.join(",");
        setCookie("product",newCookie);
      }
      if(tr)
        tr.remove();
      location.herf = "";
    }else{
      return false;
    }
  });
  // 后台删除
  $(".manageDel").click(function(){
    var $tr = $(this).parent().parent();
    if(confirm("确定要删除吗？")){
      if($tr)
        $tr.remove();
      location.herf = "";
    }else{
      return false;
    }
  })
  // 修改
  $(".number").find("span").click(function(){
    var $tds = $(this).parent().parent().children("td");
    var $price = $($tds[1]);
    var $number = $($tds[2]);
    var price = $price.find("input[type='hidden']").val();// 存值
    var $priceBox = $price.find("span");// 现实价钱
    var $number = $number.find("input");// 得到存储input对象
    var opr = $(this).attr("name");// 判断增减
    var number = $number.val();// 数量
    if(opr == "del"){
      number--;
      if(number <= 0){
        if(confirm("确定要删除吗？")){
          $price.parent().remove();
        }else{
          number = 1;
        }
      }
    }else if(opr == "add"){
      number++;
    }
    $number.val(number);
    $priceBox.text("￥" + price * number);
    $("#shopping").find("#total").text("总计：￥" + totalPrice());
  });
  // 计算总价
  function totalPrice(){
    var totalPrice = 0;
    $("#shopping").find(".price").find("input[type='hidden']").each(function(i,d){
      var p = parseFloat($(d).val());
      var n = $(d).parent().parent().find("input[name='number']").val();
      totalPrice = totalPrice + p * n;
    });
    return totalPrice;
  }
  $("#shopping").find("input[name='number']").change(function(){
    var v = $(this).val();
    if(!(/^[0-9]*[1-9][0-9]*$/.test(v))){
      alert("请输入正整数");
      $(this).val(1);
    }
    var $price = $($(this).parent().parent().children("td")[1]);
    var p = $price.find("input").val();
    $price.find("span").text(p * $(this).val());
    $("#shopping").find("#total").text("总计：￥" + totalPrice());
  });
  $("#shopping").find("#total").text("总计：￥" + totalPrice());
  // 注销
  $("#logout").click(function(){
    if(confirm("购物车中尚有未结算的商品，是否结账？")){
      location.href = "shopping.html";
    }else{
      location.href = "index.html";
      return false;
    }
  });
  // 轮换广告
  var index = 0;
  setInterval(function(){
    index++;
    var $li = $("#slideBox").children("li");
    if(index >= $li.length){
      index = 0;
    }
    $li.eq(index).stop(true,true).fadeIn().siblings().fadeOut();
  },3000);
  // 欢迎图片
  if(document.referrer == ""){
    $("#welcomeImage").slideDown(4000).delay(1000).slideUp(4000);
  }
  // 订单号验证，只能为数字
  $("#orderForm").submit(function(){
    var flag = !isNaN($("#entityId").val());
    if(!flag){
      alert("只能是数字！");
    }
    return flag;
  });
  // 出现大图标
  $("#product .thumb img").mouseover(function(){
    var src = $(this).attr("src").split("/");
    var name = src[src.length - 1].split(".")[0];
    $("#product").append('<img id="bigImg" src="images/product/' + name + '_big.jpg"/>');
    $("#bigImg").show().error(function(){
      $(this).remove();
    });
  }).mouseleave(function(){
    $("#bigImg").hide();
  })
  // 商品分类,默认第一个展开
  $($("#main .box dl dt")[0]).nextUntil('dt').show();
  $("#main .box dl dt").click(function(){
    $(this).nextUntil('dt').toggle();
  });
  // 购物车
  $("#shoppingBag").mouseover(function(){
    var o = $(this).offset();
    var $table = $('<table id="floatBag" border="1" style="left:' + o.left + 'px;top:' + (o.top + 20) + 'px;"></table>');
    $("#header").append($table);
    var html = [
        "<tr><th>图标</th><th>名称</th><th>价格</th></tr>","<tr><td>图标</td><td>VVVVV</td><td>99</td></tr>"]
    $table.html(html.join(""));
    $("#floatBag").show();
  }).mouseleave(function(){
    $("#floatBag").hide();
  });
  // 验证留言
  $("#guestBook").submit(function(){
    if($(this).find("textarea").val().length <= 100){
      return true;
    }
    $(this).find("span").addClass("error").html("留言不得多于100字");
    return false;
  });
})