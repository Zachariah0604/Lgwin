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
public partial class Lgwin_manage_ZtManage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Mystring.chksess();
        //if (Mystring.chkAdmin(Session["Admin"].ToString(), 0))
        //{
        //    MultiView2.Visible = false;
        //    RadioButtonList2.Visible = false;
        //    if (GridView1.Rows.Count > 0)
        //    {
        //        if (Session["ZtId"] == null || Session["ZtJianch"] == null)
        //        {
        //            Session["ZtId"] = GridView1.Rows[0].Cells[0].Text.ToString();
        //            Session["ZtJianch"] = GridView1.Rows[0].Cells[2].Text.ToString();
        //        }
        //    }
        //}   
        Mystring.chksess();
        if (!IsPostBack)
        {
            if (Mystring.chksess())
            {
                if (Mystring.chkAdmin(Session["Admin"].ToString(), 0))
                {
                    MultiView2.Visible = false;
                    RadioButtonList2.Visible = false;
                    if (GridView1.Rows.Count > 0)
                    {
                        if (Session["ZtId"] == null || Session["ZtJianch"] == null)
                        {
                            Session["ZtId"] = GridView1.Rows[0].Cells[0].Text.ToString();
                            Session["ZtJianch"] = GridView1.Rows[0].Cells[2].Text.ToString();
                        }
                    }
                }
            }
        }
    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = RadioButtonList1.SelectedIndex;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int ztid=0;
        string Name = TextBox_Name.Text.Trim();
        string Jiancheng = TextBox_Jiancheng.Text.Trim();
        string Paixu = TextBox_Paixu.Text.Trim();
        bool cunzai = false;
        Zt mod = new Zt();
        mod.Ztname = Name;
        mod.ZtJiancheng = Jiancheng;
        mod.Px = Paixu;
        mod.Show = true;
        ZtBLL bll = new ZtBLL();
        IList<Zt> list = bll.GetZtList(true);
        foreach (Zt mod2 in list)
        {
            if (mod2.ZtJiancheng == Jiancheng)
            {
                cunzai = true;
            }
        }
        if (cunzai == true)
        {
            Mystring.alert("此专题简称已存在，请换用其他");
        }
        else
        {
            if (bll.Add(mod))
            list= bll.GetZtList(true);//得到新加专题的id
            foreach (Zt modzt in list)
            {
                if (modzt.ZtJiancheng == Jiancheng)
                {
                    ztid = modzt.Id;
                    break;
                }
            }
            Myfile.AddTopic(ztid);//生成专题文件
            MultiView1.ActiveViewIndex = 0;
            RadioButtonList1.SelectedIndex = 0;
            GridView1.DataBind();
            GridView1.SelectedIndex = GridView1.Rows.Count-1;
        }
    }
    /// <summary>
    /// 栏目管理
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button_Lanmu_Click(object sender, EventArgs e)
    {
        if (Mystring.chksess())
        {
            if (Mystring.chkPower(29, Session["User"].ToString()))
            {
                MultiView2.Visible = true;
                RadioButtonList2.Visible = true;
                MultiView2.ActiveViewIndex = 0;
                RadioButtonList2.SelectedIndex = 0;
                GridView2.DataBind();
            }
        }
    }
    protected void RadioButtonList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        MultiView2.Visible = true;
        MultiView2.ActiveViewIndex = RadioButtonList2.SelectedIndex;
        RadioButtonList2.Visible = true;
    }
    /// <summary>
    /// 添加栏目
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button2_Click(object sender, EventArgs e)
    {
        string Lanmu = TextBox_Lanmu.Text.Trim();
        ZtCaptionBLL blll = new ZtCaptionBLL();
        ZtCaption mod = new ZtCaption();
        if (Lanmu == "")
        {
            Mystring.alert("请输入栏目名称！");
        }
        else
        {
            mod.ZtCaptionName = Lanmu;
            mod.Ztid = Session["ZtId"].ToString().Trim();
            IList<ZtCaption> list= blll.GetZtCaptionList(mod.Ztid);
            int i = 0;
            for (int j = 0; j < list.Count; j++)
            {
                if (list[j].ZtCaptionName == Lanmu)
                { i = 1; }
            }
            if (i == 1)
            {
                Mystring.alert("该栏目名称已经存在！");
                MultiView2.Visible = true;
                MultiView2.ActiveViewIndex = 0;
                RadioButtonList2.Visible = true;
                RadioButtonList2.SelectedIndex = 0;
                GridView2.DataBind();
                GridView2.SelectedIndex = -1;
            }
            else
            {
                if (blll.Add(mod))
                {
                    Mystring.alert("操作成功！");
                    MultiView2.Visible = true;
                    MultiView2.ActiveViewIndex = 0;
                    RadioButtonList2.Visible = true;
                    RadioButtonList2.SelectedIndex = 0;
                    GridView2.DataBind();
                    GridView2.SelectedIndex = -1;
                }
            }
        }

    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if(e.CommandName=="ed")
        {
            GridViewRow grdrow=(GridViewRow)((LinkButton)e.CommandSource).NamingContainer;
            Session["id"] = GridView1.Rows[grdrow.RowIndex].Cells[0].Text.Trim();//传递专题id
            string name=GridView1.Rows[grdrow.RowIndex].Cells[1].Text.Trim();
            string jiancheng=GridView1.Rows[grdrow.RowIndex].Cells[2].Text.Trim();
            string paixu=GridView1.Rows[grdrow.RowIndex].Cells[3].Text.Trim();
            CheckBox chbox=(CheckBox)GridView1.Rows[grdrow.RowIndex].Cells[4].Controls[0];
            MultiView1.ActiveViewIndex = 2;
            TextBoxEdname.Text=name;
            TextBox_edjich.Text = jiancheng;
            TextBox_editpa.Text = paixu;
             if(chbox!=null)
                 CheckBox1.Checked=chbox.Checked;
        }
   }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string id = GridView1.SelectedRow.Cells[0].Text.Trim();
        string name2 = GridView1.SelectedRow.Cells[2].Text.Trim();
        if (Session["ZtId"] != null)
        {
            Session.Remove("id");
            Session.Remove("ZtId");
            Session.Remove("ZtJianch");
            Session.Add("ZtJianch", name2);
            Session.Add("ZtId", id);
            Session.Add("id", id);
        }
        else
        {
            Session.Remove("id");
            Session.Add("ZtId",id);
            Session.Add("id", id);
            Session.Add("ZtJianch", name2);

        }
    }
    /// <summary>
    /// 更新专题
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button3_Click(object sender, EventArgs e)
    {
        string name = TextBoxEdname.Text;
        string jiangcheng=TextBox_edjich.Text ;
        string Paixu= TextBox_editpa.Text ;
        bool xianshi= CheckBox1.Checked ;
        Zt mod = new Zt();
        ZtBLL bll = new ZtBLL();
        mod = bll.GetZtById(int.Parse(Session["id"].ToString()));
        mod.Ztname = name;
        mod.ZtJiancheng = jiangcheng;
        mod.Px = Paixu;
        mod.Show = xianshi; 
        if (bll.Update(mod))
        {
            Mystring.alert("操作成功！");
        }
        MultiView1.ActiveViewIndex = 0;
        RadioButtonList1.SelectedIndex = 0;
        GridView1.DataBind();
        GridView1.SelectedIndex = -1;
    }
    protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        GridViewRow grdrow = (GridViewRow)((LinkButton)e.CommandSource).NamingContainer;
        if (e.CommandName == "editlm")
        {
            Session["capid"]=grdrow.Cells[0].Text.Trim();
            string name = grdrow.Cells[1].Text.Trim();
            MultiView2.Visible = true;
            MultiView2.ActiveViewIndex = 2;
            RadioButtonList2.Visible = true;
            TextBox_EditMCh.Text = name;

        }
        if (e.CommandName == "Dellm")
        {
            Session["capid"] = grdrow.Cells[0].Text.Trim();
            MultiView2.Visible = true;
            MultiView2.ActiveViewIndex = 0;
            RadioButtonList2.Visible = true;
            RadioButtonList2.SelectedIndex = 0;
            string capid = GridView2.Rows[grdrow.RowIndex].Cells[0].Text.Trim();
            ZtCaptionBLL bll = new ZtCaptionBLL();
            if (bll.Del(capid)>0)
            {
                Mystring.alert("删除成功！");
            }
            GridView2.DataBind();
        }

    }
    /// <summary>
    /// 修改栏目
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button4_Click(object sender, EventArgs e)
    {
        ZtCaptionBLL bll = new ZtCaptionBLL();
        ZtCaption mod = bll.GetZtCaption(int.Parse(Session["capid"].ToString()));
        mod.ZtCaptionName = TextBox_EditMCh.Text.ToString().Trim();
        if (bll.Update(mod))        
        {
            Mystring.alert("操作成功！");
        }
        MultiView2.Visible = true;
        MultiView2.ActiveViewIndex = 0;
        RadioButtonList2.Visible = true;
        RadioButtonList2.SelectedIndex = 0;
        GridView2.DataBind();
        GridView2.SelectedIndex = -1;
    }
    /// <summary>
    /// 删除专题
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button_Del_Click(object sender, EventArgs e)
    {
        if (Mystring.chksess())
        {
            if (Mystring.chkPower(27, Session["User"].ToString()))
            {
                int count;
                ContentBLL blll = new ContentBLL();
                count = blll.GetCount("zt='" + Session["ZtJianch"].ToString() + "'");
                IList<Lgwin.Model.Content> list2 = blll.GetList("", count, 1, "zt='" + Session["ZtJianch"].ToString() + "'", out count);
                foreach (Lgwin.Model.Content mod in list2)
                {
                    ToHtml.DelHtml(mod);
                    blll.Del(mod.Id.ToString());
                }
                ZtBLL ztbll = new ZtBLL();
                ztbll.Del(Session["id"].ToString());
                Mystring.alert("删除" + count + "条记录成功！");
                GridView1.DataBind();
            }
        }
          
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        if (Mystring.chksess())
        {
            if (Mystring.chkPower(28, Session["User"].ToString()))
            {
                int count;
                ContentBLL blll = new ContentBLL();
                count = blll.GetCount("zt='" + Session["ZtJianch"].ToString() + "'");
                //Response.Write(count);
                IList<Lgwin.Model.Content> list2 = blll.GetList("", count, 1, "zt='" + Session["ZtJianch"].ToString() + "'", out count);
                foreach (Lgwin.Model.Content mod in list2)
                {
                    blll.Del(mod.Id.ToString());
                }
                ZtBLL ztbll = new ZtBLL();
                ztbll.Del(Session["id"].ToString());
                Mystring.alert("删除" + count + "条记录成功！");
                GridView1.DataBind();
            }
        }
    }
}
