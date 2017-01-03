<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="blessmall.aspx.cs" Inherits="Lgwin.Lgwin.manage.blessmall" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>无标题页</title>
<link href="Inc/Admin_Style.Css" rel="stylesheet" type="text/css"/>
</head>
<script type="text/javascript">
    function SelectAll(tempControl) {
        //将除头模板中的其它所有的CheckBox取反  
        var theBox = tempControl;
        xState = theBox.checked;
        elem = theBox.form.elements;
        for (i = 0; i < elem.length; i++)
            if (elem[i].type == "checkbox" && elem[i].id != theBox.id) {
                if (elem[i].checked != xState)
                    elem[i].click();
            }
    }   
  </script>
<body style="margin-top:10px">
    <form id="form1" runat="server">
    <div align="center">        
 <table width="95%" border="0" cellspacing="0" cellpadding="0" class="border">
    <tr>
    <td align="center" colspan="2">
    <table width="100%" border="0" align="center" cellpadding="0" cellspacing="1" >
           <tr class="title">
         
          <td width="15%" height="22" align="center"><strong>作者</strong></td>
          <td width="70%" align="center"><strong>内容</strong></td>
          <td width="15%" height="22" align="center"><strong>操作选项</strong></td>
        </tr>
    <asp:Repeater ID="NewsList" runat="server">
        <ItemTemplate>
            <tr class="tdbg" onMouseOut="this.className='tdbg'" onMouseOver="this.className='tdbg2'">
             
              <td align="left"><%#DataBinder.Eval(Container.DataItem, "author")%></a></td>
              <td align="left"><%# DataBinder.Eval(Container.DataItem, "ccontent")%></td>
              <td align="center">
              <a href="?Id=<%# DataBinder.Eval(Container.DataItem, "Id") %>&Action=Del" " class="False" onclick="return confirm('你确定要执行删除操作？')">删除</a>
              </td>
            </tr>
        </ItemTemplate>
    </asp:Repeater>
    <tr class="title">
          <td align="center" colspan="4"><webdiyer:AspNetPager runat="server" ID="pager" 
            CustomInfoHTML="第%CurrentPageIndex%页，共%PageCount%页，每页%PageSize%条" 
            FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页" 
            ShowCustomInfoSection="Left" onpagechanging="pager_PageChanging" 
            PageSize="20" PageIndexBoxType="DropDownList" ShowPageIndexBox="Auto" 
                  SubmitButtonText="Go" TextAfterPageIndexBox="页" 
                  TextBeforePageIndexBox="转到" NumericButtonCount="8"></webdiyer:AspNetPager>
              <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label></td>
      </tr>
     </table></td>
  </tr>
</table>
    </div>
    </form>
</body>
</html>
