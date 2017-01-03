using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Lgwin.BLL;
using Lgwin.Model;

public partial class Lgwin_manage_UserDetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.chksess();
        string user = "";
        user = Request.QueryString["User"].ToString();
        if (!IsPostBack)
        {
            if (user == null || user == "")
            {

                Mystring.alertAndBack("参数丢失！");
            }
            else
            {
                int count;
                RegUser mod = new RegUser();
                RegUserBLL bll = new RegUserBLL();
                IList<Lgwin.Model.RegUser> list = bll.GetUserByPage(10, 1, "users='" + user.Trim()+"'", out count);
                //mod = bll.GetUserInfo(user);
                //Response.Write(mod.Email);
                //Response.Write("users=" + user.Trim());

                //Repeater1.DataSource = mod;
                //Repeater1.DataBind();
                FormView1.DataSource = list;
                FormView1.DataBind();
                
            }
        }
    }

    
}
