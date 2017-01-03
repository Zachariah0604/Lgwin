using System;
using System.Collections.Generic;
using Lgwin.IDAL;
using Lgwin.DALFactory;
using Lgwin.Model;

namespace Lgwin.BLL
{
    public class VideoBLL
    {
        /// <summary>
        /// 通过数据工厂获得专题对象
        /// </summary>
        private static readonly IVideo dal = DataAccess.CreatVideo();
        public bool Add(Video mod)
        {
            return dal.Add(mod);
        }
        public int Del(string Ids)
        {
            return dal.Del(Ids);
        }
        public bool Update(Video mod)
        {
            return dal.Update(mod);
        }
        public Video GetVideoById(int id)
        {
            return dal.GetVideoById(id);
        }
        public int GetCount(string where)
        {
            return dal.GetCount(where);
        }
        public int GetHitNumber(string Id)
        {
            return dal.GetHitNumber(Id);
        }
        /// <summary>
        /// 返回专题列表
        /// </summary>
        /// <param name="ShowAll">boolean 是否返回所有列表</param>
        /// <returns></returns>
       
        public IList<Video> GetVideoList(int PageSize, int Page, string Where, out int PageCount)
        {
            return dal.GetVideoList(PageSize, Page, Where, out PageCount);
        }
        public IList<Video1> GetVideolist(int PageSize, int Page, string Where, string ORDERBY, bool DESC, out int PageCount)
        {
            return dal.GetVideolist(PageSize, Page, Where, ORDERBY, DESC, out  PageCount);
        }
    }
}
