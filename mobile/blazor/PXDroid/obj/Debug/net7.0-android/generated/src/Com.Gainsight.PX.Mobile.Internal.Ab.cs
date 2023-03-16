using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Gainsight.PX.Mobile.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ab']"
	[global::Android.Runtime.Register ("com/gainsight/px/mobile/internal/ab", DoNotGenerateAcw=true)]
	public partial class Ab : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/gainsight/px/mobile/internal/ab", typeof (Ab));

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

		protected Ab (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate? cb_a_Landroid_content_Context_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetA_Landroid_content_Context_Landroid_net_Uri_Handler ()
		{
			if (cb_a_Landroid_content_Context_Landroid_net_Uri_ == null)
				cb_a_Landroid_content_Context_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_A_Landroid_content_Context_Landroid_net_Uri_);
			return cb_a_Landroid_content_Context_Landroid_net_Uri_;
		}

		static bool n_A_Landroid_content_Context_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Internal.Ab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.A (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile.internal']/class[@name='ab']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register ("a", "(Landroid/content/Context;Landroid/net/Uri;)Z", "GetA_Landroid_content_Context_Landroid_net_Uri_Handler")]
		public virtual unsafe bool A (global::Android.Content.Context? p0, global::Android.Net.Uri? p1)
		{
			const string __id = "a.(Landroid/content/Context;Landroid/net/Uri;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

	}
}
