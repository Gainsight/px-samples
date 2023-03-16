using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Gainsight.PX.Mobile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GlobalContextData']"
	[global::Android.Runtime.Register ("com/gainsight/px/mobile/GlobalContextData", DoNotGenerateAcw=true)]
	public partial class GlobalContextData : global::Com.Gainsight.PX.Mobile.ValueMap {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/gainsight/px/mobile/GlobalContextData", typeof (GlobalContextData));

		internal static new IntPtr class_ref {
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

		protected GlobalContextData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GlobalContextData']/constructor[@name='GlobalContextData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GlobalContextData () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate? cb_getKeys;
#pragma warning disable 0169
		static Delegate GetGetKeysHandler ()
		{
			if (cb_getKeys == null)
				cb_getKeys = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetKeys);
			return cb_getKeys;
		}

		static IntPtr n_GetKeys (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GlobalContextData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.Keys);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.ICollection<string>? Keys {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GlobalContextData']/method[@name='getKeys' and count(parameter)=0]"
			[Register ("getKeys", "()Ljava/util/Set;", "GetGetKeysHandler")]
			get {
				const string __id = "getKeys.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_hasKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHasKey_Ljava_lang_String_Handler ()
		{
			if (cb_hasKey_Ljava_lang_String_ == null)
				cb_hasKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_HasKey_Ljava_lang_String_);
			return cb_hasKey_Ljava_lang_String_;
		}

		static bool n_HasKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GlobalContextData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasKey (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GlobalContextData']/method[@name='hasKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hasKey", "(Ljava/lang/String;)Z", "GetHasKey_Ljava_lang_String_Handler")]
		public virtual unsafe bool HasKey (string? p0)
		{
			const string __id = "hasKey.(Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_put_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_util_Map_Handler ()
		{
			if (cb_put_Ljava_util_Map_ == null)
				cb_put_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Put_Ljava_util_Map_);
			return cb_put_Ljava_util_Map_;
		}

		static IntPtr n_Put_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GlobalContextData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Android.Runtime.JavaDictionary<string, object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Put (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GlobalContextData']/method[@name='put' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;? extends java.lang.String, ?&gt;']]"
		[Register ("put", "(Ljava/util/Map;)Lcom/gainsight/px/mobile/GlobalContextData;", "GetPut_Ljava_util_Map_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.GlobalContextData? Put (global::System.Collections.Generic.IDictionary<string, object>? p0)
		{
			const string __id = "put.(Ljava/util/Map;)Lcom/gainsight/px/mobile/GlobalContextData;";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, object>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GlobalContextData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_putBoolean_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetPutBoolean_Ljava_lang_String_ZHandler ()
		{
			if (cb_putBoolean_Ljava_lang_String_Z == null)
				cb_putBoolean_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_L) n_PutBoolean_Ljava_lang_String_Z);
			return cb_putBoolean_Ljava_lang_String_Z;
		}

		static IntPtr n_PutBoolean_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GlobalContextData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutBoolean (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GlobalContextData']/method[@name='putBoolean' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("putBoolean", "(Ljava/lang/String;Z)Lcom/gainsight/px/mobile/GlobalContextData;", "GetPutBoolean_Ljava_lang_String_ZHandler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.GlobalContextData? PutBoolean (string? p0, bool p1)
		{
			const string __id = "putBoolean.(Ljava/lang/String;Z)Lcom/gainsight/px/mobile/GlobalContextData;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GlobalContextData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putDate_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutDate_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_putDate_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_putDate_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_PutDate_Ljava_lang_String_Ljava_lang_String_);
			return cb_putDate_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_PutDate_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GlobalContextData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutDate (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GlobalContextData']/method[@name='putDate' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("putDate", "(Ljava/lang/String;Ljava/lang/String;)Lcom/gainsight/px/mobile/GlobalContextData;", "GetPutDate_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.GlobalContextData? PutDate (string? p0, string? p1)
		{
			const string __id = "putDate.(Ljava/lang/String;Ljava/lang/String;)Lcom/gainsight/px/mobile/GlobalContextData;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GlobalContextData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate? cb_putDate_Ljava_lang_String_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetPutDate_Ljava_lang_String_Ljava_util_Date_Handler ()
		{
			if (cb_putDate_Ljava_lang_String_Ljava_util_Date_ == null)
				cb_putDate_Ljava_lang_String_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_PutDate_Ljava_lang_String_Ljava_util_Date_);
			return cb_putDate_Ljava_lang_String_Ljava_util_Date_;
		}

		static IntPtr n_PutDate_Ljava_lang_String_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GlobalContextData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutDate (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GlobalContextData']/method[@name='putDate' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Date']]"
		[Register ("putDate", "(Ljava/lang/String;Ljava/util/Date;)Lcom/gainsight/px/mobile/GlobalContextData;", "GetPutDate_Ljava_lang_String_Ljava_util_Date_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.GlobalContextData? PutDate (string? p0, global::Java.Util.Date? p1)
		{
			const string __id = "putDate.(Ljava/lang/String;Ljava/util/Date;)Lcom/gainsight/px/mobile/GlobalContextData;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GlobalContextData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate? cb_putDate_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetPutDate_Ljava_lang_String_JHandler ()
		{
			if (cb_putDate_Ljava_lang_String_J == null)
				cb_putDate_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJ_L) n_PutDate_Ljava_lang_String_J);
			return cb_putDate_Ljava_lang_String_J;
		}

		static IntPtr n_PutDate_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GlobalContextData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutDate (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GlobalContextData']/method[@name='putDate' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("putDate", "(Ljava/lang/String;J)Lcom/gainsight/px/mobile/GlobalContextData;", "GetPutDate_Ljava_lang_String_JHandler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.GlobalContextData? PutDate (string? p0, long p1)
		{
			const string __id = "putDate.(Ljava/lang/String;J)Lcom/gainsight/px/mobile/GlobalContextData;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GlobalContextData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putNumber_Ljava_lang_String_D;
#pragma warning disable 0169
		static Delegate GetPutNumber_Ljava_lang_String_DHandler ()
		{
			if (cb_putNumber_Ljava_lang_String_D == null)
				cb_putNumber_Ljava_lang_String_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLD_L) n_PutNumber_Ljava_lang_String_D);
			return cb_putNumber_Ljava_lang_String_D;
		}

		static IntPtr n_PutNumber_Ljava_lang_String_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GlobalContextData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutNumber (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GlobalContextData']/method[@name='putNumber' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double']]"
		[Register ("putNumber", "(Ljava/lang/String;D)Lcom/gainsight/px/mobile/GlobalContextData;", "GetPutNumber_Ljava_lang_String_DHandler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.GlobalContextData? PutNumber (string? p0, double p1)
		{
			const string __id = "putNumber.(Ljava/lang/String;D)Lcom/gainsight/px/mobile/GlobalContextData;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GlobalContextData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putNumber_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetPutNumber_Ljava_lang_String_IHandler ()
		{
			if (cb_putNumber_Ljava_lang_String_I == null)
				cb_putNumber_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_PutNumber_Ljava_lang_String_I);
			return cb_putNumber_Ljava_lang_String_I;
		}

		static IntPtr n_PutNumber_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GlobalContextData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutNumber (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GlobalContextData']/method[@name='putNumber' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("putNumber", "(Ljava/lang/String;I)Lcom/gainsight/px/mobile/GlobalContextData;", "GetPutNumber_Ljava_lang_String_IHandler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.GlobalContextData? PutNumber (string? p0, int p1)
		{
			const string __id = "putNumber.(Ljava/lang/String;I)Lcom/gainsight/px/mobile/GlobalContextData;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GlobalContextData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putNumber_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetPutNumber_Ljava_lang_String_JHandler ()
		{
			if (cb_putNumber_Ljava_lang_String_J == null)
				cb_putNumber_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJ_L) n_PutNumber_Ljava_lang_String_J);
			return cb_putNumber_Ljava_lang_String_J;
		}

		static IntPtr n_PutNumber_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GlobalContextData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutNumber (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GlobalContextData']/method[@name='putNumber' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("putNumber", "(Ljava/lang/String;J)Lcom/gainsight/px/mobile/GlobalContextData;", "GetPutNumber_Ljava_lang_String_JHandler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.GlobalContextData? PutNumber (string? p0, long p1)
		{
			const string __id = "putNumber.(Ljava/lang/String;J)Lcom/gainsight/px/mobile/GlobalContextData;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GlobalContextData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putString_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutString_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_putString_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_putString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_PutString_Ljava_lang_String_Ljava_lang_String_);
			return cb_putString_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_PutString_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GlobalContextData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutString (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GlobalContextData']/method[@name='putString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("putString", "(Ljava/lang/String;Ljava/lang/String;)Lcom/gainsight/px/mobile/GlobalContextData;", "GetPutString_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.GlobalContextData? PutString (string? p0, string? p1)
		{
			const string __id = "putString.(Ljava/lang/String;Ljava/lang/String;)Lcom/gainsight/px/mobile/GlobalContextData;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GlobalContextData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate? cb_removeKey_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveKey_arrayLjava_lang_String_Handler ()
		{
			if (cb_removeKey_arrayLjava_lang_String_ == null)
				cb_removeKey_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RemoveKey_arrayLjava_lang_String_);
			return cb_removeKey_arrayLjava_lang_String_;
		}

		static void n_RemoveKey_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.GlobalContextData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (string[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.RemoveKey (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='GlobalContextData']/method[@name='removeKey' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("removeKey", "([Ljava/lang/String;)V", "GetRemoveKey_arrayLjava_lang_String_Handler")]
		public virtual unsafe void RemoveKey (params string[]? p0)
		{
			const string __id = "removeKey.([Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
