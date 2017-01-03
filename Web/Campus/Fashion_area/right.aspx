<%@ Page Language="C#" AutoEventWireup="true" Inherits="right" Codebehind="right.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<style type="text/css">
   a:link {text-decoration: none;color:#000000;}
   a:visited {text-decoration: none;color: #000000;}
   a:hover {text-decoration:underline;}
   a:active {text-decoration: none;}

    .h1
    {
        height:10px
        }
        .h2{height:20px}
        .h3{height:85px}
</style>
    <title></title>
</head>
<body style="width:293px;height:773px;margin-top:0px;margin-left:0px;margin-bottom:0px;margin-right:0px;border:0px;font-size:12px;background-image:url(images/right_images/background_image.gif);border:0px">
    <form id="form1" runat="server">
    <div style="width:293px;height:773px;background-image:url(images/right_images/background_image.gif)">
    <div style="width:100%;height:10px"></div>
    <div style="width:279px;height:30px;margin-left:14px"><img src="images/right_images/towen5.gif" alt="" /><span style="font-size:16px; font-weight:bold">&nbsp;最新文章</span><img
            alt="" src="images/right_images/hr5.gif" style="width:180px;border:0px"/>    </div>
     
     <%--DataList1 --%>        
    <div style="width:273px;height:180px;margin-left:20px">
     <asp:DataList ID="DataList1" runat="server"> <ItemTemplate>
    <table style="width:270px;height:20px"><tr><td style="width:270px;height:20px"> 
        <img alt="" src="images/right_images/toleft5.gif" />&nbsp;<a href='<%# "index3_bh.aspx?id=" + Eval("ID").ToString() %>' target="_blank" title='<%# Eval("title")%>'><%#SubStr( DataBinder.Eval(Container.DataItem,"title").ToString(),16) %></a></td></tr></table>
        </ItemTemplate>
    </asp:DataList></div>
    <div class="h1"></div>
    <div  class="h3" style="text-align:center"><a href="http://lgwindow.sdut.edu.cn/TouGao/TouGao.aspx" target="_blank"><img border="0" src="images/right_images/tougao.gif" alt="" /></a></div>
    <div style="width:279px;height:30px;margin-left:14px"><img src="images/right_images/towen5.gif" alt="" /><span style="font-size:16px; font-weight:bold">&nbsp;编辑推荐</span><img
            alt="" src="images/right_images/hr5.gif" style="width:180px" />    </div>
      
     <%--DataList2 --%>  
    <div style="width:273px;height:180px;margin-left:20px">
    <asp:DataList ID="DataList2" runat="server">
        <ItemTemplate>
          <table style="width:270px;height:20px"><tr><td style="width:270px;height:20px"> 
        <img alt="" src="images/right_images/toleft5.gif" />&nbsp;<a href='<%# "index3_shuyu.aspx?id=" + Eval("ID").ToString() %>' target="_blank" title='<%# Eval("title")%>'><%# SubStr(DataBinder.Eval(Container.DataItem,"title").ToString(),16) %></a></td></tr></table>  
        </ItemTemplate>
    </asp:DataList>
    </div>
    <div class="h1"></div>
    <div  class="h3" style="text-align:center"><a href="http://lgwindow.sdut.edu.cn/Campus/Index.html" target="_blank"><img border="0px"src="images/right_images/kong.gif" alt="" /></a></div>
     <div class="h1"></div>
     <div style="width:279px;height:30px;margin-left:14px"><img src="images/right_images/towen5.gif" alt="" /><span style="font-size:16px; font-weight:bold">&nbsp;文学社简介</span><img
            alt="" src="images/right_images/hr5.gif" style="width:164px"/>    </div>
            <div style="text-align:left;width:271px">

            
            <div style="width:250px;margin-left:20px">
            <table width="240" align="center" border="0" cellspacing="2" cellpadding="2" style="font-size:12px; font-weight:bold; color:#06C">
<tr><td style="width:100">蒲公英文学社</td><td style="width:100">大学生记者协会</td></tr>
<tr ><td style="width:100">樱花雨文学社</td><td style="width:100">星辰阁文学社</td></tr>
<tr ><td style="width:100">晚亭诗社</td><td style="width:100">幽然书友苑</td></tr>
   
</table></div></div>









    </div>
    </form>
</body>
</html>
