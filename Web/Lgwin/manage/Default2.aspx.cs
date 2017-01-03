using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuqi.Webdiyer;
using System.Data;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    private static string ConStr = System.Configuration.ConfigurationManager.AppSettings["connStr"].ToString();
    string users;
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.chksess();
        if (!IsPostBack)
        {
            if (Mystring.chksess())
            {
                PageBind();
            }
            users=Session["User"].ToString();
            //Response.Write(users);
            Panel2.Visible = false;
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Panel2.Visible = true;
    }
    private void PageBind()
    {

        int curpage = Convert.ToInt32(this.labPage.Text);
        PagedDataSource ps = new PagedDataSource();
        SqlConnection conn = new SqlConnection(ConStr);
        conn.Open();
        string str = "";
        if (Session["User"].ToString() == "zhang")
        {
            str = "select * from problem where observer<>'lihedi' order by id desc";
        }
        else
        {
            str = "select * from problem order by id desc";
        }
        SqlDataAdapter MyAdapter = new SqlDataAdapter(str, conn);
        DataSet ds = new DataSet();
        MyAdapter.Fill(ds, "problem");
        ps.DataSource = ds.Tables["problem"].DefaultView;
        ps.AllowPaging = true; //是否可以分页
        ps.PageSize = 25; //显示的数量
        ps.CurrentPageIndex = curpage - 1; //取得当前页的页码
        this.lnkbtnUp.Enabled = true;
        this.lnkbtnNext.Enabled = true;
        this.lnkbtnBack.Enabled = true;
        this.lnkbtnOne.Enabled = true;
        if (curpage == 1)
        {
            this.lnkbtnOne.Enabled = false;//不显示第一页按钮
            this.lnkbtnUp.Enabled = false;//不显示上一页按钮
        }
        if (curpage == ps.PageCount)
        {
            this.lnkbtnNext.Enabled = false;//不显示下一页
            this.lnkbtnBack.Enabled = false;//不显示最后一页
        }
        this.labBackPage.Text = Convert.ToString(ps.PageCount);
        this.Repeater1.DataSource = ps;
        this.Repeater1.DataBind();
        conn.Close();

        if (Repeater1.Items.Count == 0)
        {
            Label1.Visible = true;
            Label1.Text = "没有数据";
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int n = 0;
        int c = 0;
        if (this.Repeater1.Items.Count > 0)
        {
            for (int i = 0; i < Repeater1.Items.Count; i++)
            {
                CheckBox ck = Repeater1.Items[i].FindControl("chkDelete") as CheckBox;
                HiddenField hd = Repeater1.Items[i].FindControl("HiddenField1") as HiddenField;
                int id = int.Parse(hd.Value);
                if (ck.Checked)
                {
                    SqlConnection con = new SqlConnection(ConStr);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from problem where id='"+id+"'",con);
                    c = cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    n++;
                }

                if (n == this.Repeater1.Items.Count)
                {

                    ClientScript.RegisterStartupScript(typeof(Page), "aa", "alert('至少应选择一项')", true);
                }

            }
            if (c > 0)
            {
                Mystring.alert("删除成功！");
            }
            else
            {
                Mystring.alert("删除失败");
            }
        }
        PageBind();
    }
    protected void lnkbtnOne_Click(object sender, EventArgs e)
    {
        this.labPage.Text = "1";
        this.PageBind();
    }
    protected void lnkbtnUp_Click(object sender, EventArgs e)
    {
        this.labPage.Text = Convert.ToString(Convert.ToInt32(this.labPage.Text) - 1);
        this.PageBind();
    }
    protected void lnkbtnNext_Click(object sender, EventArgs e)
    {
        this.labPage.Text = Convert.ToString(Convert.ToInt32(this.labPage.Text) + 1);
        this.PageBind();
    }
    protected void lnkbtnBack_Click(object sender, EventArgs e)
    {
        this.labPage.Text = this.labBackPage.Text;
        this.PageBind();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        users = Session["User"].ToString();
        string time = System.DateTime.Now.ToShortDateString();

        SqlConnection con = new SqlConnection(ConStr);
        con.Open();
        string strcmd = "insert into problem (problem,status,observer,time) values ('" + tb_problem.Text + "','未解决','"+users+"','"+time+"')";
        SqlCommand cmd = new SqlCommand(strcmd,con);
        int c = cmd.ExecuteNonQuery();
        con.Close();
        if (c > 0)
        {
            Mystring.alert("添加成功！");
        }
        else
        {
            Mystring.alert("添加失败！");
        }
        PageBind();
        Panel2.Visible = false;
    }
}