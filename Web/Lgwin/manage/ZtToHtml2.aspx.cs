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
using System.Collections.Generic;
using System.IO;

public partial class Lgwin_manage_ZtToHtml23 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Mystring.chksess())
        {
            Mystring.chkPower(26, Session["User"].ToString());
        }

    }
    protected void Button_list_Click(object sender, EventArgs e)
    {
        int count;
        int zt = int.Parse(Session["ZtId"].ToString());
        string result = "";
        int ztid = int.Parse(RadioButtonList1.SelectedValue);
        int titlelen = 0;
        int tiaoshu = 0;
        if (File.Exists(Server.MapPath("~/topic/" + Session["ZtJianch"].ToString() + "/config.txt")))
        {
            string[] configs = File.ReadAllLines(Server.MapPath("~/topic/" + Session["ZtJianch"].ToString() + "/config.txt"));
            int len = configs.GetLength(0);
            if (len > 1)
            {
                string config = configs.GetValue(len - 2).ToString();
                if (config.IndexOf("grade2") > -1)
                {
                    string[] c = config.Split(',');
                    titlelen = int.Parse(c[1]);
                    tiaoshu = int.Parse(c[2]);
                }
                else//默认二级页标题长度和条数
                {
                    titlelen = 70;
                    tiaoshu = 25;
                }
            }
            else//默认二级页标题长度和条数
            {
                titlelen = 70;
                tiaoshu = 25;
            }
        }
        else//默认二级页标题长度和条数
        {
            titlelen = 70;
            tiaoshu = 25;
        }
        ContentBLL conbll = new ContentBLL();
        count = conbll.GetCount("ztid='" + ztid + "'");
        IList<Lgwin.Model.Content> list = conbll.GetArticles(count, 1, "ztid='" + ztid + "' and auditing=1 ", "datee", true, out count);
        if (ztid == 147)
        {
            ztid = 148;
        }
        else if (ztid == 148)
        {
            ztid = 147;
        }
        count = conbll.GetCount("ztid='" + ztid + "'");
        IList<Lgwin.Model.Content> newlist = conbll.GetArticles(count, 1, "ztid='" + ztid + "' and auditing=1 ", "datee", true, out count);
        if (zt == 52)//2012迎新
        {
            if (ztid == 146 || ztid == 149||ztid==150)
            {
                result = ToHtml.bylist(list, newlist, ztid, zt, count, 20, titlelen);
            }
            else if (ztid == 147)
            {
                result = ToHtml.bylist(newlist, list, ztid, zt, count, 10, titlelen);
            }
          
            else
            {
                result = ToHtml.bylist(list, newlist, ztid, zt, count, 10, titlelen);
            }
            TextBox1.Text = result;
        }
        else if (zt == 57 || zt == 58)//十周年站庆各个子专题静态化
        {
            result = ToHtml.Tenyears(list, titlelen, 12, zt, ztid);
            TextBox1.Text = result;
        }
        else if (zt == 56)
        {
            TextBox1.Text ="此专题不存在二级页";
        }
        else if (zt == 65)
        {
            result = ToHtml.bylist2013shsj(list, ztid, zt, count, 25, titlelen);
            TextBox1.Text = result;
        }
        else if (zt==57)
        {
            result = ToHtml.bylist2(list, ztid, zt, count, 12, titlelen);
            TextBox1.Text = result;
        }
        else if (zt == 51)//2012年暑期社会实践
        {
            result = ToHtml.bylist1(list, ztid, zt, count, 25, titlelen);
            TextBox1.Text = result;
        }
        //else if (zt == 60)//特色名校
        //{
        //    result = ToHtml.bylist1(list, ztid, zt, count, 25, titlelen);
        //    TextBox1.Text = result;
        //}
        else if (zt == 66)//党的群众路线教育实践活动
        {
            result = ToHtml.bylist_public(list, ztid, zt, count, 25, titlelen);
            TextBox1.Text = result;
        }
        else if (zt == 64 && (ztid == 199 || ztid == 200))//2013毕业专题二级页一
        {
            result = ToHtml.bylist2013byj12(list, ztid, zt, count, 10, titlelen);
            TextBox1.Text = result;
        }
        else if (zt == 64 && (ztid == 201 || ztid == 202 || ztid == 203 || ztid == 204 || ztid == 205 || ztid == 206))//2013毕业专题二级页二
        {
            result = ToHtml.bylist2013byj(list, ztid, zt, count, 10, titlelen);
            TextBox1.Text = result;
        }
        else if (zt == 69 && (ztid == 231 || ztid == 233 || ztid == 234))//2013迎新专题二级页一 迎新快讯，新生导航，大学时代
        {
            result = ToHtml.bylist2013yingxin1(list, ztid, zt, count, 10, titlelen);
            TextBox1.Text = result;
        }
        else if (zt == 69 && (ztid == 232))//2013迎新专题二级页二  通知公告
        {
            result = ToHtml.bylist2013yingxin2(list, ztid, zt, count, 10, titlelen);
            TextBox1.Text = result;
        }
        else if (zt == 54)
        {
            ContentBLL bll = new ContentBLL();
            IList<Lgwin.Model.Content> cont = bll.getldartlist(ztid.ToString(), "t");
            result = ToHtml.list(cont, titlelen, tiaoshu, zt, ztid);
            TextBox1.Text = result;
        }
        else
        {
            result = ToHtml.list(list, titlelen, tiaoshu, zt, ztid);
            TextBox1.Text = result;
        }
        if (RadioButtonList1.SelectedIndex != (RadioButtonList1.Items.Count - 1))
            RadioButtonList1.SelectedIndex = RadioButtonList1.SelectedIndex + 1;
        else
            RadioButtonList1.SelectedIndex = 0;
    }
    protected void Button_sanji_Click(object sender, EventArgs e)
    {
        int count;
        string result = "";
        int zt = int.Parse(Session["ZtId"].ToString());
        if (zt == 54) return;
        int ztid = int.Parse(RadioButtonList1.SelectedValue);
        ContentBLL conbll = new ContentBLL();
        count = conbll.GetCount("ztid='" + ztid + "'");
        IList<Lgwin.Model.Content> list = conbll.GetArticles(count, 1, "ztid='" + ztid + "' and auditing=1", "id", true, out count);
        if (zt == 52)
        {
            result = ToHtml.manycon_toHtml(list, ztid);
            TextBox1.Text = result;
        }
        else if (zt == 51)
        {
            result = ToHtml.manycon_toHtml(list);
            TextBox1.Text = result;
        }
        else if (zt == 60)
        {
            result = ToHtml.manycon_toHtml(list);
            TextBox1.Text = result;
        }
        else
        {
            result = ToHtml.manycon_toHtml(list);
            TextBox1.Text = result;
        }

        if (RadioButtonList1.SelectedIndex != (RadioButtonList1.Items.Count - 1))
            RadioButtonList1.SelectedIndex = RadioButtonList1.SelectedIndex + 1;
        else
            RadioButtonList1.SelectedIndex = 0;
    }
    protected void Button_All3_Click(object sender, EventArgs e)
    {
        int count;
        int zt = int.Parse(Session["ZtId"].ToString());

        string result = "";
        ContentBLL conbll = new ContentBLL();
        count = conbll.GetCount("zt='" + zt.ToString() + "'");
        IList<Lgwin.Model.Content> list = conbll.GetArticles(count, 1, "zt='" + zt.ToString() + "'", "id", true, out count);
        if (zt == 52)
        {
            result = ToHtml.manycon_toHtml(list, 146);
            TextBox1.Text += result;
            TextBox1.Text += "成功生成" + count + "条！";
            return;
        }
        result = ToHtml.manycon_toHtml(list);
        TextBox1.Text += result;
        TextBox1.Text += "成功生成" + count + "条！";

    }
}
