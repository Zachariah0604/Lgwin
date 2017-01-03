<%@ WebHandler Language="C#" Class="PreNextHandler" %>

using System;
using System.Web;
using Lgwin.BLL;
using Lgwin.Model;
using System.Collections.Generic;
using System.Text;

public class PreNextHandler : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentEncoding = Encoding.GetEncoding("GB2312");
        context.Response.Charset = "GB2312";
        context.Response.ContentType = "text/html";
        string id = context.Request.QueryString["Id"].ToString();
        string zt = "";
        string text = "<tr><td width='49'>&nbsp;</td><td class='prenext'>前一篇：";
        string preone = "";
        string nextone = "";
        int count = 0;
        IList<Lgwin.Model.Content> list = null;
        ContentBLL conbll = new ContentBLL();
        Lgwin.Model.Content mod = conbll.Get(int.Parse(id));
        zt = mod.Zt;
        string ztlm = mod.Ztid;
        list = conbll.GetList(1, 1, "id<'" + id + "' and [zt]='" + zt + "' and [ztid]='" + ztlm + "' and auditing=1", out count);
        if (list.Count > 0)
            preone = "<a href='" + list[0].Id + ".html' title='" + list[0].Title + "' >" + Mystring.lim_withoutPoint(list[0].Title, 14) + "</a>";
        else
            preone = "没有了！";
        list = conbll.GetList(1, 1, "id>'" + id + "' and [zt]='" + zt + "' and [ztid]='" + ztlm + "' and auditing=1", "id", false, out count);//取下一篇时要正序取
        if (list.Count > 0)
            nextone = "<a href='" + list[0].Id + ".html' title='" + list[0].Title + "' >" + Mystring.lim_withoutPoint(list[0].Title, 13) + "</a>";
        else
            nextone = "没有了！";
        text += preone + "</td><td width='38'>&nbsp;</td></tr><tr><td width='49'>&nbsp;</td><td class='prenext'>后一篇：";
        text += nextone + "</td><td width='38'>&nbsp;</td></tr>";

        context.Response.Write("document.write(\"" + text + "\");");
        //HttpContext.Current.Response.Write(HttpContext.Current.Request.Headers["Accept"].ToString());
        string page;
        if (context.Request.Cookies["page"] == null)
        {
            page = "";
        }
        else
        {
            page = context.Request.Cookies["page"].Value.ToString(); //获取cookie中存储的url值 
        }

        string strThisPage = context.Request.Url.AbsoluteUri.ToString();//获取当前页地址 
        int number;
        if ((page.Equals(strThisPage)))//如果cookie中的值和当前页相等，那么表示是刷新操作 
        {
            number = conbll.GetHitNumber(id, true);
        }
        else
        {
            number = conbll.GetHitNumber(id, false);
        }
        if (number == 0)
            number = 188;
        string java = "var sp; sp=document.getElementById('hit');sp.innerHTML=" + number.ToString() + ";";
        context.Response.Write(java);
        context.Response.Cookies["page"].Value = strThisPage;

    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}