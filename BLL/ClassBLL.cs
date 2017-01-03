using System;
using System.Collections.Generic;
using Lgwin.Model;
using Lgwin.IDAL;
using Lgwin.DALFactory;

namespace Lgwin.BLL
{
    /// <summary>
    /// 分类的业务处理
    /// </summary>
    public class ClassBLL
    {
        /// <summary>
        /// 通过工厂创建类别对象
        /// </summary>
        private static readonly IClass dal = DALFactory.DataAccess.CreatClass();

        /// <summary>
        /// 添加分类
        /// </summary>
        /// <param name="Model">类对象</param>
        /// <returns></returns>
        public bool Add(Class Model)
        {
            return (dal.Add(Model));
        }

        /// <summary>
        /// 删除分类
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public int Del(params int[] ids)
        {
            return (dal.Del(ids));
        }

        /// <summary>
        /// 更新分类
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        public bool Update(Class Model)
        {
            return (dal.Update(Model));
        }

        /// <summary>
        /// 获取类对象
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Class GetClass(int Id)
        {
            return (dal.GetClass(Id));
        }
        /// <summary>
        /// 获取类列表
        /// </summary>
        /// <param name="ShowAll">true表示显示所有栏目，false表示只显示show为true的</param>
        /// <returns></returns>
        public IList<Class> GetClassList(bool ShowAll)
        {
            IList<Class> list = dal.GetClassList();
            if (!ShowAll)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (!list[i].Show)
                    {
                        list.Remove(list[i]);
                        i--;
                    }
                }
            }
            return list;
        }
    }
}
