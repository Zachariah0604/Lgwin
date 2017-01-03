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

public partial class Lgwin_manage_ClassManage : System.Web.UI.Page
{
    //栏目管理页
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.chksess();
        if (!IsPostBack)
        {
            if (Mystring.chksess())
            {
                Mystring.chkAdmin(Session["Admin"].ToString(), 0);
                Mystring.chkPower(35, Session["User"].ToString());
            }
        }

    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "ed")
        {
            GridViewRow grdrow = (GridViewRow)((LinkButton)e.CommandSource).NamingContainer;
            Session["id"] = GridView1.Rows[grdrow.RowIndex].Cells[0].Text.Trim();
            string tid = GridView1.Rows[grdrow.RowIndex].Cells[1].Text.Trim();
            string name = GridView1.Rows[grdrow.RowIndex].Cells[2].Text.Trim();
            string power = GridView1.Rows[grdrow.RowIndex].Cells[3].Text.Trim();
            CheckBox chbox = (CheckBox)GridView1.Rows[grdrow.RowIndex].Cells[4].Controls[0];
            MultiView1.ActiveViewIndex = 2;
            RadioButtonList1.SelectedIndex = 2;
            TextBox_editid.Text = tid;
            TextBoxEdname.Text = name;
            TextBox_ediquanx.Text = power;
            if (chbox != null)
                CheckBox1.Checked = chbox.Checked;
        }
        if (e.CommandName == "deljigou")
        {
            GridViewRow grdrow = (GridViewRow)((LinkButton)e.CommandSource).NamingContainer;
            string id = GridView1.Rows[grdrow.RowIndex].Cells[0].Text.Trim();

            ClassBLL colbll = new ClassBLL();
            colbll.Del(int.Parse(id));

            GridView1.DataBind();
            MultiView1.ActiveViewIndex = 0;
        }
    }    
    protected void Button_add_Click(object sender, EventArgs e)
    {
        ClassBLL colbll = new ClassBLL();
        Class mod = new Class();
        mod.Tid = TextBox_id.Text.Trim();
        mod.PaiXu = mod.Tid;
        mod.Title = TextBox_Name.Text.Trim();
        mod.Power = TextBox_quanxian.Text.Trim();
        mod.Show = CheckBox2.Checked;

        if (colbll.Add(mod))
            Mystring.alert("添加成功！");

        GridView1.DataBind();
        MultiView1.ActiveViewIndex = 0;
        RadioButtonList1.SelectedIndex = 0;
    }
    protected void  Button_edit_Click(object sender, EventArgs e)
    {
        ClassBLL colbll = new ClassBLL();
        Class mod = colbll.GetClass(int.Parse(Session["id"].ToString()));
        mod.Tid = TextBox_editid.Text.Trim();
        mod.PaiXu = mod.Tid;
        mod.Title = TextBoxEdname.Text.Trim();
        mod.Power = TextBox_ediquanx.Text.Trim();
        mod.Show = CheckBox1.Checked;
        if (colbll.Update(mod))
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
