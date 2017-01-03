using System;
using System.Collections.Generic;
using Lgwin.Model;

namespace Lgwin.IDAL
{
    /// <summary>
    /// 权限接口服务
    /// </summary>
    public interface IPower
    {
        Power Get(string Users);

        bool Update(Power Model);


    }
}
