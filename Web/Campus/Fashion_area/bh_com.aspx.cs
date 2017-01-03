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


public partial class bh_com : System.Web.UI.Page
{

    protected static string constr = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;

    SqlConnection conn = new SqlConnection(constr);
   
   
        protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            string strid = Page.Request.QueryString["ID"];
            string sqlstr = "select * from Campus_comment where ID='" + strid + "' ";
            SqlDataAdapter myda=new SqlDataAdapter(sqlstr,conn);
            DataSet myds = new DataSet();
            myda.Fill(myds, "Campus_comment");
            DataRowView mydrv = myds.Tables["Campus_comment"].DefaultView[0];
            Label7.Text = Convert.ToString(mydrv.Row["title"]);
            TextBox1.Text = Convert.ToString(mydrv.Row["name"]);
            TextBox2.Text = Convert.ToString(mydrv.Row["datee"]);
            TextBox3.Text = Convert.ToString(mydrv.Row["comment"]);
            myds.Dispose();
            
        }
    }


        protected void Button3_Click(object sender, EventArgs e)
        {
            string strid = Page.Request.QueryString["ID"];
            conn.Open();
            string sqlstr = "update Campus_comment set correct='是' ,name='" + TextBox1.Text + "',datee='" + TextBox2.Text + "' ,comment='" + TextBox3.Text + "'where ID='" + strid + "' ";
           
            SqlDataAdapter myda = new SqlDataAdapter(sqlstr,conn);
            DataSet myds = new DataSet();
            myda.Fill(myds, "Campus_comment");
            conn.Close();
            Response.Redirect("bh_comlist.aspx");

        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            string strid = Page.Request.QueryString["ID"];
            string sqlstr = "delete from Campus_comment where ID='" + strid + "'";
            SqlDataAdapter myda = new SqlDataAdapter(sqlstr, conn);
            DataSet myds = new DataSet();
            myda.Fill(myds, "Campus_comment");
            conn.Close();
            Response.Redirect("bh_comlist.aspx");

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("bh_comlist.aspx");
        }
}
