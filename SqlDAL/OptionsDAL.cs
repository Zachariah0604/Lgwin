using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lgwin.IDAL;
using Lgwin.Model;
using Lgwin.DBUtility;
using System.Data;
using System.Data.SqlClient;

namespace Lgwin.SqlDAL
{
    public class OptionsDAL:IOptions
    {
        #region Options Members

        public bool Update(Options Model)
        {
            SqlParameter[] param = { 
                                        new SqlParameter("@name",SqlDbType.VarChar,50),
                                        new SqlParameter("@nr",SqlDbType.VarChar,2000),
                                   };
            param[0].Value = Model.AD;
            param[1].Value = Model.Nr;
            int rowAffected;
            ProcCommander.RunProcedure("Options_Update", param, out rowAffected);
            return (rowAffected > 0);
        }
        public Options GetOptions(string ad)
        {
            SqlParameter[] param = {
                                        new SqlParameter("@ad",SqlDbType.VarChar,50)
                                   };
            param[0].Value = ad;
            using (SqlDataReader dr = ProcCommander.RunProcedure("Options_GetInfo", param))
            {
                try
                {
                    if (dr.Read())
                        return (Transform.ToOptions(dr));
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
        #endregion
    }
}
