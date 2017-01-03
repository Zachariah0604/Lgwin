<%@ Page Language="C#" AutoEventWireup="true" Inherits="AboutAdmin_AdminCounter_admin_counter" Codebehind="admin_counter.aspx.cs" %>

<HTML>
	<HEAD>
		<title>admin_counter</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
		<link href="../Inc/Admin_Style.Css" rel="stylesheet" type="text/css" />
	</HEAD>
	<body leftMargin="0" topMargin="0">
		<form id="Form1" method="post" runat="server">
			<table class="table" style="BORDER-COLLAPSE: collapse" borderColor="#6595d6" cellSpacing="1"
				cellPadding="2" width="97%" align="center" bgColor="#ffffff"  class="border">
				<tr class="title">
					<td class="title"  colSpan="2" style="height: 40px; font-size:20px; font-weight:bold; color:White;">访问统计</td>
				</tr>
				<tr>
					<td width="60%">
						<DIV align="left"><br>
							<table width="500" border="0" align="center" cellpadding="2" cellspacing="1" bordercolor="#6595d6"
								bgcolor="#6595d6">
								<tr>
									<td height="30" align="center" bgcolor="#e2e9ff"><font color="#990000"> 站点访问统计系统</font></td>
								</tr>
								<tr>
									<td height="231" align="center" bgcolor="#ffffff">
										<table width="400" border="0" cellpadding="5" cellspacing="3">
											<tr align="center">
												<td width="80" height="66"><a href="admin_counter_month.aspx"><img src="../AdminImages/stat2.jpg" width="60" height="60" border="0"></a></td>
												<td width="80"><a href="admin_counter_year.aspx"><img src="../AdminImages/stat5.jpg" width="60" height="60" border="0"></a></td>
												<td width="80"><a href="admin_counter_browser.aspx"><img src="../AdminImages/stat9.jpg" width="70" height="70" border="0"></a></td>
												<td width="80"><a href="admin_counter_os.aspx"><img src="../AdminImages/stat7.jpg" width="60" height="60" border="0"></a></td>
											</tr>
											<tr align="center">
												<td width="80">日访问量</td>
												<td width="80">月访问量</td>
												<td width="80">浏览器</td>
												<td width="80">操作系统</td>
											</tr>
											<tr align="center">
												<td width="80" height="66"><a href="admin_counter_site.aspx"><img src="../AdminImages/stat10.jpg" width="70" height="70" border="0"></a></td>
												<td width="80"><a href="admin_counter_local.aspx"><img src="../AdminImages/stat8.jpg" width="70" height="70" border="0"></a></td>
												<td width="80"><a href="admin_counter_ip.aspx"><img src="../AdminImages/stat0.jpg" width="70" height="70" border="0"></a></td>
												<td width="80"><a href="admin_counter_about.aspx"><img src="../AdminImages/stat6.jpg" width="60" height="60" border="0"></a></td>
											</tr>
											<tr align="center">
												<td width="80">访问渠道</td>
												<td width="80">地区统计</td>
												<td width="80">访问记录</td>
												<td width="80">系统说明</td>
											</tr>
										</table>
									</td>
								</tr>
								<tr>
									<td height="24" bgcolor="#e2e9ff"></td>
								</tr>
							</table>
							<br>
						</DIV>
					</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>