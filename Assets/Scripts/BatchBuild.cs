using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

public class BatchBuild : MonoBehaviour {
	[UnityEditor.MenuItem ( "Tools / Build Project AllScene Android" )]
	public  static  void BuildProjectAllSceneAndroid () {
		EditorUserBuildSettings.SwitchActiveBuildTarget (BuildTarget.Android);
		String [] allScene = new  string [EditorBuildSettings.scenes.Length];
		int i = 0 ;
		foreach (EditorBuildSettingsScene scene in EditorBuildSettings.scenes) {
			allScene [i] = scene.path;
			i++;
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
		EditorUserBuildSettings.SwitchActiveBuildTarget (BuildTarget.iOS);
		String [] allScene = new  string [EditorBuildSettings.scenes.Length];
		int i = 0 ;
		foreach (EditorBuildSettingsScene scene in EditorBuildSettings.scenes) {
			allScene [i] = scene.path;
			i++;
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
			allScene,
			"Hoge 4 i OSDevice" ,
			BuildTarget.iOS,
			opt
		);

		if ( string .IsNullOrEmpty (errorMsg_Device)) {

		} else {
			// error handling appropriately		
		}


		// BUILD for Simulator
		PlayerSettings.iOS.sdkVersion = iOSSdkVersion.SimulatorSDK;
			// Then as with the Device build.
	}
}
