<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_NewsList" Codebehind="NewsList.aspx.cs" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<html>
<head runat="server">
    <title>新闻列表</title>
<link href="Inc/Admin_Style.Css" rel="stylesheet" type="text/css">
</head>
<script type="text/javascript">
  function SelectAll(tempControl)
  {
  //将除头模板中的其它所有的CheckBox取反  
  var theBox=tempControl;
  xState=theBox.checked;   
  elem=theBox.form.elements;
  for(i=0;i<elem.length;i++)
  if(elem[i].type=="checkbox" && elem[i].id!=theBox.id)
  {
  if(elem[i].checked!=xState)
  elem[i].click();
  }
  }   
  </script>
<body style="margin-top:10px">
    <form id="form1" runat="server">
    <div>
    <table width="100%" border="0" cellspacing="0" cellpadding="0" style="font-size:16px; font-weight:bold;">
  <tr>
    <td  style="padding-left:40px;">请选择栏目：<asp:DropDownList ID="caption" runat="server" 
            AutoPostBack="True" onselectedindexchanged="caption_SelectedIndexChanged"></asp:DropDownList> 
   &nbsp; 
  <%-- <asp:TextBox ID="txt_search" runat="server"></asp:TextBox>
   &nbsp;<asp:Button ID="btn_search" runat="server" Text="搜索文章" onclick="btn_search_Click" />--%></td>
 
    <td align="right">&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Text="批量静态化" onclick="Button1_Click" /></td>
  </tr>
</table>
      <table width="100%" border="0" align="center" cellpadding="0" cellspacing="1" class="border">
        <tr class="title">
          <td width="50px" align="center"><asp:CheckBox ID="CheckAll" runat="server" 
                  onclick="javascript:SelectAll(this);" Text="全选" Width="50px" /></td>
          <td height="22" align="center"><strong>文章标题名称</strong></td>
          <td width="100px" align="center"><strong>来源</strong></td>
          <td width="50px" align="center"><strong>作者</strong></td>
          <td width="50px" align="center"><strong>审核人</strong></td>
          <td width="255" height="22" align="center"><strong>操作选项</strong></td>
        </tr>
    <asp:Repeater ID="NewsList" runat="server">
        <ItemTemplate>
            <tr class="tdbg" onMouseOut="this.className='tdbg'" onMouseOver="this.className='tdbg2'">
              <td align="center">
               <input type="checkbox" name="cbxID" value='<%# Eval("Id") %>' />
              </td>  
              <td><a href="Article.Aspx?Id=<%# DataBinder.Eval(Container.DataItem, "Id") %>" title="<%#DataBinder.Eval(Container.DataItem, "Title") %>">&gt;&gt; <span style="color:Black"><%#Mystring.lim_withoutPoint(DataBinder.Eval(Container.DataItem, "Title").ToString(),25) %>[<%#Convert.ToDateTime( DataBinder.Eval(Container.DataItem, "Datee")).ToString("yy-MM-dd") %>]</span></a></td>
              <td align="center"><%# DataBinder.Eval(Container.DataItem, "Fro")%></td>
              <td align="left"><%# DataBinder.Eval(Container.DataItem, "Author")%></td>
              <td align="left"><%# DataBinder.Eval(Container.DataItem, "Editor") %></td>
              <td align="center">
              <a href="?Id=<%# DataBinder.Eval(Container.DataItem, "Id") %>&Action=<%# Convert.ToBoolean(Eval("Yaowen")) ?"YaowenFalse" :"YaowenTrue"%>" class="<%#  Eval("Yaowen").ToString() %>">头条</a>-
              <a href="?Id=<%# DataBinder.Eval(Container.DataItem, "Id") %>&Action=<%# Convert.ToBoolean(Eval("Tuwen")) ?"TuwenFalse" :"TuwenTrue"%>" class="<%#  Eval("Tuwen").ToString() %>">图文</a>-
              <a href="?Id=<%# DataBinder.Eval(Container.DataItem, "Id") %>&Action=<%# Convert.ToBoolean(Eval("Sdut")) ?"SdutFalse" :"SdutTrue"%>" class="<%#  Eval("Sdut").ToString() %>">学校首页</a>-
              <a href="?Id=<%# DataBinder.Eval(Container.DataItem, "Id") %>&Action=<%# Convert.ToBoolean(Eval("SdutPic")) ?"SdutPicFalse" : "SdutPicTrue"%>" class="<%#  Eval("SdutPic").ToString() %>">Sdut图文</a>-
              <a href="<%#ToHtml.GetHtmlById(DataBinder.Eval(Container.DataItem, "Id").ToString())%>" class="False" target="_blank" >预览</a>----
              <a href="?Id=<%# DataBinder.Eval(Container.DataItem, "Id") %>&Action=Del" " class="False" onclick="return confirm('你确定要执行删除操作？该操作会删除记录包含的图片，静态页面，缩略图等相关信息')">删除</a>
              </td>
            </tr>
        </ItemTemplate>
    </asp:Repeater>
    <tr class="title">
          <td align="center" colspan="6"><webdiyer:AspNetPager runat="server" ID="pager" 
            CustomInfoHTML="第%CurrentPageIndex%页，共%PageCount%页，每页%PageSize%条" 
            FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页" 
            ShowCustomInfoSection="Left" onpagechanging="pager_PageChanging" 
            PageSize="20" PageIndexBoxType="DropDownList" ShowPageIndexBox="Auto" 
                  SubmitButtonText="Go" TextAfterPageIndexBox="页" 
                  TextBeforePageIndexBox="转到" HorizontalAlign="Center" NumericButtonCount="8"></webdiyer:AspNetPager>
              <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label></td>
      </tr>
     </table>
     <div style="text-align:right">
        <asp:Button ID="DelAll" runat="server" Text="批量删除" onclick="DelAll_Click"/>
     </div>
</div>
    </form>
</body>
</html>
