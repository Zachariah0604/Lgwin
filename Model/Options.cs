using System;
namespace Lgwin.Model
{
    public class Options
    {
        private int _Id;
        private string _nr;
        private string _ad;
        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            get { return this._Id; }
            set { this._Id = value; }
        }
        /// <summary>
        /// 广告位中的内容
        /// </summary>
        public string Nr
        {
            get { return _nr; }
            set { _nr = value; }
        }
        /// <summary>
        /// 所属广告位
        /// </summary>
        public string AD
        {
            get { return _ad; }
            set { _ad = value; }
        }
    }
}
