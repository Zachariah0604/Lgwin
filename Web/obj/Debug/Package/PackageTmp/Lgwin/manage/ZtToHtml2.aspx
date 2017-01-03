<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_ZtToHtml23" Codebehind="ZtToHtml2.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
    <link href="Inc/Admin_Style.Css" rel="stylesheet" type="text/css" />
</head>
<body class="newStyle1">
    <form id="form1" runat="server">
    <div>
    <br />
        <br />
        <br />
        <table width="100%" cellspacing="1" cellpadding="0" bordercolor="#FFFFFF" bgcolor="#DEF0FA"  class="border">
          <tr class="title">
            <th colspan="2" scope="col">二三级页面生成&gt;&gt;&gt;</th>
          </tr>
          <tr class="tdbg" >
            <td width="14">&nbsp;</td>
            <td width="761">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                    RepeatDirection="Horizontal" RepeatColumns="8" 
                    DataSourceID="ObjectDataSource1" DataTextField="ZtCaptionName" 
                    DataValueField="Id"> </asp:RadioButtonList>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                    SelectMethod="GetZtCaptionList" TypeName="Lgwin.BLL.ZtCaptionBLL">
                    <SelectParameters>
                        <asp:SessionParameter DefaultValue="0" Name="id" SessionField="ZtId" 
                            Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                    </td>
          </tr>
          <tr class="tdbg">
            <td>&nbsp;</td>
            <td><asp:Button ID="Button_list" runat="server" OnClick="Button_list_Click" Text="生成二级页面" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button_sanji" runat="server" onclick="Button_sanji_Click" 
                    Text="生成三级页面" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button_All3" runat="server" onclick="Button_All3_Click" 
                    Text="生成所有三级页面" />
                    </td>
          </tr>
          <tr class="tdbg">
            <td>&nbsp;</td>
            <td  valign="top">提示：
                  <asp:TextBox ID="TextBox1" runat="server" Height="310px" TextMode="MultiLine" Width="655px"></asp:TextBox></td>
          </tr>
        </table>
    </div>
    </form>
</body>
</html>
