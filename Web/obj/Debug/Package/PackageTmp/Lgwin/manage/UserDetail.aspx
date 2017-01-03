<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_UserDetail" Codebehind="UserDetail.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="Inc/Admin_Style.Css" rel="stylesheet" type="text/css">
    <title>无标题页</title>
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
    <td rowspan="7" align="center" width="40%" style="padding-bottom:5px">
        <asp:Image ID="Img" runat="server" ImageUrl='<%#Eval("Img") %>' Width="150px" /></td>
    <td align="right" width="20%">年级：</td>
    <td><%# DataBinder.Eval(Container.DataItem,"Nianji") %></td>
  </tr>
  <tr class="tdbg">
    <td align="right">学号：</td>
    <td><%# Eval("Xuehao") %></td>
  </tr>
  <tr class="tdbg">
    <td align="right">生日：</td>
    <td><%#Mystring.dateStr(Eval("Birthday"),"yyyy-MM-dd") %></td>
  </tr>
  <tr class="tdbg">
    <td align="right">Q Q：</td>
    <td><%# Eval("QQ") %></td>
  </tr>
  <tr class="tdbg">
    <td align="right">电话：</td>
    <td><%#Eval("Tel") %></td>
  </tr>
  <tr class="tdbg">
    <td align="right">邮箱：</td>
    <td><%# DataBinder.Eval(Container.DataItem,"Email") %></td>
  </tr>
  <tr class="tdbg">
    <td align="right">班级：</td>
    <td><%# DataBinder.Eval(Container.DataItem,"Zybj") %></td>
  </tr>
  <tr class="tdbg" height="30px">
    <td align="center"><%# DataBinder.Eval(Container.DataItem,"Zhiwu") %>：<%# DataBinder.Eval(Container.DataItem,"Name") %></td>
    <td align="right">籍贯：</td>
    <td><%# DataBinder.Eval(Container.DataItem,"Jiguan") %></td>
  </tr>
  <tr id="jieshao" class="tdbg"><td colspan="3" style="line-height:25px; text-align:left; padding-top:5px; padding-bottom:10px;">
    <p> <%# DataBinder.Eval(Container.DataItem, "Jieshao")%></p></td></tr>
</table>
        </ItemTemplate>
        </asp:FormView>
    </td>
  </tr>
</table>    </div>
    </form>
</body>
</html>


