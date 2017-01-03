<%@ Page Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_ZtArticle" Codebehind="ZtArticle.aspx.cs" %>
<%@ Register TagPrefix="CE" Namespace="CuteEditor" Assembly="CuteEditor" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>���±༭</title>
<script language="javascript" src="Inc/selectDateTime.js"  type="text/javascript" charset="utf-8"></script>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
<link href="Inc/Admin_Style.Css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table width="90%" border="0" cellspacing="1" cellpadding="0" bordercolor="#FFFFFF" bgcolor="#DEF0FA"  class="border">
  <tr>
    <td colspan="2"  class="title"><strong><font color="#FFFFFF">���±༭</font></strong></td>
    </tr>
  <tr class="tdbg">
    <td width="11%" rowspan="2" align="center"><strong>���±��⣺</strong></td>
    <td width="89%"> &nbsp;&nbsp;&nbsp;&nbsp;�����⣺&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="title" runat="server" Width="305px"></asp:TextBox>
        <asp:Label ID="Label_caption" runat="server" Text="Label"></asp:Label>
      </td>
  </tr>
  <tr class="tdbg">
    <td> &nbsp;&nbsp;&nbsp;&nbsp;�����⣺&nbsp;&nbsp;&nbsp;&nbsp;����
      <asp:TextBox ID="subtitle" runat="server" Width="280px"></asp:TextBox>
      </td>
  </tr>
  <tr class="tdbg">
    <td align="center" height="20"><strong>������Ŀ��</strong></td>
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
            runat="server" ControlToValidate="RadioButtonList_lanmu" ErrorMessage="����ѡ����Ŀ��"></asp:RequiredFieldValidator>
                    </td>
  </tr>
  
  <tr class="tdbg">
    <td align="center"><strong>����ʱ�䣺</strong></td>
    <td>&nbsp;&nbsp;&nbsp;&nbsp;
      <asp:TextBox ID="datee" runat="server" Width="125px"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<strong>���������
      <asp:TextBox ID="hits" runat="server" Width="125px"></asp:TextBox>
      </strong></td>
  </tr>
  <tr class="tdbg">
    <td align="center" ><strong>ת�����ӣ�</strong></td>
    <td >&nbsp;&nbsp;&nbsp;&nbsp;
      <asp:TextBox ID="url" runat="server" Width="370px">0</asp:TextBox>
    &nbsp; (0��ʾû������,���������ʽhttp://www...)</td>
  </tr>
  <tr class="tdbg">
    <td align="center"><strong>�������ԣ�</strong></td>
    <td>&nbsp;&nbsp;&nbsp;&nbsp;
    	<asp:CheckBox ID="sdut" runat="server" Text="ѧУ��ҳ" />&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="sdutpic" runat="server"  Text="Sdutͼ��"  AutoPostBack="true"
            oncheckedchanged="sdutpic_CheckedChanged"/>&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="pic" runat="server"  Text="ͼ��" AutoPostBack="true"
            oncheckedchanged="pic_CheckedChanged"/>&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="tuijian" runat="server"  Text="ͷ��"/>&nbsp;&nbsp;&nbsp;&nbsp;
        </td>
  </tr>
  <tr class="tdbg">
    <td align="center"><strong>�������ݣ�</strong>
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
		str_time="<font style='font-size:10pt;color:#FF0000'>��ʱʣ��ʱ�䣺"+int_minute+":"+int_second+"</font>";
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
    <td colspan="2" align="center"><strong>���ߣ�</strong>
      <asp:TextBox ID="author" runat="server" Width="100px"></asp:TextBox>
      &nbsp;&nbsp;&nbsp;<strong>�绰��</strong>
      <asp:TextBox ID="tel" runat="server" Width="100px"></asp:TextBox>
      &nbsp;&nbsp;&nbsp;<strong>��Դ��</strong>
      <asp:DropDownList ID="fro" runat="server"> </asp:DropDownList><asp:TextBox ID="fro_tb" runat="server"></asp:TextBox><input id="bt_manual" type="button" value="�ֶ�" runat="server" onclick="changevisible()"/>
      <script language="javascript" type="text/javascript">
          document.all("fro_tb").style.visibility = "hidden";
          document.all("fro_tb").style.width = "0px";
          document.all("fro").style.width = "100px";
          function changevisible() {
              if (document.all("bt_manual").value == "�ֶ�") {
                  document.all("bt_manual").value = "�Զ�";
                  document.all("fro").style.visibility = "hidden";
                  document.all("fro_tb").style.visibility = "visible";
                  document.all("fro").style.width = "0px";
                  document.all("fro_tb").style.width = "100px";
              }
              else {
                  document.all("bt_manual").value = "�ֶ�";
                  document.all("fro").style.visibility = "visible";
                  document.all("fro_tb").style.visibility = "hidden";
                  document.all("fro").style.width = "100px";
                  document.all("fro_tb").style.width = "0px";
              }
          }
        </script>
      &nbsp;&nbsp;&nbsp;<strong>����ˣ�</strong>
      <asp:TextBox ID="editor" runat="server" Width="100px"></asp:TextBox></td>
    </tr>
  <tr class="tdbg">
    <td colspan="2" align="center">
        <asp:CheckBox ID="auditing" runat="server" Text="��Ҫ���" Checked="True" />        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="�ύ" onclick="Button1_Click" />
      &nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="ȡ��" />
      </td>
    </tr>
</table>
    </div>
     </form>

</body>
</html>
