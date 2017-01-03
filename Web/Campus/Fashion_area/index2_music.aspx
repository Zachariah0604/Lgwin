<%@ Page Language="C#" AutoEventWireup="true" Inherits="index2_music" Codebehind="index2_music.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head id="Head1" runat="server">
<style type="text/css">
    .body{font-size:12px;}
        a:link {text-decoration: none;color:#000000;}
        a:visited {text-decoration: none;color: #000000;}
        a:hover {text-decoration:underline;}
        a:active {text-decoration: none;}
 .s4
{  width:990px;
    height:46px
    }
 .s5
{width:990px;
  height:133px
    }
     .s6
{  height:10px
    } .s7
{
  height:40px
    } .s8
{width:120px;
  height:32px
    }
    
    .style1
    {
        width: 650px;
        font-size:14px
    }
    .style2
    {
        width: 91px;
        font-size:14px
    }
    

    .style3
    {
        width: 237px;
    }
    

</style>
<script src="Scripts/swfobject_modified.js" type="text/javascript"></script>
    <title>山东理工大学校园文化-时尚广角</title>
</head>
<body style="font-size:12px;margin-top:0px;margin-left:0px;margin-right:0px">
    <form id="form1" runat="server">
      <iframe id="head" src="flash.htm" scrolling="no" frameborder="0" width="100%" height="235px"></iframe>
    
  
     <div style="width:990px;margin-left:auto;margin-right:auto" >
     
     <div style="background-image: url(images/tushu_images/tushu_16.gif); width: 743px; height: 24px; margin-left: 0px">
           <table>
               <tr>
                   <td style="width:50px">
                   </td>
                   <td style="width:200px;font-size:medium;">
                       音乐</td>
                   <td style="width:493px">
                   </td>
               </tr>
           </table>
       </div>
       <div class="s6" > </div>
        
         <div style="width:990px">


         <div style="width:990px;margin-right:auto;margin-left:auto;height:780px">
         <div style="width:670px;height:780px;float:left">
         <div id="R1" style="margin-top:0px">
          <asp:DataList ID="DataList1" runat="server" RepeatColumns="2" DataKeyField="ID" >
                
    <ItemTemplate>
         <div style="height:150px;width:335px">
         <div style="width:120px;height:150px;float:left">
            <a href="<%# "index3_music.aspx?id=" + Eval("ID").ToString() %>"><img  border="0" src="<%# DataBinder.Eval(Container.DataItem,"picurl").ToString() %>" alt="<%# DataBinder.Eval(Container.DataItem,"title").ToString() %>" style="width:100px;height:110px;margin-top:30px;margin-left:8px;margin-right:2px" /></a>
         </div>
          <div style="width:215px;height:150px;float:left">
          <table style="width:215px;height:150px;" cellspacing="0"cellpadding="0">
          <tr><td style="width:215px;height:10px;text-align:left"></td></tr>
          <tr><td style="width:215px;height:15px;text-align:left">         <a href='<%# "index3_music.aspx?id=" + Eval("ID").ToString() %>' target="_blank" title='<%# Eval("title")%>'><%# DataBinder.Eval(Container.DataItem,"title").ToString() %></a>
</td></tr>
          <tr><td style="width:215px;height:15px;text-align:left"> 歌手：<%# DataBinder.Eval(Container.DataItem,"author").ToString() %></td></tr>
          <tr><td style="width:215px;height:104px;text-align:left"> <%#SubStr( DataBinder.Eval(Container.DataItem,"content").ToString(),115) %></td></tr>
          <tr><td style="width:215px;height:4px"><hr style="color:#dddddd"></td></tr>
          </table></div>
    </div>
   </ItemTemplate></asp:DataList>
         </div></div>
              <div style="width:10px;height:780px;float:left"></div>
                <div style="width:300px;height:780px; float:left">
               <iframe  name="iframe1"style="width:300px;height:780px;" src="right.aspx" scrolling="no" frameborder="0" ></iframe>
                </div></div>
                 </div>
    <div class="s6"></div>
   <div class="s7" style="text-align:center">
    <asp:Label ID="Label1" runat="server" Text="当前页码为："></asp:Label>
                               [
                                <asp:Label ID="labPage" runat="server" Text="1"></asp:Label>
                                &nbsp;]
                                <asp:Label ID="Label2" runat="server" Text="总页码为："></asp:Label>
                                [
                                <asp:Label ID="labBackPage" runat="server"></asp:Label>
                                &nbsp;]&nbsp;<asp:LinkButton ID="lnkbtnOne" runat="server" Font-Underline="False" ForeColor="Red"
                                    OnClick="lnkbtnOne_Click">第一页</asp:LinkButton>&nbsp;
                                <asp:LinkButton ID="lnkbtnUp" runat="server" Font-Underline="False" ForeColor="Red"
                                    OnClick="lnkbtnUp_Click">上一页</asp:LinkButton>&nbsp;
                                <asp:LinkButton ID="lnkbtnNext" runat="server" Font-Underline="False" ForeColor="Red"
                                    OnClick="lnkbtnNext_Click">下一页</asp:LinkButton>&nbsp;
                                <asp:LinkButton ID="lnkbtnBack" runat="server" Font-Underline="False" ForeColor="Red"
                                    OnClick="lnkbtnBack_Click">最后一页</asp:LinkButton>&nbsp;&nbsp;</div>
         

      <div id="foot" style="margin-left:auto;margin-right:auto;font-size:14px;width:990px" >
       <iframe id="iframe1" src="foot.htm" scrolling="no" frameborder="0" width="990px"></iframe>
    </div> 
     
     
        
   </div>
    </form>
</body>

</html>

