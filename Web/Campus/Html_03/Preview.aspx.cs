using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;
using System.IO;
public partial class Campus_Html_03_Preview : System.Web.UI.Page
{
    protected static string constr = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
    SqlConnection conn = new SqlConnection(constr);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int strid = int.Parse(Request.QueryString["id"]);

            string sqlstr = "select * from article where ID='" + strid + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlstr, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lanmu.Text = dr["LanMu"].ToString();
                title.Text = dr["Title"].ToString();
                subtitle.Text = dr["SubTitle"].ToString();
                date.Text = dr["Date"].ToString();
                author.Text = dr["Author"].ToString();
                from.Text = dr["From"].ToString();
                content.Text = dr["Content"].ToString();
                editor.Text = dr["Editor"].ToString();
            }
            conn.Close();
        }

    }
}