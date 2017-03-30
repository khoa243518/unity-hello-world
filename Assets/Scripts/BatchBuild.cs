[UnityEditor.MenuItem ( "Tools / Build Project AllScene Android" )]
 public  static  void BuildProjectAllSceneAndroid () {
    EditorUserBuildSettings.SwitchActiveBuildTarget (BuildTarget.Android);
    String [] allScene = new  string [EditorBuildSettings.scenes.Length];
     int i = 0 ;
     foreach (EditorBuildSettingsScene scene in EditorBuildSettings.scenes) {
        AllScene [i] = scene.path;
        I ++;
    }	
    PlayerSettings.bundleIdentifier = "jp.co.hoge.hoge" ;
    PlayerSettings.statusBarHidden = true ;
    BuildPipeline.BuildPlayer (allScene,
                              "Hoge.apk" ,
                              BuildTarget.Android,
                              BuildOptions.None
                             );
}
[UnityEditor.MenuItem ( "Tools / Build Project AllScene iOS" )]
 public  static  void BuildProjectAllSceneiOS () {	
    EditorUserBuildSettings.SwitchActiveBuildTarget (BuildTarget.iPhone);
    String [] allScene = new  string [EditorBuildSettings.scenes.Length];
     int i = 0 ;
     foreach (EditorBuildSettingsScene scene in EditorBuildSettings.scenes) {
        AllScene [i] = scene.path;
	I ++;
    }
	    
    BuildOptions opt = BuildOptions.SymlinkLibraries |
			BuildOptions.AllowDebugging |
			BuildOptions.ConnectWithProfiler |
			BuildOptions.Development;
		
    // BUILD for Device
    PlayerSettings.iOS.sdkVersion = iOSSdkVersion.DeviceSDK;
    PlayerSettings.bundleIdentifier = "jp.co.hoge.hoge" ;
    PlayerSettings.statusBarHidden = true ;
     string errorMsg_Device = BuildPipeline.BuildPlayer (
                                       AllScene,
	                               "Hoge 4 i OSDevice" ,
	                               BuildTarget.iPhone,
	                               Opt
	                               );
		
    If ( string .IsNullOrEmpty (errorMsg_Device)) {
	
    } Else {
	 // error handling appropriately		
    }
	
	
　　// BUILD for Simulator
　　PlayerSettings.iOS.sdkVersion = iOSSdkVersion.SimulatorSDK:
　　// Then as with the Device build.
