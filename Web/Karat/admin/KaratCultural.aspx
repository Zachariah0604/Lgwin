<%@ Page Language="C#" AutoEventWireup="true" Inherits="karat1_admin_KaratCultural" Codebehind="KaratCultural.aspx.cs" %>

<%@ Register TagPrefix="CE" Namespace="CuteEditor" Assembly="CuteEditor" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <link href="css/Article.Css" rel="stylesheet" type="text/css" />
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 93px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
        <table width="90%" border="0" cellspacing="1" cellpadding="0" bordercolor="#FFFFFF"
            bgcolor="#DEF0FA" class="border">
            <tr>
                <td colspan="2" class="title">
                    团队文化
                </td>
            </tr>
            <tr class="tdbg">
                <td align="center" class="style1">
                    <strong>所属专题：</strong>
                </td>
                <td align="center">
                    团队理念
                </td>
            </tr>
            <tr class="tdbg">
                <td align="center" class="style1">
                    团结：
                </td>
                <td align="left">
                    <asp:TextBox ID="TextBox1" runat="server" Width="90%"></asp:TextBox>
                </td>
            </tr>
            <tr class="tdbg">
                <td align="center" class="style1">
                    高效：
                </td>
                <td align="left">
                    <asp:TextBox ID="TextBox2" runat="server" Width="90%"></asp:TextBox>
                </td>
            </tr>
            <tr class="tdbg">
                <td align="center" class="style1">
                    严谨：
                </td>
                <td align="left">
                    <asp:TextBox ID="TextBox3" runat="server" Width="90%"></asp:TextBox>
                </td>
            </tr>
            <tr class="tdbg">
                <td align="center" class="style1">
                    汇才：
                </td>
                <td align="left">
                    <asp:TextBox ID="TextBox4" runat="server" Width="90%"></asp:TextBox>
                </td>
            </tr>
            <tr class="tdbg">
                <td align="center" class="style1">
                    <strong>所属专题：</strong>
                </td>
                <td align="center">
                    部门设置
                </td>
            </tr>
            <tr class="tdbg">
                <td align="center" class="style1">
                    站长：
                </td>
                <td align="left">
                    <asp:TextBox ID="TextBox8" runat="server" Width="50%"></asp:TextBox>
                    &nbsp;&nbsp;</td>
            </tr>
            <tr class="tdbg">
                <td align="center" class="style1">
                    采编部：
                </td>
                <td align="left">
                    <asp:TextBox ID="TextBox5" runat="server" Width="90%"></asp:TextBox>
                </td>
            </tr>
            <tr class="tdbg">
                <td align="center" class="style1">
                    综合部：
                </td>
                <td align="left">
                    <asp:TextBox ID="TextBox6" runat="server" Width="90%"></asp:TextBox>
                </td>
            </tr>
            <tr class="tdbg">
                <td align="center" class="style1">
                    技术部：
                </td>
                <td align="left">
                    <asp:TextBox ID="TextBox7" runat="server" Width="90%"></asp:TextBox>
                </td>
            </tr>
            <tr class="tdbg">
                <td align="center" class="style1">
                    <strong>所属专题：</strong>
                </td>
                <td align="center">
                    卡瑞特简介</td>
            </tr>
            <tr class="tdbg">
                <td align="center" class="style1">
                    <strong>新闻内容：</strong>
                    <div id="timer">
                    </div>
                    <td align="left">
                        <CE:Editor ID="Editor1" runat="server" FilesPath="CuteSoft_Client/CuteEditor/" Height="700px"
                            SecurityPolicyFile="Admin.config" ThemeType="Office2007" Width="95%">
                        </CE:Editor>
                    </td>
                    </td>
            </tr>
            <tr class="tdbg">
                <td colspan="2" align="center">
                </td>
            </tr>
            <tr class="tdbg">
                <td colspan="2" align="center">
                    <asp:Button ID="Button1" runat="server" Text="提交" onclick="Button1_Click" />
                    &nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="取消" onclick="Button2_Click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
