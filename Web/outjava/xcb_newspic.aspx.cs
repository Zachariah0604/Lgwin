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
using System.Text;

public partial class outjava_xcb_newspic : System.Web.UI.Page
{
    protected static string strConn = ConfigurationSettings.AppSettings["connStr"];
    protected static SqlConnection myConn = new SqlConnection(strConn);
    protected void Page_Load(object sender, EventArgs e)
    {
        //Count.DBclass db = new Count.DBclass();
        SqlDataReader dr =ExecuteSqlDataReader("select top 4 * from newscon where tuwen='true' and yaowen='true' and auditing='true'  order by datee desc,id desc");
        StringBuilder pics = new StringBuilder();
        StringBuilder links = new StringBuilder();
        StringBuilder titles = new StringBuilder();
    
        while (dr.Read())
        {
            
            string orginalPicString= myRegular.pic_Src_Top1(dr["content"].ToString());
            string subString = orginalPicString.Replace("src=\"", "http://lgwindow.sdut.edu.cn");
            string lastString = subString.Remove(subString.Length - 1, 1);
            pics.Append(lastString+ "|");
            if (pics.ToString() != "src=\"\"")
            {
                string id = dr["id"].ToString();
                links.Append("http://lgwindow.sdut.edu.cn/news/" + id + ".html|");
                string  title = dr["title"].ToString();
                titles.Append(Mystring.lim_withPoint(title,26) + "|");               
            }
        }
        string picString=pics.Remove(pics.Length-1,1).ToString();
        string linkString=links.Remove(links.Length-1,1).ToString();
        string titleString=titles.Remove(titles.Length-1,1).ToString();
        dr.Close();
        dr.Dispose();
        Encoding gb2312 = Encoding.GetEncoding("gb2312"); 
        Response.ContentEncoding = gb2312;
        Response.Write("\nvar pics='"+picString+"';\n var links='"+linkString+"';\n var texts='"+titleString+"';\n" );
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
