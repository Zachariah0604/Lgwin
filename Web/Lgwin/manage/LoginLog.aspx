<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginLog.aspx.cs" Inherits="Lgwin_manage_LoginLog" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language="javascript" src="Inc/selectDateTime.js" type="text/javascript"
        charset="utf-8"></script>
    <link href="Inc/Admin_Style.Css" rel="stylesheet" type="text/css">
    <script language="javascript" type="text/javascript">
        function empty1() {
            document.getElementById("tb_starttime").value = "";
      
        }
</script>
 <script language="javascript" type="text/javascript">
     function empty2() {
         document.getElementById("tb_endtime").value = "";

     }
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="tb_starttime" runat="server" Text="起始时间" onfocus="empty1();"></asp:TextBox>-
        <asp:TextBox ID="tb_endtime" runat="server" Text="截止时间"  onfocus="empty2();"></asp:TextBox>
        <asp:Button ID="btnsummit" runat="server" Text="查询" OnClick="btnsummit_Click" />
    </div>
    <div>
        <table>
            <tr>
                <td>
                    用户
                </td>
                <td>
                    登录时间
                </td>
            </tr>
            <tr>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                       <tr>
                            <td>
                                <%# DataBinder.Eval(Container.DataItem, "user")%>
                            </td>
                            <td>
                                <%#DataBinder.Eval(Container.DataItem,"time") %>
                            </td>
                     </tr>
                    </ItemTemplate>
                </asp:Repeater>
                <%-- <tr align="center" class="title">
                    <td colspan="7">
                        <webdiyer:aspnetpager runat="server" id="pager" custominfohtml="第%CurrentPageIndex%页，共%PageCount%页，每页%PageSize%条"
                            firstpagetext="首页" lastpagetext="尾页" nextpagetext="下一页" prevpagetext="上一页" showcustominfosection="Left"
                            onpagechanging="pager_PageChanging" pagesize="29"></webdiyer:aspnetpager>
                    </td>
                </tr>--%>
        </table>
    </div>
    </form>
</body>
</html>
