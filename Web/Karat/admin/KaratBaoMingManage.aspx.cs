using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuqi.Webdiyer;
using System.Data.SqlClient;
using System.Data;
using Lgwin.BLL;

public partial class karat1_admin_KaratBaoMingManage : System.Web.UI.Page
{
     protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.karatchksess();
        if (!IsPostBack)
        {
            PageBind();
        }
    }
    private void PageBind()
    {
        int curpage = Convert.ToInt32(this.labPage.Text);
        PagedDataSource ps = new PagedDataSource();
        DataTable dt = new KaratBLL().BaomingSelectAll();
        ps.DataSource = dt.DefaultView;
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
                    bool flag = new KaratBLL().KaratDelete(id, "Karat_BaoMing");
                    if (flag == true)
                    {
                        c = 1;
                    }
                    else
                        c = -1;
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
}