using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Lgwin.Karat
{
    public partial class KaratPhoto : System.Web.UI.Page
    {
        SQLHelper helper = new SQLHelper();
        protected void Page_Load(object sender, EventArgs e)
        {
            string iParentID = Request["ParentID"];
            DataTable dt = new DataTable();
            dt = helper.DisPlayList_Ds(iParentID);
            KaratImages.DataSource = dt.DefaultView;
            KaratImages.DataBind();
        }
      
        public string BuyListTitle(string lcontent)
        {
            string buycontent;

            if (lcontent.Length <= 15)
            {


                buycontent = lcontent;

                return buycontent;

            }

            else
            {

                buycontent = lcontent.Substring(0, 15);

                return buycontent + "..";
            }

        }
    }
}