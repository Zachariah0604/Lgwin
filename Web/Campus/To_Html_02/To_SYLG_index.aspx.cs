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

public partial class Campus_To_Html_02_To_SYLG_index : System.Web.UI.Page
{
    private static string ConStr = System.Configuration.ConfigurationSettings.AppSettings["connStr"].ToString();
    protected void Page_Load(object sender, EventArgs e)
    {
        Myfile.File_Write(Server.MapPath("../suiyueligong/2.html"), text());
        Response.Write("<script>location='To_wangshi02.aspx'</script>");
    }
    public string text()
    {
        string text = Myfile.Read_Model(Server.MapPath("../model/SYLG.html"), "gb2312");
        SqlConnection conn1 = new SqlConnection(ConStr);
        conn1.Open();
        SqlCommand cmd1 = new SqlCommand("select top 4 Title ,URL from article where LanMu='岁月理工' and Audited=0 order by Date desc", conn1);
        SqlDataReader dr1_1 = cmd1.ExecuteReader();
        StringBuilder sb1_1 = new StringBuilder();
        while (dr1_1.Read())
        {
            string title = dr1_1["Title"].ToString();
            string title_lim = Mystring.lim_withoutPoint(dr1_1["Title"].ToString(), 20);
            string url = dr1_1["URL"].ToString();
            sb1_1.AppendFormat("<div style=\"margin-bottom:8px;\"><img src=\"images/index/images/icon.png\" width=\"4\" height=\"5\" />&nbsp;<a href=\"../Html_03/{0}\" title=\"{1}\">{2}</a></div>", url, title, title_lim);
        }
        dr1_1.Close();
        text = text.Replace("%%SYLG%%", sb1_1.ToString());
        conn1.Close();
        return text;
    }
}