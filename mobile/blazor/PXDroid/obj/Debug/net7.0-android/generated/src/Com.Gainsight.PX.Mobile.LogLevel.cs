using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Gainsight.PX.Mobile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='LogLevel']"
	[global::Android.Runtime.Register ("com/gainsight/px/mobile/LogLevel", DoNotGenerateAcw=true)]
	public sealed partial class LogLevel : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='LogLevel']/field[@name='BASIC']"
		[Register ("BASIC")]
		[global::System.Obsolete (@"deprecated")]
		public static global::Com.Gainsight.PX.Mobile.LogLevel? Basic {
			get {
				const string __id = "BASIC.Lcom/gainsight/px/mobile/LogLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='LogLevel']/field[@name='DEBUG']"
		[Register ("DEBUG")]
		public static global::Com.Gainsight.PX.Mobile.LogLevel? Debug {
			get {
				const string __id = "DEBUG.Lcom/gainsight/px/mobile/LogLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='LogLevel']/field[@name='INFO']"
		[Register ("INFO")]
		public static global::Com.Gainsight.PX.Mobile.LogLevel? Info {
			get {
				const string __id = "INFO.Lcom/gainsight/px/mobile/LogLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='LogLevel']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::Com.Gainsight.PX.Mobile.LogLevel? None {
			get {
				const string __id = "NONE.Lcom/gainsight/px/mobile/LogLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='LogLevel']/field[@name='VERBOSE']"
		[Register ("VERBOSE")]
		public static global::Com.Gainsight.PX.Mobile.LogLevel? Verbose {
			get {
				const string __id = "VERBOSE.Lcom/gainsight/px/mobile/LogLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/gainsight/px/mobile/LogLevel", typeof (LogLevel));

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

		internal LogLevel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='LogLevel']/method[@name='log' and count(parameter)=0]"
		[Register ("log", "()Z", "")]
		public unsafe bool Log ()
		{
			const string __id = "log.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='LogLevel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/LogLevel;", "")]
		public static unsafe global::Com.Gainsight.PX.Mobile.LogLevel? ValueOf (string? p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/gainsight/px/mobile/LogLevel;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.LogLevel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='LogLevel']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/gainsight/px/mobile/LogLevel;", "")]
		public static unsafe global::Com.Gainsight.PX.Mobile.LogLevel[]? Values ()
		{
			const string __id = "values.()[Lcom/gainsight/px/mobile/LogLevel;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Gainsight.PX.Mobile.LogLevel[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Gainsight.PX.Mobile.LogLevel));
			} finally {
			}
		}

	}
}
