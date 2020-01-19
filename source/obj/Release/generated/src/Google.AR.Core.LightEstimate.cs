using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='LightEstimate']"
	[global::Android.Runtime.Register ("com/google/ar/core/LightEstimate", DoNotGenerateAcw=true)]
	public partial class LightEstimate : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='LightEstimate.State']"
		[global::Android.Runtime.Register ("com/google/ar/core/LightEstimate$State", DoNotGenerateAcw=true)]
		public sealed partial class State : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='LightEstimate.State']/field[@name='NOT_VALID']"
			[Register ("NOT_VALID")]
			public static global::Google.AR.Core.LightEstimate.State NotValid {
				get {
					const string __id = "NOT_VALID.Lcom/google/ar/core/LightEstimate$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.LightEstimate.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='LightEstimate.State']/field[@name='VALID']"
			[Register ("VALID")]
			public static global::Google.AR.Core.LightEstimate.State Valid {
				get {
					const string __id = "VALID.Lcom/google/ar/core/LightEstimate$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.LightEstimate.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/LightEstimate$State", typeof (State));
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

			internal State (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='LightEstimate.State']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/LightEstimate$State;", "")]
			public static unsafe global::Google.AR.Core.LightEstimate.State ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/ar/core/LightEstimate$State;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.LightEstimate.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='LightEstimate.State']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/ar/core/LightEstimate$State;", "")]
			public static unsafe global::Google.AR.Core.LightEstimate.State[] Values ()
			{
				const string __id = "values.()[Lcom/google/ar/core/LightEstimate$State;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Google.AR.Core.LightEstimate.State[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.LightEstimate.State));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/LightEstimate", typeof (LightEstimate));
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

		protected LightEstimate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='LightEstimate']/constructor[@name='LightEstimate' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe LightEstimate ()
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

		static Delegate cb_getPixelIntensity;
#pragma warning disable 0169
		static Delegate GetGetPixelIntensityHandler ()
		{
			if (cb_getPixelIntensity == null)
				cb_getPixelIntensity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetPixelIntensity);
			return cb_getPixelIntensity;
		}

		static float n_GetPixelIntensity (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.LightEstimate __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.LightEstimate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PixelIntensity;
		}
#pragma warning restore 0169

		public virtual unsafe float PixelIntensity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='LightEstimate']/method[@name='getPixelIntensity' and count(parameter)=0]"
			[Register ("getPixelIntensity", "()F", "GetGetPixelIntensityHandler")]
			get {
				const string __id = "getPixelIntensity.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
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
			global::Google.AR.Core.LightEstimate __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.LightEstimate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timestamp;
		}
#pragma warning restore 0169

		public virtual unsafe long Timestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='LightEstimate']/method[@name='getTimestamp' and count(parameter)=0]"
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

		static Delegate cb_acquireEnvironmentalHdrCubeMap;
#pragma warning disable 0169
		static Delegate GetAcquireEnvironmentalHdrCubeMapHandler ()
		{
			if (cb_acquireEnvironmentalHdrCubeMap == null)
				cb_acquireEnvironmentalHdrCubeMap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AcquireEnvironmentalHdrCubeMap);
			return cb_acquireEnvironmentalHdrCubeMap;
		}

		static IntPtr n_AcquireEnvironmentalHdrCubeMap (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.LightEstimate __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.LightEstimate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.AcquireEnvironmentalHdrCubeMap ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='LightEstimate']/method[@name='acquireEnvironmentalHdrCubeMap' and count(parameter)=0]"
		[Register ("acquireEnvironmentalHdrCubeMap", "()[Lcom/google/ar/core/ArImage;", "GetAcquireEnvironmentalHdrCubeMapHandler")]
		public virtual unsafe global::Google.AR.Core.ArImage[] AcquireEnvironmentalHdrCubeMap ()
		{
			const string __id = "acquireEnvironmentalHdrCubeMap.()[Lcom/google/ar/core/ArImage;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Google.AR.Core.ArImage[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.ArImage));
			} finally {
			}
		}

		static Delegate cb_getColorCorrection_arrayFI;
#pragma warning disable 0169
		static Delegate GetGetColorCorrection_arrayFIHandler ()
		{
			if (cb_getColorCorrection_arrayFI == null)
				cb_getColorCorrection_arrayFI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_GetColorCorrection_arrayFI);
			return cb_getColorCorrection_arrayFI;
		}

		static void n_GetColorCorrection_arrayFI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Google.AR.Core.LightEstimate __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.LightEstimate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.GetColorCorrection (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='LightEstimate']/method[@name='getColorCorrection' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='int']]"
		[Register ("getColorCorrection", "([FI)V", "GetGetColorCorrection_arrayFIHandler")]
		public virtual unsafe void GetColorCorrection (float[] p0, int p1)
		{
			const string __id = "getColorCorrection.([FI)V";
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

		static Delegate cb_getEnvironmentalHdrAmbientSphericalHarmonics;
#pragma warning disable 0169
		static Delegate GetGetEnvironmentalHdrAmbientSphericalHarmonicsHandler ()
		{
			if (cb_getEnvironmentalHdrAmbientSphericalHarmonics == null)
				cb_getEnvironmentalHdrAmbientSphericalHarmonics = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEnvironmentalHdrAmbientSphericalHarmonics);
			return cb_getEnvironmentalHdrAmbientSphericalHarmonics;
		}

		static IntPtr n_GetEnvironmentalHdrAmbientSphericalHarmonics (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.LightEstimate __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.LightEstimate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetEnvironmentalHdrAmbientSphericalHarmonics ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='LightEstimate']/method[@name='getEnvironmentalHdrAmbientSphericalHarmonics' and count(parameter)=0]"
		[Register ("getEnvironmentalHdrAmbientSphericalHarmonics", "()[F", "GetGetEnvironmentalHdrAmbientSphericalHarmonicsHandler")]
		public virtual unsafe float[] GetEnvironmentalHdrAmbientSphericalHarmonics ()
		{
			const string __id = "getEnvironmentalHdrAmbientSphericalHarmonics.()[F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_getEnvironmentalHdrMainLightDirection;
#pragma warning disable 0169
		static Delegate GetGetEnvironmentalHdrMainLightDirectionHandler ()
		{
			if (cb_getEnvironmentalHdrMainLightDirection == null)
				cb_getEnvironmentalHdrMainLightDirection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEnvironmentalHdrMainLightDirection);
			return cb_getEnvironmentalHdrMainLightDirection;
		}

		static IntPtr n_GetEnvironmentalHdrMainLightDirection (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.LightEstimate __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.LightEstimate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetEnvironmentalHdrMainLightDirection ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='LightEstimate']/method[@name='getEnvironmentalHdrMainLightDirection' and count(parameter)=0]"
		[Register ("getEnvironmentalHdrMainLightDirection", "()[F", "GetGetEnvironmentalHdrMainLightDirectionHandler")]
		public virtual unsafe float[] GetEnvironmentalHdrMainLightDirection ()
		{
			const string __id = "getEnvironmentalHdrMainLightDirection.()[F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_getEnvironmentalHdrMainLightIntensity;
#pragma warning disable 0169
		static Delegate GetGetEnvironmentalHdrMainLightIntensityHandler ()
		{
			if (cb_getEnvironmentalHdrMainLightIntensity == null)
				cb_getEnvironmentalHdrMainLightIntensity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEnvironmentalHdrMainLightIntensity);
			return cb_getEnvironmentalHdrMainLightIntensity;
		}

		static IntPtr n_GetEnvironmentalHdrMainLightIntensity (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.LightEstimate __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.LightEstimate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetEnvironmentalHdrMainLightIntensity ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='LightEstimate']/method[@name='getEnvironmentalHdrMainLightIntensity' and count(parameter)=0]"
		[Register ("getEnvironmentalHdrMainLightIntensity", "()[F", "GetGetEnvironmentalHdrMainLightIntensityHandler")]
		public virtual unsafe float[] GetEnvironmentalHdrMainLightIntensity ()
		{
			const string __id = "getEnvironmentalHdrMainLightIntensity.()[F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_getState;
#pragma warning disable 0169
		static Delegate GetGetStateHandler ()
		{
			if (cb_getState == null)
				cb_getState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetState);
			return cb_getState;
		}

		static IntPtr n_GetState (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.LightEstimate __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.LightEstimate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetState ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='LightEstimate']/method[@name='getState' and count(parameter)=0]"
		[Register ("getState", "()Lcom/google/ar/core/LightEstimate$State;", "GetGetStateHandler")]
		public virtual unsafe global::Google.AR.Core.LightEstimate.State GetState ()
		{
			const string __id = "getState.()Lcom/google/ar/core/LightEstimate$State;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.LightEstimate.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
