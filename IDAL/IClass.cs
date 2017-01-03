using System;
using System.Collections.Generic;
using Lgwin.Model;

namespace Lgwin.IDAL
{
    /// <summary>
    /// 分类操作接口
    /// </summary>
    public interface IClass
    {
        /// <summary>
        /// 添加分类
        /// </summary>
        /// <param name="Model">分类对象</param>
        /// <returns>Boolean</returns>
        bool Add(Class Model);

        /// <summary>
        /// 删除分类
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int Del(params int[] Id);

        /// <summary>
        /// 更新分类
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        bool Update(Class Model);

        /// <summary>
        /// 获取指定ID的分类对象
        /// </summary>
        /// <param name="Id">编号</param>
        /// <returns>分类对象</returns>
        Class GetClass(int Id);

        /// <summary>
        /// 获取分类列表
        /// </summary>
        /// <returns>返回分类列表对象</returns>
        IList<Class> GetClassList();
    }
}
