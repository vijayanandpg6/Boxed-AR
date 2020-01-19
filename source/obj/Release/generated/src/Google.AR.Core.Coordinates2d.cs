using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='Coordinates2d']"
	[global::Android.Runtime.Register ("com/google/ar/core/Coordinates2d", DoNotGenerateAcw=true)]
	public sealed partial class Coordinates2d : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Coordinates2d']/field[@name='IMAGE_NORMALIZED']"
		[Register ("IMAGE_NORMALIZED")]
		public static global::Google.AR.Core.Coordinates2d ImageNormalized {
			get {
				const string __id = "IMAGE_NORMALIZED.Lcom/google/ar/core/Coordinates2d;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Coordinates2d> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Coordinates2d']/field[@name='IMAGE_PIXELS']"
		[Register ("IMAGE_PIXELS")]
		public static global::Google.AR.Core.Coordinates2d ImagePixels {
			get {
				const string __id = "IMAGE_PIXELS.Lcom/google/ar/core/Coordinates2d;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Coordinates2d> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Coordinates2d']/field[@name='OPENGL_NORMALIZED_DEVICE_COORDINATES']"
		[Register ("OPENGL_NORMALIZED_DEVICE_COORDINATES")]
		public static global::Google.AR.Core.Coordinates2d OpenglNormalizedDeviceCoordinates {
			get {
				const string __id = "OPENGL_NORMALIZED_DEVICE_COORDINATES.Lcom/google/ar/core/Coordinates2d;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Coordinates2d> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Coordinates2d']/field[@name='TEXTURE_NORMALIZED']"
		[Register ("TEXTURE_NORMALIZED")]
		public static global::Google.AR.Core.Coordinates2d TextureNormalized {
			get {
				const string __id = "TEXTURE_NORMALIZED.Lcom/google/ar/core/Coordinates2d;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Coordinates2d> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Coordinates2d']/field[@name='TEXTURE_TEXELS']"
		[Register ("TEXTURE_TEXELS")]
		public static global::Google.AR.Core.Coordinates2d TextureTexels {
			get {
				const string __id = "TEXTURE_TEXELS.Lcom/google/ar/core/Coordinates2d;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Coordinates2d> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Coordinates2d']/field[@name='VIEW']"
		[Register ("VIEW")]
		public static global::Google.AR.Core.Coordinates2d View {
			get {
				const string __id = "VIEW.Lcom/google/ar/core/Coordinates2d;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Coordinates2d> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Coordinates2d']/field[@name='VIEW_NORMALIZED']"
		[Register ("VIEW_NORMALIZED")]
		public static global::Google.AR.Core.Coordinates2d ViewNormalized {
			get {
				const string __id = "VIEW_NORMALIZED.Lcom/google/ar/core/Coordinates2d;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Coordinates2d> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/Coordinates2d", typeof (Coordinates2d));
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

		internal Coordinates2d (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Coordinates2d']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/Coordinates2d;", "")]
		public static unsafe global::Google.AR.Core.Coordinates2d ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/ar/core/Coordinates2d;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Coordinates2d> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Coordinates2d']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/ar/core/Coordinates2d;", "")]
		public static unsafe global::Google.AR.Core.Coordinates2d[] Values ()
		{
			const string __id = "values.()[Lcom/google/ar/core/Coordinates2d;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Google.AR.Core.Coordinates2d[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.Coordinates2d));
			} finally {
			}
		}

	}
}
