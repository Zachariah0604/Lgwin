using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class karat1_admin_KaratBaoMingDetail : System.Web.UI.Page
{
    private static string ConStr = System.Configuration.ConfigurationManager.AppSettings["connStr"].ToString();
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.karatchksess();
        string id = "";
        if (Request.QueryString["id"] != "" && Request.QueryString["id"] != null)
            id = Request.QueryString["id"].ToString();
        SqlConnection con = new SqlConnection(ConStr);
        con.Open();
 
        SqlDataAdapter da = new SqlDataAdapter("select * from Karat_BaoMing where id='" + id + "'", con);
        DataSet dt = new DataSet();
        da.Fill(dt, "Karat_BaoMing");

        FormView1.DataSource = dt;
        FormView1.DataBind();

        da.Dispose();
        con.Close();
    }
}