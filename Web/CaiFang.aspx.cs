using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Data.SqlClient;
using Lgwin.BLL;
using Lgwin.Model;
using Lgwin.SqlDAL;

public partial class CaiFang : System.Web.UI.Page
{
    Lgwin.Model.CaiFang _model = new Lgwin.Model.CaiFang();
    protected void Page_Load(object sender, EventArgs e)
    {
        TbxTime.Attributes.Add("onFocus", "selectDate(this)");
        TextBox_time.Attributes.Add("onFocus", "selectTime(this)");

    }
    protected void ImgBtTj_Click(object sender, System.Web.UI.ImageClickEventArgs e)
    {
        if (TbxTitle.Text != "" && TbxTime.Text != "" && TbxPlace.Text != "" && TbxOrganization.Text != "")
        {
            _model.Title = TbxTitle.Text;
            _model.Time =TbxTime.Text+"/"+TextBox_time.Text;
            _model.Place =TbxPlace.Text;
            _model.Organization = TbxOrganization.Text;
            _model.Leader = TbxLeader.Text;
            _model.Description =TbxDescription.Text;

            CaiFangBLL bll = new CaiFangBLL();
            bll.Add(_model);

            //Mystring.alert("添加成功");
            Mystring.alertAndRedirect("添加成功！", "index.html");
            //Response.Redirect("index.html");
        }
    }
    protected void ImgBtCz_Click(object sender, System.Web.UI.ImageClickEventArgs e)
    {
        TbxTitle.Text = "";
        TbxTime.Text = "";
        TbxPlace.Text = "";
        TbxOrganization.Text = "";
        TbxLeader.Text = "";
        TbxDescription.Text = "";
    }
}
