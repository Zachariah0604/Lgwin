using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lgwin.Model;
using Lgwin.BLL;
using System.Collections;

public partial class karat1_admin_KaratMemberAdd : System.Web.UI.Page
{
    public int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.karatchksess();
        id = Convert.ToInt16(Request.QueryString["id"]);
        if (!IsPostBack)
        {
           
            if (id > 0)
            {
                Karat mod = new Karat();
                mod = new KaratBLL().MenbersContentGetById(id);
                TextBox1.Text = mod.Name;

                DropDownList1.Items.Clear();
                DropDownList1.Items.Insert(0, mod.Bumen);
                DropDownList1.Items.Add("站长");
                DropDownList1.Items.Add("采编部");
                DropDownList1.Items.Add("综合部");
                DropDownList1.Items.Add("技术部(美工)");
                DropDownList1.Items.Add("技术部(程序)");
                DropDownList1.DataBind();

                DropDownList2.Items.Clear();
                DropDownList2.Items.Add(mod.Zhiwu);
                DropDownList2.DataBind();
        
 

                DropDownList5.Text = mod.Yuanxi;
                TextBox5.Text = mod.Email;
                if (mod.Zaizhi == true)
                    DropDownList3.Text = "是";
                else
                    DropDownList3.Text = "否";
                TextBox7.Text = mod.Qq.ToString();
                TextBox9.Text = mod.Tel.ToString();
                imgurl.Text = mod.Imgurl;
                beizhu.Text = mod.Beizhu;



            }

        }
 
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        Karat mod = new Karat();
        mod.Name = TextBox1.Text;
        mod.Bumen = DropDownList1.Text;
        mod.Zhiwu = DropDownList2.Text;
        mod.Yuanxi = DropDownList5.Text;
        mod.Email = TextBox5.Text;
        if (DropDownList3.Text == "是")
            mod.Zaizhi = true;
        else
            mod.Zaizhi = false;
        mod.Qq = TextBox7.Text.ToString() ;
        mod.Tel = TextBox9.Text.ToString() ;
        mod.Year = DropDownList4.Text;
        if (FileUpload1.HasFile)
        {
            string textname = "";
            textname = DateTime.Now.ToString("yyyyMMddhhmmss");
            Boolean fileOK = false;
            String fileExtension = "";
            String path = Server.MapPath("../images/members/");//在web控件中可以使用~,表示虚拟路径根目录! 

            if (FileUpload1.HasFile)
            {
                fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
                String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtension == allowedExtensions[i])
                    {
                        fileOK = true;
                    }
                }
            }
            if (fileOK)
            {
                FileUpload1.PostedFile.SaveAs(path + textname + fileExtension);
            }

            mod.Imgurl = ("../images/members/" + textname + fileExtension).Trim();
            mod.Beizhu = ("members/" + textname + fileExtension).Trim();
        }
        if (FileUpload1.HasFile == false)
        {
            mod.Imgurl = imgurl.Text;
            mod.Beizhu = beizhu.Text;
        }
        if (id > 0)
        {
            mod.Id = id;
            new KaratBLL().MembersUpdate(mod);
        }
        else
            new KaratBLL().MembersAdd(mod);
        if (id > 0)
        {
            Response.Write("<script language=javascript>alert('修改成功！');self.location='MemberManage.aspx'</script>");
        }
        else
            Response.Write("<script language=javascript>alert('添加成员成功！');self.location='MemberManage.aspx'</script>");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("MemberManage.aspx");
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (DropDownList1.SelectedItem.Text)
        {
            case "站长": zhanzhang(); break;
            case "综合部": bumen(); break;
            case "采编部": bumen(); break;
            case "技术部(美工)": bumen(); break;
            case "技术部(程序)": bumen(); break;
            default: break;
        }
    }
    protected void zhanzhang()
    {
        DropDownList2.Items.Clear();
        DropDownList2.Items.Add("站长");
        DropDownList2.DataBind();
    }
    protected void bumen()
    {
        DropDownList2.Items.Clear();
        DropDownList2.Items.Add("部长");
        DropDownList2.Items.Add("成员");
        DropDownList2.DataBind();
    }
 
}