<%@ Page Language="C#" AutoEventWireup="true" Inherits="karat1_admin_KaratBaoMingManage" Codebehind="KaratBaoMingManage.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<link href="../css/karat.Css" rel="stylesheet" type="text/css"></link>
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 5%;
        }
        .style2
        {
            width: 7%;
        }
        .style3
        {
            width: 6%;
        }
    </style>
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
<body>
    <form id="form1" runat="server">
     <div style="text-align:center">
<table width="100%" border="0"  cellpadding="0" cellspacing="1" class="border" >
    <tr>
    <td colspan="8"><div style="width:10%; float:right"><asp:Button ID="Button1" 
            runat="server" Text="批量删除" onclick="Button1_Click" 
              style="height: 20px" onclientclick="return confirm('你确定要执行删除操作？')" /></div></td>
  </tr>
  <tr  class="title" >
    <td height="30" width="5%"><div align="center"><asp:CheckBox ID="CheckAll" runat="server" 
                  onclick="javascript:SelectAll(this);" Text="全选" Width="50px" /></div></td>
    <td height="30" width="10%"><div align="center"><span lang="zh-cn">姓名</span></div></td>
    <td height="30" class="style3"><div align="center"><span lang="zh-cn">性别</span></div></td>
    <td height="30" width="10%"><div align="center"><span lang="zh-cn">校区</span></div></td>
    <td height="30" class="style2"><div align="center"><span lang="zh-cn">是否有电脑</span></div></td>
    <td height="30" width="10%"><div align="center"><span lang="zh-cn">应聘职位</span></div></td>
    <td height="30" width="15%"><div align="center"><span lang="zh-cn">电话</span></div></td>
        <td height="30" width="15%"><div align="center"><span lang="zh-cn">报名时间</span></div></td>
    <td height="30" width="25%"><div align="center"><span lang="zh-cn">简介</span></div></td>
    
  </tr>
        <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
        <tr align="center" class="tdbg">    
    <td><asp:CheckBox ID="chkDelete"  runat="server"/><asp:HiddenField ID="HiddenField1" runat="server" Value='<%# Eval("ID")%>'/></td>
    <td align="center"><a href="Baoming2013.aspx?Id=<%# DataBinder.Eval(Container.DataItem, "Id") %>" title="<%#DataBinder.Eval(Container.DataItem, "name") %>" target="_blank"> >><%#DataBinder.Eval(Container.DataItem, "name") %></a></td>
    <td><%# DataBinder.Eval(Container.DataItem, "sex")%></td>
    <td><%# DataBinder.Eval(Container.DataItem, "xiaoqu")%></td>
    <td><%# DataBinder.Eval(Container.DataItem, "diannao")%></td>
    <td><%# DataBinder.Eval(Container.DataItem, "zhiwei")%></td>
    <td><%# DataBinder.Eval(Container.DataItem, "tel")%></td>
    <td><%# Convert.ToDateTime(DataBinder.Eval(Container.DataItem, "datee")).ToString("yyyy-MM:dd")%></td>
    <td><%#Mystring.lim_withoutPoint(DataBinder.Eval(Container.DataItem, "jingli").ToString(),25)%></td>
  </tr></ItemTemplate>
        </asp:Repeater>   
        <tr  class="title">
     <td colspan="9" class="style1">
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
    </form>
</body>
</html>
