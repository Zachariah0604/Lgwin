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
using Lgwin.BLL;
using Lgwin.Model;
using System.IO;

public partial class Lgwin_manage_RegUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            shengri.Attributes.Add("onFocus", "selectDate(this)");
            jinru.Attributes.Add("onFocus", "selectDate(this)");
            likai.Attributes.Add("onFocus", "selectDate(this)");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        RegUserBLL dal=new RegUserBLL();
        RegUser model=new RegUser();

        string user=User.Text.Trim();
        string password = TextBox_password.Text.Trim();
        myEncryption pwd=new myEncryption();
        string Encodepwd=pwd.Encrypto(password);

        if(dal.Exists(user))
        {
            Mystring.alert("该用户名已经存在，请换用其他用户名！");
        }
        else 
        {
            string extension = "";
            string fileName = "";
            string path = "";
            try
            {
                if (UploadFile.PostedFile.FileName.Trim() != "")
                {
                    extension = Path.GetExtension(UploadFile.PostedFile.FileName).ToUpper();
                    fileName = DateTime.Now.ToString("yyyyMMddhhmmss");
                    path = Server.MapPath("") + "/photo/" + fileName + extension;
                    UploadFile.PostedFile.SaveAs(path);
                    try
                    {
                        model.UserName = user;
                        model.Name = namee.Text.Trim();
                        model.PassWord = Encodepwd;
                        model.Tel = tel.Text.Trim();
                        model.Email = Email.Text.Trim();
                        model.QQ = QQ.Text.Trim();
                        model.Birthday = Convert.ToDateTime(shengri.Text.ToString().Trim());
                        model.Img = "photo/" + fileName + extension;
                        model.Nianji = DropDownList1.SelectedValue;
                        model.Xuehao = xuehao.Text;
                        model.Zybj = zybj.Text;
                        model.Jiguan = jiguan.Text;
                        model.Intime = Convert.ToDateTime(jinru.Text.ToString().Trim());
                        model.Outtime = Convert.ToDateTime(likai.Text.ToString().Trim());
                        model.Zhiwu = RadioButtonList1.SelectedItem.Text;
                        model.Paixu = RadioButtonList1.SelectedValue;
                        model.Power = getPowerString();
                        model.Jieshao = jieshao.Text;
                        model.Ip = "222.206.75.15|222.206.75.16|222.206.75.13|222.206.75.246|222.206.75.247|222.206.75.248";//登陆ip，注册用户，只能在网站登陆
                        if (dal.Add(model))
                        {
                            Mystring.alertAndRedirect("注册成功！请等待管理员审核。", "http://lgwindow.sdut.edu.cn/");
                        }
                        else
                        {
                            Mystring.alert("注册失败！");
                        }
                    }
                    catch (Exception dd)
                    {
                        File.Delete(path);
                        Mystring.alertAndBack("注册失败！请重试");
                        //Response.Write(dd);
                    }
                }
                else
                {
                    Mystring.alert("请选择上传的图片！");
                }
            }
            catch
            {
                Mystring.alertAndBack("上传图片失败，请重试！");
            }
            

        }        
    }
protected void  Button2_Click(object sender, EventArgs e)
{
    //RequiredFieldValidator1.Enabled = false;
    //RequiredFieldValidator2.Enabled = false;
    //RequiredFieldValidator3.Enabled = false;
    //RequiredFieldValidator4.Enabled = false;
    //RequiredFieldValidator5.Enabled = false;
    //RequiredFieldValidator6.Enabled = false;
    User.Text = "";
    TextBox_password.Text = "";
    TextBox_pwd2.Text = "";
    namee.Text = "";
    tel.Text = "";
    Email.Text = "";
    QQ.Text="";
    shengri.Text="";
    xuehao.Text="";
    zybj.Text="";
    jiguan.Text="";
    jieshao.Text="";
    User.Focus();
}
public string getPowerString()
{
    string ps = "";

    for (int i = 0; i < CheckBoxList1.Items.Count; i++)
    {
        if (CheckBoxList1.Items[i].Selected == true)
        {
            if (ps == "")
            {
                ps += CheckBoxList1.Items[i].Value;
            }
            else
                ps += "|" + CheckBoxList1.Items[i].Value;
        }
    }
    return ps;
}
}
