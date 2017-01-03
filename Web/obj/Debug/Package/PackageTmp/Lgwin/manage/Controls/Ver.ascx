<%@ Control Language="C#" AutoEventWireup="true" Inherits="Lgwin_manage_Controls_Ver" Codebehind="Ver.ascx.cs" %>
<div id="ver">
	<div id="verline"></div>
	By Sunky.2009<br />
	当前消耗内存:<%=(System.Diagnostics.Process.GetCurrentProcess().WorkingSet/1024)/1024%>M<br />
	自<%=System.Diagnostics.Process.GetCurrentProcess().StartTime%>以来的最大内存消耗:<%=System.Diagnostics.Process.GetCurrentProcess().PeakWorkingSet/1024/1024%>M
</div>