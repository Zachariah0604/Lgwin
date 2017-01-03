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

public partial class Lgwin_manage_UserManage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txt_search.Attributes.Add("onkeydown", "EnterKeyClick('btn_search');");
        if (Mystring.chksess())
        {
            if (Mystring.chkPower(30, Session["User"].ToString()))
            {
                if (!IsPostBack)
                {
                    RegUserBLL bll = new RegUserBLL();
                    IList<Lgwin.Model.RegUser> list = bll.GetUserList("", " zaizhi DESC, paixu");
                    PagedDataSource pds = new PagedDataSource();
                    pds.AllowPaging = true;
                    pds.PageSize = pager.PageSize;
                    pds.DataSource = list;
                    pager.RecordCount = bll.GetUserCount("", "");
                    Repeater1.DataSource = pds;
                    Repeater1.DataBind();
                }
            }
        }
    }
    protected void pager_PageChanging(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
    {
        pager.CurrentPageIndex = e.NewPageIndex;
        PageBind();
    }

    private void PageBind()
    {
        RegUserBLL dal = new RegUserBLL();
        IList<Lgwin.Model.RegUser> list = dal.GetUserList("", "zaizhi DESC, paixu");
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = list;
        pds.AllowPaging = true;
        pds.PageSize = pager.PageSize;
        pds.CurrentPageIndex = pager.CurrentPageIndex - 1;
        pager.RecordCount = dal.GetUserCount("", "");
        Repeater1.DataSource = pds;
        Repeater1.DataBind();

    }

    protected void btn_search_Click(object sender, EventArgs e)
    {
        string name = txt_search.Text.Trim();
        RegUserBLL dal = new RegUserBLL();
        IList<Lgwin.Model.RegUser> list = dal.GetUserList(" [namee] like '%"+name+"%'", "zaizhi DESC, paixu");
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = list;
        pds.AllowPaging = true;
        pds.PageSize = pager.PageSize;
        pds.CurrentPageIndex = pager.CurrentPageIndex - 1;
        pager.RecordCount = dal.GetUserCount("", "");
        Repeater1.DataSource = pds;
        Repeater1.DataBind();
    }
}
