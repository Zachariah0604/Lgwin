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
    public partial class karat_2013 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2013_Click(object sender, EventArgs e)
        {
             Model.Karatbaoming mod = new Model.Karatbaoming();
            string filename = "";
            if (FileUpload2013.HasFile)
            {
                string exten = Path.GetExtension(FileUpload2013.PostedFile.FileName).ToUpper();
                if (exten == ".JPG" || exten == ".JPEG" || exten == ".GIF")
                {
                    filename = DateTime.Now.ToString("yyyyMMddhhmmss");
                    string url = "karat/images/touxiang/" + DateTime.Now.Year.ToString() + "/" + DateTime.Now.Month.ToString();
                    string path = Server.MapPath("~/") + url;
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    FileUpload2013.PostedFile.SaveAs(path + "/" + filename + exten);
                    filename = "../images/touxiang/" + DateTime.Now.Year.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + filename + exten;
                    mod.Name = name2013.Text;//姓名
                    mod.Sex = sex2013.Text;//性别
                    //mod.Xuehao = TextBox2.Text;
                    mod.Xueyuan = xueyuan2013.Text;//学院
                    mod.Her = jiguan2013.Text;//籍贯
                    mod.Banji = banji2013.Text;//班级
                    mod.Diannao = computer2013.SelectedItem.Text;//电脑
                    mod.Renzhi = jingyan2013.Text;// 校外工作经验
                    mod.Xiaoqu = sushe2013.Text;//宿舍
                    mod.Zhiwei = zhiwei2013.SelectedItem.Text.Trim();//应聘职位
                    mod.Kaoyan = kaoyan2013.SelectedItem.Text;//是否考研,2013年新增字段
                    mod.Email = mail2013.Text;//邮箱
                    mod.Jianjie = aihao2013.Text;//兴趣爱好
                    mod.Tel = tel2013.Text;//电话
                    mod.Touxiang = filename;//头像
                    mod.Jingli = techang2013.Text;//特长
                    mod.Qq = qq2013.Text.ToString();//qq
                    mod.Zuopin = zuopin2013.Text;//作品
                    mod.club_exp = shetuan2013.Text;//社团经历
                    mod.orge_exp = cehua2013.SelectedItem.Text;//组织策划
                    mod.get_award = jiangli2013.Text;//获取奖励
                    mod.write_able = write2013.SelectedItem.Text;//写作能力
                    mod.grade = yuyan2013.SelectedItem.Text;//语言表达能力
                    mod.freetime = kongxian2013.Text;//空闲时间
                    mod.work_time = work2013.Text;//工作时间
                    mod.Ip = Page.Request.UserHostAddress;
                    mod.HostName = Page.Request.UserHostName;
                    mod.Qita = other2013.Text;//其他联系方式
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
            name2013.Text = "";
            sex2013.Text = "";
            xueyuan2013.Text = "";
            jiguan2013.Text = "";
            banji2013.Text = "";
            jingyan2013.Text = "";
            sushe2013.Text = "";
            mail2013.Text = "";
            aihao2013.Text = "";
            tel2013.Text = "";
            techang2013.Text = "";
            zuopin2013.Text = "";
            shetuan2013.Text = "";
            jiangli2013.Text = "";
            kongxian2013.Text = "";
            work2013.Text = "";
            other2013.Text = "";
        }


    }
}   
    
