using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedImageDatabase']"
	[global::Android.Runtime.Register ("com/google/ar/core/AugmentedImageDatabase", DoNotGenerateAcw=true)]
	public partial class AugmentedImageDatabase : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/AugmentedImageDatabase", typeof (AugmentedImageDatabase));
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

		protected AugmentedImageDatabase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedImageDatabase']/constructor[@name='AugmentedImageDatabase' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Session']]"
		[Register (".ctor", "(Lcom/google/ar/core/Session;)V", "")]
		public unsafe AugmentedImageDatabase (global::Google.AR.Core.Session p0)
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

		static Delegate cb_getNumImages;
#pragma warning disable 0169
		static Delegate GetGetNumImagesHandler ()
		{
			if (cb_getNumImages == null)
				cb_getNumImages = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumImages);
			return cb_getNumImages;
		}

		static int n_GetNumImages (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.AugmentedImageDatabase __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedImageDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumImages;
		}
#pragma warning restore 0169

		public virtual unsafe int NumImages {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedImageDatabase']/method[@name='getNumImages' and count(parameter)=0]"
			[Register ("getNumImages", "()I", "GetGetNumImagesHandler")]
			get {
				const string __id = "getNumImages.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_addImage_Ljava_lang_String_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetAddImage_Ljava_lang_String_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_addImage_Ljava_lang_String_Landroid_graphics_Bitmap_ == null)
				cb_addImage_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_AddImage_Ljava_lang_String_Landroid_graphics_Bitmap_);
			return cb_addImage_Ljava_lang_String_Landroid_graphics_Bitmap_;
		}

		static int n_AddImage_Ljava_lang_String_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Google.AR.Core.AugmentedImageDatabase __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedImageDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.AddImage (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedImageDatabase']/method[@name='addImage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register ("addImage", "(Ljava/lang/String;Landroid/graphics/Bitmap;)I", "GetAddImage_Ljava_lang_String_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe int AddImage (string p0, global::Android.Graphics.Bitmap p1)
		{
			const string __id = "addImage.(Ljava/lang/String;Landroid/graphics/Bitmap;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_addImage_Ljava_lang_String_Landroid_graphics_Bitmap_F;
#pragma warning disable 0169
		static Delegate GetAddImage_Ljava_lang_String_Landroid_graphics_Bitmap_FHandler ()
		{
			if (cb_addImage_Ljava_lang_String_Landroid_graphics_Bitmap_F == null)
				cb_addImage_Ljava_lang_String_Landroid_graphics_Bitmap_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, float, int>) n_AddImage_Ljava_lang_String_Landroid_graphics_Bitmap_F);
			return cb_addImage_Ljava_lang_String_Landroid_graphics_Bitmap_F;
		}

		static int n_AddImage_Ljava_lang_String_Landroid_graphics_Bitmap_F (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, float p2)
		{
			global::Google.AR.Core.AugmentedImageDatabase __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedImageDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.AddImage (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedImageDatabase']/method[@name='addImage' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='float']]"
		[Register ("addImage", "(Ljava/lang/String;Landroid/graphics/Bitmap;F)I", "GetAddImage_Ljava_lang_String_Landroid_graphics_Bitmap_FHandler")]
		public virtual unsafe int AddImage (string p0, global::Android.Graphics.Bitmap p1, float p2)
		{
			const string __id = "addImage.(Ljava/lang/String;Landroid/graphics/Bitmap;F)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedImageDatabase']/method[@name='deserialize' and count(parameter)=2 and parameter[1][@type='com.google.ar.core.Session'] and parameter[2][@type='java.io.InputStream']]"
		[Register ("deserialize", "(Lcom/google/ar/core/Session;Ljava/io/InputStream;)Lcom/google/ar/core/AugmentedImageDatabase;", "")]
		public static unsafe global::Google.AR.Core.AugmentedImageDatabase Deserialize (global::Google.AR.Core.Session p0, global::System.IO.Stream p1)
		{
			const string __id = "deserialize.(Lcom/google/ar/core/Session;Ljava/io/InputStream;)Lcom/google/ar/core/AugmentedImageDatabase;";
			IntPtr native_p1 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedImageDatabase> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_serialize_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetSerialize_Ljava_io_OutputStream_Handler ()
		{
			if (cb_serialize_Ljava_io_OutputStream_ == null)
				cb_serialize_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Serialize_Ljava_io_OutputStream_);
			return cb_serialize_Ljava_io_OutputStream_;
		}

		static void n_Serialize_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.AR.Core.AugmentedImageDatabase __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.AugmentedImageDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Serialize (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='AugmentedImageDatabase']/method[@name='serialize' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("serialize", "(Ljava/io/OutputStream;)V", "GetSerialize_Ljava_io_OutputStream_Handler")]
		public virtual unsafe void Serialize (global::System.IO.Stream p0)
		{
			const string __id = "serialize.(Ljava/io/OutputStream;)V";
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
