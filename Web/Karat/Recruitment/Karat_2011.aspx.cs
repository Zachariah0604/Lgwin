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
    public partial class Karat_2011 : System.Web.UI.Page
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
                    mod.Name = TextBox1.Text;
                    mod.Sex = DropDownList1.Text;
                    mod.Xuehao = TextBox2.Text;
                    mod.Xueyuan = TextBox4.Text;
                    mod.Her = TextBox3.Text;
                    mod.Diannao = DropDownList2.Text;
                    mod.Renzhi = TextBox6.Text;
                    mod.Xiaoqu = TextBox5.Text;
                    mod.Zhiwei = DropDownList3.Text;
                    mod.Email = TextBox9.Text;
                    mod.Jianjie = TextBox11.Text;
                    mod.Tel = TextBox7.Text;
                    mod.Touxiang = filename;
                    mod.Jingli = TextBox12.Text;
                    mod.Qq = TextBox8.Text.ToString();
                    mod.Zuopin = TextBox13.Text;
                    mod.Ip = Page.Request.UserHostAddress;
                    mod.HostName = Page.Request.UserHostName;
                    mod.Qita = TextBox10.Text;
                    new KaratBLL().Karat_Baoming(mod);
                    Response.Write("<script language=javascript>alert('为了网络信息安全，您的的IP已经被记录！报名成功！请等待我们审核！！！');self.location='http://lgwindow.sdut.edu.cn/Karat/index.html'</script>");
 
                }
                else
                {
                    Mystring.alert("图片格式不支持，请上传jpg，jpeg，gif等格式图片");
                }
            }
          
        }
 

    }
}