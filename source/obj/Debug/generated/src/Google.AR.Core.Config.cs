using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config']"
	[global::Android.Runtime.Register ("com/google/ar/core/Config", DoNotGenerateAcw=true)]
	public partial class Config : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.AugmentedFaceMode']"
		[global::Android.Runtime.Register ("com/google/ar/core/Config$AugmentedFaceMode", DoNotGenerateAcw=true)]
		public sealed partial class AugmentedFaceMode : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.AugmentedFaceMode']/field[@name='DISABLED']"
			[Register ("DISABLED")]
			public static global::Google.AR.Core.Config.AugmentedFaceMode Disabled {
				get {
					const string __id = "DISABLED.Lcom/google/ar/core/Config$AugmentedFaceMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.AugmentedFaceMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.AugmentedFaceMode']/field[@name='MESH3D']"
			[Register ("MESH3D")]
			public static global::Google.AR.Core.Config.AugmentedFaceMode Mesh3d {
				get {
					const string __id = "MESH3D.Lcom/google/ar/core/Config$AugmentedFaceMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.AugmentedFaceMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/Config$AugmentedFaceMode", typeof (AugmentedFaceMode));
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

			internal AugmentedFaceMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.AugmentedFaceMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/Config$AugmentedFaceMode;", "")]
			public static unsafe global::Google.AR.Core.Config.AugmentedFaceMode ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/ar/core/Config$AugmentedFaceMode;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.AugmentedFaceMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.AugmentedFaceMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/ar/core/Config$AugmentedFaceMode;", "")]
			public static unsafe global::Google.AR.Core.Config.AugmentedFaceMode[] Values ()
			{
				const string __id = "values.()[Lcom/google/ar/core/Config$AugmentedFaceMode;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Google.AR.Core.Config.AugmentedFaceMode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.Config.AugmentedFaceMode));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.CloudAnchorMode']"
		[global::Android.Runtime.Register ("com/google/ar/core/Config$CloudAnchorMode", DoNotGenerateAcw=true)]
		public sealed partial class CloudAnchorMode : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.CloudAnchorMode']/field[@name='DISABLED']"
			[Register ("DISABLED")]
			public static global::Google.AR.Core.Config.CloudAnchorMode Disabled {
				get {
					const string __id = "DISABLED.Lcom/google/ar/core/Config$CloudAnchorMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.CloudAnchorMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.CloudAnchorMode']/field[@name='ENABLED']"
			[Register ("ENABLED")]
			public static global::Google.AR.Core.Config.CloudAnchorMode Enabled {
				get {
					const string __id = "ENABLED.Lcom/google/ar/core/Config$CloudAnchorMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.CloudAnchorMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/Config$CloudAnchorMode", typeof (CloudAnchorMode));
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

			internal CloudAnchorMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.CloudAnchorMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/Config$CloudAnchorMode;", "")]
			public static unsafe global::Google.AR.Core.Config.CloudAnchorMode ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/ar/core/Config$CloudAnchorMode;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.CloudAnchorMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.CloudAnchorMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/ar/core/Config$CloudAnchorMode;", "")]
			public static unsafe global::Google.AR.Core.Config.CloudAnchorMode[] Values ()
			{
				const string __id = "values.()[Lcom/google/ar/core/Config$CloudAnchorMode;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Google.AR.Core.Config.CloudAnchorMode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.Config.CloudAnchorMode));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.FocusMode']"
		[global::Android.Runtime.Register ("com/google/ar/core/Config$FocusMode", DoNotGenerateAcw=true)]
		public sealed partial class FocusMode : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.FocusMode']/field[@name='AUTO']"
			[Register ("AUTO")]
			public static global::Google.AR.Core.Config.FocusMode Auto {
				get {
					const string __id = "AUTO.Lcom/google/ar/core/Config$FocusMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.FocusMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.FocusMode']/field[@name='FIXED']"
			[Register ("FIXED")]
			public static global::Google.AR.Core.Config.FocusMode Fixed {
				get {
					const string __id = "FIXED.Lcom/google/ar/core/Config$FocusMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.FocusMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/Config$FocusMode", typeof (FocusMode));
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

			internal FocusMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.FocusMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/Config$FocusMode;", "")]
			public static unsafe global::Google.AR.Core.Config.FocusMode ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/ar/core/Config$FocusMode;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.FocusMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.FocusMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/ar/core/Config$FocusMode;", "")]
			public static unsafe global::Google.AR.Core.Config.FocusMode[] Values ()
			{
				const string __id = "values.()[Lcom/google/ar/core/Config$FocusMode;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Google.AR.Core.Config.FocusMode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.Config.FocusMode));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.LightEstimationMode']"
		[global::Android.Runtime.Register ("com/google/ar/core/Config$LightEstimationMode", DoNotGenerateAcw=true)]
		public sealed partial class LightEstimationMode : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.LightEstimationMode']/field[@name='AMBIENT_INTENSITY']"
			[Register ("AMBIENT_INTENSITY")]
			public static global::Google.AR.Core.Config.LightEstimationMode AmbientIntensity {
				get {
					const string __id = "AMBIENT_INTENSITY.Lcom/google/ar/core/Config$LightEstimationMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.LightEstimationMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.LightEstimationMode']/field[@name='DISABLED']"
			[Register ("DISABLED")]
			public static global::Google.AR.Core.Config.LightEstimationMode Disabled {
				get {
					const string __id = "DISABLED.Lcom/google/ar/core/Config$LightEstimationMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.LightEstimationMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.LightEstimationMode']/field[@name='ENVIRONMENTAL_HDR']"
			[Register ("ENVIRONMENTAL_HDR")]
			public static global::Google.AR.Core.Config.LightEstimationMode EnvironmentalHdr {
				get {
					const string __id = "ENVIRONMENTAL_HDR.Lcom/google/ar/core/Config$LightEstimationMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.LightEstimationMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/Config$LightEstimationMode", typeof (LightEstimationMode));
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

			internal LightEstimationMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.LightEstimationMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/Config$LightEstimationMode;", "")]
			public static unsafe global::Google.AR.Core.Config.LightEstimationMode ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/ar/core/Config$LightEstimationMode;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.LightEstimationMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.LightEstimationMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/ar/core/Config$LightEstimationMode;", "")]
			public static unsafe global::Google.AR.Core.Config.LightEstimationMode[] Values ()
			{
				const string __id = "values.()[Lcom/google/ar/core/Config$LightEstimationMode;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Google.AR.Core.Config.LightEstimationMode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.Config.LightEstimationMode));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.PlaneFindingMode']"
		[global::Android.Runtime.Register ("com/google/ar/core/Config$PlaneFindingMode", DoNotGenerateAcw=true)]
		public sealed partial class PlaneFindingMode : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.PlaneFindingMode']/field[@name='DISABLED']"
			[Register ("DISABLED")]
			public static global::Google.AR.Core.Config.PlaneFindingMode Disabled {
				get {
					const string __id = "DISABLED.Lcom/google/ar/core/Config$PlaneFindingMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.PlaneFindingMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.PlaneFindingMode']/field[@name='HORIZONTAL']"
			[Register ("HORIZONTAL")]
			public static global::Google.AR.Core.Config.PlaneFindingMode Horizontal {
				get {
					const string __id = "HORIZONTAL.Lcom/google/ar/core/Config$PlaneFindingMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.PlaneFindingMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.PlaneFindingMode']/field[@name='HORIZONTAL_AND_VERTICAL']"
			[Register ("HORIZONTAL_AND_VERTICAL")]
			public static global::Google.AR.Core.Config.PlaneFindingMode HorizontalAndVertical {
				get {
					const string __id = "HORIZONTAL_AND_VERTICAL.Lcom/google/ar/core/Config$PlaneFindingMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.PlaneFindingMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.PlaneFindingMode']/field[@name='VERTICAL']"
			[Register ("VERTICAL")]
			public static global::Google.AR.Core.Config.PlaneFindingMode Vertical {
				get {
					const string __id = "VERTICAL.Lcom/google/ar/core/Config$PlaneFindingMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.PlaneFindingMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/Config$PlaneFindingMode", typeof (PlaneFindingMode));
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

			internal PlaneFindingMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.PlaneFindingMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/Config$PlaneFindingMode;", "")]
			public static unsafe global::Google.AR.Core.Config.PlaneFindingMode ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/ar/core/Config$PlaneFindingMode;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.PlaneFindingMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.PlaneFindingMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/ar/core/Config$PlaneFindingMode;", "")]
			public static unsafe global::Google.AR.Core.Config.PlaneFindingMode[] Values ()
			{
				const string __id = "values.()[Lcom/google/ar/core/Config$PlaneFindingMode;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Google.AR.Core.Config.PlaneFindingMode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.Config.PlaneFindingMode));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.UpdateMode']"
		[global::Android.Runtime.Register ("com/google/ar/core/Config$UpdateMode", DoNotGenerateAcw=true)]
		public sealed partial class UpdateMode : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.UpdateMode']/field[@name='BLOCKING']"
			[Register ("BLOCKING")]
			public static global::Google.AR.Core.Config.UpdateMode Blocking {
				get {
					const string __id = "BLOCKING.Lcom/google/ar/core/Config$UpdateMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.UpdateMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.UpdateMode']/field[@name='LATEST_CAMERA_IMAGE']"
			[Register ("LATEST_CAMERA_IMAGE")]
			public static global::Google.AR.Core.Config.UpdateMode LatestCameraImage {
				get {
					const string __id = "LATEST_CAMERA_IMAGE.Lcom/google/ar/core/Config$UpdateMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.UpdateMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/Config$UpdateMode", typeof (UpdateMode));
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

			internal UpdateMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.UpdateMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/Config$UpdateMode;", "")]
			public static unsafe global::Google.AR.Core.Config.UpdateMode ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/ar/core/Config$UpdateMode;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.UpdateMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.UpdateMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/ar/core/Config$UpdateMode;", "")]
			public static unsafe global::Google.AR.Core.Config.UpdateMode[] Values ()
			{
				const string __id = "values.()[Lcom/google/ar/core/Config$UpdateMode;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Google.AR.Core.Config.UpdateMode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.Config.UpdateMode));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/Config", typeof (Config));
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

		protected Config (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config']/constructor[@name='Config' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe Config ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config']/constructor[@name='Config' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Session']]"
		[Register (".ctor", "(Lcom/google/ar/core/Session;)V", "")]
		public unsafe Config (global::Google.AR.Core.Session p0)
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

		static Delegate cb_getAugmentedImageDatabase;
#pragma warning disable 0169
		static Delegate GetGetAugmentedImageDatabaseHandler ()
		{
			if (cb_getAugmentedImageDatabase == null)
				cb_getAugmentedImageDatabase = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAugmentedImageDatabase);
			return cb_getAugmentedImageDatabase;
		}

		static IntPtr n_GetAugmentedImageDatabase (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Config __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AugmentedImageDatabase);
		}
#pragma warning restore 0169

		public virtual unsafe global::Google.AR.Core.AugmentedImageDatabase AugmentedImageDatabase {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config']/method[@name='getAugmentedImageDatabase' and count(parameter)=0]"
			[Register ("getAugmentedImageDatabase", "()Lcom/google/ar/core/AugmentedImageDatabase;", "GetGetAugmentedImageDatabaseHandler")]
			get {
				const string __id = "getAugmentedImageDatabase.()Lcom/google/ar/core/AugmentedImageDatabase;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedImageDatabase> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAugmentedFaceMode;
#pragma warning disable 0169
		static Delegate GetGetAugmentedFaceModeHandler ()
		{
			if (cb_getAugmentedFaceMode == null)
				cb_getAugmentedFaceMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAugmentedFaceMode);
			return cb_getAugmentedFaceMode;
		}

		static IntPtr n_GetAugmentedFaceMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Config __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetAugmentedFaceMode ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config']/method[@name='getAugmentedFaceMode' and count(parameter)=0]"
		[Register ("getAugmentedFaceMode", "()Lcom/google/ar/core/Config$AugmentedFaceMode;", "GetGetAugmentedFaceModeHandler")]
		public virtual unsafe global::Google.AR.Core.Config.AugmentedFaceMode GetAugmentedFaceMode ()
		{
			const string __id = "getAugmentedFaceMode.()Lcom/google/ar/core/Config$AugmentedFaceMode;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.AugmentedFaceMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getCloudAnchorMode;
#pragma warning disable 0169
		static Delegate GetGetCloudAnchorModeHandler ()
		{
			if (cb_getCloudAnchorMode == null)
				cb_getCloudAnchorMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCloudAnchorMode);
			return cb_getCloudAnchorMode;
		}

		static IntPtr n_GetCloudAnchorMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Config __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetCloudAnchorMode ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config']/method[@name='getCloudAnchorMode' and count(parameter)=0]"
		[Register ("getCloudAnchorMode", "()Lcom/google/ar/core/Config$CloudAnchorMode;", "GetGetCloudAnchorModeHandler")]
		public virtual unsafe global::Google.AR.Core.Config.CloudAnchorMode GetCloudAnchorMode ()
		{
			const string __id = "getCloudAnchorMode.()Lcom/google/ar/core/Config$CloudAnchorMode;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.CloudAnchorMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getFocusMode;
#pragma warning disable 0169
		static Delegate GetGetFocusModeHandler ()
		{
			if (cb_getFocusMode == null)
				cb_getFocusMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFocusMode);
			return cb_getFocusMode;
		}

		static IntPtr n_GetFocusMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Config __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetFocusMode ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config']/method[@name='getFocusMode' and count(parameter)=0]"
		[Register ("getFocusMode", "()Lcom/google/ar/core/Config$FocusMode;", "GetGetFocusModeHandler")]
		public virtual unsafe global::Google.AR.Core.Config.FocusMode GetFocusMode ()
		{
			const string __id = "getFocusMode.()Lcom/google/ar/core/Config$FocusMode;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.FocusMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getLightEstimationMode;
#pragma warning disable 0169
		static Delegate GetGetLightEstimationModeHandler ()
		{
			if (cb_getLightEstimationMode == null)
				cb_getLightEstimationMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLightEstimationMode);
			return cb_getLightEstimationMode;
		}

		static IntPtr n_GetLightEstimationMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Config __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetLightEstimationMode ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config']/method[@name='getLightEstimationMode' and count(parameter)=0]"
		[Register ("getLightEstimationMode", "()Lcom/google/ar/core/Config$LightEstimationMode;", "GetGetLightEstimationModeHandler")]
		public virtual unsafe global::Google.AR.Core.Config.LightEstimationMode GetLightEstimationMode ()
		{
			const string __id = "getLightEstimationMode.()Lcom/google/ar/core/Config$LightEstimationMode;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.LightEstimationMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getPlaneFindingMode;
#pragma warning disable 0169
		static Delegate GetGetPlaneFindingModeHandler ()
		{
			if (cb_getPlaneFindingMode == null)
				cb_getPlaneFindingMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlaneFindingMode);
			return cb_getPlaneFindingMode;
		}

		static IntPtr n_GetPlaneFindingMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Config __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetPlaneFindingMode ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config']/method[@name='getPlaneFindingMode' and count(parameter)=0]"
		[Register ("getPlaneFindingMode", "()Lcom/google/ar/core/Config$PlaneFindingMode;", "GetGetPlaneFindingModeHandler")]
		public virtual unsafe global::Google.AR.Core.Config.PlaneFindingMode GetPlaneFindingMode ()
		{
			const string __id = "getPlaneFindingMode.()Lcom/google/ar/core/Config$PlaneFindingMode;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.PlaneFindingMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getUpdateMode;
#pragma warning disable 0169
		static Delegate GetGetUpdateModeHandler ()
		{
			if (cb_getUpdateMode == null)
				cb_getUpdateMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUpdateMode);
			return cb_getUpdateMode;
		}

		static IntPtr n_GetUpdateMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Config __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetUpdateMode ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config']/method[@name='getUpdateMode' and count(parameter)=0]"
		[Register ("getUpdateMode", "()Lcom/google/ar/core/Config$UpdateMode;", "GetGetUpdateModeHandler")]
		public virtual unsafe global::Google.AR.Core.Config.UpdateMode GetUpdateMode ()
		{
			const string __id = "getUpdateMode.()Lcom/google/ar/core/Config$UpdateMode;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.UpdateMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setAugmentedFaceMode_Lcom_google_ar_core_Config_AugmentedFaceMode_;
#pragma warning disable 0169
		static Delegate GetSetAugmentedFaceMode_Lcom_google_ar_core_Config_AugmentedFaceMode_Handler ()
		{
			if (cb_setAugmentedFaceMode_Lcom_google_ar_core_Config_AugmentedFaceMode_ == null)
				cb_setAugmentedFaceMode_Lcom_google_ar_core_Config_AugmentedFaceMode_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAugmentedFaceMode_Lcom_google_ar_core_Config_AugmentedFaceMode_);
			return cb_setAugmentedFaceMode_Lcom_google_ar_core_Config_AugmentedFaceMode_;
		}

		static IntPtr n_SetAugmentedFaceMode_Lcom_google_ar_core_Config_AugmentedFaceMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.AR.Core.Config __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.Config.AugmentedFaceMode p0 = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.AugmentedFaceMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAugmentedFaceMode (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config']/method[@name='setAugmentedFaceMode' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Config.AugmentedFaceMode']]"
		[Register ("setAugmentedFaceMode", "(Lcom/google/ar/core/Config$AugmentedFaceMode;)Lcom/google/ar/core/Config;", "GetSetAugmentedFaceMode_Lcom_google_ar_core_Config_AugmentedFaceMode_Handler")]
		public virtual unsafe global::Google.AR.Core.Config SetAugmentedFaceMode (global::Google.AR.Core.Config.AugmentedFaceMode p0)
		{
			const string __id = "setAugmentedFaceMode.(Lcom/google/ar/core/Config$AugmentedFaceMode;)Lcom/google/ar/core/Config;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setAugmentedImageDatabase_Lcom_google_ar_core_AugmentedImageDatabase_;
#pragma warning disable 0169
		static Delegate GetSetAugmentedImageDatabase_Lcom_google_ar_core_AugmentedImageDatabase_Handler ()
		{
			if (cb_setAugmentedImageDatabase_Lcom_google_ar_core_AugmentedImageDatabase_ == null)
				cb_setAugmentedImageDatabase_Lcom_google_ar_core_AugmentedImageDatabase_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAugmentedImageDatabase_Lcom_google_ar_core_AugmentedImageDatabase_);
			return cb_setAugmentedImageDatabase_Lcom_google_ar_core_AugmentedImageDatabase_;
		}

		static IntPtr n_SetAugmentedImageDatabase_Lcom_google_ar_core_AugmentedImageDatabase_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.AR.Core.Config __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.AugmentedImageDatabase p0 = global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedImageDatabase> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAugmentedImageDatabase (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config']/method[@name='setAugmentedImageDatabase' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.AugmentedImageDatabase']]"
		[Register ("setAugmentedImageDatabase", "(Lcom/google/ar/core/AugmentedImageDatabase;)Lcom/google/ar/core/Config;", "GetSetAugmentedImageDatabase_Lcom_google_ar_core_AugmentedImageDatabase_Handler")]
		public virtual unsafe global::Google.AR.Core.Config SetAugmentedImageDatabase (global::Google.AR.Core.AugmentedImageDatabase p0)
		{
			const string __id = "setAugmentedImageDatabase.(Lcom/google/ar/core/AugmentedImageDatabase;)Lcom/google/ar/core/Config;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setCloudAnchorMode_Lcom_google_ar_core_Config_CloudAnchorMode_;
#pragma warning disable 0169
		static Delegate GetSetCloudAnchorMode_Lcom_google_ar_core_Config_CloudAnchorMode_Handler ()
		{
			if (cb_setCloudAnchorMode_Lcom_google_ar_core_Config_CloudAnchorMode_ == null)
				cb_setCloudAnchorMode_Lcom_google_ar_core_Config_CloudAnchorMode_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCloudAnchorMode_Lcom_google_ar_core_Config_CloudAnchorMode_);
			return cb_setCloudAnchorMode_Lcom_google_ar_core_Config_CloudAnchorMode_;
		}

		static IntPtr n_SetCloudAnchorMode_Lcom_google_ar_core_Config_CloudAnchorMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.AR.Core.Config __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.Config.CloudAnchorMode p0 = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.CloudAnchorMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCloudAnchorMode (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config']/method[@name='setCloudAnchorMode' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Config.CloudAnchorMode']]"
		[Register ("setCloudAnchorMode", "(Lcom/google/ar/core/Config$CloudAnchorMode;)Lcom/google/ar/core/Config;", "GetSetCloudAnchorMode_Lcom_google_ar_core_Config_CloudAnchorMode_Handler")]
		public virtual unsafe global::Google.AR.Core.Config SetCloudAnchorMode (global::Google.AR.Core.Config.CloudAnchorMode p0)
		{
			const string __id = "setCloudAnchorMode.(Lcom/google/ar/core/Config$CloudAnchorMode;)Lcom/google/ar/core/Config;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setFocusMode_Lcom_google_ar_core_Config_FocusMode_;
#pragma warning disable 0169
		static Delegate GetSetFocusMode_Lcom_google_ar_core_Config_FocusMode_Handler ()
		{
			if (cb_setFocusMode_Lcom_google_ar_core_Config_FocusMode_ == null)
				cb_setFocusMode_Lcom_google_ar_core_Config_FocusMode_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetFocusMode_Lcom_google_ar_core_Config_FocusMode_);
			return cb_setFocusMode_Lcom_google_ar_core_Config_FocusMode_;
		}

		static IntPtr n_SetFocusMode_Lcom_google_ar_core_Config_FocusMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.AR.Core.Config __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.Config.FocusMode p0 = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.FocusMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFocusMode (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config']/method[@name='setFocusMode' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Config.FocusMode']]"
		[Register ("setFocusMode", "(Lcom/google/ar/core/Config$FocusMode;)Lcom/google/ar/core/Config;", "GetSetFocusMode_Lcom_google_ar_core_Config_FocusMode_Handler")]
		public virtual unsafe global::Google.AR.Core.Config SetFocusMode (global::Google.AR.Core.Config.FocusMode p0)
		{
			const string __id = "setFocusMode.(Lcom/google/ar/core/Config$FocusMode;)Lcom/google/ar/core/Config;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setLightEstimationMode_Lcom_google_ar_core_Config_LightEstimationMode_;
#pragma warning disable 0169
		static Delegate GetSetLightEstimationMode_Lcom_google_ar_core_Config_LightEstimationMode_Handler ()
		{
			if (cb_setLightEstimationMode_Lcom_google_ar_core_Config_LightEstimationMode_ == null)
				cb_setLightEstimationMode_Lcom_google_ar_core_Config_LightEstimationMode_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetLightEstimationMode_Lcom_google_ar_core_Config_LightEstimationMode_);
			return cb_setLightEstimationMode_Lcom_google_ar_core_Config_LightEstimationMode_;
		}

		static IntPtr n_SetLightEstimationMode_Lcom_google_ar_core_Config_LightEstimationMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.AR.Core.Config __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.Config.LightEstimationMode p0 = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.LightEstimationMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetLightEstimationMode (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config']/method[@name='setLightEstimationMode' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Config.LightEstimationMode']]"
		[Register ("setLightEstimationMode", "(Lcom/google/ar/core/Config$LightEstimationMode;)Lcom/google/ar/core/Config;", "GetSetLightEstimationMode_Lcom_google_ar_core_Config_LightEstimationMode_Handler")]
		public virtual unsafe global::Google.AR.Core.Config SetLightEstimationMode (global::Google.AR.Core.Config.LightEstimationMode p0)
		{
			const string __id = "setLightEstimationMode.(Lcom/google/ar/core/Config$LightEstimationMode;)Lcom/google/ar/core/Config;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPlaneFindingMode_Lcom_google_ar_core_Config_PlaneFindingMode_;
#pragma warning disable 0169
		static Delegate GetSetPlaneFindingMode_Lcom_google_ar_core_Config_PlaneFindingMode_Handler ()
		{
			if (cb_setPlaneFindingMode_Lcom_google_ar_core_Config_PlaneFindingMode_ == null)
				cb_setPlaneFindingMode_Lcom_google_ar_core_Config_PlaneFindingMode_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPlaneFindingMode_Lcom_google_ar_core_Config_PlaneFindingMode_);
			return cb_setPlaneFindingMode_Lcom_google_ar_core_Config_PlaneFindingMode_;
		}

		static IntPtr n_SetPlaneFindingMode_Lcom_google_ar_core_Config_PlaneFindingMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.AR.Core.Config __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.Config.PlaneFindingMode p0 = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.PlaneFindingMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPlaneFindingMode (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config']/method[@name='setPlaneFindingMode' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Config.PlaneFindingMode']]"
		[Register ("setPlaneFindingMode", "(Lcom/google/ar/core/Config$PlaneFindingMode;)Lcom/google/ar/core/Config;", "GetSetPlaneFindingMode_Lcom_google_ar_core_Config_PlaneFindingMode_Handler")]
		public virtual unsafe global::Google.AR.Core.Config SetPlaneFindingMode (global::Google.AR.Core.Config.PlaneFindingMode p0)
		{
			const string __id = "setPlaneFindingMode.(Lcom/google/ar/core/Config$PlaneFindingMode;)Lcom/google/ar/core/Config;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setUpdateMode_Lcom_google_ar_core_Config_UpdateMode_;
#pragma warning disable 0169
		static Delegate GetSetUpdateMode_Lcom_google_ar_core_Config_UpdateMode_Handler ()
		{
			if (cb_setUpdateMode_Lcom_google_ar_core_Config_UpdateMode_ == null)
				cb_setUpdateMode_Lcom_google_ar_core_Config_UpdateMode_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetUpdateMode_Lcom_google_ar_core_Config_UpdateMode_);
			return cb_setUpdateMode_Lcom_google_ar_core_Config_UpdateMode_;
		}

		static IntPtr n_SetUpdateMode_Lcom_google_ar_core_Config_UpdateMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.AR.Core.Config __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.Config.UpdateMode p0 = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.UpdateMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUpdateMode (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config']/method[@name='setUpdateMode' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Config.UpdateMode']]"
		[Register ("setUpdateMode", "(Lcom/google/ar/core/Config$UpdateMode;)Lcom/google/ar/core/Config;", "GetSetUpdateMode_Lcom_google_ar_core_Config_UpdateMode_Handler")]
		public virtual unsafe global::Google.AR.Core.Config SetUpdateMode (global::Google.AR.Core.Config.UpdateMode p0)
		{
			const string __id = "setUpdateMode.(Lcom/google/ar/core/Config$UpdateMode;)Lcom/google/ar/core/Config;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
