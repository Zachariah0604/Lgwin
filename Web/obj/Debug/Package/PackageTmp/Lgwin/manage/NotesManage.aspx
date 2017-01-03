<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_NotesManage" Codebehind="NotesManage.aspx.cs" %>
<%@ Register TagPrefix="CE" Namespace="CuteEditor" Assembly="CuteEditor" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>管理员通知管理</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td align="center"><CE:Editor id="Editor1" runat="server" Height="600px" Width="98%" >
        </CE:Editor></td>
  </tr>
  <tr>
    <td align="center">
        <asp:Button ID="Button_tiaojiao" runat="server" Text="提交" 
            onclick="Button_tiaojiao_Click" /></td>
  </tr>
</table>
    </div>
    </form>
</body>
</html>
