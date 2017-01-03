using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Lgwin.Model;
using Lgwin.BLL;
using System.Data.SqlClient;


public partial class MessageReply : System.Web.UI.Page
{
    private static string ConStr = System.Configuration.ConfigurationManager.AppSettings["connStr"].ToString();
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.karatchksess();
        int id = Convert.ToInt32(Request.QueryString["id"]);
        
        SqlConnection con = new SqlConnection(ConStr);
        con.Open();

        SqlDataAdapter da = new SqlDataAdapter("select * from Karat_message where id='" + id + "'", con);
        DataSet dt = new DataSet();
        da.Fill(dt, "Karat_message");

        repeater1.DataSource = dt;
        repeater1.DataBind();

        da.Dispose();
        con.Close();
        if (!IsPostBack)
        {
            Karat mod = new KaratBLL().SelectModel(id);
           
            Label3.Text = mod.M_time.ToString();
            huifu.Text = mod.R_Content;
            TextBox3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            TextBox3.Attributes.Add("onFocus", "setday(this)");
            if (mod.Pass == true)
            {
                Label4.Text = "已审核";
            }
            else
                Label4.Text = "未审核";
            
            
        }

    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(Request.QueryString["id"]);
        Karat mod = new Karat();

        mod.Auditor = TextBox2.Text;
        mod.R_Content = huifu.Text.ToString();
        mod.Id = id;
        mod.R_time = Convert.ToDateTime(TextBox3.Text);
        
        if (this.DropDownList1.Text == "未审核")
        {
            mod.Pass = false;
        }
        else
            mod.Pass = true;
        new KaratBLL().MessageReply(mod);
      //  Karat_ToIndex.messagetoindex();
        Response.Write("<script>alert('回复成功！');</script>");
        Response.Redirect("KararMessageIndex.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("KararMessageIndex.aspx");
    }

}