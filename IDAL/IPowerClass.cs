using System;
using System.Collections.Generic;
using System.Text;
using Lgwin.Model;

namespace Lgwin.IDAL
{

    public interface IPowerClass
    {
        /// <summary>
        /// 添加权限类别
        /// </summary>
        /// <param name="Model">分类对象</param>
        /// <returns>Boolean</returns>
        bool Add(PowerClass Model);

        /// <summary>
        /// 添加权限类别
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int Del(params int[] Id);

        /// <summary>
        /// 更新权限类别
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        bool Update(PowerClass Model);

        /// <summary>
        /// 获取指定权限的ID对象
        /// </summary>
        /// <param name="Power">权限</param>
        /// <returns>分类对象</returns>
        PowerClass GetPowerClass(string Power);

        /// <summary>
        /// 获取指定ID对象
        /// </summary>
        /// <param name="Id">id</param>
        /// <returns>分类对象</returns>
        PowerClass GetPowerClassById(int Id);

        /// <summary>
        /// 获取权限类别列表
        /// </summary>
        /// <returns>返回分类列表对象</returns>
        IList<PowerClass> GetPowerClassList(string Class);
    }
}
