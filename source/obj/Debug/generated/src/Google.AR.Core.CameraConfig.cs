using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraConfig']"
	[global::Android.Runtime.Register ("com/google/ar/core/CameraConfig", DoNotGenerateAcw=true)]
	public partial class CameraConfig : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraConfig.DepthSensorUsage']"
		[global::Android.Runtime.Register ("com/google/ar/core/CameraConfig$DepthSensorUsage", DoNotGenerateAcw=true)]
		public sealed partial class DepthSensorUsage : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraConfig.DepthSensorUsage']/field[@name='DO_NOT_USE']"
			[Register ("DO_NOT_USE")]
			public static global::Google.AR.Core.CameraConfig.DepthSensorUsage DoNotUse {
				get {
					const string __id = "DO_NOT_USE.Lcom/google/ar/core/CameraConfig$DepthSensorUsage;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.CameraConfig.DepthSensorUsage> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraConfig.DepthSensorUsage']/field[@name='REQUIRE_AND_USE']"
			[Register ("REQUIRE_AND_USE")]
			public static global::Google.AR.Core.CameraConfig.DepthSensorUsage RequireAndUse {
				get {
					const string __id = "REQUIRE_AND_USE.Lcom/google/ar/core/CameraConfig$DepthSensorUsage;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.CameraConfig.DepthSensorUsage> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/CameraConfig$DepthSensorUsage", typeof (DepthSensorUsage));
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

			internal DepthSensorUsage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraConfig.DepthSensorUsage']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/CameraConfig$DepthSensorUsage;", "")]
			public static unsafe global::Google.AR.Core.CameraConfig.DepthSensorUsage ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/ar/core/CameraConfig$DepthSensorUsage;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.CameraConfig.DepthSensorUsage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraConfig.DepthSensorUsage']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/ar/core/CameraConfig$DepthSensorUsage;", "")]
			public static unsafe global::Google.AR.Core.CameraConfig.DepthSensorUsage[] Values ()
			{
				const string __id = "values.()[Lcom/google/ar/core/CameraConfig$DepthSensorUsage;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Google.AR.Core.CameraConfig.DepthSensorUsage[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.CameraConfig.DepthSensorUsage));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraConfig.FacingDirection']"
		[global::Android.Runtime.Register ("com/google/ar/core/CameraConfig$FacingDirection", DoNotGenerateAcw=true)]
		public sealed partial class FacingDirection : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraConfig.FacingDirection']/field[@name='BACK']"
			[Register ("BACK")]
			public static global::Google.AR.Core.CameraConfig.FacingDirection Back {
				get {
					const string __id = "BACK.Lcom/google/ar/core/CameraConfig$FacingDirection;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.CameraConfig.FacingDirection> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraConfig.FacingDirection']/field[@name='FRONT']"
			[Register ("FRONT")]
			public static global::Google.AR.Core.CameraConfig.FacingDirection Front {
				get {
					const string __id = "FRONT.Lcom/google/ar/core/CameraConfig$FacingDirection;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.CameraConfig.FacingDirection> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/CameraConfig$FacingDirection", typeof (FacingDirection));
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

			internal FacingDirection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraConfig.FacingDirection']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/CameraConfig$FacingDirection;", "")]
			public static unsafe global::Google.AR.Core.CameraConfig.FacingDirection ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/ar/core/CameraConfig$FacingDirection;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.CameraConfig.FacingDirection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraConfig.FacingDirection']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/ar/core/CameraConfig$FacingDirection;", "")]
			public static unsafe global::Google.AR.Core.CameraConfig.FacingDirection[] Values ()
			{
				const string __id = "values.()[Lcom/google/ar/core/CameraConfig$FacingDirection;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Google.AR.Core.CameraConfig.FacingDirection[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.CameraConfig.FacingDirection));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraConfig.TargetFps']"
		[global::Android.Runtime.Register ("com/google/ar/core/CameraConfig$TargetFps", DoNotGenerateAcw=true)]
		public sealed partial class TargetFps : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraConfig.TargetFps']/field[@name='TARGET_FPS_30']"
			[Register ("TARGET_FPS_30")]
			public static global::Google.AR.Core.CameraConfig.TargetFps TargetFps30 {
				get {
					const string __id = "TARGET_FPS_30.Lcom/google/ar/core/CameraConfig$TargetFps;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.CameraConfig.TargetFps> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraConfig.TargetFps']/field[@name='TARGET_FPS_60']"
			[Register ("TARGET_FPS_60")]
			public static global::Google.AR.Core.CameraConfig.TargetFps TargetFps60 {
				get {
					const string __id = "TARGET_FPS_60.Lcom/google/ar/core/CameraConfig$TargetFps;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.CameraConfig.TargetFps> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/CameraConfig$TargetFps", typeof (TargetFps));
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

			internal TargetFps (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraConfig.TargetFps']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/CameraConfig$TargetFps;", "")]
			public static unsafe global::Google.AR.Core.CameraConfig.TargetFps ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/ar/core/CameraConfig$TargetFps;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.CameraConfig.TargetFps> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraConfig.TargetFps']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/ar/core/CameraConfig$TargetFps;", "")]
			public static unsafe global::Google.AR.Core.CameraConfig.TargetFps[] Values ()
			{
				const string __id = "values.()[Lcom/google/ar/core/CameraConfig$TargetFps;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Google.AR.Core.CameraConfig.TargetFps[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.CameraConfig.TargetFps));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/CameraConfig", typeof (CameraConfig));
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

		protected CameraConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraConfig']/constructor[@name='CameraConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe CameraConfig ()
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

		static Delegate cb_getCameraId;
#pragma warning disable 0169
		static Delegate GetGetCameraIdHandler ()
		{
			if (cb_getCameraId == null)
				cb_getCameraId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCameraId);
			return cb_getCameraId;
		}

		static IntPtr n_GetCameraId (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.CameraConfig __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.CameraConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CameraId);
		}
#pragma warning restore 0169

		public virtual unsafe string CameraId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraConfig']/method[@name='getCameraId' and count(parameter)=0]"
			[Register ("getCameraId", "()Ljava/lang/String;", "GetGetCameraIdHandler")]
			get {
				const string __id = "getCameraId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFpsRange;
#pragma warning disable 0169
		static Delegate GetGetFpsRangeHandler ()
		{
			if (cb_getFpsRange == null)
				cb_getFpsRange = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFpsRange);
			return cb_getFpsRange;
		}

		static IntPtr n_GetFpsRange (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.CameraConfig __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.CameraConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FpsRange);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Util.Range FpsRange {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraConfig']/method[@name='getFpsRange' and count(parameter)=0]"
			[Register ("getFpsRange", "()Landroid/util/Range;", "GetGetFpsRangeHandler")]
			get {
				const string __id = "getFpsRange.()Landroid/util/Range;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Util.Range> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getImageSize;
#pragma warning disable 0169
		static Delegate GetGetImageSizeHandler ()
		{
			if (cb_getImageSize == null)
				cb_getImageSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageSize);
			return cb_getImageSize;
		}

		static IntPtr n_GetImageSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.CameraConfig __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.CameraConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ImageSize);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Util.Size ImageSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraConfig']/method[@name='getImageSize' and count(parameter)=0]"
			[Register ("getImageSize", "()Landroid/util/Size;", "GetGetImageSizeHandler")]
			get {
				const string __id = "getImageSize.()Landroid/util/Size;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Util.Size> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextureSize;
#pragma warning disable 0169
		static Delegate GetGetTextureSizeHandler ()
		{
			if (cb_getTextureSize == null)
				cb_getTextureSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextureSize);
			return cb_getTextureSize;
		}

		static IntPtr n_GetTextureSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.CameraConfig __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.CameraConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextureSize);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Util.Size TextureSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraConfig']/method[@name='getTextureSize' and count(parameter)=0]"
			[Register ("getTextureSize", "()Landroid/util/Size;", "GetGetTextureSizeHandler")]
			get {
				const string __id = "getTextureSize.()Landroid/util/Size;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Util.Size> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDepthSensorUsage;
#pragma warning disable 0169
		static Delegate GetGetDepthSensorUsageHandler ()
		{
			if (cb_getDepthSensorUsage == null)
				cb_getDepthSensorUsage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDepthSensorUsage);
			return cb_getDepthSensorUsage;
		}

		static IntPtr n_GetDepthSensorUsage (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.CameraConfig __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.CameraConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetDepthSensorUsage ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraConfig']/method[@name='getDepthSensorUsage' and count(parameter)=0]"
		[Register ("getDepthSensorUsage", "()Lcom/google/ar/core/CameraConfig$DepthSensorUsage;", "GetGetDepthSensorUsageHandler")]
		public virtual unsafe global::Google.AR.Core.CameraConfig.DepthSensorUsage GetDepthSensorUsage ()
		{
			const string __id = "getDepthSensorUsage.()Lcom/google/ar/core/CameraConfig$DepthSensorUsage;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.CameraConfig.DepthSensorUsage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getFacingDirection;
#pragma warning disable 0169
		static Delegate GetGetFacingDirectionHandler ()
		{
			if (cb_getFacingDirection == null)
				cb_getFacingDirection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFacingDirection);
			return cb_getFacingDirection;
		}

		static IntPtr n_GetFacingDirection (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.CameraConfig __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.CameraConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetFacingDirection ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraConfig']/method[@name='getFacingDirection' and count(parameter)=0]"
		[Register ("getFacingDirection", "()Lcom/google/ar/core/CameraConfig$FacingDirection;", "GetGetFacingDirectionHandler")]
		public virtual unsafe global::Google.AR.Core.CameraConfig.FacingDirection GetFacingDirection ()
		{
			const string __id = "getFacingDirection.()Lcom/google/ar/core/CameraConfig$FacingDirection;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.CameraConfig.FacingDirection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
