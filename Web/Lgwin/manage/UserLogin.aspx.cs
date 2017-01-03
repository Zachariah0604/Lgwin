using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Web.Security;
using System.Security.Cryptography;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.IO;
using System.Text;
using Lgwin.Model;
using Lgwin.BLL;
using Count;
using BloClass;
//using Lgwin.SqlDAL;

public partial class Lgwin_manage_UserLogin : System.Web.UI.Page
{
    //zgy
    public string VisitedIP;//获取IP
    //zgy
     
       
    protected void Page_Load(object sender, EventArgs e)
    {
       
        User.Focus();
        string dd = "";
        dd = Request.QueryString["Type"] == null || Request.QueryString["Type"] == string.Empty ? "Login" : Request.QueryString["Type"].ToString().Trim();
        if (dd == "LoginOut")
        {
            Session.Clear();
            Session.Abandon();
            Mystring.alertAndRedirect("您已经安全退出！", "UserLogin.aspx", "top");
        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        RegUserBLL rub = new RegUserBLL();
        myEncryption ensure = new myEncryption();//加密类实例化
        string _UserName = User.Text.Trim();
        string _PassWord = ensure.Encrypto(Password.Text.Trim().ToString());
        try
        {
            if (rub.Exists(_UserName))   //用户已经存在
            {
                RegUser _Model = rub.GetUserInfo(_UserName);
                Session.Add("Admin", _Model.Admin);
                Session.Add("Power", _Model.Power);
                Session.Add("Name", _Model.Name);
                Session.Add("User", _Model.UserName);
                if (_Model.PassWord == _PassWord)
                {
                    if (_Model.Pass == true)
                    {
                        //zgy
                        if (Request.ServerVariables["HTTP_VIA"] != null)
                        {
                            VisitedIP = Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
                        }
                        else
                        {
                            if (Request.ServerVariables["HTTP_VIA"] != null)
                            {
                                VisitedIP = Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
                            }
                            else
                            {
                                VisitedIP = Request.ServerVariables["REMOTE_ADDR"].ToString();
                            }

                        }
                        Count.DBclass dbex = new DBclass();
                        if (_Model.Zhiwu == "站长" || _Model.Zhiwu == "老师" || _Model.Name == "陈庆" || _Model.Name == "赵仁盛")
                        {
                            if (dbex.ExecuteSql("insert into log ([user],time,ip) values ('" + _Model.Name + "','" + System.DateTime.Now.ToString() + "','" + VisitedIP + "')") > 0)
                                Response.Redirect("NewsIndex.aspx");
                        }
                        else
                        {
                          //  if (_Model.Ip.IndexOf(VisitedIP) >= 0 || VisitedIP == "192.168.0.1" || VisitedIP == "127.0.0.1" || VisitedIP == "222.206.76.48" || VisitedIP == "211.64.19.66")//程序员调试请把这注释掉，因为此处VisitedIP获取的是192.168.0.1，127.0.0.1而实际的ip是222.206.75.16或222.206.75.15
                         //   {
                                if (dbex.ExecuteSql("insert into log ([user],time,ip) values ('" + _Model.Name + "','" + System.DateTime.Now.ToString() + "','" + VisitedIP + "')") > 0)
                                    Response.Redirect("NewsIndex.aspx");
                           // }
                           // else
                             //   Mystring.alert("你不能在此处登录后台，请在网站或指定地点登陆后台！");
                        }

                        //zgy

                    }
                    else
                        Mystring.alert("该用户已被锁定！");

                }
                else
                {
                    Err.Text = "密码错误！";
                }
            }
            else
            {
                Err.Text = "服务器存在异常，请稍后重试！";
            }
        }
        catch (Exception ex)
        {
            Err.Text = ex.ToString();
        }
        finally
        { }
    }
}
