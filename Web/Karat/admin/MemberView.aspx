<%@ Page Language="C#" AutoEventWireup="true" Inherits="karat1_admin_KaratMemberView" Codebehind="MemberView.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<link href="../css/karat.Css" rel="stylesheet" type="text/css">
    <title>无标题页</title>

</head>
<body>
    <form id="form1" runat="server">
    <div  style="text-align:center;">
      <table  border="0" align="center" cellpadding="0" cellspacing="1" class="border" 
            style="width:300px; margin-top:50px; " >
  <tr height="20px"  class="title">
    <td>成员详细信息</td>
  </tr>
  <tr class="tdbg">
    <td><asp:FormView ID="FormView1" runat="server" RowStyle-VerticalAlign="Middle">
        <ItemTemplate>
        <table width="500px" border="0"  align="center" cellspacing="1" cellpadding="0" bgcolor="White">
  <tr class="tdbg">
    <td rowspan="8" align="center" width="40%" style="padding-bottom:5px">
     <asp:Image ID="Img" runat="server" ImageUrl='<%#Eval("imgurl")%>' Width="150px" /></td>
    <td align="right" width="20%">姓名：</td> 
    <td align="left"><%# DataBinder.Eval(Container.DataItem, "name")%></td>
  </tr>
  <tr class="tdbg">
    <td align="right">部门：</td>
    <td align="left"><%# Eval("bumen")%></td>
  </tr>
  <tr class="tdbg">
    <td align="right">职务：</td>
    <td align="left"><%# Eval("zhiwu")%></td>
  </tr>
  <tr class="tdbg">
    <td align="right">院系：</td>
    <td align="left"><%# Eval("yuanxi")%></td>
  </tr>
  <tr class="tdbg">
    <td align="right">邮箱：</td>
    <td align="left"><%# DataBinder.Eval(Container.DataItem, "email")%></td>
  </tr>
  <tr class="tdbg">
    <td align="right">QQ：</td>
    <td align="left"><%# DataBinder.Eval(Container.DataItem, "qq")%></td>
  </tr>
  <tr class="tdbg">
    <td align="right">电话：</td>
    <td align="left"><%# DataBinder.Eval(Container.DataItem, "tel")%></td>
  </tr>
  <tr class="tdbg">
    <td align="right">是否在职：</td>
    <td align="left"><%# DataBinder.Eval(Container.DataItem, "zaizhi")%></td>
  </tr>
  <tr class="tdbg" height="30px">
    <td align="center">姓名：<%# DataBinder.Eval(Container.DataItem, "name")%></td>
    <td align="right">届时： </td>
    <td align="left"> <%# DataBinder.Eval(Container.DataItem, "year")%></td>
  </tr>


</table>
        </ItemTemplate>
        </asp:FormView>
    </td>
  </tr>
        <tr height="20px"  class="title">
    <td>
        <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click">修改</asp:LinkButton>
&nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">返回</asp:LinkButton>
            &nbsp;</td>
  </tr>
</table>    </div>
    </form>
</body>
</html>


