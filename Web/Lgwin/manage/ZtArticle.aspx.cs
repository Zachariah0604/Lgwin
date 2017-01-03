using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lgwin.BLL;
using Lgwin.Model;

public partial class Lgwin_manage_ZtArticle : System.Web.UI.Page
{
    protected Lgwin.Model.Content _Article = new Lgwin.Model.Content();
    protected int _ArticleId;
    protected string _Type;
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.chksess();
        _ArticleId = Request.QueryString["Id"] != null ? int.Parse(Request.QueryString["Id"].ToString()) : 0;
        if (!IsPostBack)
        {
            Initialize();
        }   
        datee.Attributes.Add("onFocus", "selectDate(this)");
    }
    private void Initialize()
    {
        CollegeBLL _coBLL = new CollegeBLL();
        IList<College> _coList = _coBLL.GetCollegeList();
        fro.DataSource = _coList;
        fro.DataTextField = "Name";
        fro.DataValueField = "Name";
        fro.DataBind();
        url.Text = "0";
        datee.Text = DateTime.Now.ToString("yyyy/MM/dd");
        hits.Text = "0";
        editor.Text = Session["Name"].ToString();
        Label_caption.Text = "0";
        Label_caption.Visible = false;


        //获取新闻主体，进行初始化
        if (_ArticleId != 0)
        {
            ContentBLL _arBLL = new ContentBLL();
            _Article = _arBLL.Get(_ArticleId);
            if (_Article != null)
            {
                if (_Article.Caption != null && _Article.Caption != "")
                {
                    Label_caption.Text = "(" + _Article.Caption + ")";
                    Label_caption.Visible = true;
                }
                else
                {
                    Label_caption.Text = "0";
                    Label_caption.Visible = false;
                }
                Button1.Text = "修改";
                title.Text = _Article.Title;
                subtitle.Text = _Article.Subtitle;
                datee.Text = _Article.Datee.ToShortDateString();
                hits.Text = _Article.Counter.ToString();
                url.Text = _Article.Url;
                sdut.Checked = _Article.Sdut;
                sdutpic.Checked = _Article.Sdutpic;
                tuijian.Checked = _Article.Yaowen;
                pic.Checked = _Article.Tuwen;
                Editor1.Text = _Article.Contents;
                author.Text = _Article.Author;
                tel.Text = _Article.Tel;
                editor.Text = _Article.Editor;


                ZtCaption ztmod = new ZtCaption();
                ZtCaptionBLL ztbll = new ZtCaptionBLL();
                ztmod = ztbll.GetZtCaption(int.Parse(_Article.Ztid));
                RadioButtonList_lanmu.SelectedValue =ztmod.Id.ToString();


                if (fro.SelectedValue != _Article.Fro)
                {
                    College co = new College();
                    co.Name = _Article.Fro;
                    _coList.Insert(0, co);
                    fro.DataSource = _coList;
                    fro.DataTextField = "Name";
                    fro.DataValueField = "Name";
                    fro.DataBind();
                }
                else
                {
                    fro.SelectedValue = _Article.Fro;
                }
                auditing.Checked = !_Article.Auditing;
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        _Article.Id = _ArticleId;
        _Article.Title = title.Text;
        _Article.Subtitle = subtitle.Text;
        if (Label_caption.Text != "0")
        {
            Label_caption.Visible = true;
            string[] Array1 = Label_caption.Text.Split(new char[2] { '(', ')' });
            _Article.Caption = Array1[1].ToString();
        }
        else
            _Article.Caption = "";
        _Article.Datee = Convert.ToDateTime(datee.Text.ToString().Trim());
        _Article.Counter = hits.Text != string.Empty ? int.Parse(hits.Text) : 0;
        _Article.Url = url.Text == "0" || url.Text == string.Empty ? "0" : url.Text;
        _Article.Zt = Session["ZtId"].ToString();
        _Article.Ztid = RadioButtonList_lanmu.SelectedValue;

        if (!checkPic())
        {
            sdutpic.Checked = false;
            pic.Checked = false;
        }
        _Article.Sdut = sdut.Checked;
        _Article.Sdutpic = sdutpic.Checked;
        _Article.Tuwen = pic.Checked;
        _Article.Yaowen = tuijian.Checked;

        if (_Article.Url == "0")
            _Article.Contents = Editor1.Text;
        else
            _Article.Contents = string.Empty;
        _Article.Author = author.Text;
        _Article.Tel = tel.Text;

        if (Request.Form["fro_tb"] != "" && Request.Form["fro_tb"] != null)
        {
            _Article.Fro = fro_tb.Text;
        }
        else
        {
            _Article.Fro = fro.SelectedValue;
        }
        _Article.Editor = editor.Text;
        _Article.Auditing = !auditing.Checked;

        if (Button1.Text == "修改")
        {
            ContentBLL ArDal = new ContentBLL();
            if (ArDal.Update(_Article))
            {
                if (_Article.Url == "0")
                {
                    ToHtml.singlecon_toHtml(_Article);
                }
                if (auditing.Checked)
                    Response.Write("<script language=javascript>alert('操作成功！');self.location='ZtlistUnpass.aspx?Class=" + _Article.Ztid + "'</script>");
                else
                    Response.Write("<script language=javascript>alert('操作成功！');self.location='Ztlist.aspx?Class=" + _Article.Ztid + "'</script>");
            }
            else
                Response.Write("<script language=javascript>alert('操作失败！');</script>");
        }
        else
        {
            ContentBLL ArDal = new ContentBLL();
            if (ArDal.Add(_Article))
            {
                if (_Article.Url == "0")
                {
                    ToHtml.singlecon_toHtml(_Article);
                }
                if (auditing.Checked)
                    Response.Write("<script language=javascript>alert('操作成功！');self.location='ZtlistUnpass.aspx?Class=" + int.Parse(RadioButtonList_lanmu.SelectedValue) + "'</script>");
                else
                    Response.Write("<script language=javascript>alert('操作成功！');self.location='Ztlist.aspx?Class=" + _Article.Ztid + "'</script>");
            }
            else
                Response.Write("<script language=javascript>alert('操作失败！');</script>");
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Mystring.Back();
    }
    protected void sdutpic_CheckedChanged(object sender, EventArgs e)
    {
        if (!checkPic())
        {
            sdutpic.Checked = false;
            Mystring.alert("文章中确实有图片么？");
        }

    }
    public bool checkPic()
    {
        if (!(Editor1.Text.IndexOf(".jpg") < 0) && !(Editor1.Text.IndexOf("src") < 0))
            return true;
        else
            return false;
    }

    protected void pic_CheckedChanged(object sender, EventArgs e)
    {
        if (!checkPic())
        {
            pic.Checked = false;
            Mystring.alert("文章中确实有图片么？");
        }
    }

}
