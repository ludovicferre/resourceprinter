using System;
using System.Globalization;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using Altiris.AssetControl.Web;
using Altiris.NS.ContextManagement;
using Altiris.NS.ResourceManagement;
using Altiris.NS.Utilities;
using Altiris.NS.ItemManagement;
using Altiris.Resource;

namespace Symantec.CWoC {
	public class AssetPrintview : System.Web.UI.Page {
		
		protected Label lbl_assettype;
		protected Label lbl_assettag;
		protected Label lbl_manufacturer;
		protected Label lbl_model;
		protected Label lbl_comment;
		protected Label lbl_phonenumber;
		protected Label lbl_owner;
		protected Label lbl_deliverydate;
		protected Label lbl_form_title;
		protected Label lbl_serialnumber;
		protected Label lbl_signature;
		protected Label lbl_lorem_ipsum;		
		protected Label assettype;
		protected Label assettag;
		protected Label assettag2;
		protected Label manufacturer;
		protected Label model;
		protected Label comment;
		protected Label phonenumber;
		protected Label serialnumber;
		protected Label timestamp;
		protected Label username;

		void Page_Load(Object Sender, EventArgs e) {
			
			/* Localise labels */
			lbl_assettype.Text = l10n.get("$lbl_assettype");
			lbl_assettag.Text = l10n.get("$lbl_assettag");
			lbl_manufacturer.Text = l10n.get("$lbl_manufacturer");
			lbl_model.Text = l10n.get("$lbl_model");
			lbl_comment.Text = l10n.get("$lbl_comment");
			lbl_phonenumber.Text = l10n.get("$lbl_phonenumber");
			lbl_owner.Text = l10n.get("$lbl_owner");
			lbl_form_title.Text = l10n.get("$lbl_form_title");
			lbl_serialnumber.Text = l10n.get("$lbl_serialnumber");
			lbl_deliverydate.Text = l10n.get("$lbl_deliverydate");
			lbl_signature.Text = l10n.get("$lbl_signature");
			lbl_lorem_ipsum.Text = l10n.lorem_ipsum;
			

			/* Get computed data */
			if (!base.IsPostBack && (base.Request.QueryString["itemguid"] != null)) {
				string g = base.Request.QueryString["itemguid"];
				ResourceItem rsrcItm = Item.GetItem(new Guid(g), ItemLoadFlags.IgnoreSecurity) as ResourceItem;
				if (rsrcItm != null) {
					string sql = String.Format(customtypes_sql, rsrcItm.ResourceTypeGuid.ToString(), rsrcItm.Guid.ToString());
					DataTable t = GetTable(sql);
					
					foreach (DataRow r in t.Rows) {
						assettype.Text = r[0].ToString();
						lbl_form_title.Text = lbl_form_title.Text.Replace("$assettype", r[0].ToString());
						this.Title = lbl_form_title.Text;
						manufacturer.Text = r[1].ToString();
						model.Text = r[2].ToString();
						serialnumber.Text = r[3].ToString();
						assettag.Text = r[4].ToString();
						assettag2.Text = r[4].ToString();
						username.Text = r[5].ToString();
						comment.Text = r[6].ToString();
						phonenumber.Text = r[7].ToString();
						if (phonenumber.Text == "") {
							phonenumber.Visible = false;
							lbl_phonenumber.Visible = false;
						}
						timestamp.Text = DateTime.Now.ToString("yyyy-MM-dd");
						break;
					}
				}
			}

		}

		public static DataTable GetTable(string sqlStatement) {
			DataTable t = new DataTable();
			try {
				using (DatabaseContext context = DatabaseContext.GetContext()) {
					SqlCommand cmdAllResources = context.CreateCommand() as SqlCommand;
					cmdAllResources.CommandText = sqlStatement;
					using (SqlDataReader r = cmdAllResources.ExecuteReader()) {
						t.Load(r);                    
					}
				}
				return t;
			}
			catch {
				throw new Exception("Failed to execute SQL command...");
			}
		}


		private string customtypes_sql = @"
	SELECT va.[Asset Type], va.Manufacturer, va.Model, va.[Serial Number], vi.Name, o.[User Name], c.[Comment], ph.[Phone Number]
	  FROM vAsset va
	  JOIN vItem vi
		ON va._ResourceGuid = vi.guid
	  LEFT JOIN Inv_Comment c
	    ON c._ResourceGuid = va._ResourceGuid
	  LEFT JOIN Inv_Phone_Details ph
	    ON ph._ResourceGuid = va._ResourceGuid
	  LEFT JOIN vAssetUserOwner o
		ON va._ResourceGuid = o._AssetGuid
	 WHERE va._ResourceTypeGuid = '{0}'
	   AND va._ResourceGuid = '{1}'";
	   
		public static class l10n {
			public static string lorem_ipsum = @"Person who sign the form is fully responsible for the received device. All Employees who have access to information and communication resources of Company are obligated to fulfill rules of CHARTER FOR CORRECT USAGE OF NEW TECHNOLOGIES OF INFORMATION AND COMMUNICATION.";

			public static string get(String key) {
				string locale = CultureInfo.CurrentCulture.ToString();
				switch (locale.ToLower()) {
					case "fr-fr":
						return FR.get(key);
					default:
						return EN.get(key);
				}
			}
			public static class EN {
				public static string get(string key) {
					switch (key) {
						case "$lbl_assettype":		return "Asset type";
						case "$lbl_assettag":		return "Asset tag";
						case "$lbl_manufacturer":	return "Manufacturer";
						case "$lbl_model":			return "Model";
						case "$lbl_comment":		return "Comment";
						case "$lbl_phonenumber":	return "Phone number: ";
						case "$lbl_serialnumber":	return "Serial Number";
						case "$lbl_owner":			return "Owner";
						case "$lbl_deliverydate":	return "Delivery date";
						case "$lbl_signature":		return "Signature";
						case "$lbl_form_title":		return "$assettype remittance form";
						case "Computer":			return "Computer";
						case "Phone":				return "Smartphone";
						case "Thinclient":			return "Thin client";
						default:					return "ERRROR!!!";
					}
				}
			}
			public static class FR {
				public static string get(string key) {
					switch (key) {
						case "$lbl_assettype":		return "Type de bien";
						case "$lbl_assettag":		return "Nom du bien";
						case "$lbl_manufacturer":	return "Fabricant";
						case "$lbl_model":			return "Mod&egrave;le";
						case "$lbl_comment":		return "Commentaires";
						case "$lbl_phonenumber":	return "Num&eacute de t&eacute;l&eacutephone";
						case "$lbl_serialnumber":	return "Num&eacute;ro de s&eacuterie";
						case "$lbl_owner":			return "Utilisateur";
						case "$lbl_deliverydate":	return "Date de livraison";
						case "$lbl_signature":		return "Signature";
						case "$lbl_form_title":		return "Document de livraison ($assettype)";
						case "Computer":			return "Ordinateur";
						case "Phone":				return "Smartphone";
						case "Thinclient":			return "Client L&eacute;ger";
						default:					return "ERRREUR!!!";
					}
				}
			}
		}
	}
}