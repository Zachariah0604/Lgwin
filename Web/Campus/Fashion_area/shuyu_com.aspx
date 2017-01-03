<%@ Page Language="C#" AutoEventWireup="true" Inherits="shuyu_com" Codebehind="shuyu_com.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>时尚广角——书余——评论审核</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        时尚广角——书余——评论审核</div>
    <p>
        书名：<asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        评论者： 
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        评论时间：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        评论：</p>
    <p>
        <asp:TextBox ID="TextBox3" runat="server" Height="106px" 
             Width="501px"></asp:TextBox>
   </p>
    <asp:Button ID="Button3" runat="server" Text="确认发表" onclick="Button3_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button4" runat="server" style="margin-left: 0px" Text="删除" 
        Width="78px" onclick="Button4_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Button 
        ID="Button5" runat="server" Text="返回列表" onclick="Button5_Click" 
         Width="78px" />
    </form>
    <div>
    
    </div>
    </form>
</body>
</html>
