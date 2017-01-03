using System;
using System.Collections.Generic;
using Lgwin.DBUtility;
using Lgwin.Model;
using Lgwin.IDAL;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace Lgwin.SqlDAL
{
     public class ImageDAL:IImage
     {
         #region Image Members
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="Model">用户对象</param>
        /// <returns></returns>
         /// id, name, url, type, href, [on]
        public bool Add(Image Model)
        {
            SqlParameter[] param = {
                                     new SqlParameter ("@name",SqlDbType.VarChar,50),
                                     new SqlParameter ("@url",SqlDbType.VarChar,500),
                                     new SqlParameter ("@type",SqlDbType.VarChar,500),
                                     new SqlParameter ("@href",SqlDbType.VarChar,500),
                                     new SqlParameter ("@on",SqlDbType.Bit),
                                     new SqlParameter ("@fenlei",SqlDbType.VarChar,50)
                                   };
            param[0].Value = Model.Name;
            param[1].Value = Model.Url;
            param[2].Value = Model.Type;
            param[3].Value = Model.Href;
            param[4].Value= Convert.ToByte(Model.On);
            param[5].Value = Model.FenLei;
            int rowAffected;
            ProcCommander.RunProcedure("Image_Add", param, out rowAffected);
            return (rowAffected > 0);
        }
        public int Del(string Ids)
        {
            SqlParameter[] param = { 
                                        new SqlParameter("@ids",SqlDbType.VarChar,2000)
                                   };
            param[0].Value = Ids;
            int rowAffected;
            ProcCommander.RunProcedure("Image_Del", param, out rowAffected);
            return rowAffected;
        }
        /// <summary>
        /// 通过用户名获取用户
        /// </summary>
        /// <param name="UserName">用户名</param>
        /// <returns>用户对象</returns>
        public Image GetImage(string Id)
        {
            SqlParameter[] param = {
                                       new SqlParameter("@ID",SqlDbType.VarChar,50)
                                    };
            param[0].Value = Id;
            SqlDataReader dr = ProcCommander.RunProcedure("Image_GetInfo", param);
            try
            {
                if (dr.Read())
                    return Transform.ToImage(dr);
                else
                    return null;
            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
            }
        }
        public IList<Image> GetImageList(string Ids)
        {
            SqlParameter[] param = { new SqlParameter("@Ids",SqlDbType.VarChar,500)};
            param[0].Value = Ids;
            IList<Image> CollegeList = new List<Image>();
            using (SqlDataReader dr = ProcCommander.RunProcedure("Image_GetList", param))
            {
                while (dr.Read())
                {
                    CollegeList.Add(Transform.ToImage(dr));
                }
                dr.Close();//zgy
            }
            return CollegeList;
        }
        public IList<Image> GetImageGetFenlei(string fenlei)
        {
            SqlParameter[] param = { new SqlParameter("@fenlei", SqlDbType.VarChar, 50) };
            param[0].Value = fenlei;
            IList<Image> CollegeList = new List<Image>();
            using (SqlDataReader dr = ProcCommander.RunProcedure("Image_GetFenlei", param))
            {
                while (dr.Read())
                {
                    CollegeList.Add(Transform.ToImage(dr));
                }
                dr.Close();//zgy
            }
            return CollegeList;
        }

        public IList<Image> GetPicList()
        {
            IList<Image> List = new List<Image>();
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
            param[0].Value = "Photo_photo";
            param[1].Value = "*";
            param[2].Value = "id";
            param[3].Value = 8;
            param[4].Value = 1;
            param[5].Value = 1;
            param[6].Value = 1;
            param[7].Value = "shouye='true'";

            using (SqlDataReader dr = ProcCommander.RunProcedure("GetInfoByPage", param))
            {
                try
                {
                    while (dr.Read())
                    {
                        List.Add(Transform.ToImage(dr));
                    }
                }
                finally
                {
                    if (dr != null && !dr.IsClosed)
                        dr.Close();
                    dr.Dispose();
                }
            }
 
            return List;
        }

        #endregion
    }
}
