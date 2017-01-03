<%@ Page Language="C#" AutoEventWireup="true" Inherits="CaiFang" Codebehind="CaiFang.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=GB2312" />
<link href="images/index/TopFooter.css" rel="stylesheet" type="text/css" />
<title>采访申请</title>
<style type="text/css">
<!--
body {
margin-left:auto;
	margin-right:auto;
	margin-top:0px;
}
#main {
	margin-left:auto;
	margin-right:auto;
}
#left {
    width:712px;
    float:left; 
    height:752px;
    margin-right:6px;
    margin-top:5px;
	border-color:#9d9d9d;
	border-style:solid;
	border-width:1px;
}
.left1 {
	float:left;
	width:30px;
	height:516px;
}
.left2 {
	float:left;
	width:647px;
	height:516px;
	overflow:hidden;
}
.left3{
	float:left;
	width:33px;
	height:516px;
}
.Left2_1 {
	width:647px;
	height:478px;
	overflow:hidden;
}
.left2_2 {
	width:647px;
	height:478px;
} 
.td1 {
	width:125px;
	height:50px;
	text-align:right;
	padding-right:20px;
	font-size:12px;
}
.td2 {
	width:220px;
	height:50px;
}
.td3 {
	width:305px;
	height:50px;
}
.tb1 {
	width:198px;
	height:20px;
}
.span {
    color:#2075a5;
    font-size:12px;
}
.td {
	width:710px;
	height:44px;
	font-size:14px;
	padding-left:22px;
}
		
-->
</style>
<script language="javascript" src="Lgwin/manage/Inc/selectDateTime.js"  type="text/javascript" charset="utf-8"></script>
</head>
<body style="margin-top:0px;">
    <form id="form1" runat="server">
<iframe src="images/Top.html" width="1000px" height="220" scrolling="No" frameborder="0"></iframe>
<div id="main">
    <div id="left">
    	<div><table width="710" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td class="td">当前位置：首页>> 采访申请</td>
  </tr>
  <tr>
    <td><img src="images/images/CaiFang_05.jpg" width="710" height="54" /></td>
  </tr>
  <tr>
    <td><img src="images/images/CaiFang_06.jpg" width="710" height="40" /></td>
  </tr>
  <tr>
    <td><img src="images/images/CaiFang_07.jpg" width="710" height="98" /></td>
  </tr>
</table>
</div>
	<div class="left1"><img src="images/images/CaiFang_08.jpg" width="30" height="516" /></div>
    <div class="left2">
   		<div class="Left2_1">
   		  <table width="645" height="300px" border="0" cellspacing="0" cellpadding="0">
   		    <tr style="background-color:#eff6fc">
   		      <td class="td1">活动主题：</td>
   		      <td class="td2">
                  <asp:TextBox ID="TbxTitle" runat="server" CssClass="tb1"></asp:TextBox>
                                    </td>
   		      <td class="td3">
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                      ControlToValidate="TbxTitle" ErrorMessage="*"></asp:RequiredFieldValidator>
                                    </td>
	        </tr>
   		    <tr>
   		      <td class="td1">日期：</td>
   		      <td class="td2">
                  <asp:TextBox ID="TbxTime" runat="server" CssClass="tb1"></asp:TextBox>
                                                                      </td>
   		      <td class="td3">
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                      ControlToValidate="TbxTime" ErrorMessage="*"></asp:RequiredFieldValidator>
                  </td>
	        </tr>
	        <tr>
   		      <td class="td1">时间：</td>
   		      <td class="td2">
                  <asp:TextBox ID="TextBox_time" runat="server" CssClass="tb1"></asp:TextBox>
                                    </td>
   		      <td class="td3">
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                      ControlToValidate="TbxTime" ErrorMessage="*"></asp:RequiredFieldValidator>
                            </td>
	        </tr>
   		    <tr style="background-color:#eff6fc">
   		      <td class="td1">地点：</td>
   		      <td class="td2">
                  <asp:TextBox ID="TbxPlace" runat="server" CssClass="tb1"></asp:TextBox>
                                    </td>
   		      <td class="td3">
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                      ControlToValidate="TbxPlace" ErrorMessage="*"></asp:RequiredFieldValidator>
                                    </td>
	        </tr>
   		    <tr>
   		      <td class="td1">单位：</td>
   		      <td class="td2">
                  <asp:TextBox ID="TbxOrganization" runat="server" CssClass="tb1"></asp:TextBox>
                                    </td>
   		      <td class="td3">
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                      ControlToValidate="TbxPlace" ErrorMessage="*"></asp:RequiredFieldValidator>
                                    </td>
	        </tr>
   		    <tr style="background-color:#eff6fc">
   		      <td class="td1">出席领导：</td>
   		      <td class="td2">
                  <asp:TextBox ID="TbxLeader" runat="server" CssClass="tb1"></asp:TextBox>
                                    </td>
   		      <td class="td3">&nbsp;
                  </td>
	        </tr>
	      </table>
          <table width="645" height="100px" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td class="td1">内容简介：</td>
    <td  style="width:520px">
        <asp:TextBox ID="TbxDescription" runat="server" Height="100px" 
            TextMode="MultiLine" Width="400px"></asp:TextBox>
                                    </td>
  </tr>
</table>
<table width="645" border="0" height="40px" cellspacing="0" cellpadding="0">
  <tr>
    <td style="text-align:right; padding-right:20px; width:323px">
        <asp:ImageButton ID="ImgBtTj" runat="server"  ImageUrl="~/images/images/TiaoJiao.gif" 
            onclick="ImgBtTj_Click"/>
      </td>
    <td  style="width:323px">
        <asp:ImageButton ID="ImgBtCz" runat="server"  ImageUrl="~/images/images/ChongZhi.gif" 
            onclick="ImgBtCz_Click"/>
      </td>
  </tr>
</table>

   		</div>
            <div class="left2_2"><img src="images/images/CaiFang_11.jpg" width="647" height="38" /></div></div>
    <div class="left3"><img src="images/images/CaiFang_10.jpg" width="33" height="516" /></div>
</div>
    <div style="float:left"><iframe src="images/Right.html" width="280px" height="760" scrolling="No" frameborder="0"></iframe></div>
</div>
<iframe src="images/Footer.html" width="1000px" height="110" scrolling="No"  frameborder="0"></iframe>
</form>
</body>
</html>
