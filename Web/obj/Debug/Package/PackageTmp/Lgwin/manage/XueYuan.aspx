<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_XueYuan" Codebehind="XueYuan.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
    <link href="Inc/Admin_Style.Css" rel="stylesheet" type="text/css">   
</head>
<body style="margin-top:10px;">
    <form id="form1" runat="server">
    <div style="text-align:center">
     <table cellspacing="1" cellpadding="1"  class="border" style="font-size:16px; font-weight:bold;" 
            width="99%">
          <tr class="title">
            <th colspan="2" scope="col">机构管理              
            </th>        
         </tr>
          <tr class="tdbg">
            <td width="5%">&nbsp;</td>
            <td width="95%" style="padding-top:10px; text-align:left" >
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" 
            RepeatDirection="Horizontal" 
                    onselectedindexchanged="RadioButtonList1_SelectedIndexChanged">
              <asp:ListItem Selected="True">查看机构</asp:ListItem>
              <asp:ListItem>添加机构</asp:ListItem>
              <asp:ListItem enabled="False">编辑机构</asp:ListItem>
            </asp:RadioButtonList></td>
          </tr>
          <tr class="tdbg">
            <td>&nbsp;</td>
            <td style="padding-top:10px">
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
                            <asp:BoundField DataField="Id" HeaderText="机构Id" SortExpression="Id" />
                            <asp:BoundField DataField="Name" HeaderText="机构名称" SortExpression="Name" />
                            <asp:BoundField DataField="Xu" HeaderText="排序" 
                                SortExpression="Xu" />
                            <asp:CheckBoxField DataField="Type" HeaderText="是否学校机构" SortExpression="Type" />
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
                        SelectMethod="GetCollegeList" TypeName="Lgwin.BLL.CollegeBLL">
                    </asp:ObjectDataSource></td></tr>
                    </table>                   

                </asp:View>
                <asp:View ID="View2" runat="server"> 机构名称：
                    <asp:TextBox ID="TextBox_Name" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox_Name" ErrorMessage="必填"></asp:RequiredFieldValidator>
                    排序：<asp:TextBox ID="TextBox_Paixu" runat="server" Width="40px"></asp:TextBox>
                    &nbsp;&nbsp;
                    <asp:CheckBox ID="CheckBox2" runat="server" Text="是否学校机构" TextAlign="Left" />
                    <asp:Button ID="Button1" runat="server" Text=" 添加 " onclick="Button1_Click" />                
                </asp:View>
                    <asp:View ID="View5" runat="server">
                        机构名称： <asp:TextBox ID="TextBoxEdname" runat="server"></asp:TextBox>
                        排序：<asp:TextBox ID="TextBox_editpa" runat="server" Width="40px"></asp:TextBox>
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="是否学校机构" TextAlign="Left" />
                        <asp:Button ID="Button3" runat="server" Text="提交" onclick="Button3_Click" />
                    </asp:View>
            </asp:MultiView></td>
        </tr>     
 </table>   
    </div>
    </form>
</body>
</html>
