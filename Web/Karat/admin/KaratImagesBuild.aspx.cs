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
    public partial class KaratImagesBuild : System.Web.UI.Page
    {
        SQLHelper helper = new SQLHelper();
        protected void Page_Load(object sender, EventArgs e)
        {
            Mystring.karatchksess();
            if (!IsPostBack)
            {
                if (Request.Params["ImgID"] != null)
                {
                    btnAddDir.Enabled = true;
                    ViewState["ImgID"] = Request.Params["ImgID"].ToString();
                }
                else
                {
                    btnAddDir.Enabled = false;
                    ViewState["ImgID"] = "";
                }

            }

        }
        protected void btnAddDir_Click(object sender, EventArgs e)
        {
            helper.addNode(tbxDirName.Text, "", "1", ViewState["ImgID"].ToString());
            Response.Write("<script>window.alert('目录添加成功！')</script>");
        }
        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("KaratImagesManage.aspx");
        }
    }
}