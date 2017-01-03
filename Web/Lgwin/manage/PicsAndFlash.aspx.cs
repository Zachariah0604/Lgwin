using System;
using System.Collections.Generic;
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
using Lgwin.Model;
using Lgwin.BLL;
using Lgwin.SqlDAL;

public partial class Lgwin_manage_PicsAndFlash : System.Web.UI.Page
{
    //首页图片管理页
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.chksess();
        CheckBoxList1.Visible = false;
        TextBox_Time.Visible = false;
        Label_shijian.Visible = false;
        PicXianshi();       
    }
    public void PicXianshi()
    {
        string text = "<table width=\"95%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" style=\"text-align:center;\">";
        ImageBLL bbb = new ImageBLL();
        IList<Lgwin.Model.Image> list00 = bbb.GetImageList("0");
        //Repeater1.DataSource = list00;
        //Repeater1.DataBind();
        //int count = list00.Count;
        //for (int i = 0; i < count; i++)
        foreach(Lgwin.Model.Image mod in list00)
        {
            if (File.Exists(HttpContext.Current.Server.MapPath("~/images/ad12/" + mod.Name)))
            {
                if (mod.Type == "pic")
                {
                    if (mod.Href.Trim() == "")
                    {
                        text += "<tr><td><img src=\"../../" + mod.Url + "\" width=\"680px\" height=\"72px\" /><br />文件名称：" + mod.Name + "</td></tr>";
                    }
                    else
                    {
                        text += "<tr><td><img src=\"../../" + mod.Url + "\" width=\"680px\" height=\"72px\" /><br />文件名称：" + mod.Name + "&nbsp;&nbsp;&nbsp;&nbsp;链接地址为：" + mod.Href + "</td></tr>";
                    }
                }
                else
                {
                    if (mod.Href.Trim() == "")
                    {
                        text += "<tr><td><object classid=\"clsid:D27CDB6E-AE6D-11cf-96B8-444553540000\" codebase=\"http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0\" width=\"680\" height=\"72\"><param name=\"movie\" value=\"../../" + mod.Url + "\" /><param name=\"quality\" value=\"high\" /><embed src=\"../../" + mod.Url + "\" quality=\"high\" pluginspage=\"http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash\" type=\"application/x-shockwave-flash\" width=\"680\" height=\"72\"></embed></object><br />文件名称：" + mod.Name + "</td></tr>";
                    }
                    else
                    {
                        text += "<tr><td><object classid=\"clsid:D27CDB6E-AE6D-11cf-96B8-444553540000\" codebase=\"http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0\" width=\"680\" height=\"72\"><param name=\"movie\" value=\"../../" + mod.Url + "\" /><param name=\"quality\" value=\"high\" /><embed src=\"../../" + mod.Url + "\" quality=\"high\" pluginspage=\"http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash\" type=\"application/x-shockwave-flash\" width=\"680\" height=\"72\"></embed></object><br />文件名称：" + mod.Name + "&nbsp;&nbsp;&nbsp;&nbsp;链接地址为：" + mod.Href + "</td></tr>";
                    }
                }
            }
        }
        text += "</table>";
        Label_flash.Text = text;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            string type = "";
            string url = "";
            string href = TextBox_herf.Text;
            bool on = false;
            string name = FileUpload1.FileName;
            string fenlei = "";
            string exten = Path.GetExtension(FileUpload1.PostedFile.FileName).ToUpper();
            string path = Server.MapPath("~/") + "images";
            if (RadioButtonList1.SelectedValue == "0")//12
            {
                if (exten == ".JPG" || exten == ".PNG" || exten == ".JPEG" || exten == ".GIF" || exten == ".BMP")
                {
                    type = "pic";
                }
                else
                {
                    type = "flash";
                }
                fenlei = "ad12";
                url = "images/ad12/";
                FileUpload1.PostedFile.SaveAs(path + "/ad12/" + name);
            }
            if(RadioButtonList1.SelectedValue == "1")//xiaobao
            {
                if (exten == ".JPG" || exten == ".PNG" || exten == ".JPEG" || exten == ".GIF" || exten == ".BMP")
                {
                    type = "pic";
                }
                else
                {
                    type = "flash";
                }
                fenlei = "xiaobao";
                url = "images/xiaobao/";
                FileUpload1.PostedFile.SaveAs(path+"/xiaobao/"+name);
            }
            if (RadioButtonList1.SelectedValue == "2")//zhuanti
            {
                if (exten == ".JPG" || exten == ".PNG" || exten == ".JPEG" || exten == ".GIF" || exten == ".BMP")
                {
                    type = "pic";
                }
                else
                {
                    type = "flash";
                }
                fenlei = "zhuanti";
                url = "images/zhuanti/";
                FileUpload1.PostedFile.SaveAs(path + "/zhuanti/" + name);
            }
            Lgwin.Model.Image mod = new Lgwin.Model.Image();
            ImageBLL bll = new ImageBLL();
            mod.Name = name;
            mod.Url = url + name;
            mod.Type = type;
            mod.Href = href;
            mod.On = on;
            mod.FenLei = fenlei;
            if (bll.Add(mod))
                Mystring.alert("上传文件成功！");
            else
            {
                Mystring.alert("图片数据插入数据库出错！");
            }
        }
        else
            Labele.Text = "请选择文件，再点击上传！";
        PicXianshi();
        TextBox_herf.Text = "";

    }
    protected void Button2_Click(object sender, EventArgs e)//weizhi1
    {
        if (Mystring.chksess())
        {
            if (Mystring.chkPower(18, Session["User"].ToString()))
            {
                ImageBLL blll = new ImageBLL();
                IList<Lgwin.Model.Image> list = blll.GetImageGetFenlei("ad12");
                CheckBoxList1.DataSource = list;
                CheckBoxList1.DataTextField = "Name";
                CheckBoxList1.DataValueField = "Id";
                CheckBoxList1.DataBind();

                CheckBoxList1.Visible = true;
                TextBox_Time.Visible = true;
                TextBox_Time.Text = "6";
                Label_shijian.Visible = true;
                MultiView1.ActiveViewIndex = 0;
            }
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (Mystring.chksess())
        {
            if (Mystring.chkPower(19, Session["User"].ToString()))
            {
                ImageBLL blll = new ImageBLL();
                IList<Lgwin.Model.Image> list = blll.GetImageGetFenlei("ad12");
                CheckBoxList1.DataSource = list;
                CheckBoxList1.DataTextField = "Name";
                CheckBoxList1.DataValueField = "Id";
                CheckBoxList1.DataBind();

                CheckBoxList1.Visible = true;
                TextBox_Time.Visible = true;
                TextBox_Time.Text = "6";
                Label_shijian.Visible = true;
                MultiView1.ActiveViewIndex = 1;
            }
        }
    }

    protected void Button_Del_Click(object sender, EventArgs e)//删除显示
    {
        if (Mystring.chksess())
        {
            if (Mystring.chkPower(22, Session["User"].ToString()))
            {
                ImageBLL blll = new ImageBLL();
                IList<Lgwin.Model.Image> list = blll.GetImageList("0");
                CheckBoxList1.DataSource = list;
                CheckBoxList1.DataTextField = "Name";
                CheckBoxList1.DataValueField = "Id";
                CheckBoxList1.DataBind();

                CheckBoxList1.Visible = true;
                TextBox_Time.Visible = false;
                Label_shijian.Visible = false;
                MultiView1.ActiveViewIndex = 4;
            }
        }
    }   
    /// <summary>
    /// 获取选定图片的id
    /// </summary>
    /// <returns></returns>
    public string GetIds()
    {
        string ids = "";
        for (int i = 0; i < CheckBoxList1.Items.Count; i++)
        {
            if (CheckBoxList1.Items[i].Selected == true)
                ids += CheckBoxList1.Items[i].Value+",";
        }
        return ids;
    }
    public string GetId()
    {
        string id="";
        if(CheckBoxList1.SelectedIndex>-1)
        {
        id=CheckBoxList1.SelectedValue.ToString();
        }
        return id;
    }
    protected void Button_xddDel_Click(object sender, EventArgs e)
    {
        string idds = GetIds();
        char[] seperator = { ',' };
        string[] id = idds.Split(seperator);
        foreach (string d in id)
        {
            if (d.Trim() != "")
            {
                ImageBLL imgbll = new ImageBLL();
                Lgwin.Model.Image mod = imgbll.GetImage(d);
                ToHtml.DelImg(mod);
            }
        }
        Lgwin.Model.Image mo = new Lgwin.Model.Image();
        ImageBLL ball = new ImageBLL();
        int aa=ball.Del(idds);
        if (aa > 0)
            Mystring.alert("删除"+aa+"个文件成功！");
        PicXianshi();
        MultiView1.ActiveViewIndex = -1;
    }
    protected void Button_xuanding1_Click(object sender, EventArgs e)
    {
        string idds = GetIds();
        string ad1 = "<div id=\"out1\" style=\"FILTER: revealTrans(Transition=23,Duration=6)\">";
        int xu = 1;
        ImageBLL bbbb = new ImageBLL();
        IList<Lgwin.Model.Image> list111 = bbbb.GetImageList(idds);
        //int coun = list111.Count();
        //for (int i = 0; i < coun; i++)
        foreach(Lgwin.Model.Image modimg in list111)
        {
            string item = "<div class=\"item\" style=\"display:";
            if (xu != 1)
            {
                item += "none";
            }
            item += "\" id=\"Items1_" + xu + "\">";
            if (modimg.Type == "pic")
            {
                if ((modimg.Href.Trim()) != "")
                {
                    item += "<a href=\"" + modimg.Href + "\" target=\"_blank\">"; item += "<img src=\"" + modimg.Url + "\" width=\"1000\" height=\"90\" /></a>";
                }
                else
                {
                    item += "<img src=\"" + modimg.Url + "\" width=\"1000\" height=\"90\" />";
                }

            }
            else
            {
                if ((modimg.Href.Trim()) != "")
                {
                    item += "<a href=\"" + modimg.Href + "\" target=\"_blank\">"; item += "<object classid=\"clsid:D27CDB6E-AE6D-11cf-96B8-444553540000\" codebase=\"http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0\" width=\"1000\" height=\"90\"><param name=\"movie\" value=\"" + modimg.Url + "\" /><param name=\"quality\" value=\"high\" /><embed src=\"" + modimg.Url + "\" quality=\"high\" pluginspage=\"http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash\" type=\"application/x-shockwave-flash\" width=\"1000\" height=\"90\"></embed></object></a>";
                }
                else
                {
                    item += "<object classid=\"clsid:D27CDB6E-AE6D-11cf-96B8-444553540000\" codebase=\"http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0\" width=\"1000\" height=\"90\"><param name=\"movie\" value=\"" + modimg.Url + "\" /><param name=\"quality\" value=\"high\" /><embed src=\"" + modimg.Url + "\" quality=\"high\" pluginspage=\"http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash\" type=\"application/x-shockwave-flash\" width=\"1000\" height=\"90\"></embed></object>";
                }
            }                
            item += "</div>";
            ad1 += item;
            xu += 1; 
        }
        ad1 += "</div>";
        xu -= 1;
        ad1 += "<script language=\"javascript\" type=\"text/javascript\">\nstart(1,1," + xu + ","+TextBox_Time.Text+"000);\n</script>";

        OptionsBLL cc = new OptionsBLL();
        Lgwin.Model.Options mo = cc.GetOptions("ad1");
        mo.Nr = ad1;
        cc.Update(mo);
        Mystring.alert("选择位置一成功！");
        PicXianshi();
    }
    protected void Button_xuanding2_Click(object sender, EventArgs e)
    {
        string idds = GetIds();
        string ad1 = "<div id=\"out2\" style=\"FILTER: revealTrans(Transition=1,Duration=1)\">";
        int xu = 1;
        ImageBLL bbbb = new ImageBLL();
        IList<Lgwin.Model.Image> list111 = bbbb.GetImageList(idds);
        //int coun = list111.Count();
        //for (int i = 0; i < coun; i++)
        foreach (Lgwin.Model.Image modimg in list111)
        {
            string item = "<div class=\"item\" style=\"display:";
            if (xu != 1)
            {
                item += "none";
            }
            item += "\" id=\"Items2_" + xu + "\">";
            if (modimg.Type == "pic")
            {
                if ((modimg.Href.Trim()) != "")
                {
                    item += "<a href=\"" + modimg.Href + "\" target=\"_blank\">"; item += "<img src=\"" + modimg.Url + "\" width=\"698\" height=\"90\" /></a>";
                }
                else
                {
                    item += "<img src=\"" + modimg.Url + "\" width=\"698\" height=\"90\" />";
                }

            }
            else
            {
                if ((modimg.Href.Trim()) != "")
                {
                    item += "<a href=\"" + modimg.Href + "\" target=\"_blank\">"; item += "<object classid=\"clsid:D27CDB6E-AE6D-11cf-96B8-444553540000\" codebase=\"http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0\" width=\"698\" height=\"90\"><param name=\"movie\" value=\"" + modimg.Url + "\" /><param name=\"quality\" value=\"high\" /><embed src=\"" + modimg.Url + "\" quality=\"high\" pluginspage=\"http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash\" type=\"application/x-shockwave-flash\" width=\"698\" height=\"90\"></embed></object></a>";
                }
                else
                {
                    item += "<object classid=\"clsid:D27CDB6E-AE6D-11cf-96B8-444553540000\" codebase=\"http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0\" width=\"698\" height=\"90\"><param name=\"movie\" value=\"" + modimg.Url + "\" /><param name=\"quality\" value=\"high\" /><embed src=\"" + modimg.Url + "\" quality=\"high\" pluginspage=\"http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash\" type=\"application/x-shockwave-flash\" width=\"698\" height=\"90\"></embed></object>";
                }
            }
            item += "</div>";
            ad1 += item;
            xu += 1;
        }
        ad1 += "</div>";
        xu -= 1;
        ad1 += "<script language=\"javascript\" type=\"text/javascript\">\nstart(2,1," + xu + "," + TextBox_Time.Text + "000);\n</script>";

        OptionsBLL cc = new OptionsBLL();
        Lgwin.Model.Options mo = cc.GetOptions("ad2");
        mo.Nr = ad1;
        cc.Update(mo);
        Mystring.alert("选择位置二成功！");

        PicXianshi();
    }
    protected void Button_Xiaobao_Click(object sender, EventArgs e)//校报显示
    {
        if (Mystring.chksess())
        {
            if (Mystring.chkPower(20, Session["User"].ToString()))
            {
                CheckBoxList1.Visible = false;
                TextBox_Time.Visible = false;
                Label_shijian.Visible = false;
                MultiView1.ActiveViewIndex = 5;
            }
        }
    }
    protected void Button_Zhuanti_Click(object sender, EventArgs e)//专题显示
    {
        if (Mystring.chksess())
        {
            if (Mystring.chkPower(21, Session["User"].ToString()))
            {
                ImageBLL blll = new ImageBLL();
                IList<Lgwin.Model.Image> list = blll.GetImageGetFenlei("zhuanti");
                CheckBoxList1.DataSource = list;
                CheckBoxList1.DataTextField = "Name";
                CheckBoxList1.DataValueField = "Id";
                CheckBoxList1.DataBind();

                CheckBoxList1.Visible = true;
                TextBox_Time.Visible = false;
                Label_shijian.Visible = false;
                MultiView1.ActiveViewIndex = 3;
            }
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        string qishu = TextBox_Qishu.Text.Trim();
        string neirong = "<div id=\"xbbiaoti\">《山东理工大学报》<br />总第"+qishu+"期</div>";
        OptionsBLL cc = new OptionsBLL();
        Lgwin.Model.Options mo = cc.GetOptions("qishu");
        mo.Nr = neirong;
        cc.Update(mo);
        Mystring.alert("操作成功，请为各版块选择图片！");


        ImageBLL blll = new ImageBLL();
        IList<Lgwin.Model.Image> list = blll.GetImageGetFenlei("xiaobao");
        CheckBoxList1.DataSource = list;
        CheckBoxList1.DataTextField = "Name";
        CheckBoxList1.DataValueField = "Id";
        CheckBoxList1.DataBind();

        CheckBoxList1.Visible = true;
        TextBox_Time.Visible = false;
        Label_shijian.Visible = false;
        MultiView1.ActiveViewIndex = 2;

    }
    protected void Button_xb_Click(object sender, EventArgs e)//校报选择
    {
        string id = GetId();
        string fenlei="";
        string xbnr = "<div class=\"Leftimg\">";
        ImageBLL bbbb = new ImageBLL();
        Lgwin.Model.Image mod=bbbb.GetImage(id);
        if (mod != null)
        {
            if (mod.Href.ToString().Trim() == "")
            {
                xbnr += "<img src=\"" + mod.Url + "\" />";
            }
            else
            {
                xbnr += "<a href=\"" + mod.Href + "\" target=\"_blank\"><img src=\"" + mod.Url + "\" /></a>";
            }
        }
        xbnr += "</div>";
        if(RadioButtonList2.SelectedValue=="0")//touban
        {
            fenlei="touban";
        }
        if(RadioButtonList2.SelectedValue=="1")//综合
        {
            fenlei="zonghe";
        }
        if(RadioButtonList2.SelectedValue=="2")//校园
        {
            fenlei="xiaoyuan";
        }
        if(RadioButtonList2.SelectedValue=="3")//副刊
        {
            fenlei="fukan";
        }
        OptionsBLL cc = new OptionsBLL();
        Lgwin.Model.Options mo = cc.GetOptions(fenlei);
        mo.Nr = xbnr;
        if(cc.Update(mo))
        {
        Mystring.alert("选择成功！");
        }
        else
        {
           Mystring.alert("哎呀，出错了，请重试！");
        }
        //重新绑定继续选择
        ImageBLL blll = new ImageBLL();
        IList<Lgwin.Model.Image> list = blll.GetImageGetFenlei("xiaobao");
        CheckBoxList1.DataSource = list;
        CheckBoxList1.DataTextField = "Name";
        CheckBoxList1.DataValueField = "Id";
        CheckBoxList1.DataBind();

        CheckBoxList1.Visible = true;
        TextBox_Time.Visible = false;
        Label_shijian.Visible = false;
        MultiView1.ActiveViewIndex = 2;

    }
    protected void Button_zht_Click(object sender, EventArgs e)//选择专题图片
    {
        string ids=GetIds();
        string ztnr="<div id=\"ZtImg\">";
        ImageBLL imgbll=new ImageBLL();
        IList<Lgwin.Model.Image> list=imgbll.GetImageList(ids);
        int count=list.Count;
        if (count > 0)
        {
            for (int i = 0; i < count; i++)
            {
                if (list[i].Href.ToString().Trim() != "")
                    ztnr += "<a href=\"" + list[i].Href + "\" target=\"_blank\"><img src=\"" + list[i].Url + "\" /></a>";
                else
                {
                    ztnr += "<img src=\"" + list[i].Url + "\" />";
                }
            }
        }
        ztnr+="</div>";
         OptionsBLL cc = new OptionsBLL();
        Lgwin.Model.Options mo = cc.GetOptions("zhuanti");
        mo.Nr = ztnr;
        if(cc.Update(mo))
        {
        Mystring.alert("选择成功！");
        }
        else
        {
           Mystring.alert("哎呀，出错了，请重试！");
        }
    }
}
