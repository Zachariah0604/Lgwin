using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Globalization;
using System.Data;
public partial class Campus_Html_03_Comment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string ConStr = System.Configuration.ConfigurationManager.AppSettings["connStr"].ToString();

        int id = int.Parse(Request.Form["hd_id"].ToString());
        string name = Request.Form["name"].ToString();
        string neirong = Request.Form["neirong"].ToString();
        if (name != "" && neirong != "")
        {
            string datee = Convert.ToString(System.DateTime.Now);
            SqlConnection myconnection = new SqlConnection(ConStr);
            myconnection.Open();
            SqlCommand mycommand = new SqlCommand("insert into Campus_comment (AID,name,comment,datee) values ('" + id + "','" + name + "','" + neirong + "','" + datee + "')", myconnection);
            int i = mycommand.ExecuteNonQuery();
            myconnection.Close();

            if (i > 0)
            {
                Response.Write("<script>alert('添加成功，等待审核……');history.go(-1)</script>");
                
                //Response.Write("<script>alert('添加成功！请刷新页面查看');</script>");
                //Response.Write("<script>location='" + url.ToString() + "'</script>");
            }

        }

        else
        {
            Response.Write("<script>alert('请填写用户名或评论！');history.go(-1)</script>");
        }
    }
    
        
  }