using System;
using System.Collections.Generic;
using Lgwin.IDAL;
using Lgwin.DALFactory;
using Lgwin.Model;

namespace Lgwin.BLL
{
    public class ImageBLL
    {
        /// <summary>
        /// 通过数据工厂获得Image对象
        /// </summary>
        private static readonly IImage dal = DataAccess.CreatImage();
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add(Image model)
        {
            try
            {
                return dal.Add(model);
            }
            catch (Exception ex)
            {
                //错误处理，记录日志
                return false;
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public int Del(string ids)
        {
            try
            {
                return (dal.Del(ids));
            }
            catch (Exception ex)
            {
                //错误处理，记录日志
                return 0;
            }
        }
        /// <summary>
        /// 由id得到图片
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Image GetImage(string id)
        {
            try
            {
                return (dal.GetImage(id));
            }
            catch (Exception ex)
            {
                //错误处理，记录日志
                return null;
            }
        }
        /// <summary>
        /// 由Id获得图片列表,0表示所有图片
        /// </summary>
        /// <param name="PicFlash">图片的id，用“，”分割</param>
        /// <returns></returns>
        public IList<Image> GetImageList(string Ids)
        {
            return dal.GetImageList(Ids);
        }
        public IList<Image> GetImageGetFenlei(string fenlei)
        {
            return dal.GetImageGetFenlei(fenlei);
        }
        public IList<Image> GetPicList()
        {
            return dal.GetPicList();
        }

    }
}