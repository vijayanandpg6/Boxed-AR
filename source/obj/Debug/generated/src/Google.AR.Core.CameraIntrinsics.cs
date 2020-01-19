using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraIntrinsics']"
	[global::Android.Runtime.Register ("com/google/ar/core/CameraIntrinsics", DoNotGenerateAcw=true)]
	public partial class CameraIntrinsics : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/CameraIntrinsics", typeof (CameraIntrinsics));
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

		protected CameraIntrinsics (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraIntrinsics']/constructor[@name='CameraIntrinsics' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe CameraIntrinsics ()
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

		static Delegate cb_getFocalLength;
#pragma warning disable 0169
		static Delegate GetGetFocalLengthHandler ()
		{
			if (cb_getFocalLength == null)
				cb_getFocalLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFocalLength);
			return cb_getFocalLength;
		}

		static IntPtr n_GetFocalLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.CameraIntrinsics __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.CameraIntrinsics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetFocalLength ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraIntrinsics']/method[@name='getFocalLength' and count(parameter)=0]"
		[Register ("getFocalLength", "()[F", "GetGetFocalLengthHandler")]
		public virtual unsafe float[] GetFocalLength ()
		{
			const string __id = "getFocalLength.()[F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_getFocalLength_arrayFI;
#pragma warning disable 0169
		static Delegate GetGetFocalLength_arrayFIHandler ()
		{
			if (cb_getFocalLength_arrayFI == null)
				cb_getFocalLength_arrayFI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_GetFocalLength_arrayFI);
			return cb_getFocalLength_arrayFI;
		}

		static void n_GetFocalLength_arrayFI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Google.AR.Core.CameraIntrinsics __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.CameraIntrinsics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.GetFocalLength (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraIntrinsics']/method[@name='getFocalLength' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='int']]"
		[Register ("getFocalLength", "([FI)V", "GetGetFocalLength_arrayFIHandler")]
		public virtual unsafe void GetFocalLength (float[] p0, int p1)
		{
			const string __id = "getFocalLength.([FI)V";
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

		static Delegate cb_getImageDimensions;
#pragma warning disable 0169
		static Delegate GetGetImageDimensionsHandler ()
		{
			if (cb_getImageDimensions == null)
				cb_getImageDimensions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageDimensions);
			return cb_getImageDimensions;
		}

		static IntPtr n_GetImageDimensions (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.CameraIntrinsics __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.CameraIntrinsics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetImageDimensions ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraIntrinsics']/method[@name='getImageDimensions' and count(parameter)=0]"
		[Register ("getImageDimensions", "()[I", "GetGetImageDimensionsHandler")]
		public virtual unsafe int[] GetImageDimensions ()
		{
			const string __id = "getImageDimensions.()[I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_getImageDimensions_arrayII;
#pragma warning disable 0169
		static Delegate GetGetImageDimensions_arrayIIHandler ()
		{
			if (cb_getImageDimensions_arrayII == null)
				cb_getImageDimensions_arrayII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_GetImageDimensions_arrayII);
			return cb_getImageDimensions_arrayII;
		}

		static void n_GetImageDimensions_arrayII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Google.AR.Core.CameraIntrinsics __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.CameraIntrinsics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.GetImageDimensions (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraIntrinsics']/method[@name='getImageDimensions' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("getImageDimensions", "([II)V", "GetGetImageDimensions_arrayIIHandler")]
		public virtual unsafe void GetImageDimensions (int[] p0, int p1)
		{
			const string __id = "getImageDimensions.([II)V";
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

		static Delegate cb_getPrincipalPoint;
#pragma warning disable 0169
		static Delegate GetGetPrincipalPointHandler ()
		{
			if (cb_getPrincipalPoint == null)
				cb_getPrincipalPoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrincipalPoint);
			return cb_getPrincipalPoint;
		}

		static IntPtr n_GetPrincipalPoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.CameraIntrinsics __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.CameraIntrinsics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPrincipalPoint ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraIntrinsics']/method[@name='getPrincipalPoint' and count(parameter)=0]"
		[Register ("getPrincipalPoint", "()[F", "GetGetPrincipalPointHandler")]
		public virtual unsafe float[] GetPrincipalPoint ()
		{
			const string __id = "getPrincipalPoint.()[F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_getPrincipalPoint_arrayFI;
#pragma warning disable 0169
		static Delegate GetGetPrincipalPoint_arrayFIHandler ()
		{
			if (cb_getPrincipalPoint_arrayFI == null)
				cb_getPrincipalPoint_arrayFI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_GetPrincipalPoint_arrayFI);
			return cb_getPrincipalPoint_arrayFI;
		}

		static void n_GetPrincipalPoint_arrayFI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Google.AR.Core.CameraIntrinsics __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.CameraIntrinsics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.GetPrincipalPoint (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='CameraIntrinsics']/method[@name='getPrincipalPoint' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='int']]"
		[Register ("getPrincipalPoint", "([FI)V", "GetGetPrincipalPoint_arrayFIHandler")]
		public virtual unsafe void GetPrincipalPoint (float[] p0, int p1)
		{
			const string __id = "getPrincipalPoint.([FI)V";
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
