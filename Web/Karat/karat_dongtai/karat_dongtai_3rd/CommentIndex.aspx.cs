using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using _211;

/// <summary>
/// Comment 的摘要说明
/// </summary>
public partial class CommentIndex : System.Web.UI.Page
{
    string action = string.Empty;
    string id = string.Empty;
    string page = string.Empty;
    string pagehtml = string.Empty;
    string linkhtml = string.Empty;
    int Pages = 5;

    string commentparentid = string.Empty;
    string commentuser = string.Empty;
    string commenttext = string.Empty;
    string commentvalidate = string.Empty;
    string commentemail = string.Empty;
    string imagename = string.Empty;
    string type =string.Empty;
    string commenttype = string.Empty;
    public CommentIndex()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        
        action = Request.Params["action"];
        id = Request.Params["id"];
        page = Request.Params["commmentpage"];
        type = Request.Params["type"];
        if (action == "ajax_getcomment")
        {
            ajax_getcomment(id, Int32.Parse(page),Int32.Parse(type));
        }
        else if (action == "ajax_sendcomment")
        {

            commenttype = Request.Params["commenttype"];
            commentparentid = Request.Params["commentparentid"];
            commentuser = Request.Params["commentuser"].Replace("中共", "*").Replace("淫", "*").Replace("他妈的", "*").Replace("傻逼", "*").Replace("tmd", "*").Replace("sb", "*");
            
            commenttext = Request.Params["commenttext"].Replace("中共", "*").Replace("淫", "*").Replace("他妈的", "*").Replace("傻逼", "*").Replace("tmd", "*").Replace("sb", "*");

         
            commentemail = Request.Params["commentemail"];
            imagename = Request.Params["imagename"];
            string datee = DateTime.Now.ToString("yyyy-MM-dd");
            try
            {
                    if (datee != null)
                    {
                        DBQuery.ExecuteScalar("insert into Campus_Comment(Type,Aid,Guest,DateeGuest,ContentGuest,ContentAdmin,Ip) values('" + commenttype + "','" + commentparentid + "','" + commentuser + "','" + datee + "','" + Server.HtmlEncode(commenttext) + "','','" + Request.ServerVariables["REMOTE_ADDR"] + "')");
                        Response.Write("评论发表成功!");
                    }
                    else
                    {
                        Response.Write("服务器出错，请稍后评论！");
                    }
              
            }
            catch
            {
                Response.Write("ERROR！");//验证码处报错比较频繁，此异常必须抛出
            }
        }
        else
        {
            Response.Write("ERROR!");
        }

    }
    private void ajax_getcomment(string id, int page,int Type)
    {

        using (CommentBO cm = new CommentBO(id, page - 1,Type))
        {
            Response.Write(cm.getCommentContent());
        }
    }
   
}

