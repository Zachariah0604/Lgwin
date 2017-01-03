using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Lgwin.photo
{
    public partial class PhotoSearch : System.Web.UI.Page
    {
        private static string typ = "";
        private static string me = "";
        private static string key = "";
        private static string Zht = "";
        int page = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Attributes.Add("onkeydown", "EnterKeyClick('Button5');");
            if (!IsPostBack)
            {

                if (Request["type"] != null && Request["textfield"] != null)
                {

                    key = Request["textfield"].ToString().Replace("''", "");

                    typ = Request["type"].ToString().Replace("''", "");
                    Zht = Request["zht"].ToString().Replace("''", "");
                    typ += "";
                    key += "";
                    Zht += "";
                    if (Zht == "" || typ == "" || key == "" || key == "请输入关键字")
                        caption.Text = "对不起,请输入搜索关键字！";
                    //Mystring.alertAndRedirect("对不起,请输入搜索关键字！", "index.html", "top");
                    else
                        PageBind();
                    //alertAndBack("对不起,请输入搜索关键字！");
                }
            }
            else
                PageBind();
        }
        protected void PageBind()
        {
            string type = typ.Trim();
            string keywords = key.Trim();
            string website = Zht.Trim();
            string me = "";
            string sqll = "";
            string sqll2 = "";
            int count = 0;
            if (website == "光影专题")
            {
                switch (type)
                {
                    case "biaoti":
                        sqll = "select * from Photo_photo where [zuozhe] like '%" + keywords + "%' and [zhtname] like '%" + website + "%'and  redian='true' order by [id] desc";
                        sqll2 = "select count(*) from Photo_photo where [zuozhe] like '%" + keywords + "%' and [zhtname] like '%" + website + "%'and  redian='true' ";
                        me = "标题";
                        break;
                    case "zuozhe":
                        sqll = "select * from Photo_photo where [zuozhe] like '%" + keywords + "%' and [zhtname] like '%" + website + "%'and  redian='true' order by [id] desc";
                        sqll2 = "select count(*) from Photo_photo where [zuozhe] like '%" + keywords + "%' and [zhtname] like '%" + website + "%'and  redian='true'";
                        me = "作者";
                        break;

                    default:
                        break;
                }
                //PhotoBLL bll = new PhotoBLL();
                //List<Lgwin.Model.Photo> list = bll.GetPhotolist(15, 1, sqll, out count);
                Databind(sqll, sqll2, website, keywords, me);

            }
            if (website == "理工表情")
            {
                switch (type)
                {
                    case "biaoti":
                        sqll = "select * from Photo_photo where [zuozhe] like '%" + keywords + "%' and [zhtname] like '%" + website + "%'and  redian='true' order by [id] desc";
                        sqll2 = "select count(*) from Photo_photo where [zuozhe] like '%" + keywords + "%' and [zhtname] like '%" + website + "%'and  redian='true' ";
                        break;
                    case "zuozhe":
                        sqll = "select * from Photo_photo where [zuozhe] like '%" + keywords + "%' and [zhtname] like '%" + website + "%'and  redian='true' order by [id] desc";
                        sqll2 = "select count(*) from Photo_photo where [zuozhe] like '%" + keywords + "%' and [zhtname] like '%" + website + "%'and  redian='true'";
                        me = "作者";
                        break;

                    default:
                        break;
                }
                Databind(sqll, sqll2, website, keywords, me);


            }
            if (website == "大学时代")
            {
                switch (type)
                {
                    case "biaoti":
                        sqll = "select * from Photo_photo where [zuozhe] like '%" + keywords + "%' and [zhtname] like '%" + website + "%'and  redian='true' order by [id] desc";
                        sqll2 = "select count(*) from Photo_photo where [zuozhe] like '%" + keywords + "%' and [zhtname] like '%" + website + "%'and  redian='true' ";
                        me = "标题";
                        break;
                    case "zuozhe":
                        sqll = "select * from Photo_photo where [zuozhe] like '%" + keywords + "%' and [zhtname] like '%" + website + "%'and  redian='true' order by [id] desc";
                        sqll2 = "select count(*) from Photo_photo where [zuozhe] like '%" + keywords + "%' and [zhtname] like '%" + website + "%'and  redian='true' ";
                        me = "作者";
                        break;

                    default:
                        break;
                }

                Databind(sqll, sqll2, website, keywords, me);
            }
            if (website == "行摄天下")
            {
                switch (type)
                {
                    case "biaoti":
                        sqll = "select * from Photo_photo where [zuozhe] like '%" + keywords + "%' and [zhtname] like '%" + website + "%'and  redian='true' order by [id] desc";
                        sqll2 = "select count(*) from Photo_photo where [zuozhe] like '%" + keywords + "%' and [zhtname] like '%" + website + "%'and  redian='true' ";
                        me = "标题";
                        break;
                    case "zuozhe":
                        sqll = "select * from Photo_photo where [zuozhe] like '%" + keywords + "%' and [zhtname] like '%" + website + "%'and  redian='true' order by [id] desc";
                        sqll2 = "select count(*) from Photo_photo where [zuozhe] like '%" + keywords + "%' and [zhtname] like '%" + website + "%'and  redian='true'";
                        me = "作者";
                        break;

                    default:
                        break;
                }
                //PhotoBLL bll = new PhotoBLL();
                //IList<Lgwin.Model.Photo> list = bll.GetPhotolist(15, 1,sqll, out count);
                Databind(sqll, sqll2, website, keywords, me);
            }

            else
            {




                switch (type)
                {
                    case "biaoti":
                        sqll = "select * from Photo_photo where [name] like '%" + keywords + "%' and [zhtname] like '%" + website + "%'and redian='true' order by [id] desc ";
                        sqll2 = "select count(*) from Photo_photo where [name] like '%" + keywords + "%' and [zhtname] like '%" + website + "%'and  redian='true' ";
               me = "标题";
                        break;
                    case "zuozhe":
                        sqll = "select * from Photo_photo where [zuozhe] like '%" + keywords + "%' and [zhtname] like '%" + website + "%'and  redian='true' order by [id] desc";
                 sqll2 = "select count(*) from Photo_photo where [zuozhe] like '%" + keywords + "%' and [zhtname] like '%" + website + "%'and  redian='true'";
                  me = "作者";
                        break;

                    default:
                        break;
                }
                Databind(sqll, sqll2, website, keywords, me);
            }
        }

        protected void Databind(string sqll, string sqll2, string website, string keywords, string me)
        {
            lblCurrentPage.Visible = true;
            Button1.Visible = true;
            Button2.Visible = true;
            Button3.Visible = true;
            Button4.Visible = true;
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
            Label5.Visible = true;
            Label6.Visible = true;
            tolpage.Visible = true;
            Label4.Visible = true;
            TextBox1.Visible = true;
            Button5.Visible = true;
            string strcon = System.Configuration.ConfigurationManager.AppSettings["connStr"];
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sqll, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "photo");

            PagedDataSource objPds = new PagedDataSource();
            objPds.DataSource = ds.Tables[0].DefaultView;
            objPds.AllowPaging = true;
            objPds.PageSize = 16;

            int curpage = Convert.ToInt32(lblCurrentPage.Text);
            this.Button1.Enabled = true;
            this.Button2.Enabled = true;
            this.Button3.Enabled = true;
            this.Button4.Enabled = true;

            objPds.CurrentPageIndex = curpage - 1;
            this.tolpage.Text = objPds.PageCount.ToString();
            if (curpage == 1)
            {
                this.Button1.Enabled = false;
                this.Button3.Enabled = false;
            }
            if (curpage == objPds.PageCount)
            {
                this.Button2.Enabled = false;
                this.Button4.Enabled = false;
            }

            Repeater1.DataSource = objPds;
            Repeater1.DataBind();
            con.Close();



            SqlCommand cmd = new SqlCommand(sqll2, con);
            con.Open();
            int num = (int)cmd.ExecuteScalar();
            con.Close();

            caption.Text = "<font color=red>“" + website + "”</font>，关键词：<font color=red>“" + keywords + "”</font>；搜索类型：按<font color=red>" + me + "</font>搜索，共<font color=red>" + num.ToString() + "</font>条记录";


        }
        protected void Head_Click(object sender, EventArgs e)
        {
            this.lblCurrentPage.Text = "1";
            PageBind();
        }

        protected void Down_Click(object sender, EventArgs e)
        {
            this.lblCurrentPage.Text = Convert.ToString(Convert.ToInt32(lblCurrentPage.Text) + 1);
            PageBind();

        }

        protected void Up_Click(object sender, EventArgs e)
        {
            this.lblCurrentPage.Text = Convert.ToString(Convert.ToInt32(lblCurrentPage.Text) - 1);
            PageBind();
        }

        protected void Bottom_Click(object sender, EventArgs e)
        {
            this.lblCurrentPage.Text = this.tolpage.Text;
            PageBind();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Label6.Text = "";
            string s1 = TextBox1.Text;
            if (int.Parse(TextBox1.Text) <= int.Parse(this.tolpage.Text))
                {
                    this.lblCurrentPage.Text = this.TextBox1.Text;
                    PageBind();
                }
                else { Label6.Text = "所查页超出了总页量！";  
                    TextBox1.Text = "";
                }
           
               
          
         

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }


    }
}