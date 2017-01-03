<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_NewsTongJi" Codebehind="NewsTongJi.aspx.cs" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="Inc/Admin_Style.Css" rel="stylesheet" type="text/css" />
    <title>审核统计详细信息</title>
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
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:center;">
   <table width="95%" border="0" cellspacing="0" cellpadding="0">
  <tr class="title"><td width="12%"  colspan="2">提示信息：<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
    
  </tr>  
    <tr>
    <td align="center" colspan="2">
    <table width="100%" border="0" align="center" cellpadding="0" cellspacing="1" class="border">
        <tr class="title" height="30px">
          <td width="8%" align="center"><strong>所属栏目</strong></td>
          <td height="22" width="55%" align="center"><strong>文章标题名称和日期</strong></td>
          <td width="13%px" align="center"><strong>作者</strong></td>
          <td width="6%" align="center"><strong>审核人</strong></td>
          <td width="18%"  align="center"><strong>来源</strong></td>
        </tr>
    <asp:Repeater ID="NewsList" runat="server">
        <ItemTemplate>
            <tr class="tdbg" onMouseOut="this.className='tdbg'" onMouseOver="this.className='tdbg2'">
              <td align="center"><%# DataBinder.Eval(Container.DataItem, "Caption") %></td>  
              <td align="left"><a href="<%#ToHtml.GetHtmlById(DataBinder.Eval(Container.DataItem, "Id").ToString())%>" title="<%#DataBinder.Eval(Container.DataItem, "Title") %>" target="_blank">&gt;&gt; <%#Mystring.lim_withoutPoint(DataBinder.Eval(Container.DataItem, "Title").ToString(),25) %>[<%#Convert.ToDateTime( DataBinder.Eval(Container.DataItem, "Datee")).ToString("yyyy-MM-dd") %>]</a></td>
              <td align="left"><%#Mystring.lim_withoutPoint(DataBinder.Eval(Container.DataItem, "Author").ToString(),7)%></td>
              <td align="left"><%#DataBinder.Eval(Container.DataItem, "Editor") %></td>
              <td align="center"><%# DataBinder.Eval(Container.DataItem, "Fro") %> </td>
            </tr>
        </ItemTemplate>
    </asp:Repeater>
    <tr class="title">
          <td align="center" colspan="5">
              <webdiyer:AspNetPager runat="server" ID="pager" 
            CustomInfoHTML="第%CurrentPageIndex%页，共%PageCount%页，每页%PageSize%条" 
            FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页" 
            ShowCustomInfoSection="Left" onpagechanging="pager_PageChanging" 
            PageSize="30" PageIndexBoxType="DropDownList" ShowPageIndexBox="Auto" 
                  SubmitButtonText="Go" TextAfterPageIndexBox="页" TextBeforePageIndexBox="转到"></webdiyer:AspNetPager></td>
      </tr>
     <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <tr class="tdbg" onMouseOut="this.className='tdbg'" onMouseOver="this.className='tdbg2'">
              <td align="center"><%# DataBinder.Eval(Container.DataItem, "Lanmu") %></td>  
              <td align="left"><a href="/Campus/News/news_<%#DataBinder.Eval(Container.DataItem, "id").ToString()%>.html" title="<%#DataBinder.Eval(Container.DataItem, "Title") %>" target="_blank">&gt;&gt; <%#Mystring.lim_withoutPoint(DataBinder.Eval(Container.DataItem, "Title").ToString(),25) %>[<%#Convert.ToDateTime( DataBinder.Eval(Container.DataItem, "Datee")).ToString("yyyy-MM-dd") %>]</a></td>
              <td align="left"><%#Mystring.lim_withoutPoint(DataBinder.Eval(Container.DataItem, "Author").ToString(),7)%></td>
              <td align="left"><%#DataBinder.Eval(Container.DataItem, "Editor") %></td>
              <td align="center"><%# DataBinder.Eval(Container.DataItem, "FromTo") %> </td>
            </tr>
            
        </ItemTemplate>
    </asp:Repeater>
    <tr class="title" >
          <td align="center" colspan="5" style="padding-top:25px; padding-bottom:5px;">
         <asp:Label ID="Label2" runat="server" Text="第" Visible="false"></asp:Label> <asp:label ID="lblCurrentPage" runat="server" Text="1" Visible="false"></asp:label>
          <asp:Label ID="Label3" runat="server" Text="页" Visible="false"></asp:Label>  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           
            <asp:Button ID="Button1" runat="server" Text="上一页" onclick="Button1_Click"  
                  Visible="false" BorderStyle="None"></asp:Button>
            &nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Button ID="Button2" runat="server" Text="下一页" onclick="Button2_Click"  
                  Visible="false" BorderStyle="None"></asp:Button>
             </td>
      </tr>
</table> 
    </div>
    </form>
</body>
</html>
