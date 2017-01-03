using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using Lgwin.Pic;
using System.Data.SqlClient;
using Lgwin.Model;
using Lgwin.BLL;

public partial class photo_upload1 : System.Web.UI.Page
{
    public string path = "";
    static string olestr = System.Configuration.ConfigurationManager.AppSettings["connStr"].ToString();
    SqlConnection conn = new SqlConnection(olestr);
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
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
            Photo mod = new Photo();
            mod.name = name_old;
            mod.zhtID = Convert.ToInt32(DropDownList1.SelectedValue);
            mod.shuoming = TextBox2.Text;
            mod.zuozhe = TextBox1.Text;
            mod.path = name_new;
            mod.path_small = name_new_small;
            mod.zhtname = DropDownList1.SelectedItem.Text;

            bool flag = new PhotoBLL().sdut_upload(mod);
            if (flag == true)
            { Mystring.alert("上传成功！！！"); }
            else { Mystring.alert("上传失败！！！"); }
        }
        else
        {
            Response.Write("文件不存在…请检查文件是否存在");
        }

        TextBox_name.Text = "";
        TextBox1.Text = "";
        TextBox2.Text = "";
    }

}
