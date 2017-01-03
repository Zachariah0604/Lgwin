using System;
using System.Web;
using System.Web.Caching;
using System.Data.OleDb;
namespace _211
{
	/// <summary>
	/// DBConnection 的摘要说明。
	/// </summary>
	public class DBConnection
	{
		public DBConnection()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}

		public static string getConnStr()
		{
			if(HttpContext.Current.Cache["conn"]==null)
			{
                HttpContext.Current.Cache.Insert("conn", "data source=" + HttpContext.Current.Server.MapPath("DB_51aspx/db.asax").ToString() + ";provider=microsoft.jet.oledb.4.0");//5~1-a-s-p-x
			}
			return HttpContext.Current.Cache["conn"].ToString();
		}

		public static OleDbConnection getConn()
		{
			return new OleDbConnection(getConnStr());//51@aspx
		}

		public static OleDbConnection getConn(string ConnStr)
		{
			return new OleDbConnection(ConnStr);
		}
	}
}
