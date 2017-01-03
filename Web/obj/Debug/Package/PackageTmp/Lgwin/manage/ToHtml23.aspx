<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_ToHtml23" Codebehind="ToHtml23.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
<link href="Inc/Admin_Style.Css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <br />
        <br />
        <table width="95%" border="0" align="center" cellpadding="0" cellspacing="1" class="border">
          <tr class="title">
            <th colspan="2" scope="col">二三级页面生成&gt;&gt;&gt;</th>
          </tr>
          <tr  class="tdbg">
            <td width="6%">栏目：</td>
            <td width="94%">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                    RepeatDirection="Horizontal" RepeatColumns="8" 
                    DataSourceID="ObjectDataSource1" DataTextField="Title" 
                    DataValueField="Tid"> </asp:RadioButtonList>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                    SelectMethod="GetClassList" TypeName="Lgwin.BLL.ClassBLL">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="false" Name="ShowAll" Type="Boolean" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                    </td>
          </tr>
          <tr class="tdbg">
            <td>操作：</td>
            <td><asp:Button ID="Button_list" runat="server" OnClick="Button_list_Click" Text="生成二级页面" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button_sanji" runat="server" onclick="Button_sanji_Click" 
                    Text="生成三级页面" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
          </tr>
          <tr class="tdbg" >
            <td>提示：</td>
            <td  valign="top">&nbsp;<asp:TextBox ID="TextBox1" runat="server" Height="310px" TextMode="MultiLine" Width="655px"></asp:TextBox></td>
          </tr>
        </table>
    </div>
    </form>
</body>
</html>
