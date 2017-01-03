using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Lgwin.BLL;
using Lgwin.Model;
using Lgwin.Pic;
using System.Collections.Generic;
using System.IO;


public partial class Lgwin_manage_Sdut_maker : System.Web.UI.Page
{
    private static string url = "http://lgwindow.sdut.edu.cn", path_model = "",path_model_new="", txt = "",txt_new, path = "", path_new="";
    ContentBLL conbll = new ContentBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Mystring.chksess())
            {
                if (Mystring.chkAdmin(Session["Admin"].ToString(), 0) || Mystring.chkPower(17, Session["User"].ToString()))
                {
                    //path = ConfigurationManager.AppSettings["sdut_path"];//目标（要生成文件）路径
                    //path_model = HttpContext.Current.Server.MapPath("model/sdut.model");//2011-09-13修改了学校首页，模板更换
                    //txt = Myfile.Read_Model(path_model);
                    //txt = txt.Replace("$$pic$$", pic());
                    //txt = txt.Replace("$$pic_content$$", pic_content());
                    //txt = txt.Replace("$$titles$$", titles());
                    //makehtml(txt, path);

                    //学校新首页2010-12-28
                    path_new = ConfigurationManager.AppSettings["sdut_path_new"];//目标（要生成文件）路径
                    path_model_new = HttpContext.Current.Server.MapPath("model/sdut_new.model");//新模板
                    txt_new = Myfile.Read_Model(path_model_new);

                    txt_new = txt_new.Replace("$$titles$$", titles_new());
                    txt_new = txt_new.Replace("$$pic$$", pic_new());
                    makehtml(txt_new, path_new);
                    Label4.Text = "生成成功！";
                }
            }
        }       
    }
   //public string pic()
   // {
   //     int count;
   //     string text = "";
   //     string[] pic=new string[5];        
   //     SuoluePic mysuolue = new SuoluePic();
   //     IList<Lgwin.Model.Content> list = conbll.GetArticles(5, 1, "[sdut]='1' and [sdutpic]='1' and [auditing]='1'", "datee", true, out count);
   //     for (int i = 0; i < list.Count; i++)
   //     {
   //         if (list.Count > 0)
   //         {
   //             if (list[i].Contents.ToString().ToLower().IndexOf("<img") >= 0)
   //             {
   //                 string pic_src = "";
   //                 pic_src = myRegular.pic_Src_Top1(list[i].Contents.ToString());
   //                 pic_src = pic_src.Replace("\"", "").Replace("src=", "");
   //                 string fileName = DateTime.Now.ToString("inex_2007")+i + ".jpg";
   //                 string Dir_path = Server.MapPath("~") + "/Uploads/sdut/";
   //                 if (!Directory.Exists(Dir_path))
   //                 {
   //                     Directory.CreateDirectory(Dir_path);
   //                 }
   //                 string yuan_path = Server.MapPath("~") + "/" + pic_src;
   //                 mysuolue.MakeThumbnail(yuan_path, Dir_path + "/" + fileName, 157, 104, "W");
   //                 pic[i] = "src='http://lgwindow.sdut.edu.cn/Uploads/sdut/" + fileName + "'";
   //             }
   //             else
   //                 pic[i] = "http://lgwindow.sdut.edu.cn/Uploads/2009/05/10/20090510071749_Marked.jpg";
   //         }
   //         else
   //             pic[i] = "http://lgwindow.sdut.edu.cn/Uploads/2009/05/10/20090510071749_Marked.jpg";
   //         string url = "http://lgwindow.sdut.edu.cn";
   //         if (list[i].Url != "0")
   //             url = list[i].Url;
   //         else
   //         {
   //             if (list[i].Zt == "" || list[i].Ztid == "" || list[i].Ztid == "0" || list[i].Zt == "0")
   //             {
   //                 url += "/News/" + list[i].Id + ".html";
   //             }
   //             else
   //             {
   //                 ZtBLL ztbll = new ZtBLL();
   //                 Zt ztmod = ztbll.GetZtById(int.Parse(list[i].Zt));
   //                 if (ztmod != null)
   //                     url += "/topic/" + ztmod.ZtJiancheng + "/news/" + list[i].Id + ".html";
   //             }
   //         }
   //         text += "<a href="+url+" target='blank' title="+list[i].Title+"><img " + pic[i] + " border='0' align='absmiddle'  height='104' width='157'></a>";
   //     }
   //     Label1.Text = text;
   //     return text;
   // }

    //public string pic_content()
    //{
    //    string text = "", content = "";
    //    int imgst, imgen,count;
    //    IList<Lgwin.Model.Content> list = conbll.GetArticles(1, 1, "[sdut]='1' and [sdutpic]='1' and [auditing]='1'", "datee", true, out count);
    //    if (list.Count>0)
    //    {
    //        content = list[0].Contents.ToString().ToLower();
    //        content = myRegular.KillHTML(content);
    //        content = content.Replace("\n", "　");
    //        text = "<table width='100%' border='0' cellspacing='0' cellpadding='0' class='t-02'><tr><td height=60 valign=top><div align=center><b><font color=d54918><a href=\"javascript:win_show('" + url + "/news/" + list[0].Id.ToString() + ".html')\" title='" + list[0].Title.ToString() + "' class='t-03'>" + Mystring.lim_withPoint(list[0].Title.ToString(), 36) + "</a></font></b></div><br/>";
    //        text += Mystring.lim_withPoint(content, 90) + "</td></tr><tr><td valign=top>";
    //        text += "<div style=\"text-align:right; padding-right:10px\"><a href=\"javascript:win_show('" + url + ToHtml.GetHtmlAdress(list[0]) + "')\" title='" + list[0].Title.ToString() + "'>[ 详情请进 ]　</a></div></td></tr></table>";
    //    }
    //    Label2.Text = text;
    //    return text;
    //}
     //<summary>
     //生成学校列表，原5条
     //</summary>
    // //<returns></returns>
    //public string titles()
    //{
    //    int count;
    //    string to_url = "";
    //    string text = "", sign = "<img src='http://www.sdut.edu.cn/image/01/news_bz.gif'/>";
    //    IList<Lgwin.Model.Content> list = conbll.GetArticles(5, 1, "sdut='1' and sdutpic <> '1' and auditing='1'", "id", true, out count);
    //    foreach(Lgwin.Model.Content mod in list)
    //    {
    //        if (mod.Url.Length > 6)
    //            to_url = mod.Url;
    //        else
    //            to_url = url + ToHtml.GetHtmlAdress(mod);
    //        text += "<font style='font-size: 9pt;'>" + sign + "</font>  <a href=javascript:win_show('" + to_url + "') title='" + mod.Title + "' class='worddext'>" + Mystring.lim_withPoint(mod.Title, 56) + "</a><font color='#ff9999' style='font-size: 10pt;'>【</font><font style='font-size: 10pt;'>" + mod.Datee.ToString("yyyy-MM-dd") + "</font><font color='#ff9999' style='font-size: 10pt;'>】</font><br>";
    //    }
    //    Label3.Text = text;
    //    return text;

    //}
    /// <summary>
    /// 新学校首页8条
    /// </summary>
    /// <returns></returns>
    public string titles_new()
    {
        int count;
        string to_url = "";
        string text = "", sign = "<img src='http://www.sdut.edu.cn/image/01/news_bz.gif'/>";
        IList<Lgwin.Model.Content> list = conbll.GetArticles(8, 1, "sdut='1'  and auditing='1'", "id", true, out count);
        foreach (Lgwin.Model.Content mod in list)
        {
            if (mod.Url.Length > 6)
                to_url = mod.Url;
            else
                to_url = url + ToHtml.GetHtmlAdress(mod);
            text += "<font style='font-size: 9pt;'>" + sign + "</font>  <a href=javascript:win_show('" + to_url + "') title='" + mod.Title + "' class='worddext'>" + Mystring.lim_withPoint(mod.Title, 34) + "</a><font color='#ff9999' style='font-size: 10pt;'>【</font><font style='font-size: 10pt;'>" + mod.Datee.ToString("yyyy-MM-dd") + "</font><font color='#ff9999' style='font-size: 10pt;'>】</font><br>";//<font color='#ff9999' style='font-size: 10pt;'>【</font><font style='font-size: 10pt;'>" + mod.Datee.ToString("yyyy-MM-dd") + "</font><font color='#ff9999' style='font-size: 10pt;'>】</font>
        }
        Label3.Text = text;
        return text;

    }
    public string pic_new()
    {
        string text = "";
        int count;
        ContentBLL bll = new ContentBLL();
        IList<Lgwin.Model.Content> list = conbll.GetArticles(8, 1, "[sdut]='1' and [sdutpic]='1' and [auditing]='1'", "datee", true, out count);
        int j = 1;
        for (int i = 1; i <= 8; i++)
        {
            if (list[i - 1].Contents.IndexOf("img") > 0)
            {
                text += "imgLink" + j + "=\"http://lgwindow.sdut.edu.cn" +ToHtml.GetHtmlAdress(list[i - 1]) + "\";";
                text += "imgUrl" + j + "=\"http://lgwindow.sdut.edu.cn/" + myRegular.pic_Src_Top1(list[i - 1].Contents).Replace("src=\"/", "") + ";";
                text += "imgtext" + j + "=\"" + Mystring.lim_withoutPoint(list[i - 1].Title, 18) + "\";";
                j++;
            }
            if (j == 6)
                continue;
        }
        return text;
    }
    /// <summary>
    /// 写HTML
    /// </summary>
    /// <param name="content">内容</param>
    /// <param name="path">存放文件路径</param>
    /// <returns></returns>
    public bool makehtml(string content, string path)
    {
        System.Text.Encoding code = System.Text.Encoding.GetEncoding("gb2312");
        StreamWriter sw = null;

        try
        {
            sw = new StreamWriter(path, false, code);
            sw.Write(content);
            sw.Flush();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
        finally
        {
            sw.Dispose();
            sw.Close();
        }
    }
}