<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_ZtArticle" Codebehind="ZtArticle.aspx.cs" %>
<%@ Register TagPrefix="CE" Namespace="CuteEditor" Assembly="CuteEditor" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>文章编辑</title>
<script language="javascript" src="Inc/selectDateTime.js"  type="text/javascript" charset="utf-8"></script>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
<link href="Inc/Admin_Style.Css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table width="90%" border="0" cellspacing="1" cellpadding="0" bordercolor="#FFFFFF" bgcolor="#DEF0FA"  class="border">
  <tr>
    <td colspan="2"  class="title"><strong><font color="#FFFFFF">文章编辑</font></strong></td>
    </tr>
  <tr class="tdbg">
    <td width="11%" rowspan="2" align="center"><strong>文章标题：</strong></td>
    <td width="89%"> &nbsp;&nbsp;&nbsp;&nbsp;主标题：&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="title" runat="server" Width="305px"></asp:TextBox>
        <asp:Label ID="Label_caption" runat="server" Text="Label"></asp:Label>
      </td>
  </tr>
  <tr class="tdbg">
    <td> &nbsp;&nbsp;&nbsp;&nbsp;副标题：&nbsp;&nbsp;&nbsp;&nbsp;——
      <asp:TextBox ID="subtitle" runat="server" Width="280px"></asp:TextBox>
      </td>
  </tr>
  <tr class="tdbg">
    <td align="center" height="20"><strong>文章栏目：</strong></td>
    <td height="20">&nbsp;&nbsp;<asp:RadioButtonList ID="RadioButtonList_lanmu" runat="server" 
            DataSourceID="ObjectDataSource1" DataTextField="ZtCaptionName" 
            DataValueField="Id" RepeatDirection="Horizontal">
        </asp:RadioButtonList>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            SelectMethod="GetZtCaptionList" TypeName="Lgwin.BLL.ZtCaptionBLL">
            <SelectParameters>
                <asp:SessionParameter Name="id" SessionField="ZtId" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
            runat="server" ControlToValidate="RadioButtonList_lanmu" ErrorMessage="（请选择栏目）"></asp:RequiredFieldValidator>
                    </td>
  </tr>
  
  <tr class="tdbg">
    <td align="center"><strong>发布时间：</strong></td>
    <td>&nbsp;&nbsp;&nbsp;&nbsp;
      <asp:TextBox ID="datee" runat="server" Width="125px"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<strong>点击次数：
      <asp:TextBox ID="hits" runat="server" Width="125px"></asp:TextBox>
      </strong></td>
  </tr>
  <tr class="tdbg">
    <td align="center" ><strong>转向链接：</strong></td>
    <td >&nbsp;&nbsp;&nbsp;&nbsp;
      <asp:TextBox ID="url" runat="server" Width="370px">0</asp:TextBox>
    &nbsp; (0表示没有链接,添加链接形式http://www...)</td>
  </tr>
  <tr class="tdbg">
    <td align="center"><strong>新闻属性：</strong></td>
    <td>&nbsp;&nbsp;&nbsp;&nbsp;
    	<asp:CheckBox ID="sdut" runat="server" Text="学校首页" />&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="sdutpic" runat="server"  Text="Sdut图文"  AutoPostBack="true"
            oncheckedchanged="sdutpic_CheckedChanged"/>&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="pic" runat="server"  Text="图文" AutoPostBack="true"
            oncheckedchanged="pic_CheckedChanged"/>&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="tuijian" runat="server"  Text="头条"/>&nbsp;&nbsp;&nbsp;&nbsp;
        </td>
  </tr>
  <tr class="tdbg">
    <td align="center"><strong>新闻内容：</strong>
<script language="javascript" type="text/javascript">
var time_now_server,time_now_client,time_end,time_server_client,timerID;
time_now_server=new Date();
time_now_server=time_now_server.getTime();
time_now_client=new Date();
time_now_client=time_now_client.getTime();
time_end=time_now_client+1200000;
time_server_client=time_now_server-time_now_client;
setTimeout("show_time()",1000);
function show_time()
{
	timer.innerHTML =time_server_client;

	var time_now,time_distance,str_time;
	var int_day,int_hour,int_minute,int_second;
	time_now=new Date();
	time_now=time_now.getTime()+time_server_client;
	time_distance=time_end-time_now;
	if(time_distance>0)
	{
		int_day=Math.floor(time_distance/86400000)
		time_distance-=int_day*86400000;
		int_hour=Math.floor(time_distance/3600000)
		time_distance-=int_hour*3600000;
		int_minute=Math.floor(time_distance/60000)
		time_distance-=int_minute*60000;
		int_second=Math.floor(time_distance/1000)
	
		if(int_hour<10)
			int_hour="0"+int_hour;
		if(int_minute<10)
			int_minute="0"+int_minute;
		if(int_second<10)
			int_second="0"+int_second;
		str_time="<font style='font-size:10pt;color:#FF0000'>超时剩余时间："+int_minute+":"+int_second+"</font>";
		timer.innerHTML=str_time;
		setTimeout("show_time()",1000);
	}
	else
	{
		timer.innerHTML ="over";
		clearTimeout(timerID)
	}
}
</script>

<div id="timer"></div></td>
    <td>
        <CE:Editor ID="Editor1" runat="server" Height="700px" Width="98%" 
            SecurityPolicyFile="Admin.config" ThemeType="Office2007" 
            FilesPath="CuteSoft_Client/CuteEditor/">
        </CE:Editor>
    </td>
    </tr>
  <tr class="tdbg">
    <td colspan="2" align="center"><strong>作者：</strong>
      <asp:TextBox ID="author" runat="server" Width="100px"></asp:TextBox>
      &nbsp;&nbsp;&nbsp;<strong>电话：</strong>
      <asp:TextBox ID="tel" runat="server" Width="100px"></asp:TextBox>
      &nbsp;&nbsp;&nbsp;<strong>来源：</strong>
      <asp:DropDownList ID="fro" runat="server"> </asp:DropDownList><asp:TextBox ID="fro_tb" runat="server"></asp:TextBox><input id="bt_manual" type="button" value="手动" runat="server" onclick="changevisible()"/>
      <script language="javascript" type="text/javascript">
          document.all("fro_tb").style.visibility = "hidden";
          document.all("fro_tb").style.width = "0px";
          document.all("fro").style.width = "100px";
          function changevisible() {
              if (document.all("bt_manual").value == "手动") {
                  document.all("bt_manual").value = "自动";
                  document.all("fro").style.visibility = "hidden";
                  document.all("fro_tb").style.visibility = "visible";
                  document.all("fro").style.width = "0px";
                  document.all("fro_tb").style.width = "100px";
              }
              else {
                  document.all("bt_manual").value = "手动";
                  document.all("fro").style.visibility = "visible";
                  document.all("fro_tb").style.visibility = "hidden";
                  document.all("fro").style.width = "100px";
                  document.all("fro_tb").style.width = "0px";
              }
          }
        </script>
      &nbsp;&nbsp;&nbsp;<strong>审核人：</strong>
      <asp:TextBox ID="editor" runat="server" Width="100px"></asp:TextBox></td>
    </tr>
  <tr class="tdbg">
    <td colspan="2" align="center">
        <asp:CheckBox ID="auditing" runat="server" Text="需要审核" Checked="True" />        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="提交" onclick="Button1_Click" />
      &nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="取消" />
      </td>
    </tr>
</table>
    </div>
     </form>

</body>
</html>
