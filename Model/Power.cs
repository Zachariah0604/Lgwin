using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lgwin.Model
{
    /// <summary>
    /// 权限
    /// </summary>
    public class Power
    {
        private string _UserName;
        private string _Admin;
        private string _Caption;
        private bool _Zaizhi;
        private string _Zhiwu;

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        /// <summary>
        /// 管理员权限
        /// </summary>
        public string Admin
        {
            get { return _Admin; }
            set { _Admin = value; }
        }

        /// <summary>
        /// 栏目权限
        /// </summary>
        public string Caption
        {
            get { return _Caption; }
            set { _Caption = value; }
        }

        /// <summary>
        /// 是否在岗
        /// </summary>
        public bool ZaiZhi
        {
            get { return _Zaizhi; }
            set { _Zaizhi = value; }
        }

        /// <summary>
        /// 职务
        /// </summary>
        public string Zhiwu
        {
            get { return _Zhiwu; }
            set { _Zhiwu = value; }
        }
    }
}
