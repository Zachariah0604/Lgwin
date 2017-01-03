using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Lgwin.IDAL;
using Lgwin.Model;
using Lgwin.DBUtility;

namespace Lgwin.SqlDAL
{
    public class VideoDAL:IVideo
    {
        #region IVideo Members

        public bool Add(Video Model)
        {
            SqlParameter[] param = {
                                    new SqlParameter("@name",SqlDbType.VarChar,50),
                                    new SqlParameter("@title",SqlDbType.VarChar,200),
                                    new SqlParameter("@Recommend",SqlDbType.VarChar,500),
                                    new SqlParameter("@HitNum",SqlDbType.Int),
                                    new SqlParameter("@AddDate",SqlDbType.DateTime),
                                    new SqlParameter("@uploader",SqlDbType.VarChar,50),
                                    new SqlParameter("@From",SqlDbType.VarChar,50),
                                    new SqlParameter("@Url",SqlDbType.VarChar,50),
                                    new SqlParameter("@Type",SqlDbType.VarChar,50),
                                    new SqlParameter("@Href",SqlDbType.VarChar,50),
                                    new SqlParameter("@Pic",SqlDbType.VarChar,50)
                                   };
            param[0].Value = Model.Name;
            param[1].Value = Model.Title;
            param[2].Value = Model.Recommend;
            param[3].Value = int.Parse(Model.HitNum.ToString());
            param[4].Value = Model.AddDate;
            param[5].Value = Model.Uploader;
            param[6].Value = Model.From;
            param[7].Value = Model.Url;
            param[8].Value = Model.Type;
            param[9].Value = Model.Href;
            param[10].Value = Model.Pic;
            int rowAffect;
            ProcCommander.RunProcedure("Video_Add", param, out rowAffect);
            return (rowAffect > 0);
        }
        public bool Update(Video Model)
        {
            SqlParameter[] param = {
                                    new SqlParameter("@id",SqlDbType.Int),
                                    new SqlParameter("@name",SqlDbType.VarChar,50),
                                    new SqlParameter("@title",SqlDbType.VarChar,200),
                                    new SqlParameter("@Recommend",SqlDbType.VarChar,500),
                                    new SqlParameter("@HitNum",SqlDbType.Int),
                                    new SqlParameter("@AddDate",SqlDbType.DateTime),
                                    new SqlParameter("@uploader",SqlDbType.VarChar,50),
                                    new SqlParameter("@From",SqlDbType.VarChar,50),
                                   new SqlParameter("@Url",SqlDbType.VarChar,50),
                                   new SqlParameter("@Type",SqlDbType.VarChar,50),
                                    new SqlParameter("@Href",SqlDbType.VarChar,50)
                                   };
            param[0].Value = Model.Id;
            param[1].Value = Model.Name;
            param[2].Value = Model.Title;
            param[3].Value = Model.Recommend;
            param[4].Value =int.Parse(Model.HitNum.ToString());
            param[5].Value=Model.AddDate;
            param[6].Value=Model.Uploader;
            param[7].Value=Model.From;
            param[8].Value = Model.Url;
            param[9].Value = Model.Type;
            param[10].Value = Model.Href;

            int rowAffect;
            ProcCommander.RunProcedure("Video_Update", param, out rowAffect);
            return (rowAffect > 0);
        }

        public int Del(string Ids)
        {
            SqlParameter[] param = {
                                    new SqlParameter("@id",SqlDbType.VarChar,2000)
                                   };
            param[0].Value = Ids;
            int rowAffect;
            ProcCommander.RunProcedure("Video_Del", param, out rowAffect);
            return rowAffect;
        }
        public Video GetVideoById(int Id)
        {
            SqlParameter[] param = {
                                        new SqlParameter("@Id",SqlDbType.Int)
                                   };
            param[0].Value = Id;
            using (SqlDataReader dr = ProcCommander.RunProcedure("Video_GetInfo", param))
            {
                try
                {
                    if (dr.Read())
                        return (Transform.ToVideo(dr));
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
        public int GetHitNumber(string Id)
        {
            int hitnumber = 0;
            SqlParameter[] param = {
                                        new SqlParameter("@Id",SqlDbType.VarChar,50)
                                   };
            param[0].Value = Id;
            hitnumber = (int)ProcCommander.RunProcedureScalar("Video_HitNumber", param);
            return hitnumber;
        }
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
            param2[0].Value = "Video";
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
        
        public IList<Video> GetVideoList(int PageSize, int Page, string Where, out int PageCount)
        {
            IList<Video> List = new List<Video>();
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
            param[0].Value = "Video";
            param[1].Value = "[id],[name],[title],[Recommend],[HitNum],[AddDate],[uploader],[From] ,[Url],[Type],[Href],[Pic]";
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
                    List.Add(Transform.ToVideo(dr));
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
            param2[0].Value = "Video";
            param2[1].Value = "[id],[name],[title],[Recommend],[HitNum],[AddDate],[uploader],[From] ,[Url],[Type],[Pic]";
            param2[2].Value = "id";
            param2[3].Value = PageSize;
            param2[4].Value = Page;
            param2[5].Value = 1;
            param2[6].Value = 1;
            param2[7].Value = Where;
            PageCount = (int)ProcCommander.RunProcedureScalar("GetInfoByPage", param2);
            return List;
        }
        public IList<Video1> GetVideolist(int PageSize, int Page, string Where, string ORDERBY, bool DESC, out int PageCount)
        {
            List<Video1> list = new List<Video1>();
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
            param[0].Value = "Campus_Video";
            param[1].Value = "*";
            param[2].Value = ORDERBY;
            param[3].Value = PageSize;
            param[4].Value = Page;
            param[5].Value = 0;
            param[6].Value = Convert.ToByte(DESC);
            param[7].Value = Where;
            SqlDataReader dr = ProcCommander.RunProcedure("GetInfoByPage", param);

            try
            {

                while (dr.Read())
                {
                    Transform<Video1> transform = new Transform<Video1>();
                    list.Add(transform.DataReaderToModel(dr));

                }
                dr.Close();
            }
            finally
            {

                if (dr != null && !dr.IsClosed)
                    dr.Close();
                dr.Dispose();

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
            param2[0].Value = "Campus_Video";
            param2[1].Value = "*";
            param2[2].Value = ORDERBY;
            param2[3].Value = PageSize;
            param2[4].Value = Page;
            param2[5].Value = 1;
            param2[6].Value = Convert.ToByte(DESC);
            param2[7].Value = Where;
            PageCount = int.Parse(ProcCommander.RunProcedureScalar("GetInfoByPage", param2).ToString());

            return list;
        }
        #endregion
    }
}
