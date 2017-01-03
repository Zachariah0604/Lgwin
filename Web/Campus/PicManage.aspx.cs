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
using System.Threading;
using System.Collections.Generic;

public partial class PicManage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void upload_Click(object sender, EventArgs e)
    {
        if (PicUpload.PostedFile.FileName != "")
        {
            string ImgPath = PicUpload.PostedFile.FileName;
            string ImgName = ImgPath.Substring(ImgPath.LastIndexOf("\\") + 1);
            string ImgExtend = ImgPath.Substring(ImgPath.LastIndexOf(".") + 1);
            if (!(ImgExtend == "bmp" || ImgExtend == "jpg" || ImgExtend == "gif" || ImgExtend == "JPG"))
            {
                Label_Msg.Text = "上传格式不正确";
                return;
            }
            string ServerPath = Server.MapPath("./Pictures/") + ImgName;
            PicUpload.PostedFile.SaveAs(ServerPath);
            string ConStr = System.Configuration.ConfigurationSettings.AppSettings["connStr"].ToString();
            string com = "insert into Pic (Pic_name,Pic_lanmu) values ('"+ ImgName +"','"+ DropDownList1.Text +"')";
            SqlConnection Con = new SqlConnection(ConStr);
            Con.Open();
            SqlCommand sqlcom = new SqlCommand(com, Con);
            int i=sqlcom.ExecuteNonQuery();
            Con.Close();
            if (i > 0)
            {
                Label_Msg.Text = "上传成功" + ImgName;
            }
        }
    }
    protected void Button_return_Click(object sender, EventArgs e)
    {
        Response.Write("<script>location='Main_Console.aspx'</script>");
    }
}
