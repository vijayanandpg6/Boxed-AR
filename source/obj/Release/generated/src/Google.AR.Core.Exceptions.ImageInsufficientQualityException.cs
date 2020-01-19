using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Google.AR.Core.Exceptions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core.exceptions']/class[@name='ImageInsufficientQualityException']"
	[global::Android.Runtime.Register ("com/google/ar/core/exceptions/ImageInsufficientQualityException", DoNotGenerateAcw=true)]
	public partial class ImageInsufficientQualityException : global::Java.Lang.IllegalArgumentException {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/exceptions/ImageInsufficientQualityException", typeof (ImageInsufficientQualityException));
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

		protected ImageInsufficientQualityException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core.exceptions']/class[@name='ImageInsufficientQualityException']/constructor[@name='ImageInsufficientQualityException' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ImageInsufficientQualityException ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

	}
}
