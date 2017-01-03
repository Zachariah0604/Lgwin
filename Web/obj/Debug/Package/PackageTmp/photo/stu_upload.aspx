<%@ Page Language="C#" AutoEventWireup="true" Inherits="photo_upload1" Codebehind="stu_upload.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <script type="text/JavaScript">
<!--
         function MM_goToURL() { //v3.0
             var i, args = MM_goToURL.arguments; document.MM_returnValue = false;
             for (i = 0; i < (args.length - 1); i += 2) eval(args[i] + ".location='" + args[i + 1] + "'");
         }
//-->
    </script>
    <style type="text/css">
     body{ text-align:center; margin-top:4px;  margin:auto; }
    
    
    a:link {text-decoration: none;color:#000000;}
 a:visited {text-decoration: none;color: #000000;}
  a:hover {text-decoration:underline;color:Gray;}
   a:active {text-decoration: none;}
    
        .style1
        {
            height: 57px;
        }
        .style2
        {
            height: 39px;
        }
    
    
    
    
     
    
    
    
        .style3
        {
            height: 16px;
        }
    
    
    
    
     
    
    
    
    </style>
</head>
<body  >
    <form id="form1" runat="server">
    <div id="box"  style=" margin:auto;   text-align:center;  width:1000px; height:auto;">
    <table align="center" cellpadding="0" cellspacing="0" border="0"  style=" border:none;">
       <tr><td   style="  background-color:#5b5b5b; width:1000px; height:5px;" ></td></tr>
       <tr><td  style="   width:1000px; height:30px;" >
           <table style=" font-size:12px; height:10px;width:180px; margin-left:800px;"><tr>
               <td class="style3" ><a href="index.html">光影理工</a></td><td class="style3">|</td>
           <td class="style3"><a href="../index.html">新闻网</a></td><td class="style3">|</td> 
               <td class="style3" ><a href="../Campus/Index.html">校园文化</a></td><td class="style3">|</td></tr></table></td></tr>
       <tr><td   style="  background-color:#5b5b5b; width:1000px; height:30px;" ></td></tr>
       <tr><td   style=" background-repeat:no-repeat; text-align:center;  background-image:url(images/upload_head2.gif);width:1000px; height:202px;">
            <table width="297" style=" padding-bottom:0px; text-align:left; margin:auto; margin-top:40px ">
                <tr><td width="108" height="30">图片名称：</td><td width="237">
                 <asp:TextBox ID="TextBox_name" runat="server" BorderColor="#666666" BorderWidth="1px"></asp:TextBox></td></tr> 
                  <tr><td height="32">摄影作者：</td><td><asp:TextBox ID="TextBox1" runat="server" BorderColor="#666666" BorderWidth="1px"></asp:TextBox></td></tr>
                 <tr><td height="28">分类：</td><td><asp:DropDownList ID="DropDownList1" runat="server"   DataSourceID="SqlDataSource2"
                  DataTextField="name" DataValueField="ID"> </asp:DropDownList></td></tr>
                  <tr><td height="27">说明：</td><td>&nbsp;</td></tr>
              </table>
         </td></tr>
                 
        <tr><td style=" margin:auto; text-align:center;width:1000px; height:300px; " >
          <table style=" margin:auto; margin-top:0;">
          <tr><td><asp:TextBox ID="TextBox2" runat="server" Height="140px" TextMode="MultiLine" Width="382px"></asp:TextBox></td></tr>
          <tr> <td class="style2">&nbsp;<asp:FileUpload ID="FileUpload1" runat="server" />
           <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="FileUpload1"
            ErrorMessage="必填"></asp:RequiredFieldValidator>宽度：<asp:TextBox 
            ID="TextBox_w" runat="server" Width="39px">800</asp:TextBox>
                    </td></tr>
           <tr><td class="style1"><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="上传" />
           <input name="Submit" type="button" onclick="MM_goToURL('self','index.html');return document.MM_returnValue" value="返回" /></td></tr>
          </table>
  
     </td></tr><tr><td><table style="font-size:14px; text-align:center" width="500" height="20" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td width="111">Copyright@2010</td>
    <td width="142"><a  href="http://www.lgwindow.stud.edu.cn">lgwindow.stud.edu.cn</a></td>
    <td style="font-size:12px;" width="56">版权所有</td>
    <td width="86">Designed by</td>
    <td width="23"><a  href="../karat"><img style=" border:none;"  src="images/logo.jpg" width="18" height="20" /></a></td>
    <td width="93"><a  href="../karat">karat Studio</a></td>
    
  </tr>
</table></td></tr>
    </table>
    </div>
        
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConStr %>" 
            SelectCommand="SELECT * FROM [Photo_zhtfenlei] ORDER BY [paixu]">
            <SelectParameters>
                <asp:Parameter DefaultValue="31" Name="id1" Type="Int32" />
                <asp:Parameter DefaultValue="32" Name="id" Type="Int32" />
                <asp:Parameter DefaultValue="30" Name="id2" Type="Int32" />
                <asp:Parameter DefaultValue="29" Name="id3" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>

    </form>
</body>
</html>
