<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_ZtXuanZe" Codebehind="ZtXuanZe.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
    <link href="Inc/Admin_Style.Css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:center">
    <table align="center" cellspacing="1" cellpadding="0" bordercolor="#FFFFFF" bgcolor="#DEF0FA"  class="border">
    <tr class="title"><td align="center" style="font-size: 18px;font-weight: bold;">请选择操作的专题</td></tr>
    <tr class="tdbg"><td style="text-align: center; padding-top:10px" align="center">
        <asp:GridView ID="GridView1" 
            runat="server" AutoGenerateColumns="False" 
                        CellPadding="4" ForeColor="#333333" GridLines="None" 
                        Width="800px" 
                        DataSourceID="ObjectDataSource1" DataKeyNames="Id,ZtName,ZtJiancheng,Px,Show" 
                        onselectedindexchanged="GridView1_SelectedIndexChanged" 
            SelectedIndex="0">
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="专题Id" />
                            <asp:BoundField DataField="Ztname" HeaderText="专题名称" SortExpression="Ztname" />
                            <asp:BoundField DataField="ZtJiancheng" HeaderText="专题简称" 
                                SortExpression="ZtJiancheng" />
                            <asp:BoundField DataField="Px" HeaderText="专题排序" SortExpression="Px" />
                            <asp:CheckBoxField DataField="Show" HeaderText="专题显示" />
                            <asp:CommandField ShowSelectButton="True" ControlStyle-Width="100px"  SelectText="选择专题" ItemStyle-Font-Size="14px"/>
                        </Columns>
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <RowStyle BackColor="#EFF3FB" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#2461BF" />
                        <AlternatingRowStyle BackColor="White" />
                    </asp:GridView><asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                        SelectMethod="GetZtList" TypeName="Lgwin.BLL.ZtBLL">
                        <SelectParameters>
                            <asp:Parameter DefaultValue="true" Name="ShowAll" Type="Boolean" />
                        </SelectParameters>
                    </asp:ObjectDataSource></td></tr>
                    </table>
    </div>
    </form>
</body>
</html>
