<%@ Page Language="C#" AutoEventWireup="True" Inherits="index" Codebehind="index.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<script src="Scripts/AC_RunActiveContent.js" type="text/javascript"></script>
<style type="text/css">
      a:link {text-decoration: none;color:#000000;}
        a:visited {text-decoration: none;color: #000000;}
        a:hover {text-decoration:underline;}
        a:active {text-decoration: none;}
    .hr1
    {
        height:2px;
        width:100%
        }
        
.s6
{  height:10px
    }
    </style>

    <title>山东理工大学校园文化-时尚广角</title>
</head>
<body style="font-size:12px;margin-top:0px;margin-left:0px;margin-right:0px">
    <form id="form1" runat="server">
 
       <iframe id="head" src="flash.htm" scrolling="no" frameborder="0" width="100%" height="235px"></iframe>
       


     <div style="width:990px; margin-left:auto;margin-right:auto">

        <asp:Image ID="Image5" runat="server" ImageUrl="images/index_images/index_03.gif"></asp:Image>
         <div class="s6"></div>
        <div style="width:830px;height:276px">
        <div style="width:480px;float:left;height:276px">
        <div style="width:480px;height:36px"><img src="images/index_images/index_07.gif" style="height:36px;width:480px"alt="" border="0"  usemap="#Map1" />
          <map name="Map1"id="1">
            <area shape="rect" coords="423,8,477,27" href="index2_bh.aspx" alt="more" target="_blank"/>
          </map>
        </div>
    <%--bh--%>
        <div style="width:480px;height:240px;background-color:#fafafa">
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="2" DataKeyField="ID" style="width:480px;height:240px">
                
    <ItemTemplate>
         <div style="height:73px;width:232px">
         <div style="width:100px;height:73px;float:left">
            <a href="<%# "index3_bh.aspx?id=" + Eval("ID").ToString() %>"><img  border="0" src="<%# DataBinder.Eval(Container.DataItem,"picurl").ToString() %>" alt="<%# DataBinder.Eval(Container.DataItem,"title").ToString() %>" style="width:65px;height:70px;margin-top:10px;margin-left:10px" /></a>
         </div>


       



                   <div style="width:130px;height:73px;float:left">
          <table style="width:130px;height:73px;" cellspacing="0"cellpadding="0">
          <tr><td style="width:130px;height:2px;text-align:left"></td></tr>
          <tr><td style="width:130px;height:12px;text-align:left">     
              <a href='<%# "index3_shuyu.aspx?id=" + Eval("ID").ToString() %>' target="_blank" title='<%# Eval("title")%>'><%# SubStr(DataBinder.Eval(Container.DataItem,"title").ToString(),8) %></a>
</tr>
          <tr><td style="width:130px;height:12px;text-align:left"> 作者：<%# SubStr(DataBinder.Eval(Container.DataItem,"author").ToString(),7) %></tr>
          <tr><td style="width:130px;height:41px;text-align:left"> <%#SubStr( DataBinder.Eval(Container.DataItem,"content").ToString(),27) %></tr>
          <tr><td style="width:130px;height:2px;text-align:left"></tr>
          </table></div>


      
   
        
    
    </div>
   </ItemTemplate></asp:DataList>
        </div>
        <%--bh--%>
        </div>
        <div style="width:18px;float:left; height: 32px;height:276px"></div>
        <div style="width:332px;float:left;margin-right:0px;height:276px" >
        <div style="width:332px;height:36px" ><img src="images/index_images/index_09.gif" alt="" border="0" usemap="#Map2" />
          <map name="Map2" id="2">
            <area shape="rect" coords="277,13,329,29" href="index2_shuyu.aspx"   target="_blank" alt="more"/>
          </map>
        </div>
        <%--shuyu--%>
         <div style="width:332px;height:240px">
            <asp:DataList ID="DataList2" runat="server"  style="width:330px;height:240px">
            <AlternatingItemStyle BackColor="White" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#EFF3FB" />
           <ItemTemplate>
           <table style="width:330px;height:20px;border:0px" cellspacing="0" cellpadding="0">
           <tr><td style="width:230px;height:20px;text-align:left"> <a href='<%# "index3_shuyu.aspx?id=" + Eval("ID").ToString() %>' target="_blank" title='<%# Eval("title")%>'><img  border="0" src="images/index_images/tubiao1.gif" alt="" />&nbsp;&nbsp;<%#SubStr(DataBinder.Eval(Container.DataItem,"title").ToString(),12) %></a></td>
           <td style="width:100px;height:20px;text-align:left"><%# SubStr(DataBinder.Eval(Container.DataItem,"author").ToString(),8) %></td></tr>
           </table>
            </ItemTemplate> 
            <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#fafafa" />
        </asp:DataList>
            </div>
            <%--shuyu--%>
            </div>
        </div><div class="s6"></div><hr class="hr1"/>
        
        <asp:Image ID="Image8" runat="server" ImageUrl="images/index_images/index_18.gif"></asp:Image> <div class="s6"></div>

        <div  style="width:830px;height:120px">
        <div style="float:left;width:227px;height:120px">
             <asp:Image ID="Image9" runat="server" ImageUrl="images/index_images/index_21.gif"></asp:Image></div>
        <div style="float:left;height:120px;width:556px;text-align:right">
              <%--mp3player--%>
               <div style="text-align:center">
<script type="text/javascript">
    AC_FL_RunContent('codebase', 'http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0', 'width', '500', 'height', '118', 'src', 'mp3 player', 'quality', 'high', 'pluginspage', 'http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash', 'movie', 'mp3 player'); //end AC code
</script>
<noscript>
  <object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0" width="500" height="118">
    <param name="movie" value="mp3 player.swf" />
    <param name="quality" value="high" />
    <embed src="mp3 player.swf" quality="high" pluginspage="http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash" type="application/x-shockwave-flash" width="500" height="118"></embed>
  </object>
</noscript>
       </div> </div>
         </div>
         <div class="s6"></div>


         <div style="width:830px;height:133px">
         
         <div style="width:658px;height:43px;background-image:url(images/index_images/music.gif)">
          <table style="width:658px;height:43px;border:0px" cellspacing="0" cellpadding="0" ><tr><td style="width:600px;height:12px">
             </td><td style="width:58px;height:12px"></td></tr>
                <tr><td style="width:600px;height:16px"></td><td style="width:58px;height:16px;text-align:center"><a href="index2_music.aspx"><img  border="0" alt="" src="images/index_images/xiaotubiao_more.gif" /></a></td></tr>
                <tr><td style="width:600px;height:15px"></td><td style="width:58px;height:15px"></td></tr></table>
         </div>
               
         <div style="width:658px;float:left; height:90px;background-color:#fafafa">
         
             <asp:DataList ID="DataList3" runat="server" RepeatColumns="3" >
             <ItemTemplate>
                      <table style="width:220px;height:22px"  cellspacing="0" cellpadding="0"><tr><td style="width:220px;height:20px;text-align:left"><a href='<%# "index3_music.aspx?id=" + Eval("ID").ToString() %>' target="_blank" title='<%# Eval("title")%>'><img  border="0" src="images/index_images/tubiao1.gif"  alt=""  style="margin-bottom:0px" />&nbsp;&nbsp;<%# DataBinder.Eval(Container.DataItem,"title").ToString() %></a></td></tr></table>

             </ItemTemplate>
             </asp:DataList>
             
         </div>
    
     
         
         </div>
         
         




         
         
         
         <div class="s6"></div><hr class="hr1"/>
         <asp:Image ID="Image1" runat="server" ImageUrl="images/index_images/index_30.gif"></asp:Image>
         <div class="s6"></div>
         <div style="width:830px;height:44px">
         <div style="width:303px;float:left; height:44px;background-image:url(images/index_images/index_34.gif)">
         <table style="width:303px;height:44px;border:0px" cellspacing="0" cellpadding="0" ><tr><td style="width:203px;height:12px">
             </td><td style="width:100px;height:12px"></td></tr>
                <tr><td style="width:203px;height:16px"></td><td style="width:100px;height:16px;text-align:center"><a href="index2_movie.aspx"><img  border="0" alt="" src="images/index_images/xiaotubiao_more.gif" /></a></td></tr>
                <tr><td style="width:203px;height:16px"></td><td style="width:100px;height:16px"></td></tr></table></div>
         <div style="width:29px;float:left; height:44px"></div>
         <div style="width:493px; float:left;height:44px"><img src="images/index_images/index_36.gif" alt="" border="0" usemap="#Map4" />
           <map name="Map4"  id="4">
             <area shape="rect" coords="429,10,483,30" href="index2_mtv.aspx" alt="more" target="_blank"/>
           </map>
         </div>
         </div>
          <div style="width:830px;height:190px">
          <%--moviepic--%>
         <div style="width:303px;float:left; height:190px">
         <div style="width:303px; height:180px;border:0px;background-color:#fafafa">
         <div style="width:303px;height:180px">


         <a href="index2_movie.aspx"><img border="0" src="images/index_images/dulala.gif" alt="" style="width:283;height:170px;margin-top:5px;margin-bottom:5px;margin-left:10px;margin-right:10px" /></a></div>
         </div>
         <div style="width:303px; height:10px"></div>
         </div>
          <%--moviepic--%>
         <div style="width:31px;float:left; height:190px"></div>
        <%--mtv--%> 
        <div style="width:490px; float:left;height:190px">
        <div style="width:265px; float:left;height:175px;border:3px;border-style:solid;border-color:Gray"><%--视频播放器--%>
        <object type="application/x-shockwave-flash" data="../../images/VideoPlayer/lgwinplayer.swf" width="265" height="175" id="vcastr3">
			<param name="movie" value="../../images/VideoPlayer/lgwinplayer.swf"/> 
			<param name="allowFullScreen" value="true" />
			<param name="FlashVars" value="xml=<vcastr><channel><item>	<source>../../Campus/Fashion_area/video/mtv/20100620045927.flv</source>		</item>	</channel> <config>  <bufferTime>4</bufferTime><contralPanelAlpha>0.75</contralPanelAlpha>             <controlPanelBgColor>0x000000</controlPanelBgColor>                <controlPanelBtnColor>0xffffff</controlPanelBtnColor>                <controlPanelBtnGlowColor>0x00ff00</controlPanelBtnGlowColor>                <controlpanelmode>float</controlpanelmode>
      <defautVolume>0.8</defautVolume><isAutoPlay>false</isAutoPlay>                <isLoadBegin>true</isLoadBegin><isShowAbout>false</isShowAbout>                <scaleMode>showAll</scaleMode></config>
					<plugIns><logoPlugIn> <url>../../images/VideoPlayer/logoPlugIn.swf</url>		
							<logoClipUrl>../../images/VideoPlayer/backlogosmall.png</logoClipUrl>	<logoClipAlpha>0.5</logoClipAlpha>
							<logoClipLink>http://lgwindow.sdut.edu.cn/</logoClipLink>						<logoTextColor>0xffffff</logoTextColor>	<clipMargin>10 20 auto auto</clipMargin>
						</logoPlugIn></plugIns> </vcastr>"/></object> </div>
        <div style="width:204px; float:left;height:180px;margin-left:8px;background-color:#fafafa">
          <asp:DataList ID="DataList6" runat="server" >
             <ItemTemplate>
         <table style="width:204px;height:20px" cellspacing="0" cellpadding="0" >
         <tr><td style="width:204px;height:20px;text-align:left">
         <a href='<%# "Htmlmtv_03/"+ Eval("ID").ToString()+".html" %>' target="_blank" title='<%# Eval("title")%>'>
         <img  border="0" src="images/index_images/tubiao1.gif" alt="" />&nbsp;
           <%#SubStr(DataBinder.Eval(Container.DataItem,"title").ToString(),12) %></a></a></td></tr></table>
          </ItemTemplate>
             </asp:DataList>
        </div>
        <div style="width:490px;height:5px"></div>
        
        
        </div> 
        
         </div>
          <div style="width:830px;height:20px">
          
         <div style="width:303px;float:left; height:20px;border:1px;border-bottom-style:solid;border-bottom-color:Silver;">
         
         <asp:DataList ID="DataList5" runat="server" RepeatColumns="2" DataKeyField="ID" >
         <ItemTemplate><table style="width:150px;height:18px;border:0px" cellspacing="0" cellpadding="0" ><tr><td> <a href='<%# "index3_movie.aspx?id=" + Eval("ID").ToString() %>' target="_blank" title='<%# Eval("title")%>' >《<%# SubStr(DataBinder.Eval(Container.DataItem,"title").ToString(),10) %>》</td></tr></table>
         </ItemTemplate></asp:DataList>
         </div>
         <%--movie_more--%>
         <div style="width:29px;float:left; height:20px"></div>
         <div style="width:493px; float:left;height:20px"><table style="width:100%;height:50%;background-color:Gray"><tr><td></td></tr></table></div>
         </div>
         <div class="s6"></div><hr class="hr1"/>
        
   <div id="foot" style="margin-left:auto;margin-right:auto;font-size:14px;width:990px" >
       <iframe id="iframefoot" src="foot.htm" scrolling="no" frameborder="0" width="990px"></iframe>
    </div>     </div>
         





    </form>

</body>
</html>