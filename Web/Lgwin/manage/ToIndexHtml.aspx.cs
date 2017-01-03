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
using System.Data.SqlClient;
using System.Text;


public partial class Lgwin_manage_ToIndexHtml : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Mystring.chksess())
        {
            if (Mystring.chkPower(16, Session["User"].ToString()))
            {
                StringBuilder sb = new StringBuilder();
                string text = "";
                string sql = "select top 24 * from Photo_photo where xww=1 order by id desc";
                SqlDataReader dr = xlxy.dr(sql);
                while (dr.Read())
                {
                    if (dr["name"].ToString().Length > 9)
                    {
                        string s = dr["name"].ToString();
                        text = sb.AppendFormat("<li><a href=\"photo/{0}\" title=\"{1}\" target=\"_blank\"><img src=\"photo/admin/photo/{2}/{3}\" width=\"500\" height=\"375\" class=\"picStyle\"/></a> <a href=\"photo/{0}\" title=\"{1}\" target=\"_blank\">{4}</a></li>", dr["pagename"].ToString(), dr["name"].ToString(), dr["zhtID"].ToString(), dr["path"].ToString(),s.Substring(0, 9) + "..").ToString();
                    }
                    else
                    text = sb.AppendFormat("<li><a href=\"photo/{0}\" title=\"{1}\" target=\"_blank\"><img src=\"photo/admin/photo/{2}/{3}\" width=\"500\" height=\"375\" class=\"picStyle\"/></a> <a href=\"photo/{0}\" title=\"{1}\" target=\"_blank\">{1}</a></li>", dr["pagename"].ToString(), dr["name"].ToString(), dr["zhtID"].ToString(), dr["path"].ToString()).ToString();
                }
                dr.Close();
                StringBuilder sb1 = new StringBuilder();
                string text_xywh = "";
                string sql_xywh = "select top 9 Title,id,Datee,ToUrl from Campus_Article where LgIndex='true' and pass='true'and Lanmu<>'废稿' order by Datee desc,id desc";
                SqlDataReader dr1 = xlxy.dr(sql_xywh);
                while (dr1.Read())
                {
                    if (dr1["ToUrl"].ToString() !="0")
                    { text_xywh = sb1.AppendFormat("<tr><td class=\"NewsList\"><a href=\"{0}\" title=\"{3}\"  target=\"_blank\">{1}</a></td><td class=\"time\">[{2}]</td></tr>", dr1["ToUrl"].ToString(), Mystring.lim_withoutPoint(dr1["Title"].ToString(), 13), Mystring.lim_withoutPoint(5, dr1["Datee"].ToString(), 5), dr1["Title"].ToString()).ToString(); }
                    else{ text_xywh = sb1.AppendFormat("<tr><td class=\"NewsList\"><a href=\"Campus/News/news_{0}.html\" title=\"{3}\"  target=\"_blank\">{1}</a></td><td class=\"time\">[{2}]</td></tr>", dr1["id"].ToString(), Mystring.lim_withoutPoint(dr1["Title"].ToString(), 13), Mystring.lim_withoutPoint(5, dr1["Datee"].ToString(), 5), dr1["Title"].ToString()).ToString();}
                }

                string contents = "";
                contents = Myfile.Read_Model(HttpContext.Current.Server.MapPath("model/index.model"), "utf-8");
                contents = contents.Replace(" %%TouTiao%%", ToHtml.index_toutiao(30, 70, "MM-dd"));
                contents = contents.Replace("%%flash%%", ToHtml.index_flash(18));
                contents = contents.Replace("%%guangying%%", text);

                OptionsBLL bll0 = new OptionsBLL();
                Options modad1 = bll0.GetOptions("ad1");
                contents = contents.Replace("%%ad1%%", modad1.Nr);
                Options modad2 = bll0.GetOptions("ad2");
                contents = contents.Replace("%%ad2%%", modad2.Nr);
                Options mod0 = bll0.GetOptions("qishu");
                contents = contents.Replace("%%QISHU%%", mod0.Nr);
                Options mod1 = bll0.GetOptions("touban");
                contents = contents.Replace("%%toubanpic%%", mod1.Nr);
                Options mod2 = bll0.GetOptions("zonghe");
                contents = contents.Replace("%%zonghepic%%", mod2.Nr);
                Options mod3 = bll0.GetOptions("xiaoyuan");
                contents = contents.Replace("%%xiaoyuanpic%%", mod3.Nr);
                Options mod4 = bll0.GetOptions("fukan");
                contents = contents.Replace("%%fukanpic%%", mod4.Nr);
                Options zhuanti = bll0.GetOptions("zhuanti");
                contents = contents.Replace(" %%zhuantipic%%", zhuanti.Nr);

                contents = contents.Replace("%%touban%%", ToHtml.index_xiaobao("头版", 8, 7));
                contents = contents.Replace("%%zonghe%%", ToHtml.index_xiaobao("综合", 8, 7));
                contents = contents.Replace("%%xiaoyuan%%", ToHtml.index_xiaobao("校园", 8, 7));
                contents = contents.Replace("%%fukan%%", ToHtml.index_xiaobao("副刊", 8, 7));

                contents = contents.Replace("%%paihang%%", ToHtml.index_list("学风建设", 8, 13, ""));
                //contents = contents.Replace("%%paihang%%",ToHtml.index_paihang(7,7));
                //contents = contents.Replace("%%videosource%%",ToHtml.index_videosource(4));

                contents = contents.Replace("%%zhuantitex%%", ToHtml.index_Zhuantitex(2, 18));
                contents = contents.Replace("%%tongzhi%%", ToHtml.index_Gonggao("资讯公告", 8, " auditing=1 and zixun='true'", 30, ""));
                contents = contents.Replace("%%MeiTiLG%%", ToHtml.index_list("媒体理工", 9, 18));
                contents = contents.Replace("%%LGYaoWen%%", ToHtml.index_list("理工要闻", 13, 20, ""));
                contents = contents.Replace("%%XiaoYuanWH%%", text_xywh);
                contents = contents.Replace("%%JiaoXueKY%%", ToHtml.index_list("教学科研", 9, 18, ""));
                contents = contents.Replace("%%XueShengGZ%%", ToHtml.index_list("学生工作", 9, 13, ""));
                contents = contents.Replace("%%LGRenWu%%", ToHtml.index_list("理工人物", 8, 13, ""));
                contents = contents.Replace("%%YuanBuChZh%%", ToHtml.index_list("院部传真", 9, 18, ""));
                contents = contents.Replace("%%JiXiashp%%", ToHtml.index_list("稷下时评", 9, 15, ""));
                contents = contents.Replace("%%GaiJiaoShD%%", ToHtml.index_list("高教视点", 8, 18, ""));


                if (Myfile.File_Write(HttpContext.Current.Server.MapPath("../../index.html"), contents))
                {
                    Label1.Text = "生成首页成功！点击查看";
                }
                else
                {
                    Label1.Text = "生成首页失败！请重试";
                }
            }
        }
    }
}
