var OxOed0c=["onload","contentWindow","idSource","innerHTML","body","document","","designMode","on","contentEditable","fontFamily","style","Tahoma","fontSize","11px","color","black","background","white","length","\x22","\x3C$1$3"," ","\x26nbsp;","$1","\x3Ch$1\x3E","\x3C$1\x3E$2\x3C/$1\x3E"];var editor=Window_GetDialogArguments(window);function cancel(){Window_CloseDialog(window);} ;window[OxOed0c[0]]=function (){var iframe=document.getElementById(OxOed0c[2])[OxOed0c[1]];iframe[OxOed0c[5]][OxOed0c[4]][OxOed0c[3]]=OxOed0c[6];iframe[OxOed0c[5]][OxOed0c[7]]=OxOed0c[8];iframe[OxOed0c[5]][OxOed0c[4]][OxOed0c[9]]=true;iframe[OxOed0c[5]][OxOed0c[4]][OxOed0c[11]][OxOed0c[10]]=OxOed0c[12];iframe[OxOed0c[5]][OxOed0c[4]][OxOed0c[11]][OxOed0c[13]]=OxOed0c[14];iframe[OxOed0c[5]][OxOed0c[4]][OxOed0c[11]][OxOed0c[15]]=OxOed0c[16];iframe[OxOed0c[5]][OxOed0c[4]][OxOed0c[11]][OxOed0c[17]]=OxOed0c[18];iframe.focus();} ;function insertContent(){var iframe=document.getElementById(OxOed0c[2])[OxOed0c[1]];var Oxc7=iframe[OxOed0c[5]][OxOed0c[4]][OxOed0c[3]];if(Oxc7&&Oxc7[OxOed0c[19]]>0){editor.PasteHTML(_RemoveWord(Oxc7));Window_CloseDialog(window);} ;} ;function _RemoveWord(Ox2b){Ox2b=Ox2b.replace(/<[\/]?(base|meta|link|style|font|st1|shape|path|lock|imagedata|stroke|formulas|xml|del|ins|[ovwxp]:\w+)[^>]*?>/gi,OxOed0c[6]);Ox2b=Ox2b.replace(/\s*mso-[^:]+:[^;"]+;?/gi,OxOed0c[6]);Ox2b=Ox2b.replace(/<!--[\s\S]*?-->/gi,OxOed0c[6]);Ox2b=Ox2b.replace(/\s*MARGIN: 0cm 0cm 0pt\s*;/gi,OxOed0c[6]);Ox2b=Ox2b.replace(/\s*MARGIN: 0cm 0cm 0pt\s*"/gi,OxOed0c[20]);Ox2b=Ox2b.replace(/\s*TEXT-INDENT: 0cm\s*;/gi,OxOed0c[6]);Ox2b=Ox2b.replace(/\s*TEXT-INDENT: 0cm\s*"/gi,OxOed0c[20]);Ox2b=Ox2b.replace(/\s*TEXT-ALIGN: [^\s;]+;?"/gi,OxOed0c[20]);Ox2b=Ox2b.replace(/\s*PAGE-BREAK-BEFORE: [^\s;]+;?"/gi,OxOed0c[20]);Ox2b=Ox2b.replace(/\s*FONT-VARIANT: [^\s;]+;?"/gi,OxOed0c[20]);Ox2b=Ox2b.replace(/\s*tab-stops:[^;"]*;?/gi,OxOed0c[6]);Ox2b=Ox2b.replace(/\s*tab-stops:[^"]*/gi,OxOed0c[6]);Ox2b=Ox2b.replace(/<(\w[^>]*) class=([^ |>]*)([^>]*)/gi,OxOed0c[21]);Ox2b=Ox2b.replace(/\s*style="\s*"/gi,OxOed0c[6]);Ox2b=Ox2b.replace(/<SPAN\s*[^>]*>\s* \s*<\/SPAN>/gi,OxOed0c[22]);Ox2b=Ox2b.replace(/<(\w+)[^>]*\sstyle="[^"]*DISPLAY\s?:\s?none(.*?)<\/\1>/ig,OxOed0c[6]);Ox2b=Ox2b.replace(/<span\s*[^>]*>\s*&nbsp;\s*<\/span>/gi,OxOed0c[23]);Ox2b=Ox2b.replace(/<SPAN\s*[^>]*><\/SPAN>/gi,OxOed0c[6]);Ox2b=Ox2b.replace(/<(\w[^>]*) lang=([^ |>]*)([^>]*)/gi,OxOed0c[21]);Ox2b=Ox2b.replace(/<SPAN\s*>(.*?)<\/SPAN>/gi,OxOed0c[24]);Ox2b=Ox2b.replace(/<\/?\w+:[^>]*>/gi,OxOed0c[6]);Ox2b=Ox2b.replace(/<\!--.*?-->/g,OxOed0c[6]);Ox2b=Ox2b.replace(/<H\d>\s*<\/H\d>/gi,OxOed0c[6]);Ox2b=Ox2b.replace(/<(\w[^>]*) language=([^ |>]*)([^>]*)/gi,OxOed0c[21]);Ox2b=Ox2b.replace(/<(\w[^>]*) onmouseover="([^\"]*)"([^>]*)/gi,OxOed0c[21]);Ox2b=Ox2b.replace(/<(\w[^>]*) onmouseout="([^\"]*)"([^>]*)/gi,OxOed0c[21]);Ox2b=Ox2b.replace(/<H(\d)([^>]*)>/gi,OxOed0c[25]);Ox2b=Ox2b.replace(/<(H\d)><FONT[^>]*>(.*?)<\/FONT><\/\1>/gi,OxOed0c[26]);Ox2b=Ox2b.replace(/<(H\d)><EM>(.*?)<\/EM><\/\1>/gi,OxOed0c[26]);Ox2b=Ox2b.replace(/<a name="?OLE_LINK\d+"?>((.|[\r\n])*?)<\/a>/gi,OxOed0c[24]);Ox2b=Ox2b.replace(/<a name="?_Hlt\d+"?>((.|[\r\n])*?)<\/a>/gi,OxOed0c[24]);Ox2b=Ox2b.replace(/<a name="?_Toc\d+"?>((.|[\r\n])*?)<\/a>/gi,OxOed0c[24]);return Ox2b;} ;