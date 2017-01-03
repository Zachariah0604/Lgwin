using System;
using System.Web;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Text;
using Count;
using System.Collections.Generic;
using Lgwin.BLL;
using Lgwin.Model;

public partial class FWStatistics : System.Web.UI.Page
{
    //访问统计前台页，在静态页中调用
    public string VisitedIP;//获取IP
    public string VisitedAddress;//获取地址
    public string VisitedIplocal;//获取上网方式
    public string VisitedMethod;//获取浏览途径
    public string VisitedRefer;//获取上次访问URL
    public string VisitedIe;//获取IE版本
    public string VisitedSystem;//获取操作系统
    public AboutCounter counterabout = new AboutCounter();
    public int AddResult;
    public int EditResult;
    public int Cyear;
    public int Cmonth;
    public int Cday;
    public int CountMonth;
    protected void Page_Load(object sender, EventArgs e)
    {        
        if (1 == 1)//Request.Cookies["havecount"] == null)
        {
           HttpContext.Current.Response.Cookies["havecount"].Value = "yes";
            //获取用户真实IP
            if (Request.ServerVariables["HTTP_VIA"] != null)
            {
                VisitedIP = Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
            }
            else
            {
                if (Request.ServerVariables["HTTP_VIA"] != null)
                {
                    VisitedIP = Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
                }
                else
                {
                    VisitedIP = Request.ServerVariables["REMOTE_ADDR"].ToString();
                }

            }
            //end 已经获取VisitedIP 
            //根据IP判断来自何处
            StringBuilder strResult = new StringBuilder();
            string[] strip = VisitedIP.Split('.');
            foreach (string strips in strip)
            {
                if (strips.Length == 1)
                {
                    strResult.Append("00");
                    strResult.Append(strips);
                    strResult.Append(".");
                }
                if (strips.Length == 2)
                {
                    strResult.Append("0");
                    strResult.Append(strips);
                    strResult.Append(".");
                }
                if (strips.Length == 3)
                {
                    strResult.Append(strips);
                    strResult.Append(".");
                }
            }
            string finalip = strResult.ToString().Substring(0, 15).Trim();
            int pid = (int)counterabout.SelectUserIplocalA(finalip);
            if (pid != 0)
            {
                DataSet dsaddress = new DataSet();
                dsaddress = counterabout.SelectUserIplocalD("Count_Iplocal", finalip);
                VisitedAddress = dsaddress.Tables["Count_Iplocal"].Rows[0][0].ToString();
                VisitedIplocal = dsaddress.Tables["Count_Iplocal"].Rows[0][1].ToString();
                dsaddress.Dispose();//zgy
            }
            else
            {
                VisitedAddress = "未知IP地址";
            }
            //已经获取VisitedAddress,VisitedIplocal
            //获取结束
            //获取用户访问途径
            //获取上页访问URL
            ViewState["url"] = Request.UrlReferrer;
            Uri VisitedUrl = (Uri)ViewState["url"];
            //判断来源	
            if (ViewState["url"] != null)
            {
                string[,] Usercome = { { "sina.com.cn", "新浪搜索" }, { "sohu.com", "搜狐搜索" }, { "baidu.com", "百度搜索" }, { "online.sh.cn", "上海热线" }, { "163.com", "网易搜索" }, { "yahoo.com", "Yahoo" }, { "21cn.com", "21cn搜索" }, { "google.com", "Google" }, { "china.com", "中华网" }, { "3721.com", "网络实名" }, { "lycos.com", "Lycos搜索" }, { "fm365.com", "FM365搜索" }, { "tom.com", "Tom搜索" }, { "61.145.114.84", "网络实名" }, { "218.244.44.36", "网络实名" }, { "218.244.44.6", "网络实名" }, { "218.244.44.37", "网络实名" } };
                int LengthOfusercome = Usercome.GetLength(0);
                for (int i = 0; i < LengthOfusercome; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        int ifcheck = VisitedUrl.ToString().IndexOf(Usercome[i, 0]);
                        if (ifcheck >= 0)
                            VisitedMethod = Usercome[i, 1];
                    }
                }
                if (VisitedMethod == null)
                {
                    VisitedMethod = "其他位置";
                }
                VisitedRefer = ViewState["url"].ToString();
            }
            else
            {
                VisitedMethod = "域名输入";
                VisitedRefer = "";
            }
            //已经获取VisitedMethod				
            VisitedIe = User.Agent(1);
            VisitedSystem = User.Agent(2);
            //至此结束,用户信息全部获取
            //Response.Write(VisitedIP + "<br>");//获取IP
            //Response.Write(VisitedAddress + "<br>");//获取地址
            //Response.Write(VisitedIplocal + "<br>");//获取上网方式
            //Response.Write(VisitedMethod + "<br>");//获取浏览途径			
            //Response.Write(VisitedRefer + "<br>");//获取上次访问URL
            //Response.Write(VisitedIe + "<br>");//获取IE版本
            //Response.Write(VisitedSystem + "<br>");//获取操作系统	
            //将数据添加到用户访问信息中
            AddResult = (int)counterabout.AddUserInfor(VisitedIP, DateTime.Now.ToString(), VisitedAddress, VisitedIplocal, VisitedRefer, VisitedIe, VisitedSystem);
            Cyear = Convert.ToInt32(Convert.ToDateTime(DateTime.Now).ToString("yyyy"));
            Cmonth = Convert.ToInt32(Convert.ToDateTime(DateTime.Now).ToString("MM"));
            Cday = Convert.ToInt32(Convert.ToDateTime(DateTime.Now).ToString("dd"));
            CountMonth = Convert.ToInt32(Convert.ToDateTime(DateTime.Now).ToString("yyyyMM"));

            //添加年记录
            int pyear = (int)counterabout.SelectCountYearA(Cyear);
            if (pyear == 0)
            {
                AddResult = (int)counterabout.AddYear(Cyear);
            }
            EditResult = (int)counterabout.EditYear(Cyear, Cmonth);
            //至此结束
            //添加月记录
            int pmonth = (int)counterabout.SelectCountMonthC(CountMonth);
            if (pmonth == 0)
            {
                AddResult = (int)counterabout.AddMonth(CountMonth);
            }
            EditResult = (int)counterabout.EditMonth(CountMonth, Cday);
            //至此结束
            //添加Browser.os.local,sute
            int pcount1 = (int)counterabout.SelectCountBOL("Count_Browser", VisitedIe);
            if (pcount1 == 0)
            {
                AddResult = (int)counterabout.AddBOL("Count_Browser", VisitedIe);
            }
            EditResult = (int)counterabout.EditBOLE("Count_Browser", VisitedIe);
            //
            int pcount2 = (int)counterabout.SelectCountBOL("Count_Os", VisitedSystem);
            if (pcount2 == 0)
            {
                AddResult = (int)counterabout.AddBOL("Count_Os", VisitedSystem);
            }
            EditResult = (int)counterabout.EditBOLE("Count_Os", VisitedSystem);
            //
            int pcount3 = (int)counterabout.SelectCountBOL("Count_Local", VisitedAddress);
            if (pcount3 == 0)
            {
                AddResult = (int)counterabout.AddBOL("Count_Local", VisitedAddress);
            }
            EditResult = (int)counterabout.EditBOLE("Count_Local", VisitedAddress);
            //
            int pcount4 = (int)counterabout.SelectCountBOL("Count_Site", VisitedMethod);
            if (pcount4 == 0)
            {
                AddResult = (int)counterabout.AddBOL("Count_Site", VisitedMethod);
            }
            EditResult = (int)counterabout.EditBOLE("Count_Site", VisitedMethod);
            //至此结束

        }
        else
        {
            //Response.Write("已经统计");
        }
        counterabout.upTotal();
        int Count = Convert.ToInt32(counterabout.SelectToday(CountMonth, Cday));
        counterabout.upMaxDay(Count);        
    }
    public class User//获取用户操作系统和浏览器版本
    {
        public static string Agent(int intNum)
        {
            string strResult = null;
            strResult = HttpContext.Current.Request.UserAgent.Split(';')[intNum].Trim().Replace("(", "").Replace(")", "");
            switch (intNum)
            {
                case 1:
                    strResult = Browser(strResult);
                    break;
                case 2:
                    strResult = System(strResult);
                    break;
            }
            return strResult;
        }

        public static string System(string strPara)
        {
            string strResult = null;
            switch (strPara)
            {
                case "Windows 4.10":
                    strResult = "Windows 98";
                    break;
                case "Windows 4.9":
                    strResult = "Windows Me";
                    break;
                case "Windows NT 5.0":
                    strResult = "Windows 2000";
                    break;
                case "Windows NT 5.1":
                    strResult = "Windows XP";
                    break;
                case "Windows NT 5.2":
                    strResult = "Windows Server 2003";
                    break;
                default:
                    strResult = "其他系统";
                    break;
            }
            return strResult;
        }

        public static string Browser(string strPara)
        {
            string strResult = null;
            strResult = strPara.Replace("MSIE", "Internet Explorer");
            return strResult;
        }
    }
}
