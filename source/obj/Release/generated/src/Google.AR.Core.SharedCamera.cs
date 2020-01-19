using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='SharedCamera']"
	[global::Android.Runtime.Register ("com/google/ar/core/SharedCamera", DoNotGenerateAcw=true)]
	public partial class SharedCamera : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/SharedCamera", typeof (SharedCamera));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected SharedCamera (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getArCoreSurfaces;
#pragma warning disable 0169
		static Delegate GetGetArCoreSurfacesHandler ()
		{
			if (cb_getArCoreSurfaces == null)
				cb_getArCoreSurfaces = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetArCoreSurfaces);
			return cb_getArCoreSurfaces;
		}

		static IntPtr n_GetArCoreSurfaces (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.SharedCamera __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.SharedCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Views.Surface>.ToLocalJniHandle (__this.ArCoreSurfaces);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Android.Views.Surface> ArCoreSurfaces {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='SharedCamera']/method[@name='getArCoreSurfaces' and count(parameter)=0]"
			[Register ("getArCoreSurfaces", "()Ljava/util/List;", "GetGetArCoreSurfacesHandler")]
			get {
				const string __id = "getArCoreSurfaces.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Android.Views.Surface>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSurfaceTexture;
#pragma warning disable 0169
		static Delegate GetGetSurfaceTextureHandler ()
		{
			if (cb_getSurfaceTexture == null)
				cb_getSurfaceTexture = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSurfaceTexture);
			return cb_getSurfaceTexture;
		}

		static IntPtr n_GetSurfaceTexture (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.SharedCamera __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.SharedCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SurfaceTexture);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.SurfaceTexture SurfaceTexture {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='SharedCamera']/method[@name='getSurfaceTexture' and count(parameter)=0]"
			[Register ("getSurfaceTexture", "()Landroid/graphics/SurfaceTexture;", "GetGetSurfaceTextureHandler")]
			get {
				const string __id = "getSurfaceTexture.()Landroid/graphics/SurfaceTexture;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_createARDeviceStateCallback_Landroid_hardware_camera2_CameraDevice_StateCallback_Landroid_os_Handler_;
#pragma warning disable 0169
		static Delegate GetCreateARDeviceStateCallback_Landroid_hardware_camera2_CameraDevice_StateCallback_Landroid_os_Handler_Handler ()
		{
			if (cb_createARDeviceStateCallback_Landroid_hardware_camera2_CameraDevice_StateCallback_Landroid_os_Handler_ == null)
				cb_createARDeviceStateCallback_Landroid_hardware_camera2_CameraDevice_StateCallback_Landroid_os_Handler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateARDeviceStateCallback_Landroid_hardware_camera2_CameraDevice_StateCallback_Landroid_os_Handler_);
			return cb_createARDeviceStateCallback_Landroid_hardware_camera2_CameraDevice_StateCallback_Landroid_os_Handler_;
		}

		static IntPtr n_CreateARDeviceStateCallback_Landroid_hardware_camera2_CameraDevice_StateCallback_Landroid_os_Handler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Google.AR.Core.SharedCamera __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.SharedCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.Camera2.CameraDevice.StateCallback p0 = global::Java.Lang.Object.GetObject<global::Android.Hardware.Camera2.CameraDevice.StateCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateARDeviceStateCallback (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='SharedCamera']/method[@name='createARDeviceStateCallback' and count(parameter)=2 and parameter[1][@type='android.hardware.camera2.CameraDevice.StateCallback'] and parameter[2][@type='android.os.Handler']]"
		[Register ("createARDeviceStateCallback", "(Landroid/hardware/camera2/CameraDevice$StateCallback;Landroid/os/Handler;)Landroid/hardware/camera2/CameraDevice$StateCallback;", "GetCreateARDeviceStateCallback_Landroid_hardware_camera2_CameraDevice_StateCallback_Landroid_os_Handler_Handler")]
		public virtual unsafe global::Android.Hardware.Camera2.CameraDevice.StateCallback CreateARDeviceStateCallback (global::Android.Hardware.Camera2.CameraDevice.StateCallback p0, global::Android.OS.Handler p1)
		{
			const string __id = "createARDeviceStateCallback.(Landroid/hardware/camera2/CameraDevice$StateCallback;Landroid/os/Handler;)Landroid/hardware/camera2/CameraDevice$StateCallback;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Hardware.Camera2.CameraDevice.StateCallback> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_createARSessionStateCallback_Landroid_hardware_camera2_CameraCaptureSession_StateCallback_Landroid_os_Handler_;
#pragma warning disable 0169
		static Delegate GetCreateARSessionStateCallback_Landroid_hardware_camera2_CameraCaptureSession_StateCallback_Landroid_os_Handler_Handler ()
		{
			if (cb_createARSessionStateCallback_Landroid_hardware_camera2_CameraCaptureSession_StateCallback_Landroid_os_Handler_ == null)
				cb_createARSessionStateCallback_Landroid_hardware_camera2_CameraCaptureSession_StateCallback_Landroid_os_Handler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateARSessionStateCallback_Landroid_hardware_camera2_CameraCaptureSession_StateCallback_Landroid_os_Handler_);
			return cb_createARSessionStateCallback_Landroid_hardware_camera2_CameraCaptureSession_StateCallback_Landroid_os_Handler_;
		}

		static IntPtr n_CreateARSessionStateCallback_Landroid_hardware_camera2_CameraCaptureSession_StateCallback_Landroid_os_Handler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Google.AR.Core.SharedCamera __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.SharedCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.Camera2.CameraCaptureSession.StateCallback p0 = global::Java.Lang.Object.GetObject<global::Android.Hardware.Camera2.CameraCaptureSession.StateCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateARSessionStateCallback (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='SharedCamera']/method[@name='createARSessionStateCallback' and count(parameter)=2 and parameter[1][@type='android.hardware.camera2.CameraCaptureSession.StateCallback'] and parameter[2][@type='android.os.Handler']]"
		[Register ("createARSessionStateCallback", "(Landroid/hardware/camera2/CameraCaptureSession$StateCallback;Landroid/os/Handler;)Landroid/hardware/camera2/CameraCaptureSession$StateCallback;", "GetCreateARSessionStateCallback_Landroid_hardware_camera2_CameraCaptureSession_StateCallback_Landroid_os_Handler_Handler")]
		public virtual unsafe global::Android.Hardware.Camera2.CameraCaptureSession.StateCallback CreateARSessionStateCallback (global::Android.Hardware.Camera2.CameraCaptureSession.StateCallback p0, global::Android.OS.Handler p1)
		{
			const string __id = "createARSessionStateCallback.(Landroid/hardware/camera2/CameraCaptureSession$StateCallback;Landroid/os/Handler;)Landroid/hardware/camera2/CameraCaptureSession$StateCallback;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Hardware.Camera2.CameraCaptureSession.StateCallback> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setAppSurfaces_Ljava_lang_String_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetAppSurfaces_Ljava_lang_String_Ljava_util_List_Handler ()
		{
			if (cb_setAppSurfaces_Ljava_lang_String_Ljava_util_List_ == null)
				cb_setAppSurfaces_Ljava_lang_String_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAppSurfaces_Ljava_lang_String_Ljava_util_List_);
			return cb_setAppSurfaces_Ljava_lang_String_Ljava_util_List_;
		}

		static void n_SetAppSurfaces_Ljava_lang_String_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Google.AR.Core.SharedCamera __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.SharedCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::Android.Views.Surface>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetAppSurfaces (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='SharedCamera']/method[@name='setAppSurfaces' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;android.view.Surface&gt;']]"
		[Register ("setAppSurfaces", "(Ljava/lang/String;Ljava/util/List;)V", "GetSetAppSurfaces_Ljava_lang_String_Ljava_util_List_Handler")]
		public virtual unsafe void SetAppSurfaces (string p0, global::System.Collections.Generic.IList<global::Android.Views.Surface> p1)
		{
			const string __id = "setAppSurfaces.(Ljava/lang/String;Ljava/util/List;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Android.Views.Surface>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setCaptureCallback_Landroid_hardware_camera2_CameraCaptureSession_CaptureCallback_Landroid_os_Handler_;
#pragma warning disable 0169
		static Delegate GetSetCaptureCallback_Landroid_hardware_camera2_CameraCaptureSession_CaptureCallback_Landroid_os_Handler_Handler ()
		{
			if (cb_setCaptureCallback_Landroid_hardware_camera2_CameraCaptureSession_CaptureCallback_Landroid_os_Handler_ == null)
				cb_setCaptureCallback_Landroid_hardware_camera2_CameraCaptureSession_CaptureCallback_Landroid_os_Handler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCaptureCallback_Landroid_hardware_camera2_CameraCaptureSession_CaptureCallback_Landroid_os_Handler_);
			return cb_setCaptureCallback_Landroid_hardware_camera2_CameraCaptureSession_CaptureCallback_Landroid_os_Handler_;
		}

		static void n_SetCaptureCallback_Landroid_hardware_camera2_CameraCaptureSession_CaptureCallback_Landroid_os_Handler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Google.AR.Core.SharedCamera __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.SharedCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.Camera2.CameraCaptureSession.CaptureCallback p0 = global::Java.Lang.Object.GetObject<global::Android.Hardware.Camera2.CameraCaptureSession.CaptureCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetCaptureCallback (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='SharedCamera']/method[@name='setCaptureCallback' and count(parameter)=2 and parameter[1][@type='android.hardware.camera2.CameraCaptureSession.CaptureCallback'] and parameter[2][@type='android.os.Handler']]"
		[Register ("setCaptureCallback", "(Landroid/hardware/camera2/CameraCaptureSession$CaptureCallback;Landroid/os/Handler;)V", "GetSetCaptureCallback_Landroid_hardware_camera2_CameraCaptureSession_CaptureCallback_Landroid_os_Handler_Handler")]
		public virtual unsafe void SetCaptureCallback (global::Android.Hardware.Camera2.CameraCaptureSession.CaptureCallback p0, global::Android.OS.Handler p1)
		{
			const string __id = "setCaptureCallback.(Landroid/hardware/camera2/CameraCaptureSession$CaptureCallback;Landroid/os/Handler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
