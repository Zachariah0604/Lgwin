using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Text;
//using Count;

public partial class outjava_xcb_news : System.Web.UI.Page
{
    protected static string strConn = ConfigurationSettings.AppSettings["connStr"];
    protected static SqlConnection myConn = new SqlConnection(strConn);
    protected void Page_Load(object sender, EventArgs e)
    {
        //Count.DBclass db = new DBclass();
        string javastr = "javastr=\"\"\njavastr=javastr+\"<table width=\\\"100%\\\" border=\\\"0\\\">\"\n";
        SqlDataReader dr =ExecuteSqlDataReader("select top 5 * from [newscon] where [sdut]=1 and [auditing]=1 order by id desc");
        string url = "",title="",linktext="";
        try
        {
            while (dr.Read())
            {
                if (dr["url"].ToString() != "0")
                {
                    url = dr["url"].ToString();
                    title = dr["title"].ToString();
                    linktext = Mystring.lim_withPoint(title, 36);
                }
                else
                {
                    url = "http://lgwindow.sdut.edu.cn/news/"+dr["id"].ToString()+".html";
                    title = dr["title"].ToString();
                    linktext = Mystring.lim_withPoint(title, 36);
                }
                javastr += "javastr=javastr+\"<tr><td class='line_h20'>\"\n";
                javastr+="javastr=javastr+\"·&nbsp;<a href=";
                javastr+=url;
                javastr+=" target=\\\"_blank\\\" title=\\\"";
                javastr+=title;
                javastr+="\\\" onFocus=this.blur()><span  font-size:9pt;line-height:15pt\\\">";
                javastr+=linktext;
                javastr += "</span></a></td><td align='right'>(";
                javastr+=Mystring.dateStr(dr["datee"],"yyyy-MM-dd")+")\"\n";
                javastr+="javastr=javastr+\"</td></tr>\"\n";

                
                url="";
                title="";
                linktext="";
            }
        }
        catch (Exception ex)
        {

        }
        finally
        {

            dr.Dispose();
            dr.Close();
        }
        javastr += "javastr=javastr+\"</table>\" \ndocument.write (javastr)";
        Encoding gb2312 = Encoding.GetEncoding("gb2312");
        Response.ContentEncoding = gb2312;
        Response.Write(javastr);


    }
    public SqlDataReader ExecuteSqlDataReader(string strSQL)
    {
        if (myConn.State != ConnectionState.Open)
            myConn.Open();
        try
        {
            SqlCommand myCmd = new SqlCommand(strSQL, myConn);
            SqlDataReader myDr = myCmd.ExecuteReader(CommandBehavior.CloseConnection);
            return myDr;
        }
        catch (System.Data.SqlClient.SqlException e)
        {
            throw new Exception(e.Message);
            myConn.Close();
        }
        finally
        {
        }

    }
}
