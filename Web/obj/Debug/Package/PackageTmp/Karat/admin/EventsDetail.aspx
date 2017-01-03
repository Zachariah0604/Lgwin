<%@ Page Language="C#" AutoEventWireup="true" Inherits="karat1_admin_EventsArtDetail" Codebehind="EventsDetail.aspx.cs" %>
<%@ Register TagPrefix="CE" Namespace="CuteEditor" Assembly="CuteEditor" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
 <link href="css/Article.Css" rel="stylesheet" type="text/css" />
    <title></title>
    <style type="text/css">
        .style1
        {
            height: 8px;
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
                    <strong><font color="#FFFFFF">文章编辑</font></strong>
                </td>
            </tr>
            <tr class="tdbg">
                <td width="15%"  align="center">
                    <strong>年号：</strong>
                </td>
                <td align="left" width="85%">
                    <asp:TextBox ID="TextBox1" runat="server" Width="90%"></asp:TextBox>
                </td>
            </tr>
            <%--<tr class="tdbg">
                <td width="15%"  align="center">
                    <strong>具体时间：</strong>
                </td>
                <td align="left" width="85%">
                    <asp:TextBox ID="TextBox3" runat="server" Width="90%"></asp:TextBox>
                </td>
            </tr>--%>
            <tr class="tdbg">
                <td align="center">
                    <strong>内容：</strong>
                    <div id="timer">
                    </div>
                    <td align="left">
                        <ce:editor id="Editor1" runat="server" filespath="CuteSoft_Client/CuteEditor/" height="700px"
                            securitypolicyfile="Admin.config" themetype="Office2007" width="95%">
        </ce:editor>
                    </td>
            </tr>
                      <tr class="tdbg">
                <td align="center" class="style1">
                    <strong>URL：</strong></td>
                <td align="left">
                    <asp:TextBox ID="TextBox2" runat="server" Width="90%"></asp:TextBox>
                    </td>
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
