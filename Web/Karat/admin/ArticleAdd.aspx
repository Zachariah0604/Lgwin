<%@ Page Language="C#" AutoEventWireup="true" Inherits="karat1_admin_ArticleAdd" Codebehind="ArticleAdd.aspx.cs" %>
<%@ Register TagPrefix="CE" Namespace="CuteEditor" Assembly="CuteEditor" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <link href="css/Article.Css" rel="stylesheet" type="text/css" />
 <script language="javascript" src="../javascript/selectDateTime.js"  type="text/javascript" charset="utf-8"></script>
    <title></title>
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
                <td width="15%" rowspan="2" align="center">
                    <strong>文章标题：</strong>
                </td>
                <td width="85%" align="left">
                    主标题：
                    <asp:TextBox ID="title" runat="server" Width="305px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*请填写标题名" ControlToValidate="title"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr class="tdbg">
                <td align="left">
                    副标题：——
                    <asp:TextBox ID="subtitle" runat="server" Width="280px"></asp:TextBox>
                </td>
            </tr>
            <tr class="tdbg">
                <td align="center">
                    <strong>所属专题：</strong>
                </td>
                <td align="left">
                    <asp:DropDownList ID="zt1" runat="server" Height="20px" Width="124px">
                        <asp:ListItem>卡瑞特心语</asp:ListItem>
                        <asp:ListItem>团队动态</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;*注意修改添加类别&nbsp;
                </td>
            </tr>
            <tr class="tdbg">
                <td align="center">
                    <strong>发布时间：</strong>
                </td>
                <td align="left">
                    
                    <asp:TextBox ID="datee" runat="server" Width="200px"></asp:TextBox> 
                &nbsp; *格式为2010/01/01 0:0:12</td>
            </tr>
            <tr class="tdbg">
                <td align="center">
                    <strong>是否审核：</strong>
                </td>
                <td align="left">
                   
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="100">
                        <asp:ListItem>未审核</asp:ListItem>
                        <asp:ListItem>已审核</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr class="tdbg">
                <td align="center">
                    <strong>首页展示：</strong>
                </td>
                <td align="left">
                   
                    <asp:DropDownList ID="DropDownList2" runat="server" Width="100">
                        <asp:ListItem>否</asp:ListItem>
                        <asp:ListItem>是</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr class="tdbg">
                <td align="center">
                    <strong>新闻内容：</strong>
                    <div id="timer">
                    </div>
                    <td align="left">
                        <ce:editor id="Editor1" runat="server" filespath="CuteSoft_Client/CuteEditor/" height="700px"
                            securitypolicyfile="Admin.config" themetype="Office2007" width="95%">
        </ce:editor>
                    </td>
            </tr>
            <tr class="tdbg">
                <td   align="center">
                    审核<strong>人：</strong></td>
                    <td align="left">
                    <asp:TextBox ID="author" runat="server" Width="100px"></asp:TextBox>
                    
                    <asp:Label ID="Label1" runat="server" Text="Label" Visible="false"></asp:Label>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ErrorMessage="*请填写审核人名" ControlToValidate="author"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr class="tdbg">
                <td colspan="2" align="center">
                    <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" />
                    &nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="取消" CausesValidation="false"/>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
