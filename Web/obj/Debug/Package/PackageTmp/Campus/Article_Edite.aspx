<%@ Page Language="C#" AutoEventWireup="true" ResponseEncoding="gb2312" EnableEventValidation="false"  Inherits="Article_Edite" Codebehind="Article_Edite.aspx.cs" %>
<%@ Register TagPrefix="CE" Namespace="CuteEditor" Assembly="CuteEditor" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<link href="Inc/Style.Css" rel="stylesheet" type="text/css" />
<head id="Head1" runat="server">
    <title>校园文化</title>
    <script language="javascript" src="../Lgwin/manage/Inc/selectDateTime.js"  type="text/javascript" charset="utf-8"></script>
    <style type="text/css">
        .style1 {
            height: 22px;
            font-weight:bold;
        }
        .style2
        {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    <table width="850" border="1" cellspacing="0" cellpadding="0">
  <tr>
    <td class=style1>文章标题：</td>
    <td align=left class=style1>主标题：<asp:TextBox ID="Title" runat="server" Width="400px"></asp:TextBox>
        <br />
        副标题：<asp:TextBox ID="SubTitle" runat="server" Width="400px" 
            AutoPostBack="True"></asp:TextBox>
      </td>
  </tr>
  <tr>
    <td class="style1">文章栏目：</td>
    <td align="left">
        <asp:DropDownList ID="DropDownList_lanmu" runat="server" Height="22px" 
            style="text-align: justify" Width="120px" DataSourceID="SqlDataSource1" 
            DataTextField="LanMu" DataValueField="LanMu" >
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConStr %>" 
            SelectCommand="SELECT [LanMu] FROM [lanmu]"></asp:SqlDataSource>
      </td>
  </tr>
  <tr>
    <td class=style1>发布时间：</td>
    <td align=left>
        <asp:TextBox ID="Date" runat="server" Width="100px"></asp:TextBox>
      </td>
  </tr>
  <tr>
    <td class=style1>文章属性：</td>
    <td align=left style="font-weight: bold">
        &nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="index" runat="server" Text="新闻网显示" />
        &nbsp;<asp:CheckBox ID="recommend" runat="server" Text="二级页推荐文章" />
      </td>
  </tr>
  <tr>
    <td class=style1>转向链接：</td>
    <td align=left class=style1>
        <%--<asp:RegularExpressionValidator 
            ID="RegularExpressionValidator1" runat="server" 
            ErrorMessage="请输入正确的网址" ControlToValidate="URL" Display="Dynamic" ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w-./?%&=]*)?">
            </asp:RegularExpressionValidator>--%>
        &nbsp;
        <asp:Label ID="URL" runat="server" Text="Label"></asp:Label>
      </td>
  </tr>
  <tr>
    <td Height="600px" class=style1>文章内容：</td>
    <td style="background-color: #00FFFF">
    <div align=left>
    <CE:Editor ID="Editor1" runat="server" Height="600" Width="100%" 
            SecurityPolicyFile="Admin.config" ThemeType="Office2007" 
            FilesPath="CuteSoft_Client/CuteEditor/" 
            EditorWysiwygModeCss="Inc/example.css" style="margin-bottom: 0px">
        </CE:Editor>
     </div>
    </td>
  </tr>
  <tr>
    <td class="style2"></td>
    <td class="style2" style="font-weight: bold">作者：</strong><asp:TextBox ID="Author" Width="100px" runat="server"></asp:TextBox>
        &nbsp;
        编辑：<asp:TextBox ID="Editor" Width="80px" runat="server"></asp:TextBox>
        &nbsp;&nbsp;文章来源：</strong><asp:TextBox ID="From" runat="server" style="margin-bottom: 0px"></asp:TextBox>
        &nbsp;&nbsp;
        电话：<asp:TextBox ID="Phone" Width="100px" runat="server"></asp:TextBox>
      </td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td class=style1>
        <asp:CheckBox ID="Audited" runat="server" Text="需要审核" />
        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
        <asp:Button ID="Button_update" runat="server" Text="更新" 
            onclick="Button_update_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button_cancel" runat="server" Text="取消" 
            onclick="Button_cancel_Click" />
      </td>
  </tr>
</table>
    
    </div>
    </form>
</body>
</html>
