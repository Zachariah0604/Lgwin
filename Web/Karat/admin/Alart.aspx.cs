using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Karat_admin_Alart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

        Response.Write("<script>alert('模块正在建设中，敬请期待！');self.location='../index.html'</script>");
  
    }
}