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


public partial class music_add : System.Web.UI.Page
{
    protected static string constr = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //音频上传
        if (FileUpload1.PostedFile.FileName != "")
        {

            string MscPath = FileUpload1.PostedFile.FileName;
            string MscName = MscPath.Substring(MscPath.LastIndexOf("\\") + 1);
            string MscExtend = MscPath.Substring(MscPath.LastIndexOf(".") + 1);
            string ServerPath1 = Server.MapPath("Picture01/") + MscName;
            FileUpload1.PostedFile.SaveAs(ServerPath1);

            string Path = FileUpload1.PostedFile.FileName;
            string Name = Path.Substring(Path.LastIndexOf("\\") + 1);
            string Extend = Path.Substring(MscPath.LastIndexOf(".") + 1);
            string ServerPath2 = Server.MapPath("video/music/") + Name;
            FileUpload1.PostedFile.SaveAs(ServerPath2);
            SqlConnection con = new SqlConnection(constr);
            string title = this.title.Text.ToString();
            string picurl = "Picture01/" + MscName;
            string songurl = "video/music/" + Name;
            string source = this.source.Text.ToString();
            string lyric = this.Editor1.Text.ToString();
            string singer = this.singer.Text.ToString();
            string editor = this.editor.Text.ToString();
            string lanmu = "music";
            string datee = Convert.ToString(System.DateTime.Now);
            string Comstr = "Insert into fashion(title,picurl,url,content,author,editor,datee,source,lanmu) values "
                + "('" + title.ToString() + "','"+picurl+"','" + songurl.ToString() + "','" + lyric.ToString() + "','" + singer.ToString() + "','" + editor.ToString() + "','" + datee.ToString() + "','" + source.ToString() + "','"+lanmu+"')";
            con.Open();
            SqlCommand com = new SqlCommand(Comstr, con);
            com.ExecuteNonQuery();
            con.Close();

            Response.Write("<script language=javascript>alert('添加成功！');location='javascript:history.go(-1)'</script>");
            
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("music_add.aspx");


    }

}