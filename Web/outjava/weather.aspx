<%@ Page Language="C#" AutoEventWireup="true" Inherits="weather" Codebehind="weather.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <style type="text/css">
    a {
    color:White;
    }
    </style>
</head>

<body style="background-color:black; margin:0px; color:White; font-size:16pt; color:Red">
    <form id="form1" runat="server">
    <div>
    <table width="100%">
    <tr><td style="text-align:center">
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </td></tr>
    <tr><td style="text-align: center">
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </td></tr>
    </table>
        &nbsp;</div>
    </form>
</body>
</html>
