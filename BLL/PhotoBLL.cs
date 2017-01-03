using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Lgwin.Model;
using Lgwin.SqlDAL;
using System.Data.SqlClient;
using Lgwin.IDAL;


namespace Lgwin.BLL
{
    public class PhotoBLL
    {
        public DataTable select(int zhtID, int lmid)
        {
            DataTable dt = new DataTable();
            if (lmid == 0)
            {
                return dt = new Photoselect().Selectone(zhtID);

            }
            else { return dt = new Photoselect().Selecttwo(lmid); }


        }
        public SqlDataReader PhotoSelect(int id, string name, string tablename)
        {
            SqlDataReader sd = new Photoselect().PhotoSelect(id, name, tablename);
            return sd;

        }
        public bool PhotoDelete(int id, string name, string tablename)
        {

            return new Photoselect().PhotoDelete(id, name, tablename);
        }
        public DataTable Fenlei_man_Select(string zhtID)
        {
            return new Photoselect().Fenlei_man_Select(zhtID);

        }
        public bool Fenlei_man_Add(Photo mod)
        {
            return new Photoselect().Fenlei_man_Add(mod);

        }
        public bool FENLEI_manAdd(string name)
        {
            return new Photoselect().FENLEI_manAdd(name);
        }
        public SqlDataReader fenlei_edit(int id)
        {
            return new Photoselect().fenlei_edit(id);

        }
        public bool fenlei_edit1(int id, string introduction, string name, DateTime created_time)
        {
            return new Photoselect().fenlei_edit1(id, introduction, name, created_time);


        }
        public bool pic_edit(int id, string pic_path)
        {
            return new Photoselect().pic_edit(id, pic_path);


        }
        public bool pic_edit1(Photo mod)
        {
            return new Photoselect().pic_edit1(mod);
        }
        public bool pic_upload1(int id, string name, string tablename)
        {
            return new Photoselect().pic_upload1(id, name, tablename);
        }
        public bool pic_upload(Photo mod)
        {
            return new Photoselect().pic_upload(mod);

        }
        public SqlDataReader lgbq1(int zhtID, int lmID)
        {
            return new Photoselect().lgbq1(zhtID, lmID);
        }
        public SqlDataReader lgbq()
        {
            return new Photoselect().lgbq();
        }
        public bool sdut_upload(Photo mod)
        {
            return new Photoselect().sdut_upload(mod);
        }
        public SqlDataReader Tohtml(int num, string xshshch, string shouye, int zhtID, string table)
        {
            return new Photoselect().Tohtml(num, xshshch, shouye, zhtID, table);

        }
        public SqlDataReader DxTohtml(int num, int zhtID)
        {
            return new Photoselect().DxTohtml(num, zhtID);
        }
        public SqlDataReader DxTohtml1(int num, string xshshch, string shouye, string tuijian)
        {

            return new Photoselect().DxTohtml1(num, xshshch, shouye, tuijian);
        }
        public SqlDataReader DxTohtml2(int num)
        {

            return new Photoselect().DxTohtml2(num);
        }
        public SqlDataReader DxTohtml3(string table, string name, string value)
        {
            return new Photoselect().DxTohtml3(table, name, value);

        }
        public int DxTohtml4(int value)
        {
            return new Photoselect().DxTohtml4(value);
        }
        public SqlDataReader DxTohtml5(string value)
        {
            return new Photoselect().DxTohtml5(value);

        }
        // public List<Photo> GetPhotolist(int PageSize, int Page, string Where, out int PageCount)
        // {

        //    return new Photoselect().GetPhotolist(PageSize, Page, Where,out PageCount);

        //}
    }
}

