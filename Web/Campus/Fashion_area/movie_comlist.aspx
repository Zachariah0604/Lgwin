<%@ Page Language="C#" AutoEventWireup="true" Inherits="movie_comlist" Codebehind="movie_comlist.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    时尚广角——电影——评论列表 
    <div>
 
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            OnRowDeleting="GridView1_RowDeleting" AllowPaging="true"   PageSize="20">   
    <Columns>    
        
        <asp:BoundField DataField="title" HeaderText="评论文章" /> 
        <asp:BoundField DataField="correct" HeaderText="是否已审核发表" />   
        <asp:BoundField DataField="datee" HeaderText="日期" /> 
        <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="movie_com.aspx?id={0}" 
                HeaderText="编辑" Text="编辑" />    
        <asp:TemplateField ShowHeader="False">   
            <ItemTemplate>   
                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"   
                    Text="删除" OnClientClick='<%#  "if (!confirm(\"你确定要删除吗?\")) return false;"%>'></asp:LinkButton>   
            </ItemTemplate>   
        </asp:TemplateField>   
    </Columns>   
 </asp:GridView>   

    
  
        
        </div>
     
    
    </form>
</body>
</html>
