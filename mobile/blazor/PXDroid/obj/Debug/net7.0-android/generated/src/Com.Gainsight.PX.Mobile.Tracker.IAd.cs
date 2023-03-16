using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Gainsight.PX.Mobile.Tracker {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/interface[@name='ad']"
	[Register ("com/gainsight/px/mobile/tracker/ad", "", "Com.Gainsight.PX.Mobile.Tracker.IAdInvoker")]
	public partial interface IAd : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/interface[@name='ad']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/lang/String;", "GetAHandler:Com.Gainsight.PX.Mobile.Tracker.IAdInvoker, PXDroid")]
		string? A ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/interface[@name='ad']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.view.KeyEvent']]"
		[Register ("a", "(Landroid/view/KeyEvent;)Z", "GetA_Landroid_view_KeyEvent_Handler:Com.Gainsight.PX.Mobile.Tracker.IAdInvoker, PXDroid")]
		bool A (global::Android.Views.KeyEvent? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/interface[@name='ad']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.gainsight.px.mobile.tracker.ae']]"
		[Register ("a", "(Lcom/gainsight/px/mobile/tracker/ae;)V", "GetA_Lcom_gainsight_px_mobile_tracker_ae_Handler:Com.Gainsight.PX.Mobile.Tracker.IAdInvoker, PXDroid")]
		void A (global::Com.Gainsight.PX.Mobile.Tracker.Ae? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/interface[@name='ad']/method[@name='onMenuItemSelected' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.MenuItem']]"
		[Register ("onMenuItemSelected", "(ILandroid/view/MenuItem;)V", "GetOnMenuItemSelected_ILandroid_view_MenuItem_Handler:Com.Gainsight.PX.Mobile.Tracker.IAdInvoker, PXDroid")]
		void OnMenuItemSelected (int p0, global::Android.Views.IMenuItem? p1);

	}

	[global::Android.Runtime.Register ("com/gainsight/px/mobile/tracker/ad", DoNotGenerateAcw=true)]
	internal partial class IAdInvoker : global::Java.Lang.Object, IAd {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/gainsight/px/mobile/tracker/ad", typeof (IAdInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IAd? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAd> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.gainsight.px.mobile.tracker.ad'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_A);
			return cb_a;
		}

		static IntPtr n_A (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Tracker.IAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.A ());
		}
#pragma warning restore 0169

		IntPtr id_a;
		public unsafe string? A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_a), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_a_Landroid_view_KeyEvent_;
#pragma warning disable 0169
		static Delegate GetA_Landroid_view_KeyEvent_Handler ()
		{
			if (cb_a_Landroid_view_KeyEvent_ == null)
				cb_a_Landroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_A_Landroid_view_KeyEvent_);
			return cb_a_Landroid_view_KeyEvent_;
		}

		static bool n_A_Landroid_view_KeyEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Tracker.IAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.A (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_a_Landroid_view_KeyEvent_;
		public unsafe bool A (global::Android.Views.KeyEvent? p0)
		{
			if (id_a_Landroid_view_KeyEvent_ == IntPtr.Zero)
				id_a_Landroid_view_KeyEvent_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/view/KeyEvent;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_a_Landroid_view_KeyEvent_, __args);
			return __ret;
		}

		static Delegate? cb_a_Lcom_gainsight_px_mobile_tracker_ae_;
#pragma warning disable 0169
		static Delegate GetA_Lcom_gainsight_px_mobile_tracker_ae_Handler ()
		{
			if (cb_a_Lcom_gainsight_px_mobile_tracker_ae_ == null)
				cb_a_Lcom_gainsight_px_mobile_tracker_ae_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_A_Lcom_gainsight_px_mobile_tracker_ae_);
			return cb_a_Lcom_gainsight_px_mobile_tracker_ae_;
		}

		static void n_A_Lcom_gainsight_px_mobile_tracker_ae_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Tracker.IAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Tracker.Ae> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		IntPtr id_a_Lcom_gainsight_px_mobile_tracker_ae_;
		public unsafe void A (global::Com.Gainsight.PX.Mobile.Tracker.Ae? p0)
		{
			if (id_a_Lcom_gainsight_px_mobile_tracker_ae_ == IntPtr.Zero)
				id_a_Lcom_gainsight_px_mobile_tracker_ae_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/gainsight/px/mobile/tracker/ae;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_Lcom_gainsight_px_mobile_tracker_ae_, __args);
		}

		static Delegate? cb_onMenuItemSelected_ILandroid_view_MenuItem_;
#pragma warning disable 0169
		static Delegate GetOnMenuItemSelected_ILandroid_view_MenuItem_Handler ()
		{
			if (cb_onMenuItemSelected_ILandroid_view_MenuItem_ == null)
				cb_onMenuItemSelected_ILandroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_OnMenuItemSelected_ILandroid_view_MenuItem_);
			return cb_onMenuItemSelected_ILandroid_view_MenuItem_;
		}

		static void n_OnMenuItemSelected_ILandroid_view_MenuItem_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Tracker.IAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (global::Android.Views.IMenuItem?)global::Java.Lang.Object.GetObject<global::Android.Views.IMenuItem> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnMenuItemSelected (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onMenuItemSelected_ILandroid_view_MenuItem_;
		public unsafe void OnMenuItemSelected (int p0, global::Android.Views.IMenuItem? p1)
		{
			if (id_onMenuItemSelected_ILandroid_view_MenuItem_ == IntPtr.Zero)
				id_onMenuItemSelected_ILandroid_view_MenuItem_ = JNIEnv.GetMethodID (class_ref, "onMenuItemSelected", "(ILandroid/view/MenuItem;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMenuItemSelected_ILandroid_view_MenuItem_, __args);
		}

	}
}
