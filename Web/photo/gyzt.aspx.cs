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

public partial class tsxw : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        dlbind();
    }

    private void dlbind()
    {
        string olestr = System.Configuration.ConfigurationManager.AppSettings["connStr"].ToString();
        SqlConnection conn = new SqlConnection(olestr);
        conn.Open();
        SqlCommand cmd = new SqlCommand("select ID from Photo_lmfenlei where zhtID ='28'order by created_time desc ", conn);
        SqlDataReader dr = cmd.ExecuteReader();

        ArrayList Array = new ArrayList();
        while (dr.Read())
        {
            string str = dr["ID"].ToString();
            Array.Add(dr.GetValue(0));
        }
        dr.Dispose();
        dr.Close();
        conn.Close();
        DataTable mydt = new DataTable("photo");
        DataColumn dc = null;
        dc = mydt.Columns.Add("lmname", Type.GetType("System.String"));
        dc = mydt.Columns.Add("path", Type.GetType("System.String"));
        dc = mydt.Columns.Add("lmID", Type.GetType("System.String"));
        dc = mydt.Columns.Add("zhtID", Type.GetType("System.String"));
        dc = mydt.Columns.Add("pagename", Type.GetType("System.String"));

        foreach (int i in Array)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            string sql = "select top 1 lmname ,path,lmID ,zhtID,pagename from Photo_photo where zhtID=28  and xshshch=0  and   lmID = " + i;
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader myread = comm.ExecuteReader();
            while (myread.Read())
            {
                DataRow mydr = mydt.NewRow();
                for (int t = 0; t < mydt.Columns.Count; t++)
                    mydr[t] = myread[t].ToString();
                mydt.Rows.Add(mydr);
            }
            myread.Dispose();
            myread.Close();
            conn.Close();
        }

        PagedDataSource ps = new PagedDataSource();
        int cup = Convert.ToInt32(this.labpage.Text);
        ps.DataSource = mydt.DefaultView;
        mydt.Dispose();
        ps.AllowPaging = true;
        ps.PageSize = 12;
        ps.CurrentPageIndex = cup - 1;
        this.LinkButtonUp.Enabled = true;
        this.LinkButtonNexT.Enabled = true;
        this.LinkButtonLast.Enabled = true;
        this.LinkButton1.Enabled = true;
        if (cup == 1)
        {
            this.LinkButton1.Enabled = false;
            this.LinkButtonUp.Enabled = false;

        }

        if (cup == ps.PageCount)
        {
            this.LinkButtonNexT.Enabled = false;
            this.LinkButtonLast.Enabled = false;

        }

        this.Label6.Text = Convert.ToString(ps.PageCount);
        DataList1.DataSource = ps;
        DataList1.DataBind();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        this.labpage.Text = "1";
        this.dlbind();
    }
    protected void LinkButtonUp_Click(object sender, EventArgs e)
    {
        this.labpage.Text = Convert.ToString(Convert.ToUInt32(this.labpage.Text) - 1);
        this.dlbind();
    }
    protected void LinkButtonNext_Click(object sender, EventArgs e)
    {
        this.labpage.Text = Convert.ToString(Convert.ToUInt32(this.labpage.Text) + 1);
        this.dlbind();

    }
    protected void LinkButtonLast_Click(object sender, EventArgs e)
    {
        this.labpage.Text = this.Label6.Text;
        this.dlbind();
    }
}
