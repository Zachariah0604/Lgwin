var OxO2567=["zoomcount","wheelDelta","zoom","style","0%","top","hiddenDirectory","hiddenFile","hiddenAlert","hiddenAction","hiddenActionData","This function is disabled in the demo mode.","disabled","[[Disabled]]","[[SpecifyNewFolderName]]","","value","createdir","[[CopyMoveto]]","/","move","copy","[[AreyouSureDelete]]","parentNode","text","isdir","true",".","[[SpecifyNewFileName]]","rename","True","False",":","path","FoldersAndFiles","TR","length","onmouseover","this.bgColor=\x27#eeeeee\x27;","onmouseout","this.bgColor=\x27\x27;","nodeName","INPUT","changedir","url","TargetUrl","htmlcode","onload","getElementsByTagName","table","sortable"," ","className","id","rows","cells","innerHTML","\x3Ca href=\x22#\x22 onclick=\x22ts_resortTable(this);return false;\x22\x3E","\x3Cspan class=\x22sortarrow\x22\x3E\x26nbsp;\x3C/span\x3E\x3C/a\x3E","string","undefined","innerText","childNodes","nodeValue","nodeType","span","cellIndex","TABLE","sortdir","down","\x26uarr;","up","\x26darr;","sortbottom","tBodies","sortarrow","\x26nbsp;","20","19","Form1","Image1","FolderDescription","CreateDir","Copy","Move","img_AutoThumbnail","img_ImageEditor","Delete","DoRefresh","name_Cell","size_Cell","op_Cell","op_space","divpreview","img_demo","Align","Border","bordercolor","bordercolor_Preview","inp_width","imgLock","inp_height","constrain_prop","HSpace","VSpace","AlternateText","inp_id","longDesc","fieldsetUpload","Button1","Button2","btn_zoom_in","btn_zoom_out","btn_Actualsize","btn_bestfit","img","editor","src","src_cetemp","width","height","vspace","hspace","border","borderColor","backgroundColor","align","alt","file","IMG","complete","../images/1x1.gif","?","\x26time=","?time=","0","onmousewheel",".aspx","display","none","Edit","[[ValidID]]","[[ValidColor]]","[[SelectImagetoInsert]]","longdesc","=\x22","\x22","checked","../Load.ashx?type=image\x26file=locked.gif","../Load.ashx?type=image\x26file=1x1.gif","[[SelectImagetoThumbnail]]","dir","refresh","Thumbnail.aspx?","dialogWidth:310px;dialogHeight:150px;help:no;scroll:no;status:no;resizable:1;","UseStandardDialog","1","\x26Dialog=Standard","setting=","EditorSetting","\x26Theme=","Theme","\x26","DNNArg","[[SelectImagetoEdit]]","[[_CuteEditorResource_]]","../ImageEditor/ImageEditor.aspx?f=","\x26p=","dialogWidth:676px;dialogHeight:500px;help:no;scroll:no;status:no;resizable:0;","onclick","wrapupPrompt","iepromptfield","body","div","IEPromptBox","promptBlackout","1px solid #b0bec7","#f0f0f0","position","absolute","330px","zIndex","100","\x3Cdiv style=\x22width: 100%; padding-top:3px;background-color: #DCE7EB; font-family: verdana; font-size: 10pt; font-weight: bold; height: 22px; text-align:center; background:url(Load.ashx?type=image\x26file=formbg2.gif) repeat-x left top;\x22\x3E[[InputRequired]]\x3C/div\x3E","\x3Cdiv style=\x22padding: 10px\x22\x3E","\x3CBR\x3E\x3CBR\x3E","\x3Cform action=\x22\x22 onsubmit=\x22return wrapupPrompt()\x22\x3E","\x3Cinput id=\x22iepromptfield\x22 name=\x22iepromptdata\x22 type=text size=46 value=\x22","\x22\x3E","\x3Cbr\x3E\x3Cbr\x3E\x3Ccenter\x3E","\x3Cinput type=\x22submit\x22 value=\x22\x26nbsp;\x26nbsp;\x26nbsp;[[OK]]\x26nbsp;\x26nbsp;\x26nbsp;\x22\x3E","\x26nbsp;\x26nbsp;\x26nbsp;\x26nbsp;\x26nbsp;\x26nbsp;","\x3Cinput type=\x22button\x22 onclick=\x22wrapupPrompt(true)\x22 value=\x22\x26nbsp;[[Cancel]]\x26nbsp;\x22\x3E","\x3C/form\x3E\x3C/div\x3E","100px","left","offsetWidth","px","block","CuteEditor_ColorPicker_ButtonOver(this)"];function OnImageMouseWheel(){var Ox32a=Event_GetEvent();var img=Event_GetSrcElement(Ox32a);var Ox406=img[OxO2567[0]]||3;if(Ox32a[OxO2567[1]]>=106){Ox406++;} else {if(Ox32a[OxO2567[1]]<=-106){Ox406--;} ;} ;img[OxO2567[0]]=Ox406;img[OxO2567[3]][OxO2567[2]]=Ox406+OxO2567[4];return false;} ;function Window_GetDialogTop(Ox1a1){return Ox1a1[OxO2567[5]];} ;var hiddenDirectory=Window_GetElement(window,OxO2567[6],true);var hiddenFile=Window_GetElement(window,OxO2567[7],true);var hiddenAlert=Window_GetElement(window,OxO2567[8],true);var hiddenAction=Window_GetElement(window,OxO2567[9],true);var hiddenActionData=Window_GetElement(window,OxO2567[10],true);function CreateDir_click(){if(isDemoMode){alert(OxO2567[11]);return false;} ;if(Event_GetSrcElement()[OxO2567[12]]){alert(OxO2567[13]);return false;} ;if(Browser_IsIE7()){IEprompt(Ox218,OxO2567[14],OxO2567[15]);function Ox218(Ox379){if(Ox379){hiddenActionData[OxO2567[16]]=Ox379;hiddenAction[OxO2567[16]]=OxO2567[17];window.PostBackAction();return true;} else {return false;} ;} ;return Event_CancelEvent();} else {var Ox379=prompt(OxO2567[14],OxO2567[15]);if(Ox379){hiddenActionData[OxO2567[16]]=Ox379;return true;} else {return false;} ;return false;} ;} ;function Move_click(){if(isDemoMode){alert(OxO2567[11]);return false;} ;if(Event_GetSrcElement()[OxO2567[12]]){alert(OxO2567[13]);return false;} ;if(Browser_IsIE7()){IEprompt(Ox218,OxO2567[18],OxO2567[19]);function Ox218(Ox379){if(Ox379){hiddenActionData[OxO2567[16]]=Ox379;hiddenAction[OxO2567[16]]=OxO2567[20];window.PostBackAction();return true;} else {return false;} ;} ;return Event_CancelEvent();} else {var Ox379=prompt(OxO2567[18],OxO2567[19]);if(Ox379){hiddenActionData[OxO2567[16]]=Ox379;return true;} else {return false;} ;return false;} ;} ;function Copy_click(){if(isDemoMode){alert(OxO2567[11]);return false;} ;if(Event_GetSrcElement()[OxO2567[12]]){alert(OxO2567[13]);return false;} ;if(Browser_IsIE7()){IEprompt(Ox218,OxO2567[18],OxO2567[19]);function Ox218(Ox379){if(Ox379){hiddenActionData[OxO2567[16]]=Ox379;hiddenAction[OxO2567[16]]=OxO2567[21];window.PostBackAction();return true;} else {return false;} ;} ;return Event_CancelEvent();} else {var Ox379=prompt(OxO2567[18],OxO2567[19]);if(Ox379){hiddenActionData[OxO2567[16]]=Ox379;return true;} else {return false;} ;return false;} ;} ;function Delete_click(){if(isDemoMode){alert(OxO2567[11]);return false;} ;if(Event_GetSrcElement()[OxO2567[12]]){alert(OxO2567[13]);return false;} ;return confirm(OxO2567[22]);} ;function EditImg_click(img){if(isDemoMode){alert(OxO2567[11]);return false;} ;if(img[OxO2567[12]]){alert(OxO2567[13]);return false;} ;var Ox37e=img[OxO2567[23]][OxO2567[23]];var Ox37f=Ox37e[OxO2567[24]];var name;var Ox380;if(Browser_IsOpera()){Ox380=Ox37e.getAttribute(OxO2567[25])==OxO2567[26];} else {Ox380=Ox37e[OxO2567[25]];} ;if(Browser_IsIE7()){var Oxc3;if(Ox380){IEprompt(Ox218,OxO2567[14],Ox37f);} else {var i=Ox37f.lastIndexOf(OxO2567[27]);Oxc3=Ox37f.substr(i);var Ox12=Ox37f.substr(0,Ox37f.lastIndexOf(OxO2567[27]));IEprompt(Ox218,OxO2567[28],Ox12);} ;function Ox218(Ox379){if(Ox379&&Ox379!=Ox37e[OxO2567[24]]){if(!Ox380){Ox379=Ox379+Oxc3;} ;hiddenAction[OxO2567[16]]=OxO2567[29];hiddenActionData[OxO2567[16]]=(Ox380?OxO2567[30]:OxO2567[31])+OxO2567[32]+Ox37e[OxO2567[33]]+OxO2567[32]+Ox379;window.PostBackAction();} ;} ;} else {if(Ox380){name=prompt(OxO2567[14],Ox37f);} else {var i=Ox37f.lastIndexOf(OxO2567[27]);var Oxc3=Ox37f.substr(i);var Ox12=Ox37f.substr(0,Ox37f.lastIndexOf(OxO2567[27]));name=prompt(OxO2567[28],Ox12);if(name){name=name+Oxc3;} ;} ;if(name&&name!=Ox37e[OxO2567[24]]){hiddenAction[OxO2567[16]]=OxO2567[29];hiddenActionData[OxO2567[16]]=(Ox380?OxO2567[30]:OxO2567[31])+OxO2567[32]+Ox37e[OxO2567[33]]+OxO2567[32]+name;window.PostBackAction();} ;} ;return Event_CancelEvent();} ;setMouseOver();function setMouseOver(){var FoldersAndFiles=Window_GetElement(window,OxO2567[34],true);var Ox383=FoldersAndFiles.getElementsByTagName(OxO2567[35]);for(var i=0;i<Ox383[OxO2567[36]];i++){var Ox37e=Ox383[i];Ox37e[OxO2567[37]]= new Function(OxO2567[15],OxO2567[38]);Ox37e[OxO2567[39]]= new Function(OxO2567[15],OxO2567[40]);} ;} ;function row_click(Ox37e){var Ox380;if(Browser_IsOpera()){Ox380=Ox37e.getAttribute(OxO2567[25])==OxO2567[26];} else {Ox380=Ox37e[OxO2567[25]];} ;if(Ox380){if(Event_GetSrcElement()[OxO2567[41]]==OxO2567[42]){return ;} ;hiddenAction[OxO2567[16]]=OxO2567[43];hiddenActionData[OxO2567[16]]=Ox37e.getAttribute(OxO2567[33]);window.PostBackAction();} else {var Ox102=Ox37e.getAttribute(OxO2567[33]);hiddenFile[OxO2567[16]]=Ox102;var Ox280=Ox37e.getAttribute(OxO2567[44]);Window_GetElement(window,OxO2567[45],true)[OxO2567[16]]=Ox280;var htmlcode=Ox37e.getAttribute(OxO2567[46]);if(htmlcode!=OxO2567[15]&&htmlcode!=null){do_preview(htmlcode);} else {if(Ox280!=OxO2567[15]&&Ox280!=null){try{Actualsize();} catch(x){do_preview();} ;} ;} ;} ;} ;function reset_hiddens(){if(hiddenAlert[OxO2567[16]]){alert(hiddenAlert.value);} ;if(TargetUrl[OxO2567[16]]!=OxO2567[15]&&TargetUrl[OxO2567[16]]!=null){do_preview();} ;hiddenAlert[OxO2567[16]]=OxO2567[15];hiddenAction[OxO2567[16]]=OxO2567[15];hiddenActionData[OxO2567[16]]=OxO2567[15];} ;Event_Attach(window,OxO2567[47],reset_hiddens);function RequireFileBrowseScript(){} ;Event_Attach(window,OxO2567[47],sortables_init);var SORT_COLUMN_INDEX;function sortables_init(){if(!document[OxO2567[48]]){return ;} ;var Ox388=document.getElementsByTagName(OxO2567[49]);for(var Ox389=0;Ox389<Ox388[OxO2567[36]];Ox389++){var Ox38a=Ox388[Ox389];if(((OxO2567[51]+Ox38a[OxO2567[52]]+OxO2567[51]).indexOf(OxO2567[50])!=-1)&&(Ox38a[OxO2567[53]])){ts_makeSortable(Ox38a);} ;} ;} ;function ts_makeSortable(Ox38c){if(Ox38c[OxO2567[54]]&&Ox38c[OxO2567[54]][OxO2567[36]]>0){var Ox38d=Ox38c[OxO2567[54]][0];} ;if(!Ox38d){return ;} ;for(var i=2;i<4;i++){var Ox38e=Ox38d[OxO2567[55]][i];var Ox27b=ts_getInnerText(Ox38e);Ox38e[OxO2567[56]]=OxO2567[57]+Ox27b+OxO2567[58];} ;} ;function ts_getInnerText(Ox27){if( typeof Ox27==OxO2567[59]){return Ox27;} ;if( typeof Ox27==OxO2567[60]){return Ox27;} ;if(Ox27[OxO2567[61]]){return Ox27[OxO2567[61]];} ;var Ox24=OxO2567[15];var Ox33a=Ox27[OxO2567[62]];var Ox11=Ox33a[OxO2567[36]];for(var i=0;i<Ox11;i++){switch(Ox33a[i][OxO2567[64]]){case 1:Ox24+=ts_getInnerText(Ox33a[i]);break ;;case 3:Ox24+=Ox33a[i][OxO2567[63]];break ;;} ;} ;return Ox24;} ;function ts_resortTable(Ox391){var Ox29e;for(var Ox392=0;Ox392<Ox391[OxO2567[62]][OxO2567[36]];Ox392++){if(Ox391[OxO2567[62]][Ox392][OxO2567[41]]&&Ox391[OxO2567[62]][Ox392][OxO2567[41]].toLowerCase()==OxO2567[65]){Ox29e=Ox391[OxO2567[62]][Ox392];} ;} ;var Ox393=ts_getInnerText(Ox29e);var Ox1dd=Ox391[OxO2567[23]];var Ox394=Ox1dd[OxO2567[66]];var Ox38c=getParent(Ox1dd,OxO2567[67]);if(Ox38c[OxO2567[54]][OxO2567[36]]<=1){return ;} ;var Ox395=ts_getInnerText(Ox38c[OxO2567[54]][1][OxO2567[55]][Ox394]);var Ox396=ts_sort_caseinsensitive;if(Ox395.match(/^\d\d[\/-]\d\d[\/-]\d\d\d\d$/)){Ox396=ts_sort_date;} ;if(Ox395.match(/^\d\d[\/-]\d\d[\/-]\d\d$/)){Ox396=ts_sort_date;} ;if(Ox395.match(/^[?]/)){Ox396=ts_sort_currency;} ;if(Ox395.match(/^[\d\.]+$/)){Ox396=ts_sort_numeric;} ;SORT_COLUMN_INDEX=Ox394;var Ox38d= new Array();var Ox397= new Array();for(var i=0;i<Ox38c[OxO2567[54]][0][OxO2567[36]];i++){Ox38d[i]=Ox38c[OxO2567[54]][0][i];} ;for(var j=1;j<Ox38c[OxO2567[54]][OxO2567[36]];j++){Ox397[j-1]=Ox38c[OxO2567[54]][j];} ;Ox397.sort(Ox396);if(Ox29e.getAttribute(OxO2567[68])==OxO2567[69]){var Ox398=OxO2567[70];Ox397.reverse();Ox29e.setAttribute(OxO2567[68],OxO2567[71]);} else {Ox398=OxO2567[72];Ox29e.setAttribute(OxO2567[68],OxO2567[69]);} ;for(i=0;i<Ox397[OxO2567[36]];i++){if(!Ox397[i][OxO2567[52]]||(Ox397[i][OxO2567[52]]&&(Ox397[i][OxO2567[52]].indexOf(OxO2567[73])==-1))){Ox38c[OxO2567[74]][0].appendChild(Ox397[i]);} ;} ;for(i=0;i<Ox397[OxO2567[36]];i++){if(Ox397[i][OxO2567[52]]&&(Ox397[i][OxO2567[52]].indexOf(OxO2567[73])!=-1)){Ox38c[OxO2567[74]][0].appendChild(Ox397[i]);} ;} ;var Ox399=document.getElementsByTagName(OxO2567[65]);for(var Ox392=0;Ox392<Ox399[OxO2567[36]];Ox392++){if(Ox399[Ox392][OxO2567[52]]==OxO2567[75]){if(getParent(Ox399[Ox392],OxO2567[49])==getParent(Ox391,OxO2567[49])){Ox399[Ox392][OxO2567[56]]=OxO2567[76];} ;} ;} ;Ox29e[OxO2567[56]]=Ox398;} ;function getParent(Ox27,Ox39b){if(Ox27==null){return null;} else {if(Ox27[OxO2567[64]]==1&&Ox27[OxO2567[41]].toLowerCase()==Ox39b.toLowerCase()){return Ox27;} else {return getParent(Ox27.parentNode,Ox39b);} ;} ;} ;function ts_sort_date(Oxe7,b){var Ox39d=ts_getInnerText(Oxe7[OxO2567[55]][SORT_COLUMN_INDEX]);var Ox39e=ts_getInnerText(b[OxO2567[55]][SORT_COLUMN_INDEX]);if(Ox39d[OxO2567[36]]==10){var Ox39f=Ox39d.substr(6,4)+Ox39d.substr(3,2)+Ox39d.substr(0,2);} else {var Ox3a0=Ox39d.substr(6,2);if(parseInt(Ox3a0)<50){Ox3a0=OxO2567[77]+Ox3a0;} else {Ox3a0=OxO2567[78]+Ox3a0;} ;var Ox39f=Ox3a0+Ox39d.substr(3,2)+Ox39d.substr(0,2);} ;if(Ox39e[OxO2567[36]]==10){var Ox3a1=Ox39e.substr(6,4)+Ox39e.substr(3,2)+Ox39e.substr(0,2);} else {Ox3a0=Ox39e.substr(6,2);if(parseInt(Ox3a0)<50){Ox3a0=OxO2567[77]+Ox3a0;} else {Ox3a0=OxO2567[78]+Ox3a0;} ;var Ox3a1=Ox3a0+Ox39e.substr(3,2)+Ox39e.substr(0,2);} ;if(Ox39f==Ox3a1){return 0;} ;if(Ox39f<Ox3a1){return -1;} ;return 1;} ;function ts_sort_currency(Oxe7,b){var Ox39d=ts_getInnerText(Oxe7[OxO2567[55]][SORT_COLUMN_INDEX]).replace(/[^0-9.]/g,OxO2567[15]);var Ox39e=ts_getInnerText(b[OxO2567[55]][SORT_COLUMN_INDEX]).replace(/[^0-9.]/g,OxO2567[15]);return parseFloat(Ox39d)-parseFloat(Ox39e);} ;function ts_sort_numeric(Oxe7,b){var Ox39d=parseFloat(ts_getInnerText(Oxe7[OxO2567[55]][SORT_COLUMN_INDEX]));if(isNaN(Ox39d)){Ox39d=0;} ;var Ox39e=parseFloat(ts_getInnerText(b[OxO2567[55]][SORT_COLUMN_INDEX]));if(isNaN(Ox39e)){Ox39e=0;} ;return Ox39d-Ox39e;} ;function ts_sort_caseinsensitive(Oxe7,b){var Ox39d=ts_getInnerText(Oxe7[OxO2567[55]][SORT_COLUMN_INDEX]).toLowerCase();var Ox39e=ts_getInnerText(b[OxO2567[55]][SORT_COLUMN_INDEX]).toLowerCase();if(Ox39d==Ox39e){return 0;} ;if(Ox39d<Ox39e){return -1;} ;return 1;} ;function ts_sort_default(Oxe7,b){var Ox39d=ts_getInnerText(Oxe7[OxO2567[55]][SORT_COLUMN_INDEX]);var Ox39e=ts_getInnerText(b[OxO2567[55]][SORT_COLUMN_INDEX]);if(Ox39d==Ox39e){return 0;} ;if(Ox39d<Ox39e){return -1;} ;return 1;} [sortables_init];RequireFileBrowseScript();var Form1=Window_GetElement(window,OxO2567[79],true);var hiddenDirectory=Window_GetElement(window,OxO2567[6],true);var hiddenFile=Window_GetElement(window,OxO2567[7],true);var hiddenAlert=Window_GetElement(window,OxO2567[8],true);var hiddenAction=Window_GetElement(window,OxO2567[9],true);var hiddenActionData=Window_GetElement(window,OxO2567[10],true);var Image1=Window_GetElement(window,OxO2567[80],true);var FolderDescription=Window_GetElement(window,OxO2567[81],true);var CreateDir=Window_GetElement(window,OxO2567[82],true);var Copy=Window_GetElement(window,OxO2567[83],true);var Move=Window_GetElement(window,OxO2567[84],true);var img_AutoThumbnail=Window_GetElement(window,OxO2567[85],true);var img_ImageEditor=Window_GetElement(window,OxO2567[86],false);var FoldersAndFiles=Window_GetElement(window,OxO2567[34],true);var Delete=Window_GetElement(window,OxO2567[87],true);var DoRefresh=Window_GetElement(window,OxO2567[88],true);var name_Cell=Window_GetElement(window,OxO2567[89],true);var size_Cell=Window_GetElement(window,OxO2567[90],true);var op_Cell=Window_GetElement(window,OxO2567[91],true);var op_space=Window_GetElement(window,OxO2567[92],true);var divpreview=Window_GetElement(window,OxO2567[93],true);var img_demo=Window_GetElement(window,OxO2567[94],true);var Align=Window_GetElement(window,OxO2567[95],true);var Border=Window_GetElement(window,OxO2567[96],true);var bordercolor=Window_GetElement(window,OxO2567[97],true);var bordercolor_Preview=Window_GetElement(window,OxO2567[98],true);var inp_width=Window_GetElement(window,OxO2567[99],true);var imgLock=Window_GetElement(window,OxO2567[100],true);var inp_height=Window_GetElement(window,OxO2567[101],true);var constrain_prop=Window_GetElement(window,OxO2567[102],true);var HSpace=Window_GetElement(window,OxO2567[103],true);var VSpace=Window_GetElement(window,OxO2567[104],true);var TargetUrl=Window_GetElement(window,OxO2567[45],true);var AlternateText=Window_GetElement(window,OxO2567[105],true);var inp_id=Window_GetElement(window,OxO2567[106],true);var longDesc=Window_GetElement(window,OxO2567[107],true);var fieldsetUpload=Window_GetElement(window,OxO2567[108],true);var Button1=Window_GetElement(window,OxO2567[109],true);var Button2=Window_GetElement(window,OxO2567[110],true);var btn_zoom_in=Window_GetElement(window,OxO2567[111],true);var btn_zoom_out=Window_GetElement(window,OxO2567[112],true);var btn_Actualsize=Window_GetElement(window,OxO2567[113],true);var btn_bestfit=Window_GetElement(window,OxO2567[114],true);var obj=Window_GetDialogArguments(window);var element=obj[OxO2567[115]];var editor=obj[OxO2567[116]];var src=OxO2567[15];if(element.getAttribute(OxO2567[117])){src=element.getAttribute(OxO2567[117]);} ;if(element.getAttribute(OxO2567[118])){src=element.getAttribute(OxO2567[118]);} ;inp_width[OxO2567[16]]=element[OxO2567[119]]||OxO2567[15];inp_height[OxO2567[16]]=element[OxO2567[120]]||OxO2567[15];inp_id[OxO2567[16]]=element[OxO2567[53]]||OxO2567[15];if(element[OxO2567[121]]<=0){VSpace[OxO2567[16]]=OxO2567[15];} else {VSpace[OxO2567[16]]=element[OxO2567[121]];} ;if(element[OxO2567[122]]<=0){HSpace[OxO2567[16]]=OxO2567[15];} else {HSpace[OxO2567[16]]=element[OxO2567[122]];} ;Border[OxO2567[16]]=element[OxO2567[123]]||OxO2567[15];if(Browser_IsWinIE()){bordercolor[OxO2567[16]]=element[OxO2567[3]][OxO2567[124]];} else {var arr=revertColor(element[OxO2567[3]].borderColor).split(OxO2567[51]);bordercolor[OxO2567[16]]=arr[0];} ;bordercolor[OxO2567[3]][OxO2567[125]]=bordercolor[OxO2567[16]]||OxO2567[15];bordercolor_Preview[OxO2567[3]][OxO2567[125]]=bordercolor[OxO2567[16]]||OxO2567[15];Align[OxO2567[16]]=element[OxO2567[126]]||OxO2567[15];AlternateText[OxO2567[16]]=element[OxO2567[127]]||OxO2567[15];longDesc[OxO2567[16]]=element[OxO2567[107]]||OxO2567[15];if(TargetUrl[OxO2567[16]]){Actualsize();} else {if(element&&src){TargetUrl[OxO2567[16]]=src;} ;} ;var sCheckFlag=OxO2567[128];function ResetFields(){TargetUrl[OxO2567[16]]=OxO2567[15];inp_width[OxO2567[16]]=OxO2567[15];inp_height[OxO2567[16]]=OxO2567[15];inp_id[OxO2567[16]]=OxO2567[15];VSpace[OxO2567[16]]=OxO2567[15];HSpace[OxO2567[16]]=OxO2567[15];Border[OxO2567[16]]=OxO2567[15];bordercolor[OxO2567[16]]=OxO2567[15];bordercolor[OxO2567[3]][OxO2567[125]]=OxO2567[15];Align[OxO2567[16]]=OxO2567[15];AlternateText[OxO2567[16]]=OxO2567[15];longDesc[OxO2567[16]]=OxO2567[15];} ;function do_preview(){var Ox228=TargetUrl[OxO2567[16]];if(Ox228==null){TargetUrl[OxO2567[16]]=OxO2567[15];Ox228==OxO2567[15];} ;if(Ox228!=null&&Ox228!=OxO2567[15]){var Ox415;var Ox416;var Ox415=document.createElement(OxO2567[129]);Ox415[OxO2567[117]]=Ox228;function Ox417(){if(Ox415[OxO2567[130]]){window.clearInterval(Ox416);var Oxa0= new Date();var Oxa1=Oxa0.getTime();if(Ox228==OxO2567[15]){Ox228=OxO2567[131];} ;if(Ox228.indexOf(OxO2567[132])!=-1){Ox228=Ox228+OxO2567[133]+Oxa1;} else {Ox228=Ox228+OxO2567[134]+Oxa1;} ;if(inp_width[OxO2567[16]]==OxO2567[135]||inp_width[OxO2567[16]]==OxO2567[15]){inp_width[OxO2567[16]]=Ox415[OxO2567[119]];inp_height[OxO2567[16]]=Ox415[OxO2567[120]];} ;img_demo[OxO2567[117]]=Ox228;if(Browser_IsWinIE()){Event_Attach(img_demo,OxO2567[136],OnImageMouseWheel);} ;img_demo[OxO2567[127]]=AlternateText[OxO2567[16]];img_demo[OxO2567[126]]=Align[OxO2567[16]];img_demo[OxO2567[119]]=inp_width[OxO2567[16]];img_demo[OxO2567[120]]=inp_height[OxO2567[16]];img_demo[OxO2567[121]]=VSpace[OxO2567[16]];img_demo[OxO2567[122]]=HSpace[OxO2567[16]];if(parseInt(Border.value)>0){img_demo[OxO2567[123]]=Border[OxO2567[16]];} ;if(bordercolor[OxO2567[16]]!=OxO2567[15]){img_demo[OxO2567[3]][OxO2567[124]]=bordercolor[OxO2567[16]];} ;Ox228=Ox228.toLowerCase();if(Ox228.indexOf(OxO2567[137])!=-1){img_AutoThumbnail[OxO2567[3]][OxO2567[138]]=OxO2567[139];if(img_ImageEditor){img_ImageEditor[OxO2567[3]][OxO2567[138]]=OxO2567[139];} ;} ;} ;} ;Ox416=window.setInterval(Ox417,100);} ;} ;function do_insert(){var img=element;img[OxO2567[117]]=TargetUrl[OxO2567[16]];if(editor.GetActiveTab()==OxO2567[140]){img.setAttribute(OxO2567[118],TargetUrl.value);} ;img[OxO2567[119]]=inp_width[OxO2567[16]];img[OxO2567[120]]=inp_height[OxO2567[16]];if(img[OxO2567[3]][OxO2567[119]]||img[OxO2567[3]][OxO2567[120]]){img[OxO2567[3]][OxO2567[119]]=inp_width[OxO2567[16]];img[OxO2567[3]][OxO2567[120]]=inp_height[OxO2567[16]];} ;img[OxO2567[121]]=VSpace[OxO2567[16]];img[OxO2567[122]]=HSpace[OxO2567[16]];img[OxO2567[123]]=Border[OxO2567[16]];var Ox36d=/[^a-z\d]/i;if(Ox36d.test(inp_id.value)){alert(OxO2567[141]);return ;} ;img[OxO2567[53]]=inp_id[OxO2567[16]];try{img[OxO2567[3]][OxO2567[124]]=bordercolor[OxO2567[16]];} catch(er){alert(OxO2567[142]);return false;} ;img[OxO2567[126]]=Align[OxO2567[16]];img[OxO2567[127]]=AlternateText[OxO2567[16]]||OxO2567[15];img[OxO2567[107]]=longDesc[OxO2567[16]];if(TargetUrl[OxO2567[16]]==OxO2567[15]){alert(OxO2567[143]);return false;} ;if(img[OxO2567[119]]==0){img.removeAttribute(OxO2567[119]);} ;if(img[OxO2567[120]]==0){img.removeAttribute(OxO2567[120]);} ;if(img[OxO2567[144]]==OxO2567[15]||img[OxO2567[144]]==null){img.removeAttribute(OxO2567[144]);} ;if(img[OxO2567[107]]==OxO2567[15]||img[OxO2567[107]]==null){img.removeAttribute(OxO2567[107]);} ;if(img[OxO2567[122]]==OxO2567[15]){img.removeAttribute(OxO2567[122]);} ;if(img[OxO2567[121]]==OxO2567[15]){img.removeAttribute(OxO2567[121]);} ;if(img[OxO2567[53]]==OxO2567[15]){img.removeAttribute(OxO2567[53]);} ;if(img[OxO2567[123]]==OxO2567[15]){img.removeAttribute(OxO2567[123]);} ;if(img[OxO2567[126]]==OxO2567[15]){img.removeAttribute(OxO2567[126]);} ;if(!img[OxO2567[23]]){editor.InsertElement(img);} ;Window_CloseDialog(window);} ;function attr(name,Ox4e){if(!Ox4e||Ox4e==OxO2567[15]){return OxO2567[15];} ;return OxO2567[51]+name+OxO2567[145]+Ox4e+OxO2567[146];} ;function do_Close(){Window_CloseDialog(window);} ;function Zoom_In(){if(Browser_IsWinIE()){if(divpreview[OxO2567[3]][OxO2567[2]]!=0){divpreview[OxO2567[3]][OxO2567[2]]*=1.2;} else {divpreview[OxO2567[3]][OxO2567[2]]=1.2;} ;} ;} ;function Zoom_Out(){if(Browser_IsWinIE()){if(divpreview[OxO2567[3]][OxO2567[2]]!=0){divpreview[OxO2567[3]][OxO2567[2]]*=0.8;} else {divpreview[OxO2567[3]][OxO2567[2]]=0.8;} ;} ;} ;function BestFit(){var img=img_demo;if(!img){return ;} ;var Ox6c=280;var Ox6d=290;if(Browser_IsWinIE()){divpreview[OxO2567[3]][OxO2567[2]]=1/Math.max(img[OxO2567[119]]/Ox6d,img[OxO2567[120]]/Ox6c);} ;} ;function Actualsize(){inp_width[OxO2567[16]]=OxO2567[15];inp_height[OxO2567[16]]=OxO2567[15];do_preview();if(Browser_IsWinIE()){divpreview[OxO2567[3]][OxO2567[2]]=1;} ;} ;function toggleConstrains(){if(constrain_prop[OxO2567[147]]){imgLock[OxO2567[117]]=OxO2567[148];checkConstrains(OxO2567[119]);} else {imgLock[OxO2567[117]]=OxO2567[149];} ;} ;var checkingConstrains=false;function checkConstrains(Ox73){if(checkingConstrains){return ;} ;checkingConstrains=true;try{if(constrain_prop[OxO2567[147]]){var Ox76=document.createElement(OxO2567[129]);Ox76[OxO2567[117]]=TargetUrl[OxO2567[16]];var Ox418=Ox76[OxO2567[119]];var Ox419=Ox76[OxO2567[120]];if((Ox418>0)&&(Ox419>0)){var Ox6d=inp_width[OxO2567[16]];var Ox6c=inp_height[OxO2567[16]];if(Ox73==OxO2567[119]){if(Ox6d[OxO2567[36]]==0||isNaN(Ox6d)){inp_width[OxO2567[16]]=OxO2567[15];inp_height[OxO2567[16]]=OxO2567[15];} else {Ox6c=parseInt(Ox6d*Ox419/Ox418);inp_height[OxO2567[16]]=Ox6c;} ;} ;if(Ox73==OxO2567[120]){if(Ox6c[OxO2567[36]]==0||isNaN(Ox6c)){inp_width[OxO2567[16]]=OxO2567[15];inp_height[OxO2567[16]]=OxO2567[15];} else {Ox6d=parseInt(Ox6c*Ox418/Ox419);inp_width[OxO2567[16]]=Ox6d;} ;} ;} ;} ;do_preview();} finally{checkingConstrains=false;} ;} ;function AutoThumbnail(){if(TargetUrl[OxO2567[16]]==OxO2567[15]){alert(OxO2567[150]);return false;} ;var obj= new Object();obj[OxO2567[117]]=TargetUrl[OxO2567[16]];obj[OxO2567[151]]=FolderDescription[OxO2567[56]]+OxO2567[15];function Ox354(Ox203){if(Ox203){TargetUrl[OxO2567[16]]=Ox203;hiddenAction[OxO2567[16]]=OxO2567[152];window.PostBackAction();} ;} ;editor.SetNextDialogWindow(window);editor.ShowDialog(Ox354,OxO2567[153]+GetDialogQueryString(),obj,OxO2567[154]);} ;function GetDialogQueryString(){var Ox119=OxO2567[15];if(editor.GetScriptProperty(OxO2567[155])==OxO2567[156]){Ox119=OxO2567[157];} ;return OxO2567[158]+editor.GetScriptProperty(OxO2567[159])+OxO2567[160]+editor.GetScriptProperty(OxO2567[161])+Ox119+OxO2567[162]+editor.GetScriptProperty(OxO2567[163]);} ;function ImageEditor(){var src=TargetUrl[OxO2567[16]];if(src==OxO2567[15]){alert(OxO2567[164]);return false;} ;if(src.charAt(0)!=OxO2567[19]){return ;} ;var img=document.createElement(OxO2567[129]);img[OxO2567[117]]=src;var p=OxO2567[165];function Ox354(arr){TargetUrl[OxO2567[16]]=src;do_preview();} ;editor.SetNextDialogWindow(window);editor.ShowDialog(Ox354,OxO2567[166]+src+OxO2567[167]+p,img,OxO2567[168]);} ;bordercolor[OxO2567[169]]=bordercolor_Preview[OxO2567[169]]=function bordercolor_onclick(){SelectColor(bordercolor,bordercolor_Preview);} ;if(!Browser_IsWinIE()){img_ImageEditor[OxO2567[3]][OxO2567[138]]=btn_zoom_in[OxO2567[3]][OxO2567[138]]=btn_zoom_out[OxO2567[3]][OxO2567[138]]=btn_bestfit[OxO2567[3]][OxO2567[138]]=btn_Actualsize[OxO2567[3]][OxO2567[138]]=OxO2567[139];} ;if(Browser_IsIE7()){var _dialogPromptID=null;function IEprompt(Ox218,Ox219,Ox21a){that=this;this[OxO2567[170]]=function (Ox21b){val=document.getElementById(OxO2567[171])[OxO2567[16]];_dialogPromptID[OxO2567[3]][OxO2567[138]]=OxO2567[139];document.getElementById(OxO2567[171])[OxO2567[16]]=OxO2567[15];if(Ox21b){val=OxO2567[15];} ;Ox218(val);return false;} ;if(Ox21a==undefined){Ox21a=OxO2567[15];} ;if(_dialogPromptID==null){var Ox21c=document.getElementsByTagName(OxO2567[172])[0];tnode=document.createElement(OxO2567[173]);tnode[OxO2567[53]]=OxO2567[174];Ox21c.appendChild(tnode);_dialogPromptID=document.getElementById(OxO2567[174]);tnode=document.createElement(OxO2567[173]);tnode[OxO2567[53]]=OxO2567[175];Ox21c.appendChild(tnode);_dialogPromptID[OxO2567[3]][OxO2567[123]]=OxO2567[176];_dialogPromptID[OxO2567[3]][OxO2567[125]]=OxO2567[177];_dialogPromptID[OxO2567[3]][OxO2567[178]]=OxO2567[179];_dialogPromptID[OxO2567[3]][OxO2567[119]]=OxO2567[180];_dialogPromptID[OxO2567[3]][OxO2567[181]]=OxO2567[182];} ;var Ox21d=OxO2567[183];Ox21d+=OxO2567[184]+Ox219+OxO2567[185];Ox21d+=OxO2567[186];Ox21d+=OxO2567[187]+Ox21a+OxO2567[188];Ox21d+=OxO2567[189];Ox21d+=OxO2567[190];Ox21d+=OxO2567[191];Ox21d+=OxO2567[192];Ox21d+=OxO2567[193];_dialogPromptID[OxO2567[56]]=Ox21d;_dialogPromptID[OxO2567[3]][OxO2567[5]]=OxO2567[194];_dialogPromptID[OxO2567[3]][OxO2567[195]]=parseInt((document[OxO2567[172]][OxO2567[196]]-315)/2)+OxO2567[197];_dialogPromptID[OxO2567[3]][OxO2567[138]]=OxO2567[198];var Ox21e=document.getElementById(OxO2567[171]);try{var Ox21f=Ox21e.createTextRange();Ox21f.collapse(false);Ox21f.select();} catch(x){Ox21e.focus();} ;} ;} ;if(CreateDir){CreateDir[OxO2567[37]]= new Function(OxO2567[199]);} ;if(Copy){Copy[OxO2567[37]]= new Function(OxO2567[199]);} ;if(Move){Move[OxO2567[37]]= new Function(OxO2567[199]);} ;if(Delete){Delete[OxO2567[37]]= new Function(OxO2567[199]);} ;if(DoRefresh){DoRefresh[OxO2567[37]]= new Function(OxO2567[199]);} ;if(btn_zoom_in){btn_zoom_in[OxO2567[37]]= new Function(OxO2567[199]);} ;if(btn_zoom_out){btn_zoom_out[OxO2567[37]]= new Function(OxO2567[199]);} ;if(btn_Actualsize){btn_Actualsize[OxO2567[37]]= new Function(OxO2567[199]);} ;if(img_ImageEditor){img_ImageEditor[OxO2567[37]]= new Function(OxO2567[199]);} ;if(btn_bestfit){btn_bestfit[OxO2567[37]]= new Function(OxO2567[199]);} ;if(img_AutoThumbnail){img_AutoThumbnail[OxO2567[37]]= new Function(OxO2567[199]);} ;