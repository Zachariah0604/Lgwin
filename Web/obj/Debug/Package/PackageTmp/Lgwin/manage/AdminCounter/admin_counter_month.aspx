<%@ Page language="c#" Inherits="Asp600.AboutAdmin.AdminCounter.admin_counter_month" Codebehind="admin_counter_month.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>admin_counter_month</title>
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
							<table width="500" border="0" align="center" cellpadding="2" cellspacing="1" bordercolor="#6595d6"
								bgcolor="#6595d6">
								<tr>
									<td height="30" align="center" bgcolor="#e2e9ff"><font color="#990000"> 站点访问统计系统</font></td>
								</tr>
								<tr>
									<td height="231" align="center" valign="top" bgcolor="#ffffff">
										<table width="490" border="0" align="center" cellspacing="0">
											<tr>
												<td width="49%"><font color="#333333">统计日期：<%=Cyear+"年"+Cmonth+"月"%> 本月累计：<%=SumCount%> </font>
												</td>
												<td width="51%" align="right">[<a href="admin_counter_month.aspx">当前月</a>] [<a href="admin_counter_month.aspx?step=1">前一月</a>] 
													[<a href="admin_counter_month.aspx?step=2">前两月</a>] [<a href="admin_counter.aspx">返回</a>]</td>
											</tr>
										</table>
										<% 
									if (pmonth==0) {
									%>
										<table width="490" border="1" style="BORDER-COLLAPSE: collapse" align="center" cellpadding="2" cellspacing="0" bordercolor="#6595d6">
            <tr> 
              <td><div align="center">没有任何数据</div></td>
            </tr>
          </table><%
									}
									else
									{
									%>
										<table width="490" border="0" align="center" cellpadding="2" cellspacing="1" bordercolor="#6595d6"
											bgcolor="#6595d6">
											<tr align="center" bgcolor="#e2e9ff">
												<td width="45">日期</td>
												<td width="47">星期</td>
												<td>访问量</td>
												<td width="250">比例</td>

<%=aboutdate%>											</tr>
<%
	for (int ii=1; ii<LastdayL+1; ii++)
	{
	DateTime  aboutdate1=Convert.ToDateTime(aboutdate+"-"+ii);	
%>
											<tr bgcolor="#ffffff">
												<td align="center"><%=ii%>&nbsp;</td>
												<td align="center">												
												<%
												if ((aboutdate1.DayOfWeek.ToString()=="Saturday")||(aboutdate1.DayOfWeek.ToString()=="Sunday"))
												{Response.Write("<font color=red>"+GetDayOfWeek(aboutdate1.DayOfWeek.ToString())+"</font>");}
												else
												{Response.Write(GetDayOfWeek(aboutdate1.DayOfWeek.ToString()));}
												%>&nbsp;</td>
												<td align="center"><%=dsadmin.Tables["Count_Month"].Rows[0][ii].ToString()%></td>
												<td width="251">
			<%
			if (MaxCount ==0) 
			{
				LeftPx = 0;
			}
			else
			{
			    LeftPx = Convert.ToInt32(250 *Convert.ToInt32(dsadmin.Tables["Count_Month"].Rows[0][ii].ToString())/MaxCount);
			 }
			%>
													<table width="251" height="10" border="0" cellpadding="0" cellspacing="0">
														<tr>
															<td bgcolor="#00cc00" width="<% = (1 + LeftPx) %>" height="9"></td>
															<td bgcolor="#efefef" width=<% = (250 - LeftPx) %>></td>
														</tr>
													</table>
												</td>
											</tr><%}%>
										</table>
										<%}%>
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
						<asp:HyperLink id="HyperLink22" runat="server" NavigateUrl="admin_counter.aspx">[返回上级菜单]</asp:HyperLink></td>
				</tr>
			</table>
		</form>
	</body>
</HTML>