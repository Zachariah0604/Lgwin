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

public partial class topic_xuefengjianshe_Default : System.Web.UI.Page
{
    private static string ConStr = System.Configuration.ConfigurationManager.AppSettings["connStr"].ToString();
    protected void Page_Load(object sender, EventArgs e)
    {
        //师者风范  学子风采  他山之石

        SqlConnection con1 = new SqlConnection(ConStr);
        string str1 = Myfile.Read_Model(Server.MapPath("~/topic/xuefengjianshe/models/three.html"));
        string strcmd1 = "select top 1 * from newscon where ztid='113' and auditing=1 and tuwen=1 order by datee desc";
        SqlCommand cmd1 = new SqlCommand(strcmd1, con1);
        con1.Open();
        SqlDataReader dr1 = cmd1.ExecuteReader();
        string src1;
        while (dr1.Read())
        {
            if (dr1["caption"].ToString() != null && dr1["caption"].ToString() != "" && dr1["content"].ToString() != null && dr1["content"].ToString() != "")
            {
                src1 = Mystring.lim_withoutPoint(6, Convert.ToString(myRegular.pic_Src_Top1(dr1["content"].ToString())), 66);
            }
            else
            {
                src1 = Mystring.lim_withoutPoint(6, Convert.ToString(myRegular.pic_Src_Top1(dr1["content"].ToString())), 66);
            }
            str1 = str1.Replace("%%pic%%", src1);

            str1 = str1.Replace("%%content%%", Mystring.lim_withoutPoint(myRegular.KillHTML(dr1["content"].ToString()),50));
            str1 = str1.Replace("%%url%%", "/topic/xuefengjianshe/news/" + dr1["id"].ToString() + ".html");
        }
        Myfile.File_Write(Server.MapPath("~/topic/xuefengjianshe/fengfan.html"), str1);
        dr1.Close();
        


        
        string str2 = Myfile.Read_Model(Server.MapPath("~/topic/xuefengjianshe/models/three.html"));
        string strcmd2 = "select top 1 * from newscon where ztid='114' and auditing=1 and tuwen=1 order by datee desc";
        SqlCommand cmd2 = new SqlCommand(strcmd2, con1);
        SqlDataReader dr2 = cmd2.ExecuteReader();
        string src2;
        while (dr2.Read())
        {
            if (dr2["caption"].ToString() != null && dr2["caption"].ToString() != "" && dr2["content"].ToString() != null && dr2["content"].ToString() != "")
            {
                src2 = Mystring.lim_withoutPoint(6, Convert.ToString(myRegular.pic_Src_Top1(dr2["content"].ToString())), 44);
            }
            else
            {
                src2 = Mystring.lim_withoutPoint(6, Convert.ToString(myRegular.pic_Src_Top1(dr2["content"].ToString())), 44);//56
            }
            str2 = str2.Replace("%%pic%%", src2);

            str2 = str2.Replace("%%content%%", Mystring.lim_withoutPoint(myRegular.KillHTML(dr2["content"].ToString()), 50));
            str2 = str2.Replace("%%url%%", "/topic/xuefengjianshe/news/" + dr2["id"].ToString() + ".html");
        }
        Myfile.File_Write(Server.MapPath("~/topic/xuefengjianshe/fengcai.html"), str2);
        dr2.Close();


        string str3 = Myfile.Read_Model(Server.MapPath("~/topic/xuefengjianshe/models/three.html"));
        string strcmd3 = "select top 1 * from newscon where ztid='115' and auditing=1 and tuwen=1 order by datee desc";
        SqlCommand cmd3 = new SqlCommand(strcmd3, con1);
        SqlDataReader dr3 = cmd3.ExecuteReader();
        string src3;
        while (dr3.Read())
        {
            if (dr3["caption"].ToString() != null && dr3["caption"].ToString() != "" && dr3["content"].ToString() != null && dr3["content"].ToString() != "")
            {
                src3 = Mystring.lim_withoutPoint(6, Convert.ToString(myRegular.pic_Src_Top1(dr3["content"].ToString())), 63);
            }
            else
            {
                src3 = Mystring.lim_withoutPoint(6, Convert.ToString(myRegular.pic_Src_Top1(dr3["content"].ToString())), 63);//56
            }
            str3 = str3.Replace("%%pic%%", src3);

            str3 = str3.Replace("%%content%%", Mystring.lim_withoutPoint(myRegular.KillHTML(dr3["content"].ToString()), 50));
            str3 = str3.Replace("%%url%%", "/topic/xuefengjianshe/news/" + dr3["id"].ToString() + ".html");
        }
        Myfile.File_Write(Server.MapPath("~/topic/xuefengjianshe/zhishi.html"), str3);
        dr3.Close();


        con1.Close();
       
        //  fengfan  fengcai zhishi



         //活动动态
       
        ////活动动态
        //SqlConnection con_1 = new SqlConnection(ConStr);
        //con_1.Open();
        //string strcmd_1 = "select * from newscon where ztid='110' and [tuwen]=1";
        //SqlCommand cmd_1 = new SqlCommand(strcmd_1, con_1);
        //SqlDataReader dr_1 = cmd_1.ExecuteReader();
        //string str_1 = Myfile.Read_Model(Server.MapPath("~/topic/xuefengjianshe/models/tupian.html"));
        //int j = 1;
        //string str_sb = "";
        //string PicPash = "";
        //string limTitle = "";
        //StringBuilder sb = new StringBuilder();
        //while (dr_1.Read())
        //{
        //    if (dr_1["caption"].ToString() != null && dr_1["caption"].ToString() != "")
        //    {
        //        PicPash = Mystring.lim_withoutPoint(6, Convert.ToString(myRegular.pic_Src_Top1(dr_1["content"].ToString())), 45);
        //    }
        //    else
        //    {
        //        PicPash = Mystring.lim_withoutPoint(6, Convert.ToString(myRegular.pic_Src_Top1(dr_1["content"].ToString())), 56);
        //    }
        //    limTitle= Mystring.lim_withoutPoint(dr_1["title"].ToString(), 22);
        //    str_1 = str_1.Replace("%%pic_" + j + "%%",PicPash);
        //    str_sb = sb.AppendFormat("<a href=\"{0}\" target=\"_blank\" title=\"{1}\"><img {2}/><span>{3}</span></a>", "/topic/xuefengjianshe/news/" + dr_1["id"].ToString() + ".html", dr_1["title"].ToString(), PicPash, limTitle).ToString();
        //    j++;
        //}
        //str_1 = str_1.Replace("%%title_pic%%", str_sb);

        //if (Myfile.File_Write(Server.MapPath("~/topic/xuefengjianshe/tupian.html"), str_1))
        //{
        //    Label1.Text = "生成首页成功，点击查看";
        //}
        //else
        //{
        //    Label1.Text = "生成首页失败！";
        //}
        //dr_1.Dispose();
        //dr_1.Close();
        //con_1.Close();
        
    }
}