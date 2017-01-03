// JavaScript Document

function $(id) {
	var obj = document.getElementById(id);
	return obj
}

function Trim(str){   
    return str.replace(/(^\s*)|(\s*$)/g, "");
}


//Ajax函数,将返回的文本作为eval函数的参数
function AjaxReturnText(url) {
    var xmlHttp;

    try {
        // Firefox, Opera 8.0+, Safari
        xmlHttp = new XMLHttpRequest();
    }
    catch (e) {

        // Internet Explorer
        try {
            xmlHttp = new ActiveXObject("Msxml2.XMLHTTP");
        }
        catch (e) {

            try {
                xmlHttp = new ActiveXObject("Microsoft.XMLHTTP");
            }
            catch (e) {
                alert("您的浏览器不支持AJAX！");
                return false;
            }
        }
    }

    xmlHttp.onreadystatechange = function () {
        if (xmlHttp.readyState == 4) {
            return xmlHttp.responseText;
        }
    }
    xmlHttp.open("GET", url, true);
    xmlHttp.send(null);
}

//Ajax函数,将返回的文本作为eval函数的参数
function AjaxEval(url) {
    var xmlHttp;

    try {
        // Firefox, Opera 8.0+, Safari
        xmlHttp = new XMLHttpRequest();
    }
    catch (e) {

        // Internet Explorer
        try {
            xmlHttp = new ActiveXObject("Msxml2.XMLHTTP");
        }
        catch (e) {

            try {
                xmlHttp = new ActiveXObject("Microsoft.XMLHTTP");
            }
            catch (e) {
                alert("您的浏览器不支持AJAX！");
                return false;
            }
        }
    }

    xmlHttp.onreadystatechange = function () {
        if (xmlHttp.readyState == 4) {
            eval(xmlHttp.responseText);
        }
    }
    xmlHttp.open("GET", url, true);
    xmlHttp.send(null);
}

//Ajax函数,返回服务器返回的文本,插入元素的innerHTML属性中
function AjaxSetInnerHTML(url,id) {
    var xmlHttp;

    try {
        // Firefox, Opera 8.0+, Safari
        xmlHttp = new XMLHttpRequest();
    }
    catch (e) {

        // Internet Explorer
        try {
            xmlHttp = new ActiveXObject("Msxml2.XMLHTTP");
        }
        catch (e) {

            try {
                xmlHttp = new ActiveXObject("Microsoft.XMLHTTP");
            }
            catch (e) {
                alert("您的浏览器不支持AJAX！");
                return false;
            }
        }
    }

    xmlHttp.onreadystatechange = function () {
        if (xmlHttp.readyState == 4) {
            $(id).innerHTML = xmlHttp.responseText;
        }
    }
    xmlHttp.open("GET", url, true);
    xmlHttp.send(null);
}