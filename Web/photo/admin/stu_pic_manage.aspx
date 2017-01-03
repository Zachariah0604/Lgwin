<%@ Page Language="C#" AutoEventWireup="true" Inherits="admin_up_pic_edit" Codebehind="stu_pic_manage.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>无标题页</title>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<link rel="stylesheet" type="text/css" href="clearbox.css" />
<script type="text/javascript" src="clearbox.js"></script>
<style type="text/css">
body
{ text-align:center;
  }
  #gridview{ }
  #button{ text-align:center;}
  
</style>

</head>
<body>
    <form id="form1" runat="server">
    <div id="gridview">
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" 
                    ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="name" HeaderText="名称" />
                
                
                <asp:TemplateField>
                <ItemTemplate>
                
               <div style="margin:10px auto; ">
<a href="photo/<%# Eval("zhtID") %>/<%# Eval("path") %>" rel="clearbox[test1]"><img src="photo/<%# Eval("zhtID") %>/<%# Eval("path") %>"width="150" height="100" /></a>
                </div>
                
                </ItemTemplate></asp:TemplateField>
              <asp:BoundField DataField="zhtname" HeaderText="所属专题" 
                    SortExpression="zhtname" />
               
                <asp:BoundField DataField="shuoming" HeaderText="说明" 
                    SortExpression="shuoming" />
                <asp:BoundField DataField="zuozhe" HeaderText="作者" 
                    SortExpression="zuozhe" />

                    <asp:HyperLinkField  DataNavigateUrlFields="id" Text="编辑" DataNavigateUrlFormatString="stu_pic_edit.aspx?id={0}" />
                    <asp:HyperLinkField  DataNavigateUrlFields="id" Text="删除" DataNavigateUrlFormatString="del.aspx?id={0}" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
              ConnectionString="<%$ ConnectionStrings:ConStr %>" 
            SelectCommand="SELECT * FROM [Photo_photo] WHERE ([xshshch] =@xshshch) ORDER BY [ID] desc">
            <SelectParameters>
                <asp:Parameter DefaultValue="true" Name="xshshch" Type="Boolean" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    <div id="button" >

    <asp:Button ID="Button1" runat="server" Text="返回" onclick="Button1_Click" />
    </div>
    </form>
</body>
</html>
