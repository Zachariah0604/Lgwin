<%@ Page Language="C#" AutoEventWireup="true"  Inherits="KararMessageIndex" Codebehind="KararMessageIndex.aspx.cs" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <link href="../css/karat.css" rel="stylesheet" type="text/css">
    <title>卡瑞特后台</title>
    <style type="text/css">
        .style1
        {
            width: 7%;
        }
    </style>
</head>
<script type="text/javascript">
    function SelectAll(tempControl) {
        //将除头模板中的其它所有的CheckBox取反  
        var theBox = tempControl;
        xState = theBox.checked;
        elem = theBox.form.elements;
        for (i = 0; i < elem.length; i++)
            if (elem[i].type == "checkbox" && elem[i].id != theBox.id) {
                if (elem[i].checked != xState)
                    elem[i].click();
            }
    }   
</script>
<body>
    <form id="form1" runat="server">
    <div>
        <table width="95%" align="center">
            <tr>
                <td>
                    <table width="100%" border="0" align="center" cellpadding="0" cellspacing="1" class="border">
                        <tr class="title">
                            <td colspan="7">
                                留言管理
                            </td>                     
                            <td>
                                <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">留言板静态化</asp:LinkButton>
                            </td>
                            <td colspan="2">
                            <a href="../message.html" target="_blank">前台查看</a>
                            </td>
                           
                        </tr>
                        <tr class="title">
                            <td height="30" class="style1">
                                <asp:CheckBox ID="CheckAll" runat="server" onclick="javascript:SelectAll(this);"
                                    Text="全选" Width="50px" />
                            </td>
                            <td height="30" width="10%">
                                <div align="center">
                                    <strong>姓名</strong></div>
                            </td>
                            <td height="30" width="10%">
                                <div align="center">
                                    <strong>主题</strong></div>
                            </td>
                            <td height="30" width="10%">
                                <div align="center">
                                    <strong>邮箱</strong></div>
                            </td>
                            <td height="30" width="10%">
                                <div align="center">
                                    <strong>留言时间</strong></div>
                            </td>
                            <td height="30" width="10%">
                                <div align="center">
                                    <strong>回复时间</strong></div>
                            </td>
 
                            <td height="30" width="10%">
                                <div align="center">
                                    <strong>已审核</strong></div>
                            </td>
                            <td height="30" width="10%">
                                <div align="center">
                                    <strong>审核人</strong></div>
                            </td>
                            <td height="30" width="5%">
                                <div align="center">
                                    编辑</div>
                            </td>
                            <td height="30" width="5%">
                                <div align="center">
                                    <strong>删除</strong></div>
                            </td>
                        </tr>
                        <asp:Repeater ID="Repeater1" runat="server">
                            <ItemTemplate>
                                <tr align="center" class="tdbg">
                                    <td>
                                        <asp:CheckBox ID="CheckBox1" runat="server" />
                                        <asp:HiddenField ID="HiddenField1" runat="server" Value='<%# Eval("ID")%>' />
                                    </td>
                                    <td>
                                        <%# DataBinder.Eval(Container.DataItem, "name")%>
                                    </td>
                                    <td>
                                        <%# DataBinder.Eval(Container.DataItem, "topic")%>
                                    </td>
                                    <td>
                                        <%# DataBinder.Eval(Container.DataItem, "e_mail")%>
                                    </td>
                                    <td>
                                         <%# DataBinder.Eval(Container.DataItem, "m_time")%> 
                                    </td>
                                    <td>
                                        <%# DataBinder.Eval(Container.DataItem, "r_time")%>
                                    </td>
                                    <td>
                                        <%# DataBinder.Eval(Container.DataItem, "pass")%>
                                    </td>
                                    <td>
                                        <%# DataBinder.Eval(Container.DataItem, "auditor")%>
                                    </td>
                                    <td>
                                      <a href="KaratMessageReply.aspx?id=<%# DataBinder.Eval(Container.DataItem, "id")%>">>>编辑</a> 
                                    </td>
                                    <td>
                                    <a href="KararMessageIndex.aspx?id=<%# DataBinder.Eval(Container.DataItem, "id")%>" onclick="return confirm('你确定要执行删除操作？')">删除</a> 
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                        <tr align="center" class="title">
                            <td class="style1">
                                <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click" OnClientClick="return confirm('你确定要执行删除吗？')">批量删除</asp:LinkButton>
                            </td>
                            <td colspan="9">
                                <asp:Label ID="Label2" runat="server" Text="当前页码"></asp:Label>
                                [<asp:Label ID="labPage" runat="server" Text="1"></asp:Label>
                                ]<asp:Label ID="Label4" runat="server" Text="总页数"></asp:Label>
                                [<asp:Label ID="labBackPage" runat="server" Text="labBackPage"></asp:Label>
                                ]<asp:LinkButton ID="lnkbtnOne" runat="server" OnClick="lnkbtnOne_Click" Font-Underline="False">第一页</asp:LinkButton>
                                <asp:LinkButton ID="lnkbtnUp" runat="server" OnClick="lnkbtnUp_Click" Font-Underline="False">上一页</asp:LinkButton>
                                <asp:LinkButton ID="lnkbtnNext" runat="server" OnClick="lnkbtnNext_Click" Font-Underline="False">下一页</asp:LinkButton>
                                <asp:LinkButton ID="lnkbtnBack" runat="server" OnClick="lnkbtnBack_Click" Font-Underline="False">最后一页</asp:LinkButton>
                                </span>
                                <asp:Label ID="Label1" runat="server" Text="" Visible="false"></asp:Label>
                            </td>
                        </tr>
                    </table>
            </tr>
        </table>
    </div>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p style="text-align: center">
    <a href="../message.html" target="_blank"><asp:Label ID="Label5" 
            runat="server" BackColor="#8DDFFB" Font-Bold="True" Font-Size="14px" 
            Font-Underline="False"></asp:Label></a>
    </p>
    </form>
</body>
</html>
