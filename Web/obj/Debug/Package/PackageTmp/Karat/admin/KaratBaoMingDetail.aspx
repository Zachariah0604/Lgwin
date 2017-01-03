<%@ Page Language="C#" AutoEventWireup="true" Inherits="karat1_admin_KaratBaoMingDetail" Codebehind="KaratBaoMingDetail.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<link href="../css/karat.Css" rel="stylesheet" type="text/css">
    <title>无标题页</title>
    <link rel="stylesheet" href="../photo/css/lightbox.css" type="text/css" media="screen" />
	<script src="../../photo/js/prototype.js" type="text/javascript"></script>
	<script src="../../photo/js/scriptaculous.js?load=effects" type="text/javascript"></script>
	<script src="../../photo/js/lightbox.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div  style="text-align:center;">
      <table  border="0" align="center" cellpadding="0" cellspacing="1" class="border" 
            style="width:300px; margin-top:50px; " >
  <tr height="20px"  class="title">
    <td><div align="right"><a href="javascript:history.go(-1)">×</a></div></td>
  </tr>
  <tr class="tdbg">
    <td><asp:FormView ID="FormView1" runat="server" RowStyle-VerticalAlign="Middle">
        <ItemTemplate>
        <table width="500px" border="0"  align="center" cellspacing="1" cellpadding="0" bgcolor="White">
  <tr class="tdbg">
    <td rowspan="8" align="center" width="40%" style="padding-bottom:5px">
        <a  href="<%#Eval("touxiang") %>" rel="lightbox"><asp:Image ID="Img" runat="server" ImageUrl='<%#Eval("touxiang") %>' Width="150px" /></a></td>
    <td align="right" width="20%">学院：</td>
    <td align="left"><%# DataBinder.Eval(Container.DataItem, "xueyuan")%></td>
  </tr>
  <tr class="tdbg">
    <td align="right">班级：</td>
    <td align="left"><%# Eval("banji")%></td>
  </tr>
  <tr class="tdbg">
    <td align="right">性别：</td>
    <td align="left"><%# Eval("sex")%></td>
  </tr>
  <tr class="tdbg">
    <td align="right">是否有电脑：</td>
    <td align="left"><%# Eval("diannao")%></td>
  </tr>
  <tr class="tdbg">
    <td align="right">邮箱：</td>
    <td align="left"><%# DataBinder.Eval(Container.DataItem, "email")%></td>
  </tr>
  <tr class="tdbg">
    <td align="right">籍贯：</td>
    <td align="left"><%# DataBinder.Eval(Container.DataItem, "her")%></td>
  </tr>
  <tr class="tdbg">
    <td align="right">职位：</td>
    <td align="left"><%# DataBinder.Eval(Container.DataItem, "zhiwei")%></td>
  </tr>
  <tr class="tdbg">
    <td align="right">电话：</td>
    <td align="left"><%# DataBinder.Eval(Container.DataItem, "tel")%></td>
  </tr>
  <tr class="tdbg" height="30px">
    <td align="center">姓名：<%# DataBinder.Eval(Container.DataItem, "name")%></td>
    <td align="right">个人博客：</td>
    <td align="left"><%# DataBinder.Eval(Container.DataItem, "blog")%></td>
  </tr>
  <tr class="tdbg" height="30px">
    <td align="center">校区 宿舍：<%# DataBinder.Eval(Container.DataItem, "xiaoqu")%></td>
    <td align="right">作品：</td>
    <td><%# DataBinder.Eval(Container.DataItem, "zuopin")%></td>
  </tr>
  <tr id="jieshao" class="tdbg"><td colspan="3" style="line-height:25px; text-align:left; padding-top:5px; padding-bottom:10px;">
    <p> 简介： <%# DataBinder.Eval(Container.DataItem, "jianjie")%></p></td></tr>
</table>
        </ItemTemplate>
        </asp:FormView>
    </td>
  </tr>
</table>    </div>
    </form>
</body>
</html>



