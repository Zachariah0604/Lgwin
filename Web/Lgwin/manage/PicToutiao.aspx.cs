using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using ConfigOperator;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

public partial class Lgwin_manage_PicToutiao : System.Web.UI.Page
{
    //头条图片样式设置
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Mystring.chksess())
        {
            if (Mystring.chkPower(39, Session["User"].ToString()))
            {

                if (!Page.IsPostBack)
                {

                    System.Drawing.Text.InstalledFontCollection font;//安装在系统的所有字体，无法继承
                    font = new System.Drawing.Text.InstalledFontCollection();
                    foreach (System.Drawing.FontFamily family in font.Families)
                    {
                        DropDownList1.Items.Add(family.Name);
                    }

                    //获取系统所有颜色(利用枚举获取系统的颜色并且将Dropdownlist的字体颜色改成当前的颜色)
                    //string[] colorArray = Enum.GetNames(typeof(System.Drawing.KnownColor));
                    //foreach (string color in colorArray)
                    //{
                    //    ListItem item = new ListItem(color);
                    //    item.Attributes.Add("style", "color:" + color);
                    //    DropDownList2.Style.Add("BackColor", color);
                    //    DropDownList2.Items.Add(item);

                    //}
                    DropDownList1.SelectedItem.Text = ConfigurationManager.AppSettings["TouTiaoFontFamily"].ToString();
                    TextBox_red.Text = ConfigurationManager.AppSettings["Red"].ToString();
                    TextBox_green.Text = ConfigurationManager.AppSettings["Green"].ToString(); ;
                    TextBox_blue.Text = ConfigurationManager.AppSettings["Blue"].ToString();
                    TextBox_ZuoBJ.Text = ConfigurationManager.AppSettings["Left"].ToString();
                    TextBox_ShangBJ.Text = ConfigurationManager.AppSettings["Top"].ToString();
                    TextBox_Width.Text = ConfigurationManager.AppSettings["Width"].ToString();
                    TextBox_Height.Text = ConfigurationManager.AppSettings["Heigth"].ToString();
                    TextBox_Daxiao.Text = ConfigurationManager.AppSettings["FontSize"].ToString();
                    TextBox_Touming.Text = ConfigurationManager.AppSettings["Alpha"].ToString();
                    TextBox_Pinzhi.Text = ConfigurationManager.AppSettings["Quality"].ToString();
                    if (ConfigurationManager.AppSettings["Shadow"].ToString().Trim() == "True")
                        CheckBox_Yinying.Checked = true;
                    if (ConfigurationManager.AppSettings["AdaptTable"].ToString() == "True")
                        CheckBox_Shiying.Checked = true;
                }
            }
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string fontFamily = DropDownList1.SelectedItem.Text;
        int Red = int.Parse(TextBox_red.Text.Trim());
        int green = int.Parse(TextBox_green.Text.Trim());
        int blue = int.Parse(TextBox_blue.Text.Trim());
        int Left = Convert.ToInt16(TextBox_ZuoBJ.Text);
        int Top = Convert.ToInt16(TextBox_ShangBJ.Text);
        int _Width = Convert.ToInt16(TextBox_Width.Text);
        int _Heigth = Convert.ToInt16(TextBox_Height.Text);
        int fontSize = Convert.ToInt16(TextBox_Daxiao.Text);
        int alpha = Convert.ToInt16(TextBox_Touming.Text);
        long _quality = Convert.ToInt64(TextBox_Pinzhi.Text);
        bool shadow = CheckBox_Yinying.Checked;
        bool adaptable = CheckBox_Shiying.Checked;

        ConfigurationOperator co = new ConfigurationOperator();
        co.AddAppSetting("TouTiaoFontFamily", fontFamily);
        co.AddAppSetting("Red",Red.ToString());
        co.AddAppSetting("Green",green.ToString());
        co.AddAppSetting("Blue",blue.ToString());
        co.AddAppSetting("Left", Left.ToString());
        co.AddAppSetting("Top", Top.ToString());
        co.AddAppSetting("Width", _Width.ToString());
        co.AddAppSetting("Heigth", _Heigth.ToString());
        co.AddAppSetting("FontSize", fontSize.ToString());
        co.AddAppSetting("Alpha", alpha.ToString());
        co.AddAppSetting("Quality", _quality.ToString());
        co.AddAppSetting("Shadow", shadow.ToString());
        co.AddAppSetting("AdaptTable", adaptable.ToString());
        co.Save();
        Mystring.alertAndBack("设置成功！");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Mystring.Back();
    }
}
       // Watermark mark = new Watermark();
       // mark.FontFamily=ConfigurationManager.AppSettings["TouTiaoFontFamily"].ToString();
       // mark.Left=Convert.ToInt16( ConfigurationManager.AppSettings["Left"].ToString());
       // mark.Top = Convert.ToInt16(ConfigurationManager.AppSettings["Top"].ToString());
       // mark.FontSize = Convert.ToInt16(ConfigurationManager.AppSettings["FontSize"].ToString());
       // mark.Alpha = Convert.ToInt16(ConfigurationManager.AppSettings["Alpha"].ToString());
       // mark.Shadow=Convert.ToBoolean(ConfigurationManager.AppSettings["Shadow"].ToString());
       // mark.Adaptable=Convert.ToBoolean( ConfigurationManager.AppSettings["AdaptTable"]);
       // mark.BackgroundImage = "c:\\11.jpg";
       // mark.Text = "理工视窗理工视窗理工视窗理工视窗";
       // mark.ResultImage = @"c:\11.jpg";
       // mark.Height = 50;
       //mark.Width = 300;
       //mark.Quality = 100;
       // mark.BgColor = System.Drawing.Color.White;
       //mark.Blue = 255;
       //mark.Red = 0;
       // mark.Green=0;
       // mark.Create();