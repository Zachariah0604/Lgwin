var OxO2efc=["onload","contentWindow","idSource","innerHTML","body","document","","designMode","on","contentEditable","fontFamily","style","Tahoma","fontSize","11px","color","black","background","white","length","\x3C$1$3","\x26nbsp;","$1","\x26amp;","\x26lt;","\x26gt;","\x26#39;","\x26quot;"];var editor=Window_GetDialogArguments(window);function cancel(){Window_CloseDialog(window);} ;window[OxO2efc[0]]=function (){var iframe=document.getElementById(OxO2efc[2])[OxO2efc[1]];iframe[OxO2efc[5]][OxO2efc[4]][OxO2efc[3]]=OxO2efc[6];iframe[OxO2efc[5]][OxO2efc[7]]=OxO2efc[8];iframe[OxO2efc[5]][OxO2efc[4]][OxO2efc[9]]=true;iframe[OxO2efc[5]][OxO2efc[4]][OxO2efc[11]][OxO2efc[10]]=OxO2efc[12];iframe[OxO2efc[5]][OxO2efc[4]][OxO2efc[11]][OxO2efc[13]]=OxO2efc[14];iframe[OxO2efc[5]][OxO2efc[4]][OxO2efc[11]][OxO2efc[15]]=OxO2efc[16];iframe[OxO2efc[5]][OxO2efc[4]][OxO2efc[11]][OxO2efc[17]]=OxO2efc[18];iframe.focus();} ;function insertContent(){var iframe=document.getElementById(OxO2efc[2])[OxO2efc[1]];var Oxc7=iframe[OxO2efc[5]][OxO2efc[4]][OxO2efc[3]];if(Oxc7&&Oxc7[OxO2efc[19]]>0){Oxc7=_CleanCode(Oxc7);if(Oxc7.match(/<*>/g)){Oxc7=String_HtmlEncode(Oxc7);} ;editor.PasteHTML(Oxc7);Window_CloseDialog(window);} ;} ;function _CleanCode(Ox2b){Ox2b=Ox2b.replace(/<\\?\??xml[^>]>/gi,OxO2efc[6]);Ox2b=Ox2b.replace(/<([\w]+) class=([^ |>]*)([^>]*)/gi,OxO2efc[20]);Ox2b=Ox2b.replace(/<(\w[^>]*) lang=([^ |>]*)([^>]*)/gi,OxO2efc[20]);Ox2b=Ox2b.replace(/\s*mso-[^:]+:[^;"]+;?/gi,OxO2efc[6]);Ox2b=Ox2b.replace(/<o:p>\s*<\/o:p>/g,OxO2efc[6]);Ox2b=Ox2b.replace(/<o:p>.*?<\/o:p>/g,OxO2efc[21]);Ox2b=Ox2b.replace(/<\/?\w+:[^>]*>/gi,OxO2efc[6]);Ox2b=Ox2b.replace(/<\!--.*-->/g,OxO2efc[6]);Ox2b=Ox2b.replace(/<\\?\?xml[^>]*>/gi,OxO2efc[6]);Ox2b=Ox2b.replace(/<(\w+)[^>]*\sstyle="[^"]*DISPLAY\s?:\s?none(.*?)<\/\1>/ig,OxO2efc[6]);Ox2b=Ox2b.replace(/<span\s*[^>]*>\s*&nbsp;\s*<\/span>/gi,OxO2efc[21]);Ox2b=Ox2b.replace(/<span\s*[^>]*><\/span>/gi,OxO2efc[6]);Ox2b=Ox2b.replace(/\s*style="\s*"/gi,OxO2efc[6]);Ox2b=Ox2b.replace(/<([^\s>]+)[^>]*>\s*<\/\1>/g,OxO2efc[6]);Ox2b=Ox2b.replace(/<([^\s>]+)[^>]*>\s*<\/\1>/g,OxO2efc[6]);Ox2b=Ox2b.replace(/<([^\s>]+)[^>]*>\s*<\/\1>/g,OxO2efc[6]);while(Ox2b.match(/<span\s*>(.*?)<\/span>/gi)){Ox2b=Ox2b.replace(/<span\s*>(.*?)<\/span>/gi,OxO2efc[22]);} ;while(Ox2b.match(/<font\s*>(.*?)<\/font>/gi)){Ox2b=Ox2b.replace(/<font\s*>(.*?)<\/font>/gi,OxO2efc[22]);} ;Ox2b=Ox2b.replace(/<a name="?OLE_LINK\d+"?>((.|[\r\n])*?)<\/a>/gi,OxO2efc[22]);Ox2b=Ox2b.replace(/<a name="?_Hlt\d+"?>((.|[\r\n])*?)<\/a>/gi,OxO2efc[22]);Ox2b=Ox2b.replace(/<a name="?_Toc\d+"?>((.|[\r\n])*?)<\/a>/gi,OxO2efc[22]);Ox2b=Ox2b.replace(/<p([^>])*>(&nbsp;)*\s*<\/p>/gi,OxO2efc[6]);Ox2b=Ox2b.replace(/<p([^>])*>(&nbsp;)<\/p>/gi,OxO2efc[6]);return Ox2b;} ;function String_HtmlEncode(Ox27a){if(Ox27a==null){return OxO2efc[6];} ;Ox27a=Ox27a.replace(/&/g,OxO2efc[23]);Ox27a=Ox27a.replace(/</g,OxO2efc[24]);Ox27a=Ox27a.replace(/>/g,OxO2efc[25]);Ox27a=Ox27a.replace(/'/g,OxO2efc[26]);Ox27a=Ox27a.replace(/\x22/g,OxO2efc[27]);return Ox27a;} ;