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

public partial class topic_xywh_Fashion_area_index3_mtv_tohtml : System.Web.UI.Page
{    
     protected static string constr = ConfigurationManager.ConnectionStrings["Fshion_areaConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
     
        SqlConnection conn = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand("select top 1 ID, title ,author,datee,url,content,editor from mtv order by ID desc", conn);
        conn.Open();
        SqlDataReader DR = cmd.ExecuteReader();
        StringBuilder sb1 = new StringBuilder();
        StringBuilder sb2 = new StringBuilder();
        StringBuilder sb3 = new StringBuilder();
        StringBuilder sb4 = new StringBuilder();
        StringBuilder sb5 = new StringBuilder();
        StringBuilder sb6 = new StringBuilder();

        while (DR.Read())
        {
            System.Text.Encoding code = System.Text.Encoding.GetEncoding("gb2312");

            // 读取模板文件
            string temp = HttpContext.Current.Server.MapPath("index3_mtv.model");

            StreamReader sr = null;
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
            string title = DR["title"].ToString();
            string date = DR["datee"].ToString();
            string content = DR["content"].ToString();
            string author = DR["author"].ToString();
            string editor = DR["editor"].ToString();
            string Url = DR["url"].ToString();
            string url = Url.ToString();
            sb1.AppendFormat("{0}", title);
            sb2.AppendFormat("{0}", url);
            sb3.AppendFormat("{0}", date);
            sb4.AppendFormat("{0}", content);
            sb5.AppendFormat("{0}", author);
            sb6.AppendFormat("{0}", editor);

            string listStr = str;
            listStr = listStr.Replace("%%title%%", sb1.ToString());
            listStr = listStr.Replace("%%url%%", sb2.ToString());
            listStr = listStr.Replace("%%datee%%", sb3.ToString());
            listStr = listStr.Replace("%%content%%", sb4.ToString());
            listStr = listStr.Replace("%%author%%", sb5.ToString());
            listStr = listStr.Replace("%%editor%%", sb6.ToString());
            string path = HttpContext.Current.Server.MapPath("Html_03/") + ID.ToString(); //获取当前路径，路径请根据自身情况设定
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
        }
        DR.Close();
      
    }
}
