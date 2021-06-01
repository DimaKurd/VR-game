# VR-game
lab4 for neurointerfaces

Directory BluetoothLE(Src) contains full C# colution for UWP application which could read data from Bluetooth servers

Directory BluetoothUWPPackage contains builded installation package  

Directory Script contains python file for calculating index of pulse variance. It works by reading data from server running at localhost

Directory UnityGame contains builded version of VR-game

Directory serverLoopback(src) contains Django Project for storing pulse data at server running at localhost:8000

GET request "localhost:8000/hr/update?bpm=78 will replace last stored data and GET request "localhost:8000/hr/get" will return current stored pulse value

File package.unitypackge is a full project created in Unity
