using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Lgwin.TouGao
{
    public partial class TouGaoManage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Mystring.karatchksess())
            {
                if (!IsPostBack)
                {
                    string sql1 = "SELECT [Content] FROM article where title='投稿公告管理' ";
                    SqlDataReader dr1 = xlxy.dr(sql1);
                    while (dr1.Read())
                    {
                        Editor1.Text = dr1["Content"].ToString();
                    }
                    dr1.Close();
                }
               
            }
        }

        protected void Button_tiaojiao_Click(object sender, EventArgs e)
        {
            string strcon = ConfigurationSettings.AppSettings["connStr"];
            string sqlstr = "update article set [Content] = '" + Editor1.Text + "' where title='投稿公告管理'";
            SqlConnection sqlcon = new SqlConnection(strcon);
            SqlCommand sqlcom = new SqlCommand(sqlstr, sqlcon);
            sqlcon.Open();
            int i = sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            if (i > 0)
            {
                Response.Write("<script>alert('修改成功！');self.location='../Lgwin/manage/Main.html'</script>");
            }
            else
                Response.Write("<script>alert('修改失败！请重试');self.location='../Lgwin/manage/Main.html'</script>");

        }

        protected void Editor1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}