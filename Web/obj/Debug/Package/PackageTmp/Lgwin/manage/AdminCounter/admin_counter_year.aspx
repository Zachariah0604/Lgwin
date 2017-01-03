<%@ Page language="c#" Inherits="Asp600.AboutAdmin.AdminCounter.admin_counter_year" Codebehind="admin_counter_year.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<TITLE>admin_counter_year</TITLE>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
		<link href="../Inc/Admin_Style.Css" rel="stylesheet" type="text/css" />
	</HEAD>
	<body leftMargin="0" topMargin="0">
		<form id="Form1" method="post" runat="server">
  <table class="table" style="BORDER-COLLAPSE: collapse" bordercolor="#6595d6" cellspacing="0"
				cellpadding="2" width="97%" align="center" bgcolor="#ffffff" border="1">
    <tr class="title_link"> 
      <td class="title" style="HEIGHT: 25px" colspan="2">访问统计</td>
    </tr>
    <tr> 
      <td width="60%"> <div align="left"><br>
          <table bordercolor="#6595d6" cellspacing="1" cellpadding="2" width="500" align="center"
								bgcolor="#6595d6" border="0">
            <tr> 
              <td align="center" bgcolor="#e2e9ff" height="30"><font color="#990000"> 站点访问统计系统</font></td>
            </tr>
            <tr> 
              <td valign="top" align="center" bgcolor="#ffffff" height="231"> 
                <table cellspacing="0" width="490" align="center" border="0">
                  <tr> 
                    <td width="49%"><font color="#333333">统计年份：<%=Cyear%> 本年累计：<%=SumCount%> 
                      </font> </td>
                    <td align="right" width="51%">[<a href="admin_counter_year.aspx">当前年</a>] 
                      [<a href="admin_counter_year.aspx?step=1">前一年</a>] [<a href="admin_counter_year.aspx?step=2">前两年</a>] 
                      [<a href="admin_counter.aspx">返回</a>]</td>
                  </tr>
                </table>
                <% 
					if (pmonth==0) {%>
                <table width="490" border="1" style="BORDER-COLLAPSE: collapse" align="center" cellpadding="2" cellspacing="0" bordercolor="#6595d6">
            <tr> 
              <td><div align="center">没有任何数据</div></td>
            </tr>
          </table>
                <%			}
							else
							{
							%>
                <table bordercolor="#6595d6" cellspacing="1" cellpadding="2" width="490" align="center"
											bgcolor="#6595d6" border="0">
                  <tr align="center" bgcolor="#e2e9ff"> 
                    <td width="65">月份</td>
                    <td width="158">访问量</td>
                    <td width="251">比例</td>
                  </tr>
                  <%
	for (int i=1; i<=12; i++)
	{		
%>
                  <tr bgcolor="#ffffff"> 
                    <td align="center">
                      <% = i %>
                      &nbsp;</td>
                    <td align="center"><%=dsadmin.Tables["Count_Year"].Rows[0][i].ToString()%>&nbsp;</td>
                    <td width="251"> 
                      <%
			if (MaxCount ==0) 
			{
				LeftPx = 0;
			}
			else
			{
			    LeftPx = Convert.ToInt32(250 *Convert.ToInt32(dsadmin.Tables["Count_Year"].Rows[0][i].ToString())/MaxCount);
			 }
			%>
                      <table height="10" cellspacing="0" cellpadding="0" width="251" border="0">
                        <tr> 
                          <td bgcolor="#00cc00" width="<% = (1 + LeftPx) %>" height="9"></td>
                          <td bgcolor="#efefef" width=<% = (250 - LeftPx) %>></td>
                        </tr>
                      </table></td>
                  </tr>
                  <%}%>
                </table>
                <%}%>
              </td>
            </tr>
            <tr> 
              <td bgcolor="#e2e9ff" height="24"></td>
            </tr>
          </table>          
          <br>
        </div></td>
    </tr>
    <tr> 
      <td>&nbsp; <asp:hyperlink ID="HyperLink2" runat="server" NavigateUrl="admin_counter.aspx">[返回上级菜单]</asp:hyperlink></td>
    </tr>
  </table>
</form>
	</body>
</HTML>