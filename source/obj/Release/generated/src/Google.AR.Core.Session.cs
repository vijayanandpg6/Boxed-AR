using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']"
	[global::Android.Runtime.Register ("com/google/ar/core/Session", DoNotGenerateAcw=true)]
	public partial class Session : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session.Feature']"
		[global::Android.Runtime.Register ("com/google/ar/core/Session$Feature", DoNotGenerateAcw=true)]
		public sealed partial class Feature : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session.Feature']/field[@name='FRONT_CAMERA']"
			[Register ("FRONT_CAMERA")]
			public static global::Google.AR.Core.Session.Feature FrontCamera {
				get {
					const string __id = "FRONT_CAMERA.Lcom/google/ar/core/Session$Feature;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session.Feature> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session.Feature']/field[@name='SHARED_CAMERA']"
			[Register ("SHARED_CAMERA")]
			public static global::Google.AR.Core.Session.Feature SharedCamera {
				get {
					const string __id = "SHARED_CAMERA.Lcom/google/ar/core/Session$Feature;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session.Feature> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/Session$Feature", typeof (Feature));
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

			internal Feature (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session.Feature']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/Session$Feature;", "")]
			public static unsafe global::Google.AR.Core.Session.Feature ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/ar/core/Session$Feature;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session.Feature> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session.Feature']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/ar/core/Session$Feature;", "")]
			public static unsafe global::Google.AR.Core.Session.Feature[] Values ()
			{
				const string __id = "values.()[Lcom/google/ar/core/Session$Feature;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Google.AR.Core.Session.Feature[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.Session.Feature));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/Session", typeof (Session));
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

		protected Session (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/constructor[@name='Session' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe Session ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/constructor[@name='Session' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe Session (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/constructor[@name='Session' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.Set&lt;com.google.ar.core.Session.Feature&gt;']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/util/Set;)V", "")]
		public unsafe Session (global::Android.Content.Context p0, global::System.Collections.Generic.ICollection<global::Google.AR.Core.Session.Feature> p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/util/Set;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = global::Android.Runtime.JavaSet<global::Google.AR.Core.Session.Feature>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getAllAnchors;
#pragma warning disable 0169
		static Delegate GetGetAllAnchorsHandler ()
		{
			if (cb_getAllAnchors == null)
				cb_getAllAnchors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllAnchors);
			return cb_getAllAnchors;
		}

		static IntPtr n_GetAllAnchors (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Session __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Google.AR.Core.Anchor>.ToLocalJniHandle (__this.AllAnchors);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.ICollection<global::Google.AR.Core.Anchor> AllAnchors {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/method[@name='getAllAnchors' and count(parameter)=0]"
			[Register ("getAllAnchors", "()Ljava/util/Collection;", "GetGetAllAnchorsHandler")]
			get {
				const string __id = "getAllAnchors.()Ljava/util/Collection;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaCollection<global::Google.AR.Core.Anchor>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCameraConfig;
#pragma warning disable 0169
		static Delegate GetGetCameraConfigHandler ()
		{
			if (cb_getCameraConfig == null)
				cb_getCameraConfig = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCameraConfig);
			return cb_getCameraConfig;
		}

		static IntPtr n_GetCameraConfig (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Session __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CameraConfig);
		}
#pragma warning restore 0169

		static Delegate cb_setCameraConfig_Lcom_google_ar_core_CameraConfig_;
#pragma warning disable 0169
		static Delegate GetSetCameraConfig_Lcom_google_ar_core_CameraConfig_Handler ()
		{
			if (cb_setCameraConfig_Lcom_google_ar_core_CameraConfig_ == null)
				cb_setCameraConfig_Lcom_google_ar_core_CameraConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCameraConfig_Lcom_google_ar_core_CameraConfig_);
			return cb_setCameraConfig_Lcom_google_ar_core_CameraConfig_;
		}

		static void n_SetCameraConfig_Lcom_google_ar_core_CameraConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.AR.Core.Session __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.CameraConfig p0 = global::Java.Lang.Object.GetObject<global::Google.AR.Core.CameraConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CameraConfig = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Google.AR.Core.CameraConfig CameraConfig {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/method[@name='getCameraConfig' and count(parameter)=0]"
			[Register ("getCameraConfig", "()Lcom/google/ar/core/CameraConfig;", "GetGetCameraConfigHandler")]
			get {
				const string __id = "getCameraConfig.()Lcom/google/ar/core/CameraConfig;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.CameraConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/method[@name='setCameraConfig' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.CameraConfig']]"
			[Register ("setCameraConfig", "(Lcom/google/ar/core/CameraConfig;)V", "GetSetCameraConfig_Lcom_google_ar_core_CameraConfig_Handler")]
			set {
				const string __id = "setCameraConfig.(Lcom/google/ar/core/CameraConfig;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getConfig;
#pragma warning disable 0169
		static Delegate GetGetConfigHandler ()
		{
			if (cb_getConfig == null)
				cb_getConfig = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConfig);
			return cb_getConfig;
		}

		static IntPtr n_GetConfig (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Session __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Config);
		}
#pragma warning restore 0169

		public virtual unsafe global::Google.AR.Core.Config Config {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/method[@name='getConfig' and count(parameter)=0]"
			[Register ("getConfig", "()Lcom/google/ar/core/Config;", "GetGetConfigHandler")]
			get {
				const string __id = "getConfig.()Lcom/google/ar/core/Config;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSharedCamera;
#pragma warning disable 0169
		static Delegate GetGetSharedCameraHandler ()
		{
			if (cb_getSharedCamera == null)
				cb_getSharedCamera = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSharedCamera);
			return cb_getSharedCamera;
		}

		static IntPtr n_GetSharedCamera (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Session __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SharedCamera);
		}
#pragma warning restore 0169

		public virtual unsafe global::Google.AR.Core.SharedCamera SharedCamera {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/method[@name='getSharedCamera' and count(parameter)=0]"
			[Register ("getSharedCamera", "()Lcom/google/ar/core/SharedCamera;", "GetGetSharedCameraHandler")]
			get {
				const string __id = "getSharedCamera.()Lcom/google/ar/core/SharedCamera;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.SharedCamera> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSupportedCameraConfigs;
#pragma warning disable 0169
		static Delegate GetGetSupportedCameraConfigsHandler ()
		{
			if (cb_getSupportedCameraConfigs == null)
				cb_getSupportedCameraConfigs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSupportedCameraConfigs);
			return cb_getSupportedCameraConfigs;
		}

		static IntPtr n_GetSupportedCameraConfigs (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Session __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Google.AR.Core.CameraConfig>.ToLocalJniHandle (__this.SupportedCameraConfigs);
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Google.AR.Core.CameraConfig> SupportedCameraConfigs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/method[@name='getSupportedCameraConfigs' and count(parameter)=0]"
			[Register ("getSupportedCameraConfigs", "()Ljava/util/List;", "GetGetSupportedCameraConfigsHandler")]
			get {
				const string __id = "getSupportedCameraConfigs.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Google.AR.Core.CameraConfig>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Session __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_configure_Lcom_google_ar_core_Config_;
#pragma warning disable 0169
		static Delegate GetConfigure_Lcom_google_ar_core_Config_Handler ()
		{
			if (cb_configure_Lcom_google_ar_core_Config_ == null)
				cb_configure_Lcom_google_ar_core_Config_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Configure_Lcom_google_ar_core_Config_);
			return cb_configure_Lcom_google_ar_core_Config_;
		}

		static void n_Configure_Lcom_google_ar_core_Config_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.AR.Core.Session __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.Config p0 = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Configure (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/method[@name='configure' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Config']]"
		[Register ("configure", "(Lcom/google/ar/core/Config;)V", "GetConfigure_Lcom_google_ar_core_Config_Handler")]
		public virtual unsafe void Configure (global::Google.AR.Core.Config p0)
		{
			const string __id = "configure.(Lcom/google/ar/core/Config;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_createAnchor_Lcom_google_ar_core_Pose_;
#pragma warning disable 0169
		static Delegate GetCreateAnchor_Lcom_google_ar_core_Pose_Handler ()
		{
			if (cb_createAnchor_Lcom_google_ar_core_Pose_ == null)
				cb_createAnchor_Lcom_google_ar_core_Pose_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateAnchor_Lcom_google_ar_core_Pose_);
			return cb_createAnchor_Lcom_google_ar_core_Pose_;
		}

		static IntPtr n_CreateAnchor_Lcom_google_ar_core_Pose_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.AR.Core.Session __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.Pose p0 = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateAnchor (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/method[@name='createAnchor' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Pose']]"
		[Register ("createAnchor", "(Lcom/google/ar/core/Pose;)Lcom/google/ar/core/Anchor;", "GetCreateAnchor_Lcom_google_ar_core_Pose_Handler")]
		public virtual unsafe global::Google.AR.Core.Anchor CreateAnchor (global::Google.AR.Core.Pose p0)
		{
			const string __id = "createAnchor.(Lcom/google/ar/core/Pose;)Lcom/google/ar/core/Anchor;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/method[@name='createForSharedCamera' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Obsolete (@"deprecated")]
		[Register ("createForSharedCamera", "(Landroid/content/Context;)Lcom/google/ar/core/Session;", "")]
		public static unsafe global::Google.AR.Core.Session CreateForSharedCamera (global::Android.Content.Context p0)
		{
			const string __id = "createForSharedCamera.(Landroid/content/Context;)Lcom/google/ar/core/Session;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getAllTrackables_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetGetAllTrackables_Ljava_lang_Class_Handler ()
		{
			if (cb_getAllTrackables_Ljava_lang_Class_ == null)
				cb_getAllTrackables_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAllTrackables_Ljava_lang_Class_);
			return cb_getAllTrackables_Ljava_lang_Class_;
		}

		static IntPtr n_GetAllTrackables_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.AR.Core.Session __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaCollection.ToLocalJniHandle (__this.GetAllTrackables (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/method[@name='getAllTrackables' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("getAllTrackables", "(Ljava/lang/Class;)Ljava/util/Collection;", "GetGetAllTrackables_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.google.ar.core.Trackable"})]
		public virtual unsafe global::System.Collections.ICollection GetAllTrackables (global::Java.Lang.Class p0)
		{
			const string __id = "getAllTrackables.(Ljava/lang/Class;)Ljava/util/Collection;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaCollection.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getConfig_Lcom_google_ar_core_Config_;
#pragma warning disable 0169
		static Delegate GetGetConfig_Lcom_google_ar_core_Config_Handler ()
		{
			if (cb_getConfig_Lcom_google_ar_core_Config_ == null)
				cb_getConfig_Lcom_google_ar_core_Config_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetConfig_Lcom_google_ar_core_Config_);
			return cb_getConfig_Lcom_google_ar_core_Config_;
		}

		static void n_GetConfig_Lcom_google_ar_core_Config_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.AR.Core.Session __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.Config p0 = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetConfig (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/method[@name='getConfig' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Config']]"
		[Register ("getConfig", "(Lcom/google/ar/core/Config;)V", "GetGetConfig_Lcom_google_ar_core_Config_Handler")]
		public virtual unsafe void GetConfig (global::Google.AR.Core.Config p0)
		{
			const string __id = "getConfig.(Lcom/google/ar/core/Config;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getSupportedCameraConfigs_Lcom_google_ar_core_CameraConfigFilter_;
#pragma warning disable 0169
		static Delegate GetGetSupportedCameraConfigs_Lcom_google_ar_core_CameraConfigFilter_Handler ()
		{
			if (cb_getSupportedCameraConfigs_Lcom_google_ar_core_CameraConfigFilter_ == null)
				cb_getSupportedCameraConfigs_Lcom_google_ar_core_CameraConfigFilter_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSupportedCameraConfigs_Lcom_google_ar_core_CameraConfigFilter_);
			return cb_getSupportedCameraConfigs_Lcom_google_ar_core_CameraConfigFilter_;
		}

		static IntPtr n_GetSupportedCameraConfigs_Lcom_google_ar_core_CameraConfigFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.AR.Core.Session __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.CameraConfigFilter p0 = global::Java.Lang.Object.GetObject<global::Google.AR.Core.CameraConfigFilter> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Google.AR.Core.CameraConfig>.ToLocalJniHandle (__this.GetSupportedCameraConfigs (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/method[@name='getSupportedCameraConfigs' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.CameraConfigFilter']]"
		[Register ("getSupportedCameraConfigs", "(Lcom/google/ar/core/CameraConfigFilter;)Ljava/util/List;", "GetGetSupportedCameraConfigs_Lcom_google_ar_core_CameraConfigFilter_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Google.AR.Core.CameraConfig> GetSupportedCameraConfigs (global::Google.AR.Core.CameraConfigFilter p0)
		{
			const string __id = "getSupportedCameraConfigs.(Lcom/google/ar/core/CameraConfigFilter;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Google.AR.Core.CameraConfig>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_hostCloudAnchor_Lcom_google_ar_core_Anchor_;
#pragma warning disable 0169
		static Delegate GetHostCloudAnchor_Lcom_google_ar_core_Anchor_Handler ()
		{
			if (cb_hostCloudAnchor_Lcom_google_ar_core_Anchor_ == null)
				cb_hostCloudAnchor_Lcom_google_ar_core_Anchor_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_HostCloudAnchor_Lcom_google_ar_core_Anchor_);
			return cb_hostCloudAnchor_Lcom_google_ar_core_Anchor_;
		}

		static IntPtr n_HostCloudAnchor_Lcom_google_ar_core_Anchor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.AR.Core.Session __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.Anchor p0 = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.HostCloudAnchor (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/method[@name='hostCloudAnchor' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Anchor']]"
		[Register ("hostCloudAnchor", "(Lcom/google/ar/core/Anchor;)Lcom/google/ar/core/Anchor;", "GetHostCloudAnchor_Lcom_google_ar_core_Anchor_Handler")]
		public virtual unsafe global::Google.AR.Core.Anchor HostCloudAnchor (global::Google.AR.Core.Anchor p0)
		{
			const string __id = "hostCloudAnchor.(Lcom/google/ar/core/Anchor;)Lcom/google/ar/core/Anchor;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_isSupported_Lcom_google_ar_core_Config_;
#pragma warning disable 0169
		static Delegate GetIsSupported_Lcom_google_ar_core_Config_Handler ()
		{
			if (cb_isSupported_Lcom_google_ar_core_Config_ == null)
				cb_isSupported_Lcom_google_ar_core_Config_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsSupported_Lcom_google_ar_core_Config_);
			return cb_isSupported_Lcom_google_ar_core_Config_;
		}

		static bool n_IsSupported_Lcom_google_ar_core_Config_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.AR.Core.Session __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.Config p0 = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsSupported (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/method[@name='isSupported' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Config']]"
		[Obsolete (@"deprecated")]
		[Register ("isSupported", "(Lcom/google/ar/core/Config;)Z", "GetIsSupported_Lcom_google_ar_core_Config_Handler")]
		public virtual unsafe bool IsSupported (global::Google.AR.Core.Config p0)
		{
			const string __id = "isSupported.(Lcom/google/ar/core/Config;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_pause;
#pragma warning disable 0169
		static Delegate GetPauseHandler ()
		{
			if (cb_pause == null)
				cb_pause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Pause);
			return cb_pause;
		}

		static void n_Pause (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Session __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public virtual unsafe void Pause ()
		{
			const string __id = "pause.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_resolveCloudAnchor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetResolveCloudAnchor_Ljava_lang_String_Handler ()
		{
			if (cb_resolveCloudAnchor_Ljava_lang_String_ == null)
				cb_resolveCloudAnchor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ResolveCloudAnchor_Ljava_lang_String_);
			return cb_resolveCloudAnchor_Ljava_lang_String_;
		}

		static IntPtr n_ResolveCloudAnchor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.AR.Core.Session __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ResolveCloudAnchor (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/method[@name='resolveCloudAnchor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("resolveCloudAnchor", "(Ljava/lang/String;)Lcom/google/ar/core/Anchor;", "GetResolveCloudAnchor_Ljava_lang_String_Handler")]
		public virtual unsafe global::Google.AR.Core.Anchor ResolveCloudAnchor (string p0)
		{
			const string __id = "resolveCloudAnchor.(Ljava/lang/String;)Lcom/google/ar/core/Anchor;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_resume;
#pragma warning disable 0169
		static Delegate GetResumeHandler ()
		{
			if (cb_resume == null)
				cb_resume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Resume);
			return cb_resume;
		}

		static void n_Resume (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Session __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resume ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/method[@name='resume' and count(parameter)=0]"
		[Register ("resume", "()V", "GetResumeHandler")]
		public virtual unsafe void Resume ()
		{
			const string __id = "resume.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setCameraTextureName_I;
#pragma warning disable 0169
		static Delegate GetSetCameraTextureName_IHandler ()
		{
			if (cb_setCameraTextureName_I == null)
				cb_setCameraTextureName_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCameraTextureName_I);
			return cb_setCameraTextureName_I;
		}

		static void n_SetCameraTextureName_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Google.AR.Core.Session __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCameraTextureName (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/method[@name='setCameraTextureName' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCameraTextureName", "(I)V", "GetSetCameraTextureName_IHandler")]
		public virtual unsafe void SetCameraTextureName (int p0)
		{
			const string __id = "setCameraTextureName.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDisplayGeometry_III;
#pragma warning disable 0169
		static Delegate GetSetDisplayGeometry_IIIHandler ()
		{
			if (cb_setDisplayGeometry_III == null)
				cb_setDisplayGeometry_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_SetDisplayGeometry_III);
			return cb_setDisplayGeometry_III;
		}

		static void n_SetDisplayGeometry_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			global::Google.AR.Core.Session __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDisplayGeometry (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/method[@name='setDisplayGeometry' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("setDisplayGeometry", "(III)V", "GetSetDisplayGeometry_IIIHandler")]
		public virtual unsafe void SetDisplayGeometry (int p0, int p1, int p2)
		{
			const string __id = "setDisplayGeometry.(III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_update;
#pragma warning disable 0169
		static Delegate GetUpdateHandler ()
		{
			if (cb_update == null)
				cb_update = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Update);
			return cb_update;
		}

		static IntPtr n_Update (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Session __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Update ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/method[@name='update' and count(parameter)=0]"
		[Register ("update", "()Lcom/google/ar/core/Frame;", "GetUpdateHandler")]
		public virtual unsafe global::Google.AR.Core.Frame Update ()
		{
			const string __id = "update.()Lcom/google/ar/core/Frame;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Frame> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
