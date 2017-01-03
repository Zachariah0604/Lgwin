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

public partial class right : System.Web.UI.Page
{
    protected static string constr = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection sqlcon = new SqlConnection(constr);
        
        string sqlstr= "select top 7 * from fashion where lanmu='bh'order by ID desc  ";
        SqlDataAdapter MyAdapter = new SqlDataAdapter(sqlstr, sqlcon);
        DataSet ds = new DataSet();
        MyAdapter.Fill(ds, "fashion");
        DataList1.DataSource = ds;
        DataList1.DataBind();
        ds.Dispose();
        
        
        string sqlstr2 = "select top 7 * from fashion where lanmu='shuyu'order by ID desc  ";
        SqlDataAdapter MyAdapter2 = new SqlDataAdapter(sqlstr2, sqlcon);
        DataSet ds2 = new DataSet();
        MyAdapter2.Fill(ds2, "fashion");
        DataList2.DataSource = ds2;
        DataList2.DataBind();
        ds2.Dispose();
        

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