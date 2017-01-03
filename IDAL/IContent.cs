using System.Collections.Generic;
using Lgwin.Model;

namespace Lgwin.IDAL
{
    public interface IContent
    {
        /// <summary>
        /// 添加文章
        /// </summary>
        /// <param name="Model">文章对象</param>
        /// <returns></returns>
        bool Add(Content Model);

        /// <summary>
        /// 更新文章
        /// </summary>
        /// <param name="Model">文章对象</param>
        /// <returns></returns>
        bool Update(Content Model);

        /// <summary>
        /// 删除文章
        /// </summary>
        /// <param name="Ids">id,id,id</param>
        /// <returns></returns>
        int Del(string Ids);

        /// <summary>
        /// 审核通过文章
        /// </summary>
        /// <param name="Ids">id,id,id</param>
        /// <returns></returns>
        int Pass(string Ids);

        /// <summary>
        /// 取消审核通过文章
        /// </summary>
        /// <param name="Ids">id,id,id</param>
        /// <returns></returns>
        int UnPass(string Ids);

        /// <summary>
        ///  获取要审核文章的编辑状态
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int ReadState(int id);

        /// <summary>
        /// 更新编辑状态
        /// </summary>
        /// <param name="ids">要更新的ID</param>
        /// <param name="state">值</param>
        /// <returns></returns>
        int StateUpdate(int ids, int state);
        IList<Content> getldartlist(string str, string str1);

        /// <summary>
        /// 通过ID获取文章对象
        /// </summary>
        /// <param name="Id">文章ID</param>
        /// <returns></returns>
        Content GetArticle(int Id);
        IList<Content> GetArticles(int PageSize, int Page, string Where, string ORDERBY, bool DESC, out int PageCount);
        int GetCount(string where);
        int GetHitNumber(string Id,bool Flag);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Caption"></param>
        /// <param name="PageSize"></param>
        /// <param name="Page"></param>
        /// <returns></returns>
        IList<Content> GetArticleList(string strWhere, string orderby);
        IList<Content> GetList(string Caption,int PageSize,int Page,string Where,out int PageCount);
        IList<Content> GetList(int PageSize, int Page, string Where, out int PageCount);
        IList<Content> GetList(int PageSize, int Page, string Where, string ORDERBY, bool DESC, out int PageCount);
        ///获取相关文章列表
        //IList<Content> GetList(int PageSize, int Page, string Where, out int PageCount,string keywords,string date);
    }
}
