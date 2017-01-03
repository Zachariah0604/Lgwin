<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_CaifangDetails" Codebehind="CaifangDetails.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="Inc/Admin_Style.Css" rel="stylesheet" type="text/css">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
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
    <td align="right" width="20%">活动主题：</td>
    <td><%# DataBinder.Eval(Container.DataItem, "Title")%></td>
  </tr>
  <tr class="tdbg">
    <td align="right">时间：</td>
    <td><%# Eval("Time")%></td>
  </tr>
  <tr class="tdbg">
    <td align="right">地点：</td>
    <td><%#Eval("Place")%></td>
  </tr>
  <tr class="tdbg">
    <td align="right">单位：</td>
    <td><%# Eval("Organization")%></td>
  </tr>
  <tr class="tdbg">
    <td align="right">出席领导：</td>
    <td><%#Eval("Leader")%></td>
  </tr>
   
  <tr id="jieshao" class="tdbg"><td colspan="2" style="line-height:25px; text-align:left; padding-top:5px; padding-bottom:10px;">
    <p> <%# DataBinder.Eval(Container.DataItem, "Description")%></p></td></tr>
</table>
        </ItemTemplate>
        </asp:FormView>
    </td>
  </tr>
</table>
    </div>
    </form>
</body>
</html>
