using System;
using Lgwin.Model;
using System.Collections.Generic;

namespace Lgwin.IDAL
{
    public interface IZtCaption
    {
        /// <summary>
        /// 专题添加
        /// </summary>
        /// <param name="Model">专题对象</param>
        /// <returns>Boolean</returns>
        bool Add(ZtCaption Model);

        /// <summary>
        /// 专题更新
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        bool Update(ZtCaption Model);

        /// <summary>
        /// 专题删除
        /// </summary>
        /// <param name="Ids">Id，id，id</param>
        /// <returns></returns>
        int Del(string Ids);
        ZtCaption GetZtCaption(int Id);
        ZtCaption GetZtCaption(string capname);
        /// <summary>
        /// 专题列表
        /// </summary>
        /// <param name="ztid">专题ID,参数0表示获取所有列表</param>
        /// <returns></returns>
        IList<ZtCaption> GetZtCaptionList(string ztid);
    }
}
