using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Web
{
    public class Global : System.Web.HttpApplication
    {

        void Application_Start(object sender, EventArgs e)
        {
            // 在应用程序启动时运行的代码
            Application.Lock();      //临界变量,使用加锁功能,其他用户不能访问。
            Application["UserCount"] = 0;
            Application.UnLock();     //临界变量被解锁。
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs
        }

        void Session_Start(object sender, EventArgs e)
        {
            // 在新会话启动时运行的代码
            Application.Lock();      //临界变量,使用加锁功能,其他用户不能访问。
            Application["UserCount"] = Int32.Parse(Application["UserCount"].ToString()) + 1;
            Application.UnLock();       //临界变量被解锁。
        }

        /// <summary>
        /// 校验参数是否存在SQL字符
        /// </summary>
        /// <param name="tm"></param>
        private void goErr(string tm)
        {
            if (SqlFilter2(tm))
                this.Response.Redirect("http://lgwindow.sdut.edu.cn/err/sql.html");
        }
        /// <summary>
        ///SQL注入过滤
        /// </summary>
        /// <param name="InText">要过滤的字符串</param>
        /// <returns>如果参数存在不安全字符，则返回true</returns>
        public static bool SqlFilter2(string InText)
        {
            string word = "and|exec|insert|select|delete|update|chr|mid|master|or|truncate|char|declare|join|'";
            if (InText == null)
                return false;
            foreach (string i in word.Split('|'))
            {
                if ((InText.ToLower().IndexOf(i + " ") > -1) || (InText.ToLower().IndexOf(" " + i) > -1))
                {
                    return true;
                }
            }
            return false;
        }

        void Session_End(object sender, EventArgs e)
        {
            // 在会话结束时运行的代码。 
            // 注意: 只有在 Web.config 文件中的 sessionstate 模式设置为
            // InProc 时，才会引发 Session_End 事件。如果会话模式设置为 StateServer 
            // 或 SQLServer，则不会引发该事件。
            Application.Lock();
            Application["UserCount"] = Int32.Parse(Application["UserCount"].ToString()) - 1;
            Application.UnLock();
        }
        /// <summary>
        /// 当有数据时交时，触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            //遍历Post参数，隐藏域除外
            foreach (string i in this.Request.Form)
            {
                if (i == "__VIEWSTATE") continue;
                this.goErr(this.Request.Form[i].ToString());
            }
            //遍历Get参数。
            foreach (string i in this.Request.QueryString)
            {
                this.goErr(this.Request.QueryString[i].ToString());
            }
        }

    }
}
