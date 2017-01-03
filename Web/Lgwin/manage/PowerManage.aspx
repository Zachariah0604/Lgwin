<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_PowerManage" Codebehind="PowerManage.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>权限管理页</title>
<link href="Inc/Admin_Style.Css" rel="stylesheet" type="text/css"> 
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:center">
    <table width="98%" cellspacing="1" cellpadding="5"  class="border">
          <tr class="title">
            <th colspan="2" scope="col">权限管理
              
            </th>        
         </tr>
          <tr class="tdbg">
            <td width="5%">&nbsp;</td>
            <td width="94%" align="left">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" 
            RepeatDirection="Horizontal" 
                    onselectedindexchanged="RadioButtonList1_SelectedIndexChanged">
              <asp:ListItem Selected="True">查看权限</asp:ListItem>
              <asp:ListItem>添加权限</asp:ListItem>
              <asp:ListItem enabled="False">编辑权限</asp:ListItem>
            </asp:RadioButtonList></td>
          </tr>
          <tr class="tdbg">
            <td>&nbsp;</td>
            <td >
                <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                <asp:View ID="View1" runat="server">
                    <table><tr><td align="center">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                        CellPadding="4" ForeColor="#333333" GridLines="None" 
                        Width="800px" 
                        DataSourceID="ObjectDataSource1" DataKeyNames="id" 
                        onrowcommand="GridView1_RowCommand" 
                            HorizontalAlign="Center">
                        <Columns>
                            <asp:BoundField DataField="id" HeaderText="权限Id" SortExpression="Id" />
                            <asp:BoundField DataField="power" HeaderText="权限" SortExpression="Power" />
                            <asp:BoundField DataField="class" HeaderText="权限类别" SortExpression="Class" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton_Bianji" runat="server" CommandName="ed">编辑</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton_del" runat="server" CommandName="deljigou">删除</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <RowStyle BackColor="#EFF3FB" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#2461BF" />
                        <AlternatingRowStyle BackColor="White" />
                    </asp:GridView>
                        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                        SelectMethod="GetPowerClassList" TypeName="Lgwin.BLL.PowerClassBLL">
                            <SelectParameters>
                                <asp:Parameter DefaultValue="all" Name="Class" Type="String" />
                            </SelectParameters>
                    </asp:ObjectDataSource></td></tr>
                    </table>                   

                </asp:View>
                <asp:View ID="View2" runat="server"> 
                    权限名称：
                    <asp:TextBox ID="TextBox_Name" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox_Name" ErrorMessage="必填"></asp:RequiredFieldValidator>
                    权限类别：<asp:DropDownList ID="DropDownList_class" runat="server" Width="150px">
                        <asp:ListItem>文章中心管理</asp:ListItem>
                        <asp:ListItem>多媒体管理</asp:ListItem>
                        <asp:ListItem>专题管理</asp:ListItem>
                        <asp:ListItem>用户管理</asp:ListItem>
                        <asp:ListItem>频道管理</asp:ListItem>
                        <asp:ListItem>系统设置</asp:ListItem>
                        <%--<asp:ListItem>生成专题二级页</asp:ListItem>
                        <asp:ListItem>专题管理</asp:ListItem>
                        <asp:ListItem>用户管理</asp:ListItem>
                        <asp:ListItem>校园文化</asp:ListItem>
                        <asp:ListItem>光影理工</asp:ListItem>
                        <asp:ListItem>卡瑞特</asp:ListItem>
                        <asp:ListItem>权限管理</asp:ListItem>
                        <asp:ListItem>栏目设置</asp:ListItem>
                        <asp:ListItem>机构管理</asp:ListItem>
                        <asp:ListItem>审核统计</asp:ListItem>
                        <asp:ListItem>访问统计</asp:ListItem>
                        <asp:ListItem>头条设置</asp:ListItem>
                        <asp:ListItem>管理公告</asp:ListItem>--%>
                    </asp:DropDownList>
                    &nbsp;&nbsp;
                    <asp:Button ID="Button_add" runat="server" Text=" 添加 " 
                        onclick="Button_add_Click" />                
                </asp:View>
                    <asp:View ID="View5" runat="server">
                        权限名称： <asp:TextBox ID="TextBoxEdname" runat="server"></asp:TextBox>
                        &nbsp;
                        &nbsp;
                        <asp:Button ID="Button_edit" runat="server" Text="提交" 
                            onclick="Button_edit_Click" />
                    </asp:View>
            </asp:MultiView></td>
        </tr>     
 </table>
    </div>
    </form>
</body>
</html>
