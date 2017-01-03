<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KaratImagesBuild.aspx.cs" Inherits="Lgwin.Karat.admin.KaratImagesBuild" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>新建目录</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 618px; height: 121px">
            <tr>
                <td align="center" colspan="3">
                    目录添加</td>
            </tr>
            <tr>
                <td align="left" colspan="3" style="height: 28px">
                    &nbsp;<asp:Label ID="Label1" runat="server" Text="目录名称：" Width="85px"></asp:Label>&nbsp;
                    &nbsp;<asp:TextBox ID="tbxDirName" runat="server" Width="186px" CausesValidation="True"></asp:TextBox>&nbsp;
                    <asp:RequiredFieldValidator ID="rfvNameNotNull" runat="server" ControlToValidate="tbxDirName"
                        ErrorMessage="*名字不能为空"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td align="center" colspan="3" style="height: 25px">
                    <asp:Button ID="btnAddDir" runat="server" OnClick="btnAddDir_Click" Text="添加" />
                    &nbsp; &nbsp; &nbsp;
                    <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" Text="返回" CausesValidation="False" /></td>
            </tr>
            <tr>
                <td colspan="3">
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
