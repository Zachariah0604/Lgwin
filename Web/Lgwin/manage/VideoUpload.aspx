<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_VideoUpload" Codebehind="VideoUpload.aspx.cs" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
<link href="Inc/Admin_Style.Css" rel="stylesheet" type="text/css">  
</head>
<body style="margin-top:10px">
<form id="form1" runat="server">
    <div>
    <table width="90%" border="0" align="center" cellpadding="0" cellspacing="1" class="border">
<tr class="title"> <td colspan="4" align="center">视频音乐上传</td>
  </tr>
  <tr class="tdbg" style="padding-top:10px;">
    <td width="10%">&nbsp;</td>
    <td width="20%"><div align="right">首页视频缩略图：</div></td>
    <td>
        <asp:FileUpload ID="FileUpload2" runat="server" Width="250px" />
                    </td>
    <td width="10%">&nbsp;</td>
  </tr>
  <tr class="tdbg">
    <td>&nbsp;</td>
    <td><div align="right">选择文件：</div></td>
    <td>
        <asp:FileUpload ID="FileUpload1" runat="server" Width="250px" />
                    </td>
    <td>&nbsp;</td>
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
    <td><div align="right">文件简评：</div></td>
    <td>
        <asp:TextBox ID="TextBox_jianping" runat="server" Height="131px" 
            TextMode="MultiLine" Width="375px"></asp:TextBox>
                    </td>
    <td>&nbsp;</td>
  </tr>
    <tr class="tdbg">
    <td>
        &nbsp;</td>
    <td>
        &nbsp;</td>
    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button_up" runat="server" Text="上传" onclick="Button_up_Click" />
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
