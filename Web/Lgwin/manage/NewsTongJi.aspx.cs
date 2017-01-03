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

public partial class Lgwin_manage_NewsTongJi : System.Web.UI.Page
{
    //审核统计详细信息,显示个人审核文章详细信息
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.chksess();
        if (!IsPostBack)
        {
            PageBind();
        }
    }
    protected void pager_PageChanging(object src, PageChangingEventArgs e)
    {
        pager.CurrentPageIndex = e.NewPageIndex;
        PageBind();
    }
    private void PageBind()//重新绑定方法
    {
        string _Author;
        string _Editor;
        string _Xueyuan;
        string _Caption;
        string _TouTiao;
        string _Start;
        string _Stop;
        string _Authorbfo;
        string _Editorbfo;
        string _Xueyuanbfo;
        string _Captionbfo;
        string _TouTiaobfo;
        string _Website;//网站
        int _webtype;
        _Authorbfo = Server.UrlDecode(Request.QueryString["Author"]);
        _Editorbfo = Server.UrlDecode(Request.QueryString["Editor"]);
        _Xueyuanbfo = Server.UrlDecode(Request.QueryString["Xueyuan"]);
        _Captionbfo = Server.UrlDecode(Request.QueryString["Caption"]);
        _TouTiaobfo = Server.UrlDecode(Request.QueryString["TouTiao"]);
        _webtype = Convert.ToInt32(Request.QueryString["webtype"]);
        _Website = Server.UrlDecode(Request.QueryString["Website"]);//获取AuditCount页的网站类型
        if (_webtype ==1)
        {
            #region 新闻网
            _Author = _Authorbfo == null || _Authorbfo == string.Empty ? "" : " and ([author] like '%" + _Authorbfo.ToString().Trim() + "%')";
            _Editor = _Editorbfo == null || _Editorbfo == string.Empty ? "" : " and ([editor] like '%" + _Editorbfo.ToString().Trim() + "%')";
            _Xueyuan = _Xueyuanbfo == null || _Xueyuanbfo == string.Empty ? "" : " and ([fro]='" + _Xueyuanbfo.ToString().Trim() + "')";
            _Caption = _Captionbfo == null || _Captionbfo == string.Empty ? "" : " and ([caption]='" + _Captionbfo.ToString().Trim() + "')";
            _TouTiao = _TouTiaobfo == null || _TouTiaobfo == string.Empty ? "" : "and ([yaowen]='1') ";
            _Start = Request.QueryString["Start"] == null || Request.QueryString["Start"] == string.Empty ? "" : " and ([datee]>='" + Request.QueryString["Start"].ToString().Trim() + "')";
            _Stop = Request.QueryString["Stop"] == null || Request.QueryString["Stop"] == string.Empty ? "" : " and ([datee]<='" + Request.QueryString["Stop"].ToString().Trim() + "')";
            int countth;

            ContentBLL dal = new ContentBLL();
            IList<Lgwin.Model.Content> list = dal.GetList(pager.PageSize, pager.CurrentPageIndex, "auditing = 'True' and ([caption]<>'废稿')" + _Author + _Editor + _Caption + _Start + _Stop + _Xueyuan + _TouTiao, out countth);
            pager.RecordCount = countth;
            NewsList.DataSource = list;
            NewsList.DataBind();

            Label1.Text = "这是新闻网 ";
            if (_Start != "")
                Label1.Text += "从 " + Request.QueryString["Start"].ToString().Trim() + "";
            if (_Stop != "")
                Label1.Text += " 到 " + Request.QueryString["Stop"].ToString().Trim() + " 时间段内，";
            if (_Author != "")
                Label1.Text += "由 " + _Authorbfo.ToString().Trim() + " 所写，";
            if (_Editor != "")
                Label1.Text += "由 " + _Editorbfo.ToString().Trim() + " 编辑，";
            if (_Xueyuan != "")
                Label1.Text += " 来自：" + _Xueyuanbfo.ToString().Trim();
            if (_Caption != "")
                Label1.Text += "发自栏目：" + _Captionbfo.ToString().Trim();
            if (_TouTiao != "")
                Label1.Text += "被 头条 选中的";
            Label1.Text += " 审核通过，不含废稿的所有新闻";
            #endregion
        }
        else
        {
            #region 校园文化
            _Author = _Authorbfo == null || _Authorbfo == string.Empty ? "" : " and ([Author] like '%" + _Authorbfo.ToString().Trim() + "%')";
            _Editor = _Editorbfo == null || _Editorbfo == string.Empty ? "" : " and ([Editor] like '%" + _Editorbfo.ToString().Trim() + "%')";
            _Xueyuan = _Xueyuanbfo == null || _Xueyuanbfo == string.Empty ? "" : " and ([FromTo]='" + _Xueyuanbfo.ToString().Trim() + "')";
            _Caption = _Captionbfo == null || _Captionbfo == string.Empty ? "" : " and ([Lanmu]='" + _Captionbfo.ToString().Trim() + "')";

            _Start = Request.QueryString["Start"] == null || Request.QueryString["Start"] == string.Empty ? "" : " and ([Datee]>='" + Request.QueryString["Start"].ToString().Trim() + "')";
            _Stop = Request.QueryString["Stop"] == null || Request.QueryString["Stop"] == string.Empty ? "" : " and ([Datee]<='" + Request.QueryString["Stop"].ToString().Trim() + "')";
            int countth;
            Button1.Visible = true;
            Button2.Visible = true;
            string strcon = System.Configuration.ConfigurationManager.AppSettings["connStr"];
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            string sql = "select * from Campus_Article where Pass = 'True'" + _Author + _Editor + _Caption + _Start + _Stop + _Xueyuan;

            SqlDataAdapter da = new SqlDataAdapter(sql, con);
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
            Label1.Text = "这是校园文化 ";
            if (_Start != "")
                Label1.Text += "从 " + Request.QueryString["Start"].ToString().Trim() + "";
            if (_Stop != "")
                Label1.Text += " 到 " + Request.QueryString["Stop"].ToString().Trim() + " 时间段内，";
            if (_Author != "")
                Label1.Text += "由 " + _Authorbfo.ToString().Trim() + " 所写，";
            if (_Editor != "")
                Label1.Text += "由 " + _Editorbfo.ToString().Trim() + " 编辑，";
            if (_Xueyuan != "")
                Label1.Text += " 来自：" + _Xueyuanbfo.ToString().Trim();
            if (_Caption != "")
                Label1.Text += "发自栏目：" + _Captionbfo.ToString().Trim();

            Label1.Text += " 审核通过，不含废稿的所有新闻";
            #endregion

        }

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