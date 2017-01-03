using System;
using System.Collections.Generic;
using Lgwin.IDAL;
using Lgwin.DALFactory;
using Lgwin.Model;
using System.Data;

namespace Lgwin.BLL
{
    public class KaratBLL
    {

        private static readonly IKarat dal = DataAccess.CreatKarat();

        public bool KaratDelete(int id, string tablename)
        {
            return dal.KaratDelete(id, tablename);
        }

        public bool ArticleAdd(Karat Mod)
        {
            return dal.ArticleAdd(Mod);
        }

        public bool ArticleUpdate(Karat Mod)
        {
            return dal.ArticleUpdate(Mod);
        }

        public bool EventsUpdate(Karat Mod)
        {
            return dal.EventsUpdate(Mod);
        }

        public bool EventsAdd(Karat Mod)
        {
            return dal.EventsAdd(Mod);
        }

        public bool MessageReply(Karat Model)
        {
            return dal.MessageReply(Model);
        }
        public bool FrontMessageReply(Karat Model)
        {
            return dal.FrontMessageReply(Model);
        }
        public bool GetZ(Karat Model)
        {
            return dal.GetZ(Model);
        }
        public Karat SelectModel(int id)
        {
            return dal.SelectModel(id);
        }

        public DataTable SelectAll()
        {
            return dal.SelectAll();
        }

        public DataTable SelectByLanmu(string tablename, string where)
        {
            return dal.SelectByLanmu(tablename, where);
        }



        public bool WorkAdd(Karat Mod)
        {
            return dal.WorkAdd(Mod);
        }

        public bool WorkUpdate(Karat Mod)
        {
            return dal.WorkUpdate(Mod);
        }


        public bool MembersAdd(Karat Mod)
        {
            return dal.MembersAdd(Mod);
        }

        public DataTable MembersSelectById(int id)
        {
            return dal.MembersSelectById(id);
        }

        public DataTable MembersSelectAll()
        {
            return dal.MembersSelectAll();
        }

        public DataTable MembersSelectByYear(string year)
        {
            return dal.MembersSelectByYear(year);
        }

        public Karat MenbersContentGetById(int id)
        {
            return dal.MenbersContentGetById(id);
        }

        public Karatbaoming BaomingGetById(int Id)
        {
            return dal.BaomingGetById(Id);
        }

        public bool MembersUpdate(Karat Mod)
        {
            return dal.MembersUpdate(Mod);
        }

        public DataTable BaomingSelectAll()
        {
            return dal.BaomingSelectAll();
        }

        #region 卡瑞特

        public IList<Karat> KaratGetList(string Caption, int PageSize, int Page, string Where, out int Count, int order, string tablename)
        {
            IList<Karat> list = new List<Karat>();
            list = dal.KaratGetList(Caption, PageSize, Page, Where, out Count, order, tablename);
            return list;
        }

        public Karat GetKaratArticle(int Id)
        {
            return dal.GetKaratArticle(Id);
        }

        public Karat GetWorkContent(int Id)
        {
            return dal.GetWorkContent(Id);
        }

        public Karat GetEventsArticle(int Id)
        {
            return dal.GetEventsArticle(Id);
        }

        public Karat GetMenbers(int Id)
        {
            return dal.GetMenbers(Id);
        }

        #endregion

        public bool Karat_BaomingT(Karatbaoming Mod)
        {
            return dal.Karat_BaomingT(Mod);
        }
        public bool Karat_Baoming(Karatbaoming Mod)
        {
            return dal.Karat_Baoming(Mod);
        }
        #region 团队文化

        public bool CultruelUpdade(string title, string content)
        {
            return dal.CultruelUpdade(title, content);
        }

        public string sdrcontent(string where)
        {
            return dal.sdrcontent(where);
        }
        #endregion
    }
}
