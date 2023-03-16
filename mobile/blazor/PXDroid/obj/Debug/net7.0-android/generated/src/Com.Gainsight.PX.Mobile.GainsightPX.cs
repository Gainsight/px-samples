using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Gainsight.PX.Mobile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']"
	[global::Android.Runtime.Register ("com/gainsight/px/mobile/GainsightPX", DoNotGenerateAcw=true)]
	public partial class GainsightPX : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX.Builder']"
		[global::Android.Runtime.Register ("com/gainsight/px/mobile/GainsightPX$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/gainsight/px/mobile/GainsightPX$Builder", typeof (Builder));

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

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX.Builder']/constructor[@name='GainsightPX.Builder' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
			public unsafe Builder (global::Android.Content.Context? p0, string? p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/content/Context;Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [1] = new JniArgumentValue (native_p1);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX.Builder']/constructor[@name='GainsightPX.Builder' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.gainsight.px.mobile.GainsightPX.ExceptionHandler']]"
			[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Lcom/gainsight/px/mobile/GainsightPX$ExceptionHandler;)V", "")]
			public unsafe Builder (global::Android.Content.Context? p0, string? p1, global::Com.Gainsight.PX.Mobile.GainsightPX.IExceptionHandler? p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/content/Context;Ljava/lang/String;Lcom/gainsight/px/mobile/GainsightPX$ExceptionHandler;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p2);
				}
			}

			static Delegate? cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/gainsight/px/mobile/GainsightPX;", "GetBuildHandler")]
			public virtual unsafe global::Com.Gainsight.PX.Mobile.GainsightPX? Build ()
			{
				const string __id = "build.()Lcom/gainsight/px/mobile/GainsightPX;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_collectDeviceId_Z;
#pragma warning disable 0169
			static Delegate GetCollectDeviceId_ZHandler ()
			{
				if (cb_collectDeviceId_Z == null)
					cb_collectDeviceId_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_CollectDeviceId_Z);
				return cb_collectDeviceId_Z;
			}

			static IntPtr n_CollectDeviceId_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.CollectDeviceId (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX.Builder']/method[@name='collectDeviceId' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("collectDeviceId", "(Z)Lcom/gainsight/px/mobile/GainsightPX$Builder;", "GetCollectDeviceId_ZHandler")]
			public virtual unsafe global::Com.Gainsight.PX.Mobile.GainsightPX.Builder? CollectDeviceId (bool p0)
			{
				const string __id = "collectDeviceId.(Z)Lcom/gainsight/px/mobile/GainsightPX$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_connectionTimeout_ILjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
			static Delegate GetConnectionTimeout_ILjava_util_concurrent_TimeUnit_Handler ()
			{
				if (cb_connectionTimeout_ILjava_util_concurrent_TimeUnit_ == null)
					cb_connectionTimeout_ILjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_L) n_ConnectionTimeout_ILjava_util_concurrent_TimeUnit_);
				return cb_connectionTimeout_ILjava_util_concurrent_TimeUnit_;
			}

			static IntPtr n_ConnectionTimeout_ILjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ConnectionTimeout (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX.Builder']/method[@name='connectionTimeout' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
			[Register ("connectionTimeout", "(ILjava/util/concurrent/TimeUnit;)Lcom/gainsight/px/mobile/GainsightPX$Builder;", "GetConnectionTimeout_ILjava_util_concurrent_TimeUnit_Handler")]
			public virtual unsafe global::Com.Gainsight.PX.Mobile.GainsightPX.Builder? ConnectionTimeout (int p0, global::Java.Util.Concurrent.TimeUnit? p1)
			{
				const string __id = "connectionTimeout.(ILjava/util/concurrent/TimeUnit;)Lcom/gainsight/px/mobile/GainsightPX$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (p1);
				}
			}

			static Delegate? cb_crypto_Lcom_gainsight_px_mobile_Crypto_;
#pragma warning disable 0169
			static Delegate GetCrypto_Lcom_gainsight_px_mobile_Crypto_Handler ()
			{
				if (cb_crypto_Lcom_gainsight_px_mobile_Crypto_ == null)
					cb_crypto_Lcom_gainsight_px_mobile_Crypto_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Crypto_Lcom_gainsight_px_mobile_Crypto_);
				return cb_crypto_Lcom_gainsight_px_mobile_Crypto_;
			}

			static IntPtr n_Crypto_Lcom_gainsight_px_mobile_Crypto_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Crypto> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Crypto (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX.Builder']/method[@name='crypto' and count(parameter)=1 and parameter[1][@type='com.gainsight.px.mobile.Crypto']]"
			[Register ("crypto", "(Lcom/gainsight/px/mobile/Crypto;)Lcom/gainsight/px/mobile/GainsightPX$Builder;", "GetCrypto_Lcom_gainsight_px_mobile_Crypto_Handler")]
			public virtual unsafe global::Com.Gainsight.PX.Mobile.GainsightPX.Builder? Crypto (global::Com.Gainsight.PX.Mobile.Crypto? p0)
			{
				const string __id = "crypto.(Lcom/gainsight/px/mobile/Crypto;)Lcom/gainsight/px/mobile/GainsightPX$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			static Delegate? cb_engagementCallback_Lcom_gainsight_px_mobile_GainsightPX_EngagementCallback_;
#pragma warning disable 0169
			static Delegate GetEngagementCallback_Lcom_gainsight_px_mobile_GainsightPX_EngagementCallback_Handler ()
			{
				if (cb_engagementCallback_Lcom_gainsight_px_mobile_GainsightPX_EngagementCallback_ == null)
					cb_engagementCallback_Lcom_gainsight_px_mobile_GainsightPX_EngagementCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_EngagementCallback_Lcom_gainsight_px_mobile_GainsightPX_EngagementCallback_);
				return cb_engagementCallback_Lcom_gainsight_px_mobile_GainsightPX_EngagementCallback_;
			}

			static IntPtr n_EngagementCallback_Lcom_gainsight_px_mobile_GainsightPX_EngagementCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (global::Com.Gainsight.PX.Mobile.GainsightPX.IEngagementCallback?)global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.IEngagementCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.EngagementCallback (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX.Builder']/method[@name='engagementCallback' and count(parameter)=1 and parameter[1][@type='com.gainsight.px.mobile.GainsightPX.EngagementCallback']]"
			[Register ("engagementCallback", "(Lcom/gainsight/px/mobile/GainsightPX$EngagementCallback;)Lcom/gainsight/px/mobile/GainsightPX$Builder;", "GetEngagementCallback_Lcom_gainsight_px_mobile_GainsightPX_EngagementCallback_Handler")]
			public virtual unsafe global::Com.Gainsight.PX.Mobile.GainsightPX.Builder? EngagementCallback (global::Com.Gainsight.PX.Mobile.GainsightPX.IEngagementCallback? p0)
			{
				const string __id = "engagementCallback.(Lcom/gainsight/px/mobile/GainsightPX$EngagementCallback;)Lcom/gainsight/px/mobile/GainsightPX$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			static Delegate? cb_flushInterval_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
			static Delegate GetFlushInterval_JLjava_util_concurrent_TimeUnit_Handler ()
			{
				if (cb_flushInterval_JLjava_util_concurrent_TimeUnit_ == null)
					cb_flushInterval_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJL_L) n_FlushInterval_JLjava_util_concurrent_TimeUnit_);
				return cb_flushInterval_JLjava_util_concurrent_TimeUnit_;
			}

			static IntPtr n_FlushInterval_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FlushInterval (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX.Builder']/method[@name='flushInterval' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
			[Register ("flushInterval", "(JLjava/util/concurrent/TimeUnit;)Lcom/gainsight/px/mobile/GainsightPX$Builder;", "GetFlushInterval_JLjava_util_concurrent_TimeUnit_Handler")]
			public virtual unsafe global::Com.Gainsight.PX.Mobile.GainsightPX.Builder? FlushInterval (long p0, global::Java.Util.Concurrent.TimeUnit? p1)
			{
				const string __id = "flushInterval.(JLjava/util/concurrent/TimeUnit;)Lcom/gainsight/px/mobile/GainsightPX$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (p1);
				}
			}

			static Delegate? cb_flushQueueSize_I;
#pragma warning disable 0169
			static Delegate GetFlushQueueSize_IHandler ()
			{
				if (cb_flushQueueSize_I == null)
					cb_flushQueueSize_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_FlushQueueSize_I);
				return cb_flushQueueSize_I;
			}

			static IntPtr n_FlushQueueSize_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.FlushQueueSize (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX.Builder']/method[@name='flushQueueSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("flushQueueSize", "(I)Lcom/gainsight/px/mobile/GainsightPX$Builder;", "GetFlushQueueSize_IHandler")]
			public virtual unsafe global::Com.Gainsight.PX.Mobile.GainsightPX.Builder? FlushQueueSize (int p0)
			{
				const string __id = "flushQueueSize.(I)Lcom/gainsight/px/mobile/GainsightPX$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_isTrackTapInAllLayouts_Z;
#pragma warning disable 0169
			static Delegate GetIsTrackTapInAllLayouts_ZHandler ()
			{
				if (cb_isTrackTapInAllLayouts_Z == null)
					cb_isTrackTapInAllLayouts_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_IsTrackTapInAllLayouts_Z);
				return cb_isTrackTapInAllLayouts_Z;
			}

			static IntPtr n_IsTrackTapInAllLayouts_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.IsTrackTapInAllLayouts (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX.Builder']/method[@name='isTrackTapInAllLayouts' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("isTrackTapInAllLayouts", "(Z)Lcom/gainsight/px/mobile/GainsightPX$Builder;", "GetIsTrackTapInAllLayouts_ZHandler")]
			public virtual unsafe global::Com.Gainsight.PX.Mobile.GainsightPX.Builder? IsTrackTapInAllLayouts (bool p0)
			{
				const string __id = "isTrackTapInAllLayouts.(Z)Lcom/gainsight/px/mobile/GainsightPX$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_logLevel_Lcom_gainsight_px_mobile_LogLevel_;
#pragma warning disable 0169
			static Delegate GetLogLevel_Lcom_gainsight_px_mobile_LogLevel_Handler ()
			{
				if (cb_logLevel_Lcom_gainsight_px_mobile_LogLevel_ == null)
					cb_logLevel_Lcom_gainsight_px_mobile_LogLevel_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_LogLevel_Lcom_gainsight_px_mobile_LogLevel_);
				return cb_logLevel_Lcom_gainsight_px_mobile_LogLevel_;
			}

			static IntPtr n_LogLevel_Lcom_gainsight_px_mobile_LogLevel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.LogLevel> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LogLevel (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX.Builder']/method[@name='logLevel' and count(parameter)=1 and parameter[1][@type='com.gainsight.px.mobile.LogLevel']]"
			[Register ("logLevel", "(Lcom/gainsight/px/mobile/LogLevel;)Lcom/gainsight/px/mobile/GainsightPX$Builder;", "GetLogLevel_Lcom_gainsight_px_mobile_LogLevel_Handler")]
			public virtual unsafe global::Com.Gainsight.PX.Mobile.GainsightPX.Builder? LogLevel (global::Com.Gainsight.PX.Mobile.LogLevel? p0)
			{
				const string __id = "logLevel.(Lcom/gainsight/px/mobile/LogLevel;)Lcom/gainsight/px/mobile/GainsightPX$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			static Delegate? cb_maxQueueSize_I;
#pragma warning disable 0169
			static Delegate GetMaxQueueSize_IHandler ()
			{
				if (cb_maxQueueSize_I == null)
					cb_maxQueueSize_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_MaxQueueSize_I);
				return cb_maxQueueSize_I;
			}

			static IntPtr n_MaxQueueSize_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.MaxQueueSize (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX.Builder']/method[@name='maxQueueSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("maxQueueSize", "(I)Lcom/gainsight/px/mobile/GainsightPX$Builder;", "GetMaxQueueSize_IHandler")]
			public virtual unsafe global::Com.Gainsight.PX.Mobile.GainsightPX.Builder? MaxQueueSize (int p0)
			{
				const string __id = "maxQueueSize.(I)Lcom/gainsight/px/mobile/GainsightPX$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_proxy_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetProxy_Ljava_lang_String_Handler ()
			{
				if (cb_proxy_Ljava_lang_String_ == null)
					cb_proxy_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Proxy_Ljava_lang_String_);
				return cb_proxy_Ljava_lang_String_;
			}

			static IntPtr n_Proxy_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Proxy (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX.Builder']/method[@name='proxy' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("proxy", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/GainsightPX$Builder;", "GetProxy_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Gainsight.PX.Mobile.GainsightPX.Builder? Proxy (string? p0)
			{
				const string __id = "proxy.(Ljava/lang/String;)Lcom/gainsight/px/mobile/GainsightPX$Builder;";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate? cb_pxHost_Lcom_gainsight_px_mobile_GainsightPX_PXHost_;
#pragma warning disable 0169
			static Delegate GetPxHost_Lcom_gainsight_px_mobile_GainsightPX_PXHost_Handler ()
			{
				if (cb_pxHost_Lcom_gainsight_px_mobile_GainsightPX_PXHost_ == null)
					cb_pxHost_Lcom_gainsight_px_mobile_GainsightPX_PXHost_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PxHost_Lcom_gainsight_px_mobile_GainsightPX_PXHost_);
				return cb_pxHost_Lcom_gainsight_px_mobile_GainsightPX_PXHost_;
			}

			static IntPtr n_PxHost_Lcom_gainsight_px_mobile_GainsightPX_PXHost_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.PXHost> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PxHost (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX.Builder']/method[@name='pxHost' and count(parameter)=1 and parameter[1][@type='com.gainsight.px.mobile.GainsightPX.PXHost']]"
			[Register ("pxHost", "(Lcom/gainsight/px/mobile/GainsightPX$PXHost;)Lcom/gainsight/px/mobile/GainsightPX$Builder;", "GetPxHost_Lcom_gainsight_px_mobile_GainsightPX_PXHost_Handler")]
			public virtual unsafe global::Com.Gainsight.PX.Mobile.GainsightPX.Builder? PxHost (global::Com.Gainsight.PX.Mobile.GainsightPX.PXHost? p0)
			{
				const string __id = "pxHost.(Lcom/gainsight/px/mobile/GainsightPX$PXHost;)Lcom/gainsight/px/mobile/GainsightPX$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			static Delegate? cb_pxHost_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetPxHost_Ljava_lang_String_Handler ()
			{
				if (cb_pxHost_Ljava_lang_String_ == null)
					cb_pxHost_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PxHost_Ljava_lang_String_);
				return cb_pxHost_Ljava_lang_String_;
			}

			static IntPtr n_PxHost_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PxHost (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX.Builder']/method[@name='pxHost' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("pxHost", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/GainsightPX$Builder;", "GetPxHost_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Gainsight.PX.Mobile.GainsightPX.Builder? PxHost (string? p0)
			{
				const string __id = "pxHost.(Ljava/lang/String;)Lcom/gainsight/px/mobile/GainsightPX$Builder;";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate? cb_readTimeout_ILjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
			static Delegate GetReadTimeout_ILjava_util_concurrent_TimeUnit_Handler ()
			{
				if (cb_readTimeout_ILjava_util_concurrent_TimeUnit_ == null)
					cb_readTimeout_ILjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_L) n_ReadTimeout_ILjava_util_concurrent_TimeUnit_);
				return cb_readTimeout_ILjava_util_concurrent_TimeUnit_;
			}

			static IntPtr n_ReadTimeout_ILjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ReadTimeout (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX.Builder']/method[@name='readTimeout' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
			[Register ("readTimeout", "(ILjava/util/concurrent/TimeUnit;)Lcom/gainsight/px/mobile/GainsightPX$Builder;", "GetReadTimeout_ILjava_util_concurrent_TimeUnit_Handler")]
			public virtual unsafe global::Com.Gainsight.PX.Mobile.GainsightPX.Builder? ReadTimeout (int p0, global::Java.Util.Concurrent.TimeUnit? p1)
			{
				const string __id = "readTimeout.(ILjava/util/concurrent/TimeUnit;)Lcom/gainsight/px/mobile/GainsightPX$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (p1);
				}
			}

			static Delegate? cb_recordScreenViews_Z;
#pragma warning disable 0169
			static Delegate GetRecordScreenViews_ZHandler ()
			{
				if (cb_recordScreenViews_Z == null)
					cb_recordScreenViews_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_RecordScreenViews_Z);
				return cb_recordScreenViews_Z;
			}

			static IntPtr n_RecordScreenViews_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.RecordScreenViews (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX.Builder']/method[@name='recordScreenViews' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("recordScreenViews", "(Z)Lcom/gainsight/px/mobile/GainsightPX$Builder;", "GetRecordScreenViews_ZHandler")]
			public virtual unsafe global::Com.Gainsight.PX.Mobile.GainsightPX.Builder? RecordScreenViews (bool p0)
			{
				const string __id = "recordScreenViews.(Z)Lcom/gainsight/px/mobile/GainsightPX$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_shouldReportIssuesToServer_Z;
#pragma warning disable 0169
			static Delegate GetShouldReportIssuesToServer_ZHandler ()
			{
				if (cb_shouldReportIssuesToServer_Z == null)
					cb_shouldReportIssuesToServer_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_ShouldReportIssuesToServer_Z);
				return cb_shouldReportIssuesToServer_Z;
			}

			static IntPtr n_ShouldReportIssuesToServer_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.ShouldReportIssuesToServer (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX.Builder']/method[@name='shouldReportIssuesToServer' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("shouldReportIssuesToServer", "(Z)Lcom/gainsight/px/mobile/GainsightPX$Builder;", "GetShouldReportIssuesToServer_ZHandler")]
			public virtual unsafe global::Com.Gainsight.PX.Mobile.GainsightPX.Builder? ShouldReportIssuesToServer (bool p0)
			{
				const string __id = "shouldReportIssuesToServer.(Z)Lcom/gainsight/px/mobile/GainsightPX$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_shouldTrackTapEvents_Z;
#pragma warning disable 0169
			static Delegate GetShouldTrackTapEvents_ZHandler ()
			{
				if (cb_shouldTrackTapEvents_Z == null)
					cb_shouldTrackTapEvents_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_ShouldTrackTapEvents_Z);
				return cb_shouldTrackTapEvents_Z;
			}

			static IntPtr n_ShouldTrackTapEvents_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.ShouldTrackTapEvents (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX.Builder']/method[@name='shouldTrackTapEvents' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("shouldTrackTapEvents", "(Z)Lcom/gainsight/px/mobile/GainsightPX$Builder;", "GetShouldTrackTapEvents_ZHandler")]
			public virtual unsafe global::Com.Gainsight.PX.Mobile.GainsightPX.Builder? ShouldTrackTapEvents (bool p0)
			{
				const string __id = "shouldTrackTapEvents.(Z)Lcom/gainsight/px/mobile/GainsightPX$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_tag_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetTag_Ljava_lang_String_Handler ()
			{
				if (cb_tag_Ljava_lang_String_ == null)
					cb_tag_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Tag_Ljava_lang_String_);
				return cb_tag_Ljava_lang_String_;
			}

			static IntPtr n_Tag_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Tag (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX.Builder']/method[@name='tag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("tag", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/GainsightPX$Builder;", "GetTag_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Gainsight.PX.Mobile.GainsightPX.Builder? Tag (string? p0)
			{
				const string __id = "tag.(Ljava/lang/String;)Lcom/gainsight/px/mobile/GainsightPX$Builder;";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate? cb_trackApplicationCrash_Z;
#pragma warning disable 0169
			static Delegate GetTrackApplicationCrash_ZHandler ()
			{
				if (cb_trackApplicationCrash_Z == null)
					cb_trackApplicationCrash_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_TrackApplicationCrash_Z);
				return cb_trackApplicationCrash_Z;
			}

			static IntPtr n_TrackApplicationCrash_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.TrackApplicationCrash (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX.Builder']/method[@name='trackApplicationCrash' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("trackApplicationCrash", "(Z)Lcom/gainsight/px/mobile/GainsightPX$Builder;", "GetTrackApplicationCrash_ZHandler")]
			public virtual unsafe global::Com.Gainsight.PX.Mobile.GainsightPX.Builder? TrackApplicationCrash (bool p0)
			{
				const string __id = "trackApplicationCrash.(Z)Lcom/gainsight/px/mobile/GainsightPX$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_trackApplicationLifecycleEvents_Z;
#pragma warning disable 0169
			static Delegate GetTrackApplicationLifecycleEvents_ZHandler ()
			{
				if (cb_trackApplicationLifecycleEvents_Z == null)
					cb_trackApplicationLifecycleEvents_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_TrackApplicationLifecycleEvents_Z);
				return cb_trackApplicationLifecycleEvents_Z;
			}

			static IntPtr n_TrackApplicationLifecycleEvents_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.TrackApplicationLifecycleEvents (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX.Builder']/method[@name='trackApplicationLifecycleEvents' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("trackApplicationLifecycleEvents", "(Z)Lcom/gainsight/px/mobile/GainsightPX$Builder;", "GetTrackApplicationLifecycleEvents_ZHandler")]
			public virtual unsafe global::Com.Gainsight.PX.Mobile.GainsightPX.Builder? TrackApplicationLifecycleEvents (bool p0)
			{
				const string __id = "trackApplicationLifecycleEvents.(Z)Lcom/gainsight/px/mobile/GainsightPX$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.gainsight.px.mobile']/interface[@name='GainsightPX.EngagementCallback']"
		[Register ("com/gainsight/px/mobile/GainsightPX$EngagementCallback", "", "Com.Gainsight.PX.Mobile.GainsightPX/IEngagementCallbackInvoker")]
		public partial interface IEngagementCallback : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/interface[@name='GainsightPX.EngagementCallback']/method[@name='onCallback' and count(parameter)=1 and parameter[1][@type='com.gainsight.px.mobile.EngagementMetaData']]"
			[Register ("onCallback", "(Lcom/gainsight/px/mobile/EngagementMetaData;)Z", "GetOnCallback_Lcom_gainsight_px_mobile_EngagementMetaData_Handler:Com.Gainsight.PX.Mobile.GainsightPX/IEngagementCallbackInvoker, PXDroid")]
			bool OnCallback (global::Com.Gainsight.PX.Mobile.EngagementMetaData? p0);

		}

		[global::Android.Runtime.Register ("com/gainsight/px/mobile/GainsightPX$EngagementCallback", DoNotGenerateAcw=true)]
		internal partial class IEngagementCallbackInvoker : global::Java.Lang.Object, IEngagementCallback {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/gainsight/px/mobile/GainsightPX$EngagementCallback", typeof (IEngagementCallbackInvoker));

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

			public static IEngagementCallback? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IEngagementCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.gainsight.px.mobile.GainsightPX.EngagementCallback'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IEngagementCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_onCallback_Lcom_gainsight_px_mobile_EngagementMetaData_;
#pragma warning disable 0169
			static Delegate GetOnCallback_Lcom_gainsight_px_mobile_EngagementMetaData_Handler ()
			{
				if (cb_onCallback_Lcom_gainsight_px_mobile_EngagementMetaData_ == null)
					cb_onCallback_Lcom_gainsight_px_mobile_EngagementMetaData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_OnCallback_Lcom_gainsight_px_mobile_EngagementMetaData_);
				return cb_onCallback_Lcom_gainsight_px_mobile_EngagementMetaData_;
			}

			static bool n_OnCallback_Lcom_gainsight_px_mobile_EngagementMetaData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.IEngagementCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.EngagementMetaData> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnCallback (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onCallback_Lcom_gainsight_px_mobile_EngagementMetaData_;
			public unsafe bool OnCallback (global::Com.Gainsight.PX.Mobile.EngagementMetaData? p0)
			{
				if (id_onCallback_Lcom_gainsight_px_mobile_EngagementMetaData_ == IntPtr.Zero)
					id_onCallback_Lcom_gainsight_px_mobile_EngagementMetaData_ = JNIEnv.GetMethodID (class_ref, "onCallback", "(Lcom/gainsight/px/mobile/EngagementMetaData;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onCallback_Lcom_gainsight_px_mobile_EngagementMetaData_, __args);
				return __ret;
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.gainsight.px.mobile']/interface[@name='GainsightPX.ExceptionHandler']"
		[Register ("com/gainsight/px/mobile/GainsightPX$ExceptionHandler", "", "Com.Gainsight.PX.Mobile.GainsightPX/IExceptionHandlerInvoker")]
		public partial interface IExceptionHandler : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/interface[@name='GainsightPX.ExceptionHandler']/method[@name='onExceptionOccurred' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.gainsight.px.mobile.ValueMap'] and parameter[3][@type='java.lang.String']]"
			[Register ("onExceptionOccurred", "(Ljava/lang/String;Lcom/gainsight/px/mobile/ValueMap;Ljava/lang/String;)V", "GetOnExceptionOccurred_Ljava_lang_String_Lcom_gainsight_px_mobile_ValueMap_Ljava_lang_String_Handler:Com.Gainsight.PX.Mobile.GainsightPX/IExceptionHandlerInvoker, PXDroid")]
			void OnExceptionOccurred (string? p0, global::Com.Gainsight.PX.Mobile.ValueMap? p1, string? p2);

		}

		[global::Android.Runtime.Register ("com/gainsight/px/mobile/GainsightPX$ExceptionHandler", DoNotGenerateAcw=true)]
		internal partial class IExceptionHandlerInvoker : global::Java.Lang.Object, IExceptionHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/gainsight/px/mobile/GainsightPX$ExceptionHandler", typeof (IExceptionHandlerInvoker));

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

			public static IExceptionHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IExceptionHandler> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.gainsight.px.mobile.GainsightPX.ExceptionHandler'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IExceptionHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_onExceptionOccurred_Ljava_lang_String_Lcom_gainsight_px_mobile_ValueMap_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnExceptionOccurred_Ljava_lang_String_Lcom_gainsight_px_mobile_ValueMap_Ljava_lang_String_Handler ()
			{
				if (cb_onExceptionOccurred_Ljava_lang_String_Lcom_gainsight_px_mobile_ValueMap_Ljava_lang_String_ == null)
					cb_onExceptionOccurred_Ljava_lang_String_Lcom_gainsight_px_mobile_ValueMap_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_OnExceptionOccurred_Ljava_lang_String_Lcom_gainsight_px_mobile_ValueMap_Ljava_lang_String_);
				return cb_onExceptionOccurred_Ljava_lang_String_Lcom_gainsight_px_mobile_ValueMap_Ljava_lang_String_;
			}

			static void n_OnExceptionOccurred_Ljava_lang_String_Lcom_gainsight_px_mobile_ValueMap_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.IExceptionHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ValueMap> (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnExceptionOccurred (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onExceptionOccurred_Ljava_lang_String_Lcom_gainsight_px_mobile_ValueMap_Ljava_lang_String_;
			public unsafe void OnExceptionOccurred (string? p0, global::Com.Gainsight.PX.Mobile.ValueMap? p1, string? p2)
			{
				if (id_onExceptionOccurred_Ljava_lang_String_Lcom_gainsight_px_mobile_ValueMap_Ljava_lang_String_ == IntPtr.Zero)
					id_onExceptionOccurred_Ljava_lang_String_Lcom_gainsight_px_mobile_ValueMap_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onExceptionOccurred", "(Ljava/lang/String;Lcom/gainsight/px/mobile/ValueMap;Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				IntPtr native_p2 = JNIEnv.NewString ((string?)p2);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onExceptionOccurred_Ljava_lang_String_Lcom_gainsight_px_mobile_ValueMap_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX.PXHost']"
		[global::Android.Runtime.Register ("com/gainsight/px/mobile/GainsightPX$PXHost", DoNotGenerateAcw=true)]
		public sealed partial class PXHost : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX.PXHost']/field[@name='EU']"
			[Register ("EU")]
			public static global::Com.Gainsight.PX.Mobile.GainsightPX.PXHost? Eu {
				get {
					const string __id = "EU.Lcom/gainsight/px/mobile/GainsightPX$PXHost;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.PXHost> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX.PXHost']/field[@name='US']"
			[Register ("US")]
			public static global::Com.Gainsight.PX.Mobile.GainsightPX.PXHost? Us {
				get {
					const string __id = "US.Lcom/gainsight/px/mobile/GainsightPX$PXHost;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.PXHost> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX.PXHost']/field[@name='US2']"
			[Register ("US2")]
			public static global::Com.Gainsight.PX.Mobile.GainsightPX.PXHost? Us2 {
				get {
					const string __id = "US2.Lcom/gainsight/px/mobile/GainsightPX$PXHost;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.PXHost> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/gainsight/px/mobile/GainsightPX$PXHost", typeof (PXHost));

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

			internal PXHost (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX.PXHost']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/GainsightPX$PXHost;", "")]
			public static unsafe global::Com.Gainsight.PX.Mobile.GainsightPX.PXHost? ValueOf (string? p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/gainsight/px/mobile/GainsightPX$PXHost;";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.PXHost> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX.PXHost']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/gainsight/px/mobile/GainsightPX$PXHost;", "")]
			public static unsafe global::Com.Gainsight.PX.Mobile.GainsightPX.PXHost[]? Values ()
			{
				const string __id = "values.()[Lcom/gainsight/px/mobile/GainsightPX$PXHost;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Gainsight.PX.Mobile.GainsightPX.PXHost[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Gainsight.PX.Mobile.GainsightPX.PXHost));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/gainsight/px/mobile/GainsightPX", typeof (GainsightPX));

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

		protected GainsightPX (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate? cb_getApplication;
#pragma warning disable 0169
		static Delegate GetGetApplicationHandler ()
		{
			if (cb_getApplication == null)
				cb_getApplication = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetApplication);
			return cb_getApplication;
		}

		static IntPtr n_GetApplication (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Application);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.App.Application? Application {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='getApplication' and count(parameter)=0]"
			[Register ("getApplication", "()Landroid/app/Application;", "GetGetApplicationHandler")]
			get {
				const string __id = "getApplication.()Landroid/app/Application;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.App.Application> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getGlobalContext;
#pragma warning disable 0169
		static Delegate GetGetGlobalContextHandler ()
		{
			if (cb_getGlobalContext == null)
				cb_getGlobalContext = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetGlobalContext);
			return cb_getGlobalContext;
		}

		static IntPtr n_GetGlobalContext (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.GlobalContext);
		}
#pragma warning restore 0169

		static Delegate? cb_setGlobalContext_Lcom_gainsight_px_mobile_GlobalContextData_;
#pragma warning disable 0169
		static Delegate GetSetGlobalContext_Lcom_gainsight_px_mobile_GlobalContextData_Handler ()
		{
			if (cb_setGlobalContext_Lcom_gainsight_px_mobile_GlobalContextData_ == null)
				cb_setGlobalContext_Lcom_gainsight_px_mobile_GlobalContextData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetGlobalContext_Lcom_gainsight_px_mobile_GlobalContextData_);
			return cb_setGlobalContext_Lcom_gainsight_px_mobile_GlobalContextData_;
		}

		static void n_SetGlobalContext_Lcom_gainsight_px_mobile_GlobalContextData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GlobalContextData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GlobalContext = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Gainsight.PX.Mobile.GlobalContextData? GlobalContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='getGlobalContext' and count(parameter)=0]"
			[Register ("getGlobalContext", "()Lcom/gainsight/px/mobile/GlobalContextData;", "GetGetGlobalContextHandler")]
			get {
				const string __id = "getGlobalContext.()Lcom/gainsight/px/mobile/GlobalContextData;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GlobalContextData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='setGlobalContext' and count(parameter)=1 and parameter[1][@type='com.gainsight.px.mobile.GlobalContextData']]"
			[Register ("setGlobalContext", "(Lcom/gainsight/px/mobile/GlobalContextData;)V", "GetSetGlobalContext_Lcom_gainsight_px_mobile_GlobalContextData_Handler")]
			set {
				const string __id = "setGlobalContext.(Lcom/gainsight/px/mobile/GlobalContextData;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate? cb_getLogLevel;
#pragma warning disable 0169
		static Delegate GetGetLogLevelHandler ()
		{
			if (cb_getLogLevel == null)
				cb_getLogLevel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLogLevel);
			return cb_getLogLevel;
		}

		static IntPtr n_GetLogLevel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.LogLevel);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Gainsight.PX.Mobile.LogLevel? LogLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='getLogLevel' and count(parameter)=0]"
			[Register ("getLogLevel", "()Lcom/gainsight/px/mobile/LogLevel;", "GetGetLogLevelHandler")]
			get {
				const string __id = "getLogLevel.()Lcom/gainsight/px/mobile/LogLevel;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.LogLevel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='attachToWebView' and count(parameter)=1 and parameter[1][@type='android.webkit.WebView']]"
		[Register ("attachToWebView", "(Landroid/webkit/WebView;)V", "")]
		public static unsafe void AttachToWebView (global::Android.Webkit.WebView? p0)
		{
			const string __id = "attachToWebView.(Landroid/webkit/WebView;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_custom_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCustom_Ljava_lang_String_Handler ()
		{
			if (cb_custom_Ljava_lang_String_ == null)
				cb_custom_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Custom_Ljava_lang_String_);
			return cb_custom_Ljava_lang_String_;
		}

		static void n_Custom_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Custom (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='custom' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("custom", "(Ljava/lang/String;)V", "GetCustom_Ljava_lang_String_Handler")]
		public virtual unsafe void Custom (string? p0)
		{
			const string __id = "custom.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_custom_Ljava_lang_String_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_;
#pragma warning disable 0169
		static Delegate GetCustom_Ljava_lang_String_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_Handler ()
		{
			if (cb_custom_Ljava_lang_String_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_ == null)
				cb_custom_Ljava_lang_String_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Custom_Ljava_lang_String_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_);
			return cb_custom_Ljava_lang_String_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_;
		}

		static void n_Custom_Ljava_lang_String_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Gainsight.PX.Mobile.GainsightPX.IExceptionHandler?)global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.IExceptionHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Custom (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='custom' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.gainsight.px.mobile.GainsightPX.ExceptionHandler']]"
		[Register ("custom", "(Ljava/lang/String;Lcom/gainsight/px/mobile/GainsightPX$ExceptionHandler;)V", "GetCustom_Ljava_lang_String_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_Handler")]
		public virtual unsafe void Custom (string? p0, global::Com.Gainsight.PX.Mobile.GainsightPX.IExceptionHandler? p1)
		{
			const string __id = "custom.(Ljava/lang/String;Lcom/gainsight/px/mobile/GainsightPX$ExceptionHandler;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate? cb_custom_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetCustom_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_custom_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_custom_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Custom_Ljava_lang_String_Ljava_util_Map_);
			return cb_custom_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_Custom_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Custom (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='custom' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("custom", "(Ljava/lang/String;Ljava/util/Map;)V", "GetCustom_Ljava_lang_String_Ljava_util_Map_Handler")]
		public virtual unsafe void Custom (string? p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>? p1)
		{
			const string __id = "custom.(Ljava/lang/String;Ljava/util/Map;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate? cb_custom_Ljava_lang_String_Ljava_util_Map_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_;
#pragma warning disable 0169
		static Delegate GetCustom_Ljava_lang_String_Ljava_util_Map_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_Handler ()
		{
			if (cb_custom_Ljava_lang_String_Ljava_util_Map_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_ == null)
				cb_custom_Ljava_lang_String_Ljava_util_Map_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Custom_Ljava_lang_String_Ljava_util_Map_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_);
			return cb_custom_Ljava_lang_String_Ljava_util_Map_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_;
		}

		static void n_Custom_Ljava_lang_String_Ljava_util_Map_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Gainsight.PX.Mobile.GainsightPX.IExceptionHandler?)global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.IExceptionHandler> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Custom (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='custom' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[3][@type='com.gainsight.px.mobile.GainsightPX.ExceptionHandler']]"
		[Register ("custom", "(Ljava/lang/String;Ljava/util/Map;Lcom/gainsight/px/mobile/GainsightPX$ExceptionHandler;)V", "GetCustom_Ljava_lang_String_Ljava_util_Map_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_Handler")]
		public virtual unsafe void Custom (string? p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>? p1, global::Com.Gainsight.PX.Mobile.GainsightPX.IExceptionHandler? p2)
		{
			const string __id = "custom.(Ljava/lang/String;Ljava/util/Map;Lcom/gainsight/px/mobile/GainsightPX$ExceptionHandler;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		static Delegate? cb_enabled;
#pragma warning disable 0169
		static Delegate GetEnabledHandler ()
		{
			if (cb_enabled == null)
				cb_enabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Enabled);
			return cb_enabled;
		}

		static bool n_Enabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Enabled ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='enabled' and count(parameter)=0]"
		[Register ("enabled", "()Z", "GetEnabledHandler")]
		public virtual unsafe bool Enabled ()
		{
			const string __id = "enabled.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate? cb_enterEditingMode_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetEnterEditingMode_Landroid_content_Intent_Handler ()
		{
			if (cb_enterEditingMode_Landroid_content_Intent_ == null)
				cb_enterEditingMode_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_EnterEditingMode_Landroid_content_Intent_);
			return cb_enterEditingMode_Landroid_content_Intent_;
		}

		static void n_EnterEditingMode_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EnterEditingMode (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='enterEditingMode' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("enterEditingMode", "(Landroid/content/Intent;)V", "GetEnterEditingMode_Landroid_content_Intent_Handler")]
		public virtual unsafe void EnterEditingMode (global::Android.Content.Intent? p0)
		{
			const string __id = "enterEditingMode.(Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_exitEditingMode;
#pragma warning disable 0169
		static Delegate GetExitEditingModeHandler ()
		{
			if (cb_exitEditingMode == null)
				cb_exitEditingMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ExitEditingMode);
			return cb_exitEditingMode;
		}

		static void n_ExitEditingMode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.ExitEditingMode ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='exitEditingMode' and count(parameter)=0]"
		[Register ("exitEditingMode", "()V", "GetExitEditingModeHandler")]
		public virtual unsafe void ExitEditingMode ()
		{
			const string __id = "exitEditingMode.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_flush;
#pragma warning disable 0169
		static Delegate GetFlushHandler ()
		{
			if (cb_flush == null)
				cb_flush = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Flush);
			return cb_flush;
		}

		static void n_Flush (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Flush ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler")]
		public virtual unsafe void Flush ()
		{
			const string __id = "flush.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_flush_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_;
#pragma warning disable 0169
		static Delegate GetFlush_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_Handler ()
		{
			if (cb_flush_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_ == null)
				cb_flush_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Flush_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_);
			return cb_flush_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_;
		}

		static void n_Flush_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Gainsight.PX.Mobile.GainsightPX.IExceptionHandler?)global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.IExceptionHandler> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Flush (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='flush' and count(parameter)=1 and parameter[1][@type='com.gainsight.px.mobile.GainsightPX.ExceptionHandler']]"
		[Register ("flush", "(Lcom/gainsight/px/mobile/GainsightPX$ExceptionHandler;)V", "GetFlush_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_Handler")]
		public virtual unsafe void Flush (global::Com.Gainsight.PX.Mobile.GainsightPX.IExceptionHandler? p0)
		{
			const string __id = "flush.(Lcom/gainsight/px/mobile/GainsightPX$ExceptionHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_identify_Lcom_gainsight_px_mobile_User_;
#pragma warning disable 0169
		static Delegate GetIdentify_Lcom_gainsight_px_mobile_User_Handler ()
		{
			if (cb_identify_Lcom_gainsight_px_mobile_User_ == null)
				cb_identify_Lcom_gainsight_px_mobile_User_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Identify_Lcom_gainsight_px_mobile_User_);
			return cb_identify_Lcom_gainsight_px_mobile_User_;
		}

		static void n_Identify_Lcom_gainsight_px_mobile_User_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Identify (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='identify' and count(parameter)=1 and parameter[1][@type='com.gainsight.px.mobile.User']]"
		[Register ("identify", "(Lcom/gainsight/px/mobile/User;)V", "GetIdentify_Lcom_gainsight_px_mobile_User_Handler")]
		public virtual unsafe void Identify (global::Com.Gainsight.PX.Mobile.User? p0)
		{
			const string __id = "identify.(Lcom/gainsight/px/mobile/User;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_identify_Lcom_gainsight_px_mobile_User_Lcom_gainsight_px_mobile_Account_;
#pragma warning disable 0169
		static Delegate GetIdentify_Lcom_gainsight_px_mobile_User_Lcom_gainsight_px_mobile_Account_Handler ()
		{
			if (cb_identify_Lcom_gainsight_px_mobile_User_Lcom_gainsight_px_mobile_Account_ == null)
				cb_identify_Lcom_gainsight_px_mobile_User_Lcom_gainsight_px_mobile_Account_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Identify_Lcom_gainsight_px_mobile_User_Lcom_gainsight_px_mobile_Account_);
			return cb_identify_Lcom_gainsight_px_mobile_User_Lcom_gainsight_px_mobile_Account_;
		}

		static void n_Identify_Lcom_gainsight_px_mobile_User_Lcom_gainsight_px_mobile_Account_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Identify (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='identify' and count(parameter)=2 and parameter[1][@type='com.gainsight.px.mobile.User'] and parameter[2][@type='com.gainsight.px.mobile.Account']]"
		[Register ("identify", "(Lcom/gainsight/px/mobile/User;Lcom/gainsight/px/mobile/Account;)V", "GetIdentify_Lcom_gainsight_px_mobile_User_Lcom_gainsight_px_mobile_Account_Handler")]
		public virtual unsafe void Identify (global::Com.Gainsight.PX.Mobile.User? p0, global::Com.Gainsight.PX.Mobile.Account? p1)
		{
			const string __id = "identify.(Lcom/gainsight/px/mobile/User;Lcom/gainsight/px/mobile/Account;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate? cb_identify_Lcom_gainsight_px_mobile_User_Lcom_gainsight_px_mobile_Account_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_;
#pragma warning disable 0169
		static Delegate GetIdentify_Lcom_gainsight_px_mobile_User_Lcom_gainsight_px_mobile_Account_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_Handler ()
		{
			if (cb_identify_Lcom_gainsight_px_mobile_User_Lcom_gainsight_px_mobile_Account_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_ == null)
				cb_identify_Lcom_gainsight_px_mobile_User_Lcom_gainsight_px_mobile_Account_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Identify_Lcom_gainsight_px_mobile_User_Lcom_gainsight_px_mobile_Account_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_);
			return cb_identify_Lcom_gainsight_px_mobile_User_Lcom_gainsight_px_mobile_Account_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_;
		}

		static void n_Identify_Lcom_gainsight_px_mobile_User_Lcom_gainsight_px_mobile_Account_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Gainsight.PX.Mobile.GainsightPX.IExceptionHandler?)global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.IExceptionHandler> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Identify (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='identify' and count(parameter)=3 and parameter[1][@type='com.gainsight.px.mobile.User'] and parameter[2][@type='com.gainsight.px.mobile.Account'] and parameter[3][@type='com.gainsight.px.mobile.GainsightPX.ExceptionHandler']]"
		[Register ("identify", "(Lcom/gainsight/px/mobile/User;Lcom/gainsight/px/mobile/Account;Lcom/gainsight/px/mobile/GainsightPX$ExceptionHandler;)V", "GetIdentify_Lcom_gainsight_px_mobile_User_Lcom_gainsight_px_mobile_Account_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_Handler")]
		public virtual unsafe void Identify (global::Com.Gainsight.PX.Mobile.User? p0, global::Com.Gainsight.PX.Mobile.Account? p1, global::Com.Gainsight.PX.Mobile.GainsightPX.IExceptionHandler? p2)
		{
			const string __id = "identify.(Lcom/gainsight/px/mobile/User;Lcom/gainsight/px/mobile/Account;Lcom/gainsight/px/mobile/GainsightPX$ExceptionHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		static Delegate? cb_identify_Lcom_gainsight_px_mobile_User_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_;
#pragma warning disable 0169
		static Delegate GetIdentify_Lcom_gainsight_px_mobile_User_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_Handler ()
		{
			if (cb_identify_Lcom_gainsight_px_mobile_User_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_ == null)
				cb_identify_Lcom_gainsight_px_mobile_User_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Identify_Lcom_gainsight_px_mobile_User_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_);
			return cb_identify_Lcom_gainsight_px_mobile_User_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_;
		}

		static void n_Identify_Lcom_gainsight_px_mobile_User_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Gainsight.PX.Mobile.GainsightPX.IExceptionHandler?)global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.IExceptionHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Identify (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='identify' and count(parameter)=2 and parameter[1][@type='com.gainsight.px.mobile.User'] and parameter[2][@type='com.gainsight.px.mobile.GainsightPX.ExceptionHandler']]"
		[Register ("identify", "(Lcom/gainsight/px/mobile/User;Lcom/gainsight/px/mobile/GainsightPX$ExceptionHandler;)V", "GetIdentify_Lcom_gainsight_px_mobile_User_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_Handler")]
		public virtual unsafe void Identify (global::Com.Gainsight.PX.Mobile.User? p0, global::Com.Gainsight.PX.Mobile.GainsightPX.IExceptionHandler? p1)
		{
			const string __id = "identify.(Lcom/gainsight/px/mobile/User;Lcom/gainsight/px/mobile/GainsightPX$ExceptionHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate? cb_identify_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIdentify_Ljava_lang_String_Handler ()
		{
			if (cb_identify_Ljava_lang_String_ == null)
				cb_identify_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Identify_Ljava_lang_String_);
			return cb_identify_Ljava_lang_String_;
		}

		static void n_Identify_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Identify (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='identify' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("identify", "(Ljava/lang/String;)V", "GetIdentify_Ljava_lang_String_Handler")]
		public virtual unsafe void Identify (string? p0)
		{
			const string __id = "identify.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_identify_Ljava_lang_String_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_;
#pragma warning disable 0169
		static Delegate GetIdentify_Ljava_lang_String_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_Handler ()
		{
			if (cb_identify_Ljava_lang_String_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_ == null)
				cb_identify_Ljava_lang_String_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Identify_Ljava_lang_String_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_);
			return cb_identify_Ljava_lang_String_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_;
		}

		static void n_Identify_Ljava_lang_String_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Gainsight.PX.Mobile.GainsightPX.IExceptionHandler?)global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.IExceptionHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Identify (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='identify' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.gainsight.px.mobile.GainsightPX.ExceptionHandler']]"
		[Register ("identify", "(Ljava/lang/String;Lcom/gainsight/px/mobile/GainsightPX$ExceptionHandler;)V", "GetIdentify_Ljava_lang_String_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_Handler")]
		public virtual unsafe void Identify (string? p0, global::Com.Gainsight.PX.Mobile.GainsightPX.IExceptionHandler? p1)
		{
			const string __id = "identify.(Ljava/lang/String;Lcom/gainsight/px/mobile/GainsightPX$ExceptionHandler;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='loadScript' and count(parameter)=1 and parameter[1][@type='android.webkit.WebView']]"
		[Register ("loadScript", "(Landroid/webkit/WebView;)V", "")]
		public static unsafe void LoadScript (global::Android.Webkit.WebView? p0)
		{
			const string __id = "loadScript.(Landroid/webkit/WebView;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_logger_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLogger_Ljava_lang_String_Handler ()
		{
			if (cb_logger_Ljava_lang_String_ == null)
				cb_logger_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Logger_Ljava_lang_String_);
			return cb_logger_Ljava_lang_String_;
		}

		static IntPtr n_Logger_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Logger (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='logger' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("logger", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/Logger;", "GetLogger_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.Logger? Logger (string? p0)
		{
			const string __id = "logger.(Ljava/lang/String;)Lcom/gainsight/px/mobile/Logger;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Logger> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Reset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_screen_Lcom_gainsight_px_mobile_ScreenEventData_;
#pragma warning disable 0169
		static Delegate GetScreen_Lcom_gainsight_px_mobile_ScreenEventData_Handler ()
		{
			if (cb_screen_Lcom_gainsight_px_mobile_ScreenEventData_ == null)
				cb_screen_Lcom_gainsight_px_mobile_ScreenEventData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Screen_Lcom_gainsight_px_mobile_ScreenEventData_);
			return cb_screen_Lcom_gainsight_px_mobile_ScreenEventData_;
		}

		static void n_Screen_Lcom_gainsight_px_mobile_ScreenEventData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ScreenEventData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Screen (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='screen' and count(parameter)=1 and parameter[1][@type='com.gainsight.px.mobile.ScreenEventData']]"
		[Register ("screen", "(Lcom/gainsight/px/mobile/ScreenEventData;)V", "GetScreen_Lcom_gainsight_px_mobile_ScreenEventData_Handler")]
		public virtual unsafe void Screen (global::Com.Gainsight.PX.Mobile.ScreenEventData? p0)
		{
			const string __id = "screen.(Lcom/gainsight/px/mobile/ScreenEventData;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_screen_Lcom_gainsight_px_mobile_ScreenEventData_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_;
#pragma warning disable 0169
		static Delegate GetScreen_Lcom_gainsight_px_mobile_ScreenEventData_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_Handler ()
		{
			if (cb_screen_Lcom_gainsight_px_mobile_ScreenEventData_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_ == null)
				cb_screen_Lcom_gainsight_px_mobile_ScreenEventData_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Screen_Lcom_gainsight_px_mobile_ScreenEventData_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_);
			return cb_screen_Lcom_gainsight_px_mobile_ScreenEventData_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_;
		}

		static void n_Screen_Lcom_gainsight_px_mobile_ScreenEventData_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ScreenEventData> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Gainsight.PX.Mobile.GainsightPX.IExceptionHandler?)global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.IExceptionHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Screen (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='screen' and count(parameter)=2 and parameter[1][@type='com.gainsight.px.mobile.ScreenEventData'] and parameter[2][@type='com.gainsight.px.mobile.GainsightPX.ExceptionHandler']]"
		[Register ("screen", "(Lcom/gainsight/px/mobile/ScreenEventData;Lcom/gainsight/px/mobile/GainsightPX$ExceptionHandler;)V", "GetScreen_Lcom_gainsight_px_mobile_ScreenEventData_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_Handler")]
		public virtual unsafe void Screen (global::Com.Gainsight.PX.Mobile.ScreenEventData? p0, global::Com.Gainsight.PX.Mobile.GainsightPX.IExceptionHandler? p1)
		{
			const string __id = "screen.(Lcom/gainsight/px/mobile/ScreenEventData;Lcom/gainsight/px/mobile/GainsightPX$ExceptionHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate? cb_screen_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetScreen_Ljava_lang_String_Handler ()
		{
			if (cb_screen_Ljava_lang_String_ == null)
				cb_screen_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Screen_Ljava_lang_String_);
			return cb_screen_Ljava_lang_String_;
		}

		static void n_Screen_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Screen (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='screen' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("screen", "(Ljava/lang/String;)V", "GetScreen_Ljava_lang_String_Handler")]
		public virtual unsafe void Screen (string? p0)
		{
			const string __id = "screen.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_screen_Ljava_lang_String_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_;
#pragma warning disable 0169
		static Delegate GetScreen_Ljava_lang_String_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_Handler ()
		{
			if (cb_screen_Ljava_lang_String_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_ == null)
				cb_screen_Ljava_lang_String_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Screen_Ljava_lang_String_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_);
			return cb_screen_Ljava_lang_String_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_;
		}

		static void n_Screen_Ljava_lang_String_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Gainsight.PX.Mobile.GainsightPX.IExceptionHandler?)global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.IExceptionHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Screen (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='screen' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.gainsight.px.mobile.GainsightPX.ExceptionHandler']]"
		[Register ("screen", "(Ljava/lang/String;Lcom/gainsight/px/mobile/GainsightPX$ExceptionHandler;)V", "GetScreen_Ljava_lang_String_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_Handler")]
		public virtual unsafe void Screen (string? p0, global::Com.Gainsight.PX.Mobile.GainsightPX.IExceptionHandler? p1)
		{
			const string __id = "screen.(Ljava/lang/String;Lcom/gainsight/px/mobile/GainsightPX$ExceptionHandler;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate? cb_screen_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetScreen_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_screen_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_screen_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Screen_Ljava_lang_String_Ljava_util_Map_);
			return cb_screen_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_Screen_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Screen (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='screen' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("screen", "(Ljava/lang/String;Ljava/util/Map;)V", "GetScreen_Ljava_lang_String_Ljava_util_Map_Handler")]
		public virtual unsafe void Screen (string? p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>? p1)
		{
			const string __id = "screen.(Ljava/lang/String;Ljava/util/Map;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate? cb_screen_Ljava_lang_String_Ljava_util_Map_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_;
#pragma warning disable 0169
		static Delegate GetScreen_Ljava_lang_String_Ljava_util_Map_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_Handler ()
		{
			if (cb_screen_Ljava_lang_String_Ljava_util_Map_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_ == null)
				cb_screen_Ljava_lang_String_Ljava_util_Map_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Screen_Ljava_lang_String_Ljava_util_Map_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_);
			return cb_screen_Ljava_lang_String_Ljava_util_Map_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_;
		}

		static void n_Screen_Ljava_lang_String_Ljava_util_Map_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Gainsight.PX.Mobile.GainsightPX.IExceptionHandler?)global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.IExceptionHandler> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Screen (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='screen' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[3][@type='com.gainsight.px.mobile.GainsightPX.ExceptionHandler']]"
		[Register ("screen", "(Ljava/lang/String;Ljava/util/Map;Lcom/gainsight/px/mobile/GainsightPX$ExceptionHandler;)V", "GetScreen_Ljava_lang_String_Ljava_util_Map_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_Handler")]
		public virtual unsafe void Screen (string? p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>? p1, global::Com.Gainsight.PX.Mobile.GainsightPX.IExceptionHandler? p2)
		{
			const string __id = "screen.(Ljava/lang/String;Ljava/util/Map;Lcom/gainsight/px/mobile/GainsightPX$ExceptionHandler;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		static Delegate? cb_setEnable_Z;
#pragma warning disable 0169
		static Delegate GetSetEnable_ZHandler ()
		{
			if (cb_setEnable_Z == null)
				cb_setEnable_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetEnable_Z);
			return cb_setEnable_Z;
		}

		static void n_SetEnable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SetEnable (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='setEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnable", "(Z)V", "GetSetEnable_ZHandler")]
		public virtual unsafe void SetEnable (bool p0)
		{
			const string __id = "setEnable.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='setSingletonInstance' and count(parameter)=1 and parameter[1][@type='com.gainsight.px.mobile.GainsightPX']]"
		[Register ("setSingletonInstance", "(Lcom/gainsight/px/mobile/GainsightPX;)V", "")]
		public static unsafe void SetSingletonInstance (global::Com.Gainsight.PX.Mobile.GainsightPX? p0)
		{
			const string __id = "setSingletonInstance.(Lcom/gainsight/px/mobile/GainsightPX;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_shutdown;
#pragma warning disable 0169
		static Delegate GetShutdownHandler ()
		{
			if (cb_shutdown == null)
				cb_shutdown = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Shutdown);
			return cb_shutdown;
		}

		static void n_Shutdown (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Shutdown ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='shutdown' and count(parameter)=0]"
		[Register ("shutdown", "()V", "GetShutdownHandler")]
		public virtual unsafe void Shutdown ()
		{
			const string __id = "shutdown.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_shutdown_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_;
#pragma warning disable 0169
		static Delegate GetShutdown_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_Handler ()
		{
			if (cb_shutdown_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_ == null)
				cb_shutdown_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Shutdown_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_);
			return cb_shutdown_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_;
		}

		static void n_Shutdown_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Gainsight.PX.Mobile.GainsightPX.IExceptionHandler?)global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX.IExceptionHandler> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Shutdown (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='shutdown' and count(parameter)=1 and parameter[1][@type='com.gainsight.px.mobile.GainsightPX.ExceptionHandler']]"
		[Register ("shutdown", "(Lcom/gainsight/px/mobile/GainsightPX$ExceptionHandler;)V", "GetShutdown_Lcom_gainsight_px_mobile_GainsightPX_ExceptionHandler_Handler")]
		public virtual unsafe void Shutdown (global::Com.Gainsight.PX.Mobile.GainsightPX.IExceptionHandler? p0)
		{
			const string __id = "shutdown.(Lcom/gainsight/px/mobile/GainsightPX$ExceptionHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='with' and count(parameter)=0]"
		[Register ("with", "()Lcom/gainsight/px/mobile/GainsightPX;", "")]
		public static unsafe global::Com.Gainsight.PX.Mobile.GainsightPX? With ()
		{
			const string __id = "with.()Lcom/gainsight/px/mobile/GainsightPX;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GainsightPX']/method[@name='with' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[global::System.Obsolete (@"deprecated")]
		[Register ("with", "(Landroid/content/Context;)Lcom/gainsight/px/mobile/GainsightPX;", "")]
		public static unsafe global::Com.Gainsight.PX.Mobile.GainsightPX? With (global::Android.Content.Context? p0)
		{
			const string __id = "with.(Landroid/content/Context;)Lcom/gainsight/px/mobile/GainsightPX;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GainsightPX> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
