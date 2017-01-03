using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Lgwin.IDAL;
using Lgwin.Model;
using Lgwin.DBUtility;

namespace Lgwin.SqlDAL
{
    public class CollegeDAL : ICollege
    {
        #region ICollege Members

        public bool Add(College Model)
        {
            SqlParameter[] param = { 
                                        new SqlParameter("@name",SqlDbType.VarChar,50),
                                        new SqlParameter("@type",SqlDbType.Bit),
                                        new SqlParameter("@xu",SqlDbType.Int)
                                   };
            param[0].Value = Model.Name;
            param[1].Value = Model.Type;
            param[2].Value = Model.Xu;
            int rowAffected;
            ProcCommander.RunProcedure("College_Add", param, out rowAffected);
            return (rowAffected > 0);
        }

        public int Del(string Ids)
        {
            SqlParameter[] param = { 
                                        new SqlParameter("@ids",SqlDbType.VarChar,2000)
                                   };
            param[0].Value = Ids;
            int rowAffected;
            ProcCommander.RunProcedure("College_Del", param, out rowAffected);
            return rowAffected;
        }

        public bool Update(College Model)
        {
            SqlParameter[] param = { 
                                        new SqlParameter("@name",SqlDbType.VarChar,50),
                                        new SqlParameter("@type",SqlDbType.Bit),
                                        new SqlParameter("@xu",SqlDbType.Int),
                                        new SqlParameter("@id",SqlDbType.Int)
                                   };
            param[0].Value = Model.Name;
            param[1].Value = Model.Type;
            param[2].Value = Model.Xu;
            param[3].Value = Model.Id;
            int rowAffected;
            ProcCommander.RunProcedure("College_Update", param, out rowAffected);
            return (rowAffected > 0);
        }

        public IList<College> GetList()
        {
            SqlParameter[] param = { };
            IList<College> CollegeList = new List<College>();
            using (SqlDataReader dr = ProcCommander.RunProcedure("College_GetList", param))
            {
                while (dr.Read())
                {
                    CollegeList.Add(Transform.ToCollege(dr));
                }
                dr.Close();//zgy
            }
            return CollegeList;
        }

        #endregion
    }
}