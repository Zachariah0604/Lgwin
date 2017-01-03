using System;
using System.Collections.Generic;
using Lgwin.Model;
using Lgwin.IDAL;
using Lgwin.DALFactory;

namespace Lgwin.BLL
{
    public class CollegeBLL
    {
        /// <summary>
        /// 通过数据工厂创建学院数据处理对象
        /// </summary>
        private static readonly ICollege dal = DataAccess.CreatCollege();
        public bool ADD(College mod)
        {
            return dal.Add(mod);
        }
        public int Del(string ids)
        {
            return dal.Del(ids);
        }
        public bool Update(College mod)
        {
            return dal.Update(mod);
        }        
        public IList<College> GetCollegeList()
        {
            return dal.GetList();
        }
    }
}
