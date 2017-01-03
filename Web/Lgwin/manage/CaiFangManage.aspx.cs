using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Lgwin.BLL;
using Lgwin.Model;
using Wuqi.Webdiyer;

public partial class Lgwin_manage_CaiFangManage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.chksess();
        if (!IsPostBack)
        {
            PageBind();
        }
       
    }
    protected void pager_PageChanging(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
    {
        pager.CurrentPageIndex = e.NewPageIndex;
        PageBind();
    }
    private void PageBind()
    {
        int count;
        CaiFangBLL dal = new CaiFangBLL();
        IList<Lgwin.Model.CaiFang> list = dal.GetCaifangByPage(pager.PageSize, pager.CurrentPageIndex, "", out count);
        pager.RecordCount = count;
        Repeater1.DataSource = list;
        Repeater1.DataBind();


        if (Repeater1.Items.Count == 0)
        {
            Label1.Visible = true;
            Label1.Text = "没有数据";
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        CaiFangBLL bll = new CaiFangBLL();
        int n = 0;
        if (this.Repeater1.Items.Count > 0)
        {
            for (int i = 0; i < Repeater1.Items.Count; i++)
            {
                CheckBox ck = Repeater1.Items[i].FindControl("chkDelete") as CheckBox;
                HiddenField hd = Repeater1.Items[i].FindControl("HiddenField1") as HiddenField;
                int id = int.Parse(hd.Value);
                if (ck.Checked)
                {
                    bll.Del(id);
                }
                else
                {
                    n++;
                }

                if (n == this.Repeater1.Items.Count)
                {

                    ClientScript.RegisterStartupScript(typeof(Page), "aa", "alert('至少应选择一项')", true);
                }

            }
        }
        PageBind();
        
    }
}
