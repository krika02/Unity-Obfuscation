# Unity-Obfuscation

This is a example project in Unity3D to show how you should code if you want to obfuscate your c# code.

*************************************************************************************************************
Read more about this project here https://medium.com/@utterbbq/in-this-article-im-writing-about-how-you-can-obfuscate-your-c-code-in-unity3d-e829e7b881c
*************************************************************************************************************

Open the project in Unity and export it to any platform. Extract the .dll files (if needed) and obfuscate the Assembly-CSharp.dll (prefer to use https://sharpobfuscator.codeplex.com).

You should be able to obfuscate class names, method names, fields and properties. 
But there are some limitations :
* You can not obfuscate the class name of Scene1Controller and Scene2Controller since they are and must be atached to gameObjects in Unity.
* You can not obfuscate the methods Update, OnEnable and OnDisable in the BahaviorEventBinder since they are weak typed.

After obfuscation simply swap the obfuscated .dll with the old one and run the application.

My game ZMBIS https://play.google.com/store/apps/details?id=com.PixelDonut.Zmbis was developed by using this method and is fully obfuscated.
Feel free to download the game and decompile it and you will see.
