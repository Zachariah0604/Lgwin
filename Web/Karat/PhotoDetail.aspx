<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PhotoDetail.aspx.cs" Inherits="Lgwin.Karat.PhotoDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/style.css" type="text/css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
<div style="width:100%; height:188px; margin:auto; ">
    <iframe scrolling="no" allowtransparency="true" width="100%" height="100%" src="top.html" frameborder="0"></iframe>
</div>

<div class="Ishaohua">
<div style=" width:100%; height:78px"></div>
<div class="Itime">
<table border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td style=" width:29px"></td>
    <td style=" width:90px"><a href='KaratPhoto.aspx?ParentID=2' target='_top'>2003</a></td>
    <td style=" width:90px"><a href='KaratPhoto.aspx?ParentID=6' target='_top'>2004</a></td>
    <td style=" width:92px"><a href='KaratPhoto.aspx?ParentID=7' target='_top'>2005</a></td>
    <td style=" width:90px"><a href='KaratPhoto.aspx?ParentID=21' target='_top'>2006</a></td>
    <td style=" width:95px"><a href='KaratPhoto.aspx?ParentID=22' target='_top'>2007</a></td>
    <td style=" width:90px"><a href='KaratPhoto.aspx?ParentID=23' target='_top'>2008</a></td>
    <td style=" width:92px"><a href='KaratPhoto.aspx?ParentID=24' target='_top'>2009</a></td>
    <td style=" width:92px"><a href='KaratPhoto.aspx?ParentID=25' target='_top'>2010</a></td>
    <td style=" width:92px"><a href='KaratPhoto.aspx?ParentID=26' target='_top'>2011</a></td>
    <td style=" width:89px"><a href='KaratPhoto.aspx?ParentID=27' target='_top'>2012</a></td>
    <td><a href='KaratPhoto.aspx?ParentID=28' target='_top'>2013</a></td>
  </tr>
</table>
</div>
</div>

<asp:Repeater ID="picdetail" runat="server"><ItemTemplate>
   <div class="Ipicture">
       <div class="IBpic"><img src='<%#DataBinder.Eval(Container.DataItem, "ImgUrl") %>' border="0" width="700px" /></div>
       <div class="Ipicfen"><div class="Ipictitle"><%#DataBinder.Eval(Container.DataItem, "ImgName") %>&nbsp;&nbsp;&nbsp;&nbsp;(<span id="Icolor"><%#DataBinder.Eval(Container.DataItem,"ClickCount") %></span>次浏览 )</div><div class="Ifenx"><div class="tsfx">
			<div class="bshare-custom icon-medium-plus"><a title="分享到QQ好友" class="bshare-qqim"></a><a title="分享到QQ空间" class="bshare-qzone"></a><a title="分享到新浪微博" class="bshare-sinaminiblog"></a><a title="分享到人人网" class="bshare-renren"></a><a title="分享到腾讯微博" class="bshare-qqmb"></a><a title="分享到网易微博" class="bshare-neteasemb"></a><a title="更多平台" class="bshare-more bshare-more-icon more-style-addthis"></a><span class="BSHARE_COUNT bshare-share-count">0</span></div><script type="text/javascript" charset="utf-8" src="http://static.bshare.cn/b/buttonLite.js#style=-1&amp;uuid=&amp;pophcol=3&amp;lang=zh"></script><script type="text/javascript" charset="utf-8" src="http://static.bshare.cn/b/bshareC0.js"></script>
		</div></div></div>
</div>
</ItemTemplate></asp:Repeater>


<div class="Ily">
<div style="width:100%; height:54px"><!--用来顶格--></div>
<div id="Inicheng"><asp:TextBox ID="nic" runat="server" Height="17px" 
        Width="168px"></asp:TextBox><span id="Inum"></div>
<div id="Ipinglun">
    <asp:TextBox ID="pinl" runat="server" Height="62px" TextMode="MultiLine" 
        Width="683px">请输入评论内容</asp:TextBox></div>
<div id="Ibiaoqing"></div>
<div id="Ibutton">
    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="images/out.gif" OnClick="ImageButton1_Click" />
    </div>
</div>

<div class="Ireply">
<div style="font-family:@黑体; font-size:20px; padding-left:141px; font-weight:bold; padding-top:20px; height:39px">最新评论</div>
    <asp:Repeater ID="PhtotComment" runat="server"><ItemTemplate>
<div class="Iguanshui">
<table width="716px">
    <tr>
       <td style="width:20px"><img src="images/r.gif" /></td>
       <td colspan="2" style=" font-family:@宋体; font-size:16px; color:#666768; height:26px"><%#DataBinder.Eval(Container.DataItem,"nicheng") %>&nbsp;&nbsp;&nbsp;&nbsp;[<%#DataBinder.Eval(Container.DataItem,"time", "{0:yyyy-MM-dd}") %>]</td>
    </tr>
    <tr>
       <td></td>
       <td colspan="2" style="font-family:@宋体; font-size:16px; color:#2b2b2b; height:68px"><%#DataBinder.Eval(Container.DataItem,"content") %></td>
    </tr>
    
</table>
</div>
    </ItemTemplate></asp:Repeater>



</div>

<div id="footer" style="float:left;">
        <div id="f1" style="background-color:#d05600"></div>
        <div id="f2" style="background-color:#fc6e09">
            <div id="fmain1">
                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                        <td colspan="11" height="13px">&nbsp;</td>
                    </tr>
                    <tr height="36px;">
                        <td width="150">&nbsp;</td>
    <td width="100"><a href="http://lgwindow.sdut.edu.cn/News/26263.html" target="_blank">关于我们</a></td>
    <td width="40"><div class="n"><img src="images/foot_s.png" border="0" /></div></td>
    <td width="100"><a href="http://lgwindow.sdut.edu.cn/News/26262.html" target="_blank">新闻热线</a></td>
    <td width="40"><div class="n"><img src="images/foot_s.png" border="0" /></div></td>
    <td width="100"><a href="http://lgwindow.sdut.edu.cn/TouGao/TouGao.aspx" target="_blank">在线投稿</a></td>
    <td width="40"><div class="n"><img src="images/foot_s.png" border="0" /></div></td>
    <td width="100"><a href="http://lgwindow.sdut.edu.cn/karat/" target="_blank">诚招英才</a></td>
    <td width="40"><div class="n"><img src="images/foot_s.png" border="0" /></div></td>
    <td width="100"><a href="http://lgwindow.sdut.edu.cn/News/26264.html" target="_blank">版权声明</a></td>
    <td width="150">&nbsp;</td>
                    </tr>
                </table>
            </div>
            <div style="background-image:url(images/foot_h.png); background-repeat:repeat-x; height:2px;"></div>
            <div id="fmain2">
                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                        <td height="10px"></td>
                    </tr>
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
    </form>
</body>
</html>
