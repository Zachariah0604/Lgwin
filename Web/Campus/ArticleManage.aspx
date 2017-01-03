<%@ Page Language="C#" AutoEventWireup="true" ResponseEncoding="gb2312"
    Inherits="Campus_ArticleManage" Codebehind="ArticleManage.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </script>
<style type="text/css">
a:link {
	text-decoration: none;
	color: #000;
}
a:visited {
	text-decoration: none;
	color: #000;
}
a:hover {
	text-decoration: none;
	color: #666;
}
</style>
</head>
<body style="margin:auto">
    <form id="form1" runat="server">
    <div align="left">
        <asp:Label ID="Label2" runat="server" Text="校园文化文章管理&gt;&gt;" Font-Bold="True" Font-Italic="False"
            Font-Names="华文中宋" Font-Size="20px"></asp:Label>
        <asp:Button ID="Button3" runat="server" BackColor="White" BorderColor="#99CCFF" BorderStyle="Solid"
            OnClick="Button3_Click" Text="未审核文章" />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="请选择栏目：" Font-Bold="True" Font-Italic="False"
            Font-Names="宋体"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"
            AutoPostBack="True" BackColor="#CCFFFF" Font-Bold="False" ForeColor="Black">
            <asp:ListItem Value="岁月理工">岁月理工</asp:ListItem>
            <asp:ListItem Value="名家讲坛">名家讲坛</asp:ListItem>
            <asp:ListItem Value="学生原创">学生原创</asp:ListItem>
            <asp:ListItem Value="心灵启迪">心灵启迪</asp:ListItem>
            <asp:ListItem Value="记者观察">记者观察</asp:ListItem>
            <asp:ListItem Value="稷下时评">稷下时评</asp:ListItem>
            <asp:ListItem Value="校园生活">校园生活</asp:ListItem>
            <asp:ListItem Value="文学之星">文学之星</asp:ListItem>
            <asp:ListItem Value="社团风采">社团风采</asp:ListItem>
            <asp:ListItem Value="网视">网视</asp:ListItem>
            <asp:ListItem Value="公告">公告</asp:ListItem>
        </asp:DropDownList>
        &nbsp;
        <asp:CheckBox ID="CheckBox2" runat="server" AutoPostBack="True" Font-Size="12px"
            Font-Bold="True" OnCheckedChanged="CheckBox2_CheckedChanged" Text="全选" BorderColor="#99CCFF"
            BorderStyle="Solid" BorderWidth="1px" />
        &nbsp;
        &nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="批量静态化"
            BorderColor="#99CCFF" BorderStyle="Solid" />
    </div>
    <div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="true" PageSize="20" PagerSettings-Position="Bottom"
            AllowSorting="True" AutoGenerateColumns="False" Width="100%" OnPageIndexChanging="GridView1_PageIndexChanging"
            OnRowDeleting="GridView1_RowDeleting" DataKeyNames="id" HeaderStyle-Font-Size="Small"
            HeaderStyle-Height="30px" CellPadding="0" ForeColor="#333333" GridLines="None"
            align="center" RowStyle-BorderColor="BlueViolet" RowStyle-BorderStyle="Solid"
            RowStyle-BorderWidth="1px" Style="margin-bottom: 0px; margin-top: 0px;" OnRowDataBound="GridView1_RowDataBound">
            <RowStyle BackColor="#F7F6F3" Font-Size="Smaller" Height="12" ForeColor="#333333" />
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333"/>
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderStyle-Width="3%">
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                        <asp:HiddenField ID="HiddenField1"
                            runat="server" Value='<%# Eval("ID") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Title" HeaderStyle-Width="35%" HeaderText="标题" SortExpression="Title">
                 <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="Author" HeaderStyle-Width="10%" HeaderText="作者" SortExpression="Author">
                    <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="From" HeaderStyle-Width="140px" HeaderText="文章来源" SortExpression="From">
                    <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                
                <asp:BoundField DataField="Date" HeaderStyle-Width="90px" HeaderText="日期" SortExpression="Date">
                    <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>

                <asp:BoundField DataField="Editor" HeaderStyle-Width="50px" HeaderText="编辑" SortExpression="Editor">
                    <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:CheckBoxField DataField="Audited" HeaderStyle-Width="60px" HeaderText="未审核"
                    SortExpression="Audited">
                    <ItemStyle HorizontalAlign="Center" />
                </asp:CheckBoxField>
                <asp:CheckBoxField DataField="_Index" HeaderStyle-Width="80px" HeaderText="新闻网显示"
                    SortExpression="_Index">
                    <ItemStyle HorizontalAlign="Center" />
                </asp:CheckBoxField>
                <asp:CheckBoxField DataField="Recommend" HeaderStyle-Width="60px" HeaderText="编辑推荐"
                    SortExpression="Recommend">
                    <ItemStyle HorizontalAlign="Center" />
                </asp:CheckBoxField>
                <asp:HyperLinkField DataNavigateUrlFields="id" HeaderStyle-Width="30px" DataNavigateUrlFormatString="Html_03\Preview.aspx?id={0}" Target="_blank"
                    HeaderText="预览" Text="预览">
                    <HeaderStyle Width="30px"></HeaderStyle>
                </asp:HyperLinkField>
                <asp:HyperLinkField DataNavigateUrlFields="id" HeaderStyle-Width="30px" DataNavigateUrlFormatString="Article_Edite.aspx?id={0}"
                    HeaderText="编辑" Text="编辑">
                    <HeaderStyle Width="30px"></HeaderStyle>
                </asp:HyperLinkField>
                <asp:CommandField HeaderText="删除" HeaderStyle-Width="5%" ShowDeleteButton="True" />
                <%--<asp:Button ID="Button2" runat="server" Font-Size="9pt" Text="删除" OnClick="Button2_Click" />--%>
            </Columns>
        </asp:GridView>
    </div>
    <p style="text-align:center">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="删除选择项" BorderColor="#99CCFF"
            BorderStyle="Solid" />
        </p>
    </form>
</body>
</html>
