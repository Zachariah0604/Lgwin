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

namespace Lgwin.Karat.admin
{
    public partial class KaratUpload : System.Web.UI.Page
    {
        SQLHelper helper = new SQLHelper();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Mystring.karatchksess();
                if (Request.Params["ImgID"] != null)
                {
                    btnUploadPic.Enabled = true;
                    ViewState["ImgID"] = Request.Params["ImgID"].ToString();
                }
                else
                {
                    btnUploadPic.Enabled = false;
                    ViewState["ImgID"] = "";
                }
            }

        }
        protected void btnUploadPic_Click(object sender, EventArgs e)
        {
            if (!tbxPicPath.HasFile)
            {
                Response.Write("<script>window.alert('请指定上传路径！')</script>");
                return;
            }
            else if (tbxPicPath.PostedFile.ContentLength == 0)
            {
                Response.Write("<script>window.alert('文件的内容不能为空！')</script>");
                return;
            }
            String fileName = tbxPicPath.PostedFile.FileName.Substring(tbxPicPath.PostedFile.FileName.LastIndexOf("\\"));

            if (System.IO.File.Exists(Server.MapPath(Request.ApplicationPath) + "\\Pictures" + fileName))
            {
                Response.Write("<script>window.alert('该文件名在服务器中已存在，请更改文件名！')</script>");
            }
            else
            {
                try
                {
                    tbxPicPath.PostedFile.SaveAs(Server.MapPath(Request.ApplicationPath) + "\\Uploads/KaratPictures" + fileName);

                    helper.addNode(tbxPicName.Text.Trim(), Request.ApplicationPath + "\\Uploads/KaratPictures" + fileName, "0", ViewState["ImgID"].ToString());

                    Response.Write("<script>window.alert('文件上传成功！')</script>");
                }
                catch (Exception ex)
                {
                    Response.Write("<script>window.alert('由于网络原因，上载文件错误  " + ex.Message + "')</script>");
                }

                tbxPicName.Text = "";
            }
        }
        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("KaratImagesManage.aspx");
        }
    }
}