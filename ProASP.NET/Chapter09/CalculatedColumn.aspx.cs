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
using System.Data.SqlClient;

namespace Chapter09
{
	/// <summary>
	/// Summary description for CalculatedColumn.
	/// </summary>
	public class CalculatedColumn : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Create the Connection, DataAdapter, and DataSet.
			string connectionString = "Data Source=localhost;Initial Catalog=Northwind;" + 
				"Integrated Security=SSPI";
			SqlConnection con = new SqlConnection(connectionString);
			
			string sqlCat = "SELECT CategoryID, CategoryName FROM Categories";
			string sqlProd = "SELECT ProductName, CategoryID, UnitPrice FROM Products";

			SqlDataAdapter da = new SqlDataAdapter(sqlCat, con);
			DataSet ds = new DataSet();
    
			try
			{
				con.Open();

				// Fill the DataSet with the Categories table.
				da.Fill(ds, "Categories");

				// Change the command text and retrieve the Products table.
				// You could also use another DataAdapter object for this task.
				da.SelectCommand.CommandText = sqlProd;
				da.Fill(ds, "Products");
			}
			finally
			{
				con.Close();
			}
    
			// Define the relationship between Categories and Products.
			DataRelation relat = new DataRelation("CatProds", 
				ds.Tables["Categories"].Columns["CategoryID"],
				ds.Tables["Products"].Columns["CategoryID"]);
			// Add the relationship to the DataSet.
			ds.Relations.Add(relat);
   
			// Create the calculated columns.
            DataColumn count = new DataColumn(
             "Products (#)", typeof(int), 
			 "COUNT(Child(CatProds).CategoryID)");
			DataColumn max = new DataColumn(
			  "Most Expensive Product", typeof(decimal), 
			  "MAX(Child(CatProds).UnitPrice)");
			DataColumn min = new DataColumn(
			  "Least Expensive Product", typeof(decimal), 
			  "MIN(Child(CatProds).UnitPrice)");
        
			// Add the columns.
			ds.Tables["Categories"].Columns.Add(count);
			ds.Tables["Categories"].Columns.Add(max);
			ds.Tables["Categories"].Columns.Add(min);

			// Show the data.
			DataGrid1.DataSource = ds.Tables["Categories"];
			DataGrid1.DataBind();
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
