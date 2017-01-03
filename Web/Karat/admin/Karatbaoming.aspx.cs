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

public partial class karat1_admin_KaratBaoMing : System.Web.UI.Page
{
 
    protected void Page_Load(object sender, EventArgs e)
    {
 
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
       // Karat mod = new Karat();
       // string filename = "";
       // if (FileUpload1.HasFile)
       // {
       //     string exten = Path.GetExtension(FileUpload1.PostedFile.FileName).ToUpper();
       //     if (exten == ".JPG" || exten == ".JPEG" || exten == ".GIF")
       //     {
       //         filename = DateTime.Now.ToString("yyyyMMddhhmmss");
       //         string url = "karat/images/touxiang/" + DateTime.Now.Year.ToString() + "/" + DateTime.Now.Month.ToString();
       //         string path = Server.MapPath("~/") + url;
       //         if (!Directory.Exists(path))
       //         {
       //             Directory.CreateDirectory(path);
       //         }
       //         FileUpload1.PostedFile.SaveAs(path + "/" + filename + exten);
       //         filename = "../images/touxiang/" + DateTime.Now.Year.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + filename + exten;
       //     }
       //     else
       //     {
       //         Mystring.alert("图片格式不支持，请上传jpg，jpeg，gif等格式图片");
       //     }
       // }
       // mod.Name = TextBox1.Text;
       // mod.Xingbie = DropDownList1.Text;
       // mod.Yuanxi = TextBox2.Text;
       // mod.Zhuanye = TextBox4.Text;
       // mod.Xiaoqu = TextBox3.Text;
       // mod.Diannao = DropDownList2.Text;
       // mod.Email = TextBox5.Text;
       // mod.Jiguan = TextBox6.Text;
       // mod.Zhiwei = DropDownList3.Text;
       // mod.Blog = TextBox7.Text;
       // mod.Show = TextBox8.Text;
       // mod.TelTel = TextBox9.Text;
       // mod.Imgurl = filename;
       // mod.Jianjie = TextBox10.Text;

       // new KaratBLL().Karat_Baoming(mod);
       // nulll();
       //Response.Write("<script>alert('恭喜你！报名成功！');</script>");
       
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        nulll();
    }
    public void nulll()
    {
         TextBox1.Text = null;

        TextBox2.Text = null;
        TextBox4.Text = null;
        TextBox3.Text = null;

        TextBox5.Text = null;
        TextBox6.Text = null;

        TextBox7.Text = null;
        TextBox8.Text = null;
        TextBox9.Text = null;

        TextBox10.Text = null;
    }
}