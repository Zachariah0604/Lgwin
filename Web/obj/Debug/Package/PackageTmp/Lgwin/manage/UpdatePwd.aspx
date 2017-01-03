<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_UpdatePwd" Codebehind="UpdatePwd.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="Inc/Admin_Style.Css" rel="stylesheet" type="text/css">
    <title>无标题页</title>
</head>
<body style="margin-top:100px;">
    <form id="form1" runat="server">
    <div>
    <table width="70%" border="0" align="center" cellpadding="0" cellspacing="1" class="border">
          <tr class="title">
            <td colspan="2" align="center" style="height: 35px">密码修改</td>
          </tr>
          <tr class="tdbg">
            <td width="41%" align="right" style="height: 30px">
        旧密码：&nbsp;</td>
            <td align="left" style="width: 392px; height: 30px">&nbsp;<asp:TextBox ID="Old" runat="server" TextMode="Password" Width="174px"></asp:TextBox></td>
          </tr>
          <tr class="tdbg">
            <td align="right" height="30px">
        新密码：&nbsp;</td>
            <td align="left" style="width: 392px">&nbsp;<asp:TextBox ID="New1" runat="server" TextMode="Password" Width="174px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="New1"
            ErrorMessage="*"></asp:RequiredFieldValidator></td>
          </tr>
          <tr class="tdbg">
            <td align="right" height="30px">
        确认新密码：&nbsp;</td>
            <td align="left" style="width: 392px">&nbsp;<asp:TextBox ID="New2" runat="server" TextMode="Password" Width="174px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="New2"
            ErrorMessage="*"></asp:RequiredFieldValidator><asp:CompareValidator ID="CompareValidator1"
                runat="server" ControlToCompare="New1" ControlToValidate="New2" ErrorMessage="密码不一致"></asp:CompareValidator></td>
          </tr>
          <tr class="title">
            <td colspan="2" align="center" style="height: 30px">
        <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="取消" />
              </td>
          </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
