using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BloClass;

namespace Lgwin.Lgwin.manage
{
    public partial class blog : System.Web.UI.Page
    {
        const long clientID = 1601956471;//app_key
        const string responseType = "code";
        const string redirectUri = "http://lgwindow.sdut.edu.cn/Lgwin/manage/blog.aspx";//回调地址
        const string clientSecret = "b1f38df8abdd2173d0b2d3f34f5efe64";//app_secret
        SinaSerive serive = new SinaSerive(clientID.ToString(), clientSecret, redirectUri);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["code"] == null || Request["code"].ToString() == "")
            {
                serive.GetAuthorizationCode();
                
                //Response.Redirect("NewsIndex.aspx?code=" + Session["code"]);
            }
            else
            {
                //Application["code"] = Request["code"];
                //Response.Write(Session["code"].ToString());
                Session["code"] = Request["code"];
                Response.Redirect("blog.htm");
            }
            if (!IsPostBack)
            {
                
            }
        }

      
    }
}