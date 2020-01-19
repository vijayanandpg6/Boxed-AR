using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='TrackingState']"
	[global::Android.Runtime.Register ("com/google/ar/core/TrackingState", DoNotGenerateAcw=true)]
	public sealed partial class TrackingState : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='TrackingState']/field[@name='PAUSED']"
		[Register ("PAUSED")]
		public static global::Google.AR.Core.TrackingState Paused {
			get {
				const string __id = "PAUSED.Lcom/google/ar/core/TrackingState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.TrackingState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='TrackingState']/field[@name='STOPPED']"
		[Register ("STOPPED")]
		public static global::Google.AR.Core.TrackingState Stopped {
			get {
				const string __id = "STOPPED.Lcom/google/ar/core/TrackingState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.TrackingState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='TrackingState']/field[@name='TRACKING']"
		[Register ("TRACKING")]
		public static global::Google.AR.Core.TrackingState Tracking {
			get {
				const string __id = "TRACKING.Lcom/google/ar/core/TrackingState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.TrackingState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/TrackingState", typeof (TrackingState));
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

		internal TrackingState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='TrackingState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/TrackingState;", "")]
		public static unsafe global::Google.AR.Core.TrackingState ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/ar/core/TrackingState;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.TrackingState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='TrackingState']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/ar/core/TrackingState;", "")]
		public static unsafe global::Google.AR.Core.TrackingState[] Values ()
		{
			const string __id = "values.()[Lcom/google/ar/core/TrackingState;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Google.AR.Core.TrackingState[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.TrackingState));
			} finally {
			}
		}

	}
}
