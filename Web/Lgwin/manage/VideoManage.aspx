<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_VideoManage" Codebehind="VideoManage.aspx.cs" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="Inc/Admin_Style.Css" rel="stylesheet" type="text/css">
    <title>无标题页</title>
</head>
<body style="margin-top:10px">
    <form id="form1" runat="server">
    <div>        
   <table width="95%" border="0" cellspacing="0" cellpadding="0">
  <tr><td width="15%"></td>
    <td align="right" style="padding-bottom:5px;">
        <asp:Button ID="DelAll" runat="server" Text="批量删除" onclick="DelAll_Click" 
            onclientclick="return confirm('你确定要执行删除操作？')" Height="15px" />&nbsp;&nbsp;</td>
  </tr>
  <tr><td>请选择文件类型：</td>
    <td><asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" 
            onselectedindexchanged="RadioButtonList1_SelectedIndexChanged1" 
            RepeatDirection="Horizontal">
        <asp:ListItem Value="0">视频</asp:ListItem>
        <asp:ListItem Value="1">音频</asp:ListItem>
        </asp:RadioButtonList>
    </td>
  </tr>
    <tr>
    <td align="center" colspan="2">
    <table width="100%" border="0" align="center" cellpadding="0" cellspacing="1" class="border">
        <tr class="title">
          <td width="5%px" align="center"><asp:CheckBox ID="CheckAll" runat="server" 
                  onclick="javascript:SelectAll(this);" Text="全选" Width="50px" /></td>
          <td width="40%" height="22" align="center"><strong>视频名称</strong></td>
          <td width="10%" align="center">上传者</td>
          <td width="11%" height="22" align="center"><strong>上传时间</strong></td>
          <td width="12%" height="22" align="center"><strong>视频来源</strong></td>
          <td width="7%" height="22" align="center"><strong>点击量</strong></td>
          <td width="15%" height="22" align="center"><strong>操作选项</strong></td>
        </tr>
    <asp:Repeater ID="NewsList" runat="server">
        <ItemTemplate>
            <tr class="tdbg" onMouseOut="this.className='tdbg'" onMouseOver="this.className='tdbg2'">
              <td align="center">
               <input type="checkbox" name="cbxID" value='<%# Eval("Id") %>' />
              </td>  
              <td align="left"><a href="VideoEdit.aspx?Id=<%# DataBinder.Eval(Container.DataItem, "Id") %>" title="<%#DataBinder.Eval(Container.DataItem, "Title") %>" >&gt;&gt; <%#Mystring.lim_withoutPoint(DataBinder.Eval(Container.DataItem, "Title").ToString(),25) %></a></td>
              <td align="center"><%# DataBinder.Eval(Container.DataItem, "Uploader") %></td>
              <td align="center">[<%#Convert.ToDateTime( DataBinder.Eval(Container.DataItem, "AddDate")).ToString("yyyy-MM-dd") %>]</td>
              <td align="center"><%# DataBinder.Eval(Container.DataItem, "From")%></td>
              <td align="center"><%# DataBinder.Eval(Container.DataItem, "HitNum")%></td>
              <td align="center">
              <a href="<%#ToHtml.GetVideoHtmlById(DataBinder.Eval(Container.DataItem, "Id").ToString())%>" class="False" target="_blank" >预览</a>-
              <a href="?Id=<%# DataBinder.Eval(Container.DataItem, "Id") %>&Action=Del" " class="False" onclick="return confirm('你确定要执行删除操作？')">删除</a>
              </td>
            </tr>
        </ItemTemplate>
    </asp:Repeater>
    <tr class="title">
          <td align="center" colspan="7"><webdiyer:AspNetPager runat="server" ID="pager" 
            CustomInfoHTML="第%CurrentPageIndex%页，共%PageCount%页，每页%PageSize%条" 
            FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页" 
            ShowCustomInfoSection="Left" onpagechanging="pager_PageChanging" 
            PageSize="20" PageIndexBoxType="DropDownList" ShowPageIndexBox="Auto" 
                  SubmitButtonText="Go" TextAfterPageIndexBox="页" 
                  TextBeforePageIndexBox="转到" NumericButtonCount="8"></webdiyer:AspNetPager></td>
      </tr>
     </table></td>
  </tr>
</table>
    </div>
    </form>
</body>
</html>
