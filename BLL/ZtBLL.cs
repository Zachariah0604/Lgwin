using System;
using System.Collections.Generic;
using Lgwin.IDAL;
using Lgwin.DALFactory;
using Lgwin.Model;

namespace Lgwin.BLL
{
    public class ZtBLL
    {
        /// <summary>
        /// 通过数据工厂获得专题对象
        /// </summary>
        private static readonly IZt dal = DataAccess.CreatZt();
        public  bool Add(Zt mod)
        {
           return dal.Add(mod);
        }
        public int Del(string Ids)
        {
            return dal.Del(Ids);
        }
        public bool Update(Zt mod)
        {
            return dal.Update(mod);
        }
        public void leadAdd(string leadid, string artid)
        {
            try
            {
                dal.leadAdd(leadid, artid);
            }
            catch
            { }
        }
        public void Delldart(string ldid, string artid)
        {
            try
            {
                dal.Delldart(ldid, artid);
            }
            catch
            { }
        }
        public Zt GetZtById(int id)
        {
            return dal.GetZtById(id);
        }
        /// <summary>
        /// 返回专题列表
        /// </summary>
        /// <param name="ShowAll">boolean 是否返回所有列表</param>
        /// <returns></returns>
        public IList<Zt> GetZtList(bool ShowAll)
        {
            return dal.GetZtList(ShowAll);
        }

        /// <summary>
        /// 返回无刷新专题下拉JS代码
        /// </summary>
        /// <returns></returns>
        //public string GetJsZt()
        //{
        //    string str = "";
        //    IList<Zt> list =dal.GetZtList(true);
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        //str += "ztcaption[" + i.ToString() + "] = new Array('" + list[i].Id.ToString() + "','" + da["ztcaption"].ToString() + "','" + da["id"].ToString() + "');\n";
        //    }
        //        return str;
        //}

    }
}