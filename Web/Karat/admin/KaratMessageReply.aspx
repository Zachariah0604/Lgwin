<%@ Page Language="C#" AutoEventWireup="true" Inherits="MessageReply" Codebehind="KaratMessageReply.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<link href="../css/karat.css" rel="stylesheet" type="text/css">
 <script language="javascript" src="../javascript/selectDateTime.js"  type="text/javascript" charset="utf-8"></script>
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="0" cellpadding="0" cellspacing="1" class="border" width="100%" align="center">
            <tr class="title">
                <td height="40" colspan="5">
                    <div align="center">
                        留言回复</div>
                </td>
            </tr><asp:Repeater ID="repeater1" runat="server">
                    <ItemTemplate>

            <tr class="tdbg">
                <td align="right" width="100px">
                    留言者姓名：
                </td>
                <td>
                    <%# DataBinder.Eval(Container.DataItem, "name")%>
                </td>
                <td align="right">
                    主题：
                </td>
                <td colspan="2">
                    <%# DataBinder.Eval(Container.DataItem, "topic")%>
                </td>
            </tr>
            <tr class="tdbg">
                <td align="right">
                    留言内容：
                </td>
                <td height="60" colspan="4">
                    
                    <%# DataBinder.Eval(Container.DataItem, "m_nr")%>
                        
                </td>
            </tr>
            </ItemTemplate>
                        </asp:Repeater>
            <tr class="tdbg">
                <td align="right">
                    留言时间：
                </td>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </td>
                <td align="right">
                    审核状态:
                </td>
                <td colspan="2">
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr class="tdbg">
                <td align="right">
                    回复内容：
                </td>
                <td colspan="4">
                    <asp:TextBox ID="huifu" runat="server" Height="100px" TextMode="MultiLine" Width="90%"></asp:TextBox>
                </td>
            </tr>
            <tr class="tdbg">
                <td align="right">
                    是否已审核：
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>未审核</asp:ListItem>
                        <asp:ListItem>已审核</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td align="right">
                    回复人：
                </td>
                <td colspan="2">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TextBox2" runat="server" ErrorMessage="请填写姓名！"></asp:RequiredFieldValidator>

                </td>
            </tr>
            <tr class="tdbg"><td align="right">回复时间</td><td colspan="3">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;*日期格式要写成&nbsp; 2011-2-2&nbsp; (或者是2011-2-2 0:0:0)</td></tr>
            <tr class="title">
                <td height="40" colspan="5">
                    <div align="center">
                        <asp:Button ID="Button1" runat="server" Text="回复" onclick="Button1_Click1"  CausesValidation="true" onclientclick="return confirm('你确定要回复？')"/>
                        &nbsp;&nbsp;
                        <asp:Button ID="Button2" runat="server" Text="返回" onclick="Button2_Click" CausesValidation="false" />
                    </div>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
