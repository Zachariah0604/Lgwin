using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Lgwin.Model;
using System.Data.SqlClient;
using Lgwin.DBUtility;


namespace Lgwin.SqlDAL
{
    public class Photoselect
    {
        public DataTable Selectone(int zhtID)
        {
            SqlParameter[] param = {
                                    new SqlParameter("@xshshch",SqlDbType.Bit),
                                    new SqlParameter("@zhtID",SqlDbType.Int)
                                  
                                   };

            param[0].Value =0;
            param[1].Value = zhtID;

            SqlDataReader sdr = ProcCommander.RunProcedure("Phtomanage_Getlist", param);
            DataTable dt = new DataTable();
            dt.Load(sdr);
            return dt;


        }
        public DataTable Selecttwo(int lmid)
        {
            SqlParameter[] param = {
                                    new SqlParameter("@xshshch",SqlDbType.Bit),
                                    new SqlParameter("@lmID",SqlDbType.VarChar,50)
                                  
                                   };

            param[0].Value = 0;
            param[1].Value = lmid;

            SqlDataReader sdr = ProcCommander.RunProcedure("Phtomanage_repeater", param);
            DataTable dt = new DataTable();
            dt.Load(sdr);
            return dt;


        }
        public SqlDataReader PhotoSelect(int id, string name, string tablename)
        {
            SqlParameter[] param = {
                                    new SqlParameter("@id",SqlDbType.Int),
                                    new SqlParameter("@name",SqlDbType.VarChar,50),
                                    new SqlParameter("@table",SqlDbType.VarChar,50)
                                  
                                   };
            param[0].Value = id;
            param[1].Value = name;
            param[2].Value = tablename;
            SqlDataReader dr = ProcCommander.RunProcedure("Photomanage_select", param);
            return dr;
        }
        public bool PhotoDelete(int id, string name, string tablename)
        {
            SqlParameter[] param = {
                                    new SqlParameter("@id",SqlDbType.Int),
                                    new SqlParameter("@name",SqlDbType.VarChar,50),
                                    new SqlParameter("@table",SqlDbType.VarChar,50)
                                   
                                   };
            param[0].Value = id;
            param[1].Value = name;
            param[2].Value = tablename;
            int rowAffect;
            ProcCommander.RunProcedure("Photomanage_delete", param, out rowAffect);
            return (rowAffect > 0);
        }
        public DataTable Fenlei_man_Select(string zhtID)
        {
            SqlParameter[] param ={
                               new SqlParameter("@zhtID ",SqlDbType.VarChar,50)
                               };
            param[0].Value = zhtID;
            //int rowAffect;
            SqlDataReader sd = ProcCommander.RunProcedure("Fenlei_man_Select", param);
            DataTable dt = new DataTable();
            dt.Load(sd);
            return dt;
        }
        public bool Fenlei_man_Add(Photo mod)
        {
            SqlParameter[] param ={
                           new SqlParameter("@name",SqlDbType.VarChar,50),
                             new SqlParameter("@zhtname",SqlDbType.VarChar,50),
                               new SqlParameter("@zhtID",SqlDbType.Int),
                                 new SqlParameter("@introduction",SqlDbType.VarChar,10000),
                                   new SqlParameter("@created_time",SqlDbType.NVarChar,100)
                           };

            param[0].Value = mod.name;
            param[1].Value = mod.zhtname;
            param[2].Value = mod.zhtID;
            param[3].Value = mod.introduction;
            param[4].Value = mod.created_time;
            int rowAffect;
            ProcCommander.RunProcedure("Fenlei_man_Add", param, out rowAffect);
            return (rowAffect > 0);
        }
        public bool FENLEI_manAdd(string name)
        {
            SqlParameter[] param = { 
                               new SqlParameter("@name", SqlDbType.VarChar,50)  };
            param[0].Value = "";

            SqlDataReader dr = ProcCommander.RunProcedure("FENLEI_manAdd", param);
            bool flag = false;
            while (dr.Read())
            {
                if (dr["name"].ToString() == name)
                    flag = true;
            }
            return flag;
        }
        public SqlDataReader fenlei_edit(int id)
        {
            SqlParameter[] param = { 
                                 new SqlParameter("@id",SqlDbType.Int)
                                 };
            param[0].Value = id;
            SqlDataReader sdr = ProcCommander.RunProcedure("fenlei_edit", param);
            return sdr;

        }
        public bool fenlei_edit1(int id, string introduction, string name, DateTime created_time)
        {
            SqlParameter[] param = { 
                                 new SqlParameter("@id",SqlDbType.Int),
                                 new SqlParameter("@introduction",SqlDbType.VarChar,10000000),
                                  new SqlParameter("@name",SqlDbType.VarChar,50),
                                   new SqlParameter("@created_time",SqlDbType.DateTime),
                                 };
            param[0].Value = id;
            param[1].Value = introduction;
            param[2].Value = name;
            param[3].Value = created_time;
            int rowAffect;
            ProcCommander.RunProcedure("Infenlei_edit", param, out rowAffect);
            return (rowAffect > 0);

        }
        public bool pic_edit(int id, string pic_path)
        {
            SqlParameter[] param = { 
                                 new SqlParameter("@id",SqlDbType.Int),
                                 new SqlParameter("@path",SqlDbType.VarChar,255),
                                  
                                 };
            param[0].Value = id;
            param[1].Value = pic_path;
            int rowAffect;
            ProcCommander.RunProcedure("pic_edit", param, out rowAffect);
            return (rowAffect > 0);

        }
        public bool pic_edit1(Photo mod)
        {
            SqlParameter[] param = { 
                                 new SqlParameter("@id",SqlDbType.Int),
                                 new SqlParameter("@name",SqlDbType.NVarChar,50),
                                  new SqlParameter("@pagename",SqlDbType.NVarChar,255),
                                  new SqlParameter("@path",SqlDbType.NVarChar,255),
                                  new SqlParameter("@zhtID",SqlDbType.Int ),
                                  new SqlParameter("@lmID",SqlDbType.Int),
                                  new SqlParameter("@lmname",SqlDbType.NVarChar,50),
                                  new SqlParameter("@zhtname",SqlDbType.NVarChar,50),
                                  new SqlParameter("@zuozhe ",SqlDbType.NVarChar,255),
                                  new SqlParameter("@editor",SqlDbType.NVarChar,50),

                                  new SqlParameter("@shuoming",SqlDbType.NText),
                                  new SqlParameter("@tuijian",SqlDbType.NVarChar,50),
                                  new SqlParameter("@redian",SqlDbType.NVarChar,50),
                                    new SqlParameter("@xww ",SqlDbType.NVarChar,50),
                                   new SqlParameter("@xshshch",SqlDbType.NVarChar,50),
                                new SqlParameter("@upload_time",SqlDbType.DateTime),
                                  new SqlParameter("@shouye",SqlDbType.NVarChar,50)
                                 };
            param[0].Value = mod.id;
            param[1].Value = mod.name;
            param[2].Value = mod.pagename;
            param[3].Value = mod.path;
            param[4].Value = mod.zhtID;
            param[5].Value = mod.lmID;
            param[6].Value = mod.lmname;
            param[7].Value = mod.zhtname;
            param[8].Value = mod.zuozhe;
            param[9].Value = mod.editor;
            param[10].Value = mod.shuoming;
            param[11].Value = mod.tuijian;
            param[12].Value = mod.redian;
            param[13].Value = mod.xww;
            param[14].Value = mod.xshshch;
            param[15].Value = mod.upload_time;
            param[16].Value = mod.shouye;
            int rowAffect;
            ProcCommander.RunProcedure("pic_edit1", param, out rowAffect);
            return (rowAffect > 0);
        }
        public bool pic_upload1(int id, string name, string tablename)
        {
            SqlParameter[] param = {
                                    new SqlParameter("@id",SqlDbType.Int),
                                    new SqlParameter("@name",SqlDbType.VarChar,50),
                                    new SqlParameter("@table",SqlDbType.VarChar,50)
                                   
                                   };
            param[0].Value = id;
            param[1].Value = name;
            param[2].Value = tablename;
            int rowAffect;
            ProcCommander.RunProcedure("Photomanage_select", param, out rowAffect);
            return (rowAffect > 0);
        }      
        public bool pic_upload( Photo mod)
        {
            SqlParameter[] param = { 
                               
                                 new SqlParameter("@name",SqlDbType.NVarChar,50),
                                  new SqlParameter("@pagename",SqlDbType.NVarChar,255),
                                  new SqlParameter("@path",SqlDbType.NVarChar,255),
                                  new SqlParameter("@path_small",SqlDbType.NVarChar,255),
                                  new SqlParameter("@zhtID",SqlDbType.Int ),
                                  new SqlParameter("@lmID",SqlDbType.Int),
                                  new SqlParameter("@lmname",SqlDbType.NVarChar,50),
                                  new SqlParameter("@zhtname",SqlDbType.NVarChar,50),
                                  new SqlParameter("@zuozhe ",SqlDbType.NVarChar,255),
                                  new SqlParameter("@editor",SqlDbType.NVarChar,50),
                                  new SqlParameter("@shuoming",SqlDbType.NText),
                                  new SqlParameter("@tuijian",SqlDbType.NVarChar,50),
                                  new SqlParameter("@redian",SqlDbType.NVarChar,50),
                                  new SqlParameter("@xww ",SqlDbType.NVarChar,50),
                                  new SqlParameter("@xshshch",SqlDbType.NVarChar,50),
                                  new SqlParameter("@upload_time",SqlDbType.DateTime),
                                  new SqlParameter("@shouye",SqlDbType.NVarChar,50)
                                  
                                 };

            param[0].Value = mod.name;
            param[1].Value = mod.pagename;
            param[2].Value = mod.path;
            param[3].Value = mod.path_small;
            param[4].Value = mod.zhtID;
            param[5].Value = mod.lmID;
            param[6].Value = mod.lmname;
            param[7].Value = mod.zhtname;
            param[8].Value = mod.zuozhe;
            param[9].Value = mod.editor;
            param[10].Value = mod.shuoming;
            param[11].Value = mod.tuijian;
            param[12].Value = mod.redian;
            param[13].Value = mod.xww;
            param[14].Value = mod.xshshch;
            param[15].Value = mod.upload_time;
            param[16].Value = mod.shouye;
            int rowAffect;
            ProcCommander.RunProcedure("pic_upload", param, out rowAffect);
            return (rowAffect > 0);

        }
        public bool sdut_upload(Photo mod)
        {

            SqlParameter[] param = { 
                                   new SqlParameter("@name",SqlDbType.NVarChar,50),
                                     new SqlParameter("@zhtID",SqlDbType.Int),
                                       new SqlParameter("@shuoming",SqlDbType.NText),
                                         new SqlParameter("@zuozhe",SqlDbType.NVarChar,50),
                                           new SqlParameter("@path",SqlDbType.NVarChar,255),
                                           new SqlParameter("@path_small",SqlDbType.NVarChar,255),
                                             new SqlParameter("@zhtname",SqlDbType.NVarChar,50),
                                              new SqlParameter("@xshshch",SqlDbType.NVarChar,10),

                                                                      };
            param[0].Value = mod.name;
            param[1].Value = mod.zhtID;
            param[2].Value = mod.shuoming;
            param[3].Value = mod.zuozhe;
            param[4].Value = mod.path;
            param[5].Value = mod.path_small;
            param[6].Value = mod.zhtname;
            param[7].Value = "1";
            int rowAffect;
            ProcCommander.RunProcedure("Sdu_upload", param, out rowAffect);
            return (rowAffect>0);
        }
        public SqlDataReader Tohtml(int num, string xshshch, string shouye, int zhtID, string table)
        {
            SqlParameter[] param = { 
                                    
                                      new SqlParameter("@num",SqlDbType.Int),
                                        new SqlParameter("@xshshch",SqlDbType.NVarChar,10),
                                          new SqlParameter("@shouye",SqlDbType.NVarChar,10),
                                            new SqlParameter("@zhtID",SqlDbType.Int),
                                              new SqlParameter("@table",SqlDbType.NVarChar,50),
                                        };

            param[0].Value = num;
            param[1].Value = xshshch;
            param[2].Value = shouye;
            param[3].Value = zhtID;
            param[4].Value = table;
            SqlDataReader dr = ProcCommander.RunProcedure("Photomanagegy_tohtml", param);
            return dr;
        }
        public SqlDataReader DxTohtml(int num, int zhtID)
        {
            SqlParameter[] param = { 
                                    
                                      new SqlParameter("@num",SqlDbType.Int),                                       
                                            new SqlParameter("@zhtID",SqlDbType.Int),
                                            
                                    };

            param[0].Value = num;
            param[1].Value = zhtID;

            SqlDataReader dr = ProcCommander.RunProcedure("Photomangedx_tohtml", param);
            return dr;
        }
        public SqlDataReader lgbq1(int zhtID, int lmID) {
            SqlParameter[] param = { 
                                    
                                      new SqlParameter("@zhtID",SqlDbType.Int), 
                                       new SqlParameter("@lmID",SqlDbType.Int), 
                                                                            
                                                                                };

            param[0].Value = zhtID;

            param[1].Value = lmID;
            SqlDataReader dr = ProcCommander.RunProcedure("photo_lgbq1", param);
            return dr;
        
        }
        public SqlDataReader lgbq()
        {
            SqlParameter[] param = { 
                                    
                                      new SqlParameter("@zhtID",SqlDbType.Int), 
                                                                              
                                                                                };

            param[0].Value =0;

          
            SqlDataReader dr = ProcCommander.RunProcedure("photo_lgbq", param);
            return dr;

        }
        public SqlDataReader DxTohtml1(int num, string xshshch, string shouye, string tuijian)
        {
            SqlParameter[] param = { 
                                    
                                      new SqlParameter("@num",SqlDbType.Int), 
                                        new SqlParameter("@xshshch",SqlDbType.VarChar,10),
                                          new SqlParameter("@shouye",SqlDbType.VarChar,10),
                                          new SqlParameter("@tuijian",SqlDbType.VarChar,10)                                       
                                                                                };

            param[0].Value = num;
            param[1].Value = xshshch;
            param[2].Value = shouye;
            param[3].Value = tuijian;
            SqlDataReader dr = ProcCommander.RunProcedure("Photomannagedx_tohtml1", param);
            return dr;
        }
        public SqlDataReader DxTohtml2(int num)
        {
            SqlParameter[] param = { 
                                    
                                      new SqlParameter("@num",SqlDbType.Int), 
                                                                            
                                                                                };

            param[0].Value = num;
            SqlDataReader dr = ProcCommander.RunProcedure("Third_tohtml", param);
            return dr;
        }
        public SqlDataReader DxTohtml3(string table, string name, string value)
        {

            SqlParameter[] param ={
                                 new SqlParameter("@table",SqlDbType.VarChar,50),
                                   new SqlParameter("@name",SqlDbType.VarChar,50),
                                     new SqlParameter("@value",SqlDbType.VarChar,50)
 
                             };

            param[0].Value = table;
            param[1].Value = name;
            param[2].Value = value;
            SqlDataReader dr = ProcCommander.RunProcedure("Third_tohtml1", param);
            return dr;


        }
        public SqlDataReader DxTohtml5(string value)
        {

            SqlParameter[] param ={
                                
                                     new SqlParameter("@zhtname",SqlDbType.VarChar,50)
 
                             };


            param[0].Value = value;
            SqlDataReader dr = ProcCommander.RunProcedure("Third_tohtml3", param);
            return dr;


        }
        public int DxTohtml4(int id)
        {
            SqlParameter[] param = {                                       
                                       new SqlParameter("@id",SqlDbType.Int), 
                                        };
            param[0].Value =id;

            int i = Convert.ToInt32(ProcCommander.RunProcedureScalar("Photomannagedx_tohtml3", param));

            return i;
        }
        //public List<Photo> GetPhotolist(int PageSize, int Page, string Where, out int PageCount)
        // {
        //     List<Photo> List = new List<Photo>();
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
        //    param[0].Value = "Photo_photo";
        //    param[1].Value = "[id],[name],[zhtID],[shuoming],[zuozhe],[path],[path_small],[lmID] ,[zhtname],[lmname],[tuijian],[shouye],[redian] ,[xww],[xshshch],[pagename],[upload_time],[editor] ";
        //    param[2].Value = "id";
        //    param[3].Value = PageSize;
        //    param[4].Value = Page;
        //    param[5].Value = 0;
        //    param[6].Value = 1;
        //    param[7].Value = Where;

        //    using (SqlDataReader dr = ProcCommander.RunProcedure("GetInfoByPage", param))
        //    {
        //        while (dr.Read())
        //        {
        //            List.Add(Transform.Tophotolist(dr));
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
        //    param2[0].Value = "Photo_photo";
        //    param2[1].Value = "[name],[zhtID],[shuoming],[zuozhe],[path],[path_small],[lmID] ,[zhtname],[lmname],[tuijian],[shouye],[redian] ,[xww],[xshshch],[pagename],[upload_time],[editor] ";
        //    param2[2].Value = "id";
        //    param2[3].Value = PageSize;
        //    param2[4].Value = Page;
        //    param2[5].Value = 1;
        //    param2[6].Value = 1;
        //    param2[7].Value = Where;
        //    PageCount = (int)ProcCommander.RunProcedureScalar("GetInfoByPage", param2);
        //    return List;
        //}
        
        }
    }

