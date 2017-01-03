<%@ Page Language="C#" AutoEventWireup="true" Inherits="karat3_Index" Codebehind="Index.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <link href="../css/karat.Css" rel="stylesheet" type="text/css"></link>
    <title></title>
    <style type="text/css">
        .style1
        {
            text-align: center;
            background-color: #CCFF99;
        }
        .style2
        {
            color: #FF0000;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table width="100%" border="0" align="center" cellpadding="0" cellspacing="1" class="border">
            <tr>
                <td height="30" class="style1" colspan="9">
                    <span class="style2"><font size="6">卡瑞特后台管理中心</font></span>
                </td>
            </tr>
            <tr align="center" class="tdbg">
                <td class="tdbg3" height="30" width="10%">
                    <asp:LinkButton ID="LinkButton7" runat="server" OnClick="LinkButton7_Click">团队动态</asp:LinkButton>
                </td>
                <td class="tdbg3" height="30" width="10%">
                    <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click">卡瑞特心语</asp:LinkButton>
                </td>
                <td class="tdbg3" height="30" width="10%">
                    <a href="ArticleAdd.aspx" target="_self">添加文章</a>
                </td>
                <td class="tdbg3" height="30" width="10%">
                    <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">团队文化</asp:LinkButton>
                </td>
                <td class="tdbg3" height="30" width="10%">
                    <a href="MemberManage.aspx" target="_self">成员管理</a>
                </td>
                <td class="tdbg3" height="30" width="10%">
                    <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">作品管理</asp:LinkButton>
                </td>
                <td class="tdbg3" height="30" width="10%">
                    <a href="KaratBaoMingManage.aspx" target="_self">招聘管理</a>
                </td>
                <td class="tdbg3" height="30" width="10%">
                    <asp:LinkButton ID="LinkButton6" runat="server" OnClick="LinkButton6_Click">大事记</asp:LinkButton>
                </td>
                <td class="tdbg3" height="30" width="10%">
                    <a href="KararMessageIndex.aspx" target="_self">留言管理</a>
                </td>
            </tr>
            <tr align="center" class="tdbg">
                <td class="tdbg3" height="30" width="10%">
                    <a href="KaratImagesManage.aspx" target="_self">韶华掠影</a>
                </td>
                <td class="tdbg3" height="30" width="10%">
                    &nbsp;
                </td>
                <td class="tdbg3" height="30" width="10%">
                    &nbsp;
                </td>
                <td class="tdbg3" height="30" width="10%">
                    &nbsp;
                </td>
                <td class="tdbg3" height="30" width="10%">
                </td>
                <td class="tdbg3" height="30" width="10%">
                    &nbsp;
                </td>
                <td class="tdbg3" height="30" width="10%">
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">一级页静态化</asp:LinkButton>
                </td>
                <td class="tdbg3" height="30" width="10%">
                    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">二三级页静态化</asp:LinkButton>
                </td>
                <td class="tdbg3" height="30" width="10%">
                    <asp:LinkButton ID="LinkButton8" runat="server"><a href="../index.html" target="_blank">查看首页</a></asp:LinkButton>
                </td>
            </tr>
        </table>
    </div>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p style="text-align: center">
        <a href="../index.html" target="_blank">
            <asp:Label ID="Label1" runat="server" BackColor="#8DDFFB" Font-Bold="True" Font-Size="14px"
                Font-Underline="False"></asp:Label></a>
    </p>
    <p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center">
        &nbsp;</p>
    </form>
    <table width="90%">
        <tr width="20">
            <td height="300">
                <font size="3"><font size="5" color="red">&nbsp;使用说明：<br />
                </font> &nbsp;</font><font size="2"><br />
&nbsp;&nbsp;&nbsp; 一.此版本共分为七个板块，其中“卡瑞特心语”与“团队动态”同属文章板块（添加文章可实现文章板块内容的添加），其他六个板块为“团队文化”、“成员管理”、“作品展示”、“招聘管理”、“大事记”和“留言管理”</font>
                <font size="2">
                <br />
                <br />
&nbsp;&nbsp;&nbsp; 二.静态化说明：除“留言管理”模块，其他六个板块均可通过“一级页静态化”和“二三级页静态化”实现静态化（“留言管理”需独立静态化）
                 
                <br />
                <br />
&nbsp;&nbsp;&nbsp; 三.首页展示的“团队动态”文章中必须有图片，且首页“团队文章”数量必须大于六篇 
                </font>
            </td>
        </tr>
    </table>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p style="text-align: center">
        &nbsp;</p>
</body>
</html>
