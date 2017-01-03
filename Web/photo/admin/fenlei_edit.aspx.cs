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
public partial class xlxy_admin_fenlei_edit : System.Web.UI.Page
{
    public string path = "";
    static string olestr = System.Configuration.ConfigurationManager.AppSettings["connStr"].ToString();
    SqlConnection conn = new SqlConnection(olestr);
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.chksess();
       if (!IsPostBack)
      {
           int id = Convert.ToInt32(Request.QueryString["ID"]);
           conn.Open();
           //SqlCommand cmd = new SqlCommand("select * from [Photo_lmfenlei] where ID='"+id+"'",conn);
           //SqlDataReader dr = cmd.ExecuteReader();
           SqlDataReader dr = new PhotoBLL().PhotoSelect(id, "ID", "Photo_lmfenlei");
           dr.Read();
           if (dr["name"].ToString() != "" && dr["name"].ToString() != null)
           {
                  TextBox1.Text = dr["name"].ToString();
                
           }
           if (dr["introduction"].ToString() != "" && dr["introduction"].ToString() != null)
           {
              Editor1.Text = dr["introduction"].ToString();

           }
           if (dr["created_time"].ToString() != "" && dr["created_time"].ToString() != null)
           {
               TextBox2.Text = dr["created_time"].ToString();

           }
           else { TextBox2.Text ="当前时间"+ DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); }
           
           dr.Dispose();
           dr.Close();
           conn.Close();
       }
     
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        int id = Convert.ToInt32(Request["id"].ToString());
        string introduction = Editor1.Text.ToString();
        string name = TextBox1.Text.ToString();
        DateTime created_time = Convert.ToDateTime(TextBox2.Text.ToString());

        // xlxy.sqlNoQ("UPDATE [Photo_lmfenlei] SET[introduction]=  '" + Editor1.Text.ToString() + "',  [name] = '" + TextBox1.Text.ToString() + "',  [created_time] = '" + Convert.ToDateTime(TextBox2.Text.ToString()) + "' WHERE [ID] = " + Request["id"].ToString() + "");
        bool flag = new PhotoBLL().fenlei_edit1(id, introduction, name, created_time);
        if (flag == true)
        {
            Response.Write("<script>alert('操作成功');self.location='fenlei_man.aspx'</script>");
        }
        else { Response.Write("<script>alert('操作失败');self.location='fenlei_edit.aspx'</script>"); }
    }
}
