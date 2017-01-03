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

public partial class bh_list: System.Web.UI.Page
{
    protected static string constr = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bind();
        }

    }

    private void Bind()
    {

        SqlConnection conn = new SqlConnection(constr);
        SqlDataAdapter adq = new SqlDataAdapter("select * from fashion where lanmu='bh' order by datee desc ", conn);
        DataSet ds = new DataSet();
        adq.Fill(ds, "fashion");
        GridView1.DataSource = ds;
        GridView1.DataKeyNames = new String[] { "ID" };
        GridView1.DataBind();
        ds.Dispose();
        

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        SqlConnection conn = new SqlConnection(constr);
        SqlCommand comm = new SqlCommand("delete from  fashion where ID='" + GridView1.DataKeys[e.RowIndex].Value.ToString() + "'", conn);
        conn.Open();
        try
        {
            int i = Convert.ToInt32(comm.ExecuteNonQuery());
            if (i > 0)
            {
                Response.Write("<script language=javascript>alert('删除成功！')</script>");
            }
            else
            {
                Response.Write("<script language=javascript>alert('删除失败！')</script>");
            }
            Bind();
        }
        catch (Exception erro)
        {
            Response.Write("错误信息:" + erro.Message);
        }
        finally
        {
            conn.Close();
        }
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        Bind();
    }


}
