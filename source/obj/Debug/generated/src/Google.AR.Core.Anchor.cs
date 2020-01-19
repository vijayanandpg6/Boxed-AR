using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='Anchor']"
	[global::Android.Runtime.Register ("com/google/ar/core/Anchor", DoNotGenerateAcw=true)]
	public partial class Anchor : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='Anchor.CloudAnchorState']"
		[global::Android.Runtime.Register ("com/google/ar/core/Anchor$CloudAnchorState", DoNotGenerateAcw=true)]
		public sealed partial class CloudAnchorState : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Anchor.CloudAnchorState']/field[@name='ERROR_CLOUD_ID_NOT_FOUND']"
			[Register ("ERROR_CLOUD_ID_NOT_FOUND")]
			public static global::Google.AR.Core.Anchor.CloudAnchorState ErrorCloudIdNotFound {
				get {
					const string __id = "ERROR_CLOUD_ID_NOT_FOUND.Lcom/google/ar/core/Anchor$CloudAnchorState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor.CloudAnchorState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Anchor.CloudAnchorState']/field[@name='ERROR_HOSTING_DATASET_PROCESSING_FAILED']"
			[Register ("ERROR_HOSTING_DATASET_PROCESSING_FAILED")]
			public static global::Google.AR.Core.Anchor.CloudAnchorState ErrorHostingDatasetProcessingFailed {
				get {
					const string __id = "ERROR_HOSTING_DATASET_PROCESSING_FAILED.Lcom/google/ar/core/Anchor$CloudAnchorState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor.CloudAnchorState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Anchor.CloudAnchorState']/field[@name='ERROR_HOSTING_SERVICE_UNAVAILABLE']"
			[Register ("ERROR_HOSTING_SERVICE_UNAVAILABLE")]
			public static global::Google.AR.Core.Anchor.CloudAnchorState ErrorHostingServiceUnavailable {
				get {
					const string __id = "ERROR_HOSTING_SERVICE_UNAVAILABLE.Lcom/google/ar/core/Anchor$CloudAnchorState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor.CloudAnchorState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Anchor.CloudAnchorState']/field[@name='ERROR_INTERNAL']"
			[Register ("ERROR_INTERNAL")]
			public static global::Google.AR.Core.Anchor.CloudAnchorState ErrorInternal {
				get {
					const string __id = "ERROR_INTERNAL.Lcom/google/ar/core/Anchor$CloudAnchorState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor.CloudAnchorState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Anchor.CloudAnchorState']/field[@name='ERROR_NOT_AUTHORIZED']"
			[Register ("ERROR_NOT_AUTHORIZED")]
			public static global::Google.AR.Core.Anchor.CloudAnchorState ErrorNotAuthorized {
				get {
					const string __id = "ERROR_NOT_AUTHORIZED.Lcom/google/ar/core/Anchor$CloudAnchorState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor.CloudAnchorState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Anchor.CloudAnchorState']/field[@name='ERROR_RESOLVING_LOCALIZATION_NO_MATCH']"
			[Register ("ERROR_RESOLVING_LOCALIZATION_NO_MATCH")]
			public static global::Google.AR.Core.Anchor.CloudAnchorState ErrorResolvingLocalizationNoMatch {
				get {
					const string __id = "ERROR_RESOLVING_LOCALIZATION_NO_MATCH.Lcom/google/ar/core/Anchor$CloudAnchorState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor.CloudAnchorState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Anchor.CloudAnchorState']/field[@name='ERROR_RESOLVING_SDK_VERSION_TOO_NEW']"
			[Register ("ERROR_RESOLVING_SDK_VERSION_TOO_NEW")]
			public static global::Google.AR.Core.Anchor.CloudAnchorState ErrorResolvingSdkVersionTooNew {
				get {
					const string __id = "ERROR_RESOLVING_SDK_VERSION_TOO_NEW.Lcom/google/ar/core/Anchor$CloudAnchorState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor.CloudAnchorState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Anchor.CloudAnchorState']/field[@name='ERROR_RESOLVING_SDK_VERSION_TOO_OLD']"
			[Register ("ERROR_RESOLVING_SDK_VERSION_TOO_OLD")]
			public static global::Google.AR.Core.Anchor.CloudAnchorState ErrorResolvingSdkVersionTooOld {
				get {
					const string __id = "ERROR_RESOLVING_SDK_VERSION_TOO_OLD.Lcom/google/ar/core/Anchor$CloudAnchorState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor.CloudAnchorState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Anchor.CloudAnchorState']/field[@name='ERROR_RESOURCE_EXHAUSTED']"
			[Register ("ERROR_RESOURCE_EXHAUSTED")]
			public static global::Google.AR.Core.Anchor.CloudAnchorState ErrorResourceExhausted {
				get {
					const string __id = "ERROR_RESOURCE_EXHAUSTED.Lcom/google/ar/core/Anchor$CloudAnchorState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor.CloudAnchorState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Anchor.CloudAnchorState']/field[@name='ERROR_SERVICE_UNAVAILABLE']"
			[Register ("ERROR_SERVICE_UNAVAILABLE")]
			public static global::Google.AR.Core.Anchor.CloudAnchorState ErrorServiceUnavailable {
				get {
					const string __id = "ERROR_SERVICE_UNAVAILABLE.Lcom/google/ar/core/Anchor$CloudAnchorState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor.CloudAnchorState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Anchor.CloudAnchorState']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::Google.AR.Core.Anchor.CloudAnchorState None {
				get {
					const string __id = "NONE.Lcom/google/ar/core/Anchor$CloudAnchorState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor.CloudAnchorState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Anchor.CloudAnchorState']/field[@name='SUCCESS']"
			[Register ("SUCCESS")]
			public static global::Google.AR.Core.Anchor.CloudAnchorState Success {
				get {
					const string __id = "SUCCESS.Lcom/google/ar/core/Anchor$CloudAnchorState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor.CloudAnchorState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Anchor.CloudAnchorState']/field[@name='TASK_IN_PROGRESS']"
			[Register ("TASK_IN_PROGRESS")]
			public static global::Google.AR.Core.Anchor.CloudAnchorState TaskInProgress {
				get {
					const string __id = "TASK_IN_PROGRESS.Lcom/google/ar/core/Anchor$CloudAnchorState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor.CloudAnchorState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/Anchor$CloudAnchorState", typeof (CloudAnchorState));
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

			internal CloudAnchorState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			public unsafe bool IsError {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Anchor.CloudAnchorState']/method[@name='isError' and count(parameter)=0]"
				[Register ("isError", "()Z", "GetIsErrorHandler")]
				get {
					const string __id = "isError.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Anchor.CloudAnchorState']/method[@name='forNumber' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("forNumber", "(I)Lcom/google/ar/core/Anchor$CloudAnchorState;", "")]
			public static unsafe global::Google.AR.Core.Anchor.CloudAnchorState ForNumber (int p0)
			{
				const string __id = "forNumber.(I)Lcom/google/ar/core/Anchor$CloudAnchorState;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor.CloudAnchorState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Anchor.CloudAnchorState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/Anchor$CloudAnchorState;", "")]
			public static unsafe global::Google.AR.Core.Anchor.CloudAnchorState ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/ar/core/Anchor$CloudAnchorState;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor.CloudAnchorState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Anchor.CloudAnchorState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/ar/core/Anchor$CloudAnchorState;", "")]
			public static unsafe global::Google.AR.Core.Anchor.CloudAnchorState[] Values ()
			{
				const string __id = "values.()[Lcom/google/ar/core/Anchor$CloudAnchorState;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Google.AR.Core.Anchor.CloudAnchorState[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.Anchor.CloudAnchorState));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/Anchor", typeof (Anchor));
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

		protected Anchor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='Anchor']/constructor[@name='Anchor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe Anchor ()
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

		static Delegate cb_getCloudAnchorId;
#pragma warning disable 0169
		static Delegate GetGetCloudAnchorIdHandler ()
		{
			if (cb_getCloudAnchorId == null)
				cb_getCloudAnchorId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCloudAnchorId);
			return cb_getCloudAnchorId;
		}

		static IntPtr n_GetCloudAnchorId (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Anchor __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CloudAnchorId);
		}
#pragma warning restore 0169

		public virtual unsafe string CloudAnchorId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Anchor']/method[@name='getCloudAnchorId' and count(parameter)=0]"
			[Register ("getCloudAnchorId", "()Ljava/lang/String;", "GetGetCloudAnchorIdHandler")]
			get {
				const string __id = "getCloudAnchorId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Google.AR.Core.Anchor __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Pose);
		}
#pragma warning restore 0169

		public virtual unsafe global::Google.AR.Core.Pose Pose {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Anchor']/method[@name='getPose' and count(parameter)=0]"
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
			global::Google.AR.Core.Anchor __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TrackingState);
		}
#pragma warning restore 0169

		public virtual unsafe global::Google.AR.Core.TrackingState TrackingState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Anchor']/method[@name='getTrackingState' and count(parameter)=0]"
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

		static Delegate cb_detach;
#pragma warning disable 0169
		static Delegate GetDetachHandler ()
		{
			if (cb_detach == null)
				cb_detach = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Detach);
			return cb_detach;
		}

		static void n_Detach (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Anchor __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Detach ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Anchor']/method[@name='detach' and count(parameter)=0]"
		[Register ("detach", "()V", "GetDetachHandler")]
		public virtual unsafe void Detach ()
		{
			const string __id = "detach.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getCloudAnchorState;
#pragma warning disable 0169
		static Delegate GetGetCloudAnchorStateHandler ()
		{
			if (cb_getCloudAnchorState == null)
				cb_getCloudAnchorState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCloudAnchorState);
			return cb_getCloudAnchorState;
		}

		static IntPtr n_GetCloudAnchorState (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Anchor __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetCloudAnchorState ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Anchor']/method[@name='getCloudAnchorState' and count(parameter)=0]"
		[Register ("getCloudAnchorState", "()Lcom/google/ar/core/Anchor$CloudAnchorState;", "GetGetCloudAnchorStateHandler")]
		public virtual unsafe global::Google.AR.Core.Anchor.CloudAnchorState GetCloudAnchorState ()
		{
			const string __id = "getCloudAnchorState.()Lcom/google/ar/core/Anchor$CloudAnchorState;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor.CloudAnchorState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
