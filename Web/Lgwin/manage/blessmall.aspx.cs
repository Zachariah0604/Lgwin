using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lgwin.Model;
using Lgwin.BLL;
using Wuqi.Webdiyer;

namespace Lgwin.Lgwin.manage
{
    public partial class blessmall : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // Mystring.chksess();
            string _Action;
            int _id;
            _id = Convert.ToInt32(Request.QueryString["Id"] == null || Request.QueryString["Id"] == string.Empty ? "0" : Request.QueryString["Id"].ToString().Trim());
            _Action = Request.QueryString["Action"] == null || Request.QueryString["Action"] == string.Empty ? "" : Request.QueryString["Action"].ToString().Trim();
            if (!IsPostBack)
            {
                if (_id == 0 || _Action == "")
                {
                    Session["CurrentPageIndex"] = 1;
                 
                }
                else
                {
                    OpreatInitialize(_id, _Action);
                   
                }
            }
            else
            {
                Session["CurrentPageIndex"] = 1;
            }
           PageBind();
        }

        protected void OpreatInitialize(int _id, string _Action)
        {
            switch (_Action)
            {
               
                case "Del":
                    int i = new bless().Del(_id);
                    break;
                default:
                    break;
            }
            PageBind();
        }
        private void PageBind()//重新绑定方法
        {
            int countth;
            ContentBLL dal = new ContentBLL();
            IList<T_love> list = new bless().GetloveList(pager.PageSize, Convert.ToInt32(Session["CurrentPageIndex"].ToString()), "", out countth);
            pager.RecordCount = countth;
            pager.CurrentPageIndex = int.Parse(Session["CurrentPageIndex"].ToString());
            NewsList.DataSource = list;
            NewsList.DataBind();
            //NewsList.Visible = true;
            if (NewsList.Items.Count == 0)
            {
                Label1.Visible = true;
                Label1.Text = "没有数据";
            }


        }
        protected void pager_PageChanging(object src, PageChangingEventArgs e)
        {
            pager.CurrentPageIndex = e.NewPageIndex;
            Session.Remove("CurrentPageIndex");
            Session["CurrentPageIndex"] = pager.CurrentPageIndex;
            PageBind();
        }
    
    }
}