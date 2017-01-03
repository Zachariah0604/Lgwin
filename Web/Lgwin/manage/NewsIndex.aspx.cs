using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BloClass;

public partial class Lgwin_manage_NewsIndex : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        //校园文化跳转
        //if (Request.QueryString["%cap"] != "" && Request.QueryString["%cap"] != null)
        //{
        //    if (Request.QueryString["%cap"].ToString() == "campus")
        //    {
        //if (!IsPostBack)
        //{
        //    Session["admin"] = Request.QueryString["%0%"];
        //    Session["Power"] = Request.QueryString["%p%o"];
        //    Session["Name"] = Request.QueryString["%0%"];
        //    Session["User"] = Request.QueryString["%u%e"];
        //}
        //    }
        //}    
       
        if (Session["admin"] == null)
        {
            Session.Abandon();
            Response.Write("<script>alert('尚未登陆或登陆超时，请重新登陆！');top.location='UserLogin.aspx'</script>");
        }
       
    }
}
