using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Google.AR.Core {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.ar.core']/interface[@name='Trackable']"
	[Register ("com/google/ar/core/Trackable", "", "Google.AR.Core.ITrackableInvoker")]
	public partial interface ITrackable : IJavaObject {

		global::System.Collections.Generic.ICollection<global::Google.AR.Core.Anchor> Anchors {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/interface[@name='Trackable']/method[@name='getAnchors' and count(parameter)=0]"
			[Register ("getAnchors", "()Ljava/util/Collection;", "GetGetAnchorsHandler:Google.AR.Core.ITrackableInvoker, Xamarin.Google.ARCore")] get;
		}

		global::Google.AR.Core.TrackingState TrackingState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/interface[@name='Trackable']/method[@name='getTrackingState' and count(parameter)=0]"
			[Register ("getTrackingState", "()Lcom/google/ar/core/TrackingState;", "GetGetTrackingStateHandler:Google.AR.Core.ITrackableInvoker, Xamarin.Google.ARCore")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/interface[@name='Trackable']/method[@name='createAnchor' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Pose']]"
		[Register ("createAnchor", "(Lcom/google/ar/core/Pose;)Lcom/google/ar/core/Anchor;", "GetCreateAnchor_Lcom_google_ar_core_Pose_Handler:Google.AR.Core.ITrackableInvoker, Xamarin.Google.ARCore")]
		global::Google.AR.Core.Anchor CreateAnchor (global::Google.AR.Core.Pose p0);

	}

	[global::Android.Runtime.Register ("com/google/ar/core/Trackable", DoNotGenerateAcw=true)]
	internal class ITrackableInvoker : global::Java.Lang.Object, ITrackable {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/google/ar/core/Trackable", typeof (ITrackableInvoker));

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

		public static ITrackable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITrackable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.ar.core.Trackable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITrackableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAnchors;
#pragma warning disable 0169
		static Delegate GetGetAnchorsHandler ()
		{
			if (cb_getAnchors == null)
				cb_getAnchors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAnchors);
			return cb_getAnchors;
		}

		static IntPtr n_GetAnchors (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.ITrackable __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ITrackable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Google.AR.Core.Anchor>.ToLocalJniHandle (__this.Anchors);
		}
#pragma warning restore 0169

		IntPtr id_getAnchors;
		public unsafe global::System.Collections.Generic.ICollection<global::Google.AR.Core.Anchor> Anchors {
			get {
				if (id_getAnchors == IntPtr.Zero)
					id_getAnchors = JNIEnv.GetMethodID (class_ref, "getAnchors", "()Ljava/util/Collection;");
				return global::Android.Runtime.JavaCollection<global::Google.AR.Core.Anchor>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAnchors), JniHandleOwnership.TransferLocalRef);
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
			global::Google.AR.Core.ITrackable __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ITrackable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TrackingState);
		}
#pragma warning restore 0169

		IntPtr id_getTrackingState;
		public unsafe global::Google.AR.Core.TrackingState TrackingState {
			get {
				if (id_getTrackingState == IntPtr.Zero)
					id_getTrackingState = JNIEnv.GetMethodID (class_ref, "getTrackingState", "()Lcom/google/ar/core/TrackingState;");
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.TrackingState> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrackingState), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_createAnchor_Lcom_google_ar_core_Pose_;
#pragma warning disable 0169
		static Delegate GetCreateAnchor_Lcom_google_ar_core_Pose_Handler ()
		{
			if (cb_createAnchor_Lcom_google_ar_core_Pose_ == null)
				cb_createAnchor_Lcom_google_ar_core_Pose_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateAnchor_Lcom_google_ar_core_Pose_);
			return cb_createAnchor_Lcom_google_ar_core_Pose_;
		}

		static IntPtr n_CreateAnchor_Lcom_google_ar_core_Pose_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.AR.Core.ITrackable __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ITrackable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.Pose p0 = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateAnchor (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createAnchor_Lcom_google_ar_core_Pose_;
		public unsafe global::Google.AR.Core.Anchor CreateAnchor (global::Google.AR.Core.Pose p0)
		{
			if (id_createAnchor_Lcom_google_ar_core_Pose_ == IntPtr.Zero)
				id_createAnchor_Lcom_google_ar_core_Pose_ = JNIEnv.GetMethodID (class_ref, "createAnchor", "(Lcom/google/ar/core/Pose;)Lcom/google/ar/core/Anchor;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Google.AR.Core.Anchor __ret = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createAnchor_Lcom_google_ar_core_Pose_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
