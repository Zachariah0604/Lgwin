using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using Lgwin.BLL;
using Lgwin.Model;

namespace Lgwin.topic.blesswall
{
    public partial class blessindex : System.Web.UI.Page
    {
        public StringBuilder sb = null;
        public string str = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            PageBind();
        }
        protected void pager_PageChanging(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
        {
            pager.CurrentPageIndex = e.NewPageIndex;
            PageBind();
        }
        public void PageBind()
        {
            int count;
            IList<T_love> list =new bless().GetloveList(pager.PageSize, pager.CurrentPageIndex, "", out count);
            pager.RecordCount = count;
            Repeater1.DataSource = list;
            Repeater1.DataBind();
        }
    }
}