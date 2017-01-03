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
using Lgwin.BLL;
using Lgwin.Model;
using Wuqi.Webdiyer;
using System.Data.SqlClient;
using System.Text;

public partial class Search1 : System.Web.UI.Page
{
    private static string typ = "";
    private static string me = "";
    private static string key = "";
    private static string Website = "";
    int page = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request["type"] != null && Request["textfield"] != null)
            {
                key = Request["textfield"].ToString().Replace("'", "");
                typ = Request["type"].ToString().Replace("'", "");
                Website = Request["website"].ToString().Replace("'", "");
                typ += "";
                key += "";
                Website += "";
                if (Website == "" || typ == "" || key == "" || key == "请输入关键字")
                    caption.Text = "对不起,请输入搜索关键字！";
                //Mystring.alertAndRedirect("对不起,请输入搜索关键字！", "index.html", "top");
                else
                    PageBind();
                //alertAndBack("对不起,请输入搜索关键字！");
            }
        }
        else
            PageBind();
    }
    protected void PageBind()
    {
        string type = typ.Trim();
        string keywords = key.Trim();
        string website = Website.Trim();
        string me = "";
        string sqll = "";
        string sqll2 = "";
        int count = 0;
        if (website == "lgwindow")
        {
            switch (type)
            {
                case "biaoti":
                    sqll = " [title] like '%" + keywords + "%'";
                    me = "标题";
                    break;
                case "zuozhe":
                    sqll = " [author] like '%" + keywords + "%'";
                    me = "作者";
                    break;
                case "laiyuan":
                    sqll = " [fro] like '%" + keywords + "%'";
                    me = "来源";
                    break;
                case "neirong":
                    sqll = " [content] like '%" + keywords + "%'";
                    me = "内容";
                    break;
                default:
                    break;
            }
            ContentBLL bll = new ContentBLL();
            IList<Lgwin.Model.Content> list = bll.GetList(pager.PageSize, pager.CurrentPageIndex, "[auditing]='1' and [caption]<>'废稿' and " + sqll, out count);
            pager.RecordCount = count;
            NewsList.DataSource = list;
            NewsList.DataBind();
            caption.Text = "<font color=red>新闻网</font>，搜索关键词：<font color=red>“" + keywords + "”</font>；搜索类型：按<font color=red>" + me + "</font>搜索，共<font color=red>" + count + "</font>条记录";
        }
        else
        {


            lblCurrentPage.Visible = true;
            Button1.Visible = true;
            Button2.Visible = true;
            Label1.Visible = true;
            Label2.Visible = true;
            string strcon = System.Configuration.ConfigurationManager.AppSettings["connStr"];
            SqlConnection con = new SqlConnection(strcon);
            switch (type)
            {
                case "biaoti":
                    sqll = "select * from Campus_Article where [Title] like '%" + keywords + "%' and Pass='True' and [Lanmu]<>'废稿' order by Datee desc ";
                    sqll2 = "select count(*) from Campus_Article where [Title] like '%" + keywords + "%' and Pass='True' and [Lanmu]<>'废稿'";
                    me = "标题";
                    break;
                case "zuozhe":
                    sqll = "select * from Campus_Article where [Author] like '%" + keywords + "%' and Pass='True' and [Lanmu]<>'废稿' order by Datee desc";
                    sqll2 = "select count(*) from Campus_Article where [Author] like '%" + keywords + "%' and Pass='True' and [Lanmu]<>'废稿'";
                    me = "作者";
                    break;
                case "laiyuan":
                    sqll = "select * from Campus_Article where [FromTo] like '%" + keywords + "%' and Pass='True' and [Lanmu]<>'废稿' order by Datee desc";
                    sqll2 = "select count(*) from Campus_Article where [FromTo] like '%" + keywords + "%' and Pass='True' and [Lanmu]<>'废稿' ";
                    me = "来源";
                    break;
                case "neirong":
                    sqll = "select * from Campus_Article where [Content] like '%" + keywords + "%' and Pass='True' and [Lanmu]<>'废稿' order by Datee desc";
                    sqll2 = "select count(*) from Campus_Article where [Content] like '%" + keywords + "%' and Pass='True' and [Lanmu]<>'废稿' ";
                    me = "内容";
                    break;
                default:
                    break;
            }
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sqll, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Campus_Article");

            PagedDataSource objPds = new PagedDataSource();
            objPds.DataSource = ds.Tables[0].DefaultView;
            objPds.AllowPaging = true;
            objPds.PageSize = 25;

            int curpage = Convert.ToInt32(lblCurrentPage.Text);
            this.Button1.Enabled = true;
            this.Button2.Enabled = true;
            objPds.CurrentPageIndex = curpage - 1;
            if (curpage == 1)
            {
                this.Button1.Enabled = false;
            }
            if (curpage == objPds.PageCount)
            {
                this.Button2.Enabled = false;
            }

            Repeater1.DataSource = objPds;
            Repeater1.DataBind();
            con.Close();



            SqlCommand cmd = new SqlCommand(sqll2, con);
            con.Open();
            int num = (int)cmd.ExecuteScalar();
            con.Close();
            caption.Text = "<font color=red>校园文化</font>，关键词：<font color=red>“" + keywords + "”</font>；搜索类型：按<font color=red>" + me + "</font>搜索，共<font color=red>" + num.ToString() + "</font>条记录";
        }
    }
    protected void pager_PageChanging(object src, PageChangingEventArgs e)
    {
        pager.CurrentPageIndex = e.NewPageIndex;
        PageBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        this.lblCurrentPage.Text = Convert.ToString(Convert.ToInt32(lblCurrentPage.Text) - 1);
        PageBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        this.lblCurrentPage.Text = Convert.ToString(Convert.ToInt32(lblCurrentPage.Text) + 1);
        PageBind();

    }
}