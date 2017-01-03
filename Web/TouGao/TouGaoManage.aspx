<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TouGaoManage.aspx.cs" Inherits="Lgwin.TouGao.TouGaoManage" %>

<%@ Register Assembly="CuteEditor" Namespace="CuteEditor" TagPrefix="CE" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>投稿内容管理</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td align="center"> 
        <CE:Editor ID="Editor1" runat="server" Height="600px" Width="98%" 
            ontextchanged="Editor1_TextChanged">
        </CE:Editor>
    </td>
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
