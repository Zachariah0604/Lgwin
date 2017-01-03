using System;
using Lgwin.Model;
using System.Collections.Generic;

namespace Lgwin.IDAL
{
    public interface IZt
    {
        /// <summary>
        /// 专题添加
        /// </summary>
        /// <param name="Model">专题对象</param>
        /// <returns>Boolean</returns>
        bool Add(Zt Model);

        /// <summary>
        /// 校领导合集专题
        /// </summary>
        /// <param name="leadid">领导id</param>
        /// <param name="artid">文章id</param>
        void leadAdd(string leadid, string artid);
        void Delldart(string ldid, string artid);
        /// <summary>
        /// 专题更新
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        bool Update(Zt Model);

        /// <summary>
        /// 专题删除
        /// </summary>
        /// <param name="Ids">Id，id，id</param>
        /// <returns></returns>
        int Del(string Ids);
        /// <summary>
        /// 通过ID获取专题对象
        /// </summary>
        /// <param name="Id">专题Id</param>
        /// <returns></returns>
        Zt GetZtById(int Id);
        /// <summary>
        /// 专题列表
        /// </summary>
        /// <param name="Show">是否显示全部</param>
        /// <returns></returns>
        IList<Zt> GetZtList(bool ShowAll);
    }
}
