<%@ Page Language="C#" AutoEventWireup="true" Inherits="karat1_admin_KaratMessageDetail" Codebehind="KaratMessageDetail.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
    <link href="../css/karat.css" rel="stylesheet" type="text/css">
<head runat="server">
    <title></title>
    <style type="text/css">

TD,INPUT{FONT-SIZE: 12px; vertical-align:middle;}
.tdbg{ background:#def0fa; padding:0 3px; height:22;}
#jieshao { text-indent:2em;}
 
 
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div  >
        <table align="center"><tr><td>
 
        <table width="500px" border="0" align="center" cellspacing="1" cellpadding="0" bgcolor="White">
    <tr class="title" ><td colspan="2" align="center">留言信息</td></tr> 
  <tr class="tdbg">
 
    <td align="right" width="20%"><font size="2"><strong>留言人：</strong></font></td>
    <td>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
  </tr>
  <tr class="tdbg">
    <td align="right"><font size="2"><strong>留言主题：</strong></font></td>
    <td>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td>
  </tr>
    <tr class="tdbg">
    <td align="right"><font size="2"><strong>留言内容：</strong></font></td>
    <td height="30">
        <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label></td>
  </tr>
  <tr class="tdbg">
    <td align="right"><font size="2"><strong>留言时间：</strong></font></td>
    <td>
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></td>
  </tr>
  <tr class="tdbg">
    <td align="right"><font size="2"><strong>留言人邮箱：</strong></font></td>
    <td>
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></td>
  </tr>
  <tr class="tdbg">
    <td align="right"><font size="2"><strong>是否已回复：</strong></font></td>
    <td>
        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></td>
  </tr>
  <tr class="tdbg">
    <td align="right"><font size="2"><strong>回复内容：</strong></font></td>
    <td height="30">
        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></td>
  </tr>
  <tr class="tdbg">
    <td align="right"><font size="2"><strong>回复人：</strong></font></td>
    <td>
        <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label></td>
  </tr>
  <tr class="tdbg" >
   
    <td align="right"><font size="2"><strong>回复时间：</strong></font></td>
    <td>
        <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label></td>
  </tr>
   <tr class="tdbg" >
   
    <td align="right"><font size="2"><strong>回复人IP：</strong></font></td>
    <td>
        <asp:Label ID="ipadd" runat="server" Text="ipadd"></asp:Label></td>
  </tr>
 
        <tr class="title" ><td colspan="2" align="center">
      <asp:Button ID="Button1" runat="server" Text="修改" onclick="Button1_Click" />&nbsp;&nbsp;&nbsp; 
            <asp:Button ID="Button2"
          runat="server" Text="返回" onclick="Button2_Click" /></td></tr>
</table>
        
    </td></tr></table>
    </div>
    </form>
</body>
</html>
