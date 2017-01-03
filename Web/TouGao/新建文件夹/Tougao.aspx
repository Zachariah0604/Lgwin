<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TouGao2.aspx.cs" Inherits="Lgwin.TouGao.TouGao" %>

<%@ Register Assembly="CuteEditor" Namespace="CuteEditor" TagPrefix="CE" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>山东理工大学新闻网-在线投稿</title>
    <style type="text/css">
        body
        {
            border: 0px;
            color: #666;
            margin: 0;
            padding: 0;
            font-family: "宋体";
            font-size: 14px;
            font-weight: 400;
            background-image: url(images/tougao_bg.jpg);
            background-repeat: repeat-x;
        }
        a:link
        {
            color: #999;
            text-decoration: none;
        }
        a:visited
        {
            text-decoration: none;
            color: #666;
        }
        a:hover
        {
            text-decoration: none;
            color: #8dae27;
        }
        a:active
        {
            text-decoration: none;
            color: #999;
        }
        #box
        {
            width: 1000px;
            margin: 0 auto;
        }
        #top_serach
        {
            height: 28px;
            width: 1000px;
            line-height: 28px;
            background-color:#f7faeb;
        }
        #toppic
        {
            height: 184px;
            width: 1000px;
            background-image: url(images/top_pic.jpg);
            background-repeat: no-repeat;
            background-position: top;
        }
        #dh
        {
            height: 54px;
            background-image: url('images/fast_dh.jpg');
            background-repeat: no-repeat;
            background-position: 50% top;
            background-position:left;
            padding-top: 0px;
            padding-bottom: 10px;
            width: 1000px;
        }
        #text_top
        {
            height: 148px;
        }
        #text_bottom
        {
            height: 710px;
            background-image: url(images/bottom_bk.jpg);
            background-repeat: no-repeat;
        }
        #bottom
        {
            margin-top: 8px;
            margin-bottom: 20px;
            height: 84px;
            background-image: url(images/bottom_bg.jpg);
        }
        #text_top_left
        {
            height: 148px;
            width: 763px;
            background-image: url('images/text_01_left.jpg');
            float: left;
            background-repeat:no-repeat;
        }
        #text_top_right
        {
            height: 148px;
            width: 237px;
            float: right;
            background-image: url(images/text_01_right.jpg);
            background-position:top;
            background-repeat:no-repeat;
            background-position:left;
        }
        #text_top_right_text
        {
            margin-top: 5px;
            margin-left: 5px;
            margin-right: 0px;
            margin-bottom: 5px;
            height: 146px;
            line-height: 22px;
            color: #C00;
            font-family: "宋体";
            font-size: 13px;
            font-weight: 400;
            width: 232px;
        }
        #text_bottom_left
        {
            height: 707px;
            width: 758px;
            float: left;
        }
        #text_bottom_right
        {
            height: 710px;
            width: 237px;
            float: right;
            background-image: url(images/text_02_right.jpg);
            margin-top:2px;
            background-repeat:no-repeat;
        }
        #text_bottom_right_text
        {
            margin-top: 0px;
            margin-left: 5px;
            margin-right: 12px;
            margin-bottom: 0px;
            line-height: 22px;
            font-family: "宋体";
            font-size: 12px;
            font-weight: 400;
        }
        #dh_text
        {
            width: 999px;
            height: 58px;
        }
        #text_text_text
        {
            height: 637px;
            margin-top: 0px;
            margin-left: 0px;
            margin-right: 0px;
            width: 757px;
        }
        #text_text_bianji
        {
            height: 32px;
            margin-top: 12px;
            margin-left: 16px;
            margin-right: 6px;
            line-height: 32px;
            border: #C2D9B1 1px solid;
            width: 730px;
        }
        #bt
        {
            background-image: url(images/bt.jpg);
            background-repeat: no-repeat;
            background-position:center;
        }
         #shouye
         {
             background-image: url(images/shouye.jpg);
             background-repeat: no-repeat;
             background-position:center;
         }
         #butoombg2
         {
            background-image: url(images/bottombg2.jpg); 
         }
         #top1
         {
             height: 22px;
             background-color:#f7faeb;
             vertical-align:text-top;
             line-height:22px;
         }   
        .style1
        {
            color: #C00;
        }
        .style2
        {
            width: 98px;
        }
        .style3
        {
            width: 84px;
        }

        .style4
        {
            width: 64px;
        }

        </style>
</head>
<script language="javascript" type="text/javascript">
    function empty() {
        document.getElementById("txt1").value = "";
    }
    function txt1_onclick() {

    }

</script>
<body>
    <form id="form1" runat="server">
    <div id="box">
    <iframe src="top.htm" width="1000px" height="22" scrolling="No" frameborder="0" ></iframe>
        <div id="toppic">
        </div>
        <div id="dh">
            <div id="dh_text">
                <table cellpadding="0" cellspacing="0" border="0" height="58" 
                    style="width: 999px">
                    <tr height="26" style="line-height: 26px;">
                        <td class="style3">
                            &nbsp;
                        </td>
                        <td>
                            <table cellpadding="0" cellspacing="0" border="0" height="26">
                                <tr align="center">
                                    <td width="85" align="center">
                                        <a href="http://lgwindow.sdut.edu.cn/" target="_self"><font color="#000000">新 闻 网</font></a>：
                                    </td>
                                    <td align="center" id="shouye" class="style4">
                                        <a href="http://lgwindow.sdut.edu.cn/" target="_self">首页</a>
                                    </td>
                                    <td width="88" id="bt">
                                        <a href="http://lgwindow.sdut.edu.cn/News/1_1.html" target="_self">理工要闻</a>
                                    </td>
                                    <td width="88" id="bt">
                                        <a href="http://lgwindow.sdut.edu.cn/News/2_1.html" target="_self">院部传真</a>
                                    </td>
                                    <td width="88" id="bt">
                                        <a href="http://lgwindow.sdut.edu.cn/News/3_1.html" target="_self">教学科研</a>
                                    </td>
                                    <td width="88" id="bt">
                                        <a href="http://lgwindow.sdut.edu.cn/News/7_1.html" target="_self">理工人物</a>
                                    </td>
                                    <td width="88" id="bt">
                                        <a href="http://lgwindow.sdut.edu.cn/News/5_1.html" target="_self">学生工作</a>
                                    </td>
                                    <td width="88" id="bt">
                                        <a href="http://lgwindow.sdut.edu.cn/topic/xuefengjianshe/index.html" target="_self">
                                            学风建设</a>
                                    </td>
                                    <td width="88" id="bt">
                                        <a href="http://lgwindow.sdut.edu.cn/photo/index.html" target="_self">光影理工</a>
                                    </td>
                                    <td width="88" id="bt">
                                        <a href="http://lgwindow.sdut.edu.cn/News/9_1.html" target="_self">资讯公告</a>
                                    </td>
                                    <td width="88" id="bt">
                                        <a href="http://lgwindow.sdut.edu.cn/map/" target="_self">虚拟校园</a>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr height="26" style="line-height: 26px;">
                        <td class="style3">
                            &nbsp;
                        </td>
                        <td>
                        <table cellpadding="0" cellspacing="0" border="0" height="26">
                                <tr align="center">
                                    <td width="85" align="center">
                                        <a href="../Campus/index.html" target="_self"><font color="#000000">校园文化</font></a>：
                                    </td>
                                    <td align="center" id="shouye" class="style4">
                                        <a href="../Campus/index.html" target="_self">首页</a></td>
                                    <td width="88" id="bt">
                                        <a href="../Campus/News/1_1.html" target="_self">名家讲坛</a>
                                    </td>
                                    <td width="88" id="bt">
                                        <a href="../Campus/News/2_1.html" target="_self">菁菁校园</a>
                                    </td>
                                    <td width="88" id="bt">
                                        <a href="../Campus/News/3_1.html" target="_self">稷下时评</a>
                                    </td>
                                    <td width="88" id="bt">
                                        <a href="../Campus/News/4_1.html" target="_self">人物访谈</a>
                                    </td>
                                    <td width="88" id="bt">
                                        <a href="../Campus/News/200_1.html" target="_self">原创视频</a>
                                    </td>
                                    <td width="88" id="bt">
                                        <a href="../Campus/News/100_1.html" target="_self">经典视频</a>
                                    </td>
                                    <td width="88" id="bt">
                                        <a href="../Campus/News/6_1.html" target="_self">文学原创</a>
                                    </td>
                                    <td width="88" id="bt">
                                        <a href="../Campus/News/7_1.html" target="_self">生活视界</a>
                                    </td>
                                    <td width="88" id="bt">
                                        <a href="../Campus/News/300_1.html" target="_self">E路同行</a>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </div></div>
        <div id="text_top">
            <div id="text_top_left">
                <table width="100%" cellpadding="0" cellspacing="0" border="0" style="margin-top: 5px;
                    height: 146px;">
                    <tr height="36" style="line-height: 36px;">
                        <td>
                            &nbsp;<span class="style1">*</span>&nbsp;所属分类：&nbsp;<asp:DropDownList ID="bigclass" runat="server" Width="90" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"
                                AutoPostBack="true">
                                <asp:ListItem>校园文化</asp:ListItem>
                                <asp:ListItem Selected="True">新闻网</asp:ListItem>
                                <asp:ListItem>光影理工</asp:ListItem>
                            </asp:DropDownList>
                            &nbsp;
                            <asp:DropDownList ID="smallclass" runat="server" Width="90">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr height="36" style="line-height: 36px;">
                        <td>
                            <asp:Panel ID="Panel4" runat="server">
                                &nbsp;<span class="style1">*</span>&nbsp;标&nbsp;&nbsp;&nbsp;&nbsp;题:
                                <asp:TextBox ID="title" runat="server" Width="400"></asp:TextBox>
                                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"
                                    ControlToValidate="title" ForeColor="red"></asp:RequiredFieldValidator>
                            </asp:Panel>
                        </td>
                    </tr>
                    <tr height="36" style="line-height: 36px;">
                        <td>
                            <asp:Panel ID="Panel5" runat="server">
                                &nbsp; &nbsp;副&nbsp;标&nbsp;题：<asp:TextBox ID="subtitle" runat="server" Width="400"></asp:TextBox>
                            </asp:Panel>
                        </td>
                    </tr>
                    <tr height="36">
                        <td class="style2">
                            <asp:Panel ID="Panel3" runat="server" Height="36px" Width="761px">
                                <div style=" line-height:36px;">
                                    &nbsp;<span class="style1">*</span>&nbsp;作&nbsp;&nbsp;&nbsp;&nbsp;者：<asp:TextBox
                                        ID="author" runat="server"></asp:TextBox>
                                    &nbsp;&nbsp;<span class="style1">*</span> 来源：<asp:DropDownList ID="from_to" runat="server"
                                        Width="160">
                                    </asp:DropDownList>
                                    &nbsp; <span class="style1">*</span>&nbsp;电话：<asp:TextBox ID="tel" runat="server"></asp:TextBox>
                                    &nbsp;</div>
                            </asp:Panel>
                        </td>
                    </tr>
                </table>
            </div>
            <div id="text_top_right">
                <div id="text_top_right_text">
                    　<font>　　　【温馨提示】<br /></font>
                    &nbsp;&nbsp; 来稿图片请以数字或字母命名，<br /> &nbsp;建议图片不低于500*375px，光影<br />&nbsp;理工投稿图片建议宽度800px，通&nbsp;&nbsp;<br /> &nbsp;过正确途径上传图片。<br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 带"*"项为必填项。
                </div>
            </div>
        </div>
        <div id="text_bottom">
            <div id="text_bottom_left">
                <table style="height: 710px; width: 758px; margin-right: 0px;">
                    <tr>
                        <td height="637" valign="top">
                            <div id="text_text_text">
                                <asp:Panel ID="Panel1" runat="server">
                                    <CE:Editor ID="conte" runat="server" ThemeType="Office2007" Height="639px" FilesPath="CuteSoft_Client/CuteEditor/"
                                        SecurityPolicyFile="Guest.config" Width="100%" OnTextChanged="conte_TextChanged"
                                        Style="margin-bottom: 0px; margin-left: 0px;">
                                    </CE:Editor>
                                </asp:Panel>
                                <asp:Panel ID="Panel7" runat="server">
                                    <CE:Editor ID="Editor1" runat="server" Height="639px" FilesPath="CuteSoft_Client/CuteEditor/"
                                        SecurityPolicyFile="CampusGuest.config" Width="100%" 
                                        >
                                    </CE:Editor>
                                </asp:Panel>
                                <asp:Panel ID="Panel2" runat="server">
                                    <table width="100%">
                                        <tr align="center">
                                            <td>
                                                图片名称：
                                                <asp:TextBox ID="TextBox_name" runat="server"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*"
                                                    ControlToValidate="TextBox_name" ForeColor="red"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr align="center">
                                            <td>
                                                摄影作者：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr align="center">
                                            <td>
                                                分类：
                                                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource2"
                                                    DataTextField="name" DataValueField="ID">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr align="center">
                                            <td>
                                                说明：
                                                <asp:TextBox ID="TextBox2" runat="server" Height="140px" TextMode="MultiLine" Width="382px"></asp:TextBox><asp:RequiredFieldValidator
                                                    ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="TextBox2"
                                                    ForeColor="red"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr align="center">
                                            <td>
                                                <asp:FileUpload ID="FileUpload1" runat="server" Width="191px" />&nbsp;&nbsp;
                                                <asp:TextBox ID="TextBox_w" runat="server" Text="800" Width="60"></asp:TextBox>
                                                宽度
                                            </td>
                                        </tr>
                                        <tr align="center">
                                            <td>
                                                <br />
                                                <br />
                                                <br />
                                                <br />
                                                <asp:Button ID="Button2" runat="server" Text="提交" OnClick="Button2_Click" />
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                            </div>
                        </td>
                    </tr>
                    <tr style="height: 30px; line-height: 30px; text-align: center;">
                        <td id="butoombg2">
                            <asp:Panel ID="Panel6" runat="server" Height="29px" Width="746px">
                                <asp:Button ID="Button1" runat="server" Text="提交投稿" BorderColor="white" ForeColor="#3f3f3f" BackColor="#E6E6E6" Font-Bold="false" BorderWidth="0"
                                     OnClick="Button1_Click" />
                            </asp:Panel>
                        </td>
                    </tr>
                </table>
            </div>
            <div id="text_bottom_right">
                <div id="text_bottom_right_text">
                   <span class="style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<font color="#000000">　　　【投稿说明】</font></span><br />
                    <span class="style1"><font color="#000000">　1.所有来稿须保证作者原创,不得抄袭,否则后果自负。</br>　2.在上传来稿文章时请尽量使用纯文本粘贴。<br />
                        　3.来稿尽量使用一句话标题，极特殊情况可用副标题,副标题粘贴时不需使用破折号,后台自动生成。<br />
                        　4.请认真选择文章属性,例如：院系新闻请选择"院部传真",言论类文章、散文等请选"校园文化"。<br />
                        　5.来稿中若附带图片请以数字或字母命名，建议图片不低于500x375px，光影理工投稿图片建议宽度800px，通过正确途径上传图片。</font></span><font color="#000000"><a href="图片上传方法.doc"><font
                            color="#CC6600">（图片上传方法)</font></a><br />
                    <span class="style1">　<font color="#000000">6.请认真填写"来源"及"电话"以便出现问题时我们能够及时与您取得联系。
                        <br />
                        　7.若投稿系统出现问题，请随时与我们联系，也可将稿件直接发送至新闻网邮箱：</span><font color="#CC6600">lgwindow@163.com。</font><br />
                    <br />
                    &nbsp;&nbsp;&nbsp;<span class="style1">&nbsp; <font color="#000000">办公电话：0533-2786727<br />
                        &nbsp;&nbsp;&nbsp;&nbsp;办公地址：鸿远楼西212室<br />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;最后，感谢您对理工大新闻网的关注与支持!</span></font><br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <a href="http://lgwindow.sdut.edu.cn/"><font color="#86a318">山东理工大学新闻网</font></a><br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                    <img src="images/karat_logo.jpg" width="13" height="13" /><a href="http://lgwindow.sdut.edu.cn/Karat/index.html"><font color="#86a318">卡瑞特工作室</font></a></div>
            </div>
        </div>
        <div id="bottom">
            <div style="background-image: url(images/bottom_bg.jpg); background-repeat: no-repeat;
                width: 996px; height: 83px;">
                <div style="width: 383px; height: 26px; margin-left: 310px; padding-top: 8px; font-family: '宋体';
                    font-size: 13px; margin-top: 3px; text-align: center">
                    <table>
                        <tr>
                            <td width="120">
                                <a href="http://lgwindow.sdut.edu.cn/karat/">关于我们</a>
                            </td>
                            <td>
                                <img src="images/lines.jpg" />
                            </td>
                            <td width="120">
                                <a href="http://lgwindow.sdut.edu.cn/TouGao/TouGao.aspx">新闻热线</a>
                            </td>
                            <td>
                                <img src="images/lines.jpg" />
                            </td>
                            <td width="120">
                                <a href="http://lgwindow.sdut.edu.cn/TouGao/TouGao.aspx">在线投稿</a>
                            </td>
                            <td>
                                <img src="images/lines.jpg" />
                            </td>
                            <td width="120">
                                <a href="http://lgwindow.sdut.edu.cn/Karat/recruitment.html">
                                   诚招英才</a>
                            </td>
                            <td>
                                <img src="images/lines.jpg" />
                            </td>
                            <td width="120">
                                <a href="javascript:window.external.AddFavorite(location.href, document.title);">加入收藏</a>
                            </td>
                        </tr>
                    </table>
                </div>
                <div style="text-align: center; font-family: '宋体'; font-size: 12px; color: #003;
                    margin-top: 9px;">
                    版权所有©<a href="http://lgwindow.sdut.edu.cn/" style="color: #003;">山东理工大学新闻中心</a>
                    <a href="http://lgwindow.sdut.edu.cn/" style="color: #003">新闻网</a> 地址：山东省淄博市张店区张周路12号</div>
                <div style="text-align: center; font-family: '宋体'; font-size: 12px; color: #003;
                    margin-top: 5px;" id="karat">
                    邮编：255049 联系电话:0533-2786727 Designed by
                    <img src="images/karat_logo.jpg" width="13" height="13" /><a href="http://lgwindow.sdut.edu.cn/karat/">卡瑞特工作室</a></div>
            </div>
        </div>
    </div>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConStr %>"
        SelectCommand="SELECT * FROM [Photo_zhtfenlei] WHERE (([id] = @id1)or ([id] = @id) or ([id] = @id2)or ([id] = @id3))">
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
