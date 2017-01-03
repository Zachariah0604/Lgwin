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
using Lgwin.BLL;
using Lgwin.Model;
using System.Collections.Generic;

public partial class Lgwin_manage_PowerManage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Mystring.chksess())
            {
                Mystring.chkAdmin(Session["Admin"].ToString(), 0);
                Mystring.chkPower(34, Session["User"].ToString());
            }
        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "ed")
        {
            GridViewRow grdrow = (GridViewRow)((LinkButton)e.CommandSource).NamingContainer;
            Session["id"] = GridView1.Rows[grdrow.RowIndex].Cells[0].Text.Trim();
            string PowerName = GridView1.Rows[grdrow.RowIndex].Cells[1].Text.Trim();
            string power = GridView1.Rows[grdrow.RowIndex].Cells[2].Text.Trim();
            MultiView1.ActiveViewIndex = 2;
            RadioButtonList1.SelectedIndex = 2;
            TextBoxEdname.Text = PowerName;
        }
        if (e.CommandName == "deljigou")
        {
            GridViewRow grdrow = (GridViewRow)((LinkButton)e.CommandSource).NamingContainer;
            string id = GridView1.Rows[grdrow.RowIndex].Cells[0].Text.Trim();

            PowerClassBLL Pcbll = new PowerClassBLL();
            Pcbll.Del(int.Parse(id));
            
            GridView1.DataBind();
            MultiView1.ActiveViewIndex = 0;
        }
    }    
    protected void Button_add_Click(object sender, EventArgs e)
    {
        PowerClassBLL PcBll = new PowerClassBLL();
        PowerClass mod = new PowerClass();
        mod.Power =TextBox_Name.Text.Trim();
        mod.Class = DropDownList_class.SelectedValue;

        if (PcBll.Add(mod))
            Mystring.alert("添加成功！");

        GridView1.DataBind();
        MultiView1.ActiveViewIndex = 0;
        RadioButtonList1.SelectedIndex = 0;
    }
    protected void Button_edit_Click(object sender, EventArgs e)
    {
        PowerClassBLL PcBll = new PowerClassBLL();
        PowerClass mod = PcBll.GetPowerClassById(int.Parse(Session["id"].ToString()));

        mod.Power = TextBoxEdname.Text.Trim();
        if (PcBll.Update(mod))
            Mystring.alert("更新成功！");

        GridView1.DataBind();
        MultiView1.ActiveViewIndex = 0;
        RadioButtonList1.SelectedIndex = 0;
    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = RadioButtonList1.SelectedIndex;
    }
}