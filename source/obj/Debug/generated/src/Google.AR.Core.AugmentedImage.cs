using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedImage']"
	[global::Android.Runtime.Register ("com/google/ar/core/AugmentedImage", DoNotGenerateAcw=true)]
	public partial class AugmentedImage : global::Google.AR.Core.TrackableBase {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedImage.TrackingMethod']"
		[global::Android.Runtime.Register ("com/google/ar/core/AugmentedImage$TrackingMethod", DoNotGenerateAcw=true)]
		public sealed partial class TrackingMethod : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedImage.TrackingMethod']/field[@name='FULL_TRACKING']"
			[Register ("FULL_TRACKING")]
			public static global::Google.AR.Core.AugmentedImage.TrackingMethod FullTracking {
				get {
					const string __id = "FULL_TRACKING.Lcom/google/ar/core/AugmentedImage$TrackingMethod;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedImage.TrackingMethod> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedImage.TrackingMethod']/field[@name='LAST_KNOWN_POSE']"
			[Register ("LAST_KNOWN_POSE")]
			public static global::Google.AR.Core.AugmentedImage.TrackingMethod LastKnownPose {
				get {
					const string __id = "LAST_KNOWN_POSE.Lcom/google/ar/core/AugmentedImage$TrackingMethod;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedImage.TrackingMethod> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedImage.TrackingMethod']/field[@name='NOT_TRACKING']"
			[Register ("NOT_TRACKING")]
			public static global::Google.AR.Core.AugmentedImage.TrackingMethod NotTracking {
				get {
					const string __id = "NOT_TRACKING.Lcom/google/ar/core/AugmentedImage$TrackingMethod;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedImage.TrackingMethod> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/AugmentedImage$TrackingMethod", typeof (TrackingMethod));
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

			internal TrackingMethod (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedImage.TrackingMethod']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/AugmentedImage$TrackingMethod;", "")]
			public static unsafe global::Google.AR.Core.AugmentedImage.TrackingMethod ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/ar/core/AugmentedImage$TrackingMethod;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedImage.TrackingMethod> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedImage.TrackingMethod']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/ar/core/AugmentedImage$TrackingMethod;", "")]
			public static unsafe global::Google.AR.Core.AugmentedImage.TrackingMethod[] Values ()
			{
				const string __id = "values.()[Lcom/google/ar/core/AugmentedImage$TrackingMethod;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Google.AR.Core.AugmentedImage.TrackingMethod[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.AugmentedImage.TrackingMethod));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/AugmentedImage", typeof (AugmentedImage));
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

		protected AugmentedImage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getCenterPose;
#pragma warning disable 0169
		static Delegate GetGetCenterPoseHandler ()
		{
			if (cb_getCenterPose == null)
				cb_getCenterPose = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCenterPose);
			return cb_getCenterPose;
		}

		static IntPtr n_GetCenterPose (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.AugmentedImage __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CenterPose);
		}
#pragma warning restore 0169

		public virtual unsafe global::Google.AR.Core.Pose CenterPose {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedImage']/method[@name='getCenterPose' and count(parameter)=0]"
			[Register ("getCenterPose", "()Lcom/google/ar/core/Pose;", "GetGetCenterPoseHandler")]
			get {
				const string __id = "getCenterPose.()Lcom/google/ar/core/Pose;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getExtentX;
#pragma warning disable 0169
		static Delegate GetGetExtentXHandler ()
		{
			if (cb_getExtentX == null)
				cb_getExtentX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetExtentX);
			return cb_getExtentX;
		}

		static float n_GetExtentX (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.AugmentedImage __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExtentX;
		}
#pragma warning restore 0169

		public virtual unsafe float ExtentX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedImage']/method[@name='getExtentX' and count(parameter)=0]"
			[Register ("getExtentX", "()F", "GetGetExtentXHandler")]
			get {
				const string __id = "getExtentX.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getExtentZ;
#pragma warning disable 0169
		static Delegate GetGetExtentZHandler ()
		{
			if (cb_getExtentZ == null)
				cb_getExtentZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetExtentZ);
			return cb_getExtentZ;
		}

		static float n_GetExtentZ (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.AugmentedImage __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExtentZ;
		}
#pragma warning restore 0169

		public virtual unsafe float ExtentZ {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedImage']/method[@name='getExtentZ' and count(parameter)=0]"
			[Register ("getExtentZ", "()F", "GetGetExtentZHandler")]
			get {
				const string __id = "getExtentZ.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getIndex;
#pragma warning disable 0169
		static Delegate GetGetIndexHandler ()
		{
			if (cb_getIndex == null)
				cb_getIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIndex);
			return cb_getIndex;
		}

		static int n_GetIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.AugmentedImage __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Index;
		}
#pragma warning restore 0169

		public virtual unsafe int Index {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedImage']/method[@name='getIndex' and count(parameter)=0]"
			[Register ("getIndex", "()I", "GetGetIndexHandler")]
			get {
				const string __id = "getIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.AugmentedImage __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedImage']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTrackingState;
#pragma warning disable 0169
		static Delegate GetGetTrackingStateHandler ()
		{
			if (cb_getTrackingState == null)
				cb_getTrackingState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrackingState);
			return cb_getTrackingState;
		}

		static IntPtr n_GetTrackingState (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.AugmentedImage __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TrackingState);
		}
#pragma warning restore 0169

		public override unsafe global::Google.AR.Core.TrackingState TrackingState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedImage']/method[@name='getTrackingState' and count(parameter)=0]"
			[Register ("getTrackingState", "()Lcom/google/ar/core/TrackingState;", "GetGetTrackingStateHandler")]
			get {
				const string __id = "getTrackingState.()Lcom/google/ar/core/TrackingState;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.TrackingState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Google.AR.Core.AugmentedImage __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.Pose p0 = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateAnchor (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedImage']/method[@name='createAnchor' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Pose']]"
		[Register ("createAnchor", "(Lcom/google/ar/core/Pose;)Lcom/google/ar/core/Anchor;", "GetCreateAnchor_Lcom_google_ar_core_Pose_Handler")]
		public override unsafe global::Google.AR.Core.Anchor CreateAnchor (global::Google.AR.Core.Pose p0)
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

		static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEquals_Ljava_lang_Object_Handler ()
		{
			if (cb_equals_Ljava_lang_Object_ == null)
				cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
			return cb_equals_Ljava_lang_Object_;
		}

		static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.AR.Core.AugmentedImage __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedImage']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;)Z", "GetEquals_Ljava_lang_Object_Handler")]
		public override unsafe bool Equals (global::Java.Lang.Object p0)
		{
			const string __id = "equals.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getTrackingMethod;
#pragma warning disable 0169
		static Delegate GetGetTrackingMethodHandler ()
		{
			if (cb_getTrackingMethod == null)
				cb_getTrackingMethod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrackingMethod);
			return cb_getTrackingMethod;
		}

		static IntPtr n_GetTrackingMethod (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.AugmentedImage __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetTrackingMethod ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedImage']/method[@name='getTrackingMethod' and count(parameter)=0]"
		[Register ("getTrackingMethod", "()Lcom/google/ar/core/AugmentedImage$TrackingMethod;", "GetGetTrackingMethodHandler")]
		public virtual unsafe global::Google.AR.Core.AugmentedImage.TrackingMethod GetTrackingMethod ()
		{
			const string __id = "getTrackingMethod.()Lcom/google/ar/core/AugmentedImage$TrackingMethod;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedImage.TrackingMethod> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_hashCode;
#pragma warning disable 0169
		static Delegate GetGetHashCodeHandler ()
		{
			if (cb_hashCode == null)
				cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
			return cb_hashCode;
		}

		static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.AugmentedImage __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHashCode ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedImage']/method[@name='hashCode' and count(parameter)=0]"
		[Register ("hashCode", "()I", "GetGetHashCodeHandler")]
		public override unsafe int GetHashCode ()
		{
			const string __id = "hashCode.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
