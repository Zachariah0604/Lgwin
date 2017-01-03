<%@ Page Language="C#" AutoEventWireup="true" Inherits="shuyu_list" Codebehind="shuyu_list.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>时尚广角——书余——列表</title>
</head>
<body>
    <form id="form1" runat="server">
        时尚广角——书余——列表
         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            OnRowDeleting="GridView1_RowDeleting"  OnPageIndexChanging= "GridView1_PageIndexChanging "  AllowPaging="true"  PageSize="20">   
  
            <Columns>
               
                <asp:BoundField DataField="title" HeaderText="书名" SortExpression="title" />
                <asp:BoundField DataField="author" HeaderText="作者" 
                    SortExpression="author" />
                <asp:BoundField DataField="editor" HeaderText="编辑" 
                    SortExpression="editor" />
                <asp:BoundField DataField="datee" HeaderText="时间" SortExpression="datee" />
                 <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="shuyu_edit.aspx?id={0}" 
                HeaderText="编辑" Text="编辑" />    
                <asp:TemplateField ShowHeader="False">   
            <ItemTemplate>   
                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"   
                    Text="删除" OnClientClick='<%#  "if (!confirm(\"你确定要删除吗?\")) return false;"%>'></asp:LinkButton>   
            </ItemTemplate>   
        </asp:TemplateField>   
            </Columns>
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
        
    </form>
</body>
</html>
