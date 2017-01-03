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
    public partial class Baoming2012 : System.Web.UI.Page
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
                xingming.Text = mod.Name;
                xingbie.Text = mod.Sex;
                jiguan.Text = mod.Her;
                xueyuan.Text = mod.Xueyuan;
                banji.Text = mod.Banji;
                sushe.Text = mod.Xiaoqu;
                zhiwu.Text = mod.Renzhi;
                diannao.Text = mod.Diannao;
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
                    jz.Checked = true;
                }
                else if (zhiwei == "美术编辑")
                {
                    mb.Checked = true;
                }
                else if (zhiwei == "综合办公人员")
                {
                    zh.Checked = true;
                }
                else
                    cx.Checked = true;
                aihao.Text = mod.Jianjie;
                zuopin.Text = mod.Zuopin;
                imgage.ImageUrl = mod.Touxiang;
                dianhua.Text = mod.Tel;
                youxiang.Text = mod.Email;
                qqhaoma.Text = mod.Qq;
                qita.Text = mod.Qita;
                gongzuo.Text = mod.Jingli;
                club.Text = mod.club_exp;
                orgexp.Text = mod.orge_exp;
                getaward.Text = mod.get_award;
                abl.Text = mod.write_able;
                perfo.Text = mod.grade;
                free.Text = mod.freetime;
                wtime.Text = mod.work_time;
                zuopin.Text = mod.Zuopin;
            }

        }
    }
}