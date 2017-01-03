using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lgwin.Model;
using Lgwin.SqlDAL;

namespace Lgwin.BLL
{
    public  class bless
    {
       public IList<T_love> GetloveList(int PageSize, int PageIndex, string strWhere, out int count)
       {
           IList<T_love> userList = new xuyuanDAL().GetloveList(PageSize, PageIndex, strWhere, out count);
           return userList;
       }
       public int Del(int Ids)
       {
           return new xuyuanDAL().Del(Ids);
       }
    }
}
