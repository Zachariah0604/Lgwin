using System;
using System.Data;

namespace _211
{
	/// <summary>
	/// TableQuery ��ժҪ˵����
	/// </summary>
	public sealed class TableQuery
	{
		
        public static DataTable CommentQuery(int pagesize, int page, string IID,int Type)
        {
            string[] col ={ "id", "Type", "Aid", "Guest","TouXiang","DateeGuest", "ContentGuest", "ContentAdmin", "DateeGuest", "Ip" };
            string[] cod = { "Aid=" + IID + " and " + "Type=" + Type };

            return DBQuery.OpenTable("Campus_Comment", col, cod, "id", false, pagesize, page);
        }

	
	}
}
