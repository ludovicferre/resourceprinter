<%@ Page Language="C#" AutoEventWireup="true" src="AssetPrintview.cs" Inherits="Symantec.CWoC.AssetPrintview"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>$assettype remitance form</title>
</head>
<body>
<img src="cwoc.png" />
<table bgcolor="#e1e1e1" border="0" width="100%">
<tbody>
	<tr>
		<td align="left"><h2><asp:Label id="lbl_form_title" runat="server"/></h2></td>
		<td align="right"><h2><asp:Label id="assettag2" runat="server" /></h2></td>
	</tr>
</tbody>
</table>
<p><b><asp:Label id="lbl_deliverydate" runat="server"/>:</b> <asp:Label id="timestamp" runat="server" /></p>
<blockquote>
<table border="0" width="500px">
	<tr height="40px">
		<td><asp:Label id="lbl_assettype" runat="server"/>: </td><td><asp:Label id="assettype" runat="server" /></td>
	</tr>
	<tr height="40px">
		<td><asp:Label id="lbl_assettag" runat="server"/>: </td><td><asp:Label id="assettag" runat="server" /></td>
	</tr>
	<tr height="40px">
		<td><asp:Label id="lbl_manufacturer" runat="server"/>: </td><td><asp:Label id="manufacturer" runat="server" /></td>
	</tr>
	<tr height="40px">
		<td><asp:Label id="lbl_model" runat="server"/></td><td><asp:Label id="model" runat="server" /></td>
	</tr>
	<tr height="40px">
		<td><asp:Label id="lbl_serialnumber" runat="server"/></td><td><asp:Label id="serialnumber" runat="server" /></td>
	</tr>
	<tr height="40px">
		<td><asp:Label id="lbl_owner" runat="server"/>:</td><td><asp:Label id="username" runat="server" /></td>
	</tr>
</table>
</blockquote>
<span style="position: relative; left: 100px;"><asp:Label id="lbl_signature" runat="server"/></span><br/>
<table  style="border:3px solid black; position: relative; left: 100px; width:400px; height:100px; vertical-align:top">
<tr border="0px"><td>&nbsp</td><tr>
</table>
<br/>
<br/>
<br/>
<br/>
<table  style="border:1px solid black; width:80%; height:120px; vertical-align:top;" align="center">
<tr border="0px"><td><asp:Label id="lbl_lorem_ipsum" runat="server"/></td><tr>
</table><br/>
<table  style="border:1px solid black; width:80%; height:120px; vertical-align:top;" align="center">
<tr border="0px"><td><asp:Label id="lbl_lorem_ipsum2" runat="server"/></td><tr>
</table>
</body></html>
</html>
<!-- Sample
http://smp-w2k8-01.epm.local/altiris/assetcontrol/printing/printpreview5.aspx?itemguid=ba6a18a1-222a-44af-bdd6-2e347007c4f9
-->