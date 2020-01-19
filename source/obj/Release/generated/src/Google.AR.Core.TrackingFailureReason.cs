using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='TrackingFailureReason']"
	[global::Android.Runtime.Register ("com/google/ar/core/TrackingFailureReason", DoNotGenerateAcw=true)]
	public sealed partial class TrackingFailureReason : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='TrackingFailureReason']/field[@name='BAD_STATE']"
		[Register ("BAD_STATE")]
		public static global::Google.AR.Core.TrackingFailureReason BadState {
			get {
				const string __id = "BAD_STATE.Lcom/google/ar/core/TrackingFailureReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.TrackingFailureReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='TrackingFailureReason']/field[@name='EXCESSIVE_MOTION']"
		[Register ("EXCESSIVE_MOTION")]
		public static global::Google.AR.Core.TrackingFailureReason ExcessiveMotion {
			get {
				const string __id = "EXCESSIVE_MOTION.Lcom/google/ar/core/TrackingFailureReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.TrackingFailureReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='TrackingFailureReason']/field[@name='INSUFFICIENT_FEATURES']"
		[Register ("INSUFFICIENT_FEATURES")]
		public static global::Google.AR.Core.TrackingFailureReason InsufficientFeatures {
			get {
				const string __id = "INSUFFICIENT_FEATURES.Lcom/google/ar/core/TrackingFailureReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.TrackingFailureReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='TrackingFailureReason']/field[@name='INSUFFICIENT_LIGHT']"
		[Register ("INSUFFICIENT_LIGHT")]
		public static global::Google.AR.Core.TrackingFailureReason InsufficientLight {
			get {
				const string __id = "INSUFFICIENT_LIGHT.Lcom/google/ar/core/TrackingFailureReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.TrackingFailureReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='TrackingFailureReason']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::Google.AR.Core.TrackingFailureReason None {
			get {
				const string __id = "NONE.Lcom/google/ar/core/TrackingFailureReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.TrackingFailureReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/TrackingFailureReason", typeof (TrackingFailureReason));
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

		internal TrackingFailureReason (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='TrackingFailureReason']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/TrackingFailureReason;", "")]
		public static unsafe global::Google.AR.Core.TrackingFailureReason ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/ar/core/TrackingFailureReason;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.TrackingFailureReason> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='TrackingFailureReason']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/ar/core/TrackingFailureReason;", "")]
		public static unsafe global::Google.AR.Core.TrackingFailureReason[] Values ()
		{
			const string __id = "values.()[Lcom/google/ar/core/TrackingFailureReason;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Google.AR.Core.TrackingFailureReason[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.TrackingFailureReason));
			} finally {
			}
		}

	}
}
