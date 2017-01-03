<%@ Page Language="C#" AutoEventWireup="true"
    Inherits="karat1_admin_KaratBaoMing" Codebehind="Karatbaoming.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
    <title></title>
    <link href="css/baoming.css" rel="stylesheet" type="text/css" />
    <style type="text/css">

        .style1
        {
            width: 190px;
        }
        .style2
        {
            width: 110px;
        }
        .style3
        {
            width: 98px;
        }
        .style4
        {
            width: 90px;
        }
        .style5
        {
            width: 241px;
        }
        .style6
        {
            width: 74px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="wai" class="margin_center">
        <table border="1" class="table1" cellpadding="1" cellspacing="0">
            <tr align="center"><td colspan="4"><b><font size="5" color="#808080">卡瑞特报名表</font></b></td></tr>
            <tr class="lines1">
                <td class="style4">
                    <strong><font size="2" color="#808080">姓名</font><font color="red" >*</font></strong>
                </td>
                <td class="style5">
                    <asp:TextBox ID="TextBox1" class="textbox" runat="server"></asp:TextBox>
                    <font size="2"><asp:RequiredFieldValidator ID="name" runat="server" 
                        ErrorMessage="请填写姓名" ControlToValidate="TextBox1"></asp:RequiredFieldValidator></font>
                </td>
                <td class="style6">
                    <strong><font size="2" color="#808080">性别</font></strong>
                </td>
                <td class="style1">
                    <asp:DropDownList ID="DropDownList1" runat="server" class="textbox2" Width="80">
                        <asp:ListItem>男</asp:ListItem>
                        <asp:ListItem>女</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr class="lines1">
                <td class="style4">
                   <strong><font size="2" color="#808080"> 院系</font><font color="red" >*</font></strong>
                </td>
                <td class="style5">
                    <asp:TextBox ID="TextBox2" runat="server" class="textbox"></asp:TextBox>
                     <font size="2"><asp:RequiredFieldValidator ID="yuanxi" runat="server" 
                        ErrorMessage="请填写院系" ControlToValidate="TextBox2"></asp:RequiredFieldValidator></font>
                </td>
                <td class="style6">
                    <strong><font size="2" color="#808080">专业班级</font></strong>
                </td>
                <td class="style1">
                    <asp:TextBox ID="TextBox4" runat="server" class="textbox"></asp:TextBox>
                </td>
            </tr>
            <tr class="lines1">
                <td class="style4">
                    <strong><font size="2" color="#808080">校区、宿舍</font><font color="red" >*</font></strong>
                </td>
                <td class="style5">
                    <asp:TextBox ID="TextBox3" runat="server" class="textbox"></asp:TextBox>
                     <font size="2"><asp:RequiredFieldValidator ID="xiaoqu" runat="server" 
                        ErrorMessage="请填写校区" ControlToValidate="TextBox3"></asp:RequiredFieldValidator></font>
                </td>
                <td class="style6">
                    <strong><font size="2" color="#808080">有无电脑</font></strong>
                </td>
                <td class="style1">
                    <asp:DropDownList ID="DropDownList2" runat="server" Width="80" class="textbox2">
                        <asp:ListItem>有</asp:ListItem>
                        <asp:ListItem>无</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr class="lines1">
                <td class="style4">
                    <strong><font size="2" color="#808080">邮箱</font><font color="red" >*</font></strong>
                </td>
                <td class="style5">
                     
                    <asp:TextBox ID="TextBox5" runat="server" class="textbox"></asp:TextBox>
                     <font size="2"><asp:RequiredFieldValidator ID="email" runat="server" 
                        ErrorMessage="请填写邮箱" ControlToValidate="TextBox5" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RequiredFieldValidator></font>
                </td>
                <td class="style6">
                    <strong><font size="2" color="#808080">籍贯</font></strong>
                </td>
                <td class="style1">
                   
                    <asp:TextBox ID="TextBox6" runat="server" class="textbox"></asp:TextBox>
                </td>
            </tr>
            <tr class="lines1">
                <td class="style4">
                    <strong><font size="2" color="#808080">应聘职位</font><font color="red" >*</font></strong>
                </td>
                <td class="style3" colspan="3">

                  <asp:DropDownList ID="DropDownList3" runat="server" Width="200" class="textbox2">
                        <asp:ListItem>编辑记者</asp:ListItem>
                        <asp:ListItem>美术编辑</asp:ListItem>
                        <asp:ListItem>程序员</asp:ListItem>
                        <asp:ListItem>综合办公室人员</asp:ListItem>
                    </asp:DropDownList>
                     
                </td>
            </tr>
            <tr class="lines1">
                <td class="style4">
                    <strong><font size="2" color="#808080">个人网站或博客地址</font></strong>
                </td>
                <td class="style2" colspan="3">
                    
                    <asp:TextBox ID="TextBox7" runat="server" class="textbox" Width="400"></asp:TextBox>
                </td>
            </tr>
            <tr class="lines1">
                <td class="style4">
                    <strong><font size="2" color="#808080">作品展示</font></strong>
                </td>
                <td class="style2" colspan="3">
                     
                    <asp:TextBox ID="TextBox8" runat="server" class="textbox" Width="400"></asp:TextBox>
                    <br />
                    <font size="2" color="#808080">在线作品请在这里注明详细地址，其他作品请写明名称和属性</font></td>
            </tr>
            <tr class="lines1">
                <td class="style4">
                    <strong><font size="2" color="#808080">联系电话</font><font color="red" >*</font></strong>
                </td>
                <td class="style2" colspan="3">
                     
                    <asp:TextBox ID="TextBox9" runat="server" Width="160" class="textbox"></asp:TextBox>
                    <font size="2"> <asp:RequiredFieldValidator ID="tel" runat="server" 
                        ErrorMessage="请填写电话" ControlToValidate="TextBox9"></asp:RequiredFieldValidator></font>
                </td>
            </tr>
            <tr class="lines1">
                <td class="style4">
                    <strong><font size="2" color="#808080">上传头像</font><font color="red" >*</font></strong></td>
                <td class="style2" colspan="3">
                  
                    <asp:FileUpload ID="FileUpload1" runat="server" Width="216px" 
                        class="textbox2" />
                <font size="2"> <asp:RequiredFieldValidator ID="touxiang" runat="server" 
                        ErrorMessage="请上传头像" ControlToValidate="FileUpload1"></asp:RequiredFieldValidator></font>
                </td>
            </tr>
                        <tr class="lines1">
                <td class="style4">
                    <strong><font size="2" color="#808080">个人简介</font><font color="red" >*</font><br />
                    </strong><font size="2" color="#808080">(如性格爱好、个人特长、工作经历等)</font></td>
                <td class="style2" colspan="3">
                 
                    <asp:TextBox ID="TextBox10" runat="server"  Height="100px" Width="400" TextMode="MultiLine" class="textbox2" ></asp:TextBox>
                    <font size="2"><asp:RequiredFieldValidator ID="jianjie" runat="server" 
                        ErrorMessage="请填写个人信息" ControlToValidate="TextBox10"></asp:RequiredFieldValidator></font>
                </td>
            </tr>
            <tr class="lines1">
    
                <td  class="td1"  colspan="4">
                    &nbsp;
                    <asp:Button ID="Button1" runat="server" Text="提交" Width="70" Height="25" onclick="Button1_Click1" 
                         CausesValidation="true" />
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="重置" Width="70" Height="25" 
                        onclick="Button2_Click" CausesValidation="false"/>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
