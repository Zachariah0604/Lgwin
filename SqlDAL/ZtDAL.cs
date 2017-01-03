using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Lgwin.IDAL;
using Lgwin.Model;
using Lgwin.DBUtility;

namespace Lgwin.SqlDAL
{
    public class ZtDAL : IZt
    {
        #region IZt Members

        public bool Add(Zt Model)
        {
            SqlParameter[] param = {
                                    new SqlParameter("@ztname",SqlDbType.VarChar,50),
                                    new SqlParameter("@px",SqlDbType.VarChar,50),
                                    new SqlParameter("@show",SqlDbType.Bit),
                                    new SqlParameter("@ztjch",SqlDbType.VarChar,50)

                                   };
            param[0].Value = Model.Ztname;
            param[1].Value = Model.Px;
            param[2].Value = Convert.ToByte(Model.Show);
            param[3].Value = Model.ZtJiancheng;

            int rowAffect;
            ProcCommander.RunProcedure("Zt_Add", param, out rowAffect);
            return (rowAffect > 0);
        }

        /// <summary>
        /// 添加领导报道集文章
        /// </summary>
        /// <param name="leadid"></param>
        /// <param name="artid"></param>
        public void leadAdd(string leadid, string artid)
        {
            SqlParameter[] par ={
                                    new SqlParameter("@leadid",SqlDbType.Int),
                                    new SqlParameter("@artid",SqlDbType.Int)
                               };
            par[0].Value = Int32.Parse(leadid);
            par[1].Value = Int32.Parse(artid);
            int row;
            ProcCommander.RunProcedure("leadadd", par, out row);
        }
        /// <summary>
        /// 删除领导报道集文章
        /// </summary>
        /// <param name="ldid"></param>
        /// <param name="artid"></param>
        public void Delldart(string ldid, string artid)
        {
            SqlParameter[] par = { 
                                 new SqlParameter("@ldid",SqlDbType.Int),
                                 new SqlParameter("artid",SqlDbType.Int)
                                 };
            par[0].Value = Int32.Parse(ldid);
            par[1].Value = Int32.Parse(artid);
            ProcCommander.RunProcedure("delldart", par);
        }

        public bool Update(Zt Model)
        {
            SqlParameter[] param = {
                                    new SqlParameter("@ztname",SqlDbType.VarChar,50),
                                    new SqlParameter("@px",SqlDbType.VarChar,50),
                                    new SqlParameter("@show",SqlDbType.Bit),
                                    new SqlParameter("@id",SqlDbType.Int),
                                    new SqlParameter("@ztjch",SqlDbType.VarChar,50)
                                   };
            param[0].Value = Model.Ztname;
            param[1].Value = Model.Px;
            param[2].Value = Convert.ToByte(Model.Show);
            param[3].Value = Model.Id;
            param[4].Value = Model.ZtJiancheng;

            int rowAffect;
            ProcCommander.RunProcedure("Zt_Update", param, out rowAffect);
            return (rowAffect > 0);
        }

        public int Del(string Ids)
        {
            SqlParameter[] param = {
                                    new SqlParameter("@ids",SqlDbType.VarChar,2000)
                                   };
            param[0].Value = Ids;

            int rowAffect;
            ProcCommander.RunProcedure("Zt_Del", param, out rowAffect);
            return rowAffect;
        }
        public Zt GetZtById(int Id)
        {
             SqlParameter[] param = {
                                        new SqlParameter("@Id",SqlDbType.Int)
                                   };
             param[0].Value = Id;
             using (SqlDataReader dr = ProcCommander.RunProcedure("Zt_GetInfo", param))
             {
                 try
                 {
                     if (dr.Read())
                         return (Transform.ToZt(dr));
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

        public IList<Zt> GetZtList(bool ShowAll)
        {
            IList<Zt> ztlist = new List<Zt>();
            SqlParameter[] param = {
                                    new SqlParameter("@show",SqlDbType.Bit)
                                   };
            param[0].Value = Convert.ToByte(ShowAll);
            using (SqlDataReader dr = ProcCommander.RunProcedure("Zt_Show", param))
            {
                Zt ztinfo = new Zt();
                while (dr.Read())
                {
                    ztinfo = Transform.ToZt(dr);
                    ztlist.Add(ztinfo);
                }
                dr.Close();//zgy
            }
            return ztlist;
        }
        #endregion
    }
}
