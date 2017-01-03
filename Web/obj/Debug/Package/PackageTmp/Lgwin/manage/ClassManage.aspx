<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_ClassManage" Codebehind="ClassManage.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>栏目管理页</title>
<link href="Inc/Admin_Style.Css" rel="stylesheet" type="text/css"> 
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:center">
    <table width="98%" cellspacing="1" cellpadding="5"  class="border">
          <tr class="title">
            <th colspan="2" scope="col">栏目管理
              
            </th>        
         </tr>
          <tr class="tdbg">
            <td width="5%">&nbsp;</td>
            <td width="94%" align="left">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" 
            RepeatDirection="Horizontal" 
                    onselectedindexchanged="RadioButtonList1_SelectedIndexChanged">
              <asp:ListItem Selected="True">查看栏目</asp:ListItem>
              <asp:ListItem>添加栏目</asp:ListItem>
              <asp:ListItem enabled="False">编辑栏目</asp:ListItem>
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
                        DataSourceID="ObjectDataSource1" DataKeyNames="Id" 
                        onrowcommand="GridView1_RowCommand" 
                            HorizontalAlign="Center">
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="栏目Id" SortExpression="Id" />
                            <asp:BoundField DataField="Tid" HeaderText="栏目自命名id" SortExpression="Tid" />
                            <asp:BoundField DataField="Title" HeaderText="栏目名称" 
                                SortExpression="Title" />
                            <asp:BoundField DataField="Power" HeaderText="权限" SortExpression="Power" />
                            <asp:CheckBoxField DataField="Show" HeaderText="是否显示" SortExpression="Type" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton_Bianji" runat="server" CommandName="ed" >编辑</asp:LinkButton>
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
                        SelectMethod="GetClassList" TypeName="Lgwin.BLL.ClassBLL">
                            <SelectParameters>
                                <asp:Parameter DefaultValue="true" Name="ShowAll" Type="Boolean" />
                            </SelectParameters>
                    </asp:ObjectDataSource></td></tr>
                    </table>                   

                </asp:View>
                <asp:View ID="View2" runat="server"> 栏目id：<asp:TextBox ID="TextBox_id" 
                        runat="server" Width="30px"></asp:TextBox>
                    栏目名称：
                    <asp:TextBox ID="TextBox_Name" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox_Name" ErrorMessage="必填"></asp:RequiredFieldValidator>
                    权限：<asp:TextBox ID="TextBox_quanxian" runat="server" Width="40px"></asp:TextBox>
                    &nbsp;&nbsp;
                    <asp:CheckBox ID="CheckBox2" runat="server" Text="是否显示" TextAlign="Left" />
                    <asp:Button ID="Button_add" runat="server" Text=" 添加 " 
                        onclick="Button_add_Click" />                
                </asp:View>
                    <asp:View ID="View5" runat="server">
                        栏目id：<asp:TextBox ID="TextBox_editid" runat="server" Width="30px"></asp:TextBox>
                        栏目名称： <asp:TextBox ID="TextBoxEdname" runat="server"></asp:TextBox>
                        权限：<asp:TextBox ID="TextBox_ediquanx" runat="server" Width="40px"></asp:TextBox>
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="是否显示" TextAlign="Left" />
                        <asp:Button ID="Button_edit" runat="server" Text="提交" 
                            onclick="Button_edit_Click"  onclientclick="return confirm('你确定要更改吗？更改后原栏目的文章将不会显示哦')" 
                             />
                    </asp:View>
            </asp:MultiView></td>
        </tr>     
 </table>
    </div>
    </form>
</body>
</html>
