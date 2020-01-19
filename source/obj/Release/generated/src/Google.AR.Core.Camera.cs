using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='Camera']"
	[global::Android.Runtime.Register ("com/google/ar/core/Camera", DoNotGenerateAcw=true)]
	public partial class Camera : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/Camera", typeof (Camera));
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

		protected Camera (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='Camera']/constructor[@name='Camera' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe Camera ()
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

		static Delegate cb_getDisplayOrientedPose;
#pragma warning disable 0169
		static Delegate GetGetDisplayOrientedPoseHandler ()
		{
			if (cb_getDisplayOrientedPose == null)
				cb_getDisplayOrientedPose = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplayOrientedPose);
			return cb_getDisplayOrientedPose;
		}

		static IntPtr n_GetDisplayOrientedPose (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Camera __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Camera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DisplayOrientedPose);
		}
#pragma warning restore 0169

		public virtual unsafe global::Google.AR.Core.Pose DisplayOrientedPose {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Camera']/method[@name='getDisplayOrientedPose' and count(parameter)=0]"
			[Register ("getDisplayOrientedPose", "()Lcom/google/ar/core/Pose;", "GetGetDisplayOrientedPoseHandler")]
			get {
				const string __id = "getDisplayOrientedPose.()Lcom/google/ar/core/Pose;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getImageIntrinsics;
#pragma warning disable 0169
		static Delegate GetGetImageIntrinsicsHandler ()
		{
			if (cb_getImageIntrinsics == null)
				cb_getImageIntrinsics = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageIntrinsics);
			return cb_getImageIntrinsics;
		}

		static IntPtr n_GetImageIntrinsics (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Camera __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Camera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ImageIntrinsics);
		}
#pragma warning restore 0169

		public virtual unsafe global::Google.AR.Core.CameraIntrinsics ImageIntrinsics {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Camera']/method[@name='getImageIntrinsics' and count(parameter)=0]"
			[Register ("getImageIntrinsics", "()Lcom/google/ar/core/CameraIntrinsics;", "GetGetImageIntrinsicsHandler")]
			get {
				const string __id = "getImageIntrinsics.()Lcom/google/ar/core/CameraIntrinsics;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.CameraIntrinsics> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPose;
#pragma warning disable 0169
		static Delegate GetGetPoseHandler ()
		{
			if (cb_getPose == null)
				cb_getPose = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPose);
			return cb_getPose;
		}

		static IntPtr n_GetPose (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Camera __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Camera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Pose);
		}
#pragma warning restore 0169

		public virtual unsafe global::Google.AR.Core.Pose Pose {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Camera']/method[@name='getPose' and count(parameter)=0]"
			[Register ("getPose", "()Lcom/google/ar/core/Pose;", "GetGetPoseHandler")]
			get {
				const string __id = "getPose.()Lcom/google/ar/core/Pose;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextureIntrinsics;
#pragma warning disable 0169
		static Delegate GetGetTextureIntrinsicsHandler ()
		{
			if (cb_getTextureIntrinsics == null)
				cb_getTextureIntrinsics = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextureIntrinsics);
			return cb_getTextureIntrinsics;
		}

		static IntPtr n_GetTextureIntrinsics (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Camera __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Camera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextureIntrinsics);
		}
#pragma warning restore 0169

		public virtual unsafe global::Google.AR.Core.CameraIntrinsics TextureIntrinsics {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Camera']/method[@name='getTextureIntrinsics' and count(parameter)=0]"
			[Register ("getTextureIntrinsics", "()Lcom/google/ar/core/CameraIntrinsics;", "GetGetTextureIntrinsicsHandler")]
			get {
				const string __id = "getTextureIntrinsics.()Lcom/google/ar/core/CameraIntrinsics;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.CameraIntrinsics> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTrackingFailureReason;
#pragma warning disable 0169
		static Delegate GetGetTrackingFailureReasonHandler ()
		{
			if (cb_getTrackingFailureReason == null)
				cb_getTrackingFailureReason = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrackingFailureReason);
			return cb_getTrackingFailureReason;
		}

		static IntPtr n_GetTrackingFailureReason (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Camera __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Camera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TrackingFailureReason);
		}
#pragma warning restore 0169

		public virtual unsafe global::Google.AR.Core.TrackingFailureReason TrackingFailureReason {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Camera']/method[@name='getTrackingFailureReason' and count(parameter)=0]"
			[Register ("getTrackingFailureReason", "()Lcom/google/ar/core/TrackingFailureReason;", "GetGetTrackingFailureReasonHandler")]
			get {
				const string __id = "getTrackingFailureReason.()Lcom/google/ar/core/TrackingFailureReason;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.TrackingFailureReason> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Google.AR.Core.Camera __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Camera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TrackingState);
		}
#pragma warning restore 0169

		public virtual unsafe global::Google.AR.Core.TrackingState TrackingState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Camera']/method[@name='getTrackingState' and count(parameter)=0]"
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

		static Delegate cb_getProjectionMatrix_arrayFIFF;
#pragma warning disable 0169
		static Delegate GetGetProjectionMatrix_arrayFIFFHandler ()
		{
			if (cb_getProjectionMatrix_arrayFIFF == null)
				cb_getProjectionMatrix_arrayFIFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, float, float>) n_GetProjectionMatrix_arrayFIFF);
			return cb_getProjectionMatrix_arrayFIFF;
		}

		static void n_GetProjectionMatrix_arrayFIFF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, float p2, float p3)
		{
			global::Google.AR.Core.Camera __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Camera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.GetProjectionMatrix (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Camera']/method[@name='getProjectionMatrix' and count(parameter)=4 and parameter[1][@type='float[]'] and parameter[2][@type='int'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("getProjectionMatrix", "([FIFF)V", "GetGetProjectionMatrix_arrayFIFFHandler")]
		public virtual unsafe void GetProjectionMatrix (float[] p0, int p1, float p2, float p3)
		{
			const string __id = "getProjectionMatrix.([FIFF)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_getViewMatrix_arrayFI;
#pragma warning disable 0169
		static Delegate GetGetViewMatrix_arrayFIHandler ()
		{
			if (cb_getViewMatrix_arrayFI == null)
				cb_getViewMatrix_arrayFI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_GetViewMatrix_arrayFI);
			return cb_getViewMatrix_arrayFI;
		}

		static void n_GetViewMatrix_arrayFI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Google.AR.Core.Camera __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Camera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.GetViewMatrix (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Camera']/method[@name='getViewMatrix' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='int']]"
		[Register ("getViewMatrix", "([FI)V", "GetGetViewMatrix_arrayFIHandler")]
		public virtual unsafe void GetViewMatrix (float[] p0, int p1)
		{
			const string __id = "getViewMatrix.([FI)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
