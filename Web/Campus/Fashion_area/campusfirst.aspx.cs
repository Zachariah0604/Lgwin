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


public partial class campusfirst : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string constr = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
        SqlConnection conn = new SqlConnection(constr);
        string sqlstr = "select top 6 * from fashion where lanmu='mtv' order by datee desc ";
        SqlDataAdapter myda = new SqlDataAdapter(sqlstr, conn);
        DataSet ds = new DataSet();
        myda.Fill(ds, "fashion");
        DataList1.DataSource = ds;
        DataList1.DataBind();
        ds.Dispose();
       
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