var n = Math.round(Math.random() * 10);
var cx = slideimages.length;
function chki(no){
	var pImg = document.getElementById("slide");
	//var pUrl = document.getElementById("RollUrl");
	var pTitle = document.getElementById("textslide");
	//var ci = document.getElementById("sbtn").getElementsByTagName("img");
	var cb = document.getElementById("sbtn").getElementsByTagName("li");
	//鼠标指向换图
	for(i=0;i<cx;i++){
		if(no!=i){
			cb[i].style.backgroundColor='#999999';
			}
			else
			{
				cb[i].style.backgroundColor='yellow';
				}
		   }
	n=no;
	//alert(slideimages[no]);
	pImg.src = slideimages[no];
	pTitle.innerHTML = slidetext[no];  
}

function switjs(){
	n = (n >= cx-1) ? 0 : n+1;
	setimgurl();
	var setTimeId=setTimeout("switjs()",interval);
}

function setimgurl(numt){
	var xx = document.getElementById("sbtn").getElementsByTagName("img");
	//var ci = xx[n];
	var cb= document.getElementById("sbtn").getElementsByTagName("li");
	//var cb=cbold[n]
	if(document.all){
		document.getElementById("slide").filters.blendTrans.apply();
	}
	else
	{
		filterit("slide",0.6);
	}
	document.getElementById("slide").src=slideimages[n];
	document.getElementById("textslide").innerHTML=slidetext[n];
	if(document.all){
		document.getElementById("slide").filters.blendTrans.play();
	}
	else
	{
		setTimeout("filterit('slide',1)",557);
		//document.getElementById("slide").style.opacity=1;
		}
	//自动换图
	   if(n>0)
	   	cb[n-1].style.backgroundColor='#999999';
		else
		cb[cx-1].style.backgroundColor='#999999';
	   cb[n].style.backgroundColor='red';
	}

function filterit(obj,stime){
	document.getElementById(obj).style.opacity=stime;
}