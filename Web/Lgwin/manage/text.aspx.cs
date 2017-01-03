using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Text;
using System.IO;

namespace Lgwin.Lgwin.manage
{
    public partial class text : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            PostOnSina("nihaoma");
        }
        public string PostOnSina(string contents)
        {
            string username =" lgwindow@163.com";
            string password = "xinwenwang0618";
            string appKey = "1601956471";
            string url = "https://api.weibo.com/2/statuses/update.json";
            var request = WebRequest.Create(url) as HttpWebRequest;

            request.Credentials = new NetworkCredential(username, password);
            byte[] authBytes = Encoding.UTF8.GetBytes(username + ":" + password);
            request.Headers["Authorization"] = "Basic " + Convert.ToBase64String(authBytes);
            request.Method = "POST";

            request.ContentType = "application/x-www-form-urlencoded";
            var body = "source=" + HttpUtility.UrlEncode(appKey) + "&status=" + HttpUtility.UrlEncode(contents);

            using (var writer = new StreamWriter(request.GetRequestStream()))
            {
                writer.Write(body);
            }

            WebResponse response = request.GetResponse();
            using (Stream receiveStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(receiveStream, Encoding.UTF8);
                string result = reader.ReadToEnd();
                return result;
            }
        }
    }
}