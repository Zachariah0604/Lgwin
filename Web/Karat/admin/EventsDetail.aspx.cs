using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lgwin.BLL;
using Lgwin.Model;
using Count;

public partial class karat1_admin_EventsArtDetail : System.Web.UI.Page
{
    public static string reurl = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.karatchksess();
        int id = 0;
        id = Convert.ToInt32(Request.QueryString["id"]);
        if (!IsPostBack)
        {
            if (id > 0)
            {
                Karat mod = new Karat();
                mod = new KaratBLL().GetEventsArticle(id);
                TextBox1.Text = mod.From_Year;
                Editor1.Text = mod.From_Content;
                TextBox2.Text = mod.Url;
               // TextBox3.Text = mod.From_Month;
                reurl = "EventsManage.aspx"; 
 
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int id = 0;
        id = Convert.ToInt32(Request.QueryString["id"]);
        if (id > 0)
        {

            Karat mod = new Karat();

            mod.From_Year = TextBox1.Text;
            mod.From_Content = Editor1.Text;
           // mod.From_Month = TextBox3.Text;
            mod.Url = TextBox2.Text;
 
            mod.Id = id;
            bool flag = new KaratBLL().EventsUpdate(mod);
            if (flag == true)
            {
                Response.Write("<script language=javascript>alert('修改成功！');</script>");
            }
            Response.Redirect("EventsManage.aspx");                
        }
        else
        {
            Karat mod = new Karat();
            mod.From_Year = TextBox1.Text;
            mod.From_Content = Editor1.Text;
           // mod.From_Month = TextBox3.Text;
            mod.Url = TextBox2.Text;

            bool flag = new KaratBLL().EventsAdd(mod);
            if (flag==true)
            {
                Response.Write("<script language=javascript>alert('添加成功！');</script>");
            }
            Response.Redirect("EventsManage.aspx");  
        }


    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect(reurl);
    }
}