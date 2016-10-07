using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace Chapter22
{
	/// <summary>
	/// Summary description for IFrameTest.
	/// </summary>
	public class IFrameTest : System.Web.UI.Page
	{
		protected System.Web.UI.HtmlControls.HtmlGenericControl Iframe2;
		protected System.Web.UI.HtmlControls.HtmlGenericControl IFRAME1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			IFRAME1.Attributes["src"] = "PageProcessor_Start.aspx";
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}