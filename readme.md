# Pre-Requisites 
* Java SDK
* Jenkins install package (for windows)
* Unity3D
* Git 1.7.10 or later
* Nothing else running on port 8080 (Jenkins uses it by default)
* A NHN github account with a github project
# Install Plugins
Before we can start with building and testing we need some plugins.
* Click “Manage Jenkins”
* Click “Manage Plugins”
* Under the tab “Available” you can search for plugins

<h2>Install the following plugins</h2>

* Git plugin
* Keychains and Provisioning Profiles Management
* Test Results Analyzer Plugin
* Xcode integration
* Credentials Plugin

You may need to restart your jenkins.

# Create the Jenkins job
* 1. Click “New Item”
* 2. Insert your Item Name
* 3. Choose Freestyle Project
* 4. Click “Ok”

You will be redirected to the configuration page of your Jenkins job. Here we will configure everything we need to build our project and test it.

# Jenkins Job Configuration
First we will configure our connection to git.
........
........
....
.
# Configure unity3D project
You have to make sure your that project can be built by Command line, to do that you have to create a build script and put it in Editor folder of you project
```c#
#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

public class BatchBuild : MonoBehaviour {
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
		PlayerSettings.bundleIdentifier = "com.nhnent.boardgame" ;
		PlayerSettings.statusBarHidden = true ;
		string errorMsg_Device = BuildPipeline.BuildPlayer (
			allScene,
			"Board Game" ,
			BuildTarget.iOS,
			opt
		);

		if ( string .IsNullOrEmpty (errorMsg_Device)) {

		} else {

		}
		PlayerSettings.iOS.sdkVersion = iOSSdkVersion.SimulatorSDK;
	}
}
#endif
```

# Configure Build setting
Now we add build step "Xcode" & "Invoke Unity3d Editor"
In the Unity3d Editor puglin we now configure:
* image

Next we config Xcode

* image

