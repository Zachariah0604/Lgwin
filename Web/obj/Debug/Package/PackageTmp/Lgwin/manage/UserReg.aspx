<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_RegUser" Codebehind="UserReg.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="Inc/Admin_Style.Css" rel="stylesheet" type="text/css" />
<script language="javascript" src="Inc/selectDateTime.js"  type="text/javascript" charset="utf-8"></script>
    <title>用户注册</title>
</head>
<body style="margin-top:10px">
    <form id="form1" runat="server">
    <div>     
  <table width="95%" border="0" align="center" cellpadding="0" cellspacing="1" class="border">
<tr class="title">
    <td height="30" colspan="5" ><div align="center" style="color:White; font-size:20px; font-weight:bold;">用户注册</div></td>
  </tr>
  <tr class="tdbg">
    <td width="12%" align="right">登陆账号：</td>
    <td><asp:TextBox ID="User" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="User"
                            ErrorMessage="必填"></asp:RequiredFieldValidator>    </td>
    <td width="12%" align="right"><span style="width: 99px; height: 36px">真实姓名：</span></td>
    <td><asp:TextBox ID="namee" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="namee"
                            ErrorMessage="必须填写"></asp:RequiredFieldValidator></td>
    <td rowspan="8" width="20%"><asp:Image ID="imgID" runat="server" Height="176px" Width="153px" /><br />更改照片：<input id="UploadFile"  runat="server" name="fileUp" onpropertychange="document.all.imgID.src='file:///'+this.value" type="file" style="width: 335px; height: 23px" /></td>
  </tr>
  <tr class="tdbg">
    <td align="right">登陆密码：</td>
    <td><asp:TextBox ID="TextBox_password" runat="server" Width="149px" 
            TextMode="Password"></asp:TextBox>
                    </td>
    <td align="right">密码确认：</td>
    <td><asp:TextBox ID="TextBox_pwd2" runat="server" Width="155px" TextMode="Password"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ControlToCompare="TextBox_password" ControlToValidate="TextBox_pwd2" 
            ErrorMessage="两次密码输入不一致"></asp:CompareValidator>
                    </td>
  </tr>
  <tr class="tdbg">
    <td align="right">联系电话：</td>
    <td><asp:TextBox ID="tel" runat="server" Width="149px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tel"
                            ErrorMessage="只能数字" ValidationExpression="^\d+$"></asp:RegularExpressionValidator></td>
    <td align="right">E-mail：</td>
    <td><asp:TextBox ID="Email" runat="server" Width="155px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="Email"
                            ErrorMessage="格式错误" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td>
  </tr>
  <tr class="tdbg">
    <td align="right">QQ：</td>
    <td><asp:TextBox ID="QQ" runat="server" Width="120px"></asp:TextBox></td>
    <td align="right">出生年月：</td>
    <td><asp:TextBox ID="shengri" runat="server" Width="120px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" 
                        runat="server" ControlToValidate="shengri" ErrorMessage="请填写生日"></asp:RequiredFieldValidator></td>
  </tr>
  <tr class="tdbg">
    <td align="right">年级：</td>
    <td align="left"><asp:DropDownList ID="DropDownList1" runat="server">
                          <asp:ListItem>2005</asp:ListItem>
                          <asp:ListItem>2006</asp:ListItem>
                          <asp:ListItem>2007</asp:ListItem>
                          <asp:ListItem>2008</asp:ListItem>
                          <asp:ListItem>2009</asp:ListItem>
                          <asp:ListItem>2010</asp:ListItem>
                          <asp:ListItem>2011</asp:ListItem>
                          <asp:ListItem>2012</asp:ListItem>
                          <asp:ListItem Selected="True">2013</asp:ListItem>
                          <asp:ListItem>2014</asp:ListItem>
                          <asp:ListItem>2015</asp:ListItem>
                      </asp:DropDownList></td>
    <td align="right">学号：</td>
    <td><asp:TextBox ID="xuehao" runat="server" Width="120px"></asp:TextBox></td>
  </tr>
  <tr class="tdbg">
    <td align="right">专业班级：</td>
    <td><asp:TextBox ID="zybj" runat="server" Width="120px"></asp:TextBox></td>
    <td align="right">籍贯：</td>
    <td><asp:TextBox ID="jiguan" runat="server" 
                        Width="120px"></asp:TextBox></td>
  </tr>
  <tr class="tdbg">
    <td align="right">进入时间：</td>
    <td><asp:TextBox ID="jinru" runat="server" Width="120px"></asp:TextBox></td>
    <td align="right">离开时间：</td>
    <td><asp:TextBox ID="likai" runat="server" 
                        Width="120px"></asp:TextBox></td>
  </tr>
  <tr class="tdbg">
    
    <td colspan="4" align="right"></td>
    
  </tr>
  <tr class="tdbg">
    <td align="right">职务：</td>
    <td colspan="4"> <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
            BorderStyle="None" CellPadding="1"
                        CellSpacing="1" RepeatColumns="9" RepeatDirection="Horizontal" 
            Width="90%">
                        <asp:ListItem Value="212">老师</asp:ListItem>
                        <asp:ListItem Value="312">站长</asp:ListItem>
                        <asp:ListItem Value="412">采编部长</asp:ListItem>
                        <asp:ListItem Value="512">综合部长</asp:ListItem>
                        <asp:ListItem Value="612">技术部长</asp:ListItem>
                        <asp:ListItem Value="422">采编</asp:ListItem>
                        <asp:ListItem Value="522">综合</asp:ListItem>
                        <asp:ListItem Value="622">程序员</asp:ListItem>
                        <asp:ListItem Value="624">美工</asp:ListItem>
                    </asp:RadioButtonList>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                          ControlToValidate="RadioButtonList1" ErrorMessage="请选择"></asp:RequiredFieldValidator></td>
  </tr>
  <tr class="tdbg">
    <td align="right">我的栏目：</td>
    <td colspan="4">
        <asp:CheckBoxList ID="CheckBoxList1" 
                          runat="server" RepeatColumns="9" RepeatDirection="Horizontal" 
                          DataSourceID="ObjectDataSource1" DataTextField="Title" 
            DataValueField="Power" >
                      </asp:CheckBoxList>
                      <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                          SelectMethod="GetClassList" TypeName="Lgwin.BLL.ClassBLL">
                          <SelectParameters>
                              <asp:Parameter DefaultValue="true" Name="ShowAll" Type="Boolean" />
                          </SelectParameters>
                      </asp:ObjectDataSource></td>
  </tr>
  <tr class="tdbg">
    <td align="right">自我介绍：</td>
    <td colspan="4" align="left">
        <asp:TextBox ID="jieshao" 
                          runat="server" Height="135px" TextMode="MultiLine" 
            Width="90%"></asp:TextBox></td>
  </tr>
  <tr class="title"><td></td><td colspan="2"><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="提交" /></td>
  <td><asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="取消" /></td> 
 <td></td>
 </tr>
</table>  
</div>
    </form>
</body>
</html>
