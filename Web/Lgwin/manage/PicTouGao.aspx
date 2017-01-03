<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_PicTouGao" Codebehind="PicTouGao.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
    <link href="Inc/Admin_Style.Css" rel="stylesheet" type="text/css">
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    <table border="0" align="center" cellpadding="0" cellspacing="1" class="border">
    <tr class="tdbg">
    <td style="padding-top:10px"><asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            ShowHeader="False">
            <Columns>
                <asp:TemplateField>
                <ItemTemplate>
                <img src='<%#Eval("src") %>' height="300" width="400" />
                </ItemTemplate></asp:TemplateField>                
            <asp:TemplateField>
                <ItemTemplate>
                <asp:CheckBox runat="server" ID="c1" />
                </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView></td></tr>
    <tr class="title"><td>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="删除选择项" />
    </td></tr></table>
    
            
    </div>
    </form>
</body>
</html>
