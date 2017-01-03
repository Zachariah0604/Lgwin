using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lgwin.Model;
using Lgwin.DBUtility;
using System.Data.SqlClient;
using System.Data;

namespace Lgwin.SqlDAL
{
  public   class xuyuanDAL
    {
      public IList<T_love> GetloveList(int PageSize, int PageIndex, string strWhere, out int count)
      {
          IList<T_love> userList = new List<T_love>();

          SqlParameter[] param = {
                                         new SqlParameter("@tbName",SqlDbType.VarChar,50),
                                         new SqlParameter("@strGetItem",SqlDbType.VarChar,1000),
                                         new SqlParameter("@fldName",SqlDbType.VarChar,50),
                                         new SqlParameter("@PageSize",SqlDbType.Int),
                                         new SqlParameter("@PageIndex",SqlDbType.Int),
                                         new SqlParameter("@doCount",SqlDbType.Bit),
                                         new SqlParameter("@OrderType",SqlDbType.Bit),
                                         new SqlParameter("@strWhere",SqlDbType.VarChar,1500)                                       
                                    };
          param[0].Value = "T_love";
          param[2].Value = "id";
          param[3].Value = PageSize;
          param[4].Value = PageIndex;
          param[6].Value = 1;
          param[7].Value = strWhere;
          using (SqlDataReader dr = ProcCommander.RunProcedure("GetInfoByPage", param))
          {
              while (dr.Read())
              {
                  userList.Add(Transform.bind(dr));
              }
              dr.Close();//zgy
          }

          SqlParameter[] param2 = {
                                         new SqlParameter("@tbName",SqlDbType.VarChar,50),
                                         new SqlParameter("@strGetItem",SqlDbType.VarChar,1000),
                                         new SqlParameter("@fldName",SqlDbType.VarChar,50),
                                         new SqlParameter("@PageSize",SqlDbType.Int),
                                         new SqlParameter("@PageIndex",SqlDbType.Int),
                                         new SqlParameter("@doCount",SqlDbType.Bit),
                                         new SqlParameter("@OrderType",SqlDbType.Bit),
                                         new SqlParameter("@strWhere",SqlDbType.VarChar,1500)                                       
                                    };
          param2[0].Value = "T_love";
          param2[2].Value = "id";
          param2[3].Value = PageSize;
          param2[4].Value = PageIndex;
          param2[5].Value = 1;
          param2[6].Value = 1;
          param2[7].Value = strWhere;
          count = (int)ProcCommander.RunProcedureScalar("GetInfoByPage", param2);
          return userList;

      }
      public int Del(int Ids)
      {
          SqlParameter[] param = {
                                        new SqlParameter("@ids",SqlDbType.VarChar,2000)
                                   };
          param[0].Value = Ids;
          int rowAffected;
          ProcCommander.RunProcedure("LOVE_Del", param, out rowAffected);
          return rowAffected;
      }
    }
}
