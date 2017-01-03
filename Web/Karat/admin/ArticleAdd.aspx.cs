using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lgwin.BLL;
using Lgwin.Model;
using Count;

public partial class karat1_admin_ArticleAdd : System.Web.UI.Page
{
    public static string reurl = "Index.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.karatchksess();
        int id = 0;
        id = Convert.ToInt32(Request.QueryString["id"]);
        if (!IsPostBack)
        {
            if (id > 0)
            {
                Karat mod = new Karat();
                mod = new KaratBLL().GetKaratArticle(id);
                title.Text = mod.Title;
                subtitle.Text = mod.SubTitle;
                zt1.Text = mod.LanMu;
                datee.Text = mod.Time.ToString();
                datee.Attributes.Add("onFocus", "setday(this)");
                Label1.Text = mod.Url;
                Editor1.Text = mod.Content;
                author.Text = mod.Author;
                switch (mod.LanMu)
                {
                    case "卡瑞特心语": reurl = "ArticleManage.aspx"; break;
                    case "团队动态": reurl = "DongtaiManage.aspx"; break;
                };
                if (mod.IndexComment == true)
                {
                    DropDownList2.Text = "是";
                }
                else
                    DropDownList2.Text = "否";
                if (mod.Pass == true)
                {
                    DropDownList1.Text = "已审核";
                }
                else
                    DropDownList1.Text = "未审核";
            }
            else
            {
                datee.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                datee.Attributes.Add("onFocus", "setday(this)");
                author.Text = Session["Name"].ToString();
            }
        }
        if (id == 0)
        {
            datee.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            datee.Attributes.Add("onFocus", "setday(this)");
            author.Text = Session["Name"].ToString();

        }

    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        int id = 0;
        id = Convert.ToInt32(Request.QueryString["id"]);
        if (id > 0)
        {
            Karat mod = new Karat();
            mod.Title = title.Text;
            mod.SubTitle = subtitle.Text;
            mod.LanMu = zt1.Text;
            //mod.Time = Convert.ToDateTime(datee);
            mod.Time = Convert.ToDateTime(datee.Text);
            //mod.Url = DateTime.Now.ToString("yyyyMMddHHmmssfffffff") + ".html";
            mod.Url = Label1.Text;
            mod.Content = Editor1.Text;

            mod.Author = author.Text;
            mod.IndexComment = true;
            mod.Id = id;
            if (DropDownList2.Text == "是")
            {
                mod.IndexComment = true;
            }
            else
                mod.IndexComment = false;
            if (DropDownList1.Text == "已审核")
            {
                mod.Pass = true;
            }
            else
                mod.Pass = false;
            bool flag = new KaratBLL().ArticleUpdate(mod);

            Response.Write("<script language=javascript>alert('操作成功！');</script>");
            switch (mod.LanMu)
            {
                case "卡瑞特心语": Response.Redirect("ArticleManage.aspx"); break;
                case "团队动态": Response.Redirect("DongtaiManage.aspx"); break;
                default: break;
            };

        }
        else
        {
            Karat mod = new Karat();
            mod.Title = title.Text;
            mod.SubTitle = subtitle.Text;
            mod.LanMu = zt1.Text;
            //mod.Time = Convert.ToDateTime(datee);
            mod.Time = DateTime.Now;
            mod.Url = DateTime.Now.ToString("yyyyMMddHHmmssfffffff") + ".html";
            mod.Content = Editor1.Text;
            mod.Author = author.Text;
            mod.IndexComment = true;
            if (DropDownList2.Text == "是")
            {
                mod.IndexComment = true;
            }
            else
                mod.IndexComment = false;
            if (DropDownList1.Text == "已审核")
            {
                mod.Pass = true;
            }
            else
                mod.Pass = false;
            bool flag = new KaratBLL().ArticleAdd(mod);
            Response.Write("<script language=javascript>alert('操作成功！');self.location='Index.aspx'</script>");
 
        }


    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect(reurl);
    }
}
