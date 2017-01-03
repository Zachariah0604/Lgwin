using System;
using System.Data;
using System.Collections;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Lgwin.Model;
using Lgwin.BLL;
//using Web.App_Code;
using Lgwin.Pic;
using System.Text.RegularExpressions;

/// <summary>
///ToHtml静态页管理类，包括生成和删除
/// </summary>
public class ToHtml
{


    public ToHtml()
    {
        //
        //TODO: 在此处添加构造函数逻辑
        //
    }
    /// <summary>
    /// 生成首页flash动态内容
    /// </summary>
    /// <param name="len">图片说明文字字数</param>
    /// <returns></returns>
    public static string index_flash(int len)
    {
        string text = "";
        int count;
        ContentBLL bll = new ContentBLL();
        IList<Lgwin.Model.Content> list = bll.GetArticles(8, 1, "[tuwen]='1' and [yaowen]='1'and  auditing = 'true'", "id", true, out count);
        int j = 1;
        for (int i = 1; i <= 8; i++)
        {
            if (list[i - 1].Contents.IndexOf("img") > 0)
            {
                text += "imgLink" + j + "=\"http://lgwindow.sdut.edu.cn" + GetHtmlAdress(list[i - 1]) + "\";";
                text += "imgUrl" + j + "=\"" + myRegular.pic_Src_Top1(list[i - 1].Contents).Replace("src=\"/", "") + ";";
                text += "imgtext" + j + "=\"" + Mystring.lim_withoutPoint(list[i - 1].Title, len) + "\";";
                j++;
            }
            if (j == 6)
                continue;
        }
        return text;
    }

    //首页焦点图提取
    public static string index_jiaodian(int len)
    {
        string text = "";
        int count;
        ContentBLL bll = new ContentBLL();
        IList<Lgwin.Model.Content> list = bll.GetArticles(8, 1, "[tuwen]='1' and [ztid]='218'and  auditing = 'true'", "id", true, out count);
        int j = 1;
        for (int i = 1; i <= 8; i++)
        {
            if (list[i - 1].Contents.IndexOf("img") > 0)
            {
                text += "imgLink" + j + "=\"http://lgwindow.sdut.edu.cn" + GetHtmlAdress(list[i - 1]) + "\";";
                text += "imgUrl" + j + "=\"" + myRegular.pic_Src_Top1(list[i - 1].Contents).Replace("src=\"/", "") + ";";
                text += "imgtext" + j + "=\"" + Mystring.lim_withoutPoint(list[i - 1].Title, len) + "\";";
                j++;
            }
            if (j == 6)
                continue;
        }
        return text;
    }


    /// <summary>
    /// 生成特色名校flash动态内容
    /// </summary>
    /// <param name="len">图片说明文字字数</param>
    /// <returns></returns>
    public static string index_flash1(int len)
    {
        string text = "";
        int count;
        ContentBLL bll = new ContentBLL();
        IList<Lgwin.Model.Content> list = bll.GetArticles(8, 1, "[tuwen]='1' and [ztid]='191' and  auditing = 'true'", "id", true, out count);
        int j = 1;
        for (int i = 1; i <= 8; i++)
        {
            if (list[i - 1].Contents.IndexOf("img") > 0)
            {
                text += "imgLink" + j + "=\"http://lgwindow.sdut.edu.cn" + GetHtmlAdress(list[i - 1]) + "\";";
                text += "imgUrl" + j + "=\"" + myRegular.pic_Src_Top1(list[i - 1].Contents).Replace("src=\"/", "") + ";";
                text += "imgtext" + j + "=\"" + Mystring.lim_withoutPoint(list[i - 1].Title, len) + "\";";
                j++;
            }
            if (j == 6)
                continue;
        }
        return text;
    }
    public static string tesemingxiao(int len)
    {
        string text = "";
        int count;
        ContentBLL bll = new ContentBLL();
        IList<Lgwin.Model.Content> list = bll.GetArticles(5, 1, "[tuwen]='1' and zt='60' and ztid='186' and auditing = 'true'", "id", true, out count);
        int j = 1;
        int k = 5;
        if (list.Count < 5)
        {
            text += "imgUrl1=\"images/pic.jpg\";imgUrl2=\"images/20121220022301_Marked.jpg\";imgUrl3=\"images/20111222022935_Marked.jpg\";imgUrl4=\"images/20110908105515_Marked.jpg\";";
            text += "imgLink1=\"http://lgwindow.sdut.edu.cn/topic/tesemingxiao/news/34958.html\";imgLink2=\"http://lgwindow.sdut.edu.cn/topic/tesemingxiao/news/34384.html\";imgLink3=\"http://lgwindow.sdut.edu.cn/topic/tesemingxiao/news/28442.html\";imgLink4=\"http://lgwindow.sdut.edu.cn/Campus/News/news_1682.html\";";
            text += "imgtext1=\"特色名校建设方案论证工作\";imgtext2=\"探索应用型卓越法律人才培养模式\";imgtext3=\"学校部署山东省高等教育名校建设工程申报工作\";imgtext4=\"山东理工大学——历史沿革（一）\";";
        }
        else
        {
            for (int i = 1; i <= k; i++)
            {
                if (list[i - 1].Contents.IndexOf("img") > 0)
                {
                    text += "imgLink" + j + "=\"http://lgwindow.sdut.edu.cn" + GetHtmlAdress(list[i - 1]) + "\";";
                    text += "imgUrl" + j + "=\"" + myRegular.pic_Src_Top1(list[i - 1].Contents).Replace("src=\"/", "") + ";";
                    text += "imgtext" + j + "=\"" + Mystring.lim_withoutPoint(list[i - 1].Title, len) + "\";";
                    j++;
                }
                if (j == 6)
                    continue;
            }
        }
        return text;
    }
    //群众路线专题获取首页图片
    public static string people1(int len)
    {
        string text = "";
        int count;
        ContentBLL bll = new ContentBLL();
        IList<Lgwin.Model.Content> list = bll.GetArticles(5, 1, "[tuwen]='1' and zt='66' and ztid='218' and auditing = 'true'", "id", true, out count);
        int j = 1;
        int k = 4;
        if (list.Count < 4)
        {
            text += "<DIV class=dis name=\"f\"><A href=\"http://lgwindow.sdut.edu.cn/News/38826.html\" target=_blank><IMG height=255 alt=校党委常委集体学习《中共中央关于全面深化改革若干重大问题的决定》 src=\"images/01.jpg\" width=370></A></DIV><DIV class=undis name=\"f\"><A href=\"http://lgwindow.sdut.edu.cn/News/38827.html\" target=_blank><IMG height=250 alt=学校召开会议通报校党委班子专题民主生活会情况 src=\"images/02.jpg\" width=370></A></DIV><DIV class=undis name=\"f\"><A href=\"http://lgwindow.sdut.edu.cn/News/38671.html\" target=_blank><IMG height=250 alt=学校党委常委班子召开专题民主生活会 src=\"images/03.jpg\" width=370></A></DIV><DIV class=undis name=\"f\"><A href=\"http://lgwindow.sdut.edu.cn/News/38001.html\" target=_blank><IMG height=250 alt=学校召开党委理论学习中心组扩大会议 src=\"images/04.jpg\" width=370></A></DIV>";
        }
        else
        {
            for (int i = 1; i <= k; i++)
            {
                if (list[i - 1].Contents.IndexOf("img") > 0)
                {
                    text += "<DIV class=dis name=\"f\"><A href=\"" + "http://lgwindow.sdut.edu.cn" + GetHtmlAdress(list[i - 1]) + "\"target=_blank><IMG height=255 alt=" + Mystring.lim_withoutPoint(list[i - 1].Title, len) + " src=\"" + "http://lgwindow.sdut.edu.cn/" + myRegular.pic_Src_Top1(list[i - 1].Contents).Replace("src=\"/", "") + " width=370></A></DIV>";
                    j++;
                }
                if (j == 6)
                    continue;
            }
        }
        return text;
    }
    public static string people2(int len)
    {
        string text = "";
        int count;
        ContentBLL bll = new ContentBLL();
        IList<Lgwin.Model.Content> list = bll.GetArticles(5, 1, "[tuwen]='1' and zt='66' and ztid='218' and auditing = 'true'", "id", true, out count);
        int j = 1;
        int k = 4;
        if (list.Count < 4)
        {
            text += "<TD class=s onmouseover=\"play(this,'au','');\" align=right><A href=\"http://lgwindow.sdut.edu.cn/News/38826.html\" target=_blank><IMG height=56 src=\"images/sm1.jpg\" width=77></A></TD><TD class=s onmouseover=\"play(this,'au','');\" align=right><A href=\"http://lgwindow.sdut.edu.cn/News/38827.html\" target=_blank><IMG height=56 src=\"images/sm2.jpg\" width=77></A></TD><TD class=s onmouseover=\"play(this,'au','');\" align=right><A href=\"http://lgwindow.sdut.edu.cn/News/38671.html\" target=_blank><IMG height=56 src=\"images/sm3.jpg\" width=77></A></TD><TD class=s onmouseover=\"play(this,'au','');\" align=right><A href=\"http://lgwindow.sdut.edu.cn/News/38001.html\" target=_blank><IMG height=56 src=\"images/sm4.jpg\" width=77></A></TD>";
        }
        else
        {
            for (int i = 1; i <= k; i++)
            {
                if (list[i - 1].Contents.IndexOf("img") > 0)
                {
                    text += "<TD class=s onmouseover=\"play(this,'au','');\" align=right><A href=\"" + "http://lgwindow.sdut.edu.cn" + GetHtmlAdress(list[i - 1]) + "\" target=_blank><IMG height=56 src=\"" + "http://lgwindow.sdut.edu.cn/" + myRegular.pic_Src_Top1(list[i - 1].Contents).Replace("src=\"/", "") + " width=77></A></TD>";
                    j++;
                }
                if (j == 6)
                    continue;
            }
        }
        return text;
    }
    ///2013迎新专题迎新快讯最新文章显示方法
  public static string YXzuixin(int titlelen, int contentlen)
{
        
     int count;
       string text = "";
       string url = "";
       ContentBLL contbll = new ContentBLL();

       IList<Lgwin.Model.Content> list = contbll.GetArticles(1, 1, "ztid='231' and zt='69'", "id", true, out count);
       url = GetHtmlAdress(list[0]);
       string content = myRegular.KillHTML(list[0].Contents);
       string title = myRegular.KillHTML(list[0].Title);
       text += "<div class=\"yxjd\"><div class=\"yxpic\"><img src=\"" + "http://lgwindow.sdut.edu.cn/" + myRegular.pic_Src_Top1(list[0].Contents).Replace("src=\"/", "") + " ></div><div class=\"yxcontent\"><div class=\"yxt\"><a href=\"" + url + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(title, titlelen) + "</a></div><div class=\"yxc\">" + Mystring.lim_withoutPoint(content, contentlen) + "......<a href=\"" + url + "\" target=\"_blank\" style=\"color:#3486c5;\">[详细]</a></div></div></div>";
        return text;
    }


    /// <summary>
    /// 资讯公告获得内容方法
    /// </summary>
    /// <param name="caption">栏目</param>
    /// <param name="tiaoshu">显示条数</param>
    /// <param name="where">sql条件</param>
    /// <param name="zishu">一条显示字数</param>
    /// <param name="datestr">日期格式</param>
    /// <returns></returns>
    public static string index_Gonggao(string caption, int tiaoshu, string where, int zishu, string datestr)
    {
        int count;
        string text = "";
        ContentBLL conbll = new ContentBLL();
        IList<Lgwin.Model.Content> list = conbll.GetList(caption, tiaoshu, 1, where, out count);
        for (int i = 0; i < list.Count; i++)
        {
            if (datestr == "")
                text += GetHref(list[i], zishu) + "[" + list[i].Datee.ToString("MM-dd") + "]&nbsp;&nbsp;&nbsp;";
            else
                text += GetHref(list[i], zishu) + "[" + list[i].Datee.ToString(datestr) + "]&nbsp;&nbsp;&nbsp;";
        }
        return text;
    }
    /// <summary>
    /// 各栏目获得内容方法
    /// </summary>
    /// <param name="caption">栏目</param>
    /// <param name="tiaoshu">显示条数</param>
    /// <param name="where">sql条件</param>
    /// <param name="zishu">一条显示字数</param>
    /// <returns></returns>
    public static string index_list(string caption, int tiaoshu, int zishu)
    {
        int count;
        string text = "";
        ContentBLL conbll = new ContentBLL();
        IList<Lgwin.Model.Content> list = conbll.GetList(caption, tiaoshu, 1, " auditing = 'true'", out count);
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].Contents == "" || list[i].Contents == null)
            {
                text += "<tr><td class=\"NewsList1\" >" + GetHref(list[i], zishu) + "</td></tr>";
            }
            else
            {
                text += "<tr><td class=\"NewsList\" >" + GetHref(list[i], zishu) + "</td></tr>";
            }
        }
        return text;
    }
    /// <summary>
    /// 各栏目获得内容方法
    /// </summary>
    /// <param name="caption">栏目</param>
    /// <param name="tiaoshu">显示条数</param>
    /// <param name="where">sql条件</param>
    /// <param name="zishu">一条显示字数</param>
    /// <param name="datestr">日期格式</param>
    /// <returns></returns>
    public static string index_list(string caption, int tiaoshu, int zishu, string datestr)
    {
        int count;
        string text = "";
        ContentBLL conbll = new ContentBLL();
        IList<Lgwin.Model.Content> list = conbll.GetList(caption, tiaoshu, 1, " auditing = 'true'", out count);
        for (int i = 0; i < list.Count; i++)
        {
            if (datestr == "")
                text += "<tr><td class=\"NewsList\" >" + GetHref(list[i], zishu) + "</td><td class=\"time\">[" + list[i].Datee.ToString("MM-dd") + "]</td></tr>";
            else
                text += "<tr><td class=\"NewsList\" >" + GetHref(list[i], zishu) + "</td><td class=\"time\">[" + list[i].Datee.ToString(datestr) + "]</td></tr>";
        }
        return text;
    }

    public static string index_toutiao(int titlelen, int contentlen, string datestr)
    {
        int count;
        string text = "";
        string url = "";
        ContentBLL contbll = new ContentBLL();
        IList<Lgwin.Model.Content> list = contbll.GetArticles(1, 1, "yaowen='1'and auditing = 'true'", "id", true, out count);

        Watermark mark = new Watermark();//生成今日头条图片
        mark.FontFamily = ConfigurationManager.AppSettings["TouTiaoFontFamily"].ToString();
        mark.Left = Convert.ToInt16(ConfigurationManager.AppSettings["Left"].ToString());
        mark.Top = Convert.ToInt16(ConfigurationManager.AppSettings["Top"].ToString());
        mark.Width = Convert.ToInt16(ConfigurationManager.AppSettings["Width"].ToString());
        mark.Height = Convert.ToInt16(ConfigurationManager.AppSettings["Heigth"].ToString());
        mark.FontSize = Convert.ToInt16(ConfigurationManager.AppSettings["FontSize"].ToString());
        mark.Alpha = Convert.ToInt16(ConfigurationManager.AppSettings["Alpha"].ToString());
        mark.Quality = Convert.ToInt16(ConfigurationManager.AppSettings["Quality"].ToString());
        mark.Shadow = Convert.ToBoolean(ConfigurationManager.AppSettings["Shadow"].ToString());
        mark.Adaptable = Convert.ToBoolean(ConfigurationManager.AppSettings["AdaptTable"]);
        mark.BackgroundImage = "";
        mark.Text = Mystring.lim_withoutPoint(list[0].Title, titlelen).ToString();
        mark.ResultImage = HttpContext.Current.Server.MapPath("~/") + "images\\index\\Toutiao.Jpeg";
        mark.BgColor = System.Drawing.Color.White;
        mark.Blue = Convert.ToInt16(ConfigurationManager.AppSettings["Blue"].ToString());
        mark.Red = Convert.ToInt16(ConfigurationManager.AppSettings["Red"].ToString());
        mark.Green = Convert.ToInt16(ConfigurationManager.AppSettings["Green"].ToString());
        mark.Create();

        url = GetHtmlAdress(list[0]);
        string content = myRegular.KillHTML(list[0].Contents);
        text += "<div id=\"TT1\"><a href=\"" + url + "\" title=\"" + list[0].Title + "\" target=\"_blank\"><img src=\"images/index/Toutiao.Jpeg\" width=\"400\" height=\"50\" /></a></div>";
        if (datestr != "")
            text += "<div id=\"TT2\">" + Mystring.lim_withoutPoint(content, contentlen) + "[" + list[0].Datee.ToString(datestr) + "]</div>";
        else
            text += "<div id=\"TT2\">" + Mystring.lim_withoutPoint(content, contentlen) + "[" + list[0].Datee.ToString("MM-dd") + "]</div>";
        text += "<div id=\"TT3\"><a href=\"" + url + "\" target=\"_blank\">>>详情请进</a></div>";
        return text;
    }
    public static string index_xiaobao(string lanmu, int tiaoshu, int titlelen)
    {
        int count;
        int listcount;
        string text = "";

        ZtCaptionBLL bll = new ZtCaptionBLL();
        ZtCaption mod = bll.GetZtCaption(lanmu);
        if (mod != null)
        {
            ContentBLL conbll = new ContentBLL();
            IList<Lgwin.Model.Content> list = conbll.GetList(tiaoshu, 1, " [datee]>=dateadd(day,2-datepart(weekday,getdate()),convert(varchar,getdate(),112)) and ztid='" + mod.Id + "' and  auditing = 'true'", out count);
            listcount = list.Count;
            if (listcount > 0)
            {
                for (int i = 0; i < listcount; i++)
                {
                    text += "<li>" + GetHref(list[i], titlelen) + "</li>";
                }
            }
        }
        return text;

    }
    public static string index_videosource(int tiaoshu)
    {
        int vdocon = 0;
        string text = "";
        VideoBLL vdobll = new VideoBLL();
        IList<Video> vdolist = vdobll.GetVideoList(tiaoshu, 1, "[Type]='视频'", out vdocon);
        foreach (Video mod in vdolist)
        {
            text += "<channel><item><source>../../" + mod.Url + "</source><title>" + mod.Title + "</title></item></channel>";
        }
        return text;
    }

    public static string index_videoAndPic(int tiaoshu)
    {
        int vdocon = 0;
        string text = "";
        VideoBLL vdobll = new VideoBLL();
        IList<Video> vdolist = vdobll.GetVideoList(tiaoshu, 1, "[Type]='视频'", out vdocon);
        foreach (Video mod in vdolist)
        {
            text += mod.Pic;
        }
        return text;
    }

    public static string index_Zhuantitex(int tiaoshu, int titlelen)
    {
        int count;
        string text = "";
        ContentBLL bll = new ContentBLL();
        IList<Lgwin.Model.Content> list = bll.GetList("专题报道", tiaoshu, 1, " auditing=1 and id<>33973 and id<>33972", out count);
        if (list.Count > 0)
        {
            for (int i = 0; i < list.Count; i++)
            {
                text += "<img src=\"images/index/blue.jpg\"/>" + GetHref(list[i], titlelen) + "<br />";
            }
        }
        return text;
    }
    /// <summary>
    /// 排行函数
    /// </summary>
    /// <param name="tiaoshu">显示排行的条数，0表示所有学院</param>
    /// <param name="frolen">学院显示字数</param>
    /// <returns>表格的行tr，三列</returns>
    public static string index_paihang(int tiaoshu, int frolen)
    {
        CollegeBLL colbll = new CollegeBLL();
        IList<College> list = colbll.GetCollegeList();
        int con = list.Count;
        int m = 0;
        int[] paiming = new int[con - 1];
        string[] xueyuan = new string[con - 1];
        string text = "";
        ContentBLL conbll = new ContentBLL();
        //for (int i = 0; i < list.Count; i++)
        //{
        //    paiming[i] = conbll.GetCount("fro='" + list[i].Name + "'");
        //    xueyuan[i] = list[i].Name;
        //}
        for (int i = 0; i < con; i++)
        {
            if (list[i].Name != "-----------------------------" && list[i].Name != "新闻中心" && list[i].Name != "理工视窗")
            {
                paiming[m] = conbll.GetCount("fro='" + list[i].Name + "'");
                xueyuan[m] = list[i].Name;
                if (i != con - 1)  //曾出现Index was outside the bounds of the array. 错误
                {
                    m++;
                }
            }
        }
        Array.Sort(paiming, xueyuan);
        if (tiaoshu == 0)
        {
            for (int j = 0; j < m; j++)
            {
                text += "<tr><td>" + (j + 1) + "</td><td>" + paiming[m - j + 1] + "</td><td>" + Mystring.lim_withoutPoint(xueyuan[m - j + 1], frolen) + "</td></tr>";
            }
        }
        else
        {
            for (int j = 0; j < tiaoshu; j++)
            {
                text += "<tr><td>" + (j + 1) + "</td><td>" + paiming[m - j + 1] + "</td><td>" + Mystring.lim_withoutPoint(xueyuan[m - j + 1], frolen) + "</td></tr>";
            }
        }
        return text;
    }
    /// <summary>
    /// 获取文章的链接地址返回完整的 href=“...”
    /// </summary>
    /// <param name="mod">内容实体</param>
    /// <param name="TitleLength">标题长度</param>
    /// <returns></returns>
    public static string GetHref(Lgwin.Model.Content mod, int TitleLength)
    {
        string href = "";
        if (mod.Title.Trim() != "")
        {
            if (mod.Url != "0")
            {
                href = "<a href=\"" + mod.Url + "\" title=\"" + mod.Title + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(mod.Title, TitleLength) + "</a>";
            }
            else
            {
                if (mod.Zt == "" || mod.Ztid == "" || mod.Ztid == "0" || mod.Zt == "0")
                {
                    href = "<a href=\"../News/" + mod.Id + ".html\" title=\"" + mod.Title + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(mod.Title, TitleLength) + "</a>";
                }
                else
                {
                    ZtBLL ztbll = new ZtBLL();
                    Zt ztmod = ztbll.GetZtById(int.Parse(mod.Zt));
                    if (ztmod != null)
                        href = "<a href=\"../topic/" + ztmod.ZtJiancheng + "/news/" + mod.Id + ".html\" title=\"" + mod.Title + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(mod.Title, TitleLength) + "</a>";
                }
            }
        }
        return href;
    } /// <summary>
    /// 用于专题管理中的生成二级页，获取文章的链接地址返回完整的 href=“...”
    /// </summary>
    /// <param name="mod">内容实体</param>
    /// <param name="TitleLength">标题长度</param>
    /// <returns></returns>
    public static string ZtGetHref(Lgwin.Model.Content mod, int TitleLength)
    {
        string href = "";
        if (mod.Title.Trim() != "")
        {
            if (mod.Url != "0")
            {
                href = "<a href=\"" + mod.Url + "\" title=\"" + mod.Title + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(mod.Title, TitleLength) + "</a>";
            }
            else
            {
                if (mod.Zt == "" || mod.Ztid == "" || mod.Ztid == "0" || mod.Zt == "0" || mod.Zt == "54")
                {
                    if (mod.Zt == "54")
                    {
                        href = "<a href=\"../../News/" + mod.Id + ".html\" title=\"" + mod.Title + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(mod.Title, TitleLength) + "</a>";
                    }
                    else
                    {
                        href = "<a href=\"../News/" + mod.Id + ".html\" title=\"" + mod.Title + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(mod.Title, TitleLength) + "</a>";
                    }
                }
                else
                {
                    ZtBLL ztbll = new ZtBLL();
                    Zt ztmod = ztbll.GetZtById(int.Parse(mod.Zt));
                    if (ztmod != null)
                        href = "<a href=\"/topic/" + ztmod.ZtJiancheng + "/news/" + mod.Id + ".html\" title=\"" + mod.Title + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(mod.Title, TitleLength) + "</a>";
                }
            }
        }
        return href;
    }
    /// <summary>
    /// 获取文章的链接地址返回完整的 href=“...”，用于列表页
    /// </summary>
    /// <param name="mod">内容实体</param>
    /// <param name="TitleLength">标题长度</param>
    /// <returns></returns>
    public static string GetListHref(Lgwin.Model.Content mod, int TitleLength)
    {
        string href = "";
        if (mod.Url != "0")
        {
            href = "<a href=\"" + mod.Url + "\" title=\"" + mod.Title + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(mod.Title, TitleLength) + "</a>";
        }
        else
        {
            if (mod.Zt == "" || mod.Ztid == "" || mod.Ztid == "0" || mod.Zt == "0" || mod.Zt == null || mod.Ztid == null)
            {
                href = "<a href=\"" + mod.Id + ".html\" title=\"" + mod.Title + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(mod.Title, TitleLength) + "</a>";
            }
            else
            {
                string zt = mod.Zt;
                if (myRegular.isNumber(zt))
                {
                    ZtBLL ztbll = new ZtBLL();
                    Zt ztmod = ztbll.GetZtById(int.Parse(mod.Zt));
                    if (ztmod != null)
                    {
                        href = "<a href=\"../topic/" + ztmod.ZtJiancheng + "/news/" + mod.Id + ".html\" title=\"" + mod.Title + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(mod.Title, TitleLength) + "</a>";
                    }
                }
            }
        }
        return href;
    }
    /// <summary>
    /// 文章的在磁盘的地址    
    /// </summary>
    /// <param name="mod"></param>
    /// <returns></returns>    
    public static string GetHtmlAdress(Lgwin.Model.Content mod)
    {
        string adress = "";
        if (mod.Url != "0")
            return adress;//指向外部链接时没有静态页生成
        else
        {
            if (mod.Zt == "" || mod.Ztid == "" || mod.Ztid == "0" || mod.Zt == "0")
            {
                adress += "/News/" + mod.Id + ".html";
            }
            else
            {
                ZtBLL ztbll = new ZtBLL();
                Zt ztmod = ztbll.GetZtById(int.Parse(mod.Zt));
                if (ztmod != null)
                    adress += "/topic/" + ztmod.ZtJiancheng + "/news/" + mod.Id + ".html";
            }
        }
        return adress;

    }
    /// <summary>
    /// 获得html地址，用于后台预览页面
    /// </summary>
    /// <param name="id">文章id</param>
    /// <returns></returns>
    public static string GetHtmlById(string id)
    {
        string adress = "";
        ContentBLL conbll = new ContentBLL();
        Lgwin.Model.Content mod = conbll.Get(int.Parse(id));

        if (mod != null)
        {
            if (mod.Url != "0")
                return mod.Url;
            else
            {
                if (mod.Zt == "" || mod.Ztid == "" || mod.Ztid == "0" || mod.Zt == "0")
                {
                    adress += "../../News/" + mod.Id + ".html";
                }
                else
                {
                    ZtBLL ztbll = new ZtBLL();
                    Zt ztmod = ztbll.GetZtById(int.Parse(mod.Zt));
                    if (ztmod != null && ztmod.ZtJiancheng != "")
                    {
                        adress += "../../topic/" + ztmod.ZtJiancheng + "/news/" + mod.Id + ".html";
                    }
                }
            }
        }
        return adress;
    }
    public static string GetVideoHtmlById(string id)
    {
        string adress = "";
        VideoBLL vbll = new VideoBLL();
        Video mod = vbll.GetVideoById(int.Parse(id));
        if (mod != null)
        {
            if (mod.Href != "0")
            {
                return mod.Href;
            }
            else
            {
                adress = "../../News/video/" + id + ".html";
            }
        }
        return adress;
    }
    /// <summary>
    /// 获得html地址（标题所指向的链接地址）
    /// </summary>
    /// <param name="mod"></param>
    /// <returns></returns>
    public static string GetHtml(Lgwin.Model.Content mod)
    {
        if (mod != null)
        {
            if (mod.Url != "0")
                return mod.Url;
            else
            {
                return GetHtmlAdress(mod);
            }
        }
        else
            return null;
    }
    /// <summary>
    /// 获取文章的链接地址返回单引号的href，用于本周新闻排行WeekHotHandler.ashx文件中
    /// </summary>
    /// <param name="mod"></param>
    /// <param name="TitleLength"></param>
    /// <returns></returns>
    public static string GetHref_danyinhao(Lgwin.Model.Content mod, int TitleLength)
    {
        string href = "";
        if (mod.Url != "0")
        {
            href = "<a href='" + mod.Url + "' title='" + mod.Title + "' target='_blank'>" + Mystring.lim_withoutPoint(mod.Title, TitleLength) + "</a>";
        }
        else
        {
            if (mod.Zt == "" || mod.Ztid == "" || mod.Ztid == "0" || mod.Zt == "0")
            {
                href = "<a href='http://lgwindow.sdut.edu.cn/News/" + mod.Id + ".html' title='" + mod.Title + "' target='_blank'>" + Mystring.lim_withoutPoint(mod.Title, TitleLength) + "</a>";
            }
            else
            {
                ZtBLL ztbll = new ZtBLL();
                Zt ztmod = ztbll.GetZtById(int.Parse(mod.Zt));
                href = "<a href='http://lgwindow.sdut.edu.cn/topic/" + ztmod.ZtJiancheng + "/news/" + mod.Id + ".html' title='" + mod.Title + "' target='_blank'>" + Mystring.lim_withoutPoint(mod.Title, TitleLength) + "</a>";
            }
        }
        return href;
    }
    /// <summary>
    /// 删除静态页和相关图片等文件
    /// </summary>
    /// <param name="mod"></param>
    /// <returns></returns>
    public static bool DelHtml(Lgwin.Model.Content mod)
    {
        ArrayList aa = myRegular.Article_File(mod.Contents, "rar|doc|jpg|gif");
        foreach (string pic_src in aa)
        {
            Myfile.File_Del(pic_src);
        }
        if (mod.Zt == "" || mod.Ztid == "" || mod.Ztid == "0" || mod.Zt == "0")
        {
            Myfile.File_Del(HttpContext.Current.Server.MapPath("~/News/" + mod.Id + ".html"));
        }
        else
        {
            ZtBLL ztbll = new ZtBLL();
            Zt ztmod = ztbll.GetZtById(int.Parse(mod.Zt));
            Myfile.File_Del(HttpContext.Current.Server.MapPath("~/topic/" + ztmod.ZtJiancheng + "/news/" + mod.Id + ".html"));//, "utf-8"
        }
        return true;

    }
    /// <summary>
    /// 删除首页图片方法
    /// </summary>
    /// <param name="mod"></param>
    /// <returns></returns>
    public static bool DelImg(Lgwin.Model.Image mod)
    {
        if (mod.FenLei == "ad12")
        {
            Myfile.File_Del(HttpContext.Current.Server.MapPath("~/images/ad12/" + mod.Name));
        }
        if (mod.FenLei == "xiaobao")
        {
            Myfile.File_Del(HttpContext.Current.Server.MapPath("~/images/xiaobao/" + mod.Name));
        }
        if (mod.FenLei == "zhuanti")
        {
            Myfile.File_Del(HttpContext.Current.Server.MapPath("~/images/zhuanti/" + mod.Name));
        }
        return true;
    }
    /// <summary>
    /// 生成二级页
    /// </summary>
    /// <param name="mods">所有列表内容</param>
    /// <param name="titlelen">每条长度</param>
    /// <param name="tiaoshu">每页条数</param>
    /// <param name="zt">栏目名称</param>
    /// <param name="ztid">栏目Tid</param>
    /// <returns></returns>
    public static string classlist(IList<Lgwin.Model.Content> mods, int titlelen, int tiaoshu, string classname, int classid)
    {
        string rts = "";
        int Tzong, Tzong_no = mods.Count;
        Tzong = zheng(Tzong_no, tiaoshu);
        string titles = "<table width=\"95%\" id=\"titles\" border=\"0\" cellpadding=\"0\" cellspacing=\"1\">\n";
        //  int start = st - 1;
        int i = 1;  //单页计数
        int pag = 1;  //页码
        foreach (Lgwin.Model.Content mod in mods)
        {
            if (mod.Caption == "媒体理工" && (mod.Contents == "" || mod.Contents == null))
            {
                titles += "<tr>\n<td style=\"background: url(../images/index/list2ji1.jpg) no-repeat;\"><span>" + GetListHref(mod, titlelen) + "</span><span class=\"date\" >[" + mod.Datee.ToString("yyyy-MM-dd") + "]</span></td></tr>\n";
            }
            else
            {
                titles += "<tr >\n<td><span>" + GetListHref(mod, titlelen) + "</span><span class=\"date\" >[" + mod.Datee.ToString("yyyy-MM-dd") + "]</span></td></tr>\n";
            }
            if (i == tiaoshu)
            {
                i = 1;
                try
                {
                    titles += "</table>";
                    rts += make_html(titles, pag, Tzong, classname, classid, tiaoshu);
                }
                catch (Exception ex)
                {
                    throw ex;
                    HttpContext.Current.Response.End();
                }
                pag++;
                titles = "<table width=\"95%\" id=\"titles\" border=\"0\" cellpadding=\"0\" cellspacing=\"1\">\n";
            }
            else
                i++;
        }
        if (i != 1)//不满最后一页 table标签未结束
        {
            titles += "</table>";
            rts += make_html(titles, pag, Tzong, classname, classid, tiaoshu);
        }
        return rts;
    }
    /// <summary>
    /// 生成前四页用到的方法
    /// </summary>
    /// <param name="mods">列表</param>
    /// <param name="zongshu">所有记录总数</param>
    /// <param name="titlelen">每条字数</param>
    /// <param name="tiaoshu">每页条数</param>
    /// <param name="classname">栏目名称</param>
    /// <param name="classid">栏目id</param>
    /// <returns></returns>
    public static string classlist(IList<Lgwin.Model.Content> mods, int zongshu, int titlelen, int tiaoshu, string classname, int classid)
    {
        string rts = "";
        int Tzong;
        Tzong = zheng(zongshu, tiaoshu);
        string titles = "<table width=\"95%\" id=\"titles\" border=\"0\" cellpadding=\"0\" cellspacing=\"1\">\n";
        //  int start = st - 1;
        int i = 1;  //单页计数
        int pag = 1;  //页码
        foreach (Lgwin.Model.Content mod in mods)
        {
            titles += "<tr>\n<td><span>" + GetListHref(mod, titlelen) + "</span><span class=\"date\" >[" + mod.Datee.ToString("yyyy-MM-dd") + "]</span></td></tr>\n";
            if (i == tiaoshu)
            {
                i = 1;
                try
                {
                    titles += "</table>";
                    rts += make_html(titles, pag, Tzong, classname, classid, tiaoshu);
                }
                catch (Exception ex)
                {
                    throw ex;
                    HttpContext.Current.Response.End();
                }
                pag++;
                titles = "<table width=\"95%\" id=\"titles\" border=\"0\" cellpadding=\"0\" cellspacing=\"1\">\n";
            }
            else
                i++;
        }
        if (i != 1)//不满最后一页 table标签未结束
        {
            titles += "</table>";
            rts += make_html(titles, pag, Tzong, classname, classid, tiaoshu);
        }
        return rts;
    }
    /// <summary>
    /// 生成视频二级页
    /// </summary>
    /// <param name="mods">视频实体</param>
    /// <param name="titlelen">标题长度</param>
    /// <param name="tiaoshu">每页条数</param>
    /// <param name="classname">视频理工</param>
    /// <param name="classid">视频理工的栏目id</param>
    /// <returns></returns>
    public static string videolist(IList<Video> mods, int titlelen, int tiaoshu, string classname, int classid)
    {
        string rts = "";
        int Tzong, Tzong_no = mods.Count;
        Tzong = zheng(Tzong_no, tiaoshu);
        string titles = "<table width=\"95%\" id=\"titles\" border=\"0\" cellpadding=\"0\" cellspacing=\"1\">\n";
        //  int start = st - 1;
        int i = 1;  //单页计数
        int pag = 1;  //页码
        foreach (Video mod in mods)
        {
            titles += "<tr>\n<td><span>" + GetVideoHref(mod, titlelen) + "</span><span class=\"date\" >[" + mod.AddDate.ToString("yyyy-MM-dd") + "]</span></td></tr>\n";
            if (i == tiaoshu)
            {
                i = 1;
                try
                {
                    titles += "</table>";
                    rts += make_html(titles, pag, Tzong, classname, classid, tiaoshu);
                }
                catch (Exception ex)
                {
                    throw ex;
                    HttpContext.Current.Response.End();
                }
                pag++;
                titles = "<table width=\"95%\" id=\"titles\" border=\"0\" cellpadding=\"0\" cellspacing=\"1\">\n";
            }
            else
                i++;
        }
        if (i != 1)//不满最后一页 table标签未结束
        {
            titles += "</table>";
            rts += make_html(titles, pag, Tzong, classname, classid, tiaoshu);
        }
        return rts;
    }
    public static string GetVideoHref(Video mod, int TitleLength)
    {
        string href = "";
        if (mod.Href != "0")
        {
            href = "<a href=\"" + mod.Href + "\" title=\"" + mod.Title + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(mod.Title, TitleLength) + "</a>";
        }
        else
        {
            href = "<a href=\"video/" + mod.Id + ".html\" title=\"" + mod.Title + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(mod.Title, TitleLength) + "</a>";
        }
        return href;
    }
    public static string Paihanglist()
    {
        string rts = "";
        string nrr = "";
        nrr = Myfile.Read_Model(HttpContext.Current.Server.MapPath("~/Lgwin/manage/model/paihang.model"));
        nrr = nrr.Replace("%%capname%%", "稿件排行");
        nrr = nrr.Replace("%%titles%%", Paihangtab());
        nrr = nrr.Replace("%%pager%%", "");
        try
        {
            Myfile.File_Write(HttpContext.Current.Server.MapPath("~") + "/News/Paihang.html", nrr);
            rts += " 稿件排行 生成成功\n";
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return rts;
    }
    /// <summary>
    /// 排行列表
    /// </summary>
    /// <returns></returns>
    public static string Paihangtab()
    {
        CollegeBLL colbll = new CollegeBLL();
        IList<College> list = colbll.GetCollegeList();
        int con = list.Count;
        int m = 0;
        int[] paiming = new int[con];
        string[] xueyuan = new string[con];
        string text = "";
        text = "<table width=\"95%\" id=\"titles\" border=\"0\" cellpadding=\"0\" cellspacing=\"1\" ><tr><td class=\"paihang\" width=\"50%\">部门名称</td><td class=\"paihang\" width=\"25%\">用稿数</td><td class=\"paihang\" width=\"25%\">名次</td></tr>";
        ContentBLL conbll = new ContentBLL();
        for (int i = 0; i < con; i++)
        {
            if (list[i].Name != "-----------------------------" && list[i].Name != "新闻中心" && list[i].Name != "理工视窗")
            {
                paiming[m] = conbll.GetCount("fro='" + list[i].Name + "'");
                xueyuan[m] = list[i].Name;
                m++;
            }
        }

        Array.Sort(paiming, xueyuan);

        for (int j = 0; j < m; j++)
        {
            if (paiming[con - j - 1] > 0)
            {
                text += "<tr><td class=\"ph\">" + xueyuan[con - j - 1] + "</td><td class=\"ph\">" + paiming[con - j - 1] + "</td><td class=\"ph\">" + (j + 1) + "</td></tr>";
            }
        }
        text += "</table>";
        return text;
    }
    /// <summary>
    /// 生成单页列表
    /// </summary>
    /// <param name="titles">标题</param>
    /// <param name="page">当前页</param>
    /// <param name="Tzong">总页数</param>
    /// <param name="classname">栏目名称</param>
    /// <param name="classid">栏目Tid</param>
    /// <returns></returns>
    public static string make_html(string titles, int page, int Tzong, string classname, int classid, int tiaoshu)  //单页全文内容
    {
        string rts = "";
        string nrr = "";
        string url = "";
        switch (classname)
        {
            case "理工要闻":
                url = "/News/1_1.html";
                break;
            case "院部传真":
                url = "/News/2_1.html";
                break;
            case "教学科研":
                url = "/News/3_1.html";
                break;
            case "学生工作":
                url = "/News/5_1.html";
                break;
            case "视频理工":
                url = "/News/11_1.html";
                break;
            case "媒体理工":
                url = "/News/6_1.html";
                break;
            case "专题报道":
                url = "/News/12_1.html";
                break;
            case "理工人物":
                url = "/News/7_1.html";
                break;
            case "高教视点":
                url = "/News/8_1.html";
                break;
            case "学风建设":
                url = "/News/14_1.html";
                break;
            case "综合服务":
                url = "/News/16_1.html";
                break;
            case "资讯公告":
                url = "/News/9_1.html";
                break;
            case "师德建设大讨论专栏":
                url = "/News/17_1.html";
                break;
            case "山东理工大学十年发展大事记(2001—2010)":
                url = "/News/19_1.html";
                break;
            case "庆祝建党90周年专栏":
                url = "/News/21_1.html";
                break;
        }
        nrr = Myfile.Read_Model(HttpContext.Current.Server.MapPath("~/Lgwin/manage/model/list.model"));
        nrr = nrr.Replace("%%url%%", url);
        nrr = nrr.Replace("%%capname%%", classname);
        nrr = nrr.Replace("%%titles%%", titles);
        nrr = nrr.Replace("%%pager%%", pager(Tzong, page, classid, tiaoshu));
        try
        {
            Myfile.File_Write(HttpContext.Current.Server.MapPath("~") + "/News/" + classid + "_" + page + ".html", nrr);
            rts += "第" + page + "页生成成功\n";
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return rts;
    }
    /// <summary>
    /// 根据新闻实体的专题栏目属性，生成相应文章页
    /// </summary>
    /// <param name="mod"></param>
    /// <returns></returns>
    public static bool singlecon_toHtml(Lgwin.Model.Content mod)
    {
        if (Convert.ToInt32(mod.Zt) == 52)
        {
            string t = content_text1(mod);

            return singlecon_toHtml(mod, t);
        }
        else
        {
            string t = content_text(mod);
            return singlecon_toHtml(mod, t);
        }
    }
    /// <summary>
    /// 根据新闻实体的专题栏目属性，生成相应文章页
    /// </summary>
    /// <param name="mod">新闻实体</param>
    /// <param name="text">新闻页内容</param>
    /// <returns></returns>
    public static bool singlecon_toHtml(Lgwin.Model.Content mod, string text)
    {

        text = content_text_replace(text, mod);
        if (mod.Zt == "" || mod.Ztid == "" || mod.Zt == string.Empty || mod.Ztid == string.Empty || mod.Zt == "0" || mod.Ztid == "0" || mod.Zt == null || mod.Ztid == null)
        {
            Myfile.File_Write(HttpContext.Current.Server.MapPath("~/News/" + mod.Id + ".html"), text);
        }
        else
        {
            ZtBLL ztbll = new ZtBLL();
            Zt ztmod = ztbll.GetZtById(int.Parse(mod.Zt));
            if (ztmod != null)
            {
                Myfile.File_Write(HttpContext.Current.Server.MapPath("~/topic/" + ztmod.ZtJiancheng + "/news/" + mod.Id + ".html"), text);//, "utf-8"
            }
        }
        return true;
    }
    public static bool singlecon_toHtml(Lgwin.Model.Content mod, string text, int ztid)
    {

        text = content_text_replace(text, mod, Convert.ToInt32(mod.Ztid));
        if (mod.Zt == "" || mod.Ztid == "" || mod.Zt == string.Empty || mod.Ztid == string.Empty || mod.Zt == "0" || mod.Ztid == "0" || mod.Zt == null || mod.Ztid == null)
        {
            Myfile.File_Write(HttpContext.Current.Server.MapPath("~/News/" + mod.Id + ".html"), text);
        }
        else
        {
            ZtBLL ztbll = new ZtBLL();
            Zt ztmod = ztbll.GetZtById(int.Parse(mod.Zt));
            if (ztmod != null)
            {
                Myfile.File_Write(HttpContext.Current.Server.MapPath("~/topic/" + ztmod.ZtJiancheng + "/news/" + mod.Id + ".html"), text);//, "utf-8"
            }
        }
        return true;
    }
    /// <summary>
    /// 批量静态化
    /// </summary>
    /// <param name="mods"></param>
    /// <returns></returns>
    public static string manycon_toHtml(IList<Lgwin.Model.Content> mods)
    {
        string rts = "";
        foreach (Lgwin.Model.Content mod in mods)
        {
            string t = content_text(mod);
            if (singlecon_toHtml(mod, t))
                rts += mod.Id + "ok!\n";
            else
                rts += mod.Id + "错误!\n";
        }
        return rts;
    }
    public static string manycon_toHtml(IList<Lgwin.Model.Content> mods, int ztid)
    {
        string rts = "";
        foreach (Lgwin.Model.Content mod in mods)
        {
            string t = content_text(mod, ztid);
            if (singlecon_toHtml(mod, t, ztid))
                rts += mod.Id + "ok!\n";
            else
                rts += mod.Id + "错误!\n";
        }
        return rts;
    }
    /// <summary>
    /// 文本替换方法
    /// </summary>
    /// <param name="text">模板内容</param>
    /// <param name="mod">新闻实体</param>
    /// <returns>替换后的新文本</returns>
    public static string content_text_replace(string text, Lgwin.Model.Content mod)
    {
        string url = "";
        switch (mod.Caption)
        {
            case "理工要闻":
                url = "/News/1_1.html";
                break;
            case "院部传真":
                url = "/News/2_1.html";
                break;
            case "教学科研":
                url = "/News/3_1.html";
                break;
            case "学生工作":
                url = "/News/5_1.html";
                break;
            case "媒体理工":
                url = "/News/6_1.html";
                break;
            case "专题报道":
                url = "/News/12_1.html";
                break;
            case "理工人物":
                url = "/News/7_1.html";
                break;
            case "高教视点":
                url = "/News/8_1.html";
                break;
            case "学风建设":
                url = "/News/14_1.html";
                break;
            case "综合服务":
                url = "/News/16_1.html";
                break;
            case "资讯公告":
                url = "/News/9_1.html";
                break;

        }

        ZtCaptionBLL capbll = new ZtCaptionBLL();
        Lgwin.Model.ZtCaption cap = new Lgwin.Model.ZtCaption();

        if (mod.Ztid != null && mod.Ztid != "" && mod.Ztid != "0")
        {
            cap = capbll.GetZtCaption(int.Parse(mod.Ztid));
        }
        switch (cap.ZtCaptionName)
        {
            case "印象感悟":
                url = "176_1.html";
                break;
            case "一网情深":
                url = "178_1.html";
                break;
            case "深入贯彻落实十八大精神":
                url = "../182_1.html";
                break;
            case "“我的中国梦”专栏":
                url = "../198_1.html";
                break;
            case "特色名校建设专题":
                url = "../184_1.html";
                break;
            case null:
                break;
            default:
                url = mod.Ztid+"_1.html";
                break;
        }
        text = text.Replace("%%url%%", url);
        text = text.Replace("%%id%%", mod.Id.ToString());
        text = text.Replace("%%content%%", mod.Contents);
        if (mod.Zt == "" || mod.Ztid == "" || mod.Ztid == "0" || mod.Zt == "0" || mod.Zt == null || mod.Ztid == null)
        {
            if (mod.Zt == "54")
            {
                text = text.Replace("%%caption%%", "理工要闻");
            }
            else
            {
                text = text.Replace("%%caption%%", mod.Caption.ToString());
            }
        }
        else
        {
            text = text.Replace("%%caption%%", cap.ZtCaptionName);
        }
        text = text.Replace("%%title%%", mod.Title);
        if (mod.Subtitle == "")
        {
            text = text.Replace("%%subtitle%%", mod.Subtitle);
        }
        else
        {
            text = text.Replace("%%subtitle%%", "——" + mod.Subtitle);
        }
        if (mod.Author == "")
        {
            text = text.Replace("%%author%%", mod.Author);
        }
        else
        {
            text = text.Replace("%%author%%", "作者：" + mod.Author);
        }
        if (mod.Fro == "")
        {
            text = text.Replace("%%fro%%", mod.Fro);
        }
        else
        {
            text = text.Replace("%%fro%%", "来源：" + mod.Fro);
        }
        text = text.Replace("%%editor%%", mod.Editor);
        text = text.Replace("%%datee%%", mod.Datee.ToShortDateString());
        if (mod.Forbiden == "1")
            text = text.Replace("%%forbiden%%", "oncopy=\"return false\" oncut=\"return false\"");
        else
            text = text.Replace("%%forbiden%%", "");
        return text;
    }
    public static string content_text_replace(string text, Lgwin.Model.Content mod, int ztid)
    {
        string url = "";
        switch (ztid)
        {
            case 146:
                url = mod.Ztid + "_1.html";
                break;
            case 147:
            case 148:
                url = "147_1.html";
                break;
            case 149:
                url = "149_1.html";
                break;
            case 150:
                url = "150_1.html";
                break;
            default:
                break;
        }

        ZtCaptionBLL capbll = new ZtCaptionBLL();
        Lgwin.Model.ZtCaption cap = new Lgwin.Model.ZtCaption();
        if (mod.Ztid != null && mod.Ztid != "" && mod.Ztid != "0")
        {
            cap = capbll.GetZtCaption(int.Parse(mod.Ztid));
        }
        text = text.Replace("%%url%%", url);
        text = text.Replace("%%id%%", mod.Id.ToString());
        text = text.Replace("%%content%%", mod.Contents);
        if (mod.Zt == "" || mod.Ztid == "" || mod.Ztid == "0" || mod.Zt == "0" || mod.Zt == null || mod.Ztid == null)
        {
            text = text.Replace("%%caption%%", mod.Caption.ToString());
        }
        else
        {
            text = text.Replace("%%caption%%", cap.ZtCaptionName);
        }
        text = text.Replace("%%title%%", mod.Title);
        if (mod.Subtitle == "")
        {
            text = text.Replace("%%subtitle%%", mod.Subtitle);
        }
        else
        {
            text = text.Replace("%%subtitle%%", "——" + mod.Subtitle);
        }
        if (mod.Author == "")
        {
            text = text.Replace("%%author%%", mod.Author);
        }
        else
        {
            text = text.Replace("%%author%%", "作者：" + mod.Author);
        }
        if (mod.Fro == "")
        {
            text = text.Replace("%%fro%%", mod.Fro);
        }
        else
        {
            text = text.Replace("%%fro%%", "来源：" + mod.Fro);
        }
        text = text.Replace("%%editor%%", mod.Editor);
        text = text.Replace("%%datee%%", mod.Datee.ToShortDateString());
        if (mod.Forbiden == "1")
            text = text.Replace("%%forbiden%%", "oncopy=\"return false\" oncut=\"return false\"");
        else
            text = text.Replace("%%forbiden%%", "");
        return text;
    }

    public static string manyVideo_toHtml(IList<Video> mods)
    {
        string rts = "";
        foreach (Video mod in mods)
        {
            if (singleVideo_toHtml(mod))
                rts += mod.Id + "ok!\n";
            else
                rts += mod.Id + "错误！\n";
        }
        return rts;
    }
    public static bool singleVideo_toHtml(Video mod)
    {
        string text = "";
        text = Myfile.Read_Model(HttpContext.Current.Server.MapPath("~/Lgwin/manage/model/video.model"));
        text = video_text_replace(text, mod);
        if (Myfile.File_Write(HttpContext.Current.Server.MapPath("~/News/video/" + mod.Id + ".html"), text))
            return true;
        else
            return false;
    }
    public static bool singleVideoAndPic_toHtml(Video mod)
    {
        string text = "";
        text = Myfile.Read_Model(HttpContext.Current.Server.MapPath("~/Lgwin/manage/model/video.model"));
        text = video_text_replace(text, mod);
        if (Myfile.File_Write(HttpContext.Current.Server.MapPath("~/News/video/" + mod.Id + ".html"), text))
            return true;
        else
            return false;
    }
    public static string manyMusic_toHtml(IList<Video> mods)
    {
        string rts = "";
        foreach (Video mod in mods)
        {
            if (singleMusic_toHtml(mod))
                rts += mod.Id + "ok!\n";
            else
                rts += mod.Id + "错误！\n";
        }
        return rts;
    }
    public static bool singleMusic_toHtml(Video mod)
    {
        string text = "";
        text = Myfile.Read_Model(HttpContext.Current.Server.MapPath("~/Lgwin/manage/model/Music.model"));
        text = video_text_replace(text, mod);
        if (Myfile.File_Write(HttpContext.Current.Server.MapPath("~/News/video/" + mod.Id + ".html"), text))
            return true;
        else
            return false;
    }
    public static bool WriteMusicList(IList<Video> mods)
    {
        string text = "", list = "";
        text = Myfile.Read_Model(HttpContext.Current.Server.MapPath("~/Lgwin/manage/model/songlist.xml"));
        foreach (Video mod in mods)
        {
            list += "<song name=\"" + mod.Title + "\" url=\"../../" + mod.Url + "\"/>";
        }
        text = text.Replace("%%MusicList%%", list);
        if (Myfile.File_Write(HttpContext.Current.Server.MapPath("~/News/video/songlist.xml"), text))
            return true;
        else
            return false;
    }

    public static string video_text_replace(string text, Video mod)
    {
        string souce = "";
        souce += "<channel><item><source>../../" + mod.Url + "</source><title>" + mod.Title + "</title></item></channel>";
        text = text.Replace("%%videosource%%", souce);
        text = text.Replace("%%id%%", mod.Id.ToString());
        text = text.Replace("%%caption%%", "视频理工");
        text = text.Replace("%%title%%", mod.Title);

        if (mod.Uploader == "")
        {
            text = text.Replace("%%author%%", mod.Uploader);
        }
        else
        {
            text = text.Replace("%%author%%", "上传者：" + mod.Uploader);
        }
        if (mod.From == "")
        {
            text = text.Replace("%%fro%%", mod.From);
        }
        else
        {
            text = text.Replace("%%fro%%", "来源：" + mod.From);
        }
        text = text.Replace("%%commcontent%%", mod.Recommend);
        text = text.Replace("%%datee%%", mod.AddDate.ToString("yyyy-MM-dd"));
        int count;
        VideoBLL vdiobll = new VideoBLL();
        IList<Video> prelist = vdiobll.GetVideoList(1, 1, "id<'" + mod.Id.ToString() + "'", out count);
        if (prelist.Count > 0)
            text = text.Replace("%%preone%%", "<a href=\"" + prelist[0].Id + ".html\" title=\"" + prelist[0].Title + "\" >" + Mystring.lim_withoutPoint(prelist[0].Title, 40) + "</a>");
        else
        {
            text = text.Replace("%%preone%%", "没有了");
        }
        IList<Video> nextlist = vdiobll.GetVideoList(1, 1, "id>'" + mod.Id.ToString() + "'", out count);
        if (nextlist.Count > 0)
            text = text.Replace("%%nextone%%", "<a href=\"" + nextlist[0].Id + ".html\" title=\"" + nextlist[0].Title + "\" >" + Mystring.lim_withoutPoint(nextlist[0].Title, 40) + "</a>");
        else
        {
            text = text.Replace("%%nextone%%", "没有了");
        }

        return text;
    }
    //public static string Firstvideo_text_replace(string text, Video mod)
    //{
    //    text = text.Replace("%%id%%", mod.Id.ToString());
    //    text = text.Replace("%%caption%%", "视频理工");
    //    text = text.Replace("%%title%%", mod.Title);

    //    if (mod.Author == "")
    //    {
    //        text = text.Replace("%%author%%", mod.Uploader);
    //    }
    //    else
    //    {
    //        text = text.Replace("%%author%%", "上传者：" + mod.Author);
    //    }
    //    if (mod.Fro == "")
    //    {
    //        text = text.Replace("%%fro%%", mod.From);
    //    }
    //    else
    //    {
    //        text = text.Replace("%%fro%%", "来源：" + mod.From);
    //    }
    //    text = text.Replace("%%commcontent%%", mod.Recommend);
    //    text = text.Replace("%%datee%%", mod.AddDate.ToString("yyyy-MM-dd"));
    //    text = text.Replace("%%preone%%", "没有了");
    //    int count;
    //    VideoBLL vdiobll = new VideoBLL();
    //    IList<Video> nextlist = vdiobll.GetVideoList(1, 1, "id>'" + mod.Id.ToString() + "'", out count);
    //    if (nextlist.Count > 0)
    //        text = text.Replace("%%nextone%%", "<a href=\"" + nextlist[0].Id + ".html\" title=\"" + nextlist[0].Title + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(nextlist[0].Title, 40) + "</a>");

    //    return text;
    //}
    //public static string Lasttvideo_text_replace(string text, Video mod)
    //{
    //    text = text.Replace("%%id%%", mod.Id.ToString());
    //    text = text.Replace("%%caption%%", "视频理工");
    //    text = text.Replace("%%title%%", mod.Title);

    //    if (mod.Author == "")
    //    {
    //        text = text.Replace("%%author%%", mod.Uploader);
    //    }
    //    else
    //    {
    //        text = text.Replace("%%author%%", "上传者：" + mod.Author);
    //    }
    //    if (mod.Fro == "")
    //    {
    //        text = text.Replace("%%fro%%", mod.From);
    //    }
    //    else
    //    {
    //        text = text.Replace("%%fro%%", "来源：" + mod.From);
    //    }
    //    text = text.Replace("%%commcontent%%", mod.Recommend);
    //    text = text.Replace("%%datee%%", mod.AddDate.ToString("yyyy-MM-dd"));
    //    int count;
    //    VideoBLL vdiobll = new VideoBLL();
    //    IList<Video> prelist = vdiobll.GetVideoList(1, 1, "id<'" + mod.Id.ToString() + "'", out count);
    //    if (prelist.Count > 0)
    //        text = text.Replace("%%preone%%", "<a href=\"" + prelist[0].Id + ".html\" title=\"" + prelist[0].Title + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(prelist[0].Title, 40) + "</a>");
    //    text = text.Replace("%%nextone%%", "没有了");

    //    return text;
    //}
    /// <summary>
    /// 读专题看新闻页的模板，栏目有自己的模板时用自己的，没有时用专题的，都没有时用理工视窗的新闻页模板
    /// </summary>
    /// <param name="topic">专题字母名称</param>
    /// <param name="caption">专题栏目id</param>
    /// <returns>模板内容</returns>
    public static string content_text(Lgwin.Model.Content mod)
    {
        string text = "";
        if (mod.Zt == "" || mod.Ztid == "" || mod.Ztid == "0" || mod.Zt == "0")
        {
            text = Myfile.Read_Model(HttpContext.Current.Server.MapPath("~/Lgwin/manage/model/news.model"));
        }

        else
        {
            ZtBLL ztbll = new ZtBLL();
            Zt ztmod = ztbll.GetZtById(int.Parse(mod.Zt));
            if (ztmod != null)
            {
                if (!File.Exists(HttpContext.Current.Server.MapPath("~/topic/" + ztmod.ZtJiancheng + "/models/" + mod.Ztid.ToString() + ".html")))
                {
                    //if (mod.Zt == "60")
                    if (mod.Zt == "61")
                    {
                        text = Myfile.Read_Model(HttpContext.Current.Server.MapPath("~/topic/" + ztmod.ZtJiancheng + "/models/thr.html"));
                    }
                    if (mod.Zt == "66" && mod.Ztid == "214")
                    {
                        text = Myfile.Read_Model(HttpContext.Current.Server.MapPath("~/topic/" + ztmod.ZtJiancheng + "/models/full.html"));
                    }
                    else if (!File.Exists(HttpContext.Current.Server.MapPath("~/topic/" + ztmod.ZtJiancheng + "/models/3rd.html")))
                    {
                        text = Myfile.Read_Model(HttpContext.Current.Server.MapPath("~/Lgwin/manage/model/news_zt.model"));
                    }
                    else
                    {
                        text = Myfile.Read_Model(HttpContext.Current.Server.MapPath("~/topic/" + ztmod.ZtJiancheng + "/models/3rd.html"));
                    }
                }
                else
                {
                    text = Myfile.Read_Model(HttpContext.Current.Server.MapPath("~/topic/" + ztmod.ZtJiancheng + "/models/" + mod.Ztid.ToString() + ".html"));
                }
            }
        }
        return text;
    }
    public static string content_text1(Lgwin.Model.Content mod)
    {
        int ztid = Convert.ToInt32(mod.Ztid);
        string text = "";
        if (mod.Zt == "" || mod.Ztid == "" || mod.Ztid == "0" || mod.Zt == "0")
        {
            text = Myfile.Read_Model(HttpContext.Current.Server.MapPath("~/Lgwin/manage/model/news.model"));
        }
        else
        {
            ZtBLL ztbll = new ZtBLL();
            Zt ztmod = ztbll.GetZtById(int.Parse(mod.Zt));
            if (ztmod != null)
            {

                if (!File.Exists(HttpContext.Current.Server.MapPath("~/topic/" + ztmod.ZtJiancheng + "/models/" + mod.Ztid.ToString() + ".html")))
                {
                    if (mod.Zt == "52")
                    {
                        text = Myfile.Read_Model(HttpContext.Current.Server.MapPath("~/topic/" + ztmod.ZtJiancheng + "/models/thr.html"));
                    }
                }
                else
                {
                    text = Myfile.Read_Model(HttpContext.Current.Server.MapPath("~/topic/" + ztmod.ZtJiancheng + "/models/" + mod.Ztid.ToString() + ".html"));
                }
            }
        }
        return text;
    }
    public static string content_text(Lgwin.Model.Content mod, int ztid)
    {
        string text = "";
        if (mod.Zt == "" || mod.Ztid == "" || mod.Ztid == "0" || mod.Zt == "0")
        {
            text = Myfile.Read_Model(HttpContext.Current.Server.MapPath("~/Lgwin/manage/model/news.model"));
        }
        else
        {
            ZtBLL ztbll = new ZtBLL();
            Zt ztmod = ztbll.GetZtById(int.Parse(mod.Zt));
            if (ztmod != null)
            {

                if (!File.Exists(HttpContext.Current.Server.MapPath("~/topic/" + ztmod.ZtJiancheng + "/models/" + mod.Ztid.ToString() + ".html")))
                {
                    if (mod.Zt == "52")
                    {
                        text = Myfile.Read_Model(HttpContext.Current.Server.MapPath("~/topic/" + ztmod.ZtJiancheng + "/models/thr.html"));
                    }
                }
                else
                {
                    text = Myfile.Read_Model(HttpContext.Current.Server.MapPath("~/topic/" + ztmod.ZtJiancheng + "/models/" + mod.Ztid.ToString() + ".html"));
                }
            }
        }
        return text;
    }
    //以下方法用于专题静态化
    /// <summary>
    /// 生成专题列表
    /// </summary>
    /// <param name="mods">内容实体</param>
    /// <param name="len">一条字数</param>
    /// <param name="datestr">日期格式</param>
    /// <returns></returns>
    /// 

    public static string index_list(IList<Lgwin.Model.Content> mods, int len, string datestr, int i)
    {
        string rts = "";
        string dates = "";
        string title = "";
        string contents = "";
        string tel = "";
        string url = "";
        int flag = 0;
        System.Text.StringBuilder strb = new System.Text.StringBuilder();
        foreach (Lgwin.Model.Content mod in mods)
        {
            if (datestr != "")
            {
                dates = mod.Datee.ToString(datestr);
            }
            if (mod.Url != "0")
                url = mod.Url;
            else
                url = "news/" + mod.Id.ToString() + ".html";
            title = Mystring.lim_withoutPoint(mod.Title, len);
            int zt = Convert.ToInt32(mod.Zt);
            int ztid = Convert.ToInt32(mod.Ztid);
            if (zt == 51)
            {
                switch (ztid)
                {
                    case 139:
                    case 142:
                    case 143:
                        strb.AppendFormat("<tr height=\"20\"><td width=\"1%\"><img src=\"images/logo_03.jpg\" width=\"5\" height=\"5\" /></td><td align=\"left\"><a href=\"{0}\" title=\"{1}\" target=\"_blank\">{2}</a></td><td width=\"15%\">[{3}]</td></tr>", url, mod.Title, title, dates);
                        break;
                    case 140:
                    case 141:
                        strb.AppendFormat("<tr height=\"22\"><td width=\"2%\"><img src=\"images/logo_03.jpg\" width=\"5\" height=\"5\" /></td><td align=\"left\"><a href=\"{0}\" title=\"{1}\" target=\"_blank\">{2}</a></td><td width=\"30%\">[{3}]</td></tr>", url, mod.Title, title, dates);
                        break;
                }
            }
            else if (zt == 55)//站庆专题，校园风首页静态化
            {
                switch (ztid)
                {
                    case 166:
                        strb.AppendFormat("<li><a href=\"{0}\" title=\"{1}\" target=\"_blank\">{2}</a></li>", url, mod.Title, title, dates);
                        break;
                    case 167:
                    case 168:
                        strb.AppendFormat("<div><div  class=\"z_content\"></div><div  class=\"z_content2\"><a href=\"{0}\" title=\"{1}\" target=\"_blank\">{2}</a></div><div  class=\"z_content3\">[{3}]</div></div>", url, mod.Title, title, dates);
                        break;
                    case 169:
                        if (flag % 3 == 0) { strb.AppendFormat("<div class='r_left'>"); }
                        strb.AppendFormat("<div><div class=\"r_content\"></div><div class=\"r_content2\"><a href=\"{0}\" title=\"{1}\" target=\"_blank\">{2}</a></div><div class=\"r_content3\">[{3}]</div></div>", url, mod.Title, title, dates);
                        if (flag % 3 == 2 || flag == mods.Count - 1) { strb.AppendFormat("</div>"); }
                        flag++;
                        break;
                    case 170:
                        strb.AppendFormat("<li><a href=\"{0}\" title=\"{1}\" target=\"_blank\">{2}</a></li>", url, mod.Title, title);
                        break;
                    case 171:
                        strb.AppendFormat("<div><div class=\"m_content\"></div><div class=\"m_content2\"><a href=\"{0}\" title=\"{1}\" target=\"_blank\">{2}</a></div><div class=\"m_content3\">[{3}]</div></div>", url, mod.Title, title, dates);
                        break;
                }
            }
            else if (zt == 56)//十周年站庆--相约同行
            {
                switch (ztid)
                {
                    case 173:
                        strb.AppendFormat("<tr><td width=\"5%\" valign=\"center\" align=\"right\"> <img src=\"images/logo.jpg\" width=\"5\" height=\"8\" /> </td> <td><a href=\"{0}\" title=\"{1}\" target=\"_blank\">{2}</a></td><td width=\"18%\">[{3}]</td></tr>", url, mod.Title, title, dates);
                        break;
                }
            }

            else if (zt == 57)//十周年站庆--印象十载
            {
                switch (ztid)
                {
                    case 176:
                        strb.AppendFormat("  <tr><td width=\"26px\"><img alt=\"fangkuai\" src=\"images/fangkuai.gif\" /></td><td align=\"left\"><a href=\"{0}\" title=\"{1}\" target=\"_blank\">{2}</a></td><td>[{3}]</td></tr>", url, mod.Title, title, dates);
                        break;
                }
            }
            else if (zt == 58)//十周年站庆--情系卡瑞特
            {
                switch (ztid)
                {
                    case 178:
                        strb.AppendFormat("<tr><td><img src=\"images/wordlogo.jpg\" /></td><td width=\"75%\"><a href=\"{0}\" title=\"{1}\" target=\"_blank\" class=\"qingshen\">{2}</a></td><td width=\"25%\" align=\"center\">[{3}]</td></tr>", url, mod.Title, title, dates);
                        break;
                }
            }
            else if (60 == zt)//特色名校专题
            {
                dates = mod.Datee.ToString("yyyy-MM-dd");
                switch (ztid)
                {
                    case 186:
                        strb.AppendFormat("<div class=\"Gbiaoti\"><div class=\"tubiao\" style=\"margin-top:5px\"><img src=\"images/FK.jpg\" /></div><div class=\"Gfont\"><a href=\"{0}\" style=\"color:#000000\" target=\"_balnk\">{1}</a></div><div class=\"Gtime\">[{2}]</div></div>", url, title, dates);
                        break;
                    case 187:
                        strb.AppendFormat("<div class=\"biaoti\"><div class=\"tubiao\"><img src=\"images/tibiao.gif\" /></div><div class=\"Zfont\"><a href=\"{0}\" style=\"color:#000000\" target=\"_balnk\">{1}</a></div></div>", url, title);
                        break;
                    case 188:
                        strb.AppendFormat("<div class=\"biaoti\"><div class=\"tubiao\"><img src=\"images/tibiao.gif\" /></div><div class=\"Zfont\"><a href=\"{0}\" style=\"color:#000000\" target=\"_balnk\">{1}</a></div></div>", url, title);
                        break;
                    case 189:
                        strb.AppendFormat("<div class=\"Lbiaoti\"><div class=\"tubiao\"><img src=\"images/tibiao.gif\" /></div><div class=\"Lfont\"><a href=\"{0}\" style=\"color:#000000\" target=\"_balnk\">{1}</a></div> </div>", url, title);
                        break;
                    case 190:
                        strb.AppendFormat("<div class=\"biaoti\"><div class=\"tubiao\"><img src=\"images/tubiao2.gif\" /></div><div class=\"Zfont\"><a href=\"{0}\" style=\"color:#000000\" target=\"_balnk\">{1}</a></div></div>", url, title);
                        break;
                    case 191:
                        strb.AppendFormat("<div class=\"biaoti\"><div class=\"tubiao\"><img src=\"images/tubiao2.gif\" /></div><div class=\"Zfont\"><a href=\"{0}\" style=\"color:#000000\" target=\"_balnk\">{1}</a></div></div>", url, title);
                        break;
                }
            }
            else if (64 == zt)//2013毕业专题
            {
                dates = mod.Datee.ToString("MM-dd");
                contents = Mystring.DelHTML(mod.Contents.ToString());
                tel = mod.Tel.ToString();
                Regex r = new Regex(@"\s+");
                switch (ztid)
                {
                    case 199:
                        strb.AppendFormat("<div class=\"face_mes\"><div class=\"face_mes_1\"></div><div class=\"face_mes_2\"><a href=\"{0}\" target=\"_blank\">{1}</a></div><div class=\"face_mes_3\">[{2}]</div></div>", url, title, dates);
                        break;
                    case 200:
                        strb.AppendFormat("<div class=\"face_mes\"><div class=\"face_mes_1\"></div><div class=\"face_mes_2\"><a href=\"{0}\" target=\"_blank\">{1}</a></div><div class=\"face_mes_3\">[{2}]</div></div>", url, title, dates);
                        break;
                    case 202:
                        contents = Mystring.lim_withoutPointNo(contents, 66);
                        strb.AppendFormat("<div class=\"youqing_article\"><div class=\"youqing_article_1\"><a href=\"{0}\"  target=\"_blank\">{1}</a></div><div class=\"youqing_article_2\"><a href=\"{0}\" target=\"_blank\"><img width=\"153px\" height=\"115px\" src=\"http://lgwindow.sdut.edu.cn{2}\" /></a></div><div class=\"youqing_article_3\"><a href=\"{0}\" style=\"color:#000000;\" target=\"_blank\">{3}</a>　<a href=\"{0}\" target=\"_blank\" style=\"color:#bb1f1f; font-weight:bold;\">…【详细】</a></div></div>", url, title, tel, "　　"+r.Replace(contents.Trim(),"<br />　　"));
                        break;
                    case 203:
                        contents = Mystring.lim_withoutPointNo(contents, 102);
                        strb.AppendFormat("<div class=\"aiqing_title\"><a href=\"{0}\" title=\"{1}\" target=\"_blank\">{1}</a></div><div class=\"aiqing_content\"><a href=\"{0}\" style=\"color:#000000;\" title=\"{2}\" target=\"_blank\">{2}</a> <a href=\"{0}\" style=\"font-weight:bold; color:#bb1f1f;\" target=\"_blank\">　……【详细】</a></div>", url, title, "　　"+r.Replace(contents.Trim(),"<br />　　"));
                        break;
                    case 204:
                        contents = Mystring.lim_withoutPointNo(contents, 116);
                        strb.AppendFormat("<div class=\"ganhuai_article1\"><div class=\"ganhuai_title1\"></div><div class=\"ganhuai_title2\"><a href=\"{0}\" title=\"{1}\" target=\"_blank\">{1}</a></div><div class=\"ganhuai_content\"><a href=\"{0}\" title=\"{3}\" style=\"color:#000000;\" target=\"_blank\">{3}</a>　<a href=\"{0}\" style=\"color:#bb1f1f; font-weight:bold;\" target=\"_blank\">……【详细】</a></div><div class=\"ganhuai_img1\"><a href=\"{0}\" target=\"_blank\"><img width=\"201px\" height=\"130px\" src=\"http://lgwindow.sdut.edu.cn{2}\" /></a></div></div>", url, title, tel, "　　" + r.Replace(contents.Trim(), "<br />　　"));
                        break;
                    case 206:
                        strb.AppendFormat("<div class=\"yx_body2_shipn_list\"><a href=\"{0}\" style=\"color:#000000;\" target=\"_blank\">{1}</a></div>", url, title);
                        break;
                }
            }
            else if (65 == zt)//2013暑期社会实践专题
            {
                dates = mod.Datee.ToString("MM-dd");
                contents = Mystring.DelHTML(mod.Contents.ToString());
                tel = mod.Tel.ToString();
                Regex r = new Regex(@"\s+");
                switch (ztid)
                {
                    case 207:
                        strb.AppendFormat("<div class=\"s-list\"><div class=\"zjz\" style=\"float:left;\">·</div><div class=\"s-date\">[{2}]</div><div class=\"s-title\"><a href=\"{0}\" target=\"_blank\">{1}</a></div></div>", url, title, dates);
                        break;
                    case 208:
                        strb.AppendFormat("<div class=\"t-list\"><div class=\"zjz\" style=\"float:left;\">·</div><div class=\"t-date1\">[{2}]</div><div class=\"t-title1\"><a href=\"{0}\" target=\"_blank\">{1}</a></div></div>", url, title, dates);
                        break;
                    case 209:
                        contents = Mystring.lim_withoutPointNo(contents, 65);
                        strb.AppendFormat("<div id=\"y-list\"><table style=\"width:100%; height:100%\" cellpadding=\"0\" cellspacing=\"0\"><tr style=\"height:24px; width:100%; text-align:left;\"><td><a href=\"{0}\" target=\"_blank\" style=\"color:#08587D; font-size:16px;\">{1}</a></td></tr><tr style=\"height:55px; float:left; font-size:14px;\"><td>{2}...<a href=\"{0}\" target=\"_blank\" style=\"color:#08587D\">[详细]</a></td></tr></table></div>", url, title, "　　" + r.Replace(contents.Trim(), ""));
                        break;
                    case 210:
                        strb.AppendFormat("<div class=\"w-list\"><div class=\"zjz\" style=\"float:left;\">·</div><div class=\"w-date\">[{2}]</div><div class=\"w-title\"><a href=\"{0}\" target=\"_blank\">{1}</a></div></div>", url, title, dates);
                        break;
                    case 211:
                        contents = Mystring.lim_withoutPointNo(contents, 35);
                        strb.AppendFormat("<div id=\"cg2\"><table style=\"width:189px; height:117px; margin-left:7px; margin-top:9px;\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td colspan=\"3\"  style=\"height:30px; text-align:left; vertical-align:middle;\"><a href=\"{0}\" style=\"color:#5090AD; font-size:13.2px;\">{1}</a></td></tr><tr><td style=\"width:85px;\"><img {3} width=\"85px\" height=\"86px\" /></td><td style=\"width:4px;\"></td><td style=\"float:right;\">{4}<a href=\"{0}\" target=\"_blank\" style=\"color:#08587D; font-size:12px;\">...[详细]</a></td></tr></table></div>", url, title, tel, myRegular.pic_Src_Top1(mod.Contents),"　　" + r.Replace(contents.Trim(), ""));
                        break;
                    
                }
            }
            else if (66 == zt)//党的群众路线教育实践活动专题
            {
                dates = mod.Datee.ToString("yyyy-MM-dd");
                string dates1 = mod.Datee.ToString("MM-dd");
                contents = Mystring.DelHTML(mod.Contents.ToString());
                title = Mystring.lim_withoutPointNo(mod.Title, len);
                string title1 = Mystring.lim_withoutPoint(title, 18);
                Regex r = new Regex(@"\s+");
                switch (ztid)
                {
                    case 218:
                        contents = Mystring.lim_withoutPointNo(contents, 66);
                        strb.AppendFormat("<div class=\"toutiao_title\"><a href=\"{0}\" target=\"_blank\" style=\"font-size:28px; font-family:'黑体'; color:#D22028; line-height:38px;\">{1}</a></div><div class=\"toutiao_body\"><a href=\"{0}\" target=\"_blank\" style=\"font-size:15px; color:#5f5a3d; font-family:'宋体'; line-height:24px;\">{3}...[{2}]</a></div>", url, title1, dates1,contents);
                        break;
                    case 212:
                        strb.AppendFormat("<div class=\"dongtai_list\"><div class=\"dongtai_list1\">·<a href=\"{0}\" target=\"_blank\">{1}……</a></div><div class=\"dongtai_list2\">{2}</div></div>", url, title, dates);
                        break;
                    case 213:
                        strb.AppendFormat("<div class=\"chuanzhen_list\"><div class=\"chuanzhen_list1\">·<a href=\"{0}\" target=\"_blank\">{1}……</a></div><div class=\"chuanzhen_list2\">{2}</div></div>", url, title, dates);
                        break;
                    case 214:
                        strb.AppendFormat("<div class=\"jianbao_list\"><div class=\"jianbao_list1\">·<a href=\"{0}\" target=\"_blank\">{1}</a></div><div class=\"jianbao_list2\">{2}</div></div>", url, title, dates);
                        break;
                    case 215:
                        strb.AppendFormat("<div class=\"jingshen_list\"><div class=\"jingshen_list1\">·<a href=\"{0}\" target=\"_blank\">{1}…</a></div></div>", url, title);
                        break;
                    case 216:
                        strb.AppendFormat("<div class=\"guandian_list\">·<a href=\"{0}\" target=\"_blank\">{1}</a></div>", url, title);
                        break;
                    case 217:
                        strb.AppendFormat("<div class=\"guandian_list\">·<a href=\"{0}\" target=\"_blank\">{1}</a></div>", url, title);
                        break;
                }
            }
            else if (69 == zt)//2013迎新专题
            {

                
                contents = Mystring.DelHTML(mod.Contents.ToString());
               
              
                dates = mod.Datee.ToString("MM-dd");
                string weeks = mod.Datee.ToString("dddd");
                
                tel = mod.Tel.ToString();
                Regex r = new Regex(@"\s+");
                switch (ztid)
                {
                    case 231:
                        strb.AppendFormat("<div class=\"yxlist\"><div class=\"yxdian\"><font>·</font></div><div class=\"yxtitle\"><a href=\"{0}\" target=\"_blank\">{1}</a></div><div class=\"yxtime\">[{2}]</div></div>", url, title, dates);
                        break;
                    case 232:
                         contents = Mystring.lim_withoutPointNo(contents, 32);
                         strb.AppendFormat("<div class=\"tzlist\"><div class=\"tztime\"><div class=\"tzxq\"><font>{0}</font></div><div class=\"tzri\"><font>{1}</font></div></div><div class=\"tztitle\"><div class=\"tztt\"><a href=\"{2}\" target=\"_blank\">{3}</a></div><div class=\"tzcc\">{4}......<a href=\"{2}\" target=\"_blank\" style=\"color:#3486c5;\">【详细】</a></div></div></div>", weeks, dates, url, title, "　　" + r.Replace(contents.Trim(), ""));
                        break;
                    case 233:
                        contents = Mystring.lim_withoutPointNo(contents, 32);
                        strb.AppendFormat("", url, title, "　　" + r.Replace(contents.Trim(), ""));
                        break;
                    case 234:
                        contents = Mystring.lim_withoutPointNo(contents, 80);
                        strb.AppendFormat("<div id=\"dxlist\"><div id=\"dxpic\"><img {3} width=\"110px\" height=\"110px\" /></div><div id=\"dxtc\"><div id=\"dxtitle\"><a href=\"{0}\" target=\"_blank\">{1}</a></div><div id=\"dxcontent\">{4}......<a href=\"{0}\" style=\"color:#3486c5;\">【详细】</a></div></div></div>", url, title, tel, myRegular.pic_Src_Top1(mod.Contents), "　　" + r.Replace(contents.Trim(), ""));
                        break;
                    case 235:
                        strb.AppendFormat("<div class=\"qtitle\"><a href=\"{0}\" target=\"_blank\">{1}</a></div>", url, title);
                        break;

                }
            }
            else if (52 == zt)
            {
                switch (ztid)
                {
                    case 146:
                        if (flag == 0)
                        {
                            strb.AppendFormat("<div class='commen_hgt commen_pt'><div class='li'><img src='images/li.jpg' /></div><div class='title'><a href='{0}'  target='_blank'>{1}</a></div><div class='time'>[{2}]</div></div>", url, title, dates);
                        }
                        else
                        {
                            strb.AppendFormat("<div class='commen_hgt'><div class='li'><img src='images/li.jpg' /></div><div class='title'><a href='{0}' target='_blank'>{1}</a></div><div class='time'>[{2}]</div></div>", url, title, dates);
                        }
                        flag++;
                        break;
                    case 147:
                    case 148:
                        if (flag == 0)
                        {
                            strb.AppendFormat("<div class='commen_hgt commen_pt1'><div class='title1'><a href='{0}' target='_blank'>{1}</a></div><div class='time'>[{2}]</div></div>", url, title, dates);
                        }
                        else
                        {
                            strb.AppendFormat("<div class='commen_hgt'><div class='title1'><a href='{0}' target='_blank'>{1}</a></div><div class='time'>[{2}]</div></div>", url, title, dates);
                        }
                        flag++;
                        break;
                    case 149:
                    case 150:
                        strb.AppendFormat("<li><a href='{0}' target='_blank'>{1}</a></li>", url, title);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                if (i == 0)
                {
                    strb.AppendFormat("<tr ><td style=\"width:5%\"></td><td style=\"width:80%\">  <a href=\"{0}\" target=\"_blank\" title=\"{1}\">{2}</a></td><td>{3}</td></tr>", url, mod.Title, title, dates);
                }
                else
                {
                    strb.AppendFormat("<tr ><td style=\"width:5%\"><img src=\"images/index/index_tubiao_{0}.jpg\" /></td><td style=\"width:80%\">  <a href=\"{1}\" target=\"_blank\" title=\"{2}\">{3}</a></td><td>{4}</td></tr>", i, url, mod.Title, title, dates);
                    //strb.AppendFormat("<a href=\"{0}\" target=\"_blank\" title=\"{3}\">{1}{2}</a>", url, title, dates, mod.Title);
                }

            }
        }
        rts = strb.ToString();

        return rts;

    }
    /// <summary>
    /// 文章中只有图片时
    /// </summary>
    public static string index_pic(IList<Lgwin.Model.Content> mods)
    {
        string rts = "";

        StringBuilder stb = new StringBuilder();
        foreach (Lgwin.Model.Content mod in mods)
        {
            stb.AppendFormat("\n<a href=\"{0}\" target=\"_blank\" title=\"{1}\"><img {2} /></a>", mod.Url == "0" ? "news/" + mod.Id.ToString() + ".html" : mod.Url, mod.Title, myRegular.pic_Src_Top1(mod.Contents));
        }
        return stb.ToString();
    }
    /// <summary>
    /// 文章中有文字和图片时
    /// </summary>
    public static string index_pic_with_content(IList<Lgwin.Model.Content> mods)
    {
        StringBuilder stb = new StringBuilder();
        foreach (Lgwin.Model.Content mod in mods)
        {
            stb.AppendFormat("\n<a href=\"{0}\" target=\"_blank\" title=\"{3}\"><img {1} /><span>{2}</span></a>", mod.Url == "0" ? "news/" + mod.Id.ToString() + ".html" : mod.Url, myRegular.pic_Src_Top1(mod.Contents), mod.Title, mod.Title);
        }
        return stb.ToString();
    }

    //以下是生成二级页面
    /// <summary>
    /// 生成专题二级页
    /// </summary>
    /// <param name="mods">所有列表内容</param>
    /// <param name="titlelen">每条长度</param>
    /// <param name="tiaoshu">每页条数</param>
    /// <param name="zt">专题id</param>
    /// <param name="ztid">专题栏目id</param>
    /// <returns></returns>
    public static string list(IList<Lgwin.Model.Content> mods, int titlelen, int tiaoshu, int zt, int ztid)
    {
        string rts = "";
        int Tzong, Tzong_no = mods.Count;
        Tzong = zheng(Tzong_no, tiaoshu);
        string titles = "<table width=\"95%\" border=\"0\" cellpadding=\"0\" cellspacing=\"1\">\n";
        //  int start = st - 1;
        int i = 1;  //单页计数
        int pag = 1;  //页码
        //<img src="images/list/list_tubiao.jpg"/>用于专题列表显示的小图标，没有时可用空白图片替换掉
        //datee样式如下
        //text-decoration: none;
        //float: left;
        //width: 15%;
        //margin-top: 0px;
        //padding-left: 0px;
        foreach (Lgwin.Model.Content mod in mods)
        {
            if (zt != 54 && zt != 59 && zt != 60 && zt != 63)
            {
                titles += "<tr>\n<td width=\"5%\" class=\"pos\"><img  src=\"images/list/list_tubiao.jpg\"/></td><td align=\"left\" style=\"line-height:15pt;\">";
                titles += ZtGetHref(mod, titlelen) + "</td><td width=\"80\" class=\"datee\" align=\"right\">" + mod.Datee.ToString("yyyy-MM-dd") + "</td></tr>\n";
            }
            else
            {
                titles += "<tr>\n<td width=\"21px\" class=\"pos\"><img align='left' src=\"images/list/list_tubiao.jpg\"/></td><td align=\"left\" style=\" line-height:18px;padding-bottom:3px;\">";
                titles += ZtGetHref(mod, titlelen) + "</td><td width=\"110\" class=\"datee\" align=\"left\" style=\"padding-bottom:3px;\" >[" + mod.Datee.ToString("yyyy-MM-dd") + "]</td></tr>\n";
            }
            
            if (i == tiaoshu)
            {
                i = 1;
                try
                {
                    titles += "</table>";
                    rts += make_html(titles, pag, Tzong, zt, ztid, tiaoshu);
                }
                catch (Exception ex)
                {
                    throw ex;
                    HttpContext.Current.Response.End();
                }
                pag++;
                titles = "<table width=\"98%\" border=\"0\" cellpadding=\"0\" cellspacing=\"1\">";
            }
            else
                i++;
        }
        if (i != 1)//不满最后一页 table标签未结束
        {
            titles += "</table>";
            rts += make_html(titles, pag, Tzong, zt, ztid, tiaoshu);
        }
        return rts;
    }
    public static string bylist(IList<Lgwin.Model.Content> lists, IList<Lgwin.Model.Content> lists1, int ztid, int zt, int allcount, int tiaoshu, int zishu)
    {
        string text = "";
        string title = "";
        decimal temp = (decimal)allcount / tiaoshu;
        decimal pagecount = Math.Ceiling(temp);//存在小数进一
        int zongji = 0;
        int pag = 1;
        int flag = (lists.Count - 1) / tiaoshu >= (lists1.Count - 1) / tiaoshu ? (lists.Count - 1) / tiaoshu + 1 : (lists1.Count - 1) / tiaoshu + 1;
        while (pag <= flag)
        {
            int i = 1;
            zongji = 0;
            if (ztid == 147 || ztid == 148)
            {
                while (i <= tiaoshu)
                {
                    zongji += 10 * (pag - 1);
                    if (zongji < lists.Count)
                    {
                        if (i == 1 && (ztid == 147 || ztid == 148))
                        {
                            title += @"<div class='md2'><div class='inner'></div>";
                        }
                        if (i % 5 == 1)
                        {
                            if (ztid == 147 || ztid == 148)
                            {
                                title += "<div class=\"list\">";
                            }
                            else
                            {
                                title += "<div class=\"list1\">";
                            }
                        }
                        title += "<div class=\"list_list\"><table cellpadding=\"0\" cellspacing=\"0\" border=\"0\" width=\"100%\"><tr><td width=\"25\"><img src=\"../images/tubiao.gif\" /></td><td ><a href=\"" + lists[zongji].Id + ".html\"  title=\"" + lists[zongji].Title + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(lists[zongji].Title, 18) + "</a></td><td width=\"120\" align=\"right\">" + lists[zongji].Author + "</td><td width=\"60\" align=\"center\">[" + lists[zongji].Datee.ToString("MM-dd") + "]</td></tr></table></div>";
                        if ((i % 5 == 0) || ((i % 5 != 0) && zongji == lists.Count - 1))
                        {
                            title += "</div>";
                        }
                        if ((i == 10 || lists.Count - 1 == zongji) && (ztid == 147 || ztid == 148))
                        {
                            title += "</div>";
                        }
                    }
                    i++;
                    zongji++;
                }
            }
            if (i % tiaoshu != 1)
            {
                title += "</div>";
            }
            i = 1;
            zongji = 0;
            while ((i <= tiaoshu && (ztid == 146 || ztid == 149 || ztid == 150)) || (i <= 10 && (ztid == 147 || ztid == 148)))
            {
                zongji += 10 * (pag - 1);
                if (zongji < lists1.Count)
                {
                    if (i == 1 && (ztid == 147 || ztid == 148))
                    {
                        title += @"<div class='md3'><div class='inner'></div>";
                    }
                    if (i % 5 == 1)
                    {
                        if (ztid == 147 || ztid == 148)
                        {
                            title += "<div class=\"list\">";
                        }
                        else
                        {
                            title += "<div class=\"list1\">";
                        }
                    }
                    title += "<div class=\"list_list\"><table cellpadding=\"0\" cellspacing=\"0\" border=\"0\" width=\"100%\"><tr><td width=\"25\"><img src=\"../images/tubiao.gif\" /></td><td ><a href=\"ZtGetHref(mod, titlelen)\"  title=\"" + lists1[zongji].Title + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(lists1[zongji].Title, 18) + "</a></td><td width=\"120\" align=\"right\">" + lists1[zongji].Author + "</td><td width=\"60\" align=\"center\">[" + lists1[zongji].Datee.ToString("MM-dd") + "]</td></tr></table></div>";
                    if ((i % 5 == 0) || ((i % 5 != 0) && zongji == lists1.Count - 1))
                    {
                        title += "</div>";
                    }
                    if ((i == 10 || lists1.Count - 1 == zongji) && (ztid == 147 || ztid == 148))
                    {
                        title += "</div>";
                    }
                }
                i++;
                zongji++;
            }
            if (i % tiaoshu != 1)
            {
                title += "</div>";
            }
            if (ztid == 147 || ztid == 148)
            {
                pagecount = flag;
                tiaoshu = 20;
            }
            text = bymake_html(title, tiaoshu, (int)pagecount, pag, ztid, zt);
            pag++;
            title = "";
        }
        return text;
    }

    //十周年站庆印象十载二级页静态化测试
    /// <summary>
    /// 十周年站庆二级页静态化测试
    /// </summary>
    /// <param name="lists"></param>
    /// <param name="ztid"></param>
    /// <param name="zt"></param>
    /// <param name="allcount"></param>
    /// <param name="tiaoshu"></param>
    /// <param name="zishu"></param>
    /// <returns></returns>
    /// 
    public static string bylist2(IList<Lgwin.Model.Content> lists, int ztid, int zt, int allcount, int tiaoshu, int zishu)
    {
        string text = "";
        string title = "";
        decimal temp = (decimal)allcount / tiaoshu;
        decimal pagecount = Math.Ceiling(temp);//存在小数进一
        int count = 0;
        //ArticleBLL articlebll = new ArticleBLL();
        //List<Article> list = articlebll.GetArticlelist(tiaoshu, 1, " Pass='true' ", "id", true, out count);
        int pag = 1;
        int i = 1;
        //for (int j = 0; j < 5; j++)
        //{
        foreach (Lgwin.Model.Content list in lists)
        {
            if (i % 12 == 1)
            {
                title += "<div class=\"title\">";
            }

            title += " <table width=\"99%\"><tr><td width=\"6\"><img src=\"../images/logo.jpg\" width=\"6\" /></td><td width=\"550\"><span style=\"font-size:16px; color:#2b66cf;font-family:黑体\"><a href=\"" + list.Id + ".html\"  title=\"" + list.Title + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(list.Title, 35) + "</a> </span>&nbsp; <span style=\"font-size:14px; color:#4C7ED7; font-family:黑体\">印象●感悟</span></td><td style=\"font-size:14px; color:#303030; font-family:黑体\">[" + list.Datee.ToString("yyyy-MM-dd") + "]</td></tr></table></div><div class=\"article\"><a style=\"color:#4C7ED7;\" href=\"" + list.Id + ".html\"  title=\"" + list.Contents + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(list.Contents, 70) + "</a></div>";
            text = bymake_html2(title, tiaoshu, (int)pagecount, pag, ztid, zt);
        }
        return text;
    }
    public static string bylist1(IList<Lgwin.Model.Content> lists, int ztid, int zt, int allcount, int tiaoshu, int zishu)
    {
        string text = "";
        string title = "";
        decimal temp = (decimal)allcount / tiaoshu;
        decimal pagecount = Math.Ceiling(temp);//存在小数进一
        int count = 0;
        int pag = 1;
        int i = 1;
        
        foreach (Lgwin.Model.Content list in lists)
        {
            if (i % 5 == 1)
            {
                title += "<div class=\"list\">";
            }
            title += "<div class=\"A2\"><img src=\"../images/fang_07.jpg\" /></div><div class=\"A1\"><div class=\"A3\"><a href=\"" + list.Id + ".html\"  title=\"" + list.Title + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(list.Title, 35) + "</a></div><div class=\"A4\">[" + list.Datee.ToString("yyyy-MM-dd") + "]</div></div>";
            if (i % 5 == 0)
            {
                title += "</div>";
            }
            if (i % tiaoshu == 0)
            {
                text = bymake_html1(title, tiaoshu, (int)pagecount, pag, ztid, zt);
                pag++;
                //i = 0;
                title = "";
            }
            i++;
        }
        if ((i > tiaoshu) && (i % tiaoshu != 0))
        {
            if (i % 5 != 1)
            {
                title += "</div>";
            }
            text = bymake_html1(title, tiaoshu, (int)pagecount, pag, ztid, zt);
        }
        else if (i <= tiaoshu)
        {
            if (i % 5 != 1)
            {
                title += "</div>";
            }
            text = bymake_html1(title, tiaoshu, (int)pagecount, pag, ztid, zt);
        }
        return text;
    }
    //公共二级页列表生成
    public static string bylist_public(IList<Lgwin.Model.Content> lists, int ztid, int zt, int allcount, int tiaoshu, int zishu)
    {
        string text = "";
        string title = "";
        
        decimal temp = (decimal)allcount / tiaoshu;
        decimal pagecount = Math.Ceiling(temp);//存在小数进一
        int count = 0;
        int pag = 1;
        int i = 1;

        foreach (Lgwin.Model.Content list in lists)
        {
            if (i % 5 == 1)
            {
                title += "<div class=\"list\">";
            }
            string href1 = list.Url;
            //默认title += "<div class=\"A2\"><img src=\"../images/fang_07.jpg\" /></div><div class=\"A1\"><div class=\"A3\"><a href=\"" + list.Id + ".html\"  title=\"" + list.Title + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(list.Title, 35) + "</a></div><div class=\"A4\">[" + list.Datee.ToString("yyyy-MM-dd") + "]</div></div>";
            //备份title += "<div class=\"erjiye_list\"><div class=\"list_pic\"><div class=\"list_pic1\"></div></div><div class=\"erjiye_list1\"><a href=\"" + list.Id + ".html\" style=\"font-size:14px; color:#D22028;\" target=\"_blank\">" + Mystring.lim_withoutPoint(list.Title, 37) + "</a></div><div class=\"erjiye_list2\">[" + list.Datee.ToString("yyyy-MM-dd") + "]</div></div>";
            //title += "<div class=\"erjiye_list\"><div class=\"list_pic\"><div class=\"list_pic1\"></div></div><div class=\"erjiye_list1\">";
            //title += list.Url + Mystring.lim_withoutPoint(list.Title, 37) + "</a></div><div class=\"erjiye_list2\">[" + list.Datee.ToString("yyyy-MM-dd") + "]</div></div>";
            if(list.Url != "0")
            {
                title += "<div class=\"erjiye_list\"><div class=\"list_pic\"><div class=\"list_pic1\"></div></div><div class=\"erjiye_list1\"><a href=\"" +list.Url + "\" style=\"font-size:14px; color:#D22028;\" target=\"_blank\">" + Mystring.lim_withoutPoint(list.Title, 37) + "</a></div><div class=\"erjiye_list2\">[" + list.Datee.ToString("yyyy-MM-dd") + "]</div></div>";
            }
            else
            {
                title += "<div class=\"erjiye_list\"><div class=\"list_pic\"><div class=\"list_pic1\"></div></div><div class=\"erjiye_list1\"><a href=\"" + list.Id + ".html\" style=\"font-size:14px; color:#D22028;\" target=\"_blank\">" + Mystring.lim_withoutPoint(list.Title, 37) + "</a></div><div class=\"erjiye_list2\">[" + list.Datee.ToString("yyyy-MM-dd") + "]</div></div>";
            }
            if (i % 5 == 0)
            {
                title += "</div>";
            }
            if (i % tiaoshu == 0)
            {
                text = bymake_html1(title, tiaoshu, (int)pagecount, pag, ztid, zt);
                pag++;
                //i = 0;
                title = "";
            }
            i++;
        }
        if ((i > tiaoshu) && (i % tiaoshu != 0))
        {
            if (i % 5 != 1)
            {
                title += "</div>";
            }
            text = bymake_html1(title, tiaoshu, (int)pagecount, pag, ztid, zt);
        }
        else if (i <= tiaoshu)
        {
            if (i % 5 != 1)
            {
                title += "</div>";
            }
            text = bymake_html1(title, tiaoshu, (int)pagecount, pag, ztid, zt);
        }
        return text;
    }

    //2013社会实践专题二级页
    public static string bylist2013shsj(IList<Lgwin.Model.Content> lists, int ztid, int zt, int allcount, int tiaoshu, int zishu)
    {
        string text = "";
        string title = "";
        decimal temp = (decimal)allcount / tiaoshu;
        decimal pagecount = Math.Ceiling(temp);//存在小数进一
        int count = 0;
        int pag = 1;
        int i = 1;

        foreach (Lgwin.Model.Content list in lists)
        {
            if (i % 5 == 1)
            {
                title += "<div class=\"list\">";
            }
            title += "<div class=\"S_list\"><div class=\"S_title_logo\"></div><div class=\"S_title\"><a href=\"" + list.Id + ".html\"  title=\"" + list.Title + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(list.Title, 32) + "</a></div><div class=\"S_date\">[" + list.Datee.ToString("yyyy-MM-dd") + "]</div></div>";
            if (i % 5 == 0)
            {
                title += "</div>";
            }
            if (i % tiaoshu == 0)
            {
                text = bymake_html1(title, tiaoshu, (int)pagecount, pag, ztid, zt);
                pag++;
                //i = 0;
                title = "";
            }
            i++;
        }
        if ((i > tiaoshu) && (i % tiaoshu != 0))
        {
            if (i % 5 != 1)
            {
                title += "</div>";
            }
            text = bymake_html1(title, tiaoshu, (int)pagecount, pag, ztid, zt);
        }
        else if (i <= tiaoshu)
        {
            if (i % 5 != 1)
            {
                title += "</div>";
            }
            text = bymake_html1(title, tiaoshu, (int)pagecount, pag, ztid, zt);
        }
        return text;
    }
    /// <summary>
    /// 2013毕业季二级页静态化一
    /// </summary>
    /// <param name="lists"></param>
    /// <param name="ztid"></param>
    /// <param name="zt"></param>
    /// <param name="allcount"></param>
    /// <param name="tiaoshu"></param>
    /// <param name="zishu"></param>
    /// <returns></returns>

    /// 2013毕业季二级页静态化二
    public static string bylist2013byj(IList<Lgwin.Model.Content> lists, int ztid, int zt, int allcount, int tiaoshu, int zishu)
    {
        string text = "";
        string title = "";
        Regex r = new Regex(@"\s+");
        System.Text.StringBuilder strb = new System.Text.StringBuilder();
        decimal temp = (decimal)allcount / tiaoshu;
        decimal pagecount = Math.Ceiling(temp);//存在小数进一
        int count = 0;

        int pag = 1;
        int i = 1;
 
        foreach (Lgwin.Model.Content list in lists)
        {
            if (i % 5 == 1)
            {
                title += "<div class=\"list\">";
            }
            title += "<div class=\"article\"><div class=\"article1\"><a href=\"" + list.Id + ".html\" title=\"" + list.Title + "\" target=\"_blank\"><img width=\"124px\" height=\"106px\" src=\"http://lgwindow.sdut.edu.cn" + list.Tel + "\" /></a></div><div class=\"article2\"><div class=\"article2_1\"><a href=\"" + list.Id + ".html\" title=\"" + Mystring.lim_withoutPoint(list.Title, 25) + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(list.Title, 25) + "</a></div><div class=\"article2_21\">作者 ：" + list.Author + "</div><div class=\"article2_22\">发布于" + list.Datee.ToString("yyyy-MM-dd") + "</div><div class=\"article2_3\"><a href=\"" + list.Id + ".html\" title=\"" + Mystring.lim_withoutPointNo(Mystring.DelHTML(list.Contents), 98) + "\" target=\"_blank\">" + Mystring.lim_withoutPointNo("　　" + r.Replace(Mystring.DelHTML(list.Contents).Trim(), ""), 98) + "</a>　<a href=\"" + list.Id + ".html\" style=\"color:#bb1f1f; font-weight:bold;\" target=\"_blank\">【详细】</a></div></div><div class=\"article3\">" + list.Counter + "</div></div>";
            if (i % 5 == 0)
            {
                title += "</div>";
            }
            if (i % tiaoshu == 0)
            {
                text = bymake_html1(title, tiaoshu, (int)pagecount, pag, ztid, zt);
                pag++;

                title = "";
            }
            i++;
        }
        if ((i > tiaoshu) && (i % tiaoshu != 0))
        {
            if (i % 5 != 1)
            {
                title += "</div>";
            }
            text = bymake_html1(title, tiaoshu, (int)pagecount, pag, ztid, zt);
        }
        else if (i <= tiaoshu)
        {
            if (i % 5 != 1)
            {
                title += "</div>";
            }
            text = bymake_html1(title, tiaoshu, (int)pagecount, pag, ztid, zt);
        }
        return text;
    }
    /// <summary>
    /// 2013毕业季二级页静态化二
    /// </summary>
    /// <param name="lists"></param>
    /// <param name="ztid"></param>
    /// <param name="zt"></param>
    /// <param name="allcount"></param>
    /// <param name="tiaoshu"></param>
    /// <param name="zishu"></param>
    /// <returns></returns>
    
    public static string bylist2013byj12(IList<Lgwin.Model.Content> lists, int ztid, int zt, int allcount, int tiaoshu, int zishu)
    {
        string text = "";
        string title = "";
        Regex r = new Regex(@"\s+");
        System.Text.StringBuilder strb = new System.Text.StringBuilder();
        decimal temp = (decimal)allcount / tiaoshu;
        decimal pagecount = Math.Ceiling(temp);//存在小数进一
        int count = 0;
        int pag = 1;
        int i = 1;

        foreach (Lgwin.Model.Content list in lists)
        {

            if (i % 5 == 1)
            {
                title += "<div class=\"list\">";
            }
            
            title += "<div class=\"article_2ed12\"><div class=\"article2\"><div class=\"article2_1\"><a href=\"" + list.Id + ".html\" title=\"" + Mystring.lim_withoutPoint(list.Title, 25) + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(list.Title, 25) + "</a></div><div class=\"article2_21\">作者 ：" + list.Author + "</div><div class=\"article2_22\">发布于" + list.Datee.ToString("yyyy-MM-dd") + "</div><div class=\"article2_3\"><a href=\"" + list.Id + ".html\" title=\"" + Mystring.lim_withoutPointNo("　　" + r.Replace(Mystring.DelHTML(list.Contents).Trim(), ""), 98) + "\" target=\"_blank\">" + Mystring.lim_withoutPointNo("　　" + r.Replace(Mystring.DelHTML(list.Contents).Trim(), ""), 98) + "</a>　<a href=\"" + list.Id + ".html\" style=\"color:#bb1f1f; font-weight:bold;\" target=\"_blank\">【详细】</a></div></div><div class=\"article3\">" + list.Counter + "</div></div>";
            if (i % 5 == 0)
            {
                title += "</div>";
            }
            if (i % tiaoshu == 0)
            {
                text = bymake_html_2013biyeji12(title, tiaoshu, (int)pagecount, pag, ztid, zt);
                pag++;

                title = "";
            }
            i++;
        }
        
        if ((i > tiaoshu) && (i % tiaoshu != 0))
        {
            if (i % 5 != 1)
            {
                title += "</div>";
            }
            text = bymake_html_2013biyeji12(title, tiaoshu, (int)pagecount, pag, ztid, zt);
        }
        else if (i <= tiaoshu)
        {
            if (i % 5 != 1)
            {
                title += "</div>";
            }
            text = bymake_html_2013biyeji12(title, tiaoshu, (int)pagecount, pag, ztid, zt);
        }
        return text;
    }
  




    /// 2013迎新二级页静态化一

    public static string bylist2013yingxin1(IList<Lgwin.Model.Content> lists, int ztid, int zt, int allcount, int tiaoshu, int zishu)
    {
        string text = "";
        string title = "";
        Regex r = new Regex(@"\s+");
        System.Text.StringBuilder strb = new System.Text.StringBuilder();
        decimal temp = (decimal)allcount / tiaoshu;
        decimal pagecount = Math.Ceiling(temp);//存在小数进一
        int count = 0;
        int pag = 1;
        int i = 1;

        foreach (Lgwin.Model.Content list in lists)
        {

            if (i % 5 == 1)
            {
                title += "<div class=\"list\">";
            }
            title += "<div id=\"dxlist\"><div id=\"dxpic\"><img width=\"100px\" height=\"90px\" src=\"" + "http://lgwindow.sdut.edu.cn/" + myRegular.pic_Src_Top1(list.Contents).Replace("src=\"/", "") + "  /></div><div id=\"dxtc\"><div id=\"dxtitle\"><a href=\"" + list.Id + ".html\" target=\"_blank\">" + Mystring.lim_withoutPoint(list.Title, 20) + "</a></div><div id=\"dxcontent\">" + Mystring.lim_withoutPointNo("　　" + r.Replace(Mystring.DelHTML(list.Contents).Trim(), ""), 100) + "......<a href=\"" + list.Id + ".html\" target=\"_blank\" style=\"color:#3486c5;\">【详细】</a></div></div></div>";
            if (i % 5 == 0)
            {
                title += "</div>";
            }
            if (i % tiaoshu == 0)
            {
                text = bymake_2013yingxin1(title, tiaoshu, (int)pagecount, pag, ztid, zt);
                pag++;

                title = "";
            }
            i++;
        }

        if ((i > tiaoshu) && (i % tiaoshu != 0))
        {
            if (i % 5 != 1)
            {
                title += "</div>";
            }
            text = bymake_2013yingxin1(title, tiaoshu, (int)pagecount, pag, ztid, zt);
        }
        else if (i <= tiaoshu)
        {
            if (i % 5 != 1)
            {
                title += "</div>";
            }
            text = bymake_2013yingxin1(title, tiaoshu, (int)pagecount, pag, ztid, zt);
        }
        return text;
    }
    /// 2013迎新二级页静态化二

    public static string bylist2013yingxin2(IList<Lgwin.Model.Content> lists, int ztid, int zt, int allcount, int tiaoshu, int zishu)
    {
        string text = "";
        string title = "";
        Regex r = new Regex(@"\s+");
        System.Text.StringBuilder strb = new System.Text.StringBuilder();
        decimal temp = (decimal)allcount / tiaoshu;
        decimal pagecount = Math.Ceiling(temp);//存在小数进一
        int count = 0;
        int pag = 1;
        int i = 1;

        foreach (Lgwin.Model.Content list in lists)
        {

            if (i % 5 == 1)
            {
                title += "<div class=\"list\">";
            }
            title += "<div class=\"tzlist\"><div class=\"tztime\"><div class=\"tzxq\"><font>" + list.Datee.ToString("dddd") + "</font></div><div class=\"tzri\"><font>" + list.Datee.ToString("MM-dd") + "</font></div></div><div class=\"tztitle\"><div class=\"tztt\"><a href=\"" + list.Id + ".html\" target=\"_blank\">" + Mystring.lim_withoutPoint(list.Title, 20) + "</a></div><div class=\"tzcc\">" + Mystring.lim_withoutPointNo("　　" + r.Replace(Mystring.DelHTML(list.Contents).Trim(), ""), 67) + "......<a href=\"" + list.Id + ".html\" target=\"_blank\" style=\"color:#3486c5;\">【详细】</a></div></div></div>";
            if (i % 5 == 0)
            {
                title += "</div>";
            }
            if (i % tiaoshu == 0)
            {
                text = bymake_2013yingxin2(title, tiaoshu, (int)pagecount, pag, ztid, zt);
                pag++;

                title = "";
            }
            i++;
        }

        if ((i > tiaoshu) && (i % tiaoshu != 0))
        {
            if (i % 5 != 1)
            {
                title += "</div>";
            }
            text = bymake_2013yingxin2(title, tiaoshu, (int)pagecount, pag, ztid, zt);
        }
        else if (i <= tiaoshu)
        {
            if (i % 5 != 1)
            {
                title += "</div>";
            }
            text = bymake_2013yingxin2(title, tiaoshu, (int)pagecount, pag, ztid, zt);
        }
        return text;
    }
   
    /// <summary>
    /// 分页导航，下面的链接
    /// </summary>
    /// <param name="zong">总页数</param>
    /// <param name="dangqian">当前页</param>
    /// <param name="ztid">栏目Id</param>
    /// <param name="tiaoshu">每页条数</param>
    /// <returns></returns>
    public static string pager(int zong, int dangqian, int ztid, int tiaoshu)
    {
        string result = "", st = "", en = "", mid = "", other = "";
        if (dangqian == 1)
        {
            st = "共" + zong + "页/每页" + tiaoshu + "条-<a href=\"" + ztid + "_1.html\" target=\"_self\"> 首页 </a> ";
        }
        else
        {
            st = "共" + zong + "页/每页" + tiaoshu + "条-<a href=\"" + ztid + "_1.html\" target=\"_self\"> 首页 </a>-<a href=\"" + ztid + "_" + (dangqian - 1) + ".html\" target=\"_self\"> 上一页 </a>";
        }
        if (dangqian == zong)
        {
            en = "<a href=\"" + ztid + "_" + zong + ".html\" target=\"_self\">末页</a>";
        }
        else
        {
            en = "<a href=\"" + ztid + "_" + (dangqian + 1) + ".html\" target=\"_self\"> 下一页 </a>-<a href=\"" + ztid + "_" + zong + ".html\" target=\"_self\"> 末页 </a>";

        }
        if (zong <= 16)
        {  //无。。。。。。。
            for (int i = 1; i <= zong; i++)
            {
                if (i == dangqian)
                    other = "<font style=\"color:#FF0000\">" + i + "</font> ";
                else
                    other = "<a href=\"" + ztid + "_" + i + ".html\" target=\"_self\">" + i + "</a> ";
                mid += other;
            }
            result = st + mid + en;
        }
        else  //有。。。。。
        {
            //。。。前几页
            int p = dangqian - 8, stno = 1, enno = 1;
            if (p < 2)
            {
                //pre10 = "";
                stno = 1;
            }
            else
            {
                //pre10 = "<a href=\"" + ztid + "_" + p + ".html\" target=\"_self\">...</a> ";
                stno = p + 1;
            }
            //循环结束页码
            enno = stno + 14;
            if (enno > zong)
            {
                enno = zong;
                stno = zong - 14;
            }
            //。。。后几页
            //int n = dangqian + 8;
            //if (n < zong)
            //    next10 = "<a href=\"" + ztid + "_" + n + ".html\" target=\"_self\">...</a> ";
            //else
            //    next10 = "";


            for (int i = stno; i <= enno; i++)
            {
                if (i == dangqian)
                    other = "<font style=\"color:#FF0000\">" + i + "</font> ";
                else
                    other = "<a href=\"" + ztid + "_" + i + ".html\" target=\"_self\">" + i + "</a> ";
                mid += other;
            }
            result = st + mid + en;
        }
        return result;
    }
    /// <summary>
    /// 写二级页
    /// </summary>
    /// <param name="titles">标题列表</param>
    /// <param name="page">当前第几页</param>
    /// <param name="Tzong">总页数</param>
    /// <param name="topic">所属专题id</param>
    /// <param name="ztid">所属栏目Id</param>
    /// <returns></returns>
    public static string make_html(string titles, int page, int Tzong, int zt, int ztid, int tiaoshu)  //单页全文内容
    {
        string rts = "";
        string nrr = "";
        ZtBLL bll = new ZtBLL();
        Zt ztmod = bll.GetZtById(zt);

        ZtCaptionBLL capbll = new ZtCaptionBLL();
        ZtCaption capmod = capbll.GetZtCaption(ztid);

        nrr = list_text(ztmod.ZtJiancheng);
        if (ztmod.ZtJiancheng == "xytx" || ztmod.ZtJiancheng == "yxsz" || ztmod.ZtJiancheng == "Qxkarat")//十周年站庆-相约同行静态化
        {

            nrr = nrr.Replace("%%capname%%", capmod.ZtCaptionName);
            nrr = nrr.Replace("%%leftcontent%%", titles);
            nrr = nrr.Replace("%%pager%%", pager(Tzong, page, ztid, tiaoshu));
            try
            {
                Myfile.File_Write(HttpContext.Current.Server.MapPath("~") + "/topic/" + ztmod.ZtJiancheng + "/news/" + ztid + "_" + page + ".html", nrr);
                rts += "第" + page + "页生成成功\n";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        else
        {
            nrr = nrr.Replace("%%capname%%", capmod.ZtCaptionName);
            nrr = nrr.Replace("%%titles%%", titles);
            nrr = nrr.Replace("%%pager%%", pager(Tzong, page, ztid, tiaoshu));
            try
            {
                Myfile.File_Write(HttpContext.Current.Server.MapPath("~") + "/topic/" + ztmod.ZtJiancheng + "/" + ztid + "_" + page + ".html", nrr);
                rts += "第" + page + "页生成成功\n";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        return rts;
    }
    public static string bymake_html(string title, int tiaoshu, int pagecount, int pag, int ztid, int zt)
    {
        string url = "";
        switch (ztid)
        {
            case 146:
                url = "146_1.html";
                break;
            case 147:
            case 148:
                url = "147_1.html";
                break;
            case 149:
                url = "149_1.html";
                break;
            case 150:
                url = "150_1.html";
                break;
            default:
                break;
        }
        string text = "";
        string rts = "";
        ZtBLL bll = new ZtBLL();
        Zt ztmod = bll.GetZtById(zt);
        ZtCaptionBLL capbll = new ZtCaptionBLL();
        ZtCaption capmod = capbll.GetZtCaption(ztid);
        if (ztid == 146 || ztid == 149 || ztid == 150)
        {
            text = Myfile.Read_Model(HttpContext.Current.Server.MapPath("~/topic/" + ztmod.ZtJiancheng + "/models/2nd_1.html"));
        }
        else
        {
            text = Myfile.Read_Model(HttpContext.Current.Server.MapPath("~/topic/" + ztmod.ZtJiancheng + "/models/2nd_2.model"));
        }

        text = text.Replace("%%url%%", url);
        text = text.Replace("%%capname%%", capmod.ZtCaptionName);
        text = text.Replace("%%titles%%", title);
        text = text.Replace("%%pager%%", pager((int)pagecount, pag, ztid, tiaoshu));
        //text = nav_tohtml(text);
        try
        {
            if (ztid == 147 || ztid == 148)
            {
                ztid = 147;
            }
            Myfile.File_Write(HttpContext.Current.Server.MapPath("~/topic/" + ztmod.ZtJiancheng + "/news/" + ztid + "_" + pag + ".html"), text);
            rts += "共生成" + pag + "张二级页生";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
        return rts;
    }

    //十周年站庆印象十载二级页静态化测试
    /// <summary>
    /// 十周年站庆测试
    /// </summary>
    /// <param name="title"></param>
    /// <param name="tiaoshu"></param>
    /// <param name="pagecount"></param>
    /// <param name="pag"></param>
    /// <param name="ztid"></param>
    /// <param name="zt"></param>
    /// <returns></returns>
    /// 
    public static string bymake_html2(string title, int tiaoshu, int pagecount, int pag, int ztid, int zt)
    {
        string url = "";
        switch (ztid)
        {
            case 176:
                url = "176_1.html";
                break;
        }
        string text = "";
        string rts = "";
        ZtBLL bll = new ZtBLL();
        Zt ztmod = bll.GetZtById(zt);

        ZtCaptionBLL capbll = new ZtCaptionBLL();
        ZtCaption capmod = capbll.GetZtCaption(ztid);
        text = Myfile.Read_Model(HttpContext.Current.Server.MapPath("~/topic/" + ztmod.ZtJiancheng + "/models/2nd.html"));
        text = text.Replace("%%url%%", url);
        text = text.Replace("%%capname%%", capmod.ZtCaptionName);
        text = text.Replace("%%titles%%", title);
        text = text.Replace("%%pager%%", pager((int)pagecount, pag, ztid, tiaoshu));
        //text = nav_tohtml(text);
        try
        {
            Myfile.File_Write(HttpContext.Current.Server.MapPath("~/topic/" + ztmod.ZtJiancheng + "/news/" + ztid + "_" + pag + ".html"), text);
            rts += "共生成" + pag + "张二级页生";
        }
        catch (Exception ex)
        {
            return ex.Message;
            ;
        }
        return rts;
    }

    public static string bymake_html1(string title, int tiaoshu, int pagecount, int pag, int ztid, int zt)
    {
        string url = ztid.ToString()+ "_1.html";
        switch (ztid)
        {
            case 133:
                url = "133_1.html";
                break;
            case 134:
                url = "134_1.html";
                break;
            case 135:
                url = "135_1.html";
                break;
            case 136:
                url = "136_1.html";
                break;
            case 137:
                url = "137_1.html";
                break;
        }
        string text = "";
        string rts = "";
        ZtBLL bll = new ZtBLL();
        Zt ztmod = bll.GetZtById(zt);

        ZtCaptionBLL capbll = new ZtCaptionBLL();
        ZtCaption capmod = capbll.GetZtCaption(ztid);
        text = Myfile.Read_Model(HttpContext.Current.Server.MapPath("~/topic/" + ztmod.ZtJiancheng + "/models/2nd.htm"));
        text = text.Replace("%%url%%", url);
        text = text.Replace("%%capname%%", capmod.ZtCaptionName);
        text = text.Replace("%%titles%%", title);
        text = text.Replace("%%pager%%", pager((int)pagecount, pag, ztid, tiaoshu));
        //text = nav_tohtml(text);
        try
        {
            Myfile.File_Write(HttpContext.Current.Server.MapPath("~/topic/" + ztmod.ZtJiancheng + "/news/" + ztid + "_" + pag + ".html"), text);
            rts += "共生成" + pag + "张二级页生";
        }
        catch (Exception ex)
        {
            return ex.Message;
            ;
        }
        return rts;
    }
    public static string bymake_html_2013biyeji12(string title, int tiaoshu, int pagecount, int pag, int ztid, int zt)
    {
        string url = ztid.ToString() + "_1.html";
        string text = "";
        string rts = "";
        ZtBLL bll = new ZtBLL();
        Zt ztmod = bll.GetZtById(zt);

        ZtCaptionBLL capbll = new ZtCaptionBLL();
        ZtCaption capmod = capbll.GetZtCaption(ztid);
        text = Myfile.Read_Model(HttpContext.Current.Server.MapPath("~/topic/" + ztmod.ZtJiancheng + "/models/2nd12.htm"));
        text = text.Replace("%%url%%", url);
        text = text.Replace("%%capname%%", capmod.ZtCaptionName);
        text = text.Replace("%%titles%%", title);
        text = text.Replace("%%pager%%", pager((int)pagecount, pag, ztid, tiaoshu));
        try
        {
            Myfile.File_Write(HttpContext.Current.Server.MapPath("~/topic/" + ztmod.ZtJiancheng + "/news/" + ztid + "_" + pag + ".html"), text);
            rts += "共生成" + pag + "张二级页生";
        }
        catch (Exception ex)
        {
            return ex.Message;
            ;
        }
        return rts;
    }
    public static string bymake_2013yingxin1(string title, int tiaoshu, int pagecount, int pag, int ztid, int zt)
    {
        string url = ztid.ToString() + "_1.html";
        string text = "";
        string rts = "";
        ZtBLL bll = new ZtBLL();
        Zt ztmod = bll.GetZtById(zt);

        ZtCaptionBLL capbll = new ZtCaptionBLL();
        ZtCaption capmod = capbll.GetZtCaption(ztid);
        text = Myfile.Read_Model(HttpContext.Current.Server.MapPath("~/topic/" + ztmod.ZtJiancheng + "/models/2nd-3.htm"));
        text = text.Replace("%%url%%", url);
        text = text.Replace("%%capname%%", capmod.ZtCaptionName);
        text = text.Replace("%%titles%%", title);
        text = text.Replace("%%pager%%", pager((int)pagecount, pag, ztid, tiaoshu));
        try
        {
            Myfile.File_Write(HttpContext.Current.Server.MapPath("~/topic/" + ztmod.ZtJiancheng + "/news/" + ztid + "_" + pag + ".html"), text);
            rts += "共生成" + pag + "张二级页生";
        }
        catch (Exception ex)
        {
            return ex.Message;
            ;
        }
        return rts;
    }
    public static string bymake_2013yingxin2(string title, int tiaoshu, int pagecount, int pag, int ztid, int zt)
    {
        string url = ztid.ToString() + "_1.html";
        string text = "";
        string rts = "";
        ZtBLL bll = new ZtBLL();
        Zt ztmod = bll.GetZtById(zt);

        ZtCaptionBLL capbll = new ZtCaptionBLL();
        ZtCaption capmod = capbll.GetZtCaption(ztid);
        text = Myfile.Read_Model(HttpContext.Current.Server.MapPath("~/topic/" + ztmod.ZtJiancheng + "/models/2nd-2.htm"));
        text = text.Replace("%%url%%", url);
        text = text.Replace("%%capname%%", capmod.ZtCaptionName);
        text = text.Replace("%%titles%%", title);
        text = text.Replace("%%pager%%", pager((int)pagecount, pag, ztid, tiaoshu));
        try
        {
            Myfile.File_Write(HttpContext.Current.Server.MapPath("~/topic/" + ztmod.ZtJiancheng + "/news/" + ztid + "_" + pag + ".html"), text);
            rts += "共生成" + pag + "张二级页生";
        }
        catch (Exception ex)
        {
            return ex.Message;
            ;
        }
        return rts;
    }
    
    /// 获取专题二级页模板,有专题自己的模板时用自己的，否则用视窗的列表页
    /// </summary>
    /// <param name="topic">专题简称</param>
    /// <returns></returns>
    public static string list_text(string topic)
    {
        string t = "";
        if (File.Exists(HttpContext.Current.Server.MapPath("~/topic/" + topic + "/models/2nd.html")))
            t = Myfile.Read_Model(HttpContext.Current.Server.MapPath("~/topic/" + topic + "/models/2nd.html"));
        else
        {
            t = Myfile.Read_Model(HttpContext.Current.Server.MapPath("~/Lgwin/manage/model/list_zt.model"));
        }
        return t;
    }
    public static int zheng(int x, int y)
    {
        int z = 0;
        if (x % y == 0)
        {
            z = x / y;
        }
        else
        {
            z = (int)x / y + 1;
        }
        return z;
    }
    //十周年站庆专题二级页静态方法
    public static string Tenyears(IList<Lgwin.Model.Content> lists, int ztid, int zt, int allcount, int tiaoshu, int zishu)
    {

        string text = "";
        StringBuilder sb = new StringBuilder();
        foreach (Lgwin.Model.Content mod in lists)
        {
            text = sb.AppendFormat("<div class=\"title\"> <table width=\"99%\"><tr><td width=\"6\"><img src=\"../images/logo.jpg\" width=\"6\" /></td><td width=\"550\"><span style=\"font-size:16px;color:#2b66cf;font-family:黑体\">{0}</span>&nbsp; <span style=\"font-size:14px; color:#303030; font-family:黑体\">发来贺词</span></td><td style=\"font-size:14px; color:#303030; font-family:黑体\">{1}</td></tr></table></div><div class=\"article\">{2}</div>", mod.Title, mod.Datee, mod.Contents).ToString();
        }
        return "";
    }
    public static string Tenyears(IList<Lgwin.Model.Content> lists, int titlelen, int tiaoshu, int zt, int ztid)
    {
        StringBuilder sb = new StringBuilder();
        string text = "";
        string rts = "";
        int Tzong, Tzong_no = lists.Count;
        Tzong = zheng(Tzong_no, tiaoshu);
        int i = 1;  //单页计数
        int pag = 1;  //页码

        foreach (Lgwin.Model.Content mod in lists)
        {
            if (zt == 56)
            {
                if (ztid == 173)
                {
                    text += "<div class=\"title\"><table width=\"99%\"><tr><td width=\"6\"><img src=\"../images/logo1.jpg\" width=\"6\" /></td><td width=\"550\"><span style=\"font-size:16px; color:#2b66cf;font-family:黑体\">" + mod.Fro + "</span>&nbsp; <span style=\"font-size:14px; color:#303030; font-family:黑体\">发来贺词</span></td><td style=\"font-size:14px; color:#303030; font-family:黑体\">" + mod.Datee.ToString("yyyy-MM-dd") + "</td></tr></table></div><div class=\"article\">&nbsp; " + Mystring.DelHTML(mod.Contents.ToString()).ToString() + "</div>";
                }
                else
                {
                    text += "<div class=\"title\"> <table width=\"99%\"><tr><td width=\"6\"><img src=\"../images/logo1.jpg\" width=\"6\" /></td><td width=\"550\"><span style=\"font-size:16px;color:#2b66cf;font-family:黑体\"><a href=\"" + mod.Id + ".html\" target=\"_blank\" class=\"url\">" + mod.Title + "</a></span></td><td style=\"font-size:14px; color:#303030; font-family:黑体\">" + mod.Datee.ToString("yyyy-MM-dd") + "</td></tr></table></div><div class=\"article\">" + Mystring.lim_withoutPoint(Mystring.DelHTML(mod.Contents.ToString()), 100).ToString().Trim() + "</div>";

                }
            }
            else
            {
                text += "<div class=\"title\"> <table width=\"99%\"><tr><td width=\"6\"><img src=\"../images/logo.jpg\" width=\"6\" /></td><td width=\"550\"><span style=\"font-size:16px;color:#2b66cf;font-family:黑体\"><a href=\"" + mod.Id + ".html\" target=\"_blank\" class=\"url\">" + mod.Title + "</a></span></td><td style=\"font-size:14px; color:#303030; font-family:黑体\">" + mod.Datee.ToString("yyyy-MM-dd") + "</td></tr></table></div><div class=\"article\">" + Mystring.lim_withoutPoint(Mystring.DelHTML(mod.Contents.ToString()), 100).ToString().Trim() + "</div>";
            }
            if (i == tiaoshu)
            {
                i = 1;
                try
                {
                    rts += make_html(text, pag, Tzong, zt, ztid, tiaoshu);
                }
                catch (Exception ex)
                {
                    throw ex;
                    HttpContext.Current.Response.End();
                }
                pag++;
                text = string.Empty;
            }
            else
                i++;
        }
        if (i != 1)//不满最后一页 table标签未结束
        {
            rts += make_html(text, pag, Tzong, zt, ztid, tiaoshu);
        }
        return rts;
    }

}





