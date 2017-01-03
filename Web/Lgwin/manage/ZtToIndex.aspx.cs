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
using System.Collections.Generic;
using System.IO;
using Lgwin.BLL;
using Lgwin.Model;

public partial class Lgwin_manage_ZtToIndex : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Mystring.chksess())
        {
            if (Mystring.chkPower(25, Session["User"].ToString()))
            {
                if (Session["ZtJianch"].ToString() == "scleader")
                {
                    return;
                }
                Myfile.File_Write(Server.MapPath("~/topic/" + Session["ZtJianch"].ToString() + "/index.html"), text());
                string[] configs = File.ReadAllLines(Server.MapPath("~/topic/" + Session["ZtJianch"].ToString() + "/config.txt"));
                int len = configs.GetLength(0);
                string config_0 = configs.GetValue(len - 1).ToString();
                if (config_0.IndexOf("Redirect") > -1)
                {
                    string[] d = config_0.Split(',');
                    string a = d[1];
                    Response.Redirect(d[1]);
                }
            }
        }
    }
    public string text()
    {
        IList<Lgwin.Model.Content> mods;
        int count;
        if (!File.Exists(Server.MapPath("~/topic/" + Session["ZtJianch"].ToString() + "/models/1st.html")))
        {
            Mystring.alertAndBack("请上传首页模板再生成首页！");
            return null;
        }
        else
        {
            string modelpath = Server.MapPath("~/topic/" + Session["ZtJianch"].ToString() + "/models/1st.html");
            string text = Myfile.Read_Model(modelpath);
            string[] configs = File.ReadAllLines(Server.MapPath("~/topic/" + Session["ZtJianch"].ToString() + "/config.txt"));
            int len = configs.GetLength(0);
            string[] c = null;
            string config = "";
            for (int i = 0; i < len - 2; i++)
            {
                config = configs[i];
                c = config.Split(',');                   
                if (c[0].IndexOf("Redirect") > 0)
                {
                    Response.Redirect(c[1]);
                }
                else
                {
                    if (c[0].IndexOf("pic") > 0)//图片获取
                    {
                        string where = "[ztid]=" + c[1] + " and [tuwen]=1 and [auditing]=1";
                        if (c[0] == "%%pic_all%%")//当为%%pic_all%%时获取整个专题所有栏目的图片
                            where = "[zt]='" + Session["ZtId"].ToString() + "' and [tuwen]=1 and [yaowen]=1 and [auditing]=1";
                        ContentBLL bll = new ContentBLL();
                        mods = bll.GetList(int.Parse(c[2]), 1, where, out count);

                        if (c[4] == "true")//图片下面是否显示文字
                            text = text.Replace(c[0], ToHtml.index_pic_with_content(mods));
                        else
                            text = text.Replace(c[0], ToHtml.index_pic(mods));
                        continue;

                    }

                    if (c[0] == "%%list_all%%")//所有栏目列表
                    {
                        string where2 = "[zt]='" + Session["ZtId"].ToString() + "' and [yaowen]=1 and [auditing]=1";
                        ContentBLL bll2 = new ContentBLL();
                        mods = bll2.GetList(int.Parse(c[2]), 1, where2, out count);
                        if (c[5] == "Havedate")//有日期
                        {
                            text = text.Replace(c[0], ToHtml.index_list(mods, int.Parse(c[3]), "MM-dd", int.Parse(c[6])));
                        }
                        else
                        {
                            text = text.Replace(c[0], ToHtml.index_list(mods, int.Parse(c[3]), "", int.Parse(c[6])));
                        }
                    }
                    else
                    {
                        string where3 = "[ztid]='" + c[1] + "' and [auditing]=1";
                        ContentBLL bll3 = new ContentBLL();                        
                        if (Session["ZtJianch"].ToString() == "12yingxin")
                        {
                            mods = bll3.GetList(int.Parse(c[2]), 1, where3, "id", true, out count);
                        }
                            //特色名校专题首页图片轮换
                        else if (Session["ZtJianch"].ToString() == "tesemingxiao")
                        {
                            mods = bll3.GetList(int.Parse(c[2]), 1, where3, out count);
                            text = text.Replace("%%flash%%", ToHtml.tesemingxiao(18));
                        }
                        //群众路线专题
                        else if (Session["ZtJianch"].ToString() == "people")
                        {
                            mods = bll3.GetList(int.Parse(c[2]), 1, where3, out count);
                            text = text.Replace("%%PIC1%%", ToHtml.people1(18));
                            text = text.Replace("%%PIC2%%", ToHtml.people2(18));
                        }
                            //2013迎新专题
                     else if (Session["ZtJianch"].ToString() == "13newstart")
                        {
                           mods = bll3.GetList(int.Parse(c[2]), 1, where3, out count);
                        text = text.Replace("%%ZX%%", ToHtml.YXzuixin(15,92));
                        }
                        else if (Session["ZtJianch"].ToString() == "2013biyeji")
                        {
                            mods = bll3.GetList(int.Parse(c[2]), 1, where3, "datee", true, out count);
                        }
                        else
                        {
                            mods = bll3.GetList(int.Parse(c[2]), 1, where3, out count);
                        }
                        if (c[5] == "Havedate")
                        { text = text.Replace(c[0], ToHtml.index_list(mods, int.Parse(c[3]), "MM-dd", int.Parse(c[6]))); }
                        else{
                            text = text.Replace(c[0], ToHtml.index_list(mods, int.Parse(c[3]), "", int.Parse(c[6])));
                        }
                    }
                }
            }
            return text;
            //return ztvideotohtml(text) ;
        }
    }
    public string ztvideotohtml(string text)
    {


        int count;
        VideoBLL bll = new VideoBLL();
        IList<Video1> list = bll.GetVideolist(4, 1, "Lanmu='专题视频'", "datee", true, out count);//
        int t = list.Count;
        string str = "";
        string str1 = "MM-dd";
        if (t < 1)
        {
            return text;
        }
        else
        {
            for (int i = 0; i < t; i++)
            {
                if (i == 0)
                {
                    string date = list[i].Datee.ToString();
                    str += "<div class=\"list_list1\"><table cellpadding=\"0\" cellspacing=\"0\" border=\"0\" width=\"100%\"><tr><td width=\"24\"><img src=\"images/index/index_tubiao_2.jpg\" width=\"24\" height=\"15\" /></td><td width=\"320\"><a href=\"http://lgwindow.sdut.edu.cn/Campus/News/video_index.html \"  target=\"_blank\"><span style=\"font-family: 宋体;font-size: 16px; color: #134079;\">" + Mystring.lim_withoutPoint(list[i].Title, 10) + "</span></a></td><td width=\"120\" align=\"right\">[" + list[i].Time.ToString(str1) + "]</td></tr></table></div>";
                }
                else
                {
                    str += "<div class=\"list_list1\"><table cellpadding=\"0\" cellspacing=\"0\" border=\"0\" width=\"100%\"><tr><td width=\"24\"><img src=\"images/index/index_tubiao_2.jpg\" width=\"24\" height=\"15\" /></td><td width=\"320\"><a href=\"http://lgwindow.sdut.edu.cn/Campus/News/video_" + list[i].id + ".html\"  target=\"_blank\"><span style=\"font-family: 宋体;font-size: 16px; color: #134079;\">" + Mystring.lim_withoutPoint(list[i].Title, 10) + "</span></a></td><td width=\"120\" align=\"right\">[" + list[i].Time.ToString(str1) + "]</td></tr></table></div>";
                }
            }
            text = text.Replace("%%shipin%%", str);
            text = text.Replace("%%shipinsource%%", "http://lgwindow.sdut.edu.cn" + list[0].Url);
            return text;
        }
    }
}
