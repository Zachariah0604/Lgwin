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
    /// 实现ICaiFang接口
    /// </summary>
    public class CaiFangDAL : ICaiFang
    {
        #region ICaiFang Members

        /// <summary>
        /// 添加采访
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        public bool Add(CaiFang Model)
        {
            SqlParameter[] param = {
                                     new SqlParameter ("@title",SqlDbType.VarChar,300),
                                     new SqlParameter ("@time",SqlDbType.VarChar,50),
                                     new SqlParameter ("@place",SqlDbType.VarChar,300),
                                     new SqlParameter ("@Organization",SqlDbType.VarChar,300),
                                     new SqlParameter ("@leader",SqlDbType.VarChar,200),
                                     new SqlParameter ("@description",SqlDbType.VarChar,800)
                                   };
            param[0].Value = Model.Title;
            param[1].Value = Model.Time;
            param[2].Value = Model.Place;
            param[3].Value = Model.Organization ;
            param[4].Value = Model.Leader;
            param[5].Value = Model.Description;
            int rowAffected;
            ProcCommander.RunProcedure("CaiFang_Add", param, out rowAffected);
            return (rowAffected > 0);
        }

        /// <summary>
        /// 删除采访
        /// </summary>
        /// <param name="Id">采访编号</param>
        /// <returns>删除采访数量</returns>
        public int Del(params int[] Id)
        {
            SqlParameter[] param ={
                                     new SqlParameter("@Ids",SqlDbType.Int)
                                  };
            int rowAfected;
            int count = 0;
            foreach (int i in Id)
            {
                param[0].Value = i;
                rowAfected = 0;
                ProcCommander.RunProcedure("CaiFang_Del", param, out rowAfected);
                if (rowAfected > 0)
                    count++;
            }
            return count;
        }

        ///// <summary>
        ///// 获取采访数据列表
        ///// </summary>
        ///// <returns>分类采访列表</returns>
        //public IList<CaiFang> GetCaiFangList()
        //{
        //    SqlParameter[] param = { };
        //    SqlDataReader dr = ProcCommander.RunProcedure("CaiFang_GetList", param);
        //    IList<CaiFang> list = new List<CaiFang>();
        //    try
        //    {
        //        while (dr.Read())
        //        {
        //            list.Add(Transform.ToCaiFang(dr));
        //        }
        //        return list;
        //    }
        //    finally
        //    {
        //        if (dr != null && !dr.IsClosed)
        //            dr.Close();
        //    }
        //}
        /// <summary>
        /// 获取采访分页列表
        /// </summary>
        /// <param name="PageSize">分页大小</param>
        /// <param name="PageIndex">索引</param>
        /// <param name="strWhere">SQL条件</param>
        /// <param name="count">输出总条数</param>
        /// <returns></returns>
        public IList<CaiFang> GetCaiFangList(int PageSize, int PageIndex, string strWhere, out int count)
        {
            IList<CaiFang> userList = new List<CaiFang>();

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
            param[0].Value = "CaiFang";
            param[2].Value = "ID";
            param[3].Value = PageSize;
            param[4].Value = PageIndex;
            param[7].Value = strWhere;
            using (SqlDataReader dr = ProcCommander.RunProcedure("GetInfoByPage", param))
            {
                while (dr.Read())
                {
                    userList.Add(Transform.ToCaiFang(dr));
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
            param2[0].Value = "CaiFang";
            param2[2].Value = "ID";
            param2[3].Value = PageSize;
            param2[4].Value = PageIndex;
            param2[5].Value = 1;
            param2[6].Value = 1;
            param2[7].Value = strWhere;
            count = (int)ProcCommander.RunProcedureScalar("GetInfoByPage", param2);
            return userList;

        }
        #endregion
    }
}
