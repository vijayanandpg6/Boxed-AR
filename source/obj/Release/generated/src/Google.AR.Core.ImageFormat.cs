using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageFormat']"
	[global::Android.Runtime.Register ("com/google/ar/core/ImageFormat", DoNotGenerateAcw=true)]
	public partial class ImageFormat : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageFormat']/field[@name='RGBA_FP16']"
		[Register ("RGBA_FP16")]
		public const int RgbaFp16 = (int) 22;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageFormat']/field[@name='YUV_420_888']"
		[Register ("YUV_420_888")]
		public const int Yuv420888 = (int) 35;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/ImageFormat", typeof (ImageFormat));
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

		protected ImageFormat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
