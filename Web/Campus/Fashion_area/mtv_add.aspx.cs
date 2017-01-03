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
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Globalization;


public partial class mtv_add : System.Web.UI.Page
{
    protected static string constr = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
      
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //上传
        if (FileUpload1.PostedFile.FileName != "")
        {

            string Path1 = FileUpload1.PostedFile.FileName;
            string Name1 = Path1.Substring(Path1.LastIndexOf("\\") + 1);
            string Extend1 = Path1.Substring(Path1.LastIndexOf(".") + 1);
            string ServerPath1 = Server.MapPath("Picture01/") + Name1;
            FileUpload1.PostedFile.SaveAs(ServerPath1);

            string Path2 = FileUpload2.PostedFile.FileName;
            string Name2 = Path2.Substring(Path2.LastIndexOf("\\") + 1);
            string Extend2 = Path2.Substring(Path2.LastIndexOf(".") + 1);
            string ServerPath2 = Server.MapPath("video/mtv/") + Name2;
            FileUpload2.PostedFile.SaveAs(ServerPath2);


            SqlConnection con = new SqlConnection(constr);
            string title = this.title.Text.ToString();
            string picurl = "Picture01/" + Name1;
            string url ="video/mtv/"+ Name2;
            string source = this.source.Text.ToString();
            string jianjie = this.Editor1.Text.ToString();
            string author = this.author.Text.ToString();
            string editor = this.editor.Text.ToString();
            string lanmu = "mtv";
            string datee = Convert.ToString(System.DateTime.Now);
            string Comstr = "Insert into fashion(title,picurl,url,content,author,editor,datee,source,lanmu) values "
                + "('" + title.ToString() + "','" + picurl + "','" + url.ToString() + "','" + jianjie.ToString() + "','" + author.ToString() + "','" + editor.ToString() + "','" + datee.ToString() + "','" + source.ToString() + "','" + lanmu + "')";
            con.Open();
            SqlCommand com = new SqlCommand(Comstr, con);
            com.ExecuteNonQuery();
            con.Close();
                        
         

        }
        //生成静态页

        SqlConnection conn = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand("select top 1 ID, title ,author,datee,url,content,editor from fashion where lanmu='mtv' order by ID desc", conn);
        conn.Open();
        SqlDataReader DR = cmd.ExecuteReader();
        StringBuilder sb1 = new StringBuilder();
        StringBuilder sb2 = new StringBuilder();
        StringBuilder sb3 = new StringBuilder();
        StringBuilder sb4 = new StringBuilder();
        StringBuilder sb5 = new StringBuilder();
        StringBuilder sb6 = new StringBuilder();
        
        while (DR.Read())
        {
            System.Text.Encoding code = System.Text.Encoding.GetEncoding("gb2312");

            // 读取模板文件
            string temp = HttpContext.Current.Server.MapPath("index3_mtv.model");

            StreamReader sr = null;
            string str = "";
            try
            {
                sr = new StreamReader(temp, code);
                str = sr.ReadToEnd(); // 读取文件
            }
            catch (Exception exp)
            {
                HttpContext.Current.Response.Write(exp.Message);
                HttpContext.Current.Response.End();
                sr.Close();
            }
            string id = DR["ID"].ToString();
            string title = DR["title"].ToString();
            string date = DateTime.Parse(DR["datee"].ToString()).ToString("yyyy-MM-dd hh:mm"); 
            string content = DR["content"].ToString();
            string author = DR["author"].ToString();
            string editor = DR["editor"].ToString();
            string Url = DR["url"].ToString();
            string url = Url.ToString();
            sb1.AppendFormat("{0}", title);
            sb2.AppendFormat("{0}", url);
            sb3.AppendFormat("{0}", date);
            sb4.AppendFormat("{0}", content);
            sb5.AppendFormat("{0}", author);
            sb6.AppendFormat("{0}", editor);

            string listStr = str;
            listStr = listStr.Replace("%%title%%", sb1.ToString());
            listStr = listStr.Replace("%%url%%", sb2.ToString());
            listStr = listStr.Replace("%%datee%%", sb3.ToString());
            listStr = listStr.Replace("%%content%%", sb4.ToString());
            listStr = listStr.Replace("%%author%%", sb5.ToString());
            listStr = listStr.Replace("%%editor%%", sb6.ToString());
            string path = HttpContext.Current.Server.MapPath("Htmlmtv_03/") + id+".html"; //获取当前路径，路径请根据自身情况设定
            try
            {
                StreamWriter sw = new StreamWriter(path, false, code);
                sw.Write(listStr);
                sw.Flush();
                sw.Close();
                sw.Dispose();
            }
            catch (Exception ex)
            {
                HttpContext.Current.Response.Write(ex.Message);
                HttpContext.Current.Response.End();
            }
        }
        DR.Close();
        //生成静态页结束

        Response.Write("<script language=javascript>alert('添加成功！');location='javascript:history.go(-1)'</script>");
       

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("mtv_add.aspx");


    }

   
}