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
	/// admin_counter_year 的摘要说明。
	/// </summary>
	public partial class admin_counter_year : System.Web.UI.Page
	{
	    public AboutCounter counterabout=new AboutCounter();
		public int Cmonth;
		public int Cyear;
		public int pmonth;
		public int SumCount;
		public int MaxCount;
		public DataSet dsadmin;
		public int LeftPx;
		protected void Page_Load(object sender, System.EventArgs e)
		{			
			Cyear = Convert.ToInt32(Convert.ToDateTime(DateTime.Now).ToString("yyyy"));			
			if (Request.QueryString["step"]!=null)
			{
				if (Request.QueryString["step"].ToString()=="1")
				{					
				Cyear = Cyear - 1;	
                }
				if (Request.QueryString["step"].ToString()=="2")
				{					
				Cyear = Cyear - 2;					
				}			
			}
			else
			{				
				Cyear = Cyear;
			}
			pmonth=(int)counterabout.SelectCountYearA(Cyear);
			if (pmonth!=0)
			{
				dsadmin=new DataSet();			
				dsadmin=counterabout.CountYearList("Count_Year",Cyear);         
						
				MaxCount=0;
				for (int i=1; i<=12; i++)
				{
					SumCount+=Convert.ToInt32(dsadmin.Tables["Count_Year"].Rows[0][i].ToString());
				   
					if (Convert.ToInt32(dsadmin.Tables["Count_Year"].Rows[0][i].ToString())>MaxCount)
					{
						MaxCount=Convert.ToInt32(dsadmin.Tables["Count_Year"].Rows[0][i].ToString());
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

		}
		#endregion
	}
}
