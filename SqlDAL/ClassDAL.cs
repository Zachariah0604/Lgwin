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
    public class ClassDAL:IClass
    {
        #region IClass Members

        /// <summary>
        /// 添加分类
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        public bool Add(Class Model)
        {
            SqlParameter[] param = {
                                     new SqlParameter ("@title",SqlDbType.VarChar,50),
                                     new SqlParameter ("@tid",SqlDbType.VarChar,50),
                                     new SqlParameter ("@power",SqlDbType.VarChar,50),
                                     new SqlParameter ("@paixu",SqlDbType.VarChar,50),
                                     new SqlParameter ("@show",SqlDbType.Bit)
                                   };
            param[0].Value = Model.Title;
            param[1].Value = Model.Tid;
            param[2].Value = Model.Power;
            param[3].Value = Model.PaiXu;
            param[4].Value = Convert.ToByte(Model.Show);
            int rowAffected;
            ProcCommander.RunProcedure("Class_Add", param,out rowAffected);
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
                ProcCommander.RunProcedure("Class_Del", param, out rowAfected);
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
        public bool Update(Class Model)
        {
            SqlParameter[] param = {
                                       new SqlParameter ("@Id",SqlDbType.Int),
                                       new SqlParameter ("@Tid",SqlDbType.VarChar,50),
                                       new SqlParameter ("@Title",SqlDbType.VarChar,50),
                                       new SqlParameter ("@Power",SqlDbType.VarChar,50),
                                        new SqlParameter ("@paixu",SqlDbType.VarChar,50),
                                       new SqlParameter("@Show",SqlDbType.Bit)
                                   };
            param[0].Value = Model.Id;
            param[1].Value = Model.Tid;
            param[2].Value = Model.Title;
            param[3].Value = Model.Power;
            param[4].Value = Model.PaiXu;
            param[5].Value = Convert.ToByte(Model.Show);

            int rowAffected;
            ProcCommander.RunProcedure("Class_Update", param, out rowAffected);
            return (rowAffected > 0);
        }

        /// <summary>
        /// 获得指定Id分类对象
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Class GetClass(int Id)
        {
            SqlParameter[] param ={
                                      new SqlParameter("@Id",SqlDbType.Int)
                                  };
            param[0].Value = Id;
            SqlDataReader dr = ProcCommander.RunProcedure("Class_GetModel", param);
            try
            {
                if (dr.Read())
                    return Transform.ToClass(dr);
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
        /// 获取分类数据列表
        /// </summary>
        /// <returns>分类数据列表</returns>
        public IList<Class> GetClassList()
        {
            SqlParameter[] param = { };
            SqlDataReader dr = ProcCommander.RunProcedure("Class_GetList", param);
            IList<Class> list = new List<Class>();
            try
            {
                while (dr.Read())
                {
                    list.Add(Transform.ToClass(dr));
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
