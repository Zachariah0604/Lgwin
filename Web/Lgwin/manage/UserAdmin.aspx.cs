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

public partial class Lgwin_manage_UserAdmin : System.Web.UI.Page
{        
    protected  string user = "";
    RegUser mod = new RegUser();
    RegUserBLL bll = new RegUserBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.chksess();
        if (!IsPostBack)
        {
            if (Mystring.chksess())
            {
                if (Mystring.chkAdmin(Session["Admin"].ToString(), 0))
                {
                    user = Server.UrlDecode(Request.QueryString["User"].ToString());
                    if (user == null || user == "")
                    {
                        Mystring.alertAndBack("参数丢失！");
                    }
                    else
                    {
                        mod = bll.GetUserInfo(user);
                        dangqian.Text = mod.Name;
                        paixu_tb.Text = mod.Paixu;
                        if (mod.Zaizhi)
                        {
                            zaizhi.Checked = true;
                        }
                        if (mod.Pass)
                        {
                            Unlock.Checked = true;
                        }
                        RadioButtonList1.SelectedValue = mod.Admin;
                        User_tb.Text = mod.UserName;
                        namee_tb.Text = mod.Name;
                        tel_tb.Text = mod.Tel;
                        Email_tb.Text = mod.Email;
                        QQ_tb.Text = mod.QQ;
                        if (mod.Birthday.ToShortDateString() == "0001-1-1")
                            shengri_tb.Text = "";
                        else
                        {
                            shengri_tb.Text = mod.Birthday.ToShortDateString();
                        }
                        DropDownList1.SelectedValue = mod.Nianji;
                        xuehao_tb.Text = mod.Xuehao;
                        zybj_tb.Text = mod.Zybj;
                        jiguan_tb.Text = mod.Jiguan;
                        if (mod.Intime.ToShortDateString() == "0001-1-1")
                            jinru_tb.Text = "";
                        else
                            jinru_tb.Text = mod.Intime.ToShortDateString();
                        if (mod.Outtime.ToShortDateString() == "0001-1-1")
                            likai_tb.Text = "";
                        else
                            likai_tb.Text = mod.Outtime.ToShortDateString();

                        for (int i = 0; i < RadioButtonList_zhiwu.Items.Count; i++)
                        {
                            if (RadioButtonList_zhiwu.Items[i].Text == mod.Zhiwu.ToString())
                                RadioButtonList_zhiwu.Items[i].Selected = true;
                        }

                        //Lgwin.BLL.PowerClassBLL pcbll = new PowerClassBLL();
                        //PowerClass pcmod = new PowerClass();
                        //pcmod=pcbll.GetPowerClassList("all");
                        

                        CheckBoxList1.DataBind();
                        CheckBoxList2.DataBind();
                        CheckBoxList3.DataBind();
                        CheckBoxList4.DataBind();
                        CheckBoxList5.DataBind();
                        CheckBoxList6.DataBind();
                        setPower(mod.Power.ToString());
                        jieshao_tb.Text = mod.Jieshao;
                        shengri_tb.Attributes.Add("onFocus", "selectDate(this)");
                        jinru_tb.Attributes.Add("onFocus", "selectDate(this)");
                        likai_tb.Attributes.Add("onFocus", "selectDate(this)");
                    }
                }
            }
            
        }
    }
    public string getPowerString()
    {
        string ps = "|";

        for (int i = 0; i < CheckBoxList1.Items.Count; i++)
        {
            if (CheckBoxList1.Items[i].Selected == true)
            {
                if (ps == "|")
                {
                    ps += CheckBoxList1.Items[i].Value;
                }
                else
                    ps += "|" + CheckBoxList1.Items[i].Value;
            }
        }
        for (int i = 0; i < CheckBoxList2.Items.Count; i++)
        {
            if (CheckBoxList2.Items[i].Selected == true)
            {
                if (ps == "|")
                {
                    ps += CheckBoxList2.Items[i].Value;
                }
                else
                    ps += "|" + CheckBoxList2.Items[i].Value;
            }
        }
        for (int i = 0; i < CheckBoxList3.Items.Count; i++)
        {
            if (CheckBoxList3.Items[i].Selected == true)
            {
                if (ps == "|")
                {
                    ps += CheckBoxList3.Items[i].Value;
                }
                else
                    ps += "|" + CheckBoxList3.Items[i].Value;
            }
        }
        for (int i = 0; i < CheckBoxList4.Items.Count; i++)
        {
            if (CheckBoxList4.Items[i].Selected == true)
            {
                if (ps == "|")
                {
                    ps += CheckBoxList4.Items[i].Value;
                }
                else
                    ps += "|" + CheckBoxList4.Items[i].Value;
            }
        }
        for (int i = 0; i < CheckBoxList5.Items.Count; i++)
        {
            if (CheckBoxList5.Items[i].Selected == true)
            {
                if (ps == "|")
                {
                    ps += CheckBoxList5.Items[i].Value;
                }
                else
                    ps += "|" + CheckBoxList5.Items[i].Value;
            }
        }
        for (int i = 0; i < CheckBoxList6.Items.Count; i++)
        {
            if (CheckBoxList6.Items[i].Selected == true)
            {
                if (ps == "|")
                {
                    ps += CheckBoxList6.Items[i].Value;
                }
                else
                    ps += "|" + CheckBoxList6.Items[i].Value;
            }
        }
        ps = ps + "|";
        return ps;
    }
    public void setPower(string ps)
    {
        for (int i = 0; i < CheckBoxList1.Items.Count; i++)
        {
            if (ps.IndexOf("|" + CheckBoxList1.Items[i].Value + "|") >= 0)
            {
                CheckBoxList1.Items[i].Selected = true;
            }
        }
        for (int i = 0; i < CheckBoxList2.Items.Count; i++)
        {
            if (ps.IndexOf("|" + CheckBoxList2.Items[i].Value + "|") >= 0)
            {
                CheckBoxList2.Items[i].Selected = true;
            }
        }
        for (int i = 0; i < CheckBoxList3.Items.Count; i++)
        {
            if (ps.IndexOf("|" + CheckBoxList3.Items[i].Value + "|") >= 0)
            {
                CheckBoxList3.Items[i].Selected = true;
            }
        }
        for (int i = 0; i < CheckBoxList4.Items.Count; i++)
        {
            if (ps.IndexOf("|" + CheckBoxList4.Items[i].Value + "|") >= 0)
            {
                CheckBoxList4.Items[i].Selected = true;
            }
        }

        for (int i = 0; i < CheckBoxList5.Items.Count; i++)
        {
            if (ps.IndexOf("|" + CheckBoxList5.Items[i].Value+"|") >= 0)
            {
                CheckBoxList5.Items[i].Selected = true;
            }
        }
        for (int i = 0; i < CheckBoxList6.Items.Count; i++)
        {
            if (ps.IndexOf("|" + CheckBoxList6.Items[i].Value + "|") >= 0)
            {
                CheckBoxList6.Items[i].Selected = true;
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        user = Request.QueryString["User"].ToString();
        if (user == null || user == "")
        {
            Mystring.alertAndBack("参数丢失！");
        }
        else
        {
            RegUser mod2 = new RegUser();
            RegUserBLL bll2 = new RegUserBLL();
            mod2 = bll2.GetUserInfo(user);

            mod2.Paixu = paixu_tb.Text.Trim();
            mod2.Pass = Unlock.Checked;
            mod2.Zaizhi = zaizhi.Checked;
            mod2.Admin = RadioButtonList1.SelectedValue;
            mod2.Zhiwu = RadioButtonList_zhiwu.SelectedItem.Text;

            mod2.UserName = User_tb.Text.Trim();
            mod2.Name = namee_tb.Text.Trim();
            mod2.Tel = tel_tb.Text.Trim();
            mod2.Email = Email_tb.Text.Trim();
            mod2.QQ = QQ_tb.Text.Trim();
            if (shengri_tb.Text == null || shengri_tb.Text.Trim() == "")
                mod2.Birthday = DateTime.Parse(System.Data.SqlTypes.SqlDateTime.MinValue.ToString());
            else
            {
                mod2.Birthday = Convert.ToDateTime(shengri_tb.Text.Trim());
            }
            mod2.Nianji = DropDownList1.SelectedValue;
            mod2.Xuehao = xuehao_tb.Text;
            mod2.Zybj = zybj_tb.Text;
            mod2.Jiguan = jiguan_tb.Text;
            if (jinru_tb.Text == null || jinru_tb.Text.Trim() == "")
                mod2.Intime = DateTime.Parse(System.Data.SqlTypes.SqlDateTime.MinValue.ToString());
            else
            {
                mod2.Intime = Convert.ToDateTime(jinru_tb.Text.Trim());
            }
            if (likai_tb.Text == null || likai_tb.Text.Trim() == "")
                mod2.Outtime = DateTime.Parse(System.Data.SqlTypes.SqlDateTime.MinValue.ToString());
            else
            {
                mod2.Outtime = Convert.ToDateTime(likai_tb.Text.Trim());
            }
            mod2.Zhiwu = RadioButtonList_zhiwu.SelectedItem.ToString();
            mod2.Power = getPowerString();
            mod2.Jieshao = jieshao_tb.Text;

            if (bll2.Update(mod2))
            {
                Mystring.alertAndRedirect("管理用户数据成功！","UserManage.aspx"); 
            }
            else
            {
                Mystring.alert("操作失败，请重试！");
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Mystring.Back();
    }
    protected void Button_Del_Click(object sender, EventArgs e)
    {
        user = Request.QueryString["User"].ToString();
        mod= bll.GetUserInfo(user);
        if(bll.Del(mod.UserId.ToString())>0)
        {
            Mystring.alertAndRedirect("删除用户数据成功！","UserManage.aspx"); 
        }
    }
}
