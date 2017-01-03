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
using System.IO;
public partial class Lgwin_manage_VideoEdit : System.Web.UI.Page
{
    protected Video _video = new Video();
    protected VideoBLL vdobll = new VideoBLL();
    protected int _videoId;
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.chksess();
        _videoId = Request.QueryString["Id"] != null ? int.Parse(Request.QueryString["Id"].ToString()) : 0;
        if (!IsPostBack)
        {
            if (_videoId != 0)
            {
                _video = vdobll.GetVideoById(_videoId);
                Label_dangqian.Text = _video.Id.ToString();
                Label_name.Text = _video.Name;
                TextBox_href.Text = _video.Href;
                TextBox_From.Text = _video.From;
                TextBox_jianping.Text = _video.Recommend;
                TextBox_time.Text = _video.AddDate.ToString("yyyy-MM-dd");
                TextBox_title.Text = _video.Title;
            }
        }
    }
    protected void Button_up_Click(object sender, EventArgs e)
    {
        _video= vdobll.GetVideoById(int.Parse(Label_dangqian.Text));
        _video.Name = Label_name.Text;
        _video.Href = TextBox_href.Text.Trim();
        _video.From = TextBox_From.Text;
        _video.Recommend = TextBox_jianping.Text;
        _video.AddDate = DateTime.Parse(TextBox_time.Text);
        _video.Title = TextBox_title.Text;

        if (_video.Type=="视频")
        {
            if (vdobll.Update(_video))
            {
                ToHtml.singleVideo_toHtml(_video);
                Mystring.alertAndRedirect("更新成功！", "VideoManage.aspx?Type=0");
            }
        }
        else
        {
            if (vdobll.Update(_video))
            {
                ToHtml.singleMusic_toHtml(_video);
                Mystring.alertAndRedirect("更新成功！", "VideoManage.aspx?Type=1");
            }
        }
    }
    protected void Button_cancel_Click(object sender, EventArgs e)
    {
        Mystring.Back();
    }
}
