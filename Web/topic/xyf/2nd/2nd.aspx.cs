using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lgwin.BLL;
using Lgwin.Model;

namespace Lgwin.topic.xyf._2nd
{
    public partial class _2nd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.danghao.Visible = false;
            if(!IsPostBack)
            {  
               zhanqipagerbind();
                zhanhupagerbind();
              
            }
        }
        public void zhanqipagerbind()
        {
            int count;
            ContentBLL dal = new ContentBLL();
            IList<Model.Content> list1 = dal.GetList(zhanqipager.PageSize, zhanqipager.CurrentPageIndex, "auditing = 'True' and zt='55' and ztid='179'", out count);
                zhanqipager.RecordCount = count;
                zhanqi.DataSource = list1;
                zhanqi.DataBind();
          
        }
        public void zhanhupagerbind()
        {
            ContentBLL dal = new ContentBLL();
            int count;
            int curpage = Convert.ToInt32(this.labPage.Text);
            PagedDataSource ps = new PagedDataSource();
            IList<Model.Content> list = dal.GetList(30, 1, "auditing = 'True' and zt='55' and ztid='180'", out count);
            ps.DataSource = list;
            ps.AllowPaging = true; //是否可以分页
            ps.PageSize = 6; //显示的数量
            ps.CurrentPageIndex = curpage - 1; //取得当前页的页码
            this.lnkbtnUp.Enabled = true;
            this.lnkbtnNext.Enabled = true;
            this.lnkbtnBack.Enabled = true;
            this.lnkbtnOne.Enabled = true;
            if (curpage == 1)
            {
                this.lnkbtnOne.Enabled = false;//不显示第一页按钮
                this.lnkbtnUp.Enabled = false;//不显示上一页按钮
            }
            if (curpage == ps.PageCount)
            {
                this.lnkbtnNext.Enabled = false;//不显示下一页
                this.lnkbtnBack.Enabled = false;//不显示最后一页
            }
            this.labBackPage.Text = Convert.ToString(ps.PageCount);
            this.zhanhu.DataSource = ps;
            this.zhanhu.DataBind();


            if (list.Count > 6)
            {
                this.danghao.Visible = true;

            }
            else {
                this.danghao.Visible = false;
            }
        }

        protected void zhanqipager_PageChanging(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
        {
            zhanqipager.CurrentPageIndex = e.NewPageIndex;
            zhanqipagerbind();

        }

   
        public string geturl(string str)
        {
            string urlimg = string.Empty;
            string imgurl = string.Empty;
            int imgstart = str.IndexOf("uploads");
            int imgend = str.IndexOf(".jpg");
            urlimg = "" + str.Substring(imgstart, imgend - imgstart + 4);
            return urlimg;
        }
        protected void lnkbtnOne_Click(object sender, EventArgs e)
        {
            this.labPage.Text = "1";
            this.zhanhupagerbind();
        }
        protected void lnkbtnUp_Click(object sender, EventArgs e)
        {
            this.labPage.Text = Convert.ToString(Convert.ToInt32(this.labPage.Text) - 1);
            this.zhanhupagerbind();
        }
        protected void lnkbtnNext_Click(object sender, EventArgs e)
        {
            this.labPage.Text = Convert.ToString(Convert.ToInt32(this.labPage.Text) + 1);
            this.zhanhupagerbind();
        }
        protected void lnkbtnBack_Click(object sender, EventArgs e)
        {
            this.labPage.Text = this.labBackPage.Text;
            this.zhanhupagerbind();
        }
      
    }
}