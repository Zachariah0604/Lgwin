using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lgwin.BLL;
using Lgwin.Model;
using Count;
using System.IO;
using BloClass;
using System.Drawing;

public partial class Lgwin_manage_Article_Add : System.Web.UI.Page
{
    //文章编辑页
    protected Lgwin.Model.Content _Article = new Lgwin.Model.Content();
    protected int _ArticleId;
    protected string _Type;
    //微博参数
    //const long clientID = 1601956471;//app_key
    //const string responseType = "code";
    //const string redirectUri = "http://lgwindow.sdut.edu.cn/Lgwin/manage/NewsIndex.aspx";//回调地址
    //const string clientSecret = "b1f38df8abdd2173d0b2d3f34f5efe64";//app_secret
    //SinaSerive serive = new SinaSerive(clientID.ToString(), clientSecret, redirectUri);

    protected void Page_Load(object sender, EventArgs e)
    {
        this.sdut.Visible = false;
        if (Mystring.chkPower1(29, Session["User"].ToString()))
        {
            this.sdut.Visible = true;
        }
        Mystring.chksess();
        _ArticleId = Request.QueryString["Id"] != null ? int.Parse(Request.QueryString["Id"].ToString()) : 0;
        string bianji = Request.QueryString["bianji"] == null || Request.QueryString["bianji"] == string.Empty ? "" : Request.QueryString["bianji"].ToString().Trim();

        if (!IsPostBack)
        {
            ContentBLL cont = new ContentBLL();
            //int vla = cont.ReadState(_ArticleId);
            //if (vla == 1)
            //{
            //    Response.Write("<script language=javascript>alert('文章正在被编辑！请等待！');</script>");
            //    _ArticleId = 0;
            //    Initialize();
            //}
            //else
            //{
            ///yhb 2011-07-15
            cont.StateUpdate(_ArticleId, 1);//更新编辑状态
            Initialize();//更新编辑状态
            //}

        }
        //Mystring.chksess();
        if (Session["Admin"].ToString() == "2")
            editor.Enabled = false;
        datee.Attributes.Add("onFocus", "selectDate(this)");
        //fro_tb.Visible = false;
    }

    private void Initialize()
    {
        ClassBLL _clBLL = new ClassBLL();
        //IList<Class> _classList = _clBLL.GetClassList(false);
        caption.DataSource = _clBLL.GetClassList(false);
        caption.DataTextField = "Title";
        caption.DataValueField = "Title";
        caption.DataBind();
        caption.Items.Insert(caption.Items.Count, "专题文章");
        cbox1.Visible = false;
        zt1caption.Visible = true;
        //去掉没有权限的栏目
        RegUser mod = new RegUser();
        RegUserBLL bll = new RegUserBLL();
        if (Mystring.chksess())
        {
            mod = bll.GetUserInfo(Session["User"].ToString());
        }
        PowerClass pcmod = new PowerClass();
        PowerClassBLL pcbll = new PowerClassBLL();
        IList<PowerClass> PowerList = pcbll.GetPowerClassList("文章中心管理");

        for (int i = 0; i < PowerList.Count; i++)
        {
            if (mod.Power.IndexOf("|" + PowerList[i].Id.ToString() + "|") < 0)
                caption.Items.Remove(PowerList[i].Power.ToString());
        }
        //
        CollegeBLL _coBLL = new CollegeBLL();
        IList<College> _coList = _coBLL.GetCollegeList();
        fro.DataSource = _coList;
        fro.DataTextField = "Name";
        fro.DataValueField = "Name";
        fro.Items.Remove("理工大新闻网");
        fro.DataBind();

        ZtBLL _ztbll = new ZtBLL();
        IList<Zt> _ztlist = _ztbll.GetZtList(true);
        Zt zt0 = new Zt();
        zt0.Id = 0;
        zt0.Ztname = "==请选择专题==";
        _ztlist.Insert(0, zt0);
        zt1.DataSource = _ztlist;
        zt1.DataTextField = "Ztname";
        zt1.DataValueField = "Id";
        zt1.DataBind();
        //zt2.DataSource = _ztlist;
        //zt2.DataTextField = "Ztname";
        //zt2.DataValueField = "Id";
        //zt2.DataBind();
        listdatabind("0");

        //zt1.Attributes.Add("onchange", "mychange(this.options[this.selectedIndex].value,'1')");
        url.Text = "0";
        datee.Text = DateTime.Now.ToString("yyyy/MM/dd");
        hits.Text = "0";
        editor.Text = Session["Name"].ToString();

        //获取新闻主体，进行初始化
        if (_ArticleId != 0)
        {
            ContentBLL _arBLL = new ContentBLL();
            _Article = _arBLL.Get(_ArticleId);
            if (_Article != null)
            {
                if (_Article.Zt == "54")
                {
                    cboxbind("54");
                    cbox1.Visible = true;
                    ContentBLL ctb = new ContentBLL();
                    IList<Lgwin.Model.Content> list = ctb.getldartlist(_ArticleId.ToString(), "art");
                    foreach (Lgwin.Model.Content li in list)
                    {
                        for (int i = 0; i < cbox1.Items.Count; i++)
                        {
                            if (cbox1.Items[i].Value == li.Ztid)
                            {
                                cbox1.Items[i].Selected = true;
                            }
                        }
                    }
                    zt1caption.Visible = false;
                }
                else
                {
                    cbox1.Visible = false;
                    zt1caption.Visible = true;
                }
                Button1.Text = "修改";
                title.Text = _Article.Title;
                subtitle.Text = _Article.Subtitle;
                keywords.Text = _Article.Keywords;
                if (_Article.Caption == "" || _Article.Caption == null)
                    caption.SelectedValue = "专题文章";
                else
                    caption.SelectedValue = _Article.Caption;
                datee.Text = _Article.Datee.ToShortDateString();
                hits.Text = _Article.Counter.ToString();
                url.Text = _Article.Url;
                zt1.SelectedValue = _Article.Zt;
                if (Button1.Text == "修改")
                {
                    listdatabind(zt1.SelectedValue);
                    zt1caption.SelectedValue = _Article.Ztid;
                }
                sdut.Checked = _Article.Sdut;
                sdutpic.Checked = _Article.Sdutpic;
                tuijian.Checked = _Article.Yaowen;
                zixun.Checked = _Article.Zixun;
                forbidden.Checked = bool.Parse(_Article.Forbiden);
                pic.Checked = _Article.Tuwen;
                Editor1.Text = _Article.Contents;

                author.Text = _Article.Author;
                tel.Text = _Article.Tel;
                if (_Article.Editor != null && _Article.Editor != "")
                    editor.Text = _Article.Editor;
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

    /// <summary>
    /// 无刷新Js代码输出
    /// </summary>
    /// <returns></returns>
    protected string Js()
    {
        ZtCaptionBLL _ztcBll = new ZtCaptionBLL();
        string str = _ztcBll.CaptionJsStr();
        if (_Article.Zt != null)
        {
            string ztid1 = _Article.Ztid != string.Empty ? _Article.Ztid : "0";
            //string ztid2 = _Article.Ztid2 != string.Empty ? _Article.Ztid2 : "0";
            str = str + "var ztid1= " + ztid1;
            //" + "var ztid2= " + ztid2 + ";"
        }
        return str;
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        _Article.Id = _ArticleId;
        _Article.Title = title.Text;
        _Article.Subtitle = subtitle.Text;
        _Article.Keywords = keywords.Text;
        if (caption.SelectedValue == "专题文章")
            _Article.Caption = "";
        else
            _Article.Caption = caption.SelectedValue;
        _Article.Datee = Convert.ToDateTime(datee.Text.ToString().Trim());
        _Article.Counter = hits.Text != string.Empty ? int.Parse(hits.Text) : 0;
        _Article.Url = url.Text == "0" || url.Text == string.Empty ? "0" : url.Text;
        _Article.Zt = zt1.SelectedValue;
        if (zt1.SelectedValue == "54")
        {
            _Article.Ztid = "0";
        }
        else
        {
            _Article.Ztid = zt1caption.SelectedValue;
        }

        _Article.Sdut = sdut.Checked;
        if (!checkPic())
        {
            sdutpic.Checked = false;
            pic.Checked = false;
        }
        _Article.Sdutpic = sdutpic.Checked;
        _Article.Tuwen = pic.Checked;
        _Article.Yaowen = tuijian.Checked;
        _Article.Zixun = zixun.Checked;
        _Article.Forbiden = forbidden.Checked.ToString();

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
        _Article.StateNow = 0;
        if (Button1.Text == "修改")
        {
            ContentBLL ArDal = new ContentBLL();
            if (ArDal.Update(_Article))
            {
                if (_Article.Zt == "54")
                {
                    ZtBLL zt = new ZtBLL();
                    for (int i = 0; i < cbox1.Items.Count; i++)
                    {
                        if (cbox1.Items[i].Selected == true)
                        {
                            zt.leadAdd(cbox1.Items[i].Value, _ArticleId.ToString());
                        }
                        else
                        {
                            zt.Delldart(cbox1.Items[i].Value, _ArticleId.ToString());
                        }
                    }
                }
                if (_Article.Caption == "废稿") { }
                else
                {
                    if (_Article.Url == "0")
                    {
                        ToHtml.singlecon_toHtml(_Article);//生成三级页
                    }
                }
                int classid = 0;//获得栏目id
                ClassBLL classbll = new ClassBLL();
                IList<Class> clslist = classbll.GetClassList(false);
                for (int i = 0; i < clslist.Count; i++)
                {
                    if (clslist[i].Title == _Article.Caption)
                    {
                        classid = int.Parse(clslist[i].Tid);
                        break;
                    }
                }
                int count = 0;
                string result = "";
                if (_Article.Caption == "废稿")
                {
                    string htmlpath = Server.MapPath("~") + "/News/" + _Article.Id + ".html";
                    if (File.Exists(htmlpath))
                    {
                        File.Delete(htmlpath);
                    }
                }
                else
                {
                    count = ArDal.GetCount("caption='" + _Article.Caption + "' and  auditing = 'true'");
                    IList<Lgwin.Model.Content> list = ArDal.GetList(120, 1, "caption='" + _Article.Caption + "' and  auditing = 'true'", out count);
                    result = ToHtml.classlist(list, count, 36, 25, _Article.Caption, classid);//生成前四页二级页
                }


                int idd = Request.QueryString["Id"] != null ? int.Parse(Request.QueryString["Id"].ToString()) : 0;
                if (idd != 0)
                {
                    ContentBLL cont = new ContentBLL();
                    int vla = cont.StateUpdate(idd, 0);
                }
                if (auditing.Checked)
                    Response.Write("<script language=javascript>alert('修改成功！');self.location='NewsUnPass.aspx?Class=" + _Article.Caption + "'</script></script>");
                else
                    Response.Write("<script language=javascript>alert('修改成功！');self.location='NewsUnPass.aspx?Class=" + _Article.Caption + "'</script></script>");
            }
            else
                Response.Write("<script language=javascript>alert('修改失败！');</script>");


        }
        else
        {
            ContentBLL ArDal = new ContentBLL();
            if (ArDal.Add(_Article))
            {
                if (_Article.Zt == "54")
                {
                    ZtBLL zt = new ZtBLL();
                    for (int i = 0; i < cbox1.Items.Count; i++)
                    {
                        if (cbox1.Items[i].Selected == true)
                        {
                            zt.leadAdd(cbox1.Items[i].Value, _ArticleId.ToString());
                        }
                    }
                }
                if (_Article.Caption == "废稿")
                {
                    string htmlpath = Server.MapPath("~") + "/News/" + _Article.Id + ".html";
                    if (File.Exists(htmlpath))
                    {
                        File.Delete(htmlpath);
                    }

                    else { }
                }
                else
                {
                    if (_Article.Url == "0")
                    {
                        ToHtml.singlecon_toHtml(_Article);//生成三级页
                    }
                }
                int classid = 0;//获得栏目id
                ClassBLL classbll = new ClassBLL();
                IList<Class> clslist = classbll.GetClassList(false);
                for (int i = 0; i < clslist.Count; i++)
                {
                    if (clslist[i].Title == _Article.Caption)
                    {
                        classid = int.Parse(clslist[i].Tid);
                        break;
                    }
                }
                int count = 0;
                string result = "";
                if (_Article.Caption == "废稿")
                {

                }
                else
                {
                    count = ArDal.GetCount("caption='" + _Article.Caption + "' and  auditing = 'true'");
                    IList<Lgwin.Model.Content> list = ArDal.GetList(120, 1, "caption='" + _Article.Caption + "' and  auditing = 'true'", out count);
                    result = ToHtml.classlist(list, count, 36, 25, _Article.Caption, classid);//生成前四页二级页
                }
                if (auditing.Checked)
                    Response.Write("<script language=javascript>alert('添加成功！');self.location='NewsUnPass.aspx?Class=" + _Article.Caption + "'</script>");
                else
                    Response.Write("<script language=javascript>alert('添加成功！');self.location='NewsList.aspx?Class=" + _Article.Caption + "'</script>");
            }
            else
                Response.Write("<script language=javascript>alert('添加失败！');</script>");
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int idd = Request.QueryString["Id"] != null ? int.Parse(Request.QueryString["Id"].ToString()) : 0;
        if (idd != 0)
        {
            ContentBLL cont = new ContentBLL();
            int vla = cont.StateUpdate(idd, 0);
        }
        Mystring.Back();
    }
    protected void ButtonToCampus_Click(object sender, EventArgs e)
    {
        DBclass xywh = new DBclass();
        bool flag = false;
        string laiyuan = "";
        if (fro_tb.Text == "")
        {
            laiyuan = fro.Text;
        }
        else
            laiyuan = fro_tb.Text;
        if (xywh.ExecuteSql("insert into Campus_Article (Lanmu,Title,Subtitle,Author,[Content],Editor,Datee,HitCount,Tel,Pass,Hot,TodayRec,IndexRec,LgIndex,statenow,FromTo,ToUrl)"
            + "values ('菁菁校园','" + title.Text + "','" + subtitle.Text + "','" + author.Text + "','" + Editor1.Text + "','" + editor.Text + "','" + DateTime.Parse(datee.Text).ToString("yyyy-MM-dd") + "'," + hits.Text.Trim() + ",'" + tel.Text.Trim() + "','false','false','false','false','false',0,'" + laiyuan + "','0')") > 0)
        {
            ContentBLL bll = new ContentBLL();
            if (bll.Del(_ArticleId.ToString()) > 0)
                Mystring.alert("操作成功！");
            else
                Mystring.alert("操作失败！");
        }
        else
            Mystring.alert("操作失败！");
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

    protected void zt1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (zt1.SelectedValue == "54")
        {
            zt1caption.Visible = false;
            cboxbind("54");
            cbox1.Visible = true;
        }
        else
        {
            listdatabind(zt1.SelectedValue);
            zt1caption.Visible = true;
            cbox1.Visible = false;
        }
    }

    private void cboxbind(string zt)
    {
        ZtCaptionBLL _ztCapBLL = new ZtCaptionBLL();
        IList<ZtCaption> _ztCapList = _ztCapBLL.GetZtCaptionList(zt);
        cbox1.DataSource = _ztCapList;
        cbox1.DataTextField = "ZtCaptionName";
        cbox1.DataValueField = "Id";
        cbox1.DataBind();
    }

    private void listdatabind(string value)
    {
        ZtCaptionBLL _ztCapBLL = new ZtCaptionBLL();
        IList<ZtCaption> _ztCapList = _ztCapBLL.GetZtCaptionList(value);
        if (value == "0")
        {
            _ztCapList.Clear();
        }
        ZtCaption ztcap0 = new ZtCaption();
        ztcap0.Id = 0;
        ztcap0.ZtCaptionName = "==请选择栏目==";
        _ztCapList.Insert(0, ztcap0);
        zt1caption.DataSource = _ztCapList;
        zt1caption.DataTextField = "ZtCaptionName";
        zt1caption.DataValueField = "Id";
        zt1caption.DataBind();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        const long clientID = 1601956471;//app_key
        const string responseType = "code";
        const string redirectUri = "http://lgwindow.sdut.edu.cn/Lgwin/manage/blog.aspx";//回调地址
        const string clientSecret = "b1f38df8abdd2173d0b2d3f34f5efe64";//app_secret
        SinaSerive serive = new SinaSerive(clientID.ToString(), clientSecret, redirectUri);
        string topic = "#" + caption.SelectedItem.Text + "#";
        string url = string.Empty;
        string editor = this.Editor1.Text;
        int i = editor.IndexOf("<p>");
        int t = editor.IndexOf("</p>");
        int div = editor.IndexOf("<div>");
        int divend = editor.IndexOf("</div>");
        int imgstart = editor.IndexOf("uploads");
        int imgend = editor.IndexOf(".jpg");
        string str = string.Empty;
        string content = string.Empty;
        if (i == 0 && div != 0)
        {
            str = editor.Substring(i, t);
        }
        else if (i != 0 && div == 0)
        {
            str = editor.Substring(div, divend);
        }
        else
        {
            str = editor;
        }
        string param = myRegular.DelHTML(str);//去除html格式
        if (param.Length > 85)
        {
            content = param.Substring(0, 85);
        }
        else
        {
            content = param;
        }
        if (this.Button1.Text == "修改")
        {
            url = "http://lgwindow.sdut.edu.cn/News/" + _ArticleId + ".html";
        }
        else
        {
            string sql = "select top 1 id from newscon order by id desc";
            while (xlxy.dr(sql).Read())
            {
                url = "http://lgwindow.sdut.edu.cn/News/" + (Convert.ToInt32(xlxy.dr(sql)["id"]) + 1) + ".html";
            }
        }
        string urlimg = string.Empty;
        string imgurl = string.Empty;
        try
        {
            urlimg = "/" + editor.Substring(imgstart, imgend - imgstart + 4);
            imgurl = HttpContext.Current.Server.MapPath("~" + urlimg);
        }
        catch
        {
            imgurl = "";
        }
        //byte[] sr =  File.ReadAllBytes(imgurl);
        if (imgurl == "")
        {
            try
            {
                if (serive.Token != null)
                {
                    var status = serive.Statuses_Update(topic + "" + content + "……" + url);
                }
                else
                {
                    serive.GetAccessTokenByAuthorizationCode(Session["code"].ToString());
                    var status = serive.Statuses_Update(topic + "" + content + "……" + url);
                }
            }
            catch
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "<script>alert('此条微博已发送！')</script>", false);


            }
        }
        else
        {
            FileStream fs = new FileStream(imgurl, FileMode.Open, FileAccess.Read);
            BinaryReader bypic = new BinaryReader(fs);
            int count = 0;
            List<byte> list = new List<byte>();

            while (count == 0)
            {
                try
                {
                    list.Add(bypic.ReadByte());
                }
                catch (EndOfStreamException eof)
                {
                    count = list.Count;
                }
            }

            //Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "<script>alert('文件已对到末尾！')</script>", false);

            byte[] uploadpic = new byte[list.Count];
            for (int x = 0; x < list.Count; x++)
            {
                uploadpic[x] = list[x];
                //Response.Write(uploadpic[x]);
            }

            try
            {
                if (serive.Token != null)
                {
                    var status = serive.Statuses_Upload(topic + "" + content + "……" + url, uploadpic);
                }
                else
                {
                    serive.GetAccessTokenByAuthorizationCode(Session["code"].ToString());
                    var status = serive.Statuses_Upload(topic + "" + content + "……" + url, uploadpic);
                }
            }
            catch
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "<script>alert('此条微博已发送！')</script>", false);


            }
        }
    }
}
