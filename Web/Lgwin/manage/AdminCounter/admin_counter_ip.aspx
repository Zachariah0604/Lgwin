<%@ Page language="c#" Inherits="Asp600.AboutAdmin.AdminCounter.admin_counter_ip" Codebehind="admin_counter_ip.aspx.cs" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>admin_counter_ip</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
		<link href="../Inc/Admin_Style.Css" rel="stylesheet" type="text/css" />
	</HEAD>
	<body leftMargin="0" topMargin="0">
		<form id="Form1" method="post" runat="server">
			<table class="table" style="BORDER-COLLAPSE: collapse" borderColor="#6595d6" cellSpacing="0"
				cellPadding="2" width="97%" align="center" bgColor="#ffffff" border="1">
				<tr class="title_link">
					<td class="title" style="HEIGHT: 25px" colSpan="2">访问统计</td>
				</tr>
				<tr>
					<td width="60%">
						<DIV align="left"><br>
							<table width="700" border="0" align="center" cellpadding="2" cellspacing="1" bordercolor="#6595d6"
								bgcolor="#6595d6">
								<tr>
									<td height="30" align="center" bgcolor="#e2e9ff"><font color="#990000"> 站点访问统计系统</font></td>
								</tr>
								<tr>
									<td height="231" align="center" valign="top" bgcolor="#ffffff">
										<table width="690" border="0" align="center" cellspacing="0">
											<tr>
												<td width="49%"><font color="#333333">访客累计：
														<%=allcount%>
													</font>
												</td>
												<td width="51%" align="right">
													[<a href="admin_counter.aspx">返回</a>]</td>
											</tr>
										</table>
										<% 
									if (allcount==0) {
									%>
										<table width="690" border="1" style="BORDER-COLLAPSE: collapse" align="center" cellpadding="2"
											cellspacing="0" bordercolor="#6595d6">
											<tr>
												<td><div align="center">没有任何数据</div>
												</td>
											</tr>
										</table>
										<%
									}
									else
									{
									%>
										<table style="TABLE-LAYOUT: fixed" width="690" border="0" align="center" cellpadding="2"
											cellspacing="1" bordercolor="#6595d6" bgcolor="#6595d6">
											<tr align="center" bgcolor="#e2e9ff">
												<td width="10%">记录号</td>
												<td width="16%">访问者IP</td>
												<td width="16%">所在地</td>
												<td width="27%">访问日期</td>
												<td width="36%">来源</td>
											</tr>
											<asp:repeater id="Repeater1" runat="server">
												<itemtemplate>
													<tr bgcolor="#ffffff">
														<td align="center"><%# DataBinder.Eval(Container.DataItem,"CountId") %>&nbsp;</td>
														<td align="center"><%# DataBinder.Eval(Container.DataItem,"CountIp") %>&nbsp;</td>
														<td align="center">
															<%# DataBinder.Eval(Container.DataItem,"CountCountry") %>
														</td>
														<td align="center">
															<%# DataBinder.Eval(Container.DataItem,"CountLogtime") %>
														</td>
														<td align="center">
															<a href="#" title="<%# DataBinder.Eval(Container.DataItem,"CountReferer") %>">
																<%# DataBinder.Eval(Container.DataItem,"CountReferer") %>
															</a>
														</td>
													</tr>
												</itemtemplate>
											</asp:repeater>
										</table>
										<%}%>
										<table width="690" border="0" align="center" cellpadding="0" cellspacing="0">
											<tr class="title">
												<td><webdiyer:AspNetPager runat="server" ID="pager" 
            CustomInfoHTML="第%CurrentPageIndex%页，共%PageCount%页，每页%PageSize%条" 
            FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页" 
            ShowCustomInfoSection="Left" onpagechanging="pager_PageChanging" 
            PageSize="20" PageIndexBoxType="DropDownList" ShowPageIndexBox="Auto" 
                  SubmitButtonText="Go" TextAfterPageIndexBox="页" 
                  TextBeforePageIndexBox="转到" NumericButtonCount="8"></webdiyer:AspNetPager></td>
											</tr>
										</table>
									</td>
								</tr>
								<TR>
									<td height="24" bgcolor="#e2e9ff"></td>
								</TR>
							</table>
							<br>
						</DIV>
					</td>
				</tr>
				<tr>
					<td>&nbsp;
						<asp:HyperLink id="HyperLink2" runat="server" NavigateUrl="admin_counter.aspx">[返回上级菜单]</asp:HyperLink></td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
