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


public partial class bh_add : System.Web.UI.Page 
{

    
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
         string constr = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
        //图片上传
        if (FileUpload1.PostedFile.FileName != "")
        {   
            
            string Path = FileUpload1.PostedFile.FileName;
            string Name =Path.Substring(Path.LastIndexOf("\\") + 1);
            string Extend = Path.Substring(Path.LastIndexOf(".") + 1);
            if (!(Extend == "bmp" || Extend == "jpg" || Extend == "gif"))
            {
                Response.Write("<script language=javascript>alert('图片格式不正确，请选择合适格式图片!');location='javascript:history.go(-1)'</script>");
               
            }
           
            string ServerPath = Server.MapPath("Picture01/")+ Name;
            FileUpload1.PostedFile.SaveAs(ServerPath);
            SqlConnection con = new SqlConnection(constr);
            string title = this.title.Text.ToString();
            string book_pic = "Picture01/" + Name;
            string book_content = this.Editor1.Text.ToString();
            string author = this.author.Text.ToString();
            string editor = this.editor.Text.ToString();
            string lanmu = "bh";
            string datee = Convert.ToString(System.DateTime.Now);
            string Comstr = "Insert into fashion(title,content,picurl,author,editor,datee,lanmu) values "
                + "('" + title.ToString() + "','" + book_content.ToString() + "','" + book_pic.ToString() + "','" + author.ToString() + "','" + editor.ToString() + "','" + datee.ToString() + "','"+lanmu+"')";
            con.Open();
            SqlCommand com = new SqlCommand(Comstr, con);
            com.ExecuteNonQuery();
            con.Close();

            Response.Write("<script language=javascript>alert('添加成功！');location='javascript:history.go(-1)'</script>");

          
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("bh_add.aspx");
    
  
    }



   
}
