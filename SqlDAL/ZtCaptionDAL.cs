using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Lgwin.IDAL;
using Lgwin.Model;
using Lgwin.DBUtility;

namespace Lgwin.SqlDAL
{
    public class ZtCaptionDAL : IZtCaption
    {
        #region IZtCaption Members

        public bool Add(ZtCaption Model)
        {
            SqlParameter[] param = {
                                    new SqlParameter("@ztcaption",SqlDbType.VarChar,50),
                                    new SqlParameter("@ztid",SqlDbType.VarChar,50)
                                   };
            param[0].Value = Model.ZtCaptionName;
            param[1].Value = Model.Ztid;

            int rowAffect;
            ProcCommander.RunProcedure("ZtCaption_Add", param, out rowAffect);
            return (rowAffect > 0);
        }

        public bool Update(ZtCaption Model)
        {
            SqlParameter[] param = {
                                    new SqlParameter("@ztcaption",SqlDbType.VarChar,50),
                                    new SqlParameter("@ztid",SqlDbType.VarChar,50),
                                    new SqlParameter("@id",SqlDbType.Int)                                                           };
            param[0].Value = Model.ZtCaptionName;
            param[1].Value = Model.Ztid;
            param[2].Value = Model.Id;

            int rowAffect;
            ProcCommander.RunProcedure("ZtCaption_Update", param, out rowAffect);
            return (rowAffect > 0);
        }

        public int Del(string Ids)
        {
            SqlParameter[] param = {
                                    new SqlParameter("@ids",SqlDbType.VarChar,2000)
                                   };
            param[0].Value = Ids;

            int rowAffect;
            ProcCommander.RunProcedure("ZtCaption_Del", param, out rowAffect);
            return rowAffect;
        }
        public ZtCaption GetZtCaption(int Id)
        {
            SqlParameter[] param = {
                                        new SqlParameter("@Id",SqlDbType.Int)
                                   };
            param[0].Value = Id;
            using (SqlDataReader dr = ProcCommander.RunProcedure("ZtCaption_GetInfo", param))
            {
                try
                {
                    if (dr.Read())
                        return (Transform.ToZtCaption(dr));
                    else
                        return null;
                }
                finally
                {
                    if (dr != null && !dr.IsClosed)
                        dr.Close();//zgy
                }
            } 
        }
        public ZtCaption GetZtCaption(string capname)
        {
            SqlParameter[] param = {
                                        new SqlParameter("@capname",SqlDbType.VarChar,50)
                                   };
            param[0].Value = capname;
            using (SqlDataReader dr = ProcCommander.RunProcedure("ZtCaption_GetId", param))
            {
                try
                {
                    if (dr.Read())
                        return (Transform.ToZtCaption(dr));
                    else
                        return null;        
                }
                finally
                {
                    if (dr != null && !dr.IsClosed)
                        dr.Close();//zgy
                }
            }
         }
        /// <summary>
        /// 专题栏目获取
        /// </summary>
        /// <param name="ztid">专题ID,参数0表示获取所有列表</param>
        /// <returns></returns>
        public IList<ZtCaption> GetZtCaptionList(string ztid)
        {
            IList<ZtCaption> Model = new List<ZtCaption>();
            SqlParameter[] param = {
                                    new SqlParameter("@ztid",SqlDbType.VarChar,50)
                                   };
            param[0].Value = ztid;
            using (SqlDataReader dr = ProcCommander.RunProcedure("ZtCaption_GetList", param))
            {
                ZtCaption ztinfo = new ZtCaption();
                while (dr.Read())
                {
                    ztinfo = Transform.ToZtCaption(dr);
                    Model.Add(ztinfo);
                }
                dr.Close();//zgy
            }
            return Model;
        }

        #endregion
    }
}
