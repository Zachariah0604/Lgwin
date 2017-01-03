using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Text;
using System.IO;
using Lgwin.BLL;
using Lgwin.Model;

/// <summary>
///Myfile 的摘要说明
/// </summary>
public class Myfile
{
    public Myfile()
    {
        //
        //TODO: 在此处添加构造函数逻辑
        //
    }
    /// <summary>
    /// 读模板
    /// </summary>
    /// <param name="path">模板路径</param>
    /// <returns></returns>
    public static string Read_Model(string path)
    {
        System.Text.Encoding code = System.Text.Encoding.GetEncoding("gb2312");
        StreamReader read = new StreamReader(path, code);
        string text = read.ReadToEnd();
        read.Dispose();
        read.Close();
        return text;
    }
    //System.IO.FileStream fs = new System.IO.FileStream(fileName, System.IO.FileMode.Open, System.IO.FileAccess.Read, FileShare.ReadWrite);


    /// <summary>
    /// 读模板
    /// </summary>
    /// <param name="path">模板路径</param>
    /// <param name="codeName">编码方式</param>
    /// <returns></returns>
    public static string Read_Model(string path, string codeName)
    {
        if (codeName == "")
            codeName = "gb2312";
        System.Text.Encoding code = System.Text.Encoding.GetEncoding(codeName);
        StreamReader read = new StreamReader(path, code);
        string text = read.ReadToEnd();
        read.Dispose();
        read.Close();
        return text;
    }
    /// <summary>
    /// 写文件
    /// </summary>
    /// <param name="Path">文件路径</param>
    /// <param name="content">编码方式</param>
    /// <returns></returns>
    public static bool File_Write(string Path, string content)
    {
        System.Text.Encoding code = System.Text.Encoding.GetEncoding("gb2312");
        if (Directory.Exists(Path.Remove(Path.LastIndexOf("\\"))) == false)
            Directory.CreateDirectory(Path.Remove(Path.LastIndexOf("\\")));
        StreamWriter write = new StreamWriter(Path, false, code);
        try
        {
            write.Write(content);
            return true;
        }
        catch
        {
            return false;
        }
        finally
        {
            write.Dispose();
            write.Close();
        }
    }
    /// <summary>
    /// 写文件
    /// </summary>
    /// <param name="Path">文件路径</param>
    /// <param name="content">文件内容</param>
    /// <param name="codeName">编码方式</param>
    /// <returns></returns>
    public static bool File_Write(string Path, string content, string codeName)
    {
        if (codeName == "")
            codeName = "gb2312";

        System.Text.Encoding code = System.Text.Encoding.GetEncoding(codeName);
        if (Directory.Exists(Path.Remove(Path.LastIndexOf("\\"))) == false)
            Directory.CreateDirectory(Path.Remove(Path.LastIndexOf("\\")));
        StreamWriter write = new StreamWriter(Path, false, code);
        try
        {
            write.Write(content);
            return true;
        }
        catch
        {
            return false;
        }
        finally
        {
            write.Dispose();
            write.Close();
        }
    }
    /// <summary>
    /// 删除指定路径文件
    /// </summary>
    /// <param name="Path">文件路径</param>
    /// <returns></returns>
    public static bool File_Del(string Path)
    {
        if (File.Exists(Path))
        {
            File.Delete(Path);
            return true;
        }
        else
        {
            return false;
        }
    }
    /// <summary>
    /// 添加专题生成默认文件
    /// </summary>
    /// <param name="topic_kw">专题Id</param>
    public static void AddTopic(int ztid)
    {
        ZtBLL ztbll = new ZtBLL();
        Zt ztmod = ztbll.GetZtById(ztid);

        ZtCaptionBLL capbll = new ZtCaptionBLL();
        ZtCaption capmod = new ZtCaption();

        string path = HttpContext.Current.Server.MapPath("~/topic/" + ztmod.ZtJiancheng);
        capmod.ZtCaptionName = "图片传真";
        capmod.Ztid = ztid.ToString();
        capbll.Add(capmod);
        Directory.CreateDirectory(path);
        Directory.CreateDirectory(path + "/news");
        Directory.CreateDirectory(path + "/models");
        //File.Create(path + "/models/1st.html");
        File.WriteAllText(path + "/counter.txt", "1");
        File.WriteAllText(path + "/config.txt","1");
    }
}
