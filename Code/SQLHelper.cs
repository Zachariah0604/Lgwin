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


public class SQLHelper
{
    public string connStr = System.Configuration.ConfigurationManager.AppSettings["connStr"];
    public SqlConnection conn = null;
    public SqlCommand cmd = null;
    public SqlDataAdapter adapter = null;
    public DataSet dataset = null;
	public SQLHelper()
	{
		//
		// TODO: 在此处添加构造函数逻辑
        conn = new SqlConnection(connStr);
        cmd = new SqlCommand();
        cmd.Connection = conn;
	}
    public void openConn()
    {
        if (conn.State ==ConnectionState.Closed)
        {
            conn.Open();
        }
    }
    public void closeConn()
    {
        if (conn.State == ConnectionState.Open)
        {
            conn.Close();
        }
    }
    // 验证节点是否为目录
    public bool checkdir(string strID)
    {
        bool dt;
        string tempCmd = "SELECT isDir FROM Karat_Images WHERE ImgID=" + strID;
        try
        {
            this.openConn();
            cmd.CommandText = tempCmd;
            dt = Boolean.Parse(cmd.ExecuteScalar().ToString());
        }
        catch (Exception ex)
        {
            throw ex;

        }
        finally
        {
            this.closeConn();
        }
        return dt;
    }

    public DataTable getpicinfo()
    {
        DataTable dt;
        string tempCmd = "SELECT * FROM Karat_Images";
        try
        {
            this.openConn();
            cmd.CommandText = tempCmd;
            adapter = new SqlDataAdapter(cmd);
            dataset = new DataSet();
            adapter.Fill(dataset);
            dt = dataset.Tables[0];
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            this.closeConn();
        }
        return dt;
    }
    public bool checkchildnode(string strID)
    {
        bool dt;
        string tempCmd = "SELECT COUNT(*) FROM Karat_Images WHERE ParentID=" + strID;
        try
        {
            this.openConn();
            cmd.CommandText = tempCmd;
            dt = Int32.Parse(cmd.ExecuteScalar().ToString())>0?true:false;
        }
        catch(Exception ex)
        {
         throw ex;
        }
        finally
        {
        this.closeConn();
        }
        return dt;
    }
    public DataTable DisPlayList_Ds(string ina)
    {
        conn = new SqlConnection(connStr);
        string tempCmd = "select ImgID,ImgName,ImgUrl,CreateDate from Karat_Images where ParentID= '"+ina+"'";
        DataTable Dt = new DataTable();
        SqlDataAdapter ShowAdapter = new SqlDataAdapter(tempCmd, conn);
        ShowAdapter.Fill(Dt);
       
        return Dt;
    }
    public DataTable DisPlayList_DsD(string ina)
    {
        conn = new SqlConnection(connStr);
        string tempCmd = "select ImgID,ImgName,ImgUrl,CreateDate,ClickCount from Karat_Images where ImgID= '" + ina + "'";
        DataTable Dt = new DataTable();
        SqlDataAdapter ShowAdapter = new SqlDataAdapter(tempCmd, conn);
        ShowAdapter.Fill(Dt);
        conn.Close();
        return Dt;
    }
    public DataTable DisPlayList_DsDD(string ina)
    {
        conn = new SqlConnection(connStr);
        string tempCmd = "select * from Karat_PhotoComment where imgid= '" + ina + "'";
        DataTable Dt = new DataTable();
        SqlDataAdapter ShowAdapter = new SqlDataAdapter(tempCmd, conn);
        ShowAdapter.Fill(Dt);
        conn.Close();
        return Dt;
    }
    public void addclick(string imgid)
    {
        conn = new SqlConnection(connStr);
        conn.Open();
        string tempCmd = "update Karat_Images set ClickCount=ClickCount+1 where ImgID='" + imgid + "'";
        SqlCommand cmd = new SqlCommand(tempCmd,conn);
        cmd.ExecuteNonQuery();
        conn.Close();
    }
    public DataSet GetMessageData(int id)
    {
        conn = new SqlConnection(connStr);
        conn.Open();
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = new SqlCommand("select * from Karat_message order by m_time desc", conn);
        DataSet ds = new DataSet();

            da.Fill(ds, "Karat_message");
            return ds;

    }
    public DataSet repLMessageData(string iid)
    {
        string strSQL2 = "select * from T_Karat_Message_Reply where LeftWordID='" + iid + "' order by ReplyTime desc";
        SqlDataAdapter dar = new SqlDataAdapter(strSQL2, conn);
        DataSet dsr = new DataSet();
        dar.Fill(dsr, "T_Karat_Message_Reply");
        return dsr;
    }
    //public string ReplyCount(string recount)
    //{
    //    string sql = "select count(KaratReplyID)+1 from T_Karat_Message_Reply where LeftWordID='" + recount + "'";
    //    SqlCommand cmd = new SqlCommand(sql,conn);
    //    cmd.Connection.Open();
    //    string repcount = cmd.ExecuteNonQuery().ToString();
    //    cmd.Connection.Close();
    //    return repcount;
    //}
    //public void GetZan(int iid)
    //{
    //    conn = new SqlConnection(connStr);
    //    conn.Open();
    //    string sql = "update Karat_message set zan = zan + 1 where id = '" + iid + "'";
    //    SqlCommand cmd = new SqlCommand(sql, conn);
    //    cmd.ExecuteNonQuery();
    //    conn.Close();
    //}
    public void PhotoCommentAddInfo(string nic, string pinl, string dtime, string imgid)
    {
        conn = new SqlConnection(connStr);
        string tempCmd = "INSERT INTO Karat_PhotoComment (nicheng,[content],time,imgid)VALUES(@nic,@pinl,@dtime,@imgid)";
        SqlParameter[] paras = new SqlParameter[]
        {
            new SqlParameter("@nic",nic),
                new SqlParameter("@pinl",pinl),
                new SqlParameter("@dtime",dtime),
                new SqlParameter("@imgid",imgid)
        };
        try
        {
            conn.Open();
            SqlCommand AddInfoCmd = new SqlCommand(tempCmd, conn);
            AddInfoCmd.Parameters.AddRange(paras);
            AddInfoCmd.ExecuteNonQuery();
          
          

        }
        catch
        {
            
            conn.Close();
        }
      
    }
    public void deleteNode(string strID)
    {
        string tempCmd = "DELETE Karat_Images WHERE ImgID=" + strID;
        try
        {
            this.openConn();
            cmd.CommandText = tempCmd;
            cmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            this.closeConn();
        }
    }
   //添加节点
    public void addNode(string name,string url,string isDir,string ParentID)
    {
        string tempCmd = "INSERT INTO Karat_Images (ImgName,ImgUrl,isDir,ParentID,CreateDate)VALUES" + "('" + name + "','" + url + "','" + isDir + "'," + ParentID + ",GetDate())";
        try
        {
            this.openConn();
            cmd.CommandText = tempCmd;
            cmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw ex;

        }
        finally
        {
            this.closeConn();
        }
    }
    //public void PatchaddNode(string[] name, string url, string isDir, string ParentID)
    //{
    //    string tempCmd = "INSERT INTO Karat_Images (ImgName,ImgUrl,isDir,ParentID,CreateDate)VALUES" + "('" + name + "','" + url + "','" + isDir + "'," + ParentID + ",GetDate())";
    //    try
    //    {
    //        this.openConn();
    //        cmd.CommandText = tempCmd;
    //        cmd.ExecuteNonQuery();

    //    }
    //    catch (Exception ex)
    //    {
    //        throw ex;

    //    }
    //    finally
    //    {
    //        this.closeConn();
    //    }
    //}
    //更新节点
    public void updateNode(string strID, string name)
    {
        string tempCmd = "UPDATE Karat_Images SET ImgName='" + name + "'WHERE ImgID=" + strID;
        try
        {
            this.openConn();
            cmd.CommandText = tempCmd;
            cmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            this.closeConn();
        }
    }




    }