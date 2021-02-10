# Boxed-AR  :tada: 
---
##### An android application using Xamarin .NET, Google AR Core and Open-GL to estimate sizes of carton boxes using A/R.
<img alt="demo gif" src="https://github.com/vijayanandpg6/Boxed-AR/blob/main/files/walk-through1.gif" width="600" height="300" />

---
What does it do? :sparkles:
* An android application to estimate the size of carton box needed to package an item, in real time.
* User will be provided with an AR view with live camera to navigate over the objects they wish to relocate.
* The app requires the user to tap on the screen for base point and then 3 taps to set the length, breadth and height of the item.
* The item and the plane on which the item is placed is captured using the device camera Surface view.
* The plane and the visual markers for length, breadth & height is detected and marked as anchors using ARCore
* Visual marker cubes and virtual Carton box is rendered on screen as real time 3D object  using OpenGL.
* Dimensions are calculated based on the anchors & reference, then displayed to the user as length, breadth, height, surface area and volume.
---
<img alt="demo gif" src="https://github.com/vijayanandpg6/Boxed-AR/blob/main/files/walk-through2.gif" width="600" height="300" />

Android A/R application using below :sparkles:
* C# .NET Xamarin 4.12
* Xamarin.Android SDK 9.1
* Google.ARCore 1.12
* JavaGl DLL
* Android.OpenGL ES2 (from JavaGl)
* Cake .NET Core package to install, generate and reference JAR file 
* Tools – Visual Studio 2017, Xamarin Android Emulator
* Target framework Android 8.1 Oreo – API 27
* Minimum Android 7.0 Nougat – API 24
---
Download & install the APK file <a id="raw-url" href="https://github.com/vijayanandpg6/Boxed-AR/blob/main/files/Squad.BoxedAR.apk">Here</a>

<img alt="demo gif" src="https://github.com/vijayanandpg6/Boxed-AR/blob/main/files/walk-through3.gif" width="600" height="300" />

---
