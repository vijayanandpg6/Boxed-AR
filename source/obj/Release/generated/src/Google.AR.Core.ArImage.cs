using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArImage']"
	[global::Android.Runtime.Register ("com/google/ar/core/ArImage", DoNotGenerateAcw=true)]
	public partial class ArImage : global::Android.Media.Image {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/ArImage", typeof (ArImage));
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

		protected ArImage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArImage']/constructor[@name='ArImage' and count(parameter)=2 and parameter[1][@type='com.google.ar.core.Session'] and parameter[2][@type='long']]"
		[Register (".ctor", "(Lcom/google/ar/core/Session;J)V", "")]
		public unsafe ArImage (global::Google.AR.Core.Session p0, long p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/google/ar/core/Session;J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getFormat;
#pragma warning disable 0169
		static Delegate GetGetFormatHandler ()
		{
			if (cb_getFormat == null)
				cb_getFormat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFormat);
			return cb_getFormat;
		}

		static int n_GetFormat (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.ArImage __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return (int) __this.Format;
		}
#pragma warning restore 0169

		public override unsafe global::Android.Graphics.ImageFormatType Format {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArImage']/method[@name='getFormat' and count(parameter)=0]"
			[Register ("getFormat", "()I", "GetGetFormatHandler")]
			get {
				const string __id = "getFormat.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return (global::Android.Graphics.ImageFormatType) __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.ArImage __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		public override unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArImage']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				const string __id = "getHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
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
			global::Google.AR.Core.ArImage __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timestamp;
		}
#pragma warning restore 0169

		public override unsafe long Timestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArImage']/method[@name='getTimestamp' and count(parameter)=0]"
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

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidth);
			return cb_getWidth;
		}

		static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.ArImage __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		public override unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArImage']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				const string __id = "getWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
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
			global::Google.AR.Core.ArImage __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArImage']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public override unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getPlanes;
#pragma warning disable 0169
		static Delegate GetGetPlanesHandler ()
		{
			if (cb_getPlanes == null)
				cb_getPlanes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlanes);
			return cb_getPlanes;
		}

		static IntPtr n_GetPlanes (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.ArImage __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPlanes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArImage']/method[@name='getPlanes' and count(parameter)=0]"
		[Register ("getPlanes", "()[Landroid/media/Image$Plane;", "GetGetPlanesHandler")]
		public override unsafe global::Android.Media.Image.Plane[] GetPlanes ()
		{
			const string __id = "getPlanes.()[Landroid/media/Image$Plane;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Android.Media.Image.Plane[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Android.Media.Image.Plane));
			} finally {
			}
		}

		static Delegate cb_setTimestamp_J;
#pragma warning disable 0169
		static Delegate GetSetTimestamp_JHandler ()
		{
			if (cb_setTimestamp_J == null)
				cb_setTimestamp_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetTimestamp_J);
			return cb_setTimestamp_J;
		}

		static void n_SetTimestamp_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Google.AR.Core.ArImage __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTimestamp (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArImage']/method[@name='setTimestamp' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setTimestamp", "(J)V", "GetSetTimestamp_JHandler")]
		public virtual unsafe void SetTimestamp (long p0)
		{
			const string __id = "setTimestamp.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
