using System.Collections.Generic;
using Lgwin.Model;

namespace Lgwin.IDAL
{
    public interface IVideo
    {
        /// <summary>
        /// 视频添加
        /// </summary>
        /// <param name="Model">视频对象</param>
        /// <returns>Boolean</returns>
        bool Add(Video Model);

        /// <summary>
        /// 视频更新
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        bool Update(Video Model);

        /// <summary>
        /// 视频删除
        /// </summary>
        /// <param name="Ids">Id，id，id</param>
        /// <returns></returns>
        int Del(string Ids);
        int GetCount(string where);
        int GetHitNumber(string Id);
        Video GetVideoById(int Id);
        /// <summary>
        /// 视频列表
        /// </summary>
        /// <param name="ztid">视频ID,参数0表示获取所有列表</param>
        /// <returns></returns>
        IList<Video> GetVideoList(int PageSize, int Page, string Where, out int PageCount);
        IList<Video1> GetVideolist(int PageSize, int Page, string Where, string ORDERBY, bool DESC, out int PageCount);
    }
}
