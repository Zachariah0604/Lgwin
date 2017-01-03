using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Net;
using System.IO;

public partial class weather : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        byte[] buf = new byte[38192];
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.nmc.gov.cn/tqframe/54830/1.html");   //textBox1中输入网址   
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Stream resStream = response.GetResponseStream();
        int count = resStream.Read(buf, 0, buf.Length);
        string content= System.Text.Encoding.Default.GetString(buf, 0, count);
        string qiwen = "";
        int start = content.IndexOf("温");
        qiwen = content.Substring(start+2);
        int end = qiwen.IndexOf("</td>");
        qiwen = ""+qiwen.Remove(end);

        start = content.IndexOf("ff60\">");
        string tianqi = "";
        tianqi = content.Substring(start+6);
        end = tianqi.IndexOf("</span></td>");
        tianqi = tianqi.Remove(end);

        start = content.IndexOf("风：");
        string feng = "";
        feng = content.Substring(start+2);
        end = feng.IndexOf("</td>");
        feng = ""+feng.Remove(end);

        //start = content.IndexOf();
        Label2.Text = DateTime.Now.ToString("dd") + "日 " + tianqi;
        Label1.Text =feng+"　"+ qiwen ;
        resStream.Close(); 
    }
}
