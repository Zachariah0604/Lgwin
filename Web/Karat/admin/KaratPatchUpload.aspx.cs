using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;

namespace Lgwin.Karat.admin
{
    public partial class KaratPatchUpload : System.Web.UI.Page
    {
        SQLHelper helper = new SQLHelper();
        public static string Iparam;
        protected void Page_Load(object sender, EventArgs e)
        {
            Mystring.karatchksess();
            string initp = Request["ImgID"];
            if (initp != null)
            {
                string param = Request["ImgID"];
                Iparam = param;
            }

            string path = Server.MapPath("../../Uploads\\KaratPictures\\");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            HttpPostedFile file = Request.Files["Filedata"]; 
            if (file != null && file.ContentLength > 0)
            {
                file.SaveAs(path + Request.Form["filename"]);
                helper.addNode(Request.Form["filename"], Request.ApplicationPath + "\\Uploads\\KaratPictures\\" + Request.Form["filename"], "0", Iparam);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("KaratImagesManage.aspx");
        }
    }
}