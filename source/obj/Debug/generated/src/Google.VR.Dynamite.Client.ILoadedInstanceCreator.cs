using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Google.VR.Dynamite.Client {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.vr.dynamite.client']/interface[@name='ILoadedInstanceCreator']"
	[Register ("com/google/vr/dynamite/client/ILoadedInstanceCreator", "", "Google.VR.Dynamite.Client.ILoadedInstanceCreatorInvoker")]
	public partial interface ILoadedInstanceCreator : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.vr.dynamite.client']/interface[@name='ILoadedInstanceCreator']/method[@name='newNativeLibraryLoader' and count(parameter)=2 and parameter[1][@type='com.google.vr.dynamite.client.IObjectWrapper'] and parameter[2][@type='com.google.vr.dynamite.client.IObjectWrapper']]"
		[Register ("newNativeLibraryLoader", "(Lcom/google/vr/dynamite/client/IObjectWrapper;Lcom/google/vr/dynamite/client/IObjectWrapper;)Lcom/google/vr/dynamite/client/INativeLibraryLoader;", "GetNewNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_Handler:Google.VR.Dynamite.Client.ILoadedInstanceCreatorInvoker, Xamarin.Google.ARCore")]
		global::Google.VR.Dynamite.Client.INativeLibraryLoader NewNativeLibraryLoader (global::Google.VR.Dynamite.Client.IObjectWrapper p0, global::Google.VR.Dynamite.Client.IObjectWrapper p1);

	}

	[global::Android.Runtime.Register ("com/google/vr/dynamite/client/ILoadedInstanceCreator", DoNotGenerateAcw=true)]
	internal class ILoadedInstanceCreatorInvoker : global::Java.Lang.Object, ILoadedInstanceCreator {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/google/vr/dynamite/client/ILoadedInstanceCreator", typeof (ILoadedInstanceCreatorInvoker));

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

		public static ILoadedInstanceCreator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILoadedInstanceCreator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.vr.dynamite.client.ILoadedInstanceCreator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILoadedInstanceCreatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_newNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_;
#pragma warning disable 0169
		static Delegate GetNewNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_Handler ()
		{
			if (cb_newNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_ == null)
				cb_newNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_NewNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_);
			return cb_newNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_;
		}

		static IntPtr n_NewNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Google.VR.Dynamite.Client.ILoadedInstanceCreator __this = global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.ILoadedInstanceCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.VR.Dynamite.Client.IObjectWrapper p0 = (global::Google.VR.Dynamite.Client.IObjectWrapper)global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.IObjectWrapper> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Google.VR.Dynamite.Client.IObjectWrapper p1 = (global::Google.VR.Dynamite.Client.IObjectWrapper)global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.IObjectWrapper> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewNativeLibraryLoader (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_newNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_;
		public unsafe global::Google.VR.Dynamite.Client.INativeLibraryLoader NewNativeLibraryLoader (global::Google.VR.Dynamite.Client.IObjectWrapper p0, global::Google.VR.Dynamite.Client.IObjectWrapper p1)
		{
			if (id_newNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_ == IntPtr.Zero)
				id_newNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_ = JNIEnv.GetMethodID (class_ref, "newNativeLibraryLoader", "(Lcom/google/vr/dynamite/client/IObjectWrapper;Lcom/google/vr/dynamite/client/IObjectWrapper;)Lcom/google/vr/dynamite/client/INativeLibraryLoader;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Google.VR.Dynamite.Client.INativeLibraryLoader __ret = global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.INativeLibraryLoader> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Google.VR.Dynamite.Client.ILoadedInstanceCreator __this = global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.ILoadedInstanceCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
