<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KaratUpload.aspx.cs" Inherits="Lgwin.Karat.admin.KaratUpload" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>上传图片</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp;<asp:Label ID="lable1" runat="server" Text="图片名称：" Width="90px"></asp:Label>
        &nbsp;
        <asp:TextBox ID="tbxPicName" runat="server" CausesValidation="True"></asp:TextBox>&nbsp;
        <asp:RequiredFieldValidator ID="rfvNameNotNull" runat="server" ErrorMessage="*名称不能为空" Width="130px" ControlToValidate="tbxPicName"></asp:RequiredFieldValidator><br />
        <br />
        &nbsp;<asp:Label ID="lable2" runat="server" Text="图片路径：" Width="90px"></asp:Label>
        &nbsp; &nbsp;&nbsp;<asp:FileUpload ID="tbxPicPath" runat="server" Width="433px" />
        &nbsp; &nbsp;<br />
        &nbsp;<br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        <asp:Button ID="btnUploadPic" runat="server" OnClick="btnUploadPic_Click" Text="上传图片"
            Width="100px" Enabled="False" />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" Text="返回" Width="100px" CausesValidation="False" />
    
    </div>
    </form>
</body>
</html>