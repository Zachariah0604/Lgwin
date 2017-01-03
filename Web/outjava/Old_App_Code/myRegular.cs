using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Collections;
using System.Text.RegularExpressions;

/// <summary>
///myRegular 用于获得图片地址，判断输入格式是否符合要求等
/// </summary>
public class myRegular
{
    public myRegular()
    {
        //
        //TODO: 在此处添加构造函数逻辑
        //
    }
    /// <summary>
    /// 从给定的文字中提取图片文件jpg|gif|png|bmp|jpeg的完整路径
    /// </summary>
    /// <param name="content">传入的文本内容</param>
    /// <returns>ArrayList文件名数组</returns>
    public static ArrayList Article_File(string content)
    {
        ArrayList arr = new ArrayList();
        Regex re = new Regex("(src=)('|\"| )?(.[^'| |\"]*)(\\.)(jpg|gif|png|bmp|jpeg)('|\"| |>)?", RegexOptions.IgnoreCase);
        MatchCollection matches = re.Matches(content);
        Regex ii = new Regex("src=", RegexOptions.IgnoreCase);
        Regex ij = new Regex("\"", RegexOptions.IgnoreCase);
        //string path = ConfigurationManager.AppSettings["path"];
        string path = HttpContext.Current.Server.MapPath("~/");
        foreach (Match match in matches)
        {
            arr.Add(ij.Replace(path + ii.Replace(match.Groups[0].Value, ""), ""));
        }
        return arr;
    }

    /// <summary>
    /// 从给定的文字中提取给定类型文件(jpg|gif)
    /// </summary>
    /// <param name="content">传入的文本内容</param>
    /// <param name="type">文件类型(用|分割,如jpg|gif)</param>
    /// <returns>ArrayList文件名数组</returns>
    public static ArrayList Article_File(string content, string type)
    {
        if (type == "")
            type = "jpg|gif|png|bmp|jpeg";
        ArrayList arr = new ArrayList();
        Regex re = new Regex("(src=)('|\"| )?(.[^'| |\"]*)(\\.)(" + type + ")('|\"| |>)?", RegexOptions.IgnoreCase);
        MatchCollection matches = re.Matches(content);
        Regex ii = new Regex("src=", RegexOptions.IgnoreCase);
        Regex ij = new Regex("\"", RegexOptions.IgnoreCase);
        //string path = ConfigurationManager.AppSettings["path"];
        string path = HttpContext.Current.Server.MapPath("~/");

        foreach (Match match in matches)
        {
            arr.Add(ij.Replace(path + ii.Replace(match.Groups[0].Value, ""), ""));
        }
        return arr;
    }

    /// <summary>
    /// 返回带有src的图片地址，用于图片显示
    /// </summary>
    /// <param name="content">传入的文本内容</param>
    /// <returns>图片src地址</returns>
    public static ArrayList pic_Src(string content)
    {
        ArrayList arr = new ArrayList();
        Regex re = new Regex("(src=)('|\"| )?(.[^'| |\"]*)(\\.)(jpg|gif|png|bmp|jpeg)('|\"| |>)?", RegexOptions.IgnoreCase);
        MatchCollection matches = re.Matches(content);
        foreach (Match match in matches)
        {
            arr.Add(match.Groups[0].Value);
        }
        return arr;
    }
    /// <summary>
    /// 返回第一张带有src的图片地址，用于图片显示
    /// </summary>
    /// <param name="content">传入的文本内容</param>
    /// <returns>图片src地址</returns>
    public static string pic_Src_Top1(string content)
    {
        ArrayList arr = new ArrayList();
        Regex re = new Regex("(src=)('|\"| )?(.[^'| |\"]*)(\\.)(jpg|gif|png|bmp|jpeg)('|\"| |>)?", RegexOptions.IgnoreCase);
        if (content != "")
        {
            MatchCollection matches = re.Matches(content);
            foreach (Match match in matches)
            {
                arr.Add(match.Groups[0].Value);
            }
        }
        if (arr.Count > 0)
        {
            return arr[0].ToString();
        }
        else
            return null;
    }
    public static string KillHTML(string Content)
    {
        if ((Content != null) && (Content != string.Empty))
        {
            Content = Content.Replace(" ", "");
            Content = Regex.Replace(Content, "<[^>]+>", "");
        }
        return Content;
    }
    /// <summary>
    /// 验证id输入是否符合（1,2,3）
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public static bool idAllStr(string id)
    {
        Regex regex = new Regex(@"^(\d+)(,\d+)*$");
        return regex.IsMatch(id);
    }

    public static bool isNumber(string num)
    {
        Regex regex = new Regex(@"^(\d+)");
        return regex.IsMatch(num);
    }
    public static bool isString(string str)
    {
        Regex regex = new Regex(@"^(\w+)");
        return regex.IsMatch(str);
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
