<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_UserAdmin" Codebehind="UserAdmin.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="Inc/Admin_Style.Css" rel="stylesheet" type="text/css">
    <title>无标题页</title>
<script language="javascript" src="Inc/selectDateTime.js"  type="text/javascript" charset="utf-8"></script>
</head>
<body style="margin-top:5px;">
    <form id="form1" runat="server">
    <div >
    <table width="95%" border="0" align="center" cellpadding="0" cellspacing="1" class="border"  align="center">
  <tr  class="title" >
    <td height="30" colspan="4" align="center"><strong>用户信息管理</strong></td>
  </tr>
  <tr class="tdbg">
    <td align="right" width="15%" >当前操作：   </td>
    <td width="35%" ><asp:Label ID="dangqian" runat="server"></asp:Label> </td>
    <td  width="15%" align="right">排&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;序：</td>
    <td width="35%">  <asp:TextBox ID="paixu_tb" runat="server" Width="80px"></asp:TextBox>
                    &nbsp;&nbsp; 数字越小越靠前</td>  </tr>
  
  <tr class="tdbg">
     <td align="right">解除锁定：</td>
    <td>
        <asp:CheckBox ID="Unlock" runat="server" />
                    </td>
                    <td align="right">在&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;职：</td>
    <td>
        <asp:CheckBox ID="zaizhi" runat="server" />
                    </td>
  </tr>
  <tr class="tdbg">
     <td align="right">身&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;份：</td>
    <td colspan="3">
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Value="2">文章管理员</asp:ListItem>
            <asp:ListItem Value="1">高级管理员</asp:ListItem>
            <asp:ListItem Value="0">超级管理员</asp:ListItem>
        </asp:RadioButtonList>
                    </td>
  </tr>  
  <tr class="tdbg"><td colspan="4">
  <table width="100%" border="0" align="center" cellpadding="0" cellspacing="1" bgcolor="White">
<tr class="title">
    <td height="15px" colspan="4" ><div align="center"><strong><span>个人可以更改的信息</span></strong></div></td>
  </tr>
  <tr class="tdbg">
    <td width="15%" align="right">登陆账号：</td>
    <td width="35%"><asp:TextBox ID="User_tb" runat="server" Width="120px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="User_tb"
                            ErrorMessage="必须填写"></asp:RequiredFieldValidator>    </td>
    <td width="15%" align="right"><span style="width: 99px; height: 36px">真实姓名：</span></td>
    <td width="35%"><asp:TextBox ID="namee_tb" runat="server" Width="120px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="namee_tb"
                            ErrorMessage="必须填写"></asp:RequiredFieldValidator></td>    
  </tr>
  <tr class="tdbg">
    <td align="right">联系电话：</td>
    <td><asp:TextBox ID="tel_tb" runat="server" Width="120px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tel_tb"
                            ErrorMessage="只能数字" ValidationExpression="^\d+$"></asp:RegularExpressionValidator></td>
    <td align="right">E-mail：</td>
    <td><asp:TextBox ID="Email_tb" runat="server" Width="120px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="Email_tb"
                            ErrorMessage="格式错误" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td>
  </tr>
  <tr class="tdbg">
    <td align="right">QQ：</td>
    <td><asp:TextBox ID="QQ_tb" runat="server" Width="120px"></asp:TextBox></td>
    <td align="right">出生年月：</td>
    <td><asp:TextBox ID="shengri_tb" runat="server" Width="120px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" 
                        runat="server" ControlToValidate="shengri_tb" ErrorMessage="请填写生日"></asp:RequiredFieldValidator></td>
  </tr>
  <tr class="tdbg">
    <td align="right">年级：</td>
    <td align="left"><asp:DropDownList ID="DropDownList1" runat="server">
                          <asp:ListItem>2005</asp:ListItem>
                          <asp:ListItem>2006</asp:ListItem>
                          <asp:ListItem>2007</asp:ListItem>
                          <asp:ListItem Selected="True">2008</asp:ListItem>
                          <asp:ListItem>2009</asp:ListItem>
                          <asp:ListItem>2010</asp:ListItem>
                          <asp:ListItem>2011</asp:ListItem>
                          <asp:ListItem>2012</asp:ListItem>
                          <asp:ListItem>2013</asp:ListItem>
                          <asp:ListItem>2014</asp:ListItem>
                          <asp:ListItem>2015</asp:ListItem>
                      </asp:DropDownList></td>
    <td align="right">学号：</td>
    <td><asp:TextBox ID="xuehao_tb" runat="server" Width="120px"></asp:TextBox></td>
  </tr>
  <tr class="tdbg">
    <td align="right">专业班级：</td>
    <td><asp:TextBox ID="zybj_tb" runat="server" Width="120px"></asp:TextBox></td>
    <td align="right">籍贯：</td>
    <td><asp:TextBox ID="jiguan_tb" runat="server" 
                        Width="120px"></asp:TextBox></td>
  </tr>
  <%--<tr class="tdbg">
    <td align="right">进入时间：</td>
    <td><asp:TextBox ID="TextBox1" runat="server" Width="120px"></asp:TextBox></td>
    <td align="right">离开时间：</td>
    <td><asp:TextBox ID="TextBox2" runat="server" 
                        Width="120px"></asp:TextBox></td>
  </tr>--%>
  <tr class="tdbg">
    <td  align="right">进入时间：</td>
    <td>
        <asp:TextBox ID="jinru_tb" runat="server" Width="120px"></asp:TextBox>
                    &nbsp;&nbsp; </td>
     <td align="right">离开时间：</td>
    <td>
        <asp:TextBox ID="likai_tb" runat="server" Width="120px"></asp:TextBox>
                    &nbsp;&nbsp; </td>
  </tr>  
  <tr class="tdbg">
    <td align="right">职务：</td>
    <td colspan="3"> 
        <asp:RadioButtonList ID="RadioButtonList_zhiwu" runat="server" 
            BorderStyle="None" CellPadding="1"
                        CellSpacing="1" RepeatColumns="10" RepeatDirection="Horizontal" 
            Width="95%">
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
    <td colspan="3">
        <asp:CheckBoxList ID="CheckBoxList1" 
                          runat="server" RepeatColumns="9" RepeatDirection="Horizontal" 
                          DataSourceID="ObjectDataSource1" DataTextField="Power" 
            DataValueField="Id" >
                      </asp:CheckBoxList>
                      <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                          SelectMethod="GetPowerClassList" TypeName="Lgwin.BLL.PowerClassBLL">
                          <SelectParameters>
                              <asp:Parameter DefaultValue="文章中心管理" Name="Class" Type="String" />
                          </SelectParameters>
                      </asp:ObjectDataSource></td>
  </tr>
  <tr class="tdbg">
    <td align="right"></td>
    <td colspan="3">
        <asp:CheckBoxList ID="CheckBoxList2" 
                          runat="server" RepeatColumns="8" RepeatDirection="Horizontal" 
                          DataSourceID="ObjectDataSource2" DataTextField="Power" 
            DataValueField="Id" >
                      </asp:CheckBoxList>
                      <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" 
                          SelectMethod="GetPowerClassList" TypeName="Lgwin.BLL.PowerClassBLL">
                          <SelectParameters>
                              <asp:Parameter DefaultValue="多媒体管理" Name="Class" Type="String" />
                          </SelectParameters>
                      </asp:ObjectDataSource></td>
  </tr>
  <tr class="tdbg">
    <td align="right">&nbsp;</td>
    <td colspan="3">
        <asp:CheckBoxList ID="CheckBoxList3" 
                          runat="server" RepeatColumns="8" RepeatDirection="Horizontal" 
                          DataSourceID="ObjectDataSource3" DataTextField="Power" 
            DataValueField="Id" >
                      </asp:CheckBoxList>
                      <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" 
                          SelectMethod="GetPowerClassList" TypeName="Lgwin.BLL.PowerClassBLL">
                          <SelectParameters>
                              <asp:Parameter DefaultValue="专题管理" Name="Class" Type="String" />
                          </SelectParameters>
                      </asp:ObjectDataSource></td>
  </tr>
  <tr class="tdbg">
    <td align="right">&nbsp;</td>
    <td colspan="3">
        <asp:CheckBoxList ID="CheckBoxList4" 
                          runat="server" RepeatColumns="8" RepeatDirection="Horizontal" 
                          DataSourceID="ObjectDataSource4" DataTextField="Power" 
            DataValueField="Id" >
                      </asp:CheckBoxList>
                      <asp:ObjectDataSource ID="ObjectDataSource4" runat="server" 
                          SelectMethod="GetPowerClassList" TypeName="Lgwin.BLL.PowerClassBLL">
                          <SelectParameters>
                              <asp:Parameter DefaultValue="用户管理" Name="Class" Type="String" />
                          </SelectParameters>
                      </asp:ObjectDataSource></td>
  </tr>
  <tr class="tdbg">
    <td align="right">&nbsp;</td>
    <td colspan="3">
        <asp:CheckBoxList ID="CheckBoxList5" 
                          runat="server" RepeatColumns="8" RepeatDirection="Horizontal" 
                          DataSourceID="ObjectDataSource5" DataTextField="Power" 
            DataValueField="Id" >
                      </asp:CheckBoxList>
                      <asp:ObjectDataSource ID="ObjectDataSource5" runat="server" 
                          SelectMethod="GetPowerClassList" TypeName="Lgwin.BLL.PowerClassBLL">
                          <SelectParameters>
                              <asp:Parameter DefaultValue="频道管理" Name="Class" Type="String" />
                          </SelectParameters>
                      </asp:ObjectDataSource></td>
  </tr>
  <tr class="tdbg">
    <td align="right">&nbsp;</td>
    <td colspan="3">
        <asp:CheckBoxList ID="CheckBoxList6" 
                          runat="server" RepeatColumns="8" RepeatDirection="Horizontal" 
                          DataSourceID="ObjectDataSource6" DataTextField="Power" 
            DataValueField="Id" >
                      </asp:CheckBoxList>
                      <asp:ObjectDataSource ID="ObjectDataSource6" runat="server" 
                          SelectMethod="GetPowerClassList" TypeName="Lgwin.BLL.PowerClassBLL">
                          <SelectParameters>
                              <asp:Parameter DefaultValue="系统设置" Name="Class" Type="String" />
                          </SelectParameters>
                      </asp:ObjectDataSource></td>
  </tr>
 
  <tr class="tdbg">
    <td align="right">自我介绍：</td>
    <td colspan="3" align="left">
        <asp:TextBox ID="jieshao_tb" 
                          runat="server" Height="135px" TextMode="MultiLine" 
            Width="90%"></asp:TextBox></td>
  </tr>  
</table>
  </td></tr>
  <tr  class="title" >
    <td height="30" colspan="4" align="center"><asp:Button ID="Button1" runat="server" 
            Text="提交" onclick="Button1_Click"  />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="取消" />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button_Del" runat="server" onclick="Button_Del_Click" 
            Text="删除该用户" />
      </td>
  </tr>
</table>
            
    </div>
    </form>
</body>
</html>
