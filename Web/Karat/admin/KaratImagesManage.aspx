<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KaratImagesManage.aspx.cs" Inherits="Lgwin.Karat.admin.KaratImagesManage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        body { font-family:微软雅黑; text-decoration:none;
        }
        .title {width:800px; height:20px; margin:auto; font-size:16px; font-weight:600;}
        .but {width:80px; height:30px; background-color:#00AADC; float:right; margin-right:60px; color:#fff;
        }
            .but a {color:#fff;text-decoration:none; 
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table width="100%" cellspacing="0" cellpadding="0" border="1px">
  <tr>
    <td colspan="2" class="auto-style1" height="50px"><div class="title"> 韶华掠影图片管理<font color="#ff0000">（该板块功能新建，如有问题或遇到未知错误，请及时告知程序部或直接告诉肖，）</font></div></td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td  height="50px">
        <asp:Button ID="btnAddPicture"  class="but" runat="server"  Text="上传图片" OnClick="btnAddPicture_Click" />
        <asp:Button ID="PatchAddPicture"  class="but" runat="server"  Text="批量上传" OnClick="PatchAddPicture_Click" />
        <asp:Button ID="btnEditNode" runat="server" class="but" Text="修改项目" OnClick="btnEditNode_Click" />
        <asp:Button ID="btnNewDir" runat="server" Text="新建目录"  class="but" OnClick="btnNewDir_Click" />
        <asp:Button ID="btnDeleteNode" runat="server" class="but" Text="删除项目" OnClick="btnDeleteNode_Click" />
    </td>
  </tr>
  <tr>
    <td width="300px">
        <asp:TreeView ID="treeList" runat="server" Width="177px" OnSelectedNodeChanged="treeList_SelectedNodeChanged" Height="500px" ImageSet="Arrows">
            <ParentNodeStyle Font-Bold="False" />
            <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
            <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px"
                VerticalPadding="0px" />
            <NodeStyle Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" HorizontalPadding="5px"
                NodeSpacing="0px" VerticalPadding="0px" />
        </asp:TreeView>
    </td>
    <td><asp:Image ID="imagePic" runat="server" Height="487px" Width="842px" /></td>
  </tr>
</table>
    </div>
    </form>
</body>
</html>