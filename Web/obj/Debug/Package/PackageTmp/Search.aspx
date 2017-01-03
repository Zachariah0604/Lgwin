<%@ Page Language="C#" AutoEventWireup="true" Inherits="Search1" Codebehind="Search.aspx.cs" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
    <title>新闻搜索--山东理工大学新闻网</title>
<link href="images/index/TopFooter.css" rel="stylesheet" type="text/css" />
<link href="images/news/news.css" rel="stylesheet" type="text/css" />
</head>
<body style="margin-top:3px;">
    <form id="form1" runat="server">
    <div>
    <iframe src="images/Top.html" width="1000px" height="220" scrolling="No" frameborder="0" ></iframe>
    <div id="content" class="Bord">
    <div align="left" id="menutop" style="padding-bottom:10px; padding-top:10px;"><span style="color: #000000">您的搜索条件为：</span><asp:Label ID="caption" runat="server"></asp:Label>
</div>
      <div valign="top">
      <div><table style="width: 708px"><tr class="title" style="padding-top:8px; padding-bottom:8px;">
          <td width="55%" align="center"><strong>新闻标题</strong></td>
          <td width="15%" align="center"><strong>新闻作者</strong></td>
          <td width="15%" align="center"><strong>新闻来源</strong></td>
          <td width="15%" height="22" align="center"><strong>发布日期</strong></td>
        </tr></table></div>
         <table width="708px"  border="0"  valign="top" class="border" align="center" cellpadding="0" cellspacing="0" >
       
    <asp:Repeater ID="NewsList" runat="server">
        <ItemTemplate>
            <tr class="tdbg" >
              <td align="left"><a href="<%#ToHtml.GetHtmlById(DataBinder.Eval(Container.DataItem, "Id").ToString())%>" title="<%#DataBinder.Eval(Container.DataItem, "Title") %>"  target="_blank" onMouseOut="this.className='tdbg'" onMouseOver="this.className='tdbg2'">&gt;&gt; <%#Mystring.lim_withoutPoint(DataBinder.Eval(Container.DataItem, "Title").ToString(),23) %></a></td>
              <td align="center"><%#Mystring.lim_withoutPoint(DataBinder.Eval(Container.DataItem, "Author").ToString(),4)%></td>               
              <td align="center"><%#Mystring.lim_withoutPoint(DataBinder.Eval(Container.DataItem, "Fro").ToString(),5)%></td>
              <td align="center">[<%#Convert.ToDateTime( DataBinder.Eval(Container.DataItem, "Datee")).ToString("yy-MM-dd")%>]</td>
            </tr>
        </ItemTemplate>
    </asp:Repeater>
    <tr class="title">
          <td align="center" colspan="4" style="padding-top:25px; padding-bottom:5px;">
              <webdiyer:AspNetPager runat="server" ID="pager" 
            CustomInfoHTML="第%CurrentPageIndex%页，共%PageCount%页，每页%PageSize%条" 
            FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页" 
            ShowCustomInfoSection="Left" onpagechanging="pager_PageChanging" 
            PageSize="25"></webdiyer:AspNetPager></td>
      </tr>
     </table>
          <table width="708px"  border="0"  valign="top" class="border" align="center" cellpadding="0" cellspacing="0" >
        
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <tr class="tdbg" >
             <td align="left"width="55%" ><a href="../Campus/News/news_<%#DataBinder.Eval(Container.DataItem, "id").ToString()%>.html" title="<%#DataBinder.Eval(Container.DataItem, "Title") %>"  target="_blank" onMouseOut="this.className='tdbg'" onMouseOver="this.className='tdbg2'">&gt;&gt; <%#Mystring.lim_withoutPoint(DataBinder.Eval(Container.DataItem, "Title").ToString(),15) %></a></td>
              <td align="center" width="15%"><%#Mystring.lim_withoutPoint(DataBinder.Eval(Container.DataItem, "Author").ToString(),4)%></td>               
              <td align="center" width="15%"><%#Mystring.lim_withoutPoint(DataBinder.Eval(Container.DataItem, "FromTo").ToString(),5)%></td>
              <td align="center" width="13%" ><%#Mystring.lim_withoutPoint(DataBinder.Eval(Container.DataItem, "Datee").ToString(),10)%></td>
            </tr>
        </ItemTemplate>
    </asp:Repeater>
     <tr class="title" >
          <td align="center" colspan="3" style="padding-top:25px; padding-bottom:5px;">
         <asp:Label ID="Label1" runat="server" Text="第" Visible="false"></asp:Label> <asp:label ID="lblCurrentPage" runat="server" Text="1" Visible="false"></asp:label>
          <asp:Label ID="Label2" runat="server" Text="页" Visible="false"></asp:Label>  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           
            <asp:Button ID="Button1" runat="server" Text="上一页" onclick="Button1_Click"  
                  Visible="false" BorderStyle="None"></asp:Button>
            &nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Button ID="Button2" runat="server" Text="下一页" onclick="Button2_Click"  
                  Visible="false" BorderStyle="None"></asp:Button>
             </td>
      </tr>
     </table>
        </div>
    </div>
<iframe src="images/Right.html" width="280" height="760" style=" float:right;" scrolling="No" align="left" frameborder="0"></iframe>
<iframe src="images/Footer.html" width="1000" height="110" scrolling="No" frameborder="0"></iframe>
    </div>
 
    </form>
    
</body>
</html>

