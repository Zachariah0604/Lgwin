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

public partial class To_Html_03_To_html_03 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string ConStr = System.Configuration.ConfigurationManager.AppSettings["connStr"].ToString();
        SqlConnection conn = new SqlConnection(ConStr);
        //int id = int.Parse(Request["id"]);
        //string id = "";
        //id = Request["id"].ToString();
        if (Request["id"]==null)
        {
                    StringBuilder sb = new StringBuilder();
                    //string title = "";
                    string sql1 = "select top 1 * from article where Audited=0 order by id desc";
                    string _id = "";
                    string title = "";
                    string subtitle = "";
                    string lanmu = "";
                    string date = "";
                    string author = "";
                    string from = "";
                    string content = "";
                    string editor = "";
                    string PLname="";
                    string PLneirong="";
                    string PLdate="";
                    string PL="";
                    string URL="";
                    SqlDataReader dr1 = xlxy.dr(sql1);
                    while (dr1.Read())
                    {
                        _id = dr1["id"].ToString();
                        title = dr1["Title"].ToString();
                        subtitle = dr1["SubTitle"].ToString();
                        lanmu=dr1["LanMu"].ToString();
                        date=dr1["Date"].ToString();
                        author=dr1["Author"].ToString();
                        from=dr1["From"].ToString();
                        content=dr1["Content"].ToString();
                        editor=dr1["Editor"].ToString();
                        URL=dr1["URL"].ToString();
                    }
                    //dr1.Close();
                    //string sql2 = "select * from Campus_comment where AID='" + id + "'";
                    //SqlDataReader dr2=xlxy.dr(sql2);
                    //while(dr2.Read())
                    //{
                    //    PLname=dr2["name"].ToString();
                    //    PLneirong=dr2["comment"].ToString();
                    //    PLdate=dr2["datee"].ToString();
                    PL = sb.AppendFormat("<div style=\"font-size:12px;margin-top:10px\"><div style=\"float:left; color:#666\">&nbsp; {0}</div><div style=\"float:right; color:#666\">评论时间：{2}</div></br></br>&nbsp; {1}</div><hr / width=\"650px\" align=\"center\" style=\"border:1px #cccccc dotted\">", PLname, PLneirong, PLdate).ToString();
                    //}
                    string texts = "";
                    texts = Myfile.Read_Model(Server.MapPath("../model/xywh3.html"));
                    texts = texts.Replace("%%id%%", _id);
                    texts = texts.Replace("%%title%%", title);
                    texts = texts.Replace("%%subtitle%%", subtitle);
                    texts = texts.Replace("%%lanmu%%", lanmu);
                    texts = texts.Replace("%%date%%", date);
                    texts = texts.Replace("%%author%%", author);
                    texts = texts.Replace("%%from%%", from);
                    texts = texts.Replace("%%content%%", content);
                    texts = texts.Replace("%%editor%%", editor);
                    texts = texts.Replace("%%canshu%%", PL);
                   if (Myfile.File_Write(Server.MapPath("../Html_03/") + URL.ToString(), texts, "utf-8"))
                    {
                        //string pagename = id.ToString() + ".html";
                        //xlxy.sqlNoQ("update [Photo_lmfenlei] set [pagename]='" + pagename + "' where [id]='" + id + "'");
                        Response.Write("<script>alert('操作成功');self.location='../ArticleManage.aspx'</script>");
                    }
                    else
                    {
                        Mystring.alert("操作失败，请重试！！！");
                    }
        //Response.Write("<script>location='../To_right_list.aspx'</script>");
        }
   
        else
        {
            int _id = int.Parse(Request["id"]);
                   StringBuilder sb = new StringBuilder();
                    //string title = "";
                    string sql1 = "select * from article where id='" + _id + "'";
                    //string _id = "";
                    string title = "";
                    string subtitle = "";
                    string lanmu = "";
                    string date = "";
                    string author = "";
                    string from = "";
                    string content = "";
                    string editor = "";
                    string PLname="";
                    string PLneirong="";
                    string PLdate="";
                    string PL="";
                    string URL="";
                    SqlDataReader dr1 = xlxy.dr(sql1);
                    while (dr1.Read())
                    {
                        //_id = dr1["id"].ToString();
                        title = dr1["Title"].ToString();
                        subtitle=dr1["SubTitle"].ToString();
                        lanmu=dr1["LanMu"].ToString();
                        date=dr1["Date"].ToString();
                        author=dr1["Author"].ToString();
                        from=dr1["From"].ToString();
                        content=dr1["Content"].ToString();
                        editor=dr1["Editor"].ToString();
                        URL=dr1["URL"].ToString();
                    }
                    dr1.Close();
                    string sql2 = "select * from Campus_comment where AID='" + _id + "'";
                    SqlDataReader dr2=xlxy.dr(sql2);
                    while(dr2.Read())
                    {
                        PLname=dr2["name"].ToString();
                        PLneirong=dr2["comment"].ToString();
                        PLdate=dr2["datee"].ToString();
                        PL = sb.AppendFormat("<div style=\"font-size:12px;margin-top:10px\"><div style=\"float:left; color:#666\">&nbsp; {0}</div><div style=\"float:right; color:#666\">评论时间：{2}</div></br></br>&nbsp; {1}</div><hr / width=\"650px\" align=\"center\" style=\"border:1px #cccccc dotted\">", PLname, PLneirong, PLdate).ToString();
                    }
                    string texts = "";
                    texts = Myfile.Read_Model(Server.MapPath("../model/xywh3.html"));
                    texts = texts.Replace("%%id%%", _id.ToString());
                    texts = texts.Replace("%%title%%", title);
                    texts = texts.Replace("%%subtitle%%", subtitle);
                    texts = texts.Replace("%%lanmu%%", lanmu);
                    texts = texts.Replace("%%date%%", date);
                    texts = texts.Replace("%%author%%", author);
                    texts = texts.Replace("%%from%%", from);
                    texts = texts.Replace("%%content%%", content);
                    texts = texts.Replace("%%editor%%", editor);
                    texts = texts.Replace("%%canshu%%", PL);
                    if (Myfile.File_Write(Server.MapPath("../Html_03/") + URL.ToString(), texts, "utf-8"))
                    {
                        //string pagename = id.ToString() + ".html";
                        //xlxy.sqlNoQ("update [Photo_lmfenlei] set [pagename]='" + pagename + "' where [id]='" + id + "'");
                        dr2.Close();
                        Response.Write("<script>alert('操作成功');self.location='../ArticleManage.aspx'</script>");
                    }
                    else
                    {
                        Mystring.alert("操作失败，请重试！！！");
                    }
            
            //Response.Write("<script>location='../To_right_list.aspx'</script>");
            }
            
        }
            
    }
