using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedFace']"
	[global::Android.Runtime.Register ("com/google/ar/core/AugmentedFace", DoNotGenerateAcw=true)]
	public partial class AugmentedFace : global::Google.AR.Core.TrackableBase {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedFace.RegionType']"
		[global::Android.Runtime.Register ("com/google/ar/core/AugmentedFace$RegionType", DoNotGenerateAcw=true)]
		public sealed partial class RegionType : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedFace.RegionType']/field[@name='FOREHEAD_LEFT']"
			[Register ("FOREHEAD_LEFT")]
			public static global::Google.AR.Core.AugmentedFace.RegionType ForeheadLeft {
				get {
					const string __id = "FOREHEAD_LEFT.Lcom/google/ar/core/AugmentedFace$RegionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedFace.RegionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedFace.RegionType']/field[@name='FOREHEAD_RIGHT']"
			[Register ("FOREHEAD_RIGHT")]
			public static global::Google.AR.Core.AugmentedFace.RegionType ForeheadRight {
				get {
					const string __id = "FOREHEAD_RIGHT.Lcom/google/ar/core/AugmentedFace$RegionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedFace.RegionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedFace.RegionType']/field[@name='NOSE_TIP']"
			[Register ("NOSE_TIP")]
			public static global::Google.AR.Core.AugmentedFace.RegionType NoseTip {
				get {
					const string __id = "NOSE_TIP.Lcom/google/ar/core/AugmentedFace$RegionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedFace.RegionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/AugmentedFace$RegionType", typeof (RegionType));
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

			internal RegionType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedFace.RegionType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/AugmentedFace$RegionType;", "")]
			public static unsafe global::Google.AR.Core.AugmentedFace.RegionType ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/ar/core/AugmentedFace$RegionType;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedFace.RegionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedFace.RegionType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/ar/core/AugmentedFace$RegionType;", "")]
			public static unsafe global::Google.AR.Core.AugmentedFace.RegionType[] Values ()
			{
				const string __id = "values.()[Lcom/google/ar/core/AugmentedFace$RegionType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Google.AR.Core.AugmentedFace.RegionType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.AugmentedFace.RegionType));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/AugmentedFace", typeof (AugmentedFace));
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

		protected AugmentedFace (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedFace']/constructor[@name='AugmentedFace' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe AugmentedFace ()
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
			global::Google.AR.Core.AugmentedFace __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedFace> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CenterPose);
		}
#pragma warning restore 0169

		public virtual unsafe global::Google.AR.Core.Pose CenterPose {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedFace']/method[@name='getCenterPose' and count(parameter)=0]"
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

		static Delegate cb_getMeshNormals;
#pragma warning disable 0169
		static Delegate GetGetMeshNormalsHandler ()
		{
			if (cb_getMeshNormals == null)
				cb_getMeshNormals = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMeshNormals);
			return cb_getMeshNormals;
		}

		static IntPtr n_GetMeshNormals (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.AugmentedFace __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedFace> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MeshNormals);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Nio.FloatBuffer MeshNormals {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedFace']/method[@name='getMeshNormals' and count(parameter)=0]"
			[Register ("getMeshNormals", "()Ljava/nio/FloatBuffer;", "GetGetMeshNormalsHandler")]
			get {
				const string __id = "getMeshNormals.()Ljava/nio/FloatBuffer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMeshTextureCoordinates;
#pragma warning disable 0169
		static Delegate GetGetMeshTextureCoordinatesHandler ()
		{
			if (cb_getMeshTextureCoordinates == null)
				cb_getMeshTextureCoordinates = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMeshTextureCoordinates);
			return cb_getMeshTextureCoordinates;
		}

		static IntPtr n_GetMeshTextureCoordinates (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.AugmentedFace __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedFace> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MeshTextureCoordinates);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Nio.FloatBuffer MeshTextureCoordinates {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedFace']/method[@name='getMeshTextureCoordinates' and count(parameter)=0]"
			[Register ("getMeshTextureCoordinates", "()Ljava/nio/FloatBuffer;", "GetGetMeshTextureCoordinatesHandler")]
			get {
				const string __id = "getMeshTextureCoordinates.()Ljava/nio/FloatBuffer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMeshTriangleIndices;
#pragma warning disable 0169
		static Delegate GetGetMeshTriangleIndicesHandler ()
		{
			if (cb_getMeshTriangleIndices == null)
				cb_getMeshTriangleIndices = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMeshTriangleIndices);
			return cb_getMeshTriangleIndices;
		}

		static IntPtr n_GetMeshTriangleIndices (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.AugmentedFace __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedFace> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MeshTriangleIndices);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Nio.ShortBuffer MeshTriangleIndices {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedFace']/method[@name='getMeshTriangleIndices' and count(parameter)=0]"
			[Register ("getMeshTriangleIndices", "()Ljava/nio/ShortBuffer;", "GetGetMeshTriangleIndicesHandler")]
			get {
				const string __id = "getMeshTriangleIndices.()Ljava/nio/ShortBuffer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Nio.ShortBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMeshVertices;
#pragma warning disable 0169
		static Delegate GetGetMeshVerticesHandler ()
		{
			if (cb_getMeshVertices == null)
				cb_getMeshVertices = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMeshVertices);
			return cb_getMeshVertices;
		}

		static IntPtr n_GetMeshVertices (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.AugmentedFace __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedFace> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MeshVertices);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Nio.FloatBuffer MeshVertices {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedFace']/method[@name='getMeshVertices' and count(parameter)=0]"
			[Register ("getMeshVertices", "()Ljava/nio/FloatBuffer;", "GetGetMeshVerticesHandler")]
			get {
				const string __id = "getMeshVertices.()Ljava/nio/FloatBuffer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Google.AR.Core.AugmentedFace __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedFace> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TrackingState);
		}
#pragma warning restore 0169

		public override unsafe global::Google.AR.Core.TrackingState TrackingState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedFace']/method[@name='getTrackingState' and count(parameter)=0]"
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
			global::Google.AR.Core.AugmentedFace __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedFace> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.Pose p0 = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateAnchor (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedFace']/method[@name='createAnchor' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Pose']]"
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
			global::Google.AR.Core.AugmentedFace __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedFace> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedFace']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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

		static Delegate cb_getRegionPose_Lcom_google_ar_core_AugmentedFace_RegionType_;
#pragma warning disable 0169
		static Delegate GetGetRegionPose_Lcom_google_ar_core_AugmentedFace_RegionType_Handler ()
		{
			if (cb_getRegionPose_Lcom_google_ar_core_AugmentedFace_RegionType_ == null)
				cb_getRegionPose_Lcom_google_ar_core_AugmentedFace_RegionType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetRegionPose_Lcom_google_ar_core_AugmentedFace_RegionType_);
			return cb_getRegionPose_Lcom_google_ar_core_AugmentedFace_RegionType_;
		}

		static IntPtr n_GetRegionPose_Lcom_google_ar_core_AugmentedFace_RegionType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.AR.Core.AugmentedFace __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedFace> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.AugmentedFace.RegionType p0 = global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedFace.RegionType> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRegionPose (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedFace']/method[@name='getRegionPose' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.AugmentedFace.RegionType']]"
		[Register ("getRegionPose", "(Lcom/google/ar/core/AugmentedFace$RegionType;)Lcom/google/ar/core/Pose;", "GetGetRegionPose_Lcom_google_ar_core_AugmentedFace_RegionType_Handler")]
		public virtual unsafe global::Google.AR.Core.Pose GetRegionPose (global::Google.AR.Core.AugmentedFace.RegionType p0)
		{
			const string __id = "getRegionPose.(Lcom/google/ar/core/AugmentedFace$RegionType;)Lcom/google/ar/core/Pose;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Google.AR.Core.AugmentedFace __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedFace> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHashCode ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedFace']/method[@name='hashCode' and count(parameter)=0]"
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
