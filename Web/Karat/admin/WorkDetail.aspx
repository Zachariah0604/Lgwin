<%@ Page Language="C#" AutoEventWireup="true"
    Inherits="karat1_admin_KaratWorkDetail" Codebehind="WorkDetail.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <link href="css/Article.Css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
        <table width="90%" border="0" cellspacing="1" cellpadding="0" bordercolor="#FFFFFF"
            bgcolor="#DEF0FA" class="border">
            <tr>
                <td colspan="2" class="title">
                    卡瑞特作品增加（修改）页
                </td>
            </tr>
            <tr class="tdbg">
                <td width="15%" align="center">
                    <strong>作品名称：</strong>
                </td>
                <td align="left" width="85%">
                    <asp:TextBox ID="TextBox1" runat="server" Width="50%"></asp:TextBox>
                </td>
            </tr>
            <tr class="tdbg">
                <td align="center">
                    <strong>类型：</strong>
                    <td align="left">
                        <asp:TextBox ID="TextBox2" runat="server" Width="30%"></asp:TextBox>
                    </td>
            </tr>
            <tr class="tdbg">
                <td align="center">
                    <strong>完成时间：</strong>
                    <td align="left">
                        <asp:TextBox ID="TextBox3" runat="server" Width="30%"></asp:TextBox>
                    </td>
            </tr>
            <tr class="tdbg">
                <td align="center">
                    <strong>建站工具：</strong>
                    <td align="left">
                       <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatColumns="4" 
                        RepeatDirection="Horizontal" style="margin-bottom: 19px" Width="500px">
                        <asp:ListItem Value="1">Dreamwaver</asp:ListItem>
                        <asp:ListItem Value="2">Photoshop</asp:ListItem>
                        <asp:ListItem Value="3">Visual Studio</asp:ListItem>
                        <asp:ListItem Value="4">SQL Server</asp:ListItem>
                        <asp:ListItem Value="4">Adobe Flash</asp:ListItem>
                        <asp:ListItem Value="5">Flash Builder</asp:ListItem>
                        <asp:ListItem Value="6">IIIustrator</asp:ListItem>
                    </asp:CheckBoxList>
                    </td>
            </tr>
            <tr class="tdbg">
                <td align="center">
                    <strong>作品网址：</strong>
                    <td align="left">
                        <asp:TextBox ID="TextBox5" runat="server" Width="60%"></asp:TextBox>
                    </td>
            </tr>
            <tr class="tdbg">
                <td align="center">
                    <strong>作品图片：</strong>
                    <td align="left">
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                        <asp:Label ID="Label1" runat="server" Text="Label" Visible="false"></asp:Label>
                        <font color="red" >*注意</font>（修改作品展示时，此项不必重新填写）</td>
            </tr>
            <tr class="tdbg">
                <td colspan="2" align="center">
                    <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" />
                    &nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="取消" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
