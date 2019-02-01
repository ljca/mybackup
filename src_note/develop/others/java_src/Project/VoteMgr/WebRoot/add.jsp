<%@ page language="java" contentType="text/html; charset=utf-8"
    pageEncoding="utf-8"%>
    <link type="text/css" rel="stylesheet" href="css/style.css" />
<div class="addVote">
	<h2>发布新投票</h2>
	<div class="vote-content">
		<form method="post" action="" onsubmit="return validate();">
			<dl>
				<dt>投票内容：</dt>
				<dd>
				   <input id="voteTitle" type="text" class="input-text" name="subject.title"  value="" title="填入投票内容"/>
				</dd>
				<dt>投票类型：</dt>
				<dd>
		  		   <input type="radio" name="subject.type" value="1" checked=checked/>单选
				   <input type="radio" name="subject.type" value="2" />多选
				</dd>
				<dt>投票选项：</dt>
				<dd id="voteoptions">
					<p><input type="text" class="input-text" name="options" /></p>
					<p><input type="text" class="input-text" name="options" /></p>
				</dd>
				<dt></dt>
				<dd class="button">
					<input type="image" src="images/button_submit.gif" />
					<a id="addOption" href="javascript:void(0);" >增加选项</a>
					<a href="">取消操作</a>
				</dd>
			</dl>
		</form>
	</div>
</div>
<div id="dialog-message" title="警告" style="height:80px;width:130px;display:none">
	<p>投票内容不能为空</p>
</div>

