using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Lgwin.Model;
using Lgwin.BLL;
using Lgwin.SqlDAL;
using System.Data.SqlClient;



    public partial class message : System.Web.UI.Page

    {
        SQLHelper help = new SQLHelper();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
           
                
            DataSet ds = new DataSet();
            try
            {
                ds=help.GetMessageData(id);
                MessageRepeater.DataSource = ds;
                MessageRepeater.DataBind();

            }
            catch (SqlException e1)
            {
                Response.Write(e1.ToString());
            }


            this.PageInfo.InnerHtml = PageList.GetPageNum(ds, MessageRepeater, 5);
            help.closeConn();
        }
        protected void repLM_ItemDataBound(object sender, System.Web.UI.WebControls.RepeaterItemEventArgs e)
        {

            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                string iid = ((Label)e.Item.FindControl("llid")).Text;
                help.openConn();
                Repeater MessageReplyRepeater = (Repeater)e.Item.FindControl("MessageReply");
               
                DataRowView rowv = (DataRowView)e.Item.DataItem;
                DataSet dsr = new DataSet();
                dsr=help.repLMessageData(iid);
                MessageReplyRepeater.DataSource = dsr.Tables["T_Karat_Message_Reply"].DefaultView;
                MessageReplyRepeater.DataBind();
                help.closeConn();
            }

        }
      
    }
