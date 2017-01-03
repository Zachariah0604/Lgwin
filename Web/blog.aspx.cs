using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BloClass;
namespace Lgwin
{
    public partial class blog : System.Web.UI.Page
    {
        const long clientID = 1601956471;//app_key
        const string responseType = "code";
        const string redirectUri = "http://lgwindow.sdut.edu.cn/Lgwin/manage/blog.aspx";//回调地址
        const string clientSecret = "b1f38df8abdd2173d0b2d3f34f5efe64";//app_secret
        SinaSerive serive = new SinaSerive(clientID.ToString(), clientSecret, redirectUri);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetCode();
            }
        }

        //请求
        protected void Button1_Click(object sender, EventArgs e)
        {
            serive.GetAuthorizationCode();
         
        }

      //  换取access_token
        protected void Button2_Click(object sender, EventArgs e)
        {
            serive.GetAccessTokenByAuthorizationCode(Request["code"]);
           
            //Response.Write("Access_token:" + serive.Token.access_token + "<br />");
            //Response.Write("Expires_in:" + serive.Token.expires_in + "<br />");
            //Response.Write("Refresh_Token:" + serive.Token.refresh_token + "<br />");

        }

       // 执行API
        protected void Button3_Click(object sender, EventArgs e)
        {
            var status = serive.Statuses_Upload("Oauth 2.0 测试" + DateTime.Now, upload.FileBytes);
            foreach (var p in status.GetType().GetProperties())
            {
                Response.Write(p.Name + ":" + p.GetValue(status, null) + "<br/>");
            }
        }

        private void GetCode()
        {
            if (serive.Token != null)
            {
                code.Text = serive.Token.access_token;
            }
            else
            {
                code.Text = "null";
            }
        }
    }
}