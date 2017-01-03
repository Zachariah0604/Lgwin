using System;
using System.IO;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
//Դ�����ؼ����۵�ַ��http://www.51aspx.com/CV/XuYuanQiang
namespace pizi
{
	/// <summary>
	/// Html ��ժҪ˵����
	/// </summary>
	public class Html
	{
		int pageSize;
		
		int currentPage = 0;
		int tempNewsCount = 0;
		int currentNewsCount = 0; //�ۼƵ�����
		int pageCount;
		string newsList = null;
		string htmPath = null;
		SqlDataReader dr;

		public int NewsPageSize
		{
			get{return pageSize;}
			set{pageSize = value;}
		}

		public int CurrentPage
		{
			get{return currentPage;}
			set{currentPage = value;}
		}

		#region ����ģ���ļ�
		public StringBuilder ReadTemplate(string filePath)
		{
			//StreamReader sr = new StreamReader(filePath);
			StringBuilder sb = new StringBuilder();
			Encoding ecode = Encoding.GetEncoding("GB2312");
			using(StreamReader sr = new StreamReader(filePath,ecode))
			{
				string line;
				while((line = sr.ReadLine())!=null)
					sb.Append(line);
				sr.Close();
			}

			return sb;
				
		}
		#endregion


		#region �õ��ܵ�ҳ��
		public int GetPageCount()
		{
			//�д����ƣ�
			pageCount = 8;
			return pageCount;
		}
		#endregion

		#region �õ��ܵ���������
		public int GetNewsCount()
		{
			int newsCount = 0;
			string strCon = ConfigurationSettings.AppSettings["DSN"];
			SqlConnection conn = new SqlConnection(strCon);
			SqlCommand myCom = new SqlCommand("select count(*) from Products",conn);
			
			conn.Open();
			SqlDataReader dr = myCom.ExecuteReader();
			
			if(dr.Read())
			{
				newsCount = Convert.ToInt32(dr[0].ToString());
			}
			dr.Close();
			return newsCount;
			
		}
		#endregion


		#region ��ҳ

		public void MakeHtm()
		{
			string strCon = ConfigurationSettings.AppSettings["DSN"];
			SqlConnection conn = new SqlConnection(strCon);
			SqlCommand myCom = new SqlCommand("select ProductID,ProductName from Products order by ProductID asc",conn);
			Encoding ecode = Encoding.GetEncoding("GB2312");
			
			conn.Open();
			dr = myCom.ExecuteReader(CommandBehavior.CloseConnection);
			int myNewsCount = GetNewsCount();
			while(dr.Read())
			{
				newsList += dr["ProductID"] + ". " + myNewsCount + "<a href=view.aspx?id=" + dr["ProductID"] + ">" + dr["ProductName"] + "</a><br />";
				tempNewsCount++;
				currentNewsCount++;
				if ((tempNewsCount == pageSize) || (pageCount == 1) || (myNewsCount == currentNewsCount))
				{
					if(currentPage == 0)
						htmPath = @"c:\htm\list.htm";
					else
						htmPath = @"c:\htm\list_" + currentPage + ".htm";
					currentPage++;

					StringBuilder sbNewsList = new StringBuilder(newsList);
					//Html.WriteHtml(sbNewsList,htmPath);
					using(StreamWriter sw = new StreamWriter(htmPath,false,ecode))
					{
						sw.Write(sbNewsList);
						sw.Flush();
						sw.Close();
					}
					tempNewsCount = 0;
					newsList = null;
				}

			}
			dr.Close();
		}

		#endregion

	}
}
