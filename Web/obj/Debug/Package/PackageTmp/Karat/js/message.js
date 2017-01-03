// JavaScript Document

///
function TextAreaOnfocus(textArea, btnID) {
	if(textArea.value=="我要回复...") {
		textArea.value = "";		
	}
	textArea.style.color = "#000000";
	textArea.style.height = "60px";
	$(btnID).style.display = "inline-block";
	textArea.style.border = "1px solid #FFCC00";
}

function AddImg(id,imgSrc) {
	var textarea = $(id);
	var oImg=document.createElement("img");
	oImg.src=imgSrc;
	oImg.width = 24;
	oImg.height = 24;
	textarea.appendChild(oImg);
	alert(textarea.innerHTML);
}
//
function TextAreaCanel(replyID,btnID) {
	var textArea = $(replyID)
	textArea.value = "我要回复...";
	textArea.style.color = "#ccc";
	textArea.style.height = "20px";
	$(btnID).style.display = "none";
}
//
function BtnClick(gid,uid,msg) {
	var msg = $(msg).value;
	if(msg!="") {
		if(msg.length<200) {
			//alert(msg.length);
			var gid = $(gid).value;
			var uid = $(uid).value;
			
			var url = encodeURI("ReplyPage.aspx?gid="+gid+"&uid="+uid+"&msg="+msg);
			//alert(url);
			window.location.href = url;
			} else {
				alert("字数不能超过200个字符！");
			}
	} else {
		alert("内容不能为空！");
	}
}
function BtnZan(uuid)
{
    
           // var uid = $(uid).value;

    var url = encodeURI("ReplyPage.aspx?uuid=" + uuid);
            //alert(url);
            window.location.href = url;
    
}
function Btn_sayclick() {
	var subject = $('subject').value;
	var mysay = $('mySay').value;
	if(subject!=""&&mysay!="") {
		var url = encodeURI("WriteMessage.aspx?sub="+subject+"&msg="+mysay);
		window.location.href = url;
	} else {
		alert("主题或内容不能为空！");
	}
}
//
function TextCount(input) {
	var len = input.value.length;
	$('txtCount').innerHTML = len + "/<span class='redTxt'>200</span>";
}

function InputOnfocus(input) {
	input.style.border = "1px solid #FFCC00";
}
//
function InputOnblur(input) {
	input.style.border = "1px solid #D3D3D3";
}