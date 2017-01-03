using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;


namespace Web
{
    
    public class Upload : IHttpHandler
    {
        SQLHelper helper = new SQLHelper();
        public static string Iparam;
        protected void Page_Load(object sender, EventArgs e)
        {
            string initp = System.Web.HttpContext.Current.Request["ImgID"];
            if (initp != null)
            {
                string param = System.Web.HttpContext.Current.Request["ImgID"];
                Iparam = param;
            }
        }
        public void ProcessRequest(HttpContext context)
        {
            HttpPostedFile file = context.Request.Files["FileData"];
            string uploadpath = context.Server.MapPath(context.Request["folder"] + "\\");
            
            if (file != null)
            {
                if (!Directory.Exists(uploadpath))
                {
                    Directory.CreateDirectory(uploadpath);
                }
                file.SaveAs(uploadpath + file.FileName);
                helper.addNode(file.FileName, System.Web.HttpContext.Current.Request.ApplicationPath + "\\Uploads\\KaratPictures\\" + file.FileName, "0", Iparam);
                context.Response.Write("1|222"); //标志位1标识上传成功，后面的可以返回前台的参数，比如上传后的路径等，中间使用|隔开
            }
            else
            {
                context.Response.Write("0|");
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}