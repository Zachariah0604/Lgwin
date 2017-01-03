using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lgwin.Karat.admin
{
    public partial class KaratImagesEdit : System.Web.UI.Page
    {
        SQLHelper helper = new SQLHelper();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Mystring.karatchksess();
                if (Request.Params["ImgID"] != null)
                {
                    btnEdit.Enabled = true;
                    ViewState["ImgID"] = Request.Params["ImgID"].ToString();
                    TextBox1.Text = Server.HtmlDecode(Request.Params["ImgName"].ToString());
                    //tbxDirName.Text = "";
                }
                else
                {
                    btnEdit.Enabled = false;
                    ViewState["ImgID"] = "";
                    tbxDirName.Text = "";
                }

            }
        }
        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("KaratImagesManage.aspx");
        }
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            helper.updateNode(ViewState["ImgID"].ToString(), tbxDirName.Text);
            Response.Write("<script>window.alter('名称修改成功！')</script>");
        }
    }
}