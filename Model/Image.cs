using System;

namespace Lgwin.Model
{
   public class Image
    {
        private string _id;
        private string _name;
        private string _url;
        private string _type;
        private string _href;
        private bool _on;
        private string _feilei;
        /// <summary>
        /// 图片ID
        /// </summary>
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// 图片名字
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }
        /// <summary>
        /// 类型，Pic or Flash
        /// </summary>
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
       /// <summary>
       /// 链接地址
       /// </summary>
        public string Href
        {
            get { return _href; }
            set { _href = value; }
        }
       /// <summary>
       /// 是否在首页显示
       /// </summary>
        public bool On
        {
            get { return _on; }
            set { _on = value; }
        }
        public string FenLei
        {
            get { return _feilei; }
            set { _feilei = value; }
        }
    }

   public class Pic
   {
       public Pic()
       { }
       public Pic(int id, string Title, string Jianjie, string Position, int Type, string ToUrl, string Url, string Datee, bool Pass)
       {
       }

       /// <summary>
       /// 
       /// </summary>
       public int id
       {
           set;
           get;
       }
       /// <summary>
       /// 
       /// </summary>
       public string Title
       {
           set;
           get;
       }
       /// <summary>
       /// 
       /// </summary>
       public string Jianjie
       {
           set;
           get;
       }
       /// <summary>
       /// 
       /// </summary>
       public string Position
       {
           set;
           get;
       }
       /// <summary>
       /// 
       /// </summary>
       public int Type
       {
           set;
           get;
       }
       /// <summary>
       /// 
       /// </summary>
       public string ToUrl
       {
           set;
           get;
       }
       /// <summary>
       /// 
       /// </summary>
       public string Url
       {
           set;
           get;
       }
       /// <summary>
       /// 
       /// </summary>
       public string Datee
       {
           set;
           get;
       }
       /// <summary>
       /// 
       /// </summary>
       public bool Pass
       {
           set;
           get;
       }

   }
}
