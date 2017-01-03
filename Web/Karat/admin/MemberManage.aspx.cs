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
using System.Collections.Generic;
using System.Data.SqlClient;
using Lgwin.Model;
using Wuqi.Webdiyer;
using Lgwin.BLL;
using System.IO;
using System.Text;
using System.Globalization;


public partial class MemberManage : System.Web.UI.Page
{

 
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.karatchksess();
        int id;
        id = Convert.ToInt32(Request.QueryString["id"]);
        if (id > 0)
        {
            Delete(id);
        }
        
        if (!IsPostBack)
        {
            dropbind();                        
            DropDownList1.SelectedValue = DateTime.Now.Year.ToString();
            PageBind();
        }
    }

    private void PageBind()
    {
        int curpage = Convert.ToInt32(this.labPage.Text);
        PagedDataSource ps = new PagedDataSource();
        DataTable dt = new KaratBLL().MembersSelectByYear(DropDownList1.Text);
        ps.DataSource = dt.DefaultView;
        ps.AllowPaging = true; //是否可以分页
        ps.PageSize = 20; //显示的数量
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

    private void dropbind()
    {
        for (int i = 2002; i <= DateTime.Now.Year; i++)
        {
            ListItem li = new ListItem(i.ToString());
            DropDownList1.Items.Add(li);
        }
    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        int n = 0;
        int c = 0;
        if (this.Repeater1.Items.Count > 0)
        {
            for (int i = 0; i < Repeater1.Items.Count; i++)
            {
                CheckBox ck = Repeater1.Items[i].FindControl("CheckBox1") as CheckBox;
                HiddenField hd = Repeater1.Items[i].FindControl("HiddenField1") as HiddenField;
                int id = int.Parse(hd.Value);

                if (ck.Checked)
                {
                    bool flag = new KaratBLL().KaratDelete(id, "Karat_members");
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

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        PageBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("MemberAdd.aspx");
    }

    protected void Delete(int id)
    {
        bool flag = new KaratBLL().KaratDelete(id, "Karat_members");
 
        Response.Write("<script language=javascript>alert('删除成功！');self.location='MemberManage.aspx'</script>");

    }
}