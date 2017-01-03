using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Lgwin.BLL;
using Lgwin.Model;

public partial class karat1_admin_KaratMessageDetail : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.karatchksess();
         int id = Convert.ToInt32(Request.QueryString["id"]);
        if (!IsPostBack)
        {
            Karat mod = new KaratBLL().SelectModel(id);
       
            Label1.Text = mod.Name;
            Label2.Text = mod.Topic;
            Label9.Text = mod.M_Content;
            Label3.Text = mod.M_time.ToString();
            Label4.Text = mod.Email;
            if (mod.Pass == true)
            {
                Label5.Text = "已回复";
            }
            else
                Label5.Text = "没有回复";
            Label6.Text = mod.R_Content;
            Label7.Text = mod.Auditor;
            Label8.Text = mod.R_time.ToString();
            ipadd.Text = mod.Ip;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("KaratMessageReply.aspx?id=" + Convert.ToInt32(Request.QueryString["id"]) + "");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("KararMessageIndex.aspx");
    }
}