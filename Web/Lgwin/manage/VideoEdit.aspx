<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_VideoEdit" Codebehind="VideoEdit.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>无标题页</title>
<link href="Inc/Admin_Style.Css" rel="stylesheet" type="text/css">  
</head>
<body style="margin-top:10px">
<form id="form1" runat="server">
    <div>
    <table width="90%" border="0" align="center" cellpadding="0" cellspacing="1" class="border">
<tr class="title"> <td colspan="4" align="center">视频音乐修改</td>
  </tr>
  <tr class="tdbg" style="padding-top:10px;">
    <td width="10%">&nbsp;</td>
    <td width="20%"><div align="right">当前修改文件ID：</div></td>
    <td>
        <asp:Label ID="Label_dangqian" runat="server"></asp:Label>
                    （<asp:Label ID="Label_name" runat="server"></asp:Label>
        ）</td>
    <td width="10%">&nbsp;</td>
  </tr>
  <tr class="tdbg">
    <td>&nbsp;</td>
    <td><div align="right">文件指向链接：</div></td>
    <td>
        <asp:TextBox ID="TextBox_href" runat="server" Width="250px"></asp:TextBox>
                    </td>
    <td>&nbsp;</td>
  </tr>
    <tr class="tdbg">
    <td>&nbsp;</td>
    <td><div align="right">文件标题：</div></td>
    <td>
        <asp:TextBox ID="TextBox_title" runat="server" Width="250px"></asp:TextBox>
                    </td>
    <td>&nbsp;</td>
  </tr>
  <tr class="tdbg">
    <td>&nbsp;</td>
    <td><div align="right">文件来源：</div></td>
    <td>
        <asp:TextBox ID="TextBox_From" runat="server" Width="250px"></asp:TextBox>
                    </td>
    <td>&nbsp;</td>
  </tr>
  <tr class="tdbg">
    <td>&nbsp;</td>
    <td><div align="right">上传时间：</div></td>
    <td>
        <asp:TextBox ID="TextBox_time" runat="server" Width="250px"></asp:TextBox>
                    </td>
    <td>&nbsp;</td>
  </tr>
  <tr class="tdbg">
    <td>&nbsp;</td>
    <td><div align="right">文件简评：</div></td>
    <td>
        <asp:TextBox ID="TextBox_jianping" runat="server" Height="131px" 
            TextMode="MultiLine" Width="375px"></asp:TextBox>
                    </td>
    <td>&nbsp;</td>
  </tr>
    <tr class="tdbg">
    <td>&nbsp;</td>
    <td></td>
    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button_up" runat="server" Text="修改" onclick="Button_up_Click" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button_cancel" runat="server" Text="取消" 
            onclick="Button_cancel_Click" />
                    </td>
    <td>&nbsp;</td>
  </tr>
</table>
    </div>
    </form>
</body>
</html>
