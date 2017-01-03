<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_PicToutiao" Codebehind="PicToutiao.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>头条图片样式设置</title>
    <link href="Inc/Admin_Style.Css" rel="stylesheet" type="text/css">
</head>
<body style="margin-top:10px;">
    <form id="form1" runat="server">
    <div>
    <table width="600" border="0" align="center" cellpadding="0" cellspacing="1" class="border">
   <tr class="title" >
    <td colspan="2"  height="30px" align="center"><strong>头条图片样式设置</strong></td>
  </tr>
  <tr class="tdbg">
    <td width="30%" align="right">文字字体：</td>
    <td>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList></td>
  </tr>
  <tr class="tdbg">
    <td width="30%" align="right">文字字体颜色：</td>
    <td>R值：<asp:TextBox ID="TextBox_red" runat="server" Width="30px"></asp:TextBox> &nbsp; 
        G值：<asp:TextBox ID="TextBox_green" runat="server" Width="30px"></asp:TextBox>
&nbsp; B值：<asp:TextBox ID="TextBox_blue" runat="server" Width="30px"></asp:TextBox>
        （红绿蓝的颜色值，0-255之间）</td>
  </tr>
  <tr class="tdbg">
    <td align="right">左边距：</td>
    <td>
        <asp:TextBox ID="TextBox_ZuoBJ" runat="server" Width="30px"></asp:TextBox>
        像素</td>
  </tr>
  <tr class="tdbg">
    <td align="right">上边距：</td>
    <td>
        <asp:TextBox ID="TextBox_ShangBJ" runat="server" Width="30px"></asp:TextBox>
        像素</td>
  </tr>
  <tr class="tdbg">
    <td align="right"> 图片宽度：</td>
    <td>
        <asp:TextBox ID="TextBox_Width" runat="server" Width="30px"></asp:TextBox>
        像素</td>
  </tr>
  <tr class="tdbg">
    <td align="right">图片高度：</td>
    <td>
        <asp:TextBox ID="TextBox_Height" runat="server" Width="30px"></asp:TextBox>
        像素</td>
  </tr>
  <tr class="tdbg">
    <td align="right">文字大小：</td>
    <td>
        <asp:TextBox ID="TextBox_Daxiao" runat="server" Width="30px"></asp:TextBox>
        像素</td>
  </tr>
  <tr class="tdbg">
    <td align="right">文字透明度：</td>
    <td>
        <asp:TextBox ID="TextBox_Touming" runat="server" Width="30px"></asp:TextBox>
&nbsp;&nbsp; 填1-255之间的数字，255表示不透明</td>
  </tr>
  <tr class="tdbg">
    <td align="right">图片质量：</td>
    <td>
        <asp:TextBox ID="TextBox_Pinzhi" runat="server" Width="30px"></asp:TextBox>
&nbsp;&nbsp; 填1-100之间的数字，数字越大图片质量越高</td>
  </tr>
  <tr class="tdbg">
    <td align="right">文字加阴影：</td>
    <td>
        <asp:CheckBox ID="CheckBox_Yinying" runat="server" />
                    </td>
  </tr>
  <tr class="tdbg">
    <td align="right">文字大小适应：</td>
    <td>
        <asp:CheckBox ID="CheckBox_Shiying" runat="server" />
                    </td>
  </tr>
    <tr  class="title">
    <td align="right"></td>
    <td align="left">
        <asp:Button ID="Button1" runat="server" Text="保存设置" onclick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="取消" />
        </td>
  </tr>
</table>
    </div>
    </form>
</body>
</html>
