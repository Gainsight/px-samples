using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Gainsight.PX.Mobile.Tracker {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/class[@name='ae']"
	[global::Android.Runtime.Register ("com/gainsight/px/mobile/tracker/ae", DoNotGenerateAcw=true)]
	public partial class Ae : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/gainsight/px/mobile/tracker/ae", typeof (Ae));

		internal static IntPtr class_ref {
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
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected Ae (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Tracker.Ae> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.A ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/class[@name='ae']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Landroid/view/MotionEvent;", "GetAHandler")]
		public virtual unsafe global::Android.Views.MotionEvent? A ()
		{
			const string __id = "a.()Landroid/view/MotionEvent;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_b;
#pragma warning disable 0169
		static Delegate GetBHandler ()
		{
			if (cb_b == null)
				cb_b = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_B);
			return cb_b;
		}

		static IntPtr n_B (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Tracker.Ae> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.B ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/class[@name='ae']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Landroid/view/View;", "GetBHandler")]
		public virtual unsafe global::Android.Views.View? B ()
		{
			const string __id = "b.()Landroid/view/View;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
