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

public partial class index3_shuyu : System.Web.UI.Page
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

                Label1.Text = dr["title"].ToString();
                Label2.Text = dr["author"].ToString();
                Label3.Text = DateTime.Parse(dr["datee"].ToString()).ToString("yyyy-MM-dd  HH:mm");
                Label4.Text = dr["content"].ToString();
                Label5.Text = dr["editor"].ToString();
                Image1.ImageUrl = dr["picurl"].ToString();

                
            }
            dr.Close();
            conn.Close();
            //评论取得
            string sqlstr1 = "select top 10 * from [Campus_comment] where TID='" + strid + "' and title='" + Label1.Text + "'and lanmu='shuyu'  and correct='是' order by ID desc";

            SqlDataAdapter myda = new SqlDataAdapter(sqlstr1, conn);
           
            DataSet ds = new DataSet();
            myda.Fill(ds, "Campus_comment");
            DataList1.DataSource = ds;
            DataList1.DataBind();
            ds.Dispose();
            
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox2.Text != "")
        {
            string strid = Page.Request.QueryString["ID"];
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlDataAdapter myda = new SqlDataAdapter("select title from fashion where ID='" + strid + "'", conn);
            DataSet myds = new DataSet();
            myda.Fill(myds, "fashion");
            DataRowView mydrv = myds.Tables["fashion"].DefaultView[0];
            string title = Convert.ToString(mydrv.Row["title"]);
            string name = "";
            if (TextBox1.Text != "")
            {
                name = this.TextBox1.Text.ToString();
            }
            else
            {
                name = "理工网友";
            }
            string comment = this.TextBox2.Text.ToString();
            string datee = Convert.ToString(System.DateTime.Now);
            string lanmu = "shuyu";
            string correct = "否";
            string sqlstr = "insert into Campus_comment(TID,title,name,comment,datee,lanmu,correct)values('" + strid + "','" + title.ToString() + "','" + name.ToString() + "','" + comment.ToString() + "','" + datee.ToString() + "','" + lanmu + "','" + correct + "') ";
            SqlCommand cmd = new SqlCommand(sqlstr, conn);
            cmd.ExecuteNonQuery();
            myds.Dispose();
            conn.Close();
            Response.Write("<script language=javascript>alert('评论成功，待审核！');location='javascript:history.go(-1)'</script>");
        }
        else
        {
            Response.Write("<script language=javascript>alert('请输入评论内容');location='javascript:history.go(-1)'</script>");
        }

    }
}
