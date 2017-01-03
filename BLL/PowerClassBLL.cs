using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lgwin.IDAL;
using Lgwin.DALFactory;
using Lgwin.Model;

namespace Lgwin.BLL
{
    public class PowerClassBLL
    {
        /// <summary>
        /// 通过工厂创建权限类别对象
        /// </summary>
        private static readonly IPowerClass dal = DALFactory.DataAccess.CreatPowerClass();

        /// <summary>
        /// 添加权限
        /// </summary>
        /// <param name="Model">权限对象</param>
        /// <returns></returns>
        public bool Add(PowerClass Model)
        {
            return (dal.Add(Model));
        }

        /// <summary>
        /// 删除权限
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public int Del(params int[] ids)
        {
            return (dal.Del(ids));
        }

        /// <summary>
        /// 更新权限
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        public bool Update(PowerClass Model)
        {
            return (dal.Update(Model));
        }

        /// <summary>
        /// 获取权限对象
        /// </summary>
        /// <param name="Power"></param>
        /// <returns></returns>
        public PowerClass GetPowerClass(string Power)
        {
            return (dal.GetPowerClass(Power));
        }
        /// <summary>
        /// 获取指定id对象
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public PowerClass GetPowerClassById(int Id)
        {
            return (dal.GetPowerClassById(Id));
        }


        /// <summary>
        /// 获取权限列表
        /// </summary>
        /// <returns></returns>
        public IList<PowerClass> GetPowerClassList(string Class)
        {
            IList<PowerClass> list = dal.GetPowerClassList(Class);
            return list;
        }
    }
}
