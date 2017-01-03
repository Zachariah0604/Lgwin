<%@ WebHandler Language="C#" Class="ZtImageHandler" %>

using System;
using System.Web;
using Lgwin.BLL;
using Lgwin.Model;
using System.Collections.Generic;

public class ZtImageHandler : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        //context.Response.ContentType = "text/plain";

        string ztnr = "<div id='ZtImg'>";
        ImageBLL imgbll = new ImageBLL();
        IList<Lgwin.Model.Image> list = imgbll.GetImageGetFenlei("zhuanti");
        int num = list.Count;
        if (num > 3)
        {
            for (int i = 0; i < 3; i++)
            {
                if (list[i].Href.ToString().Trim() != "")
                    ztnr += "<a href='" + list[i].Href + "' target='_blank'><img src='zhuanti/" + list[i].Name + "' /></a>";
                else
                {
                    ztnr += "<img src='zhuanti/" + list[i].Name + "' />";
                }
            }
        }
        else
        {
            for (int i = 0; i < num; i++)
            {
                if (list[i].Href.ToString().Trim() != "")
                    ztnr += "<a href='" + list[i].Href + "' target='_blank'><img src='zhuanti/" + list[i].Name + "' /></a>";
                else
                {
                    ztnr += "<img src='zhuanti/" + list[i].Name + "' />";
                }
            } 
        }
            
        ztnr += "</div>";
        context.Response.Write("document.write(\"" + ztnr + "\");");
            
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}