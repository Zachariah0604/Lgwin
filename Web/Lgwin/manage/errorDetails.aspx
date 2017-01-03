<%@ Page Language="C#" AutoEventWireup="true" Inherits="errorDetails" Codebehind="errorDetails.aspx.cs" %>

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
    <td>
        <table width="500px" border="0"  align="center" cellspacing="1" cellpadding="0" bgcolor="White">
  <tr class="">
    <td align="right" width="20%">问题或建议：</td>
    <td>
        <asp:TextBox ID="tb_problem" runat="server" Height="65px" TextMode="MultiLine" 
            Width="394px"></asp:TextBox></td>
  </tr>
  <tr class="tdbg">
    <td align="right">测试日期：</td>
    <td>
        <asp:TextBox ID="tb_time" runat="server"></asp:TextBox>
      </td>
  </tr>
  <tr class="tdbg">
    <td align="right">发现人：</td>
    <td>
        <asp:TextBox ID="tb_observer" runat="server"></asp:TextBox>
      </td>
  </tr>
  <tr class="tdbg">
    <td align="right">解决办法：</td>
    <td>
        <asp:TextBox ID="tb_solutions" runat="server" Height="50px" TextMode="MultiLine" 
            Width="385px"></asp:TextBox>
      </td>
  </tr>
  <tr class="tdbg">
    <td align="right">是否解决：</td>
    <td>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>已解决</asp:ListItem>
            <asp:ListItem>未解决</asp:ListItem>
        </asp:DropDownList>
      </td>
  </tr>
   
  <tr id="jieshao" class="tdbg"><td colspan="2" style="line-height:25px; text-align:left; padding-top:5px; padding-bottom:10px;">
    <p>解决人：<asp:Label ID="lb_label" runat="server" Text="Label"></asp:Label>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="提交" onclick="Button1_Click" />
        <asp:HiddenField ID="hidden_id" runat="server" />
      </p></td></tr>
</table>
       
    </td>
  </tr>
</table>
    </div>
    </form>
</body>
</html>