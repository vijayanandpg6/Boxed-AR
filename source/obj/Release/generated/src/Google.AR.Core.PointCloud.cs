using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='PointCloud']"
	[global::Android.Runtime.Register ("com/google/ar/core/PointCloud", DoNotGenerateAcw=true)]
	public partial class PointCloud : global::Java.Lang.Object, global::Java.IO.ICloseable {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/PointCloud", typeof (PointCloud));
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

		protected PointCloud (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='PointCloud']/constructor[@name='PointCloud' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe PointCloud ()
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

		static Delegate cb_getIds;
#pragma warning disable 0169
		static Delegate GetGetIdsHandler ()
		{
			if (cb_getIds == null)
				cb_getIds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIds);
			return cb_getIds;
		}

		static IntPtr n_GetIds (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.PointCloud __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.PointCloud> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Ids);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Nio.IntBuffer Ids {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='PointCloud']/method[@name='getIds' and count(parameter)=0]"
			[Register ("getIds", "()Ljava/nio/IntBuffer;", "GetGetIdsHandler")]
			get {
				const string __id = "getIds.()Ljava/nio/IntBuffer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Nio.IntBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPoints;
#pragma warning disable 0169
		static Delegate GetGetPointsHandler ()
		{
			if (cb_getPoints == null)
				cb_getPoints = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPoints);
			return cb_getPoints;
		}

		static IntPtr n_GetPoints (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.PointCloud __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.PointCloud> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Points);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Nio.FloatBuffer Points {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='PointCloud']/method[@name='getPoints' and count(parameter)=0]"
			[Register ("getPoints", "()Ljava/nio/FloatBuffer;", "GetGetPointsHandler")]
			get {
				const string __id = "getPoints.()Ljava/nio/FloatBuffer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Google.AR.Core.PointCloud __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.PointCloud> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timestamp;
		}
#pragma warning restore 0169

		public virtual unsafe long Timestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='PointCloud']/method[@name='getTimestamp' and count(parameter)=0]"
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
			global::Google.AR.Core.PointCloud __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.PointCloud> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='PointCloud']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.PointCloud __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.PointCloud> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='PointCloud']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
