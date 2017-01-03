using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lgwin.BLL;
using Lgwin.Model;
using Count;
 
using System.Data.SqlClient;
using System.Data;

public partial class karat1_admin_KaratCultural : System.Web.UI.Page
{
     protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.karatchksess();
        if (!IsPostBack)
        {
            TextBox1.Text= new KaratBLL().sdrcontent("lanmu='团队文化' and Title='团结'");
            TextBox2.Text = new KaratBLL().sdrcontent("lanmu='团队文化' and Title='高效'");
            TextBox3.Text = new KaratBLL().sdrcontent("lanmu='团队文化' and Title='严谨'");
            TextBox4.Text = new KaratBLL().sdrcontent("lanmu='团队文化' and Title='汇才'");
            TextBox8.Text = new KaratBLL().sdrcontent("lanmu='团队文化' and Title='站长'");
            TextBox5.Text = new KaratBLL().sdrcontent("lanmu='团队文化' and Title='采编部'");
            TextBox6.Text = new KaratBLL().sdrcontent("lanmu='团队文化' and Title='综合部'");
            TextBox7.Text = new KaratBLL().sdrcontent("lanmu='团队文化' and Title='技术部'");
            Editor1.Text = new KaratBLL().sdrcontent("lanmu='团队文化' and Title='卡瑞特简介'");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        new KaratBLL().CultruelUpdade("团结", TextBox1.Text);
        new KaratBLL().CultruelUpdade("高效", TextBox2.Text);
        new KaratBLL().CultruelUpdade("严谨", TextBox3.Text);
        new KaratBLL().CultruelUpdade("汇才", TextBox4.Text);
        new KaratBLL().CultruelUpdade("站长", TextBox8.Text);
        new KaratBLL().CultruelUpdade("采编部", TextBox5.Text);
        new KaratBLL().CultruelUpdade("综合部", TextBox6.Text);
        new KaratBLL().CultruelUpdade("技术部", TextBox7.Text);
        new KaratBLL().CultruelUpdade("卡瑞特简介", Editor1.Text);
        Response.Write("<script language=javascript>alert('操作成功！'); </script>");   
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Index.aspx");
    }

}