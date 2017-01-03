using System;
using System.Collections.Generic;
using Lgwin.IDAL;
using Lgwin.DALFactory;
using Lgwin.Model;

namespace Lgwin.BLL
{
    public class OptionsBLL
    {
        private static readonly IOptions dal = DataAccess.CreatOptions();
        /// <summary>
        /// 更新广告位的内容
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        public bool Update(Options Model)
        {
            try
            {
                return (dal.Update(Model));
            }
            catch (Exception ex)
            {
                //错误处理，记录日志
                return false;
            }
        }
        /// <summary>
        /// 根据广告位得到内容
        /// </summary>
        /// <param name="ad"></param>
        /// <returns></returns>
        public Options GetOptions(string ad)
        {
            try
            {
                return dal.GetOptions(ad);
            }
            catch (Exception ex)
            {
                //错误处理，记录日志
                return null;
            }
        }

    }
}
