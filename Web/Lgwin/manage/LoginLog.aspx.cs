using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;



public partial class Lgwin_manage_LoginLog : System.Web.UI.Page
{
    static string connenctstring = ConfigurationManager.AppSettings["connStr"];
    SqlConnection connect = new SqlConnection(connenctstring);
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.chksess();
    }

    protected void btnsummit_Click(object sender, EventArgs e)
    {
        DateTime starttime = Convert.ToDateTime(tb_starttime.Text);
        DateTime endtime = Convert.ToDateTime(tb_endtime.Text);
        SqlDataAdapter da = new SqlDataAdapter("select * from log  where time >'" + starttime + "' and time<'" + endtime + "'", connect);
        DataTable ds = new DataTable();
        da.Fill(ds);

        //PagedDataSource pdg = new PagedDataSource();
 
        //pdg.DataSource = ds;
        Repeater1.DataSource = ds;
        Repeater1.DataBind();



    }


}
