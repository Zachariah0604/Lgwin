using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class karat_Search : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    
        string year = Request.Form["textfield"].ToString();
        string path = Server.MapPath("~") + "/karat/member/" + year + ".html";
        if (File.Exists(path))
        {
            Response.Redirect(year + ".html");
        }
        else
        { Response.Write("<script>alert('对不起您输入有误');history.go(-1)</script>"); }
        if (year == "在职")
        {
            Response.Redirect("team_members.html");
        }
    }
}