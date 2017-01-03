<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" Inherits="Lgwin_manage_Article_Add" Codebehind="Article.aspx.cs" %>
<%@ Register TagPrefix="CE" Namespace="CuteEditor" Assembly="CuteEditor" %>

<%@ Register assembly="AspNetPager" namespace="Wuqi.Webdiyer" tagprefix="webdiyer" %>

<html>
<head id="Head1" runat="server">
    <title>文章编辑</title>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<link href="Inc/Admin_Style.Css" rel="stylesheet" type="text/css" />
<script language="javascript" src="Inc/selectDateTime.js"  type="text/javascript" charset="utf-8"></script>
    <style type="text/css">
        #timer
        {
            height: 12px;
            width: 167px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" ViewStateMode=Disabled > 
        </asp:ScriptManager>
    <div align="center">
    <table width="90%" border="0" cellspacing="1" cellpadding="0" bordercolor="#FFFFFF" bgcolor="#DEF0FA"  class="border">
  <tr>
    <td colspan="2"  class="title"><strong><font color="#FFFFFF">文章编辑</font></strong></td>
    </tr>
  <tr class="tdbg">
    <td width="15%" rowspan="2" align="center"><strong>文章标题：</strong></td>
    <td width="85%"> &nbsp;&nbsp;&nbsp;&nbsp;主标题：&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="title" runat="server" Width="305px"></asp:TextBox>
        &nbsp;关键字：<asp:TextBox ID="keywords" runat="server" Width="60px"></asp:TextBox>
      </td>
  </tr>
  <tr class="tdbg">
    <td> &nbsp;&nbsp;&nbsp;&nbsp;副标题：&nbsp;&nbsp;&nbsp;&nbsp;——
      <asp:TextBox ID="subtitle" runat="server" Width="280px"></asp:TextBox>
      </td>
  </tr>
  <tr class="tdbg">
    <td align="center"><strong>文章栏目：</strong></td>
    <td><asp:DropDownList ID="caption" runat="server" 
            Height="20px" Width="124px">
        </asp:DropDownList>
      </td>
  </tr>
  <tr class="tdbg">
    <td align="center"><strong>所属专题：</strong></td>
    <td>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:DropDownList ID="zt1" runat="server" Height="20px" 
                    Width="124px" AutoPostBack="True" onselectedindexchanged="zt1_SelectedIndexChanged" 
                    ></asp:DropDownList>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong>&nbsp; 专题栏目：</strong><asp:DropDownList ID="zt1caption" runat="server" Height="20px" Width="124px">
                  <asp:ListItem Value="0">==请选择栏目==</asp:ListItem>
                </asp:DropDownList>
                <asp:CheckBoxList CssClass="marleft" ID="cbox1" runat="server" RepeatColumns="12" 
                    RepeatDirection="Horizontal">
                </asp:CheckBoxList>
            </ContentTemplate>
         </asp:UpdatePanel>
    </td>
  </tr>
  <tr class="tdbg">
    <td align="center"><strong>发布时间：</strong></td>
    <td>&nbsp;&nbsp;
      <asp:TextBox ID="datee" runat="server" Width="125px"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<strong>点击次数：
      <asp:TextBox ID="hits" runat="server" Width="125px"></asp:TextBox>
      </strong></td>
  </tr>
  <tr class="tdbg">
    <td align="center" ><strong>转向链接：</strong></td>
    <td >&nbsp;&nbsp;
      <asp:TextBox ID="url" runat="server" Width="370px">0</asp:TextBox>
    &nbsp; (0表示没有链接,链接形式http://www...)</td>
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
        <asp:CheckBox ID="zixun" runat="server"  Text="资讯公告推荐"/>&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:CheckBox ID="forbidden" runat="server"  Text="禁止复制"/>&nbsp;&nbsp;&nbsp;&nbsp;
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
time_end=time_now_client+1200000;//20min
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
		clearTimeout(timerID);
	}
}
</script>
<div id="timer"></div></td>
    <td>
        <CE:Editor ID="Editor1" runat="server" Height="700px" Width="95%" 
            SecurityPolicyFile="Admin.config" ThemeType="Office2000" 
            FilesPath="CuteSoft_Client/CuteEditor/">
        </CE:Editor>
    </td>
    </tr>
  <tr class="tdbg">
    <td colspan="2" align="center"><strong>作者：</strong>
      <asp:TextBox ID="author" runat="server" Width="100px"></asp:TextBox>
      &nbsp;<strong>电话：</strong>
      <asp:TextBox ID="tel" runat="server" Width="100px"></asp:TextBox>
      &nbsp;<strong>来源：</strong>
      <asp:DropDownList ID="fro" runat="server"></asp:DropDownList><asp:TextBox ID="fro_tb" runat="server"></asp:TextBox>
       <input id="bt_manual" type="button" value="手动" runat="server" onclick="changevisible()"/>
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
        &nbsp;&nbsp;<strong>审核人：</strong>
      <asp:TextBox ID="editor" runat="server" Width="100px"></asp:TextBox>&nbsp;
        <asp:Button ID="ButtonToCampus" runat="server" Text="转到校园文化" 
            onclick="ButtonToCampus_Click" />
 
      </td>
    </tr>
  <tr class="tdbg">
    <td colspan="2" align="center">
        <asp:CheckBox ID="auditing" runat="server" Text="需要审核" Checked="True" />        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="提交" onclick="Button1_Click" />
      &nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="取消" />
        &nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="发到微博" />
      </td>
    </tr>
</table>

    </div>
     </form>

</body>
</html>
<!--<script language="javascript" type="text/javascript">
        ztcaption = new Array();
        <%=Js() %>
        
   var dd=document.getElementById("zt1").value;
        mychange(dd,1);
//        mychange(document.form1.zt2.value,2);
//        
        for(var i=0;i<document.getElementById("zt1caption").length;i++)
        {
            if(document.getElementById("zt1caption").options[i].value==ztid1)
                   document.getElementById("zt1caption").options[i].selected = true;
        }
//        for(var i=0;i<document.form1.zt2caption.length;i++)
//        {
//            if(document.form1.zt2caption.options[i].value==ztid2)
//                   document.form1.zt2caption.options[i].selected = true;
//        }

    	function mychange(ztid,nom) {					//proValue参数传入客户选中的专题栏目编号
    	if(nom=="1")
    	{
		    document.getElementById("zt1caption").length = 0;				//将ztcaption下拉框先清空
		    document.getElementById("zt1caption").options[0] = new Option('==请选择栏目==','0');//先添加第0行
		    var i; 
		    for (i=0;i < ztcaption.length; i++)				// subcity.length表示数组长度，为5
			    { 
				    if (ztcaption[i][0] == ztid)			//判断是否属于所选专题栏目
				    {
				    //下面语句将在ztcaption下拉框最下边添加一个新项
				    document.getElementById("zt1caption").options[document.getElementById("zt1caption").length] = new Option(ztcaption[i][1],ztcaption[i][2]); 
				    }         
			    }
		}
//		if(nom=="2")
//		{
//		    document.form1.zt2caption.length = 0;				//将ztcaption下拉框先清空
//		    document.form1.zt2caption.options[0] = new Option('==请选择栏目==','0');//先添加第0行
//		    var i; 
//		    for (i=0;i < ztcaption.length; i++)				// subcity.length表示数组长度，为5
//			    { 
//				    if (ztcaption[i][0] == ztid)			//判断是否属于所选专题栏目
//				    {
//				    //下面语句将在ztcaption下拉框最下边添加一个新项
//				    document.form1.zt2caption.options[document.form1.zt2caption.length] = new Option(ztcaption[i][1],ztcaption[i][2]); 
//				    }         
//			    }
//		} 
		} 
		function MM_findObj(n, d) { //v4.01
  var p,i,x;  if(!d) d=document; if((p=n.indexOf("?"))>0&&parent.frames.length) {
    d=parent.frames[n.substring(p+1)].document; n=n.substring(0,p);}
  if(!(x=d[n])&&d.all) x=d.all[n]; for (i=0;!x&&i<d.forms.length;i++) x=d.forms[i][n];
  for(i=0;!x&&d.layers&&i<d.layers.length;i++) x=MM_findObj(n,d.layers[i].document);
  if(!x && d.getElementById) x=d.getElementById(n); return x;
}

function MM_showHideLayers() { //v6.0
  var i,p,v,obj,args=MM_showHideLayers.arguments;
  for (i=0; i<(args.length-2); i+=3) if ((obj=MM_findObj(args[i]))!=null) { v=args[i+2];
    if (obj.style) { obj=obj.style; v=(v=='show')?'visible':(v=='hide')?'hidden':v; }
    obj.visibility=v; }
}

function MM_changeProp(objName,x,theProp,theValue) { //v6.0
  var obj = MM_findObj(objName);
  if (obj && (theProp.indexOf("style.")==-1 || obj.style)){
    if (theValue == true || theValue == false)
      eval("obj."+theProp+"="+theValue);
    else eval("obj."+theProp+"='"+theValue+"'");
  }
}   
		function IsChecked(form,checkname){
            var len = form.elements.length;
            var i=0;
            for( i=0; i<len; i++){
            if (form.elements[i].name==checkname)
            {
            if(form.elements[i].checked)
                {return form.elements[i].value;}
            }
            }
            return "请输入";
        }
</script>-->
