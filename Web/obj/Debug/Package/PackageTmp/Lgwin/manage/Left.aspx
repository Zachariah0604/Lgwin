<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_left" Codebehind="Left.aspx.cs" %>

<html>
<head>
<meta http-equiv='Content-Type' content='text/html; charset=gb2312'>
<title>管理导航菜单</title>
<script src="Images/prototype.js"></script>
<link href="Images/Admin_left.CSS" rel="stylesheet" type="text/css">
</head>
<body>
<table width=180 border='0' align=center cellpadding=0 cellspacing=0>
  <tr>
    <td height=44 valign=top><img src='Images/title.gif'></td>
  </tr>
</table>
<table cellpadding=0 cellspacing=0 width=180 align=center>
    <tr>
    <td height=97 background='Images/title_bg_admin.gif' style='display:' id='submenu0'><div style='width:180'>
        <table cellpadding=0 cellspacing=0 align=center width=130>
          <tr>
            <td height=25>欢 迎 您：<%=_UserName %></td>
          </tr>
          <tr>
            <td height=25>您的身份：<%=_Admin %></td>
<%--          </tr>
      <tr>
            <td height=25>在线人数：<asp:Label ID="ZaiXainLB" runat="server" Text=""></asp:Label></td>
          </tr>--%>
        </table>
      </div>
    </td>
  </tr>
</table>

<table cellpadding=0 cellspacing=0 width=167 align=center>
  <tr>
    <td height=28 class=menu_title onmouseover=this.className='menu_title2'; onmouseout=this.className='menu_title'; background='Images/Admin_left_1.gif' id=menuTitle1 onClick="new Element.toggle('submenu1')" style='cursor:hand;'><span class=glow>文章中心管理</span></td>
  </tr>
  <tr>
    <td style='display:compact' align='right' id='submenu1'><div class=sec_menu style='width:165'>
        <table cellpadding=0 cellspacing=0 align=center width=130>
          <tr>
            <td height="20"><a href="Article.aspx" target="main">添加文章</a></td>
          </tr>
           <tr>
            <td height="20"><a href="NewsUnPass.aspx" target="main">文章审核</a></td>
          </tr>
          <tr>
            <td height="20"><a href="NewsList.aspx" target="main">文章管理</a></td>
          </tr>
          <tr>
            <td height="20"><a href="NewsMe.aspx" target="main">我审核的文章</a></td>
          </tr>
           <tr>
            <td height="20"><a href="ToIndexHtml.aspx" target="main">生成首页</a></td>
        </tr>
		  <tr>
            <td height="20"><a href="Sdut_maker.aspx" target="main"><font color="#FF0000">生成学校首页</font></a></td>
        </tr>
        </table>
      </div>
        <div style='width:167'>
          <table cellpadding=0 cellspacing=0 align=center width=130>
            <tr>
              <td height=5></td>
            </tr>
          </table>
      </div></td>
  </tr>
</table>

<table cellpadding=0 cellspacing=0 width=167 align="center">
  <tr>
    <td height=28 class="menu_title" onmouseover="this.className='menu_title2'"; onmouseout=this.className='menu_title'; background='Images/Admin_left_3.gif' id=menuTitle3 onClick="new Element.toggle('submenu3')" style='cursor:hand;'>
        <span class="glow">多媒体管理</span></td></tr>
  <tr>
    <td style='display:none' align='right' id='submenu3'><div class="sec_menu" style='width:165'>
        <table cellpadding=0 cellspacing=0 align="center" width=130>
          <tr>
            <td height="20"><a href="PicUp.aspx" target="main">上传图片</a></td>
          </tr>
          <tr>
            <td height="20"><a href="VideoUpload.aspx" target="main">上传视频音乐</a></td>
          </tr>
          <tr>
            <td height="20"><a href="PicTouGao.aspx" target="main">投稿图片管理 </a></td></tr>
          <tr>
            <td height="20"><a href="PicsAndFlash.aspx" target="main">首页图片管理</a></td>
        </tr>
        <tr>
            <td height="20"><a href="VideoManage.aspx"target="main">视频音乐管理</a></td>
        </tr>
        </table>
      </div>
        <div style='width:167'>
          <table cellpadding="0" cellspacing="0" align="center" width="130">
            <tr>
              <td height=5></td>
            </tr>
          </table>
      </div></td>
  </tr>
</table>

<table cellpadding=0 cellspacing=0 width=167 align=center>
  <tr>
    <td height=28 class=menu_title onmouseover=this.className='menu_title2'; onmouseout=this.className='menu_title'; background='Images/Admin_left_1.gif' id=Td1 onClick="new Element.toggle('Td2')" style='cursor:hand;'><span class="glow"><a href="ZtXuanZe.aspx" target="main">专题管理</a></span></td>
  </tr>
  <tr>
    <td style="display:none" align='right' id='Td2'><div class=sec_menu style='width:165'>
        <table cellpadding="0" cellspacing=0 align="center" width="130">          
          <%-- <tr>
            <td height="20"><a href="ZtXuanZe.aspx" target="main">选择专题</a></td>
          </tr>--%>
          <tr>
            <td height="20"><a href="ZtArticle.aspx"target="main">添加专题文章</a></td>
          </tr>
          <tr>
            <td height="20"><a href="ZtlistUnpass.aspx" target="main">专题文章审核</a></td>
          </tr>
          <tr>
            <td height="20"><a href="Ztlist.aspx" target="main">专题文章管理</a></td>
          </tr>
          <tr>
            <td height="20"><a href="ZtToIndex.aspx" target="main">生成专题首页</a></td>
        </tr>
        <tr>
            <td height="20"><a href="ZtToHtml2.aspx" target="main">生成二级页面</a></td>
        </tr>
        <tr>
            <td height="20"><a href="ZTManage.aspx" target="main">专题管理</a></td>
        </tr>
       </table>
      </div>
        <div style='width:167'>
          <table cellpadding=0 cellspacing=0 align="center" width=130>
            <tr>
              <td height=5></td>
            </tr>
          </table>
      </div></td>
  </tr>
</table>

<table cellpadding="0" cellspacing="0" width="167" align="center">
  <tr>
    <td height="28" class="menu_title" onmouseover="this.className='menu_title2'"; onmouseout="this.className='menu_title'";  id=Td3 onClick="new Element.toggle('jingtai')" style="cursor:hand; background-image: url('Images/admin_left_4.gif')"><span class=glow>静态页管理</span></td>
  </tr>
  <tr>
    <td style='display:none' align='right' id='jingtai'><div class="sec_menu" style='width:165'>
        <table cellpadding=0 cellspacing=0 align="center" width=130>
        <tr>
            <td height="20"><a href="ToHtml23.aspx" target="main">生成二三级页面</a></td>
        </tr>          
      </table>
      </div>
        <div  style='width:167'>
          <table cellpadding=0 cellspacing=0 align="center">
            <tr>
              <td height=5></td>
            </tr>
          </table>
      </div></td>
  </tr>
</table>

<table cellpadding="0" cellspacing="0" width="167" align="center">
  <tr>
    <td height="28" class="menu_title" onmouseover="this.className='menu_title2'"; onmouseout="this.className='menu_title'"; background='Images/admin_left_11.gif' id="menuTitle203" onClick="new Element.toggle('submenu203')" style='cursor:hand;'><span class=glow>用户管理</span></td>
  </tr>
  <tr>
    <td style='display:none' align='right' id='submenu203'><div class="sec_menu" style='width:165'>
        <table cellpadding=0 cellspacing=0 align="center" width=130>
        <tr>
            <td height="20"><a href="UserManage.aspx" target="main">用户管理</a></td>
        </tr>
          <tr>
            <td height="20"><a href="UsersShow.aspx" target="main">管理员列表</a></td>
          </tr>
          <tr>
            <td height="20"><a href="UserEdit.aspx" target="main">用户资料修改</a></td>
          </tr>
          </table>
      </div>
        <div  style='width:167'>
          <table cellpadding=0 cellspacing=0 align="center">
            <tr>
              <td height=5></td>
            </tr>
          </table>
      </div>
     </td>
  </tr>
</table>

<table cellpadding="0" cellspacing="0" width="167" align="center">
  <tr>
    <td height="28" class="menu_title" onmouseover="this.className='menu_title2'"; onmouseout="this.className='menu_title'"; background='Images/Admin_left_04.gif' id="Td4" onClick="new Element.toggle('lianjie')" style="cursor:hand; "><span class="glow">频道管理</span></td>
  </tr>
  <tr>
    <td style='display:none' align='right' id="lianjie"><div class="sec_menu" style='width:165'>
        <table cellpadding=0 cellspacing=0 align="center" width=130>        
        <tr>
            <td height="20"><a href="http://lgwindow.sdut.edu.cn/Campus/manage/Administrator/UserLogin.aspx" target="_blank">校园文化</a></td>
          </tr>
          <tr>
            <td height="20"><a href="../../photo/admin/manage.aspx" target="main">光影理工</a></td>
          </tr>
          <tr>
            <td height="20"><a href="../../karat/admin/index.aspx" target="main">卡瑞特工作室</a></td>
        </tr>
          <tr>
            <td height="20"><a href="http://lgwindow.sdut.edu.cn/fleamarket/admin/admin_login.aspx" target="_blank">跳蚤市场</a></td>
        </tr>
          
          </table>
      </div>
        <div  style='width:167'>
          <table cellpadding=0 cellspacing=0 align="center">
            <tr>
              <td height=5></td>
            </tr>
          </table>
      </div></td>
  </tr>
</table>

<table cellpadding="0" cellspacing="0" width="167" align="center">
  <tr>
    <td height="28" class="menu_title" onmouseover=this.className='menu_title2'; onmouseout=this.className='menu_title'; background='Images/Admin_left_01.gif' id=menuTitle201 onClick="new Element.toggle('submenu201')" style='cursor:hand;'><span class=glow>系统设置</span></td>
  </tr>
  <tr>
    <td style='display:none' align='right' id='submenu201'><div class="sec_menu" style='width:165'>
        <table cellpadding=0 cellspacing=0 align="center" width="130px">
        <tr>
                <td height="20">
                    <a href="PowerManage.aspx" target="main">权限管理</a></td>
            </tr>
		<%-- <tr>
                <td height="20">
                    <a href="ClassManage.aspx" target="main">栏目设置</a></td>
            </tr>--%>
            <tr>
            <td height="20"><a href="XueYuan.aspx" target="main">机构管理</a></td>
        </tr>
        <tr>
            <td height="20"><a href="AuditCount.aspx" target="main">审核统计</a></td>
        </tr>
        <tr>
            <td height="20"><a href="AdminCounter/admin_counter.aspx" target="main">访问统计</a></td>
        </tr>
        <tr>
            <td height="20"><a href="PicToutiao.aspx" target="main">头条样式设置</a></td>
        </tr>
	 <tr>
          <td height="20">
            <a href="NotesManage.aspx" target="main">添加管理员公告</a></td>
            </tr>
            	 <tr>
          <td height="20">
            <a href="../../TouGao/TouGaoManage.aspx" target="main">添加投稿通知</a></td>
            </tr>
            <tr>
          <td height="20">
            <a href="blog.aspx" target="main">申请授权</a></td>
            </tr>
        </table>
      </div>
        <div style='width:167'>
          <table cellpadding=0 cellspacing=0 align=center width=130>
            <tr>
              <td height=5></td>
            </tr>
          </table>
      </div></td>
  </tr>
</table>
<table cellpadding=0 cellspacing=0 width=167 align=center>  
  <tr>
    <td align='right'><div class=sec_menu style='width:165'>
        <table cellpadding=0 cellspacing=0 align=center width=130>
          <tr>
            <td height=20><br>
              版权所有：&nbsp;&nbsp;&nbsp;理工视窗<br/>
              <br>
            </td>
          </tr>
        </table>
    </div></td>
  </tr>
</table>
</body>
</html>