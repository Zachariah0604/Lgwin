using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Collections;
using System.Data.SqlClient;
using Lgwin.BLL;

namespace Lgwin.Old_App_Code
{
    public class P_tohtmlcs
    {
        public static void getzhtid(int i, string zht)
        {
            ArrayList Arr = new ArrayList();
            string sql33 = "Select id from Photo_lmfenlei where zhtID=" + i + " order by created_time desc";
            SqlDataReader dr33 = xlxy.dr(sql33);
            while (dr33.Read())
            {

                Arr.Add(dr33.GetValue(0));

            }

            dr33.Dispose();
            dr33.Close();

            int cnt = 0;
            StringBuilder sbd = new StringBuilder();
            string[] text = new string[1000];
            foreach (int j in Arr)
            {
                SqlDataReader dr32 = new PhotoBLL().lgbq1(i, j);
                while (dr32.Read())
                {
                    text[cnt] = "<div class=\"ul\"><ul class=\"ull\" > <li class=\"li_img\" ><a  href=\"" + dr32["pagename"].ToString() + "\" target=\"_blank\" ><img src=\"admin/photo/" + dr32["zhtID"].ToString() + "/" + dr32["path"].ToString() + "\"alt=\"" + dr32["lmname"].ToString() + "--作者:" + dr32["zuozhe"].ToString() + "--" + dr32["upload_time"].ToString() + "上传\" class=\"img_8\"/></a></li><li  class=\"li_text\"><a href=\"" + dr32["pagename"].ToString() + "\" title=\"" + dr32["lmname"].ToString() + "\"  > " + Mystring.lim_withoutPoint(dr32["lmname"].ToString(), 10).ToString() + "</a> </li></ul></div>";
                }
                dr32.Dispose();
                dr32.Close();
                cnt++;
            }
            check(zht, cnt, text, i);

        }
        public static void check(string zht, int cnt, string[] text, int i)
        {

            int talpage = 0;
            if (cnt <= 12)
            {
                string pic = "";
                for (int k = 0; k < cnt; k++)
                {
                    pic += text[k];
                }
                string ts;
                ts = Myfile.Read_Model(HttpContext.Current.Server.MapPath("~") + "/photo/admin/model/Default.model", "GB2312");
                ts = ts.Replace("%%zhtname%%", zht);
                ts = ts.Replace("%%dangqian%%", "1");
                ts = ts.Replace("：%%zonggong%%", "1");
                ts = ts.Replace("%%diyi%%", "" + i + "_0.html");
                ts = ts.Replace("%%pic%%", pic);

                if (Myfile.File_Write(HttpContext.Current.Server.MapPath("../../photo/" + i + "_0.html"), ts, "utf-8"))
                {
                    string pagename2 = i.ToString() + "_0.html";
                    xlxy.sqlNoQ("update [Photo_zhtfenlei] set [pagename]='" + pagename2 + "' where [id]='" + i + "'");
                    talpage = 1;
                }
                else
                {
                    Mystring.alert("二级页静态化失败，请重试！！！");
                }

            }
            else
            {
                int cntpage = cnt / 12;//整页数
                int p = cnt % 12;//最后余数
                if (p == 0)
                {

                    for (int n = 0; n < cntpage; n++)
                    {
                        string pic = "";

                        for (int start = n * 12; start < 12 * (n + 1); start++)
                        {

                            pic += text[start];
                        }
                        string ts;
                        ts = Myfile.Read_Model(HttpContext.Current.Server.MapPath("~") + "/photo/admin/model/Default.model", "GB2312");
                        ts = ts.Replace("%%zhtname%%", zht);
                        ts = ts.Replace("%%dangqian%%", (n + 1).ToString());
                        ts = ts.Replace("%%zonggong%%", cntpage.ToString());
                        ts = ts.Replace("%%diyi%%", "" + i + "_0.html");
                        if (n > 0)
                        {
                            ts = ts.Replace("%%qianyeyi%%", "" + i + "_" + (n - 1) + ".html");
                        }
                        if (n < cntpage - 1)
                        {
                            ts = ts.Replace("%%xiayiye%%", "" + i + "_" + (n + 1) + ".html");
                        }
                        ts = ts.Replace("%%weiye%%", "" + i + "_" + (cntpage - 1) + ".html");
                        ts = ts.Replace("%%pic%%", pic);

                        if (Myfile.File_Write(HttpContext.Current.Server.MapPath("../../photo/" + i + "_" + n + ".html"), ts, "utf-8"))
                        {
                            string pagename2 = i.ToString() + "_0.html";
                            xlxy.sqlNoQ("update [Photo_zhtfenlei] set [pagename]='" + pagename2 + "' where [id]='" + i + "'");
                            talpage = n + 1;

                        }
                        else
                        {
                            Mystring.alert("二级页静态化失败，请重试！！！");
                        }



                    }
                }
                else
                {

                    int len = text.Length;
                    for (int n = 0; n <= cntpage; n++)
                    {
                        string pic = "";

                        for (int start = 12 * n; start < 12 * (n + 1); start++)
                        {
                            pic += text[start];


                        }

                        string ts;
                        ts = Myfile.Read_Model(HttpContext.Current.Server.MapPath("~") + "/photo/admin/model/Default.model", "GB2312");
                        ts = ts.Replace("%%zhtname%%", zht);
                        ts = ts.Replace("%%dangqian%%", (n + 1).ToString());
                        ts = ts.Replace("%%zonggong%%", (cntpage + 1).ToString());
                        ts = ts.Replace("%%diyi%%", "" + i + "_0.html");
                        if (n > 0)
                        {
                            ts = ts.Replace("%%qianyeyi%%", " " + i + "_" + (n - 1) + ".html");
                        }
                        if (n < cntpage)
                        {
                            ts = ts.Replace("%%xiayiye%%", "" + i + "_" + (n + 1) + ".html");
                        }
                        ts = ts.Replace("%%weiye%%", "" + i + "_" + cntpage + ".html");
                        ts = ts.Replace("%%pic%%", pic);

                        if (Myfile.File_Write(HttpContext.Current.Server.MapPath("../../photo/" + i + "_" + n + ".html"), ts, "utf-8"))
                        {
                            string pagename2 = i.ToString() + "_0.html";
                            xlxy.sqlNoQ("update [Photo_zhtfenlei] set [pagename]='" + pagename2 + "' where [id]='" + i + "'");
                            talpage = n + 1;
                        }
                        else
                        {
                            Mystring.alert("二级页静态化失败，请重试！！！");
                        }
                    }
                }
            }

        }   
    }
}