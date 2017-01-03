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

public partial class Lgwin_manage_ZtXuanZe : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.chksess();
        Session["ZtId"]=GridView1.SelectedRow.Cells[0].Text.Trim();
        Session["ZtJianch"] = GridView1.SelectedRow.Cells[2].Text.Trim();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string id = GridView1.SelectedRow.Cells[0].Text.Trim();
        string name2 = GridView1.SelectedRow.Cells[2].Text.Trim();
        if (Session["ZtId"] != null)
        {
            Session.Remove("ZtId");
            Session.Remove("ZtJianch");
            Session.Add("ZtJianch", name2);
            Session.Add("ZtId", id);
        }
        else
        {
            Session.Add("ZtId", id);
            Session.Add("ZtJianch", name2);
        }
        //Response.Write(Session["ZtId"].ToString() + Session["ZtJianch"].ToString());
    }
}
