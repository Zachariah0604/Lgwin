using System;
using System.Collections.Generic;
using Lgwin.Model;
using Lgwin.IDAL;
using Lgwin.DALFactory;

namespace Lgwin.BLL
{
    public class ZtCaptionBLL
    {
        /// <summary>
        /// 通过数据工厂获得专题栏目对象
        /// </summary>
        private static readonly IZtCaption dal = DataAccess.CreatZtCaption();
        /// <summary>
        /// 专题添加
        /// </summary>
        /// <param name="Model">专题对象</param>
        /// <returns>Boolean</returns>
        public bool Add(ZtCaption Model)
        {
            return dal.Add(Model);
        }

        /// <summary>
        /// 专题更新
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        public bool Update(ZtCaption Model)
        {
            return dal.Update(Model);
        }

        /// <summary>
        /// 专题删除
        /// </summary>
        /// <param name="Ids">Id，id，id</param>
        /// <returns></returns>
       public int Del(string Ids)
        {
            return dal.Del(Ids);
        }
       public ZtCaption GetZtCaption(int id)
       {
           return dal.GetZtCaption(id);
       }
       public ZtCaption GetZtCaption(string capname)
       {
           return dal.GetZtCaption(capname);
       }
        /// <summary>
        /// 专题栏目列表
        /// </summary>
        /// <param name="id">专题id，参数0表示所有id</param>
        /// <returns></returns>
        public IList<ZtCaption> GetZtCaptionList(string id)
        {
            IList<ZtCaption> list = dal.GetZtCaptionList(id);
            return list;
        }

        ///// <summary>
        ///// 返回无刷新二级菜单的JS代码
        ///// </summary>
        ///// <returns></returns>
        //public string CaptionJsStr()
        //{
        //    ZtBLL bll = new ZtBLL();//由专题Id获得专题简称
        //    IList<ZtCaption> list = dal.GetZtCaptionList("0");
        //    string str = "";
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        str += "ztcaption[" + i.ToString() + "] = new Array('" +list[i].Ztid + "','" + list[i].ZtCaptionName.ToString() + "','" + list[i].Id.ToString() + "');\n";
        //    }
        //    return str;
        //}
        /// <summary>
        /// 返回无刷新二级菜单的JS代码
        /// </summary>
        /// <returns></returns>
        public string CaptionJsStr()
        {
            IList<ZtCaption> list = dal.GetZtCaptionList("0");
            string str = "";
            for (int i = 0; i < list.Count; i++)
            {
                str += "ztcaption[" + i.ToString() + "] = new Array('" + list[i].Ztid.ToString() + "','" + list[i].ZtCaptionName.ToString() + "','" + list[i].Id.ToString() + "');\n";
            }
            return str;
        }
    }
}
