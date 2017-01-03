using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Count
{
    /// <summary>
    /// DBClass 的摘要说明。
    /// </summary>
    public class DBclass
    {
        protected static string strConn = ConfigurationSettings.AppSettings["connStr"];
        protected static SqlConnection myConn = new SqlConnection(strConn);
        protected static string strSQL;
        public DBclass()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        #region "***** Functions of DataClass *****"

        /// <summary>
        /// executing SQL commands
        /// </summary>//执行insert delete update语句
        /// <param name="strSQL">string</param>
        /// <returns>return int</returns>
        public int ExecuteSql(string strSQL)
        {
            SqlCommand myCmd = new SqlCommand(strSQL, myConn);
            try
            {
                myConn.Open();
                myCmd.ExecuteNonQuery();
                return 1;
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                myCmd.Dispose();
                myConn.Close();
            }
        }
        /// <summary>
        ///executing SQL commands查询返回植是一个植
        /// </summary>
        /// <param name="strSQL">要执行的SQL语句,为字符串类型string</param>
        /// <returns>返回执行情况,整形int</returns>
        public int ExecuteSqlDr(string strSQL)
        {
            SqlCommand myCmd = new SqlCommand(strSQL, myConn);

            try
            {
                myConn.Open();
                SqlDataReader myDr = myCmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (myDr.Read())
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
                if(myDr != null && !myDr.IsClosed)
                    myDr.Close();

            }
            catch (System.Data.SqlClient.SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                myCmd.Dispose();
                myConn.Close();
            }
        }
        public string str(string str)
        {
            string result = "'" + str.Replace("'", "\"") + "'";
            return result;

        }
        public string sear(string str)
        {
            string result = str.Replace("'", "\"");
            return result;
        }

        /// <summary>
        /// get dataset
        /// </summary>执行select语句返回dataset
        /// <param name="strSQL">(string)</param>
        /// <returns>(DataSet)</returns>
        public DataSet ExecuteSqlDs(string strSQL, string tablename)
        {
            try
            {
                myConn.Open();
                SqlDataAdapter myDa = new SqlDataAdapter(strSQL, myConn);
                DataSet ds = new DataSet();
                myDa.Fill(ds, tablename);
                return ds;
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                myConn.Close();
            }
        }
        //定义分页
        public DataSet ExecuteSqlDsReapter(string strSQL, int repeatestr1, int repeatestr2, string tablename)
        {
            SqlCommand myCmd = new SqlCommand(strSQL, myConn);
            try
            {
                myConn.Open();
                SqlDataAdapter myDa = new SqlDataAdapter(myCmd);
                DataSet dsReapter = new DataSet();
                myDa.Fill(dsReapter, repeatestr1, repeatestr2, tablename);
                return dsReapter;
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                myConn.Close();
            }
        }

        /// <summary>
        /// datareader
        /// </summary>
        /// <param name="strSQL">string</param>
        /// <returns>SqlDataReader</returns>
        public SqlDataReader ExecuteSqlDataReader(string strSQL)
        {
            if (myConn.State != ConnectionState.Open)
                myConn.Open();
            try
            {
                SqlCommand myCmd = new SqlCommand(strSQL, myConn);
                SqlDataReader myDr = myCmd.ExecuteReader(CommandBehavior.CloseConnection);
                return myDr;
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                throw new Exception(e.Message);
                //myConn.Close();
            }
            finally
            {
            }

        }

        /// <summary>
        /// get single value
        /// </summary>
        /// <param name="strSQL">(string)</param>
        /// <returns>(int)</returns>
        public int ExecuteCount(string strSQL)
        {
            SqlCommand myCmd = new SqlCommand(strSQL, myConn);
            try
            {
                myConn.Open();
                object r = myCmd.ExecuteScalar();
                if (Object.Equals(r, null))
                {
                    throw new Exception("value unavailable！");
                }
                else
                {
                    return (int)r;
                }
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                myCmd.Dispose();
                myConn.Close();
            }
        }
        /// <summary>
        /// get object
        /// </summary>
        /// <param name="strSQL">(string)</param>
        /// <returns>(object)</returns>
        public object ExecuteSql4ValueEx(string strSQL)
        {
            SqlCommand myCmd = new SqlCommand(strSQL, myConn);
            try
            {
                myConn.Open();
                object r = myCmd.ExecuteScalar();
                if (Object.Equals(r, null))
                {
                    throw new Exception("object unavailable!");
                }
                else
                {
                    return r;
                }
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                myCmd.Dispose();
                myConn.Close();
            }
        }
        #endregion
    }
}
