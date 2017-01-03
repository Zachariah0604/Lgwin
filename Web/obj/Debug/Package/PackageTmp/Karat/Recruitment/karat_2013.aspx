<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="karat_2013.aspx.cs" Inherits="Lgwin.Karat.Recruitment.karat_2013" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>报名表</title>
<link rel=File-List href="baoming/filelist.xml">
<link rel=Edit-Time-Data href="baoming/editdata.mso">
<link href="admin/css/baoming.css" rel="stylesheet" type="text/css" />
    <link href="../css/style.css" type="text/css" rel="Stylesheet" />
    <script language="javascript" type="text/javascript">
        function PreviewImg(imgFile) {
            var newPreview = document.getElementById("newPreview");
            newPreview.filters.item("DXImageTransform.Microsoft.AlphaImageLoader").src = imgFile.value;
            newPreview.style.width = "130px";
            newPreview.style.height = "150px";
        }
        function empty() {
            document.getElementById("TextBox6").value = "";
        }
    </script>
</head>
<style>
body
{
	margin:0;
	padding:0px;
	border:0;
  background:#fff;
}
 #newPreview
        {
            margin-top: 5px;
          
            width: 130px;
            filter: progid:DXImageTransform.Microsoft.AlphaImageLoader(sizingMethod=scale);
            height: 150px;
            margin-left:2px;
        }
        .style8
        {
            width: 96pt;
            height: 6px;
        }
        .style9
        {
            width: 78px;
            height: 81px;
        }
        .style14
        {
            width: 75.15pt;
            height: 46px;
        }
        .style36
        {
            width: 450.95pt;
            height: 115px;
        }
        .style46
        {
            height: 81px;
        }
        .style50
        {
            width: 450.95pt;
            height: 175px;
        }
        .style54
        {
            width: 123.15pt;
            height: 61px;
        }
        .style57
        {
            height: 1pt;
        }
        .style58
        {
            width: 213.75pt;
            height: 1pt;
        }
        #newPreview
        {
            height: 133px;
            width: 93px;
        }
                
        .style89
        {
            width: 3px;
        }
        .style90
        {
            width: 450.95pt;
            height: 115pt;
        }
        .style94
        {
        width: 106px;
    }
        .style97
        {
            width: 96pt;
            font-size: 14px;
            font-weight: bold;
            color: #808080;
            height: 61px;
        }
        .style99
        {
            width: 106px;
            height: 61px;
        }
        .style101
        {
            width: 96pt;
            height: 46px;
        }
        .style103
        {
            height: 46px;
        }
        .style104
        {
            height: 73px;
        }
        .style106
        {
            height: 61px;
        }
        .style109
        {
        }
        .style110
        {
        }
        .style112
        {
            width: 94px;
        }
        .style113
        {
          
        }
        #box
{
    margin:0 auto;
	width:754px;

}
#box_nei
{
	margin:0 auto;
	width:760px;
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
    .style5
    {
        height: 25px;
    }

    .style119
    {
        width: 78px;
        height: 6px;
    }
    .style121
    {
        height: 24pt;
    }
    .style122
    {
        width: 96pt;
    }
    .style124
    {
        width: 78px;
        height: 61px;
    }
    .style125
    {
        width: 78px;
    }
 -->
</style>




<body>
    <iframe scrolling="no" allowtransparency="true" width="100%" height="180px" src="../top.html" frameborder="0"></iframe>
    <form id="form1" runat="server">
    <div style="margin:auto; width:950px">

 
<div id="box">

  <div id="box_nei">
    <div id="title"><b style='mso-bidi-font-weight:normal'><span
style='font-size:26.0pt;font-family:方正大标宋简体'>山东理工大学新闻网纳新报名表<span lang=EN-US><o:p></o:p></span></span></b></div>
      <div id="tab">
    <table border="1" cellspacing="0" cellpadding="0" style='border-style: none; border-color: inherit;
            border-width: medium; width: 713px; border-collapse: collapse; margin-right: 0px;
            background-image: url(&#039;../images/baoming3.jpg&#039;); height: 845px; display:inline; border:1px solid; ' align="center" frame="box">
            <tr style='height: 17.85pt'>
                <td colspan="7" style='border: solid black 1.0pt; background: #F7F7FF; padding: 0cm 5.4pt 0cm 5.4pt;
                    height: 17.85pt'>
                    <p class="MsoNormal" align="center" style='margin-left: 21.0pt; text-align: center;
                        text-indent: -15.35pt; height: 20px; width: 673px;'>
                        <span lang="EN-US" style='font-size: 12.0pt; font-family: Symbol'>
                            <img width="15" height="15" src="../images/baoming2.gif" alt="*"/><span
                                style='font: 7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp; </span></span><b><span style='font-size: 12.0pt;
                                    font-family: 宋体'>个人信息</span></b></p>
                </td>
            </tr>
            <tr>
                <td style='border-left: 1.0pt solid black; border-right: 1.0pt solid black; border-bottom: 1.0pt solid black;
                    padding: 0cm 5.4pt; border-top-style: none; border-top-color: inherit; border-top-width: medium;'
                    >
                    姓<br />
                    名<font color="red">*</font>
                </td>
                <td colspan="1" style='border-bottom: solid black 1.0pt; border-right: solid black 1.0pt;
                    padding: 0cm 5.4pt 0cm 0pt; border-left-style: none; border-left-color: inherit;
                    border-left-width: medium; border-top-style: none; border-top-color: inherit;
                    border-top-width: medium;' class="style106">
                    <asp:TextBox ID="name2013" runat="server" class="textbox" Width="110px" 
                        Height="17px" MaxLength="12"></asp:TextBox>
                    <font size="1"  color="red">
                        <asp:RequiredFieldValidator ID="name" runat="server" ErrorMessage="不为空" ControlToValidate="name2013"></asp:RequiredFieldValidator></font>
                </td>
                <td style='border-bottom: solid black 1.0pt; border-right: solid black 1.0pt;
                    padding: 0cm 5.4pt 0cm 5.4pt; border-left-style: none; border-left-color: inherit;
                    border-left-width: medium; border-top-style: none; border-top-color: inherit;
                    border-top-width: medium;' class="style8">
                    <asp:Label ID="Label10" runat="server" 
                        Text="性别&lt;font color=&quot;red&quot; &gt;*&lt;/font&gt;" Width="30px"></asp:Label>
                </td>
                <td style='border-bottom: solid black 1.0pt; border-right: solid black 1.0pt; padding: 0cm 5.4pt 0cm 5.4pt;
                    border-left-style: none; border-left-color: inherit; border-left-width: medium;
                    border-top-style: none; border-top-color: inherit; border-top-width: medium;'
                    class="style106">
                    <asp:DropDownList ID="sex2013" runat="server" Height="24px" Width="46px">
                        <asp:ListItem Selected="True">男</asp:ListItem>
                        <asp:ListItem>女　</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td style='border-bottom: solid black 1.0pt; border-right: solid black 1.0pt; padding: 0cm 5.4pt 0cm 5.4pt;
                    border-left-style: none; border-left-color: inherit; border-left-width: medium;
                    border-top-style: none; border-top-color: inherit; border-top-width: medium;'
                    class="style119">
                    籍贯<font color="red">*</font>
                </td>
                <td colspan="1" style='border-bottom: solid black 1.0pt; border-right: solid black 1.0pt;
                    padding: 0cm 5.4pt 0cm 0pt; border-left-style: none; border-left-color: inherit;
                    border-left-width: medium; border-top-style: none; border-top-color: inherit;
                    border-top-width: medium;' class="style106">
                    <asp:TextBox ID="jiguan2013" runat="server" class="textbox" Width="156px" MaxLength="30"></asp:TextBox>
                    <font size="1"  color="red">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="不能为空！"
                            ControlToValidate="jiguan2013"></asp:RequiredFieldValidator></font>
                </td>
                <td rowspan="3" style='border-bottom: solid black 1.0pt; border-right: solid black 1.0pt;
                    padding: 0cm 0pt 0cm 0pt; border-left-style: none; border-left-color: inherit;
                    border-left-width: medium; border-top-style: none; border-top-color: inherit;
                    border-top-width: medium;' class="style94">
                    <div style="margin-left: 3px; height: 32px; width: 114px;">
                         在此处上传头像</div>
                    <div id="newPreview">
                    </div>
                </td>
            </tr>
            <tr>
                <td style='border-left: 1.0pt solid black; border-right: 1.0pt solid black; border-bottom: 1.0pt solid black;
                    padding: 0cm 5.4pt; border-top-style: none; border-top-color: inherit; border-top-width: medium;'
                    >
                    所<br />
                    在<br />
                    学<br />
                    院<font color="red">*</font>
                </td>
                <td colspan="3" style='border-bottom: solid black 1.0pt; border-right: solid black 1.0pt;
                    padding: 0cm 5.4pt 0cm 0pt; border-left-style: none; border-left-color: inherit;
                    border-left-width: medium; border-top-style: none; border-top-color: inherit;
                    border-top-width: medium;' class="style104">
                    <asp:TextBox ID="xueyuan2013" runat="server" Width="224px" class="textbox" MaxLength="25"></asp:TextBox>
                    <font size="1"  color="red">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="不能为空！"
                            ControlToValidate="xueyuan2013"></asp:RequiredFieldValidator></font>
                </td>
                <td 
                    
                    style='border-bottom: solid black 1.0pt; border-right: solid black 1.0pt; padding: 0cm 5.4pt 0cm 5.4pt;
                    border-left-style: none; border-left-color: inherit; border-left-width: medium;
                    border-top-style: none; border-top-color: inherit; border-top-width: medium;' 
                    class="style125" > 
                          专业<br/>班级<font color="red">*</font>
                    
                  
                   
                </td>
                <td colspan="1" style='border-bottom: solid black 1.0pt; border-right: solid black 1.0pt;
                    padding: 0cm 5.4pt 0cm 0pt; border-left-style: none; border-left-color: inherit;
                    border-left-width: medium; border-top-style: none; border-top-color: inherit;
                    border-top-width: medium;' class="style104">
                    <asp:TextBox ID="banji2013" runat="server" class="textbox" Width="157px" MaxLength="25"></asp:TextBox>
                    <font size="1"  color="red">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="不能为空！"
                            ControlToValidate="banji2013"></asp:RequiredFieldValidator></font>
                </td>
            </tr>
            <tr>
                <td style='border-left: 1.0pt solid black; border-right: 1.0pt solid black; border-bottom: 1.0pt solid black;
                    padding: 0cm 5.4pt; border-top-style: none; border-top-color: inherit; border-top-width: medium;'
                   >
                    有<br />
                    无<br />
                    电<br />
                    脑
                </td>
                <td colspan="1" style='border-bottom: solid black 1.0pt; border-right: solid black 1.0pt;
                    padding: 0cm 5.4pt 0cm 5.4pt; border-left-style: none; border-left-color: inherit;
                    border-left-width: medium; border-top-style: none; border-top-color: inherit;
                    border-top-width: medium;' class="style14">
                   <asp:RadioButtonList ID="computer2013" runat="server" 
                        RepeatDirection="Horizontal" Height="28px" Width="72px">
                        <asp:ListItem Selected="True">是　</asp:ListItem>
                        <asp:ListItem>否</asp:ListItem>
                    </asp:RadioButtonList>
                   
                </td>
                <td style='border-bottom: solid black 1.0pt; border-right: solid black 1.0pt;
                    padding: 0cm 5.4pt 0cm 5.4pt; border-left-style: none; border-left-color: inherit;
                    border-left-width: medium; border-top-style: none; border-top-color: inherit;
                    border-top-width: medium;' class="style101">
                    <asp:Label ID="Label11" runat="server" 
                        Text="宿舍&lt;font color=&quot;red&quot; &gt;*&lt;/font&gt;" Width="30px"></asp:Label>
                </td>
                <td style='border-bottom: solid black 1.0pt; border-right: solid black 1.0pt; padding: 0cm 5.4pt 0cm 0pt;
                    border-left-style: none; border-left-color: inherit; border-left-width: medium;
                    border-top-style: none; border-top-color: inherit; border-top-width: medium;'
                    class="style103">
                    <asp:TextBox ID="sushe2013" runat="server" class="textbox" Width="130px" 
                        MaxLength="15"  onfocus="empty();" value="如：西校4#432"></asp:TextBox>
                    <font size="1"  color="red">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="不能为空！"
                            ControlToValidate="sushe2013" Width="40"></asp:RequiredFieldValidator></font>
                </td>
                <td 
                    
                    style='border-bottom: solid black 1.0pt; border-right: solid black 1.0pt; padding: 0cm 5.4pt 0cm 5.4pt;
                    border-left-style: none; border-left-color: inherit; border-left-width: medium;
                    border-top-style: none; border-top-color: inherit; border-top-width: medium;' class="style125"
                   >
                    E-MAIL<font color="red">*</font>
                </td>
                <td colspan="1" style='border-bottom: solid black 1.0pt; border-right: solid black 1.0pt;
                    padding: 0cm 5.4pt 0cm 0pt; border-left-style: none; border-left-color: inherit;
                    border-left-width: medium; border-top-style: none; border-top-color: inherit;
                    border-top-width: medium;' class="style103">
                    <asp:TextBox ID="mail2013" runat="server" class="textbox" Width="159px" MaxLength="20"></asp:TextBox>
                    <font size="1"  color="red">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="不能为空！"
                            ControlToValidate="mail2013"></asp:RequiredFieldValidator><asp:RegularExpressionValidator
                                ID="RegularExpressionValidator1" runat="server" 
                        ErrorMessage="邮箱格式不正确!" ControlToValidate="mail2013" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></font>
            </tr>
            <tr>
                <td style='border-left: 1.0pt solid black; border-right: 1.0pt solid black; border-bottom: 1.0pt solid black;
                    padding: 0cm 5.4pt; border-top-style: none; border-top-color: inherit; border-top-width: medium;'
                    class="style106">
                    联<br />
                    系<br />
                    电<br />
                    话<font color="red">*</font>
                </td>
                <td colspan="1" style='border-bottom: solid black 1.0pt; border-right: solid black 1.0pt;
                    padding: 0cm 0pt 0cm 0pt; border-left-style: none; border-left-color: inherit;
                    border-left-width: medium; border-top-style: none; border-top-color: inherit;
                    border-top-width: medium;' class="style106">
                    <asp:TextBox ID="tel2013" runat="server" class="textbox" Width="118px" 
                        Height="16px" MaxLength="13"></asp:TextBox>
                    <font size="1"  color="red">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="不能为空！"
                            ControlToValidate="tel2013"></asp:RequiredFieldValidator><asp:RegularExpressionValidator
                                ID="RegularExpressionValidator2" runat="server" 
                        ErrorMessage="你输入格式不对！" ControlToValidate="tel2013" 
                        ValidationExpression="^[0-9]*$"></asp:RegularExpressionValidator></font>
                </td>
                <td style='border-bottom: solid black 1.0pt; border-right: solid black 1.0pt;
                    padding: 0cm 5.4pt 0cm 5.4pt; border-left-style: none; border-left-color: inherit;
                    border-left-width: medium; border-top-style: none; border-top-color: inherit;
                    border-top-width: medium;' class="style97">
                    <asp:Label ID="Label12" runat="server" 
                        Text=" Q Q&lt;font color=&quot;red&quot; &gt;*&lt;/font&gt; " Width="30px"></asp:Label>
                </td>
                <td 
                    
                    
                    style='border-bottom: solid black 1.0pt; border-right: solid black 1.0pt; padding: 0cm 5.4pt 0cm 0pt;
                    border-left-style: none; border-left-color: inherit; border-left-width: medium;
                    border-top-style: none; border-top-color: inherit; border-top-width: medium;' 
                    class="style106">
                    <asp:TextBox ID="qq2013" runat="server" class="textbox" Width="130px" 
                        Height="16px" MaxLength="13"></asp:TextBox>
                    <font size="1"  color="red">
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="不能为空！"
                            ControlToValidate="qq2013" Width="40px" Height="16px"></asp:RequiredFieldValidator>
                             <asp:RegularExpressionValidator
                                ID="RegularExpressionValidator3" runat="server" 
                        ErrorMessage="你输入格式不对！" ControlToValidate="qq2013" 
                        ValidationExpression="^[0-9]*$"></asp:RegularExpressionValidator></font>
                </td>
                <td style='border-bottom: solid black 1.0pt; border-right: solid black 1.0pt; padding: 0cm 5.4pt 0cm 5.4pt;
                    border-left-style: none; border-left-color: inherit; border-left-width: medium;
                    border-top-style: none; border-top-color: inherit; border-top-width: medium;'
                    class="style124">
                    人人/微博等其他方式
                </td>
                <td colspan="1" style='border-bottom: solid black 1.0pt; border-right: solid black 1.0pt;
                    padding: 0cm 5.4pt 0cm 0pt; border-left-style: none; border-left-color: inherit;
                    border-left-width: medium; border-top-style: none; border-top-color: inherit;
                    border-top-width: medium;' class="style54">
                    <asp:TextBox ID="other2013" runat="server" class="textbox" Width="152px" 
                        Height="19px" MaxLength="20"></asp:TextBox>
                </td>
                <td class="style99" align="right">
                    <asp:FileUpload ID="FileUpload2013" runat="server" onchange="PreviewImg(this)" 
                        Width="105px" CssClass="style113" Height="20px"  />
                    &nbsp&nbsp <font size="2"  color="red">
                        <asp:RequiredFieldValidator ID="touxiang" runat="server" ErrorMessage="请上传头像" ControlToValidate="FileUpload2013"
                            ></asp:RequiredFieldValidator></font>
                </td>
            </tr>
            <tr>
                <td colspan="7" style='border-left: 1.0pt solid black; border-right: 1.0pt solid black;
                    border-bottom: 1.0pt solid black; background: #F7F7FF; padding: 0cm 5.4pt; border-top-style: none;
                    border-top-color: inherit; border-top-width: medium;' class="style5">
                    <p class="MsoNormal" align="center" style='margin-left: 21.0pt; text-align: center;
                        text-indent: -15.35pt; width: 633px; height: 12px;'>
                        <span lang="EN-US" style='font-size: 12.0pt; font-family: Symbol'>
                            <img width="15" height="15" src="../images/baoming2.gif" alt="*"><span style='font: 7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;
                            </span></span><b><span style='font-size: 12.0pt; font-family: 宋体'>发展轨迹</span></b></p>
                </td>
            </tr>
            <tr>
                <td style='border-left: 1.0pt solid black; border-right: 1.0pt solid black; border-bottom: 1.0pt solid black;
                    padding: 0cm 5.4pt; border-top-style: none; border-top-color: inherit; border-top-width: medium;'
                  >
                    大<br />
                    学<br />
                    社<br />
                    团<br />
                    经<br />
                    历<br />及<br />职<br />务
                </td>
                <td colspan="3" style='border-bottom: solid black 1.0pt; border-right: solid windowtext 1.0pt;
                    padding: 0cm 5.4pt 0cm 0pt; border-left-style: none; border-left-color: inherit;
                    border-left-width: medium; border-top-style: none; border-top-color: inherit;
                    border-top-width: medium;' class="style46">
                    <asp:TextBox ID="shetuan2013" runat="server" Height="111px" TextMode="MultiLine" Width="305px"
                        class="textbox"></asp:TextBox>
                </td>
                <td colspan="1" style='border-bottom: solid black 1.0pt; border-right: solid windowtext 1.0pt;
                    padding: 0cm 5.4pt 0cm 5.4pt; border-left-style: none; border-left-color: inherit;
                    border-left-width: medium; border-top-style: none; border-top-color: inherit;
                    border-top-width: medium;' class="style9">
                    有无活动组织策划经历
                </td>
                <td colspan="2" style='border-bottom: solid black 1.0pt; border-right: solid windowtext 1.0pt;
                    padding: 0cm 5.4pt 0cm 5.4pt; border-left-style: none; border-left-color: inherit;
                    border-left-width: medium; border-top-style: none; border-top-color: inherit;
                    border-top-width: medium;' >
                    <asp:RadioButtonList ID="cehua2013" runat="server" 
                        RepeatDirection="Horizontal" Width="150px">
                        <asp:ListItem>有</asp:ListItem>
                        <asp:ListItem Selected="True">无</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td style='border-left: 1.0pt solid black; border-right: 1.0pt solid black; border-bottom: 1.0pt solid black;
                    padding: 0cm 5.4pt; border-top-style: none; border-top-color: inherit; border-top-width: medium;'
                   >
                 校<br />外<br />工<br />作<br />经<br />验
                </td>
                <td colspan="3" style='border-bottom: solid black 1.0pt; border-right: solid windowtext 1.0pt;
                    padding: 0cm 5.4pt 0cm 0pt; border-left-style: none; border-left-color: inherit;
                    border-left-width: medium; border-top-style: none; border-top-color: inherit;
                    border-top-width: medium;' class="style57">
                    <asp:TextBox ID="jingyan2013" runat="server" class="textbox" Height="71px" 
                        Width="305px" MaxLength="50" TextMode="MultiLine"></asp:TextBox>
                </td>
                <td colspan="1" style='border-bottom: solid black 1.0pt; border-right: solid windowtext 1.0pt;
                    padding: 0cm 5.4pt 0cm 5.4pt; border-left-style: none; border-left-color: inherit;
                    border-left-width: medium; border-top-style: none; border-top-color: inherit;
                    border-top-width: medium;' class="style125">
                    获取<br />
                    奖励
                </td>
                <td colspan="2" style='border-bottom: solid black 1.0pt; border-right: solid black 1.0pt;
                    padding: 0cm 5.4pt 0cm 0pt; border-left-style: none; border-left-color: inherit;
                    border-left-width: medium; border-top-style: none; border-top-color: inherit;
                    border-top-width: medium;' class="style58">
                    <asp:TextBox ID="jiangli2013" runat="server" class="textbox" TextMode="MultiLine" Height="76px"
                        Width="293px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style='border-left: 1.0pt solid black; border-right: 1.0pt solid black; border-bottom: 1.0pt solid black;
                    padding: 0cm 5.4pt; border-top-style: none; border-top-color: inherit; border-top-width: medium;'
                    >
                  写<br />
                    作<br />
                    能<br />
                    力
                </td>
                <td colspan="3" style='border-bottom: solid black 1.0pt; border-right: solid black 1.0pt;
                    padding: 0cm 5.4pt 0cm 0pt; border-left-style: none; border-left-color: inherit;
                    border-left-width: medium; border-top-style: none; border-top-color: inherit;
                    border-top-width: medium;'>
                    <asp:RadioButtonList ID="write2013" runat="server" RepeatDirection="Horizontal"
                        Height="38px" Width="280px" CssClass="style110">
                        <asp:ListItem>优秀</asp:ListItem>
                        <asp:ListItem>良好</asp:ListItem>
                        <asp:ListItem Selected="True">一般</asp:ListItem>
                        <asp:ListItem>很差</asp:ListItem>
                     </asp:RadioButtonList>
                </td>
                <td colspan="1" style='border-bottom: solid black 1.0pt; border-right: solid black 1.0pt;
                    padding: 0cm 5.4pt 0cm 5.4pt; border-left-style: none; border-left-color: inherit;
                    border-left-width: medium; border-top-style: none; border-top-color: inherit;
                    border-top-width: medium;' class="style125" >
                    语言<br />表达<br />
                    能力
                </td>
                <td colspan="2" style='border-bottom: solid black 1.0pt; border-right: solid black 1.0pt;
                    padding: 0cm 5.4pt 0cm 5.4pt; border-left-style: none; border-left-color: inherit;
                    border-left-width: medium; border-top-style: none; border-top-color: inherit;
                    border-top-width: medium;'>
                    <asp:RadioButtonList ID="yuyan2013" runat="server" RepeatDirection="Horizontal"
                        Height="16px" Width="250px" CssClass="style109">
                        <asp:ListItem>优秀</asp:ListItem>
                        <asp:ListItem Selected="True">中等</asp:ListItem>
                        <asp:ListItem>中下</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr style='height: 25.75pt'>
                <td style='border-left: 1.0pt solid black; border-right: 1.0pt solid black; border-bottom: 1.0pt solid black;
                    padding: 0cm 5.4pt; border-top-style: none; border-top-color: inherit; border-top-width: medium;'
                   >
                   
                   应<br />
                    聘<br />
                    职<br />
                    位<font color="red" >*</font>

                </td>
                <td colspan="6" style='border-bottom: solid black 1.0pt; border-right: solid black 1.0pt;
                    padding: 0cm 5.4pt 0cm 0pt; height: 25.75pt; border-left-style: none; border-left-color: inherit;
                    border-left-width: medium; border-top-style: none; border-top-color: inherit;
                    border-top-width: medium;'>
                    <asp:RadioButtonList ID="zhiwei2013" runat="server" 
                        RepeatDirection="Horizontal" Width="400px">
                        <asp:ListItem>编辑记者</asp:ListItem>
                        <asp:ListItem>综合办公人员</asp:ListItem>
                        <asp:ListItem>美术编辑</asp:ListItem>
                        <asp:ListItem>程序员</asp:ListItem>
                    </asp:RadioButtonList>
                  <font size="2"  color="red"><asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="不能为空！"
                            ControlToValidate="zhiwei2013"></asp:RequiredFieldValidator></font>
                </td>
            </tr>
            <tr>
                <td colspan="7" 
                    style='border-left: 1.0pt solid black; border-right: 1.0pt solid black;
                    border-bottom: 1.0pt solid black; background: #F7F7FF; padding: 0cm 5.4pt; border-top-style: none; border-top-color: inherit; border-top-width: medium;' 
                    class="style121">
                    <p class="MsoNormal" align="center" style='margin-left: 21.0pt; text-align: center;
                        text-indent: -15.35pt; height: 15px; width: 665px;'>
                        <span lang="EN-US" style='font-family: Symbol'>
                            <img alt="*" height="15" src="../images/baoming2.gif" width="15" /><span style='font: 7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;
                            </span></span><b><span style='font-size: 12.0pt; font-family: 宋体'>应聘条件</span></b></p>
                </td>
            </tr>
            <tr>
                <td colspan="2" style='border-left: 1.0pt solid black; border-right: 1.0pt solid black;
                    border-bottom: 1.0pt solid black; padding: 0cm 5.4pt; border-top-style: none;
                    border-top-color: inherit; border-top-width: medium;' >
                    <asp:Label ID="Label20" runat="server" Text="Label">每周空闲时间</asp:Label>
               
                    <br />  <font size="2">（2小时/次）</font>
               
                   
                <td colspan="1" style='border-bottom: solid black 1.0pt; border-right: solid black 1.0pt;
                    padding: 0cm 5.4pt 0cm 0pt; border-left-style: none; border-left-color: inherit;
                    border-left-width: medium; border-top-style: none; border-top-color: inherit;
                    border-top-width: medium;'>
                    <asp:TextBox ID="kongxian2013" runat="server" Width="83px" class="textbox"></asp:TextBox>
                </td>
                <td colspan="2" style='border-bottom: solid black 1.0pt; border-right: solid black 1.0pt;
                    padding: 0cm 5.4pt 0cm 5.4pt; border-left-style: none; border-left-color: inherit;
                    border-left-width: medium; border-top-style: none; border-top-color: inherit;
                    border-top-width: medium;' >
                    预计在新闻网工作时间
                     
                    <br />
                    <font size="2">（以学期为单位）</font>
                </td>
                <td colspan="1" style='border-bottom: solid black 1.0pt; border-right: solid black 1.0pt;
                    padding: 0cm 5.4pt 0cm 5.4pt; border-left-style: none; border-left-color: inherit;
                    border-left-width: medium; border-top-style: none; border-top-color: inherit;
                    border-top-width: medium;' class="style94">
                    <asp:TextBox ID="work2013" runat="server" class="textbox" Width="83px"></asp:TextBox>
                </td>
                <td colspan="1" style='border-bottom: solid black 1.0pt; border-right: solid black 1.0pt;
                    padding: 0cm 5.4pt 0cm 5.4pt; border-left-style: none; border-left-color: inherit;
                    border-left-width: medium; border-top-style: none; border-top-color: inherit;
                    border-top-width: medium;' >
                    <br />是否考研<br />
                    <asp:RadioButtonList ID="kaoyan2013" runat="server" 
                        RepeatDirection="Horizontal" Height="28px" Width="112px">
                        <asp:ListItem Selected="True">是　</asp:ListItem>
                        <asp:ListItem>否</asp:ListItem>
                    </asp:RadioButtonList>
                     
                    <br />
                    
                </td>
                
            </tr>
            <tr>
                <td colspan="1" style='border-left: 1.0pt solid black; border-right: 1.0pt solid black;
                    border-bottom: 1.0pt solid black; padding: 0cm 5.4pt 0cm 5.4pt; border-top-style: none; border-top-color: inherit;
                    border-top-width: medium;' >
                   兴<br />
                    趣<br />
                    爱<br />
                    好
                <td colspan="6" style='border-bottom: solid black 1.0pt; border-right: solid black 1.0pt;
                    border-left-style: none; border-left-color: inherit; border-left-width: medium;
                    border-top-style: none; border-top-color: inherit; border-top-width: medium;'
                    class="style36">
                    <asp:TextBox ID="aihao2013" runat="server" TextMode="MultiLine" Height="112px" Width="691px"
                        class="textbox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="1" style='border-left: 1.0pt solid black; border-right: 1.0pt solid black;
                    border-bottom: 1.0pt solid black; padding: 0cm 5.4pt; border-top-style: none;
                    border-top-color: inherit; border-top-width: medium;' >
                    特长综述  <font size="2">
                    <br />
                    （填写与所报岗位有关内容）</font>
                </td>
                <td colspan="6" style='border-bottom: solid black 1.0pt; border-right: solid black 1.0pt;
                    padding: 0cm 5.4pt 0cm 0pt; border-left-style: none; border-left-color: inherit;
                    border-left-width: medium; border-top-style: none; border-top-color: inherit;
                    border-top-width: medium;' class="style50">
                    <asp:TextBox ID="techang2013" runat="server" Height="160px" Width="693px" TextMode="MultiLine"
                        Style="margin-bottom: 0px" class="textbox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="1" rowspan="2" style='border-left: 1.0pt solid black; border-right: 1.0pt solid black;
                    border-bottom: 1.0pt solid black; padding: 0cm 5.4pt 0cm 5.4pt; border-top-style: none;
                    border-top-color: inherit; border-top-width: medium;' class="style116">
                   作<br />
                    品<br />
                    展<br />
                    示
                </td>
                <td colspan="6" style='border-bottom: solid black 1.0pt; border-right: solid black 1.0pt;
                    padding: 0cm 5.4pt 0cm 5.4pt; height: 41.9pt; border-left-style: none; border-left-color: inherit;
                    border-left-width: medium; border-top-style: none; border-top-color: inherit;
                    border-top-width: medium;'>
                    <p class="MsoNormal" align="left" style='text-align: left'>
                        <b><span style='font-size: 9.0pt; font-family: 宋体'>请在此填写个人作品</span></b><span style='font-size: 9.0pt;
                            font-family: 宋体'>。获奖作品请注明获奖时间及奖项，在校内媒体发表的作品请写清标题及发布媒体栏目。原创作品打印版可与报名表一起交给现场纳新负责人，或送至网站办公室（<b>鸿远楼西</b></span><b><span
                                lang="EN-US" style='font-size: 9.0pt'>212</span></b><b><span style='font-size: 9.0pt;
                                    font-family: 宋体'>室</span></b><span style='font-size: 9.0pt; font-family: 宋体'>），</span><span
                                        lang="EN-US"><a href="mailto:电子版直接发送至lgwindow@163.com（格式：宋体，小四号，行距1.5"><span lang="EN-US"
                                            style='font-size: 9.0pt; font-family: 宋体; color: windowtext; text-decoration: none'><span
                                                lang="EN-US">电子版直接发送至</span></span><b><span style='font-size: 9.0pt; color: windowtext;
                                                    text-decoration: none'>lgwindow@163.com</span></b><span lang="EN-US" style='font-size: 9.0pt;
                                                        font-family: 宋体; color: windowtext; text-decoration: none'><span lang="EN-US">（格式：</span></span><b><span
                                                            lang="EN-US" style='font-size: 9.0pt; font-family: 宋体; color: windowtext; text-decoration: none'><span
                                                                lang="EN-US">宋体，小四号，行距</span></span></b><b><span style='font-size: 9.0pt; color: windowtext;
                                                                    text-decoration: none'>1.5</span></b></a></span><span style='font-size: 9.0pt; font-family: 宋体'>，<b>作品须注明作者姓名，学院及联系方式</b>等基本信息）</span></p>
                </td>
            </tr>
            <tr style='height: 108.3pt'>
                <td colspan="7" style='border-bottom: solid black 1.0pt; border-right: solid black 1.0pt;
                    padding: 0cm 5.4pt 0cm 0pt; border-left-style: none; border-left-color: inherit;
                    border-left-width: medium; border-top-style: none; border-top-color: inherit;
                    border-top-width: medium;' class="style90">
                    <asp:TextBox ID="zuopin2013" runat="server" TextMode="MultiLine" Height="137px" Width="692px"
                        class="textbox"></asp:TextBox>
                </td>
            </tr>
            <tr style="width: 716px">
                <td style='border: none;' class="style112">
                    注：
                </td>
                <td colspan="5" style="border: none; font-size:14px; font-family:微软雅黑;">
                    1、此表用于报名，一经录取，则作为备案，可写入个人简历；<br />
                    2、正式开始工作后，网站会定期开展培训，进行业务提高；
                </td>
            </tr>
            <tr style="width: 716px">
                <td style='border: none;' class="style112">
                </td>
                <td style='border: none'>
                </td>
                <td style='border: none' class="style122">
                </td>
                <td style='border: none'>
                 <asp:Button ID="Button2013" runat="server" Text="提交" Width="70" Height="25" 
                        onclick="Button2013_Click" />
                </td>
                <td style='border: none' class="style125" >
                   
                </td>
                <td align="left" style='border: none' class="style89">
                    <asp:Button ID="Button2" runat="server" Text="重置" Width="70" Height="25" 
                        onclick="Button2_Click" CausesValidation="False" />
                </td>
                <td style='border: none' class="style94">
                </td>
            </tr>
        </table>
    </div>
</div></div></div>
    </form>
    <div id="footer">
	<div id="f1" style="background-color:#d05600"></div>
	<div id="f2" style="background-color:#fc6e09">
		<div id="fmain1">
			<table width="100%" border="0" cellspacing="0" cellpadding="0">
				<tr>
    				<td colspan="11" height="13px">&nbsp;</td>
    			</tr>
  				<tr height="36px;">
    <td width="150">&nbsp;</td>
    <td width="100"><a href="">关于我们</a></td>
    <td width="40"><div class="n"><img src="../images/foot_s.png" border="0" /></div></td>
    <td width="100"><a href="">新闻热线</a></td>
    <td width="40"><div class="n"><img src="../images/foot_s.png" border="0" /></div></td>
    <td width="100"><a href="">在线投稿</a></td>
    <td width="40"><div class="n"><img src="../images/foot_s.png" border="0" /></div></td>
    <td width="100"><a href="">诚招英才</a></td>
    <td width="40"><div class="n"><img src="../images/foot_s.png" border="0" /></div></td>
    <td width="100"><a href="">版权声明</a></td>
    <td width="150">&nbsp;</td>
  				</tr>
  			</table>
  		</div>
  		<div style="background-image:url(images/foot_h.png); background-repeat:repeat-x; height:2px;"></div> 
  			<div id="fmain2">
				<table  width="100%" border="0" cellspacing="0" cellpadding="0">
					<tr>
						<td height="10px"></td></tr>
  					<tr>
    					<td align="center" height="20px">版权所有&nbsp;@&nbsp;山东理工大学宣传部&nbsp;&nbsp;&nbsp;&nbsp;地址：山东省淄博市张店区张周路12号</td>
    				</tr>
  					<tr>
    					<td align="center" height="20px">邮编：255049&nbsp;&nbsp;&nbsp;&nbsp;联系电话：0533-2786727&nbsp;&nbsp;&nbsp;&nbsp;Designed By&nbsp;卡瑞特工作室</td>
    				</tr>
					<tr>
    					<td height="10px">&nbsp;</td>
    				</tr>
				 </table>
			</div>
		</div>
</div>
</body>
</html>
