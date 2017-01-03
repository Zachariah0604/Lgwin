<%@ Page Language="C#" AutoEventWireup="true" Inherits="Campus_Comment_Manage" Codebehind="Comment_Manage.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin: auto">
    <form id="form1" runat="server">
    <div with="100%">
        <div align="left" style="font-weight: bold; font-size: 14px; padding: inherit">
            <span style="font-size: 20px; font-weight:bolder;">校园文化文章评论管理&gt;&gt;<br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span>请选择栏目：<asp:DropDownList
                    ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" BackColor="#CCFFFF" Font-Bold="False" ForeColor="Black"
                    AutoPostBack="True">
                    <asp:ListItem Value="岁月理工">岁月理工</asp:ListItem>
                    <asp:ListItem Value="名家讲坛">名家讲坛</asp:ListItem>
                    <asp:ListItem Value="学生原创">学生原创</asp:ListItem>
                    <asp:ListItem Value="心灵启迪">心灵启迪</asp:ListItem>
                    <asp:ListItem Value="记者观察">记者观察</asp:ListItem>
                    <asp:ListItem Value="稷下时评">稷下时评</asp:ListItem>
                    <asp:ListItem Value="文学之星">文学之星</asp:ListItem>
                    <asp:ListItem Value="校园生活">校园生活</asp:ListItem>
                    <asp:ListItem Value="社团风采">社团风采</asp:ListItem>
                    <asp:ListItem Value="网视">网视</asp:ListItem>
                    <asp:ListItem Value="公告">公告</asp:ListItem>
                </asp:DropDownList>
            &nbsp;<asp:CheckBox ID="CheckBox2" AutoPostBack="true" runat="server" Font-Italic="False"
                OnCheckedChanged="CheckBox2_CheckedChanged" Font-Size="12px" Font-Bold="True"
                Text="全选" BorderColor="#99CCFF" BorderStyle="Solid" BorderWidth="1px" />
            &nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Text="批量审核通过" 
                OnClick="Button2_Click" BorderColor="#99CCFF" BorderStyle="Solid" />
            <br />
        </div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="true" PageSize="20" PagerSettings-Position="Bottom"
            AllowSorting="True" AutoGenerateColumns="False" OnPageIndexChanging="GridView1_PageIndexChanging" Width="100%"
            OnRowDeleting="GridView1_RowDeleting" DataKeyNames="ID" HeaderStyle-Font-Size="Small"
            HeaderStyle-Height="30px" CellPadding="0" ForeColor="#333333" GridLines="None"
            align="center" RowStyle-BorderColor="BlueViolet" RowStyle-BorderStyle="Solid"
            RowStyle-BorderWidth="1px" Style="margin-bottom: 0px; margin-top: 0px;" OnRowDataBound="GridView1_RowDataBound">
            <RowStyle BackColor="#F7F6F3" Font-Size="Smaller" Height="12" ForeColor="#333333" />
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" />
            <Columns>
             <asp:TemplateField HeaderStyle-Width="3%">
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" /><asp:HiddenField ID="HiddenField1"
                            runat="server" Value='<%# Eval("ID") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Title" HeaderStyle-Width="350px" HeaderText="文章标题" SortExpression="Title">
                </asp:BoundField>
                <asp:BoundField DataField="LanMu" HeaderStyle-Width="60px" HeaderText="栏目" SortExpression="LanMu">
                    <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="name" HeaderStyle-Width="90px" HeaderText="评论者" SortExpression="name">
                    <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="comment" HeaderStyle-Width="30%" HeaderText="评论内容" SortExpression="comment">
                    <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="datee" HeaderStyle-Width="180px" HeaderText="评论时间" SortExpression="datee">
                    <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:CommandField HeaderText="删除" HeaderStyle-Width="3%" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    </div>
    <p style="text-align:center">
        <asp:Button ID="Button1" runat="server" Text="删除选中评论" 
                OnClick="Button1_Click" BorderColor="#99CCFF" BorderStyle="Solid" />
            </p>
    </form>
</body>
</html>
