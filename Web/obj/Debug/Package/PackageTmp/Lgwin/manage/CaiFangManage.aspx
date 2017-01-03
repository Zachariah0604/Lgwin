<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_CaiFangManage" Codebehind="CaiFangManage.aspx.cs" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<link href="Inc/Admin_Style.Css" rel="stylesheet" type="text/css"></link>
    <title>无标题页</title>
    <style type="text/css">
        .style1
        {
            height: 31px;
        }
    </style>
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
    <div style="text-align:center">
<table width="100%" border="0"  cellpadding="0" cellspacing="1" class="border" >
    <tr>
    <td colspan="6"><div style="width:10%; float:right"></div></td>
  </tr>
  <tr  class="title" >
    <td height="30" width="5%"><div align="center"><asp:CheckBox ID="CheckAll" runat="server" 
                  onclick="javascript:SelectAll(this);" Text="全选" Width="50px" /></div></td>
    <td height="30" width="30%"><div align="center"><span lang="zh-cn">活动主题</span></div></td>
    <td height="30" width="15%"><div align="center"><span lang="zh-cn">时间</span></div></td>
    <td height="30" width="15%"><div align="center"><span lang="zh-cn">地点</span></div></td>
    <td height="30" width="15%"><div align="center"><span lang="zh-cn">单位</span></div></td>
    <td height="30" width="20%"><div align="center"><span lang="zh-cn">出席领导</span></div></td>
    
  </tr>
        <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
        <tr align="center" class="tdbg">    
    <td><asp:CheckBox ID="chkDelete"  runat="server"/><asp:HiddenField ID="HiddenField1" runat="server" Value='<%# Eval("ID")%>'/></td>
    <td align="left"><a href="CaifangDetails.aspx?Id=<%# DataBinder.Eval(Container.DataItem, "Id") %>" title="<%#DataBinder.Eval(Container.DataItem, "Title") %>"> <%#Mystring.lim_withoutPoint(DataBinder.Eval(Container.DataItem, "Title").ToString(),25) %></a></td>
    <td><%# DataBinder.Eval(Container.DataItem, "Time")%></td>
    <td><%# DataBinder.Eval(Container.DataItem, "Place")%></td>
    <td><%# DataBinder.Eval(Container.DataItem, "Organization")%></td>
    <td><%# DataBinder.Eval(Container.DataItem, "Leader")%></td>
  </tr></ItemTemplate>
        </asp:Repeater>   
        <tr  class="title">
    <td colspan="6" >
    <webdiyer:AspNetPager runat="server" ID="pager" 
            CustomInfoHTML="第%CurrentPageIndex%页，共%PageCount%页，每页%PageSize%条" 
            FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页" 
            ShowCustomInfoSection="Left" onpagechanging="pager_PageChanging" 
            PageSize="20"></webdiyer:AspNetPager><asp:Label ID="Label1" runat="server" Text="" Visible="false"></asp:Label></td>
  </tr>
</table>
<div style="text-align:right">
        <asp:Button ID="Button1" 
            runat="server" Text="批量删除" onclick="Button1_Click" 
              style="height: 20px" onclientclick="return confirm('你确定要执行删除操作？')" />
      </div>
      </div>
    </form>
</body>
</html>
