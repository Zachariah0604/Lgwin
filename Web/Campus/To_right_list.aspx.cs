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

public partial class To_right_list : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string ConStr = System.Configuration.ConfigurationSettings.AppSettings["connStr"].ToString();
        SqlConnection conn = new SqlConnection(ConStr);
        SqlCommand cmd1 = new SqlCommand("select top 8 Title ,URL from article where Audited=0  order by id desc", conn);
        SqlCommand cmd2 = new SqlCommand("select top 8 Title ,URL from article where Recommend='1' and Audited=0  order by id desc", conn);
        conn.Open();
        SqlDataReader dr1 = cmd1.ExecuteReader();
        StringBuilder sb1 = new StringBuilder();
        System.Text.Encoding code = System.Text.Encoding.GetEncoding("gb2312");

        // 读取模板文件
        string temp = HttpContext.Current.Server.MapPath("model/right_list01.html");
        string path = HttpContext.Current.Server.MapPath("right_list.html"); //获取当前路径，路径请根据自身情况设定
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
        while (dr1.Read())
        {
            string title = dr1["Title"].ToString();
            string url = dr1["URL"].ToString();
            sb1.AppendFormat("<div class=\"middle_right_01\"><a href=\"Html_03/{0}\" target=\"_blank\">{1}</a></div>", url, title);
        }
        dr1.Close();
        SqlDataReader dr2 = cmd2.ExecuteReader();
        StringBuilder sb2 = new StringBuilder();
        while (dr2.Read())
        {
            string title = dr2["Title"].ToString();
            string url = dr2["URL"].ToString();
            sb2.AppendFormat("<div class=\"middle_right_01\"><a href=\"Html_03/{0}\" target=\"_blank\">{1}</a></div>", url, title);
        }
        dr2.Close();
        string listStr = str;
        listStr = listStr.Replace("%%Recent%%", sb1.ToString());
        listStr = listStr.Replace("%%Recommend%%", sb2.ToString());
        try
        {
            StreamWriter sw = new StreamWriter(path, false, code);
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
        Response.Write("<script>location='Manage.aspx'</script>");
        
    }
}
