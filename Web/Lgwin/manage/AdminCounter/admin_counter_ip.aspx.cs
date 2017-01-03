using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using Count;
using Wuqi.Webdiyer;


namespace Asp600.AboutAdmin.AdminCounter
{
    /// <summary>
    /// admin_counter_ip ��ժҪ˵����
    /// </summary>
    public partial class admin_counter_ip : System.Web.UI.Page
    {
        public AboutCounter counterabout = new AboutCounter();
        public int allcount;

        protected void Page_Load(object sender, System.EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                DataBindChannel();
            }
            pager.RecordCount = counterabout.CountListCount("Count_Visitor");
            allcount = pager.RecordCount;
            DataBindChannel();
        }
        public void DataBindChannel()
        {
            DataSet newslist = new DataSet();
            int repeatestr1 = pager.PageSize * (pager.CurrentPageIndex-1);
            int repeatestr2 = pager.PageSize;
            newslist = counterabout.CountList("Count_Visitor", repeatestr1, repeatestr2);
            Repeater1.DataSource = newslist.Tables["Count_Visitor"];
            Repeater1.DataBind();
        }

        #region Web ������������ɵĴ���
        //override protected void OnInit(EventArgs e)
        //{
        //    //
        //    // CODEGEN: �õ����� ASP.NET Web ���������������ġ�
        //    //
        //    InitializeComponent();
        //    base.OnInit(e);
        //}

        ///// <summary>
        ///// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
        ///// �˷��������ݡ�
        ///// </summary>
        //private void InitializeComponent()
        //{
        //    this.AspNetPager1.PageChanged += new Wuqi.Webdiyer.PageChangedEventHandler(this.AspNetPager1_PageChanged);

        //}
        #endregion
        protected void pager_PageChanging(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
        {
            pager.CurrentPageIndex = e.NewPageIndex;
            DataBindChannel();
        }
}
}