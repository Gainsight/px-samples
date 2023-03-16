using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Gainsight.PX.Mobile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Crypto']"
	[global::Android.Runtime.Register ("com/gainsight/px/mobile/Crypto", DoNotGenerateAcw=true)]
	public abstract partial class Crypto : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/gainsight/px/mobile/Crypto", typeof (Crypto));

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

		protected Crypto (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Crypto']/constructor[@name='Crypto' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Crypto () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_decrypt_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetDecrypt_Ljava_io_InputStream_Handler ()
		{
			if (cb_decrypt_Ljava_io_InputStream_ == null)
				cb_decrypt_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Decrypt_Ljava_io_InputStream_);
			return cb_decrypt_Ljava_io_InputStream_;
		}

		static IntPtr n_Decrypt_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Crypto> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.Decrypt (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Crypto']/method[@name='decrypt' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("decrypt", "(Ljava/io/InputStream;)Ljava/io/InputStream;", "GetDecrypt_Ljava_io_InputStream_Handler")]
		public abstract global::System.IO.Stream? Decrypt (global::System.IO.Stream? p0);

		static Delegate? cb_encrypt_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetEncrypt_Ljava_io_OutputStream_Handler ()
		{
			if (cb_encrypt_Ljava_io_OutputStream_ == null)
				cb_encrypt_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Encrypt_Ljava_io_OutputStream_);
			return cb_encrypt_Ljava_io_OutputStream_;
		}

		static IntPtr n_Encrypt_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Crypto> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.Encrypt (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Crypto']/method[@name='encrypt' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("encrypt", "(Ljava/io/OutputStream;)Ljava/io/OutputStream;", "GetEncrypt_Ljava_io_OutputStream_Handler")]
		public abstract global::System.IO.Stream? Encrypt (global::System.IO.Stream? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Crypto']/method[@name='none' and count(parameter)=0]"
		[Register ("none", "()Lcom/gainsight/px/mobile/Crypto;", "")]
		public static unsafe global::Com.Gainsight.PX.Mobile.Crypto? None ()
		{
			const string __id = "none.()Lcom/gainsight/px/mobile/Crypto;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Crypto> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/gainsight/px/mobile/Crypto", DoNotGenerateAcw=true)]
	internal partial class CryptoInvoker : Crypto {
		public CryptoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/gainsight/px/mobile/Crypto", typeof (CryptoInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Crypto']/method[@name='decrypt' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("decrypt", "(Ljava/io/InputStream;)Ljava/io/InputStream;", "GetDecrypt_Ljava_io_InputStream_Handler")]
		public override unsafe global::System.IO.Stream? Decrypt (global::System.IO.Stream? p0)
		{
			const string __id = "decrypt.(Ljava/io/InputStream;)Ljava/io/InputStream;";
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Crypto']/method[@name='encrypt' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("encrypt", "(Ljava/io/OutputStream;)Ljava/io/OutputStream;", "GetEncrypt_Ljava_io_OutputStream_Handler")]
		public override unsafe global::System.IO.Stream? Encrypt (global::System.IO.Stream? p0)
		{
			const string __id = "encrypt.(Ljava/io/OutputStream;)Ljava/io/OutputStream;";
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
