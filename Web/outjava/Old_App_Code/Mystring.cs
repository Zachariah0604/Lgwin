using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using Lgwin.BLL;
using Lgwin.Model;
/// <summary>
///Mystring 的摘要说明
/// </summary>
public class Mystring
{
    public Mystring()
    {
        //
        //TODO: 在此处添加构造函数逻辑
        //
    }
    /// <summary>
    /// 检查Session是否超时
    /// </summary>
    /// <returns></returns>
    public static bool chksess()
    {
        if (HttpContext.Current.Session["User"] == null || HttpContext.Current.Session["User"].ToString().Length < 1 || HttpContext.Current.Session["Name"] == null || HttpContext.Current.Session["Name"].ToString().Length < 1)
        {
            HttpContext.Current.Session.Abandon();
            alertAndRedirect("你未登录或超时,请重新登录！","UserLogin.aspx","top");
            HttpContext.Current.Response.End();
            return false;
        }
        else
            return true;
    }
    /// <summary>
    /// 检查光影理工专题Session是否超时
    /// </summary>
    /// <returns></returns>
    public static bool photochksess()
    {
        if (HttpContext.Current.Session["User"] == null || HttpContext.Current.Session["User"].ToString().Length < 1 || HttpContext.Current.Session["Name"] == null || HttpContext.Current.Session["Name"].ToString().Length < 1)
        {
            HttpContext.Current.Session.Abandon();
            alertAndRedirect("你未登录或超时,请重新登录！", "../../Lgwin/manage/UserLogin.aspx", "top");
            HttpContext.Current.Response.End();
            return false;
        }
        else
            return true;
        
        }
    /// <summary>
    /// karat检查Session是否超时
    /// </summary>
    /// <returns></returns>
    public static bool karatchksess()
    {
        if (HttpContext.Current.Session["User"] == null || HttpContext.Current.Session["User"].ToString().Length < 1 || HttpContext.Current.Session["Name"] == null || HttpContext.Current.Session["Name"].ToString().Length < 1)
        {
            HttpContext.Current.Session.Abandon();
            alertAndRedirect("你未登录或超时,请重新登录！", "../../lgwin/manage/UserLogin.aspx", "top");
            HttpContext.Current.Response.End();
            return false;
        }
        else
            return true;
    }
    /// <summary>
    /// 检查身份是否符合要求
    /// </summary>
    /// <param name="dangqian">当前用户身份</param>
    /// <param name="yaoqiu">本页要求身份</param>
    /// <returns></returns>
    public static bool chkAdmin(string dangqian, int yaoqiu)
    {
        int dangint = int.Parse(dangqian.Trim());
        if (dangint > yaoqiu)
        {
            alertAndBack("对不起，此操作有权限要求，您的权限不足");
            return false;
        }
        else
            return true;
 
    }
    /// <summary>
    /// 检查权限是否符合要求
    /// </summary>
    /// <param name="yaoqiu">本页要求权限id</param>
    /// <param name="user">登录用户</param>
    /// <returns></returns>
    public static bool chkPower(int yaoqiu,string user)
    {
        RegUser mod = new RegUser();
        RegUserBLL bll = new RegUserBLL();
        mod = bll.GetUserInfo(user);
        if (mod.Power.IndexOf("|"+yaoqiu.ToString() + "|") < 0)
        {
            alertAndBack("对不起，此操作有权限要求，您的权限不足");
            return false;
        }
        else
            return true;

    }
    public static bool chkPower1(int yaoqiu, string user)
    {
        RegUser mod = new RegUser();
        RegUserBLL bll = new RegUserBLL();
        mod = bll.GetUserInfo(user);
        if (mod.Power.IndexOf("|" + yaoqiu.ToString() + "|") < 0)
        {
            
            return false;
        }
        else
            return true;

    }
     //Session.Add("Admin", _Model.Admin);
     //           Session.Add("Power", _Model.Power);
     //           Session.Add("Name", _Model.Name);
     //           Session.Add("User", _Model.UserName);
    /// <summary>
    /// 提示跳转js函数，调用举例 myString.alertAndRedirect(this, "成功", "Art_manage.aspx");
    /// </summary>
    /// <param name="page">this</param>
    /// <param name="msg">弹出对话框的内容</param>
    /// <param name="url">要跳转到的页面</param>
    public static void alertAndRedirect(Page page, string msg, string url)
    {
        StringBuilder builder = new StringBuilder();
        builder.Append("<script language='javascript' defer>");
        builder.AppendFormat("alert('{0}');", msg);
        builder.AppendFormat("self.location.href='{0}'", url);
        builder.Append("</script>");
        page.ClientScript.RegisterStartupScript(page.GetType(), "message", builder.ToString());
    }
    /// <summary>
    /// 提示跳转函数，调用举例 myString.alertAndRedirect("成功", "Art_manage.aspx","top");
    /// </summary>
    /// <param name="mes">弹出对话框的内容</param>
    /// <param name="url">要跳转到的页面</param>
    /// <param name="topOrSelf">top表示跳出框架转到url，self表示自身跳转</param>
    public static void alertAndRedirect(string mes, string url, string topOrSelf)
    {
        string err;
        if (mes == "")
            mes = "对不起，未知错误……";
        if (url != "")
            url = topOrSelf + ".location=\"" + url + "\"";
        err = "<script language='javascript' defer>alert(\"" + mes + "\");" + url + "</script>";
        HttpContext.Current.Response.Write(err);
    }
    /// <summary>
    /// 提示跳转函数，调用举例 myString.alertAndRedirect("成功", "Art_manage.aspx");
    /// </summary>
    /// <param name="mes">弹出对话框的内容</param>
    /// <param name="url">要跳转到的页面</param>
    public static void alertAndRedirect(string mes, string url)
    {
        string err;
        if (mes == "")
            mes = "对不起，未知错误……";
        if (url != "")
            url = "self.location=\"" + url + "\"";
        err = "<script language='javascript' defer>alert(\"" + mes + "\");" + url + "</script>";
        HttpContext.Current.Response.Write(err);
    }
    /// <summary>
    /// 提示并关闭当前页函数
    /// </summary>
    /// <param name="mes">提示内容</param>
    /// <param name="close">trueOrfalse</param>
    public static void alertAndClose(string mes, bool close)
    {
        string err = "", url = "";
        if (mes == "")
            mes = "对不起，未知错误……";
        if (close == true)
            url = "window.close()";
        err = "<script>alert(\"" + mes + "\");" + url + "</script>";
        HttpContext.Current.Response.Write(err);
    }
    /// <summary>
    /// 提示信息函数
    /// </summary>
    /// <param name="mes">提示内容</param>
    public static void alert(string mes)
    {
        alertAndClose(mes, false);
    }
    public static void alertAndBack(string mes)
    {
        string err = "";
        if (mes == "")
        mes = "对不起，未知错误……";
        err = "<script>alert(\"" + mes + "\");history.go(-2)</script>";
        HttpContext.Current.Response.Write(err); 
    }
    /// <summary>
    /// 后退，取消操作用的
    /// </summary>
    public static void Back()
    {
        string err = "";
        err = "<script>history.go(-2)</script>";
        HttpContext.Current.Response.Write(err);
    }
    /// <summary>
    /// 把数据库中的bit类型转换成汉字“是”或“否”
    /// </summary>
    /// <param name="str"></param>
    /// <returns>是或否</returns>
    public static string boolStr(object str)
    {
        if ((bool)str == true)
            return "<font color='#FF0000'>是</font>";
        else
            return "<font color='#ddd7da'>否</font>";
    }
    public static string zaizhiStr(object str)
    {
        if ((bool)str == true)
            return "<font color='#FF0000'>在职</font>";
        else
            return "离职";
    }
    /// <summary>
    /// 管理员权限转换，分为超级、高级和普通管理员
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static string adminStr(object str)
    {
        if (str.ToString() == "0")
            return "<font color='#FF0000'>超级管理员</font>";
        if (str.ToString() == "1")
            return "<font color='#DD0000'>高级管理员</font>";
        if (str.ToString() == "2")
            return "文章管理员";
        else
            return "普通管理员";
    }
   
    /// <summary>
    /// 字符串截取函数，不足长度的用“...”填充
    /// </summary>
    /// <param name="s">被截字符串</param>
    /// <param name="len">截取长度</param>
    /// <returns></returns>
    public static string lim_withPoint(string s, int len)
    {
        string result = ""; //最终返回的结果
        int byteLen = System.Text.Encoding.Default.GetByteCount(s);  //单字节字符长度
        int charLen = s.Length; //把字符平等对待时的字符串长度
        int byteCount = 0;  //记录读取进度{中文按两单位计算}
        int pos = 0;    //记录截取位置{中文按两单位计算}
        int last = 1;       //记录上一字符
        if (byteLen > len)
        {
            for (int i = 0; i < charLen; i++)
            {
                if (Convert.ToInt32(s.ToCharArray()[i]) > 255)  //遇中文字符计数加2
                {
                    byteCount += 2;
                    last = 2;
                }
                else         //按英文字符计算加1
                {
                    byteCount += 1;
                    last = 1;
                }
                if (byteCount >= len)   //到达指定长度时，记录指针位置并停止
                {
                    pos = i;
                    break;
                }
            }
            if (last == 1)
                result = s.Substring(0, pos) + ".";
            else
                result = s.Substring(0, pos) + "..";
        }

        else
        {
            result = s;
            for (int j = 0; j < len - byteLen; j++)
                result += ".";
        }

        return result;
    }

    /// <summary>
    /// 字符串截取函数，不足长度的不变
    /// </summary>
    /// <param name="beforeString">被截字符</param>
    /// <param name="stringLength">截取长度</param>
    /// <returns></returns>
    public static string lim_withoutPoint(string beforeString, int stringLength)
    {
        if (beforeString.Length <= stringLength)
        {
            return beforeString;
        }
        else
        {
            beforeString = beforeString.Substring(0, stringLength);
            beforeString = beforeString + "...";
            return beforeString;
        }
    }
    /// <summary>
    /// 字符串截取函数，不足长度的不变,不自动加点
    /// </summary>
    /// <param name="beforeString">被截字符</param>
    /// <param name="stringLength">截取长度</param>
    /// <returns></returns>
    public static string lim_withoutPointNo(string beforeString, int stringLength)
    {
        if (beforeString.Length <= stringLength)
        {
            return beforeString;
        }
        else
        {
            beforeString = beforeString.Substring(0, stringLength);
            beforeString = beforeString + "";
            return beforeString;
        }
    }
    /// <summary>
    /// 字符串截取函数，不足长度的不变
    /// </summary>
    /// <param name="i">从i处开始截取,如果i=0加“..”调用lim_withoutPoint(string beforeString, int stringLength)</param>
    /// <param name="beforeString">被截字符</param>
    /// <param name="stringLength">截取长度</param>
    /// <returns></returns>
    public static string lim_withoutPoint(int i, string beforeString, int stringLength)
    {
        if (beforeString.Length <= stringLength)
        {
            return beforeString;
        }
        else
        {
            beforeString = beforeString.Substring(i, stringLength);
            return beforeString;
        }
    }

    /// <summary>
    /// 时间日期格式控制函数
    /// </summary>
    /// <param name="str">被控制时间日期</param>
    /// <param name="style">显示格式，如"yyyy-MM-dd"</param>
    /// <returns></returns>
    public static string dateStr(object str, string style)
    {
        DateTime dt = (DateTime)str;
        string s = dt.ToString(style);
        return s;
    }
    /// <summary>
    /// 检查文章编辑状态函数
    /// </summary>
    /// <param name="ids">要检查的文章ID</param>
    /// <returns>1表示正被编辑，0表示没有被编辑</returns>
    public static string CheckEditorState(int ids)
    {
        
        string adress = "";
        ContentBLL cont = new ContentBLL();
        int vla = cont.ReadState(ids);
        if (vla == 1)
        {
            adress = "return confirm('文章正在被编辑？确定要强行编辑吗？')";
        }
        else
        {
            adress = "";
        }
        return adress;
    }
    public static string DelHTML(string Htmlstring)//将HTML去除
    {

        #region

        //删除脚本

        Htmlstring = System.Text.RegularExpressions.Regex.Replace(Htmlstring, @"<script[^>]*?>.*?</script>", "", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        //删除HTML

        Htmlstring = System.Text.RegularExpressions.Regex.Replace(Htmlstring, @"<(.[^>]*)>", "", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        Htmlstring = System.Text.RegularExpressions.Regex.Replace(Htmlstring, @"([\r\n])[\s]+", "", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        Htmlstring = System.Text.RegularExpressions.Regex.Replace(Htmlstring, @"-->", "", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        Htmlstring = System.Text.RegularExpressions.Regex.Replace(Htmlstring, @"<!--.*", "", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        //Htmlstring =System.Text.RegularExpressions. Regex.Replace(Htmlstring,@"<A>.*</A>","");

        //Htmlstring =System.Text.RegularExpressions. Regex.Replace(Htmlstring,@"<[a-zA-Z]*=\.[a-zA-Z]*\?[a-zA-Z]+=\d&\w=%[a-zA-Z]*|[A-Z0-9]","");

        Htmlstring = System.Text.RegularExpressions.Regex.Replace(Htmlstring, @"&(quot|#34);", "\"", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        Htmlstring = System.Text.RegularExpressions.Regex.Replace(Htmlstring, @"&(amp|#38);", "&", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        Htmlstring = System.Text.RegularExpressions.Regex.Replace(Htmlstring, @"&(lt|#60);", "<", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        Htmlstring = System.Text.RegularExpressions.Regex.Replace(Htmlstring, @"&(gt|#62);", ">", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        Htmlstring = System.Text.RegularExpressions.Regex.Replace(Htmlstring, @"&(nbsp|#160);", " ", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        Htmlstring = System.Text.RegularExpressions.Regex.Replace(Htmlstring, @"&(iexcl|#161);", "\xa1", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        Htmlstring = System.Text.RegularExpressions.Regex.Replace(Htmlstring, @"&(cent|#162);", "\xa2", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        Htmlstring = System.Text.RegularExpressions.Regex.Replace(Htmlstring, @"&(pound|#163);", "\xa3", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        Htmlstring = System.Text.RegularExpressions.Regex.Replace(Htmlstring, @"&(copy|#169);", "\xa9", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        Htmlstring = System.Text.RegularExpressions.Regex.Replace(Htmlstring, @"&#(\d+);", "", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        Htmlstring.Replace("<", "");

        Htmlstring.Replace(">", "");

        Htmlstring.Replace("\r\n", "");

        //Htmlstring=HttpContext.Current.Server.HtmlEncode(Htmlstring).Trim();

        #endregion

        return Htmlstring;

    }

}