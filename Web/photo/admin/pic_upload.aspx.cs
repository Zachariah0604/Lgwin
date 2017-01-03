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
using System.Data.SqlClient;
using Lgwin.Pic;
using Lgwin.BLL;
using Lgwin.Model;


public partial class xlxy_admin_pic_upload : System.Web.UI.Page
{    
    public string path = "";
    
    protected void Page_Load(object sender, EventArgs e)
    {

        Mystring.chksess();
        if (!IsPostBack)
        {
            
            TextBox3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, new ListItem("—选择专题类型—", "0"));
           
            DropDownList2.DataBind();
            DropDownList2.Items.Insert(0, new ListItem("—选择栏目类型—", "0"));
           
        }
        Image1.ImageUrl = "~/photo/images/shuiyin/backlogo1.png";
        Image2.ImageUrl = "~/photo/images/shuiyin/backlogo2.png";
        Image3.ImageUrl = "~/photo/images/shuiyin/backlogo3.png";
        Image4.ImageUrl = "~/photo/images/shuiyin/backlogo4.png";
        Image5.ImageUrl = "~/photo/images/shuiyin/backlogo5.png";
        Image6.ImageUrl = "~/photo/images/shuiyin/backlogo6.png"; 
         
    }
    protected void Button1_Click(object sender, EventArgs e)
    {    

        if (DropDownList2.SelectedValue == "0")
            {Response.Write("<script>alert('请选择栏目分类');self.location='pic_upload.aspx'</script>");}

    else {        
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
        if (FileUpload1.HasFile)//上传图片
        {
            
           
                path = Server.MapPath("~") + "/photo/admin/photo/" + DropDownList1.SelectedValue + "/";
                name_old = FileUpload1.FileName.Remove(FileUpload1.FileName.Length - 4);
                if (TextBox_name.Text.Trim() != "")
                {
                    name_old = TextBox_name.Text.Trim();
                }
                
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                FileUpload1.SaveAs(path + name_new_lin);
                image im = new image();
                im.t(path + name_new_lin, path + name_new, width, 500, 100, false);
                im.t(path + name_new_lin, path + name_new_small, width/10, 50, 90, false);
                File.Delete(path + name_new_lin);
                if (CheckBox1.Checked)
                {
                    kuan.Text = Convert.ToString(800);
                    ImageModification wm = new ImageModification();

                    wm.DrawedImagePath = Server.MapPath("~") + "/photo/images/shuiyin/" + "backlogo" + RadioButtonList1.SelectedValue + ".png";
                    wm.ModifyImagePath = path + name_new;

                    switch (RadioButtonList_weizhi.SelectedValue)
                    {
                        case "左":
                            {
                                wm.RightSpace = Convert.ToInt32(kuan.Text) - 30;
                                break;
                            }
                        case "右":
                            {
                                wm.RightSpace = 190;
                                break;
                            }
                        case "中":
                            {
                                wm.RightSpace = (int)(Convert.ToInt32(kuan.Text) / 2) + 80;
                                break;
                            }

                    }
                    wm.BottoamSpace = 50;
                    wm.LucencyPercent = 100;
                    string newfile = name_new.Substring(0, 14);
                    wm.OutPath = path + "/" + newfile + "_Marked.jpg";
                    wm.DrawImage();
                    File.Delete(path + name_new);
                    name_new = newfile + "_Marked.jpg";
                } 
                    //添加图片属性
                    string CheckBox2Text = "";
                    if (CheckBox2.Checked)
                    { 
                        CheckBox2Text = "1";
                    }
                    if (!CheckBox2.Checked)
                    {
                        CheckBox2Text = "0";
                    }
                    string CheckBox3Text = "";
                    if (CheckBox3.Checked)
                    {
                        CheckBox3Text = "1";
                    }
                    if (!CheckBox3.Checked)
                    {
                        CheckBox3Text = "0";
                    } string CheckBox4Text = "";
                    if (CheckBox4.Checked)
                    {
                        CheckBox4Text = "1";
                    }
                    if (!CheckBox4.Checked)
                    {
                        CheckBox4Text = "0";
                    } string CheckBox5Text = "";
                    if (CheckBox5.Checked)
                    {
                        CheckBox5Text = "1";
                    }
                    if (!CheckBox5.Checked)
                    {
                        CheckBox5Text = "0";
                    }
                    int id = Convert.ToInt32(DropDownList2.SelectedValue);

                    bool flag = new PhotoBLL().pic_upload1(id, "ID", "Photo_zhtfenlei");
                    string pagename2 = DropDownList2.SelectedValue.ToString() + ".html";
                    Photo mod = new Photo();
                    mod.name = name_old;
                    mod.zhtID = Convert.ToInt32(DropDownList1.SelectedValue);
                    mod.lmID = Convert.ToInt32(DropDownList2.SelectedValue);
                    mod.lmname = DropDownList2.SelectedItem.ToString();
                    mod.shuoming = TextBox2.Text;
                    mod.zuozhe = TextBox1.Text;
                    mod.path_small = name_new_small;
                    mod.path = name_new;
                    mod.zhtname = DropDownList1.SelectedItem.Text;
                    mod.tuijian = CheckBox2Text;
                    mod.shouye = CheckBox3Text;
                    mod.redian = CheckBox4Text;
                    mod.xww = CheckBox5Text;
                    mod.xshshch = "0";
                    mod.pagename = pagename2;
                    mod.upload_time = Convert.ToDateTime(TextBox3.Text);
                    mod.editor = TextBox4.Text;
                    bool flag1 = new PhotoBLL().pic_upload(mod);
                    if (flag1 == true)
                    {
                        Response.Write("<script>alert('上传成功！')</script>");
                    }
        }
        else
        {
            Response.Write("文件不存在…请检查文件是否存在");
        }
        TextBox_name.Text = "";
        TextBox1.Text = "";
        TextBox2.Text = "";
         } 
    } //button

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList2.DataBind();
        DropDownList2.Items.Insert(0, new ListItem("—选择栏目类型—", "0"));


    }

    

}
