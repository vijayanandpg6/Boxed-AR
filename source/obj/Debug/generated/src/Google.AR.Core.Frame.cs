using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='Frame']"
	[global::Android.Runtime.Register ("com/google/ar/core/Frame", DoNotGenerateAcw=true)]
	public partial class Frame : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/Frame", typeof (Frame));
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

		protected Frame (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='Frame']/constructor[@name='Frame' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe Frame ()
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

		static Delegate cb_getAndroidCameraTimestamp;
#pragma warning disable 0169
		static Delegate GetGetAndroidCameraTimestampHandler ()
		{
			if (cb_getAndroidCameraTimestamp == null)
				cb_getAndroidCameraTimestamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetAndroidCameraTimestamp);
			return cb_getAndroidCameraTimestamp;
		}

		static long n_GetAndroidCameraTimestamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Frame __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AndroidCameraTimestamp;
		}
#pragma warning restore 0169

		public virtual unsafe long AndroidCameraTimestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Frame']/method[@name='getAndroidCameraTimestamp' and count(parameter)=0]"
			[Register ("getAndroidCameraTimestamp", "()J", "GetGetAndroidCameraTimestampHandler")]
			get {
				const string __id = "getAndroidCameraTimestamp.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getAndroidSensorPose;
#pragma warning disable 0169
		static Delegate GetGetAndroidSensorPoseHandler ()
		{
			if (cb_getAndroidSensorPose == null)
				cb_getAndroidSensorPose = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAndroidSensorPose);
			return cb_getAndroidSensorPose;
		}

		static IntPtr n_GetAndroidSensorPose (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Frame __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AndroidSensorPose);
		}
#pragma warning restore 0169

		public virtual unsafe global::Google.AR.Core.Pose AndroidSensorPose {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Frame']/method[@name='getAndroidSensorPose' and count(parameter)=0]"
			[Register ("getAndroidSensorPose", "()Lcom/google/ar/core/Pose;", "GetGetAndroidSensorPoseHandler")]
			get {
				const string __id = "getAndroidSensorPose.()Lcom/google/ar/core/Pose;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCamera;
#pragma warning disable 0169
		static Delegate GetGetCameraHandler ()
		{
			if (cb_getCamera == null)
				cb_getCamera = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCamera);
			return cb_getCamera;
		}

		static IntPtr n_GetCamera (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Frame __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Camera);
		}
#pragma warning restore 0169

		public virtual unsafe global::Google.AR.Core.Camera Camera {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Frame']/method[@name='getCamera' and count(parameter)=0]"
			[Register ("getCamera", "()Lcom/google/ar/core/Camera;", "GetGetCameraHandler")]
			get {
				const string __id = "getCamera.()Lcom/google/ar/core/Camera;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Camera> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hasDisplayGeometryChanged;
#pragma warning disable 0169
		static Delegate GetHasDisplayGeometryChangedHandler ()
		{
			if (cb_hasDisplayGeometryChanged == null)
				cb_hasDisplayGeometryChanged = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasDisplayGeometryChanged);
			return cb_hasDisplayGeometryChanged;
		}

		static bool n_HasDisplayGeometryChanged (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Frame __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasDisplayGeometryChanged;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasDisplayGeometryChanged {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Frame']/method[@name='hasDisplayGeometryChanged' and count(parameter)=0]"
			[Register ("hasDisplayGeometryChanged", "()Z", "GetHasDisplayGeometryChangedHandler")]
			get {
				const string __id = "hasDisplayGeometryChanged.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getImageMetadata;
#pragma warning disable 0169
		static Delegate GetGetImageMetadataHandler ()
		{
			if (cb_getImageMetadata == null)
				cb_getImageMetadata = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageMetadata);
			return cb_getImageMetadata;
		}

		static IntPtr n_GetImageMetadata (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Frame __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ImageMetadata);
		}
#pragma warning restore 0169

		public virtual unsafe global::Google.AR.Core.ImageMetadata ImageMetadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Frame']/method[@name='getImageMetadata' and count(parameter)=0]"
			[Register ("getImageMetadata", "()Lcom/google/ar/core/ImageMetadata;", "GetGetImageMetadataHandler")]
			get {
				const string __id = "getImageMetadata.()Lcom/google/ar/core/ImageMetadata;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ImageMetadata> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLightEstimate;
#pragma warning disable 0169
		static Delegate GetGetLightEstimateHandler ()
		{
			if (cb_getLightEstimate == null)
				cb_getLightEstimate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLightEstimate);
			return cb_getLightEstimate;
		}

		static IntPtr n_GetLightEstimate (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Frame __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LightEstimate);
		}
#pragma warning restore 0169

		public virtual unsafe global::Google.AR.Core.LightEstimate LightEstimate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Frame']/method[@name='getLightEstimate' and count(parameter)=0]"
			[Register ("getLightEstimate", "()Lcom/google/ar/core/LightEstimate;", "GetGetLightEstimateHandler")]
			get {
				const string __id = "getLightEstimate.()Lcom/google/ar/core/LightEstimate;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.LightEstimate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTimestamp;
#pragma warning disable 0169
		static Delegate GetGetTimestampHandler ()
		{
			if (cb_getTimestamp == null)
				cb_getTimestamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTimestamp);
			return cb_getTimestamp;
		}

		static long n_GetTimestamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Frame __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timestamp;
		}
#pragma warning restore 0169

		public virtual unsafe long Timestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Frame']/method[@name='getTimestamp' and count(parameter)=0]"
			[Register ("getTimestamp", "()J", "GetGetTimestampHandler")]
			get {
				const string __id = "getTimestamp.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getUpdatedAnchors;
#pragma warning disable 0169
		static Delegate GetGetUpdatedAnchorsHandler ()
		{
			if (cb_getUpdatedAnchors == null)
				cb_getUpdatedAnchors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUpdatedAnchors);
			return cb_getUpdatedAnchors;
		}

		static IntPtr n_GetUpdatedAnchors (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Frame __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Google.AR.Core.Anchor>.ToLocalJniHandle (__this.UpdatedAnchors);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.ICollection<global::Google.AR.Core.Anchor> UpdatedAnchors {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Frame']/method[@name='getUpdatedAnchors' and count(parameter)=0]"
			[Register ("getUpdatedAnchors", "()Ljava/util/Collection;", "GetGetUpdatedAnchorsHandler")]
			get {
				const string __id = "getUpdatedAnchors.()Ljava/util/Collection;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaCollection<global::Google.AR.Core.Anchor>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_acquireCameraImage;
#pragma warning disable 0169
		static Delegate GetAcquireCameraImageHandler ()
		{
			if (cb_acquireCameraImage == null)
				cb_acquireCameraImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AcquireCameraImage);
			return cb_acquireCameraImage;
		}

		static IntPtr n_AcquireCameraImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Frame __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AcquireCameraImage ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Frame']/method[@name='acquireCameraImage' and count(parameter)=0]"
		[Register ("acquireCameraImage", "()Landroid/media/Image;", "GetAcquireCameraImageHandler")]
		public virtual unsafe global::Android.Media.Image AcquireCameraImage ()
		{
			const string __id = "acquireCameraImage.()Landroid/media/Image;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.Media.Image> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_acquirePointCloud;
#pragma warning disable 0169
		static Delegate GetAcquirePointCloudHandler ()
		{
			if (cb_acquirePointCloud == null)
				cb_acquirePointCloud = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AcquirePointCloud);
			return cb_acquirePointCloud;
		}

		static IntPtr n_AcquirePointCloud (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Frame __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AcquirePointCloud ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Frame']/method[@name='acquirePointCloud' and count(parameter)=0]"
		[Register ("acquirePointCloud", "()Lcom/google/ar/core/PointCloud;", "GetAcquirePointCloudHandler")]
		public virtual unsafe global::Google.AR.Core.PointCloud AcquirePointCloud ()
		{
			const string __id = "acquirePointCloud.()Lcom/google/ar/core/PointCloud;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.PointCloud> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getUpdatedTrackables_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetGetUpdatedTrackables_Ljava_lang_Class_Handler ()
		{
			if (cb_getUpdatedTrackables_Ljava_lang_Class_ == null)
				cb_getUpdatedTrackables_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetUpdatedTrackables_Ljava_lang_Class_);
			return cb_getUpdatedTrackables_Ljava_lang_Class_;
		}

		static IntPtr n_GetUpdatedTrackables_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.AR.Core.Frame __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaCollection.ToLocalJniHandle (__this.GetUpdatedTrackables (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Frame']/method[@name='getUpdatedTrackables' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("getUpdatedTrackables", "(Ljava/lang/Class;)Ljava/util/Collection;", "GetGetUpdatedTrackables_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.google.ar.core.Trackable"})]
		public virtual unsafe global::System.Collections.ICollection GetUpdatedTrackables (global::Java.Lang.Class p0)
		{
			const string __id = "getUpdatedTrackables.(Ljava/lang/Class;)Ljava/util/Collection;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaCollection.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_hitTest_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetHitTest_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_hitTest_Landroid_view_MotionEvent_ == null)
				cb_hitTest_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_HitTest_Landroid_view_MotionEvent_);
			return cb_hitTest_Landroid_view_MotionEvent_;
		}

		static IntPtr n_HitTest_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.AR.Core.Frame __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Google.AR.Core.HitResult>.ToLocalJniHandle (__this.HitTest (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Frame']/method[@name='hitTest' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("hitTest", "(Landroid/view/MotionEvent;)Ljava/util/List;", "GetHitTest_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Google.AR.Core.HitResult> HitTest (global::Android.Views.MotionEvent p0)
		{
			const string __id = "hitTest.(Landroid/view/MotionEvent;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Google.AR.Core.HitResult>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_hitTest_FF;
#pragma warning disable 0169
		static Delegate GetHitTest_FFHandler ()
		{
			if (cb_hitTest_FF == null)
				cb_hitTest_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, IntPtr>) n_HitTest_FF);
			return cb_hitTest_FF;
		}

		static IntPtr n_HitTest_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Google.AR.Core.Frame __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Google.AR.Core.HitResult>.ToLocalJniHandle (__this.HitTest (p0, p1));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Frame']/method[@name='hitTest' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("hitTest", "(FF)Ljava/util/List;", "GetHitTest_FFHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Google.AR.Core.HitResult> HitTest (float p0, float p1)
		{
			const string __id = "hitTest.(FF)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Google.AR.Core.HitResult>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_hitTest_arrayFIarrayFI;
#pragma warning disable 0169
		static Delegate GetHitTest_arrayFIarrayFIHandler ()
		{
			if (cb_hitTest_arrayFIarrayFI == null)
				cb_hitTest_arrayFIarrayFI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, int, IntPtr>) n_HitTest_arrayFIarrayFI);
			return cb_hitTest_arrayFIarrayFI;
		}

		static IntPtr n_HitTest_arrayFIarrayFI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, int p3)
		{
			global::Google.AR.Core.Frame __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			float[] p2 = (float[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (float));
			IntPtr __ret = global::Android.Runtime.JavaList<global::Google.AR.Core.HitResult>.ToLocalJniHandle (__this.HitTest (p0, p1, p2, p3));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Frame']/method[@name='hitTest' and count(parameter)=4 and parameter[1][@type='float[]'] and parameter[2][@type='int'] and parameter[3][@type='float[]'] and parameter[4][@type='int']]"
		[Register ("hitTest", "([FI[FI)Ljava/util/List;", "GetHitTest_arrayFIarrayFIHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Google.AR.Core.HitResult> HitTest (float[] p0, int p1, float[] p2, int p3)
		{
			const string __id = "hitTest.([FI[FI)Ljava/util/List;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Google.AR.Core.HitResult>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_transformCoordinates2d_Lcom_google_ar_core_Coordinates2d_arrayFLcom_google_ar_core_Coordinates2d_arrayF;
#pragma warning disable 0169
		static Delegate GetTransformCoordinates2d_Lcom_google_ar_core_Coordinates2d_arrayFLcom_google_ar_core_Coordinates2d_arrayFHandler ()
		{
			if (cb_transformCoordinates2d_Lcom_google_ar_core_Coordinates2d_arrayFLcom_google_ar_core_Coordinates2d_arrayF == null)
				cb_transformCoordinates2d_Lcom_google_ar_core_Coordinates2d_arrayFLcom_google_ar_core_Coordinates2d_arrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_TransformCoordinates2d_Lcom_google_ar_core_Coordinates2d_arrayFLcom_google_ar_core_Coordinates2d_arrayF);
			return cb_transformCoordinates2d_Lcom_google_ar_core_Coordinates2d_arrayFLcom_google_ar_core_Coordinates2d_arrayF;
		}

		static void n_TransformCoordinates2d_Lcom_google_ar_core_Coordinates2d_arrayFLcom_google_ar_core_Coordinates2d_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Google.AR.Core.Frame __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.Coordinates2d p0 = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Coordinates2d> (native_p0, JniHandleOwnership.DoNotTransfer);
			float[] p1 = (float[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (float));
			global::Google.AR.Core.Coordinates2d p2 = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Coordinates2d> (native_p2, JniHandleOwnership.DoNotTransfer);
			float[] p3 = (float[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.TransformCoordinates2d (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Frame']/method[@name='transformCoordinates2d' and count(parameter)=4 and parameter[1][@type='com.google.ar.core.Coordinates2d'] and parameter[2][@type='float[]'] and parameter[3][@type='com.google.ar.core.Coordinates2d'] and parameter[4][@type='float[]']]"
		[Register ("transformCoordinates2d", "(Lcom/google/ar/core/Coordinates2d;[FLcom/google/ar/core/Coordinates2d;[F)V", "GetTransformCoordinates2d_Lcom_google_ar_core_Coordinates2d_arrayFLcom_google_ar_core_Coordinates2d_arrayFHandler")]
		public virtual unsafe void TransformCoordinates2d (global::Google.AR.Core.Coordinates2d p0, float[] p1, global::Google.AR.Core.Coordinates2d p2, float[] p3)
		{
			const string __id = "transformCoordinates2d.(Lcom/google/ar/core/Coordinates2d;[FLcom/google/ar/core/Coordinates2d;[F)V";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (native_p3);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static Delegate cb_transformCoordinates2d_Lcom_google_ar_core_Coordinates2d_Ljava_nio_FloatBuffer_Lcom_google_ar_core_Coordinates2d_Ljava_nio_FloatBuffer_;
#pragma warning disable 0169
		static Delegate GetTransformCoordinates2d_Lcom_google_ar_core_Coordinates2d_Ljava_nio_FloatBuffer_Lcom_google_ar_core_Coordinates2d_Ljava_nio_FloatBuffer_Handler ()
		{
			if (cb_transformCoordinates2d_Lcom_google_ar_core_Coordinates2d_Ljava_nio_FloatBuffer_Lcom_google_ar_core_Coordinates2d_Ljava_nio_FloatBuffer_ == null)
				cb_transformCoordinates2d_Lcom_google_ar_core_Coordinates2d_Ljava_nio_FloatBuffer_Lcom_google_ar_core_Coordinates2d_Ljava_nio_FloatBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_TransformCoordinates2d_Lcom_google_ar_core_Coordinates2d_Ljava_nio_FloatBuffer_Lcom_google_ar_core_Coordinates2d_Ljava_nio_FloatBuffer_);
			return cb_transformCoordinates2d_Lcom_google_ar_core_Coordinates2d_Ljava_nio_FloatBuffer_Lcom_google_ar_core_Coordinates2d_Ljava_nio_FloatBuffer_;
		}

		static void n_TransformCoordinates2d_Lcom_google_ar_core_Coordinates2d_Ljava_nio_FloatBuffer_Lcom_google_ar_core_Coordinates2d_Ljava_nio_FloatBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Google.AR.Core.Frame __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.Coordinates2d p0 = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Coordinates2d> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.FloatBuffer p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.Coordinates2d p2 = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Coordinates2d> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.FloatBuffer p3 = global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.TransformCoordinates2d (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Frame']/method[@name='transformCoordinates2d' and count(parameter)=4 and parameter[1][@type='com.google.ar.core.Coordinates2d'] and parameter[2][@type='java.nio.FloatBuffer'] and parameter[3][@type='com.google.ar.core.Coordinates2d'] and parameter[4][@type='java.nio.FloatBuffer']]"
		[Register ("transformCoordinates2d", "(Lcom/google/ar/core/Coordinates2d;Ljava/nio/FloatBuffer;Lcom/google/ar/core/Coordinates2d;Ljava/nio/FloatBuffer;)V", "GetTransformCoordinates2d_Lcom_google_ar_core_Coordinates2d_Ljava_nio_FloatBuffer_Lcom_google_ar_core_Coordinates2d_Ljava_nio_FloatBuffer_Handler")]
		public virtual unsafe void TransformCoordinates2d (global::Google.AR.Core.Coordinates2d p0, global::Java.Nio.FloatBuffer p1, global::Google.AR.Core.Coordinates2d p2, global::Java.Nio.FloatBuffer p3)
		{
			const string __id = "transformCoordinates2d.(Lcom/google/ar/core/Coordinates2d;Ljava/nio/FloatBuffer;Lcom/google/ar/core/Coordinates2d;Ljava/nio/FloatBuffer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_transformDisplayUvCoords_Ljava_nio_FloatBuffer_Ljava_nio_FloatBuffer_;
#pragma warning disable 0169
		static Delegate GetTransformDisplayUvCoords_Ljava_nio_FloatBuffer_Ljava_nio_FloatBuffer_Handler ()
		{
			if (cb_transformDisplayUvCoords_Ljava_nio_FloatBuffer_Ljava_nio_FloatBuffer_ == null)
				cb_transformDisplayUvCoords_Ljava_nio_FloatBuffer_Ljava_nio_FloatBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_TransformDisplayUvCoords_Ljava_nio_FloatBuffer_Ljava_nio_FloatBuffer_);
			return cb_transformDisplayUvCoords_Ljava_nio_FloatBuffer_Ljava_nio_FloatBuffer_;
		}

		static void n_TransformDisplayUvCoords_Ljava_nio_FloatBuffer_Ljava_nio_FloatBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Google.AR.Core.Frame __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.FloatBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.FloatBuffer p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.TransformDisplayUvCoords (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Frame']/method[@name='transformDisplayUvCoords' and count(parameter)=2 and parameter[1][@type='java.nio.FloatBuffer'] and parameter[2][@type='java.nio.FloatBuffer']]"
		[Obsolete (@"deprecated")]
		[Register ("transformDisplayUvCoords", "(Ljava/nio/FloatBuffer;Ljava/nio/FloatBuffer;)V", "GetTransformDisplayUvCoords_Ljava_nio_FloatBuffer_Ljava_nio_FloatBuffer_Handler")]
		public virtual unsafe void TransformDisplayUvCoords (global::Java.Nio.FloatBuffer p0, global::Java.Nio.FloatBuffer p1)
		{
			const string __id = "transformDisplayUvCoords.(Ljava/nio/FloatBuffer;Ljava/nio/FloatBuffer;)V";
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
