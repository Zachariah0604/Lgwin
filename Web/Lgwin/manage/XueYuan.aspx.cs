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
public partial class Lgwin_manage_XueYuan : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.chksess();
        if (!IsPostBack)
        {
            if (Mystring.chksess())
            {
                Mystring.chkAdmin(Session["Admin"].ToString(), 0);
                Mystring.chkPower(36, Session["User"].ToString());
            }
        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "ed")
        {
            GridViewRow grdrow = (GridViewRow)((LinkButton)e.CommandSource).NamingContainer;
            Session["id"] = GridView1.Rows[grdrow.RowIndex].Cells[0].Text.Trim();//传递专题id
            string name = GridView1.Rows[grdrow.RowIndex].Cells[1].Text.Trim();
            string paixu = GridView1.Rows[grdrow.RowIndex].Cells[2].Text.Trim();
            CheckBox chbox = (CheckBox)GridView1.Rows[grdrow.RowIndex].Cells[3].Controls[0];
            MultiView1.ActiveViewIndex = 2;
            RadioButtonList1.SelectedIndex = 2;
            TextBoxEdname.Text = name;
            TextBox_editpa.Text = paixu;
            if (chbox != null)
                CheckBox1.Checked = chbox.Checked;
        }
        if (e.CommandName == "deljigou")
        {
            GridViewRow grdrow = (GridViewRow)((LinkButton)e.CommandSource).NamingContainer;
            string id = GridView1.Rows[grdrow.RowIndex].Cells[0].Text.Trim();     

            CollegeBLL colbll = new CollegeBLL();
            colbll.Del(id);

            GridView1.DataBind();
            MultiView1.ActiveViewIndex = 0;
        }
    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = RadioButtonList1.SelectedIndex;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        CollegeBLL colbll = new CollegeBLL();
        College mod = new College();
        mod.Id =int.Parse(Session["id"].ToString());
        mod.Name = TextBoxEdname.Text;
        mod.Type=CheckBox1.Checked;
        mod.Xu =int.Parse(TextBox_editpa.Text);
        if(colbll.Update(mod))
            Mystring.alert("更新成功！");

        GridView1.DataBind();
        MultiView1.ActiveViewIndex = 0;
        RadioButtonList1.SelectedIndex = 0;

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        CollegeBLL colbll = new CollegeBLL();
        College mod = new College();
        mod.Name = TextBox_Name.Text;
        mod.Type = CheckBox2.Checked;
        mod.Xu =int.Parse(TextBox_Paixu.Text);
        if (colbll.ADD(mod))
            Mystring.alert("添加成功！");

        GridView1.DataBind();
        MultiView1.ActiveViewIndex = 0;
        RadioButtonList1.SelectedIndex = 0;
    }
}
