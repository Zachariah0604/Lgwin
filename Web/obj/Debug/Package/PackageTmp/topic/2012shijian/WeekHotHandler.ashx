<%@ WebHandler Language="C#" Class="WeekHotHandler" %>

using System;
using System.Web;
using Lgwin.BLL;
using Lgwin.Model;
using System.Collections.Generic;

public class WeekHotHandler : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        //context.Response.ContentType = "text/plain";
        //context.Response.Write("Hello World");
        int count;
        string target = "";
        ContentBLL bll = new ContentBLL();
        //IList<Lgwin.Model.Content> list = bll.GetList(10, 1, "([datee]>=dateadd(day,2-datepart(weekday,getdate()),convert(varchar,getdate(),112))) and ([auditing]='1') and ([caption]<>'废稿') ", "counter", true, out count);
        IList<Lgwin.Model.Content> list = bll.GetList(10, 1, "(datee<=GETDATE()and datee>=GETDATE()-10 ) and ([auditing]='1') and ([caption]<>'废稿') and (zt='51')", "counter", true, out count);
        int con = list.Count;
        if (con >= 10)
        {
            for (int i = 0; i < 10; i++)
            {
                //target = "<tr><td class='NewsList' >" + ToHtml.GetHref_danyinhao(list[i], 10) + "(" + list[i].Counter + ")</td><td class='time'>[" + list[i].Datee.ToShortDateString() + "]</td></tr>";
                target = "<td width='12\'><img src='images/logo_03.jpg' width='7' height='7\' /></td><td>" + ToHtml.GetHref_danyinhao(list[i], 25) + "(" + list[i].Counter + ")</td></tr>";
                HttpContext.Current.Response.Write("document.write(\"" + target + "\");");
            }
        }
        else
        {
            for (int i = 0; i < con; i++)
            {
                target = "<td width='12\'><img src='images/logo_03.jpg' width='7' height='7\' /></td><td>" + ToHtml.GetHref_danyinhao(list[i], 10) + "(" + list[i].Counter + ")</td></tr>";
                //target = "<tr><td class='NewsList' >" + ToHtml.GetHref_danyinhao(list[i], 10) + "(" + list[i].Counter + ")</td><td class='time'>[" + list[i].Datee.ToShortDateString() + "]</td></tr>";
                HttpContext.Current.Response.Write("document.write(\"" + target + "\");");
            } 
        }
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}
