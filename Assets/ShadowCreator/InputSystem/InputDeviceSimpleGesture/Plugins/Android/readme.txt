版本：v1.0.0
维护：陈伟桦

一、获取手势识别帮助类
包名：com.invision.gesture
SDKGestureManager getSDKGestureManager(Context context)

Unity范例：
AndroidJavaClass mUnityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
AndroidJavaObject mAndroidActivity = mUnityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
AndroidJavaObject mContext = mAndroidActivity.Call<AndroidJavaObject>("getApplicationContext");
AndroidJavaClass mClazz = new AndroidJavaClass("com.invision.gesture.SDKGestureManager");
AndroidJavaObject mSDKGestureManager = mClazz.CallStatic<AndroidJavaObject>("getSDKGestureManager", mContext);

二、设置设置手势回调
GestureEventCallback包名变更：com.invision.gesture.callback

setGestureEventCallback(GestureEventCallback gestureEventCallback)

三、判断语手势别是否在运行（对应原来的接口unityIsGestureRunning()）
isGestureRunning()

四、开启识别服务（对应原来的接口unityStartGestureService()）
startGestureService()

五、关闭识别服务（对应原来的接口unityStopGestureService()）
stopGestureService()

六、关闭手势识别帮助类时候调用，比如退出程序或者程序需要的地方
onDestroy()