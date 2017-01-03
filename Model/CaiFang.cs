using System;

namespace Lgwin.Model
{
    public class CaiFang
    {
        private int _Id;
        private string _Title;
        private string _Time;
        private string _Place;
        private string _Organization;
        private string _Leader;
        private string _Description;

        public CaiFang()
        {
            _Title = string.Empty;
            _Time = string.Empty;
            _Place = string.Empty;
            _Organization = string.Empty;
            _Leader = string.Empty;
            _Description =string.Empty;
        }

        public int Id
        {
            get { return this._Id; }
            set { this._Id = value; }
        }

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }


        public string Time
        {
            get { return _Time; }
            set { _Time = value; }
        }


        public string Place
        {
            get { return _Place; }
            set { _Place = value; }
        }

        public string Organization
        {
            get { return _Organization; }
            set { _Organization = value; }
        }

        public string Leader
        {
            get { return _Leader; }
            set { _Leader = value; }
        }

        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

    }
}
