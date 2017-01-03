using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using Lgwin.BLL;
using Lgwin.Model;
using Count;
using Lgwin.SqlDAL;
using Lgwin.Pic;

namespace Lgwin.TouGao
{
    public partial class Tougao : System.Web.UI.Page
    {
        public string path = "";
        static string olestr = System.Configuration.ConfigurationManager.AppSettings["connStr"].ToString();
        SqlConnection conn = new SqlConnection(olestr);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Panel7.Visible = false;
                Panel2.Visible = false;
                CollegeBLL bll = new CollegeBLL();
                IList<College> list = bll.GetCollegeList();
                from_to.DataSource = list;
                from_to.DataTextField = "name";
                from_to.DataBind();
                from_to.Items.Insert(0, "  ----请选择来源----");
                smallclass.Items.Clear();
                smallclass.Items.Insert(0, "院部传真");
                smallclass.Items.Add("理工要闻");
                smallclass.Items.Add("教学研究");
                smallclass.Items.Add("理工人物");
                smallclass.Items.Add("学生工作");
                smallclass.Items.Add("学风建设");
                smallclass.Items.Add("资讯公告");
                smallclass.Items.Add("其他");
                smallclass.DataBind();
                string sql1 = "SELECT [Content] FROM article where title='投稿公告管理' ";
                SqlDataReader dr1 = xlxy.dr(sql1);
                while (dr1.Read())
                {
                    conte.Text = dr1["Content"].ToString();
                    Editor1.Text = dr1["Content"].ToString();
                }
            }
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (bigclass.SelectedItem.Text)
            {
                case "校园文化": { Panel7.Visible = true; Panel1.Visible = false; Panel2.Visible = false; Panel3.Visible = true; Panel4.Visible = true; Panel5.Visible = true; Panel6.Visible = true; campusbind(); } break;
                case "新闻网": { Panel7.Visible = false; Panel1.Visible = true; Panel2.Visible = false; Panel3.Visible = true; Panel4.Visible = true; Panel5.Visible = true; Panel6.Visible = true; newsbind(); } break;
                case "光影理工": { Panel7.Visible = false; Panel1.Visible = false; Panel2.Visible = true; Panel3.Visible = false; Panel4.Visible = false; Panel5.Visible = false; Panel6.Visible = false; gylgbind(); } break;
                default: break;
            }
        }
        protected void campusbind()
        {
            smallclass.Items.Clear();
            smallclass.Items.Insert(0, "菁菁校园");
            smallclass.Items.Add("名家讲坛");
            smallclass.Items.Add("稷下时评");
            smallclass.Items.Add("人物访谈");
            smallclass.Items.Add("原创视频");
            smallclass.Items.Add("文学原创");
            smallclass.Items.Add("生活视界");
            smallclass.Items.Add("E路同行");
            smallclass.Items.Add("其他");
            smallclass.DataBind();
        }
        protected void newsbind()
        {
            smallclass.Items.Clear();
            smallclass.Items.Insert(0, "院部传真");
            smallclass.Items.Add("理工要闻");
            smallclass.Items.Add("教学研究");
            smallclass.Items.Add("理工人物");
            smallclass.Items.Add("学生工作");
            smallclass.Items.Add("学风建设");
            smallclass.Items.Add("资讯公告");
            smallclass.Items.Add("其他");
            smallclass.DataBind();
        }
        protected void gylgbind()
        {
            smallclass.Items.Clear();
            smallclass.Items.Add("光影专题");
            smallclass.Items.Add("理工表情");
            smallclass.Items.Add("大学时代");
            smallclass.Items.Add("行摄天下");
            smallclass.Items.Add("秀丽校园");
            smallclass.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            Model.Content mod = new Model.Content();
            ContentBLL conbll = new ContentBLL();
            //mod.Title = title.Text;
            //mod.Subtitle = subtitle.Text;
            //mod.Fro = from_to.SelectedItem.Text;
            //mod.Contents = conte.Text;
            //mod.Author = author.Text;
            //mod.Caption = smallclass.SelectedItem.Text;
            //mod.Tel = tel.Text;
            //mod.Datee = DateTime.Now;
            //mod.Tuwen = false;//hot
            //mod.Url = "0";
            //mod.Counter = 0;
            //mod.Editor = "";


            mod.Author = author.Text.Trim();
            mod.Caption = smallclass.SelectedItem.Text;
            mod.Contents = conte.Text;
            mod.Counter = 0;
            mod.Datee = DateTime.Now.Date;
            mod.Fro = from_to.SelectedItem.Text;
            mod.Html = false;
            mod.Subtitle = subtitle.Text.Trim();
            mod.Tel = tel.Text.Trim();
            mod.Title = title.Text.Trim();
            mod.Auditing = false;
            mod.StateNow = 0;



            if (smallclass.Text == "请选择栏目")
            {
                Response.Write("<script>alert('请选择文章栏目！')</script>");
            }
            else
            {
                //判断电话是否为INT型
                try
                {
                    decimal temp = Convert.ToDecimal(tel.Text);
                }
                catch
                {
                    Response.Write("<script>alert('请在半角状态下输入电话号码！')</script>");
                    goto loop;
                }
                if (bigclass.Text == "校园文化")
                {
                    Random ran = new Random();
                    DateTime datetime = DateTime.Now;
                    string url = datetime.Year.ToString() + datetime.Month + datetime.Day + datetime.Hour.ToString() + datetime.Millisecond.ToString() + ran.Next(1000, 9999).ToString() + ".html";
                    DBclass xywh = new DBclass();
                    if (xywh.ExecuteSql("insert into Campus_Article ([Lanmu],[Title],[Subtitle],[Author],[Content],[Editor],[Datee],[HitCount],[FromTo],[Tel],[ToUrl] ,[Keywords],[Pass],[TodayRec],[Daodu],[Hot],[IndexRec],[LgIndex] , [IsComment] , [TwoRec],[StateNow],[Ip] )"
                        + "values ('" + smallclass.Text + "','" + title.Text + "','" + subtitle.Text + "','" + author.Text + "','" + Editor1.Text + "','','" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "',0,'" + from_to.SelectedValue + "','" + tel.Text + "','0','','false','false','false','false','false','false','false','false',0,'" + Page.Request.UserHostAddress + "')") > 0)
                        Mystring.alertAndRedirect("投稿成功，请等待我们编辑审核，谢谢您的来稿！", "http://lgwindow.sdut.edu.cn/");
                }
                else
                {
                    if (conbll.Add(mod))
                    {
                        Mystring.alertAndRedirect("投稿成功，请等待我们编辑审核，谢谢您的来稿！", "http://lgwindow.sdut.edu.cn/");
                    }
                }


            loop: ;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            #region 上传光影理工

            int width = int.Parse(TextBox_w.Text);
            path = Server.MapPath("~") + "/photo/admin/photo/" + DropDownList1.SelectedValue + "/";
            string name_old = FileUpload1.FileName.Remove(FileUpload1.FileName.Length - 4);
            if (TextBox_name.Text.Trim() != "")
                name_old = TextBox_name.Text.Trim();
            string name_new = DateTime.Now.ToString("yyyyMMddhhmmss") + ".jpg";
            string name_new_lin = DateTime.Now.ToString("yyyyMMddhhmmss") + "lin.jpg";
            string name_new_small = DateTime.Now.ToString("yyyyMMddhhmmss") + "small.jpg";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(path + name_new_lin);
                image im = new image();
                im.t(path + name_new_lin, path + name_new, 800, 500, 100, false);
                im.t(path + name_new_lin, path + name_new_small, 80, 50, 90, false);
                File.Delete(path + name_new_lin);
                string sqlstr = "insert into [Photo_photo] ([name],[zhtID],[shuoming],[zuozhe],[path],[path_small],[zhtname],[xshshch]) values ('" + name_old + "','" + DropDownList1.SelectedValue + "','" + TextBox2.Text + "','" + TextBox1.Text + "','" + name_new + "','" + name_new_small + "','" + DropDownList1.SelectedItem.Text + "','" + 1 + "')";
                //xlxy.oleNoQ(sqlstr);
                conn.Open();
                SqlCommand olecmd = new SqlCommand(sqlstr, conn);
                int i = olecmd.ExecuteNonQuery();
                if (i > 0)
                {
                    Response.Write("<script>alert('操作成功');self.location='http://lgwindow.sdut.edu.cn/'</script>");
                }
                else
                {
                    Mystring.alert("添加失败！");
                }
                conn.Close();
            }
            else
            {
                Response.Write("文件不存在…请检查文件是否存在");
            }
            TextBox_name.Text = "";
            TextBox1.Text = "";
            TextBox2.Text = "";

            #endregion
        }
    }
}