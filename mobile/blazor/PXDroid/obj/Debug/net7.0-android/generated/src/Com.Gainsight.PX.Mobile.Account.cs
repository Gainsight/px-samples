using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Gainsight.PX.Mobile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']"
	[global::Android.Runtime.Register ("com/gainsight/px/mobile/Account", DoNotGenerateAcw=true)]
	public partial class Account : global::Com.Gainsight.PX.Mobile.ValueMap {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/gainsight/px/mobile/Account", typeof (Account));

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

		protected Account (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/constructor[@name='Account' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe Account (string? p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate? cb_city;
#pragma warning disable 0169
		static Delegate GetCityHandler ()
		{
			if (cb_city == null)
				cb_city = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_City);
			return cb_city;
		}

		static IntPtr n_City (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.City ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='city' and count(parameter)=0]"
		[Register ("city", "()Ljava/lang/String;", "GetCityHandler")]
		public virtual unsafe string? City ()
		{
			const string __id = "city.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_continent;
#pragma warning disable 0169
		static Delegate GetContinentHandler ()
		{
			if (cb_continent == null)
				cb_continent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Continent);
			return cb_continent;
		}

		static IntPtr n_Continent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Continent ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='continent' and count(parameter)=0]"
		[Register ("continent", "()Ljava/lang/String;", "GetContinentHandler")]
		public virtual unsafe string? Continent ()
		{
			const string __id = "continent.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_countryCode;
#pragma warning disable 0169
		static Delegate GetCountryCodeHandler ()
		{
			if (cb_countryCode == null)
				cb_countryCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_CountryCode);
			return cb_countryCode;
		}

		static IntPtr n_CountryCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.CountryCode ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='countryCode' and count(parameter)=0]"
		[Register ("countryCode", "()Ljava/lang/String;", "GetCountryCodeHandler")]
		public virtual unsafe string? CountryCode ()
		{
			const string __id = "countryCode.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_countryName;
#pragma warning disable 0169
		static Delegate GetCountryNameHandler ()
		{
			if (cb_countryName == null)
				cb_countryName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_CountryName);
			return cb_countryName;
		}

		static IntPtr n_CountryName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.CountryName ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='countryName' and count(parameter)=0]"
		[Register ("countryName", "()Ljava/lang/String;", "GetCountryNameHandler")]
		public virtual unsafe string? CountryName ()
		{
			const string __id = "countryName.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_customAttributes;
#pragma warning disable 0169
		static Delegate GetCustomAttributesHandler ()
		{
			if (cb_customAttributes == null)
				cb_customAttributes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_CustomAttributes);
			return cb_customAttributes;
		}

		static IntPtr n_CustomAttributes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.CustomAttributes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='customAttributes' and count(parameter)=0]"
		[Register ("customAttributes", "()Ljava/util/Map;", "GetCustomAttributesHandler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>? CustomAttributes ()
		{
			const string __id = "customAttributes.()Ljava/util/Map;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_employees;
#pragma warning disable 0169
		static Delegate GetEmployeesHandler ()
		{
			if (cb_employees == null)
				cb_employees = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_Employees);
			return cb_employees;
		}

		static long n_Employees (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Employees ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='employees' and count(parameter)=0]"
		[Register ("employees", "()J", "GetEmployeesHandler")]
		public virtual unsafe long Employees ()
		{
			const string __id = "employees.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate? cb_id;
#pragma warning disable 0169
		static Delegate GetIdHandler ()
		{
			if (cb_id == null)
				cb_id = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Id);
			return cb_id;
		}

		static IntPtr n_Id (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Id ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='id' and count(parameter)=0]"
		[Register ("id", "()Ljava/lang/String;", "GetIdHandler")]
		public virtual unsafe string? Id ()
		{
			const string __id = "id.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_industry;
#pragma warning disable 0169
		static Delegate GetIndustryHandler ()
		{
			if (cb_industry == null)
				cb_industry = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Industry);
			return cb_industry;
		}

		static IntPtr n_Industry (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Industry ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='industry' and count(parameter)=0]"
		[Register ("industry", "()Ljava/lang/String;", "GetIndustryHandler")]
		public virtual unsafe string? Industry ()
		{
			const string __id = "industry.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_latitude;
#pragma warning disable 0169
		static Delegate GetLatitudeHandler ()
		{
			if (cb_latitude == null)
				cb_latitude = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_D) n_Latitude);
			return cb_latitude;
		}

		static double n_Latitude (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Latitude ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='latitude' and count(parameter)=0]"
		[Register ("latitude", "()D", "GetLatitudeHandler")]
		public virtual unsafe double Latitude ()
		{
			const string __id = "latitude.()D";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate? cb_longitude;
#pragma warning disable 0169
		static Delegate GetLongitudeHandler ()
		{
			if (cb_longitude == null)
				cb_longitude = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_D) n_Longitude);
			return cb_longitude;
		}

		static double n_Longitude (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Longitude ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='longitude' and count(parameter)=0]"
		[Register ("longitude", "()D", "GetLongitudeHandler")]
		public virtual unsafe double Longitude ()
		{
			const string __id = "longitude.()D";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate? cb_naicsCode;
#pragma warning disable 0169
		static Delegate GetNaicsCodeHandler ()
		{
			if (cb_naicsCode == null)
				cb_naicsCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NaicsCode);
			return cb_naicsCode;
		}

		static IntPtr n_NaicsCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.NaicsCode ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='naicsCode' and count(parameter)=0]"
		[Register ("naicsCode", "()Ljava/lang/String;", "GetNaicsCodeHandler")]
		public virtual unsafe string? NaicsCode ()
		{
			const string __id = "naicsCode.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_name;
#pragma warning disable 0169
		static Delegate GetNameHandler ()
		{
			if (cb_name == null)
				cb_name = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Name);
			return cb_name;
		}

		static IntPtr n_Name (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Name ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='name' and count(parameter)=0]"
		[Register ("name", "()Ljava/lang/String;", "GetNameHandler")]
		public virtual unsafe string? Name ()
		{
			const string __id = "name.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_plan;
#pragma warning disable 0169
		static Delegate GetPlanHandler ()
		{
			if (cb_plan == null)
				cb_plan = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Plan);
			return cb_plan;
		}

		static IntPtr n_Plan (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Plan ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='plan' and count(parameter)=0]"
		[Register ("plan", "()Ljava/lang/String;", "GetPlanHandler")]
		public virtual unsafe string? Plan ()
		{
			const string __id = "plan.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_postalCode;
#pragma warning disable 0169
		static Delegate GetPostalCodeHandler ()
		{
			if (cb_postalCode == null)
				cb_postalCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_PostalCode);
			return cb_postalCode;
		}

		static IntPtr n_PostalCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.PostalCode ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='postalCode' and count(parameter)=0]"
		[Register ("postalCode", "()Ljava/lang/String;", "GetPostalCodeHandler")]
		public virtual unsafe string? PostalCode ()
		{
			const string __id = "postalCode.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_putCity_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutCity_Ljava_lang_String_Handler ()
		{
			if (cb_putCity_Ljava_lang_String_ == null)
				cb_putCity_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutCity_Ljava_lang_String_);
			return cb_putCity_Ljava_lang_String_;
		}

		static IntPtr n_PutCity_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutCity (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='putCity' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putCity", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;", "GetPutCity_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.Account? PutCity (string? p0)
		{
			const string __id = "putCity.(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putContinent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutContinent_Ljava_lang_String_Handler ()
		{
			if (cb_putContinent_Ljava_lang_String_ == null)
				cb_putContinent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutContinent_Ljava_lang_String_);
			return cb_putContinent_Ljava_lang_String_;
		}

		static IntPtr n_PutContinent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutContinent (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='putContinent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putContinent", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;", "GetPutContinent_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.Account? PutContinent (string? p0)
		{
			const string __id = "putContinent.(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putCountryCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutCountryCode_Ljava_lang_String_Handler ()
		{
			if (cb_putCountryCode_Ljava_lang_String_ == null)
				cb_putCountryCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutCountryCode_Ljava_lang_String_);
			return cb_putCountryCode_Ljava_lang_String_;
		}

		static IntPtr n_PutCountryCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutCountryCode (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='putCountryCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putCountryCode", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;", "GetPutCountryCode_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.Account? PutCountryCode (string? p0)
		{
			const string __id = "putCountryCode.(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putCountryName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutCountryName_Ljava_lang_String_Handler ()
		{
			if (cb_putCountryName_Ljava_lang_String_ == null)
				cb_putCountryName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutCountryName_Ljava_lang_String_);
			return cb_putCountryName_Ljava_lang_String_;
		}

		static IntPtr n_PutCountryName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutCountryName (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='putCountryName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putCountryName", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;", "GetPutCountryName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.Account? PutCountryName (string? p0)
		{
			const string __id = "putCountryName.(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putCustomAttributes_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetPutCustomAttributes_Ljava_util_Map_Handler ()
		{
			if (cb_putCustomAttributes_Ljava_util_Map_ == null)
				cb_putCustomAttributes_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutCustomAttributes_Ljava_util_Map_);
			return cb_putCustomAttributes_Ljava_util_Map_;
		}

		static IntPtr n_PutCustomAttributes_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutCustomAttributes (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='putCustomAttributes' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("putCustomAttributes", "(Ljava/util/Map;)Lcom/gainsight/px/mobile/Account;", "GetPutCustomAttributes_Ljava_util_Map_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.Account? PutCustomAttributes (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>? p0)
		{
			const string __id = "putCustomAttributes.(Ljava/util/Map;)Lcom/gainsight/px/mobile/Account;";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_putEmployees_J;
#pragma warning disable 0169
		static Delegate GetPutEmployees_JHandler ()
		{
			if (cb_putEmployees_J == null)
				cb_putEmployees_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_PutEmployees_J);
			return cb_putEmployees_J;
		}

		static IntPtr n_PutEmployees_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.PutEmployees (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='putEmployees' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("putEmployees", "(J)Lcom/gainsight/px/mobile/Account;", "GetPutEmployees_JHandler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.Account? PutEmployees (long p0)
		{
			const string __id = "putEmployees.(J)Lcom/gainsight/px/mobile/Account;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_putIndustry_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutIndustry_Ljava_lang_String_Handler ()
		{
			if (cb_putIndustry_Ljava_lang_String_ == null)
				cb_putIndustry_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutIndustry_Ljava_lang_String_);
			return cb_putIndustry_Ljava_lang_String_;
		}

		static IntPtr n_PutIndustry_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutIndustry (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='putIndustry' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putIndustry", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;", "GetPutIndustry_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.Account? PutIndustry (string? p0)
		{
			const string __id = "putIndustry.(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putLatitude_D;
#pragma warning disable 0169
		static Delegate GetPutLatitude_DHandler ()
		{
			if (cb_putLatitude_D == null)
				cb_putLatitude_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPD_L) n_PutLatitude_D);
			return cb_putLatitude_D;
		}

		static IntPtr n_PutLatitude_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.PutLatitude (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='putLatitude' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("putLatitude", "(D)Lcom/gainsight/px/mobile/Account;", "GetPutLatitude_DHandler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.Account? PutLatitude (double p0)
		{
			const string __id = "putLatitude.(D)Lcom/gainsight/px/mobile/Account;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_putLongitude_D;
#pragma warning disable 0169
		static Delegate GetPutLongitude_DHandler ()
		{
			if (cb_putLongitude_D == null)
				cb_putLongitude_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPD_L) n_PutLongitude_D);
			return cb_putLongitude_D;
		}

		static IntPtr n_PutLongitude_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.PutLongitude (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='putLongitude' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("putLongitude", "(D)Lcom/gainsight/px/mobile/Account;", "GetPutLongitude_DHandler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.Account? PutLongitude (double p0)
		{
			const string __id = "putLongitude.(D)Lcom/gainsight/px/mobile/Account;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_putNaicsCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutNaicsCode_Ljava_lang_String_Handler ()
		{
			if (cb_putNaicsCode_Ljava_lang_String_ == null)
				cb_putNaicsCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutNaicsCode_Ljava_lang_String_);
			return cb_putNaicsCode_Ljava_lang_String_;
		}

		static IntPtr n_PutNaicsCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutNaicsCode (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='putNaicsCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putNaicsCode", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;", "GetPutNaicsCode_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.Account? PutNaicsCode (string? p0)
		{
			const string __id = "putNaicsCode.(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutName_Ljava_lang_String_Handler ()
		{
			if (cb_putName_Ljava_lang_String_ == null)
				cb_putName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutName_Ljava_lang_String_);
			return cb_putName_Ljava_lang_String_;
		}

		static IntPtr n_PutName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutName (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='putName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putName", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;", "GetPutName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.Account? PutName (string? p0)
		{
			const string __id = "putName.(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putPlan_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutPlan_Ljava_lang_String_Handler ()
		{
			if (cb_putPlan_Ljava_lang_String_ == null)
				cb_putPlan_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutPlan_Ljava_lang_String_);
			return cb_putPlan_Ljava_lang_String_;
		}

		static IntPtr n_PutPlan_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutPlan (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='putPlan' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putPlan", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;", "GetPutPlan_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.Account? PutPlan (string? p0)
		{
			const string __id = "putPlan.(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putPostalCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutPostalCode_Ljava_lang_String_Handler ()
		{
			if (cb_putPostalCode_Ljava_lang_String_ == null)
				cb_putPostalCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutPostalCode_Ljava_lang_String_);
			return cb_putPostalCode_Ljava_lang_String_;
		}

		static IntPtr n_PutPostalCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutPostalCode (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='putPostalCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putPostalCode", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;", "GetPutPostalCode_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.Account? PutPostalCode (string? p0)
		{
			const string __id = "putPostalCode.(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putRegionName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutRegionName_Ljava_lang_String_Handler ()
		{
			if (cb_putRegionName_Ljava_lang_String_ == null)
				cb_putRegionName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutRegionName_Ljava_lang_String_);
			return cb_putRegionName_Ljava_lang_String_;
		}

		static IntPtr n_PutRegionName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutRegionName (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='putRegionName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putRegionName", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;", "GetPutRegionName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.Account? PutRegionName (string? p0)
		{
			const string __id = "putRegionName.(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putSfdcContactId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutSfdcContactId_Ljava_lang_String_Handler ()
		{
			if (cb_putSfdcContactId_Ljava_lang_String_ == null)
				cb_putSfdcContactId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutSfdcContactId_Ljava_lang_String_);
			return cb_putSfdcContactId_Ljava_lang_String_;
		}

		static IntPtr n_PutSfdcContactId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutSfdcContactId (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='putSfdcContactId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putSfdcContactId", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;", "GetPutSfdcContactId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.Account? PutSfdcContactId (string? p0)
		{
			const string __id = "putSfdcContactId.(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putSicCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutSicCode_Ljava_lang_String_Handler ()
		{
			if (cb_putSicCode_Ljava_lang_String_ == null)
				cb_putSicCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutSicCode_Ljava_lang_String_);
			return cb_putSicCode_Ljava_lang_String_;
		}

		static IntPtr n_PutSicCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutSicCode (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='putSicCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putSicCode", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;", "GetPutSicCode_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.Account? PutSicCode (string? p0)
		{
			const string __id = "putSicCode.(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putStateCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutStateCode_Ljava_lang_String_Handler ()
		{
			if (cb_putStateCode_Ljava_lang_String_ == null)
				cb_putStateCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutStateCode_Ljava_lang_String_);
			return cb_putStateCode_Ljava_lang_String_;
		}

		static IntPtr n_PutStateCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutStateCode (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='putStateCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putStateCode", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;", "GetPutStateCode_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.Account? PutStateCode (string? p0)
		{
			const string __id = "putStateCode.(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putStateName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutStateName_Ljava_lang_String_Handler ()
		{
			if (cb_putStateName_Ljava_lang_String_ == null)
				cb_putStateName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutStateName_Ljava_lang_String_);
			return cb_putStateName_Ljava_lang_String_;
		}

		static IntPtr n_PutStateName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutStateName (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='putStateName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putStateName", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;", "GetPutStateName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.Account? PutStateName (string? p0)
		{
			const string __id = "putStateName.(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putStreet_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutStreet_Ljava_lang_String_Handler ()
		{
			if (cb_putStreet_Ljava_lang_String_ == null)
				cb_putStreet_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutStreet_Ljava_lang_String_);
			return cb_putStreet_Ljava_lang_String_;
		}

		static IntPtr n_PutStreet_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutStreet (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='putStreet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putStreet", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;", "GetPutStreet_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.Account? PutStreet (string? p0)
		{
			const string __id = "putStreet.(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putSubscriptionId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutSubscriptionId_Ljava_lang_String_Handler ()
		{
			if (cb_putSubscriptionId_Ljava_lang_String_ == null)
				cb_putSubscriptionId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutSubscriptionId_Ljava_lang_String_);
			return cb_putSubscriptionId_Ljava_lang_String_;
		}

		static IntPtr n_PutSubscriptionId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutSubscriptionId (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='putSubscriptionId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putSubscriptionId", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;", "GetPutSubscriptionId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.Account? PutSubscriptionId (string? p0)
		{
			const string __id = "putSubscriptionId.(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putTimeZone_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutTimeZone_Ljava_lang_String_Handler ()
		{
			if (cb_putTimeZone_Ljava_lang_String_ == null)
				cb_putTimeZone_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutTimeZone_Ljava_lang_String_);
			return cb_putTimeZone_Ljava_lang_String_;
		}

		static IntPtr n_PutTimeZone_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutTimeZone (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='putTimeZone' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putTimeZone", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;", "GetPutTimeZone_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.Account? PutTimeZone (string? p0)
		{
			const string __id = "putTimeZone.(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putWebsite_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutWebsite_Ljava_lang_String_Handler ()
		{
			if (cb_putWebsite_Ljava_lang_String_ == null)
				cb_putWebsite_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutWebsite_Ljava_lang_String_);
			return cb_putWebsite_Ljava_lang_String_;
		}

		static IntPtr n_PutWebsite_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutWebsite (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='putWebsite' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putWebsite", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;", "GetPutWebsite_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.Account? PutWebsite (string? p0)
		{
			const string __id = "putWebsite.(Ljava/lang/String;)Lcom/gainsight/px/mobile/Account;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_regionName;
#pragma warning disable 0169
		static Delegate GetRegionNameHandler ()
		{
			if (cb_regionName == null)
				cb_regionName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_RegionName);
			return cb_regionName;
		}

		static IntPtr n_RegionName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.RegionName ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='regionName' and count(parameter)=0]"
		[Register ("regionName", "()Ljava/lang/String;", "GetRegionNameHandler")]
		public virtual unsafe string? RegionName ()
		{
			const string __id = "regionName.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_sfdcContactId;
#pragma warning disable 0169
		static Delegate GetSfdcContactIdHandler ()
		{
			if (cb_sfdcContactId == null)
				cb_sfdcContactId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_SfdcContactId);
			return cb_sfdcContactId;
		}

		static IntPtr n_SfdcContactId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.SfdcContactId ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='sfdcContactId' and count(parameter)=0]"
		[Register ("sfdcContactId", "()Ljava/lang/String;", "GetSfdcContactIdHandler")]
		public virtual unsafe string? SfdcContactId ()
		{
			const string __id = "sfdcContactId.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_sicCode;
#pragma warning disable 0169
		static Delegate GetSicCodeHandler ()
		{
			if (cb_sicCode == null)
				cb_sicCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_SicCode);
			return cb_sicCode;
		}

		static IntPtr n_SicCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.SicCode ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='sicCode' and count(parameter)=0]"
		[Register ("sicCode", "()Ljava/lang/String;", "GetSicCodeHandler")]
		public virtual unsafe string? SicCode ()
		{
			const string __id = "sicCode.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_stateCode;
#pragma warning disable 0169
		static Delegate GetStateCodeHandler ()
		{
			if (cb_stateCode == null)
				cb_stateCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_StateCode);
			return cb_stateCode;
		}

		static IntPtr n_StateCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.StateCode ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='stateCode' and count(parameter)=0]"
		[Register ("stateCode", "()Ljava/lang/String;", "GetStateCodeHandler")]
		public virtual unsafe string? StateCode ()
		{
			const string __id = "stateCode.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_stateName;
#pragma warning disable 0169
		static Delegate GetStateNameHandler ()
		{
			if (cb_stateName == null)
				cb_stateName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_StateName);
			return cb_stateName;
		}

		static IntPtr n_StateName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.StateName ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='stateName' and count(parameter)=0]"
		[Register ("stateName", "()Ljava/lang/String;", "GetStateNameHandler")]
		public virtual unsafe string? StateName ()
		{
			const string __id = "stateName.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_street;
#pragma warning disable 0169
		static Delegate GetStreetHandler ()
		{
			if (cb_street == null)
				cb_street = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Street);
			return cb_street;
		}

		static IntPtr n_Street (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Street ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='street' and count(parameter)=0]"
		[Register ("street", "()Ljava/lang/String;", "GetStreetHandler")]
		public virtual unsafe string? Street ()
		{
			const string __id = "street.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_subscriptionId;
#pragma warning disable 0169
		static Delegate GetSubscriptionIdHandler ()
		{
			if (cb_subscriptionId == null)
				cb_subscriptionId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_SubscriptionId);
			return cb_subscriptionId;
		}

		static IntPtr n_SubscriptionId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.SubscriptionId ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='subscriptionId' and count(parameter)=0]"
		[Register ("subscriptionId", "()Ljava/lang/String;", "GetSubscriptionIdHandler")]
		public virtual unsafe string? SubscriptionId ()
		{
			const string __id = "subscriptionId.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_timeZone;
#pragma warning disable 0169
		static Delegate GetTimeZoneHandler ()
		{
			if (cb_timeZone == null)
				cb_timeZone = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_TimeZone);
			return cb_timeZone;
		}

		static IntPtr n_TimeZone (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.TimeZone ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='timeZone' and count(parameter)=0]"
		[Register ("timeZone", "()Ljava/lang/String;", "GetTimeZoneHandler")]
		public virtual unsafe string? TimeZone ()
		{
			const string __id = "timeZone.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_unmodifiableCopy;
#pragma warning disable 0169
		static Delegate GetUnmodifiableCopyHandler ()
		{
			if (cb_unmodifiableCopy == null)
				cb_unmodifiableCopy = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_UnmodifiableCopy);
			return cb_unmodifiableCopy;
		}

		static IntPtr n_UnmodifiableCopy (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.UnmodifiableCopy ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='unmodifiableCopy' and count(parameter)=0]"
		[Register ("unmodifiableCopy", "()Lcom/gainsight/px/mobile/Account;", "GetUnmodifiableCopyHandler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.Account? UnmodifiableCopy ()
		{
			const string __id = "unmodifiableCopy.()Lcom/gainsight/px/mobile/Account;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_website;
#pragma warning disable 0169
		static Delegate GetWebsiteHandler ()
		{
			if (cb_website == null)
				cb_website = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Website);
			return cb_website;
		}

		static IntPtr n_Website (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Website ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='Account']/method[@name='website' and count(parameter)=0]"
		[Register ("website", "()Ljava/lang/String;", "GetWebsiteHandler")]
		public virtual unsafe string? Website ()
		{
			const string __id = "website.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
