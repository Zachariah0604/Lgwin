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

public partial class AboutAdmin_AdminCounter_admin_counter : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.chkPower(38, Session["User"].ToString());
    }
}
