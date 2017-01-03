using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Text;

namespace Lgwin.Pic
{
    /**//// <summary>
    /// WaterMark类，用于生成首页的今日头条的图片
    /// </summary>
    public class Watermark
    {
        private int _width;  //背景宽度
        private int _height; //背景高度
        private string _fontFamily;  //字体属性
        private int _fontSize;  //字体大小
        private bool _adaptable;  //若文字太大，是否根据背景图来调整文字大小，默认为适应
        private FontStyle _fontStyle;  //文字风格
        private bool _shadow; //水印文字是否使用阴影
        private string _backgroundImage;  //背景图片
        private Color _bgColor;  //背景颜色
        private int _left;    //水印文字的左边距
        private string _resultImage;  // 生成后的图片
        private string _text;  //文字
        private int _top;     // 水印文字的顶边距
        private int _alpha;  //透明度0-255,255表示不透明
        private int _red;
        private int _green;
      private int _blue;
      private int _quality;   //输出图片质量，质量范围0-100,类型为long

      public Watermark()
      {
          //
          // TODO: Add constructor logic here
          //
          _width=460;
          _height=30;
          _fontFamily = "华文行楷";
          _fontSize = 20;
          _fontStyle=FontStyle.Regular;
          _adaptable=false ;
          _shadow=false;
          _left = 0;
          _top = 0;
          _alpha = 255;
          _red = 0;
          _green = 0;
          _blue = 0;
          _backgroundImage="";
          _quality=100;
          _bgColor=Color.FromArgb(255,229,229,229);
          
      }

      /**//// <summary>
      /// 字体
      /// </summary>
      public string FontFamily
      {
          set { this._fontFamily = value; }
      }

      /**//// <summary>
      /// 文字大小
      /// </summary>
      public int FontSize
      {
          set { this._fontSize = value; }
      }

      /**//// <summary>
      /// 文字风格
      /// </summary>
      public FontStyle FontStyle
      {
          get{return _fontStyle;}
          set{_fontStyle = value;}
      }

      /**//// <summary>
      /// 透明度0-255,255表示不透明
      /// </summary>
      public int Alpha
      {
          get { return _alpha; }
          set { _alpha = value; }
      }

      /**//// <summary>
      /// 水印文字是否使用阴影
      /// </summary>
      public bool Shadow
      {
          get { return _shadow; }
          set { _shadow = value; }
      }

        public int Red
        {
            get { return _red; }
            set { _red = value; }
        }

        public int Green
        {
            get { return _green; }
            set { _green = value; }
        }

        public int Blue
        {
            get { return _blue; }
            set { _blue = value; }
        }

        /**//// <summary>
        /// 底图
        /// </summary>
        public string BackgroundImage
        {
            set { this._backgroundImage = value; }
        }

        /**//// <summary>
        /// 水印文字的左边距
        /// </summary>
        public int Left
        {
            set { this._left = value; }
        }

        
        /**//// <summary>
        /// 水印文字的顶边距
        /// </summary>
        public int Top
        {
            set { this._top = value; }
        }

        /**//// <summary>
        /// 生成后的图片
        /// </summary>
        public string ResultImage
        {
            set { this._resultImage = value; }
        }

        /**//// <summary>
        /// 水印文本
        /// </summary>
        public string Text
        {
            set { this._text = value; }
        }

        
        /**//// <summary>
        /// 生成图片的宽度
        /// </summary>
        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        /**//// <summary>
        /// 生成图片的高度
        /// </summary>
        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        /**//// <summary>
        /// 若文字太大，是否根据背景图来调整文字大小，默认为适应
        /// </summary>
        public bool Adaptable
        {
            get { return _adaptable; }
            set { _adaptable = value; }
        }

        public Color BgColor
        {
            get { return _bgColor; }
            set { _bgColor = value; }
        }

        /**//// <summary>
        /// 输出图片质量，质量范围0-100,类型为int
        /// </summary>
        public int Quality
        {
            get { return _quality; }
            set { _quality = value; }
        }

        /**//// <summary>
        /// 立即生成水印效果图
        /// </summary>
        /// <returns>生成成功返回true,否则返回false</returns>
        public bool Create()
        {
            try
            {
                Bitmap bitmap;
                Graphics g;

                //使用纯背景色
                if(this._backgroundImage.Trim()=="")
                {
                    bitmap = new Bitmap(this._width, this._height, PixelFormat.Format64bppArgb);
                    g = Graphics.FromImage(bitmap);
                    g.Clear(this._bgColor);
                }
                else
                {
                    bitmap = new Bitmap(Image.FromFile(this._backgroundImage));
                    g = Graphics.FromImage(bitmap);
                }
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.CompositingQuality=CompositingQuality.HighQuality;

                Font f = new Font(_fontFamily, _fontSize,_fontStyle);
                SizeF size = g.MeasureString(_text, f);
                
                // 调整文字大小直到能适应图片尺寸
                while(_adaptable==true && size.Width > bitmap.Width) 
                {
                    _fontSize--;
                    f = new Font(_fontFamily, _fontSize, _fontStyle);
                    size = g.MeasureString(_text, f);
                }
                
                Brush b = new SolidBrush(Color.FromArgb(_alpha, _red, _green, _blue));
                StringFormat StrFormat = new StringFormat();
                StrFormat.Alignment = StringAlignment.Near;

                if(this._shadow)
                {
                    Brush b2=new SolidBrush(Color.FromArgb(90, 0, 0, 0));
                    g.DrawString(_text, f, b2,_left+2, _top+1);
                }
                g.DrawString(_text, f, b, new PointF(_left, _top), StrFormat);
                
                bitmap.Save(this._resultImage, ImageFormat.Jpeg);
                bitmap.Dispose();
                g.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
    /// <summary>
    /// image类
    /// </summary>
    public class image
    {
        public image()
        {
            //
            //TODO: 在此处添加构造函数逻辑
            //
        }
        public string t(string picpath, string savepath, int maxWidth, int maxHeight, int pinzhi, bool with_white)
        {
            Image img = Image.FromFile(picpath);
            ImageFormat imgformat = img.RawFormat;
            Size newSize = GetNewSize(maxWidth, maxHeight, img.Width, img.Height);
            int h = newSize.Height, w = newSize.Width;
            if (with_white)
            {
                h = maxHeight;
                w = maxWidth;
            }
            Bitmap outbmp = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(outbmp);

            //设置画布的描绘质量
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.Clear(Color.FromArgb(255, 249, 255, 240));
            g.DrawImage(img, new Rectangle((w - newSize.Width) / 2, (h - newSize.Height) / 2, newSize.Width, newSize.Height));
            g.Dispose();

            if (imgformat.Equals(ImageFormat.Gif))
            {
                System.Web.HttpContext.Current.Response.ContentType = "image/gif";
            }

            //设置压缩质量
            EncoderParameters encoderParams = new EncoderParameters();
            long[] quality = { 100 };
            quality.SetValue(pinzhi, 0);
            EncoderParameter encoderParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
            encoderParams.Param[0] = encoderParam;

            //获得包含有关内置图像编码解码器的信息的ImageCodecInfo 对象。
            ImageCodecInfo[] arrayICI = ImageCodecInfo.GetImageEncoders();
            ImageCodecInfo jpegICI = null;
            for (int fwd = 0; fwd < arrayICI.Length; fwd++)
            {
                if (arrayICI[fwd].FormatDescription.Equals("JPEG"))
                    jpegICI = arrayICI[fwd];
            }
            if (jpegICI != null)
            {
                outbmp.Save(savepath, jpegICI, encoderParams);
            }
            else
                outbmp.Save(savepath, imgformat);
            outbmp.Dispose();
            img.Dispose();
            return "";
        }

        public Size GetNewSize(int maxWidth, int maxHeight, int width, int height)
        {

            double w = 0.0, h = 0.0;
            double mw = Convert.ToDouble(maxWidth), mh = Convert.ToDouble(maxHeight);
            double sw = Convert.ToDouble(width), sh = Convert.ToDouble(height);

            if (sw < mw && sh < mh)
            {
                w = sw;
                h = sh;
            }
            else if ((sw / sh) > (mw / mh))
            {
                w = mw;
                h = w * sh / sw;
            }
            else
            {
                h = mh;
                w = h * sw / sh;
            }
            Size s = new Size(Convert.ToInt32(w), Convert.ToInt32(h));
            return s;
        }
    }

    /// <summary>
    ///图片修改类,主要是用来保护图片版权的，用于打水印
    /// </summary>
    public class ImageModification
    {
        #region "member fields"
        private string modifyImagePath = null;
        private string drawedImagePath = null;
        private int pinzhi = 95;
        private int rightSpace;
        private int bottoamSpace;
        private int lucencyPercent = 70;
        private string outPath = null;
        #endregion
        public ImageModification()
        {
        }
        #region "propertys"
        /// <summary>
        /// 获取或设置要修改的图像路径
        /// </summary>
        public string ModifyImagePath
        {
            get { return this.modifyImagePath; }
            set { this.modifyImagePath = value; }
        }
        /// <summary>
        /// 获取或设置在画的图片路径(水印图片)
        /// </summary>
        public string DrawedImagePath
        {
            get { return this.drawedImagePath; }
            set { this.drawedImagePath = value; }
        }
        /// <summary>
        /// 获取或设置水印在修改图片中的右边距
        /// </summary>
        public int RightSpace
        {
            get { return this.rightSpace; }
            set { this.rightSpace = value; }
        }
        //获取或设置水印在修改图片中距底部的高度
        public int BottoamSpace
        {
            get { return this.bottoamSpace; }
            set { this.bottoamSpace = value; }
        }
        /// <summary>
        /// 获取或设置要绘制水印的透明度,注意是原来图片透明度的百分比
        /// </summary>
        public int LucencyPercent
        {
            get { return this.lucencyPercent; }
            set
            {
                if (value >= 0 && value <= 100)
                    this.lucencyPercent = value;
            }
        }
        /// <summary>
        /// 获取或设置要绘制图片的质量
        /// </summary>
        public int PinZhi
        {
            get { return this.pinzhi; }
            set
            {
                if (value >= 0 && value <= 100)
                    this.pinzhi = value;
            }
        }
        /// <summary>
        /// 获取或设置要输出图像的路径
        /// </summary>
        public string OutPath
        {
            get { return this.outPath; }
            set { this.outPath = value; }
        }
        #endregion
        #region "methods"
        /// <summary>
        /// 开始绘制水印
        /// </summary>
        public void DrawImage()
        {
            Image modifyImage = null;
            Image drawedImage = null;
            Graphics g = null;
            try
            {
                //建立图形对象
                modifyImage = Image.FromFile(this.ModifyImagePath);
                drawedImage = Image.FromFile(this.DrawedImagePath);
                g = Graphics.FromImage(modifyImage);

                g.CompositingQuality = CompositingQuality.HighQuality;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                //获取要绘制图形坐标
                int x = modifyImage.Width - this.rightSpace;
                int y = modifyImage.Height - this.BottoamSpace;
                //设置颜色矩阵
                float[][] matrixItems ={
										   new float[] {1, 0, 0, 0, 0},
										   new float[] {0, 1, 0, 0, 0},
										   new float[] {0, 0, 1, 0, 0},
										   new float[] {0, 0, 0, (float)this.LucencyPercent/100f, 0},
										   new float[] {0, 0, 0, 0, 1}};

                ColorMatrix colorMatrix = new ColorMatrix(matrixItems);
                ImageAttributes imgAttr = new ImageAttributes();
                imgAttr.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                //绘制阴影图像
                g.DrawImage(
                    drawedImage,
                    new Rectangle(x, y, drawedImage.Width, drawedImage.Height),
                    0, 0, drawedImage.Width, drawedImage.Height,
                    GraphicsUnit.Pixel, imgAttr);
                //保存文件
                string[] allowImageType = { ".jpg", ".gif", ".png", ".bmp", ".tiff", ".wmf", ".ico" };
                FileInfo file = new FileInfo(this.ModifyImagePath);
                ImageFormat imageType = ImageFormat.Gif;
                switch (file.Extension.ToLower())
                {
                    case ".jpg":
                        imageType = ImageFormat.Jpeg;
                        break;
                    case ".gif":
                        imageType = ImageFormat.Gif;
                        break;
                    case ".png":
                        imageType = ImageFormat.Png;
                        break;
                    case ".bmp":
                        imageType = ImageFormat.Bmp;
                        break;
                    case ".tif":
                        imageType = ImageFormat.Tiff;
                        break;
                    case ".wmf":
                        imageType = ImageFormat.Wmf;
                        break;
                    case ".ico":
                        imageType = ImageFormat.Icon;
                        break;
                    default:
                        break;
                }

                //设置压缩质量
                EncoderParameters encoderParams = new EncoderParameters();
                long[] quality = { 100 };
                quality.SetValue(pinzhi, 0);
                EncoderParameter encoderParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
                encoderParams.Param[0] = encoderParam;

                //获得包含有关内置图像编码解码器的信息的ImageCodecInfo 对象。
                ImageCodecInfo[] arrayICI = ImageCodecInfo.GetImageEncoders();
                ImageCodecInfo jpegICI = null;
                for (int fwd = 0; fwd < arrayICI.Length; fwd++)
                {
                    if (arrayICI[fwd].FormatDescription.Equals("JPEG"))
                        jpegICI = arrayICI[fwd];
                }

                MemoryStream ms = new MemoryStream();
                //modifyImage.Save(ms,imageType);
                modifyImage.Save(ms, jpegICI, encoderParams);
                byte[] imgData = ms.ToArray();
                modifyImage.Dispose();
                drawedImage.Dispose();
                g.Dispose();
                FileStream fs = null;
                if (this.OutPath == null || this.OutPath == "")
                {
                    File.Delete(this.ModifyImagePath);
                    fs = new FileStream(this.ModifyImagePath, FileMode.Create, FileAccess.Write);
                }
                else
                {
                    fs = new FileStream(this.OutPath, FileMode.Create, FileAccess.Write);
                }
                if (fs != null)
                {
                    fs.Write(imgData, 0, imgData.Length);
                    fs.Close();
                }
            }
            finally
            {
                try
                {
                    drawedImage.Dispose();
                    modifyImage.Dispose();
                    g.Dispose();
                }
                catch { ;}
            }
        }
        #endregion
    }
    /// <summary>
    /// 生成缩略图类
    /// </summary>
    public class SuoluePic
    {

        /// <summary>
        /// 生成缩略图
        /// </summary>
        /// <param name="originalImagePath">源图路径（物理路径）</param>
        /// <param name="thumbnailPath">缩略图路径（物理路径）</param>
        /// <param name="width">缩略图宽度</param>
        /// <param name="height">缩略图高度</param>
        /// <param name="mode">生成缩略图的方式：W（指定宽，高按比例）H（指定高，宽按比例）Cut（指定高宽裁减（不变形））HW（指定高宽缩放）</param>  
        public void MakeThumbnail(string originalImagePath, string thumbnailPath, int width, int height, string mode)
        {
            if (File.Exists(originalImagePath))
            {
                Image originalImage = Image.FromFile(originalImagePath);

                int towidth = width;
                int toheight = height;

                int x = 0;
                int y = 0;
                int ow = originalImage.Width;
                int oh = originalImage.Height;

                switch (mode)
                {
                    case "HW"://指定高宽缩放（可能变形）                
                        break;
                    case "W"://指定宽，高按比例                    
                        toheight = originalImage.Height * width / originalImage.Width;
                        break;
                    case "H"://指定高，宽按比例
                        towidth = originalImage.Width * height / originalImage.Height;
                        break;
                    case "Cut"://指定高宽裁减（不变形）                
                        if ((double)originalImage.Width / (double)originalImage.Height > (double)towidth / (double)toheight)
                        {
                            oh = originalImage.Height;
                            ow = originalImage.Height * towidth / toheight;
                            y = 0;
                            x = (originalImage.Width - ow) / 2;
                        }
                        else
                        {
                            ow = originalImage.Width;
                            oh = originalImage.Width * height / towidth;
                            x = 0;
                            y = (originalImage.Height - oh) / 2;
                        }
                        break;
                    default:
                        break;
                }

                //新建一个bmp图片
                Image bitmap = new Bitmap(towidth, toheight);

                //新建一个画板
                Graphics g = System.Drawing.Graphics.FromImage(bitmap);

                //设置高质量插值法
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;

                //设置高质量,低速度呈现平滑程度
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                //清空画布并以透明背景色填充
                g.Clear(Color.Transparent);

                //在指定位置并且按指定大小绘制原图片的指定部分
                g.DrawImage(originalImage, new Rectangle(0, 0, towidth, toheight),
                    new Rectangle(x, y, ow, oh),
                    GraphicsUnit.Pixel);

                try
                {
                    //以jpg格式保存缩略图
                    bitmap.Save(thumbnailPath, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                catch (System.Exception e)
                {
                    throw e;
                }
                finally
                {
                    originalImage.Dispose();
                    bitmap.Dispose();
                    g.Dispose();
                }
            }
        }
    }
}