using System.Collections.Generic;
using Lgwin.Model;

namespace Lgwin.IDAL
{
    /// <summary>
    /// 用户实体数据访问接口
    /// </summary>
    public interface IRegUser
    {
        /// <summary>
        /// 用户是否存在
        /// </summary>
        /// <param name="UserNames">用户名</param>
        /// <returns>Boolean</returns>
        bool Exists(string UserNames);

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="Model">用户对象</param>
        /// <returns>Boolean</returns>
        bool Add(RegUser Model);

        /// <summary>
        /// 获得用户对象
        /// </summary>
        /// <param name="UserName">用户名</param>
        /// <returns>用户对象</returns>
        RegUser GetUser(string UserName);
        int GetUserCount(string strWhere, string orderby);
        /// <summary>
        /// 获取注册用户表
        /// </summary>
        /// <param name="PageSize">分页大小</param>
        /// <param name="PageIndex">分页索引</param>
        /// <param name="strWhere">搜索条件</param>
        /// <returns>注册用户表</returns>
        IList<RegUser> GetUserList(int PageSize, int PageIndex, string strWhere,out int conunt);
        IList<RegUser> GetUserList(string strWhere, string orderby);
        /// <summary>
        /// 更新用户
        /// </summary>
        /// <param name="Model">用户对象</param>
        /// <returns>Boolean</returns>
        bool Update(RegUser Model);
        /// <summary>
        /// 用户管理
        /// </summary>
        /// <param name="Model">用户对象</param>
        /// <returns></returns>
        //bool Admin(RegUser Model);

        /// <summary>
        /// 更新用户密码
        /// </summary>
        /// <param name="Model">用户对象</param>
        /// <returns></returns>
        bool Update_Pwd(RegUser Model);

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="UserId">params用户ID</param>
        /// <returns>Boolean</returns>
        int Del(string UserIds);

        /// <summary>
        /// 锁定用户
        /// </summary>
        /// <param name="UserId">params用户ID</param>
        /// <returns>Boolean</returns>
        int Lock(string UserId);

        /// <summary>
        /// 解锁用户
        /// </summary>
        /// <param name="UserId">params用户ID</param>
        /// <returns></returns>
        int UnLock(string UserId);

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="UserName">用户名</param>
        /// <param name="UserName">密码</param>
        /// <returns>Boolean</returns>
        bool Login(string UserName,string PassWrod);

    }
}