using System;

namespace Lgwin.Model
{
    /// <summary>
    /// 专题名
    /// </summary>
    public class Zt
    {
        private int _id;
        private string _ztname;
        private string _px;
        private bool _show;
        private string _ztjch;

        /// <summary>
        /// 专题ID
        /// </summary>
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// 专题名字
        /// </summary>
        public string Ztname
        {
            get { return _ztname; }
            set { _ztname = value; }
        }

        /// <summary>
        /// 专题排序
        /// </summary>
        public string Px
        {
            get { return _px; }
            set { _px = value; }
        }

        /// <summary>
        /// 专题是否显示
        /// </summary>
        public bool Show
        {
            get { return _show; }
            set { _show = value; }
        }
        /// <summary>
        /// 专题简称
        /// </summary>
        public string ZtJiancheng
        {
            get { return _ztjch; }
            set { _ztjch = value; }
        }
    }
}
