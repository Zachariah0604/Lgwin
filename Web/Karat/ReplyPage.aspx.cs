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


    public partial class ReplyPage : System.Web.UI.Page
    {
        SQLHelper help = new SQLHelper();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["uuid"]!=null)
            {
                int iid = Convert.ToInt32(Request.QueryString["uuid"]);
                Karat mod = new Karat();
                mod.Id = iid;
                new KaratBLL().GetZ(mod);
                //help.GetZan(iid);
                
            }
                if (Request.QueryString["gid"] != null
                    && Request.QueryString["uid"] != null
                    && Request.QueryString["msg"] != null)
                {
                    string gid = Request.QueryString["gid"].Trim();
                    string uid = Request.QueryString["uid"].Trim();
                    string msg = Request.QueryString["msg"].Trim();
                
                int id = Convert.ToInt32(Request.QueryString["id"]);
                Karat mod = new Karat();

                mod.Id = Convert.ToInt32(gid);
                mod.Ip =uid;
                mod.R_Content = msg;
                mod.R_time = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                new KaratBLL().FrontMessageReply(mod);
              
                Response.Redirect("message.aspx");
                }
             
        }
    }
