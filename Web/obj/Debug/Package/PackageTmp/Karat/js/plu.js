function StopButton() {
    document.getElementById(arguments[0]).disabled = true;
    document.getElementById(arguments[0]).value = "提交(" + arguments[1] + ")";
    if (--arguments[1] > 0) {
        window.setTimeout("StopButton('" + arguments[0] + "'," + arguments[1] + ")", 1000);
    }
    if (arguments[1] <= 0) {
        document.getElementById(arguments[0]).value = '提交';
        document.getElementById(arguments[0]).disabled = false;
    }
}
function GetComment($ID, $Page, $CommentType) {
    $.ajax({

        url: "http://lgwindow.sdut.edu.cn/karat/karat_dongtai/karat_dongtai_3rd/CommentIndex.aspx?action=ajax_getcomment&id=" + $ID + "&commmentpage=" + $Page + "&type=" + $CommentType + "&time" + new Date().toString(),
        type: 'GET',
        success: function () {
            $('#comment').html(arguments[0]);
        }
    });
}
function SendComment() {
    var $CommentParentID = arguments[0];
    var $CommentType = arguments[1];
    var $CommentUser = $('#CommentUser').val();
  
  
    var $CommentText = $('#CommentText').val();
   
    if ($.trim($CommentUser) == '') {
        alert('请您填写昵称！');
        $('#CommentUser').focus();
        return false;
    }
   
   
    if ($.trim($CommentText) == '') {
        alert('请您填写回复内容！');
        $('#CommentText').focus();
        return false;
    }
    if ($CommentText.length < 5 || $CommentText.length > 200) {
        alert('内容必须在5-200字之间！');
        return false;
    }
    StopButton('CommentSubmit', 10);
    $.ajax({
        url: "http://lgwindow.sdut.edu.cn/karat/karat_dongtai/karat_dongtai_3rd/CommentIndex.aspx?action=ajax_sendcomment&commentparentid=" + $CommentParentID + "&commenttype=" + $CommentType + "&commentuser=" + escape($CommentUser) + "&commenttext=" + escape($CommentText).replace(/&#39;/g, "\'") + "&time=" + new Date().toString(),
        type: 'GET',
        success: function () {
           
                GetComment($CommentParentID, 1, $CommentType); //忘记$CommentType，导致评论写入显示时没有type
                alert(arguments[0]);
                $("#CommentText").val("");//清空评论
               
        }
    });
    //SetCookie("CommentUser",$CommentUser,3);
}