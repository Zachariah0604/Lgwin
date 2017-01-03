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
using System.IO;

public partial class Lgwin_manage_ZtlistUnpass : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.chksess();
        string _Action;
        string _capid;
        int _id;
        _id = Convert.ToInt32(Request.QueryString["Id"] == null || Request.QueryString["Id"] == string.Empty ? "0" : Request.QueryString["Id"].ToString().Trim());
        _Action = Request.QueryString["Action"] == null || Request.QueryString["Action"] == string.Empty ? "" : Request.QueryString["Action"].ToString().Trim();
        _capid = Request.QueryString["Class"] == null || Request.QueryString["Class"] == string.Empty ? "" : Request.QueryString["Class"].ToString().Trim();
        if (!IsPostBack)
        {
            if ((_id == 0 || _Action == "") && _capid == "")
            {
                Session["CurrentPageIndex"] = 1;
                Initialize();
            }
            else
            {
                if (_capid != "")
                    Session["capid"] = _capid;
                OpreatInitialize(_id, _Action);
                PageBind();
            }
        }
        else
        {
            Session["CurrentPageIndex"] = 1;
        }

    }
    protected void Initialize()///初始化
    {
        //ZtCaptionBLL capbll = new ZtCaptionBLL();
        //IList<ZtCaption> listcap = capbll.GetZtCaptionList(Session["ZtId"].ToString());
        //RadioButtonList1.DataSource = listcap;
        //RadioButtonList1.DataTextField = "ZtCaptionName";
        //RadioButtonList1.DataValueField = "Id";
        //RadioButtonList1.DataBind();
        //RadioButtonList1.SelectedIndex = 0;

        int count;
        ContentBLL dal = new ContentBLL();
            //IList<Lgwin.Model.Content> list = dal.GetList(pager.PageSize, 1, "auditing = 'False' and zt='" + Session["ZtId"].ToString() + "' and ztid='" + RadioButtonList1.SelectedValue + "'", out count);
            IList<Lgwin.Model.Content> list = dal.GetList(pager.PageSize, 1, "auditing = 'False' and zt>0 and zt='" + Session["ZtId"].ToString() + "'", out count);
            pager.RecordCount = count;
            NewsList.DataSource = list;
            NewsList.DataBind();

            if (NewsList.Items.Count == 0)
            {
                Label1.Visible = true;
                Label1.Text = "没有数据";
            }


            //if (Session["capid"] == null || Session["capid"].ToString() == string.Empty)
            //{
            //    if (RadioButtonList1.Items.Count != 0)
            //    {
            //        Session["capid"] = RadioButtonList1.Items[0].Value;
            //    }
            //}
            if (Session["CurrentPageIndex"] == null || Session["CurrentPageIndex"].ToString() == "")
            {
                Session["CurrentPageIndex"] = 1;
            }
    }
    protected void OpreatInitialize(int _id, string _Action)
    {
        switch (_Action)
        {
            case "YaowenFalse":
                Lgwin.Model.Content mod = new Lgwin.Model.Content();
                ContentBLL bll = new ContentBLL();
                mod = bll.Get(_id);
                mod.Yaowen = false;
                bll.Update(mod);
                break;
            case "YaowenTrue":
                Lgwin.Model.Content mod2 = new Lgwin.Model.Content();
                ContentBLL bll2 = new ContentBLL();
                mod2 = bll2.Get(_id);
                mod2.Yaowen = true;
                bll2.Update(mod2);
                break;
            case "TuwenFalse":
                Lgwin.Model.Content mod3 = new Lgwin.Model.Content();
                ContentBLL bll3 = new ContentBLL();
                mod3 = bll3.Get(_id);
                mod3.Tuwen = false;
                bll3.Update(mod3);
                break;
            case "TuwenTrue":
                Lgwin.Model.Content mod4 = new Lgwin.Model.Content();
                ContentBLL bll4 = new ContentBLL();
                mod4 = bll4.Get(_id);
                if (!(mod4.Contents.IndexOf(".jpg") < 0) && !(mod4.Contents.IndexOf("src") < 0))
                {
                    mod4.Tuwen = true;
                    bll4.Update(mod4);
                }
                else
                    Mystring.alert("文章里有图片么？？？");
                break;
            case "SdutFalse":
                Lgwin.Model.Content mod5 = new Lgwin.Model.Content();
                ContentBLL bll5 = new ContentBLL();
                mod5 = bll5.Get(_id);
                mod5.Sdut = false;
                bll5.Update(mod5);
                break;
            case "SdutTrue":
                Lgwin.Model.Content mod6 = new Lgwin.Model.Content();
                ContentBLL bll6 = new ContentBLL();
                mod6 = bll6.Get(_id);
                mod6.Sdut = true;
                bll6.Update(mod6);
                break;
            case "SdutPicFalse":
                Lgwin.Model.Content mod7 = new Lgwin.Model.Content();
                ContentBLL bll7 = new ContentBLL();
                mod7 = bll7.Get(_id);
                mod7.Sdutpic = false;
                bll7.Update(mod7);
                break;
            case "SdutPicTrue":
                Lgwin.Model.Content mod8 = new Lgwin.Model.Content();
                ContentBLL bll8 = new ContentBLL();
                mod8 = bll8.Get(_id);
                if (!(mod8.Contents.IndexOf(".jpg") < 0) && !(mod8.Contents.IndexOf("src") < 0))
                {
                    mod8.Tuwen = true;
                    bll8.Update(mod8);
                }
                else
                    Mystring.alert("文章里有图片么？？？");
                break;
            case "Del":
                if (Mystring.chksess())
                {
                    if (Mystring.chkPower(30, Session["User"].ToString()))
                    {
                        try
                        {
                            string htmlpath = Server.MapPath("~") + "news/" + _id + ".html";
                            File.Delete(htmlpath);//删除静态页
                        }
                        catch
                        {
                            return;
                        }
                        ContentBLL bll9 = new ContentBLL();
                        int mod9 = bll9.Del(_id.ToString());
                    }
                }
                break;
            default:
                break;
        }
    }
    private void PageBind()//重新绑定方法
    {
        //ZtCaptionBLL capbll = new ZtCaptionBLL();
        //IList<ZtCaption> listcap = capbll.GetZtCaptionList(Session["ZtId"].ToString());
        //RadioButtonList1.DataSource = listcap;
        //RadioButtonList1.DataTextField = "ZtCaptionName";
        //RadioButtonList1.DataValueField = "Id";
        //RadioButtonList1.DataBind();
        //RadioButtonList1.SelectedValue = capId;

        int countth;
        ContentBLL dal = new ContentBLL();
        int page = Session["CurrentPageIndex"] == null || Session["CurrentPageIndex"] == "" ?1:Convert.ToInt32(Session["CurrentPageIndex"].ToString())  ;
        //IList<Lgwin.Model.Content> list = dal.GetList(pager.PageSize,page, "auditing = 'False' and zt='" + Session["ZtId"].ToString() + "' and ztid='" + capId + "'", out countth);
        IList<Lgwin.Model.Content> list = dal.GetList(pager.PageSize, page, "auditing = 'False' and zt>0 and zt='" + Session["ZtId"] + "'", out countth);
        pager.RecordCount = countth;
        pager.CurrentPageIndex = int.Parse(Session["CurrentPageIndex"].ToString());
        NewsList.DataSource = list;
        NewsList.DataBind();
        NewsList.Visible = true;

        if (NewsList.Items.Count == 0)
        {
            Label1.Visible = true;
            Label1.Text = "没有数据";
        }


    }
    protected void pager_PageChanging(object src, PageChangingEventArgs e)
    {
        pager.CurrentPageIndex = e.NewPageIndex;
        Session.Remove("CurrentPageIndex");
        Session["CurrentPageIndex"] = pager.CurrentPageIndex;
        PageBind();
    }

    //protected void RadioButtonList1_SelectedIndexChanged1(object sender, EventArgs e)//栏目选择改变时
    //{
    //    string capid = RadioButtonList1.SelectedValue;
    //    Session.Remove("capid");
    //    Session["capid"] = capid;

    //    int count;
    //    ContentBLL dal = new ContentBLL();
    //    IList<Lgwin.Model.Content> list = dal.GetList(pager.PageSize, Convert.ToInt32(Session["CurrentPageIndex"].ToString()), "auditing = 'False' and zt='" + Session["ZtId"].ToString() + "' and ztid='" + capid + "'", out count);
    //    pager.RecordCount = count;
    //    pager.CurrentPageIndex = int.Parse(Session["CurrentPageIndex"].ToString());
    //    NewsList.DataSource = list;
    //    NewsList.DataBind();
    //}
    protected void DelAll_Click(object sender, EventArgs e)
    {
        if (Mystring.chksess())
        {
            if (Mystring.chkPower(30, Session["User"].ToString()))
            {
                string sltID = Request.Form["cbxID"].Replace(" ", "");
                ContentBLL bb = new ContentBLL();
                char[] seperator = { ',' };
                string[] id = sltID.Split(seperator);
                for (int i = 0; i < id.Length; i++)
                {
                    Lgwin.Model.Content mod = bb.Get(int.Parse(id[i]));
                    ToHtml.DelHtml(mod);
                    bb.Del(id[i]);
                }
                Mystring.alert("删除成功");
                PageBind();
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string sltID = Request.Form["cbxID"].Replace(" ", "");
        ContentBLL bb = new ContentBLL();
        char[] seperator = { ',' };
        string[] id = sltID.Split(seperator);
        for (int i = 0; i < id.Length; i++)
        {
            int idid = int.Parse(id[i]);
            Lgwin.Model.Content mod = bb.Get(idid);
            ToHtml.singlecon_toHtml(mod);
        }
        Mystring.alert("操作成功");
        PageBind();
    }
}