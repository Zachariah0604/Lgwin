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
public partial class Lgwin_manage_NotesManage : System.Web.UI.Page
{
    //管理员通知管理
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Mystring.chksess())
        {
            if (Mystring.chkPower(40, Session["User"].ToString()))
            {

                if (!IsPostBack)
                {
                    Editor1.Text = Myfile.Read_Model(Server.MapPath("~") + "\\Lgwin\\manage\\Main.html");
                }
            }
        }
    }
    protected void Button_tiaojiao_Click(object sender, EventArgs e)
    {
        Myfile.File_Write(Server.MapPath("~") + " \\Lgwin\\manage\\Main.html", "<meta http-equiv='Content-Type' content='text/html; charset=GB2312' />" + Editor1.Text);
         Mystring.alertAndBack("修改成功!");
    }   
}