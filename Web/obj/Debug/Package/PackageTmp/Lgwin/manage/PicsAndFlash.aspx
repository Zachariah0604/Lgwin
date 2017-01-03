<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_PicsAndFlash" Codebehind="PicsAndFlash.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="Inc/Admin_Style.Css" rel="stylesheet" type="text/css">
    <title>首页图片管理页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    <table width="95%"border="0" align="center" cellpadding="0" cellspacing="1" class="border" style="text-align:center" align="center">
   <tr class="title"><td>上传图片或Flash广告</td></tr>
  <tr >
    <td> 
    <table width="100%" border="0" cellspacing="1" cellpadding="0" style="text-align:left;">
  <tr class="tdbg">
    <td width="20%">&nbsp;</td>
    <td width="15%">图片或Flash上传：</td>
    <td><asp:FileUpload ID="FileUpload1" runat="server" Width="250px" /></td>
    <td width="30%">
        <asp:Label ID="Labele" runat="server"></asp:Label></td>
  </tr>
  <tr class="tdbg">
    <td>&nbsp;</td>
    <td>选择图片用途：</td>
    <td>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Value="0" Selected="True">位置一、二</asp:ListItem>
            <asp:ListItem Value="1">校报</asp:ListItem>
            <asp:ListItem Value="2">专题</asp:ListItem>
        </asp:RadioButtonList>
                                </td>
    <td>&nbsp;</td>
  </tr>
  <tr  class="tdbg">
    <td>&nbsp;</td>
    <td>链接(http://……):</td>
    <td>
        <asp:TextBox ID="TextBox_herf" runat="server" Width="250px"></asp:TextBox></td>
    <td>
        &nbsp;</td>
  </tr>
   <tr  class="tdbg">
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="上传" /></td>
    <td>&nbsp;</td>
  </tr>
</table></td>
  </tr>
  <tr  class="tdbg" style="padding-top:10px; padding-bottom:5px">
    <td>
        <asp:Button ID="Button2" runat="server" Text="选择位置一" 
            onclick="Button2_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button3" 
            runat="server" Text="选择位置二" 
            onclick="Button3_Click" />
      &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button_Xiaobao" runat="server" 
            Text="校报图片管理" onclick="Button_Xiaobao_Click" />
        &nbsp;&nbsp;&nbsp;<asp:Button ID="Button_Zhuanti" runat="server" 
            Text="专题图片管理" onclick="Button_Zhuanti_Click" />
&nbsp;<asp:Button ID="Button_Del" runat="server" Text="删除文件" 
            onclick="Button_Del_Click" />
      </td>
  </tr>
  <tr  class="tdbg" style="padding-top:10px">
    <td>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" 
            RepeatColumns="4" RepeatDirection="Horizontal">
        </asp:CheckBoxList>
        <asp:Label ID="Label_shijian" runat="server" Text="显示时间设置(单位为秒)"></asp:Label>
            <asp:TextBox ID="TextBox_Time" runat="server" Width="20px"></asp:TextBox>
        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View1" runat="server">
            <asp:Button ID="Button_xuanding1" runat="server" Text="选定" 
            onclick="Button_xuanding1_Click" />
            </asp:View>
            <asp:View ID="View2" runat="server">
            <asp:Button ID="Button_xuanding2" runat="server" Text="选定" 
            onclick="Button_xuanding2_Click" />
            </asp:View>
            <asp:View ID="View3" runat="server">
            <table  width="60%" border="0" cellspacing="0" cellpadding="0">
  <tr  class="tdbg">
    <td align="right"> 请选择所属板块：</td>
    <td align="left"><asp:RadioButtonList ID="RadioButtonList2" runat="server" 
                    RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True" Value="0">头版</asp:ListItem>
                    <asp:ListItem Value="1">综合</asp:ListItem>
                    <asp:ListItem Value="2">校园</asp:ListItem>
                    <asp:ListItem Value="3">副刊</asp:ListItem>
                </asp:RadioButtonList></td>
  </tr>
</table> <asp:Button ID="Button_xb" runat="server" Text="选择" onclick="Button_xb_Click" />
            </asp:View>
            <asp:View ID="View4" runat="server">
            
                <asp:Button ID="Button_zht" runat="server" Text="选择" 
                    onclick="Button_zht_Click" />
            
            </asp:View>
            <asp:View ID="View5" runat="server">
            <asp:Button ID="Button_xddDel" runat="server" Text="选定删除" 
            onclick="Button_xddDel_Click" />
            </asp:View>
            <asp:View ID="View6" runat="server">
                请先填写校报期数：<asp:TextBox ID="TextBox_Qishu" runat="server" Width="50px"></asp:TextBox>（只填写数字，如888）<br />
                <asp:Button ID="Button4" runat="server" onclick="Button4_Click" Text="确定" />
            </asp:View>
        </asp:MultiView>
        &nbsp;
        
        
      </td>
  </tr>     
  <tr  class="tdbg">
    <td>
        <asp:Label ID="Label_flash" runat="server"></asp:Label>
   </td>
  </tr>
</table>
    </div>
    </form>
</body>
</html>
