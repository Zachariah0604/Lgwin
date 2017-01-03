using System;
using System.Collections.Generic;
using Lgwin.Model;
using Lgwin.IDAL;


namespace Lgwin.BLL
{
    /// <summary>
    /// 文章内容逻辑处理
    /// </summary>
    public class CaiFangBLL
    {
        private static readonly ICaiFang dal = DALFactory.DataAccess.CreatCaiFang();

        /// <summary>
        /// 添加采访
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        public bool Add(Lgwin.Model.CaiFang Model)
        {
            return dal.Add(Model);
        }
        /// <summary>
        /// 删除采访
        /// </summary>
        /// <param name="Ids"></param>
        /// <returns></returns>
        public int Del(params int[] ids)
        {
            return (dal.Del(ids));
        }

        /// <summary>
        /// 获取采访列表
        /// </summary>
        /// <returns></returns>
        public IList<CaiFang> GetCaifangByPage(int PageSize, int PageIndex, string strWhere, out int count)
        {

            IList<CaiFang> list = new List<CaiFang>();
            list = dal.GetCaiFangList(PageSize, PageIndex, strWhere, out count);
            return list;

        }
    }
}
