using System;

namespace Lgwin.Model
{
    public class College
    {
        private int _id;
        private string _name;
        private bool _type;
        private int _xu;

        /// <summary>
        /// 学院编号
        /// </summary>
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// 学院名字
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///是否学校机构
        /// </summary>
        public bool Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        /// 排序序号
        /// </summary>
        public int Xu
        {
            get { return _xu; }
            set { _xu = value; }
        }
    }
}