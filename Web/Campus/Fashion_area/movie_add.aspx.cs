using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;
using System.IO;


public partial class movie_add : System.Web.UI.Page
{
    protected static string constr = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //shi频上传
        if (FileUpload1.PostedFile.FileName != "")
        {

            string PicPath = FileUpload1.PostedFile.FileName;
            string PicName = PicPath.Substring(PicPath.LastIndexOf("\\") + 1);
            string PicExtend = PicPath.Substring(PicPath.LastIndexOf(".") + 1);
            string ServerPath1 = Server.MapPath("Picture01/") + PicName;
            FileUpload1.PostedFile.SaveAs(ServerPath1);

            SqlConnection con = new SqlConnection(constr);
            string title = this.title.Text.ToString();
            string picurl = "Picture01/" + PicName;
         
            string source = this.source.Text.ToString();
            string jianjie = this.Editor1.Text.ToString();
            string author = this.author.Text.ToString();
            string editor = this.editor.Text.ToString();
            string lanmu = "movie";
            string datee = Convert.ToString(System.DateTime.Now);
            string Comstr = "Insert into fashion(title,picurl,content,author,editor,datee,source,lanmu) values "
                + "('" + title.ToString() + "','"+picurl.ToString()+"','" + jianjie.ToString() + "','" + author.ToString() + "','" + editor.ToString() + "','" + datee.ToString() + "','" + source.ToString() + "','"+lanmu+"')";
            con.Open();
            SqlCommand com = new SqlCommand(Comstr, con);
            com.ExecuteNonQuery();
            con.Close();

            Response.Write("<script language=javascript>alert('添加成功！');location='javascript:history.go(-1)'</script>");
           

        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("movie_add.aspx");


    }

}