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
