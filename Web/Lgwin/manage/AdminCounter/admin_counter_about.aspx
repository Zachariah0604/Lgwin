<%@ Page language="c#" Inherits="Asp600.AboutAdmin.AdminCounter.admin_counter_about" Codebehind="admin_counter_about.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>admin_counter_about</title>
		<link href="../Inc/Admin_Style.Css" rel="stylesheet" type="text/css" />
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
<%--		<LINK href="style.css" type="text/css" rel="stylesheet" />
--%>	</HEAD>
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
							<table width="500" border="0" align="center" cellpadding="2" cellspacing="1" bordercolor="#6595d6"
								bgcolor="#6595d6">
								<tr>
									<td height="30" align="center" bgcolor="#e2e9ff"><font color="#990000"> 站点访问统计系统</font></td>
								</tr>
								<tr>
									<td height="231" align="center" valign="top" bgcolor="#ffffff">
                                        <br />
                                        <br />
										<table width="314" border="0" cellpadding="2" cellspacing="1" bordercolor="#6595d6"
											bgcolor="#6595d6">
											<tr bgcolor="#ffffff">
												<td width="69" align="center" style="height: 71px"><img src="../AdminImages/stat6.jpg" width="60" height="60" border="0"></td>
												<td width="216" style="height: 71px">
                                                    <br />
                                                    设计制作：Sunky &&Lrg<br />
                                                    <br />
													版权所有：<a href="http://lgwindow.sdut.edu.cn/" target="_blank">理工视窗<br />
                                                    </a>
												</td>
											</tr>
											<tr bgcolor="#ffffff">
												<td align="center" style="height: 11px">&nbsp;</td>
												<td align="right" style="height: 11px">[<a href="admin_counter.aspx">返回</a>]</td>
											</tr>
										</table>
									</td>
								</tr>
								<tr>
									<td height="24" bgcolor="#e2e9ff"><font color="#666666"></font></td>
								</tr>
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
