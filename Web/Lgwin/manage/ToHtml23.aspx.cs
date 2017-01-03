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

public partial class Lgwin_manage_ToHtml23 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.chksess();
    }
    protected void Button_list_Click(object sender, EventArgs e)
    {
        int count;
        string result = "";
        string classname = RadioButtonList1.SelectedItem.Text;
        int classtid = int.Parse(RadioButtonList1.SelectedValue);
        if (classname == "废稿")
        {
            return;
        }
        if (classname == "稿件排行")
        {
            TextBox1.Text = ToHtml.Paihanglist();
        }
        else if(classname=="视频理工")
        {
            int vcount;
            VideoBLL vdobll=new VideoBLL();
            vcount=vdobll.GetCount("[Type]='视频'");
            IList<Video> vlist=vdobll.GetVideoList(vcount,1,"[Type]='视频'",out vcount);
            TextBox1.Text = ToHtml.videolist(vlist, 36, 25, classname, classtid);
            TextBox1.Text += "您真棒！成功生成了\"" + classname + "\"的二级列表页！";
        }
        else
        {
            ContentBLL conbll = new ContentBLL();
            count = conbll.GetCount("caption='" + classname + "' and  auditing = 'true'");
            //IList<Lgwin.Model.Content> list = conbll.GetArticles(count, 1, "caption='" + classname + "'", "id", true, out count);
            IList<Lgwin.Model.Content> list = conbll.GetList(count, 1, "caption='" + classname + "' and  auditing = 'true'", out count);
            result = ToHtml.classlist(list, 36, 25, classname, classtid);
            TextBox1.Text = result;
            TextBox1.Text += "您真棒！成功生成了\"" + classname + "\"的二级列表页！";
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
        string classname = RadioButtonList1.SelectedItem.Text;
        int classtid = int.Parse(RadioButtonList1.SelectedValue);
        if (classname == "废稿")
        {
            return;
        }
        if (classname == "视频理工")
        {
            int countvdieo = 0;
            VideoBLL vdobll = new VideoBLL();
            countvdieo = vdobll.GetCount("[Type]='视频'");
            IList<Video> vdolist = vdobll.GetVideoList(countvdieo, 1, "[Type]='视频'", out countvdieo);
            result = ToHtml.manyVideo_toHtml(vdolist);
            countvdieo = vdobll.GetCount("[Type]='音频'");
            vdolist = vdobll.GetVideoList(countvdieo, 1, "[Type]='音频'", out countvdieo);
            result += ToHtml.manyMusic_toHtml(vdolist);
            ToHtml.WriteMusicList(vdolist);
            TextBox1.Text += result;
            //TextBox1.Text += "您真厉害！成功生成了" + countvdieo + "个新闻页！";
        }
        else
        {
            ContentBLL conbll = new ContentBLL();
            count = conbll.GetCount("caption='" + classname + "' and  auditing = 'true'");
            IList<Lgwin.Model.Content> list = conbll.GetArticles(count, 1, "caption='" + classname + "' and  auditing = 'true'", "id", true, out count);
            result = ToHtml.manycon_toHtml(list);
            TextBox1.Text = result;
            TextBox1.Text += "您真厉害！成功生成了" + count + "个新闻页！";
        }
        if (RadioButtonList1.SelectedIndex != (RadioButtonList1.Items.Count - 1))
            RadioButtonList1.SelectedIndex = RadioButtonList1.SelectedIndex + 1;
        else
            RadioButtonList1.SelectedIndex = 0;
    }   
}
