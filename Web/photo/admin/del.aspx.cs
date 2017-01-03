using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.IO;
using Lgwin.BLL;


public partial class xlxy_admin_del : System.Web.UI.Page
{
    static string olestr = System.Configuration.ConfigurationManager.AppSettings["connStr"].ToString();
    SqlConnection conn = new SqlConnection(olestr);
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.chksess();
        int id = Convert.ToInt32(Request.QueryString["id"]);
        SqlDataReader dr = new PhotoBLL().PhotoSelect(id, "id", "Photo_photo");
       
        dr.Read();
        string path =Server.MapPath("~")+"/photo/admin/photo/"+dr["zhtID"].ToString()+ "/";
        File.Delete(path + dr["path"].ToString());
        File.Delete(path + dr["path_small"].ToString());
        dr.Close();
        new PhotoBLL().PhotoDelete(id, "id", "Photo_photo");
        Response.Write("<script>alert('操作成功');self.location='stu_pic_manage.aspx'</script>");
        

    }
}
