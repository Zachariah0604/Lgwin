<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="blesswall.aspx.cs" Inherits="Lgwin.topic.blesswall.blesswall" %>
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
        if (!wid || wid < 300) wid = 500;

        for (var i = 0; i < elements.length; i++) {
            if (elements[i].tagName && elements[i].tagName == 'DIV') {
                elements[i].style.top = Math.ceil(250 * Math.random()) + "px"
                elements[i].style.left = Math.ceil((wid - 350) * Math.random()) + "px";
                elements[i].style.right = Math.ceil((wid - 350) * Math.random()) + "px";
                elements[i].style.zIndex = elements.length + 2 - i;
            }
        }
    </script>
</body>
</html>
