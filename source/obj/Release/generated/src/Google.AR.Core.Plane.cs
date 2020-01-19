using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane']"
	[global::Android.Runtime.Register ("com/google/ar/core/Plane", DoNotGenerateAcw=true)]
	public partial class Plane : global::Google.AR.Core.TrackableBase {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane.Type']"
		[global::Android.Runtime.Register ("com/google/ar/core/Plane$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane.Type']/field[@name='HORIZONTAL_DOWNWARD_FACING']"
			[Register ("HORIZONTAL_DOWNWARD_FACING")]
			public static global::Google.AR.Core.Plane.Type HorizontalDownwardFacing {
				get {
					const string __id = "HORIZONTAL_DOWNWARD_FACING.Lcom/google/ar/core/Plane$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane.Type']/field[@name='HORIZONTAL_UPWARD_FACING']"
			[Register ("HORIZONTAL_UPWARD_FACING")]
			public static global::Google.AR.Core.Plane.Type HorizontalUpwardFacing {
				get {
					const string __id = "HORIZONTAL_UPWARD_FACING.Lcom/google/ar/core/Plane$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane.Type']/field[@name='VERTICAL']"
			[Register ("VERTICAL")]
			public static global::Google.AR.Core.Plane.Type Vertical {
				get {
					const string __id = "VERTICAL.Lcom/google/ar/core/Plane$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/Plane$Type", typeof (Type));
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

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/Plane$Type;", "")]
			public static unsafe global::Google.AR.Core.Plane.Type ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/ar/core/Plane$Type;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane.Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/ar/core/Plane$Type;", "")]
			public static unsafe global::Google.AR.Core.Plane.Type[] Values ()
			{
				const string __id = "values.()[Lcom/google/ar/core/Plane$Type;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Google.AR.Core.Plane.Type[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.Plane.Type));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/Plane", typeof (Plane));
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

		protected Plane (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane']/constructor[@name='Plane' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe Plane ()
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
			global::Google.AR.Core.Plane __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CenterPose);
		}
#pragma warning restore 0169

		public virtual unsafe global::Google.AR.Core.Pose CenterPose {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane']/method[@name='getCenterPose' and count(parameter)=0]"
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
			global::Google.AR.Core.Plane __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExtentX;
		}
#pragma warning restore 0169

		public virtual unsafe float ExtentX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane']/method[@name='getExtentX' and count(parameter)=0]"
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
			global::Google.AR.Core.Plane __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExtentZ;
		}
#pragma warning restore 0169

		public virtual unsafe float ExtentZ {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane']/method[@name='getExtentZ' and count(parameter)=0]"
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

		static Delegate cb_getPolygon;
#pragma warning disable 0169
		static Delegate GetGetPolygonHandler ()
		{
			if (cb_getPolygon == null)
				cb_getPolygon = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPolygon);
			return cb_getPolygon;
		}

		static IntPtr n_GetPolygon (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Plane __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Polygon);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Nio.FloatBuffer Polygon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane']/method[@name='getPolygon' and count(parameter)=0]"
			[Register ("getPolygon", "()Ljava/nio/FloatBuffer;", "GetGetPolygonHandler")]
			get {
				const string __id = "getPolygon.()Ljava/nio/FloatBuffer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSubsumedBy;
#pragma warning disable 0169
		static Delegate GetGetSubsumedByHandler ()
		{
			if (cb_getSubsumedBy == null)
				cb_getSubsumedBy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubsumedBy);
			return cb_getSubsumedBy;
		}

		static IntPtr n_GetSubsumedBy (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Plane __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SubsumedBy);
		}
#pragma warning restore 0169

		public virtual unsafe global::Google.AR.Core.Plane SubsumedBy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane']/method[@name='getSubsumedBy' and count(parameter)=0]"
			[Register ("getSubsumedBy", "()Lcom/google/ar/core/Plane;", "GetGetSubsumedByHandler")]
			get {
				const string __id = "getSubsumedBy.()Lcom/google/ar/core/Plane;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Google.AR.Core.Plane __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TrackingState);
		}
#pragma warning restore 0169

		public override unsafe global::Google.AR.Core.TrackingState TrackingState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane']/method[@name='getTrackingState' and count(parameter)=0]"
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
			global::Google.AR.Core.Plane __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.Pose p0 = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateAnchor (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane']/method[@name='createAnchor' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Pose']]"
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
			global::Google.AR.Core.Plane __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Plane __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetType ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane']/method[@name='getType' and count(parameter)=0]"
		[Register ("getType", "()Lcom/google/ar/core/Plane$Type;", "GetGetTypeHandler")]
		public virtual unsafe global::Google.AR.Core.Plane.Type GetType ()
		{
			const string __id = "getType.()Lcom/google/ar/core/Plane$Type;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane.Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Google.AR.Core.Plane __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHashCode ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane']/method[@name='hashCode' and count(parameter)=0]"
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

		static Delegate cb_isPoseInExtents_Lcom_google_ar_core_Pose_;
#pragma warning disable 0169
		static Delegate GetIsPoseInExtents_Lcom_google_ar_core_Pose_Handler ()
		{
			if (cb_isPoseInExtents_Lcom_google_ar_core_Pose_ == null)
				cb_isPoseInExtents_Lcom_google_ar_core_Pose_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsPoseInExtents_Lcom_google_ar_core_Pose_);
			return cb_isPoseInExtents_Lcom_google_ar_core_Pose_;
		}

		static bool n_IsPoseInExtents_Lcom_google_ar_core_Pose_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.AR.Core.Plane __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.Pose p0 = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsPoseInExtents (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane']/method[@name='isPoseInExtents' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Pose']]"
		[Register ("isPoseInExtents", "(Lcom/google/ar/core/Pose;)Z", "GetIsPoseInExtents_Lcom_google_ar_core_Pose_Handler")]
		public virtual unsafe bool IsPoseInExtents (global::Google.AR.Core.Pose p0)
		{
			const string __id = "isPoseInExtents.(Lcom/google/ar/core/Pose;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_isPoseInPolygon_Lcom_google_ar_core_Pose_;
#pragma warning disable 0169
		static Delegate GetIsPoseInPolygon_Lcom_google_ar_core_Pose_Handler ()
		{
			if (cb_isPoseInPolygon_Lcom_google_ar_core_Pose_ == null)
				cb_isPoseInPolygon_Lcom_google_ar_core_Pose_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsPoseInPolygon_Lcom_google_ar_core_Pose_);
			return cb_isPoseInPolygon_Lcom_google_ar_core_Pose_;
		}

		static bool n_IsPoseInPolygon_Lcom_google_ar_core_Pose_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.AR.Core.Plane __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.Pose p0 = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsPoseInPolygon (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane']/method[@name='isPoseInPolygon' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Pose']]"
		[Register ("isPoseInPolygon", "(Lcom/google/ar/core/Pose;)Z", "GetIsPoseInPolygon_Lcom_google_ar_core_Pose_Handler")]
		public virtual unsafe bool IsPoseInPolygon (global::Google.AR.Core.Pose p0)
		{
			const string __id = "isPoseInPolygon.(Lcom/google/ar/core/Pose;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
