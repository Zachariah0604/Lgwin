using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class errorDetails : System.Web.UI.Page
{
    private static string ConStr = System.Configuration.ConfigurationManager.AppSettings["connStr"].ToString();
    string user = "";
    string name = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.chksess();
        if (!IsPostBack)
        {
            PageBind();
        }
    }
    private void PageBind()
    {
        user = Request.QueryString["id"].ToString();
        hidden_id.Value = Request.QueryString["id"];
        SqlConnection con = new SqlConnection(ConStr);
        con.Open();
        string strcmd = "select * from problem where id='" + user + "'";
        SqlCommand cmd = new SqlCommand(strcmd, con);
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            tb_problem.Text = dr["problem"].ToString();
            tb_time.Text = dr["time"].ToString();
            tb_observer.Text = dr["observer"].ToString();
            tb_solutions.Text = dr["solutions"].ToString();
            lb_label.Text = dr["solver"].ToString();
            DropDownList1.Text = dr["status"].ToString();
        }
        dr.Close();
        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        user = hidden_id.Value.ToString();
        name = Session["User"].ToString();
        //Response.Write(user);
        SqlConnection con = new SqlConnection(ConStr);
        con.Open();
        string strcmd = "update problem set solutions='" +tb_solutions.Text + "',status='"+DropDownList1.Text+"',solver='"+name+"' where id='"+user+"'";
        SqlCommand cmd = new SqlCommand(strcmd, con);
        int c = cmd.ExecuteNonQuery();
        con.Close();
        if (c > 0)
        {
            Mystring.alert("修改成功！");
        }
        else
        {
            Mystring.alert("修改失败！");
        }
        PageBind();
    }
}