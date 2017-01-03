<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="message.aspx.cs" Inherits="message" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>卡瑞特留言板</title>
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <script language="javascript" type="text/javascript" src="js/comm.js"></script>
    <script language="javascript" type="text/javascript" src="js/message.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width:100%; height:188px; margin:0 auto;">
    <iframe scrolling="no" allowtransparency="true" width="100%" height="100%" src="top.html" frameborder="0"></iframe>
</div>
<div id="mTu"></div>
<div id="mmain">
        <div id="mmain1"></div>
        <div id="mmain2">
            
            <asp:Repeater ID="MessageRepeater" runat="server" OnItemDataBound="repLM_ItemDataBound" >
            <ItemTemplate>
              <asp:Label ID="llid" Text='<%# DataBinder.Eval(Container.DataItem, "id")%>' runat="server" Visible="false"></asp:Label>
             <div class="mlw">
                <div class="mltop"><%# DataBinder.Eval(Container.DataItem, "name")%>：<%# DataBinder.Eval(Container.DataItem, "topic")%></div>
                <div class="mltime">留言时间：<%# DataBinder.Eval(Container.DataItem, "m_time")%></div>
                <div class="mlcontent"><%# DataBinder.Eval(Container.DataItem, "m_nr")%></div>
                <div class="mlreply"><div style="float:right;">
                                            <div class="bsync-custom icon-orange"><a title="一键分享到各大微博和社交网络" class="bshare-bsync" onclick="javascript:bSync.share(event)">分享</a></div>
<script type="text/javascript" charset="utf-8" src="http://static.bshare.cn/b/bsync.js#uuid=#uuid=&amp;style=1"></script>
                                     </div>
 <div style="float:right; margin-right:15px;">回复（<font color="#ff0000">10</font>）</div><div style="float:right; margin-right:15px;"><input type="image" style="margin-top:-6px;"  name="Zan" src="images/zan.png" id="imageZan" onclick="return BtnZan('<%# DataBinder.Eval(Container.DataItem, "id")%>')" />（<font color="#FF0000" ><%# DataBinder.Eval(Container.DataItem, "zan")%></font>）</div></div>
                <div class="mlreplycon">
                     <div id="addreply">
                        <textarea name="reply_<%# DataBinder.Eval(Container.DataItem, "id")%>" id="reply_<%# DataBinder.Eval(Container.DataItem, "id")%>" onfocus="return TextAreaOnfocus(this, 'but_<%# DataBinder.Eval(Container.DataItem, "id")%>')" onblur="InputOnblur(this)" onkeypress="TextCount(this)">我要回复...</textarea>
                        <div id="but_<%# DataBinder.Eval(Container.DataItem, "id")%>" class="hide">
                            <div style="width: 150px; float: left;">
                        <input name="gid_<%# DataBinder.Eval(Container.DataItem, "id")%>" id="gid_<%# DataBinder.Eval(Container.DataItem, "id")%>" type="hidden" value="<%# DataBinder.Eval(Container.DataItem, "id")%>" />
                        <input name="uid_<%# DataBinder.Eval(Container.DataItem, "id")%>" id="uid_<%# DataBinder.Eval(Container.DataItem, "id")%>" type="hidden" value="<%# DataBinder.Eval(Container.DataItem, "ip")%>" />
                                <input name="onsumit" type="button" id="onsumit" value="确定" onclick="return BtnClick('gid_<%# DataBinder.Eval(Container.DataItem, "id")%>', 'uid_<%# DataBinder.Eval(Container.DataItem, "id")%>', 'reply_<%# DataBinder.Eval(Container.DataItem, "id")%>')" />
                           <input name="cancel" type="button" id="cancel" value="取消" style="background: #F7F7F7; color: #CCC;" onclick="return TextAreaCanel('reply_<%# DataBinder.Eval(Container.DataItem, "id")%>', 'but_<%# DataBinder.Eval(Container.DataItem, "id")%>')" />
                            </div>
                            <span id="txtCount" style="float: right;">0/<span class="redTxt">200</span></span>
                        </div>
                       
                    </div>
                    <br />
                    
                           <font style="color: #FF0000">管理员回复说：</font><%# DataBinder.Eval(Container.DataItem, "r_nr")%><br /><asp:Repeater ID="MessageReply" runat="server" >
                        <ItemTemplate>
                            
                            <font style="color: #FF0000"><%# DataBinder.Eval(Container.DataItem, "UserID")%>回复说：</font><%# DataBinder.Eval(Container.DataItem, "ReplyMessage")%><br />
                           
                        </ItemTemplate>
                    </asp:Repeater>
                    
                </div>
            </div>
                </ItemTemplate>
        </asp:Repeater>

            <div style=" width:95%; float:right; height:30px; margin-right:90px; margin-top:10px; margin-bottom:10px; text-align:right;">
                <div id="PageInfo" runat="server" class="anpager"></div>
            </div>

        </div>

        <div id="mmain3">
            <div id="mmain3_lw">
            <iframe scrolling="no" allowtransparency="true" width="100%" height="100%" src="admin/Message_Add.aspx" frameborder="0"></iframe></div>
        </div>
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
