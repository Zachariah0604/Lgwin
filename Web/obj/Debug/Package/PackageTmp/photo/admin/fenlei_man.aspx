<%@ Page Language="C#" AutoEventWireup="true" Inherits="xlxy_admin_fenlei_man" Codebehind="fenlei_man.aspx.cs" %>
<%@ Register TagPrefix="CE" Namespace="CuteEditor" Assembly="CuteEditor" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
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
    function bigg(a) {
        if (a.height == "60") {
            a.height = "180";
            a.width = "200";
        }
        else {

            a.width = "80";
            a.height = "60";
        }
    }
  </script>

<link href="../../Lgwin/manage/Inc/Admin_Style.Css" rel="stylesheet" type="text/css"></link>
<style type="text/css">
body{ }
    #box
    { text-align:center
        
    }
    #top{
          }
    #lm{ }
</style>
    <title>分类管理</title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="box">
    <div  id="top">
        
     
        
        
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" 
            DataSourceID="SqlDataSource2" DataTextField="name" DataValueField="id" 
            onselectedindexchanged="RadioButtonList1_SelectedIndexChanged" 
            RepeatDirection="Horizontal">
        </asp:RadioButtonList>
          
       
    
       
          
       
     
          </div>
          <div id="center">
          <table width="40%" border="0"  cellpadding="0" cellspacing="1" class="border" >
          <tr   class="title"> <td colspan="8" align="right" class="style1">
              <asp:Button ID="Button6" runat="server" onclick="Button6_Click" Text="上传图片" />
              <asp:Button ID="Button3" runat="server" Text="返回管理" onclick="Button3_Click" />
              <asp:Button ID="Button5" runat="server" Text="添加栏目" onclick="Button5_Click" />
              <asp:Button ID="Button2" runat="server" Text="确认删除"   onclick="Button2_Click" /></td></tr>
          <tr><td width="5%" align="center"><asp:CheckBox ID="CheckAll" runat="server"  onclick="javascript:SelectAll(this);" Text="全选" Width="50px" /></td>
                  <td width="10%">栏目名称</td><td width="10%">栏目ID</td><td width="10%">专题名称</td><td width="10%">专题ID</td><td width="20%">栏目说明</td><td width="10%">创建时间</td><td width="10%"> 编辑</td></tr>
                  
                 <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
             <tr align="center" class="tdbg">
             <td><asp:CheckBox runat="server" ID="Checkbox1" />  <asp:HiddenField ID="HiddenField1" runat="server" Value='<%# Eval("ID") %>'/></td>
             <td><%# Eval("name") %></td>
             <td><%# Eval("ID") %></td>
             <td><%# Eval("zhtname") %></td>
             <td><%# Eval("zhtID") %></td>
             <td> <%# Mystring.lim_withoutPoint( Eval("introduction").ToString(),20) %> </td>
             <td><%# Eval("created_time") %></td>
             <td> <asp:HyperLink ID="HyperLink1" runat="server"  
                        NavigateUrl='<%# Eval("ID", "fenlei_edit.aspx?ID={0}") %>' Text="编辑"></asp:HyperLink></td>
                         
              </tr>
               </ItemTemplate>
              
          </asp:Repeater>
           <tr  class="title">
    <td colspan="8" class="style1">
   <asp:Label ID="Label2" runat="server" Text="当前页码"></asp:Label>
            <asp:Label ID="labPage" runat="server" Text="1"></asp:Label>
            <asp:Label ID="Label4" runat="server" Text="总页数"></asp:Label>
            <asp:Label ID="labBackPage" runat="server" Text="labBackPage"></asp:Label>
            <asp:LinkButton ID="lnkbtnOne" runat="server" OnClick="lnkbtnOne_Click" Font-Underline="False">第一页</asp:LinkButton>
        <asp:LinkButton ID="lnkbtnUp" runat="server" OnClick="lnkbtnUp_Click" Font-Underline="False">上一页</asp:LinkButton>
        <asp:LinkButton ID="lnkbtnNext" runat="server" OnClick="lnkbtnNext_Click" Font-Underline="False">下一页</asp:LinkButton>
        <asp:LinkButton ID="lnkbtnBack" runat="server" OnClick="lnkbtnBack_Click" Font-Underline="False">最后一页</asp:LinkButton>
        <asp:Label ID="Label1" runat="server" Text="" Visible="false"></asp:Label></td>
  </tr>
          </table></div>
          <div id="lm"> <asp:Panel ID="Panel1" runat="server" Visible="False"><table><tr><td> 栏目名称：</td><td><asp:TextBox ID="TextBox_name" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox_name"
            ErrorMessage="必填"></asp:RequiredFieldValidator></td><td>所属专题：</td><td><asp:DropDownList ID="DropDownList1" runat="server" 
            DataSourceID="SqlDataSource2" DataTextField="name" DataValueField="id">
        </asp:DropDownList></td>
        </tr><tr><td colspan="4"><CE:Editor ID="Editor1" runat="server" Height="400px" Width="100" 
            SecurityPolicyFile="Admin.config" ThemeType="Office2007" 
            FilesPath="CuteSoft_Client/CuteEditor/">
        </CE:Editor></td></tr>
        <tr><td colspan="4">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="确认添加 " />  
            </td></tr>
        </table>
       
             
              </asp:Panel>
      
         
           
        
         
         <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                  ConnectionString="<%$ ConnectionStrings:ConStr %>" 
                
              SelectCommand="SELECT * FROM [Photo_zhtfenlei] ORDER BY [paixu] ">
            </asp:SqlDataSource>
            
       
     

    </div>
    </form>
</body>
</html>
