using System;
using System.Collections.Generic;
using Lgwin.Model;
using Lgwin.IDAL;


namespace Lgwin.BLL
{
    /// <summary>
    /// 文章内容逻辑处理
    /// </summary>
    public class ContentBLL
    {
        private static readonly IContent dal = DALFactory.DataAccess.CreatContent();

        /// <summary>
        /// 获取文章内容
        /// </summary>
        /// <param name="Id">传入文章编号</param>
        /// <returns></returns>
        public Content Get(int Id)
        {
            return dal.GetArticle(Id);
        }
        /// <summary>
        /// 返回新闻的所有内容的列表，主要用于生成首页
        /// </summary>
        /// <param name="PageSize">每页条数</param>
        /// <param name="Page">第几页</param>
        /// <param name="Where">sql条件语句</param>
        /// <param name="ORDERBY">排序字段</param>
        /// <param name="DESC">是否降序</param>
        /// <param name="PageCount">输出总条数</param>
        /// <returns></returns>
        public IList<Content> GetArticles(int PageSize, int Page, string Where, string ORDERBY, bool DESC, out int PageCount)
        {
            return dal.GetArticles(PageSize, Page, Where, ORDERBY, DESC, out PageCount);
        }

        /// <summary>
        /// 添加文章
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        public bool Add(Lgwin.Model.Content Model)
        {
            return dal.Add(Model);
        }
        /// <summary>
        /// 删除文章
        /// </summary>
        /// <param name="Ids"></param>
        /// <returns></returns>
        public int Del(string Ids)
        {
            return dal.Del(Ids);
        }
        public int Pass(string Id)
        {
            return dal.Pass(Id);
        }
        public int Unpass(string Ids)
        {
            return dal.UnPass(Ids);
        }

        /// <summary>
        /// 获取要审核文章的编辑状态
        /// </summary>
        /// <param name="id">要审核的文章</param>
        /// <returns>返回状态值</returns>
        public int ReadState(int id)
        {
            return dal.ReadState(id);
        }


        /// <summary>
        /// 编辑状态更新
        /// </summary>
        /// <param name="ids">要更新的ID</param>
        /// <param name="state">值</param>
        /// <returns></returns>
        public int StateUpdate(int ids, int state)
        {
            return dal.StateUpdate(ids,state);
        }
        /// <summary>
        /// 得到领导集合专题文章列表，暂时用，可删除
        /// </summary>
        /// <returns></returns>
        public IList<Content> getldartlist(string ldid, string where)
        {
            IList<Content> list = new List<Content>();
            try
            {
                list = dal.getldartlist(ldid, where);
            }
            catch { }
            finally
            {

            }
            return list;
        }


        /// <summary>
        /// 更新文章内容
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        public bool Update(Lgwin.Model.Content Model)
        {
            return dal.Update(Model);
        }
        public int GetCount(string where)
        {
            return dal.GetCount(where);
        }
        /// <summary>
        /// 由Id获得点击量，并且点击量加1
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int GetHitNumber(string Id,bool Flag)
        {
            return dal.GetHitNumber(Id,Flag);
        }
        public  IList<Content> GetArticleList(string strWhere, string orderby)
        {
            IList<Content> list = new List<Content>();
            return dal.GetArticleList(strWhere,orderby);
        }

        /// <summary>
        /// 获取新闻列表
         /// </summary>
         /// <param name="Caption">栏目名称</param>
         /// <param name="PageSize">每页条数</param>
         /// <param name="Page">第几页</param>
         /// <param name="Auditing">审核是否通过</param>
         /// <param name="Count">输出总条数</param>
         /// <returns></returns>
        public IList<Content> GetList(string Caption, int PageSize, int Page, string Where, out int Count)
        {
            IList<Content> list = new List<Content>();
            list = dal.GetList(Caption, PageSize, Page, Where, out Count);
            return list;
        }
        public IList<Content> GetList(int PageSize, int Page, string Where, out int Count)
        {
            IList<Content> list = new List<Content>();
            list = dal.GetList(PageSize, Page, Where, out Count);
            return list;
        }
        public IList<Content> GetList(int PageSize, int Page, string Where, string ORDERBY, bool DESC, out int PageCount)
        {
            IList<Content> list = new List<Content>();
            list = dal.GetList(PageSize, Page, Where, ORDERBY, DESC, out PageCount);
            return list;
        }
        /// <summary>
        /// 获取相关文章列表
        /// </summary>
        /// <returns></returns>
        //public IList<Content> GetList(int PageSize, int Page, string Where, out int Count,string keywords, string date)
        //{
        //    IList<Content> list = new List<Content>();
        //    list = dal.GetList(PageSize, Page, Where, out Count,keywords,date);
        //    return list;
        //}
    }
}
