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
using System.Collections.Generic;
using System.Text;
using Lgwin.Model;
using Lgwin.BLL;
using System.Data.SqlClient;

public partial class Lgwin_manage_AuditCount : System.Web.UI.Page
{
    //审核统计页
    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.chksess();
        //if (Mystring.chksess())
        //{
            //if (Mystring.chkPower(37, Session["User"].ToString()))
            //{
                TextBox_Start.Attributes.Add("onfocus", "selectDate(this)");
                TextBox_stop.Attributes.Add("onfocus", "selectDate(this)");
            //}
        //}
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedValue == "新闻网")
        {

            #region 新闻网稿件统计
            string start = TextBox_Start.Text.Trim();
            string stop = TextBox_stop.Text.Trim();
            if (stop == "" || start == "")
                Mystring.alert("请选择起止时间");
            else
            {
                string selectvalue = RadioButtonList1.SelectedValue;
                ContentBLL conbll = new ContentBLL();
                int total = 0;

                if (selectvalue == "0")//编辑/
                {
                    int count;
                    RegUserBLL usebll = new RegUserBLL();
                    IList<RegUser> aa = usebll.GetUserByPage(1, 1, "[zaizhi]=1", out count);
                    IList<RegUser> list = usebll.GetUserByPage(count, 1, "[zaizhi]=1", out count);
                    int[] number = new int[count];
                    string[] names = new string[count];
                    string text = "";
                    for (int i = 0; i < count; i++)
                    {
                        number[i] = conbll.GetCount("[auditing]='1'and([editor] like '%" + list[i].Name + "%')  and ([datee]<='" + stop + "' and [datee]>='" + start + "') and ([caption]<>'废稿')");
                        names[i] = list[i].Name;
                    }
                    Array.Sort(number, names);
                    for (int j = 0; j < count; j++)
                    {
                        text += "<tr><td><a href=\"NewsTongJi.aspx?webtype=1&Editor=" + Server.UrlEncode(names[count - j - 1].ToString()) + "&Website=" + Server.UrlEncode("新闻网") + " &Start=" + start + "&Stop=" + stop + "\" target=\"_blank\">" + names[count - j - 1] + "</a></td><td>" + number[count - j - 1] + "</td><td>" + (j + 1) + "</td></tr>";
                        total += int.Parse(number.GetValue(j).ToString());
                    }
                    text += "<tr><td>总计</td><td>" + total + "</td><td></td></tr>";
                    text = table_st() + text + table_en();
                    result.InnerHtml = text;
                }
                if (selectvalue == "1")//学院
                {
                    CollegeBLL colbll = new CollegeBLL();
                    IList<College> list = colbll.GetCollegeList();
                    int con = list.Count;
                    int[] paiming = new int[con];
                    string[] xueyuan = new string[con];
                    string text = "";
                    for (int i = 0; i < list.Count; i++)
                    {
                        paiming[i] = conbll.GetCount("[fro]='" + list[i].Name + "' and [auditing]='1' and ([datee]<='" + stop + "' and [datee]>='" + start + "') and ([caption]<>'废稿')");
                        xueyuan[i] = list[i].Name;
                    }
                    Array.Sort(paiming, xueyuan);
                    for (int j = 0; j < con; j++)
                    {
                        text += "<tr><td><a href=\"NewsTongJi.aspx?webtype=1&Xueyuan=" + Server.UrlEncode(xueyuan[con - j - 1].ToString()) + " &Website=" + Server.UrlEncode("新闻网") + " &Start=" + start + "&Stop=" + stop + "\" target=\"_blank\">" + xueyuan[con - j - 1] + "</a></td><td>" + paiming[con - j - 1] + "</td><td>" + (j + 1) + "</td></tr>";
                        total += int.Parse(paiming.GetValue(j).ToString());
                    }
                    text += "<tr><td>总计</td><td>" + total + "</td><td></td></tr>";
                    text = table_st() + text + table_en();
                    result.InnerHtml = text;
                }
                if (selectvalue == "2")//栏目
                {
                    ClassBLL classbll = new ClassBLL();
                    IList<Class> list = classbll.GetClassList(false);
                    int con = list.Count;
                    int[] shu = new int[con];
                    string[] lanmu = new string[con];
                    string text = "";
                    for (int i = 0; i < con; i++)
                    {
                        shu[i] = conbll.GetCount("caption='" + list[i].Title + "' and [auditing]='1' and ([datee]<='" + stop + "' and [datee]>='" + start + "') and ([caption]<>'废稿')");
                        lanmu[i] = list[i].Title;
                    }
                    Array.Sort(shu, lanmu);
                    for (int j = 0; j < con; j++)
                    {
                        text += "<tr><td><a href=\"NewsTongJi.aspx?webtype=1&Caption=" + Server.UrlEncode(lanmu[con - j - 1].ToString()) + "&Website=" + Server.UrlEncode("新闻网") + " &Start=" + start + "&Stop=" + stop + "\" target=\"_blank\">" + lanmu[con - j - 1] + "</a></td><td>" + shu[con - j - 1] + "</td><td>" + (j + 1) + "</td></tr>";
                        total += int.Parse(shu.GetValue(j).ToString());
                    }
                    text += "<tr><td>总计</td><td>" + total + "</td><td></td></tr>";
                    text = table_st() + text + table_en();
                    result.InnerHtml = text;
                }
                if (selectvalue == "3")//记者
                {
                    int count;
                    RegUserBLL usebll = new RegUserBLL();
                    IList<RegUser> aa = usebll.GetUserByPage(1, 1, "[zaizhi]=1", out count);
                    IList<RegUser> list = usebll.GetUserByPage(count, 1, "[zaizhi]=1", out count);
                    int[] number = new int[count];
                    string[] names = new string[count];
                    string text = "";
                    for (int i = 0; i < count; i++)
                    {
                        number[i] = conbll.GetCount("[auditing]='1'and([author] like '%" + list[i].Name + "%')  and ([datee]<='" + stop + "' and [datee]>='" + start + "') and ([caption]<>'废稿')");
                        names[i] = list[i].Name;
                    }
                    Array.Sort(number, names);
                    for (int j = 0; j < count; j++)
                    {
                        text += "<tr><td><a href=\"NewsTongJi.aspx?webtype=1&Author=" + Server.UrlEncode(names[count - j - 1].ToString()) + "&Website=" + Server.UrlEncode("新闻网") + " &Start=" + start + "&Stop=" + stop + "\" target=\"_blank\">" + names[count - j - 1] + "</a></td><td>" + number[count - j - 1] + "</td><td>" + (j + 1) + "</td></tr>";
                        total += int.Parse(number.GetValue(j).ToString());
                    }
                    text += "<tr><td>总计</td><td>" + total + "</td><td></td></tr>";
                    text = table_st() + text + table_en();
                    result.InnerHtml = text;
                }
                if (selectvalue == "4")//头条
                {
                    string text = "<table width=\"300px\" border=\"1\" bordercolor=\"#993300\" cellspacing=\"0\" cellpadding=\"0\"style=\"border-collapse:collapse\"><tr style=\"color:#FFFFFF\"><td width=\"50%\" height=\"35px\">时间</td><td>从" + start + "</td><td>到" + stop + "</td></tr> ";

                    total = conbll.GetCount("[auditing]='1' and ([yaowen]='1')  and ([datee]<='" + stop + "' and [datee]>='" + start + "') and ([caption]<>'废稿')");
                    text += "<tr><td><a href=\"NewsTongJi.aspx?webtype=1&TouTiao=" + Server.UrlEncode("发布头条总数") + "&Website=" + Server.UrlEncode("新闻网") + " &Start=" + start + "&Stop=" + stop + "\" target=\"_blank\">发布头条总数</a></td><td>" + total + "条</td><td></td></tr>";
                    text = text + table_en();
                    result.InnerHtml = text;
                }
            }
            #endregion
        }
        else
        {
            #region 校园文化稿件统计
            string start = TextBox_Start.Text.Trim();
            string stop = TextBox_stop.Text.Trim();
            if (stop == "" || start == "")
                Mystring.alert("请选择起止时间");
            else
            {
                string Connect = ConfigurationManager.AppSettings["connStr"];
                SqlConnection con = new SqlConnection(Connect);
                string selectvalue = RadioButtonList1.SelectedValue;
                int total = 0;

                if (selectvalue == "0")//编辑/
                {
                    int count;
                    RegUserBLL usebll = new RegUserBLL();
                    IList<RegUser> aa = usebll.GetUserByPage(1, 1, "[zaizhi]=1", out count);
                    IList<RegUser> list = usebll.GetUserByPage(count, 1, "[zaizhi]=1", out count);
                    int[] number = new int[count];
                    string[] names = new string[count];
                    string text = "";
                    for (int i = 0; i < count; i++)
                    {
                        SqlCommand cmd = new SqlCommand("select count(*) from Campus_Article where [Pass]='True'and([Editor] like '%" + list[i].Name + "%')  and ([Datee]<='" + stop + "' and [Datee]>='" + start + "') ", con);
                        //number[i] = conbll.GetCount("[auditing]='1'and([editor] like '%" + list[i].Name + "%')  and ([datee]<='" + stop + "' and [datee]>='" + start + "') and ([caption]<>'废稿')");
                        con.Open();
                        int num = (int)cmd.ExecuteScalar();
                        con.Close();
                        number[i] = num;
                        names[i] = list[i].Name;
                    }
                    Array.Sort(number, names);
                    for (int j = 0; j < count; j++)
                    {
                        text += "<tr><td><a href=\"NewsTongJi.aspx?webtype=0&Editor=" + Server.UrlEncode(names[count - j - 1].ToString()) + "&Website=" + Server.UrlEncode("校园文化") + " &Start=" + start + "&Stop=" + stop + "\" target=\"_blank\">" + names[count - j - 1] + "</a></td><td>" + number[count - j - 1] + "</td><td>" + (j + 1) + "</td></tr>";
                        total += int.Parse(number.GetValue(j).ToString());
                    }
                    text += "<tr><td>总计</td><td>" + total + "</td><td></td></tr>";
                    text = table_st() + text + table_en();
                    result.InnerHtml = text;
                }
                if (selectvalue == "1")//学院
                {
                    CollegeBLL colbll = new CollegeBLL();
                    IList<College> list = colbll.GetCollegeList();
                    int count = list.Count;
                    int[] paiming = new int[count];
                    string[] xueyuan = new string[count];
                    string text = "";
                    for (int i = 0; i < list.Count; i++)
                    {
                        SqlCommand cmd = new SqlCommand("select count(*) from Campus_Article where [Pass]='True' and([FromTo] like '%" + list[i].Name + "%')  and ([Datee]<='" + stop + "' and [Datee]>='" + start + "') ", con);

                        //paiming[i] = conbll.GetCount("[fro]='" + list[i].Name + "' and [auditing]='1' and ([datee]<='" + stop + "' and [datee]>='" + start + "') and ([caption]<>'废稿')");
                        con.Open();
                        int num = (int)cmd.ExecuteScalar();
                        con.Close();
                        paiming[i] = num;
                        xueyuan[i] = list[i].Name;
                    }
                    Array.Sort(paiming, xueyuan);
                    for (int j = 0; j < count; j++)
                    {
                        text += "<tr><td><a href=\"NewsTongJi.aspx?webtype=0&Xueyuan=" + Server.UrlEncode(xueyuan[count - j - 1].ToString()) + "&Website=" + Server.UrlEncode("校园文化") + " &Start=" + start + "&Stop=" + stop + "\" target=\"_blank\">" + xueyuan[count - j - 1] + "</a></td><td>" + paiming[count - j - 1] + "</td><td>" + (j + 1) + "</td></tr>";
                        total += int.Parse(paiming.GetValue(j).ToString());
                    }
                    text += "<tr><td>总计</td><td>" + total + "</td><td></td></tr>";
                    text = table_st() + text + table_en();
                    result.InnerHtml = text;
                }
                if (selectvalue == "2")//栏目
                {
                    ClassBLL classbll = new ClassBLL();
                    IList<Class> list = classbll.GetClassList(false);
                    int count = list.Count;
                    int[] shu = new int[count];
                    string[] lanmu = new string[count];
                    string text = "";
                    for (int i = 0; i < count; i++)
                    {
                        SqlCommand cmd = new SqlCommand("select count(*) from Campus_Article where Lanmu='" + list[i].Title + "' and  [Pass]='True' and ([Date]<='" + stop + "' and [Date]>='" + start + "') ", con);

                        //shu[i] = conbll.GetCount("caption='" + list[i].Title + "' and [auditing]='1' and ([datee]<='" + stop + "' and [datee]>='" + start + "') and ([caption]<>'废稿')");
                        con.Open();
                        int num = (int)cmd.ExecuteScalar();
                        con.Close();
                        shu[i] = num;
                        lanmu[i] = list[i].Title;
                    }
                    Array.Sort(shu, lanmu);
                    for (int j = 0; j < count; j++)
                    {
                        text += "<tr><td><a href=\"NewsTongJi.aspx?webtype=0&Caption=" + Server.UrlEncode(lanmu[count - j - 1].ToString()) + "&Website=" + Server.UrlEncode("校园文化") + " &Start=" + start + "&Stop=" + stop + "\" target=\"_blank\">" + lanmu[count - j - 1] + "</a></td><td>" + shu[count - j - 1] + "</td><td>" + (j + 1) + "</td></tr>";
                        total += int.Parse(shu.GetValue(j).ToString());
                    }
                    text += "<tr><td>总计</td><td>" + total + "</td><td></td></tr>";
                    text = table_st() + text + table_en();
                    result.InnerHtml = text;
                }
                if (selectvalue == "3")//记者
                {
                    int count;
                    RegUserBLL usebll = new RegUserBLL();
                    IList<RegUser> aa = usebll.GetUserByPage(1, 1, "[zaizhi]=1", out count);
                    IList<RegUser> list = usebll.GetUserByPage(count, 1, "[zaizhi]=1", out count);
                    int[] number = new int[count];
                    string[] names = new string[count];
                    string text = "";
                    for (int i = 0; i < count; i++)
                    {
                        SqlCommand cmd = new SqlCommand("select count(*) from Campus_Article where Author='" + list[i].Name + "' and  [Pass]='True' and ([Datee]<='" + stop + "' and [Datee]>='" + start + "') ", con);

                        //number[i] = conbll.GetCount("[auditing]='1'and([author] like '%" + list[i].Name + "%')  and ([datee]<='" + stop + "' and [datee]>='" + start + "') and ([caption]<>'废稿')");
                        con.Open();
                        int num = (int)cmd.ExecuteScalar();
                        con.Close();
                        number[i] = num;
                        names[i] = list[i].Name;
                    }
                    Array.Sort(number, names);
                    for (int j = 0; j < count; j++)
                    {
                        text += "<tr><td><a href=\"NewsTongJi.aspx?webtype=0&Author=" + Server.UrlEncode(names[count - j - 1].ToString()) + "&Website=" + Server.UrlEncode("校园文化") + " &Start=" + start + "&Stop=" + stop + "\" target=\"_blank\">" + names[count - j - 1] + "</a></td><td>" + number[count - j - 1] + "</td><td>" + (j + 1) + "</td></tr>";
                        total += int.Parse(number.GetValue(j).ToString());
                    }
                    text += "<tr><td>总计</td><td>" + total + "</td><td></td></tr>";
                    text = table_st() + text + table_en();
                    result.InnerHtml = text;
                }
                if (selectvalue == "4")//头条
                {
                    Response.Write("<script>alert('校园文化没有此栏目！');history.go(-1)</script>");

                }
            }

            #endregion
        }
    }
    public string table_st()
    {
        return "<table width=\"300px\" border=\"1\" bordercolor=\"#993300\" cellspacing=\"0\" cellpadding=\"0\"style=\"border-collapse:collapse\"> <tr style=\"color:#FFFFFF\"><td width=\"50%\" height=\"35px\">名称：</td><td>数量</td><td>名次</td></tr>";
    }
    public string table_en()
    {
        return "</table>";
    }
}