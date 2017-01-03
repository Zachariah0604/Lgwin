<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_PicUp" Codebehind="PicUp.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
<link href="Inc/Admin_Style.Css" rel="stylesheet" type="text/css">
</head>
<body style="margin-top:10px;">
    <form id="form1" runat="server">
    <div align="center">  
    <table width="90%" border="0" align="center" cellpadding="0">
  <tr class="title">
    <th colspan="2">&nbsp;图片上传&gt;&gt;&gt;</th>
  </tr>
  <tr bgcolor="#DEF0FA">
    <td><table width="100%" style="height: 290px;" border="0" align="center" cellpadding="0" cellspacing="1" bgcolor="White">
  <tr class="tdbg">
    <td colspan="2">
        <asp:FileUpload ID="FileUpload1" onpropertychange="document.all.imgID.src='file:///'+this.value" runat="server" Width="200px" />
      </td>
  </tr>
  <tr class="tdbg">
    <td>打水印：</td>
    <td align="left"><asp:CheckBox ID="CheckBox1" runat="server" /></td>
  </tr>
  <tr class="tdbg">
    <td>水印位置：</td>
    <td align="left">
              <asp:RadioButtonList ID="RadioButtonList_weizhi" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>左</asp:ListItem>
                <asp:ListItem>中</asp:ListItem>
                <asp:ListItem Selected="True">右</asp:ListItem>
              </asp:RadioButtonList>
         </td>
  </tr>
  <tr class="tdbg">
    <td>图片质量：</td>
    <td align="left">              <asp:RadioButtonList ID="RadioButtonList2" runat="server" 
                    RepeatDirection="Horizontal">
                <asp:ListItem Value="100" Selected="True">高</asp:ListItem>
                <asp:ListItem Value="90">中</asp:ListItem>
                <asp:ListItem  Value="80">低</asp:ListItem>
              </asp:RadioButtonList>
          </td>
  </tr>
  <tr class="tdbg"><td>图片宽度：</td><td align="left"><asp:TextBox ID="kuan" runat="server" Width="40px"></asp:TextBox>
                                px</td></tr>
  <tr class="tdbg"><td>水印图片：</td><td align="left">
              <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatColumns="6" CellPadding="0" 
                                    CellSpacing="0">
                  
                <asp:ListItem Selected="True">1</asp:ListItem>
                  <asp:ListItem>2</asp:ListItem>
                  
                  <asp:ListItem>3</asp:ListItem>
                  
                  <asp:ListItem>4</asp:ListItem>
                  
                  <asp:ListItem>5</asp:ListItem>
                  
                  <asp:ListItem>6</asp:ListItem>
              </asp:RadioButtonList>
                                </td></tr>
  <tr class="tdbg"><td>所属专题：</td><td align="left">
                                <asp:DropDownList ID="zt" runat="server" TabIndex="-1">
                                </asp:DropDownList>
                                </td></tr>
  
  <tr class="tdbg"><td></td><td>
      <asp:Button ID="Button_up" runat="server" Text="上传" onclick="Button_up_Click" />
      </td></tr>
</table></td>
    <td><table width="100%"border="0" align="center" cellpadding="0" cellspacing="1" bgcolor="White">
 <tr class="tdbg">
<td colspan="2"><asp:Image ID="imgID" runat="server" Height="150px" Width="200px" />&nbsp;</td>
</tr>
<tr class="tdbg">
<td>1.<asp:Image ID="Image1" runat="server" Height="40px" Width="100px" /> </td>
<td>2.<asp:Image ID="Image2" runat="server" Height="40px" Width="100px" /> </td>
</tr>
<tr class="tdbg">
<td>3.<asp:Image ID="Image3" runat="server" Height="40px" Width="100px" /> </td>
<td>4.<asp:Image ID="Image4" runat="server" Height="40px" Width="100px" /></td>
</tr>
<tr class="tdbg">
<td>5.<asp:Image ID="Image5" runat="server" Height="40px" Width="100px" /> </td>
<td>6.<asp:Image ID="Image6" runat="server" Height="40px" Width="100px" /></td>
</tr>
</table></td>
  </tr>
</table>
    </div></form>
</body>
</html>
