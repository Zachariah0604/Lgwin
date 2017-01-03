<%@ WebHandler Language="C#" Class="RelatedArticlesHandler" %>
using System;
using System.Web;
using Lgwin.BLL;
using Lgwin.Model;
using System.Collections.Generic;
using System.Text;

//public class RelatedArticlesHandler : IHttpHandler 
//{
//    public bool IsReusable
//    {
//        get { return true; }
//    }

//    public void ProcessRequest(HttpContext context)
//    {
//        context.Response.ContentEncoding = Encoding.GetEncoding("GB2312");
//        context.Response.Charset = "GB2312";
//        context.Response.ContentType = "text/html";
//        string id = context.Request.QueryString["Id"].ToString();
//        string caption = "";
//        string title = "";
//        string text = "<table>";
//        string articles = "";
//        string date = "";
//        string keywords = "";
//        int count = 0;
//        IList<Lgwin.Model.Content> list = null;
//        ContentBLL conbll = new ContentBLL();
//        Lgwin.Model.Content mod = conbll.Get(int.Parse(id));
//        caption = mod.Caption;
//        title = mod.Title;
//        keywords = mod.Keywords;
//        date = (mod.Datee).ToString();
//        list = conbll.GetList(1, 1, "id<'" + id + "' and auditing=1 and keywords='" + keywords+ "' ", out count,keywords,date);
//        if(list.Count > 0)
//        {
//            if(list[0].Url == "")
//                articles = "<tr><td><a href = '" + list[0].Id + ".html' title='" + list[0].Title +"'>" + Mystring.lim_withoutPoint(list[0].Title, 40) + "</a></td></tr>";
//            else
//                articles = "<tr><td><a href = '" + list[0].Id + ".html' title='" + list[0].Title + "'>" + Mystring.lim_withoutPoint(list[0].Title, 40) + "</a></td></tr>";
//            if (list[1].Url == "")
//                articles = "<tr><td><a href = '" + list[1].Id + ".html' title='" + list[1].Title + "'>" + Mystring.lim_withoutPoint(list[1].Title, 40) + "</a></td></tr>";
//            else
//                articles = "<tr><td><a href = '" + list[1].Id + ".html' title='" + list[1].Title + "'>" + Mystring.lim_withoutPoint(list[1].Title, 40) + "</a></td></tr>";
//        }

//        text += articles + "</table>";
//        //context.Response.Write(keywords+date);

//        context.Response.Write("document.wtite('" + text + "')");
        
//    }
//}