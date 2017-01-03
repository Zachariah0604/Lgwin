<%@ Page Language="C#" AutoEventWireup="true" Inherits="movie_add" Codebehind="movie_add.aspx.cs" %>
<%@ Register TagPrefix="CE" Namespace="CuteEditor" Assembly="CuteEditor" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1"  runat="server">
    <title>时尚广角——电影--添加</title>
<script language="javascript" type="text/javascript">
</script>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        时尚广角——电影<br />
    </div>
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="电影名："></asp:Label>
    
    <asp:TextBox ID="title" runat="server" ></asp:TextBox>
    
    &nbsp;
    <p>
        <asp:Label ID="Label2" runat="server" Text="导演："></asp:Label>
        <asp:TextBox ID="author" runat="server"  ></asp:TextBox>
    </p>
     <p>
        <asp:Label ID="Label7" runat="server" Text="电影图片："></asp:Label>
        <asp:FileUpload ID="FileUpload1" runat="server" />
    &nbsp; </p>
    
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
        <asp:TextBox ID="editor" runat="server" Width="128px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label6" runat="server" Text="来源："></asp:Label>
        <asp:TextBox ID="source" runat="server" Width="128px"></asp:TextBox></p>
    <p style="width: 590px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        
<p style="width: 590px">
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="添加" 
        Width="60px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button  ID="Button2" runat="server" Text="清空" onclick="Button2_Click" Width="53px" 
        />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
   
    </p>
        
</form>
        
</body>
</html>
