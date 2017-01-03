<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_UserLogin" Codebehind="UserLogin.aspx.cs" %>
<html>
<head id="Head1" runat="server">
    <title>山东理工大学新闻网管理中心</title>
 <link href="Inc/Admin_Style.Css" rel="stylesheet" type="text/css">
</head>
<body>
<table width='100%' height='100%' border='0' cellpadding='0' cellspacing='0'><tr><td>
    <form id="form1" runat="server">
    <div>
    <table width='100%' border='0' cellpadding='0' cellspacing='0'>
    <tr>
      <td width='219' height='164' background='Images/Admin_Login1_0_02.gif'></td>
      <td width='64' height='164' background='Images/Admin_Login1_0_04.gif'></td>
      <td valign='top' background='Images/Admin_Login1_0_09.gif'><table border='0' cellpadding='0' cellspacing='0'>
        <tr>
          <td><table width='100%' border='0' cellpadding='0' cellspacing='0'>
            <tr>
              <td width='270' height='79' background='Images/Admin_Login1_0_05.jpg'></td>
              <td width='150' height='79' background='Images/Admin_Login1_0_06.gif'></td>
              <td valign='top'><table width='100%' border='0' cellpadding='0' cellspacing='0'>
                <tr>
                  <td height='21'></td>
                  <td></td>
                </tr>
                <tr>
                  <td>
                      <asp:ImageButton ID="ImageButton1" runat="server" Height="50px" ImageUrl="Images/Admin_Login1_0_10.gif"
                          Width="50px" OnClick="ImageButton1_Click" /></td>
                  <td width='58' height='50' style="background-image:Images/Admin_Login1_0_11.gif" ></td>
                </tr>
              </table></td>
            </tr>
           </table></td>
        </tr>
        <tr>
          <td height='85'>		  
		  <table border='0' cellspacing='0' cellpadding='0'height="35px" >
            <tr>
              <td width='22' rowspan='2' valign='bottom' ><img src='Images/Admin_Login1_0_15.gif' alt='' /></td>
              <td style="width: 80px"><font color='#ffffff'>用户名称：</font></td>
              <td rowspan='2'  style="width: 22px" valign='bottom'><img src='Images/Admin_Login1_0_19.gif' alt='' /></td>
              <td style="width: 80px"><font color='#ffffff'>用户密码：</font></td>
              </tr>
            <tr>
              <td style="height: 18px; width: 80px;">    
        <asp:TextBox ID="User" runat="server" BorderColor="White" BorderWidth="0px" Height="16px"
                      MaxLength="20" Width="70px" ></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                      ErrorMessage="*" ControlToValidate="User"></asp:RequiredFieldValidator></td>
              <td style="height: 18px; width: 80px;">
              <asp:TextBox ID="Password" runat="server" BorderColor="White" BorderWidth="0px" Height="16px"
                      MaxLength="20" Width="70px" TextMode="Password"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                      ErrorMessage="*" ControlToValidate="Password"></asp:RequiredFieldValidator></td>
              </tr>
          </table>
              <asp:Label ID="Err" runat="server" ForeColor="White" Width="202px" Height="20px"></asp:Label></td>
        </tr>
      </table></td>
   </tr>
  </table>        
    </div>
    </form></td></tr></table>
</body>
</html>
