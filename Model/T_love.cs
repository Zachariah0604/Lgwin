using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lgwin.Model
{
    public class T_love
    {
        private string _id;
        private string _author;
        private string _ccontent;
        private string _tagbgcolor;
        private string _tagbgpic;
        private string _subtime;

        /// <summary>
        /// 学院编号
        /// </summary>
        public string id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// 学院名字
        /// </summary>
        public string author
        {
            get { return _author; }
            set { _author = value; }
        }

        /// <summary>
        ///是否学校机构
        /// </summary>
        public string ccontent
        {
            get { return _ccontent; }
            set { _ccontent = value; }
        }

        /// <summary>
        /// 排序序号
        /// </summary>
        public string tagbgcolor
        {
            get { return _tagbgcolor; }
            set { _tagbgcolor = value; }
        }
        public string tagbgpic
        {
            get { return _tagbgpic; }
            set { _tagbgpic = value; }
        }
        public string subtime
        {
            get { return _subtime; }
            set { _subtime = value; }
        }
    }
}