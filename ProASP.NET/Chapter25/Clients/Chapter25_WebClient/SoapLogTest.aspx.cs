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
using Chapter25_WebClient.LogWebService;

namespace WebClient
{
	/// <summary>
	/// Summary description for SoapLogTest.
	/// </summary>
	public class SoapLogTest : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button cmdTest;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
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
			this.cmdTest.Click += new System.EventHandler(this.cmdTest_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void cmdTest_Click(object sender, System.EventArgs e)
		{
			LogServiceTest proxy = new LogServiceTest();
			proxy.GetEmployeesCount();
		}
	}
}
