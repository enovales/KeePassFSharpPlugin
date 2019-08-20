# KeePassFSharpPlugin

This is an example project for building a [KeePass](https://keepass.info) 2.x plugin with F#. The repository  
contains a plugin project (KeePassFSharpPlugin), plus a separate test project (KeePassFSharpPluginTests), 
which is driven by the [Expecto testing framework](https://github.com/haf/expecto). The dependencies are 
managed with [Paket](https://fsprojects.github.io/Paket/). The idea here is that you could test all of the 
non-UI code of the plugin, using nice F#-native tooling, and then that code would interface with a thin 
layer over the KeePass plugin API.

To use the plugin, copy the output of the Release build into a directory inside your KeePass plugins
directory, and restart KeePass. You should be able to see `Test F# Plugin Options` under the **Tools**
menu, and if you select that menu option, it should show a message box.

To run the tests, simply run the console application that contains the tests.
