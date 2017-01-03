<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KaratPatchUpload.aspx.cs" Inherits="Lgwin.Karat.admin.KaratPatchUpload" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>韶华掠影--批量上传</title>
    <script type="text/javascript" src="js/swfobject.js"></script>   
        <script type="text/javascript" >
            var swfVersionStr = "10.0.0";
            var xiSwfUrlStr = "flash/playerProductInstall.swf";
            var flashvars = {};

            flashvars.URL = "KaratPatchUpload.aspx";//URL保存文件的服务器请求地址
            flashvars.UploadButton = false;
            flashvars.MaxCount = 10;
            flashvars.FileFilters = "Images(*.jpg,*.png,*.gif,*.jpeg)";
            flashvars.FileFormates = "*.jpg;*.png;*.gif;*.jpeg";
            flashvars.DefaultView = "list";

            var params = {};
            params.quality = "high";
            params.bgcolor = "#ffffff";
            params.allowscriptaccess = "sameDomain";
            params.allowfullscreen = "true";
            var attributes = {};
            attributes.id = "MutipleFileUpload";
            attributes.name = "MutipleFileUpload";
            attributes.align = "middle";
            swfobject.embedSWF(
                "flash/MutipleFileUpload.swf", "flashContent",
                "580", "340",
                swfVersionStr, xiSwfUrlStr,
                flashvars, params, attributes);

            function uploadCompelete() {

            }
            function submitForm() {
                if (!flashvars.UploadButton)
                    thisMovie("MutipleFileUpload").uploadFiles();
            }
            function thisMovie(movieName) {
                if (navigator.appName.indexOf("Microsoft") != -1) {
                    return window[movieName];
                } else {
                    return document[movieName];
                }
            }
            function disabledButton() {
                document.getElementById('btnUpload').disabled = true;
            }

        </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <div id="flashContent"  style="width:580px; height:340px"></div>
        <br />
        <input id="btnUpload" style="width: 71px" type="button" value="上 传" onclick="submitForm()" />
        &nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Text="返回" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>