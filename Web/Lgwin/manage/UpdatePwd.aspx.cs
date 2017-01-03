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

public partial class Lgwin_manage_UpdatePwd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Mystring.chksess();
        myEncryption pas = new myEncryption();
        string oldPwd = "";
        string newPwd = "";
        oldPwd = pas.Encrypto(Old.Text.Trim());
        newPwd = pas.Encrypto(New1.Text.Trim());

        RegUserBLL rub = new RegUserBLL();
        RegUser _Model = rub.GetUserInfo(Session["User"].ToString());
        if (oldPwd == _Model.PassWord)
        {
            _Model.PassWord = newPwd;
            if (rub.Update_Pwd(_Model))
            {
                Mystring.alertAndBack("更新密码成功！");
            }
            else
            {
                Mystring.alert("更新密码失败！请重试或联系技术部");
            }

        }
        else
        {
            Mystring.alert("原始密码错误！");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Mystring.Back();
    }
}
