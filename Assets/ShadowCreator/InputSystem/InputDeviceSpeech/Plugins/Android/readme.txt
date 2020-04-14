版本：v1.0.0
维护：陈伟桦

一、获取语音识别帮助类
包名：com.invision.speech
SDKSpeechManager getSDKSpeechManager(Context context)

Unity范例：
AndroidJavaClass mUnityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
AndroidJavaObject mAndroidActivity = mUnityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
AndroidJavaObject mContext = mAndroidActivity.Call<AndroidJavaObject>("getApplicationContext");
AndroidJavaClass mClazz = new AndroidJavaClass("com.invision.speech.SDKSpeechManager");
AndroidJavaObject mSDKSpeechManager = mClazz.CallStatic<AndroidJavaObject>("getSDKSpeechManager", mContext);

二、设置语音回调函数
SpeechEventCallback包名变更：com.invision.speech.callback

setSpeechEventCallback(SpeechEventCallback speechEventCallback)

三、判断语音识别是否在运行（对应原来的接口unityIsSpeechRunning()）
isSpeechRunning()

四、开启识别服务（对应原来的接口unityStartSpeechService()）
startSpeechService()

五、关闭识别服务（对应原来的接口unityStopSpeechService()）
stopSpeechService()

六、关闭语音识别帮助类时候调用，比如退出程序或者程序需要的地方
onDestroy()