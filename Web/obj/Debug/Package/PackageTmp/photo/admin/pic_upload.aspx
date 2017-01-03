<%@ Page Language="C#" AutoEventWireup="true" Inherits="xlxy_admin_pic_upload" Codebehind="pic_upload.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>图片上传</title>
	<style type="text/css">
	   
        #newPreview{ float:right; width:260px;
            FILTER: progid:DXImageTransform.Microsoft.AlphaImageLoader(sizingMethod=scale);
            height: 166px;
        }
        #div1{ width:320px; float:left;}
  

	    body{ text-align:center;}
	   #box{ text-align:left; width:700px; margin-left:260px;
            margin-right: 6px;
        }
	    #title{ background-color:#666666; width:680px; text-align:center;}
table{ font:normal 12px Tahoma;background:#EEEEEE}
button{border:1px solid #666666;background:#EEEEEE}
.STYLE1 {color: #FFFFFF}
        .style1
        {
            width:600px; height:30px;
        }
        .style2
        {
            width:60px;
        }
        
    </style>
    <script type="text/JavaScript">
<!--
function MM_goToURL() { //v3.0
  var i, args=MM_goToURL.arguments; document.MM_returnValue = false;
  for (i=0; i<(args.length-1); i+=2) eval(args[i]+".location='"+args[i+1]+"'");
}
//-->
    </script>
</head>
<body>
<script language="javascript" type="text/javascript">
    function PreviewImg(imgFile) {
        var newPreview = document.getElementById("newPreview");
        newPreview.filters.item("DXImageTransform.Microsoft.AlphaImageLoader").src = imgFile.value;
        newPreview.style.width = "260px";
        newPreview.style.height = "166px";
    }

    </script>


    <form id="form1" runat="server">
    <div id="box">
    <div id="title">
        图片上传</div>
	<table border="1" cellpadding="4" cellspacing="0" bordercolor="#666666">
  
  <tr>
    <td class="style2">&nbsp;名称:</td>
    <td class="style1">&nbsp;<asp:TextBox ID="TextBox_name" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox_name"
            ErrorMessage="必填"></asp:RequiredFieldValidator></td>
  </tr>
  <tr>
    <td class="style2">&nbsp;作者:</td>
    <td class="style1">&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><span style="color: #ff0000">(可不填)</span></td>
  </tr>
  <tr>
    <td class="style2">&nbsp;所在专题:</td>
    <td class="style1"><asp:ScriptManager ID="ScriptManager1" runat="server"> 
</asp:ScriptManager> 
<asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always"> 
<ContentTemplate> 
&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1"
            DataTextField="name" DataValueField="ID" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
            AutoPostBack="True" Width="100px">
        </asp:DropDownList>  
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConStr %>" 
            SelectCommand="SELECT * FROM [Photo_zhtfenlei] ORDER BY [paixu] ASC">
        </asp:SqlDataSource>
        <asp:Label ID="Label1" runat="server" Text=" 专题栏目：" Visible="False"></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server" 
            DataSourceID="SqlDataSource2" DataTextField="name" DataValueField="ID" 
            Width="200px">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConStr %>" 
            SelectCommand="SELECT * FROM [Photo_lmfenlei] WHERE ([zhtID] = @zhtID) order by id desc">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="zhtID" 
                    PropertyName="SelectedValue" Type="Int32" DefaultValue="32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="DropDownList1"
            ErrorMessage="必填"></asp:RequiredFieldValidator>
</ContentTemplate> 
</asp:UpdatePanel> </td>
  </tr>
  
  <tr>
  <td class="style2">图片属性</td>
  <td class="style1">
      <asp:CheckBox ID="CheckBox5" runat="server" Text="新闻网显示"/>
      <asp:CheckBox ID="CheckBox2" runat="server"  Text="视觉焦点" />
      <asp:CheckBox ID="CheckBox3" runat="server" Text="首页显示"  />
      <asp:CheckBox ID="CheckBox4" runat="server" Text="热点图片"/>
      
                    </td>
  
  
  </tr>
  <tr>
    <td class="style2">&nbsp;说明:</td>
    <td class="style1">&nbsp;<asp:TextBox ID="TextBox2" runat="server" Height="100px" TextMode="MultiLine"
            Width="200px"></asp:TextBox></td>
  </tr>
  <tr><td class="style2"><asp:CheckBox ID="CheckBox1" runat="server" Text="添加水印" /></td>
  <td class="style1"><div id="div1"><table>
  <tr><td> <asp:Image ID="Image1" runat="server" Height="40px" Width="100px" />   <asp:Image ID="Image2" runat="server" Height="40px" Width="100px" />    <asp:Image ID="Image3" runat="server" Height="40px" Width="100px" />    </td></tr>
  
  <tr><td> <asp:Image ID="Image4" runat="server" Height="40px" Width="100px" />    <asp:Image ID="Image5" runat="server" Height="40px" Width="100px" />    <asp:Image ID="Image6" runat="server" Height="40px" Width="100px" />   </td></tr>
  <tr><td><asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatColumns="6" 
                    Width="199px">
                  
                <asp:ListItem Selected="True">1</asp:ListItem>
                  <asp:ListItem>2</asp:ListItem>
                  
                  <asp:ListItem>3</asp:ListItem>
                  
                  <asp:ListItem>4</asp:ListItem>
                  
                  <asp:ListItem>5</asp:ListItem>
                  
                  <asp:ListItem>6</asp:ListItem>
              </asp:RadioButtonList></td></tr>
  <tr><td><asp:RadioButtonList ID="RadioButtonList_weizhi" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>左</asp:ListItem>
                <asp:ListItem>中</asp:ListItem>
                <asp:ListItem Selected="True">右</asp:ListItem>
              </asp:RadioButtonList></td></tr>
  
  <tr><td><asp:TextBox ID="kuan" runat="server" Width="30px" Height="22px"  Visible="false"
                   ></asp:TextBox></td></tr>
  
  
  
  </table></div><div id="newPreview"></div></td>
  
  </tr>
  <tr>
 <td class="style2">&nbsp;</td>
    <td class="style1">&nbsp;<asp:FileUpload ID="FileUpload1" runat="server" onchange="PreviewImg(this)"/>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="FileUpload1"
            ErrorMessage="必填" ></asp:RequiredFieldValidator>宽度：<asp:TextBox 
            ID="TextBox_w" runat="server" Width="39px" 
          >800</asp:TextBox>
                    </td>
  </tr>
   <tr>
  <td></td>
  <td>&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label2" runat="server" Text="编辑" 
          Width="40px"></asp:Label><asp:TextBox ID="TextBox4" runat="server" 
          Width="100px"></asp:TextBox> <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox4"
            ErrorMessage="必填"></asp:RequiredFieldValidator>&nbsp;&nbsp;&nbsp; <asp:Label ID="Label3" 
          runat="server" Text="上传时间" Width="60px"></asp:Label><asp:TextBox ID="TextBox3" runat="server" Height="19px"></asp:TextBox></td>
  
  </tr>
  
  <tr>
    <td class="style2">&nbsp;</td>
    <td class="style1">&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="上传" />
      <label>
      <input name="Submit" type="button" onclick="MM_goToURL('self','manage.aspx');return document.MM_returnValue" value="返回" />
          
        
      </label>

      </td>
      
  </tr>
 
</table>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
         
    
    </div>
    </form>
</body>
</html>
