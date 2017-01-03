using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.IO;
using Lgwin.Pic;
using Lgwin.BLL;
using Lgwin.Model;

public partial class xlxy_admin_Default : System.Web.UI.Page
{
    private static int id = 0;


    protected void Page_Load(object sender, EventArgs e)
    {
        Mystring.chksess();
       
       

        Image1.ImageUrl = "~/photo/images/shuiyin/backlogo1.png";
        Image2.ImageUrl = "~/photo/images/shuiyin/backlogo2.png";
        Image3.ImageUrl = "~/photo/images/shuiyin/backlogo3.png";
        Image4.ImageUrl = "~/photo/images/shuiyin/backlogo4.png";
        Image5.ImageUrl = "~/photo/images/shuiyin/backlogo5.png";
        Image6.ImageUrl = "~/photo/images/shuiyin/backlogo6.png";

        if (Request["id"] != null && Request["id"].ToString() != "")
        {
            id = Convert.ToInt32(Request["id"].Replace("'", ""));
            if (!IsPostBack)
            {
                SqlDataReader dr = new PhotoBLL().PhotoSelect(id, "id", "Photo_photo");
                try
                {
                    dr.Read();
                    TextBox_name.Text = dr["name"].ToString();
                    TextBox2.Text = dr["shuoming"].ToString();
                    TextBox1.Text = dr["zuozhe"].ToString();
                    TextBox4.Text = dr["editor"].ToString();

                    TextBox3.Text = DateTime.Now.ToString();
                    DropDownList1.DataBind();

                    for (int i = 0; i < DropDownList1.Items.Count; i++)
                    {
                        if (DropDownList1.Items[i].Value == dr["zhtID"].ToString())
                            DropDownList1.Items[i].Selected = true;
                    }

                    //DropDownList2.DataBind();
                    //for (int i = 0; i < DropDownList2.Items.Count; i++)
                    //{
                    //    if (DropDownList2.Items[i].Value == dr["lmID"].ToString())
                    //        DropDownList2.Items[i].Selected = true;
                    //}

                    Label_fenlei.Text = dr["zhtID"].ToString();
                    Label_pic_name.Text = dr["path"].ToString();
                    Label_zhtID.Text = dr["zhtID"].ToString();
                    Label_lmID.Text = id.ToString();
                    Image7.ImageUrl = "~/photo/admin/photo/" + dr["zhtID"].ToString() + "/" + dr["path"].ToString();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally
                {
                    dr.Dispose();
                }
            }
        }
        else
            Response.Write("<script>alert('参数有误');self.location='manage.aspx'</script>");


    }//pageload
    protected void Button1_Click(object sender, EventArgs e)
    {
        string pic_path = Label_pic_name.Text.ToString();
        if (DropDownList2.SelectedValue == "")

        { Response.Write("<script>alert('请选择栏目');self.location='stu_pic_edit.aspx'</script>"); }
        else
        {
            if (CheckBox1.Checked)
            {

                ImageModification wm = new ImageModification();

                wm.DrawedImagePath = Server.MapPath("~") + "/photo/images/shuiyin/" + "backlogo" + RadioButtonList1.SelectedValue + ".png";
                //wm.ModifyImagePath = path +"_new" + name_new;
                //string newpash =name_new.Substring(0,5);


                wm.ModifyImagePath = Server.MapPath("~") + "/photo/admin/photo/" + Label_zhtID.Text.ToString() + "/" + pic_path;

                switch (RadioButtonList_weizhi.SelectedValue)
                {
                    case "左":
                        {
                            wm.RightSpace = Convert.ToInt32(kuan.Text) - 30;
                            break;
                        }
                    case "右":
                        {
                            wm.RightSpace = 190;
                            break;
                        }
                    case "中":
                        {
                            wm.RightSpace = (int)(Convert.ToInt32(kuan.Text) / 2) + 80;
                            break;
                        }

                }
                wm.BottoamSpace = 50;
                wm.LucencyPercent = 100;

                string newfile = pic_path.Substring(0, 14);
                wm.OutPath = Server.MapPath("~") + "/photo/admin/photo/" + Label_zhtID.Text.ToString() + "/" + newfile + "_Marked.jpg";
                wm.DrawImage();
                File.Delete(Server.MapPath("~") + "/photo/admin/photo/" + Label_zhtID.Text.ToString() + "/" + pic_path);
                pic_path = newfile + "_Marked.jpg";

                string sql_in = "update [Photo_photo] set path= '" + pic_path + "'where id=" + Label_lmID.Text.ToString();
                xlxy.sqlNoQ(sql_in);
                Label_pic_name.Text = pic_path;





            }

            string CheckBox2Text = "";
            if (CheckBox2.Checked)
            {
                CheckBox2Text = "1";
            }
            if (!CheckBox2.Checked)
            {
                CheckBox2Text = "0";
            }
            string CheckBox3Text = "";
            if (CheckBox3.Checked)
            {
                CheckBox3Text = "1";
            }
            if (!CheckBox3.Checked)
            {
                CheckBox3Text = "0";
            } string CheckBox4Text = "";
            if (CheckBox4.Checked)
            {
                CheckBox4Text = "1";
            }
            if (!CheckBox4.Checked)
            {
                CheckBox4Text = "0";
            } string CheckBox5Text = "";
            if (CheckBox5.Checked)
            {
                CheckBox5Text = "1";
            }
            if (!CheckBox5.Checked)
            {
                CheckBox5Text = "0";
            }

         
            int y = int.Parse(DropDownList1.SelectedValue.ToString());
            Photo mod = new Photo();
            mod.id = id;
            mod.name = TextBox_name.Text;
            mod.pagename = DropDownList2.SelectedValue.ToString() + ".html";
            mod.path = pic_path;
            mod.zhtID = int.Parse(DropDownList1.SelectedValue);
            mod.lmID = int.Parse(DropDownList2.SelectedValue);
            mod.lmname = DropDownList2.SelectedItem.Text;
            mod.zhtname = DropDownList1.SelectedItem.Text;
            mod.zuozhe = TextBox1.Text;
            mod.editor = TextBox4.Text;
            mod.shuoming = TextBox2.Text;
            mod.tuijian = CheckBox2Text;
            mod.shouye = CheckBox3Text;
            mod.redian = CheckBox4Text;
            mod.xww = CheckBox5Text;
            mod.xshshch = "false";
            mod.upload_time = Convert.ToDateTime(TextBox3.Text);
            bool flag1 = new PhotoBLL().pic_edit1(mod);
            if (DropDownList1.SelectedValue != Label_fenlei.Text)
            {
                File.Copy(Server.MapPath("~") + "\\photo\\admin\\photo\\" + Label_fenlei.Text + "\\" + Label_pic_name.Text, Server.MapPath("~") + "\\photo\\admin\\photo" + "\\" + DropDownList1.SelectedValue + "\\" + Label_pic_name.Text);
                File.Copy(Server.MapPath("~") + "\\photo\\admin\\photo\\" + Label_fenlei.Text + "\\" + Label_pic_name.Text.Remove(14) + "small.jpg", Server.MapPath("~") + "\\photo\\admin\\photo\\" + "\\" + DropDownList1.SelectedValue + "\\" + Label_pic_name.Text.Remove(14) + "small.jpg");
                File.Delete(Server.MapPath("~") + "\\photo\\admin\\photo\\" + Label_fenlei.Text + "\\" + Label_pic_name.Text);
                File.Delete(Server.MapPath("~") + "\\photo\\admin\\photo\\" + Label_fenlei.Text + "\\" + Label_pic_name.Text.Remove(14) + "small.jpg");
            }
            Response.Write("<script>alert('操作成功');self.location='stu_pic_manage.aspx'</script>");
        }
    }//button1
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {


        DropDownList2.DataBind();
        DropDownList2.Items.Insert(0, new ListItem("—选择栏目类型—", ""));

    }
}




























