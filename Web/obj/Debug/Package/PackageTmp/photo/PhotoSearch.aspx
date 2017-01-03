<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PhotoSearch.aspx.cs" Inherits="Lgwin.photo.PhotoSearch" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/defualt2.css" rel="Stylesheet" type="text/css" />
    <link href="../images/index/TopFooter.css" rel="stylesheet" type="text/css" />
    <link href="../images/news/news.css" rel="stylesheet" type="text/css" />
    <title></title>
     <script language="javascript" type="text/javascript">
         function EnterKeyClick(button) {

             if (event.keyCode == 13) {

                 event.keyCode = 9;

                 event.returnValue = false;

                 document.all[button].click();

             }

         }


  </script>
    <style type="text/css">
        #content
        {
            float: left;
            width: 715px;
            height: 535px;
        }
        .Bord
        {
            border: solid #d1d1d1 1px;
            margin-top: 2px;
        }
        .title
        {
            color: #003399;
            font-weight: bold;
            font-size: 13px;
        }
        .border
        {
            border-right: #0096CE 1px solid;
            border-top: #0096CE 1px solid;
            border-left: #0096CE 1px solid;
            width: 99%;
            border-bottom: #0096CE 1px solid;
            background-color: #ffffff;
        }
        .tdbg
        {
            background: #def0fa;
            padding: 0 3px;
            height: 22px;
            font-size: 14px;
        }
    </style>
</head>
<body>
     <form id="form1" runat="server">
   <div id="box">
   <div id="head" ><iframe src="top.html" allowtransparency="true" style="background-color:transparent" 
 frameborder="0"   scrolling="no" width="990px"; height="160px"></iframe>
</div>
<div id="center">
<div id="left">
<div id="headline"></div>
    <div id="content" class="Bord">
    <div align="left" id="menutop" style="padding-bottom:10px; padding-top:10px;"><span style="color: #000000">您的搜索条件为：</span><asp:Label ID="caption" runat="server"></asp:Label>
</div>
      <div valign="top">
      <div><table style="width: 708px"><tr class="title" style="padding-top:8px; padding-bottom:8px;">
          <td width="25%" align="center"><strong>图片名称</strong></td>
          <td width="20%" align="center"><strong>摄影作者</strong></td>
          <td width="20%" align="center"><strong>所属专题</strong></td>
          <td width="35%" height="22" align="center"><strong>发布日期</strong></td>
        </tr></table></div>
        
          <table width="700px"  border="0"  valign="top" class="border" align="center" cellpadding="0" cellspacing="0" >
        
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <tr class="tdbg" >
             <td align="left"width="25%" ><a href="<%# Eval("pagename") %>" target="_blank"> <%#Mystring.lim_withoutPoint(DataBinder.Eval(Container.DataItem, "name").ToString(),15) %></a></td>
              <td align="center" width="20%"><%#Mystring.lim_withoutPoint(DataBinder.Eval(Container.DataItem, "zuozhe").ToString(),4)%></td>               
              <td align="center" width="20%"><%#Mystring.lim_withoutPoint(DataBinder.Eval(Container.DataItem, "zhtname").ToString(),5)%></td>
              <td align="center" width="35%" ><%#Convert.ToDateTime(DataBinder.Eval(Container.DataItem, "upload_time")).ToString("yy-MM-dd")%></td>
            </tr>
        </ItemTemplate>
    </asp:Repeater>
     <tr class="title" >
         <td align="center" colspan="4" style="padding-top:20px; padding-bottom:5px;">
         <asp:Label ID="Label3" runat="server" Text="共" Visible="false"></asp:Label> 
         <asp:label ID="tolpage" runat="server" Text="1 " Visible="false"></asp:label>
         <asp:Label ID="Label5" runat="server" Text="页" Visible="false"></asp:Label> 
           &nbsp;&nbsp
         <asp:Label ID="Label1" runat="server" Text="第" Visible="false"></asp:Label> 
         <asp:label ID="lblCurrentPage" runat="server" Text="1" Visible="false"></asp:label>
         <asp:Label ID="Label2" runat="server" Text="页" Visible="false"></asp:Label> 
           &nbsp;&nbsp;&nbsp; &nbsp;
          <asp:Button ID="Button3" runat="server" Text="首页"  Visible="false"   
                 BorderStyle="None" onclick="Head_Click"></asp:Button>
               
            &nbsp;&nbsp
         <asp:Button ID="Button2" runat="server" Text="下一页"  Visible="false" 
                 BorderStyle="None" onclick="Down_Click"></asp:Button>
           &nbsp
         <asp:Button ID="Button1" runat="server" Text="上一页"  Visible="false" 
                 BorderStyle="None" onclick="Up_Click"></asp:Button> 
           &nbsp 
          <asp:Button ID="Button4" runat="server" Text="尾页"  Visible="false" 
                 BorderStyle="None" onclick="Bottom_Click" ></asp:Button> 
                
            &nbsp
            <asp:Button ID="Button5" runat="server" Text="跳到"  Visible="false" 
                 BorderStyle="None" onclick="Button5_Click" ></asp:Button>       
           
             <asp:TextBox ID="TextBox1" runat="server" Width="36px" Visible="false" ontextchanged="TextBox1_TextChanged"  
               OnKeyPress="if(((event.keyCode>=48)&&(event.keyCode <=57))||(event.keyCode==46)) {event.returnValue=true;} else{event.returnValue=false;}"  ></asp:TextBox>
             <asp:Label ID="Label4" runat="server" Text="页" Visible="false"></asp:Label>
                <asp:Label ID="Label6" runat="server" Text="" Visible="false"></asp:Label>
             </td>
      </tr>
     </table>
        </div>
    </div>
</div>
<div id="right" style=" width:287px">
<iframe src="right.aspx" allowtransparency="true" style="background-color:transparent"  frameborder="0"   scrolling="no" width="300px"; height="550px"></iframe>
</div>

</div>
</div><!--center层-->
<div id="bottom">


 

<div id="link">
<table style="text-align:left; font-size:12px" width="950" height="44" border="0" cellpadding="0" cellspacing="11">
  <tr>
    <td width="100">光影理工</td>
    <td width="35">&nbsp;</td>
    <td width="90"><a href="http://210.44.191.210/">photo center</a></td>
    <td width="205"  ></td>
    <td width="50" ><a href="http://lgwindow.sdut.edu.cn/" target="_blank"><font size="2px">新闻网</font></a></td>
    <td width="52" ><a href="http://lgwindow.sdut.edu.cn/campus/" target="_blank" rel="external"><font size="2px">校园文化</font></a></td>
    <td width="52" ><a href="http://youth.sdut.edu.cn/" target="_blank" rel="external"><font size="2px">青春在线</font></a> </td>
    <td width="52" ><a href="http://www.lgqn.cn/" target="_blank" rel="external"><font size="2px">理工青年</font></a> </td>
    <td width="50" ><a href="http://wdo.sdut.edu.cn/" target="_blank" rel="external"><font size="2px">网兜网</font></a></td>
    <td width="52"  ><a href="http://syxh.sdut.edu.cn/" target="_blank" rel="external"><font size="2px">摄影协会</font></a></td>
  </tr>
</table></div>
<div id="intro">
  <table style="font-size:14px; text-align:center" width="990" height="20" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td>Copyright 2010</td>
    <td><a  href="http://www.lgwindow.stud.edu.cn">lgwindow.stud.edu.cn</a></td>
    <td>版权所有</td>
    <td>Powered by</td>
    <td><a  href="http://lgwindow.sdut.edu.cn/karat"><img src="images/logo.jpg" width="18" height="20" /></a></td>
    <td>karat Studio</td>
    <td width="300">&nbsp;</td>
    <td><a  href="http://lgwindow.sdut.edu.cn/karat">Contact</a></td>
    <td><a  href="http://lgwindow.sdut.edu.cn/karat">| About</a></td>
    <td><a  href="http://lgwindow.sdut.edu.cn/karat">| Join us</a></td>
  </tr>
</table>
  </div>
</div>



    </form>
</body>
</html>
