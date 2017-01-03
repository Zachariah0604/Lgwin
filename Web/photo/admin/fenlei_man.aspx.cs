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
using System.IO;

using System.Text;
using Lgwin.BLL;
using Lgwin.Model;


public partial class xlxy_admin_fenlei_man : System.Web.UI.Page
{     
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.chksess();
        Button2.OnClientClick = "return window.confirm('确认删除?')";
      
        if (!IsPostBack)
        {  
            RadioButtonList1.DataBind();
            if (RadioButtonList1.Items.Count != 0)
                RadioButtonList1.Items[0].Selected = true;
            PageBind();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Photo mod = new Photo();
        mod.name = TextBox_name.Text;
        string name = TextBox_name.Text;
        mod.zhtname = DropDownList1.SelectedItem.ToString();
        mod.zhtID = int.Parse(DropDownList1.SelectedValue);
        mod.introduction = Editor1.Text.ToString();
        mod.created_time = Convert.ToDateTime(TextBox1.Text.ToString());
        bool i = new PhotoBLL().FENLEI_manAdd(name);
        if (i == true)
            Mystring.alertAndRedirect("栏目分类重复", "fenlei_man.aspx");
        else
        {
            bool flag = new PhotoBLL().Fenlei_man_Add(mod);
            if (flag == true)
            { Label1.Text = "操作已成功"; }
            else { Label1.Text = "操作失败"; }
            PageBind();
        }

        Panel1.Visible = false;
    }
   
    private void PageBind()
    {
        int curpage = Convert.ToInt32(this.labPage.Text);
        string zhtID = RadioButtonList1.SelectedValue;
        DataTable mydt = new DataTable();
        DataColumn dc = null;
        dc = mydt.Columns.Add("ID", Type.GetType("System.String"));
        dc = mydt.Columns.Add("name", Type.GetType("System.String"));
        dc = mydt.Columns.Add("zhtID", Type.GetType("System.String"));
        dc = mydt.Columns.Add("zhtname", Type.GetType("System.String"));
        dc = mydt.Columns.Add("introduction", Type.GetType("System.String"));
        dc = mydt.Columns.Add("created_time", Type.GetType("System.String"));
        mydt = new PhotoBLL().Fenlei_man_Select(zhtID);
        PagedDataSource ps = new PagedDataSource();
        ps.DataSource = mydt.DefaultView;
        mydt.Dispose();

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
        mydt.Dispose();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int n = 0;
        int c = 0;
        if (this.Repeater1.Items.Count > 0)
        {
            for (int i = 0; i < Repeater1.Items.Count; i++)
            {
                CheckBox ck = Repeater1.Items[i].FindControl("Checkbox1") as CheckBox;
                HiddenField hd = Repeater1.Items[i].FindControl("HiddenField1") as HiddenField;
                int id = int.Parse(hd.Value);
                if (ck.Checked)
                {
                    bool flag1 = new PhotoBLL().PhotoDelete(id, "id", "Photo_lmfenlei");
                    bool flag2 = new PhotoBLL().PhotoDelete(id, "lmID", "Photo_photo");
                    if (flag1 == true)
                    {
                        c = 1;
                    }
                    else { c = -1; }
                    SqlDataReader dr1 = new PhotoBLL().PhotoSelect(id, "lmID", "Photo_photo");
                    while (dr1.Read())
                    {
                        string path = Server.MapPath("~") + "\\photo\\admin\\photo\\" + dr1["zhtID"].ToString() + "\\";
                        File.Delete(path + dr1["path"].ToString());
                        File.Delete(path + dr1["path_small"].ToString());
                    }

                    string path_html = Server.MapPath("~") + "\\photo\\" + id.ToString() + ".html";
                    File.Delete(path_html);

                }
                else
                {
                    n++;
                }
            }
            if (n == this.Repeater1.Items.Count)
            {

                ClientScript.RegisterStartupScript(typeof(Page), "aa", "alert('至少应选择一项')", true);
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
   
    protected void lnkbtnOne_Click(object sender, EventArgs e)
    {
        this.labPage.Text = "1";
        this.PageBind();

    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {   
        this.labPage.Text = "1";
         this.PageBind();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("manage.aspx");
    }
    
    protected void Button5_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        TextBox1.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("pic_upload.aspx");

    }
}
