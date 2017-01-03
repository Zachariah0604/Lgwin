using System;

namespace Lgwin.Model
{
    public class ZtCaption
    {
        private int _id;
        private string _ztcaption;
        private string _ztid;

        /// <summary>
        /// 专题栏目ID
        /// </summary>
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// 专题栏目名字
        /// </summary>
        public string ZtCaptionName
        {
            get { return _ztcaption; }
            set { _ztcaption = value; }
        }

        /// <summary>
        /// 所属专题ID
        /// </summary>
        public string Ztid
        {
            get { return _ztid; }
            set { _ztid = value; }
        }


        public static object Equals { get; set; }
    }
}
