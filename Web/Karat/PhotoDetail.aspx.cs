using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Lgwin.Karat
{
    public partial class PhotoDetail : System.Web.UI.Page
    {
        SQLHelper helper=new SQLHelper();
        public static string imgid;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string imgi = Request["ImgID"];
            imgid = imgi;
            if (!IsPostBack)
            {
                helper.addclick(imgid);

            }
            DataTable dt = new DataTable();
            dt = helper.DisPlayList_DsD(imgi);
            picdetail.DataSource = dt.DefaultView;
            picdetail.DataBind();
            DataTable dt2 = new DataTable();
            dt2 = helper.DisPlayList_DsDD(imgi);
            PhtotComment.DataSource = dt2.DefaultView;
            PhtotComment.DataBind();
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            string nic = this.nic.Text;
            string pinl = this.pinl.Text;
            string dtime= DateTime.Now.ToString("yyyy-MM-dd");
            helper.PhotoCommentAddInfo(nic, pinl, dtime,imgid);
        }
    }
}