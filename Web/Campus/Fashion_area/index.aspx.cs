using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class index : System.Web.UI.Page
{
    protected static string constr = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(constr);
        string sqlstr1 = "select top 6 * from fashion  where lanmu='bh'order by datee desc";
        string sqlstr2 = "select top 11 * from fashion  where lanmu='shuyu' order by datee desc";
        string sqlstr3 = "select top 16 * from fashion  where lanmu='music'order by datee desc";
       //string sqlstr4 = "select top 2 * from comment where lanmu='music' and correct='是'";
        string sqlstr5 = "select top 2 * from fashion where lanmu='movie' order by datee desc ";
        string sqlstr6 = "select top 8 * from fashion where lanmu='mtv' order by datee desc ";
       SqlDataAdapter myda1 = new SqlDataAdapter(sqlstr1, conn);
       DataSet ds1 = new DataSet();
        myda1.Fill(ds1, "fashion");
       DataList1.DataSource = ds1;
       DataList1.DataBind();
       ds1.Dispose();
       conn.Close();
        

       SqlDataAdapter myda2 = new SqlDataAdapter(sqlstr2, conn);
       DataSet ds2 = new DataSet();
       conn.Open();
       myda2.Fill(ds2, "fashion");
       DataList2.DataSource = ds2;
       DataList2.DataBind();
       ds2.Dispose();
       conn.Close();

       SqlDataAdapter myda3 = new SqlDataAdapter(sqlstr3, conn);
       DataSet ds3 = new DataSet();
       conn.Open();
       myda3.Fill(ds3, "fashion");
       DataList3.DataSource = ds3;
       DataList3.DataBind();
       ds3.Dispose();
       conn.Close();

       //SqlDataAdapter myda4 = new SqlDataAdapter(sqlstr4, conn);
       //DataSet ds4 = new DataSet();
       //conn.Open();
       //myda4.Fill(ds4, "comment");
       //DataList4.DataSource = ds4;
       //DataList4.DataBind();
       //conn.Close();

       SqlDataAdapter myda5 = new SqlDataAdapter(sqlstr5, conn);
       DataSet ds5 = new DataSet();
       conn.Open();
       myda5.Fill(ds5, "fashion");
       DataList5.DataSource = ds5;
       DataList5.DataBind();
       ds5.Dispose();
       conn.Close();


       SqlDataAdapter myda6 = new SqlDataAdapter(sqlstr6, conn);
       DataSet ds6 = new DataSet();
       conn.Open();
       myda6.Fill(ds6, "fashion");
       DataList6.DataSource = ds6;
       DataList6.DataBind();
       ds6.Dispose();
       conn.Close();







    }
    public string SubStr(string sString, int nLeng)
    {
        if (sString.Length <= nLeng)
        {
            return sString;
        }
        string sNewStr = sString.Substring(0, nLeng);
        sNewStr = sNewStr + "...";
        return sNewStr;
    }
}