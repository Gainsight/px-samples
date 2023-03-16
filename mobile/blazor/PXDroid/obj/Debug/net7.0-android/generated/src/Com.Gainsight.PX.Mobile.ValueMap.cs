using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Gainsight.PX.Mobile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ValueMap']"
	[global::Android.Runtime.Register ("com/gainsight/px/mobile/ValueMap", DoNotGenerateAcw=true)]
	public partial class ValueMap : global::Java.Lang.Object, global::Java.Util.IMap {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/gainsight/px/mobile/ValueMap", typeof (ValueMap));

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

		protected ValueMap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ValueMap']/constructor[@name='ValueMap' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ValueMap () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ValueMap']/constructor[@name='ValueMap' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe ValueMap (int p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ValueMap']/constructor[@name='ValueMap' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register (".ctor", "(Ljava/util/Map;)V", "")]
		public unsafe ValueMap (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>? p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/Map;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_isEmpty;
#pragma warning disable 0169
		static Delegate GetIsEmptyHandler ()
		{
			if (cb_isEmpty == null)
				cb_isEmpty = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsEmpty);
			return cb_isEmpty;
		}

		static bool n_IsEmpty (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ValueMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ValueMap']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "GetIsEmptyHandler")]
			get {
				const string __id = "isEmpty.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ValueMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ValueMap']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_containsKey_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetContainsKey_Ljava_lang_Object_Handler ()
		{
			if (cb_containsKey_Ljava_lang_Object_ == null)
				cb_containsKey_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_ContainsKey_Ljava_lang_Object_);
			return cb_containsKey_Ljava_lang_Object_;
		}

		static bool n_ContainsKey_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ValueMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ContainsKey (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ValueMap']/method[@name='containsKey' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("containsKey", "(Ljava/lang/Object;)Z", "GetContainsKey_Ljava_lang_Object_Handler")]
		public virtual unsafe bool ContainsKey (global::Java.Lang.Object? p0)
		{
			const string __id = "containsKey.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_containsValue_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetContainsValue_Ljava_lang_Object_Handler ()
		{
			if (cb_containsValue_Ljava_lang_Object_ == null)
				cb_containsValue_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_ContainsValue_Ljava_lang_Object_);
			return cb_containsValue_Ljava_lang_Object_;
		}

		static bool n_ContainsValue_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ValueMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ContainsValue (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ValueMap']/method[@name='containsValue' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("containsValue", "(Ljava/lang/Object;)Z", "GetContainsValue_Ljava_lang_Object_Handler")]
		public virtual unsafe bool ContainsValue (global::Java.Lang.Object? p0)
		{
			const string __id = "containsValue.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_entrySet;
#pragma warning disable 0169
		static Delegate GetEntrySetHandler ()
		{
			if (cb_entrySet == null)
				cb_entrySet = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_EntrySet);
			return cb_entrySet;
		}

		static IntPtr n_EntrySet (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ValueMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaCollection.ToLocalJniHandle (__this.EntrySet ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ValueMap']/method[@name='entrySet' and count(parameter)=0]"
		[Register ("entrySet", "()LSystem/Collections/ICollection;", "GetEntrySetHandler")]
		public virtual unsafe global::System.Collections.ICollection? EntrySet ()
		{
			const string __id = "entrySet.()LSystem/Collections/ICollection;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaCollection.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_get_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_Object_Handler ()
		{
			if (cb_get_Ljava_lang_Object_ == null)
				cb_get_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Get_Ljava_lang_Object_);
			return cb_get_Ljava_lang_Object_;
		}

		static IntPtr n_Get_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ValueMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ValueMap']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("get", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetGet_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object? Get (global::Java.Lang.Object? p0)
		{
			const string __id = "get.(Ljava/lang/Object;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_getBoolean_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetGetBoolean_Ljava_lang_String_ZHandler ()
		{
			if (cb_getBoolean_Ljava_lang_String_Z == null)
				cb_getBoolean_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_Z) n_GetBoolean_Ljava_lang_String_Z);
			return cb_getBoolean_Ljava_lang_String_Z;
		}

		static bool n_GetBoolean_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ValueMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetBoolean (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ValueMap']/method[@name='getBoolean' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("getBoolean", "(Ljava/lang/String;Z)Z", "GetGetBoolean_Ljava_lang_String_ZHandler")]
		public virtual unsafe bool GetBoolean (string? p0, bool p1)
		{
			const string __id = "getBoolean.(Ljava/lang/String;Z)Z";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_getChar_Ljava_lang_String_C;
#pragma warning disable 0169
		static Delegate GetGetChar_Ljava_lang_String_CHandler ()
		{
			if (cb_getChar_Ljava_lang_String_C == null)
				cb_getChar_Ljava_lang_String_C = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLC_C) n_GetChar_Ljava_lang_String_C);
			return cb_getChar_Ljava_lang_String_C;
		}

		static char n_GetChar_Ljava_lang_String_C (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, char p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ValueMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			char __ret = __this.GetChar (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ValueMap']/method[@name='getChar' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char']]"
		[Register ("getChar", "(Ljava/lang/String;C)C", "GetGetChar_Ljava_lang_String_CHandler")]
		public virtual unsafe char GetChar (string? p0, char p1)
		{
			const string __id = "getChar.(Ljava/lang/String;C)C";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualCharMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_getDouble_Ljava_lang_String_D;
#pragma warning disable 0169
		static Delegate GetGetDouble_Ljava_lang_String_DHandler ()
		{
			if (cb_getDouble_Ljava_lang_String_D == null)
				cb_getDouble_Ljava_lang_String_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLD_D) n_GetDouble_Ljava_lang_String_D);
			return cb_getDouble_Ljava_lang_String_D;
		}

		static double n_GetDouble_Ljava_lang_String_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ValueMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.GetDouble (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ValueMap']/method[@name='getDouble' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double']]"
		[Register ("getDouble", "(Ljava/lang/String;D)D", "GetGetDouble_Ljava_lang_String_DHandler")]
		public virtual unsafe double GetDouble (string? p0, double p1)
		{
			const string __id = "getDouble.(Ljava/lang/String;D)D";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_getEnum_Ljava_lang_Class_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetEnum_Ljava_lang_Class_Ljava_lang_String_Handler ()
		{
			if (cb_getEnum_Ljava_lang_Class_Ljava_lang_String_ == null)
				cb_getEnum_Ljava_lang_Class_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetEnum_Ljava_lang_Class_Ljava_lang_String_);
			return cb_getEnum_Ljava_lang_Class_Ljava_lang_String_;
		}

		static IntPtr n_GetEnum_Ljava_lang_Class_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ValueMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetEnum (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ValueMap']/method[@name='getEnum' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("getEnum", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;", "GetGetEnum_Ljava_lang_Class_Ljava_lang_String_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.Enum<T>"})]
		public virtual unsafe global::Java.Lang.Object? GetEnum (global::Java.Lang.Class? p0, string? p1)
		{
			const string __id = "getEnum.(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;";
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object?) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_getFloat_Ljava_lang_String_F;
#pragma warning disable 0169
		static Delegate GetGetFloat_Ljava_lang_String_FHandler ()
		{
			if (cb_getFloat_Ljava_lang_String_F == null)
				cb_getFloat_Ljava_lang_String_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLF_F) n_GetFloat_Ljava_lang_String_F);
			return cb_getFloat_Ljava_lang_String_F;
		}

		static float n_GetFloat_Ljava_lang_String_F (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ValueMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.GetFloat (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ValueMap']/method[@name='getFloat' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float']]"
		[Register ("getFloat", "(Ljava/lang/String;F)F", "GetGetFloat_Ljava_lang_String_FHandler")]
		public virtual unsafe float GetFloat (string? p0, float p1)
		{
			const string __id = "getFloat.(Ljava/lang/String;F)F";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_getInt_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetGetInt_Ljava_lang_String_IHandler ()
		{
			if (cb_getInt_Ljava_lang_String_I == null)
				cb_getInt_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_I) n_GetInt_Ljava_lang_String_I);
			return cb_getInt_Ljava_lang_String_I;
		}

		static int n_GetInt_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ValueMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetInt (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ValueMap']/method[@name='getInt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getInt", "(Ljava/lang/String;I)I", "GetGetInt_Ljava_lang_String_IHandler")]
		public virtual unsafe int GetInt (string? p0, int p1)
		{
			const string __id = "getInt.(Ljava/lang/String;I)I";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_getList_Ljava_lang_Object_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetGetList_Ljava_lang_Object_Ljava_lang_Class_Handler ()
		{
			if (cb_getList_Ljava_lang_Object_Ljava_lang_Class_ == null)
				cb_getList_Ljava_lang_Object_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetList_Ljava_lang_Object_Ljava_lang_Class_);
			return cb_getList_Ljava_lang_Object_Ljava_lang_Class_;
		}

		static IntPtr n_GetList_Ljava_lang_Object_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ValueMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList.ToLocalJniHandle (__this.GetList (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ValueMap']/method[@name='getList' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("getList", "(Ljava/lang/Object;Ljava/lang/Class;)Ljava/util/List;", "GetGetList_Ljava_lang_Object_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.gainsight.px.mobile.ValueMap"})]
		public virtual unsafe global::System.Collections.IList? GetList (global::Java.Lang.Object? p0, global::Java.Lang.Class? p1)
		{
			const string __id = "getList.(Ljava/lang/Object;Ljava/lang/Class;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate? cb_getLong_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetGetLong_Ljava_lang_String_JHandler ()
		{
			if (cb_getLong_Ljava_lang_String_J == null)
				cb_getLong_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJ_J) n_GetLong_Ljava_lang_String_J);
			return cb_getLong_Ljava_lang_String_J;
		}

		static long n_GetLong_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ValueMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetLong (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ValueMap']/method[@name='getLong' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("getLong", "(Ljava/lang/String;J)J", "GetGetLong_Ljava_lang_String_JHandler")]
		public virtual unsafe long GetLong (string? p0, long p1)
		{
			const string __id = "getLong.(Ljava/lang/String;J)J";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_getString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetString_Ljava_lang_String_Handler ()
		{
			if (cb_getString_Ljava_lang_String_ == null)
				cb_getString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetString_Ljava_lang_String_);
			return cb_getString_Ljava_lang_String_;
		}

		static IntPtr n_GetString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ValueMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetString (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ValueMap']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getString", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetString_Ljava_lang_String_Handler")]
		public virtual unsafe string? GetString (string? p0)
		{
			const string __id = "getString.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_getValueMap_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetValueMap_Ljava_lang_Object_Handler ()
		{
			if (cb_getValueMap_Ljava_lang_Object_ == null)
				cb_getValueMap_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetValueMap_Ljava_lang_Object_);
			return cb_getValueMap_Ljava_lang_Object_;
		}

		static IntPtr n_GetValueMap_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ValueMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetValueMap (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ValueMap']/method[@name='getValueMap' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getValueMap", "(Ljava/lang/Object;)Lcom/gainsight/px/mobile/ValueMap;", "GetGetValueMap_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.ValueMap? GetValueMap (global::Java.Lang.Object? p0)
		{
			const string __id = "getValueMap.(Ljava/lang/Object;)Lcom/gainsight/px/mobile/ValueMap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ValueMap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_getValueMap_Ljava_lang_String_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetGetValueMap_Ljava_lang_String_Ljava_lang_Class_Handler ()
		{
			if (cb_getValueMap_Ljava_lang_String_Ljava_lang_Class_ == null)
				cb_getValueMap_Ljava_lang_String_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetValueMap_Ljava_lang_String_Ljava_lang_Class_);
			return cb_getValueMap_Ljava_lang_String_Ljava_lang_Class_;
		}

		static IntPtr n_GetValueMap_Ljava_lang_String_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ValueMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetValueMap (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ValueMap']/method[@name='getValueMap' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("getValueMap", "(Ljava/lang/String;Ljava/lang/Class;)Lcom/gainsight/px/mobile/ValueMap;", "GetGetValueMap_Ljava_lang_String_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.gainsight.px.mobile.ValueMap"})]
		public virtual unsafe global::Java.Lang.Object? GetValueMap (string? p0, global::Java.Lang.Class? p1)
		{
			const string __id = "getValueMap.(Ljava/lang/String;Ljava/lang/Class;)Lcom/gainsight/px/mobile/ValueMap;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object?) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate? cb_keySet;
#pragma warning disable 0169
		static Delegate GetKeySetHandler ()
		{
			if (cb_keySet == null)
				cb_keySet = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_KeySet);
			return cb_keySet;
		}

		static IntPtr n_KeySet (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ValueMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaCollection.ToLocalJniHandle (__this.KeySet ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ValueMap']/method[@name='keySet' and count(parameter)=0]"
		[Register ("keySet", "()LSystem/Collections/ICollection;", "GetKeySetHandler")]
		public virtual unsafe global::System.Collections.ICollection? KeySet ()
		{
			const string __id = "keySet.()LSystem/Collections/ICollection;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaCollection.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_put_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_put_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Put_Ljava_lang_String_Ljava_lang_Object_);
			return cb_put_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_Put_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ValueMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Put (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ValueMap']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("put", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;", "GetPut_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object? Put (string? p0, global::Java.Lang.Object? p1)
		{
			const string __id = "put.(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate? cb_putAll_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetPutAll_Ljava_util_Map_Handler ()
		{
			if (cb_putAll_Ljava_util_Map_ == null)
				cb_putAll_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PutAll_Ljava_util_Map_);
			return cb_putAll_Ljava_util_Map_;
		}

		static void n_PutAll_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ValueMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Android.Runtime.JavaDictionary<string, object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutAll (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ValueMap']/method[@name='putAll' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;? extends java.lang.String, ?&gt;']]"
		[Register ("putAll", "(Ljava/util/Map;)V", "GetPutAll_Ljava_util_Map_Handler")]
		public virtual unsafe void PutAll (global::System.Collections.Generic.IDictionary<string, object>? p0)
		{
			const string __id = "putAll.(Ljava/util/Map;)V";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, object>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_putValue_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPutValue_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_putValue_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_putValue_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_PutValue_Ljava_lang_String_Ljava_lang_Object_);
			return cb_putValue_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_PutValue_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ValueMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutValue (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ValueMap']/method[@name='putValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("putValue", "(Ljava/lang/String;Ljava/lang/Object;)Lcom/gainsight/px/mobile/ValueMap;", "GetPutValue_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.ValueMap? PutValue (string? p0, global::Java.Lang.Object? p1)
		{
			const string __id = "putValue.(Ljava/lang/String;Ljava/lang/Object;)Lcom/gainsight/px/mobile/ValueMap;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ValueMap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate? cb_remove_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_Object_Handler ()
		{
			if (cb_remove_Ljava_lang_Object_ == null)
				cb_remove_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Remove_Ljava_lang_Object_);
			return cb_remove_Ljava_lang_Object_;
		}

		static IntPtr n_Remove_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ValueMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Remove (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ValueMap']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("remove", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetRemove_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object? Remove (global::Java.Lang.Object? p0)
		{
			const string __id = "remove.(Ljava/lang/Object;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ValueMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Size ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ValueMap']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public virtual unsafe int Size ()
		{
			const string __id = "size.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate? cb_toJsonObject;
#pragma warning disable 0169
		static Delegate GetToJsonObjectHandler ()
		{
			if (cb_toJsonObject == null)
				cb_toJsonObject = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToJsonObject);
			return cb_toJsonObject;
		}

		static IntPtr n_ToJsonObject (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ValueMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.ToJsonObject ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ValueMap']/method[@name='toJsonObject' and count(parameter)=0]"
		[Register ("toJsonObject", "()Lorg/json/JSONObject;", "GetToJsonObjectHandler")]
		public virtual unsafe global::Org.Json.JSONObject? ToJsonObject ()
		{
			const string __id = "toJsonObject.()Lorg/json/JSONObject;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_toStringMap;
#pragma warning disable 0169
		static Delegate GetToStringMapHandler ()
		{
			if (cb_toStringMap == null)
				cb_toStringMap = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToStringMap);
			return cb_toStringMap;
		}

		static IntPtr n_ToStringMap (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ValueMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.ToStringMap ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ValueMap']/method[@name='toStringMap' and count(parameter)=0]"
		[Register ("toStringMap", "()Ljava/util/Map;", "GetToStringMapHandler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string>? ToStringMap ()
		{
			const string __id = "toStringMap.()Ljava/util/Map;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_values;
#pragma warning disable 0169
		static Delegate GetValuesHandler ()
		{
			if (cb_values == null)
				cb_values = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Values);
			return cb_values;
		}

		static IntPtr n_Values (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ValueMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaCollection.ToLocalJniHandle (__this.Values ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ValueMap']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()LSystem/Collections/ICollection;", "GetValuesHandler")]
		public virtual unsafe global::System.Collections.ICollection? Values ()
		{
			const string __id = "values.()LSystem/Collections/ICollection;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaCollection.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
