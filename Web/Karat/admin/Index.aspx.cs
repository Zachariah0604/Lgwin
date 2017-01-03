using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Configuration;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Text;

public partial class karat3_Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.karatchksess();        
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
         Karat_ToIndex.indextohtml();
         Karat_ToIndex.work_showtohtml();
         Karat_ToIndex.team_memberstohtml();
         Karat_ToIndex.team_members_tohtml2();
         Karat_ToIndex.team_culturetohtml();
         Karat_ToIndex.karatxinyu();
         Karat_ToIndex.tuanduidongtai();
        Label1.Text = "一级页生成成功！请点击查看！";
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
      //  Karat_ToIndex.renyuanzhaopin();
        Karat_ToIndex.karatxinyu_03tohtml();
        Karat_ToIndex.dashiji_03tohtml();
        Karat_ToIndex.tuanduidongtai_03tohtml();
       Label1.Text = "二级页生成成功！请点击查看！";
    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("KaratCultural.aspx");
    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("WorkShowManage.aspx");
    }

    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        Response.Redirect("EventsManage.aspx");
    }

    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Response.Redirect("ArticleManage.aspx");
    }

    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        Response.Redirect("DongtaiManage.aspx");
    }
}