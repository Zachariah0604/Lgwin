using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Lgwin.DBUtility;
using Lgwin.IDAL;
using Lgwin.Model;

namespace Lgwin.SqlDAL
{
    public class ContentDAL : IContent
    {

        #region IContent Members

        public bool Add(Content Model)
        {
            SqlParameter[] param = { 
                                       new SqlParameter("@caption",SqlDbType.VarChar,50),
                                       new SqlParameter("@title",SqlDbType.VarChar,200),
                                       new SqlParameter("@subtitle",SqlDbType.VarChar,200),
                                       new SqlParameter("@content",SqlDbType.Text),
                                       new SqlParameter("@datee",SqlDbType.SmallDateTime),
                                       new SqlParameter("@counter", SqlDbType.Int),
                                       new SqlParameter("@auditing",SqlDbType.Bit),
                                       new SqlParameter("@author",SqlDbType.VarChar,50),
                                       new SqlParameter("@fro",SqlDbType.VarChar,160),
                                       new SqlParameter("@editor",SqlDbType.VarChar,50),
                                       new SqlParameter("@tel",SqlDbType.VarChar,50),
                                       new SqlParameter("@url",SqlDbType.VarChar,255),
                                       new SqlParameter("@yaowen",SqlDbType.Bit),
                                       new SqlParameter("@tuwen",SqlDbType.Bit),
                                       new SqlParameter("@sdut",SqlDbType.Bit),
                                       new SqlParameter("@sdutpic",SqlDbType.Bit),
                                       new SqlParameter("@ztid",SqlDbType.VarChar,50),
                                       new SqlParameter("@zt",SqlDbType.VarChar,50),
                                       new SqlParameter("@html",SqlDbType.Bit),
                                       new SqlParameter("@smallpic",SqlDbType.VarChar,200),
                                       new SqlParameter("@editing",SqlDbType.VarChar,50),
                                       //new SqlParameter("@dangtuan",SqlDbType.Bit),
                                       //new SqlParameter("@fuwu",SqlDbType.Bit),
                                       //new SqlParameter("@bumen",SqlDbType.Bit),
                                       //new SqlParameter("@kuaixun",SqlDbType.Bit),
                                       //new SqlParameter("@ztid2",SqlDbType.VarChar,50),
                                       //new SqlParameter("@zt2",SqlDbType.VarChar,50),
                                       new SqlParameter("@keywords",SqlDbType.VarChar,500),
                                       new SqlParameter("@forbiden",SqlDbType.NVarChar),
                                       new SqlParameter("@zixun",SqlDbType.Bit),
                                       new SqlParameter("@statenow",SqlDbType.Int)
                                   };
            param[0].Value = Model.Caption;
            param[1].Value = Model.Title;
            param[2].Value = Model.Subtitle;
            param[3].Value = Model.Contents;
            param[4].Value = Model.Datee;
            param[5].Value = Model.Counter;
            param[6].Value = Model.Auditing;
            param[7].Value = Model.Author;
            param[8].Value = Model.Fro;
            param[9].Value = Model.Editor;
            param[10].Value = Model.Tel;
            param[11].Value = Model.Url;
            param[12].Value = Model.Yaowen;
            param[13].Value = Model.Tuwen;
            param[14].Value = Model.Sdut;
            param[15].Value = Model.Sdutpic;
            param[16].Value = Model.Ztid;
            param[17].Value = Model.Zt;
            param[18].Value = Model.Html;
            param[19].Value = Model.Smailpic;
            param[20].Value = Model.Editing;
            //param[21].Value = Model.Dangtuan;
            //param[22].Value = Model.Fuwu;
            //param[23].Value = Model.Bumen;
            //param[24].Value = Model.Kuaixun;
            //param[25].Value = Model.Ztid2;
            //param[26].Value = Model.Zt2;
            param[21].Value = Model.Keywords;
            param[22].Value = Model.Forbiden;
            param[23].Value = Model.Zixun;
            param[24].Value = 0;
            int rowAffected;
            ProcCommander.RunProcedure("Content_Add", param, out rowAffected);
            return (rowAffected > 0);
        }

        public bool Update(Content Model)
        {
            SqlParameter[] param = { 
                                       new SqlParameter("@caption",SqlDbType.VarChar,50),
                                       new SqlParameter("@title",SqlDbType.VarChar,200),
                                       new SqlParameter("@subtitle",SqlDbType.VarChar,200),
                                       new SqlParameter("@content",SqlDbType.NText),
                                       new SqlParameter("@datee",SqlDbType.SmallDateTime),
                                       new SqlParameter("@counter", SqlDbType.Int),
                                       new SqlParameter("@auditing",SqlDbType.Bit),
                                       new SqlParameter("@author",SqlDbType.VarChar,50),
                                       new SqlParameter("@fro",SqlDbType.VarChar,160),
                                       new SqlParameter("@editor",SqlDbType.VarChar,50),
                                       new SqlParameter("@tel",SqlDbType.VarChar,50),
                                       new SqlParameter("@url",SqlDbType.VarChar,255),
                                       new SqlParameter("@yaowen",SqlDbType.Bit),
                                       new SqlParameter("@tuwen",SqlDbType.Bit),
                                       new SqlParameter("@sdut",SqlDbType.Bit),
                                       new SqlParameter("@sdutpic",SqlDbType.Bit),
                                       new SqlParameter("@ztid",SqlDbType.VarChar,50),
                                       new SqlParameter("@zt",SqlDbType.VarChar,50),
                                       new SqlParameter("@html",SqlDbType.Bit),
                                       new SqlParameter("@smallpic",SqlDbType.VarChar,200),
                                       new SqlParameter("@editing",SqlDbType.VarChar,50),
                                       //new SqlParameter("@dangtuan",SqlDbType.Bit),
                                       //new SqlParameter("@fuwu",SqlDbType.Bit),
                                       //new SqlParameter("@bumen",SqlDbType.Bit),
                                       //new SqlParameter("@kuaixun",SqlDbType.Bit),
                                       //new SqlParameter("@ztid2",SqlDbType.VarChar,50),
                                       //new SqlParameter("@zt2",SqlDbType.VarChar,50),
                                       new SqlParameter("@keywords",SqlDbType.VarChar,500),
                                       new SqlParameter("@forbiden",SqlDbType.NVarChar),
                                       new SqlParameter("@id",SqlDbType.Int),
                                       new SqlParameter("@zixun",SqlDbType.Bit)
                                   };
            param[0].Value = Model.Caption;
            param[1].Value = Model.Title;
            param[2].Value = Model.Subtitle;
            param[3].Value = Model.Contents;
            param[4].Value = Model.Datee;
            param[5].Value = Model.Counter;
            param[6].Value = Model.Auditing;
            param[7].Value = Model.Author;
            param[8].Value = Model.Fro;
            param[9].Value = Model.Editor;
            param[10].Value = Model.Tel;
            param[11].Value = Model.Url;
            param[12].Value = Model.Yaowen;
            param[13].Value = Model.Tuwen;
            param[14].Value = Model.Sdut;
            param[15].Value = Model.Sdutpic;
            param[16].Value = Model.Ztid;
            param[17].Value = Model.Zt;
            param[18].Value = Model.Html;
            param[19].Value = Model.Smailpic;
            param[20].Value = Model.Editing;
            //param[21].Value = Model.Dangtuan;
            //param[22].Value = Model.Fuwu;
            //param[23].Value = Model.Bumen;
            //param[24].Value = Model.Kuaixun;
            //param[25].Value = Model.Ztid2;
            //param[26].Value = Model.Zt2;
            param[21].Value = Model.Keywords;
            param[22].Value = Model.Forbiden;
            param[23].Value = Model.Id;
            param[24].Value = Model.Zixun;
            int rowAffected;
            ProcCommander.RunProcedure("Content_Update", param, out rowAffected);
            return (rowAffected > 0);
        }

        public int Del(string Ids)
        {
            SqlParameter[] param = {
                                        new SqlParameter("@ids",SqlDbType.VarChar,2000)
                                   };
            param[0].Value = Ids;
            int rowAffected;
            ProcCommander.RunProcedure("Content_Del", param, out rowAffected);
            return rowAffected;
        }

        public int Pass(string Ids)
        {
            SqlParameter[] param = {
                                        new SqlParameter("@ids",SqlDbType.VarChar,50)
                                   };
            param[0].Value = Ids;
            int rowAffected;
            ProcCommander.RunProcedure("Content_Pass", param, out rowAffected);
            return rowAffected;
        }

        public int UnPass(string Ids)
        {
            SqlParameter[] param = {
                                        new SqlParameter("@ids",SqlDbType.VarChar,50)
                                   };
            param[0].Value = Ids;
            int rowAffected;
            ProcCommander.RunProcedure("Content_UnPass", param, out rowAffected);
            return rowAffected;
        }

        /// <summary>
        /// 获取要审核文章的编辑状态
        /// </summary>
        /// <param name="id">要审核的文章</param>
        /// <returns>返回状态值</returns>
        public int ReadState(int id)
        {
            int state=-1;
            SqlParameter[] param = {
                                        new SqlParameter("@ids",SqlDbType.VarChar,2000)
                                   };
            param[0].Value = id;
            SqlDataReader dr = ProcCommander.RunProcedure("Content_state_select", param);
            if (dr.Read())
            {
                state = Convert.ToInt32(dr["StateNow"].ToString());
            };
            dr.Close();
            return state;
        }

        /// <summary>
        /// 编辑状态更新
        /// </summary>
        /// <param name="ids">要更新的ID</param>
        /// <param name="state">值</param>
        /// <returns></returns>
        public int StateUpdate(int ids,int state)
        {
            SqlParameter[] param = { 
                                       new SqlParameter("@ids",SqlDbType.Int),
                                       new SqlParameter("@statenow",SqlDbType.Int)
                                   };
            param[0].Value = ids;
            param[1].Value = state;
            int rowAffected;
            ProcCommander.RunProcedure("Content_state_Update", param, out rowAffected);
           return  rowAffected;
        }
        /// <summary>
        /// 领导专题获取文章列表，用后可删
        /// </summary>
        /// <returns></returns>
        public IList<Content> getldartlist(string ldid, string where)
        {
            IList<Content> articleList = new List<Content>();
            SqlParameter[] par ={
                                    new SqlParameter("@ldid",SqlDbType.Int),
                                    new SqlParameter("@where",SqlDbType.VarChar)
                               };
            par[0].Value = Int32.Parse(ldid);
            par[1].Value = where;
            Content ct = new Content();
            using (SqlDataReader dr = ProcCommander.RunProcedure("leaderselect", par))
            {
                while (dr.Read())
                {
                    ct = Transform.ToContent(dr);
                    ct.Ztid = dr["leaderid"].ToString();
                    articleList.Add(ct);
                }
                dr.Close();
            }
            return articleList;
        }
 

        /// <summary>
        /// 由Id获得点击量，并且点击量加1
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int GetHitNumber(string Id,bool Flag)
        {
            int hitnumber = 0;
            SqlParameter[] param = {
                                        new SqlParameter("@Id",SqlDbType.VarChar,50),
                                        new SqlParameter("@Flag",SqlDbType.Bit)
                                   };
            param[0].Value = Id;
            param[1].Value = Flag;
            hitnumber = (int)ProcCommander.RunProcedureScalar("Content_HitNumber", param);
            return hitnumber;
        }
        public Content GetArticle(int Id)
        {
            SqlParameter[] param = {
                                        new SqlParameter("@Id",SqlDbType.Int)
                                   };
            param[0].Value = Id;
            using (SqlDataReader dr = ProcCommander.RunProcedure("Content_GetInfo", param))
            {
                //if (dr.Read())
                //{
                //    return (Transform.ToContent(dr));
                //    dr.Close();//zgy
                //}
                //else
                //    return null;
                try
                {
                    if (dr.Read())
                        return Transform.ToContent(dr);
                    else
                        return null;
                }
                finally
                {
                    if (dr != null && !dr.IsClosed)
                        dr.Close();
                }
            }
        }
        public IList<Content> GetArticles(int PageSize, int Page, string Where, string ORDERBY, bool DESC, out int PageCount)
        {
            IList<Content> List = new List<Content>();
            SqlParameter[] param = {
                                        new SqlParameter("@tbName",SqlDbType.VarChar,50),
                                        new SqlParameter("@strGetItem",SqlDbType.VarChar,1000),
                                        new SqlParameter("@fldName",SqlDbType.VarChar,50),
                                        new SqlParameter("@PageSize",SqlDbType.Int),
                                        new SqlParameter("@PageIndex",SqlDbType.Int),
                                        new SqlParameter("@doCount",SqlDbType.Bit),
                                        new SqlParameter("@OrderType",SqlDbType.Bit),
                                        new SqlParameter("@strWhere",SqlDbType.VarChar,1500)
                                   };
            param[0].Value = "newscon";
            param[1].Value = "[id],[caption],[title],[subtitle],[content],[datee],[counter],[auditing],[hot] ,[author],[fro],[editor],[remark],[tel] ,[url],[yaowen],[tuwen],[sdut],[sdutpic] ,[zixun],[ztid],[zt],[html],[smallpic],[editing],[keywords],[forbiden],[StateNow]";
            param[2].Value = ORDERBY;
            param[3].Value = PageSize;
            param[4].Value = Page;
            param[5].Value = 0;
            param[6].Value = Convert.ToByte(DESC);
            param[7].Value = Where;

            using (SqlDataReader dr = ProcCommander.RunProcedure("GetInfoByPage", param))
            {
                while (dr.Read())
                {
                    List.Add(Transform.ToContent(dr));
                }
                dr.Close();//zgy
            }

            SqlParameter[] param2 = {
                                        new SqlParameter("@tbName",SqlDbType.VarChar,50),
                                        new SqlParameter("@strGetItem",SqlDbType.VarChar,1000),
                                        new SqlParameter("@fldName",SqlDbType.VarChar,50),
                                        new SqlParameter("@PageSize",SqlDbType.Int),
                                        new SqlParameter("@PageIndex",SqlDbType.Int),
                                        new SqlParameter("@doCount",SqlDbType.Bit),
                                        new SqlParameter("@OrderType",SqlDbType.Bit),
                                        new SqlParameter("@strWhere",SqlDbType.VarChar,1500)
                                   };
            param2[0].Value = "newscon";
            param2[1].Value = "[caption],[title],[datee],[id],[counter],[author],[editor],[sdut],[sdutpic],[zixun],[yaowen],[tuwen],[auditing],[editing],[forbiden]";
            param2[2].Value = ORDERBY;
            param2[3].Value = PageSize;
            param2[4].Value = Page;
            param2[5].Value = 1;
            param2[6].Value = Convert.ToByte(DESC);
            param2[7].Value = Where;
            PageCount = (int)ProcCommander.RunProcedureScalar("GetInfoByPage", param2);

            return List;
        }
        /// <summary>
        /// 查询标题相关文章DAL
        /// </summary>
        /// <param name="PageSize"></param>
        /// <param name="Page"></param>
        /// <param name="Where"></param>
        /// <param name="ORDERBY"></param>
        /// <param name="DESC"></param>
        /// <param name="PageCount"></param>
        /// <returns></returns>
        //public IList<Content> GetArticles1(int PageSize, int Page, string Where, string ORDERBY, bool DESC, out int PageCount)
        //{
        //    IList<Content> List = new List<Content>();
        //    SqlParameter[] param = {
        //                                new SqlParameter("@tbName",SqlDbType.VarChar,50),
        //                                new SqlParameter("@strGetItem",SqlDbType.VarChar,1000),
        //                                new SqlParameter("@fldName",SqlDbType.VarChar,50),
        //                                new SqlParameter("@PageSize",SqlDbType.Int),
        //                                new SqlParameter("@PageIndex",SqlDbType.Int),
        //                                new SqlParameter("@doCount",SqlDbType.Bit),
        //                                new SqlParameter("@OrderType",SqlDbType.Bit),
        //                                new SqlParameter("@strWhere",SqlDbType.VarChar,1500)
        //                           };
        //    param[0].Value = "newscon";
        //    param[1].Value = "[id],[caption],[title],[subtitle],[content],[datee],[counter],[auditing],[hot] ,[author],[fro],[editor],[remark],[tel] ,[url],[yaowen],[tuwen],[sdut],[sdutpic] ,[zixun],[ztid],[zt],[html],[smallpic],[editing],[keywords],[forbiden],[StateNow]";
        //    param[2].Value = ORDERBY;
        //    param[3].Value = PageSize;
        //    param[4].Value = Page;
        //    param[5].Value = 0;
        //    param[6].Value = Convert.ToByte(DESC);
        //    param[7].Value = Where;

        //    using (SqlDataReader dr = ProcCommander.RunProcedure("GetInfoByPage", param))
        //    {
        //        while (dr.Read())
        //        {
        //            List.Add(Transform.ToContent(dr));
        //        }
        //        dr.Close();//zgy
        //    }

        //    SqlParameter[] param2 = {
        //                                new SqlParameter("@tbName",SqlDbType.VarChar,50),
        //                                new SqlParameter("@strGetItem",SqlDbType.VarChar,1000),
        //                                new SqlParameter("@fldName",SqlDbType.VarChar,50),
        //                                new SqlParameter("@PageSize",SqlDbType.Int),
        //                                new SqlParameter("@PageIndex",SqlDbType.Int),
        //                                new SqlParameter("@doCount",SqlDbType.Bit),
        //                                new SqlParameter("@OrderType",SqlDbType.Bit),
        //                                new SqlParameter("@strWhere",SqlDbType.VarChar,1500)
        //                           };
        //    param2[0].Value = "newscon";
        //    param2[1].Value = "[caption],[title],[datee],[id],[counter],[author],[editor],[sdut],[sdutpic],[zixun],[yaowen],[tuwen],[auditing],[editing],[forbiden]";
        //    param2[2].Value = ORDERBY;
        //    param2[3].Value = PageSize;
        //    param2[4].Value = Page;
        //    param2[5].Value = 1;
        //    param2[6].Value = Convert.ToByte(DESC);
        //    param2[7].Value = Where;
        //    PageCount = (int)ProcCommander.RunProcedureScalar("GetInfoByPage", param2);

        //    return List;
        //}
        public int GetCount(string where)
        {
            int PageCount;
            SqlParameter[] param2 = {
                                        new SqlParameter("@tbName",SqlDbType.VarChar,50),
                                        new SqlParameter("@strGetItem",SqlDbType.VarChar,1000),
                                        new SqlParameter("@fldName",SqlDbType.VarChar,50),
                                        new SqlParameter("@PageSize",SqlDbType.Int),
                                        new SqlParameter("@PageIndex",SqlDbType.Int),
                                        new SqlParameter("@doCount",SqlDbType.Bit),
                                        new SqlParameter("@OrderType",SqlDbType.Bit),
                                        new SqlParameter("@strWhere",SqlDbType.VarChar,1500)
                                   };
            param2[0].Value = "newscon";
            //param2[1].Value = "[caption],[title],[datee],[id],[counter],[author],[editor],[sdut],[sdutpic],[yaowen],[tuwen],[auditing],[editing]";
            //param2[2].Value = "id";
            //param2[3].Value = PageSize;
            //param2[4].Value = Page;
            param2[5].Value = 1;
            param2[6].Value = 1;
            param2[7].Value = where;
            PageCount = (int)ProcCommander.RunProcedureScalar("GetInfoByPage", param2);
            return PageCount;
        }
        public IList<Content> GetArticleList(string strWhere, string orderby)
        {
            IList<Content> articleList = new List<Content>();
            SqlParameter[] param = {
                                         new SqlParameter("@tbName",SqlDbType.VarChar,50),
                                         new SqlParameter("@strGetItem",SqlDbType.VarChar,1000),
                                         new SqlParameter("@doCount",SqlDbType.Bit),
                                         new SqlParameter("@strWhere",SqlDbType.VarChar,1500),
                                         new SqlParameter("@OrderBy",SqlDbType.VarChar,1500)  
                                    };
            param[0].Value = "newscon";
            param[2].Value = "[id],[caption],[title],[subtitle],[datee],[counter],[auditing],[hot] ,[author],[fro],[editor],[remark],[tel] ,[url],[yaowen],[tuwen],[sdut],[sdutpic] ,[zixun],[ztid],[zt],[html],[smallpic],[editing],[keywords],[forbiden],[StateNow]";
            param[3].Value = strWhere;
            param[4].Value = orderby;
            using (SqlDataReader dr = ProcCommander.RunProcedure("GetInfoByWhere", param))
            {
                while (dr.Read())
                {
                    articleList.Add(Transform.ToContentList(dr));
                }
                dr.Close();
            }
            return articleList;

        }
        public IList<Content> GetList(string Caption, int PageSize, int Page, string Where, out int PageCount)
        {
            if (Where != "")
            {
                Where = "and " + Where;
            }
            IList<Content> List = new List<Content>();
            SqlParameter[] param = {
                                        new SqlParameter("@tbName",SqlDbType.VarChar,50),
                                        new SqlParameter("@strGetItem",SqlDbType.VarChar,1000),
                                        new SqlParameter("@fldName",SqlDbType.VarChar,50),
                                        new SqlParameter("@PageSize",SqlDbType.Int),
                                        new SqlParameter("@PageIndex",SqlDbType.Int),
                                        new SqlParameter("@doCount",SqlDbType.Bit),
                                        new SqlParameter("@OrderType",SqlDbType.Bit),
                                        new SqlParameter("@strWhere",SqlDbType.VarChar,1500)
                                   };
            param[0].Value = "newscon";
            param[1].Value = "[id],[caption],[title],[subtitle],[datee],[counter],[content],[auditing],[hot] ,[author],[fro],[editor],[remark],[tel] ,[url],[yaowen],[tuwen],[sdut],[sdutpic] ,[zixun],[ztid],[zt],[html],[smallpic],[editing],[keywords],[forbiden],[StateNow]";
            param[2].Value = "datee";
            param[3].Value = PageSize;
            param[4].Value = Page;
            param[5].Value = 0;
            param[6].Value = 1;
            param[7].Value = "([caption] ='" + Caption + "')" + Where;

            using (SqlDataReader dr = ProcCommander.RunProcedure("GetInfoByPage", param))
            {
                while (dr.Read())
                {
                    List.Add(Transform.ToContent(dr));
                }
                dr.Close();//zgy
            }

            SqlParameter[] param2 = {
                                        new SqlParameter("@tbName",SqlDbType.VarChar,50),
                                        new SqlParameter("@strGetItem",SqlDbType.VarChar,1000),
                                        new SqlParameter("@fldName",SqlDbType.VarChar,50),
                                        new SqlParameter("@PageSize",SqlDbType.Int),
                                        new SqlParameter("@PageIndex",SqlDbType.Int),
                                        new SqlParameter("@doCount",SqlDbType.Bit),
                                        new SqlParameter("@OrderType",SqlDbType.Bit),
                                        new SqlParameter("@strWhere",SqlDbType.VarChar,1500)
                                   };
            param2[0].Value = "newscon";
            param2[1].Value = "[caption],[title],[datee],[id],[counter],[author],[fro],[editor],[sdut],[sdutpic],[zixun],[yaowen],[tuwen],[auditing],[editing],[forbiden]";
            param2[2].Value = "datee";
            param2[3].Value = PageSize;
            param2[4].Value = Page;
            param2[5].Value = 1;
            param2[6].Value = 1;
            param2[7].Value = "([caption] ='" + Caption + "')" + Where;
            PageCount = (int)ProcCommander.RunProcedureScalar("GetInfoByPage", param2);
            return List;
        }
        public IList<Content> GetList(int PageSize, int Page, string Where, out int PageCount)
        {
            IList<Content> List = new List<Content>();
            SqlParameter[] param = {
                                        new SqlParameter("@tbName",SqlDbType.VarChar,50),
                                        new SqlParameter("@strGetItem",SqlDbType.VarChar,1000),
                                        new SqlParameter("@fldName",SqlDbType.VarChar,50),
                                        new SqlParameter("@PageSize",SqlDbType.Int),
                                        new SqlParameter("@PageIndex",SqlDbType.Int),
                                        new SqlParameter("@doCount",SqlDbType.Bit),
                                        new SqlParameter("@OrderType",SqlDbType.Bit),
                                        new SqlParameter("@strWhere",SqlDbType.VarChar,1500)
                                   };
            param[0].Value = "newscon";
            param[1].Value = "[id],[caption],[title],[subtitle],[datee],[counter],[content],[auditing],[hot] ,[author],[fro],[editor],[remark],[tel] ,[url],[yaowen],[tuwen],[sdut],[sdutpic],[zixun],[ztid],[zt],[html],[smallpic],[editing],[keywords],[forbiden],[StateNow]";
            param[2].Value = "id";
            param[3].Value = PageSize;
            param[4].Value = Page;
            param[5].Value = 0;
            param[6].Value = 1;
            param[7].Value = Where;

            using (SqlDataReader dr = ProcCommander.RunProcedure("GetInfoByPage", param))
            {
                while (dr.Read())
                {
                    List.Add(Transform.ToContent(dr));
                }
                dr.Close();//zgy
            }

            SqlParameter[] param2 = {
                                        new SqlParameter("@tbName",SqlDbType.VarChar,50),
                                        new SqlParameter("@strGetItem",SqlDbType.VarChar,1000),
                                        new SqlParameter("@fldName",SqlDbType.VarChar,50),
                                        new SqlParameter("@PageSize",SqlDbType.Int),
                                        new SqlParameter("@PageIndex",SqlDbType.Int),
                                        new SqlParameter("@doCount",SqlDbType.Bit),
                                        new SqlParameter("@OrderType",SqlDbType.Bit),
                                        new SqlParameter("@strWhere",SqlDbType.VarChar,1500)
                                   };
            param2[0].Value = "newscon";
            param2[1].Value = "[caption],[title],[datee],[id],[counter],[author],[editor],[sdut],[sdutpic],[zixun],[yaowen],[tuwen],[auditing],[editing],[forbiden]";
            param2[2].Value = "datee";
            param2[3].Value = PageSize;
            param2[4].Value = Page;
            param2[5].Value = 1;
            param2[6].Value = 1;
            param2[7].Value = Where;
            PageCount = (int)ProcCommander.RunProcedureScalar("GetInfoByPage", param2);
            return List;
        }
        /// <summary>
        /// 根据关键字获取相关文章
        /// </summary>
        /// <param name="PageSize"></param>
        /// <param name="Page"></param>
        /// <param name="Where"></param>
        /// <param name="PageCount"></param>
        /// <returns></returns>
        //public IList<Content> GetList(int PageSize, int Page, string Where, out int PageCount,string keywords,string date)
        //{
        //    IList<Content> List = new List<Content>();
        //    SqlParameter[] param = {
        //                                new SqlParameter("@tbName",SqlDbType.VarChar,50),
        //                                new SqlParameter("@strGetItem",SqlDbType.VarChar,1000),
        //                                new SqlParameter("@fldName",SqlDbType.VarChar,50),
        //                                new SqlParameter("@doCount",SqlDbType.Bit),
        //                                new SqlParameter("@OrderType",SqlDbType.Bit),
        //                                new SqlParameter("@strWhere",SqlDbType.VarChar,1500),
        //                                new SqlParameter("@keywords",SqlDbType.VarChar,500),
        //                                new SqlParameter("@datee",SqlDbType.SmallDateTime)
        //                                //new SqlParameter("@PageSize",SqlDbType.Int),
        //                                //new SqlParameter("@PageIndex",SqlDbType.Int),
        //                           };
        //    param[0].Value = "newscon";
        //    param[1].Value = "[id],[caption],[title],[subtitle],[datee],[counter],[content],[auditing],[hot] ,[author],[fro],[editor],[remark],[tel] ,[url],[yaowen],[tuwen],[sdut],[sdutpic],[zixun],[ztid],[zt],[html],[smallpic],[editing],[keywords],[forbiden],[StateNow]";
        //    param[2].Value = "id";
        //    param[3].Value = 0;
        //    param[4].Value = 1;
        //    param[5].Value = Where;
        //    param[6].Value = keywords;
        //    param[7].Value = date;
        //    //param[3].Value = PageSize;
        //    //param[4].Value = Page;

        //    using (SqlDataReader dr = ProcCommander.RunProcedure("GetInfoByKeywords", param))
        //    {
        //        while (dr.Read())
        //        {
        //            List.Add(Transform.ToContent(dr));
        //        }
        //        dr.Close();//zgy
        //    }

        //    SqlParameter[] param2 = {
        //                                new SqlParameter("@tbName",SqlDbType.VarChar,50),
        //                                new SqlParameter("@strGetItem",SqlDbType.VarChar,1000),
        //                                new SqlParameter("@fldName",SqlDbType.VarChar,50),
        //                                new SqlParameter("@doCount",SqlDbType.Bit),
        //                                new SqlParameter("@OrderType",SqlDbType.Bit),
        //                                new SqlParameter("@strWhere",SqlDbType.VarChar,1500),
        //                                new SqlParameter("@keywords",SqlDbType.VarChar,500),
        //                                new SqlParameter("@datee",SqlDbType.SmallDateTime)
        //                                //new SqlParameter("@PageSize",SqlDbType.Int),
        //                                //new SqlParameter("@PageIndex",SqlDbType.Int),
        //                           };
        //    param2[0].Value = "newscon";
        //    param2[1].Value = "[caption],[title],[datee],[id],[counter],[author],[editor],[sdut],[sdutpic],[zixun],[yaowen],[tuwen],[auditing],[editing],[forbiden]";
        //    param2[2].Value = "datee";
        //    param2[3].Value = 1;
        //    param2[4].Value = 1;
        //    param2[5].Value = Where;
        //    param2[6].Value = keywords;
        //    param2[7].Value = date;
        //    //param2[3].Value = PageSize;
        //    //param2[4].Value = Page;
        //    PageCount = (int)ProcCommander.RunProcedureScalar("GetInfoByKeywords", param2);
        //    return List;
        //}
        /// <summary>
        /// 新闻列表
        /// </summary>
        /// <param name="PageSize"></param>
        /// <param name="Page"></param>
        /// <param name="Where"></param>
        /// <param name="ORDERBY">排序字段</param>
        /// <param name="DESC">“1”表示降序</param>
        /// <param name="PageCount"></param>
        /// <returns></returns>
        public IList<Content> GetList(int PageSize, int Page, string Where, string ORDERBY, bool DESC, out int PageCount)
        {
            IList<Content> List = new List<Content>();
            SqlParameter[] param = {
                                        new SqlParameter("@tbName",SqlDbType.VarChar,50),
                                        new SqlParameter("@strGetItem",SqlDbType.VarChar,1000),
                                        new SqlParameter("@fldName",SqlDbType.VarChar,50),
                                        new SqlParameter("@PageSize",SqlDbType.Int),
                                        new SqlParameter("@PageIndex",SqlDbType.Int),
                                        new SqlParameter("@doCount",SqlDbType.Bit),
                                        new SqlParameter("@OrderType",SqlDbType.Bit),
                                        new SqlParameter("@strWhere",SqlDbType.VarChar,1500)
                                   };
            param[0].Value = "newscon";
            param[1].Value = "[id],[caption],[title],[subtitle],[datee],[counter],[content],[auditing],[hot] ,[author],[fro],[editor],[remark],[tel] ,[url],[yaowen],[tuwen],[sdut],[sdutpic]  ,[zixun],[ztid],[zt],[html],[smallpic],[editing],[keywords],[forbiden],[StateNow]";
            param[2].Value = ORDERBY;
            param[3].Value = PageSize;
            param[4].Value = Page;
            param[5].Value = 0;
            param[6].Value = Convert.ToByte(DESC);
            param[7].Value = Where;

            using (SqlDataReader dr = ProcCommander.RunProcedure("GetInfoByPage", param))
            {
                while (dr.Read())
                {
                    List.Add(Transform.ToContentList(dr));
                }
                dr.Close();//zgy
            }

            SqlParameter[] param2 = {
                                        new SqlParameter("@tbName",SqlDbType.VarChar,50),
                                        new SqlParameter("@strGetItem",SqlDbType.VarChar,1000),
                                        new SqlParameter("@fldName",SqlDbType.VarChar,50),
                                        new SqlParameter("@PageSize",SqlDbType.Int),
                                        new SqlParameter("@PageIndex",SqlDbType.Int),
                                        new SqlParameter("@doCount",SqlDbType.Bit),
                                        new SqlParameter("@OrderType",SqlDbType.Bit),
                                        new SqlParameter("@strWhere",SqlDbType.VarChar,1500)
                                   };
            param2[0].Value = "newscon";
            param2[1].Value = "[caption],[title],[datee],[id],[counter],[author],[editor],[sdut],[sdutpic] ,[zixun],[yaowen],[tuwen],[auditing],[editing],[forbiden]";
            param2[2].Value = ORDERBY;
            param2[3].Value = PageSize;
            param2[4].Value = Page;
            param2[5].Value = 1;
            param2[6].Value = Convert.ToByte(DESC);
            param2[7].Value = Where;
            PageCount = (int)ProcCommander.RunProcedureScalar("GetInfoByPage", param2);
            return List;
        }
        #endregion
    }
}
