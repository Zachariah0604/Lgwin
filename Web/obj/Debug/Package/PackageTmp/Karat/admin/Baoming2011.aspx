<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Baoming2011.aspx.cs" Inherits="Lgwin.Karat.admin.Baoming2011" %>
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
-->
</style>
<body>
    <form id="form1" runat="server">
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
      <asp:Label ID="xingming" runat="server" Text="Label"></asp:Label></td>
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
  <td width=132 style='width:99.2pt;border:solid black 1.0pt;border-left:none;
  mso-border-left-alt:solid windowtext .5pt;mso-border-alt:solid black .5pt;
  mso-border-left-alt:solid windowtext .5pt;padding:0cm 5.4pt 0cm 5.4pt;
  height:22.4pt'>
      <asp:Label ID="xingbie" runat="server" Text="Label"></asp:Label>
      </td>
  <td width=129 valign=cesnter align=center rowspan=6 style='width:96.85pt;border:solid black 1.0pt;
  border-left:none;mso-border-left-alt:solid black .5pt;mso-border-alt:solid black .5pt;
  padding-left:5px; padding-top:5px;height:22.4pt'>
      <asp:Image ID="imgage" runat="server" Height="164px" Width="120px" />
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
      <asp:Label ID="xuehao" runat="server" Text="Label"></asp:Label>
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
  <td width=132 style='width:99.2pt;border-top:none;border-left:none;
  border-bottom:solid black 1.0pt;border-right:solid black 1.0pt;mso-border-top-alt:
  solid black .5pt;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid black .5pt;mso-border-left-alt:solid windowtext .5pt;padding:0cm 5.4pt 0cm 5.4pt;
  height:22.4pt'>
      <asp:Label ID="jiguan" runat="server" Text="Label"></asp:Label>
     </td>
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
 
      <asp:Label ID="banji" runat="server" Text="Label"></asp:Label>
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
  <td width=132 style='width:99.2pt;border-top:none;border-left:none;
  border-bottom:solid black 1.0pt;border-right:solid black 1.0pt;mso-border-top-alt:
  solid black .5pt;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid black .5pt;mso-border-left-alt:solid windowtext .5pt;padding:0cm 5.4pt 0cm 5.4pt;
  height:31.4pt'>
      <asp:Label ID="sushe" runat="server" Text="Label"></asp:Label>
     </td>
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
      <asp:Label ID="zhiwu" runat="server" Text="Label"></asp:Label>
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
  <td width=132 style='width:99.2pt;border-top:none;border-left:none;
  border-bottom:solid black 1.0pt;border-right:solid black 1.0pt;mso-border-top-alt:
  solid black .5pt;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid black .5pt;mso-border-left-alt:solid windowtext .5pt;padding:0cm 5.4pt 0cm 5.4pt;
  height:22.4pt'>
      <asp:Label ID="diannao" runat="server" Text="Label"></asp:Label>
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
      <asp:Label ID="dianhua" runat="server" Text=""></asp:Label>
     </td>
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
  <td width=132 style='width:99.2pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid black 1.0pt;
  mso-border-top-alt:solid black .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-top-alt:black;mso-border-left-alt:windowtext;mso-border-bottom-alt:
  windowtext;mso-border-right-alt:black;mso-border-style-alt:solid;mso-border-width-alt:
  .5pt;padding:0cm 5.4pt 0cm 5.4pt;height:24.8pt'>
      <asp:Label ID="youxiang" runat="server" Text=""></asp:Label>
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
      <asp:Label ID="qqhaoma" runat="server" Text=""></asp:Label>
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
  <td width=132 style='width:99.2pt;border-top:none;border-left:none;
  border-bottom:solid black 1.0pt;border-right:solid black 1.0pt;mso-border-top-alt:
  solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;mso-border-top-alt:
  windowtext;mso-border-left-alt:windowtext;mso-border-bottom-alt:black;
  mso-border-right-alt:black;mso-border-style-alt:solid;mso-border-width-alt:
  .5pt;padding:0cm 5.4pt 0cm 5.4pt;height:21.6pt'>
      <asp:Label ID="qita" runat="server" Text=""></asp:Label>
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
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:12.0pt;mso-bidi-font-size:11.0pt'><span
  style='mso-spacerun:yes'>&nbsp;</span></span><asp:CheckBox ID="jz" 
          runat="server" />
      <span style='font-size:12.0pt;mso-bidi-font-size:
  11.0pt;font-family:宋体;mso-ascii-font-family:Calibri;mso-hansi-font-family:
  Calibri'>编辑记者 </span><span lang=EN-US style='font-size:12.0pt;mso-bidi-font-size:
  11.0pt'><span style='mso-spacerun:yes'>&nbsp;&nbsp;&nbsp;&nbsp; </span></span><asp:CheckBox ID="zh" 
          runat="server" /><span style='font-size:12.0pt;
  mso-bidi-font-size:11.0pt;font-family:宋体;mso-ascii-font-family:Calibri;
  mso-hansi-font-family:Calibri'>综合办公人员</span><span lang=EN-US
  style='font-size:12.0pt;mso-bidi-font-size:11.0pt'><span
  style='mso-spacerun:yes'>&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; </span></span><asp:CheckBox ID="cx" 
          runat="server" /><span style='font-size:12.0pt;
  mso-bidi-font-size:11.0pt;font-family:宋体;mso-ascii-font-family:Calibri;
  mso-hansi-font-family:Calibri'>程序员</span><span lang=EN-US style='font-size:
  12.0pt;mso-bidi-font-size:11.0pt'><span
  style='mso-spacerun:yes'>&nbsp;&nbsp; &nbsp;&nbsp; </span></span><asp:CheckBox ID="mb" 
          runat="server" /><span style='font-size:12.0pt;
  mso-bidi-font-size:11.0pt;font-family:宋体;mso-ascii-font-family:Calibri;
  mso-hansi-font-family:Calibri'>美术编辑</span><span lang=EN-US style='font-size:
  12.0pt;mso-bidi-font-size:11.0pt'>
  <o:p></o:p></span></p>
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
  mso-border-alt:solid black .5pt; padding-left:5px; padding-top:5px; ;height:179.95pt'>
      <asp:Label ID="aihao" runat="server" Text=""></asp:Label>
     </td>
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
      <asp:Label ID="gongzuo" runat="server" Text=""></asp:Label>
     </td>
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
      <asp:Label ID="zuopin" runat="server" Text=""></asp:Label>
     </td>
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
    <p align="right"><b> Powered by <img width=13 height=13
src="baoming/image002.jpg" v:shapes="_x0000_i1025"> Karat
Studio   &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
      </b></p>
    </div>
  </div>
</div>
    </form>
</body>
</html>
