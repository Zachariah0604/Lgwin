<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KaratPhoto.aspx.cs" Inherits="Lgwin.Karat.KaratPhoto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/style.css" type="text/css" rel="stylesheet" />
    <script src="js/waterfall.jquery.min.js" type="text/javascript"></script>
    <script type="text/javascript" src="js/jqueryflow.js"></script>
<script type="text/javascript" src="js/Flow.js"></script>
<script type="text/javascript">

    if ($.browser.msie && ($.browser.version == "6.0") && !$.support.style) {
        imf.create("imageFlow", 0.78, 1, 5);
        $(document).ready(function () {
            $(".bar").attr("src", "images/clear.gif");
            $(".bar").attr("style", "filter:progid:DXImageTransform.Microsoft.AlphaImageLoader(enabled=true, src='images/sc.png')");
            $(".arrow-left").attr("src", "images/clear.gif");
            $(".arrow-left").attr("style", "filter:progid:DXImageTransform.Microsoft.AlphaImageLoader(enabled=true, src='images/btn_Pro_show_left.png')");
            $(".arrow-right").attr("src", "images/clear.gif");
            $(".arrow-right").attr("style", "filter:progid:DXImageTransform.Microsoft.AlphaImageLoader(enabled=true, src='images/btn_Pro_show_right.png')");
        });
    } else {
        imf.create("imageFlow", 0.35, 1.5, 5);
    }
</script>
</head>
<body>
    <form id="form1" runat="server">
<div style="width:100%; height:188px; margin:auto; ">
    <iframe scrolling="no" allowtransparency="true" width="100%" height="100%" src="top.html" frameborder="0"></iframe>
</div>

<div class="Ishaohua">
    <div id="imageFlow">
	<div class="bank">
		<a rel='images/2003.png' href='KaratPhoto.aspx?ParentID=2' target="_top"></a>
		<a rel='images/2004.png' href='KaratPhoto.aspx?ParentID=6' target="_top"></a>w
		<a rel='images/2005.png' href='KaratPhoto.aspx?ParentID=7' target="_top"></a>
		<a rel='images/2006.png' href='KaratPhoto.aspx?ParentID=21' target="_top"></a>
		<a rel='images/2007.png' href='KaratPhoto.aspx?ParentID=22' target="_top"></a>
		<a rel='images/2008.png' href='KaratPhoto.aspx?ParentID=23' target="_top"></a>
		<a rel='images/2009.png' href='KaratPhoto.aspx?ParentID=24' target="_top"></a>
		<a rel='images/2010.png' href='KaratPhoto.aspx?ParentID=25' target="_top"></a>
		<a rel='images/2011.png' href='KaratPhoto.aspx?ParentID=26' target="_top"></a>
		<a rel='images/2012.png' href='KaratPhoto.aspx?ParentID=27' target="_top"></a>
		<a rel='images/2013.png' href='KaratPhoto.aspx?ParentID=28' target="_top"></a>
		<a rel='images/2014.png' href='KaratPhoto.aspx?ParentID=29' target="_top"></a>
	</div>
	
	
	
</div> 

</div>


<div id="Imain">  

     <div id="KPmain" role="KPmain">

      <ul id="KPtiles">
        
          <asp:Repeater ID="KaratImages" runat="server">
                    <ItemTemplate>   
                        <asp:Label ID="llid" Text='<%# DataBinder.Eval(Container.DataItem, "ImgName")%>' runat="server" Visible="false"></asp:Label>
        <li><a href='PhotoDetail.aspx?ImgID=<%#DataBinder.Eval(Container.DataItem,"ImgID") %>' target='_top'><img src='<%#DataBinder.Eval(Container.DataItem,"ImgUrl") %>'  width="240px" /></a><p><a href='PhotoDetail.aspx?ImgID=<%#DataBinder.Eval(Container.DataItem,"ImgID") %>' target='_top' style=" color:#333;"><%#BuyListTitle((string)DataBinder.Eval(Container.DataItem, "ImgName"))%></a></p></li>
       
                        </ItemTemplate>
                </asp:Repeater>
       
      </ul>

    </div>
   
  <script src="js/jquery-1.7.1.min.js"></script>
  <script src="js/jquery.wookmark.js"></script>
  
  <script type="text/javascript">
      $(document).ready(new function () {
        
          var options = {
              autoResize: true, 
              container: $('#KPmain'),
              offset: 2, 
              itemWidth: 248 
          };

         
          var handler = $('#KPtiles li');
          handler.wookmark(options);
          handler.click(function () {
              var newHeight = $('img', this).height() + Math.round(Math.random() * 300 + 30);
              $(this).css('height', newHeight + 'px');
              handler.wookmark();
          });
      });
  </script>

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
