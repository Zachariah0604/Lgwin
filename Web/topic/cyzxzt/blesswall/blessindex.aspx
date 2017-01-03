<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="blessindex.aspx.cs" Inherits="Lgwin.topic.blesswall.blessindex" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />

    <meta http-equiv="Pragma" content="no-cache" />
    <meta name="vs_defaultClientScript" content="JavaScript" />
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
    <link rel="stylesheet" href="wish.css" type="text/css" />
    <style type="text/css">
        body
        {
        }
    </style>
    <script language="JavaScript1.2" type="text/javascript">
        var Obj = ''
        var index = 10000; //z-index;
        document.onmouseup = onMouseUp
        document.onmousemove = onMouseMove
        function onMouseDown(Object) {
            Obj = Object.id
            document.all(Obj).setCapture()
            pX = event.x - document.all(Obj).style.pixelLeft;
            pY = event.y - document.all(Obj).style.pixelTop;
           
        }

        function onMouseMove() {
            if (Obj != '') {
                document.all(Obj).style.left = event.x - pX;
                document.all(Obj).style.top = event.y - pY;
            }
        }
        //控制层移动
        function onMouseUp() {
            if (Obj != '') {
                document.all(Obj).releaseCapture();
                Obj = '';
            }
        }

        function onFocus(obj) {
            if (obj.style.zIndex != index) {
                index = index + 2;
                var idx = index;
                obj.style.zIndex = idx;
            }
        }

        function onRemove() {
            if (event) {
                lObj = event.srcElement;
                n = 0;
                while (lObj && n < 2) {
                    lObj = lObj.parentElement;
                    if (lObj.tagName == "DIV") n++;

                }
            }
            var id = lObj.id
            document.getElementById(id).removeNode(true);

        }


        function getObject(objectId) {
            if (document.getElementById && document.getElementById(objectId)) {
                // W3C DOM
                return document.getElementById(objectId);
            } else if (document.all && document.all(objectId)) {
                // MSIE 4 DOM
                return document.all(objectId);
            } else if (document.layers && document.layers[objectId]) {
                // NN 4 DOM.. note: this won't find nested layers
                return document.layers[objectId];
            } else {
                return false;
            }
        }
    </script>
</head>
<body>
<SCRIPT language=javascript>
    function click() { if (event.button == 2) { alert('不许你偷看！'); } } document.onmousedown = click 
</SCRIPT>  

    <form id="form1" runat="server">
    <div style="width: 100%; height: 60%">
        <img src="wish/wish_bg.jpg" width="100%" height="600" style="position: absolute;
            z-index: 0; top: 0px; left: 0px;" />
        <div id="contentarea" align="center" runat="server">
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <div onmousedown="onFocus(this)" id="cc<%# DataBinder.Eval(Container.DataItem, "id")%>"
                        class="scrip<%# DataBinder.Eval(Container.DataItem, "tagbgcolor") %>">
                        <table border="0" cellpadding="0" cellspacing="0" style="table-layout: fixed; word-wrap: break-word"
                            width="250">
                            <tr>
                                <td onmousedown="onMouseDown(cc<%# DataBinder.Eval(Container.DataItem, "id") %>)"
                                    style="cursor: move">
                                    <div class="shead">
                                        <span ondblclick="onRemove()" title="双击关闭纸条">第[<%# DataBinder.Eval(Container.DataItem, "Id") %>]条
                                            <%# DataBinder.Eval(Container.DataItem, "subtime")%>
                                            <a style="cursor: hand" onclick="onRemove()" title="关闭纸条">×</a></span></div>
                                </td>
                            </tr>
                            <tr>
                                <td style="cursor: default">
                                    <div class="sbody">
                                        <div class="insbody">
                                            &nbsp;&nbsp;
                                            <%# DataBinder.Eval(Container.DataItem, "ccontent")%></div>
                                    </div>
                                    <div class="sbot">
                                        <img src="wish/bpic_<%# DataBinder.Eval(Container.DataItem, "tagbgpic") %>.png" class="left"
                                            border="0"><h2>
                                                <a href="#" style="font-size: 16px; word-wrap: break-word">
                                                    <%# DataBinder.Eval(Container.DataItem, "author")%></a></h2>
                                    </div>
                                </td>
                            </tr>
                        </table>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
    <div id="bar" style="width: 100%; margin-left: 0px; top: 0px; left: 0px;">
        <center>
            <webdiyer:AspNetPager runat="server" ID="pager" CustomInfoHTML="第%CurrentPageIndex%页，共%PageCount%页，每页%PageSize%条"
                FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页" ShowCustomInfoSection="Left"
                OnPageChanging="pager_PageChanging" PageSize="10" OnInit="Page_Load">
            </webdiyer:AspNetPager>
        </center>
    </div>
    </form>
    <script type="text/javascript">

        var elements = document.getElementById("contentarea").childNodes;
        var wid = document.body.scrollWidth;
        if (!wid || wid < 300) wid = 600;

        for (var i = 0; i < elements.length; i++) {
            if (elements[i].tagName && elements[i].tagName == 'DIV') {
                elements[i].style.top = Math.ceil(350 * Math.random()) + "px"
                elements[i].style.left = Math.ceil((wid - 250) * Math.random()) + "px";
                elements[i].style.zIndex = elements.length + 2 - i;
            }
        }
    </script>
    <script language="JavaScript" type="text/javascript">

        var ie = false;
        function getObj(id) {
            if (ie) {
                return document.all[id];
            } else {
                return document.getElementById(id);
            }
        }

        function setTagBColor(i) {
            color = getBColor(i);
            getObj('preview').style.background = '' + color;
            hopeFM.tagbgcolor.value = i;
        }

        function setTagBPic(i) {
            picurl = getBPic(i);
            getObj('tagBPic').style.background = " transparent url(\"" + picurl + "\") no-repeat scroll bottom left";
            hopeFM.tagbgpic.value = i;
        }

        function getBColor(i) {
            i = (i < 1 || i > 10) ? 0 : parseInt(parseInt(i) - 1);
            //colorArray = new Array ("#FFDFFF","#C5FFC2","#FFE3B8","#FFCECE","#CEECFF","#FFFFCC","#E8DEFF","#F0F0F0");
            colorArray = new Array("#E76455", "#A175E6", "#90D355", "#7CA9EA", "#E1CB29", "#7FD9C0", "#F55C92", "#D6E6A5", "#8DD152", "#EA88E4");
            return colorArray[i];
        }

        function getBPic(i) {
            i = (i < 1 || i > 40) ? 1 : i;

            //alert(parseInt(parseInt(i)+10));

            return "wish/bpic_" + parseInt(parseInt(i)) + ".png";
        }
        function textCounter(field, countfield, maxlimit) {
            if (field.value.length > maxlimit)
                field.value = field.value.substring(0, maxlimit);
            else
                countfield.value = maxlimit - field.value.length;
            //field.value = field.value.replace(" ","&nbsp;");
            //field.value = field.value.replace("\r\n","<br>");
            viewcontent.innerHTML = field.value;
        }

        function texgifunter(field, countfield, maxlimit) {
            if (field.value.length > maxlimit)
                field.value = field.value.substring(0, maxlimit);
            else
                countfield.value = maxlimit - field.value.length;
            //field.value = field.value.replace(" ","&nbsp;");
            //field.value = field.value.replace("\r\n","<br>");
            viewcontent.innerHTML = field.value;
        }

        function chkFM() {
            if (hopeFM.messages.value == "") {
                alert("\n您的祝福内容?\n");
                hopeFM.messages.focus();
                return false;
            }
            if (hopeFM.singnature.value == "") {
                alert("\n请留下您的署名!\n");
                hopeFM.singnature.focus();
                return false;
            }
            alert("提交祝福成功!");
            return true;
        }
    </script>
    <table border="0" cellpadding="0" cellspacing="0" width="1000" style="border: 1px solid #BBBBBB;
        margin: 5px auto;">
        <tr>
            <td align="center" valign="top">
                <table border="0" cellpadding="0" cellspacing="0" style="height: 459px; width: 85%">
                    <tr>
                        <td align="center" valign="top">
                            <form name="hopeFM" onsubmit="return chkFM();" method="post" action="input.aspx">
                            <input type="hidden" value="1" name="tagbgcolor">
                            <input type="hidden" value="6" name="tagbgpic">
                            <input type="hidden" value="1" name="add">
                            <input type="hidden" value="5258027" name="tid">
                            <img src="wish/spacer.gif" width="1" height="8"><br>
                            <table border="0" cellpadding="0" cellspacing="0" width="676" bgcolor="#EEF1EC">
                                <tr>
                                    <td width="652" align="center" class="f14_2167 pt4">
                                        <strong>我要贴祝福纸条 </strong>
                                    </td>
                                </tr>
                            </table>
                            <br />
                            <table border="0" cellpadding="0" cellspacing="0" width="80%">
                                <tr>
                                    <td align="center" valign="top">
                                        <img src="wish/spacer.gif" width="1" height="10"><br>
                                        <img src="wish/spacer.gif" width="1" height="10"><br>
                                        <table border="0" cellpadding="0" cellspacing="0" width="98%">
                                            <tr align="center" valign="top">
                                                <td width="398">
                                                    <table border="0" cellpadding="0" cellspacing="0" width="450">
                                                        <tr>
                                                            <td width="110" class="f12_5050">
                                                                请选择纸条颜色：
                                                            </td>
                                                            <td width="400">
                                                                <a href="javascript:setTagBColor('1');">
                                                                    <img border="0" src="wish/1_2.png" width="25" height="25"></a> &nbsp;<a href="javascript:setTagBColor('2');"><img
                                                                        border="0" src="wish/2_2.png" width="25" height="25"></a> &nbsp;<a href="javascript:setTagBColor('3');"><img
                                                                            border="0" src="wish/3_2.png" width="25" height="25"></a> &nbsp;<a href="javascript:setTagBColor('4');"><img
                                                                                border="0" src="wish/4_2.png" width="25" height="25"></a> &nbsp;<a href="javascript:setTagBColor('5');"><img
                                                                                    border="0" src="wish/5_2.png" width="25" height="25"></a> &nbsp;<a href="javascript:setTagBColor('6');"><img
                                                                                        border="0" src="wish/6_2.png" width="25" height="25"></a>
                                                                &nbsp;<a href="javascript:setTagBColor('7');"><img border="0" src="wish/7_2.png"
                                                                    width="25" height="25"></a> &nbsp;<a href="javascript:setTagBColor('8');"><img border="0"
                                                                        src="wish/8_2.png" width="25" height="25"></a> &nbsp;<a href="javascript:setTagBColor('9');"><img
                                                                            border="0" src="wish/9_2.png" width="25" height="25"></a> &nbsp;<a href="javascript:setTagBColor('10');"><img
                                                                                border="0" src="wish/10_2.png" width="25" height="25"></a>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                    <table border="0" cellpadding="0" cellspacing="0" width="450">
                                                        <tr valign="top">
                                                            <td width="110" class='f12_5050 pt12'>
                                                                请选表情：
                                                            </td>
                                                            <td width="300">
                                                                <div class="nr">
                                                                    <table border="0" cellpadding="0" cellspacing="0" width="250" style="margin: 0 auto">
                                                                        <tr align="center">
                                                                            <td width="44">
                                                                                <a href="javascript:setTagBPic('1')">
                                                                                    <img border="0" src="wish/bpic_1.png"></a>
                                                                            </td>
                                                                            <td width="79">
                                                                                <a href="javascript:setTagBPic('2');">
                                                                                    <img border="0" src="wish/bpic_2.png"></a>
                                                                            </td>
                                                                            <td width="54">
                                                                                <a href="javascript:setTagBPic('3');">
                                                                                    <img border="0" src="wish/bpic_3.png"></a>
                                                                            </td>
                                                                            <td width="86">
                                                                                <a href="javascript:setTagBPic('4');">
                                                                                    <img border="0" src="wish/bpic_4.png"></a>
                                                                            </td>
                                                                        </tr>
                                                                        <tr align="center">
                                                                            <td width="44" height="48">
                                                                                <a href="javascript:setTagBPic('5');">
                                                                                    <img border="0" src="wish/bpic_5.png"></a>
                                                                            </td>
                                                                            <td width="79">
                                                                                <a href="javascript:setTagBPic('6');">
                                                                                    <img border="0" src="wish/bpic_6.png"></a>
                                                                            </td>
                                                                            <td width="54">
                                                                                <a href="javascript:setTagBPic('7');">
                                                                                    <img border="0" src="wish/bpic_7.png"></a>
                                                                            </td>
                                                                            <td width="86">
                                                                                <a href="javascript:setTagBPic('8');">
                                                                                    <img border="0" src="wish/bpic_8.png"></a>
                                                                            </td>
                                                                        </tr>
                                                                        <tr align="center">
                                                                            <td width="44" height="48">
                                                                                <a href="javascript:setTagBPic('9');">
                                                                                    <img border="0" src="wish/bpic_9.png"></a>
                                                                            </td>
                                                                            <td width="79">
                                                                                <a href="javascript:setTagBPic('10');">
                                                                                    <img border="0" src="wish/bpic_10.png"></a>
                                                                            </td>
                                                                            <td width="54">
                                                                                <a href="javascript:setTagBPic('11');">
                                                                                    <img border="0" src="wish/bpic_11.png"></a>
                                                                            </td>
                                                                            <td width="86">
                                                                                <a href="javascript:setTagBPic('12');">
                                                                                    <img border="0" src="wish/bpic_12.png"></a>
                                                                            </td>
                                                                        </tr>
                                                                        <tr align="center">
                                                                            <td width="44" height="48">
                                                                                <a href="javascript:setTagBPic('13');">
                                                                                    <img border="0" src="wish/bpic_13.png"></a>
                                                                            </td>
                                                                            <td width="79">
                                                                                <a href="javascript:setTagBPic('14');">
                                                                                    <img border="0" src="wish/bpic_14.png"></a>
                                                                            </td>
                                                                            <td width="54">
                                                                                <a href="javascript:setTagBPic('15');">
                                                                                    <img border="0" src="wish/bpic_15.png"></a>
                                                                            </td>
                                                                            <td width="86">
                                                                                <a href="javascript:setTagBPic('16');">
                                                                                    <img border="0" src="wish/bpic_16.png"></a>
                                                                            </td>
                                                                        </tr>
                                                                        <tr align="center">
                                                                            <td width="44" height="48">
                                                                                <a href="javascript:setTagBPic('17');">
                                                                                    <img border="0" src="wish/bpic_17.png"></a>
                                                                            </td>
                                                                            <td width="79">
                                                                                <a href="javascript:setTagBPic('18');">
                                                                                    <img border="0" src="wish/bpic_18.png"></a>
                                                                            </td>
                                                                            <td width="54">
                                                                                <a href="javascript:setTagBPic('19');">
                                                                                    <img border="0" src="wish/bpic_19.png"></a>
                                                                            </td>
                                                                            <td width="86">
                                                                                <a href="javascript:setTagBPic('20');">
                                                                                    <img border="0" src="wish/bpic_20.png"></a>
                                                                            </td>
                                                                        </tr>
                                                                        <tr align="center">
                                                                            <td width="44" height="48">
                                                                                <a href="javascript:setTagBPic('21');">
                                                                                    <img border="0" src="wish/bpic_21.png"></a>
                                                                            </td>
                                                                            <td width="79">
                                                                                <a href="javascript:setTagBPic('22');">
                                                                                    <img border="0" src="wish/bpic_22.png"></a>
                                                                            </td>
                                                                            <td width="54">
                                                                                <a href="javascript:setTagBPic('23');">
                                                                                    <img border="0" src="wish/bpic_23.png"></a>
                                                                            </td>
                                                                            <td width="86">
                                                                                <a href="javascript:setTagBPic('24');">
                                                                                    <img border="0" src="wish/bpic_24.png"></a>
                                                                            </td>
                                                                        </tr>
                                                        </tr>
                                                        <tr align="center">
                                                            <td width="44" height="48">
                                                                <a href="javascript:setTagBPic(25');">
                                                                    <img border="0" src="wish/bpic_25.png"></a>
                                                            </td>
                                                            <td width="79">
                                                                <a href="javascript:setTagBPic('26');">
                                                                    <img border="0" src="wish/bpic_26.png"></a>
                                                            </td>
                                                            <td width="54">
                                                                <a href="javascript:setTagBPic('27');">
                                                                    <img border="0" src="wish/bpic_27.png"></a>
                                                            </td>
                                                            <td width="86">
                                                                <a href="javascript:setTagBPic('28');">
                                                                    <img border="0" src="wish/bpic_28.png"></a>
                                                            </td>
                                                        </tr>
                                                        <tr align="center">
                                                            <td width="44" height="48">
                                                                <a href="javascript:setTagBPic('29');">
                                                                    <img border="0" src="wish/bpic_29.png"></a>
                                                            </td>
                                                            <td width="79">
                                                                <a href="javascript:setTagBPic('30');">
                                                                    <img border="0" src="wish/bpic_30.png"></a>
                                                            </td>
                                                            <td width="54">
                                                                <a href="javascript:setTagBPic('31');">
                                                                    <img border="0" src="wish/bpic_31.png"></a>
                                                            </td>
                                                            <td width="86">
                                                                <a href="javascript:setTagBPic('32');">
                                                                    <img border="0" src="wish/bpic_32.png"></a>
                                                            </td>
                                                        </tr>
                                                        <tr align="center">
                                                            <td width="44" height="48">
                                                                <a href="javascript:setTagBPic('33');">
                                                                    <img border="0" src="wish/bpic_33.png"></a>
                                                            </td>
                                                            <td width="79">
                                                                <a href="javascript:setTagBPic('34');">
                                                                    <img border="0" src="wish/bpic_34.png"></a>
                                                            </td>
                                                            <td width="54">
                                                                <a href="javascript:setTagBPic('35');">
                                                                    <img border="0" src="wish/bpic_35.png"></a>
                                                            </td>
                                                            <td width="86">
                                                                <a href="javascript:setTagBPic('36');">
                                                                    <img border="0" src="wish/bpic_36.png"></a>
                                                            </td>
                                                        </tr>
                                                        <tr align="center">
                                                            <td width="44" height="48">
                                                                <a href="javascript:setTagBPic('37');">
                                                                    <img border="0" src="wish/bpic_37.png"></a>
                                                            </td>
                                                            <td width="79">
                                                                <a href="javascript:setTagBPic('38');">
                                                                    <img border="0" src="wish/bpic_38.png"></a>
                                                            </td>
                                                            <td width="54">
                                                                <a href="javascript:setTagBPic('39');">
                                                                    <img border="0" src="wish/bpic_39.png"></a>
                                                            </td>
                                                            <td width="86">
                                                                <a href="javascript:setTagBPic('40');">
                                                                    <img border="0" src="wish/bpic_40.png"></a>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                    </div>
                                                </td>
                                                <td width="26">
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td width="210">
                                        <div id="preview" style="background-color: #E8DEFF">
                                            <table border="0" cellpadding="0" cellspacing="0" width="210">
                                                <tr>
                                                    <td height="1">
                                                        <img src="wish/line_top.gif" width="210" height="1">
                                                    </td>
                                                </tr>
                                            </table>
                                            <table border="0" cellpadding="0" cellspacing="0" width="210">
                                                <tr>
                                                    <td align="center" valign="top">
                                                        <table border="0" cellpadding="0" cellspacing="0" width="190">
                                                            <tr>
                                                                <td width="183" class="f12_0078">
                                                                    第[xx]条&nbsp;&nbsp;&nbsp;&nbsp;<%=DateTime.Now %>
                                                                </td>
                                                                <td width="7">
                                                                    X
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <table border="0" cellpadding="0" cellspacing="0" width="190" style="height: 120px">
                                                            <tr>
                                                                <td id="tagBPic" style='background: url(images/bpic_11.jpg) no-repeat bottom left;
                                                                    word-wrap: bgifk-word'>
                                                                    <br>
                                                                    <br>
                                                                    <div id="viewcontent" style="text-align: left; word-wrap: break-word">
                                                                        献上我的祝福，祝福新浪乐居更美好！</div>
                                                                    <br>
                                                                    <br>
                                                                    <br>
                                                                    <table border="0">
                                                                        <tr>
                                                                            <td width="40">
                                                                            </td>
                                                                            <td width="150" align="right">
                                                                                <div id="viewsign">
                                                                                    我的署名</div>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                            <table border="0" cellpadding="0" cellspacing="0" width="210">
                                                <tr>
                                                    <td>
                                                        <img src="wish/line_bottom.gif" width="210" height="1">
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                    </td>
                                </tr>
                            </table>
                            <img src="wish/spacer.gif" width="1" height="10"><br>
                            <table border="0" cellpadding="0" cellspacing="0" width="608">
                                <tr>
                                    <td height="33" class="f12_5050">
                                        输入你的祝福纸条内容 ( 还能输入<input style="border-top-width: 0px; border-left-width: 0px; border-bottom-width: 0px;
                                            border-right-width: 0px" readonly maxlength="3" size="3" value="92" name="freeLength">个字
                                        )
                                    </td>
                                </tr>
                            </table>
                            <table border="0" cellpadding="0" cellspacing="0" width="608">
                                <tr>
                                    <td>
                                        <textarea cols="90" rows="5" style='color: #505050; font-size: 12px;' align="left"
                                            onkeydown="textCounter(this.form.messages,this.form.freeLength,120);" onkeyup="textCounter(this.form.messages,this.form.freeLength,120);"
                                            onfocus="if(this.value=='献上我的祝福，祝福新浪乐居更美好！')this.value=''" name="messages" wrap="physical">献上我的祝福，祝福新浪乐居更美好！</textarea>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="33" class="f12_5050">
                                        您的署名：<input type="text" name="singnature" maxlength="10" value="" onkeydown="javascript:viewsign.innerHTML=this.form.singnature.value"
                                            onkeyup="javascript:viewsign.innerHTML=this.form.singnature.value">
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
                <table border="0" cellpadding="0" cellspacing="0" width="174">
                    <tr>
                        <td>
                            <input type="image" src="wish/pic_submit.gif">
                        </td>
                    </tr>
                    <tr>
                        <td height="5">
                        </td>
                    </tr>
                </table>
                </form>
            </td>
        </tr>
    </table>
    <script type="text/javascript">        document.write('<script type="text/javascript" src="http://bbs.house.sina.com.cn/js.php?action=viewcount&amp;fid=2043&amp;tid=5258027&amp;pid=0&t=' + new Date().getTime() + '"></sc' + 'ript>');</script>
</body>
</html>
