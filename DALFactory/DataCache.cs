using System.Web;
using System.Collections.Generic;

namespace Lgwin.DALFactory
{
    /// <summary>
    /// 缓存数据操作类
    /// </summary>
    public class DataCache
    {

        /// <summary>
        /// 防止多线程创建 Add by overred
        /// </summary>
        public static object _syncRoot = new object();

        /// <summary>
        /// 获取当前应用程序指定CacheKey的Cache值
        /// </summary>
        /// <param name="CacheKey">缓存键值</param>
        /// <returns>Object</returns>
        public static T GetCache<T>(string CacheKey)
        {
            System.Web.Caching.Cache objCache = HttpRuntime.Cache;
            return (T)objCache[CacheKey];
        }

        /// <summary>
        /// 设置当前应用程序指定CacheKey的Cache值
        /// </summary>
        /// <param name="CacheKey">缓存键值</param>
        /// <param name="objObject">要缓存的对象</param>
        public static void SetCache<T>(string CacheKey, T objObject)
        {
            lock (_syncRoot)
            {
                System.Web.Caching.Cache objCache = HttpRuntime.Cache;
                objCache.Insert(CacheKey, objObject);
            }
        }
    }
}
