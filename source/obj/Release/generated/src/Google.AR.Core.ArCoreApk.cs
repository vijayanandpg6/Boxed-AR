using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk']"
	[global::Android.Runtime.Register ("com/google/ar/core/ArCoreApk", DoNotGenerateAcw=true)]
	public partial class ArCoreApk : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.Availability']"
		[global::Android.Runtime.Register ("com/google/ar/core/ArCoreApk$Availability", DoNotGenerateAcw=true)]
		public partial class Availability : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.Availability']/field[@name='SUPPORTED_APK_TOO_OLD']"
			[Register ("SUPPORTED_APK_TOO_OLD")]
			public static global::Google.AR.Core.ArCoreApk.Availability SupportedApkTooOld {
				get {
					const string __id = "SUPPORTED_APK_TOO_OLD.Lcom/google/ar/core/ArCoreApk$Availability;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.Availability> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.Availability']/field[@name='SUPPORTED_INSTALLED']"
			[Register ("SUPPORTED_INSTALLED")]
			public static global::Google.AR.Core.ArCoreApk.Availability SupportedInstalled {
				get {
					const string __id = "SUPPORTED_INSTALLED.Lcom/google/ar/core/ArCoreApk$Availability;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.Availability> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.Availability']/field[@name='SUPPORTED_NOT_INSTALLED']"
			[Register ("SUPPORTED_NOT_INSTALLED")]
			public static global::Google.AR.Core.ArCoreApk.Availability SupportedNotInstalled {
				get {
					const string __id = "SUPPORTED_NOT_INSTALLED.Lcom/google/ar/core/ArCoreApk$Availability;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.Availability> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.Availability']/field[@name='UNKNOWN_CHECKING']"
			[Register ("UNKNOWN_CHECKING")]
			public static global::Google.AR.Core.ArCoreApk.Availability UnknownChecking {
				get {
					const string __id = "UNKNOWN_CHECKING.Lcom/google/ar/core/ArCoreApk$Availability;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.Availability> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.Availability']/field[@name='UNKNOWN_ERROR']"
			[Register ("UNKNOWN_ERROR")]
			public static global::Google.AR.Core.ArCoreApk.Availability UnknownError {
				get {
					const string __id = "UNKNOWN_ERROR.Lcom/google/ar/core/ArCoreApk$Availability;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.Availability> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.Availability']/field[@name='UNKNOWN_TIMED_OUT']"
			[Register ("UNKNOWN_TIMED_OUT")]
			public static global::Google.AR.Core.ArCoreApk.Availability UnknownTimedOut {
				get {
					const string __id = "UNKNOWN_TIMED_OUT.Lcom/google/ar/core/ArCoreApk$Availability;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.Availability> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.Availability']/field[@name='UNSUPPORTED_DEVICE_NOT_CAPABLE']"
			[Register ("UNSUPPORTED_DEVICE_NOT_CAPABLE")]
			public static global::Google.AR.Core.ArCoreApk.Availability UnsupportedDeviceNotCapable {
				get {
					const string __id = "UNSUPPORTED_DEVICE_NOT_CAPABLE.Lcom/google/ar/core/ArCoreApk$Availability;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.Availability> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/ArCoreApk$Availability", typeof (Availability));
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

			protected Availability (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_isSupported;
#pragma warning disable 0169
			static Delegate GetIsSupportedHandler ()
			{
				if (cb_isSupported == null)
					cb_isSupported = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSupported);
				return cb_isSupported;
			}

			static bool n_IsSupported (IntPtr jnienv, IntPtr native__this)
			{
				global::Google.AR.Core.ArCoreApk.Availability __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.Availability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsSupported;
			}
#pragma warning restore 0169

			public virtual unsafe bool IsSupported {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.Availability']/method[@name='isSupported' and count(parameter)=0]"
				[Register ("isSupported", "()Z", "GetIsSupportedHandler")]
				get {
					const string __id = "isSupported.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_isTransient;
#pragma warning disable 0169
			static Delegate GetIsTransientHandler ()
			{
				if (cb_isTransient == null)
					cb_isTransient = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTransient);
				return cb_isTransient;
			}

			static bool n_IsTransient (IntPtr jnienv, IntPtr native__this)
			{
				global::Google.AR.Core.ArCoreApk.Availability __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.Availability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsTransient;
			}
#pragma warning restore 0169

			public virtual unsafe bool IsTransient {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.Availability']/method[@name='isTransient' and count(parameter)=0]"
				[Register ("isTransient", "()Z", "GetIsTransientHandler")]
				get {
					const string __id = "isTransient.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_isUnknown;
#pragma warning disable 0169
			static Delegate GetIsUnknownHandler ()
			{
				if (cb_isUnknown == null)
					cb_isUnknown = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUnknown);
				return cb_isUnknown;
			}

			static bool n_IsUnknown (IntPtr jnienv, IntPtr native__this)
			{
				global::Google.AR.Core.ArCoreApk.Availability __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.Availability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsUnknown;
			}
#pragma warning restore 0169

			public virtual unsafe bool IsUnknown {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.Availability']/method[@name='isUnknown' and count(parameter)=0]"
				[Register ("isUnknown", "()Z", "GetIsUnknownHandler")]
				get {
					const string __id = "isUnknown.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_isUnsupported;
#pragma warning disable 0169
			static Delegate GetIsUnsupportedHandler ()
			{
				if (cb_isUnsupported == null)
					cb_isUnsupported = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUnsupported);
				return cb_isUnsupported;
			}

			static bool n_IsUnsupported (IntPtr jnienv, IntPtr native__this)
			{
				global::Google.AR.Core.ArCoreApk.Availability __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.Availability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsUnsupported;
			}
#pragma warning restore 0169

			public virtual unsafe bool IsUnsupported {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.Availability']/method[@name='isUnsupported' and count(parameter)=0]"
				[Register ("isUnsupported", "()Z", "GetIsUnsupportedHandler")]
				get {
					const string __id = "isUnsupported.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.Availability']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/ArCoreApk$Availability;", "")]
			public static unsafe global::Google.AR.Core.ArCoreApk.Availability ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/ar/core/ArCoreApk$Availability;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.Availability> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.Availability']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/ar/core/ArCoreApk$Availability;", "")]
			public static unsafe global::Google.AR.Core.ArCoreApk.Availability[] Values ()
			{
				const string __id = "values.()[Lcom/google/ar/core/ArCoreApk$Availability;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Google.AR.Core.ArCoreApk.Availability[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.ArCoreApk.Availability));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.InstallBehavior']"
		[global::Android.Runtime.Register ("com/google/ar/core/ArCoreApk$InstallBehavior", DoNotGenerateAcw=true)]
		public sealed partial class InstallBehavior : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.InstallBehavior']/field[@name='OPTIONAL']"
			[Register ("OPTIONAL")]
			public static global::Google.AR.Core.ArCoreApk.InstallBehavior Optional {
				get {
					const string __id = "OPTIONAL.Lcom/google/ar/core/ArCoreApk$InstallBehavior;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.InstallBehavior> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.InstallBehavior']/field[@name='REQUIRED']"
			[Register ("REQUIRED")]
			public static global::Google.AR.Core.ArCoreApk.InstallBehavior Required {
				get {
					const string __id = "REQUIRED.Lcom/google/ar/core/ArCoreApk$InstallBehavior;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.InstallBehavior> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/ArCoreApk$InstallBehavior", typeof (InstallBehavior));
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

			internal InstallBehavior (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.InstallBehavior']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/ArCoreApk$InstallBehavior;", "")]
			public static unsafe global::Google.AR.Core.ArCoreApk.InstallBehavior ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/ar/core/ArCoreApk$InstallBehavior;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.InstallBehavior> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.InstallBehavior']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/ar/core/ArCoreApk$InstallBehavior;", "")]
			public static unsafe global::Google.AR.Core.ArCoreApk.InstallBehavior[] Values ()
			{
				const string __id = "values.()[Lcom/google/ar/core/ArCoreApk$InstallBehavior;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Google.AR.Core.ArCoreApk.InstallBehavior[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.ArCoreApk.InstallBehavior));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.InstallStatus']"
		[global::Android.Runtime.Register ("com/google/ar/core/ArCoreApk$InstallStatus", DoNotGenerateAcw=true)]
		public sealed partial class InstallStatus : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.InstallStatus']/field[@name='INSTALLED']"
			[Register ("INSTALLED")]
			public static global::Google.AR.Core.ArCoreApk.InstallStatus Installed {
				get {
					const string __id = "INSTALLED.Lcom/google/ar/core/ArCoreApk$InstallStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.InstallStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.InstallStatus']/field[@name='INSTALL_REQUESTED']"
			[Register ("INSTALL_REQUESTED")]
			public static global::Google.AR.Core.ArCoreApk.InstallStatus InstallRequested {
				get {
					const string __id = "INSTALL_REQUESTED.Lcom/google/ar/core/ArCoreApk$InstallStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.InstallStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/ArCoreApk$InstallStatus", typeof (InstallStatus));
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

			internal InstallStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.InstallStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/ArCoreApk$InstallStatus;", "")]
			public static unsafe global::Google.AR.Core.ArCoreApk.InstallStatus ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/ar/core/ArCoreApk$InstallStatus;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.InstallStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.InstallStatus']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/ar/core/ArCoreApk$InstallStatus;", "")]
			public static unsafe global::Google.AR.Core.ArCoreApk.InstallStatus[] Values ()
			{
				const string __id = "values.()[Lcom/google/ar/core/ArCoreApk$InstallStatus;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Google.AR.Core.ArCoreApk.InstallStatus[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.ArCoreApk.InstallStatus));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.UserMessageType']"
		[global::Android.Runtime.Register ("com/google/ar/core/ArCoreApk$UserMessageType", DoNotGenerateAcw=true)]
		public sealed partial class UserMessageType : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.UserMessageType']/field[@name='APPLICATION']"
			[Register ("APPLICATION")]
			public static global::Google.AR.Core.ArCoreApk.UserMessageType Application {
				get {
					const string __id = "APPLICATION.Lcom/google/ar/core/ArCoreApk$UserMessageType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.UserMessageType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.UserMessageType']/field[@name='FEATURE']"
			[Register ("FEATURE")]
			public static global::Google.AR.Core.ArCoreApk.UserMessageType Feature {
				get {
					const string __id = "FEATURE.Lcom/google/ar/core/ArCoreApk$UserMessageType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.UserMessageType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.UserMessageType']/field[@name='USER_ALREADY_INFORMED']"
			[Register ("USER_ALREADY_INFORMED")]
			public static global::Google.AR.Core.ArCoreApk.UserMessageType UserAlreadyInformed {
				get {
					const string __id = "USER_ALREADY_INFORMED.Lcom/google/ar/core/ArCoreApk$UserMessageType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.UserMessageType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/ArCoreApk$UserMessageType", typeof (UserMessageType));
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

			internal UserMessageType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.UserMessageType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/ArCoreApk$UserMessageType;", "")]
			public static unsafe global::Google.AR.Core.ArCoreApk.UserMessageType ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/ar/core/ArCoreApk$UserMessageType;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.UserMessageType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.UserMessageType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/ar/core/ArCoreApk$UserMessageType;", "")]
			public static unsafe global::Google.AR.Core.ArCoreApk.UserMessageType[] Values ()
			{
				const string __id = "values.()[Lcom/google/ar/core/ArCoreApk$UserMessageType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Google.AR.Core.ArCoreApk.UserMessageType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.ArCoreApk.UserMessageType));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/ArCoreApk", typeof (ArCoreApk));
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

		protected ArCoreApk (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk']/constructor[@name='ArCoreApk' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe ArCoreApk ()
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

		public static unsafe global::Google.AR.Core.ArCoreApk Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/google/ar/core/ArCoreApk;", "GetGetInstanceHandler")]
			get {
				const string __id = "getInstance.()Lcom/google/ar/core/ArCoreApk;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_checkAvailability_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetCheckAvailability_Landroid_content_Context_Handler ()
		{
			if (cb_checkAvailability_Landroid_content_Context_ == null)
				cb_checkAvailability_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CheckAvailability_Landroid_content_Context_);
			return cb_checkAvailability_Landroid_content_Context_;
		}

		static IntPtr n_CheckAvailability_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.AR.Core.ArCoreApk __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CheckAvailability (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk']/method[@name='checkAvailability' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkAvailability", "(Landroid/content/Context;)Lcom/google/ar/core/ArCoreApk$Availability;", "GetCheckAvailability_Landroid_content_Context_Handler")]
		public virtual unsafe global::Google.AR.Core.ArCoreApk.Availability CheckAvailability (global::Android.Content.Context p0)
		{
			const string __id = "checkAvailability.(Landroid/content/Context;)Lcom/google/ar/core/ArCoreApk$Availability;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.Availability> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_requestInstall_Landroid_app_Activity_Z;
#pragma warning disable 0169
		static Delegate GetRequestInstall_Landroid_app_Activity_ZHandler ()
		{
			if (cb_requestInstall_Landroid_app_Activity_Z == null)
				cb_requestInstall_Landroid_app_Activity_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_RequestInstall_Landroid_app_Activity_Z);
			return cb_requestInstall_Landroid_app_Activity_Z;
		}

		static IntPtr n_RequestInstall_Landroid_app_Activity_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Google.AR.Core.ArCoreApk __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RequestInstall (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk']/method[@name='requestInstall' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='boolean']]"
		[Register ("requestInstall", "(Landroid/app/Activity;Z)Lcom/google/ar/core/ArCoreApk$InstallStatus;", "GetRequestInstall_Landroid_app_Activity_ZHandler")]
		public virtual unsafe global::Google.AR.Core.ArCoreApk.InstallStatus RequestInstall (global::Android.App.Activity p0, bool p1)
		{
			const string __id = "requestInstall.(Landroid/app/Activity;Z)Lcom/google/ar/core/ArCoreApk$InstallStatus;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.InstallStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_requestInstall_Landroid_app_Activity_ZLcom_google_ar_core_ArCoreApk_InstallBehavior_Lcom_google_ar_core_ArCoreApk_UserMessageType_;
#pragma warning disable 0169
		static Delegate GetRequestInstall_Landroid_app_Activity_ZLcom_google_ar_core_ArCoreApk_InstallBehavior_Lcom_google_ar_core_ArCoreApk_UserMessageType_Handler ()
		{
			if (cb_requestInstall_Landroid_app_Activity_ZLcom_google_ar_core_ArCoreApk_InstallBehavior_Lcom_google_ar_core_ArCoreApk_UserMessageType_ == null)
				cb_requestInstall_Landroid_app_Activity_ZLcom_google_ar_core_ArCoreApk_InstallBehavior_Lcom_google_ar_core_ArCoreApk_UserMessageType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr, IntPtr, IntPtr>) n_RequestInstall_Landroid_app_Activity_ZLcom_google_ar_core_ArCoreApk_InstallBehavior_Lcom_google_ar_core_ArCoreApk_UserMessageType_);
			return cb_requestInstall_Landroid_app_Activity_ZLcom_google_ar_core_ArCoreApk_InstallBehavior_Lcom_google_ar_core_ArCoreApk_UserMessageType_;
		}

		static IntPtr n_RequestInstall_Landroid_app_Activity_ZLcom_google_ar_core_ArCoreApk_InstallBehavior_Lcom_google_ar_core_ArCoreApk_UserMessageType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Google.AR.Core.ArCoreApk __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.ArCoreApk.InstallBehavior p2 = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.InstallBehavior> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.ArCoreApk.UserMessageType p3 = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.UserMessageType> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RequestInstall (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk']/method[@name='requestInstall' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='boolean'] and parameter[3][@type='com.google.ar.core.ArCoreApk.InstallBehavior'] and parameter[4][@type='com.google.ar.core.ArCoreApk.UserMessageType']]"
		[Register ("requestInstall", "(Landroid/app/Activity;ZLcom/google/ar/core/ArCoreApk$InstallBehavior;Lcom/google/ar/core/ArCoreApk$UserMessageType;)Lcom/google/ar/core/ArCoreApk$InstallStatus;", "GetRequestInstall_Landroid_app_Activity_ZLcom_google_ar_core_ArCoreApk_InstallBehavior_Lcom_google_ar_core_ArCoreApk_UserMessageType_Handler")]
		public virtual unsafe global::Google.AR.Core.ArCoreApk.InstallStatus RequestInstall (global::Android.App.Activity p0, bool p1, global::Google.AR.Core.ArCoreApk.InstallBehavior p2, global::Google.AR.Core.ArCoreApk.UserMessageType p3)
		{
			const string __id = "requestInstall.(Landroid/app/Activity;ZLcom/google/ar/core/ArCoreApk$InstallBehavior;Lcom/google/ar/core/ArCoreApk$UserMessageType;)Lcom/google/ar/core/ArCoreApk$InstallStatus;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.InstallStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
