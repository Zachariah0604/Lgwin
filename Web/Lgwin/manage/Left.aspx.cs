using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Lgwin_manage_left : System.Web.UI.Page
{
    protected string _UserName;
    protected string _UserId;
    protected string _Admin;
    protected string code;//获取code

    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.chksess();
        if (Session["admin"] == null)
        {
            Session.Abandon();
            Response.Write("<script>alert('尚未登陆或登陆超时，请重新登陆！');top.location='UserLogin.aspx'</script>");
        }
        else
        {
            _Admin =Mystring.adminStr( Session["Admin"]);
            _UserName = Session["Name"].ToString();
             //ZaiXainLB.Text = Application["UserCount"].ToString() + "人";
            
        }
    }
    
}
