using System;
using System.Collections;
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
using System.Collections.Generic;


public partial class Lgwin_manage_CaifangDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.chksess();
        string user = "";
        user = Request.QueryString["Id"].ToString();
        if (!IsPostBack)
        {
            if (user == null || user == "")
            {

                Mystring.alertAndBack("参数丢失！");
            }
            else
            {
                int count;
                CaiFangBLL cfbll = new CaiFangBLL();
                //IList<CaiFang> list = cfbll.GetCaifangByPage(1, 1, "ID='" + user + "'", out count);
                FormView1.DataSource = cfbll.GetCaifangByPage(1, 1, "ID='" + user + "'", out count);
                FormView1.DataBind();

            }
        }
    }
}
