<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_NewsIndex" Codebehind="NewsIndex.aspx.cs" %>

<html>
<head runat="server">
    <title>山东理工大学新闻网管理中心</title>
        <script language="javascript" type="text/javascript">
            function unload() {
        var n = window.event.screenX - window.screenLeft;  
            var b = n > document.documentElement.scrollWidth - 20;
            if (b && window.event.clientY < 0 || window.event.altKey) {
                window.opener = null;
                window.open("UserLogin.aspx?Type=LoginOut", "_self");
              //  newwin = window.open("", "_parent", ""); 
                window.close();
       }  
       else  
        {  
          
       } 
        
            }
</SCRIPT>

<SCRIPT for="window" event="onload">
window.onunload = unload;
</SCRIPT>
</head>
<frameset framespacing="0" border="false" rows="32,*" frameborder="0" id="index">
	<frame name="top" scrolling="no" noresize="noresize" src="top.htm">
	<frameset id="frame" framespacing="0" border="false" cols="197,*" frameborder="0">
		<frame name="left" scrolling="yes" noresize="noresize" marginwidth="0" marginheight="0" src="Left.aspx">
		<frame name="main" scrolling="auto" src="Main.html">
	</frameset>
</frameset><noframes>
<body onbeforeunload="return '请正常退出后台管理！';">
</body></noframes>
</html>
