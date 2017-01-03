<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_AuditCount" Codebehind="AuditCount.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>审核统计页</title>
<link href="Inc/Admin_Style.Css" rel="stylesheet" type="text/css" />
<script language="javascript" src="Inc/selectDateTime.js"  type="text/javascript" charset="utf-8"></script>   
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:center;">
    <table width="98%" border="0" cellspacing="1" cellpadding="0" style="height: 104px"  class="border">
  <tr class="tdbg">
    <td colspan="2"  class="title" style="height: 40px; font-size:20px; font-weight:bold; color:White;">审核统计</td>
  </tr>
  <tr class="tdbg">
    <td width="35%" align="right" style="height: 34px;">请选择起止时间：</td>
    <td align="left">开始时间：<asp:TextBox ID="TextBox_Start" runat="server" Width="90px" 
            Height="15px"></asp:TextBox>
        结束时间：<asp:TextBox ID="TextBox_stop" runat="server"  Width="90px" Height="15px"></asp:TextBox>
      </td>
  </tr>
  <tr class="tdbg">
    <td align="right">请选择网站：</td>
    <td align="left"><asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem>新闻网</asp:ListItem>
        <asp:ListItem>校园文化</asp:ListItem>
        </asp:DropDownList></td>
  </tr>
  <tr class="tdbg">
    <td align="right">请选择查询类型：</td>
    <td align="left"  style="height: 34px;">
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
            RepeatDirection="Horizontal" Width="250px">
            <asp:ListItem Value="3">采写</asp:ListItem>
            <asp:ListItem Value="0">编辑</asp:ListItem>
            <asp:ListItem Value="1">学院</asp:ListItem>
            <asp:ListItem Value="2">栏目</asp:ListItem>
            <asp:ListItem Value="4">头条</asp:ListItem>
        </asp:RadioButtonList>
      </td>
  </tr>
  <tr class="tdbg">
    <td style="height: 34px;">&nbsp;</td>
    <td align="left">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="查询" onclick="Button1_Click" />
      </td>
  </tr>
</table>
<div runat="server" id="result" style="text-align:center">
    </div>
    </div>
    </form>
</body>
</html>
