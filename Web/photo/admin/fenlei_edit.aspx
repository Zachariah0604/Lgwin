<%@ Page Language="C#" AutoEventWireup="true" Inherits="xlxy_admin_fenlei_edit" Codebehind="fenlei_edit.aspx.cs" %>
<%@ Register TagPrefix="CE" Namespace="CuteEditor" Assembly="CuteEditor" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<style type="text/css">
body{ text-align:center;}
</style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div><table>
    
    <tr><td>  原名称：</td><td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td><td>创建时间：</td><td>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td></tr>
    <tr><td colspan="4"> <CE:Editor ID="Editor1" runat="server" Height="400px" Width="48%" 
            SecurityPolicyFile="Admin.config" ThemeType="Office2007" 
            FilesPath="CuteSoft_Client/CuteEditor/">
        </CE:Editor></td></tr>
    <tr><td  colspan="4">      
        
   
          <a href="fenlei_man.aspx" >返回</a>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="修改" />
        </td></tr>
    
    
    
    
    </table>
      
        
   
        
      
        
        </div>
    </form>
</body>
</html>
