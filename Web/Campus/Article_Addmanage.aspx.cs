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
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Threading;
using System.Collections.Generic;
using System.Globalization;
using System.Drawing;


public partial class Article_Addmanage : System.Web.UI.Page
{
    private static string ConStr = System.Configuration.ConfigurationSettings.AppSettings["connStr"].ToString();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            Color bg = Color.FromArgb(165, 165, 165);
            if (chkAdmin(Session["Admin"].ToString(), 1))
            {
                Editor.ReadOnly = false;
            }
            else
            {
                Editor.ReadOnly = true;
                Editor.BackColor = bg;
            }
            Editor.Text = Session["Name"].ToString();
        }
        //return editor;

        // Date.Text = DateTime.Now.ToString("yyyy-MM-dd", DateTimeFormatInfo.InvariantInfo);
    }
    /// <summary>
    /// 只有高级以上管理员能改编辑者
    /// </summary>
    /// <param name="dangqian"></param>
    /// <param name="yaoqiu"></param>
    /// <returns></returns>
    public static bool chkAdmin(string dangqian, int yaoqiu)
    {
        int dangint = int.Parse(dangqian.Trim());
        if (dangint > yaoqiu)
        {

            return false;
        }
        else
            return true;

    }
    protected void Button_submit_Click(object sender, EventArgs e)
    {
        string url;
        string editor;
        editor = Editor.Text.ToString();
        Random ran = new Random();
        DateTime datetime = DateTime.Now;
        url = datetime.Year.ToString() + datetime.Month + datetime.Day + datetime.Hour.ToString() + datetime.Millisecond.ToString() + ran.Next(1000, 9999).ToString() + ".html";
        string cmd = "INSERT INTO article (Title,SubTitle,LanMu,Date,URL,[Content],Author,Audited,Phone,_Index,Recommend,Editor,[From]) VALUES ('" + Title.Text.Trim() + "','" + SubTitle.Text.Trim() + "','" + DropDownList_lanmu.SelectedItem.ToString() + "','" + Date.Text + "','" + url.ToString() + "','" + Editor1.Text.ToString() + "','" + Author.Text + "','" + Audited.Checked.ToString().Trim() + "','" + Phone.Text.ToString().Trim() + "','" + index.Checked.ToString() + "','" + recommend.Checked.ToString() + "','" + editor.ToString() + "','" + From.Text.ToString() + "')";
        SqlConnection Con = new SqlConnection(ConStr);
        Con.Open();
        SqlCommand Com = new SqlCommand(cmd, Con);
        int i = 0;
        i = Com.ExecuteNonQuery();
        if (i != 0)
        {
            Response.Write("<script>alert('添加成功！');location='To_Html_03/To_html_03.aspx'</script>");
        }
        Con.Close();
    }
    protected void Button_cancel_Click(object sender, EventArgs e)
    {
        Response.Write("<script>location='Article Addmanage.aspx'</script>");
    }
}
