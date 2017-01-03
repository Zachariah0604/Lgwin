using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Lgwin.BLL;

public partial class karat1_admin_KaratMemberView : System.Web.UI.Page
{
    public int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.karatchksess();
        id = Convert.ToInt16(Request.QueryString["id"]);
        DataTable dt = new DataTable();
        dt = new  KaratBLL().MembersSelectById(id);
        FormView1.DataSource = dt;
        FormView1.DataBind();
 
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("MemberManage.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt16(Request.QueryString["id"]);
        Response.Redirect("MemberAdd.aspx?id="+id+"");
    }
}