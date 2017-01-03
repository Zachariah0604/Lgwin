<%@ Page language="c#" Inherits="Asp600.AboutAdmin.AdminCounter.admin_counter_site" Codebehind="admin_counter_site.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" > 

<html>
  <head>
    <title>admin_counter_site</title>
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
												
                    <td width="49%"><font color="#333333">访问渠道 累计： </font> <%=SumCount%></td>
												<td width="51%" align="right">
													[<a href="admin_counter.aspx">返回</a>]</td>
											</tr>
										</table>
											<% 
									if (pcount1==0) {
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
												<td width="27">序号</td>
												
                    <td width="146">访问渠道</td>
												<td width="45">访问量</td>
												<td width="251">比例</td>
											</tr>
				                    <asp:repeater id="Repeater1" runat="server">
				                       <itemtemplate>
											<tr bgcolor="#ffffff">
												
                        <td align="center"><%# Container.ItemIndex+1%>&nbsp;</td>
												
                        <td align="center">
                          <%# DataBinder.Eval(Container.DataItem,"Count_Site") %>
                        </td>
												
                        <td align="center">
                          <%# DataBinder.Eval(Container.DataItem,"Count_Count") %>
                        </td>
												<td width="251">					
		                                             <table width="251" height="10" border="0" cellpadding="0" cellspacing="0">
														<tr>
															<td bgcolor="#00cc00" width="<%# getlength(Convert.ToInt32(DataBinder.Eval(Container.DataItem,"Count_Count").ToString())) %>" height="9"></td>
															<td bgcolor="#efefef" width=<%# getlength1(Convert.ToInt32(DataBinder.Eval(Container.DataItem,"Count_Count").ToString())) %>></td>
														</tr>
													</table>
												</td>
											</tr>
				</itemtemplate>
			</asp:repeater>
										</table>
										<%}%>
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
				<tr>
					<td>&nbsp;
						<asp:HyperLink id="HyperLink2" runat="server" NavigateUrl="admin_counter.aspx">[返回上级菜单]</asp:HyperLink></td>
				</tr>
			</table>
		</form>
	</body>
</HTML>