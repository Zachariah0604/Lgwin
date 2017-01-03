using System;

namespace Lgwin.Model
{
    /// <summary>
    /// 分类
    /// </summary>
    public class Class
    {
        private int _id;
        private string _tid;
        private string _title;
        private string _power;
        private string _paixu;
        private bool _show;

        public Class()
        { 
            //null
        }

        /// <summary>
        /// 分类
        /// </summary>
        /// <param name="Id">编号</param>
        /// <param name="Tid">序号</param>
        /// <param name="Title">标题</param>
        /// <param name="Power">权限</param>
        public Class(int Id, string Tid, string Title, string Power,bool Show)
        {
            this._id = Id;
            this._tid = Tid;
            this._title = Title;
            this._power = Power;
            this._show = Show;
        }

        /// <summary>
        /// 分类的Id
        /// </summary>
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// 分类的序号
        /// </summary>
        public string Tid
        {
            get { return _tid; }
            set { _tid = value; }
        }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title
        {
            get
            { return _title; }
            set
            { _title = value; }
        }

        /// <summary>
        /// 权限
        /// </summary>
        public string Power
        {
            get { return _power; }
            set { _power = value; }
        }
        public string PaiXu
        {
            get { return _paixu; }
            set { _paixu = value; }
        }
        public bool Show
        {
            get { return _show; }
            set { _show = value; }
        }
    }
}
