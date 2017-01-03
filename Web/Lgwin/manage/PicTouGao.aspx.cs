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
using System.IO;


public partial class Lgwin_manage_PicTouGao : System.Web.UI.Page
{
    string[] names;
   
    DataTable t = new DataTable("pics");
    protected void Page_Load(object sender, EventArgs e)
    {
        
        Mystring.chksess();
        t.Columns.Add("src", System.Type.GetType("System.String"));
        Bind();
        if (!IsPostBack)
        {

            GridView1.DataSource =t;
            GridView1.DataBind();
        }
    }
    public void Bind()
    {
        t.Clear();
        string root = "";
        root = HttpContext.Current.Server.MapPath("~/") ;
        root += "Uploads\\tougao\\";
        //Response.Write(root);
        if (Directory.Exists(root))
        {
            names = Directory.GetFiles(root);

            foreach (string p in names)
            {
                string im = p;
                im = "../../Uploads/tougao/" + im.Substring(im.LastIndexOf("\\") + 1);
                DataRow tr = t.NewRow();
                tr[0] = im;
                t.Rows.Add(tr);
                //Response.Write(im);

            }
        }
        else
        {
            Mystring.alert("图片路径出错，请联系程序员！！！");
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            if (((CheckBox)GridView1.Rows[i].Cells[0].FindControl("c1")).Checked)
            {
                File.Delete(names[i]);                  
            }
            else
            {    }
        }
        Mystring.alertAndRedirect("删除图片成功！( *^_^* )","PicTouGao.aspx");
      }
}
