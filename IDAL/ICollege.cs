using System;
using System.Collections.Generic;
using Lgwin.Model;

namespace Lgwin.IDAL
{
    /// <summary>
    /// 学院接口
    /// </summary>
    public interface ICollege
    {
        /// <summary>
        /// 学院添加
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        bool Add(College Model);

        /// <summary>
        /// 学院删除
        /// </summary>
        /// <param name="Ids"></param>
        /// <returns></returns>
        int Del(string Ids);

        /// <summary>
        /// 学院更新
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        bool Update(College Model);

        /// <summary>
        /// 学院列表
        /// </summary>
        /// <returns></returns>
        IList<College> GetList();
    }
}
