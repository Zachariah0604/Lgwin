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
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Globalization; 
public partial class Campus_To_Html_02_To_gonggao02 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
              //#region 测试用datatable 数据集合，并插入测试数据
        string ConStr = System.Configuration.ConfigurationSettings.AppSettings["connStr"].ToString();
        SqlConnection conn = new SqlConnection(ConStr);
        SqlCommand cmd = new SqlCommand("select Title ,URL,Date from article where LanMu='公告' and Audited=0 order by Date desc", conn);
        conn.Open();
        SqlDataReader DR = cmd.ExecuteReader();
        DataTable dt = new DataTable();
        dt.Columns.Add("URL", typeof(System.String));
        dt.Columns.Add("Title", typeof(System.String));
        dt.Columns.Add("Date", typeof(System.String));
        DataRow dr = dt.NewRow();
        while (DR.Read())
        {
            dr = dt.NewRow();
            dr[0] = DR["URL"].ToString();
            dr[1] = DR["Title"].ToString();
            dr[2] = DR["Date"].ToString();
            dt.Rows.Add(dr);
        }
        DR.Close();
        conn.Close();
        int pageNum = 20;//设置每页显示几条数据
        int maxnum = dt.Rows.Count;//获取集合总数
        Response.Write("总数:" + maxnum);
        int pages = 0; //设置总页数
        int yu = maxnum % pageNum;   //取余主要是要得到要生成多少个页面
        Response.Write("取余:" + maxnum % pageNum);

        if (yu == 0)
        {
            pages = maxnum / pageNum;
        }
        else
        {
            pages = maxnum / pageNum + 1;
        }
        Response.Write("公告总页数:" + pages);
        string[] newList = new string[pages];//设置列表数组

        for (int i = 0; i < pages; i++) //给列表数组赋值
        {
            for (int o = i * pageNum; o < i * pageNum + pageNum; o++) ///
            {
                // Response.Write(i+"<br>");
                if (o > maxnum - 1)
                    break;
                newList[i] = newList[i] + "<div  class=\"middle_left_02\">" + "<div style=\"float:left; height:17px\">" + "<a href=\"" + "../Html_03/" + dt.Rows[o][0].ToString() + "\">" + dt.Rows[o][1].ToString() + "</a>" + "</div>" + "<div style=\"float:right; height:17px\">" + dt.Rows[o][2].ToString() + "</div>" + "</div>";
            }
        }

        System.Text.Encoding code = System.Text.Encoding.GetEncoding("gb2312");

        // 读取模板文件
        string temp = HttpContext.Current.Server.MapPath("..//model/xywh2.html");
        string path = HttpContext.Current.Server.MapPath("..//Html02/"); //获取当前路径，路径请根据自身情况设定
        StreamReader sr = null;
        // StreamWriter sw = null;
        string str = "";
        try
        {
            sr = new StreamReader(temp, code);
            str = sr.ReadToEnd(); // 读取文件
        }
        catch (Exception exp)
        {
            HttpContext.Current.Response.Write(exp.Message);
            HttpContext.Current.Response.End();
            sr.Close();
        }
        string[] ctr = new string[pages];//设置页码数组;
        for (int i = 0; i < pages; i++)
        {

            if (pages == 1)
            {
                ctr[i] = "<div align=\"right\" style=\"margin-top:50px; font-size:12px\">共" + Convert.ToString(pages) + "页  第" + Convert.ToString(i + 1) + "页  <a href='gonggao_list_0.html' target='_self'>首页</a> 上一页 下一页 <a href='gonggao_list_" + Convert.ToString((pages - 1)) + ".html' target='_self'>尾页</a></div>";

            }
            else if (i == 0) //显示首页时
            {
                ctr[i] = "<div align=\"right\" style=\"margin-top:50px; font-size:12px\">共" + Convert.ToString(pages) + "页  第" + Convert.ToString(i + 1) + "页  <a href='gonggao_list_0.html' target='_self'>首页</a> 上一页 <a href='gonggao_list_" + Convert.ToString(i + 1) + ".html' target='_self'>下一页</a> <a href='gonggao_list_" + Convert.ToString((pages - 1)) + ".html' target='_self'>尾页</a></div>";
            }
            else if (i == pages - 1)
            { //显示尾页时
                ctr[i] = "<div align=\"right\" style=\"margin-top:50px; font-size:12px\">共" + Convert.ToString(pages) + "页  第" + Convert.ToString(i + 1) + "页  <a href='gonggao_list_0.html' target='_self'>首页</a> <a href='gonggao_list_" + Convert.ToString(i - 1) + ".html' target='_self'>上一页</a> 下一页 <a href='gonggao_list_" + Convert.ToString((pages - 1)) + ".html' target='_self'>尾页</a></div>";

            }
            else
            {
                ctr[i] = "<div align=\"right\" style=\"margin-top:50px; font-size:12px\">共" + Convert.ToString(pages) + "页  第" + Convert.ToString(i + 1) + "页  <a href='gonggao_list_0.html'target='_self'>首页</a> <a href='gonggao_list_" + Convert.ToString(i - 1) + ".html' target='_self'>上一页</a> <a href='gonggao_list_" + Convert.ToString(i + 1) + ".html' target='_self'>下一页</a> <a href='gonggao_list_" + Convert.ToString((pages - 1)) + ".html' target='_self'>尾页</a></div>";
            }
        }
        for (int i = 0; i < pages; i++) //循环生成静态页面
        {
            string listStr = str;
            listStr = listStr.Replace("%%list%%", newList[i].ToString());
            listStr = listStr.Replace("%%page%%", ctr[i].ToString());
            listStr = listStr.Replace("%%erjiye%%", "公告");
            //listStr = listStr.Replace("%%Recent%%", sb1.ToString());
            //listStr = listStr.Replace("%%Recommend%%", sb2.ToString());
            try
            {
                StreamWriter sw = new StreamWriter(path + "/gonggao_list_" + i.ToString() + ".html", false, code);
                sw.Write(listStr);
                sw.Flush();
                sw.Close();
                sw.Dispose();
            }
            catch (Exception ex)
            {
                HttpContext.Current.Response.Write(ex.Message);
                HttpContext.Current.Response.End();
            }

        }

       Response.Write("<script>alert('页面生成完毕!')</script>");
    

    }
    }
