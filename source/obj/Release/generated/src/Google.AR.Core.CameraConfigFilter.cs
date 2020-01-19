using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraConfigFilter']"
	[global::Android.Runtime.Register ("com/google/ar/core/CameraConfigFilter", DoNotGenerateAcw=true)]
	public partial class CameraConfigFilter : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/CameraConfigFilter", typeof (CameraConfigFilter));
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

		protected CameraConfigFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraConfigFilter']/constructor[@name='CameraConfigFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe CameraConfigFilter ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraConfigFilter']/constructor[@name='CameraConfigFilter' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Session']]"
		[Register (".ctor", "(Lcom/google/ar/core/Session;)V", "")]
		public unsafe CameraConfigFilter (global::Google.AR.Core.Session p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/google/ar/core/Session;)V";

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

		static Delegate cb_setDepthSensorUsage_Ljava_util_EnumSet_;
#pragma warning disable 0169
		static Delegate GetSetDepthSensorUsage_Ljava_util_EnumSet_Handler ()
		{
			if (cb_setDepthSensorUsage_Ljava_util_EnumSet_ == null)
				cb_setDepthSensorUsage_Ljava_util_EnumSet_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDepthSensorUsage_Ljava_util_EnumSet_);
			return cb_setDepthSensorUsage_Ljava_util_EnumSet_;
		}

		static IntPtr n_SetDepthSensorUsage_Ljava_util_EnumSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.AR.Core.CameraConfigFilter __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.CameraConfigFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.EnumSet p0 = global::Java.Lang.Object.GetObject<global::Java.Util.EnumSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDepthSensorUsage (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraConfigFilter']/method[@name='setDepthSensorUsage' and count(parameter)=1 and parameter[1][@type='java.util.EnumSet&lt;com.google.ar.core.CameraConfig.DepthSensorUsage&gt;']]"
		[Register ("setDepthSensorUsage", "(Ljava/util/EnumSet;)Lcom/google/ar/core/CameraConfigFilter;", "GetSetDepthSensorUsage_Ljava_util_EnumSet_Handler")]
		public virtual unsafe global::Google.AR.Core.CameraConfigFilter SetDepthSensorUsage (global::Java.Util.EnumSet p0)
		{
			const string __id = "setDepthSensorUsage.(Ljava/util/EnumSet;)Lcom/google/ar/core/CameraConfigFilter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.CameraConfigFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setTargetFps_Ljava_util_EnumSet_;
#pragma warning disable 0169
		static Delegate GetSetTargetFps_Ljava_util_EnumSet_Handler ()
		{
			if (cb_setTargetFps_Ljava_util_EnumSet_ == null)
				cb_setTargetFps_Ljava_util_EnumSet_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTargetFps_Ljava_util_EnumSet_);
			return cb_setTargetFps_Ljava_util_EnumSet_;
		}

		static IntPtr n_SetTargetFps_Ljava_util_EnumSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.AR.Core.CameraConfigFilter __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.CameraConfigFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.EnumSet p0 = global::Java.Lang.Object.GetObject<global::Java.Util.EnumSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTargetFps (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraConfigFilter']/method[@name='setTargetFps' and count(parameter)=1 and parameter[1][@type='java.util.EnumSet&lt;com.google.ar.core.CameraConfig.TargetFps&gt;']]"
		[Register ("setTargetFps", "(Ljava/util/EnumSet;)Lcom/google/ar/core/CameraConfigFilter;", "GetSetTargetFps_Ljava_util_EnumSet_Handler")]
		public virtual unsafe global::Google.AR.Core.CameraConfigFilter SetTargetFps (global::Java.Util.EnumSet p0)
		{
			const string __id = "setTargetFps.(Ljava/util/EnumSet;)Lcom/google/ar/core/CameraConfigFilter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.CameraConfigFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
