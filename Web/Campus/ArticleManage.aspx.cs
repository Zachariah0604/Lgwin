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
using System.Globalization;

public partial class Campus_ArticleManage : System.Web.UI.Page
{
    public string strcon = ConfigurationSettings.AppSettings["connStr"];
    protected void Page_Load(object sender, EventArgs e)
    {
        //DropDownList1.Items.FindByValue("岁月理工").Selected = true;
        Button1.Attributes.Add("onclick","JavaScript:return confirm('确定删除选择项？')");
        if (!IsPostBack)
        {
            DropDownList1.Items.Insert(0, new ListItem("==选择栏目类型==", "0"));
            Grid_DataBind();
        }
    }
    protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
    {
        for (int i = 0; i <= GridView1.Rows.Count - 1; i++)
        {
            CheckBox cbox = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
            if (CheckBox2.Checked == true)
            {
                cbox.Checked = true;
            }
            else
            {
                cbox.Checked = false;
            }
        }
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        int i;
        //执行循环，保证每条数据都可以更新
        for (i = 0; i < GridView1.Rows.Count; i++)
        {
            //首先判断是否是数据行
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //当鼠标停留时更改背景色
                e.Row.Attributes.Add("onmouseover", "c=this.style.backgroundColor;this.style.backgroundColor='#00A9FF'");
                //当鼠标移开时还原背景色
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=c");
            }
        }
        //如果是绑定数据行 
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate)
            {
                ((LinkButton)e.Row.Cells[11].Controls[0]).Attributes.Add("onclick", "javascript:return confirm('你确认要删除：\"" + e.Row.Cells[1].Text + "\"吗?')");
            }
        }

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Grid_DataBind();
    }

    private void Grid_DataBind()
    {
        SqlConnection con = new SqlConnection(strcon);
        string strcmd = "";
        con.Open();
        if (DropDownList1.SelectedValue == "0")
        {
            strcmd = "select id,Title, LanMu, Date, Author, Audited, _Index,Editor, Recommend,Date,[From] from article order by Audited desc,id desc";
        }
        else
        {
            strcmd = "select id,Title, LanMu, Date, Author, Audited, _Index,Editor, Recommend,Date,[From] from article where LanMu='" + DropDownList1.SelectedValue + "' order by Audited desc,id desc";
        }
        SqlDataAdapter da = new SqlDataAdapter(strcmd, con);
        DataSet ds = new DataSet();
        da.Fill(ds, "article");
        GridView1.DataSource = ds;
        GridView1.DataBind();
        ds.Dispose();
        con.Close();
    }
    private void Grid_buttonclick_DataBind()
    {
        SqlConnection con = new SqlConnection(strcon);
        string strcmd = "";
        con.Open();
        strcmd = "select id,Title, LanMu, Date, Author, Audited, _Index,Editor, Recommend,Date,[From] from article where Audited=1 order by id desc";
        SqlDataAdapter da = new SqlDataAdapter(strcmd, con);
        DataSet ds = new DataSet();
        da.Fill(ds, "article");
        GridView1.DataSource = ds;
        GridView1.DataBind();
        ds.Dispose();
        con.Close();
 
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        Grid_DataBind();
    }
    
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string sqlstr = "delete from article where id='" + GridView1.DataKeys[e.RowIndex].Value.ToString() + "'";
        SqlConnection sqlcon = new SqlConnection(strcon);
        SqlCommand sqlcom = new SqlCommand(sqlstr, sqlcon);
        sqlcon.Open();
        sqlcom.ExecuteNonQuery();
        sqlcon.Close();
        Grid_DataBind();
    }
    //Button1.Attibutes.Add("onclick","javascript:return window.confirm('r u sure?')");
    protected void Button1_Click(object sender, EventArgs e)
    {
        //Response.Write("<script>alert('确认删除？')</script>");
        SqlConnection sqlcon = new SqlConnection(strcon);
        SqlCommand sqlcom;
        for (int i = 0; i <= GridView1.Rows.Count - 1; i++)
        {
            CheckBox cbox = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
            if (cbox.Checked == true)
            {

                string sqlstr = "delete from article where id='" + GridView1.DataKeys[i].Value + "'";
                sqlcom = new SqlCommand(sqlstr, sqlcon);
                sqlcon.Open();
                sqlcom.ExecuteNonQuery();
                sqlcon.Close();
            }
        }
        Grid_DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int n = 0;
        //int c = 0;

        if (this.GridView1.Rows.Count > 0)
        {
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                CheckBox ck = GridView1.Rows[i].FindControl("Checkbox1") as CheckBox;
                HiddenField hd = GridView1.Rows[i].FindControl("HiddenField1") as HiddenField;
                int id = int.Parse(hd.Value);
                if (ck.Checked)
                {
                    StringBuilder sb = new StringBuilder();
                    //string title = "";
                    string sql1 = "select * from article where id='" + id + "'";
                    string _id = "";
                    string title = "";
                    string subtitle = "";
                    string lanmu = "";
                    string date = "";
                    string author = "";
                    string from = "";
                    string content = "";
                    string editor = "";
                    string PLname="";
                    string PLneirong="";
                    string PLdate="";
                    string PL="";
                    string URL="";
                    SqlDataReader dr1 = xlxy.dr(sql1);
                    while (dr1.Read())
                    {
                        _id = dr1["id"].ToString();
                        title = dr1["Title"].ToString();
                        subtitle=dr1["SubTitle"].ToString();
                        lanmu=dr1["LanMu"].ToString();
                        date=dr1["Date"].ToString();
                        author=dr1["Author"].ToString();
                        from=dr1["From"].ToString();
                        content=dr1["Content"].ToString();
                        editor=dr1["Editor"].ToString();
                        URL=dr1["URL"].ToString();
                    }
                    dr1.Close();
                    string sql2 = "select * from Campus_comment where AID='" + id + "'";
                    SqlDataReader dr2=xlxy.dr(sql2);
                    while(dr2.Read())
                    {
                        PLname=dr2["name"].ToString();
                        PLneirong=dr2["comment"].ToString();
                        PLdate=dr2["datee"].ToString();
                        PL = sb.AppendFormat("<div style=\"font-size:12px;margin-top:10px\"><div style=\"float:left; color:#666\">&nbsp; {0}</div><div style=\"float:right; color:#666\">评论时间：{2}</div></br></br>&nbsp; {1}</div><hr / width=\"650px\" align=\"center\" style=\"border:1px #cccccc dotted\">", PLname, PLneirong, PLdate).ToString();
                    }
                    string texts = "";
                    texts = Myfile.Read_Model(Server.MapPath("model/xywh3.html"));
                    texts = texts.Replace("%%id%%", _id);
                    texts = texts.Replace("%%title%%", title);
                    texts = texts.Replace("%%subtitle%%", subtitle);
                    texts = texts.Replace("%%lanmu%%", lanmu);
                    texts = texts.Replace("%%date%%", date);
                    texts = texts.Replace("%%author%%", author);
                    texts = texts.Replace("%%from%%", from);
                    texts = texts.Replace("%%content%%", content);
                    texts = texts.Replace("%%editor%%", editor);
                    texts = texts.Replace("%%canshu%%", PL);
                    dr2.Close();
                    if (Myfile.File_Write(Server.MapPath("Html_03/") + URL.ToString(), texts, "utf-8"))
                    {
                        //string pagename = id.ToString() + ".html";
                        //xlxy.sqlNoQ("update [Photo_lmfenlei] set [pagename]='" + pagename + "' where [id]='" + id + "'");
                        Response.Write("<script>alert('操作成功');self.location='ArticleManage.aspx'</script>");
                    }
                    else
                    {
                        Mystring.alert("操作失败，请重试！！！");
                    }
                }
                else
                {
                    n++;
                }
            }
            if (n == this.GridView1.Rows.Count)
            {
                ClientScript.RegisterStartupScript(typeof(Page), "aa", "alert('至少应选择一项')", true);
            }
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Grid_buttonclick_DataBind();

    }


}