using System;
using System.Configuration;
using System.Reflection;
using Lgwin.IDAL;

namespace Lgwin.DALFactory
{
    /// <summary>
    /// 抽象工厂模式创建DAL(利用工厂模式+反射机制+缓存机制,实现动态创建不同的数据层对象接口)
    /// </summary>
    public sealed class DataAccess
    {
        public static readonly string path = ConfigurationSettings.AppSettings["DAL"];

        /// <summary>
        /// 创建对象或者从缓存中读取
        /// </summary>
        /// <param name="CacheKey">缓存键值</param>
        /// <returns>Object</returns>
        public static  T CreateObject<T>(string CacheKey)
        {
            T objType = DataCache.GetCache<T>(CacheKey);//从缓存读取
            if (objType == null)
            {
                objType = (T)Assembly.Load(path).CreateInstance(CacheKey + "DAL");//反射创建
                DataCache.SetCache<T>(CacheKey, objType);// 写入缓存
            }
            return objType;
        }

        /// <summary>
        /// 创建用户数据层接口
        /// </summary>
        /// <returns>IRegUser用户数据接口</returns>
        public static IRegUser CreatRegUser()
        {
            string CacheKey = path + ".RegUser";
            return CreateObject<IRegUser>(CacheKey);
        }

        /// <summary>
        /// 创建栏目数据层接口
        /// </summary>
        /// <returns>IClass用户数据接口</returns>
        public static IClass CreatClass()
        {
            string CacheKey = path + ".Class";
            return CreateObject<IClass>(CacheKey);
        }

        /// <summary>
        /// 创建栏目数据层接口
        /// </summary>
        /// <returns>IContent用户数据接口</returns>
        public static IContent CreatContent()
        {
            string CacheKey = path + ".Content";
            return CreateObject<IContent>(CacheKey);
        }

        /// <summary>
        /// 创建学院数据层接口
        /// </summary>
        /// <returns></returns>
        public static ICollege CreatCollege()
        {
            string CacheKey = path + ".College";
            return CreateObject<ICollege>(CacheKey);
        }

        /// <summary>
        /// 创建专题数据层接口
        /// </summary>
        /// <returns></returns>
        public static IZt CreatZt()
        {
            string CacheKey = path + ".Zt";
            return CreateObject<IZt>(CacheKey);
        }

        /// <summary>
        /// 创建专题栏目数据层接口
        /// </summary>
        /// <returns></returns>
        public static IZtCaption CreatZtCaption()
        {
            string CacheKey = path + ".ZtCaption";
            return CreateObject<IZtCaption>(CacheKey);
        }
        /// <summary>
        /// 创建图片数据层接口
        /// </summary>
        /// <returns></returns>
        public static IImage CreatImage()
        {
            string CacheKey = path + ".Image";
            return CreateObject<IImage>(CacheKey);
        }
        public static IOptions CreatOptions()
        {
            string CacheKey = path + ".Options";
            return CreateObject<IOptions>(CacheKey); 
        }
        public static IVideo CreatVideo()
        {
            string CacheKey = path + ".Video";
            return CreateObject<IVideo>(CacheKey);
        }
        /// <summary>
        /// 创建采访数据层接口
        /// </summary>
        /// <returns></returns>
        public static ICaiFang CreatCaiFang()
        {
            string CacheKey = path + ".CaiFang";
            return CreateObject<ICaiFang>(CacheKey);
        }
        /// <summary>
        /// 创建权限数据层接口
        /// </summary>
        /// <returns></returns>
        public static IPowerClass CreatPowerClass()
        {
            string CacheKey = path + ".PowerClass";
            return CreateObject<IPowerClass>(CacheKey);
        }
        ///// <summary>
        ///// 创建karat文章数据层接口
        ///// </summary>
        ///// <returns></returns>
        //public static IKaratContent CreatKaratContent()
        //{
        //    string CacheKey = path + ".KaratContent";
        //    return CreateObject<IKaratContent>(CacheKey);
        //}

        public static IKarat CreatKarat()
        {
            string CacheKey = path + ".Karat";
            return CreateObject<IKarat>(CacheKey);
        }
        
    }
}
