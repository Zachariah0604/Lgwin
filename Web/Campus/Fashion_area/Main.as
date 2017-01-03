package {
	//***********************************
	import flash.xml.*;
	import flash.net.URLLoader;
	//***********************************
	import flash.display.StageScaleMode;
	import flash.events.Event;
	import flash.display.Sprite;
	import flash.net.URLRequest;
	import flash.media.Sound;
	import flash.media.SoundLoaderContext;
	import flash.media.SoundChannel;
	import flash.media.SoundMixer;
	import flash.text.TextField;
	import flash.events.MouseEvent;
	import flash.text.TextFormat;
	import flash.display.Bitmap;
	import flash.display.BitmapData;
	import flash.utils.ByteArray;
	import flash.media.SoundMixer;
	import flash.geom.Rectangle;
	import flash.net.URLRequest;
	import flash.display.Loader;
	import flash.media.SoundTransform;
	//*****************************copyright
	import flash.ui.ContextMenu;
	import flash.ui.ContextMenuItem;
	import flash.events.ContextMenuEvent;
	import flash.net.navigateToURL;
	//******************************************
	public class Main extends Sprite {
		//***********************************
		private var loader:URLLoader;
		//***********************************
		private var _sound:Sound;
		private var url:URLRequest;
		private var _context:SoundLoaderContext;
		private var _channel:SoundChannel;
		private var _progress:uint;//加载进度
		private var _playprogress:uint;//播放进度
		public var _progressbar:Progressbar;//进度条
		private var _background:BackGround;//背景
		private var _progressbutton:ProgressButton;//进度滑块
		private var _progressbackground:ProgressBackground;//进度条背景
		private var _playpausebutton:PlayPauseButton;//播放暂停按钮
		private var _stopbutton:StopButton;//停止按钮
		private var _playprogressbar:PlayProgressBar;//播放进度条
		private var _soundbutton:SoundButton;//音量控制按钮
		private var _songname:TextField;//歌曲名字显示
		private var _playpause:Boolean=false;//播放暂停状态判定
		private var _position:Number;//记录音乐播放到的位置
		private var _textformat:TextFormat;//文本格式
		private var _timetext:TextField=new TextField();//时间显示文本
		private var _rectangle1:Rectangle;//进度滑块拖动范围
		private var _rectangle2:Rectangle;//声音滑块拖动范围
		private var _bitmapdata:BitmapData;
		private var _drag:Boolean=false;//进度滑块是否允许拖动
		private var _transform:SoundTransform=new SoundTransform();
		private var _volume:Number=1;
		public var progressbarwidth:Number;
		public var totaltime:Number;
		//******************************************copyright
		private var contextmenu:ContextMenu;
		private var contextmenuitem1:ContextMenuItem;
		private var array:Array;
		//***************************************************
		public function Main() {
			//***********************************
			loader=new URLLoader();
			loader.load(new URLRequest("songlist.xml"));
			loader.addEventListener(Event.COMPLETE,oncomplete);
			//***********************************
			//系统右键菜单
			contextmenu=new ContextMenu  ;
			contextmenuitem1=new ContextMenuItem("了解 卡瑞特工作室");
			array=[contextmenuitem1];
			contextmenu.hideBuiltInItems();
			contextmenu.customItems=array;
			this.contextMenu=contextmenu;
			contextmenuitem1.addEventListener(ContextMenuEvent.MENU_ITEM_SELECT,karat);
			//设置播放器的缩放类型为无缩放
			stage.scaleMode = StageScaleMode.NO_SCALE;
		}
		private function karat(e:ContextMenuEvent) {
			navigateToURL(new URLRequest("http://lgwindow.sdut.edu.cn/karat"));

		}
		private function oncomplete(evt:Event) {
			var xml:XML=new XML(loader.data);
			var str:String=xml.song.@url[0];
			url=new URLRequest(str);
			_context=new SoundLoaderContext(5000);
			_sound=new Sound(url,_context);
			_sound.addEventListener(Event.ID3, Id3Handler);//对ID3信息进行监听，处理乱码
			_channel=_sound.play();
			_progressbar=new Progressbar();
			_progressbutton=new ProgressButton();
			_playpausebutton=new PlayPauseButton();
			_background=new BackGround();
			_stopbutton=new StopButton();
			_progressbackground=new ProgressBackground();
			_playprogressbar=new PlayProgressBar();
			_songname=new TextField();
			_soundbutton=new SoundButton();
			_timetext.text="0:00 / 0:00";
			_textformat=new TextFormat();
			_bitmapdata=new BitmapData(612,60,true,0x00000000);
			var _bitmap:Bitmap=new Bitmap(_bitmapdata);
			_bitmap.x=0;
			_bitmap.y=0;
			addChild(_background);
			addChild(_progressbackground);
			addChild(_songname);
			addChild(_progressbar);
			addChild(_playpausebutton);
			_playpausebutton.buttonMode=true;
			addChild(_stopbutton);
			_stopbutton.buttonMode=true;
			addChild(_bitmap);
			addChild(_playprogressbar);
			addChild(_progressbutton);
			addChild(_timetext);
			addChild(_soundbutton);
			//*****************进度条的初始化位置
			_progressbar.x=72;
			_progressbar.y=93;
			//*****************进度条背景的初始化位置
			_progressbackground.x=72;
			_progressbackground.y=93;
			//*****************进度滑块的初始化位置
			_progressbutton.x=72;
			_progressbutton.y=91.5;
			//*****************播放暂停按钮的初始化位置
			_playpausebutton.x=5;
			_playpausebutton.y=84;
			//*****************停止按钮的初始化位置
			_stopbutton.x=35;
			_stopbutton.y=84;
			//*****************背景的初始化位置
			_background.x=0;
			_background.y=60;
			//*****************播放进度条的初始化位置
			_playprogressbar.x=72;
			_playprogressbar.y=93;
			//*****************音量控制按钮的初始化位置
			_soundbutton.x=468;
			_soundbutton.y=94;
			_soundbutton.soundbackground.visible=false;
			_soundbutton.soundrect.buttonMode=true;
			//*****************歌曲文本的初始化位置及格式
			_songname.x=5;
			_songname.y=60;
			_songname.width=500;
			_textformat.color=0xffffff;
			_textformat.size=11.5;
			_songname.selectable=false;
			//***********************************************
			//*****************时间文本的初始化位置
			_timetext.x=408;
			_timetext.y=88;
			_timetext.selectable=false;
			_timetext.setTextFormat(_textformat);
			addEventListener(Event.ENTER_FRAME,onenterframe);
			_soundbutton.addEventListener(MouseEvent.ROLL_OVER,mouseover);
			_soundbutton.addEventListener(MouseEvent.ROLL_OUT,mouseout);
			_progressbar.buttonMode=true;
			_progressbar.addEventListener(MouseEvent.CLICK,onclick);
			_playprogressbar.buttonMode=true;
			_playprogressbar.addEventListener(MouseEvent.CLICK,onclick1);
		}
		private function onenterframe(evt:Event) {
			_channel.addEventListener(Event.SOUND_COMPLETE,soundcomplete);//对声音播放完成进行监听
			_soundbutton.soundrect.addEventListener(MouseEvent.MOUSE_DOWN,onmousedown);
			_transform.volume=_volume;
			_channel.soundTransform=_transform;
			//**************************************************播放进度条的宽度*****************************************************************
			progressbarwidth=_playprogressbar.width;
			//*****************************************进度条、播放滑块位置、播放进度条的位置****************************************************
			_progress=Math.round((_sound.bytesLoaded/_sound.bytesTotal)*100);
			_playprogress=Math.round((_channel.position/_sound.length/(_sound.bytesLoaded/_sound.bytesTotal))*100);
			_progressbar.width=_progress*3.3;
			_progressbutton.x=72+_playprogress*3.1;
			_playprogressbar.width=_progressbutton.x-72;
			//*****************************************************************************************************************
			_rectangle1=new Rectangle(_progressbackground.x,_progressbackground.y,_progressbar.width-20,0);
			//****************************************音频频谱*****************************************************************
			var _array:ByteArray=new ByteArray();
			SoundMixer.computeSpectrum(_array);
			_bitmapdata.fillRect(_bitmapdata.rect,0x00000000);
			for (var i:int=0; i<256; i++) {
				_bitmapdata.setPixel32(i,20+_array.readFloat()*30,0xffff6600);
			}
			for (var j:int=0; j<256; j++) {
				_bitmapdata.setPixel32(j,40+_array.readFloat()*30,0xffff6600);
			}
			//*****************************************************************************************************************
			//******************************************************时间文本***************************************************
			var second:String;
			var minute:String;
			var totalsecond:String;
			var totalminute:String;
			var currenttime:int;
			totaltime=(_sound.length/(_sound.bytesLoaded/_sound.bytesTotal))/1000;
			if (totaltime%60>=10) {
				totalsecond=String(int(totaltime%60));
				totalminute=String(int(totaltime/60));
			} else {
				totalsecond="0"+int(totaltime%60);
				totalminute=String(int(totaltime/60));
			}
			currenttime=_channel.position/1000;
			if (currenttime%60>=10) {
				second=String(int(currenttime%60));
				minute=String(int(currenttime/60));
			} else {
				second="0"+int(currenttime%60);
				minute=String(int(currenttime/60));
			}
			_timetext.text=minute+":"+second+" "+ "/"+" "+totalminute+":"+totalsecond;
			_timetext.setTextFormat(_textformat);
			//*****************************************************************************************************************
			_playpausebutton.addEventListener(MouseEvent.CLICK,click1);
			_playpausebutton.addEventListener(MouseEvent.MOUSE_OVER,over);
			_playpausebutton.addEventListener(MouseEvent.MOUSE_OUT,out);
			_stopbutton.addEventListener(MouseEvent.CLICK,click2);
			_stopbutton.addEventListener(MouseEvent.MOUSE_OVER,over1);
			_stopbutton.addEventListener(MouseEvent.MOUSE_OUT,out1);
		}
		//声音播放完成后执行的操作
		private function soundcomplete(evt:Event) {
			_playpause=true;
			_position=0;
			_channel.stop();
			_playpausebutton.gotoAndPlay(2);
			_progressbar.width=0;
		}
		private function over(evt:MouseEvent) {
			_playpausebutton.ying.alpha=0.8;
		}
		private function out(evt:MouseEvent) {
			_playpausebutton.ying.alpha=0;
		}
		private function over1(evt:MouseEvent) {
			_stopbutton.ying1.alpha=0.8;
		}
		private function out1(evt:MouseEvent) {
			_stopbutton.ying1.alpha=0;
		}
		private function click1(evt:MouseEvent) {
			_playpause=!_playpause;
			if (_playpause==true) {
				_position=_channel.position;
				_playpausebutton.gotoAndPlay(2);
				_channel.stop();
			} else {
				_playpausebutton.gotoAndPlay(1);
				_channel=_sound.play(_position);
			}
		}
		private function click2(evt:MouseEvent) {
			_playpause=true;
			_position=0;
			_channel.stop();
			_playpausebutton.gotoAndPlay(2);
			_progressbar.width=0;
		}
		private function mouseover(evt:MouseEvent) {
			_soundbutton.soundbackground.visible=true;
			_soundbutton.soundbar.visible=true;
			_soundbutton.soundrect.visible=true;
		}
		private function mouseout(evt:MouseEvent) {
			_soundbutton.soundbackground.visible=false;
			_soundbutton.soundbar.visible=false;
			_soundbutton.soundrect.visible=false;
		}
		private function mousedown(evt:MouseEvent) {
			evt.target.startDrag();
		}
		private function onclick(evt:MouseEvent) {
			progressbarwidth=mouseX-65;
			_position=(progressbarwidth/330)*totaltime*1000;
			_channel.stop();
			_channel=_sound.play(_position);
		}
		private function onclick1(evt:MouseEvent) {
			progressbarwidth=mouseX-70;
			_position=(progressbarwidth/330)*totaltime*1000;
			_channel.stop();
			_channel=_sound.play(_position);
		}
		private function onmousedown(evt:MouseEvent) {
			_soundbutton.soundrect.startDrag(false,new Rectangle(9.006,-53.3,0,35));
			stage.addEventListener(MouseEvent.MOUSE_UP,onmouseup);
		}
		private function onmouseup(evt:MouseEvent) {
			_soundbutton.soundrect.stopDrag();
			_soundbutton.soundbar.height=_soundbutton.soundrect.y*(-1)-15;
			_volume=2.17*_soundbutton.soundbar.height/100-0.0749;
		}
		//***************************************处理ID3乱码**********************************************
		private function Id3Handler(evt:Event) {
			_songname.text="乐曲名："+EncodeUtf8(_sound.id3.songName)+"          "+"艺术家："+EncodeUtf8(_sound.id3.artist)+"          "+"专辑："+EncodeUtf8(_sound.id3.album);
			_songname.setTextFormat(_textformat);
		}
		private function EncodeUtf8(str : String):String {
			var oriByteArr : ByteArray = new ByteArray();
			oriByteArr.writeUTFBytes(str);
			var tempByteArr : ByteArray = new ByteArray();
			for (var i = 0; i<oriByteArr.length; i++) {
				if (oriByteArr[i] == 194) {
					tempByteArr.writeByte(oriByteArr[i+1]);
					i++;
				} else if (oriByteArr[i] == 195) {
					tempByteArr.writeByte(oriByteArr[i+1] + 64);
					i++;
				} else {
					tempByteArr.writeByte(oriByteArr[i]);
				}
			}
			tempByteArr.position = 0;
			return tempByteArr.readMultiByte(tempByteArr.bytesAvailable,"chinese");
		}
	}
}