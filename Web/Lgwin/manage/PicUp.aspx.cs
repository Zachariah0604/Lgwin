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
using Lgwin.Pic;
using System.IO;
using System.Drawing;
using Lgwin.BLL;
using Lgwin.Model;
using System.Collections.Generic;

public partial class Lgwin_manage_PicUp : System.Web.UI.Page
{
    public static string mFileName;
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.chksess();
        Image1.ImageUrl = "~/images/shuiyin/backlogo1.png";
        Image2.ImageUrl = "~/images/shuiyin/backlogo2.png";
        Image3.ImageUrl = "~/images/shuiyin/backlogo3.png";
        Image4.ImageUrl = "~/images/shuiyin/backlogo4.png";
        Image5.ImageUrl = "~/images/shuiyin/backlogo5.png";
        Image6.ImageUrl = "~/images/shuiyin/backlogo6.png";
        if (!IsPostBack)
        {
            kuan.Text = "500";
            ZtBLL _ztbll = new ZtBLL();
            IList<Zt> _ztlist = _ztbll.GetZtList(true);
            Zt zt0 = new Zt();
            zt0.Id = 0;
            zt0.Ztname = "==请选择专题==";
            _ztlist.Insert(0, zt0);
            zt.DataSource = _ztlist;
            zt.DataTextField = "Ztname";
            zt.DataValueField = "Id";
            zt.DataBind();
        }
        
    }

protected void Button_up_Click(object sender, EventArgs e)
{
    image im = new image();
    string extension = Path.GetExtension(FileUpload1.PostedFile.FileName).ToUpper();
    string fileName = DateTime.Now.ToString("yyyyMMddhhmmss");
    string Dir_path = "";
    if (zt.SelectedValue == "0")
    {
        Dir_path = Server.MapPath("~") + "/Uploads/" + DateTime.Now.ToString("yyyy") + "/" + DateTime.Now.ToString("MM") + "/" + DateTime.Now.ToString("dd");
    }
    else
    {
        ZtBLL ztbll = new ZtBLL();
        Zt mod = ztbll.GetZtById(int.Parse(zt.SelectedValue));
        Dir_path = Server.MapPath("~") + "/Uploads/topics/" +mod.ZtJiancheng+"/"+ DateTime.Now.ToString("yyyy") + "/" + DateTime.Now.ToString("MM") + "/" + DateTime.Now.ToString("dd");
    }

    if (!Directory.Exists(Dir_path))
    {
        Directory.CreateDirectory(Dir_path);
    }
    string path = Dir_path + "/" + fileName + ".jpg";
    FileUpload1.PostedFile.SaveAs(path);
    im.t(path, Dir_path + "/" + fileName + "_new.jpg", Convert.ToInt32(kuan.Text), 700, 100, false);//先将图片处理一次，这是初次处理，未加水印
    File.Delete(path);
    if (CheckBox1.Checked)
    {
        ImageModification wm = new ImageModification();
        wm.DrawedImagePath = Server.MapPath("~") + "/images/shuiyin/" + "backlogo" + RadioButtonList1.SelectedValue + ".png";
        wm.ModifyImagePath = Dir_path + "/" + fileName + "_new.jpg";
        wm.PinZhi = int.Parse(RadioButtonList2.SelectedValue);
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
        wm.OutPath = Dir_path + "/" + fileName + "_Marked.jpg";
        wm.DrawImage();  //保存加水印过后的图片,删除初次处理的图片 
        mFileName = fileName + "_Marked.jpg";
        File.Delete(Dir_path + "/" + fileName + "_new.jpg");
    }
    Response.Write("<script language=javascript>alert('上传图片成功');history.back(-1)</script>");
}
}