<%@ Page Language="C#" AutoEventWireup="true" Inherits="karat1_admin_Default" Codebehind="Message_Add.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>山东理工大学卡瑞特工作室留言板</title>
    <script type="text/javascript"> 
           function change() {
            var imgNode = document.getElementById("vimg");
            imgNode.src = "WaterMark.ashx?t=" + (new Date()).valueOf();  // 这里加个时间的参数是为了防止浏览器缓存的问题   
        }   
    </script>  
</head>
<body>
    <form id="form1" runat="server" action="" method="post" name="Message">
    <div>
     <table   style="font-family:'微软雅黑', '幼圆', '黑体', '宋体'; font-size:16px; color:#236dbf" width="710" border="0" cellspacing="5" cellpadding="0">
    <tr>
      <td width="60">昵称：</td>
      <td> 
        
    <asp:TextBox  ID="TextBox1" runat="server" BorderStyle="None" BackColor="Transparent"  style="border-bottom:1px solid #236dbf;width:300px"></asp:TextBox> 
          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"  ControlToValidate="TextBox1"
              ErrorMessage="必须填写昵称哦！"></asp:RequiredFieldValidator>
      </td>
    </tr>
    <tr>
      <td>主题：</td>
      <td> 
     
           <asp:TextBox ID="TextBox2"  BorderStyle="None" BackColor="Transparent"  style="border-bottom:1px solid #236dbf;width:300px" runat="server"></asp:TextBox>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
               ErrorMessage="必须填写主题哦！" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
 </td>
    </tr>
    <tr>
      <td>邮箱：</td>
      <td> 
      
      <asp:TextBox
            ID="TextBox3" runat="server"  BorderStyle="None" BackColor="Transparent"  style="border-bottom:1px solid #236dbf;width:300px"  ></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox3"
                            ErrorMessage="格式错误" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
 </td>
    </tr>
    <tr>
      <td>内容：</td>
      <td> 
     <asp:TextBox
            ID="TextBox4" runat="server" Height="100px" TextMode="MultiLine" Width="99%" onkeydown="(this.form.gb_word,this.form.total,this.form.used,this.form.remain);" onkeyup="(this.form.gb_word,this.form.total,this.form.used,this.form.remain);"></asp:TextBox><asp:RequiredFieldValidator
                ID="RequiredFieldValidator3" runat="server" ErrorMessage="总得写点什么吧！" ControlToValidate="TextBox4"></asp:RequiredFieldValidator>
  </td>
    </tr>
    <tr>
      <td>&nbsp;</td>
      <td align="right"> 
          验证码：<img src="WaterMark.ashx" id="vimg" alt=""  onclick="change()" align="absmiddle"/>
          <asp:TextBox ID="TextBox5" runat="server"  Width="45px"></asp:TextBox><asp:RequiredFieldValidator
              ID="RequiredFieldValidator4" runat="server" ErrorMessage="请输入验证码" Text="*" 
              ControlToValidate="TextBox5" ForeColor="Red"></asp:RequiredFieldValidator>
          <asp:Button
            ID="Button1" runat="server" Text="提交" 
              style=" width:45px; height:30px" onclick="Button1_Click"  />
          <asp:Button ID="Button2" runat="server" Text="重置" 
              style="margin-left:2px; width:45px; height:30px" onclick="Button2_Click" CausesValidation="false"/>
              
          
          </td>
    </tr>
  </table>
    </div>
    <div class="team_r" style="width:705px; height:45px; overflow:scroll; overflow-x:hidden; ">  
<table width="705" border="0">
    <tr>
    <td width="40" height="40"><img src="images/bpic_27.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[-_-||] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
    <td width="40" height="40"><img src="images/bpic_28.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[:.] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
    <td width="40" height="40"><img src="images/bpic_29.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[:-Q] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
    <td width="40" height="40"><img src="images/bpic_30.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[9_9] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
    <td width="40" height="40"><img src="images/bpic_31.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[:,.]';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
    <td width="40" height="40"><img src="images/bpic_32.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[:?] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
    <td width="40" height="40"><img src="images/bpic_33.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[:-|] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
    <td width="40" height="40"><img src="images/bpic_34.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[:K] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>

     <td width="40" height="40"><img src="images/bpic_35.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[:G] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
    <td width="40" height="40"><img src="images/bpic_36.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[:L] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
  </tr>
    <tr>
    <td width="40" height="40"><img src="images/bpic_17.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[:#] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
    <td width="40" height="40"><img src="images/bpic_18.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[:Z] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
    <td width="40" height="40"><img src="images/bpic_19.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[:0=] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
    <td width="40" height="40"><img src="images/bpic_20.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[/:P] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
    <td width="40" height="40"><img src="images/bpic_21.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[:$]';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
    <td width="40" height="40"><img src="images/bpic_22.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[-.-] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
    <td width="40" height="40"><img src="images/bpic_23.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[/-_-] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
    <td width="40" height="40"><img src="images/bpic_24.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[:{] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>


        <td width="40" height="40"><img src="images/bpic_25.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[zz] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
    <td width="40" height="40"><img src="images/bpic_26.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[|-_-|] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
  </tr>
  <tr>
    <td width="40" height="40"><img src="images/bpic_1.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[-_-] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
    <td width="40" height="40"><img src="images/bpic_2.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[@o@] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
    <td width="40" height="40"><img src="images/bpic_3.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[-|-] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
    <td width="40" height="40"><img src="images/bpic_4.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[o_o] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
    <td width="40" height="40"><img src="images/bpic_5.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[ToT] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
    <td width="40" height="40"><img src="images/bpic_6.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[*_*] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
    <td width="40" height="40"><img src="images/bpic_7.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[-x-] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
    <td width="40" height="40"><img src="images/bpic_8.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[-_-zz] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
  </tr>
  <tr>
    <td width="40" height="40"><img src="images/bpic_9.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[t_t] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
    <td width="40" height="40"><img src="images/bpic_10.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[-_-!] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
    <td width="40" height="40"><img src="images/bpic_11.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[:,] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
    <td width="40" height="40"><img src="images/bpic_12.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[:P] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
    <td width="40" height="40"><img src="images/bpic_13.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[:D] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
    <td width="40" height="40"><img src="images/bpic_14.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[:)] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
    <td width="40" height="40"><img src="images/bpic_15.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[:(] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
    <td width="40" height="40"><img src="images/bpic_16.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[:O] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
  </tr>
  
  
  <tr>
    <td width="40" height="40"><img src="images/bpic_37.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[:c] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
    <td width="40" height="40"><img src="images/bpic_38.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[:q] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
    <td width="40" height="40"><img src="images/bpic_39.png" width="40" height="40" onclick="document.getElementById('TextBox4').value+='[:Y] ';document.getElementById('TextBox4').focus()" style="cursor:hand"></td>
  </tr>
</table> 
</div>  
    </form>
</body>
</html>
