using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lgwin.Model
{

    /// <summary>
    /// 分类
    /// </summary>
    public class PowerClass
    {
        private int _id;
        private string _power;
        private string _class;

        public PowerClass()
        {
            //null
        }

        /// <summary>
        /// 权限类别
        /// </summary>
        /// <param name="Id">id</param>
        /// <param name="Power">权限</param>
        /// <param name="Power">权限类别</param>
        public PowerClass(int Id, string Power,string Class)
        {
            this._id = Id;
            this._power = Power;
            this._class = Class;
        }

        /// <summary>
        /// 权限的Id
        /// </summary>
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// 权限
        /// </summary>
        public string Power
        {
            get { return _power; }
            set { _power = value; }
        }
        /// <summary>
        /// 权限类别
        /// </summary>
        public string Class
        {
            get { return _class; }
            set { _class = value; }
        }
    }
}
