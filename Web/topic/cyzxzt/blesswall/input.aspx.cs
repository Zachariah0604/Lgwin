using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Lgwin.topic.blesswall
{
    public partial class input : System.Web.UI.Page
    {
        protected Encoding encod = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            bind();
        }
        public void bind()
        {
            string author = Request["singnature"].ToString();
            string tagbgcolor = Request["tagbgcolor"].ToString();
            string messages = Request["messages"].ToString();
            string tagbgpic = Request["tagbgpic"].ToString();
            if (Request["singnature"] == null || Request["tagbgcolor"] == null || Request["messages"] == null)
            {
                Response.End();
            }
            encod = Encoding.GetEncoding("GB2312");

            if (messages.Length > 100)
            {
                messages = messages.Substring(0, 100);
            }
            string Constr = System.Configuration.ConfigurationManager.AppSettings["connStr"];
            string Querystring = "INSERT INTO T_love  (author,ccontent,tagbgcolor,tagbgpic,subtime) VALUES (@author,@ccontent,@tagbgcolor,@tagbgpic,@subtime)";
            SqlConnection oleconnection = new SqlConnection(Constr);
            SqlCommand cmd = new SqlCommand(Querystring, oleconnection);
            cmd.Parameters.Add("@author", SqlDbType.NVarChar, 20);
            cmd.Parameters.Add("@ccontent", SqlDbType.NVarChar, 250);
            cmd.Parameters.Add("@tagbgpic", SqlDbType.NVarChar, 10);
            cmd.Parameters.Add("@tagbgcolor", SqlDbType.NVarChar, 250);
            cmd.Parameters.Add("@subtime", SqlDbType.DateTime);
            cmd.Parameters["@author"].Value = author;
            cmd.Parameters["@ccontent"].Value = messages;
            cmd.Parameters["@tagbgpic"].Value = tagbgpic;
            cmd.Parameters["@tagbgcolor"].Value = tagbgcolor;
            cmd.Parameters["@subtime"].Value = DateTime.Now;
            try
            {
                oleconnection.Open();
                cmd.ExecuteNonQuery();
                oleconnection.Close();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                //msgbox.Text = "错误是:" + e.ToString();
            }
            Response.Redirect("blessindex.aspx");

        }
    }
}