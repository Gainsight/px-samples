using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Gainsight.PX.Mobile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Logger']"
	[global::Android.Runtime.Register ("com/gainsight/px/mobile/Logger", DoNotGenerateAcw=true)]
	public sealed partial class Logger : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Logger']/field[@name='logLevel']"
		[Register ("logLevel")]
		public global::Com.Gainsight.PX.Mobile.LogLevel? LogLevel {
			get {
				const string __id = "logLevel.Lcom/gainsight/px/mobile/LogLevel;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "logLevel.Lcom/gainsight/px/mobile/LogLevel;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/gainsight/px/mobile/Logger", typeof (Logger));

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

		internal Logger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Logger']/method[@name='debug' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("debug", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public unsafe void Debug (string? p0, params global::Java.Lang.Object[]? p1)
		{
			const string __id = "debug.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Logger']/method[@name='error' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("error", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public unsafe void Error (global::Java.Lang.Throwable? p0, string? p1, params global::Java.Lang.Object[]? p2)
		{
			const string __id = "error.(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Logger']/method[@name='info' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("info", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public unsafe void Info (string? p0, params global::Java.Lang.Object[]? p1)
		{
			const string __id = "info.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Logger']/method[@name='subLog' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("subLog", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/Logger;", "")]
		public unsafe global::Com.Gainsight.PX.Mobile.Logger? SubLog (string? p0)
		{
			const string __id = "subLog.(Ljava/lang/String;)Lcom/gainsight/px/mobile/Logger;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Logger> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Logger']/method[@name='verbose' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("verbose", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public unsafe void Verbose (string? p0, params global::Java.Lang.Object[]? p1)
		{
			const string __id = "verbose.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Logger']/method[@name='with' and count(parameter)=1 and parameter[1][@type='com.gainsight.px.mobile.LogLevel']]"
		[Register ("with", "(Lcom/gainsight/px/mobile/LogLevel;)Lcom/gainsight/px/mobile/Logger;", "")]
		public static unsafe global::Com.Gainsight.PX.Mobile.Logger? With (global::Com.Gainsight.PX.Mobile.LogLevel? p0)
		{
			const string __id = "with.(Lcom/gainsight/px/mobile/LogLevel;)Lcom/gainsight/px/mobile/Logger;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Logger> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
