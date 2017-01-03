<%@ Page Language="C#" AutoEventWireup="true" Inherits="PicManage" Codebehind="PicManage.aspx.cs" %>

<%@ Register assembly="CuteEditor" namespace="CuteEditor" tagprefix="CE" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            height: 49px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table align="center">
    <tr><td>
        <asp:Label ID="Label1" runat="server" Text="注意：只允许上传bmp、jpg和gif格式的图片"></asp:Label>
        </td></tr>
         <tr><td>
             <asp:DropDownList ID="DropDownList1" runat="server" Width="200px">
             <asp:ListItem Value="名家讲坛">名家讲坛</asp:ListItem>
               <asp:ListItem Value="文学之星">文学之星</asp:ListItem>
             </asp:DropDownList>
        </td></tr>
    <tr><td>
        <asp:FileUpload ID="PicUpload" runat="server" Height="25px" Width="300px" />
        </td></tr>
    <tr><td align="center" class="style1">
        <asp:Button ID="upload" runat="server" Text="上传" onclick="upload_Click" />
      
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button_return" runat="server" onclick="Button_return_Click" 
            Text="返回控制台" />
     
        <br />
        <asp:Label ID="Label_Msg" runat="server" Text="Label"></asp:Label>
        </td></tr>
    </table>
    
    </div>
    </form>
</body>
</html>
