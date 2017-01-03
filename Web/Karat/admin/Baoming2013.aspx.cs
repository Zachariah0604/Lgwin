using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Lgwin.Model;
using Lgwin.BLL;
namespace Lgwin.Karat.admin
{
    public partial class Baoming2013 : System.Web.UI.Page
    {
        private static string ConStr = System.Configuration.ConfigurationManager.AppSettings["connStr"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {
            Mystring.karatchksess();
            int id = 0;
            if (Request.QueryString["id"] != "" && Request.QueryString["id"] != null)
            {
                id = Convert.ToInt32(Request.QueryString["id"]);
                Karatbaoming mod = new Karatbaoming();
                mod = new KaratBLL().BaomingGetById(id);
                xingming2013.Text = mod.Name;
                xingbie2013.Text = mod.Sex;
                jiguan2013.Text = mod.Her;
                xueyuan2013.Text = mod.Xueyuan;
                banji2013.Text = mod.Banji;
                sushe2013.Text = mod.Xiaoqu;
                zhiwu2013.Text = mod.Renzhi;
                diannao2013.Text = mod.Diannao;
                string zhiwei=mod.Zhiwei.ToString();
                //switch (zhiwei)
                //{
                //    case "编辑记者": jz.Checked = true; break;
                //    case "综合办公人员": zh.Checked = true; break;
                //    // case "程序员": cx.Checked = true; break;
                //    case "美术编辑": mb.Checked = true; break;
                //    default: break;
                //}
                if (zhiwei == "编辑记者")
                {
                    jz2013.Checked = true;
                }
                else if (zhiwei == "美术编辑")
                {
                    mb2013.Checked = true;
                }
                else if (zhiwei == "综合办公人员")
                {
                    zh2013.Checked = true;
                }
                else
                    cx2013.Checked = true;
                aihao2013.Text = mod.Jianjie;
                zuopin2013.Text = mod.Zuopin;
                imgage2013.ImageUrl = mod.Touxiang;
                dianhua2013.Text = mod.Tel;
                youxiang2013.Text = mod.Email;
                qqhaoma2013.Text = mod.Qq;
                qita2013.Text = mod.Qita;
                gongzuo2013.Text = mod.Jingli;
                club2013.Text = mod.club_exp;
                orgexp2013.Text = mod.orge_exp;
                getaward2013.Text = mod.get_award;
                abl2013.Text = mod.write_able;
                perfo2013.Text = mod.grade;
                free2013.Text = mod.freetime;
                kaoyan2013.Text = mod.Kaoyan;
                wtime2013.Text = mod.work_time;
                zuopin2013.Text = mod.Zuopin;
            }

        }
    }
}