using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Lgwin.IDAL;
using Lgwin.Model;
using Lgwin.DBUtility;

namespace Lgwin.SqlDAL
{
    /// <summary>
    /// 实现IClass接口
    /// </summary>
    public class PowerClassDAL:IPowerClass
    {
        #region IPowerClass Members

        /// <summary>
        /// 添加分类
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        public bool Add(PowerClass Model)
        {
            SqlParameter[] param = {
                                     new SqlParameter ("@power",SqlDbType.VarChar,50),
                                     new SqlParameter ("@class",SqlDbType.VarChar,30)
                                   };
            param[0].Value = Model.Power;
            param[1].Value = Model.Class;
            int rowAffected;
            ProcCommander.RunProcedure("PowerClass_Add", param, out rowAffected);
            return (rowAffected > 0);
        }

        /// <summary>
        /// 删除分类
        /// </summary>
        /// <param name="Id">分类编号</param>
        /// <returns>删除分类数量</returns>
        public int Del(params int[] Id)
        {
            SqlParameter[] param ={
                                     new SqlParameter("@id",SqlDbType.Int)
                                  };
            int rowAfected;
            int count = 0;
            foreach (int i in Id)
            {
                param[0].Value = i;
                rowAfected = 0;
                ProcCommander.RunProcedure("PowerClass_Del", param, out rowAfected);
                if (rowAfected > 0)
                    count++;
            }
            return count;
        }

        /// <summary>
        /// 更新类别
        /// </summary>
        /// <param name="Model">类别对象</param>
        /// <returns>Boolean</returns>
        public bool Update(PowerClass Model)
        {
            SqlParameter[] param = {
                                       new SqlParameter ("@Id",SqlDbType.Int),
                                       new SqlParameter ("@Power",SqlDbType.VarChar,50),
                                       new SqlParameter ("@class",SqlDbType.VarChar,30),
                                   };
            param[0].Value = Model.Id;
            param[1].Value = Model.Power;
            param[2].Value = Model.Class;

            int rowAffected;
            ProcCommander.RunProcedure("PowerClass_Update", param, out rowAffected);
            return (rowAffected > 0);
        }

        /// <summary>
        /// 获得指定权限对象
        /// </summary>
        /// <param name="Power"></param>
        /// <returns></returns>
        public PowerClass GetPowerClass(string Power)
        {
            SqlParameter[] param ={
                                      new SqlParameter("@power",SqlDbType.VarChar,50)
                                  };
            param[0].Value = Power;
            SqlDataReader dr = ProcCommander.RunProcedure("PowerClass_GetModel", param);
            try
            {
                if (dr.Read())
                    return Transform.ToPowerClass(dr);
                else
                    return null;
            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
            }
        }
        /// <summary>
        ///获取指定id对象
        /// </summary>
        /// <param name="Power"></param>
        /// <returns></returns>
        public PowerClass GetPowerClassById(int Id)
        {
            SqlParameter[] param ={
                                      new SqlParameter("@Id",SqlDbType.Int)
                                  };
            param[0].Value = Id;
            SqlDataReader dr = ProcCommander.RunProcedure("PowerClass_GetModelbyId", param);
            try
            {
                if (dr.Read())
                    return Transform.ToPowerClass(dr);
                else
                    return null;
            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
            }
        }

        /// <summary>
        /// 获取权限类别数据列表
        /// </summary>
        /// <returns>权限类别数据列表</returns>
        public IList<PowerClass> GetPowerClassList(string Class)
        {
            SqlParameter[] param ={
                                      new SqlParameter("@class",SqlDbType.VarChar,30)
                                  };
            param[0].Value = Class;
            SqlDataReader dr = ProcCommander.RunProcedure("PowerClass_GetList", param);
            IList<PowerClass> list = new List<PowerClass>();
            try
            {
                while (dr.Read())
                {
                    list.Add(Transform.ToPowerClass(dr));
                }
                return list;
            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
            }
        }

        #endregion
    }
}
