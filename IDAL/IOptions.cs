using System;
using System.Collections.Generic;
using Lgwin.Model;

namespace Lgwin.IDAL
{
    public interface IOptions
    {
        /// <summary>
        /// 更新方法
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        bool Update(Options Model);
        /// <summary>
        /// 据广告位获得相应内容
        /// </summary>
        /// <param name="ad"></param>
        /// <returns></returns>
        Options GetOptions(string ad);

    }
}
