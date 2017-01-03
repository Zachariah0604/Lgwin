<%@ Page Language="C#" AutoEventWireup="true" Inherits="index3_shuyu" Codebehind="index3_shuyu.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head id="Head1" runat="server">
<style type="text/css">
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
    
    
</style>
<script src="Scripts/swfobject_modified.js" type="text/javascript"></script>
    <title>山东理工大学校园文化-时尚广角</title>
</head>
<body style="font-size:12px;margin-top:0px;margin-left:0px;margin-right:0px">
    <form id="form1" runat="server">
        
      <iframe id="head" src="flash.htm" scrolling="no" frameborder="0" width="100%" height="215px"></iframe> 
    <div style="width:990px;margin-left:auto;margin-right:auto">
       <div style="background-image: url(images/tushu_images/tushu_16.gif); width:743px; height: 24px; margin-left: 0px">
           <table>
               <tr>
                   <td style="width:50px">
                   </td>
                   <td style="width:200px;font-size:medium;">
                       书余</td>
                   <td style="width:493px">
                   </td>
               </tr>
           </table>
       </div>
       <div class="s6" > </div>


       <div id="foot" style="margin-left:auto;margin-right:auto;font-size:14px;width:990px" >


       <div style="width:100%;margin-left:auto;margin-right:auto">
       <div style="width:650px;margin-left:10px;margin-right:10px;float:left">
       <div>
       <div style="text-align:center">
       <div>
       <span style="line-height:30px; font-size:14px;font-weight:bolder">
           <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
       </span></div>
       <span style=" font-weight: lighter; line-height:20px; font-size:12px;">
       作者： <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp&nbsp;
        上传时间：<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></span></div><hr/>
       <br/>

          <div align="center"> <asp:Image ID="Image1" runat="server"  ImageUrl="" ></asp:Image></div><br/><br/>
         <div style="text-align:left"><span style=" line-height:20px; ">
             <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></span></div><br/>
               <div id="end" style="font-size:12px; line-height:22px; text-align:right; margin-right:10px; width:100%;">
                    -----------------------------------------------------------------------
                    <br />    编辑：
                   <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>                <br />
                      <a href="javascript:window.print()"><span style="font-size:12px; color:#000000"> 【打印本稿】</span></a>
                      &nbsp;&nbsp;&nbsp;&nbsp;<a href="javascript:window.close()"><span style="font-size:12px; color:#000000">【关闭窗口】</span></a>
                    <br/>
       </div></div>
       <div  style="height:10px"></div>
       <div id="com" style="font-size:12px">
         <span style="text-align:left"><img src="images/index_images/liuyanqu.gif" alt="" /></span>
         <div class="s6"></div>
         <div style="width:100%;background-color:#f4f4f4">
         <div style="margin-left:5px;margin-top:4px">
         <asp:DataList ID="DataList1" runat="server"  CellPadding="0" Width="100%" >
        <ItemTemplate>
         <div style="height:5px;width:640px">
        <div style="height:5px;width:240px;float:left"> 评论者：<asp:Label ID="Label1" runat="server" Text='<%# Eval("name") %>'></asp:Label></div>
        
        <div style="width:400px;text-align:left;float:left">评论时间：<asp:Label ID="Label2" runat="server" Text='<%#Eval("datee").ToString() %>'>  </asp:Label></div></div>
        <div style="height:1px;width:640px"></div>
        <div style="height:30px;width:600px;overflow:hidden"><asp:Label ID="Label3" runat="server" Text='<%# Eval("comment") %>'></asp:Label></div>
        </div>
       </ItemTemplate>
       </asp:DataList></div></div>
       <div  style="height:10px"></div>
      <span style="text-align:left;margin-left:3px">发表评论</span><div>
       <table style=" width:100%; font-family: 宋体, Arial, Helvetica, sans-serif;" cellpadding="0px" 
               cellspacing="0px" frame="border" ><tr><td >用户名：<asp:TextBox 
                   ID="TextBox1" runat="server" Text="理工网友"></asp:TextBox>&nbsp;&nbsp;&nbsp;欢迎发表评论，文明用语</td></tr>
                   <tr style="height:1px;width:100%"><td></td></tr>
       <tr><td >内容：</td></tr>
       <tr><td >
       <asp:TextBox ID="TextBox2"  runat="server" Height="71px" Width="96%"></asp:TextBox></td></tr>
       <tr><td align="center"><asp:Button ID="Button1" runat="server" Text="提交" Width="80px" 
               onclick="Button1_Click"></asp:Button></td>
          </tr>
       </table>
    
    </div></div>
       
       
       
       
       
       
       
       </div>
       <div class="s6" > </div>
       <div style="width:300px;height:780px;float:left;">
       <iframe  name="iframe1"style="width:300px;height:780px;" src="right.aspx" scrolling="no" frameborder="0" ></iframe></div>
       
       </div>
       <iframe id="iframe1" src="foot.htm" scrolling="no" frameborder="0" width="990px"></iframe>
    </div> 
 
       </form>
</body>

</html>
