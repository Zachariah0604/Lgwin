<%@ Page Language="C#" AutoEventWireup="true" Inherits="Campus_Html_03_Preview" Codebehind="Preview.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
<meta http-equiv="X-UA-Compatible" content="IE=7" />
<meta http-equiv="X-UA-Compatible" content="IE=6" />
<META content="MSHTML 6.00.2800.1264" name=GENERATOR>
<title>文章预览</title>
<link href="xywh3.css" rel="stylesheet" type="text/css" media="screen" />
<script src="Scripts/swfobject_modified.js" type="text/javascript"></script>
<script type="text/javascript">
    var bFlag = true; //全局变量,用于判断是否允许清除文本框内容
    //用于清除输入框中提示信息的方法
    function clearTip() {
        var oTxt = document.getElementById("textarea");
        if (bFlag == true) {
            oTxt.value = "";
            bFlag = false;
        }
    }
</script>
<style type="text/css">
.public #middle_left div div a {
	color: #000;
	text-decoration: none;
}
#menu
{
	height:30px;
}
a:link {
	text-decoration: none;
	color: #000;
}
a:visited {
	text-decoration: none;
	color: #000;
}
a:hover {
	text-decoration: none;
	color: #666;
}
a:active {
	text-decoration: none;
}
#hot {
	font-size: 12px;
	color: #999;
	text-align:center;
}
#hot table tr td a {
	font-size: 12px;
	color: #999;
}
#menu tr td a {
	font-size: 14px;
	color:#FFF;
}
#menu tr td a:hover {
	font-size: 14px;
	color:#F00;
}
#hot tr td a {
	color: #999;
}
</style>
</head>
<body style="background-image:url(XYWH_03/top_bg_image.jpg);background-repeat:repeat-x;background-position:top;margin-top:0px">
    <form id="form1" runat="server">
<div class="public" id="top">
  <table align="center" width="996" height="157px" border="0" style="margin-top:8px" cellspacing="0" cellpadding="0">
    <tr>
      <td><table width="996" style="color: #000; font-size:12px" border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td>主办：山东理工大学党委宣传部 新闻中心</td>
          <td width="460px">&nbsp;</td>
          <td><a href="http://lgwindow.sdut.edu.cn/" target="_blank">新闻网</a></td>
          <td>｜</td>
          <td><a href="http://lgwindow.sdut.edu.cn/photo/index.html" target="_blank">光影理工</a></td>
          <td>｜</td>
          <td><a href="http://lgwindow.sdut.edu.cn/map/" target="_blank">虚拟校园</a></td>
          <td>｜</td>
          <td><a href="http://210.44.191.210/" target="_blank">校园图库</a></td>
          <td>｜</td>
          <td><a href="javascript:window.external.addFavorite('http://lgwindow.sdut.edu.cn/Campus/Index.html','山东理工大学新闻网校园文化')" title="把山东理工大学校园文化加入收藏" >加入收藏</a></td>
          <td width="30px">&nbsp;</td>
        </tr>
      </table></td>
    </tr>
    <tr>
      <td><table width="996" height="80px" border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td><img src="../images/index/images/xywh logo.jpg" width="245" height="80" alt="校园文化logo" /></td>
          <td width="200px"><img src="../images/index/images/xywh banner.jpg" width="558" height="79" alt="校园文化" /></td>
          <td>&nbsp; </td>
        </tr>
      </table></td>
    </tr>
    <tr>
      <td></td>
    </tr>
    <tr>
      <td>
        <table id="menu" width="996" style="text-align:center; color:#CCC" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td><a href="http://lgwindow.sdut.edu.cn/Campus/Index.html" target="_blank">首页</a></td>
    <td>｜</td>
    <td><a href="http://lgwindow.sdut.edu.cn/Campus/suiyueligong/2.html" target="_blank">岁月理工</a></td>
    <td>｜</td>
    <td><a href="http://lgwindow.sdut.edu.cn/Campus/Html02/mingjiajiangtan_list_0.html" target="_blank">名家讲坛</a></td>
    <td>｜</td>
    <td><a href="http://lgwindow.sdut.edu.cn/Campus/Html02/wenxuexingkong_list_0.html" target="_blank">文学星空</a></td>
    <td>｜</td>
    <td><a href="http://lgwindow.sdut.edu.cn/Campus/Html02/jingjingxiaoyuan_list_0.html" target="_blank">菁菁校园</a></td>
    <td>｜</td>
    <td><a href="http://lgwindow.sdut.edu.cn/Campus/Html02/XYSH_list_0.html" target="_blank">校园生活</a></td>
    <td>｜</td>
    <td><a href="http://lgwindow.sdut.edu.cn/Campus/Html02/ligongwangshi_list_0.html" target="_blank">社团风采</a></td>
    <td>｜</td>
    <td><a href="http://lgwindow.sdut.edu.cn/Campus/Fashion_area/index.aspx" target="_blank">时尚广角</a></td>
    <td width="200px">&nbsp;</td>
  </tr>
</table>
</td>
    </tr>
    <tr>
    <td>
    <table id="hot" width="996" style="text-align:left; margin-top:5px; margin-bottom:10px" border="0" cellspacing="0" cellpadding="0">
  <tr>
  <td width="6px">&nbsp;</td>
    <td width="70px">热门导航：</td>
    <td><a href="http://lgwindow.sdut.edu.cn/Campus/Html02/wenxuexingkong_list_0.html" target="_blank">学生原创</a></td>
    <td><a href="http://lgwindow.sdut.edu.cn/Campus/Html02/wenxuexingkong_list_0.html" target="_blank">心灵启迪</a></td>
    <td><a href="http://lgwindow.sdut.edu.cn/Campus/Html02/jingjingxiaoyuan_list_0.html" target="_blank">记者观察</a></td>
    <td><a href="http://lgwindow.sdut.edu.cn/Campus/Html02/jingjingxiaoyuan_list_0.html" target="_blank">稷下时评</a></td>
    <td><a href="http://lgwindow.sdut.edu.cn/Campus/Fashion_area/index2_mtv.aspx" target="_blank">网视</a></td>
    <td><a href="http://lgwindow.sdut.edu.cn/Campus/Fashion_area/index2_bh.aspx" target="_blank">图书</a></td>
    <td><a href="http://lgwindow.sdut.edu.cn/Campus/Fashion_area/index2_music.aspx" target="_blank">音乐</a></td>
    <td><a href="#" target="_blank">网刊</a></td>
    <td><a href="#" target="_blank">文学之星</a></td>
    <td width="440px">&nbsp;</td>
  </tr>
</table>
</td>
    </tr>
  </table>
  </div>
<div class="public">
  <div id="middle_left">
    <div style="height:20px; margin-top:5px">
      <div style=" text-align:center; width:230px; height:20px; float:left; padding-left:20px; padding-top:2px; font-size:14px">当前位置：<a href="../Index.html">校园文化</a>&gt;&gt;<asp:Label 
              ID="lanmu" runat="server" Text="Label"></asp:Label>
        </div>
      <div style="width:420px; float:right"><img src="XYWH_03/xywh_2_03.jpg" width="410" height="20" /></div>
    </div>
    <div>
      <div align="center" style="font-size:20px; font-weight:bold; font-family:'宋体'; color:#286cbf; margin-top:10px">
          <asp:Label ID="title" runat="server" Text="Label"></asp:Label>
        </div>
      <div align="center" style="font-size:14px; font-weight:bold; font-family:'宋体'; color:#286cbf; margin-top:5px">
          <asp:Label ID="subtitle" runat="server" Text="Label"></asp:Label>
        </div>
      <div align="center" style="margin-top:10px; font-size:smaller">作者：<asp:Label 
              ID="author" runat="server" Text="Label"></asp:Label>
          &nbsp;&nbsp;&nbsp;来源：<asp:Label ID="from" runat="server" Text="Label"></asp:Label>
          &nbsp;&nbsp;&nbsp;发布日期：<asp:Label ID="date" runat="server" Text="Label"></asp:Label>
        </div>
      <div align="center" style="min-height:800px; height:auto; margin-top:10px">
<table width="672" border="0" cellspacing="0" cellpadding="0"style="line-height:150%; color:#5a5a5a " >
  <tr>
    <td style="min-height:300px; text-align:left">
        <asp:Label ID="content" runat="server" Text="Label"></asp:Label>
      </td>  
  </tr>
</table>

      </div>
      <div align="right">
        <hr / width="300" align="right">
        <p style="font-size:14px">编辑：<asp:Label ID="editor" runat="server" Text="Label"></asp:Label>
            &nbsp;&nbsp;</p>
         <div align="left"><img src="XYWH_03/liuyanqu.gif" width="100" height="20" /></div>
        
        <div align="left">
      <input id="hd" type="hidden" name="hd_id" value="%%id%%"/>
      用户：<input id="input" type="text" name="name" value="理工网友" style="color:#4891B7;" onclick="this.value=''";/></br>内容：<textarea id="textarea" cols="60" name="neirong" rows="8" onfocus="clearTip()">路过...留下脚印——请文明用语</textarea></br><div style=" text-align:center; margin-top:10px"><input style="width:80px; height:30px" id="Submit1" 
              type="submit" value="提交" /></div></div>
        <p style="font-size:14px"><a href="#" onClick="window.print()">【打印本页】</a><a href="#" onClick="window.close()">【关闭窗口】</a></p>
      </div>
    </div>
  </div>
  <div id="middle_right">
<iframe width="316" align="middle" height="849" frameborder="0" allowtransparency="true" scrolling="no" src="../right_list.html"></iframe>
  </div>
</div>
<div class="public"><iframe width="996" align="middle" frameborder="0" allowtransparency="true" scrolling="no" src="../footer.html"></iframe></div>
    </form>
</body>
</html>
