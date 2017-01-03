using System;
using Lgwin.Model;
using Lgwin.IDAL;
using Lgwin.DALFactory;
using System.Web.Security;
using System.Collections.Generic;

namespace Lgwin.BLL
{
    public class RegUserBLL
    {
        /// <summary>
        /// 通过数据工厂获得RegUser数据处理对象
        /// </summary>
        private static readonly IRegUser dal = DataAccess.CreatRegUser();

        /// <summary>
        /// 检查用户是否存在
        /// </summary>
        /// <param name="UserNames">用户名</param>
        /// <returns>boolean</returns>
        public bool Exists(string UserNames)
        {
            try
            {
                return (dal.Exists(UserNames));
            }
            catch (Exception ex)
            {
                //错误处理，记录日志
                return false;
            }
        }    

        /// <summary>
        /// 用户添加
        /// </summary>
        /// <param name="Model">用户对象</param>
        /// <returns>Boolean</returns>
        public bool Add(RegUser Model)
        {
            try
            {
                return dal.Add(Model);
            }
            catch (Exception ex)
            {
                //错误处理，记录日志
                return false;
            }
        }
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="UserId">用户ID</param>
        /// <returns></returns>
        public int Del(string UserId)
        {
               return dal.Del(UserId);
        }

        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="Model">用户对象</param>
        /// <returns>Boolean</returns>
        public bool Update(RegUser Model)
        {
            try
            {
                return (dal.Update(Model));
            }
            catch (Exception ex)
            {
                //错误处理，记录日志
                return false;
            }
        }
        /// <summary>
        /// 更新密码
        /// </summary>
        /// <param name="model">用户</param>
        /// <returns></returns>
        public bool Update_Pwd(RegUser model)
        {
            return dal.Update_Pwd(model);
        }
        /// <summary>
        /// 管理用户
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        //public bool Admin(RegUser model)
        //{
        //    return dal.Admin(model);
        //}
        public int GetUserCount(string strWhere, string orderby)
        {
            return dal.GetUserCount(strWhere,orderby);
        }
        /// <summary>
        /// 获得用户对象
        /// </summary>
        /// <param name="UserName">用户名</param>
        /// <returns>用户对象</returns>
        public RegUser GetUserInfo(string UserName)
        {
            try
            {
                return dal.GetUser(UserName);
            }
            catch (Exception ex)
            {
                //错误处理，记录日志
                return null;
            }
        }

        public IList<RegUser> GetUserByPage(int PageSize, int PageIndex, string strWhere,out int count)
        {

            IList<RegUser> list=new List<RegUser>();
            list = dal.GetUserList(PageSize, PageIndex, strWhere, out count);
            return list;

        }
        public IList<RegUser> GetUserList(string strWhere, string orderby)
        {
            return dal.GetUserList(strWhere,orderby);
        }
        public bool LockUser(string userId)
        {
            return (dal.Lock(userId)>0);

        }
        public bool UnLockUser(string userId)
        {
            return (dal.UnLock(userId) > 0);
        }
        /// <summary>
        /// 用户登录认证
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="PassWord"></param>
        /// <returns></returns>
        public bool Login(string UserName, string PassWord)
        {
            if (dal.Login(UserName,PassWord))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
