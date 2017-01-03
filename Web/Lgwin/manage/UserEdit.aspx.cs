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
using Lgwin.SqlDAL;

public partial class Lgwin_manage_EditUser : System.Web.UI.Page
{
    RegUser mod = new RegUser();
    RegUserBLL bll = new RegUserBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.chksess();
        if (Session["User"] == null || Session["User"].ToString() == string.Empty)
            Mystring.alertAndRedirect("登陆超时，请重新登陆，再进行此操作！", "newsmanageLogin.aspx", "top");
        if (!IsPostBack)
        {
            mod = bll.GetUserInfo(Session["User"].ToString());

            if (Session["Admin"].ToString()=="2"||mod.Zhiwu == "老师")
            {
                LabelIp.Visible = false;
                Panel1.Visible = false;
            }
            User.Text = mod.UserName;
            namee.Text = mod.Name;
            tel.Text = mod.Tel;
            Email.Text = mod.Email;
            QQ.Text = mod.QQ;
            if (mod.Birthday.ToShortDateString() == "0001-1-1")
                shengri.Text = "";
            else
            {
                shengri.Text = mod.Birthday.ToShortDateString();
            }
            DropDownList1.SelectedValue = mod.Nianji;
            xuehao.Text = mod.Xuehao;
            zybj.Text = mod.Zybj;
            jiguan.Text = mod.Jiguan;
            if (mod.Intime.ToShortDateString() == "0001-1-1")
                jinru.Text = "";
            else
            {
                jinru.Text = mod.Intime.ToShortDateString();
            }
            if (mod.Outtime.ToShortDateString() == "0001-1-1")
                likai.Text = "";
            else
            {
                likai.Text = mod.Outtime.ToShortDateString();
            }
            imgID.ImageUrl = HttpContext.Current.Server.MapPath("") + "/" + mod.Img;
            //Response.Write(HttpContext.Current.Server.MapPath("./"));
            Session.Add("Img", mod.Img);
            for (int i = 0; i < RadioButtonList1.Items.Count; i++)
            {
                if (RadioButtonList1.Items[i].Text == mod.Zhiwu.ToString())
                    RadioButtonList1.Items[i].Selected = true;
            }
            if (mod.Admin != "0")
            {
                RadioButtonList1.Visible = false;
                LabelZhiWu.Visible = false;
            }
            //CheckBoxList1.DataBind();
            //setPower(mod.Power.ToString());
            jieshao.Text = mod.Jieshao;
            Ip.Text = mod.Ip;
            shengri.Attributes.Add("onFocus", "selectDate(this)");
            jinru.Attributes.Add("onFocus", "selectDate(this)");
            likai.Attributes.Add("onFocus", "selectDate(this)");
        }
    }
    //public string getPowerString()
    //{
    //    string ps = "";

    //    for (int i = 0; i < CheckBoxList1.Items.Count; i++)
    //    {
    //        if (CheckBoxList1.Items[i].Selected == true)
    //        {
    //            if (ps == "")
    //            {
    //                ps += CheckBoxList1.Items[i].Value;
    //            }
    //            else
    //                ps += "|" + CheckBoxList1.Items[i].Value;
    //        }
    //    }
    //    return ps;
    //}
    //public void setPower(string ps)
    //{
    //    for (int i = 0; i < CheckBoxList1.Items.Count; i++)
    //    {
    //        if (ps.IndexOf(CheckBoxList1.Items[i].Value) >= 0)
    //        {
    //            CheckBoxList1.Items[i].Selected = true;
    //        }
    //    }
    //}
    protected void Button1_Click(object sender, EventArgs e)
    {

        string extension = "";
        string fileName = "";
        string path = "";
        string imgg = "";
        try
        {
            if (UploadFile.PostedFile.FileName.Trim() != "")
            {
                extension = Path.GetExtension(UploadFile.PostedFile.FileName).ToUpper();
                fileName = DateTime.Now.ToString("yyyyMMddhhmmss");
                imgg = "photo/" + fileName + extension;
                path = Server.MapPath("") + "/" + imgg;
                UploadFile.PostedFile.SaveAs(path);
                Myfile.File_Del(Server.MapPath("") + "/" + Session["Img"].ToString());

            }
            else
            {
                imgg = Session["Img"].ToString();
            }

        }
        catch
        {
            Mystring.alertAndBack("上传图片失败，请重试！");
        }
        try
        {
            mod = bll.GetUserInfo(User.Text.Trim());
            mod.Name = namee.Text.Trim();
            mod.Tel = tel.Text.Trim();
            mod.Email = Email.Text.Trim();
            mod.QQ = QQ.Text.Trim();
            mod.Img = imgg;
            if (shengri.Text == null || shengri.Text.Trim() == "")
                mod.Birthday = DateTime.Parse(System.Data.SqlTypes.SqlDateTime.MinValue.ToString());
            else
            {
                mod.Birthday = Convert.ToDateTime(shengri.Text.Trim());
            }
            mod.Nianji = DropDownList1.SelectedValue;
            mod.Xuehao = xuehao.Text;
            mod.Zybj = zybj.Text;
            mod.Jiguan = jiguan.Text;
            if (jinru.Text == null || jinru.Text.Trim() == "")
                mod.Intime = DateTime.Parse(System.Data.SqlTypes.SqlDateTime.MinValue.ToString());
            else
            {
                mod.Intime = Convert.ToDateTime(jinru.Text.Trim());
            }
            if (likai.Text == null || likai.Text.Trim() == "")
                mod.Outtime = DateTime.Parse(System.Data.SqlTypes.SqlDateTime.MinValue.ToString());
            else
            {
                mod.Outtime = Convert.ToDateTime(likai.Text.Trim());
            }
            //mod.Intime = Convert.ToDateTime(jinru.Text.ToString().Trim());
            //mod.Outtime = Convert.ToDateTime(likai.Text.ToString().Trim());
            mod.Zhiwu = RadioButtonList1.SelectedItem.Text.ToString();
            mod.Paixu = RadioButtonList1.SelectedValue;
            //mod.Power = getPowerString();
            mod.Jieshao = jieshao.Text;
            mod.Ip =Ip.Text.Trim();

            if (bll.Update(mod))
            {
                Mystring.alertAndBack("更新成功！");
            }
            else
            {
                Mystring.alert("更新失败！请重试");
            }
        }
        catch (Exception dd)
        {
            //Mystring.alertAndBack("更新失败！请重试");
            Response.Write(dd);
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Mystring.Back();
    }
}
