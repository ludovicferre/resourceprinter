<%@ Page Language="C#" AutoEventWireup="true" src="AssetPrintview.cs" Inherits="Symantec.CWoC.AssetPrintview"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title></title>
</head>
<body>
<h2>Localised labels</h2>
	<asp:Label id="lbl_form_title" runat="server"/><br />
	<asp:Label id="lbl_deliverydate" runat="server"/><br />
	<asp:Label id="lbl_assettype" runat="server"/><br />
	<asp:Label id="lbl_assettag" runat="server"/><br />
	<asp:Label id="lbl_manufacturer" runat="server"/><br />
	<asp:Label id="lbl_model" runat="server"/><br />
	<asp:Label id="lbl_serialnumber" runat="server"/><br />
	<asp:Label id="lbl_owner" runat="server"/><br />
	<asp:Label id="lbl_signature" runat="server"/><br />
	<asp:Label id="lbl_lorem_ipsum" runat="server"/><br />
	<asp:Label id="lbl_lorem_ipsum2" runat="server"/><br />
<h2>Computed labels (may come blank)</h2>
	<asp:Label id="timestamp" runat="server" /><br />
	<asp:Label id="assettype" runat="server" /><br />
	<asp:Label id="assettag" runat="server" /><br />
	<asp:Label id="assettag2" runat="server" /><br />
	<asp:Label id="manufacturer" runat="server" /><br />
	<asp:Label id="model" runat="server" /><br />
	<asp:Label id="serialnumber" runat="server" /><br />
	<asp:Label id="username" runat="server" /><br />
</body>
</html>
