using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lgwin.Model;
using Lgwin.DBUtility;
using System.Data;
using System.Data.SqlClient;
using Lgwin.IDAL;

namespace Lgwin.SqlDAL
{
    public class KaratDAL : IKarat
    {
        //static string conn = System.Configuration.ConfigurationManager.ConnectionStrings["connStr"].ToString();

        public bool KaratDelete(int id, string tablename)//
        {
            SqlParameter[] param = {
                                    new SqlParameter("@id",SqlDbType.Int),
                                    new SqlParameter("@table",SqlDbType.VarChar,50)
                                   
                                   };
            param[0].Value = id;
            param[1].Value = tablename;

            int rowAffect;
            ProcCommander.RunProcedure("KaratDelete", param, out rowAffect);
            return (rowAffect > 0);
        }

        public bool KaratMessageAdd(Karat Model)
        {
            SqlParameter[] param = {
                                    new SqlParameter("@name",SqlDbType.VarChar,10),
                                    new SqlParameter("@topic",SqlDbType.VarChar,40),
                                    new SqlParameter("@e_mail",SqlDbType.VarChar,20),
                                    new SqlParameter("@m_nr",SqlDbType.VarChar),
                                    new SqlParameter("@m_time",SqlDbType.DateTime),
                                    new SqlParameter("@r_time",SqlDbType.DateTime),
                                    new SqlParameter("@r_nr",SqlDbType.VarChar),
                                    new SqlParameter("@pass",SqlDbType.Bit),
                                    new SqlParameter("@ip",SqlDbType.VarChar)
                               
                                   };
            param[0].Value = Model.Name;
            param[1].Value = Model.Topic;
            param[2].Value = Model.Email;
            param[3].Value = Model.M_Content;
            param[4].Value = Model.M_time;
            param[5].Value = Model.R_time;
            param[6].Value = Model.R_Content;
            param[7].Value = Model.Pass;
            param[8].Value = Model.Ip;

            int rowAffect;
            ProcCommander.RunProcedure("KaratMessage_Add", param, out rowAffect);
            return (rowAffect > 0);
        }

        public bool ArticleAdd(Karat Mod)
        {
            SqlParameter[] param = {
                                    new SqlParameter("@title",SqlDbType.VarChar,200),
                                    new SqlParameter("@subtitle",SqlDbType.VarChar,40),
                                    new SqlParameter("@lanmu",SqlDbType.VarChar,10),
                                    new SqlParameter("@url",SqlDbType.VarChar,100),
                                    new SqlParameter("@time",SqlDbType.DateTime),
                                    new SqlParameter("@author",SqlDbType.VarChar,10),
                                    new SqlParameter("@content",SqlDbType.VarChar,-1),
                                    new SqlParameter("@pass",SqlDbType.Bit),
                                     new SqlParameter("@indexComment",SqlDbType.Bit),
                               
                                   };
            param[0].Value = Mod.Title;
            param[1].Value = Mod.SubTitle;
            param[2].Value = Mod.LanMu;
            param[3].Value = Mod.Url;
            param[4].Value = Mod.Time;
            param[5].Value = Mod.Author;
            param[6].Value = Mod.Content;
            param[7].Value = Mod.Pass;
            param[8].Value = Mod.IndexComment;
            int rowAffect;
            ProcCommander.RunProcedure("Karat_ArticleAdd", param, out rowAffect);
            return (rowAffect > 0);
        }

        public bool ArticleUpdate(Karat Mod)
        {
            SqlParameter[] param = {
                                       
                                    new SqlParameter("@title",SqlDbType.VarChar,200),
                                    new SqlParameter("@subtitle",SqlDbType.VarChar,40),
                                    new SqlParameter("@lanmu",SqlDbType.VarChar,10),
                                    new SqlParameter("@url",SqlDbType.VarChar,100),
                                    new SqlParameter("@time",SqlDbType.DateTime),
                                    new SqlParameter("@author",SqlDbType.VarChar,10),
                                    new SqlParameter("@content",SqlDbType.VarChar,-1),
                                    new SqlParameter("@pass",SqlDbType.Bit),
                                     new SqlParameter("@indexComment",SqlDbType.Bit),
                                     new SqlParameter("@id",SqlDbType.Int)
                               
                                   };
            param[0].Value = Mod.Title;
            param[1].Value = Mod.SubTitle;
            param[2].Value = Mod.LanMu;
            param[3].Value = Mod.Url;
            param[4].Value = Mod.Time;
            param[5].Value = Mod.Author;
            param[6].Value = Mod.Content;
            param[7].Value = Mod.Pass;
            param[8].Value = Mod.IndexComment;
            param[9].Value = Mod.Id;
            int rowAffect;
            ProcCommander.RunProcedure("Karat_ArticleUpdate", param, out rowAffect);
            return (rowAffect > 0);
        }

        public bool EventsUpdate(Karat Mod)
        {
            SqlParameter[] param = {
                                       new SqlParameter("@id",SqlDbType.Int),
                                       new SqlParameter("@from_year",SqlDbType.VarChar,50),
                                       new SqlParameter("@from_content",SqlDbType.VarChar),
                                       new SqlParameter("@url",SqlDbType.VarChar,100)
                                   };
            param[0].Value = Mod.Id;
            param[1].Value = Mod.From_Year;
            param[2].Value = Mod.From_Content;
            param[3].Value = Mod.Url;
           
            int rowAffect;
            ProcCommander.RunProcedure("Karat_EventsUpdate", param, out rowAffect);
            return (rowAffect > 0);
        }

        public bool EventsAdd(Karat Mod)
        {
            SqlParameter[] param = {
                      
                                       new SqlParameter("@from_year",SqlDbType.VarChar,50),
                                       new SqlParameter("@from_content",SqlDbType.VarChar),
                                       new SqlParameter("@url",SqlDbType.VarChar,100)
                                   };

            param[0].Value = Mod.From_Year;
            param[1].Value = Mod.From_Content;
            param[2].Value = Mod.Url;
          
            int rowAffect;
            ProcCommander.RunProcedure("Karat_EventsAdd", param, out rowAffect);
            return (rowAffect > 0);
        }

        public bool MessageReply(Karat Model)
        {
            SqlParameter[] param = {
                               
                                    new SqlParameter("@auditor",SqlDbType.VarChar,10),
                                    new SqlParameter("@r_time",SqlDbType.DateTime),
                                    new SqlParameter("@r_nr",SqlDbType.VarChar),
                                    new SqlParameter("@pass",SqlDbType.Bit),
                                    new SqlParameter("@id",SqlDbType.Int)
                               
                                   };
            param[0].Value = Model.Auditor;

            param[1].Value = Model.R_time;
            param[2].Value = Model.R_Content;
            param[3].Value = Model.Pass;
            param[4].Value = Model.Id;

            int rowAffect;
            ProcCommander.RunProcedure("KaratMessage_Reply", param, out rowAffect);
            return (rowAffect > 0);
        }
        public bool FrontMessageReply(Karat Model)
        {
            SqlParameter[] param = {
                                     new SqlParameter("@LeftWordID",SqlDbType.Int),
                                    new SqlParameter("@UserID",SqlDbType.VarChar,100),
                                    new SqlParameter("@ReplyTime",SqlDbType.DateTime),
                                    new SqlParameter("@ReplyMessage",SqlDbType.VarChar)
                                   
                               
                                   };
            param[0].Value = Model.Id;
            param[1].Value = Model.Ip;
            param[2].Value = Model.R_time;
            param[3].Value = Model.R_Content;
            

            int rowAffect;
            ProcCommander.RunProcedure("Front_Karat_Message_Reply", param, out rowAffect);
            return (rowAffect > 0);
        }
        public bool GetZ(Karat Model)
        {
            SqlParameter[] param = {
                                       new SqlParameter("@iid",SqlDbType.Int),
                                     new SqlParameter("@Zan",SqlDbType.VarChar,50)
                                   
                               
                                   };
            param[0].Value = Model.Id;
            param[1].Value = Model.Zan;
      


            int rowAffect;
            ProcCommander.RunProcedure("Karat_GetZan", param, out rowAffect);
            return (rowAffect > 0);
        }
        public Karat SelectModel(int id)
        {
            string where = "id=" + id; ;
            string ziduan = "";
            Karat mod = new Karat();
            SqlParameter[] param = {
                                    new SqlParameter("@table",SqlDbType.VarChar,50),
                                    new SqlParameter("@where",SqlDbType.VarChar,1500),
                                    new SqlParameter("@ziduan",SqlDbType.VarChar,500)
                                   };
            param[0].Value = "Karat_message";
            param[1].Value = where;
            param[2].Value = ziduan;


            SqlDataReader sdr = ProcCommander.RunProcedure("Karat_Select", param);
            if (sdr.Read())
            {
                mod.Name = sdr["name"].ToString();
                mod.Topic = sdr["topic"].ToString();
                mod.M_time = Convert.ToDateTime(sdr["m_time"]);
                mod.M_Content = sdr["m_nr"].ToString();
                mod.Pass = Convert.ToBoolean(sdr["pass"]);
                mod.Email = sdr["e_mail"].ToString();
                mod.R_Content = sdr["r_nr"].ToString();
                mod.R_time = Convert.ToDateTime(sdr["r_time"]);
                mod.Auditor = sdr["auditor"].ToString();
                mod.Ip = sdr["ip"].ToString();
            }
            sdr.Close();
            return mod;
        }

        public DataTable SelectAll()
        {
            string where = "";
            string ziduan = "";
            SqlParameter[] param = {
                                    new SqlParameter("@table",SqlDbType.VarChar,50),
                                    new SqlParameter("@where",SqlDbType.VarChar,1500),
                                    new SqlParameter("@ziduan",SqlDbType.VarChar,500)
                                   };

            param[0].Value = "Karat_message";
            param[1].Value = where;
            param[2].Value = ziduan;
            SqlDataReader sdr = ProcCommander.RunProcedure("Karat_Select", param);
            DataTable dt = new DataTable();
            dt.Load(sdr);
            sdr.Close();
            return dt;
        }

        public DataTable SelectByLanmu(string tablename, string where)
        {

            string ziduan = "";
            SqlParameter[] param = {
                                    new SqlParameter("@table",SqlDbType.VarChar,50),
                                    new SqlParameter("@where",SqlDbType.VarChar,1500),
                                    new SqlParameter("@ziduan",SqlDbType.VarChar,500)
                                   };

            param[0].Value = tablename;
            param[1].Value = where;
            param[2].Value = ziduan;
            SqlDataReader sdr = ProcCommander.RunProcedure("Karat_Select", param);
            DataTable dt = new DataTable();
            dt.Load(sdr);
            sdr.Close();
            return dt;
        }

        public bool CultruelUpdade(string title, string content)
        {

            SqlParameter[] param = {
                                    new SqlParameter("@title",SqlDbType.VarChar,100),
                                    new SqlParameter("@content",SqlDbType.VarChar),     
                                        new SqlParameter("@lanmu",SqlDbType.VarChar,100)
                                   };
            param[0].Value = title;
            param[1].Value = content;
            param[2].Value = "团队文化";
            int rowAffect;
            ProcCommander.RunProcedure("Karat_CultruelUpdate", param, out rowAffect);
            return (rowAffect > 0);

        }

        public bool WorkAdd(Karat Mod)
        {
            SqlParameter[] param = {
                                    new SqlParameter("@name",SqlDbType.VarChar,50),
                                    new SqlParameter("@type",SqlDbType.VarChar,40),
                                    new SqlParameter("@tool",SqlDbType.VarChar,300),
                                    new SqlParameter("@href",SqlDbType.VarChar,100),
                                    new SqlParameter("@time",SqlDbType.DateTime),
                                    new SqlParameter("@imgurl",SqlDbType.VarChar,100)                               
                                   };
            param[0].Value = Mod.Name;
            param[1].Value = Mod.Type;
            param[2].Value = Mod.Tool;
            param[3].Value = Mod.Href;
            param[4].Value = Mod.Time;
            param[5].Value = Mod.Imgurl;
            int rowAffect;
            ProcCommander.RunProcedure("Karat_WorkAdd", param, out rowAffect);
            return (rowAffect > 0);
        }

        public bool WorkUpdate(Karat Mod)
        {
            SqlParameter[] param = {

                                    new SqlParameter("@name",SqlDbType.VarChar,50),
                                    new SqlParameter("@type",SqlDbType.VarChar,40),
                                    new SqlParameter("@tool",SqlDbType.VarChar,300),
                                    new SqlParameter("@href",SqlDbType.VarChar,100),
                                    new SqlParameter("@time",SqlDbType.DateTime),
                                    new SqlParameter("@imgurl",SqlDbType.VarChar,100),
                                    new SqlParameter("@id",SqlDbType.Int)
                                   };
            param[0].Value = Mod.Name;
            param[1].Value = Mod.Type;
            param[2].Value = Mod.Tool;
            param[3].Value = Mod.Href;
            param[4].Value = Mod.Time;
            param[5].Value = Mod.Imgurl;
            param[6].Value = Mod.Id;
            int rowAffect;
            ProcCommander.RunProcedure("Karat_WorkUpdate", param, out rowAffect);
            return (rowAffect > 0);
        }

        //成员增加
        public bool MembersAdd(Karat Mod)
        {
            SqlParameter[] param = {
                      
                                       new SqlParameter("@name",SqlDbType.VarChar,15),
                                       new SqlParameter("@bumen",SqlDbType.VarChar,15),
                                       new SqlParameter("@zaizhi",SqlDbType.Bit),
                                     new SqlParameter("@zhiwu",SqlDbType.VarChar,15),
                                       new SqlParameter("@qq",SqlDbType.VarChar,50),
                                       new SqlParameter("@email",SqlDbType.VarChar,50),
                                     new SqlParameter("@tel",SqlDbType.VarChar,50),
                                       new SqlParameter("@yuanxi",SqlDbType.VarChar,50),
                                       new SqlParameter("@imgurl",SqlDbType.VarChar,200),
                                      new SqlParameter("@beizhu",SqlDbType.VarChar,200),
                                      new SqlParameter("@year",SqlDbType.VarChar,50)
                            
                                   };

            param[0].Value = Mod.Name;
            param[1].Value = Mod.Bumen;
            param[2].Value = Mod.Zaizhi;
            param[3].Value = Mod.Zhiwu;
            param[4].Value = Mod.Qq; ;
            param[5].Value = Mod.Email;
            param[6].Value = Mod.Tel;
            param[7].Value = Mod.Yuanxi;
            param[8].Value = Mod.Imgurl;
            param[9].Value = Mod.Beizhu;
            param[10].Value = Mod.Year;
            int rowAffect;
            ProcCommander.RunProcedure("Karat_MemberAdd", param, out rowAffect);
            return (rowAffect > 0);

        }
        //成员按ID查询
        public DataTable MembersSelectById(int id)
        {
            string ziduan = "";
            SqlParameter[] param = {
                                    new SqlParameter("@table",SqlDbType.VarChar,50),
                                    new SqlParameter("@where",SqlDbType.VarChar,1500),
                                    new SqlParameter("@ziduan",SqlDbType.VarChar,500)
                                   };

            param[0].Value = "Karat_members";
            param[1].Value = "id=" + id;
            param[2].Value = ziduan;

            SqlDataReader sdr = ProcCommander.RunProcedure("Karat_Select", param);
            DataTable dt = new DataTable();
            dt.Load(sdr);
            sdr.Close();
            return dt;
        }
        //成员查询（所有的）
        public DataTable MembersSelectAll()
        {


            SqlParameter[] param = {
                                    new SqlParameter("@table",SqlDbType.VarChar,50),
                                    new SqlParameter("@where",SqlDbType.VarChar,1500),
                                    new SqlParameter("@ziduan",SqlDbType.VarChar,500)
                                   };

            param[0].Value = "Karat_members";
            param[1].Value = "";
            param[2].Value = "";
            SqlDataReader sdr = ProcCommander.RunProcedure("Karat_Select", param);
            DataTable dt = new DataTable();
            dt.Load(sdr);
            sdr.Close();
            return dt;
        }
        //第几届成员查询
        public DataTable MembersSelectByYear(string year)
        {
            string ziduan = "";
            SqlParameter[] param = {
                                    new SqlParameter("@table",SqlDbType.VarChar,50),
                                    new SqlParameter("@where",SqlDbType.VarChar,1500),
                                    new SqlParameter("@ziduan",SqlDbType.VarChar,500)
                                   };

            param[0].Value = "Karat_members";
            param[1].Value = "year=" + year;
            param[2].Value = ziduan;

            SqlDataReader sdr = ProcCommander.RunProcedure("Karat_Select", param);
            DataTable dt = new DataTable();
            dt.Load(sdr);
            sdr.Close();
            return dt;
        }
        //获取成员内容
        public Karat MenbersContentGetById(int Id)
        {
            SqlParameter[] param = {
                                        new SqlParameter("@Id",SqlDbType.Int)
                                   };
            param[0].Value = Id;
            using (SqlDataReader dr = ProcCommander.RunProcedure("KaratMembers_selectById", param))
            {
                try
                {
                    if (dr.Read())
                        return Transform.ToKaratMemberContent(dr);
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

        public Karatbaoming BaomingGetById(int Id)
        {
            SqlParameter[] param = {
                                        new SqlParameter("@Id",SqlDbType.Int)
                                   };
            param[0].Value = Id;
            using (SqlDataReader dr = ProcCommander.RunProcedure("Karat_BaomingGetById", param))
            {
                try
                {
                    if (dr.Read())
                        return Transform.ToKaratBaoMing(dr);
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
        //成员更新
        public bool MembersUpdate(Karat Mod)
        {
            SqlParameter[] param = {
                                        
                                       new SqlParameter("@name",SqlDbType.VarChar,15),
                                       new SqlParameter("@bumen",SqlDbType.VarChar,15),
                                       new SqlParameter("@zaizhi",SqlDbType.Bit),
                                     new SqlParameter("@zhiwu",SqlDbType.VarChar,15),
                                       new SqlParameter("@qq",SqlDbType.VarChar,50),
                                       new SqlParameter("@email",SqlDbType.VarChar,50),
                                     new SqlParameter("@tel",SqlDbType.VarChar,50),
                                       new SqlParameter("@yuanxi",SqlDbType.VarChar,50),
                                       new SqlParameter("@imgurl",SqlDbType.VarChar,200),
                                      new SqlParameter("@beizhu",SqlDbType.VarChar,200),
                                      new SqlParameter("@year",SqlDbType.VarChar,50),
                                         new SqlParameter("@id",SqlDbType.Int)
                                   };

            param[0].Value = Mod.Name;
            param[1].Value = Mod.Bumen;
            param[2].Value = Mod.Zaizhi;
            param[3].Value = Mod.Zhiwu;
            param[4].Value = Mod.Qq; ;
            param[5].Value = Mod.Email;
            param[6].Value = Mod.Tel;
            param[7].Value = Mod.Yuanxi;
            param[8].Value = Mod.Imgurl;
            param[9].Value = Mod.Beizhu;
            param[10].Value = Mod.Year;
            param[11].Value = Mod.Id;
            int rowAffect;
            ProcCommander.RunProcedure("Karat_MemberUpdate", param, out rowAffect);
            return (rowAffect > 0);

        }
        //
        #region 卡瑞特列表

        public IList<Karat> KaratGetList(string Lanmu, int PageSize, int Page, string Where, out int PageCount, int order, string tablename)
        {
            if (Lanmu != "")
            {
                Where = "and " + Where;
            }
            IList<Karat> List = new List<Karat>();
            SqlParameter[] param = {
                                        new SqlParameter("@tbName",SqlDbType.VarChar,50),//表名
                                        new SqlParameter("@strGetItem",SqlDbType.VarChar,1000),//返回的字段
                                        new SqlParameter("@fldName",SqlDbType.VarChar,50),//fldname排序字段
                                        new SqlParameter("@PageSize",SqlDbType.Int),//分页数据大小
                                        new SqlParameter("@PageIndex",SqlDbType.Int),//分页索引
                                        new SqlParameter("@doCount",SqlDbType.Bit),//返回记录总数，0不返回
                                        new SqlParameter("@OrderType",SqlDbType.Bit),//排序类型，0升序，非零降序
                                        new SqlParameter("@strWhere",SqlDbType.VarChar,1500)
                                   };
            param[0].Value = tablename;
            switch (tablename)
            {
                case "Karat_Content": param[1].Value = "[id],[lanmu],[Title],[SubTitle],[url],[Time],[Content],[imgurl],[author]"; break;
                case "Karat_message": param[1].Value = "[id],[name],[topic],[m_time],[m_nr],[r_time],[r_nr]"; break;
                case "Karat_Events": param[1].Value = "[id],[From_Year],[From_Content],[url]"; break;
                case "Karat_Work": param[1].Value = "[id],[Name],[Type],[Time],[Tool],[Href],[Url],[imgurl]"; break;
                case "Karat_members": param[1].Value = "[id],[name],[bumen],[zhiwu],[qq],[tel],[email],[year],[yuanxi],[zaizhi],[beizhu],[imgurl]"; break;
            }
            param[2].Value = "id";
            param[3].Value = PageSize;
            param[4].Value = Page;
            param[5].Value = 0;
            param[6].Value = 2;
            switch (tablename)
            {
                case "Karat_Content": param[7].Value = "([lanmu] ='" + Lanmu + "')" + Where; break;
                case "Karat_message": param[7].Value = Where; break;
                case "Karat_Events": param[7].Value = Where; break;
                case "Karat_Work": param[7].Value = Where; break;
                case "Karat_members": param[7].Value = Where; break;

            }
            using (SqlDataReader sdr = ProcCommander.RunProcedure("GetInfoByPage", param))
            {
                while (sdr.Read())
                {
                    List.Add(Transform.ToKaratList(sdr, tablename));
                }
                sdr.Close();
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
            param2[0].Value = tablename;
            switch (tablename)
            {
                case "Karat_Content": param2[1].Value = "[lanmu],[Title],[id]"; break;
                case "Karat_message": param2[1].Value = "[id],[name],[topic]"; break;
                case "Karat_Events": param[1].Value = "[id],[From_Year],[From_Content]"; break;
                case "Karat_Work": param[1].Value = "[id],[Name],[Type],[Time],[Tool],[Href],[Url],[imgurl]"; break;
                case "Karat_members": param[1].Value = "[id],[name]"; break;

            }
            param2[2].Value = "id";
            param2[3].Value = PageSize;
            param2[4].Value = Page;
            param2[5].Value = 1;
            param2[6].Value = 1;
            switch (tablename)
            {
                case "Karat_Content": param2[7].Value = "([lanmu] ='" + Lanmu + "')" + Where; break;
                case "Karat_message": param2[7].Value = Where; break;
                case "Karat_Events": param[7].Value = Where; break;
                case "Karat_Work": param[7].Value = Where; break;
                case "Karat_members": param[7].Value = Where; break;
            }
            PageCount = (int)ProcCommander.RunProcedureScalar("GetInfoByPage", param2);
            return List;
        }
        //public static List<Karat> GetGuestBooks()
        //{
        //    List<Karat> message = new List<Karat>();
        //    string cmdStr = "select l.id,l.name,l.topic,l.m_time,l.m_nr,l.r_time,l.ip ";
        //    cmdStr += "from Karat_message l";
        //    cmdStr += "order by m_time desc";

        //   // SqlConnection conn = DataClass.OpenConn(DataClass.connStr);

        //   // SqlCommand cmd = new SqlCommand(cmdStr, conn);

        //    using (SqlDataReader dr = cmd.ExecuteReader())
        //    {
        //        while (dr.Read())
        //        {
        //            Karat b = new Karat();
        //            b.id = Convert.ToUInt32(dr["GuestBookID"]);
        //            b.name = Convert.ToUInt32(dr["UserID"]);
        //            b.M_time = dr["UserName"].ToString();
        //            b.Face = "images/users/" + dr["Face"].ToString();
        //            b.Subject = dr["Subject"].ToString();
        //            b.M_Content = dr["Message"].ToString();
        //            b.R_time = Convert.ToDateTime(dr["Time"]);

        //            books.Add(b);
        //        }
        //    }

        //    return books;
        //}
        public Karat GetKaratArticle(int Id)
        {
            SqlParameter[] param = {
                                        new SqlParameter("@Id",SqlDbType.Int)
                                   };
            param[0].Value = Id;
            using (SqlDataReader dr = ProcCommander.RunProcedure("KaratContent_GetInfo", param))
            {
                try
                {
                    if (dr.Read())
                        return Transform.ToKaratContentList(dr);
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

        public Karat GetEventsArticle(int Id)
        {
            SqlParameter[] param = {
                                        new SqlParameter("@Id",SqlDbType.Int)
                                   };
            param[0].Value = Id;
            using (SqlDataReader dr = ProcCommander.RunProcedure("KaratEvents_GetInfo", param))
            {
                try
                {
                    if (dr.Read())
                        return Transform.ToKaratEventsList(dr);
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

        public Karat GetWorkContent(int Id)
        {
            SqlParameter[] param = {
                                        new SqlParameter("@Id",SqlDbType.Int)
                                   };
            param[0].Value = Id;
            using (SqlDataReader dr = ProcCommander.RunProcedure("KaratWork_GetInfo", param))
            {
                try
                {
                    if (dr.Read())
                        return Transform.ToKaratWorkList(dr);
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

        public Karat GetMenbers(int Id)
        {
            SqlParameter[] param = {
                                        new SqlParameter("@Id",SqlDbType.Int)
                                   };
            param[0].Value = Id;
            using (SqlDataReader dr = ProcCommander.RunProcedure("KaratMembers_selectList", param))
            {
                try
                {
                    if (dr.Read())
                        return Transform.ToKaratMemberList(dr);
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

        public bool Karat_BaomingT(Karatbaoming Mod)
        {
            SqlParameter[] param = {
                                    new SqlParameter("@name",SqlDbType.VarChar,50),
                                    new SqlParameter("@sex",SqlDbType.VarChar,10),
                                    new SqlParameter("@xueyuan",SqlDbType.VarChar,50),
                                    new SqlParameter("@banji",SqlDbType.VarChar,50),
                                    new SqlParameter("@xiaoqu",SqlDbType.VarChar,50),
                                    new SqlParameter("@diannao",SqlDbType.VarChar,10),
                                    new SqlParameter("@email",SqlDbType.VarChar,50),
                                    new SqlParameter("@zhiwei",SqlDbType.VarChar,20),
                                   new SqlParameter("@blog",SqlDbType.VarChar,50),
                                    new SqlParameter("@zuopin",SqlDbType.VarChar,50),
                                    new SqlParameter("@tel",SqlDbType.VarChar,50),
                                    new SqlParameter("@jianjie",SqlDbType.VarChar),
                                    new SqlParameter("@touxiang",SqlDbType.VarChar,250),
                                    new SqlParameter("@her",SqlDbType.VarChar,100),
                                    
                                    new SqlParameter("@worktime",SqlDbType.VarChar,50),
                                    new SqlParameter("@renzhi",SqlDbType.VarChar,200),
                                    new SqlParameter("@qq",SqlDbType.VarChar,50),
                                    new SqlParameter("@qita",SqlDbType.VarChar,200),
                                    new SqlParameter("@jingli",SqlDbType.VarChar,4000),
                                     new SqlParameter("@ip",SqlDbType.VarChar,500),
                                     new SqlParameter("@hostname",SqlDbType.VarChar,500),
                                     new SqlParameter("@club_exp",SqlDbType.NText),
                                     new SqlParameter("@org_exp",SqlDbType.NText),
                                     new SqlParameter("@get_award",SqlDbType.VarChar,255),
                                     new SqlParameter("@grade",SqlDbType.VarChar,10),
                                     new SqlParameter("@freetime",SqlDbType.VarChar,50),
                                      new SqlParameter("@write_able",SqlDbType.VarChar,10),
                                      new SqlParameter("@kaoyan",SqlDbType.VarChar,20)
                                    
                                   };
    //        @club_exp,
    //@org_exp,
    //@get_award,
    //@write_able,
    //@grade,
    //@freetime,
    //@worktime 
            param[0].Value = Mod.Name;
            param[1].Value = Mod.Sex;
            param[2].Value = Mod.Xueyuan;
            param[3].Value = Mod.Banji;
            param[4].Value = Mod.Xiaoqu;
            param[5].Value = Mod.Diannao;
            param[6].Value = Mod.Email;
            param[7].Value = Mod.Zhiwei;
            param[8].Value = Mod.Blog;
            param[9].Value = Mod.Zuopin;
            param[10].Value = Mod.Tel;
            param[11].Value = Mod.Jianjie;
            param[12].Value = Mod.Touxiang;
            param[13].Value = Mod.Her;

            param[14].Value = Mod.work_time;
            param[15].Value = Mod.Renzhi;
            param[16].Value = Mod.Qq;
            param[17].Value = Mod.Qita;
            param[18].Value = Mod.Jingli;
            param[19].Value = Mod.Ip;
            param[20].Value = Mod.HostName;
            param[21].Value = Mod.club_exp;
            param[22].Value = Mod.orge_exp;
            param[23].Value = Mod.get_award;
            param[24].Value = Mod.grade;
            param[25].Value = Mod.freetime;
            param[26].Value = Mod.write_able;
            param[27].Value = Mod.Kaoyan;
            int rowAffect;
            ProcCommander.RunProcedure("Karat_BaomingAddT", param, out rowAffect);
            return (rowAffect > 0);
        }
        public bool Karat_Baoming(Karatbaoming Mod)
        {
            SqlParameter[] param = {
                                    new SqlParameter("@name",SqlDbType.VarChar,50),
                                    new SqlParameter("@sex",SqlDbType.VarChar,10),
                                    new SqlParameter("@xueyuan",SqlDbType.VarChar,50),
                                    new SqlParameter("@banji",SqlDbType.VarChar,50),
                                    new SqlParameter("@xiaoqu",SqlDbType.VarChar,50),
                                    new SqlParameter("@diannao",SqlDbType.VarChar,10),
                                    new SqlParameter("@email",SqlDbType.VarChar,50),
                                    new SqlParameter("@zhiwei",SqlDbType.VarChar,20),
                                new SqlParameter("@blog",SqlDbType.VarChar,50),
                                    new SqlParameter("@zuopin",SqlDbType.VarChar,50),
                                    new SqlParameter("@tel",SqlDbType.VarChar,50),
                                    new SqlParameter("@jianjie",SqlDbType.VarChar),
                                    new SqlParameter("@touxiang",SqlDbType.VarChar,250),
                                    new SqlParameter("@her",SqlDbType.VarChar,100),
                                    
                                    new SqlParameter("@xuehao",SqlDbType.VarChar,50),
                                    new SqlParameter("@renzhi",SqlDbType.VarChar,200),
                                    new SqlParameter("@qq",SqlDbType.VarChar,50),
                                    new SqlParameter("@qita",SqlDbType.VarChar,200),
                                    new SqlParameter("@jingli",SqlDbType.VarChar,4000),
                                     new SqlParameter("@ip",SqlDbType.VarChar,500),
                                     new SqlParameter("@hostname",SqlDbType.VarChar,500),
                                    new SqlParameter("@kaoyan",SqlDbType.VarChar,20),
                                   };
            param[0].Value = Mod.Name;
            param[1].Value = Mod.Sex;
            param[2].Value = Mod.Xueyuan;
            param[3].Value = Mod.Banji;
            param[4].Value = Mod.Xiaoqu;
            param[5].Value = Mod.Diannao;
            param[6].Value = Mod.Email;
            param[7].Value = Mod.Zhiwei;
           param[8].Value = Mod.Blog;
            param[9].Value = Mod.Zuopin;
            param[10].Value = Mod.Tel;
            param[11].Value = Mod.Jianjie;
            param[12].Value = Mod.Touxiang;
            param[13].Value = Mod.Her;

            param[14].Value = Mod.Xuehao;
            param[15].Value = Mod.Renzhi;
            param[16].Value = Mod.Qq;
            param[17].Value = Mod.Qita;
            param[18].Value = Mod.Jingli;
            param[19].Value = Mod.Ip;
            param[20].Value = Mod.HostName;
            param[21].Value = Mod.Kaoyan;
            int rowAffect;
            ProcCommander.RunProcedure("Karat_BaomingAdd", param, out rowAffect);
            return (rowAffect > 0);
        }

        public DataTable BaomingSelectAll()
        {


            SqlParameter[] param = {
                                    new SqlParameter("@table",SqlDbType.VarChar,50),
                                    new SqlParameter("@where",SqlDbType.VarChar,1500),
                                    new SqlParameter("@ziduan",SqlDbType.VarChar,500)
                                   };

            param[0].Value = "Karat_BaoMing";
            param[1].Value = "";
            param[2].Value = "";
            SqlDataReader sdr = ProcCommander.RunProcedure("Karat_Select", param);
            DataTable dt = new DataTable();
            dt.Load(sdr);
            sdr.Close();
            //todo:关闭sqldatareader
            return dt;
        }

        public string sdrcontent(string where)
        {
            string rls = "";
            SqlParameter[] param = {
                                      new SqlParameter("@where",SqlDbType.VarChar,100)
                                   };
            param[0].Value = where;
            SqlDataReader sdr = ProcCommander.RunProcedure("Karat_Culture", param);

            while (sdr.Read())
            {
                rls = sdr["Content"].ToString();
            };
            sdr.Close();
            return rls;
        }

        #endregion

    }
}