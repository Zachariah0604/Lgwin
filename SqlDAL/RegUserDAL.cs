using System;
using System.Collections.Generic;
using Lgwin.DBUtility;
using Lgwin.Model;
using Lgwin.IDAL;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace Lgwin.SqlDAL
{
    public class RegUserDAL:IRegUser
    {

        #region IRegUser Members

        /// <summary>
        /// 判断用户是否存在
        /// </summary>
        /// <param name="UserNames">用户名</param>
        /// <returns></returns>
        public bool Exists(string UserNames)
        {
            SqlParameter[] param = { 
                                       new SqlParameter("@users", SqlDbType.VarChar, 50) 
                                   };
            param[0].Value = UserNames;
            int rowAffected;
            int result = ProcCommander.RunProcedure("User_Exists", param, out rowAffected);
            return (result == 1);
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="Model">用户对象</param>
        /// <returns></returns>
        public bool Add(RegUser Model)
        {
            SqlParameter[] param = {
                                        new SqlParameter("@users",SqlDbType.VarChar,50),
                                        new SqlParameter("@pwd",SqlDbType.VarChar,50),
                                        new SqlParameter("@power",SqlDbType.VarChar,200),
                                        new SqlParameter("@admin",SqlDbType.VarChar,50),
                                        new SqlParameter("@namee",SqlDbType.VarChar,50),
                                        new SqlParameter("@img",SqlDbType.VarChar,50),
                                        new SqlParameter("@pass",SqlDbType.Bit),
                                        new SqlParameter("@mail",SqlDbType.VarChar,50),
                                        new SqlParameter("@QQ",SqlDbType.VarChar,50),
                                        new SqlParameter("@tel",SqlDbType.VarChar,50),
                                        new SqlParameter("@xuehao",SqlDbType.VarChar,50),  
                                        new SqlParameter("@zaizhi",SqlDbType.Bit),
                                        new SqlParameter("@zhiwu",SqlDbType.VarChar,50),
                                        new SqlParameter("@year",SqlDbType.VarChar,4),
                                        //new SqlParameter("@paixu",SqlDbType.VarChar,100),
                                        new SqlParameter("@jieshao",SqlDbType.VarChar,2000),
                                        new SqlParameter("@intime",SqlDbType.DateTime),
                                        new SqlParameter("@outtime",SqlDbType.DateTime),
                                        new SqlParameter("@zybj",SqlDbType.VarChar,100),
                                        new SqlParameter("@jiguan",SqlDbType.VarChar,100),
                                        new SqlParameter("@birthday",SqlDbType.DateTime),
                                         new SqlParameter("@ip",SqlDbType.VarChar,400),
                                        new SqlParameter("@flag",SqlDbType.Int)
                                       
                                   };
            param[0].Value = Model.UserName;
            param[1].Value = Model.PassWord;
            param[2].Value = Model.Power;
            param[3].Value = 2;
            param[4].Value = Model.Name;
            param[5].Value = Model.Img;
            param[6].Value = Model.Pass;
            param[7].Value = Model.Email;
            param[8].Value = Model.QQ;
            param[9].Value = Model.Tel;
            param[10].Value = Model.Xuehao;
            param[11].Value = Model.Zaizhi;
            param[12].Value = Model.Zhiwu;
            param[13].Value = Model.Nianji;
            //param[14].Value = Model.Paixu;
            param[14].Value = Model.Jieshao;
            param[15].Value = Model.Intime;
            param[16].Value = Model.Outtime;
            param[17].Value = Model.Zybj;
            param[18].Value = Model.Jiguan;
            param[19].Value = Model.Birthday;
            param[20].Value = Model.Ip;
            param[21].Direction = ParameterDirection.Output;
            int rowAffected;
            ProcCommander.RunProcedure("User_Add", param, out rowAffected);
            return (Convert.ToInt32(param[21].Value) == 1);
        }

        /// <summary>
        /// 通过用户名获取用户
        /// </summary>
        /// <param name="UserName">用户名</param>
        /// <returns>用户对象</returns>
        public RegUser GetUser(string UserName)
        {
            SqlParameter[] param = {
                                       new SqlParameter("@UserName",SqlDbType.VarChar,50)
                                    };
            param[0].Value = UserName;
            SqlDataReader dr = ProcCommander.RunProcedure("User_GetInfo", param);
            try
            {
                if (dr.Read())
                    return Transform.ToRegUser(dr);
                else
                    return null;
            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
            }
        }
        public int GetUserCount(string strWhere,string orderby)
        {
            int count = 0;
            SqlParameter[] param = {
                                         new SqlParameter("@tbName",SqlDbType.VarChar,50),
                                         new SqlParameter("@strGetItem",SqlDbType.VarChar,1000),
                                         new SqlParameter("@doCount",SqlDbType.Bit),
                                         new SqlParameter("@strWhere",SqlDbType.VarChar,1500),
                                         new SqlParameter("@OrderBy",SqlDbType.VarChar,1500)                                           };
            param[0].Value = "password";
            param[2].Value = 1;
            param[3].Value = strWhere;
            param[4].Value = orderby;
            count = (int)ProcCommander.RunProcedureScalar("GetInfoByWhere", param);
            return count;
        }
        public IList<RegUser> GetUserList(string strWhere,string orderby)
        {
            IList<RegUser> userList = new List<RegUser>();
            SqlParameter[] param = {
                                         new SqlParameter("@tbName",SqlDbType.VarChar,50),
                                         new SqlParameter("@strGetItem",SqlDbType.VarChar,1000),
                                         new SqlParameter("@doCount",SqlDbType.Bit),
                                         new SqlParameter("@strWhere",SqlDbType.VarChar,1500),
                                         new SqlParameter("@OrderBy",SqlDbType.VarChar,1500)  
                                    };
            param[0].Value = "password";
            param[3].Value = strWhere;
            param[4].Value = orderby;
            using (SqlDataReader dr = ProcCommander.RunProcedure("GetInfoByWhere", param))
            {
                while (dr.Read())
                {
                    userList.Add(Transform.ToRegUser(dr));
                }
                dr.Close();//zgy
            }
            return userList;
        }
        /// <summary>
        /// 获取注册用户分页列表
        /// </summary>
        /// <param name="PageSize">分页大小</param>
        /// <param name="PageIndex">索引</param>
        /// <param name="strWhere">SQL条件</param>
        /// <param name="count">输出总条数</param>
        /// <returns></returns>
        public IList<RegUser> GetUserList(int PageSize, int PageIndex, string strWhere,out int count)
        {
            IList<RegUser> userList = new List<RegUser>();

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
            param[0].Value = "password";
            param[2].Value = "paixu";
            param[3].Value = PageSize;
            param[4].Value = PageIndex;
            param[7].Value = strWhere;
            using (SqlDataReader dr = ProcCommander.RunProcedure("GetInfoByPage", param))
            {
                while (dr.Read())
                {
                    userList.Add(Transform.ToRegUser(dr));
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
            param2[0].Value = "password";
            param2[2].Value = "paixu],[id";
            param2[3].Value =  PageSize;
            param2[4].Value = PageIndex;
            param2[5].Value = 1;
            param2[6].Value = 1;
            param2[7].Value = strWhere;
            count = (int)ProcCommander.RunProcedureScalar("GetInfoByPage", param2);
            return userList;

        }

        /// <summary>
        /// 更新用户数据
        /// </summary>
        /// <param name="Model">用户对象</param>
        /// <returns></returns>
        public bool Update(RegUser Model)
        {
            SqlParameter[] param = {
                                        new SqlParameter("@users",SqlDbType.VarChar,50),
                                        new SqlParameter("@id",SqlDbType.Int),
                                        new SqlParameter("@power",SqlDbType.VarChar,200),
                                        new SqlParameter("@admin",SqlDbType.VarChar,50),
                                        new SqlParameter("@namee",SqlDbType.VarChar,50),
                                        new SqlParameter("@img",SqlDbType.VarChar,50),
                                        new SqlParameter("@pass",SqlDbType.Bit),
                                        new SqlParameter("@mail",SqlDbType.VarChar,50),
                                        new SqlParameter("@QQ",SqlDbType.VarChar,50),
                                        new SqlParameter("@tel",SqlDbType.VarChar,50),
                                        new SqlParameter("@xuehao",SqlDbType.VarChar,50),
                                        new SqlParameter("@zaizhi",SqlDbType.Bit),
                                        new SqlParameter("@zhiwu",SqlDbType.VarChar,50),
                                        new SqlParameter("@year",SqlDbType.VarChar,4),
                                        new SqlParameter("@paixu",SqlDbType.VarChar,100),
                                        new SqlParameter("@jieshao",SqlDbType.VarChar,2000),
                                        new SqlParameter("@intime",SqlDbType.DateTime),
                                        new SqlParameter("@outtime",SqlDbType.DateTime),
                                        new SqlParameter("@zybj",SqlDbType.VarChar,100),
                                        new SqlParameter("@jiguan",SqlDbType.VarChar,100),
                                        new SqlParameter("@birthday",SqlDbType.DateTime)
                                  };
            param[0].Value = Model.UserName;
            param[1].Value = Model.UserId;
            param[2].Value = Model.Power;
            param[3].Value = Model.Admin;
            param[4].Value = Model.Name;
            param[5].Value = Model.Img;
            param[6].Value = Model.Pass;
            param[7].Value = Model.Email;
            param[8].Value = Model.QQ;
            param[9].Value = Model.Tel;
            param[10].Value = Model.Xuehao;
            param[11].Value = Model.Zaizhi;
            param[12].Value = Model.Zhiwu;
            param[13].Value = Model.Nianji;
            param[14].Value = Model.Paixu;
            param[15].Value = Model.Jieshao;
            param[16].Value = Model.Intime;
            param[17].Value = Model.Outtime;
            param[18].Value = Model.Zybj;
            param[19].Value = Model.Jiguan;
            param[20].Value = Model.Birthday;
            int rowAffected;
            ProcCommander.RunProcedure("User_Update", param, out rowAffected);
            return (rowAffected > 0);
        }
        ///// <summary>
        ///// 管理用户
        ///// </summary>
        ///// <param name="Model">用户对象</param>
        ///// <returns></returns>
        //public bool Admin(RegUser Model)
        //{
        //    SqlParameter[] parame ={   new SqlParameter("@id",SqlDbType.Int),
        //                               new SqlParameter("@paixu",SqlDbType.VarChar,100),
        //                               new SqlParameter("@pass",SqlDbType.Bit),
        //                               new SqlParameter("@zaizhi",SqlDbType.Bit),
        //                               new SqlParameter("@admin",SqlDbType.VarChar,50),
        //                               new SqlParameter("@zhiwu",SqlDbType.VarChar,50),
        //                               new SqlParameter("@intime",SqlDbType.DateTime),
        //                               new SqlParameter("@outtime",SqlDbType.DateTime)

        //                          };
        //    parame[0].Value = Model.UserId;
        //    parame[1].Value = Model.Paixu;
        //    parame[2].Value = Model.Pass;
        //    parame[3].Value = Model.Zaizhi;
        //    parame[4].Value = Model.Admin;
        //    parame[5].Value = Model.Zhiwu;
        //    parame[6].Value = Model.Intime;
        //    parame[7].Value = Model.Outtime;
        //    int row;
        //    ProcCommander.RunProcedure("User_Admin", parame, out row);
        //    return (row>0);
        //}
        /// <summary>
        /// 更新密码
        /// </summary>
        /// <param name="Model">用户对象，需指定ID，密码</param>
        /// <returns></returns>
        public bool Update_Pwd(RegUser Model)
        {
            SqlParameter[] param ={
                                     new SqlParameter ("@id",SqlDbType.Int),
                                     new SqlParameter ("@pwd",SqlDbType.VarChar,50)
                                  };
            param[0].Value = Model.UserId;
            param[1].Value = Model.PassWord;
            int rowAffected;
            ProcCommander.RunProcedure("User_Update_pwd", param, out rowAffected);
            return (rowAffected > 0);
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="UserIds">用户ID传入（params）</param>
        /// <returns>返回删除用户的数量</returns>
        public int Del(string UserIds)
        {
            int rowAffected;
            SqlParameter[] param ={
                                      new SqlParameter ("@id",SqlDbType.VarChar,2000)
                                  };

            param[0].Value = UserIds;
            rowAffected = 0;
            ProcCommander.RunProcedure("User_Del", param, out rowAffected);
            return rowAffected;
        }

        /// <summary>
        /// 锁定用户
        /// </summary>
        /// <param name="UserId">用户ID传入（params）</param>
        /// <returns>返回锁定用户的数量</returns>
        public int Lock(string UserId)
        {
            int rowAffected;
            SqlParameter[] param ={
                                      new SqlParameter ("@id",SqlDbType.VarChar,200)
                                  };

            param[0].Value = UserId;
            rowAffected = 0;
            ProcCommander.RunProcedure("User_Lock", param, out rowAffected);
            return rowAffected;
        }

        /// <summary>
        /// 解锁用户
        /// </summary>
        /// <param name="UserIds">用户ID传入（params）</param>
        /// <returns>返回锁定用户的数量</returns>
        public int UnLock(string UserId)
        {
            int rowAffected;
            SqlParameter[] param ={
                                      new SqlParameter ("@id",SqlDbType.VarChar,200)
                                  };

            param[0].Value = UserId;
            rowAffected = 0;
            ProcCommander.RunProcedure("User_Unlock", param, out rowAffected);
            return rowAffected;
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="UserName">用户名</param>
        /// <param name="PassWrod">密码的SHA值</param>
        /// <returns></returns>
        public bool Login(string UserName, string PassWrod)
        {
            int rowsAffected;
            SqlParameter[] parameters = {
											new SqlParameter("@users",SqlDbType.VarChar,50),
											new SqlParameter("@pwd",SqlDbType.VarChar,50)
										};
            parameters[0].Value = UserName;
            parameters[1].Value = PassWrod;
            int result = ProcCommander.RunProcedure("User_Login", parameters, out rowsAffected);
            return (result == 1);

        }

        #endregion
    }
}
