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

public partial class Manage : System.Web.UI.Page
{
    private static string ConStr = System.Configuration.ConfigurationSettings.AppSettings["connStr"].ToString();
    protected void Page_Load(object sender, EventArgs e)
    {
        Myfile.File_Write(Server.MapPath("Index.html"),text());
        
        Label1.Text = "生成首页成功！点击查看";
    }
    public string text()
    {
        string text = Myfile.Read_Model(Server.MapPath("model/XYWHindex.model"),"utf-8");
        
        SqlConnection conn1 = new SqlConnection(ConStr);
        conn1.Open();
        SqlCommand cmd1 = new SqlCommand("select top 4 Title ,URL from article where LanMu='岁月理工 'and Audited=0 order by Date desc", conn1);
        SqlCommand cmd2 = new SqlCommand("select top 4 Title ,URL from article where LanMu='公告' and Audited=0 order by Date desc", conn1);
        SqlCommand cmd3 = new SqlCommand("select top 7 Title ,URL from article where LanMu='名家讲坛' and Audited=0 order by Date desc", conn1);
        SqlCommand cmd4 = new SqlCommand("select top 7 Title ,URL from article where LanMu='社团风采' and Audited=0 order by Date desc", conn1);
        SqlCommand cmd5 = new SqlCommand("select top 4 ID ,title from fashion where lanmu='mtv' order by ID desc", conn1);
        SqlCommand cmd6 = new SqlCommand("select top 10 Title ,URL ,Author from article where LanMu='心灵启迪' and Audited=0 order by Date desc", conn1);
        SqlCommand cmd7 = new SqlCommand("select top 10 Title ,URL ,Author from article where LanMu='学生原创' and Audited=0 order by Date desc", conn1);
        SqlCommand cmd8 = new SqlCommand("select top 10 Title ,URL ,Author from article where LanMu='记者观察' and Audited=0 order by Date desc", conn1);
        SqlCommand cmd9 = new SqlCommand("select top 10 Title ,URL ,Author from article where LanMu='稷下时评'and Audited=0 order by Date desc", conn1);
        SqlCommand cmd10 = new SqlCommand("select top 8 Title ,URL  from article where LanMu='校园生活' and Audited=0 order by Date desc", conn1);
        SqlDataReader dr1 = cmd1.ExecuteReader();
        StringBuilder sb1 = new StringBuilder();
        while (dr1.Read())
        {
            string title = dr1["Title"].ToString();
            string title_lim = Mystring.lim_withoutPoint(dr1["Title"].ToString(), 20);
            string url = dr1["URL"].ToString();
            sb1.AppendFormat("<div style=\"margin-top:1px; overflow:hidden;width:250px;height:20px;\"><a href=\"Html_03/{0}\"title=\"{1}\">{2}</a></div>", url, title,title_lim);
        }
        dr1.Close();
       
        SqlDataReader dr2 = cmd2.ExecuteReader();
        StringBuilder sb2 = new StringBuilder();
        while (dr2.Read())
        {
            string title = dr2["Title"].ToString();
            string title_lim = Mystring.lim_withoutPoint(dr2["Title"].ToString(), 18);
            string url = dr2["URL"].ToString();
            sb2.AppendFormat("<div><a href=\"Html_03/{0}\"title=\"{1}\">{2}</a></div>", url, title,title_lim);
        }
        dr2.Close();
        SqlDataReader dr3 = cmd3.ExecuteReader();
        StringBuilder sb3 = new StringBuilder();
        while (dr3.Read())
        {
            string title =dr3["Title"].ToString();
            string title_lim = Mystring.lim_withoutPoint(dr3["Title"].ToString(), 19);
            string url = dr3["URL"].ToString();
            sb3.AppendFormat("<div style=\"margin-top:1px;overflow:hidden;height:30px;\"><a href=\"Html_03/{0}\"title=\"{1}\">{2}</a></div>", url, title,title_lim);
        }
        dr3.Close();
        SqlDataReader dr4 = cmd4.ExecuteReader();
        StringBuilder sb4 = new StringBuilder();
        while (dr4.Read())
        {
            string title = dr4["Title"].ToString();
            string title_lim = Mystring.lim_withoutPoint(dr4["Title"].ToString(), 19);
            string url = dr4["URL"].ToString();
            sb4.AppendFormat("<div style=\"margin-top:3px; padding-left:50px; background-image:url(images/index/images/index_27.jpg); background-repeat:no-repeat\"><a href=\"Html_03/{0}\"title=\"{1}\">{2}</a></div>", url, title, title_lim);
        }
        dr4.Close();
        SqlDataReader dr5 = cmd5.ExecuteReader();
        StringBuilder sb5 = new StringBuilder();
        while (dr5.Read())
        {
            string ID = dr5["ID"].ToString();
            string title = dr5["title"].ToString();
            string title_lim = Mystring.lim_withoutPoint(dr5["Title"].ToString(), 12);
            sb5.AppendFormat("<div style=\"padding-left:10px\"><a href=\"Fashion_area/Htmlmtv_03/{0}.html\"title=\"{1}\">{2}</a></div>", ID, title, title_lim);
        }
        dr5.Close();
        SqlDataReader dr6 = cmd6.ExecuteReader();

        StringBuilder sb6 = new StringBuilder();
        while (dr6.Read())
        {
            string title = dr6["Title"].ToString();
            string title_lim = Mystring.lim_withoutPoint(dr6["Title"].ToString(), 16);
            string url = dr6["URL"].ToString();
            string author = dr6["Author"].ToString().Trim();
            sb6.AppendFormat("<div style=\"margin-top:2px;overflow:hidden\"><div style=\"width:230px; float:left; padding-left:10px\"><img src=\"images/index/images/icon.png\" width=\"6\" height=\"6\" />&nbsp;<a href=\"Html_03/{0}\"title=\"{1}\">{2}</a></div><div style=\"float:right;width:45px;color:#999\">{3}</div></div>", url, title, title_lim, author);
        }
        dr6.Close();
        SqlDataReader dr7 = cmd7.ExecuteReader();
        StringBuilder sb7 = new StringBuilder();
        while (dr7.Read())
        {
            string title = dr7["Title"].ToString();
            string title_lim = Mystring.lim_withoutPoint(dr7["Title"].ToString(), 16);
            string url = dr7["URL"].ToString();
            string author = dr7["Author"].ToString().Trim();
            sb7.AppendFormat("<div style=\"margin-top:2px;overflow:hidden\"><div style=\"width:230px; float:left; padding-left:10px\"><img src=\"images/index/images/icon.png\" width=\"6\" height=\"6\" />&nbsp;<a href=\"Html_03/{0}\"title=\"{1}\">{2}</a></div><div style=\"float:right;width:45px;color:#999\">{3}</div></div>", url, title, title_lim, author);
        }
        dr7.Close();
        SqlDataReader dr8 = cmd8.ExecuteReader();
        StringBuilder sb8 = new StringBuilder();
        while (dr8.Read())
        {
            string title = dr8["Title"].ToString();
            string title_lim = Mystring.lim_withoutPoint(dr8["Title"].ToString(), 16);
            string url = dr8["URL"].ToString();
            string author = dr8["Author"].ToString().Trim();
            sb8.AppendFormat("<div style=\"margin-top:2px;overflow:hidden\"><div style=\"width:230px; float:left; padding-left:25px\"><img src=\"images/index/images/icon.png\" width=\"6\" height=\"6\" />&nbsp;<a href=\"Html_03/{0}\"title=\"{1}\">{2}</a></div><div style=\"float:right;width:40px;color:#999\">{3}</div></div>", url, title, title_lim, author);
        }
        dr8.Close();
        SqlDataReader dr9 = cmd9.ExecuteReader();
        StringBuilder sb9 = new StringBuilder();
        while (dr9.Read())
        {
            string title = dr9["Title"].ToString();
            string title_lim = Mystring.lim_withoutPoint(dr9["Title"].ToString(), 16);
            string url = dr9["URL"].ToString();
            string author = dr9["Author"].ToString().Trim();
            sb9.AppendFormat("<div style=\"margin-top:2px;overflow:hidden\"><div style=\"width:230px; float:left; padding-left:25px\"><img src=\"images/index/images/icon.png\" width=\"6\" height=\"6\" />&nbsp;<a href=\"Html_03/{0}\"title=\"{1}\">{2}</a></div><div style=\"float:right;width:40px;color:#999\">{3}</div></div>", url, title, title_lim, author);
        }
        dr9.Close();
        SqlDataReader dr10 = cmd10.ExecuteReader();
        StringBuilder sb10 = new StringBuilder();
        while (dr10.Read())
        {
            string title = dr10["Title"].ToString();
            string title_lim = Mystring.lim_withoutPoint(dr10["Title"].ToString(), 16);
            string url = dr10["URL"].ToString();
            sb10.AppendFormat("<tr><td><img src=\"suiyueligong/images/index/images/icon.png\" width=\"7\" height=\"9\" />&nbsp;<a href=\"Html_03/{0}\" title=\"{1}\">{2}</a></td></tr>", url, title, title_lim);
        }
        dr10.Close();
        conn1.Close();
        text = text.Replace("%%suiyueligong01%%", sb1.ToString());
        text = text.Replace("%%gonggao%%", sb2.ToString());
        text = text.Replace("%%mingjiajiangtan%%", sb3.ToString());
        text = text.Replace("%%ligongwangshi%%", sb4.ToString());
        text = text.Replace("%%wangshi%%", sb5.ToString());
        text = text.Replace("%%xueshengyuanchuang%%", sb6.ToString());
        text = text.Replace("%%xinlingqidi%%", sb7.ToString());
        text = text.Replace("%%jizheguancha%%", sb8.ToString());
        text = text.Replace("%%jixiashiping%%", sb9.ToString());
        text = text.Replace("%%xiaoyuanshenghuo%%", sb10.ToString()); 
        conn1.Close();
        return text;
        
    }

}
