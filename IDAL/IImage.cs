using System;
using System.Collections.Generic;
using Lgwin.Model;

namespace Lgwin.IDAL
{
     public interface  IImage
    {
        /// <summary>
        /// 图片添加
        /// </summary>
        /// <param name="Model">图片对象</param>
        /// <returns>Boolean</returns>
        bool Add(Image Model);
        /// <summary>
        /// 图片删除
        /// </summary>
        /// <param name="Ids">Id，id，id</param>
        /// <returns></returns>
        int Del(string Ids);
         /// <summary>
         /// 获得图片
         /// </summary>
         /// <param name="Ids">图片Id</param>
         /// <returns></returns>
        Model.Image GetImage(string Id);
        /// <summary>
        /// 图片列表
        /// </summary>
        /// <returns></returns>
        IList<Image> GetImageList(string Ids);
        IList<Image> GetImageGetFenlei(string fenlei);
        IList<Image> GetPicList();


    }
}
