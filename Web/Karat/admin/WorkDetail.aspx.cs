using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lgwin.BLL;
using Lgwin.Model;
using Count;

using Lgwin.BLL;

public partial class karat1_admin_KaratWorkDetail : System.Web.UI.Page
{
    public static string reurl = "WorkShowManage.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.karatchksess();
        int id = 0;
        id = Convert.ToInt32(Request.QueryString["id"]);
        if (!IsPostBack)
        {
            if (id > 0)
            {
                Karat mod = new Karat();
                mod = new KaratBLL().GetWorkContent(id);
                TextBox1.Text = mod.Name;
                TextBox2.Text = mod.Type;
                TextBox3.Text = Convert.ToDateTime(mod.Time).ToString();
                setTool(mod.Tool.ToString());
                TextBox5.Text = mod.Href;
                Label1.Text = mod.Imgurl;
                reurl = "WorkShowManage.aspx";

            }
            else
                TextBox3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss").ToString();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        int id = 0;
        id = Convert.ToInt32(Request.QueryString["id"]);
        if (id > 0)
        {

            Karat mod = new Karat();
            mod.Id = id;
            mod.Name = TextBox1.Text;
            mod.Type = TextBox2.Text;
            mod.Time = Convert.ToDateTime(TextBox3.Text);
            mod.Tool = getToolString();
            mod.Href = TextBox5.Text;

            if (FileUpload1.HasFile)
            {
                string textname = "";
                textname = DateTime.Now.ToString("yyyyMMddhhmmss");
                Boolean fileOK = false;
                String fileExtension = "";
                String path = Server.MapPath("../images/work/");//在web控件中可以使用~,表示虚拟路径根目录! 
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

                mod.Imgurl = "work/" + textname + fileExtension;
            }
            else mod.Imgurl = Label1.Text;

            bool flag = new KaratBLL().WorkUpdate(mod);
            if (flag == true)
            {
                Response.Write("<script language=javascript>alert('操作成功！');self.location='WorkShowManage.aspx'</script>");
            }
            else
                Response.Redirect("<script language=javascript>alert('操作失败！');self.location='WorkShowManage.aspx'</script>");



        }
        else
        {

            Karat mod = new Karat();
            mod.Name = TextBox1.Text;
            mod.Type = TextBox2.Text;
            mod.Time = Convert.ToDateTime(TextBox3.Text);
            mod.Tool = getToolString();
            mod.Href = TextBox5.Text;
            string textname = "";
            textname = DateTime.Now.ToString("yyyyMMddhhmmss");
            Boolean fileOK = false;
            String fileExtension = "";
            String path = Server.MapPath("../images/work/");//在web控件中可以使用~,表示虚拟路径根目录! 
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
            mod.Imgurl = textname + fileExtension;


            bool flag = new KaratBLL().WorkAdd(mod);
            if (flag == true)
            {
                Response.Write("<script language=javascript>alert('操作成功！');self.location='WorkShowManage.aspx'</script>");
            }
            else
                Response.Redirect("<script language=javascript>alert('操作失败！');self.location='WorkShowManage.aspx'</script>");

        }


    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect(reurl);
    }
    public string getToolString()
    {
        string ps = string.Empty;


        for (int i = 0; i < CheckBoxList1.Items.Count; i++)
        {
            if (CheckBoxList1.Items[i].Selected == true)
            {

                ps += CheckBoxList1.Items[i].Text.ToString() + "，";
            }
        }


        return ps;
    }

    public void setTool(string tl)
    {

        for (int i = 0; i < CheckBoxList1.Items.Count; i++)
        {
            if (tl.IndexOf(CheckBoxList1.Items[i].Text.ToString()) >= 0)
            {
                CheckBoxList1.Items[i].Selected = true;
            }
        }
    }
}