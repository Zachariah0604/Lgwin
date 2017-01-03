using System;
using System.Collections.Generic;
using Lgwin.Model;



namespace Lgwin.IDAL
{
    /// <summary>
    /// 采访操作接口
    /// </summary>
    public interface ICaiFang
    {
        /// <summary>
        /// 添加采访
        /// </summary>
        /// <param name="Model">采访对象</param>
        /// <returns>Boolean</returns>
        bool Add(CaiFang Model);

        /// <summary>
        /// 删除采访
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int Del(params int[] Id);


        ///// <summary>
        ///// 获取采访列表
        ///// </summary>
        ///// <returns>返回采访列表对象</returns>
        //IList<CaiFang> GetCaiFangList();
        /// <summary>
        /// 获取采访列表
        /// </summary>
        /// <param name="PageSize">分页大小</param>
        /// <param name="PageIndex">分页索引</param>
        /// <param name="strWhere">搜索条件</param>
        /// <returns>注册用户表</returns>
        IList<CaiFang> GetCaiFangList(int PageSize, int PageIndex, string strWhere, out int conunt);
    }
}
