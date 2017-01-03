using System;

namespace Lgwin.Model
{
    public class Content
    {
        private int _Id;
        private string _Caption;
        private string _Title;
        private string _Subtitle;
        private string _Content;
        private DateTime _Datee;
        private int _Counter;
        private bool _Auditing;
        private string _Author;
        private string _Fro;
        private string _Editor;
        private string _Tel;
        private string _Url;
        private bool _Yaowen;
        private bool _Tuwen;
        private bool _Sdut;
        private bool _Sdutpic;
        private bool _Zixun;
        private string _Ztid;
        private string _Zt;
        private bool _Html;
        private string _SmailPic;
        private string _Editing;
        //private bool _Dangtuan;
        //private bool _Fuwu;
        //private bool _Bumen;
        //private bool _Kuaixun;
        private string _Keywords;
        private string _Forbiden;
        //private bool _Flag;
        private int _StateNow;

        public Content()
        {
            _Caption = string.Empty;
            _Title = string.Empty;
            _Subtitle = string.Empty;
            _Content = string.Empty;
            _Datee = DateTime.Now;
            _Counter = 0;
            _Auditing = false;
            _Fro = string.Empty;
            _Editor = string.Empty;
            _Tel = string.Empty;
            _Url = string.Empty;
            _Yaowen = false;
            _Tuwen = false;
            _Sdut = false;
            _Sdutpic = false;
            _Zixun = false;
            _Ztid = string.Empty;
            _Zt = string.Empty;
            _Html = false;
            _SmailPic = "0";
            _Editing = string.Empty;
            //_Dangtuan = false;
            //_Fuwu = false;
            //_Bumen = false;
            //_Kuaixun = false;
            //_Ztid2 = string.Empty;
            //_Zt2 = string.Empty;
            _Keywords = "0";
            _Forbiden = "0";
            //_Flag = true;
          
        }

        public int Id
        {
            get { return this._Id; }
            set { this._Id = value; }
        }
        /// <summary>
        /// 文章所属栏目
        /// </summary>
        public string Caption
        {
            get { return _Caption; }
            set { _Caption = value; }
        }

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        public string Subtitle
        {
            get { return _Subtitle; }
            set { _Subtitle = value; }
        }

        public string Contents
        {
            get { return _Content; }
            set { _Content = value; }
        }

        public DateTime Datee
        {
            get { return _Datee; }
            set { _Datee = value; }
        }

        public int Counter
        {
            get { return _Counter; }
            set { _Counter = value; }
        }

        public bool Auditing
        {
            get { return _Auditing; }
            set { _Auditing = value; }
        }

        public string Author
        {
            get { return _Author; }
            set { _Author = value; }
        }

        public string Fro
        {
            get { return _Fro; }
            set { _Fro = value; }
        }

        public string Editor
        {
            get { return _Editor; }
            set { _Editor = value; }
        }

        public string Tel
        {
            get { return _Tel; }
            set { _Tel = value; }
        }

        public string Url
        {
            get { return _Url; }
            set { _Url = value; }
        }

        public bool Yaowen
        {
            get { return _Yaowen; }
            set { _Yaowen = value; }
        }

        public bool Tuwen
        {
            get { return _Tuwen; }
            set { _Tuwen = value; }
        }

        public bool Sdut
        {
            get { return _Sdut; }
            set { _Sdut = value; }
        }

        public bool Sdutpic
        {
            get { return _Sdutpic; }
            set { _Sdutpic = value; }
        }
        public bool Zixun
        {
            get { return _Zixun; }
            set { _Zixun = value; }
        }
        /// <summary>
        /// 所属专题内的栏目Id
        /// </summary>
        public string Ztid
        {
            get { return _Ztid; }
            set { _Ztid = value; }
        }
        /// <summary>
        /// 所属专题简称
        /// </summary>
        public string Zt
        {
            get { return _Zt; }
            set { _Zt = value; }
        }

        public bool Html
        {
            get { return _Html; }
            set { _Html = value; }
        }

        //public string Ztid2
        //{
        //    get { return _Ztid2; }
        //    set { _Ztid2 = value; }
        //}

        //public string Zt2
        //{
        //    get { return _Zt2; }
        //    set { _Zt2 = value; }
        //}

        public string Smailpic
        {
            get { return _SmailPic; }
            set { _SmailPic = value; }
        }

        public string Editing
        {
            get { return _Editing; }
            set { _Editing = value; }
        }

        //public bool Dangtuan
        //{
        //    get { return _Dangtuan; }
        //    set { _Dangtuan = value; }
        //}

        //public bool Fuwu
        //{
        //    get { return _Fuwu; }
        //    set { _Fuwu = value; }
        //}

        //public bool Bumen
        //{
        //    get { return _Bumen; }
        //    set { _Bumen = value; }
        //}

        //public bool Kuaixun
        //{
        //    get { return _Kuaixun; }
        //    set { _Kuaixun = value; }
        //}

        public string Keywords
        {
            get { return _Keywords; }
            set { _Keywords = value; }
        }
        public string Forbiden
        {
            get { return _Forbiden; }
            set { _Forbiden = value; }
        }
        //public bool Flag
        //{
        //    get { return _Flag; }
        //    set { _Flag = value; }
        //}

        public int StateNow
        {
            get { return _StateNow; }
            set { _StateNow = value; }
        }
    }
}
