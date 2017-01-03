using System;
using System.Data;
using Lgwin.Model;
using System.Reflection;

namespace Lgwin.SqlDAL
{
    /// <summary>
    /// 将DataReader的当前行数据转化为对象。
    /// </summary>
    public class Transform
    {
        /// <summary>
        /// 将DataReader的当前行数据转化为注册用户对象
        /// </summary>
        /// <param name="dr">DataReader的当前行数据</param>
        /// <returns>注册用户对象</returns>
        public static RegUser ToRegUser(IDataRecord dr)
        {
            RegUser Model = new RegUser();
            Model.UserId = int.Parse(dr["id"].ToString());
            Model.UserName = dr["users"].ToString().Trim();
            Model.PassWord = dr["pwd"].ToString().Trim();
            Model.Power = dr["power"].ToString().Trim();
            Model.Admin = dr["admin"].ToString().Trim();
            Model.Name = dr["namee"].ToString().Trim();
            Model.Img = dr["img"].ToString();
            Model.Tel = dr["tel"].ToString();
            Model.Pass = bool.Parse(dr["pass"].ToString());
            Model.Email = dr["Email"].ToString().Trim();
            Model.QQ = dr["QQ"].ToString().Trim();
            Model.Xuehao = dr["xuehao"].ToString().Trim();
            Model.Zaizhi = bool.Parse(dr["zaizhi"].ToString());
            Model.Zhiwu = dr["zhiwu"].ToString().Trim();
            Model.Nianji = dr["year"].ToString().Trim();
            Model.Paixu = dr["paixu"].ToString().Trim();
            Model.Jieshao = dr["jieshao"].ToString().Trim();
            if (!Convert.IsDBNull(dr["intime"]))
                Model.Intime = Convert.ToDateTime(dr["intime"].ToString());
            else
                Model.Intime = DateTime.Parse("0001-01-01");
            if (!Convert.IsDBNull(dr["outtime"]))
                Model.Outtime = Convert.ToDateTime(dr["outtime"].ToString());
            else
                Model.Outtime = DateTime.Parse("0001-01-01");
            Model.Zybj = dr["zybj"].ToString().Trim();
            Model.Jiguan = dr["jiguan"].ToString().Trim();
            if (!Convert.IsDBNull(dr["birthday"]))
                Model.Birthday = Convert.ToDateTime(dr["birthday"].ToString());
            else
                Model.Birthday = DateTime.Parse("0001-01-01");
            Model.Ip = dr["ip"].ToString().Trim();// 登陆ip

            return Model;
        }

        /// <summary>
        /// 将DataReader的当前行数据转化为类别对象。
        /// </summary>
        /// <param name="dr">ataReader的当前行数据</param>
        /// <returns>类别对象</returns>
        public static Class ToClass(IDataRecord dr)
        {
            Class Model = new Class();
            Model.Id = int.Parse(dr["id"].ToString());
            Model.Tid = dr["tid"].ToString().Trim();
            Model.Title = dr["title"].ToString().Trim();
            Model.Power = dr["power"].ToString().Trim();
            Model.PaiXu = dr["paixu"].ToString().Trim();
            Model.Show = Convert.ToBoolean(dr["show"].ToString());
            return Model;
        }

        public static Content ToContent(IDataRecord dr)
        {
            Content Model = new Content();

            Model.Id = int.Parse(dr["id"].ToString());
            Model.Caption = dr["caption"].ToString().Trim();
            Model.Title = dr["title"].ToString().Trim();
            Model.Subtitle = dr["subtitle"].ToString().Trim();
            Model.Contents = dr["content"].ToString();
            Model.Datee = Convert.ToDateTime(dr["datee"].ToString());
            if (!Convert.IsDBNull(dr["counter"]))
                Model.Counter = Convert.ToInt32(dr["counter"].ToString());
            else
                Model.Counter = 0;
            //Model.Counter = int.Parse(dr["counter"].ToString());
            Model.Auditing = bool.Parse(dr["auditing"].ToString());
            Model.Author = dr["author"].ToString().Trim();
            Model.Fro = dr["fro"].ToString();
            Model.Editor = dr["editor"].ToString();
            Model.Tel = dr["tel"].ToString();
            Model.Url = dr["url"].ToString();
            Model.Yaowen = bool.Parse(dr["yaowen"].ToString());
            Model.Tuwen = bool.Parse(dr["tuwen"].ToString());
            Model.Sdut = bool.Parse(dr["sdut"].ToString());
            Model.Sdutpic = bool.Parse(dr["sdutpic"].ToString());
            Model.Zixun = bool.Parse(dr["zixun"].ToString());
            Model.Forbiden = dr["forbiden"].ToString();
            Model.Ztid = dr["ztid"].ToString();
            Model.Zt = dr["zt"].ToString();
            Model.Html = bool.Parse(dr["html"].ToString());
            Model.Smailpic = dr["smallpic"].ToString();
            Model.Editing = dr["editing"].ToString();
            Model.Keywords = dr["keywords"].ToString();
            //Model.Dangtuan = bool.Parse(dr["dangtuan"].ToString());
            //Model.Fuwu = bool.Parse(dr["fuwu"].ToString());
            //Model.Bumen = bool.Parse(dr["bumen"].ToString());
            //Model.Kuaixun = bool.Parse(dr["kuaixun"].ToString());
            //Model.Ztid2 = dr["ztid2"].ToString();
            //Model.Zt2 = dr["zt2"].ToString();

            return Model;
        }

        public static Content ToContentList(IDataRecord dr)
        {
            Content Model = new Content();

            Model.Id = int.Parse(dr["id"].ToString());
            Model.Caption = dr["caption"].ToString().Trim();
            Model.Title = dr["title"].ToString().Trim();
            Model.Subtitle = dr["subtitle"].ToString().Trim();
            Model.Datee = Convert.ToDateTime(dr["datee"].ToString());
            if (!Convert.IsDBNull(dr["counter"]))
                Model.Counter = Convert.ToInt32(dr["counter"].ToString());
            else
                Model.Counter = 0;
            //Model.Counter = int.Parse(dr["counter"].ToString());
            Model.Auditing = bool.Parse(dr["auditing"].ToString());
            Model.Author = dr["author"].ToString().Trim();
            Model.Fro = dr["fro"].ToString();
            Model.Contents=dr["content"].ToString();
            Model.Editor = dr["editor"].ToString();
            Model.Tel = dr["tel"].ToString();
            Model.Url = dr["url"].ToString();
            Model.Yaowen = bool.Parse(dr["yaowen"].ToString());
            Model.Tuwen = bool.Parse(dr["tuwen"].ToString());
            Model.Sdut = bool.Parse(dr["sdut"].ToString());
            Model.Sdutpic = bool.Parse(dr["sdutpic"].ToString());
            
            //Model.Zixun = bool.Parse(dr["zixun"].ToString());
            Model.Forbiden = dr["forbiden"].ToString();
            Model.Ztid = dr["ztid"].ToString();
            Model.Zt = dr["zt"].ToString();
            Model.Html = bool.Parse(dr["html"].ToString());
            Model.Smailpic = dr["smallpic"].ToString();
            Model.Editing = dr["editing"].ToString();
            Model.StateNow = Convert.ToInt32(dr["StateNow"]);
            return Model;
        }

        public static Zt ToZt(IDataRecord dr)
        {
            Zt ztinfo = new Zt();
            ztinfo.Id = int.Parse(dr["id"].ToString());
            ztinfo.Ztname = dr["ztname"].ToString();
            ztinfo.Px = dr["px"].ToString();
            ztinfo.Show = bool.Parse(dr["show"].ToString());
            //if (!Convert.IsDBNull(dr["ztjiancheng"]))
            ztinfo.ZtJiancheng = dr["ztjiancheng"].ToString();
            //else
            //ztinfo.ZtJiancheng = "";
            return ztinfo;
        }

        public static ZtCaption ToZtCaption(IDataRecord dr)
        {
            ZtCaption Model = new ZtCaption();
            Model.Id = int.Parse(dr["id"].ToString());
            Model.ZtCaptionName = dr["ztcaption"].ToString();
            Model.Ztid = dr["ztid"].ToString();

            return Model;
        }

        public static College ToCollege(IDataRecord dr)
        {
            College Model = new College();
            Model.Id = int.Parse(dr["id"].ToString());
            Model.Name = dr["name"].ToString();
            Model.Type = bool.Parse(dr["type"].ToString());
            Model.Xu = int.Parse(dr["xu"].ToString());

            return Model;
        }

        public static Image ToImage(IDataReader dr)
        {
            Image model = new Image();
            model.Id = dr["id"].ToString();
            model.Name = dr["name"].ToString();
            model.Url = dr["url"].ToString();
            model.Type = dr["type"].ToString();
            model.Href = dr["href"].ToString();
            model.On = bool.Parse(dr["on"].ToString());
            model.FenLei = dr["fenlei"].ToString();
            return model;
        }

        public static Options ToOptions(IDataReader dr)
        {
            Options model = new Options();
            model.Id = int.Parse(dr["id"].ToString());
            model.Nr = dr["nr"].ToString();
            model.AD = dr["name"].ToString();
            return model;
        }

        public static Video ToVideo(IDataReader dr)
        {
            Video model = new Video();
            model.Id = int.Parse(dr["id"].ToString());
            model.Name = dr["name"].ToString();
            model.Title = dr["title"].ToString();
            model.Recommend = dr["Recommend"].ToString();
            model.HitNum = dr["HitNum"].ToString();
            if (!Convert.IsDBNull(dr["AddDate"]))
                model.AddDate = Convert.ToDateTime(dr["AddDate"].ToString());
            else
                model.AddDate = DateTime.Parse("0001-01-01");
            model.Uploader = dr["uploader"].ToString();
            model.From = dr["From"].ToString();
            model.Url = dr["Url"].ToString();
            model.Type = dr["Type"].ToString();
            model.Href = dr["Href"].ToString();
            model.Pic = dr["Pic"].ToString();
            return model;
        }

        public static CaiFang ToCaiFang(IDataReader dr)
        {
            CaiFang model = new CaiFang();
            model.Id = int.Parse(dr["ID"].ToString());
            model.Title = dr["Title"].ToString();
            //model.Time =System.DateTime.Parse(dr["Time"].ToString()).ToString("yyyy-MM-dd");
            model.Time = dr["Time"].ToString();
            model.Place = dr["Place"].ToString();
            model.Organization = dr["Organization"].ToString();
            model.Leader = dr["Leader"].ToString();
            model.Description = dr["Description"].ToString();

            return model;
        }

        public static PowerClass ToPowerClass(IDataRecord dr)
        {
            PowerClass Model = new PowerClass();
            Model.Id = int.Parse(dr["id"].ToString());
            Model.Power = dr["power"].ToString().Trim();
            Model.Class = dr["class"].ToString().Trim();

            return Model;
        }

        public static Karat ToKaratContentList(IDataRecord dr)
        {
            Karat mod = new Karat();
            //KaratContent mod = new KaratContent();
            mod.Id = int.Parse(dr["id"].ToString());
            mod.Title = dr["Title"].ToString();
            mod.SubTitle = dr["SubTitle"].ToString();
            mod.Content = dr["Content"].ToString();
            mod.IndexComment = Convert.ToBoolean(dr["IndexComment"].ToString());
            mod.LanMu = dr["lanmu"].ToString();
            mod.Time = Convert.ToDateTime(dr["time"].ToString());
            mod.Author = dr["Author"].ToString();
            mod.Pass = Convert.ToBoolean(dr["pass"].ToString());
            mod.Url = dr["url"].ToString();

            return mod;
        }

        public static Karat ToKaratEventsList(IDataRecord dr)
        {
            Karat mod = new Karat();
            mod.Id = int.Parse(dr["id"].ToString());
            mod.From_Year = dr["From_Year"].ToString();
            mod.From_Content = dr["From_Content"].ToString();
            mod.Url = dr["url"].ToString();
           

            return mod;
        }

        public static Karat ToKaratWorkList(IDataRecord dr)
        {
            Karat mod = new Karat();
            mod.Id = int.Parse(dr["id"].ToString());
            mod.Name = dr["Name"].ToString();
            mod.Type = dr["Type"].ToString();
            mod.Time = Convert.ToDateTime(dr["Time"]);
            mod.Tool = dr["Tool"].ToString();
            mod.Href = dr["Href"].ToString();
            mod.Imgurl = dr["imgurl"].ToString();


            return mod;
        }

        public static Karat ToKaratList(IDataRecord dr, string tablename)
        {
            Karat mod = new Karat();
            switch (tablename)
            {
                case "Karat_Content":
                    {
                        mod.Id = int.Parse(dr["id"].ToString());
                        mod.Title = dr["Title"].ToString();
                        mod.SubTitle = dr["SubTitle"].ToString();
                        //mod.Content = dr["Content"].ToString();
                        //mod.IndexComment = Convert.ToBoolean(dr["IndexComment"].ToString());
                        mod.LanMu = dr["lanmu"].ToString();
                        //mod.Time = DateTime.Parse((dr["Time"].ToString()));
                        mod.Url = dr["url"].ToString();
                        mod.Content = dr["Content"].ToString();
                        mod.Imgurl = dr["imgurl"].ToString();
                        mod.Author = dr["author"].ToString();
                        mod.Time = Convert.ToDateTime(dr["Time"].ToString());
                    }; break;
                case "Karat_message":
                    {
                        mod.Name = dr["name"].ToString();
                        mod.Topic = dr["topic"].ToString();
                        mod.M_time = Convert.ToDateTime(dr["m_time"].ToString());
                        mod.R_time = Convert.ToDateTime(dr["r_time"].ToString());
                        mod.R_Content = dr["r_nr"].ToString();
                        mod.M_Content = dr["m_nr"].ToString();
                    }; break;
                case "Karat_Events":
                    {
                        mod.Id = int.Parse(dr["id"].ToString());
                        mod.From_Year = dr["From_Year"].ToString();
                        mod.From_Content = dr["From_Content"].ToString();
                        mod.Url = dr["url"].ToString();
                       

                    }; break;

                case "Karat_Work":
                    {
                        mod.Id = int.Parse(dr["id"].ToString());
                        mod.Name = dr["Name"].ToString();
                        mod.Type = dr["Type"].ToString();
                        mod.Time = Convert.ToDateTime(dr["Time"].ToString());
                        mod.Tool = dr["Tool"].ToString();
                        mod.Href = dr["Href"].ToString();
                        mod.Url = dr["Url"].ToString();
                        mod.Imgurl = dr["Imgurl"].ToString();
                    }; break;
                case "Karat_members":
                    {
                        mod.Id = int.Parse(dr["id"].ToString());
                        mod.Name = dr["name"].ToString();
                        mod.Bumen = dr["bumen"].ToString();
                        mod.Zhiwu = dr["zhiwu"].ToString();
                        mod.Qq = dr["qq"].ToString();
                        mod.Tel = dr["tel"].ToString();
                        mod.Email = dr["email"].ToString();
                        mod.Year = dr["year"].ToString();
                        mod.Yuanxi = dr["yuanxi"].ToString();
                        mod.Zaizhi = Convert.ToBoolean(dr["zaizhi"]);
                        mod.Beizhu = dr["beizhu"].ToString();
                        mod.Imgurl = dr["imgurl"].ToString();

                    }; break;
            };
            return mod;
        }

        public static Karat ToKaratMemberList(IDataRecord dr)
        {
            Karat mod = new Karat();
            mod.Id = int.Parse(dr["id"].ToString());
            mod.Name = dr["name"].ToString();
            mod.Bumen = dr["bumen"].ToString();
            mod.Zaizhi = Convert.ToBoolean(dr["zaizhi"]);
            mod.Zhiwu = dr["zhiwu"].ToString();
            mod.Qq = dr["qq"].ToString();
            mod.Tel = dr["tel"].ToString();
            mod.Email = dr["email"].ToString();
            mod.Year = dr["year"].ToString();
            mod.Yuanxi = dr["yuanxi"].ToString();
            mod.Beizhu = dr["beizhu"].ToString();
            mod.Imgurl = dr["imgurl"].ToString();
            return mod;
        }

        public static Karat ToKaratMemberContent(IDataRecord dr)
        {
            Karat mod = new Karat();
            mod.Id = int.Parse(dr["id"].ToString());
            mod.Name = dr["name"].ToString();
            mod.Bumen = dr["bumen"].ToString();
            mod.Zaizhi = Convert.ToBoolean(dr["zaizhi"]);
            mod.Zhiwu = dr["zhiwu"].ToString();
            mod.Qq = dr["qq"].ToString();
            mod.Tel = dr["tel"].ToString();
            mod.Email = dr["email"].ToString();
            mod.Year = dr["year"].ToString();
            mod.Yuanxi = dr["yuanxi"].ToString();
            mod.Beizhu = dr["beizhu"].ToString();
            mod.Imgurl = dr["imgurl"].ToString();
            return mod;
        }

        public static Karatbaoming ToKaratBaoMing(IDataRecord dr)
        {
            Karatbaoming mod = new Karatbaoming();
            mod.Id = int.Parse(dr["id"].ToString());
            mod.Name = dr["name"].ToString();
            mod.Sex = dr["sex"].ToString();
            mod.Xueyuan = dr["xueyuan"].ToString();
            mod.Banji = dr["banji"].ToString();
            mod.Xiaoqu = dr["xiaoqu"].ToString();
            mod.Diannao =  dr["diannao"].ToString();
            mod.Email = dr["email"].ToString();
            mod.Zhiwei = dr["zhiwei"].ToString();
             mod.Blog = dr["blog"].ToString();
            mod.Tel = dr["tel"].ToString();
            mod.Jianjie = dr["jianjie"].ToString();
            mod.Touxiang= dr["touxiang"].ToString();
            mod.Zuopin = dr["zuopin"].ToString();

            mod.Her = dr["her"].ToString();
            mod.Datee = Convert.ToDateTime( dr["datee"].ToString());
            mod.Xuehao = dr["xuehao"].ToString();
            mod.Renzhi = dr["renzhi"].ToString();
            mod.Qq = dr["qq"].ToString();
            mod.Qita = dr["qita"].ToString();
            mod.Jingli = dr["jingli"].ToString();
            mod.freetime = dr["freetime"].ToString();
            mod.grade = dr["grade"].ToString();
            mod.club_exp = dr["club_exp"].ToString();
            mod.orge_exp = dr["org_exp"].ToString();
            mod.get_award = dr["get_award"].ToString();
            mod.write_able = dr["write_able"].ToString();
            mod.work_time = dr["worktime"].ToString();
          
            return mod;
        }
        public static T_love bind(IDataRecord dr)
        {
            T_love mod = new T_love();
            mod.id = dr["id"].ToString();
            mod.author = dr["author"].ToString();
            mod.ccontent = dr["ccontent"].ToString();
            mod.tagbgcolor = dr["tagbgcolor"].ToString();
            mod.tagbgpic = dr["tagbgpic"].ToString();
            mod.subtime = dr["subtime"].ToString();
            return mod;
        }

    }
    public class Transform<T> where T : class ,new()
    {
        /// <summary>
        /// 将DataReader的当前行数据转化为Model层所用数据
        /// （对原lgwin的transform方法进行了重构）
        /// </summary>
        /// <param name="dr">DataReader的当前行数据</param>
        /// <returns>Model层所用数据</returns>
        public T DataReaderToModel(IDataRecord dr)
        {
            T model = new T();
            int count = dr.FieldCount;//记录DataReader中的字段的数目
            PropertyInfo[] property_list = model.GetType().GetProperties();//建立索引
            foreach (PropertyInfo property in property_list)
            {
                for (int i = 0; i < count; i++)
                {
                    if (!Convert.DBNull.Equals(dr[i]))//判断不为空
                    {
                        string name = dr.GetName(i).ToLower();
                        if (name.Equals(property.Name.ToLower()))
                        {
                            try
                            {
                                property.SetValue(model, dr[i], null);//为model赋值
                                break;
                            }
                            catch
                            {
                            }
                        }
                    }
                }
            }
            return model;
        }
    }
}