using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Lgwin.Model;
using Lgwin.SqlDAL;

public partial class karat1_admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        string code = TextBox5.Text.Trim().ToUpper();
        string rightCode = Session["Code"].ToString();
        if (code != rightCode)
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('验证码输入错误，请重新输入！');</script>");
            return;
        }



        Karat mod = new Karat();
        mod.Name = TextBox1.Text;
        mod.Topic = TextBox2.Text;
        mod.Email = TextBox3.Text;
        mod.M_Content = PictureSwap(TextBox4.Text.ToString()); ;
        mod.Ip = Page.Request.UserHostAddress;
        new KaratDAL().KaratMessageAdd(mod);
        string url = "../message.aspx";
        //Response.Redirect("message.html");

        Response.Write("<script>alert('为了网络信息安全，您的Ip已经被记录，感谢您的留言！');</script>");

       
        Response.Write("<script type='text/Javascript'>window.open('" + url + "','_blank');</script>");

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string url = "../message.aspx";
        //Response.Redirect("message.html");
        Response.Write("<script type='text/Javascript'>window.open('" + url + "','_blank');</script>");

    }
    public string PictureSwap(string str)
    {
        string[] a = new string[] { "[-_-]", "[@o@]", "[-|-]", "[o_o]", "[ToT]", "[*_*]", "[-x-]", "[-_-zz]", "[t_t]", "[-_-!]", "[:,]", "[:P]", "[:D]", "[:)]", "[:(]", "[:O]", "[:#]", "[:Z]", "[:0=]", "[/:P]", "[:$]", "[-.-]", "[/-_-]", "[:{]", "[zz]", "[|-_-|]", "[-_-||]", "[:.]", "[:-Q]", "[9_9]", "[:,.]", "[:?]", "[:-|]", "[:K]", "[:G]", "[:L]", "[:c]", "[:q]", "[:Y]", "[/gs]", "[/sg]", "[/hp]", "[/ok]", "[/rain]", "[/yin]" };
        for (int i = 1; i <= 45; i++)
        {
            str = str.Replace(a[i - 1], "<img src='images/bpic_" + i + ".png' width='40' height='40'/>");

        }
        Response.Write(str + "<br/>");
        return str;
    }
}