﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Lgwin.BLL;
using Lgwin.IDAL;
using Lgwin.Model;
using Wuqi.Webdiyer;
using System.Collections.Generic;
using Count;

public partial class Lgwin_manage_NewsMe : System.Web.UI.Page
{
    //我审核的文章页
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.chksess();
        string _Caption;
        string _Action;
        int _id;
        _id = Convert.ToInt32(Request.QueryString["Id"] == null || Request.QueryString["Id"] == string.Empty ? "0" : Request.QueryString["Id"].ToString().Trim());
        _Action = Request.QueryString["Action"] == null || Request.QueryString["Action"] == string.Empty ? "" : Request.QueryString["Action"].ToString().Trim();
        if (!IsPostBack)
        {
            _Caption = Session["TempClass"] == null || Session["TempClass"].ToString() == string.Empty ? "理工要闻" : Session["TempClass"].ToString().Trim();
            if (_id == 0 || _Action == "")
            {
                Session["CurrentPageIndex"] = 1;
            }
            PageBind(_Caption);
            OpreatInitialize(_Caption, _id, _Action);
        }
        else
        {

            Session["CurrentPageIndex"] = 1;
            _Caption = Request.Form["caption"].ToString();
            Session["TempClass"] = _Caption;
            OpreatInitialize(Session["TempClass"].ToString(), _id, _Action);
        }
    }

    protected void OpreatInitialize(string _Caption, int _id, string _Action)
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
                    Count.DBclass delDB=new  DBclass();
                    ContentBLL bll9 = new ContentBLL();
                    Lgwin.Model.Content mode=bll9.Get(_id);
                    int mod9;
                    if (Mystring.chksess())
                    {
                        PowerClassBLL pcbll = new PowerClassBLL();
                        PowerClass pcmod = new PowerClass();
                        pcmod = pcbll.GetPowerClass(mode.Caption);
                        string name = Session["User"].ToString();
                        if (Mystring.chkPower(pcmod.Id, Session["User"].ToString()))
                        {
                            if (delDB.ExecuteSql("insert into log (titleId,title) values ('" + _id + "'," + mode.Title + ")") > 0)
                                mod9 = bll9.Del(_id.ToString());
                        }
                    }
                    break;
                default:
                    break;
            }
            PageBind(_Caption);
    }

    protected void DelAll_Click(object sender, EventArgs e)
    {
        string sltID = Request.Form["cbxID"].Replace(" ","");
        ContentBLL bb = new ContentBLL();
        char[] seperator = { ',' };
        string[] id = sltID.Split(seperator);
        Count.DBclass delDB = new DBclass();
        for (int i = 0; i < id.Length; i++)
        {
            Lgwin.Model.Content mod = bb.Get(int.Parse(id[i]));
            if (Mystring.chksess())
            {
                PowerClassBLL pcbll = new PowerClassBLL();
                PowerClass pcmod = new PowerClass();
                pcmod = pcbll.GetPowerClass(mod.Caption);
                if (Mystring.chkPower(pcmod.Id, Session["User"].ToString()))
                {
                    if (delDB.ExecuteSql("insert into log (titleId,title) values ('" + int.Parse(id[i]) + "'," + mod.Title + ")") > 0)
                    {
                        ToHtml.DelHtml(mod);
                        bb.Del(id[i]);
                    }
                }
            }
        }
        //foreach (RepeaterItem item in NewsList.Items)
        //{
        //    CheckBox check = (CheckBox)item.FindControl("CheckBox1");
        //    if (check.Checked==true )
        //    {
        //        int idid = int.Parse(check.Text.Trim());
        //        ContentBLL bb = new ContentBLL();
        //        Lgwin.Model.Content mod = bb.Get(idid);
        //        ToHtml.DelHtml(mod);
        //        bb.Del(idid.ToString());
        //    } 
        //}
        //for (int i = 0; i < NewsList.Items.Count; i++)
        //{
        //    CheckBox check = (CheckBox)NewsList.Items[i].FindControl("CheckBox1");
        //    if (check.Checked==true)
        //    {
        //        int idid=int.Parse(check.Text.Trim());
        //        ContentBLL bb = new ContentBLL();
        //        Lgwin.Model.Content mod=bb.Get(idid);
        //        ToHtml.DelHtml(mod);
        //        bb.Del(idid.ToString());
        //    }
        //}
        Mystring.alert("删除成功");
        PageBind(Session["TempClass"].ToString());
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
        PageBind(Session["TempClass"].ToString());
    }
    protected void pager_PageChanging(object src, PageChangingEventArgs e)
    {
        pager.CurrentPageIndex = e.NewPageIndex;
        Session["CurrentPageIndex"] = pager.CurrentPageIndex;
        PageBind(Session["TempClass"].ToString());
    }
    private void PageBind(string _class)
    {
        int count;
        ContentBLL dal = new ContentBLL();
        if (Session["CurrentPageIndex"] == null || Session["CurrentPageIndex"].ToString() == "")
        {
            Session["CurrentPageIndex"] = 1;
        }

        IList<Lgwin.Model.Content> list = dal.GetList(_class, pager.PageSize,Convert.ToInt32( Session["CurrentPageIndex"].ToString()),"auditing = 'True' and editor='" + Session["Name"].ToString() + "'", out count);
        pager.RecordCount = count;
        pager.CurrentPageIndex = int.Parse(Session["CurrentPageIndex"].ToString());     
        NewsList.DataSource = list;
        NewsList.DataBind();

        if (NewsList.Items.Count == 0)
        {
            Label1.Visible = true;
            Label1.Text = "没有数据";
        }


        ClassBLL classList = new ClassBLL();
        IList<Class> _ClassList = classList.GetClassList(false);
        caption.DataSource = _ClassList;
        caption.DataTextField = "Title";
        caption.DataValueField = "Title";
        caption.DataBind();
        caption.SelectedValue = _class;

        DelAll.Attributes["OnClick"] = "return confirm('你确定要执行删除操作？该操作会删除记录包含的图片，静态页面，缩略图等相关信息')";

    }
}