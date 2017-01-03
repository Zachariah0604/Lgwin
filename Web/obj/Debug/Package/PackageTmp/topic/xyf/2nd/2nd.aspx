<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2nd.aspx.cs" Inherits="Lgwin.topic.xyf._2nd._2nd" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" type="text/css" href="../css/xiaoyuanfeng.css" />
    <link rel="stylesheet" type="text/css" href="../css/xixi.css">
  <link rel="stylesheet" href="../css/lightbox.css" type="text/css" media="screen" />
    <script src="../js/prototype.js" type="text/javascript"></script>
    <script src="../js/scriptaculous.js?load=effects" type="text/javascript"></script>
    <script src="../js/lightbox.js" type="text/javascript"></script>
    <script>
        function addfavorite() {
            if (document.all) {
                window.external.addFavorite('http://lgwindow.sdut.edu.cn', '山东理工大学新闻网');
            }
            else if (window.sidebar) {
                window.sidebar.addPanel('山东理工大学新闻网', 'http://lgwindow.sdut.edu.cn', "");
            }
        } 
        </script>
        <style type="text/css">
            table
            {
                table-layout:fixed;
                }
                td{word-break: break-all; word-wrap:break-word;font-size:14px; text-indent:2em; word-spacing:3px;}
    </style>
    <title>校园风</title>
</head>
<body>
    <form runat="server" id="form1">
    <div id="all">
        <div id="top">
            <div id="daohang">
                <div id="daohang_1">
                    <a href="http://lgwindow.sdut.edu.cn/campus/topic/xiaoyuanfeng6/" target="_blank">
                        <img src="../images/shouye.png" onmouseover="this.src='../images/shouye1.png'" onmouseout="this.src='../images/shouye.png'" /></a></div>
                <div id="daohang_2">
                    <a href="http://lgwindow.sdut.edu.cn/Campus/News/2_1.html" target="_blank">
                        <img src="../images/zhengwen.png" onmouseover="this.src='../images/zhengwen1.png';document.getElementById('zhengwen_more').style.visibility='visible'"
                            onmouseout="this.src='../images/zhengwen.png';document.getElementById('zhengwen_more').style.visibility='hidden'" /></a></div>
                <div id="daohang_3">
                    <a href="#" target="_blank">
                       <img src="../images/sheying.png" onmouseover="this.src='../images/sheying1.png'" onmouseout="this.src='../images/sheying.png'" /></a></div>
                <div id="daohang_4">
                    <a href="#" target="_blank">
                        <img src="../images/zhizuo.png" onmouseover="this.src='../images/zhizuo1.png'" onmouseout="this.src='../images/zhizuo.png'" /></a></div>
            </div>
           
        </div>
        <div style="position: relative; height: 1px; width: 1000px; overflow: visible; top: 0px; left: 0px;">
            <div id="zhengwen_more" onmouseover="this.style.visibility='visible'" onmouseout="font-family:'宋体'; this.style.visibility='hidden'"
                style="position: absolute; width: 250px; height: 20px; line-height: 20px; font-size: 14px;
                right: 145px; visibility: hidden;">
                <a href="http://lgwindow.sdut.edu.cn/Campus/News/2_1.html" target="_blank">追踪报道</a> <a href="http://lgwindow.sdut.edu.cn/Campus/News/7_1.html" target="_blank">视点杂谈</a> <a href="http://lgwindow.sdut.edu.cn/Campus/News/4_1.html"
                    target="_blank">人物通讯</a> <a href="http://lgwindow.sdut.edu.cn/Campus/News/6_1.html" target="_blank">美文欣赏</a>
            </div>
        </div>
         <div><img src="../images/lanmu_bg.jpg" /></div>
        <div id="body_bg" style="background-image: url(../images/2ndbody_bg.jpg); width: 1000px;
            height:960px; background-repeat: no-repeat;margin: 0px auto;padding-top:10px;">
                 <div style="margin: 44px auto  0 64px; width: 930px; height: 470px">
                <asp:Repeater ID="zhanhu" runat="server">
                    <ItemTemplate>
                        <div style="margin: 2px auto  0 1%; width: 49%; height: 33%; float: left;">
                            <div style="margin: 0px auto  0 5px; width: 150px; height: 155px; float: left;">
                                <a href="../../../<%#geturl(DataBinder.Eval(Container.DataItem, "Contents").ToString())%>"
                                    target="_blank" title=" <table ><tr><td colspan=2><font size=2><%#Mystring.DelHTML(DataBinder.Eval(Container.DataItem, "Contents").ToString())%></font></td></tr><tr> <td ><Font color=#D988BA size=2 >作者:<%#DataBinder.Eval(Container.DataItem, "Author").ToString()%></Font></td > </tr></table>"
                                    rel="lightbox[roadtrip]">
                                    <img src="../../../<%#geturl(DataBinder.Eval(Container.DataItem, "Contents").ToString())%>"
                                        title="作者:<%#DataBinder.Eval(Container.DataItem, "Author").ToString()%>" alt="作者:<%#DataBinder.Eval(Container.DataItem, "Author").ToString()%>"
                                        width="148" height="148" border="0" /></a>
                            </div>
                            <div style="margin: 4px auto 0 13px; width: 270px; height: 144px; float: left; line-height: 26px;
                                font-size: 16px;">
                                <table width="100%">
                                    <tr>
                                        <td>
                                           <font size="3"  style=" font-weight: 700">设计说明:</font><%#Mystring.lim_withoutPoint(Mystring.DelHTML(DataBinder.Eval(Container.DataItem, "Contents").ToString()), 65)%>
                                        </td>
                                    </tr>
                                    <tr><td align="right">  <a href="../../../<%#geturl(DataBinder.Eval(Container.DataItem, "Contents").ToString())%>"
                                    target="_blank" title=" <table ><tr><td colspan=2><font size=2><%#Mystring.DelHTML(DataBinder.Eval(Container.DataItem, "Contents").ToString())%></font></td></tr><tr> <td ><Font color=#D988BA size=2 >作者:<%#DataBinder.Eval(Container.DataItem, "Author").ToString()%></Font></td > </tr></table>"
                                    rel="lightbox[roadtrip]"> <font style=" font-weight:700; color:#E39438">详细</font></a></td></tr>
                                </table>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            <div style="width: 50%; margin: 0 auto; font-size: 12px; height: auto;" runat="server" id="danghao">
                <asp:Label ID="Labeldang" runat="server" Text="第"></asp:Label>
                <asp:Label ID="labPage" runat="server" Text="1"></asp:Label>
                   <asp:Label ID="Label2" runat="server" Text="页"></asp:Label>,
                <asp:Label ID="Labelcount" runat="server" Text="共"></asp:Label>
                <asp:Label ID="labBackPage" runat="server" Text="labBackPage"></asp:Label>
                 <asp:Label ID="Label3" runat="server" Text="张"></asp:Label>，
                <asp:LinkButton ID="lnkbtnOne" runat="server" OnClick="lnkbtnOne_Click" Font-Underline="False">首张</asp:LinkButton>
                <asp:LinkButton ID="lnkbtnUp" runat="server" OnClick="lnkbtnUp_Click" Font-Underline="False">上一张</asp:LinkButton>
                <asp:LinkButton ID="lnkbtnNext" runat="server" OnClick="lnkbtnNext_Click" Font-Underline="False">下一张</asp:LinkButton>
                <asp:LinkButton ID="lnkbtnBack" runat="server" OnClick="lnkbtnBack_Click" Font-Underline="False">尾张</asp:LinkButton>
                <asp:Label ID="Label1" runat="server" Text="" Visible="false"></asp:Label>
            </div>
       
                     <link rel="stylesheet" href="../css/lightbox.css" type="text/css" media="screen" />
    <script src="../js/prototype.js" type="text/javascript"></script>
    <script src="../js/scriptaculous.js?load=effects" type="text/javascript"></script>
    <script src="../js/lightbox.js" type="text/javascript"></script>
                <%--</ContentTemplate>
            </asp:UpdatePanel>--%>
           <%--  <asp:UpdatePanel ID="UpdatePanel2" runat="server">
             
          <ContentTemplate>  --%>
         <div style="margin: 0px auto  0 64px; width: 930px; height: 400px">
                        <asp:Repeater ID="zhanqi" runat="server">
                            <ItemTemplate>
                                <div style="margin: 2px auto  0 1%; width: 49%; height: 33%; float: left;">
                                    <div style="margin: 8px auto  0 0px; width: 165px; height: 110px; float: left;">
                                        <a href="../../../<%#geturl(DataBinder.Eval(Container.DataItem, "Contents").ToString())%>"
                                            target="_blank" title="<table width=100%  ><tr><td colspan=2><font size=2><%#Mystring.DelHTML(DataBinder.Eval(Container.DataItem, "Contents").ToString())%></font></td></tr><tr> <td ><Font color=#D988BA size=2 >作者:<%#DataBinder.Eval(Container.DataItem, "Author").ToString()%></Font></td > </tr></table>"
                                            rel="lightbox[roadtrip]">
                                            <img src="../../../<%#geturl(DataBinder.Eval(Container.DataItem, "Contents").ToString())%>"
                                                title="作者:<%#DataBinder.Eval(Container.DataItem, "Author").ToString()%>" alt="作者:<%#DataBinder.Eval(Container.DataItem, "Author").ToString()%>"
                                                width="164" height="105" border="0" /></a>
                                    </div>
                                    <div style="margin: 3px auto 8px; width: 270px; height: 130px; float: left; line-height: 22px;
                                        font-size: 16px;">
                                        <table width="100%">
                                            <tr>
                                                <td>
                                                  <font size="3" style=" font-weight: 700">设计说明:</font><%#Mystring.lim_withoutPoint(Mystring.DelHTML(DataBinder.Eval(Container.DataItem, "Contents").ToString()), 75)%></td><td>详细</td>
                                            </tr>
                                        </table>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                    <div style="width: 50%; margin: 0 auto; font-size: 12px; height: auto;">
                        <webdiyer:AspNetPager runat="server" ID="zhanqipager" CustomInfoHTML="第%CurrentPageIndex%张，共%PageCount%张，每张%PageSize%条"
                            FirstPageText="首张" LastPageText="尾张" NextPageText="下一张" PrevPageText="上一张" ShowCustomInfoSection="Left"
                            OnPageChanging="zhanqipager_PageChanging" PageSize="6">
                        </webdiyer:AspNetPager>
                    </div>
          <%--  </ContentTemplate>--%>
      <%--  </asp:UpdatePanel>--%>
        </div>
        <div id="footer">
            <span><a href="http://lgwindow.sdut.edu.cn/News/26263.html" target="_blank">关于我们</a></span>
            <span><a href="http://lgwindow.sdut.edu.cn/News/26262.html" target="_blank">新闻热线</a></span>
            <span><a href="http://lgwindow.sdut.edu.cn/TouGao/TouGao.aspx" target="_blank">在线投稿</a></span>
            <span><a href="http://lgwindow.sdut.edu.cn/karat/" target="_blank">诚招英才</a></span>
            <span><a href="http://lgwindow.sdut.edu.cn/News/26264.html" target="_blank">版权声明</a></span>
            <hr />
            版权所有 &copy;山东理工大学新闻中心网络部 地址：山东省淄博市张店区张周路12号<br />
            邮编：255049 联系电话：0533-2786727 Designed by:<a href="http://lgwindow.sdut.edu.cn/karat/"
                target="_blank">卡瑞特工作室</a>
        </div>
    </div>
    </form>
</body>
</html>
