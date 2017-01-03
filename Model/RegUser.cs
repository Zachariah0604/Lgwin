using System;

namespace Lgwin.Model
{
    /// <summary>
    /// 用户注册
    /// </summary>
    public class RegUser
    {
        private int _userId;
        private string _userName;
        private string _passWord;
        private string _power;
        private string _admin;
        private string _namee;
        private string _img;
        private string _tel;
        private bool _pass;
        private string _email;
        private string _qq;
        private string _xuehao;
        private bool _zaizhi;
        private string _zhiwu;
        private string _year;
        private string _paixu;
        private string _jieshao;
        private DateTime _intime;
        private DateTime _outtime;
        private string _zybj;
        private string _jiguan;
        private DateTime _birthday;
        private string _ip;
        public RegUser()
        { }

        public RegUser(int UserId, string UserName, string PassWord, string Power, string Admin, string Namee, string Img, string Tel, bool Pass, string Email, string QQ, string Xuehao,bool Zaizhi,string Zhiwu,string Year,string Paixu,string Jieshao,DateTime Intime,DateTime Outtime,string Zhuanyebj,string Jiguan,DateTime Birthday,string Ip)
        {
            _userId = UserId;
            _userName = UserName;
            _passWord = PassWord;
            _power = Power;
            _admin = Admin;
            _namee = Namee;
            _img = Img;
            _tel = Tel;
            _pass = Pass;
            _email = Email;
            _qq = QQ;
            _xuehao = Xuehao;
            _zaizhi=Zaizhi;
            _zhiwu=Zhiwu;
            _year=Year;
            _paixu=Paixu;
            _jieshao=Jieshao;
            _intime=Intime;
            _outtime=Outtime;
            _zybj=Zhuanyebj;
            _jiguan=Jiguan;
            _birthday=Birthday;
            _ip = Ip;
        }

        /// <summary>
        /// 用户编号
        /// </summary>
        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord
        {
            get { return _passWord; }
            set { _passWord = value; }
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
        /// 管理权限
        /// </summary>
        public string Admin
        {
            get { return _admin; }
            set { _admin = value; }
        }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get { return _namee; }
            set { _namee = value; }
        }

        /// <summary>
        /// 相片地址
        /// </summary>
        public string Img
        {
            get { return _img; }
            set { _img = value; }
        }

        /// <summary>
        /// 电话
        /// </summary>
        public string Tel
        {
            get { return _tel; }
            set { _tel = value; }
        }

        /// <summary>
        /// 审核通过
        /// </summary>
        public bool Pass
        {
            get { return _pass; }
            set { _pass = value; }
        }

        /// <summary>
        /// Email
        /// </summary>
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        /// <summary>
        /// QQ号码
        /// </summary>
        public string QQ
        {
            get { return _qq; }
            set { _qq = value; }
        }

        /// <summary>
        /// 学号
        /// </summary>
        public string Xuehao
        {
            get { return _xuehao; }
            set { _xuehao = value; }
        }
        /// <summary>
        /// 是否在职
        /// </summary>
        public bool Zaizhi
        {
            get{return _zaizhi;}
            set{_zaizhi=value;}
        }
        /// <summary>
        /// 所任职务
        /// </summary>
        public string Zhiwu
        {
            get{return _zhiwu;}
            set{_zhiwu=value;}
        }
        /// <summary>
        /// 年级
        /// </summary>
        public string Nianji
        {
            get { return _year; }
            set { _year = value; }
        }
        /// <summary>
        /// 排列顺序
        /// </summary>
        public string Paixu
        {
            get { return _paixu; }
            set { _paixu = value; }
        }
        /// <summary>
        /// 个人简介
        /// </summary>
        public string Jieshao
        {
            get { return _jieshao; }
            set { _jieshao = value; }
        }
        /// <summary>
        /// 进入时间
        /// </summary>
        public DateTime Intime
        {
            get { return _intime; }
            set { _intime = value; }
        }
        public DateTime Outtime
        {
            get { return _outtime; }
            set { _outtime = value; }
        }
        /// <summary>
        /// 专业班级
        /// </summary>
        public string Zybj
        {
            get { return _zybj; }
            set { _zybj = value; }
        } 
        /// <summary>
        /// 籍贯
        /// </summary>
        public string Jiguan
        {
            get { return _jiguan; }
            set { _jiguan = value; }
        }
        /// <summary>
        /// 生日
        /// </summary>
        public DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }
        /// <summary>
        /// 登陆ip
        /// </summary>
        public string Ip
        {
            get { return _ip; }
            set { _ip = value; }
        } 
    }
}
