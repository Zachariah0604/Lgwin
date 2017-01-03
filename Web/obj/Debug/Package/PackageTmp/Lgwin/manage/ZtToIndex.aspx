<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_ZtToIndex" CodeBehind="ZtToIndex.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
    <link href="Inc/Admin_Style.Css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center;">
        <br />
        <br />
        <br />
        <a href='../../topic/<% Response.Write(Session["ZtJianch"].ToString()); %>/index.html'
            target="_blank">专题首页链接，点击查看</a>
    </div>
    </form>
</body>
</html>
