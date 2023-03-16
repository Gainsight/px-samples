using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Gainsight.PX.Mobile.Tracker {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/class[@name='ab']"
	[global::Android.Runtime.Register ("com/gainsight/px/mobile/tracker/ab", DoNotGenerateAcw=true)]
	public sealed partial class Ab : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/gainsight/px/mobile/tracker/ab", typeof (Ab));

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

		internal Ab (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/class[@name='ab']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("a", "(Landroid/app/Activity;)V", "")]
		public static unsafe void A (global::Android.App.Activity? p0)
		{
			const string __id = "a.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/class[@name='ab']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.gainsight.px.mobile.tracker.ad']]"
		[Register ("a", "(Landroid/app/Activity;Lcom/gainsight/px/mobile/tracker/ad;)V", "")]
		public static unsafe void A (global::Android.App.Activity? p0, global::Com.Gainsight.PX.Mobile.Tracker.IAd? p1)
		{
			const string __id = "a.(Landroid/app/Activity;Lcom/gainsight/px/mobile/tracker/ad;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.tracker']/class[@name='ab']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.util.List&lt;com.gainsight.px.mobile.tracker.ad&gt;'] and parameter[3][@type='boolean']]"
		[Register ("a", "(Landroid/app/Activity;Ljava/util/List;Z)V", "")]
		public static unsafe void A (global::Android.App.Activity? p0, global::System.Collections.Generic.IList<global::Com.Gainsight.PX.Mobile.Tracker.IAd>? p1, bool p2)
		{
			const string __id = "a.(Landroid/app/Activity;Ljava/util/List;Z)V";
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Gainsight.PX.Mobile.Tracker.IAd>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

	}
}
