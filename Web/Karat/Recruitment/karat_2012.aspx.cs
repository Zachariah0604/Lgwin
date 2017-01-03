using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using Lgwin.BLL;
using Lgwin.Model;

namespace Lgwin.Karat.Recruitment
{
    public partial class karat_2012 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
             Model.Karatbaoming mod = new Model.Karatbaoming();
            string filename = "";
            if (FileUpload1.HasFile)
            {
                string exten = Path.GetExtension(FileUpload1.PostedFile.FileName).ToUpper();
                if (exten == ".JPG" || exten == ".JPEG" || exten == ".GIF")
                {
                    filename = DateTime.Now.ToString("yyyyMMddhhmmss");
                    string url = "karat/images/touxiang/" + DateTime.Now.Year.ToString() + "/" + DateTime.Now.Month.ToString();
                    string path = Server.MapPath("~/") + url;
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    FileUpload1.PostedFile.SaveAs(path + "/" + filename + exten);
                    filename = "../images/touxiang/" + DateTime.Now.Year.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + filename + exten;
                    mod.Name = TextBox2.Text;//姓名
                    mod.Sex = DropDownList1.Text;//性别
                    //mod.Xuehao = TextBox2.Text;
                    mod.Xueyuan = TextBox5.Text;//学院
                    mod.Her = TextBox3.Text;//籍贯
                    mod.Banji = TextBox4.Text;
                    mod.Diannao = RadioButtonList1.SelectedItem.Text;//电脑
                    mod.Renzhi = TextBox13.Text;// 社团职务
                    mod.Xiaoqu = TextBox6.Text;//小区
                    mod.Zhiwei = RadioButtonList4.SelectedItem.Text.Trim();//应聘职位
                    mod.Email = TextBox7.Text;//邮箱
                    mod.Jianjie = TextBox17.Text;//兴趣爱好
                    mod.Tel = TextBox8.Text;//电话
                    mod.Touxiang = filename;//头像
                    mod.Jingli = TextBox18.Text;//特长
                    mod.Qq = TextBox9.Text.ToString();//qq
                    mod.Zuopin = TextBox20.Text;//作品
                    mod.club_exp = TextBox11.Text;//社团经历
                    mod.orge_exp = RadioButtonList5.SelectedItem.Text;//组织策划
                    mod.get_award = TextBox14.Text;//获取奖励
                    mod.write_able = RadioButtonList2.SelectedItem.Text;//写作能力
                    mod.grade = RadioButtonList3.SelectedItem.Text;//学习成绩
                    mod.freetime = TextBox19.Text;//空闲时间
                    mod.work_time = TextBox16.Text;//工作时间
                    mod.Ip = Page.Request.UserHostAddress;
                    mod.HostName = Page.Request.UserHostName;
                    mod.Qita = TextBox10.Text;
                    new KaratBLL().Karat_BaomingT(mod);
                    Response.Write("<script language=javascript>alert('为了网络信息安全，您的的IP已经被记录！报名成功！请等待我们审核！！！');self.location='http://lgwindow.sdut.edu.cn/Karat/index.html'</script>");
 
                }
                else
                {
                    Mystring.alert("图片格式不支持，请上传jpg，jpeg，gif等格式图片");
                }
            }
          
        }

       

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox9.Text = "";
            TextBox14.Text = "";
            TextBox16.Text = "";
            TextBox19.Text = "";
            TextBox20.Text = "";
            TextBox18.Text = "";
            TextBox8.Text = "";
            TextBox17.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox6.Text = "";
            TextBox5.Text = "";
            TextBox7.Text = "";
            TextBox13.Text = "";
            TextBox10.Text = "";
            TextBox2.Text = "";
        }


    }
}   
    
