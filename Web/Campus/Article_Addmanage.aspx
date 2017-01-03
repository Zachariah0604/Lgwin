<%@ Page Language="C#" AutoEventWireup="true"  ResponseEncoding="gb2312" EnableEventValidation="false" Inherits="Article_Addmanage" Codebehind="Article_Addmanage.aspx.cs" %>
<%@ Register TagPrefix="CE" Namespace="CuteEditor" Assembly="CuteEditor" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<link href="Inc/Style.Css" rel="stylesheet" type="text/css" />
<head runat="server">
    <title>校园文化</title>
    <style type="text/css">
        .style1 {
            height: 20px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    <table width="842" border="1" bordercolor="#ffffff" cellspacing="0" cellpadding="0">
  <tr>
    <td><strong>文章标题：</strong></td>
    <td align="left">主标题：<asp:TextBox ID="Title" runat="server" Width="400px"></asp:TextBox>
        <br />
        副标题：<asp:TextBox ID="SubTitle" runat="server" Width="400px"></asp:TextBox>
      </td>
  </tr>
  <tr>
    <td class="style1"><strong>文章栏目：</strong></td>
    <td align="left">
        <asp:DropDownList ID="DropDownList_lanmu" runat="server" Height="20px" 
            style="text-align: justify" Width="100px" DataSourceID="SqlDataSource1" 
            DataTextField="LanMu" DataValueField="LanMu" >
        </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConStr %>" 
            SelectCommand="SELECT [LanMu] FROM [lanmu]"></asp:SqlDataSource>
      </td>
  </tr>
  <tr>
    <td><strong>发布时间：</strong></td>
    <td align="left">
        <asp:TextBox ID="Date" runat="server" Width="100px"></asp:TextBox>
      </td>
  </tr>
  <tr>
    <td><strong>文章属性：</strong></td>
    <td align="left">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="index" runat="server" Text="新闻网显示" Font-Bold="True" />
        &nbsp;&nbsp;&nbsp;<asp:CheckBox ID="recommend" runat="server" Text="二级页推荐文章" 
            Font-Bold="True" />
      </td>
  </tr>
  
  <tr>
    <td Height="600px"><strong>文章内容：</strong></td>
    <td style="background-color: #00FFFF">
    <div align="left">
        <CE:Editor ID="Editor1" runat="server" Height="600px" Width="100%" 
            SecurityPolicyFile="Admin.config" ThemeType="Office2007" 
            FilesPath="CuteSoft_Client/CuteEditor/" 
            EditorWysiwygModeCss="Inc/example.css">
        </CE:Editor>
     </div>
    </td>
  </tr>
  <tr>
    <td class="style1"></td>
    <td class="style1"><strong>作者：</strong><asp:TextBox ID="Author" runat="server" Width="120px"></asp:TextBox>
        <strong>编辑：</strong><asp:TextBox ID="Editor" runat="server" Width="80px"></asp:TextBox>
        文章来源：<asp:TextBox ID="From" runat="server" Width="160px"></asp:TextBox>
        <strong>电话：</strong><asp:TextBox ID="Phone" runat="server" Width="120px"></asp:TextBox>
      </td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td>
        <asp:CheckBox ID="Audited" runat="server" Text="需要审核" Font-Bold="True" />
        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
        <asp:Button ID="Button_submit" runat="server" Text="提交" 
            onclick="Button_submit_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button_cancel" runat="server" Text="取消" 
            onclick="Button_cancel_Click" />
      </td>
  </tr>
</table>  
    </div>
    </form>
</body>
</html>
