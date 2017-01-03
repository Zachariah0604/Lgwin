<%@ Page Language="C#" AutoEventWireup="true" Inherits="tsxw" Codebehind="gyzt.aspx.cs" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<link href="css/defualt2.css" rel="Stylesheet" type="text/css"   />
    <title>光影专题-光影理工-山东理工大学新闻网 理工视窗</title>
</head>
<body>
    <form id="form1" runat="server">
   <div id="box">
   <div id="head" ><iframe src="top.html" allowtransparency="true" style="background-color=transparent" 
 frameborder="0"   scrolling="no" width="990px"; height="160px"></iframe>
</div>
<div id="center">
<div id="left">
<div id="headline"><a href="index.html">光影理工</a>>>光影专题</div>

<div id="pic">

    <asp:DataList ID="DataList1" runat="server" RepeatColumns="4" CellPadding="8" 
        RepeatDirection="Horizontal">
    <ItemTemplate>
    <table  class="Cen_ta">
    <tr> <td class="Cen1"><a href ="<%# Eval("pagename") %>"  ><img class="img7" alt="<%# Eval("lmname") %>" src="admin/photo/<%# Eval("zhtID") %>/<%# Eval("path") %>" /></a></td> </tr>
    <tr><td class="Cen2"> <a href ="<%# Eval("pagename") %>"  >  <asp:Label ID="Label1" runat="server" Text=""><%# Eval("lmname") %></asp:Label></a></td></tr>  
               </table></ItemTemplate>
    </asp:DataList><div id="page">
<asp:Label ID="Label2" runat="server" Text="当前页码为"></asp:Label>
<asp:Label ID="labpage" runat="server" Text="1"></asp:Label>
<asp:Label ID="Label4" runat="server" Text="总页码为："></asp:Label>
<asp:Label ID="Label6"  runat="server" Text=""></asp:Label>
  
   <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">第一页</asp:LinkButton>
<asp:LinkButton ID="LinkButtonUp" runat="server" onclick="LinkButtonUp_Click">上一页</asp:LinkButton>
<asp:LinkButton ID="LinkButtonNexT" runat="server" onclick="LinkButtonNext_Click">下一页</asp:LinkButton>
<asp:LinkButton ID="LinkButtonLast" runat="server" onclick="LinkButtonLast_Click">最后一页</asp:LinkButton>
</div>
</div>
</div>
<div id="right">
<iframe src="right.aspx" allowtransparency="true" style="background-color=transparent"  frameborder="0"   scrolling="no" width="300px"; height="550px"></iframe>
</div>

</div>
</div><!--center层-->
<div id="bottom">


  <div id="bottom_line"></div>

<div id="link">
<table style="text-align:center; font-size:12px" width="990" height="44" border="0" cellpadding="0" cellspacing="11">
  <tr>
    <td width="100">光影理工</td>
    <td width="35">&nbsp;</td>
    <td width="90"><a href="http://210.44.191.210/">photo center</a></td>
    <td width="345" ></td>
    <td width="40"><a href="http://lgwindow.sdut.edu.cn/" target="_blank">新闻网</a></td>
    <td width="50"><A href="http://lgwindow.sdut.edu.cn/campus/" target="_blank" rel="external">校园文化</A></td>
    <td width="50"><A href="http://youth.sdut.edu.cn/" target="_blank" rel="external">青春在线</A> </td>
    <td width="50"><A href="http://www.lgqn.cn/" target="_blank" rel="external">理工青年</A> </td>
    <td width="40"><A href="http://wdo.sdut.edu.cn/" target="_blank" rel="external">网兜网</A></td>
    <td width="60" align="left" ><A href="http://syxh.sdut.edu.cn/" target="_blank" rel="external">摄影协会</A></td>
  </tr>
</table></div>
<div id="intro">
  <table style="font-size:14px; text-align:center" width="990" height="20" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td>Copyright 2010</td>
    <td><a  href="http://www.lgwindow.stud.edu.cn">lgwindow.stud.edu.cn</a></td>
    <td>版权所有</td>
    <td>Powered by</td>
    <td><a  href="http://lgwindow.sdut.edu.cn/karat"><img src="images/logo.jpg" width="18" height="20" /></a></td>
    <td>karat Studio</td>
    <td width="300">&nbsp;</td>
    <td><a  href="http://lgwindow.sdut.edu.cn/karat">Contact</a></td>
    <td><a  href="http://lgwindow.sdut.edu.cn/karat">| About</a></td>
    <td><a  href="http://lgwindow.sdut.edu.cn/karat">| Join us</a></td>
  </tr>
</table>
  </div>
</div>



    </form>
</body>
</html>
