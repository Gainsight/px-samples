using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Gainsight.PX.Mobile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ScreenEventData']"
	[global::Android.Runtime.Register ("com/gainsight/px/mobile/ScreenEventData", DoNotGenerateAcw=true)]
	public partial class ScreenEventData : global::Com.Gainsight.PX.Mobile.ValueMap {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ScreenEventData']/field[@name='SCREEN_ACTION_KEY']"
		[Register ("SCREEN_ACTION_KEY")]
		public const string ScreenActionKey = (string) "action";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ScreenEventData']/field[@name='SCREEN_CLASS_KEY']"
		[Register ("SCREEN_CLASS_KEY")]
		public const string ScreenClassKey = (string) "screenClass";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ScreenEventData']/field[@name='SCREEN_DATA_KEY']"
		[Register ("SCREEN_DATA_KEY")]
		public const string ScreenDataKey = (string) "intentData";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ScreenEventData']/field[@name='SCREEN_NAME_KEY']"
		[Register ("SCREEN_NAME_KEY")]
		public const string ScreenNameKey = (string) "screenName";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ScreenEventData']/field[@name='SCREEN_PROPERTIES_KEY']"
		[Register ("SCREEN_PROPERTIES_KEY")]
		public const string ScreenPropertiesKey = (string) "properties";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/gainsight/px/mobile/ScreenEventData", typeof (ScreenEventData));

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

		protected ScreenEventData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ScreenEventData']/constructor[@name='ScreenEventData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe ScreenEventData (string? p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_intentAction;
#pragma warning disable 0169
		static Delegate GetIntentActionHandler ()
		{
			if (cb_intentAction == null)
				cb_intentAction = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_IntentAction);
			return cb_intentAction;
		}

		static IntPtr n_IntentAction (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ScreenEventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.IntentAction ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ScreenEventData']/method[@name='intentAction' and count(parameter)=0]"
		[Register ("intentAction", "()Ljava/lang/String;", "GetIntentActionHandler")]
		public virtual unsafe string? IntentAction ()
		{
			const string __id = "intentAction.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_intentData;
#pragma warning disable 0169
		static Delegate GetIntentDataHandler ()
		{
			if (cb_intentData == null)
				cb_intentData = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_IntentData);
			return cb_intentData;
		}

		static IntPtr n_IntentData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ScreenEventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.IntentData ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ScreenEventData']/method[@name='intentData' and count(parameter)=0]"
		[Register ("intentData", "()Ljava/lang/String;", "GetIntentDataHandler")]
		public virtual unsafe string? IntentData ()
		{
			const string __id = "intentData.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_properties;
#pragma warning disable 0169
		static Delegate GetPropertiesHandler ()
		{
			if (cb_properties == null)
				cb_properties = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Properties);
			return cb_properties;
		}

		static IntPtr n_Properties (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ScreenEventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.Properties ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ScreenEventData']/method[@name='properties' and count(parameter)=0]"
		[Register ("properties", "()Ljava/util/Map;", "GetPropertiesHandler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>? Properties ()
		{
			const string __id = "properties.()Ljava/util/Map;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_putIntentAction_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutIntentAction_Ljava_lang_String_Handler ()
		{
			if (cb_putIntentAction_Ljava_lang_String_ == null)
				cb_putIntentAction_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutIntentAction_Ljava_lang_String_);
			return cb_putIntentAction_Ljava_lang_String_;
		}

		static IntPtr n_PutIntentAction_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ScreenEventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutIntentAction (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ScreenEventData']/method[@name='putIntentAction' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putIntentAction", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/ScreenEventData;", "GetPutIntentAction_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.ScreenEventData? PutIntentAction (string? p0)
		{
			const string __id = "putIntentAction.(Ljava/lang/String;)Lcom/gainsight/px/mobile/ScreenEventData;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ScreenEventData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putIntentData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutIntentData_Ljava_lang_String_Handler ()
		{
			if (cb_putIntentData_Ljava_lang_String_ == null)
				cb_putIntentData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutIntentData_Ljava_lang_String_);
			return cb_putIntentData_Ljava_lang_String_;
		}

		static IntPtr n_PutIntentData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ScreenEventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutIntentData (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ScreenEventData']/method[@name='putIntentData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putIntentData", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/ScreenEventData;", "GetPutIntentData_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.ScreenEventData? PutIntentData (string? p0)
		{
			const string __id = "putIntentData.(Ljava/lang/String;)Lcom/gainsight/px/mobile/ScreenEventData;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ScreenEventData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putProperties_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetPutProperties_Ljava_util_Map_Handler ()
		{
			if (cb_putProperties_Ljava_util_Map_ == null)
				cb_putProperties_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutProperties_Ljava_util_Map_);
			return cb_putProperties_Ljava_util_Map_;
		}

		static IntPtr n_PutProperties_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ScreenEventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutProperties (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ScreenEventData']/method[@name='putProperties' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("putProperties", "(Ljava/util/Map;)Lcom/gainsight/px/mobile/ScreenEventData;", "GetPutProperties_Ljava_util_Map_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.ScreenEventData? PutProperties (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>? p0)
		{
			const string __id = "putProperties.(Ljava/util/Map;)Lcom/gainsight/px/mobile/ScreenEventData;";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ScreenEventData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_putScreenClass_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutScreenClass_Ljava_lang_String_Handler ()
		{
			if (cb_putScreenClass_Ljava_lang_String_ == null)
				cb_putScreenClass_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutScreenClass_Ljava_lang_String_);
			return cb_putScreenClass_Ljava_lang_String_;
		}

		static IntPtr n_PutScreenClass_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ScreenEventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutScreenClass (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ScreenEventData']/method[@name='putScreenClass' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putScreenClass", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/ScreenEventData;", "GetPutScreenClass_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.ScreenEventData? PutScreenClass (string? p0)
		{
			const string __id = "putScreenClass.(Ljava/lang/String;)Lcom/gainsight/px/mobile/ScreenEventData;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ScreenEventData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_screenClass;
#pragma warning disable 0169
		static Delegate GetScreenClassHandler ()
		{
			if (cb_screenClass == null)
				cb_screenClass = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ScreenClass);
			return cb_screenClass;
		}

		static IntPtr n_ScreenClass (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ScreenEventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.ScreenClass ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ScreenEventData']/method[@name='screenClass' and count(parameter)=0]"
		[Register ("screenClass", "()Ljava/lang/String;", "GetScreenClassHandler")]
		public virtual unsafe string? ScreenClass ()
		{
			const string __id = "screenClass.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_screenName;
#pragma warning disable 0169
		static Delegate GetScreenNameHandler ()
		{
			if (cb_screenName == null)
				cb_screenName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ScreenName);
			return cb_screenName;
		}

		static IntPtr n_ScreenName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ScreenEventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.ScreenName ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='ScreenEventData']/method[@name='screenName' and count(parameter)=0]"
		[Register ("screenName", "()Ljava/lang/String;", "GetScreenNameHandler")]
		public virtual unsafe string? ScreenName ()
		{
			const string __id = "screenName.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
