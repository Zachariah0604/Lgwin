<%@ Page Language="C#" AutoEventWireup="true" Inherits="campusfirst" Codebehind="campusfirst.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<style type="text/css">
      a:link {text-decoration: none;color:#000000;}
        a:visited {text-decoration: none;color: #000000;}
        a:hover {text-decoration:underline;}
        a:active {text-decoration: none;}

    </style>
    <title></title>
</head>
<body style="margin-left:0px;margin-top:0px;font-size:12px">
    <form id="form1" runat="server">
    
<div id="total" style="width:985px;height:205px;margin-left:auto;margin-right:auto">
<div id="left" style="width:490px;height:200px;border:2px solid #afc3ec;float:left">
<div  id="left1" style="width:204px;height:200px;float:left">
<div id="wangshi" style="width:204px;height:37px">
<a href="index2_mtv.aspx" target="_blank"><img  border="0"alt="网视show" src="images/index_images/campusfirst_mtv.gif"/></a></div>
<div id="list" style="width:190;height:150px;margin-left:14px">
 <asp:DataList ID="DataList1" runat="server" >
<ItemTemplate>
<div style="width:185px;height:23px;border-bottom:1px  dashed #5e5e5e;">
<img  alt="网视show" src="images/index_images/campusfirst_dit.gif"/>&nbsp;&nbsp;
 <a href='<%# "Htmlmtv_03/"+ Eval("ID").ToString()+".html" %>' target="_blank" title='<%# Eval("title")%>'>
  <%# SubStr(DataBinder.Eval(Container.DataItem,"title").ToString(),12) %></a></div>
           </ItemTemplate>
  </asp:DataList>
</div>
</div>
<div id="left2" style="width:286px;height:200px;float:left">
<div id="vcastr_player" style="width:252px;height:181px;margin-top:8px;margin-left:15px;margin-right:15px;border:2px #dedede solid;">
<object type="application/x-shockwave-flash" data="../../images/VideoPlayer/lgwinplayer.swf" width="252" height="181" id="vcastr3">
			<param name="movie" value="../../images/VideoPlayer/lgwinplayer.swf"/> 
			<param name="allowFullScreen" value="true" />
			<param name="FlashVars" value="xml=<vcastr><channel><item>	<source>../../Campus/Fashion_area/video/mtv/20100620045927.flv</source>		</item>	</channel> <config>  <bufferTime>4</bufferTime><contralPanelAlpha>0.75</contralPanelAlpha>             <controlPanelBgColor>0x000000</controlPanelBgColor>                <controlPanelBtnColor>0xffffff</controlPanelBtnColor>                <controlPanelBtnGlowColor>0x00ff00</controlPanelBtnGlowColor>                <controlpanelmode>float</controlpanelmode>
      <defautVolume>0.8</defautVolume><isAutoPlay>false</isAutoPlay>                <isLoadBegin>true</isLoadBegin><isShowAbout>false</isShowAbout>                <scaleMode>showAll</scaleMode></config>
					<plugIns><logoPlugIn> <url>../../images/VideoPlayer/logoPlugIn.swf</url>		
							<logoClipUrl>../../images/VideoPlayer/backlogosmall.png</logoClipUrl>	<logoClipAlpha>0.5</logoClipAlpha>
							<logoClipLink>http://lgwindow.sdut.edu.cn/</logoClipLink>						<logoTextColor>0xffffff</logoTextColor>	<clipMargin>10 20 auto auto</clipMargin>
						</logoPlugIn></plugIns> </vcastr>"/></object> </div>
</div>

</div>
<div id="middle" style="width:27px;height:204px;float:left"></div>
<div id="right" style="width:463px;height:202px;float:left;border-bottom:2px #525da6 solid">
<div id="right8" style="width:463px;height:196px">
<div id="right8_1" style="width:219px;height:196px;float:left">
<div style="width:219px;height:27px"><a href="index.aspx" target="_blank"><img  border="0"alt="fashion_area" src="images/index_images/campus_first_tushu1.gif"/></a></div>
<div style="width:219px;height:8px"></div>
<div style="width:219px;height:161px"><a href="index.aspx" target="_blank"><img  border="0"alt="fashion_area" src="images/index_images/campus_first_tushu3.gif"/></a></div>
</div>
<div id="right8_2" style="width:25px;height:196px;float:left"></div>
<div id="right8_3" style="width:219px;height:196px;float:left">
<div style="width:219px;height:27px"><a href="index2_music.aspx" target="_blank"><img  border="0"alt="fashion_area" src="images/index_images/campus_first_music1.gif"/></a></div>
<div style="width:219px;height:8px"></div>
<div style="width:219px;height:161px"><a href="index2_music.aspx" target="_blank"><img  border="0"alt="fashion_area" src="images/index_images/campus_first_music3.gif"/></a></div>
</div>
</div>
<div id="right2" style="width:463px;height:8px"></div>
</div>

</div>

    </form>
</body>
</html>

