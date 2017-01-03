<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_Sdut_maker" Codebehind="Sdut_maker.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="vertical-align:top">
        图片内容：<asp:Label ID="Label1" runat="server" 
            BackColor="White" BorderColor="#8080FF"
            BorderStyle="Solid" BorderWidth="1px" Height="104px" Width="785px"></asp:Label><br />
        <br />
        图片新闻：<asp:Label ID="Label2" runat="server" BackColor="White" BorderColor="#8080FF"
            BorderStyle="Solid" BorderWidth="1px" Height="108px" Text="" Width="282px"></asp:Label><br />
        <br />
        标题列表：<asp:Label ID="Label3" runat="server" BackColor="White" BorderColor="#8080FF"
            BorderStyle="Solid" BorderWidth="1px" Height="316px" Text=""></asp:Label><br />
        <br />
        <asp:Label ID="Label4" runat="server"></asp:Label></div>
    </form>
</body>
</html>
