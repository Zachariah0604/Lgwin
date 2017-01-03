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


namespace Asp600.AboutAdmin.AdminCounter
{
    /// <summary>
    /// admin_counter_os 的摘要说明。
    /// </summary>
    public partial class admin_counter_os : System.Web.UI.Page
    {
        public AboutCounter counterabout = new AboutCounter();
        public int pcount1;
        public DataSet dsadmin;
        public DataSet dsadmin1;
        public int SumCount;
        public int MaxCount;
        public int LeftPx;
        public int getlength(int o)
        {
            if (MaxCount == 0)
            {
                LeftPx = 0;
            }
            else
            {
                LeftPx = Convert.ToInt32((250 * o) / MaxCount);
            }
            return 1 + LeftPx;
        }
        public int getlength1(int o)
        {
            if (MaxCount == 0)
            {
                LeftPx = 0;
            }
            else
            {
                LeftPx = Convert.ToInt32((250 * o) / MaxCount);
            }
            return 250 - LeftPx;
        }
        protected void Page_Load(object sender, System.EventArgs e)
        {

            pcount1 = (int)counterabout.SelectCountBOL("Count_Os");
            if (pcount1 != 0)
            {
                dsadmin = new DataSet();
                dsadmin = counterabout.CountBOLList("Count_Os");
                MaxCount = (int)counterabout.SelectMaxCountBOL("Count_Os");
                dsadmin1 = counterabout.SelectSumCountBOL("Count_Os");
                SumCount = Convert.ToInt32(dsadmin1.Tables["Count_Os"].Rows[0][0].ToString());
                Repeater1.DataSource = dsadmin.Tables["Count_Os"];
                Repeater1.DataBind();
            }
        }

        #region Web 窗体设计器生成的代码
        override protected void OnInit(EventArgs e)
        {
            //
            // CODEGEN: 该调用是 ASP.NET Web 窗体设计器所必需的。
            //
            InitializeComponent();
            base.OnInit(e);
        }

        /// <summary>
        /// 设计器支持所需的方法 - 不要使用代码编辑器修改
        /// 此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
        }
        #endregion
    }
}
