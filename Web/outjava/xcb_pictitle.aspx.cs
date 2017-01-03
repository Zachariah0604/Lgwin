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
//using Count;

public partial class outjava_xcb_pictitle : System.Web.UI.Page
{
    protected static string strConn = ConfigurationSettings.AppSettings["connStr"];
    protected static SqlConnection myConn = new SqlConnection(strConn);
    protected void Page_Load(object sender, EventArgs e)
    {
        //Count.DBclass db = new DBclass();
        SqlDataReader dr = ExecuteSqlDataReader("select top 2 * from newscon where tuwen='1' and yaowen='1' and auditing='1'  order by datee desc,id desc");
        string src = "";
        string id = "", title = "";
        while (dr.Read())
        {
            src = myRegular.pic_Src_Top1(dr["content"].ToString());
            if (src != "src=\"\"")
            {
                id = dr["id"].ToString();
                title = dr["title"].ToString();
                break;
            }
        }
        dr.Close();
        dr.Dispose();
        Response.Write("document.write(\"<div align=center height=20><a href=http://lgwindow.sdut.edu.cn/news/"+id+".html target=_blank><b>&nbsp;"+Mystring.lim_withPoint(title,26)+"</b></a></div>\");");
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
