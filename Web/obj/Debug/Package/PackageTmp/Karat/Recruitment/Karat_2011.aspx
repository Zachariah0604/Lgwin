<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Karat_2011.aspx.cs" Inherits="Lgwin.Karat.Recruitment.Karat_2011" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>报名表</title>
<link rel=File-List href="baoming/filelist.xml">
<link rel=Edit-Time-Data href="baoming/editdata.mso">
</head>
<style>
body
{
	margin:0;
	padding:0px;
	border:0;
 
}
#box
{
    margin:0 auto;
	width:754px;

}
#box_nei
{
	margin:0 auto;
	width:754px;
}
#title
{
	text-align:center;
	margin-top:30px;
}
#tab
{
	margin-top:30px;
}
#bottom
{
	margin-top:5px;
	margin-bottom:80px;
}


<!--
 /* Font Definitions */
 @font-face
	{font-family:宋体;
	panose-1:2 1 6 0 3 1 1 1 1 1;
	mso-font-alt:SimSun;
	mso-font-charset:134;
	mso-generic-font-family:auto;
	mso-font-pitch:variable;
	mso-font-signature:3 680460288 22 0 262145 0;}
@font-face
	{font-family:宋体;
	panose-1:2 1 6 0 3 1 1 1 1 1;
	mso-font-alt:SimSun;
	mso-font-charset:134;
	mso-generic-font-family:auto;
	mso-font-pitch:variable;
	mso-font-signature:3 680460288 22 0 262145 0;}
@font-face
	{font-family:Calibri;
	panose-1:2 15 5 2 2 2 4 3 2 4;
	mso-font-charset:0;
	mso-generic-font-family:swiss;
	mso-font-pitch:variable;
	mso-font-signature:-1610611985 1073750139 0 0 159 0;}
@font-face
	{font-family:方正大标宋简体;
	panose-1:2 1 6 1 3 1 1 1 1 1;
	mso-font-charset:134;
	mso-generic-font-family:auto;
	mso-font-pitch:variable;
	mso-font-signature:1 135135232 16 0 262144 0;}
@font-face
	{font-family:"\@方正大标宋简体";
	panose-1:2 1 6 1 3 1 1 1 1 1;
	mso-font-charset:134;
	mso-generic-font-family:auto;
	mso-font-pitch:variable;
	mso-font-signature:1 135135232 16 0 262144 0;}
@font-face
	{font-family:"\@宋体";
	panose-1:2 1 6 0 3 1 1 1 1 1;
	mso-font-charset:134;
	mso-generic-font-family:auto;
	mso-font-pitch:variable;
	mso-font-signature:3 680460288 22 0 262145 0;}
 /* Style Definitions */
 p.MsoNormal, li.MsoNormal, div.MsoNormal
	{mso-style-unhide:no;
	mso-style-qformat:yes;
	mso-style-parent:"";
	margin:0cm;
	margin-bottom:.0001pt;
	text-align:justify;
	text-justify:inter-ideograph;
	mso-pagination:none;
	font-size:10.5pt;
	mso-bidi-font-size:11.0pt;
	font-family:"Calibri","sans-serif";
	mso-fareast-font-family:宋体;
	mso-bidi-font-family:"Times New Roman";
	mso-font-kerning:1.0pt;}
.MsoChpDefault
	{mso-style-type:export-only;
	mso-default-props:yes;
	mso-fareast-font-family:宋体;}
 /* Page Definitions */
 @page
	{mso-page-border-surround-header:no;
	mso-page-border-surround-footer:no;}
@page WordSection1
	{ 
	margin:0 auto;;
	mso-header-margin:42.55pt;
	mso-footer-margin:49.6pt;
	mso-paper-source:0;
	width:752px;
	layout-grid:15.6pt;}
div.WordSection1
	{page:WordSection1;}
.textbox2
{
    border-color:Gray;
    border-width:1px;
    border-style:solid;
}
    .style1
    {
        height: 22.4pt;
        width: 48pt;
    }
    .style2
    {
        height: 31.4pt;
        width: 48pt;
    }
    .style3
    {
        height: 24.8pt;
        width: 48pt;
    }
    .style4
    {
        height: 21.6pt;
        width: 48pt;
    }
 -->
</style>
<style type="javascript">
function CheckSelect() 
{ 
var tb = document.getElementById("CheckBoxList1"); 
for(var i=0;i<tb.rows.cells.length;i++) 
{ 
var chk = tb.rows.cells.firstChild; 
if(chk != event.srcElement) 
{ 
chk.checked = false; 
} 
} 
} 

</style>
<body>
    <form id="form1" runat="server">
    <div style="margin:auto; width:950px">
<iframe src="../top.html" align="center" allowtransparency="true" style=" margin-left:auto; margin-right:auto" 
 frameborder="0" scrolling="no" width="950px"; height="160px"></iframe>
 </div>
<div id="box">

  <div id="box_nei">
    <div id="title"><b style='mso-bidi-font-weight:normal'><span
style='font-size:26.0pt;font-family:方正大标宋简体'>山东理工大学新闻网纳新报名表<span lang=EN-US><o:p></o:p></span></span></b></div>
    <div id="tab">
    
    <table class=MsoNormalTable border=1 cellspacing=0 cellpadding=0
 style='border-collapse:collapse;border:none;mso-border-alt:solid black .5pt;
 mso-padding-alt:0cm 5.4pt 0cm 5.4pt;mso-border-insideh:.5pt solid black;
 mso-border-insidev:.5pt solid black'>
 <tr style='mso-yfti-irow:0;mso-yfti-firstrow:yes;height:22.4pt'>
  <td width=103 style='width:77.4pt;border:solid black 1.0pt;mso-border-alt:
  solid black .5pt;padding:0cm 5.4pt 0cm 5.4pt;height:22.4pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:12.0pt;mso-bidi-font-size:11.0pt;font-family:宋体;mso-ascii-font-family:
  Calibri;mso-hansi-font-family:Calibri'>姓　　名</span><span lang=EN-US
  style='font-size:12.0pt;mso-bidi-font-size:11.0pt'><o:p></o:p></span></p>
  </td>
  <td width=197 colspan=2 style='width:147.7pt;border-top:solid black 1.0pt;
  border-left:none;border-bottom:solid black 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-left-alt:solid black .5pt;mso-border-alt:solid black .5pt;
  mso-border-right-alt:solid windowtext .5pt;padding:0cm 5.4pt 0cm 5.4pt;
  height:22.4pt'>
      <asp:TextBox ID="TextBox1" runat="server" 
          Width="198px" MaxLength="12" ></asp:TextBox>*
      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
          ControlToValidate="TextBox1" ErrorMessage="*" ForeColor="Red" ></asp:RequiredFieldValidator>
     </td>
  <td width=98 style='width:73.2pt;border-top:solid black 1.0pt;border-left:
  none;border-bottom:solid black 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-left-alt:solid windowtext .5pt;mso-border-top-alt:black;
  mso-border-left-alt:windowtext;mso-border-bottom-alt:black;mso-border-right-alt:
  windowtext;mso-border-style-alt:solid;mso-border-width-alt:.5pt;padding:0cm 5.4pt 0cm 5.4pt;
  height:22.4pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:12.0pt;mso-bidi-font-size:11.0pt;font-family:宋体;mso-ascii-font-family:
  Calibri;mso-hansi-font-family:Calibri'>性　　别</span><span lang=EN-US
  style='font-size:12.0pt;mso-bidi-font-size:11.0pt'><o:p></o:p></span></p>
  </td>
  <td style='mso-border-left-alt:solid windowtext .5pt; border-right: 1.0pt solid black; border-top: 1.0pt solid black; border-bottom: 1.0pt solid black; mso-border-alt:solid black .5pt;
  mso-border-left-alt:solid windowtext .5pt; padding:0cm 5.4pt 0cm 5.4pt;
  border-left-style: none; border-left-color: inherit; border-left-width: medium;' 
         class="style1">
      <asp:DropDownList ID="DropDownList1" runat="server" BackColor="White" >
          <asp:ListItem>男</asp:ListItem>
          <asp:ListItem>女</asp:ListItem>
      </asp:DropDownList>
     </td>
  <td width=129  valign=top align=left rowspan=6 style='width:96.85pt;border:solid black 1.0pt;
  border-left:none;mso-border-left-alt:solid black .5pt;mso-border-alt:solid black .5pt;
  padding-left:0px; padding-top:0px;height:22.4pt'>
       <asp:Image ID="Image1" runat="server" Height="195px" Width="133px" />
     </td>
 </tr>
 <tr style='mso-yfti-irow:1;height:22.4pt'>
  <td width=103 style='width:77.4pt;border:solid black 1.0pt;border-top:none;
  mso-border-top-alt:solid black .5pt;mso-border-alt:solid black .5pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:22.4pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:12.0pt;mso-bidi-font-size:11.0pt;font-family:宋体;mso-ascii-font-family:
  Calibri;mso-hansi-font-family:Calibri'>学　　号</span><span lang=EN-US
  style='font-size:12.0pt;mso-bidi-font-size:11.0pt'><o:p></o:p></span></p>
  </td>
  <td width=197 colspan=2 style='width:147.7pt;border-top:none;border-left:
  none;border-bottom:solid black 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid black .5pt;mso-border-left-alt:solid black .5pt;
  mso-border-alt:solid black .5pt;mso-border-right-alt:solid windowtext .5pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:22.4pt'>
      <asp:TextBox ID="TextBox2" runat="server" Width="199px" MaxLength="11"></asp:TextBox>
      *<asp:RequiredFieldValidator
          ID="RequiredFieldValidator8" runat="server" ErrorMessage="*" 
          ControlToValidate="TextBox2" ForeColor="Red"></asp:RequiredFieldValidator>
     </td>
  <td width=98 style='width:73.2pt;border-top:none;border-left:none;border-bottom:
  solid black 1.0pt;border-right:solid windowtext 1.0pt;mso-border-top-alt:
  solid black .5pt;mso-border-left-alt:solid windowtext .5pt;mso-border-top-alt:
  black;mso-border-left-alt:windowtext;mso-border-bottom-alt:black;mso-border-right-alt:
  windowtext;mso-border-style-alt:solid;mso-border-width-alt:.5pt;padding:0cm 5.4pt 0cm 5.4pt;
  height:22.4pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:12.0pt;mso-bidi-font-size:11.0pt;font-family:宋体;mso-ascii-font-family:
  Calibri;mso-hansi-font-family:Calibri'>籍　　贯</span><span lang=EN-US
  style='font-size:12.0pt;mso-bidi-font-size:11.0pt'><o:p></o:p></span></p>
  </td>
  <td 
         style='border-bottom:solid black 1.0pt;border-right:solid black 1.0pt;mso-border-top-alt:
  solid black .5pt;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid black .5pt;mso-border-left-alt:solid windowtext .5pt;padding:0cm 5.4pt 0cm 5.4pt;
  border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;' 
         class="style1">
      <asp:TextBox ID="TextBox3" runat="server" Width="139px"></asp:TextBox><asp:RequiredFieldValidator
          ID="RequiredFieldValidator9" runat="server" ErrorMessage="*" 
          ControlToValidate="TextBox3" ForeColor="Red"></asp:RequiredFieldValidator>
      *</td>
 </tr>
 <tr style='mso-yfti-irow:2;height:31.4pt'>
  <td width=103 style='width:77.4pt;border:solid black 1.0pt;border-top:none;
  mso-border-top-alt:solid black .5pt;mso-border-alt:solid black .5pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:31.4pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:12.0pt;mso-bidi-font-size:11.0pt;font-family:宋体;mso-ascii-font-family:
  Calibri;mso-hansi-font-family:Calibri'>院系班级</span><span lang=EN-US
  style='font-size:12.0pt;mso-bidi-font-size:11.0pt'><o:p></o:p></span></p>
  </td>
  <td width=197 colspan=2 style='width:147.7pt;border-top:none;border-left:
  none;border-bottom:solid black 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid black .5pt;mso-border-left-alt:solid black .5pt;
  mso-border-alt:solid black .5pt;mso-border-right-alt:solid windowtext .5pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:31.4pt'>
 
      <asp:TextBox ID="TextBox4" runat="server" Width="196px" MaxLength="50"></asp:TextBox>
      *<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
          ControlToValidate="TextBox4" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
     </td>
  <td width=98 style='width:73.2pt;border-top:none;border-left:none;border-bottom:
  solid black 1.0pt;border-right:solid windowtext 1.0pt;mso-border-top-alt:
  solid black .5pt;mso-border-left-alt:solid windowtext .5pt;mso-border-top-alt:
  black;mso-border-left-alt:windowtext;mso-border-bottom-alt:black;mso-border-right-alt:
  windowtext;mso-border-style-alt:solid;mso-border-width-alt:.5pt;padding:0cm 5.4pt 0cm 5.4pt;
  height:31.4pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:12.0pt;mso-bidi-font-size:11.0pt;font-family:宋体;mso-ascii-font-family:
  Calibri;mso-hansi-font-family:Calibri'>宿　　舍</span><span lang=EN-US
  style='font-size:12.0pt;mso-bidi-font-size:11.0pt'><o:p></o:p></span></p>
  </td>
  <td 
         style='border-bottom:solid black 1.0pt;border-right:solid black 1.0pt;mso-border-top-alt:
  solid black .5pt;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid black .5pt;mso-border-left-alt:solid windowtext .5pt;padding:0cm 5.4pt 0cm 5.4pt;
  border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;' 
         class="style2">
      <asp:TextBox ID="TextBox5" runat="server" Width="139px" MaxLength="30" Text="格式为：楼号#宿舍号"  ></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
          ErrorMessage="*" ControlToValidate="TextBox5" ForeColor="Red"></asp:RequiredFieldValidator>
      *</td>
 </tr>
 <tr style='mso-yfti-irow:3;height:22.4pt'>
  <td width=103 style='width:77.4pt;border:solid black 1.0pt;border-top:none;
  mso-border-top-alt:solid black .5pt;mso-border-alt:solid black .5pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:22.4pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:12.0pt;mso-bidi-font-size:11.0pt;font-family:宋体;mso-ascii-font-family:
  Calibri;mso-hansi-font-family:Calibri'>现任职务</span><span lang=EN-US
  style='font-size:12.0pt;mso-bidi-font-size:11.0pt'><o:p></o:p></span></p>
  </td>
  <td width=197 colspan=2 style='width:147.7pt;border-top:none;border-left:
  none;border-bottom:solid black 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid black .5pt;mso-border-left-alt:solid black .5pt;
  mso-border-alt:solid black .5pt;mso-border-right-alt:solid windowtext .5pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:22.4pt'>
      <asp:TextBox ID="TextBox6" runat="server" Width="194px" MaxLength="30"></asp:TextBox>
      *<asp:RequiredFieldValidator
          ID="RequiredFieldValidator12" runat="server"  ErrorMessage="*" 
          ControlToValidate="TextBox6" ForeColor="Red"></asp:RequiredFieldValidator>
     </td>
  <td width=98 style='width:73.2pt;border-top:none;border-left:none;border-bottom:
  solid black 1.0pt;border-right:solid windowtext 1.0pt;mso-border-top-alt:
  solid black .5pt;mso-border-left-alt:solid windowtext .5pt;mso-border-top-alt:
  black;mso-border-left-alt:windowtext;mso-border-bottom-alt:black;mso-border-right-alt:
  windowtext;mso-border-style-alt:solid;mso-border-width-alt:.5pt;padding:0cm 5.4pt 0cm 5.4pt;
  height:22.4pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:12.0pt;mso-bidi-font-size:11.0pt;font-family:宋体;mso-ascii-font-family:
  Calibri;mso-hansi-font-family:Calibri'>有无电脑</span><span lang=EN-US
  style='font-size:12.0pt;mso-bidi-font-size:11.0pt'><o:p></o:p></span></p>
  </td>
  <td 
         style='border-bottom:solid black 1.0pt;border-right:solid black 1.0pt;mso-border-top-alt:
  solid black .5pt;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid black .5pt;mso-border-left-alt:solid windowtext .5pt;padding:0cm 5.4pt 0cm 5.4pt;
  border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;' 
         class="style1">
      <asp:DropDownList ID="DropDownList2" runat="server">
          <asp:ListItem>有</asp:ListItem>
          <asp:ListItem>无</asp:ListItem>
      </asp:DropDownList>
     </td>
 </tr>
 <tr style='mso-yfti-irow:4;height:24.8pt'>
  <td width=103 rowspan=2 style='width:77.4pt;border:solid black 1.0pt;
  border-top:none;mso-border-top-alt:solid black .5pt;mso-border-alt:solid black .5pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:24.8pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:12.0pt;mso-bidi-font-size:11.0pt;font-family:宋体;mso-ascii-font-family:
  Calibri;mso-hansi-font-family:Calibri'>联系方式</span><span lang=EN-US
  style='font-size:12.0pt;mso-bidi-font-size:11.0pt'><o:p></o:p></span></p>
  </td>
  <td width=82 style='width:61.6pt;border-top:none;border-left:none;border-bottom:
  solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;mso-border-top-alt:
  solid black .5pt;mso-border-left-alt:solid black .5pt;mso-border-top-alt:
  black;mso-border-left-alt:black;mso-border-bottom-alt:windowtext;mso-border-right-alt:
  windowtext;mso-border-style-alt:solid;mso-border-width-alt:.5pt;padding:0cm 5.4pt 0cm 5.4pt;
  height:24.8pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:12.0pt;mso-bidi-font-size:11.0pt;font-family:宋体;mso-ascii-font-family:
  Calibri;mso-hansi-font-family:Calibri'>电话号码</span><span lang=EN-US
  style='font-size:12.0pt;mso-bidi-font-size:11.0pt'><o:p></o:p></span></p>
  </td>
  <td width=115 style='width:86.1pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid black 1.0pt;
  mso-border-top-alt:solid black .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-top-alt:black;mso-border-left-alt:windowtext;mso-border-bottom-alt:
  windowtext;mso-border-right-alt:black;mso-border-style-alt:solid;mso-border-width-alt:
  .5pt;padding:0cm 5.4pt 0cm 5.4pt;height:24.8pt'>
      <asp:TextBox ID="TextBox7" runat="server" Width="105px" MaxLength="13"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
          ControlToValidate="TextBox7" ErrorMessage="*" ForeColor="Red" ValidationExpression="(^1[3-8]\d{9}$|^\d{3}-\d{8}$|^\d{4}-\d{7}$)"></asp:RequiredFieldValidator>
      *</td>
  <td width=98 style='width:73.2pt;border-top:none;border-left:none;border-bottom:
  solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;mso-border-top-alt:
  solid black .5pt;mso-border-left-alt:solid black .5pt;mso-border-top-alt:
  black;mso-border-left-alt:black;mso-border-bottom-alt:windowtext;mso-border-right-alt:
  windowtext;mso-border-style-alt:solid;mso-border-width-alt:.5pt;padding:0cm 5.4pt 0cm 5.4pt;
  height:24.8pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:12.0pt;mso-bidi-font-size:11.0pt;font-family:宋体;mso-ascii-font-family:
  Calibri;mso-hansi-font-family:Calibri'>邮　　箱</span><span lang=EN-US
  style='font-size:12.0pt;mso-bidi-font-size:11.0pt'><o:p></o:p></span></p>
  </td>
  <td 
         style='border-bottom:solid windowtext 1.0pt;border-right:solid black 1.0pt;
  mso-border-top-alt:solid black .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-top-alt:black;mso-border-left-alt:windowtext;mso-border-bottom-alt:
  windowtext;mso-border-right-alt:black;mso-border-style-alt:solid;mso-border-width-alt:
  .5pt;padding:0cm 5.4pt 0cm 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;' 
         class="style3">
      <asp:TextBox ID="TextBox9" runat="server" Width="143px"></asp:TextBox>
       *<asp:RegularExpressionValidator ID="RegularExpressionValidator2" 
          runat="server" ControlToValidate="TextBox9"
                            ErrorMessage="格式错误" 
          ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
          ForeColor="Red"></asp:RegularExpressionValidator>
     </td>
 </tr>
 <tr style='mso-yfti-irow:5;height:21.6pt'>
  <td width=82 style='width:61.6pt;border-top:none;border-left:none;border-bottom:
  solid black 1.0pt;border-right:solid windowtext 1.0pt;mso-border-top-alt:
  solid windowtext .5pt;mso-border-left-alt:solid black .5pt;mso-border-top-alt:
  windowtext;mso-border-left-alt:black;mso-border-bottom-alt:black;mso-border-right-alt:
  windowtext;mso-border-style-alt:solid;mso-border-width-alt:.5pt;padding:0cm 5.4pt 0cm 5.4pt;
  height:21.6pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:12.0pt;mso-bidi-font-size:11.0pt'>QQ</span><span
  style='font-size:12.0pt;mso-bidi-font-size:11.0pt;font-family:宋体;mso-ascii-font-family:
  Calibri;mso-hansi-font-family:Calibri'>号码</span><span lang=EN-US
  style='font-size:12.0pt;mso-bidi-font-size:11.0pt'><o:p></o:p></span></p>
  </td>
  <td width=115 style='width:86.1pt;border-top:none;border-left:none;
  border-bottom:solid black 1.0pt;border-right:solid black 1.0pt;mso-border-top-alt:
  solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;mso-border-top-alt:
  windowtext;mso-border-left-alt:windowtext;mso-border-bottom-alt:black;
  mso-border-right-alt:black;mso-border-style-alt:solid;mso-border-width-alt:
  .5pt;padding:0cm 5.4pt 0cm 5.4pt;height:21.6pt'>
      <asp:TextBox ID="TextBox8" runat="server" Width="104px"></asp:TextBox>
     </td>
  <td width=98 style='width:73.2pt;border-top:none;border-left:none;border-bottom:
  solid black 1.0pt;border-right:solid windowtext 1.0pt;mso-border-top-alt:
  solid windowtext .5pt;mso-border-left-alt:solid black .5pt;mso-border-top-alt:
  windowtext;mso-border-left-alt:black;mso-border-bottom-alt:black;mso-border-right-alt:
  windowtext;mso-border-style-alt:solid;mso-border-width-alt:.5pt;padding:0cm 5.4pt 0cm 5.4pt;
  height:21.6pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:12.0pt;mso-bidi-font-size:11.0pt;font-family:宋体;mso-ascii-font-family:
  Calibri;mso-hansi-font-family:Calibri'>其　　他</span><span lang=EN-US
  style='font-size:12.0pt;mso-bidi-font-size:11.0pt'><o:p></o:p></span></p>
  </td>
  <td 
         style='border-bottom:solid black 1.0pt;border-right:solid black 1.0pt;mso-border-top-alt:
  solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;mso-border-top-alt:
  windowtext;mso-border-left-alt:windowtext;mso-border-bottom-alt:black;
  mso-border-right-alt:black;mso-border-style-alt:solid;mso-border-width-alt:
  .5pt;padding:0cm 5.4pt 0cm 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;' 
         class="style4">
      <asp:TextBox ID="TextBox10" runat="server" Width="136px"></asp:TextBox>
     </td>
 </tr>

 <tr style='mso-yfti-irow:6;height:22.4pt'>
  <td width=103 style='width:77.4pt;border:solid black 1.0pt;border-top:none;
  mso-border-top-alt:solid black .5pt;mso-border-alt:solid black .5pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:22.4pt'>
  <p class=MsoNormal align=center style='text-align:center'>上传头像</p>
  </td>
  <td width=556 colspan=5 style='width:416.95pt;border-top:none;border-left:
  none;border-bottom:solid black 1.0pt;border-right:solid black 1.0pt;
  mso-border-top-alt:solid black .5pt;mso-border-left-alt:solid black .5pt;
  mso-border-alt:solid black .5pt;padding:0cm 5.4pt 0cm 5.4pt;height:22.4pt'>
      <asp:FileUpload ID="FileUpload1" runat="server" class="textbox2" 
          Width="216px" />
      &nbsp;*
      <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
          ControlToValidate="FileUpload1" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
  </td>
 </tr>

 <tr style='mso-yfti-irow:6;height:22.4pt'>
  <td width=103 style='width:77.4pt;border:solid black 1.0pt;border-top:none;
  mso-border-top-alt:solid black .5pt;mso-border-alt:solid black .5pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:22.4pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:12.0pt;mso-bidi-font-size:11.0pt;font-family:宋体;mso-ascii-font-family:
  Calibri;mso-hansi-font-family:Calibri'>应聘职位</span><span lang=EN-US
  style='font-size:12.0pt;mso-bidi-font-size:11.0pt'><o:p></o:p></span></p>
  </td>
  <td width=556 colspan=5 style='width:416.95pt;border-top:none;border-left:
  none;border-bottom:solid black 1.0pt;border-right:solid black 1.0pt;
  mso-border-top-alt:solid black .5pt;mso-border-left-alt:solid black .5pt;
  mso-border-alt:solid black .5pt;padding:0cm 5.4pt 0cm 5.4pt;height:22.4pt'>

                  <asp:DropDownList ID="DropDownList3" runat="server" Width="200" class="textbox2">
                        <asp:ListItem>编辑记者</asp:ListItem>
                        <asp:ListItem>美术编辑</asp:ListItem>
                        <asp:ListItem>程序员</asp:ListItem>
                        <asp:ListItem>综合办公室人员</asp:ListItem>
                    </asp:DropDownList>
                     
  </td>
 </tr>
 <tr style='mso-yfti-irow:7;height:179.95pt'>
  <td width=103 style='width:77.4pt;border:solid black 1.0pt;border-top:none;
  mso-border-top-alt:solid black .5pt;mso-border-alt:solid black .5pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:179.95pt'>
  <p class=MsoNormal align=center style='text-align:center'><b
  style='mso-bidi-font-weight:normal'><span style='mso-bidi-font-size:10.5pt;
  font-family:宋体;mso-ascii-font-family:Calibri;mso-hansi-font-family:Calibri'>◎</span></b><span
  style='font-size:14.0pt;font-family:宋体;mso-ascii-font-family:Calibri;
  mso-hansi-font-family:Calibri'>个人爱好及特长</span><span lang=EN-US
  style='font-size:14.0pt'><o:p></o:p></span></p>
  <p class=MsoNormal><span style='mso-bidi-font-size:10.5pt;font-family:宋体;
  mso-ascii-font-family:Calibri;mso-hansi-font-family:Calibri'>（</span><span
  style='font-family:宋体;mso-ascii-font-family:Calibri;mso-hansi-font-family:
  Calibri'>需填写与所报岗位有关内容</span><span style='mso-bidi-font-size:10.5pt;
  font-family:宋体;mso-ascii-font-family:Calibri;mso-hansi-font-family:Calibri'>）</span><span
  lang=EN-US style='mso-bidi-font-size:10.5pt'><o:p></o:p></span></p>
  </td>
  <td width=556 valign=top colspan=5 style='width:416.95pt;border-top:none;border-left:
  none;border-bottom:solid black 1.0pt;border-right:solid black 1.0pt;
  mso-border-top-alt:solid black .5pt;mso-border-left-alt:solid black .5pt;
  mso-border-alt:solid black .5pt; height:179.95pt'>
      <asp:TextBox ID="TextBox11" runat="server" Height="220px" MaxLength="743" Width="633px" 
          TextMode="MultiLine" style="margin-bottom: 0px"></asp:TextBox>
      *<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
          ControlToValidate="TextBox11" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
      （最大750字）</td>
 </tr>
 <tr style='mso-yfti-irow:8;height:103.15pt'>
  <td width=103 style='width:77.4pt;border:solid black 1.0pt;border-top:none;
  mso-border-top-alt:solid black .5pt;mso-border-alt:solid black .5pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:103.15pt'>
  <p class=MsoNormal align=center style='text-align:center'><b
  style='mso-bidi-font-weight:normal'><span style='mso-bidi-font-size:10.5pt;
  font-family:宋体;mso-ascii-font-family:Calibri;mso-hansi-font-family:Calibri'>◎</span></b><span
  style='font-size:14.0pt;font-family:宋体;mso-ascii-font-family:Calibri;
  mso-hansi-font-family:Calibri'>工作经历</span><span lang=EN-US style='font-size:
  14.0pt'><o:p></o:p></span></p>
  </td>
  <td width=556 valign=top colspan=5 style='width:416.95pt;border-top:none;border-left:
  none;border-bottom:solid black 1.0pt;border-right:solid black 1.0pt;
  mso-border-top-alt:solid black .5pt;mso-border-left-alt:solid black .5pt;
  mso-border-alt:solid black .5pt;padding-left:5px; padding-top:5px;height:auto'>
      <asp:TextBox ID="TextBox12" runat="server" Height="120px" MaxLength="455"  Width="630px"  
          TextMode="MultiLine" style="margin-bottom: 9px"></asp:TextBox>
      *<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
          ControlToValidate="TextBox12" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
      （最大460字）</td>
 </tr>
 <tr style='mso-yfti-irow:9;height:28.5pt'>
  <td width=103 rowspan=2 style='width:77.4pt;border:solid black 1.0pt;
  border-top:none;mso-border-top-alt:solid black .5pt;mso-border-alt:solid black .5pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:28.5pt'>
  <p class=MsoNormal><b style='mso-bidi-font-weight:normal'><span
  style='mso-bidi-font-size:10.5pt;font-family:宋体;mso-ascii-font-family:Calibri;
  mso-hansi-font-family:Calibri'>&nbsp;◎</span></b><span style='font-size:14.0pt;
  font-family:宋体;mso-ascii-font-family:Calibri;mso-hansi-font-family:Calibri'>作品展示</span><span
  lang=EN-US style='font-size:12.0pt'>
  <o:p></o:p></span></p>
  </td>
  <td width=556 colspan=5 valign=top style='width:416.95pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid black 1.0pt;
  mso-border-top-alt:solid black .5pt;mso-border-left-alt:solid black .5pt;
  mso-border-alt:solid black .5pt;mso-border-bottom-alt:solid windowtext .5pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:28.5pt'>
  <p class=MsoNormal><span style='mso-bidi-font-size:10.5pt;font-family:宋体;
  mso-ascii-font-family:Calibri;mso-hansi-font-family:Calibri'>请在此填写个人作品。获奖作品请注明获奖时间及奖项，在校内媒体发表的请写清标题及发布网站。原创作品打印版可与报名表一起交给现场纳新负责人，或送至网站办公室<b>（鸿远楼西侧</b></span><b><span
  lang=EN-US style='mso-bidi-font-size:10.5pt'>212</span></b><b><span
  style='mso-bidi-font-size:10.5pt;font-family:宋体;mso-ascii-font-family:Calibri;
  mso-hansi-font-family:Calibri'>室）</span></b><span style='mso-bidi-font-size:
  10.5pt;font-family:宋体;mso-ascii-font-family:Calibri;mso-hansi-font-family:
  Calibri'>，电子版直接发至</span><span lang=EN-US style='mso-bidi-font-size:10.5pt'>lg<a
  name="_Hlt268766513"></a><a name="_Hlt268766512"><span style='mso-bookmark:
  _Hlt268766513'>w</span></a>indow@163.com</span><span style='mso-bidi-font-size:
  10.5pt;font-family:宋体;mso-ascii-font-family:Calibri;mso-hansi-font-family:
  Calibri'>（格式：宋体，小四号，行距</span><span lang=EN-US style='mso-bidi-font-size:10.5pt'>1.5</span><span
  style='mso-bidi-font-size:10.5pt;font-family:宋体;mso-ascii-font-family:Calibri;
  mso-hansi-font-family:Calibri'>，作品须注明作者姓名、学院及联系方式等基本信息）。</span><span
  lang=EN-US style='mso-bidi-font-size:10.5pt'><o:p></o:p></span></p>
  </td>
 </tr>
 <tr style='mso-yfti-irow:10;mso-yfti-lastrow:yes;height:110.8pt'>
  <td width=556 colspan=5 valign=top style='width:416.95pt;border-top:none;
  border-left:none;border-bottom:solid black 1.0pt;border-right:solid black 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid black .5pt;
  mso-border-alt:solid black .5pt;mso-border-top-alt:solid windowtext .5pt;
 padding-left:5px; padding-top:5px;'>
      <asp:TextBox ID="TextBox13" runat="server" Height="123px" MaxLength="359"  Width="629px"   
          TextMode="MultiLine"></asp:TextBox>
      *<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
          ControlToValidate="TextBox13" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
      （最大360字）</td>
 </tr>
</table>
    
    
    
    </div>
    <div id="bottom">
    
    
<p class=MsoNormal align=left style='margin-top:0cm;margin-right:36.75pt;
margin-bottom:0cm;margin-left:20px;margin-bottom:.0001pt;text-align:left;
text-indent:.1pt'><b style='mso-bidi-font-weight:normal'><span
style='font-family:宋体;'>注：</span><span
lang=EN-US>1</span></b><b style='mso-bidi-font-weight:normal'><span
style='font-family:宋体;'>、此表用于报名，经考核合格转正后，将作为成员档案，请填写完整；</span><span
lang=EN-US><o:p></o:p></span></b></p>

<p class=MsoNormal align=left style='margin-top:0cm;margin-right:36.75pt;
margin-bottom:0cm;margin-left:20pt;margin-bottom:.0001pt;text-align:left;
text-indent:.1pt'><b style='mso-bidi-font-weight:normal'><span
style='font-family:宋体'></span><span
lang=EN-US>&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; 2</span></b><b style='mso-bidi-font-weight:normal'><span
style='font-family:宋体i'>、正式开始工作后，网站会定期开展培训，进行业务提高；</span><span
lang=EN-US>
<o:p></o:p></span></b></p>

<p class=MsoNormal align=left style='margin-top:0cm;margin-right:36.75pt;
margin-bottom:0cm;margin-left:20px;margin-bottom:.0001pt;text-align:left;
text-indent:.1pt'><b style='mso-bidi-font-weight:normal'><span
style='font-family:宋体;mso-ascii-font-family:Calibri;mso-hansi-font-family:Calibri'></span><span
lang=EN-US>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 3</span><span
style='font-family:宋体;mso-ascii-font-family:Calibri;mso-hansi-font-family:Calibri'>、咨询电话：</span><span
lang=EN-US>2786727</span><span
style='font-family:宋体;mso-ascii-font-family:Calibri;mso-hansi-font-family:Calibri'>　　　　　　　　　　　　　　　 </span><span
lang=EN-US>
<o:p></o:p></span></b></p>
    </div>
    <div style=" margin-bottom:40px; text-align:center">
        <asp:Button ID="Button1" runat="server" Text="提交" onclick="Button1_Click"  
            CausesValidation="true" Height="27px" Width="107px"/></div>
  </div>
</div>
<div id="Div1" style="margin:auto; width:950px"><img src="../images/bottom.jpg" width="950" height="51" border="0" usemap="#Map" />
    </form>
</body>
</html>
