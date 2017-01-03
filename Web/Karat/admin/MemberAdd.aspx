<%@ Page Language="C#" AutoEventWireup="true" Inherits="karat1_admin_KaratMemberAdd" Codebehind="MemberAdd.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <link href="css/Article.Css" rel="stylesheet" type="text/css" />
    <script src="../javascript/teammembers.js" type="text/javascript"></script>
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 288px;
        }
        .style2
        {
            width: 75px;
        }
        .style3
        {
            width: 10%;
        }
    </style>
    <script language="javascript" type="text/javascript">
// <![CDATA[

        function texttext_onclick() {

        }

// ]]>
    </script>
</head>
<body>
    <form id="form1" runat="server" name="userinfo" method="post">
    <div align="center">
        <table width="90%" border="0" cellspacing="1" cellpadding="0" bordercolor="#FFFFFF"
            bgcolor="#DEF0FA" class="border">
            <tr>
                <td colspan="4" class="title">
                    <strong><font color="#FFFFFF">成员添加编辑</font></strong>
                </td>
            </tr>
            <tr class="tdbg">
                <td align="center" class="style3">
                    <strong>姓名：</strong>
                </td>
                <td align="left" class="style1">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td align="center" class="style2">
                    <strong>部门：</strong>
                </td>
                <td align="left">
                    <asp:DropDownList ID="DropDownList1" runat="server" 
                        onselectedindexchanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true">
                        <asp:ListItem >站长</asp:ListItem>
                        <asp:ListItem>综合部</asp:ListItem>
			<asp:ListItem>采编部</asp:ListItem>
                           <asp:ListItem>技术部(美工)</asp:ListItem>
                              <asp:ListItem>技术部(程序)</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr class="tdbg">
                <td align="center" class="style3">
                    <strong>院系：</strong>
                </td>
                <td align="left" class="style1">
                    <asp:DropDownList ID="DropDownList5" runat="server" Width="150">
                        <asp:ListItem>机械工程学院</asp:ListItem>
                        <asp:ListItem>交通与车辆工程学院</asp:ListItem>
                        <asp:ListItem>农业工程与食品科学学院</asp:ListItem>
                        <asp:ListItem>计算机科学与技术学院</asp:ListItem>
                        <asp:ListItem>化学工程学院</asp:ListItem>
                        <asp:ListItem>法学院</asp:ListItem>
                        <asp:ListItem>建筑工程学院</asp:ListItem>
                        <asp:ListItem>资源与环境工程学院</asp:ListItem>
                        <asp:ListItem>材料科学与工程学院</asp:ListItem>
                        <asp:ListItem>电气与电子工程学院</asp:ListItem>
                        <asp:ListItem>生命科学学院</asp:ListItem>
                        <asp:ListItem>外国语学院</asp:ListItem>
                        <asp:ListItem>美术学院</asp:ListItem>
                        <asp:ListItem>理学院</asp:ListItem>
                        <asp:ListItem>文学与新闻传播学院</asp:ListItem>
                        <asp:ListItem>音乐学院</asp:ListItem>
                        <asp:ListItem>商学院</asp:ListItem>
                        <asp:ListItem>鲁泰纺织服装学院</asp:ListItem>
                        <asp:ListItem>体育学院</asp:ListItem>
                        <asp:ListItem>远程教育学院</asp:ListItem>
                        <asp:ListItem>其他</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td align="center" class="style2">
                    <strong>职务：</strong>
                </td>
                <td align="left">
                    <asp:DropDownList ID="DropDownList2" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr class="tdbg">
                <td align="center" class="style3">
                    <strong>邮箱：</strong>
                </td>
                <td align="left" class="style1">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
                <td align="center" class="style2">
                    <strong>是否在职：</strong>
                </td>
                <td align="left">
                    <asp:DropDownList ID="DropDownList3" runat="server">
                        <asp:ListItem>是</asp:ListItem>
                        <asp:ListItem>否</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr class="tdbg">
                <td align="center" class="style3">
                    <strong>Q Q：</strong>
                </td>
                <td align="left" class="style1">
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </td>
                <td align="center" class="style2">
                    <strong>电话：</strong>
                </td>
                <td align="left">
                    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr class="tdbg">
                <td align="center" class="style3">
                    <strong>头像：</strong>
                </td>
                <td align="left" class="style1">
                    <asp:FileUpload ID="FileUpload1" runat="server" Width="206px" />
                    <asp:Label ID="Label1" runat="server" Text="" Visible="false"></asp:Label>
                </td>
                <td align="center" class="style2">
                    <strong>第几届：</strong>
                </td>
                <td align="left">
                    <asp:DropDownList ID="DropDownList4" runat="server" Width="150">
                        <asp:ListItem>2002</asp:ListItem>
                        <asp:ListItem>2003</asp:ListItem>
                        <asp:ListItem>2004</asp:ListItem>
                        <asp:ListItem>2005</asp:ListItem>
                        <asp:ListItem>2006</asp:ListItem>
                        <asp:ListItem>2007</asp:ListItem>
                        <asp:ListItem>2008</asp:ListItem>
                        <asp:ListItem>2009</asp:ListItem>
                        <asp:ListItem Selected="True">2010</asp:ListItem>
                        <asp:ListItem>2011</asp:ListItem>
                        <asp:ListItem>2012</asp:ListItem>
                        <asp:ListItem>2013</asp:ListItem>
                        <asp:ListItem>2014</asp:ListItem>
                        <asp:ListItem>2015</asp:ListItem>
                        <asp:ListItem>2016</asp:ListItem>
                        <asp:ListItem>2017</asp:ListItem>
                        <asp:ListItem>2018</asp:ListItem>
                        <asp:ListItem>2019</asp:ListItem>
                        <asp:ListItem>2020</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr class="tdbg">
                <td colspan="4" align="left">
                     
                    <font color="red">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *注意</font>（修改成员信息时，头像不必重新上传）</td>
            </tr>
            <tr class="title">
                <td colspan="4" align="center">
                    <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" />
                    &nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="取消" CausesValidation="false" />
                </td>
            </tr>
        </table>
    </div>
    <asp:Label ID="imgurl" runat="server" Text="Label" Visible="false"></asp:Label>
    <asp:Label ID="beizhu" runat="server" Text="Label" Visible="false"></asp:Label>
    </form>
</body>
</html>
