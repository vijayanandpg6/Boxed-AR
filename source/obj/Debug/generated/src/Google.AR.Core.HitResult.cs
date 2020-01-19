using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='HitResult']"
	[global::Android.Runtime.Register ("com/google/ar/core/HitResult", DoNotGenerateAcw=true)]
	public partial class HitResult : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/HitResult", typeof (HitResult));
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

		protected HitResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='HitResult']/constructor[@name='HitResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe HitResult ()
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

		static Delegate cb_getDistance;
#pragma warning disable 0169
		static Delegate GetGetDistanceHandler ()
		{
			if (cb_getDistance == null)
				cb_getDistance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetDistance);
			return cb_getDistance;
		}

		static float n_GetDistance (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.HitResult __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.HitResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Distance;
		}
#pragma warning restore 0169

		public virtual unsafe float Distance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='HitResult']/method[@name='getDistance' and count(parameter)=0]"
			[Register ("getDistance", "()F", "GetGetDistanceHandler")]
			get {
				const string __id = "getDistance.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getHitPose;
#pragma warning disable 0169
		static Delegate GetGetHitPoseHandler ()
		{
			if (cb_getHitPose == null)
				cb_getHitPose = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHitPose);
			return cb_getHitPose;
		}

		static IntPtr n_GetHitPose (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.HitResult __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.HitResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HitPose);
		}
#pragma warning restore 0169

		public virtual unsafe global::Google.AR.Core.Pose HitPose {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='HitResult']/method[@name='getHitPose' and count(parameter)=0]"
			[Register ("getHitPose", "()Lcom/google/ar/core/Pose;", "GetGetHitPoseHandler")]
			get {
				const string __id = "getHitPose.()Lcom/google/ar/core/Pose;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTrackable;
#pragma warning disable 0169
		static Delegate GetGetTrackableHandler ()
		{
			if (cb_getTrackable == null)
				cb_getTrackable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrackable);
			return cb_getTrackable;
		}

		static IntPtr n_GetTrackable (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.HitResult __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.HitResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Trackable);
		}
#pragma warning restore 0169

		public virtual unsafe global::Google.AR.Core.ITrackable Trackable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='HitResult']/method[@name='getTrackable' and count(parameter)=0]"
			[Register ("getTrackable", "()Lcom/google/ar/core/Trackable;", "GetGetTrackableHandler")]
			get {
				const string __id = "getTrackable.()Lcom/google/ar/core/Trackable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ITrackable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_createAnchor;
#pragma warning disable 0169
		static Delegate GetCreateAnchorHandler ()
		{
			if (cb_createAnchor == null)
				cb_createAnchor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateAnchor);
			return cb_createAnchor;
		}

		static IntPtr n_CreateAnchor (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.HitResult __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.HitResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateAnchor ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='HitResult']/method[@name='createAnchor' and count(parameter)=0]"
		[Register ("createAnchor", "()Lcom/google/ar/core/Anchor;", "GetCreateAnchorHandler")]
		public virtual unsafe global::Google.AR.Core.Anchor CreateAnchor ()
		{
			const string __id = "createAnchor.()Lcom/google/ar/core/Anchor;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
