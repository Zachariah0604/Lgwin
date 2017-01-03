using System;
using System.Collections.Generic;
using Lgwin.Model;
using System.Data;

namespace Lgwin.IDAL
{
    public interface IKarat
    {
        bool KaratDelete(int id, string tablename);

        bool KaratMessageAdd(Karat Model);

       

        bool ArticleAdd(Karat Mod);

        bool ArticleUpdate(Karat Mod);

        bool EventsUpdate(Karat Mod);

        bool EventsAdd(Karat Mod);

        bool MessageReply(Karat Model);

        bool FrontMessageReply(Karat Model);
        bool GetZ(Karat Model);
        Karat SelectModel(int id);

        DataTable SelectAll();

        DataTable SelectByLanmu(string tablename, string where);

        bool WorkAdd(Karat Mod);

        bool WorkUpdate(Karat Mod);

        bool MembersAdd(Karat Mod);

        DataTable MembersSelectById(int id);

        DataTable MembersSelectAll();

        DataTable MembersSelectByYear(string year);

        Karat MenbersContentGetById(int Id);

        Karatbaoming BaomingGetById(int Id);

        bool MembersUpdate(Karat Mod);

        DataTable BaomingSelectAll();


        #region 卡瑞特
        IList<Karat> KaratGetList(string Caption, int PageSize, int Page, string Where, out int PageCount, int order, string tablename);
        Karat GetKaratArticle(int Id);
        Karat GetWorkContent(int Id);
        Karat GetEventsArticle(int Id);
        Karat GetMenbers(int Id);
        #endregion
        bool Karat_Baoming(Karatbaoming Mod);
        bool Karat_BaomingT(Karatbaoming Mod);//2012
        bool CultruelUpdade(string title, string content);

        string sdrcontent(string where);
    }
}
