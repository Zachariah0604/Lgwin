<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_ZtManage" Codebehind="ZtManage.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
    <link href="Inc/Admin_Style.Css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table width="98%" cellspacing="1" cellpadding="0" bordercolor="#FFFFFF" bgcolor="#DEF0FA"  class="border">
          <tr class="title" >
            <th colspan="2" scope="col" height="40px">专题管理              
            </th>        
         </tr>
          <tr class="tdbg">
            <td width="39">&nbsp;</td>
            <td width="736" style="padding-top:10px">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" 
            RepeatDirection="Horizontal" 
                    onselectedindexchanged="RadioButtonList1_SelectedIndexChanged">
              <asp:ListItem Selected="True">查看专题</asp:ListItem>
              <asp:ListItem>添加专题</asp:ListItem>
              <asp:ListItem enabled="False">编辑专题</asp:ListItem>
            </asp:RadioButtonList></td>
          </tr>
          <tr class="tdbg">
            <td>&nbsp;</td>
            <td  style="padding-top:10px">
                <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                <asp:View ID="View1" runat="server">
                    <table><tr class="tdbg"><td><asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                        CellPadding="4" ForeColor="#333333" GridLines="None" 
                        Width="600px" 
                        DataSourceID="ObjectDataSource1" DataKeyNames="Id,ZtName,ZtJiancheng,Px,Show" 
                        onrowcommand="GridView1_RowCommand" 
                        onselectedindexchanged="GridView1_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="专题Id" >
                                <HeaderStyle Height="15px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Ztname" HeaderText="专题名称" SortExpression="Ztname" />
                            <asp:BoundField DataField="ZtJiancheng" HeaderText="专题简称" 
                                SortExpression="ZtJiancheng" />
                            <asp:BoundField DataField="Px" HeaderText="专题排序" SortExpression="Px" />
                            <asp:CheckBoxField DataField="Show" HeaderText="专题显示" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton_Bianji" runat="server" CommandName="ed">编辑</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:CommandField ShowSelectButton="True" />
                        </Columns>
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <RowStyle BackColor="#EFF3FB" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" 
                            Height="10px" />
                        <EditRowStyle BackColor="#2461BF" />
                        <AlternatingRowStyle BackColor="White" />
                    </asp:GridView><asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                        SelectMethod="GetZtList" TypeName="Lgwin.BLL.ZtBLL">
                        <SelectParameters>
                            <asp:Parameter DefaultValue="true" Name="ShowAll" Type="Boolean" />
                        </SelectParameters>
                    </asp:ObjectDataSource></td></tr>
                    <tr class="tdbg"><td align="right" style="padding-top:10px">                    
                        <asp:Button ID="Button_Del" runat="server" onclick="Button_Del_Click" 
                            onclientclick="return confirm('你确定要执行删除操作？该操作会删除此专题的所有内容，包含图片，静态页等相关信息，一般不要执行此操作！')" 
                            Text="删除专题所有内容" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button5" runat="server" onclick="Button5_Click" 
                            onclientclick="return confirm('你确定要执行删除操作？该操作会删除数据库中的记录，保留静态页。专题不再操作时，可以执行此操作！')" 
                            Text="删除专题数据保留静态页" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button_Lanmu" runat="server" 
                            onclick="Button_Lanmu_Click" Text="栏目管理" />
                        &nbsp;&nbsp;&nbsp;&nbsp;
                    <br /></td></tr></table>                   

                </asp:View>
                <asp:View ID="View2" runat="server"> 专题名称：
                    <asp:TextBox ID="TextBox_Name" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox_Name" ErrorMessage="必填"></asp:RequiredFieldValidator>
                    关键字：<asp:TextBox ID="TextBox_Jiancheng" runat="server" Width="80px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="TextBox_Jiancheng" ErrorMessage="必填"></asp:RequiredFieldValidator>
                    关键字请用英文或数字！排序：<asp:TextBox ID="TextBox_Paixu" runat="server" Width="40px"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text=" 添加 " onclick="Button1_Click" />                
                </asp:View>
                    <asp:View ID="View5" runat="server">
                        专题名称： <asp:TextBox ID="TextBoxEdname" runat="server"></asp:TextBox>
                        关键字：<asp:TextBox ID="TextBox_edjich" runat="server" Width="80px"></asp:TextBox>
                        排序：<asp:TextBox ID="TextBox_editpa" runat="server" Width="80px"></asp:TextBox>
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="显示" TextAlign="Left" />
                        <asp:Button ID="Button3" runat="server" Text="提交" onclick="Button3_Click" />
                    </asp:View>
            </asp:MultiView></td>
        </tr>
        <tr class="tdbg"><td></td><td>
            <asp:RadioButtonList ID="RadioButtonList2" runat="server" 
                  onselectedindexchanged="RadioButtonList2_SelectedIndexChanged" 
                  RepeatDirection="Horizontal" AutoPostBack="True">
                  <asp:ListItem Value="0">查看栏目</asp:ListItem>
                  <asp:ListItem Value="1">添加栏目</asp:ListItem>
              </asp:RadioButtonList></td></tr>
        <tr class="tdbg"><td >&nbsp;</td>
  <td style="padding-top:10px">
      <asp:MultiView ID="MultiView2" runat="server" ActiveViewIndex="0">
      
          <asp:View ID="View3" runat="server">
              
              <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                  CellPadding="4" DataSourceID="ObjectDataSource2" ForeColor="#333333" 
                  GridLines="None" Width="600px" onrowcommand="GridView2_RowCommand" 
                  CssClass="zhuanti">
                  <RowStyle BackColor="#EFF3FB" />
                  <Columns>
                      <asp:BoundField DataField="Id" HeaderText="栏目Id" SortExpression="Id" />
                      <asp:BoundField DataField="ZtCaptionName" HeaderText="栏目名称" 
                          SortExpression="ZtCaptionName" />
                      <asp:BoundField DataField="Ztid" HeaderText="所属专题Id" SortExpression="Ztid" />
                      <asp:TemplateField>
                          <ItemTemplate>
                              <asp:LinkButton ID="LinkButton_editlm" runat="server" CommandName="editlm">编辑</asp:LinkButton>
                          </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField>
                          <ItemTemplate>
                              <asp:LinkButton ID="LinkButton_dellm" runat="server" CommandName="Dellm" 
                                  onclientclick="return confirm('您确认删除要删除么？')">删除</asp:LinkButton>
                          </ItemTemplate>
                      </asp:TemplateField>
                  </Columns>
                  <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                  <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                  <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                  <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" 
                      Height="10px" />
                  <EditRowStyle BackColor="#2461BF" />
                  <AlternatingRowStyle BackColor="White" />
              </asp:GridView>
              <br />
              <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" 
                  SelectMethod="GetZtCaptionList" TypeName="Lgwin.BLL.ZtCaptionBLL">
                  <SelectParameters>
                      <asp:SessionParameter Name="id" SessionField="ZtId" Type="String" />
                  </SelectParameters>
              </asp:ObjectDataSource>
          </asp:View>
          <asp:View ID="View4" runat="server">
          栏目名称：<asp:TextBox ID="TextBox_Lanmu" runat="server"></asp:TextBox>
              &nbsp;&nbsp;&nbsp;
              <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="提交" />
          </asp:View> 
          <asp:View ID="View6" runat="server">
          栏目名称：<asp:TextBox ID="TextBox_EditMCh" runat="server"></asp:TextBox>
              &nbsp;&nbsp;&nbsp;&nbsp;
              <asp:Button ID="Button4" runat="server" onclick="Button4_Click" Text="修改栏目名称" />
          </asp:View>         
      </asp:MultiView>
  </td></tr>
      </table>
    </div>
    </form>
</body>
</html>
