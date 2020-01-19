using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']"
	[global::Android.Runtime.Register ("com/google/ar/core/Pose", DoNotGenerateAcw=true)]
	public partial class Pose : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/field[@name='IDENTITY']"
		[Register ("IDENTITY")]
		public static global::Google.AR.Core.Pose Identity {
			get {
				const string __id = "IDENTITY.Lcom/google/ar/core/Pose;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/Pose", typeof (Pose));
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

		protected Pose (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/constructor[@name='Pose' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='float[]']]"
		[Register (".ctor", "([F[F)V", "")]
		public unsafe Pose (float[] p0, float[] p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([F[F)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_compose_Lcom_google_ar_core_Pose_;
#pragma warning disable 0169
		static Delegate GetCompose_Lcom_google_ar_core_Pose_Handler ()
		{
			if (cb_compose_Lcom_google_ar_core_Pose_ == null)
				cb_compose_Lcom_google_ar_core_Pose_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Compose_Lcom_google_ar_core_Pose_);
			return cb_compose_Lcom_google_ar_core_Pose_;
		}

		static IntPtr n_Compose_Lcom_google_ar_core_Pose_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.Pose p0 = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Compose (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='compose' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Pose']]"
		[Register ("compose", "(Lcom/google/ar/core/Pose;)Lcom/google/ar/core/Pose;", "GetCompose_Lcom_google_ar_core_Pose_Handler")]
		public virtual unsafe global::Google.AR.Core.Pose Compose (global::Google.AR.Core.Pose p0)
		{
			const string __id = "compose.(Lcom/google/ar/core/Pose;)Lcom/google/ar/core/Pose;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_extractRotation;
#pragma warning disable 0169
		static Delegate GetExtractRotationHandler ()
		{
			if (cb_extractRotation == null)
				cb_extractRotation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ExtractRotation);
			return cb_extractRotation;
		}

		static IntPtr n_ExtractRotation (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExtractRotation ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='extractRotation' and count(parameter)=0]"
		[Register ("extractRotation", "()Lcom/google/ar/core/Pose;", "GetExtractRotationHandler")]
		public virtual unsafe global::Google.AR.Core.Pose ExtractRotation ()
		{
			const string __id = "extractRotation.()Lcom/google/ar/core/Pose;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_extractTranslation;
#pragma warning disable 0169
		static Delegate GetExtractTranslationHandler ()
		{
			if (cb_extractTranslation == null)
				cb_extractTranslation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ExtractTranslation);
			return cb_extractTranslation;
		}

		static IntPtr n_ExtractTranslation (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExtractTranslation ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='extractTranslation' and count(parameter)=0]"
		[Register ("extractTranslation", "()Lcom/google/ar/core/Pose;", "GetExtractTranslationHandler")]
		public virtual unsafe global::Google.AR.Core.Pose ExtractTranslation ()
		{
			const string __id = "extractTranslation.()Lcom/google/ar/core/Pose;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getRotationQuaternion;
#pragma warning disable 0169
		static Delegate GetGetRotationQuaternionHandler ()
		{
			if (cb_getRotationQuaternion == null)
				cb_getRotationQuaternion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRotationQuaternion);
			return cb_getRotationQuaternion;
		}

		static IntPtr n_GetRotationQuaternion (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRotationQuaternion ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='getRotationQuaternion' and count(parameter)=0]"
		[Register ("getRotationQuaternion", "()[F", "GetGetRotationQuaternionHandler")]
		public virtual unsafe float[] GetRotationQuaternion ()
		{
			const string __id = "getRotationQuaternion.()[F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_getRotationQuaternion_arrayFI;
#pragma warning disable 0169
		static Delegate GetGetRotationQuaternion_arrayFIHandler ()
		{
			if (cb_getRotationQuaternion_arrayFI == null)
				cb_getRotationQuaternion_arrayFI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_GetRotationQuaternion_arrayFI);
			return cb_getRotationQuaternion_arrayFI;
		}

		static void n_GetRotationQuaternion_arrayFI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.GetRotationQuaternion (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='getRotationQuaternion' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='int']]"
		[Register ("getRotationQuaternion", "([FI)V", "GetGetRotationQuaternion_arrayFIHandler")]
		public virtual unsafe void GetRotationQuaternion (float[] p0, int p1)
		{
			const string __id = "getRotationQuaternion.([FI)V";
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

		static Delegate cb_getTransformedAxis_IF;
#pragma warning disable 0169
		static Delegate GetGetTransformedAxis_IFHandler ()
		{
			if (cb_getTransformedAxis_IF == null)
				cb_getTransformedAxis_IF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, float, IntPtr>) n_GetTransformedAxis_IF);
			return cb_getTransformedAxis_IF;
		}

		static IntPtr n_GetTransformedAxis_IF (IntPtr jnienv, IntPtr native__this, int p0, float p1)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTransformedAxis (p0, p1));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='getTransformedAxis' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
		[Register ("getTransformedAxis", "(IF)[F", "GetGetTransformedAxis_IFHandler")]
		public virtual unsafe float[] GetTransformedAxis (int p0, float p1)
		{
			const string __id = "getTransformedAxis.(IF)[F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_getTransformedAxis_IFarrayFI;
#pragma warning disable 0169
		static Delegate GetGetTransformedAxis_IFarrayFIHandler ()
		{
			if (cb_getTransformedAxis_IFarrayFI == null)
				cb_getTransformedAxis_IFarrayFI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, float, IntPtr, int>) n_GetTransformedAxis_IFarrayFI);
			return cb_getTransformedAxis_IFarrayFI;
		}

		static void n_GetTransformedAxis_IFarrayFI (IntPtr jnienv, IntPtr native__this, int p0, float p1, IntPtr native_p2, int p3)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p2 = (float[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.GetTransformedAxis (p0, p1, p2, p3);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='getTransformedAxis' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='float'] and parameter[3][@type='float[]'] and parameter[4][@type='int']]"
		[Register ("getTransformedAxis", "(IF[FI)V", "GetGetTransformedAxis_IFarrayFIHandler")]
		public virtual unsafe void GetTransformedAxis (int p0, float p1, float[] p2, int p3)
		{
			const string __id = "getTransformedAxis.(IF[FI)V";
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_getTranslation;
#pragma warning disable 0169
		static Delegate GetGetTranslationHandler ()
		{
			if (cb_getTranslation == null)
				cb_getTranslation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTranslation);
			return cb_getTranslation;
		}

		static IntPtr n_GetTranslation (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTranslation ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='getTranslation' and count(parameter)=0]"
		[Register ("getTranslation", "()[F", "GetGetTranslationHandler")]
		public virtual unsafe float[] GetTranslation ()
		{
			const string __id = "getTranslation.()[F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_getTranslation_arrayFI;
#pragma warning disable 0169
		static Delegate GetGetTranslation_arrayFIHandler ()
		{
			if (cb_getTranslation_arrayFI == null)
				cb_getTranslation_arrayFI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_GetTranslation_arrayFI);
			return cb_getTranslation_arrayFI;
		}

		static void n_GetTranslation_arrayFI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.GetTranslation (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='getTranslation' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='int']]"
		[Register ("getTranslation", "([FI)V", "GetGetTranslation_arrayFIHandler")]
		public virtual unsafe void GetTranslation (float[] p0, int p1)
		{
			const string __id = "getTranslation.([FI)V";
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

		static Delegate cb_getXAxis;
#pragma warning disable 0169
		static Delegate GetGetXAxisHandler ()
		{
			if (cb_getXAxis == null)
				cb_getXAxis = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetXAxis);
			return cb_getXAxis;
		}

		static IntPtr n_GetXAxis (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetXAxis ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='getXAxis' and count(parameter)=0]"
		[Register ("getXAxis", "()[F", "GetGetXAxisHandler")]
		public virtual unsafe float[] GetXAxis ()
		{
			const string __id = "getXAxis.()[F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_getYAxis;
#pragma warning disable 0169
		static Delegate GetGetYAxisHandler ()
		{
			if (cb_getYAxis == null)
				cb_getYAxis = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetYAxis);
			return cb_getYAxis;
		}

		static IntPtr n_GetYAxis (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetYAxis ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='getYAxis' and count(parameter)=0]"
		[Register ("getYAxis", "()[F", "GetGetYAxisHandler")]
		public virtual unsafe float[] GetYAxis ()
		{
			const string __id = "getYAxis.()[F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_getZAxis;
#pragma warning disable 0169
		static Delegate GetGetZAxisHandler ()
		{
			if (cb_getZAxis == null)
				cb_getZAxis = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetZAxis);
			return cb_getZAxis;
		}

		static IntPtr n_GetZAxis (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetZAxis ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='getZAxis' and count(parameter)=0]"
		[Register ("getZAxis", "()[F", "GetGetZAxisHandler")]
		public virtual unsafe float[] GetZAxis ()
		{
			const string __id = "getZAxis.()[F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_inverse;
#pragma warning disable 0169
		static Delegate GetInverseHandler ()
		{
			if (cb_inverse == null)
				cb_inverse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Inverse);
			return cb_inverse;
		}

		static IntPtr n_Inverse (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Inverse ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='inverse' and count(parameter)=0]"
		[Register ("inverse", "()Lcom/google/ar/core/Pose;", "GetInverseHandler")]
		public virtual unsafe global::Google.AR.Core.Pose Inverse ()
		{
			const string __id = "inverse.()Lcom/google/ar/core/Pose;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='makeInterpolated' and count(parameter)=3 and parameter[1][@type='com.google.ar.core.Pose'] and parameter[2][@type='com.google.ar.core.Pose'] and parameter[3][@type='float']]"
		[Register ("makeInterpolated", "(Lcom/google/ar/core/Pose;Lcom/google/ar/core/Pose;F)Lcom/google/ar/core/Pose;", "")]
		public static unsafe global::Google.AR.Core.Pose MakeInterpolated (global::Google.AR.Core.Pose p0, global::Google.AR.Core.Pose p1, float p2)
		{
			const string __id = "makeInterpolated.(Lcom/google/ar/core/Pose;Lcom/google/ar/core/Pose;F)Lcom/google/ar/core/Pose;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='makeRotation' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("makeRotation", "(FFFF)Lcom/google/ar/core/Pose;", "")]
		public static unsafe global::Google.AR.Core.Pose MakeRotation (float p0, float p1, float p2, float p3)
		{
			const string __id = "makeRotation.(FFFF)Lcom/google/ar/core/Pose;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='makeRotation' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("makeRotation", "([F)Lcom/google/ar/core/Pose;", "")]
		public static unsafe global::Google.AR.Core.Pose MakeRotation (float[] p0)
		{
			const string __id = "makeRotation.([F)Lcom/google/ar/core/Pose;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='makeTranslation' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("makeTranslation", "(FFF)Lcom/google/ar/core/Pose;", "")]
		public static unsafe global::Google.AR.Core.Pose MakeTranslation (float p0, float p1, float p2)
		{
			const string __id = "makeTranslation.(FFF)Lcom/google/ar/core/Pose;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='makeTranslation' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("makeTranslation", "([F)Lcom/google/ar/core/Pose;", "")]
		public static unsafe global::Google.AR.Core.Pose MakeTranslation (float[] p0)
		{
			const string __id = "makeTranslation.([F)Lcom/google/ar/core/Pose;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_qw;
#pragma warning disable 0169
		static Delegate GetQwHandler ()
		{
			if (cb_qw == null)
				cb_qw = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_Qw);
			return cb_qw;
		}

		static float n_Qw (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Qw ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='qw' and count(parameter)=0]"
		[Register ("qw", "()F", "GetQwHandler")]
		public virtual unsafe float Qw ()
		{
			const string __id = "qw.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_qx;
#pragma warning disable 0169
		static Delegate GetQxHandler ()
		{
			if (cb_qx == null)
				cb_qx = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_Qx);
			return cb_qx;
		}

		static float n_Qx (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Qx ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='qx' and count(parameter)=0]"
		[Register ("qx", "()F", "GetQxHandler")]
		public virtual unsafe float Qx ()
		{
			const string __id = "qx.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_qy;
#pragma warning disable 0169
		static Delegate GetQyHandler ()
		{
			if (cb_qy == null)
				cb_qy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_Qy);
			return cb_qy;
		}

		static float n_Qy (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Qy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='qy' and count(parameter)=0]"
		[Register ("qy", "()F", "GetQyHandler")]
		public virtual unsafe float Qy ()
		{
			const string __id = "qy.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_qz;
#pragma warning disable 0169
		static Delegate GetQzHandler ()
		{
			if (cb_qz == null)
				cb_qz = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_Qz);
			return cb_qz;
		}

		static float n_Qz (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Qz ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='qz' and count(parameter)=0]"
		[Register ("qz", "()F", "GetQzHandler")]
		public virtual unsafe float Qz ()
		{
			const string __id = "qz.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_rotateVector_arrayF;
#pragma warning disable 0169
		static Delegate GetRotateVector_arrayFHandler ()
		{
			if (cb_rotateVector_arrayF == null)
				cb_rotateVector_arrayF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RotateVector_arrayF);
			return cb_rotateVector_arrayF;
		}

		static IntPtr n_RotateVector_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			IntPtr __ret = JNIEnv.NewArray (__this.RotateVector (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='rotateVector' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("rotateVector", "([F)[F", "GetRotateVector_arrayFHandler")]
		public virtual unsafe float[] RotateVector (float[] p0)
		{
			const string __id = "rotateVector.([F)[F";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_rotateVector_arrayFIarrayFI;
#pragma warning disable 0169
		static Delegate GetRotateVector_arrayFIarrayFIHandler ()
		{
			if (cb_rotateVector_arrayFIarrayFI == null)
				cb_rotateVector_arrayFIarrayFI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, int>) n_RotateVector_arrayFIarrayFI);
			return cb_rotateVector_arrayFIarrayFI;
		}

		static void n_RotateVector_arrayFIarrayFI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, int p3)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			float[] p2 = (float[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.RotateVector (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='rotateVector' and count(parameter)=4 and parameter[1][@type='float[]'] and parameter[2][@type='int'] and parameter[3][@type='float[]'] and parameter[4][@type='int']]"
		[Register ("rotateVector", "([FI[FI)V", "GetRotateVector_arrayFIarrayFIHandler")]
		public virtual unsafe void RotateVector (float[] p0, int p1, float[] p2, int p3)
		{
			const string __id = "rotateVector.([FI[FI)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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

		static Delegate cb_toMatrix_arrayFI;
#pragma warning disable 0169
		static Delegate GetToMatrix_arrayFIHandler ()
		{
			if (cb_toMatrix_arrayFI == null)
				cb_toMatrix_arrayFI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_ToMatrix_arrayFI);
			return cb_toMatrix_arrayFI;
		}

		static void n_ToMatrix_arrayFI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.ToMatrix (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='toMatrix' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='int']]"
		[Register ("toMatrix", "([FI)V", "GetToMatrix_arrayFIHandler")]
		public virtual unsafe void ToMatrix (float[] p0, int p1)
		{
			const string __id = "toMatrix.([FI)V";
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

		static Delegate cb_transformPoint_arrayF;
#pragma warning disable 0169
		static Delegate GetTransformPoint_arrayFHandler ()
		{
			if (cb_transformPoint_arrayF == null)
				cb_transformPoint_arrayF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_TransformPoint_arrayF);
			return cb_transformPoint_arrayF;
		}

		static IntPtr n_TransformPoint_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			IntPtr __ret = JNIEnv.NewArray (__this.TransformPoint (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='transformPoint' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("transformPoint", "([F)[F", "GetTransformPoint_arrayFHandler")]
		public virtual unsafe float[] TransformPoint (float[] p0)
		{
			const string __id = "transformPoint.([F)[F";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_transformPoint_arrayFIarrayFI;
#pragma warning disable 0169
		static Delegate GetTransformPoint_arrayFIarrayFIHandler ()
		{
			if (cb_transformPoint_arrayFIarrayFI == null)
				cb_transformPoint_arrayFIarrayFI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, int>) n_TransformPoint_arrayFIarrayFI);
			return cb_transformPoint_arrayFIarrayFI;
		}

		static void n_TransformPoint_arrayFIarrayFI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, int p3)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			float[] p2 = (float[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.TransformPoint (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='transformPoint' and count(parameter)=4 and parameter[1][@type='float[]'] and parameter[2][@type='int'] and parameter[3][@type='float[]'] and parameter[4][@type='int']]"
		[Register ("transformPoint", "([FI[FI)V", "GetTransformPoint_arrayFIarrayFIHandler")]
		public virtual unsafe void TransformPoint (float[] p0, int p1, float[] p2, int p3)
		{
			const string __id = "transformPoint.([FI[FI)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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

		static Delegate cb_tx;
#pragma warning disable 0169
		static Delegate GetTxHandler ()
		{
			if (cb_tx == null)
				cb_tx = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_Tx);
			return cb_tx;
		}

		static float n_Tx (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Tx ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='tx' and count(parameter)=0]"
		[Register ("tx", "()F", "GetTxHandler")]
		public virtual unsafe float Tx ()
		{
			const string __id = "tx.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_ty;
#pragma warning disable 0169
		static Delegate GetTyHandler ()
		{
			if (cb_ty == null)
				cb_ty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_Ty);
			return cb_ty;
		}

		static float n_Ty (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Ty ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='ty' and count(parameter)=0]"
		[Register ("ty", "()F", "GetTyHandler")]
		public virtual unsafe float Ty ()
		{
			const string __id = "ty.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_tz;
#pragma warning disable 0169
		static Delegate GetTzHandler ()
		{
			if (cb_tz == null)
				cb_tz = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_Tz);
			return cb_tz;
		}

		static float n_Tz (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Tz ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='tz' and count(parameter)=0]"
		[Register ("tz", "()F", "GetTzHandler")]
		public virtual unsafe float Tz ()
		{
			const string __id = "tz.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
