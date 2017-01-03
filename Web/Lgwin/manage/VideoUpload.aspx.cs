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
using System.IO;
using Lgwin.BLL;
using Lgwin.Model;
using System.Collections.Generic;
using Lgwin.Pic;

public partial class Lgwin_manage_VideoUpload : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.chksess();
        if (!IsPostBack)
        {
            TextBox_From.Text = "理工视窗";
            TextBox_href.Text = "0";
        }
    }
    protected void Button_up_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            string exten = Path.GetExtension(FileUpload1.PostedFile.FileName).ToUpper();
            if (exten == ".FLV"||exten ==".F4V")
            {
                string filename = DateTime.Now.ToString("yyyyMMddhhmmss");
                string url = "Uploads/video/" + DateTime.Now.Year.ToString() + "/" + DateTime.Now.Month.ToString();
                string path = Server.MapPath("~/") + url;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                FileUpload1.PostedFile.SaveAs(path + "/" + filename + exten);

                string pic_name = "";
                string pic_exten = "";
                string pic_path = "";
                string pic_url = "";
                if (FileUpload2.HasFile)
                {
                    pic_exten = Path.GetExtension(FileUpload2.PostedFile.FileName).ToUpper();
                    if (pic_exten == ".JPG" || pic_exten == ".JPEG" || pic_exten == ".GIF")
                    {
                        pic_name = DateTime.Now.ToString("yyyyMMddhhmmss");
                        pic_url = "Uploads/video/pic/" + DateTime.Now.Year.ToString() + "/" + DateTime.Now.Month.ToString();
                        pic_path = Server.MapPath("~/") + pic_url;
                        if (!Directory.Exists(pic_path))
                        {
                            Directory.CreateDirectory(pic_path);
                        }
                        FileUpload2.PostedFile.SaveAs(pic_path + "/" + pic_name + pic_exten);
                        //hd_picName.Value = pic_name + pic_exten;
                        //hd_picDelPash.Value = pic_path + "/" + pic_name + pic_exten;

                        SuoluePic sp = new SuoluePic();
                        sp.MakeThumbnail(pic_path + "/" + pic_name + pic_exten, pic_path + "/" + pic_name + "_new" + pic_exten, 214, 142, "HW");

                        File.Delete(pic_path + "\\" + pic_name + pic_exten);
                        ImageModification wm = new ImageModification();
                        wm.DrawedImagePath = Server.MapPath("~") + "\\Lgwin\\manage\\Images\\water.png";
                        wm.ModifyImagePath = pic_path + "/" + pic_name + "_new" + pic_exten;
                        wm.RightSpace = 155;
                        wm.BottoamSpace = 120;
                        wm.LucencyPercent = 100;
                        wm.OutPath = pic_path + "\\" + pic_name + pic_exten;
                        wm.DrawImage();
                        File.Delete(pic_path + "/" + pic_name + "_new" + pic_exten);
                    }
                }

                VideoBLL bll = new VideoBLL();
                Video mod = new Video();
                mod.AddDate = DateTime.Now.Date;
                mod.From = TextBox_From.Text.Trim();
                mod.Href = TextBox_href.Text.Trim();
                mod.HitNum = "100";
                mod.Name = filename + exten;
                mod.Recommend = TextBox_jianping.Text;
                mod.Title = TextBox_title.Text;
                mod.Uploader = Session["Name"].ToString();
                //mod.Uploader = "";
                mod.Url = url + "/" + filename + exten;
                mod.Type = "视频";
                mod.Pic = pic_url + "/"+pic_name + pic_exten;

                if (bll.Add(mod))
                {
                    int count;
                    bool result=false;
                    VideoBLL vbll = new VideoBLL();
                    IList<Video> vlist = vbll.GetVideoList(1, 1, "", out count);
                    if (vlist.Count > 0)
                    {
                        //生成首页视频和图片
                        string contents = "";
                        contents = Myfile.Read_Model(HttpContext.Current.Server.MapPath("model/indexVideo.model"));
                        contents = contents.Replace("%%videosource%%", ToHtml.index_videosource(1));
                        Myfile.File_Write(HttpContext.Current.Server.MapPath("../../Video.html"), contents);

                        string pic = "";
                        pic = Myfile.Read_Model(HttpContext.Current.Server.MapPath("model/IndexPic.model"));
                        pic = pic.Replace("%%picPash%%", ToHtml.index_videoAndPic(1));
                        Myfile.File_Write(HttpContext.Current.Server.MapPath("../../Pic.html"),pic);

                        result = ToHtml.singleVideo_toHtml(vlist[0]);//生成视频三级页
                        Mystring.alertAndRedirect("上传视频成功！", "VideoManage.aspx?Type=0");
                    }
                }
                else
                {
                    Myfile.File_Del(path + "/" + filename + exten);
                    Myfile.File_Del(pic_path + "/" + pic_name + pic_exten);
                    Mystring.alert("上传失败，请重试！");
                }
            }
            else if (exten == ".MP3" || exten == ".CAD" || exten == ".MID" || exten == ".WAV" || exten == ".VQF" || exten == ".AIF" || exten == ".AU")
            {
                string filename = DateTime.Now.ToString("yyyyMMddhhmmss");
                string url = "Uploads/YinYue/" + DateTime.Now.Year.ToString() + "/" + DateTime.Now.Month.ToString();
                string path = Server.MapPath("~/") + url;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                FileUpload1.PostedFile.SaveAs(path + "/" + filename + exten);

                VideoBLL bll = new VideoBLL();
                Video mod = new Video();
                mod.AddDate = DateTime.Now.Date;
                mod.From = TextBox_From.Text.Trim();
                mod.Href = TextBox_href.Text.Trim();
                mod.HitNum = "100";
                mod.Name = filename + exten;
                mod.Recommend = TextBox_jianping.Text;
                mod.Title = TextBox_title.Text;
                mod.Uploader = Session["Name"].ToString();
                //mod.Uploader = "";
                mod.Url = url + "/" + filename + exten;
                mod.Type = "音频";
                mod.Pic = "";
                if (bll.Add(mod))
                {
                    int count;
                    bool result = false;
                    VideoBLL vbll = new VideoBLL();
                    IList<Video> vlist = vbll.GetVideoList(1, 1, "", out count);
                    if (vlist.Count > 0)
                        result = ToHtml.singleMusic_toHtml(vlist[0]);//生成视频三级页                                      //Mystring.alert("");
                    vlist = vbll.GetVideoList(5, 1, "Type='音频'", out count);
                    ToHtml.WriteMusicList(vlist);
                    Mystring.alertAndRedirect("上传音频成功！", "VideoManage.aspx?Type=1");
                }
                else
                {
                    Myfile.File_Del(path + "/" + filename + exten);
                    Mystring.alert("上传失败，请重试！");
                }
            }
            else
            {
                Mystring.alert("请上传FLV或F4V格式的文件，其他视频格式暂不支持！");
            }
        }
        else
        {
            Mystring.alert("请选择上传文件！");
        }
    }
    protected void Button_cancel_Click(object sender, EventArgs e)
    {
        Mystring.Back();
    }
}