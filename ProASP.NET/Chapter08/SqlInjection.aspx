<%@ Page language="c#" Codebehind="SqlInjection.aspx.cs" AutoEventWireup="false" Inherits="Chapter08.SqlInjection" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>SqlInjection</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:TextBox id="txtID" style="Z-INDEX: 101; LEFT: 18px; POSITION: absolute; TOP: 40px" runat="server"></asp:TextBox>
			<asp:Label id="Label1" style="Z-INDEX: 102; LEFT: 19px; POSITION: absolute; TOP: 17px" runat="server"
				Font-Names="Verdana" Font-Size="X-Small" Font-Bold="True">Enter Customer ID:</asp:Label>
			<asp:Button id="cmdGetRecords" style="Z-INDEX: 103; LEFT: 178px; POSITION: absolute; TOP: 39px"
				runat="server" Text="Get Records"></asp:Button>
			<asp:DataGrid id="DataGrid1" style="Z-INDEX: 104; LEFT: 19px; POSITION: absolute; TOP: 100px"
				runat="server" Width="392px" Height="123px" Font-Names="Verdana" Font-Size="X-Small"></asp:DataGrid>
		</form>
	</body>
</HTML>
