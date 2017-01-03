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
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Threading;
using System.Collections.Generic;
using System.Globalization;
using Lgwin.BLL;
using Lgwin.Model;
using System.Drawing;

public partial class Article_Edite : System.Web.UI.Page
{
    public static SqlConnection sqlcon;
    public static string ConStr = System.Configuration.ConfigurationSettings.AppSettings["connStr"].ToString();
    public static DataSet GetBYID(int _id, string ConStr)
    {
        string strCmd =
            "SELECT *" +
            "FROM [Article] " +
            "WHERE [id]=" + _id;
        return GetDataSet(strCmd, ConStr);

    }
    protected static void Open()
    {
        sqlcon = new SqlConnection(ConStr);
        sqlcon.Open();

    }
    /// <summary>
    /// 公有方法，关闭数据库连接。
    /// </summary>
    public static void Close()
    {
        sqlcon = new SqlConnection(ConStr);
        if (sqlcon != null)
            sqlcon.Close();
    }
    public static DataSet GetDataSet(String SqlString, string strTableName)
    {
        Open();
        SqlDataAdapter adapter = new SqlDataAdapter(SqlString, sqlcon);
        DataSet dataset = new DataSet();
        adapter.Fill(dataset, strTableName);
        Close();
        adapter.Dispose();
        return dataset;
    }
    /// <summary>
    /// 检查权限是否符合要求
    /// </summary>
    /// <param name="yaoqiu">本页要求权限id</param>
    /// <param name="user">登录用户</param>
    /// <returns></returns>
    public static bool chkPower()
    {
        string date = "";
        if (date.IndexOf('/')==0)
        {
            return false;
        }
        else
            return true;

    }
    public void databind()
    {
        string MsgInfo = "MsgInfo";
        int _id = int.Parse(Request.Params["id"]);
        DataSet dsmsg;
        dsmsg = GetBYID(_id, MsgInfo);
        DataRow row = dsmsg.Tables["MsgInfo"].Rows[0];
        Title.Text = row["Title"].ToString();
        SubTitle.Text = row["SubTitle"].ToString();
        DropDownList_lanmu.Text = row["LanMu"].ToString();
        //Date.Text = row["Date"].ToString();
        if (chkPower())
        {
            Date.Text = DateTime.Now.ToString("yyyy-MM-dd", DateTimeFormatInfo.InvariantInfo);
        }
        else
        {
            Date.Text = row["Date"].ToString();
        }

        string url = row["URL"].ToString();
        index.Checked = (bool)row["_Index"];
        recommend.Checked = (bool)row["Recommend"];
        Audited.Checked = (bool)row["Audited"];
        Editor1.Text = row["Content"].ToString();
        //Editor.Text = Session["Name"].ToString();
        if (row["editor"].ToString().Trim() == "")
        {
            Editor.Text = Session["Name"].ToString().Trim();
        }
        else
        {
            Editor.Text = row["editor"].ToString().Trim();

        }
        From.Text = row["From"].ToString();
        Author.Text = row["Author"].ToString();
        Phone.Text = row["Phone"].ToString();
        if (url == "0" || url == "")
        {
            Random ran = new Random();
            DateTime datetime = DateTime.Now;
            URL.Text = datetime.Year.ToString() + datetime.Month + datetime.Day + datetime.Hour.ToString() + datetime.Millisecond.ToString() + ran.Next(1000, 9999).ToString() + ".html";

        }
        else
        {
            URL.Text = url.ToString();
        }
        

    }
    /// <summary>
    /// 权限判断：只有高级以上管理员能改编辑者
    /// </summary>
    /// <param name="dangqian"></param>
    /// <param name="yaoqiu"></param>
    /// <returns></returns>
    public static bool chkAdmin(string dangqian, int yaoqiu)
    {
        int dangint = int.Parse(dangqian.Trim());
        if (dangint > yaoqiu)
        {

            return false;
        }
        else
            return true;

    }
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            Color bg = Color.FromArgb(165,165,165);
            if (chkAdmin(Session["Admin"].ToString(), 1))
            {
                Editor.ReadOnly = false;
            }
            else
            {
                Editor.ReadOnly = true;
                Editor.BackColor = bg;
            }
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            databind();
        }
        Date.Attributes.Add("onFocus", "selectDate(this)");
    }
    protected void Button_update_Click(object sender, EventArgs e)
    {
        //int i = 0;
        int _id = int.Parse(Request.Params["id"]);
        string upcom = "UPDATE [Article] SET [Title] ='" + this.Title.Text + "' ,[SubTitle] ='" + this.SubTitle.Text + "' ,[LanMu] = '" + DropDownList_lanmu.Text + " ' ,[Date] ='" + Date.Text + "' ,[URL] ='" + URL.Text + "' ,[Content] ='" + Editor1.Text + "',[Author] ='" + Author.Text + "',[Phone]='" + Phone.Text + "',[Audited] = '" + Audited.Checked + "',[_Index]='" + index.Checked + "',[Editor]='" + Editor.Text + "',[From]='" + From.Text + "',[Recommend]='" + recommend.Checked + "' WHERE [id]='" + _id + "'";
        Open();
        SqlCommand upsql = new SqlCommand(upcom, sqlcon);
        upsql.ExecuteNonQuery();
        Close();
        //Session["id"] = "_id";
        //Response.Write("<script>location='To_Html_03/To_html_03.aspx'</script>");
        Response.Redirect("To_Html_03/To_html_03.aspx?id=" + _id);
    }
    protected void Button_cancel_Click(object sender, EventArgs e)
    {
        Response.Write("<script>location='ArticleManage.aspx'</script>");
    }
}
