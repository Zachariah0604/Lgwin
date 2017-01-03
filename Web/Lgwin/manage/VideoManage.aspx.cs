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
using Lgwin.BLL;
using Lgwin.Model;
using Wuqi.Webdiyer;
using System.Collections.Generic;

public partial class Lgwin_manage_VideoManage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.chksess();
        string _Action;
        string _type;
        int _id;
        _id = Convert.ToInt32(Request.QueryString["Id"] == null || Request.QueryString["Id"] == string.Empty ? "0" : Request.QueryString["Id"].ToString().Trim());
        _Action = Request.QueryString["Action"] == null || Request.QueryString["Action"] == string.Empty ? "" : Request.QueryString["Action"].ToString().Trim();
        _type = Request.QueryString["Type"] == null || Request.QueryString["Type"] == string.Empty ? "" : Request.QueryString["Type"].ToString().Trim();
        if (!IsPostBack)
        {
            if ((_id == 0 || _Action == "")&&_type=="")
            {
                Session["CurrentPageIndex"] = 1;
                RadioButtonList1.SelectedIndex = 0;
                Initialize();
            }
            else
            {
                if (_type != "")
                {
                    RadioButtonList1.SelectedIndex =Convert.ToInt32(_type.ToString());
                    Session["CurrentPageIndex"] = 1;
                    if (_type == "0")
                    {
                        PageBind("视频", int.Parse(Session["CurrentPageIndex"].ToString())); 
                    }
                    else
                    {
                        PageBind("音频", int.Parse(Session["CurrentPageIndex"].ToString()));
                    }
                    
                }
                else
                {
                    OpreatInitialize(_id, _Action);
                    PageBind(Session["Type"].ToString(), int.Parse(Session["CurrentPageIndex"].ToString()));
                }
            }
        }
        else
        {
            Session["CurrentPageIndex"] = 1;
        }
    }
    protected void Initialize()///初始化
    {        
        int count;
        VideoBLL dal = new VideoBLL();
        IList<Video> list = dal.GetVideoList(pager.PageSize, 1, "Type='视频'", out count);
        pager.RecordCount = count;
        NewsList.DataSource = list;
        NewsList.DataBind();

        if (Session["Type"] == null || Session["Type"].ToString() == string.Empty)
        {
             Session["Type"] = "视频";
     
        }
        if (Session["CurrentPageIndex"] == null || Session["CurrentPageIndex"].ToString() == "")
        {
            Session["CurrentPageIndex"] = 1;
        }
    }
    protected void OpreatInitialize(int _id, string _Action)
    {
        if (Mystring.chksess())
        {
            if (Mystring.chkPower(23, Session["User"].ToString()))
            {
                if (_Action == "Del")
                {
                    VideoBLL bll9 = new VideoBLL();
                    Video mod = bll9.GetVideoById(_id);
                    Myfile.File_Del(Server.MapPath("~/") + mod.Url);
                    int mod9 = bll9.Del(_id.ToString());
                    if (mod9 > 0)
                    {
                        Mystring.alert("删除成功");
                    }
                    PageBind(Session["Type"].ToString(), pager.CurrentPageIndex);
                }
            }
        }
    }   
    private void PageBind(string capId,int page)//重新绑定方法
    {
        int con;    
        VideoBLL dal = new VideoBLL();
        IList<Video> list = dal.GetVideoList(pager.PageSize, page, "Type='" + capId + "'", out con);
        pager.RecordCount = con;
        pager.CurrentPageIndex = page;
        NewsList.DataSource = list;
        NewsList.DataBind();

    }
    protected void pager_PageChanging(object src, PageChangingEventArgs e)
    {
        pager.CurrentPageIndex = e.NewPageIndex;
        Session.Remove("CurrentPageIndex");
        Session["CurrentPageIndex"] = pager.CurrentPageIndex;
        PageBind(Session["Type"].ToString(),pager.CurrentPageIndex);
    }
    protected void DelAll_Click(object sender, EventArgs e)
    {
        if (Mystring.chksess())
        {
            if (Mystring.chkPower(30, Session["User"].ToString()))
            {
                string sltID = Request.Form["cbxID"].Replace(" ", "");
                VideoBLL bb = new VideoBLL();
                char[] seperator = { ',' };
                string[] id = sltID.Split(seperator);
                for (int i = 0; i < id.Length; i++)
                {
                    Video mod = bb.GetVideoById(int.Parse(id[i]));
                    Myfile.File_Del(Server.MapPath("~/") + mod.Url);
                    bb.Del(id[i]);
                }
                Mystring.alert("删除成功");
                PageBind(Session["Type"].ToString(), pager.CurrentPageIndex);
            }
        }
    }
    protected void RadioButtonList1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        string type = RadioButtonList1.SelectedItem.Text;
        Session.Remove("Type");
        Session["Type"] = type;
        PageBind(type,1);        
    }
}
