using System;

namespace Lgwin.Model
{
    public class Video
    {
        private int _userId;
        private string _userName;
        private string _title;
        private string _recommend;
        private string _HitNum;
        private DateTime _addtime;
        private string _uploader;
        private string _from;
        private string _url;
        private string _type;
        private string _href;
        private string _pic ;
         public int Id
        {
            get { return _userId; }
            set { _userId = value; }
        }
        /// <summary>
        /// 视频文件名
        /// </summary>
        public string Name
        {
            get { return _userName; }
            set { _userName = value; }
        }

        /// <summary>
        /// 视频标题
        /// </summary>
        public string  Title
        {
            get { return _title; }
            set { _title = value; }
        }
        /// <summary>
        /// 评论，点评
        /// </summary>
        public string  Recommend
        {
            get { return _recommend ; }
            set { _recommend = value; }
        }
        /// <summary>
        /// 点击量
        /// </summary>
       public string  HitNum
        {
            get { return _HitNum ; }
            set { _HitNum = value; }
        }
        /// <summary>
        /// 上传时间
        /// </summary>
       public DateTime  AddDate
        {
            get { return _addtime ; }
            set { _addtime = value; }
        }
        /// <summary>
        /// 上传者
        /// </summary>
       public string  Uploader
        {
            get { return _uploader ; }
            set { _uploader = value; }
        }
        /// <summary>
        /// 视频来源
        /// </summary>
       public string  From
        {
            get { return _from ; }
            set { _from = value; }
        }
        /// <summary>
        /// 文件的Url地址
        /// </summary>
       public string Url
       {
           get { return _url; }
           set { _url = value; }
       }
        /// <summary>
        /// 音频还是视频
        /// </summary>
       public string Type
       {
           get { return _type; }
           set { _type = value; }
       }
        /// <summary>
        /// 文件指向的链接
        /// </summary>
       public string Href
       {
           get { return _href; }
           set { _href = value; }
       }
       /// <summary>
       /// 视频缩略图
       /// </summary>
       public string Pic
       {
           get { return _pic; }
           set { _pic = value; }
       }
    }
    public class Video1
    {
        public Video1()
        { }
        public Video1(int id, string Lanmu, string Title, string Author, string VideoName, string Jianjie, string Editor, string Datee, DateTime Time, int HitCount, string FromTo, string ToUrl, string Url, string PicURL, bool Pass, bool IndexRec)
        {
        }
        public int id { get; set; }
        public string Lanmu { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string VideoName { get; set; }
        public string Jianjie { get; set; }
        public string Editor { get; set; }
        public string Datee { get; set; }
        public DateTime Time { get; set; }
        public int HitCount { get; set; }
        public string FromTo { get; set; }
        public string ToUrl { get; set; }
        public string Url { get; set; }
        public string PicURL { get; set; }
        public bool Pass { get; set; }
        public bool IndexRec { get; set; }
    }
}