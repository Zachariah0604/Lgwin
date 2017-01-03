using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

/// <summary>
/// xlxy 的摘要说明
/// </summary>
public class xlxy
{
    private static readonly string olestr = System.Configuration.ConfigurationManager.AppSettings["connStr"].ToString();
    private static SqlConnection conn = new SqlConnection(olestr);
    public xlxy()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
    public static SqlDataReader dr(string sql)
    {
        SqlCommand cmd = new SqlCommand(sql,conn);
        SqlDataReader drr;
        try
        {
            if (conn.State.ToString().ToLower() == "open")
                conn.Close();
            conn.Open();
            drr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        catch (Exception ex)
        {
            throw ex;
           
        }

        finally {  }
        

        return drr;
    }
    public static int sqlNoQ(string sql)
    {
        int ret = 0;
        SqlCommand cmd = new SqlCommand(sql, conn);
        try
        {
            if (conn.State.ToString().ToLower() == "open")
                conn.Close();
            conn.Open();
            ret = cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw ex;

        }
        finally
        {
            cmd.Dispose();
            conn.Close();
        }
        return ret;
    }
    public static int sqlAc(string sql)
    {
        int resu = 0;
        SqlCommand cmd = new SqlCommand(sql, conn);
        try
        {
            if (conn.State.ToString().ToLower() == "open")
                conn.Close();
            conn.Open();
            resu = Convert.ToInt32(cmd.ExecuteScalar());
        }
        catch (Exception ex)
        {
            throw ex;

        }
        finally
        {
            cmd.Dispose();
            conn.Close();
        }
        return resu;
    }

    public static string body(string fenlei,int page,int no)
    {
        string resu = "";
        if (fenlei == "")
            fenlei += "01";
        if (page < 1)
            page = 1;
        SqlDataReader dr = xlxy.dr("select top "+page*no+" [id],[path],[path_small],[namee],[fenlei] from [photo] where [fenlei]='" + fenlei + "' order by [id] desc");
        string div = "\n<div class=\"box1\"><a href=\"%%pic%%\" target=\"_blank\"><img src=\"%%spic%%\" width=\"186\" height=\"160\"  class=\"alpha\" /></a><div class=\"navLink\"><a href=\"%%pic%%\" target=\"_blank\">%%name%%</a></div></div>";
        int i = 1, start = 0;
        start = page - 1;
        start = start * no;
        while (dr.Read())
        {
            if(i>start)
                resu += div.Replace("%%pic%%", "showpic.aspx?id=" + dr["id"].ToString()).Replace("%%spic%%", "admin/photo/" + dr["fenlei"].ToString() + "/" + dr["path_small"].ToString()).Replace("%%name%%", dr["namee"].ToString());
            i++;
        }
        return resu;
    }
    public static string fenleiname(string biaoshi)
    {
        string rest="";
        SqlDataReader drr = dr("select * from [fenlei] where [biaoshi]='"+biaoshi+"'");
        if(drr.Read())
            rest = drr["namee"].ToString();
        drr.Dispose();
        return rest;
    }
}
