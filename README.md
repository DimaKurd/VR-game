# VR-game
lab4 for neurointerfaces

Directory <strong>BluetoothLE(Src)</strong> contains full C# colution for UWP application which could read data from Bluetooth servers

Directory <strong>BluetoothUWPPackage</strong> contains builded installation package  

Directory <strong>Script</strong> contains python file for calculating index of pulse variance. It works by reading data from server running at <code>localhost</code>

Directory <strong>UnityGame</strong> contains builded version of VR-game

Directory <strong>serverLoopback(src)</strong> contains Django Project for storing pulse data at server running at <code>localhost:8000</code>

<b>GET</b> request <code>localhost:8000/hr/update?bpm=78</code> will replace last stored data and <b>GET</b> request <code>localhost:8000/hr/get</code> will return current stored pulse value

File <strong>package.unitypackge</strong> is a full project created in Unity
