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

namespace Lgwin.Karat.admin
{
    public partial class KaratImagesManage : System.Web.UI.Page
    {
        SQLHelper helper = new SQLHelper();
        protected void Page_Load(object sender, EventArgs e)
        {
            Mystring.karatchksess();
            if (!Page.IsPostBack)
            {
                BindListView(treeList);
            }
        }
        public void BindListView(TreeView treeView)
        {
          
            treeView.Nodes.Clear();

         
            TreeNode rootNode = new TreeNode();
            rootNode.Text = "图片目录";
            rootNode.Value = "1";
            rootNode.ImageUrl = "images/Root.gif";
            rootNode.Expanded = false;
            rootNode.Selected = true;
          //  rootNode.Collapse();
          
            treeView.Nodes.Add(rootNode);

          
            DataTable dataTable = helper.getpicinfo();
          
            CreateChildNode(rootNode, dataTable);
        }
        private void CreateChildNode(TreeNode parentNode, DataTable dataTable)
        {
            DataRow[] rowList = dataTable.Select("ParentID='" + parentNode.Value + "'");
            foreach (DataRow row in rowList)
            {  
                TreeNode node = new TreeNode();
              
                node.Text = row["ImgName"].ToString();
                node.Value = row["ImgID"].ToString();
                if (row["isDir"].ToString() == "True")
                {
                    node.Expanded = true;
                    node.Target = "_self";
                    node.ImageUrl = "images/Dir.gif";
                }
                else
                {
                    node.Target = "_blank";
                    node.ImageUrl = "images/Picture.gif";
                }
                node.ImageToolTip = row["ImgUrl"].ToString();
                parentNode.ChildNodes.Add(node);
                CreateChildNode(node, dataTable);
            }
        }
        protected void treeList_SelectedNodeChanged(object sender, EventArgs e)
        {
            if (treeList.SelectedNode.ImageToolTip != "")
            {
                imagePic.ImageUrl = treeList.SelectedNode.ImageToolTip;
                imagePic.Visible = true;
            }

        }
        protected void btnAddPicture_Click(object sender, EventArgs e)
        {
            if (treeList.SelectedNode == null)
            {
                Response.Write("<script>window.alert('请选择合适的目录上传')</script>");
                return;
            }
            else if (!helper.checkdir(treeList.SelectedValue))
            {
                Response.Write("<script>window.alert('请选择合适的目录上传')</script>");
                return;
            }
            Response.Redirect("KaratUpload.aspx?ImgID=" + treeList.SelectedValue);
        }
        protected void PatchAddPicture_Click(object sender, EventArgs e)
        {
            if (treeList.SelectedNode == null)
            {
                Response.Write("<script>window.alert('请选择合适的目录上传')</script>");
                return;
            }
            else if (!helper.checkdir(treeList.SelectedValue))
            {
                Response.Write("<script>window.alert('请选择合适的目录上传')</script>");
                return;
            }
            Response.Redirect("KaratPatchUpload.aspx?ImgID=" + treeList.SelectedValue);
        }
        protected void btnNewDir_Click(object sender, EventArgs e)
        {
            if (treeList.SelectedNode == null)
            {
                Response.Write("<script>window.alert('请选择合适的目录添加')</script>");
                return;
            }
            else if (!helper.checkdir(treeList.SelectedValue))
            {
                Response.Write("<script>window.alert('请选择合适的目录添加')</script>");
                return;
            }
            Response.Redirect("KaratImagesBuild.aspx?ImgID=" + treeList.SelectedValue);
        }

        protected void btnEditNode_Click(object sender, EventArgs e)
        {
            if (treeList.SelectedNode == null)
            {
                Response.Write("<script>window.alert('请选择合适的修改项目')</script>");
                return;
            }
            else if (treeList.SelectedValue == "1")
            {
                Response.Write("<script>window.alert('根目录不能修改名称')</script>");
                return;
            }

            Response.Redirect("KaratImagesEdit.aspx?" +
                              "ImgID=" + treeList.SelectedValue + "&" +
                              "ImgName=" + Server.HtmlEncode(treeList.SelectedNode.Text));
        }

        protected void btnDeleteNode_Click(object sender, EventArgs e)
        {
            if (treeList.SelectedNode == null)
            {
                Response.Write("<script>window.alert('请选择合适的删除对象')</script>");
                return;
            }
            else if (treeList.SelectedValue == "1")
            {
                Response.Write("<script>window.alert('根目录不能删除')</script>");
                return;
            }
            else if (helper.checkchildnode(treeList.SelectedValue))
            {
                Response.Write("<script>window.alert('请先删除目录下的文件和子目录')</script>");
                return;
            }
          
            helper.deleteNode(treeList.SelectedValue);
        
            Response.Write("<script>window.alert('删除成功！')</script>");
            BindListView(treeList);
            imagePic.Visible = false;
        }
    }
}