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
using Lgwin.Pic;
//using Web.App_Code;

/// <summary>
///Karat_ToIndex 卡瑞特  一级、二级页面静态化方法类
///以下为2014年3月第一次改版后的代码
/// </summary>
public class Karat_ToIndex
{

    public static void indextohtml()
    {
        #region 首页静态化

        string contents = "";
        contents = Myfile.Read_Model(HttpContext.Current.Server.MapPath("model/index.model"), "GB2312");
        contents = contents.Replace("%%img_lunhuan%%", karatindex_list2("团队动态", 6, 18, 11, 1, "IndexComment='true'"));//第四个参数为switch参数
        contents = contents.Replace("%%zuopinzhanshi0%%", karatindex_list3("", 1, 18, 3, 1, "id>0"));//第五个参数为数据库排序方式 0为升序  非0降序
        contents = contents.Replace("%%zuopinzhanshi1%%", karatindex_list3("", 7, 9, 10, 1, "id>0"));
        contents = contents.Replace("%%tuanduiwenhua%%", karatindex_list2("团队文化", 4, 500, 2, 1, "Title='团队文化'"));
        contents = contents.Replace("%%tuanduidongtai%%", karatindex_list2("团队动态", 8, 20, 1, 1, "IndexComment='true'"));
        contents = contents.Replace("%%karat_xinyu%%", karatindex_list("卡瑞特心语", 7, 11, "", 1));
        contents = contents.Replace("%%tuanduione%%", dontaionekaratindex_list("团队动态", 1, 100, "", 1));
        contents = contents.Replace("%%xinyuone%%", xinyuonekaratindex_list("卡瑞特心语", 1, 100, "", 1));
        Myfile.File_Write(HttpContext.Current.Server.MapPath("../../karat/index.html"), contents);

        #endregion
    }

    

    public static void tuanduidongtai()
    {
        #region karat团队动态


        string contents = "";
        string[] str = { };
        int pagetiaoshu = 6;//每一页显示条数
        str = dongtailist("pass='True'", "团队动态",12, pagetiaoshu, 200, "Karat_Content");//第三个为每条title的字数，第五个参数为取N条
        int count = dongtaicount(200);
        int totalpageno = ToHtml.zheng(count, pagetiaoshu);
        if (count <= pagetiaoshu)
        {
            contents = Myfile.Read_Model(HttpContext.Current.Server.MapPath("model/karat_dongtai.model"), "GB2312");
            contents = contents.Replace("%%Dongtai_list_rows%%", str[0]);
            contents = contents.Replace("%%dangqian%%", "1");
            contents = contents.Replace("%%zonggong%%", "1");
            contents = contents.Replace("%%shouye%%", "#");
            contents = contents.Replace("%%qianyeyi%%", "#");
            contents = contents.Replace("%%xiayiye%%", "#");
            contents = contents.Replace("%%weiye%%", "#");
            Myfile.File_Write(HttpContext.Current.Server.MapPath("../karat_dongtai/karat_dongtai_2nd/karat_dongtai_00.html"), contents);
        }
        else
        {
            for (int i = 0; i < totalpageno; i++)
            {
                contents = Myfile.Read_Model(HttpContext.Current.Server.MapPath("model/karat_dongtai.model"), "GB2312");
                contents = contents.Replace("%%Dongtai_list_rows%%", str[i]);
                contents = contents.Replace("%%dangqian%%", (i + 1).ToString());
                contents = contents.Replace("%%zonggong%%", totalpageno.ToString());
                contents = contents.Replace("%%shouye%%", "karat_dongtai_00.html");
                if (i == 0)
                {
                    contents = contents.Replace("%%qianyeyi%%", "karat_dongtai_0" + i + ".html");
                }
                else
                { 
                    contents = contents.Replace("%%qianyeyi%%", "karat_dongtai_0" + (i - 1) + ".html");
                }

                if (i == (totalpageno - 1))
                {
                    contents = contents.Replace("%%xiayiye%%", "karat_dongtai_0" + (i) + ".html");
                }
                else
                { contents = contents.Replace("%%xiayiye%%", "karat_dongtai_0" + (i + 1) + ".html"); }

                contents = contents.Replace("%%weiye%%", "karat_dongtai_0" + (totalpageno - 1) + ".html");
                Myfile.File_Write(HttpContext.Current.Server.MapPath("../karat_dongtai/karat_dongtai_2nd/karat_dongtai_0" + i + ".html"), contents);
            }
        }



        #endregion
    }

    public static void tuanduidongtai_03tohtml()
    {
        #region 团队动态三级页静态化

        string rst = tuanduidongtaicontent_03tohtml();
        //Response.Write(rst);
        #endregion
    }

    public static void karatxinyu()
    {
        #region karat心语静态化


        //lgwin/manage/ToIndexHtml.aspx.cs参照
        string contents = "";
        string[] str = { };
        int pagetiaoshu = 6;//每一页显示条数
        str = karatxinyulist("pass='True'", "卡瑞特心语", 12, pagetiaoshu, 200, "Karat_Content");//第三个为每条title的字数，第五个参数为取N条
        int count = xinyucount(200);
        int totalpageno = ToHtml.zheng(count, pagetiaoshu);
        if (count <= pagetiaoshu)
        {
            contents = Myfile.Read_Model(HttpContext.Current.Server.MapPath("model/karat_heart.model"), "GB2312");
            contents = contents.Replace("%%Heart_list_rows%%", str[0]);
            contents = contents.Replace("%%dangqian%%", "1");
            contents = contents.Replace("%%zonggong%%", "1");
            contents = contents.Replace("%%shouye%%", "#");
            contents = contents.Replace("%%qianyeyi%%", "#");
            contents = contents.Replace("%%xiayiye%%", "#");
            contents = contents.Replace("%%weiye%%", "#");
            Myfile.File_Write(HttpContext.Current.Server.MapPath("../karat_heart/karat_heart_2nd/karat_heart_00.html"), contents);
        }
        else
        {
            for (int i = 0; i < totalpageno; i++)
            {
                contents = Myfile.Read_Model(HttpContext.Current.Server.MapPath("model/karat_heart.model"), "GB2312");
                contents = contents.Replace("%%Heart_list_rows%%", str[i]);
                contents = contents.Replace("%%dangqian%%", (i + 1).ToString());
                contents = contents.Replace("%%zonggong%%", totalpageno.ToString());
                contents = contents.Replace("%%shouye%%", "karat_heart_00.html");
                if (i == 0)
                {
                    contents = contents.Replace("%%qianyeyi%%", "karat_heart_0" + i + ".html");
                }
                else
                { contents = contents.Replace("%%qianyeyi%%", "karat_heart_0" + (i - 1) + ".html"); }

                if (i == (totalpageno - 1))
                {
                    contents = contents.Replace("%%xiayiye%%", "karat_heart_0" + (i) + ".html");
                }
                else
                { contents = contents.Replace("%%xiayiye%%", "karat_heart_0" + (i + 1) + ".html"); }

                contents = contents.Replace("%%weiye%%", "karat_heart_0" + (totalpageno - 1) + ".html");
                Myfile.File_Write(HttpContext.Current.Server.MapPath("../karat_heart/karat_heart_2nd/karat_heart_0" + i + ".html"), contents);
            }
        }


        //Response.Write("卡瑞特心语页生成成功！");
        #endregion
    }

    public static void karatxinyu_03tohtml()
    {
        #region 卡瑞特心语三级页静态化

        string rst = karatxinyucontent_03tohtml();
        //Response.Write(rst);
        #endregion
    }

    public static void dashiji_03tohtml()
    {
        #region 大事记三级页静态化

        string rst = dashijicontent_03tohtml();
        //Response.Write(rst);
        #endregion
    }

    public static void work_showtohtml()
    {
        #region 作品展示静态化


        //lgwin/manage/ToIndexHtml.aspx.cs参照
        string contents = "";
        string[] str = { };
        str = karatworklist("id>0", "", 200, 5, 200, "Karat_Work");//第二个为每一页条数，第三个参数为取N条留言
        int count = workcount(200);
        int totalpageno = ToHtml.zheng(count, 5);
        if (count <= 5)
        {
            contents = Myfile.Read_Model(HttpContext.Current.Server.MapPath("model/work_show.model"), "GB2312");
            contents = contents.Replace("%%neirong%%", str[0]);
            contents = contents.Replace("%%dangqian%%", "1");
            contents = contents.Replace("%%zonggong%%", "1");
            contents = contents.Replace("%%shouye%%", "#");
            contents = contents.Replace("%%qianyeyi%%", "#");
            contents = contents.Replace("%%xiayiye%%", "#");
            contents = contents.Replace("%%weiye%%", "#");
            Myfile.File_Write(HttpContext.Current.Server.MapPath("../../karat/work_show/work_show_00.html"), contents);
        }
        else
        {
            for (int i = 0; i < totalpageno; i++)
            {
                contents = Myfile.Read_Model(HttpContext.Current.Server.MapPath("model/work_show.model"), "GB2312");
                contents = contents.Replace("%%neirong%%", str[i]);
                contents = contents.Replace("%%dangqian%%", (i + 1).ToString());
                contents = contents.Replace("%%zonggong%%", totalpageno.ToString());
                contents = contents.Replace("%%shouye%%", "work_show_00.html");
                if (i == 0)
                {
                    contents = contents.Replace("%%qianyeyi%%", "work_show_0" + i + ".html");
                }
                else
                { contents = contents.Replace("%%qianyeyi%%", "work_show_0" + (i - 1) + ".html"); }

                if (i == (totalpageno - 1))
                {
                    contents = contents.Replace("%%xiayiye%%", "work_show_0" + (i) + ".html");
                }
                else
                { contents = contents.Replace("%%xiayiye%%", "work_show_0" + (i + 1) + ".html"); }

                contents = contents.Replace("%%weiye%%", "work_show_0" + (totalpageno - 1) + ".html");
                Myfile.File_Write(HttpContext.Current.Server.MapPath("../../karat/work_show/work_show_0" + i + ".html"), contents);
            }
        }


        //Response.Write("作品展示页生成成功！");
        #endregion
    }

    public static void team_memberstohtml()
    {
        #region 团队成员静态化
        //lgwin/manage/ToIndexHtml.aspx.cs参照
        string contents = "";
        contents = Myfile.Read_Model(HttpContext.Current.Server.MapPath("model/team_members2.model"), "gb2312");
        contents = contents.Replace("%%zz%%", karatMembers02("", 20, 10, 1, 1, "bumen='站长' and year='2012'"));//第四个参数为switch参数
        contents = contents.Replace("%%cbb%%", karatMembers02("", 20, 20, 2, 0, "bumen='采编部' and year='2012'"));//第五个参数为数据库排序方式 0为升序  非0降序
        contents = contents.Replace("%%zhb%%", karatMembers02("", 20, 20, 2, 0, "bumen='综合部' and year='2012'"));

        string text = "";
        string text1 = "";
        string text2 = "";
        text1 = karatMembers02("", 20, 20, 2, 0, "bumen='技术部(美工)' and year='2012'");
        text2 = karatMembers02("", 20, 20, 2, 0, "bumen='技术部(程序)' and year='2012'");
        text = text1 + text2;

        contents = contents.Replace("%%jsb%%", text);

        Myfile.File_Write(HttpContext.Current.Server.MapPath("../../karat/member/team_members.html"), contents);
        #endregion
    }

    public static void team_members_tohtml2()//往届成员静态化
    {
        #region 团队成员静态化
        int i;
        for (i = 0; i < 12; i++)//前19届静态化2002-2013
        {
            int year = 2002 + i;
            string contents = "";
            contents = Myfile.Read_Model(HttpContext.Current.Server.MapPath("model/team_members2.model"), "gb2312");
            contents = contents.Replace("%%zz%%", karatMembers02("", 20, 10, 1, 1, "bumen='站长' and year='" + year + "'"));//第四个参数为switch参数
            contents = contents.Replace("%%cbb%%", karatMembers02("", 20, 20, 2, 0, "bumen='采编部' and year='" + year + "'"));//第五个参数为数据库排序方式 0为升序  非0降序
            contents = contents.Replace("%%zhb%%", karatMembers02("", 20, 20, 2, 0, "bumen='综合部' and year='" + year + "'"));

            string text = "";
            string text1 = "";
            string text2 = "";
            text1 = karatMembers02("", 20, 20, 2, 0, "bumen='技术部(美工)' and year='"+year+"'");
            text2 = karatMembers02("", 20, 20, 2, 0, "bumen='技术部(程序)' and year='"+year+"'");
            text = text1 + text2;

            contents = contents.Replace("%%jsb%%", text);

            Myfile.File_Write(HttpContext.Current.Server.MapPath("../../karat/member/" + year + ".html"), contents);
        }
        #endregion
    }

    public static void team_culturetohtml()
    {
        #region 团队文化页面静态化

        string contents = "";
        contents = Myfile.Read_Model(HttpContext.Current.Server.MapPath("model/Team_culture.model"), "GB2312");
        contents = contents.Replace("%%karat_jianjie%%", karatindex_list2("团队文化", 1, 5000, 4, 1, "Title='卡瑞特简介'"));//第四个参数为switch参数
        contents = contents.Replace("%%karat_tuanjie%%", karatindex_list2("团队文化", 1, 20, 4, 0, "Title='团结'"));//第五个参数为数据库排序方式 0为升序  非0降序
        contents = contents.Replace("%%karat_gaoxiao%%", karatindex_list2("团队文化", 1, 20, 4, 0, "Title='高效'"));
        contents = contents.Replace("%%karat_yanjin%%", karatindex_list2("团队文化", 1, 20, 4, 0, "Title='严谨'"));
        contents = contents.Replace("%%karat_huicai%%", karatindex_list2("团队文化", 1, 20, 4, 0, "Title='汇才'"));
        contents = contents.Replace("%%zhanzhang%%", karatindex_list2("团队文化", 1, 100, 4, 0, "Title='站长'"));
        contents = contents.Replace("%%caibianbu%%", karatindex_list2("团队文化", 1, 100, 4, 0, "Title='采编部'"));
        contents = contents.Replace("%%zonghebu%%", karatindex_list2("团队文化", 1, 100, 4, 0, "Title='综合部'"));
        contents = contents.Replace("%%chengxubu%%", karatindex_list2("团队文化", 1, 100, 4, 0, "Title='技术部'"));
        Myfile.File_Write(HttpContext.Current.Server.MapPath("../../karat/Team_culture.html"), contents);

        #endregion
    }

   


    #region 卡瑞特


    public static string karatindex_list(string caption, int tiaoshu, int zishu, string datestr, int order)
    {
        int count;

        string text = "";
        KaratBLL conbll = new KaratBLL();
        IList<Lgwin.Model.Karat> list = conbll.KaratGetList(caption, tiaoshu, 1, "IndexComment='true' and pass='true'", out count, order, "Karat_Content");
        for (int i = 0; i < list.Count; i++)
        {
            //if (datestr == "")
            text += "<tr><td><img src=\"images/icon.png\" width=\"9\" height=\"12\" /> " + karatGetHref(list[i], zishu, caption) + "</td></tr>";
            //else
            //    text += "err";
        }
        return text;
    }
    public static string dontaionekaratindex_list(string caption, int tiaoshu, int zishu, string datestr, int order)
    {
        int count;

        string text = "";
        KaratBLL conbll = new KaratBLL();
        IList<Lgwin.Model.Karat> list = conbll.KaratGetList(caption, tiaoshu, 1, "IndexComment='true' and pass='true'", out count, order, "Karat_Content");
        for (int i = 0; i < list.Count; i++)
        {
            //if (datestr == "")
            text += "<div class=\"smid_1_left\"><img " + myRegular.pic_Src_Top1(list[0].Content) + " width=\"184px\" height=\"132px\" border=\"0\" /></div><div class=\"smid_1_right\"><p>" + Mystring.lim_withoutPoint(list[i].Content, zishu) + "...<a href=\"karat_dongtai/karat_dongtai_3rd/" + list[i].Url + "\" target=\"_blank\">【详细】</a></p></div>";
            //else
            //    text += "err";
        }
        return text;
    }
    public static string xinyuonekaratindex_list(string caption, int tiaoshu, int zishu, string datestr, int order)
    {
        int count;

        string text = "";
        KaratBLL conbll = new KaratBLL();
        IList<Lgwin.Model.Karat> list = conbll.KaratGetList(caption, tiaoshu, 1, "IndexComment='true' and pass='true'", out count, order, "Karat_Content");
        for (int i = 0; i < list.Count; i++)
        {
            //if (datestr == "")
            text += "<div class=\"smid_1_left\"><img " + myRegular.pic_Src_Top1(list[0].Content) + " width=\"184px\" height=\"132px\" border=\"0\" /></div><div class=\"smid_1_right\"><p>" + Mystring.lim_withoutPoint(list[i].Content, zishu) + "...<a href=\"karat_heart/karat_heart_3rd/" + list[i].Url + "\" target=\"_blank\">【详细】</a></p></div>";
            //else
            //    text += "err";
        }
        return text;
    }

    public static string karatindex_list2(string caption, int tiaoshu, int zishu, int datestr, int order, string where)
    {
        int count;
        string text = "";
        KaratBLL conbll = new KaratBLL();
        string whe = "";
        if (where == "")
        {
            whe = "pass='true'";
        }
        else
            whe = where + " and " + "pass='true'";
        IList<Lgwin.Model.Karat> list = conbll.KaratGetList(caption, tiaoshu, 1, whe, out count, order, "Karat_Content");



        if (datestr == 10)
        {
            for (int i = 1; i < list.Count; i++)
            {
                text += "<div class=\"Zhuanti_List\"><div class=\"ZuanTi_List_pic\"><a href=\"" + list[i].Url + "\" target=\"_blank\"><img src=\"images/" + list[i].Imgurl + "\" alt=\"" + list[i].Title + "\" width=\"132\" height=\"82\" border=\"0\" /></a></div><div class=\"ZhuanTi_List_text\"><strong><a href=\"" + list[i].Url + "\" title=\"" + list[i].Title + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(list[i].Title, zishu) + "</a></strong></div></div>";
            }
        }
        else
        {
            if (datestr == 11)
            {
                string text1 = "";
               
                string text0 = "<li id=\"banners_1_body_1\" class=\"current\"><a href=\"karat_dongtai/karat_dongtai_3rd/" + list[0].Url + "\" target=\"_blank\"><img " + myRegular.pic_Src_Top1(list[0].Content) + " width=\"297\" height=\"195\"/></a></li>";

                for (int i = 1; i < list.Count; i++)
                {
                   
                    text1 += "<li id=\"banners_" + Convert.ToInt32(i + 1) + "_body_1\"><a href=\"karat_dongtai/karat_dongtai_3rd/" + list[i].Url + "\" target=\"_blank\"><img  " + myRegular.pic_Src_Top1(list[i].Content) + "  width=\"297\" height=\"195\"/></a></li>";

                }
                text = text0 + text1;
            }
            else
                for (int i = 0; i < list.Count; i++)
                {
                    switch (datestr)
                    {
                        case 1: text += "<div class=\"slist\"><div class=\"slistt\"><a href=\"karat_dongtai/karat_dongtai_3rd/" + list[i].Url + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(list[i].Title, zishu) + "</a></div><div class=\"slistd\">【" + list[i].Time.ToString("yyyy-MM-dd") + "】</div></div>"; break;
                        case 2: text += "&nbsp;&nbsp; " + list[i].Content + ""; break;
                        case 3: text += "<a href=\"" + list[i].Url + "\" target=\"_blank\"><img src=\"images/" + list[i].Imgurl + "\" alt=\"" + list[i].Title + "\" width=\"320\" height=\"200\" border=\"0\" /></a>"; break;
                        case 4: text += Mystring.lim_withoutPoint(list[i].Content, zishu); break;
                        case 5: text += "<tr><td><a href=\"images/" + list[i].Imgurl + "\" rel=\"clearbox[test1]\"><img src=\"images/" + list[i].Imgurl + "\" width=\"114\" height=\"138\" /></a></td><td width=\"83%\">&nbsp;</td></tr><tr><td>" + list[i].Title + "</td><td>&nbsp;</td></tr>"; break;
                        case 6: text += "<div class=\"caibian_list\"><div class=\"photo\"><a href=\"images/" + list[i].Imgurl + "\" rel=\"clearbox[test1]\"><img src=\"images/" + list[i].Imgurl + "\" width=\"114\" height=\"138\" alt=\"" + list[i].Title + "\" /></a></div><div class=\"name\">" + list[i].Title + "</div></div>"; break;
                        case 7: text += list[i].Content; break;
                    }

                }
        }
        return text;
    }

    public static string karatMembers(string caption, int tiaoshu, int zishu, int datestr, int order, string where)
    {
        int count;
        string text = "";
        KaratBLL conbll = new KaratBLL();
        IList<Lgwin.Model.Karat> list = conbll.KaratGetList(caption, tiaoshu, 1, where, out count, order, "Karat_members");
        for (int i = 0; i < list.Count; i++)
        {
            switch (datestr)
            {
                case 1: text += "<tr><td><a href=\"images/" + list[i].Beizhu + "\" rel=\"clearbox[test1]\"><img src=\"images/" + list[i].Beizhu + "\" width=\"114\" height=\"138\" /></a></td><td width=\"83%\">&nbsp;</td></tr><tr><td>" + list[i].Name + "</td><td>&nbsp;</td></tr>"; break;
                case 2: text += "<div class=\"caibian_list\"><div class=\"photo\"><a href=\"images/" + list[i].Beizhu + "\" rel=\"clearbox[test1]\"><img src=\"images/" + list[i].Beizhu + "\" width=\"114\" height=\"138\" alt=\"" + list[i].Name + "\" /></a></div><div class=\"name\">" + list[i].Name + "</div></div>"; break;
            }
        }
        return text;
    }

    public static string karatMembers02(string caption, int tiaoshu, int zishu, int datestr, int order, string where)
    {
        int count;
        string text = "";
        KaratBLL conbll = new KaratBLL();
        IList<Lgwin.Model.Karat> list = conbll.KaratGetList(caption, tiaoshu, 1, where, out count, order, "Karat_members");
        for (int i = 0; i < list.Count; i++)
        {
            switch (datestr)
            {
                case 1: text += "<tr><td><a href=\"../images/" + list[i].Beizhu + "\" rel=\"clearbox[test1]\"><img src=\"../images/" + list[i].Beizhu + "\" width=\"114\" height=\"138\" /></a></td><td width=\"83%\">&nbsp;</td></tr><tr><td>" + list[i].Name + "</td><td>&nbsp;</td></tr>"; break;
                case 2: text += "<div class=\"caibian_list\"><div class=\"photo\"><a href=\"../images/" + list[i].Beizhu + "\" rel=\"clearbox[test1]\"><img src=\"../images/" + list[i].Beizhu + "\" width=\"114\" height=\"138\" alt=\"" + list[i].Name + "\" /></a></div><div class=\"name\">" + list[i].Name + "</div></div>"; break;
            }
        }
        return text;
    }

    public static string karatindex_list3(string caption, int tiaoshu, int zishu, int datestr, int order, string where)
    {
        int count;
        string text = "";
        KaratBLL conbll = new KaratBLL();
        IList<Lgwin.Model.Karat> list = conbll.KaratGetList(caption, tiaoshu, 1, where, out count, order, "Karat_Work");
        if (datestr == 10)
        {
            for (int i = 1; i < list.Count; i++)
            {
                text += "<div class=\"Zhuanti_List\"><div class=\"ZuanTi_List_pic\"><a href=\"" + list[i].Href + "\" target=\"_blank\"><img src=\"images/" + list[i].Imgurl + "\" alt=\"" + list[i].Name + "\" width=\"132\" height=\"82\" border=\"0\" /></a></div><div class=\"ZhuanTi_List_text\"><strong><a href=\"" + list[i].Href + "\" title=\"" + list[i].Name + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(list[i].Name, zishu) + "</a></strong></div></div>";
            }
        }
        else
            for (int i = 0; i < list.Count; i++)
            {
                text += "<a href=\"" + list[i].Href + "\" target=\"_blank\"><img src=\"images/" + list[i].Imgurl + "\" alt=\"" + list[i].Name + "\" width=\"320\" height=\"200\" border=\"0\" /></a>";
            }
        return text;
    }

    public static string karatGetHref(Lgwin.Model.Karat mod, int TitleLength, string caption)
    {

        string href = "";
        if (caption == "卡瑞特心语")
        {
            href = "<a href=\"karat_heart/karat_heart_3rd/" + mod.Url + "\" title=\"" + mod.Title + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(mod.Title, TitleLength) + "</a>";

        }
        else
        {
            if (mod.Title.Trim() != "")
            {
                if (mod.Url != "0")
                {
                    href = "<a href=\"" + mod.Url + "\" title=\"" + mod.Title + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(mod.Title, TitleLength) + "</a>";
                }
                else
                {

                }
            }
        }
        return href;
    }

   

    public static string[] karat_formlist(int titlelen, int meiyiyetiaoshu, int tiaoshu)//tiaoshu为取N条留言
    {
        int count;
        int j = 0;
        KaratBLL conbll = new KaratBLL();

        IList<Lgwin.Model.Karat> list = conbll.KaratGetList("", tiaoshu, 1, "", out count, 1, "Karat_Events");
        int Tzong, Tzong_no = list.Count;
        Tzong = ToHtml.zheng(Tzong_no, meiyiyetiaoshu);
        string text = "";
        string[] titles = new string[Tzong];
        if (Tzong_no <= meiyiyetiaoshu)
        {
            for (int i = 0; i < Tzong_no; i++)
            {

                text += "<div class=\"history-date\"><ul><h2 class=\"date02\"><a href=\"#nogo\">" + list[i].From_Year + "</a></h2><li><h3>年度大事<span>发展轨迹</span></h3><dl><dt><span>" + list[i].From_Content + "</span></dt></dl></li></ul></div>";
            }
            titles[0] = text;
        }
        else
        {
            int i;
            for (i = 0; i < Tzong_no; i++)
            {

                text += "<div class=\"history-date\"><ul><h2 class=\"date02\"><a href=\"#nogo\">" + list[i].From_Year + "</a></h2><li><h3>12.12<span>2011</span></h3><dl><dt><span>" + list[i].From_Content + "</span></dt></dl></li></ul></div>";
                if ((i + 1) % meiyiyetiaoshu == 0)
                {
                    titles[j] = text;
                    text = "";
                    j++;
                }

            }
            if (i % meiyiyetiaoshu != 0)
            {
                titles[Tzong - 1] = text;
            }

        }
        return titles;
    }

    public static int karat_formcount(int tiaoshu)
    {
        int count;
        KaratBLL conbll = new KaratBLL();
        IList<Lgwin.Model.Karat> list = conbll.KaratGetList("", tiaoshu, 1, "", out count, 0, "Karat_Events");
        return count;
    }

    public static string[] karatworklist(string where, string lanmu, int titlelen, int meiyiyetiaoshu, int tiaoshu, string tablename)//tiaoshu为取N条留言
    {
        int count;
        int j = 0;
        KaratBLL conbll = new KaratBLL();
        IList<Lgwin.Model.Karat> list = conbll.KaratGetList(lanmu, tiaoshu, 1, where, out count, 1, tablename);
        int Tzong, Tzong_no = list.Count;
        Tzong = ToHtml.zheng(Tzong_no, meiyiyetiaoshu);
        string text = "";
        string[] titles = new string[Tzong];
        if (Tzong_no <= meiyiyetiaoshu)
        {
            for (int i = 0; i < Tzong_no; i++)
            {
                text += "<div id=\"wlist\"><table width=\"100%\" height=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td rowspan=\"7\"  width=\"227px\"><div id=\"wimg\"><img src=\"../images/" + list[i].Imgurl + "\" width=\"223\" height=\"153\" border=\"0\"></div></td><td rowspan=\"7\" width=\"38px\">&nbsp;</td><td><div id=\"wtitle\"><a href=\"" + list[i].Href + "\" target=\"_blank\">" + list[i].Name + "</a></div></td></tr><tr><td>&nbsp;</td></tr><tr><td>类    型：" + list[i].Type + "</td></tr><tr><td>完成时间：" + list[i].Time.ToString("yyyy-MM-dd") + "</td></tr><tr><td>建站工具：" + list[i].Tool + "</td></tr><tr><td>网址：<a href=\"" + list[i].Href + "\" title=\"" + list[i].Name + "\" target=\"_blank\">" + list[i].Href + "</a></td></tr><tr><td height=\"8px\">&nbsp;</td></tr></table></div>";
            }
            titles[0] = text;
        }
        else
        {
            int i;
            for (i = 0; i < Tzong_no; i++)
            {
                text += "<div id=\"wlist\"><table width=\"100%\" height=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td rowspan=\"7\"  width=\"227px\"><div id=\"wimg\"><img src=\"../images/" + list[i].Imgurl + "\" width=\"223\" height=\"153\" border=\"0\"></div></td><td rowspan=\"7\" width=\"38px\">&nbsp;</td><td><div id=\"wtitle\"><a href=\"" + list[i].Href + "\" target=\"_blank\">" + list[i].Name + "</a></div></td></tr><tr><td>&nbsp;</td></tr><tr><td>类    型：" + list[i].Type + "</td></tr><tr><td>完成时间：" + list[i].Time.ToString("yyyy-MM-dd") + "</td></tr><tr><td>建站工具：" + list[i].Tool + "</td></tr><tr><td>网址：<a href=\"" + list[i].Href + "\" title=\"" + list[i].Name + "\" target=\"_blank\">" + list[i].Href + "</a></td></tr><tr><td height=\"8px\">&nbsp;</td></tr></table></div>";
                if ((i + 1) % meiyiyetiaoshu == 0)
                {
                    titles[j] = text;
                    text = "";
                    j++;
                }

            }
            if (i % meiyiyetiaoshu != 0)
            {
                titles[Tzong - 1] = text;
            }
        }
        return titles;
    }

    public static int workcount(int tiaoshu)
    {
        int count;
        KaratBLL conbll = new KaratBLL();
        IList<Lgwin.Model.Karat> list = conbll.KaratGetList("", tiaoshu, 1, "id>0", out count, 1, "Karat_Work");
        return count;
    }

    public static string[] karatxinyulist(string where, string lanmu, int titlelen, int meiyiyetiaoshu, int tiaoshu, string tablename)//tiaoshu为取N条留言
    {
        int count;
        int j = 0;
        KaratBLL conbll = new KaratBLL();
        IList<Lgwin.Model.Karat> list = conbll.KaratGetList(lanmu, tiaoshu, 1, where, out count, 1, tablename);
        int Tzong, Tzong_no = list.Count;
        Tzong = ToHtml.zheng(Tzong_no, meiyiyetiaoshu);
        string text = "";
        string[] titles = new string[Tzong];
        if (Tzong_no <= meiyiyetiaoshu)
        {
            for (int i = 0; i < Tzong_no; i++)
            {
                text += "<div id=\"klist\"><table width=\"100%\" height=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td colspan=\"2\"><div id=\"ktitle\"><a href=\"../karat_heart_3rd/" + list[i].Url + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(list[i].Title, titlelen) + "</a></div></td></tr><tr><td colspan=\"2\">" + Mystring.lim_withoutPoint(list[i].Author, 4) + "&nbsp;&nbsp;&nbsp;&nbsp;" + list[i].Time.ToString("yyyy-MM-dd") + "</td></tr><tr><td colspan=\"2\">" + Mystring.lim_withoutPoint(list[i].Content, 70) + "......</td></tr><tr><td width=\"84%\">&nbsp;</td><td width=\"16%\" align=\"right\"><a href=\"../karat_heart_3rd/" + list[i].Url + "\" target=\"_blank\" >阅读全文 ></a></td></tr></table></div>";
            }
            titles[0] = text;
        }
        else
        {
            int i;
            for (i = 0; i < Tzong_no; i++)
            {
                text += "<div id=\"klist\"><table width=\"100%\" height=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td colspan=\"2\"><div id=\"ktitle\"><a href=\"../karat_heart_3rd/" + list[i].Url + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(list[i].Title, titlelen) + "</a></div></td></tr><tr><td colspan=\"2\">" + Mystring.lim_withoutPoint(list[i].Author, 4) + "&nbsp;&nbsp;&nbsp;&nbsp;" + list[i].Time.ToString("yyyy-MM-dd") + "</td></tr><tr><td colspan=\"2\">" + Mystring.lim_withoutPoint(list[i].Content, 70) + "......</td></tr><tr><td width=\"84%\">&nbsp;</td><td width=\"16%\" align=\"right\"><a href=\"../karat_heart_3rd/" + list[i].Url + "\" target=\"_blank\" >阅读全文 ></a></td></tr></table></div>";
                if ((i + 1) % meiyiyetiaoshu == 0)
                {
                    titles[j] = text;
                    text = "";
                    j++;
                }

            }
            if (i % meiyiyetiaoshu != 0)
            {
                titles[Tzong - 1] = text;
            }
        }
        return titles;
    }

    public static string[] dongtailist(string where, string lanmu, int titlelen, int meiyiyetiaoshu, int tiaoshu, string tablename)//tiaoshu为取N条留言
    {
        int count;
        int j = 0;
        KaratBLL conbll = new KaratBLL();
        IList<Lgwin.Model.Karat> list = conbll.KaratGetList(lanmu, tiaoshu, 1, where, out count, 1, tablename);
        int Tzong, Tzong_no = list.Count;
        Tzong = ToHtml.zheng(Tzong_no, meiyiyetiaoshu);
        string text = "";
        string[] titles = new string[Tzong];
        if (Tzong_no <= meiyiyetiaoshu)
        {
            for (int i = 0; i < Tzong_no; i++)
            {

                text += "<div id=\"tlist\"><table width=\"100%\" height=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td rowspan=\"7\" width=\"227px\"><div id=\"timg\"><img " + myRegular.pic_Src_Top1(list[i].Content) + " width=\"192\" height=\"127\" border=\"0\"></div></td><td rowspan=\"7\" width=\"38px\">&nbsp;</td><td height=\"20px\">&nbsp;</td></tr><tr height=\"24px\"><td><div id=\"ttitle\"><a href=\"../karat_dongtai_3rd/" + list[i].Url + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(list[i].Title, titlelen) + "</a></div></td></tr><tr height=\"20px\"><td>&nbsp;</td></tr><tr><td>" + list[i].Time.ToString("yyyy-MM-dd") + "</td></tr><tr><td>" + Mystring.lim_withoutPoint(list[i].Content, 60) + "......</td></tr><tr height=\"8px\"><td></td></tr></table></div>";
            }
            titles[0] = text;
        }
        else
        {
            int i;
            for (i = 0; i < Tzong_no; i++)
            {
                text += "<div id=\"tlist\"><table width=\"100%\" height=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td rowspan=\"7\" width=\"227px\"><div id=\"timg\"><img " + myRegular.pic_Src_Top1(list[i].Content) + " width=\"192\" height=\"127\" border=\"0\"></div></td><td rowspan=\"7\" width=\"38px\">&nbsp;</td><td height=\"20px\">&nbsp;</td></tr><tr height=\"24px\"><td><div id=\"ttitle\"><a href=\"../karat_dongtai_3rd/" + list[i].Url + "\" target=\"_blank\">" + Mystring.lim_withoutPoint(list[i].Title, titlelen) + "</a></div></td></tr><tr height=\"20px\"><td>&nbsp;</td></tr><tr><td>" + list[i].Time.ToString("yyyy-MM-dd") + "</td></tr><tr><td>" + Mystring.lim_withoutPoint(list[i].Content, 60) + "......</td></tr><tr height=\"8px\"><td></td></tr></table></div>";
                if ((i + 1) % meiyiyetiaoshu == 0)
                {
                    titles[j] = text;
                    text = "";
                    j++;
                }

            }
            if (i % meiyiyetiaoshu != 0)
            {
                titles[Tzong - 1] = text;
            }
        }
        return titles;
    }

    public static string karatxinyucontent_03tohtml()
    {
        string p = "";
        int count;
        KaratBLL conbll = new KaratBLL();
        IList<Lgwin.Model.Karat> list = conbll.KaratGetList("卡瑞特心语", 300, 1, "pass='True'", out count, 1, "Karat_Content");
        int zong = list.Count;
        string contents = "";
        for (int i = 0; i < count; i++)
        {
            contents = Myfile.Read_Model(HttpContext.Current.Server.MapPath("model/karat_heart_03.model"), "GB2312");
            contents = contents.Replace("%%xyid%%",list[i].Id.ToString());
            contents = contents.Replace("%%title%%", list[i].Title);
            contents = contents.Replace("%%author%%", list[i].Author);
            contents = contents.Replace("%%time%%", list[i].Time.ToString("yyyy-MM-dd"));
            contents = contents.Replace("%%content%%", list[i].Content);
            if (i == 0)
            {
                contents = contents.Replace("%%front_url%%", list[0].Url);
                contents = contents.Replace("%%front_title%%", "这是第一个");
            }
            else
            {
                contents = contents.Replace("%%front_url%%", list[i - 1].Url);
                contents = contents.Replace("%%front_title%%", list[i - 1].Title);
            }
            if (i == (count - 1))
            {
                contents = contents.Replace("%%back_url%%", list[count - 1].Url);
                contents = contents.Replace("%%back_title%%", "没有了");
            }
            else
            {
                contents = contents.Replace("%%back_url%%", list[i + 1].Url);
                contents = contents.Replace("%%back_title%%", list[i + 1].Title);
            }
            if (Myfile.File_Write(HttpContext.Current.Server.MapPath("../karat_heart/karat_heart_3rd/" + list[i].Url + ""), contents))
            {
                p = "卡瑞特心语三级静态页生成成功！";
            }
        }
        return p;
    }

    public static string tuanduidongtaicontent_03tohtml()
    {
        string p = "";
        int count;
        KaratBLL conbll = new KaratBLL();
        IList<Lgwin.Model.Karat> list = conbll.KaratGetList("团队动态", 300, 1, "pass='True'", out count, 1, "Karat_Content");
        int zong = list.Count;
        string contents = "";
        for (int i = 0; i < count; i++)
        {
            contents = Myfile.Read_Model(HttpContext.Current.Server.MapPath("model/karat_dongtai_03.model"), "GB2312");
            contents = contents.Replace("%%tdid%%", list[i].Id.ToString());
            contents = contents.Replace("%%title%%", list[i].Title);
            contents = contents.Replace("%%author%%", list[i].Author);
            contents = contents.Replace("%%time%%", list[i].Time.ToString("yyyy-MM-dd"));
            contents = contents.Replace("%%content%%", list[i].Content);
            if (i == 0)
            {
                contents = contents.Replace("%%front_url%%", list[0].Url);
                contents = contents.Replace("%%front_title%%", "这是第一个");
            }
            else
            {
                contents = contents.Replace("%%front_url%%", list[i - 1].Url);
                contents = contents.Replace("%%front_title%%", list[i - 1].Title);
            }
            if (i == (count - 1))
            {
                contents = contents.Replace("%%back_url%%", list[count - 1].Url);
                contents = contents.Replace("%%back_title%%", "没有了");
            }
            else
            {
                contents = contents.Replace("%%back_url%%", list[i + 1].Url);
                contents = contents.Replace("%%back_title%%", list[i + 1].Title);
            }
            if (Myfile.File_Write(HttpContext.Current.Server.MapPath("../karat_dongtai/karat_dongtai_3rd/" + list[i].Url + ""), contents))
            {
                p = "团队动态三级静态页生成成功！";

            }
        }
        return p;
    }

    public static string dashijicontent_03tohtml()
    {
        string contents = "";
        string[] str = { };
        string p = "";
        int count;
        KaratBLL conbll = new KaratBLL();
        IList<Lgwin.Model.Karat> list = conbll.KaratGetList("", 300, 1, "", out count, 1, "Karat_Events");
        str = karat_formlist(8, 13, count);
        for (int i = 0; i < count; i++)
        {
            contents = Myfile.Read_Model(HttpContext.Current.Server.MapPath("model/Karat_From.model"), "GB2312");

            contents = contents.Replace("%%left_list%%", str[0]);
            if (Myfile.File_Write(HttpContext.Current.Server.MapPath("../KaratEvent.html"), contents))
            {
                p = "大事记三级静态页生成成功！";
            }
        }
        return p;
    }

    public static int xinyucount(int tiaoshu)
    {
        int count;
        KaratBLL conbll = new KaratBLL();
        IList<Lgwin.Model.Karat> list = conbll.KaratGetList("卡瑞特心语", tiaoshu, 1, "IndexComment='True'", out count, 1, "Karat_Content");
        return count;
    }

    public static int dongtaicount(int tiaoshu)
    {
        int count;
        KaratBLL conbll = new KaratBLL();
        IList<Lgwin.Model.Karat> list = conbll.KaratGetList("团队动态", tiaoshu, 1, "IndexComment='True'", out count, 1, "Karat_Content");
        return count;
    }

    public static int messagecount(int tiaoshu)
    {
        int count;
        KaratBLL conbll = new KaratBLL();
        IList<Lgwin.Model.Karat> list = conbll.KaratGetList("", tiaoshu, 1, "pass='true'", out count, 1, "Karat_message");
        return count;
    }

    #endregion
}