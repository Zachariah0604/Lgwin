
using System;
using System.Data;
using System.Collections;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Data.SqlClient;
using Lgwin.BLL;
using Lgwin.Old_App_Code;

public partial class xlxy_admin_manage : System.Web.UI.Page
{
    static string olestr = System.Configuration.ConfigurationManager.AppSettings["connStr"].ToString();
    SqlConnection conn = new SqlConnection(olestr);
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Attributes.Add("onkeydown", "EnterKeyClick('LinkButton1');");
       
                if (!IsPostBack)
                {
                    RadioButtonList1.DataBind();
                    if (RadioButtonList1.Items.Count != 0)
                        RadioButtonList1.Items[0].Selected = true;

                    DropDownList1.DataBind();
                    DropDownList1.Items.Insert(0, new ListItem("—选择栏目类型—", "0"));
                    Re_PageBind();
                }
    }
    
    public string getstring(string str)//将true或false转化为是或否的方法
    {
        string name = "";
        switch (str)
        {
            case "True":
                name = "是";
                break;
            case "False":
                name = "否";
                break;

        }
        return name;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("fenlei_man.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("stu_pic_manage.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("pic_upload.aspx");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        int n = 0;
        int c = 0;
        if (this.Repeater1.Items.Count > 0)
        {
            for (int i = 0; i < Repeater1.Items.Count; i++)
            {
                CheckBox ck = Repeater1.Items[i].FindControl("chkDelete") as CheckBox;
                HiddenField hd = Repeater1.Items[i].FindControl("HiddenField1") as HiddenField;
                int id = int.Parse(hd.Value);
                if (ck.Checked)
                {
                    if (conn.State.ToString().ToLower() == "open")
                    {
                        conn.Close();
                    }

                    conn.Open();



                    string sql = "select * from [Photo_photo] where [id]=" + id;

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    dr.Read();
                    string path = Server.MapPath("~") + "/photo/admin/photo/" + dr["zhtID"].ToString() + "/";
                    File.Delete(path + dr["path"].ToString());
                    File.Delete(path + dr["path_small"].ToString());
                    dr.Close();
                    conn.Close();
                    sql = "delete from [Photo_photo] where [id] = " + id;
                    c = xlxy.sqlNoQ(sql);


                }
                else
                {
                    n++;
                }

                if (n == this.Repeater1.Items.Count)
                {

                    ClientScript.RegisterStartupScript(typeof(Page), "aa", "alert('至少应选择一项')", true);
                }

            }
            if (c > 0)
            {
                Mystring.alert("删除成功！");
            }
            else
            {
                Mystring.alert("删除失败");
            }
        }
        PageBind();
    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList1.DataBind();
        DropDownList1.Items.Insert(0, new ListItem("—选择栏目类型—", "0"));
        Re_PageBind();
    }
    private void PageBind()
    {
        int zhtID = int.Parse(RadioButtonList1.SelectedValue);
        int lmid = int.Parse(DropDownList1.SelectedValue);

        int curpage = Convert.ToInt32(this.labPage.Text);
        PagedDataSource ps = new PagedDataSource();
        ps.DataSource = new PhotoBLL().select(zhtID, lmid).DefaultView;
        ps.AllowPaging = true; //是否可以分页
        ps.PageSize = 8; //显示的数量
        ps.CurrentPageIndex = curpage - 1; //取得当前页的页码
        this.lnkbtnUp.Enabled = true;
        this.lnkbtnNext.Enabled = true;
        this.lnkbtnBack.Enabled = true;
        this.lnkbtnOne.Enabled = true;
        if (curpage == 1)
        {
            this.lnkbtnOne.Enabled = false;//不显示第一页按钮
            this.lnkbtnUp.Enabled = false;//不显示上一页按钮
        }
        if (curpage == ps.PageCount)
        {
            this.lnkbtnNext.Enabled = false;//不显示下一页
            this.lnkbtnBack.Enabled = false;//不显示最后一页
        }
        this.labBackPage.Text = Convert.ToString(ps.PageCount);
        this.Repeater1.DataSource = ps;
        this.Repeater1.DataBind();


        if (Repeater1.Items.Count == 0)
        {
            Label1.Visible = true;
            Label1.Text = "没有数据";
        }
    }
    private void Re_PageBind()
    {
        int zhtID = int.Parse(RadioButtonList1.SelectedValue);
        int lmid = int.Parse(DropDownList1.SelectedValue);

        int curpage = Convert.ToInt32(this.labPage.Text);
        PagedDataSource ps = new PagedDataSource();
        ps.DataSource = new PhotoBLL().select(zhtID, lmid).DefaultView;
        curpage = 1;
        ps.AllowPaging = true; //是否可以分页
        ps.PageSize = 8; //显示的数量
        ps.CurrentPageIndex = curpage - 1; //取得当前页的页码
        this.lnkbtnUp.Enabled = true;
        this.lnkbtnNext.Enabled = true;
        this.lnkbtnBack.Enabled = true;
        this.lnkbtnOne.Enabled = true;
        if (curpage == 1)
        {
            this.lnkbtnOne.Enabled = false;//不显示第一页按钮
            this.lnkbtnUp.Enabled = false;//不显示上一页按钮
        }
        if (curpage == ps.PageCount)
        {
            this.lnkbtnNext.Enabled = false;//不显示下一页
            this.lnkbtnBack.Enabled = false;//不显示最后一页
        }
        this.labBackPage.Text = Convert.ToString(ps.PageCount);
        this.Repeater1.DataSource = ps;
        this.Repeater1.DataBind();
        if (Repeater1.Items.Count == 0)
        {
            Label1.Visible = true;
            Label1.Text = "没有数据";
        }
        this.labPage.Text = Convert.ToString(1);
    }

    public DataSet Ds(string sqlcmd)
    {
        if (conn.State.ToString().ToLower() == "open")
        {
            conn.Close();
            conn.Open();

        }
        SqlDataAdapter da = new SqlDataAdapter(sqlcmd, conn);
        DataSet ds = new DataSet();
        da.Fill(ds, "picture");
        conn.Close();
        return ds;
    }
    protected void lnkbtnOne_Click(object sender, EventArgs e)
    {
        this.labPage.Text = "1";
        this.PageBind();
    }
    protected void lnkbtnUp_Click(object sender, EventArgs e)
    {
        this.labPage.Text = Convert.ToString(Convert.ToInt32(this.labPage.Text) - 1);
        this.PageBind();
    }
    protected void lnkbtnNext_Click(object sender, EventArgs e)
    {
        this.labPage.Text = Convert.ToString(Convert.ToInt32(this.labPage.Text) + 1);
        this.PageBind();
    }
    protected void lnkbtnBack_Click(object sender, EventArgs e)
    {
        this.labPage.Text = this.labBackPage.Text;
        this.PageBind();
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.labPage.Text = "1";
        this.PageBind();

    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        #region MyRegion


        //光影专题（28）
        string texts = "";
        SqlDataReader dr1 = new PhotoBLL().Tohtml(7, "0", "1", 28, "Photo_photo");
        texts = Myfile.Read_Model(Server.MapPath("~") + "/photo/admin/model/index.model");
        int a = 1;
        while (dr1.Read())
        {
            texts = texts.Replace("%%gy_img" + a.ToString() + "%%", dr1["path"].ToString());
            texts = texts.Replace("%%gy_a" + a.ToString() + "%%", dr1["pagename"].ToString());
            texts = texts.Replace("%%gy_t" + a.ToString() + "%%", Mystring.lim_withoutPoint(dr1["name"].ToString(), 9));
            a++;
        }
        dr1.Dispose();
        dr1.Close();


        int b = 1;
        SqlDataReader dr2 = new PhotoBLL().Tohtml(4, "0", "1", 29, "Photo_photo");
        while (dr2.Read())
        {
            texts = texts.Replace("%%lg_img" + b.ToString() + "%%", dr2["path"].ToString());
            texts = texts.Replace("%%lg_a" + b.ToString() + "%%", dr2["pagename"].ToString());
            texts = texts.Replace("%%lg_t" + b.ToString() + "%%", Mystring.lim_withoutPoint(dr2["name"].ToString(), 8));
            b++;
        }
        int c = 1;
        SqlDataReader dr3 = new PhotoBLL().Tohtml(3, "0", "1", 31, "Photo_photo");
        while (dr3.Read())
        {
            texts = texts.Replace("%%ww_img" + c.ToString() + "%%", dr3["path"].ToString());
            texts = texts.Replace("%%ww_a" + c.ToString() + "%%", dr3["pagename"].ToString());
            texts = texts.Replace("%%ww_t" + c.ToString() + "%%", Mystring.lim_withoutPoint(dr3["name"].ToString(), 8));
            c++;
        }
        int d = 1;
        SqlDataReader dr4 = new PhotoBLL().Tohtml(10, "0", "1", 32, "Photo_photo"); while (dr4.Read())
        {
            texts = texts.Replace("%%xl_img" + d.ToString() + "%%", dr4["path"].ToString());
            texts = texts.Replace("%%xl_a" + d.ToString() + "%%", dr4["pagename"].ToString());
            texts = texts.Replace("%%xl_t" + d.ToString() + "%%", Mystring.lim_withoutPoint(dr4["name"].ToString(), 8));
            d++;
        }
        //大学时代（30),原光影专题
        SqlDataReader dr5 = new PhotoBLL().Tohtml(1, "0", "1", 30, "Photo_photo");
        if (dr5.Read())
        {
            texts = texts.Replace("%%dxsd_img1%%", dr5["path"].ToString());
            texts = texts.Replace("%%dxsd_a1%%", dr5["pagename"].ToString());
            texts = texts.Replace("%%dxsd_t1%%", dr5["name"].ToString());
        }

        //大学时代（30),原光影专题
        SqlDataReader dr6 = new PhotoBLL().DxTohtml(7, 30);
        StringBuilder sb6 = new StringBuilder();
        string text6 = "";
        while (dr6.Read())
        {
            text6 = sb6.AppendFormat("<tr> <td><a href=\"{0}\">{1}</a></td> </tr>", dr6["pagename"].ToString(), dr6["name"]).ToString();
        }
        texts = texts.Replace("%%dxsd%%", text6);

        SqlDataReader dr7 = new PhotoBLL().DxTohtml1(9, "0", "1", "1");
        StringBuilder sb7 = new StringBuilder();
        string text7 = "";
        while (dr7.Read())
        {
            text7 = sb7.AppendFormat("<tr> <td style=\"padding-left:40px\"><a href=\"{0}\">{1}</a></td> </tr>", dr7["pagename"].ToString(), Mystring.lim_withoutPoint(dr7["name"].ToString(), 6)).ToString();
        }

        texts = texts.Replace("%%shjjd%%", text7);

        SqlDataReader dr8 = new PhotoBLL().DxTohtml1(9, "0", "1", "1");
        StringBuilder sb8 = new StringBuilder();
        string text8 = "";
        while (dr8.Read())
        {
            text8 = sb8.AppendFormat("<li style=\"width:740px; height:410px\"><a href=\"{1}\" title=\"{0}\" target=\"_blank\"><img src=\"admin/photo/{2}/{3}\" style=\"width:740px; height:410px\" ></a><span class=\"title\">{0}</span></li>", Mystring.lim_withoutPoint(dr8["shuoming"].ToString(), 35), dr8["pagename"].ToString(), dr8["zhtID"].ToString(), dr8["path"].ToString()).ToString();
        }
        texts = texts.Replace("%%shjJS%%", text8);
        if (Myfile.File_Write(Server.MapPath("~") + "/photo/" + "index.html", texts, "utf-8"))
        {
            Response.Write("<script>alert('操作成功');self.location='manage.aspx'</script>");
        }
        else
        {
            Mystring.alert("首页静态化失败，请重试！！！");
        }
        #endregion

        #region 校园文化Iframe部分静态化


        string contents = "";
        contents = Myfile.Read_Model(Server.MapPath("~") + "/photo/admin/model/GYLG.model");
        //string sql17 = "select top 8  * from Photo_Photo where [xshshch]=0 and [shouye]=1 and  [tuijian]=1  order by id desc ";
        SqlDataReader dr17 = new PhotoBLL().DxTohtml1(8, "0", "1", "1");
        //SqlDataReader dr17 = xlxy.dr(sql17);
        StringBuilder sb17 = new StringBuilder();
        string text17 = "";
        while (dr17.Read())
        {
            text17 = sb17.AppendFormat("<td width=\"127\"><div class=\"lgwin_pics_list\"><div class=\"lgwin_pics_list_pic\"><a href=\"" + dr17["pagename"].ToString() + "\" target=\"_blank\"><img src=\"admin/photo/" + dr17["zhtID"].ToString() + "/" + dr17["path"].ToString() + "\" width=\"103\" height=\"136\" border=\"0\" title=\"" + dr17["name"].ToString() + "\"/></a></div><div class=\"lgwin_pics_list_text\"><a href=\"" + dr17["pagename"].ToString() + "\" target=\"_blank\" title=\"" + dr17["name"].ToString() + "\">" + Mystring.lim_withoutPoint(dr17["name"].ToString(), 5) + "</a></div></div></td>").ToString();
        }
        dr17.Dispose();
        dr17.Close();
        contents = contents.Replace("%%lgwin_pics_list%%", text17);
        Myfile.File_Write(Server.MapPath("~") + "/photo/" + "GYLG.html", contents, "utf-8");

        #endregion
    }

    protected void Button6_Click(object sender, System.EventArgs e)
    {
        int cnt = 0;
        int[] IDD = new int[10];
        string[] zht = new string[10];

        SqlDataReader dr30 = new PhotoBLL().lgbq();
        while (dr30.Read())
        {
            string name = dr30["name"].ToString();
            int id = Convert.ToInt32(dr30["id"]);
            zht[cnt] = name;
            IDD[cnt] = id;

            cnt++;
        }

        for (int i = 0; i < cnt; i++)
        {

            P_tohtmlcs.getzhtid(IDD[i], zht[i]);

        }
        //三级页静态化
        int id_max = 0;
        string sql9 = "select top 1 * from Photo_lmfenlei order by id desc ";
        SqlDataReader dr9 = xlxy.dr(sql9);
        if (dr9.Read())
        {
            id_max = int.Parse(dr9["id"].ToString());
        }
        dr9.Dispose();
        dr9.Close();
        for (int id = 0; id < id_max + 1; id++)
        {
            string sql = "select count (*) from Photo_lmfenlei where id=" + id;
            if (xlxy.sqlAc(sql) > 0)
            {
                StringBuilder sb = new StringBuilder();

                string pic = "";
                string zhtname = "";
                string lmname = "";
                string introduction = "";
                string zhtpagename = "";
                string sql10 = "select * from Photo_photo where [lmID]='" + id + "' order by upload_time desc";
                SqlDataReader dr10 = xlxy.dr(sql10);
                while (dr10.Read())
                {
                    pic = sb.AppendFormat("<ul class=\"ul\" > <li class=\"li_img\" ><a  href=\"admin/photo/{0}/{1}\" target=\"_blank\"  title=\" <table ><tr><td colspan=2><font size=2>{2}</font></td></tr><tr> <td ><Font color=#D988BA size=2 >作者:{3}</Font></td > </tr></table>\"   rel=\"lightbox[roadtrip]\"><img src=\"admin/photo/{0}/{1}\" title=\"{2}--作者:{3}--{4}上传\" alt=\"{2}--作者:{3}--{4}上传\" class=\"img_8\"/></a></li><li  class=\"li_text\"><a href=\"admin/photo/{0}/{1}\" target=\"_blank\" title=\"{2}\"   rel=\"lightbox[roadtrip]\"> {5}</a> </li></ul>", dr10["zhtID"].ToString(), dr10["path"].ToString(), dr10["shuoming"].ToString(), dr10["zuozhe"].ToString(), dr10["upload_time"].ToString(), Mystring.lim_withoutPoint(dr10["name"].ToString(), 10)).ToString();
                }
                dr10.Close();
                string sql11 = "select * from Photo_lmfenlei where [id]='" + id + "'";
                SqlDataReader dr11 = xlxy.dr(sql11);
                if (dr11.Read())
                {
                    introduction = dr11["introduction"].ToString();
                    zhtname = dr11["zhtname"].ToString();
                    lmname = dr11["name"].ToString();
                }
                dr11.Close();
                string sql12 = "select * from  Photo_zhtfenlei where [name]= '" + zhtname + "'";
                SqlDataReader dr12 = xlxy.dr(sql12);
                if (dr12.Read())
                {
                    zhtpagename = dr12["pagename"].ToString();
                }
                dr12.Close();
                string ts;
                ts = Myfile.Read_Model(Server.MapPath("~") + "/photo/admin/model/Default3.model");
                ts = ts.Replace("%%zhtpagename%%", zhtpagename);
                ts = ts.Replace("%%pic%%", pic);
                ts = ts.Replace("%%zhtname%%", zhtname);
                ts = ts.Replace("%%title%%", zhtname);
                ts = ts.Replace("%%lmname%%", lmname);
                ts = ts.Replace("%%introduction%%", introduction);
                if (Myfile.File_Write(Server.MapPath("~") + "/photo/" + id.ToString() + ".html", ts, "utf-8"))
                {
                    string pagename = id.ToString() + ".html";
                    xlxy.sqlNoQ("update [Photo_lmfenlei] set [pagename]='" + pagename + "' where [id]='" + id + "'");
                    Response.Write("<script>alert('操作成功');self.location='manage.aspx'</script>");
                }
                else
                {
                    Mystring.alert("三级页静态化失败，请重试！！！");
                }
            }
        }
    }

    protected void LinkButton1_Click(object sender, System.EventArgs e)
    {
        if (int.Parse(TextBox1.Text) <= int.Parse(labBackPage.Text))
        {
            this.labPage.Text = TextBox1.Text;
            this.PageBind();
        }
        else { Mystring.alert("所查页超出了总页量！"); }

        TextBox1.Text = "";
    }

}


