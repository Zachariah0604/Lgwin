<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_left" Codebehind="Left.aspx.cs" %>

<html>
<head>
<meta http-equiv='Content-Type' content='text/html; charset=gb2312'>
<title>�������˵�</title>
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
            <td height=25>�� ӭ ����<%=_UserName %></td>
          </tr>
          <tr>
            <td height=25>������ݣ�<%=_Admin %></td>
<%--          </tr>
      <tr>
            <td height=25>����������<asp:Label ID="ZaiXainLB" runat="server" Text=""></asp:Label></td>
          </tr>--%>
        </table>
      </div>
    </td>
  </tr>
</table>

<table cellpadding=0 cellspacing=0 width=167 align=center>
  <tr>
    <td height=28 class=menu_title onmouseover=this.className='menu_title2'; onmouseout=this.className='menu_title'; background='Images/Admin_left_1.gif' id=menuTitle1 onClick="new Element.toggle('submenu1')" style='cursor:hand;'><span class=glow>�������Ĺ���</span></td>
  </tr>
  <tr>
    <td style='display:compact' align='right' id='submenu1'><div class=sec_menu style='width:165'>
        <table cellpadding=0 cellspacing=0 align=center width=130>
          <tr>
            <td height="20"><a href="Article.aspx" target="main">�������</a></td>
          </tr>
           <tr>
            <td height="20"><a href="NewsUnPass.aspx" target="main">�������</a></td>
          </tr>
          <tr>
            <td height="20"><a href="NewsList.aspx" target="main">���¹���</a></td>
          </tr>
          <tr>
            <td height="20"><a href="NewsMe.aspx" target="main">����˵�����</a></td>
          </tr>
           <tr>
            <td height="20"><a href="ToIndexHtml.aspx" target="main">������ҳ</a></td>
        </tr>
		  <tr>
            <td height="20"><a href="Sdut_maker.aspx" target="main"><font color="#FF0000">����ѧУ��ҳ</font></a></td>
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
        <span class="glow">��ý�����</span></td></tr>
  <tr>
    <td style='display:none' align='right' id='submenu3'><div class="sec_menu" style='width:165'>
        <table cellpadding=0 cellspacing=0 align="center" width=130>
          <tr>
            <td height="20"><a href="PicUp.aspx" target="main">�ϴ�ͼƬ</a></td>
          </tr>
          <tr>
            <td height="20"><a href="VideoUpload.aspx" target="main">�ϴ���Ƶ����</a></td>
          </tr>
          <tr>
            <td height="20"><a href="PicTouGao.aspx" target="main">Ͷ��ͼƬ���� </a></td></tr>
          <tr>
            <td height="20"><a href="PicsAndFlash.aspx" target="main">��ҳͼƬ����</a></td>
        </tr>
        <tr>
            <td height="20"><a href="VideoManage.aspx"target="main">��Ƶ���ֹ���</a></td>
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
    <td height=28 class=menu_title onmouseover=this.className='menu_title2'; onmouseout=this.className='menu_title'; background='Images/Admin_left_1.gif' id=Td1 onClick="new Element.toggle('Td2')" style='cursor:hand;'><span class="glow"><a href="ZtXuanZe.aspx" target="main">ר�����</a></span></td>
  </tr>
  <tr>
    <td style="display:none" align='right' id='Td2'><div class=sec_menu style='width:165'>
        <table cellpadding="0" cellspacing=0 align="center" width="130">          
          <%-- <tr>
            <td height="20"><a href="ZtXuanZe.aspx" target="main">ѡ��ר��</a></td>
          </tr>--%>
          <tr>
            <td height="20"><a href="ZtArticle.aspx"target="main">���ר������</a></td>
          </tr>
          <tr>
            <td height="20"><a href="ZtlistUnpass.aspx" target="main">ר���������</a></td>
          </tr>
          <tr>
            <td height="20"><a href="Ztlist.aspx" target="main">ר�����¹���</a></td>
          </tr>
          <tr>
            <td height="20"><a href="ZtToIndex.aspx" target="main">����ר����ҳ</a></td>
        </tr>
        <tr>
            <td height="20"><a href="ZtToHtml2.aspx" target="main">���ɶ���ҳ��</a></td>
        </tr>
        <tr>
            <td height="20"><a href="ZTManage.aspx" target="main">ר�����</a></td>
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
    <td height="28" class="menu_title" onmouseover="this.className='menu_title2'"; onmouseout="this.className='menu_title'";  id=Td3 onClick="new Element.toggle('jingtai')" style="cursor:hand; background-image: url('Images/admin_left_4.gif')"><span class=glow>��̬ҳ����</span></td>
  </tr>
  <tr>
    <td style='display:none' align='right' id='jingtai'><div class="sec_menu" style='width:165'>
        <table cellpadding=0 cellspacing=0 align="center" width=130>
        <tr>
            <td height="20"><a href="ToHtml23.aspx" target="main">���ɶ�����ҳ��</a></td>
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
    <td height="28" class="menu_title" onmouseover="this.className='menu_title2'"; onmouseout="this.className='menu_title'"; background='Images/admin_left_11.gif' id="menuTitle203" onClick="new Element.toggle('submenu203')" style='cursor:hand;'><span class=glow>�û�����</span></td>
  </tr>
  <tr>
    <td style='display:none' align='right' id='submenu203'><div class="sec_menu" style='width:165'>
        <table cellpadding=0 cellspacing=0 align="center" width=130>
        <tr>
            <td height="20"><a href="UserManage.aspx" target="main">�û�����</a></td>
        </tr>
          <tr>
            <td height="20"><a href="UsersShow.aspx" target="main">����Ա�б�</a></td>
          </tr>
          <tr>
            <td height="20"><a href="UserEdit.aspx" target="main">�û������޸�</a></td>
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
    <td height="28" class="menu_title" onmouseover="this.className='menu_title2'"; onmouseout="this.className='menu_title'"; background='Images/Admin_left_04.gif' id="Td4" onClick="new Element.toggle('lianjie')" style="cursor:hand; "><span class="glow">Ƶ������</span></td>
  </tr>
  <tr>
    <td style='display:none' align='right' id="lianjie"><div class="sec_menu" style='width:165'>
        <table cellpadding=0 cellspacing=0 align="center" width=130>        
        <tr>
            <td height="20"><a href="http://lgwindow.sdut.edu.cn/Campus/manage/Administrator/UserLogin.aspx" target="_blank">У԰�Ļ�</a></td>
          </tr>
          <tr>
            <td height="20"><a href="../../photo/admin/manage.aspx" target="main">��Ӱ��</a></td>
          </tr>
          <tr>
            <td height="20"><a href="../../karat/admin/index.aspx" target="main">�����ع�����</a></td>
        </tr>
          <tr>
            <td height="20"><a href="http://lgwindow.sdut.edu.cn/fleamarket/admin/admin_login.aspx" target="_blank">�����г�</a></td>
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
    <td height="28" class="menu_title" onmouseover=this.className='menu_title2'; onmouseout=this.className='menu_title'; background='Images/Admin_left_01.gif' id=menuTitle201 onClick="new Element.toggle('submenu201')" style='cursor:hand;'><span class=glow>ϵͳ����</span></td>
  </tr>
  <tr>
    <td style='display:none' align='right' id='submenu201'><div class="sec_menu" style='width:165'>
        <table cellpadding=0 cellspacing=0 align="center" width="130px">
        <tr>
                <td height="20">
                    <a href="PowerManage.aspx" target="main">Ȩ�޹���</a></td>
            </tr>
		<%-- <tr>
                <td height="20">
                    <a href="ClassManage.aspx" target="main">��Ŀ����</a></td>
            </tr>--%>
            <tr>
            <td height="20"><a href="XueYuan.aspx" target="main">��������</a></td>
        </tr>
        <tr>
            <td height="20"><a href="AuditCount.aspx" target="main">���ͳ��</a></td>
        </tr>
        <tr>
            <td height="20"><a href="AdminCounter/admin_counter.aspx" target="main">����ͳ��</a></td>
        </tr>
        <tr>
            <td height="20"><a href="PicToutiao.aspx" target="main">ͷ����ʽ����</a></td>
        </tr>
	 <tr>
          <td height="20">
            <a href="NotesManage.aspx" target="main">��ӹ���Ա����</a></td>
            </tr>
            	 <tr>
          <td height="20">
            <a href="../../TouGao/TouGaoManage.aspx" target="main">���Ͷ��֪ͨ</a></td>
            </tr>
            <tr>
          <td height="20">
            <a href="blog.aspx" target="main">������Ȩ</a></td>
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
              ��Ȩ���У�&nbsp;&nbsp;&nbsp;���Ӵ�<br/>
              <br>
            </td>
          </tr>
        </table>
    </div></td>
  </tr>
</table>
</body>
</html>