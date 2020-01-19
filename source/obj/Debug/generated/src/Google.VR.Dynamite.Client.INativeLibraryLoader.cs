using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Google.VR.Dynamite.Client {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.vr.dynamite.client']/interface[@name='INativeLibraryLoader']"
	[Register ("com/google/vr/dynamite/client/INativeLibraryLoader", "", "Google.VR.Dynamite.Client.INativeLibraryLoaderInvoker")]
	public partial interface INativeLibraryLoader : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.vr.dynamite.client']/interface[@name='INativeLibraryLoader']/method[@name='checkVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("checkVersion", "(Ljava/lang/String;)I", "GetCheckVersion_Ljava_lang_String_Handler:Google.VR.Dynamite.Client.INativeLibraryLoaderInvoker, Xamarin.Google.ARCore")]
		int CheckVersion (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.vr.dynamite.client']/interface[@name='INativeLibraryLoader']/method[@name='initializeAndLoadNativeLibrary' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("initializeAndLoadNativeLibrary", "(Ljava/lang/String;)J", "GetInitializeAndLoadNativeLibrary_Ljava_lang_String_Handler:Google.VR.Dynamite.Client.INativeLibraryLoaderInvoker, Xamarin.Google.ARCore")]
		long InitializeAndLoadNativeLibrary (string p0);

	}

	[global::Android.Runtime.Register ("com/google/vr/dynamite/client/INativeLibraryLoader", DoNotGenerateAcw=true)]
	internal class INativeLibraryLoaderInvoker : global::Java.Lang.Object, INativeLibraryLoader {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/google/vr/dynamite/client/INativeLibraryLoader", typeof (INativeLibraryLoaderInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static INativeLibraryLoader GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INativeLibraryLoader> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.vr.dynamite.client.INativeLibraryLoader"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INativeLibraryLoaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_checkVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCheckVersion_Ljava_lang_String_Handler ()
		{
			if (cb_checkVersion_Ljava_lang_String_ == null)
				cb_checkVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CheckVersion_Ljava_lang_String_);
			return cb_checkVersion_Ljava_lang_String_;
		}

		static int n_CheckVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.VR.Dynamite.Client.INativeLibraryLoader __this = global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.INativeLibraryLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CheckVersion (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_checkVersion_Ljava_lang_String_;
		public unsafe int CheckVersion (string p0)
		{
			if (id_checkVersion_Ljava_lang_String_ == IntPtr.Zero)
				id_checkVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "checkVersion", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_checkVersion_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_initializeAndLoadNativeLibrary_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInitializeAndLoadNativeLibrary_Ljava_lang_String_Handler ()
		{
			if (cb_initializeAndLoadNativeLibrary_Ljava_lang_String_ == null)
				cb_initializeAndLoadNativeLibrary_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_InitializeAndLoadNativeLibrary_Ljava_lang_String_);
			return cb_initializeAndLoadNativeLibrary_Ljava_lang_String_;
		}

		static long n_InitializeAndLoadNativeLibrary_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.VR.Dynamite.Client.INativeLibraryLoader __this = global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.INativeLibraryLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.InitializeAndLoadNativeLibrary (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_initializeAndLoadNativeLibrary_Ljava_lang_String_;
		public unsafe long InitializeAndLoadNativeLibrary (string p0)
		{
			if (id_initializeAndLoadNativeLibrary_Ljava_lang_String_ == IntPtr.Zero)
				id_initializeAndLoadNativeLibrary_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "initializeAndLoadNativeLibrary", "(Ljava/lang/String;)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			long __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_initializeAndLoadNativeLibrary_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.VR.Dynamite.Client.INativeLibraryLoader __this = global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.INativeLibraryLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		IntPtr id_asBinder;
		public unsafe global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
		}

	}

}
