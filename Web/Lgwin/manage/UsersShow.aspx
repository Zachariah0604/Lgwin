<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_UserShow" Codebehind="UsersShow.aspx.cs" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="Inc/Admin_Style.Css" rel="stylesheet" type="text/css"/>
    <title>成员显示</title>
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
    <table width="90%" align="center">
    <tr> <td><asp:TextBox ID="txt_search" runat="server"></asp:TextBox><asp:Button ID="btn_search" runat="server" Text="搜索成员" 
            onclick="btn_search_Click" /></td></tr>
  <tr class="tdbg">
    <td><asp:DataList ID="DataList1" runat="server" RepeatColumns="2" Width="100%" 
            style="margin-bottom: 0px;" 
            RepeatDirection="Horizontal">
        <ItemTemplate>
        <table width="100%" border="0" align="center">
  <tr class="tdbg">
    <td><table width="100%" border="0" align="center" cellpadding="0" cellspacing="1" style="height:170px" class="border" >
  <tr class="tdbg">
    <td rowspan="7" align="center" width="40%" style="padding-bottom:5px">
        <a href="UserDetail.aspx?User=<%# DataBinder.Eval(Container.DataItem, "UserName") %> ""><asp:Image ID="Img" runat="server" ImageUrl='<%#Eval("Img") %>' Width="100px" Height="125px" /></a></td>
    <td align="right" width="20%">年级：</td>
    <td><%# DataBinder.Eval(Container.DataItem,"Nianji") %></td>
  </tr>
  <tr class="tdbg">
    <td align="right">学号：</td>
    <td><%# DataBinder.Eval(Container.DataItem,"Xuehao") %></td>
  </tr>
  <tr class="tdbg">
    <td align="right">生日：</td>
    <td><%#Mystring.dateStr(DataBinder.Eval(Container.DataItem,"Birthday"),"yyyy-MM-dd") %></td>
  </tr>
  <tr class="tdbg">
    <td align="right">Q Q：</td>
    <td><%# DataBinder.Eval(Container.DataItem,"QQ") %></td>
  </tr>
  <tr class="tdbg">
    <td align="right">电话：</td>
    <td><%# DataBinder.Eval(Container.DataItem,"Tel") %></td>
  </tr>
  <tr class="tdbg">
    <td align="right">邮箱：</td>
    <td><%# DataBinder.Eval(Container.DataItem,"Email") %></td>
  </tr>
  <tr class="tdbg">
    <td align="right">班级：</td>
    <td><%# DataBinder.Eval(Container.DataItem,"Zybj") %></td>
  </tr>
  <tr class="tdbg">
    <td align="center"><%# DataBinder.Eval(Container.DataItem,"Zhiwu") %>：<%# DataBinder.Eval(Container.DataItem,"Name") %></td>
    <td align="right">籍贯：</td>
    <td><%# DataBinder.Eval(Container.DataItem,"Jiguan") %></td>
  </tr>
</table></td>
  </tr>
</table>
        </ItemTemplate>      
        </asp:DataList></td>
  </tr>
  <tr align="center" class="title">
    <td><webdiyer:AspNetPager runat="server" ID="pager" 
            CustomInfoHTML="共%PageCount%页，当前为第%CurrentPageIndex%页，每页%PageSize%条" 
            FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页" 
            ShowCustomInfoSection="Left" onpagechanging="pager_PageChanging" 
            PageSize="6" PageIndexBoxType="DropDownList" ShowPageIndexBox="Auto" 
            SubmitButtonText="Go" TextAfterPageIndexBox="页" TextBeforePageIndexBox="转到"></webdiyer:AspNetPager></td>
  </tr>
</table> </div>
    </form>
</body>
</html>
