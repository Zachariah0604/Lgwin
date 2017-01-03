using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lgwin.Model
{
   public  class Photo
    {
        public Photo() { }
        /// <summary>
        ///相同属性名
        /// </summary>
        private int _id;
        private string _name;
        private string _pagename;
        /// <summary>
        /// 栏目属性
        /// </summary>
        private string _zhtname;
        private int _zhtid;
        private string _introduction;
        private DateTime _created_time;
        /// <summary>
        /// 图片信息
        /// </summary>
        /// private int _id;
        private string _shuoming;
        private string _zuozhe;
        private string _path;
        private string _path_small;
        private int _lmid;
        private string _lmname;
        private string _tuijian;
        private string _shouye;
        private string _redian;
        private string _xww;
        private string _xshshch;
        private DateTime _upload_time;
        private string _editor;
        /// <summary>
        /// 专题信息
        /// </summary>
        private int _paixu;
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        public string name
        {
            set { _name = value; }
            get { return _name; }
        }
        public string zhtname
        {
            set { _zhtname = value; }
            get { return _zhtname; }
        }
        public int zhtID
        {
            set { _zhtid = value; }
            get { return _zhtid; }
        }
        public string pagename
        {
            set { _pagename = value; }
            get { return _pagename; }
        }
        public string introduction
        {
            set { _introduction = value; }
            get { return _introduction; }
        }
        public DateTime upload_time 
        {
            set { _upload_time=value ;}
            get { return _upload_time; }
        }
        public DateTime created_time
        {
            set { _created_time = value; }
            get { return _created_time; }
        }
        public string shuoming
        {
            set { _shuoming = value; }
            get { return _shuoming; }
        }
        public string zuozhe
        {
            set { _zuozhe = value; }
            get { return _zuozhe; }
        }
        public string path
        {
            set { _path = value; }
            get { return _path; }
        }
        public string path_small
        {
            set { _path_small = value; }
            get { return _path_small; }
        }
        public int lmID
        {
            set { _lmid = value; }
            get { return _lmid; }
        }
        public string lmname
        {
            set { _lmname = value; }
            get { return _lmname; }
        }
        public string tuijian
        {
            set { _tuijian = value; }
            get { return _tuijian; }
        }
        public string shouye
        {
            set { _shouye = value; }
            get { return _shouye; }
        }
        public string redian
        {
            set { _redian = value; }
            get { return _redian; }
        }
        public string xww
        {
            set { _xww = value; }
            get { return _xww; }
        }
        public string xshshch
        {
            set { _xshshch = value; }
            get { return _xshshch; }
        }
        public string editor
        {
            set { _editor = value; }
            get { return _editor; }
        }
        public int paixu
        {
            set { _paixu = value; }
            get { return _paixu; }
        }

    }
    
}
