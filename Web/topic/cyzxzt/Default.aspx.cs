using System;
using System.Data;
using System.Collections;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Data.SqlClient;
using Lgwin.Model;
using Lgwin.BLL;

public partial class topic_cyzxzt_Default : System.Web.UI.Page
{
    private static string ConStr = System.Configuration.ConfigurationManager.AppSettings["connStr"].ToString();
    protected void Page_Load(object sender, EventArgs e)
    {
        //争创典型 基层创先
        
        SqlConnection con = new SqlConnection(ConStr);
        string strcmd = "select top 2 * from newscon where ztid='97' and auditing=1 order by id desc";
        SqlCommand cmd = new SqlCommand(strcmd, con);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        string str=Myfile.Read_Model(Server.MapPath("~/topic/cyzxzt/models/dianxing.html"));
        int i = 1;
        StringBuilder strsb = new StringBuilder();

        while (dr.Read())
        {
            str = str.Replace("%%title_" + i + "%%", Mystring.lim_withoutPoint(dr["title"].ToString(), 8));
            str = str.Replace("%%subtitle_" + i + "%%", Mystring.lim_withoutPoint(dr["subtitle"].ToString(), 12));
            str = str.Replace("%%content_" + i + "%%", Mystring.lim_withoutPoint(myRegular.KillHTML(dr["content"].ToString()), 91));
            str = str.Replace("%%url_" + i + "%%", "/topic/cyzxzt/news/" + dr["id"].ToString() + ".html");
            i++;
            //str = strsb.AppendFormat("<div class=\"dianxing_nr_1\"><div  class=\"margin_5_13\">基层创先</div><div class=\"padding_10_5\"><a href=\"{0}\" target=\"_blank\">{1}</a></div><div class=\"padding_10_15\"><a href=\"{0}\" target=\"_blank\">{2}</a></div><div class=\"padding_5_10\"><a href=\"{0}\" target=\"_blank\">{3}</a></div><div style=\"text-align:right; color:#640000; font-size:12px; padding-right:10px;\"><a href=\"{0}\" target=\"_blank\">更多</a></div></div></div>", "/topic/cyzxzt/news/" + dr["id"].ToString() + ".html", Mystring.lim_withoutPoint(dr["title"].ToString(), 8), Mystring.lim_withoutPoint(dr["subtitle"].ToString(), 12), Mystring.lim_withoutPoint(dr["content"].ToString(), 91)).ToString();
        }
        dr.Close();
        con.Close();

        string strcmd1 = "select top 3 * from newscon where ztid='95' and auditing=1 and tuwen=1 order by datee desc";
        SqlCommand cmd1 = new SqlCommand(strcmd1, con);
        con.Open();
        SqlDataReader dr1 = cmd1.ExecuteReader();
        int i0 = 1;
        string src_0 = "";

        while (dr1.Read())
        {

            if (dr1["caption"].ToString() != null && dr1["caption"].ToString() != "" && dr1["content"].ToString() != null && dr1["content"].ToString() != "")
            {
                //src_0 = "src=\"../../" + Mystring.lim_withoutPoint(6, Convert.ToString(myRegular.pic_Src_Top1(dr1["content"].ToString())), 42);
                src_0 =  Mystring.lim_withoutPoint(0, Convert.ToString(myRegular.pic_Src_Top1(dr1["content"].ToString())), 48);//专题首页
            }
            else
            {
                //src_0 = "src=\"../../" + Mystring.lim_withoutPoint(6, Convert.ToString(myRegular.pic_Src_Top1(dr1["content"].ToString())), 56);
                src_0 =Mystring.lim_withoutPoint(0, Convert.ToString(myRegular.pic_Src_Top1(dr1["content"].ToString())), 56);
            }
            str = str.Replace("%%dyfc_pic_" + i0 + "%%", src_0);
            str = str.Replace("%%dyfc_title_" + i0 + "%%", Mystring.lim_withoutPoint(dr1["title"].ToString(), 10));
            str = str.Replace("%%dyfc_subtitle_" + i0 + "%%", Mystring.lim_withoutPoint(dr1["subtitle"].ToString(), 12));
            str = str.Replace("%%dyfc_content_" + i0 + "%%", Mystring.lim_withoutPoint(dr1["content"].ToString(), 81));
            str = str.Replace("%%dyfc_url_" + i0 + "%%", "/topic/cyzxzt/news/" + dr1["id"].ToString() + ".html");
            i0++;
        }

        Myfile.File_Write(Server.MapPath("~/topic/cyzxzt/DianXing.html"),str);
        dr1.Close();
        con.Close();

        //活动动态
        SqlConnection con_1 = new SqlConnection(ConStr);
        con_1.Open();
        string strcmd_1 = "select * from newscon where ztid='92' and [tuwen]=1";
        SqlCommand cmd_1 = new SqlCommand(strcmd_1, con_1);
        SqlDataReader dr_1 = cmd_1.ExecuteReader();
        string str_1 = Myfile.Read_Model(Server.MapPath("~/topic/cyzxzt/models/DongTai.html"));
        int j = 1;
        string str_sb = "";
        string PicPash = "";
        string limTitle = "";
        StringBuilder sb = new StringBuilder();
        while (dr_1.Read())
        {
            if (dr_1["caption"].ToString() != null && dr_1["caption"].ToString() != "")
            {
                PicPash = "src=\"../../" + Mystring.lim_withoutPoint(6, Convert.ToString(myRegular.pic_Src_Top1(dr_1["content"].ToString())), 45);
            }
            else
            {
                PicPash = "src=\"../../" + Mystring.lim_withoutPoint(6, Convert.ToString(myRegular.pic_Src_Top1(dr_1["content"].ToString())), 56);
            }
            limTitle= Mystring.lim_withoutPoint(dr_1["title"].ToString(), 22);
            str_1 = str_1.Replace("%%pic_" + j + "%%",PicPash);
            str_sb = sb.AppendFormat("<a href=\"{0}\" target=\"_blank\" title=\"{1}\"><img {2}/><span>{3}</span></a>", "/topic/cyzxzt/news/" + dr_1["id"].ToString() + ".html", dr_1["title"].ToString(), PicPash, limTitle).ToString();
            j++;
        }
        str_1 = str_1.Replace("%%title_pic%%", str_sb);

        if (Myfile.File_Write(Server.MapPath("~/topic/cyzxzt/DongTai.html"), str_1))
        {
            Label1.Text = "生成首页成功，点击查看";
        }
        else
        {
            Label1.Text = "生成首页失败！";
        }
        dr_1.Dispose();
        dr_1.Close();
        con_1.Close();

        //最近更新
        string last = Myfile.Read_Model(Server.MapPath("~/topic/cyzxzt/models/right.html"));
        int count;
        ContentBLL bll = new ContentBLL();
        IList<Lgwin.Model.Content> list = bll.GetList(20, 1, "zt='23' and auditing = 'true'", "datee", true, out count);
        string text="";
        for (int k = 0; k < list.Count; k++)
        {
            text += "<tr><td width=\"10%\"><img src=\"images/list/right_nr.jpg\" width=\"9\" height=\"9\" /></td><td width=\"90%\"><a href=\"news/" + list[k].Id + ".html" + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(list[k].Title,14) + "</a></td></tr>";
        }
        last = last.Replace("%%last%%", text);
        Myfile.File_Write(Server.MapPath("~/topic/cyzxzt/right.html"), last);
        
    }
}