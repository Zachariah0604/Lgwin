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
    /// admin_counter_month 的摘要说明。
    /// </summary>
    public partial class admin_counter_month : System.Web.UI.Page
    {
        protected System.Web.UI.WebControls.HyperLink HyperLink2;
        protected System.Web.UI.WebControls.HyperLink HyperLink1;
        public string sweek;
        public string[] Lastday;
        public int LastdayL;
        public int SumCount;
        public int MaxCount;
        public DataSet dsadmin;
        public AboutCounter counterabout = new AboutCounter();
        public int pmonth;
        public string aboutdate;
        public int LeftPx;
        public int Cmonth;
        public int Cyear;
        public int CountMonth;

        public string GetDayOfWeek(string weekday)
        {
            string weekdaytemp = weekday;
            switch (weekday)
            {
                case "Monday":
                    sweek = "一";
                    break;
                case "Tuesday":
                    sweek = "二";
                    break;
                case "Wednesday":
                    sweek = "三";
                    break;
                case "Thursday":
                    sweek = "四";
                    break;
                case "Friday":
                    sweek = "五";
                    break;
                case "Saturday":
                    sweek = "六";
                    break;
                case "Sunday":
                    sweek = "日";
                    break;
            }
            return sweek;
        }
        private void Page_Load(object sender, System.EventArgs e)
        {

            Cyear = Convert.ToInt32(Convert.ToDateTime(DateTime.Now).ToString("yyyy"));
            Cmonth = Convert.ToInt32(Convert.ToDateTime(DateTime.Now).ToString("MM"));
            //CountMonth = Convert.ToInt32(Convert.ToDateTime(DateTime.Now).ToString("yyyyMM"));


            if (Request.QueryString["step"] != null)
            {
                if (Request.QueryString["step"].ToString() == "1")
                {
                    Cmonth = Cmonth - 1;
                    if (Cmonth < 1)
                    {
                        Cmonth = Cmonth + 12;
                        Cyear = Cyear - 1;
                    }
                    else
                        Cyear = Cyear;

                }
                if (Request.QueryString["step"].ToString() == "2")
                {
                    Cmonth = Cmonth - 2;
                    if (Cmonth < 1)
                    {
                        Cmonth = Cmonth + 12;
                        Cyear = Cyear - 1;
                    }
                    else
                        Cyear = Cyear;
                }
            }
            else
            {
                Cmonth = Cmonth;
                Cyear = Cyear;
            }
            if (Cmonth.ToString().Length < 2)//Lrg于2010/5/14改
            {
                CountMonth = Convert.ToInt32(Convert.ToString(Cyear) + "0" + Convert.ToString(Cmonth));//ToInt32此方法会把前面的零去掉，而插入数据时用的Convert.ToInt32(Convert.ToDateTime(DateTime.Now).ToString("yyyyMM"))，月份前有零，这将导致取不到数据
            }
            else
            {
                CountMonth = Convert.ToInt32(Convert.ToString(Cyear) + Convert.ToString(Cmonth));
            }
            //int Cdata = Convert.ToInt32(Convert.ToString(Cyear) + Convert.ToString(Cmonth));
            pmonth = (int)counterabout.SelectCountMonthC(CountMonth);
            aboutdate = Convert.ToString(Cyear) + "-" + Convert.ToString(Cmonth);

            if (Cyear % 4 == 0)
            {
                string strday = "31,31,29,31,30,31,30,31,31,30,31,30,31";
                Lastday = strday.Split(new Char[] { ',' });
            }
            else
            {
                string strday = "31,31,28,31,30,31,30,31,31,30,31,30,31";
                Lastday = strday.Split(new Char[] { ',' });
            }
            LastdayL = Convert.ToInt32(Lastday[Cmonth]);

            if (pmonth != 0)
            {
                dsadmin = new DataSet();
                dsadmin = counterabout.CountMonthList("Count_Month", CountMonth);

                MaxCount = 0;
                for (int i = 1; i <= LastdayL; i++)
                {
                    SumCount += Convert.ToInt32(dsadmin.Tables["Count_Month"].Rows[0][i].ToString());

                    if (Convert.ToInt32(dsadmin.Tables["Count_Month"].Rows[0][i].ToString()) > MaxCount)
                    {
                        MaxCount = Convert.ToInt32(dsadmin.Tables["Count_Month"].Rows[0][i].ToString());
                    }
                }
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
          this.Load += new System.EventHandler(this.Page_Load);
        }
        #endregion
    }
}
