<%@ Page Language="C#" AutoEventWireup="true" Inherits="photo_right1" Codebehind="right.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <link   href="css/right.css"  rel="Stylesheet" type="text/css"   />
</head>
<body>
    <form id="form1" runat="server">





<div id="right">

<div id="but1"><img src="images/gy_2ji_npic.jpg"/></div>
<div id="npic1">
    <asp:DataList ID="DataList2" runat="server" 
        RepeatColumns="2" RepeatDirection="Horizontal" 
        DataSourceID="SqlDataSource2" CellPadding="0" CellSpacing="7" 
       >
        <ItemTemplate>
       
 <table id="npic_ta">
<tr><td class="pic1" ><a href="<%# Eval("pagename") %>" target="_blank"><img id="img1" src="admin/photo/<%# Eval("zhtID") %>/<%# Eval("path") %>" /></a></td></tr>
<tr><td class="text1"><a href="<%# Eval("pagename") %>" target="_blank"><%#Mystring.lim_withoutPoint(Eval("name").ToString(),7)%></a></td></tr>

</table></ItemTemplate>
    </asp:DataList>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConStr %>" 
        
        SelectCommand="SELECT top 4 * FROM [Photo_photo] WHERE ([xshshch] = @xshshch) ORDER BY [id] DESC">
        <SelectParameters>
            <asp:Parameter DefaultValue="false" Name="xshshch" Type="Boolean" />
        </SelectParameters>
    </asp:SqlDataSource>
  
</div>

<div id="but2"><img  src="images/gy_2j_hpic.jpg" /></div>
<div id="hpic2">
    <asp:DataList ID="DataList3" runat="server" DataKeyField="ID" 
        DataSourceID="SqlDataSource3" RepeatColumns="3" 
        RepeatDirection="Horizontal" CellPadding="4"><ItemTemplate>
  <table id="hpic_ta" style="margin-top:5px">
<tr><td class="pic2"><a href="<%# Eval("pagename") %>"  target="_blank" ><img id="img2" src="admin/photo/<%# Eval("zhtID") %>/<%# Eval("path") %>" /></a></td></tr>
<tr><td class="text2"><a href="<%# Eval("pagename") %>"  target="_blank" ><%#Mystring.lim_withoutPoint(Eval("name").ToString(), 5)%></a></td></tr>

</table>
        </ItemTemplate></asp:DataList>
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConStr %>" 
        SelectCommand="SELECT top 3 * FROM [Photo_photo] WHERE ([redian] = @redian) ORDER BY [id] DESC">
        <SelectParameters>
            <asp:Parameter DefaultValue="true" Name="redian" Type="Boolean" />
        </SelectParameters>
    </asp:SqlDataSource>
    </div>
<div id="upload">
    <a href="stu_upload.aspx"  target="_blank"><img src="images/upload.jpg" /></a></div>
</div>



    </form>
</body>
</html>
