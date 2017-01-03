<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_UserManage" Codebehind="UserManage.aspx.cs" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="Inc/Admin_Style.Css" rel="stylesheet" type="text/css"/>
    <title>无标题页</title>
     <script language="javascript" type="text/javascript">
         function EnterKeyClick(button) {

             if (event.keyCode == 13) {

                 event.keyCode = 9;

                 event.returnValue = false;

                 document.all[button].click();

             }

         }


  </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
   
    <table width="95%" align="center">
  <tr>
    <td><table width="100%" border="0" align="center" cellpadding="0" cellspacing="1" class="border" >
    <tr> <td><asp:TextBox ID="txt_search" runat="server"></asp:TextBox></td>
    <td><asp:Button ID="btn_search" runat="server" Text="搜索成员" 
            onclick="btn_search_Click" /></td></tr>
  <tr  class="title" >
    <td height="30" width="12%"><div align="center"><strong>姓名</strong></div></td>
    <td height="30" width="13%"><div align="center"><strong>身份</strong></div></td>
    <td height="30" width="10%"><div align="center"><strong>职务</strong></div></td>
    <td height="30" width="10%"><div align="center"><strong>QQ</strong></div></td>
    <td height="30" width="10%"><div align="center"><strong>电话</strong></div></td>
    <td height="30" width="20%"><div align="center"><strong>班级</strong></div></td>
    <td height="30" width="15%"><div align="center"><strong>家乡</strong></div></td>
  </tr>
        <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
        <tr align="center" class="tdbg">
    <td><a href="UserAdmin.aspx?User=<%#Server.UrlEncode(DataBinder.Eval(Container.DataItem, "UserName").ToString()) %>"><%# DataBinder.Eval(Container.DataItem, "Name")%></a></td>
    <td><a href="UserAdmin.aspx?User=<%#Server.UrlEncode(DataBinder.Eval(Container.DataItem, "UserName").ToString()) %>"><%#Mystring.adminStr(DataBinder.Eval(Container.DataItem, "Admin"))%>[<%#Mystring.zaizhiStr(DataBinder.Eval(Container.DataItem, "Zaizhi"))%>]</a></td>
    <td><%# DataBinder.Eval(Container.DataItem, "Zhiwu")%></td>
    <td><%# DataBinder.Eval(Container.DataItem, "QQ")%></td>
    <td><%# DataBinder.Eval(Container.DataItem, "Tel")%></td>
    <td><%# DataBinder.Eval(Container.DataItem, "Zybj")%></td>
    <td><%# DataBinder.Eval(Container.DataItem, "Jiguan")%></td>
  </tr></ItemTemplate>
        </asp:Repeater>
        <tr align="center"  class="title">
    <td colspan="7">
    <webdiyer:AspNetPager runat="server" ID="pager" 
            CustomInfoHTML="第%CurrentPageIndex%页，共%PageCount%页，每页%PageSize%条" 
            FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页" 
            ShowCustomInfoSection="Left" onpagechanging="pager_PageChanging" 
            PageSize="29"></webdiyer:AspNetPager></td>
  </tr>
</table></td>
  </tr>
</table>
      </div>
    </form>
</body>
</html>
