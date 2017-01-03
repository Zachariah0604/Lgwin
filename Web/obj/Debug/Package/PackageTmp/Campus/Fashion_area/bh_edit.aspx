<%@ Page Language="C#" AutoEventWireup="true" Inherits="bh_editor" Codebehind="bh_edit.aspx.cs" %>
<%@ Register TagPrefix="CE" Namespace="CuteEditor" Assembly="CuteEditor" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>时尚广角——好书榜——编辑</title>
</head>
<body>
 <form id="form1" runat="server">
    <div>
    
        时尚广角——好书榜——编辑<br />
    </div>
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="书名："></asp:Label>
    
    <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
  
&nbsp;<p>
        <asp:Label ID="Label2" runat="server" Text="作者："></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"  ></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="封面图片："></asp:Label>
        <asp:FileUpload ID="FileUpload1" runat="server" />&nbsp;&nbsp;&nbsp
        注：如果图片不对，选择正确图片，待各操作完成后点击“确认发表”。</p><br />
    <p>
        <asp:Image ID="Image1" runat="server" Height="110px" ImageUrl="" Width="80px" />
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="简介："></asp:Label>
    </p>
       <p style="width: 700px">
        
             <CE:Editor ID="Editor1" runat="server" Height="400px" Width="95%" 
            SecurityPolicyFile="Admin.config" ThemeType="Office2007" 
            FilesPath="../../CuteSoft_Client/CuteEditor/">
        </CE:Editor>
    </p>
    <p style="width: 590px">
        &nbsp;</p>
    <p style="width: 590px">
        <asp:Label ID="Label5" runat="server" Text="编辑："></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" Width="128px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  <asp:Label ID="Label6" runat="server" Text="日期："></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server" Width="128px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p><p style="width: 590px">
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="确定发表" 
        Width="60px" />&nbsp;&nbsp;&nbsp;&nbsp
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" style="margin-left: 0px" 
            Text="删除" Width="60px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;<asp:Button  ID="Button3" runat="server" Text="返回" onclick="Button3_Click"  Width="60px" 
        />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
   
    </p>

       

</form>
</body>
</html>
