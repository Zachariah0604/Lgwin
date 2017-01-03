using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lgwin.Model
{
    public class Karat
    {
        private int _Id;
        private string _Caption;
        private string _Name;
        private string _Topic;
        private string _M_Content;
        private string _R_Content;
        private string _Zan;
        private DateTime _M_time;
        private DateTime _R_time;
        private string _LanMu;
        private string _Author;
        private bool _IndexComment;
        private bool _Pass;
        private string _Email;
        private string _Auditor;
        //Karat_Content
        private string _Title;
        private string _SubTitle;
        private string _Content;
        private DateTime _Time;
        private string _Url;
        private string _Imgurl;
        //Karat_Events
        private string _From_Year;
        //private string _From_Month;
        private string _From_Content;
        //karat_work
        private string _Type;
        private string _Tool;
        private string _Href;
        //karat_type
        private string _Type_Name;
        //karat_members
        private string _bumen;
        private string _zhiwu;
        private string _qq;
        private string _tel;
        private string _yuanxi;
        private bool _zaizhi;
        private string _beizhu;
        private string _year;
        //karat_baoming

        private string _Xingbie;
        private string _Zhuanye;
        private string _Xiaoqu;
        private string _Diannao;
        private string _Jiguan;
        private string _Zhiwei;
        private string _Kaoyan;
      private string _Blog;
        private string _Show;
        private string _Jianjie;
        private string _TelTel;
        private string _Ip;
       



        public Karat()
        {
            _Caption = string.Empty;
            _Name = string.Empty;
            _Topic = string.Empty;
            _M_Content = string.Empty;
            _R_Content = string.Empty;
            _Zan = string.Empty;
            _M_time = DateTime.Now;
            _R_time = DateTime.Now;
            _Author = string.Empty;
            _IndexComment = false;
            _Pass = false;
            _LanMu = string.Empty;
            _Auditor = string.Empty;
            _Email = string.Empty;

            _Title = string.Empty;
            _SubTitle = string.Empty;
            _Content = string.Empty;
            _Url = string.Empty;
            //_Time = DateTime.Now;
            _Imgurl = string.Empty;

            _From_Year = string.Empty;
            //_From_Month = string.Empty;
            _From_Content = string.Empty;

            _Type = string.Empty;
            _Tool = string.Empty;
            _Href = string.Empty;

            _Type_Name = string.Empty;
            _Ip = string.Empty;


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


        public DateTime Time
        {
            get { return _Time; }
            set { _Time = value; }
        }

        public string Content
        {
            get { return _Content; }
            set { _Content = value; }
        }

        public string SubTitle
        {
            get { return _SubTitle; }
            set { _SubTitle = value; }
        }

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        public string Url
        {
            get { return _Url; }
            set { _Url = value; }
        }

        public string Imgurl
        {
            get { return _Imgurl; }
            set { _Imgurl = value; }
        }

        public string From_Year
        {
            get { return _From_Year; }
            set { _From_Year = value; }
        }

        //public string From_Month
        //{
        //    get { return _From_Month; }
        //    set { _From_Month = value; }
        //}

        public string From_Content
        {
            get { return _From_Content; }
            set { _From_Content = value; }
        }

        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        public string Tool
        {
            get { return _Tool; }
            set { _Tool = value; }
        }

        public string Href
        {
            get { return _Href; }
            set { _Href = value; }
        }

        /// <summary>
        /// 类型
        /// </summary>
        public string Type_Name
        {
            get { return _Type_Name; }
            set { _Type_Name = value; }
        }

        /// <summary>
        /// 文章所属栏目
        /// </summary>
        public string LanMu
        {
            get { return _LanMu; }
            set { _LanMu = value; }
        }

        /// <summary>
        /// 文章标题
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        /// <summary>
        /// 文章副标题
        /// </summary>
        public string Topic
        {
            get { return _Topic; }
            set { _Topic = value; }
        }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        /// <summary>
        /// 采编人员
        /// </summary>
        public string Auditor
        {
            get { return _Auditor; }
            set { _Auditor = value; }
        }

        /// <summary>
        /// 留言内容
        /// </summary>
        public string M_Content
        {
            get { return _M_Content; }
            set { _M_Content = value; }
        }

        /// <summary>
        /// 回复内容
        /// </summary>
        public string R_Content
        {
            get { return _R_Content; }
            set { _R_Content = value; }
        }
        public string Zan
        {
            get { return _Zan; }
            set { _Zan = value; }
        }
        /// <summary>
        /// 增加时间
        /// </summary>
        public DateTime M_time
        {
            get { return _M_time; }
            set { _M_time = value; }
        }

        /// <summary>
        /// 回复时间
        /// </summary>
        public DateTime R_time
        {
            get { return _R_time; }
            set { _R_time = value; }
        }

        /// <summary>
        /// 作者
        /// </summary>
        public string Author
        {
            get { return _Author; }
            set { _Author = value; }
        }

        /// <summary>
        /// 是否推荐karat首页
        /// </summary>
        public bool IndexComment
        {
            get { return _IndexComment; }
            set { _IndexComment = value; }
        }

        /// <summary>
        /// 是否通过验证
        /// </summary>
        public bool Pass
        {
            get { return _Pass; }
            set { _Pass = value; }
        }
        public string Ip
        {
            get { return _Ip; }
            set { _Ip = value; }
        }

        #region karat_member
        public string Zhiwu
        {
            get { return _zhiwu; }
            set { _zhiwu = value; }
        }
        public string Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public string Beizhu
        {
            get { return _beizhu; }
            set { _beizhu = value; }
        }

        public string Yuanxi
        {
            get { return _yuanxi; }
            set { _yuanxi = value; }
        }




        public string Bumen
        {
            get { return _bumen; }
            set { _bumen = value; }
        }

        public bool Zaizhi
        {
            get { return _zaizhi; }
            set { _zaizhi = value; }
        }

        public string Qq
        {
            get { return _qq; }
            set { _qq = value; }
        }

        public string Tel
        {
            get { return _tel; }
            set { _tel = value; }
        }
        #endregion
        #region 卡瑞特报名层


        public string Xingbie
        {
            get { return _Xingbie; }
            set { _Xingbie = value; }
        }

        public string Zhuanye
        {
            get { return _Zhuanye; }
            set { _Zhuanye = value; }
        }

        public string Xiaoqu
        {
            get { return _Xiaoqu; }
            set { _Xiaoqu = value; }
        }

        public string Diannao
        {
            get { return _Diannao; }
            set { _Diannao = value; }
        }

        public string Jiguan
        {
            get { return _Jiguan; }
            set { _Jiguan = value; }
        }

        public string Zhiwei
        {
            get { return _Zhiwei; }
            set { _Zhiwei = value; }
        }
        public string Kaoyan
        {
            get { return _Kaoyan; }
            set { _Kaoyan = value; }
        }

        public string Blog
        {
            get { return _Blog; }
            set { _Blog = value; }
        }

        public string Show
        {
            get { return _Show; }
            set { _Show = value; }
        }

        public string Jianjie
        {
            get { return _Jianjie; }
            set { _Jianjie = value; }
        }

        public string TelTel
        {
            get { return _TelTel; }
            set { _TelTel = value; }
        }

        #endregion
    }

    public class Karatbaoming
    {
        private int _Id;
        private string _Sex;
        private string _Name;
        private string _Xueyuan;
        private string _Banji;
        private string _Xiaoqu;
        private string _Diannao;
        private string _Email;
        private string _Zhiwei;
        private string _Kaoyan;
       private string _Blog;
        private string _Zuopin;
        private string _Tel;
        private string _Jianjie;
        private string _Touxiang;
        private string _Her;
        private DateTime _Datee;
        private string _Xuehao;
        private string _Renzhi;
        private string _Qq;
        private string _Qita;
        private string _Jingli;
        private string _Ip;
        private string _HostName;

         private string _club_exp;
        private string _orge_exp;
      
        private string _get_award;
        private string _write_able;
        private string _grade;
        private string _freetime;
        private string _work_time;

      
       
   
      
     
      
        
       
       
        public Karatbaoming()
        {
            _Sex = string.Empty;
            _Name = string.Empty;
            _Xueyuan = string.Empty;
            _Banji = string.Empty;
            _Xiaoqu = string.Empty;
            _Diannao = string.Empty;
            _Email = string.Empty; ;
            _Zhiwei = string.Empty;
            _Kaoyan = string.Empty;
          _Blog = string.Empty;
            _Zuopin = string.Empty;
            _Tel = string.Empty;
            _Jianjie = string.Empty;
            _Touxiang = string.Empty;

            _Her = string.Empty;
            _Datee = DateTime.Now;
            _Xuehao = string.Empty;
            _Renzhi = string.Empty;
            _Qq = string.Empty;
            _Qita = string.Empty;
            _Jingli = string.Empty;
            _Ip = string.Empty;
            _HostName = string.Empty;
            _club_exp=string.Empty;
            _orge_exp=string.Empty;
            _get_award=string.Empty;
            _write_able=string.Empty;
            _grade=string.Empty;
            _freetime=string.Empty;
            _work_time=string.Empty;
        }

        public int Id
        {
            get { return this._Id; }
            set { this._Id = value; }
        }

        public string Sex
        {
            get { return _Sex; }
            set { _Sex = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string Xueyuan
        {
            get { return _Xueyuan; }
            set { _Xueyuan = value; }
        }

        public string Banji
        {
            get { return _Banji; }
            set { _Banji = value; }
        }

        public string Xiaoqu
        {
            get { return _Xiaoqu; }
            set { _Xiaoqu = value; }
        }


        public string Diannao
        {
            get { return _Diannao; }
            set { _Diannao = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public string Zhiwei
        {
            get { return _Zhiwei; }
            set { _Zhiwei = value; }
        }
        public string Kaoyan
        {
            get { return _Kaoyan; }
            set { _Kaoyan = value; }
        }
        public string Blog
        {
            get { return _Blog; }
            set { _Blog = value; }
        }

        public string Zuopin
        {
            get { return _Zuopin; }
            set { _Zuopin = value; }
        }

        public string Tel
        {
            get { return _Tel; }
            set { _Tel = value; }
        }

        public string Jianjie
        {
            get { return _Jianjie; }
            set { _Jianjie = value; }
        }

        public string Touxiang
        {
            get { return _Touxiang; }
            set { _Touxiang = value; }
        }
        public string Her
        {
            get { return _Her; }
            set { _Her = value; }
        }
        public DateTime Datee
        {
            get { return _Datee; }
            set { _Datee = value; }
        }
        public string Xuehao
        {
            get { return _Xuehao; }
            set { _Xuehao = value; }
        }
        public string Renzhi
        {
            get { return _Renzhi; }
            set { _Renzhi = value; }
        }
        public string Qq
        {
            get { return _Qq; }
            set { _Qq = value; }
        }
        public string Qita
        {
            get { return _Qita; }
            set { _Qita = value; }
        }
        public string Jingli
        {
            get { return _Jingli; }
            set { _Jingli = value; }
        }
        public string Ip
        {
            get { return _Ip; }
            set { _Ip = value; }
        }
        public string HostName
        {
            get { return _HostName; }
            set { _HostName = value; }
        }
        public string club_exp
        {
            get { return _club_exp; }
            set { _club_exp = value; }
        }
        public string orge_exp
        {
            get { return _orge_exp; }
            set { _orge_exp = value; }
        }
      
        public string get_award
        {
            get { return _get_award;  }
            set { _get_award = value; }
        }
        public string write_able
        {
            get { return _write_able; }
            set { _write_able = value; }
        }
     
        public string grade
        {
            get { return  _grade; }
            set {  _grade= value; }
        }
        public string freetime
        {
            get { return _freetime; }
            set { _freetime = value; }
        }
        public string work_time
        {
            get { return _work_time; }
            set { _work_time = value; }
        }
        
    }
}
