var OxOe498=["inp_src","inp_title","inp_target","sel_protocol","btnbrowse","editor","","href","value","title","target","onclick","length","options","://",":","others","selectedIndex"];var inp_src=Window_GetElement(window,OxOe498[0],true);var inp_title=Window_GetElement(window,OxOe498[1],true);var inp_target=Window_GetElement(window,OxOe498[2],true);var sel_protocol=Window_GetElement(window,OxOe498[3],true);var btnbrowse=Window_GetElement(window,OxOe498[4],true);var obj=Window_GetDialogArguments(window);var editor=obj[OxOe498[5]];SyncToView();function SyncToView(){var src=obj[OxOe498[7]].replace(/$\s*/,OxOe498[6]);Update_sel_protocol(src);inp_src[OxOe498[8]]=src;if(obj[OxOe498[9]]){inp_title[OxOe498[8]]=obj[OxOe498[9]];} ;if(obj[OxOe498[10]]){inp_target[OxOe498[8]]=obj[OxOe498[10]];} ;} ;btnbrowse[OxOe498[11]]=function btnbrowse_onclick(){function Ox354(Ox137){if(Ox137){inp_src[OxOe498[8]]=Ox137;} ;} ;editor.SetNextDialogWindow(window);if(Browser_IsSafari()){editor.ShowSelectFileDialog(Ox354,inp_src.value,inp_src);} else {editor.ShowSelectFileDialog(Ox354,inp_src.value);} ;} ;function sel_protocol_change(){var src=inp_src[OxOe498[8]].replace(/$\s*/,OxOe498[6]);for(var i=0;i<sel_protocol[OxOe498[13]][OxOe498[12]];i++){var Ox13b=sel_protocol[OxOe498[13]][i][OxOe498[8]];if(src.substr(0,Ox13b.length).toLowerCase()==Ox13b){src=src.substr(Ox13b.length,src[OxOe498[12]]-Ox13b[OxOe498[12]]);break ;} ;} ;var Ox437=src.indexOf(OxOe498[14]);if(Ox437!=-1){src=src.substr(Ox437+3,src[OxOe498[12]]-3-Ox437);} ;var Ox437=src.indexOf(OxOe498[15]);if(Ox437!=-1){src=src.substr(Ox437+1,src[OxOe498[12]]-1-Ox437);} ;var Ox438=sel_protocol[OxOe498[8]];if(Ox438==OxOe498[16]){Ox438=OxOe498[6];} ;inp_src[OxOe498[8]]=Ox438+src;} ;function Update_sel_protocol(src){var Ox43a=false;for(var i=0;i<sel_protocol[OxOe498[13]][OxOe498[12]];i++){var Ox13b=sel_protocol[OxOe498[13]][i][OxOe498[8]];if(src.substr(0,Ox13b.length).toLowerCase()==Ox13b){if(sel_protocol[OxOe498[17]]!=i){sel_protocol[OxOe498[17]]=i;} ;Ox43a=true;break ;} ;} ;if(!Ox43a){sel_protocol[OxOe498[17]]=sel_protocol[OxOe498[13]][OxOe498[12]]-1;} ;} ;function insert_link(){var arr= new Array();arr[0]=inp_src[OxOe498[8]];if(inp_target[OxOe498[8]]){arr[1]=inp_target[OxOe498[8]];} ;if(inp_title[OxOe498[8]]){arr[2]=inp_title[OxOe498[8]];} ;Window_SetDialogReturnValue(window,arr);Window_CloseDialog(window);} ;