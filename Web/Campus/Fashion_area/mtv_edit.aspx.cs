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

public partial class mtv_edit : System.Web.UI.Page
{

    protected static string constr = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;

    SqlConnection conn = new SqlConnection(constr);

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            int strid = int.Parse(Request.QueryString["ID"]);

            string sqlstr = "select * from fashion where ID='" + strid + "'";

            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlstr, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Image1.ImageUrl = dr["picurl"].ToString();
                TextBox1.Text = dr["title"].ToString();
                TextBox2.Text = dr["author"].ToString();
                Editor1.Text = dr["content"].ToString();
                TextBox4.Text = dr["source"].ToString();
                TextBox5.Text = dr["editor"].ToString();
                TextBox6.Text = dr["datee"].ToString();

            }

            dr.Close();
            conn.Close();
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int strid = int.Parse(Request.QueryString["ID"]);

        string Title = TextBox1.Text.ToString();
        string Author = TextBox2.Text.ToString();
        string Book_content = Editor1.Text.ToString();
        string Editor = TextBox5.Text.ToString();
        string Source = TextBox4.Text.ToString();
        DateTime date = Convert.ToDateTime(TextBox6.Text.ToString());
        string sqlstr = "";
        if (FileUpload1.PostedFile.FileName != "")
        {
            string MscPath = FileUpload1.PostedFile.FileName;
            string MscName = MscPath.Substring(MscPath.LastIndexOf("\\") + 1);
            string MscExtend = MscPath.Substring(MscPath.LastIndexOf(".") + 1);


            string ServerPath = Server.MapPath("Picture01/") + MscName;
            FileUpload1.PostedFile.SaveAs(ServerPath);
            string url = "Picture01/" + MscName;
            sqlstr = "update [fashion] set [title]='" + Title + "',[author]='" + Author + "',[picurl]='" + url + "',[content]='" + Book_content + "',[editor]='" + Editor + "',[datee]='" + date + "',[source]='" + Source + "'where [ID]='" + strid + "'";
        }
        else
        {
            sqlstr = "update [fashion] set [title]='" + Title + "',[author]='" + Author + "',[content]='" + Book_content + "',[editor]='" + Editor + "',[datee]='" + date + "',[source]='" + Source + "'where [ID]='" + strid + "'";
        }

        

        SqlCommand cmd = new SqlCommand(sqlstr, conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        
        conn.Close();
        Response.Redirect("mtv_list.aspx");


    }
    protected void Button2_Click(object sender, EventArgs e)
    {

        string strid = Page.Request.QueryString["ID"];
        string sqlstr = "delete from fashion where ID='" + strid + "'";
        SqlCommand cmd = new SqlCommand(sqlstr, conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
        Response.Redirect("mtv_list.aspx");


    }


    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("mtv_list.aspx");
    }
}