<%@ Page Language="C#" AutoEventWireup="true" Inherits="xlxy_admin_manage" Codebehind="manage.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="../../Lgwin/manage/Inc/Admin_Style.Css" rel="stylesheet" type="text/css"></link>

<style type="text/css" >

body
{ text-align:center;
  
    }
 #ddl{width:20px; float:left; margin-left:20px;}
 #button{width:400px;  float:right;}
     
</style>
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
        function EnterKeyClick(button) {

            if (event.keyCode == 13) {

                event.keyCode = 9;

                event.returnValue = false;

                document.all[button].click();

            }

        }


  </script>

<body>
    <form id="form1" runat="server">
    <div id="box">
    <div>
    
    
        <asp:Button ID="Button1" runat="server" Text="栏目分类管理" onclick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="上传图片管理" onclick="Button2_Click" />
    
    
    </div>

    <div>        
    <asp:RadioButtonList ID="RadioButtonList1" runat="server" DataSourceID="SqlDataSource4"
            DataTextField="name" DataValueField="ID" AutoPostBack="True" 
            CellPadding="3" RepeatDirection="Horizontal" 
            onselectedindexchanged="RadioButtonList1_SelectedIndexChanged">
        </asp:RadioButtonList>
        </div>
    <table width="100%" border="0"  cellpadding="0" cellspacing="1" class="border" >
    <tr id="title">
    <td colspan="13">
     <div id="ddl"  ><asp:DropDownList ID="DropDownList1" runat="server" 
            DataSourceID="SqlDataSource2" DataTextField="name" DataValueField="id" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
             AutoPostBack="True" Width="200px" Height="22px">
        </asp:DropDownList></div>
     
        <div id="button">
            <asp:Button ID="Button5" runat="server" Text="首页静态化" onclick="Button5_Click" />
            <asp:Button ID="Button6" runat="server" Text="二三级页静态化" onclick="Button6_Click"/>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="上传图片" /><asp:Button ID="Button4" 
            runat="server" Text="批量删除" onclick="Button4_Click" 
            onclientclick="return confirm('你确定要执行删除操作？')" Height="20px" /></div>
        </td>
  </tr>
  <tr  class="title" >
    <td height="30" width="5%">
    <div align="center"><asp:CheckBox ID="CheckAll" runat="server"  onclick="javascript:SelectAll(this);" Text="全选" Width="50px" /></div></td>
                  
    <td height="30px" width=""><div align="center"><span lang="zh-cn">名称</span></div></td>
    <td height="30px" width=""><div align="center"><span lang="zh-cn">图片</span></div></td>
    <td height="30px" width=""><div align="center"><span lang="zh-cn">作者</span></div></td>
    <td height="30px" width=""><div align="center"><span lang="zh-cn">编辑</span></div></td>
    <td height="30px" width=""><div align="center"><span lang="zh-cn">说明</span></div></td>
    <td height="30px" width=""><div align="center"><span lang="zh-cn">所属专题</span></div></td>
    <td height="30px" width=""><div align="center"><span lang="zh-cn">栏目</span></div></td>
    <td height="30px" width=""><div align="center"><span lang="zh-cn">推荐</span></div></td>  
    <td height="30px" width=""><div align="center"><span lang="zh-cn">首页</span></div></td>
    <td height="30px" width=""><div align="center"><span lang="zh-cn">热点</span></div></td> 
    <td height="30px" width=""><div align="center"><span lang="zh-cn">新闻网</span></div></td>
    <td height="30px" width=""><div align="center"><span lang="zh-cn">日期</span></div></td>
    
  </tr>
        <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
        <tr align="center" class="tdbg"> 
           
    <td><asp:CheckBox ID="chkDelete"  runat="server"/><asp:HiddenField ID="HiddenField1" runat="server" Value='<%# Eval("id")%>'/></td>

    <td><a href="pic_edit.aspx?id=<%# DataBinder.Eval(Container.DataItem, "ID") %>" title="<%#DataBinder.Eval(Container.DataItem, "name") %>"><%# Eval("name")%></a></td>
     <td><a href="photo/<%#Eval("zhtID")%>/<%#Eval("path")%>"> <img alt="<%# Eval("name") %>" src="photo/<%# Eval("zhtID") %>/<%# Eval("path") %>"    width="80px"height="60px" /></a></td>
      <td><%# DataBinder.Eval(Container.DataItem, "zuozhe")%></td>
     <td><%# DataBinder.Eval(Container.DataItem, "editor")%></td>
      <td><%#Mystring.lim_withPoint( DataBinder.Eval(Container.DataItem, "shuoming").ToString(),30)%></td>
     <td><%# DataBinder.Eval(Container.DataItem, "zhtname")%></td>
     <td><%# DataBinder.Eval(Container.DataItem, "lmname")%></td>
     <td><%#getstring( DataBinder.Eval(Container.DataItem, "tuijian").ToString())%></td>
     <td><%# getstring(DataBinder.Eval(Container.DataItem, "shouye").ToString())%></td>
     <td><%# getstring(DataBinder.Eval(Container.DataItem, "redian").ToString())%></td>
     <td><%# getstring(DataBinder.Eval(Container.DataItem, "xww").ToString())%></td>
      <td><%# DataBinder.Eval(Container.DataItem, "upload_time")%></td>
    
    
   
    
  </tr>
  
  </ItemTemplate>
  
        </asp:Repeater>   
        <tr  class="title">
    <td colspan="13" class="style1">
   <asp:Label ID="Label2" runat="server" Text="当前页码"></asp:Label>
            <asp:Label ID="labPage" runat="server" Text="1"></asp:Label>
            <asp:Label ID="Label4" runat="server" Text="总页数"></asp:Label>
            <asp:Label ID="labBackPage" runat="server" Text="labBackPage"></asp:Label>
            <asp:LinkButton ID="lnkbtnOne" runat="server" OnClick="lnkbtnOne_Click" Font-Underline="False">第一页</asp:LinkButton>
        <asp:LinkButton ID="lnkbtnUp" runat="server" OnClick="lnkbtnUp_Click" Font-Underline="False">上一页</asp:LinkButton>
        <asp:LinkButton ID="lnkbtnNext" runat="server" OnClick="lnkbtnNext_Click" Font-Underline="False">下一页</asp:LinkButton>
        <asp:LinkButton ID="lnkbtnBack" runat="server" OnClick="lnkbtnBack_Click" Font-Underline="False">最后一页</asp:LinkButton>
        <asp:Label ID="Label1" runat="server" Text="" Visible="false"></asp:Label>
         <asp:LinkButton ID="LinkButton1" runat="server"  Font-Underline="False" onclick="LinkButton1_Click" 
            >跳到</asp:LinkButton>
        <asp:TextBox ID="TextBox1" runat="server" Width="30px" Height="18px"  OnKeyPress="if(((event.keyCode>=48)&&(event.keyCode <=57))||(event.keyCode==46)) {event.returnValue=true;} else{event.returnValue=false;}"  ></asp:TextBox>
            <asp:Label ID="Label5" runat="server" Text="页"></asp:Label></td>
  </tr>
</table>
    </div>
      <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
              ConnectionString="<%$ ConnectionStrings:ConStr %>" 
            
        SelectCommand="SELECT * FROM [Photo_lmfenlei] WHERE ([zhtID] = @zhtID) ORDER BY [id] DESC">
            <SelectParameters>
                <asp:ControlParameter ControlID="RadioButtonList1" Name="zhtID" 
                    PropertyName="SelectedValue" Type="Int32" DefaultValue="0" />
            </SelectParameters>
        </asp:SqlDataSource>
    <br />
        <asp:SqlDataSource ID="SqlDataSource4" runat="server" 
              ConnectionString="<%$ ConnectionStrings:ConStr %>"  SelectCommand=" SELECT * FROM [Photo_zhtfenlei] ORDER BY [paixu] ">
        </asp:SqlDataSource>
    </form>
</body>
</html>
