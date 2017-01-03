<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KaratImagesEdit.aspx.cs" Inherits="Lgwin.Karat.admin.KaratImagesEdit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title> 编辑目录</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 477px">
            <tr>
                <td align="center" colspan="3" style="width: 539px">
                    名称修改</td>
            </tr>
            <tr>
                <td colspan="3" style="height: 20px; width: 539px;">
                    &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                    <asp:Label ID="Label2" runat="server" Height="18px" Text="旧名称：" Width="64px"></asp:Label>
                    &nbsp; &nbsp; &nbsp;&nbsp;
                    <asp:TextBox ID="TextBox1" runat="server" Height="22px" Width="155px"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="3" style="width: 539px">
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:Label ID="Label1" runat="server" Text="新名称："></asp:Label>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:TextBox
                        ID="tbxDirName" runat="server" CausesValidation="True" Height="22px" Width="155px"></asp:TextBox>&nbsp;&nbsp; &nbsp;<asp:RequiredFieldValidator
                            ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbxDirName" ErrorMessage="*名称不能为空"></asp:RequiredFieldValidator>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="center" colspan="3" style="width: 539px">
                    <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="修改" />
                    &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;<asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click"
                        Text="返回" CausesValidation="False" /></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
