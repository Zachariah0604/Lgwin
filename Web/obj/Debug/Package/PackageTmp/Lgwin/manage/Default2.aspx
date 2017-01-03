<%@ Page Language="C#" AutoEventWireup="true" Inherits="Default2" Codebehind="Default2.aspx.cs" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="Inc/Admin_Style.Css" rel="stylesheet" type="text/css"></link>
    <title></title>
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
    <div style="text-align:center">
<table width="100%" border="0"  cellpadding="0" cellspacing="1" class="border" >
    <tr>
    <td colspan="7"><div style="width:10%; float:right"><asp:Button ID="Button1" 
            runat="server" Text="批量删除" onclick="Button1_Click" 
              style="height: 20px" onclientclick="return confirm('你确定要执行删除操作？')" /></div><div style="width:5%; float:right"><asp:Button ID="Button2" 
            runat="server" Text="添加" onclick="Button2_Click" 
              style="height: 20px"/></div></td>
  </tr>
  <tr  class="title" >
    <td height="30" width="5%"><div align="center"><asp:CheckBox ID="CheckAll" runat="server" 
                  onclick="javascript:SelectAll(this);" Text="全选" Width="50px" /></div></td>
    <td height="30" width="50%"><div align="center"><span lang="zh-cn">发现问题或改进意见</span></div></td>
    <td height="30" width="5%"><div align="center"><span lang="zh-cn">测试日期</span></div></td>
    <td height="30" width="5%"><div align="center"><span lang="zh-cn">发现人</span></div></td>
    <td height="30" width="10%"><div align="center"><span lang="zh-cn">解决办法</span></div></td>
    <td height="30" width="5%"><div align="center"><span lang="zh-cn">是否解决</span></div></td>
    <td height="30" width="5%"><div align="center"><span lang="zh-cn">解决人</span></div></td>
    
  </tr>
        <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
        <tr align="center" class="tdbg">    
    <td><asp:CheckBox ID="chkDelete"  runat="server"/><asp:HiddenField ID="HiddenField1" runat="server" Value='<%# Eval("id")%>'/></td>
    <td align="left"><a href="errorDetails.aspx?id=<%# DataBinder.Eval(Container.DataItem, "id") %>" title="<%#DataBinder.Eval(Container.DataItem, "problem") %>"> <%#Mystring.lim_withoutPoint(DataBinder.Eval(Container.DataItem, "problem").ToString(),53) %></a></td>
    <td><%# DataBinder.Eval(Container.DataItem, "time")%></td>
    <td><%# DataBinder.Eval(Container.DataItem, "observer")%></td>
    <td><%#Mystring.lim_withoutPoint(DataBinder.Eval(Container.DataItem, "solutions").ToString(),9) %></td>
    <td><%# DataBinder.Eval(Container.DataItem, "status")%></td>
    <td><%# DataBinder.Eval(Container.DataItem, "solver")%></td>
  </tr></ItemTemplate>
        </asp:Repeater>   
        <tr  class="title">
    <td colspan="7" class="style1">
   <asp:Label ID="Label2" runat="server" Text="当前页码"></asp:Label>
            [<asp:Label ID="labPage" runat="server" Text="1"></asp:Label>
            ]<asp:Label ID="Label4" runat="server" Text="总页数"></asp:Label>
            [<asp:Label ID="labBackPage" runat="server" Text="labBackPage"></asp:Label>
            ]<asp:LinkButton ID="lnkbtnOne" runat="server" OnClick="lnkbtnOne_Click" Font-Underline="False">第一页</asp:LinkButton>
        <asp:LinkButton ID="lnkbtnUp" runat="server" OnClick="lnkbtnUp_Click" Font-Underline="False">上一页</asp:LinkButton>
        <asp:LinkButton ID="lnkbtnNext" runat="server" OnClick="lnkbtnNext_Click" Font-Underline="False">下一页</asp:LinkButton>
        <asp:LinkButton ID="lnkbtnBack" runat="server" OnClick="lnkbtnBack_Click" Font-Underline="False">最后一页</asp:LinkButton>
        </span><asp:Label ID="Label1" runat="server" Text="" Visible="false"></asp:Label></td>
  </tr>
</table>
      </div>
      <div style="text-align:left; height:110px">
          <asp:Panel ID="Panel2" runat="server" Width="800px" Height="150px">
          <div style="width:10%; height:100px; float:left; text-align:right">问题或建议：</div><div style="width:45%; height:100px; float:left"><asp:TextBox 
              ID="tb_problem" runat="server" Height="100px" TextMode="MultiLine" 
              Width="264px"></asp:TextBox><div style="width:15%; height:100px; float:left; text-align:right"><asp:Button ID="Button3" runat="server" 
                          Text="提交" onclick="Button3_Click" /></div></div> </asp:Panel>
      </div>
    </form>
</body>
</html>
