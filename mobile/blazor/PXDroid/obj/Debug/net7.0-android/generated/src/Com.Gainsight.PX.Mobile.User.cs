using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Gainsight.PX.Mobile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']"
	[global::Android.Runtime.Register ("com/gainsight/px/mobile/User", DoNotGenerateAcw=true)]
	public partial class User : global::Com.Gainsight.PX.Mobile.ValueMap {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User.Gender']"
		[global::Android.Runtime.Register ("com/gainsight/px/mobile/User$Gender", DoNotGenerateAcw=true)]
		public sealed partial class Gender : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User.Gender']/field[@name='FEMALE']"
			[Register ("FEMALE")]
			public static global::Com.Gainsight.PX.Mobile.User.Gender? Female {
				get {
					const string __id = "FEMALE.Lcom/gainsight/px/mobile/User$Gender;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User.Gender> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User.Gender']/field[@name='MALE']"
			[Register ("MALE")]
			public static global::Com.Gainsight.PX.Mobile.User.Gender? Male {
				get {
					const string __id = "MALE.Lcom/gainsight/px/mobile/User$Gender;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User.Gender> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User.Gender']/field[@name='NOT_SET']"
			[Register ("NOT_SET")]
			public static global::Com.Gainsight.PX.Mobile.User.Gender? NotSet {
				get {
					const string __id = "NOT_SET.Lcom/gainsight/px/mobile/User$Gender;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User.Gender> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User.Gender']/field[@name='OTHER']"
			[Register ("OTHER")]
			public static global::Com.Gainsight.PX.Mobile.User.Gender? Other {
				get {
					const string __id = "OTHER.Lcom/gainsight/px/mobile/User$Gender;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User.Gender> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/gainsight/px/mobile/User$Gender", typeof (Gender));

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

			internal Gender (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User.Gender']/method[@name='getGender' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("getGender", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/User$Gender;", "")]
			public static unsafe global::Com.Gainsight.PX.Mobile.User.Gender? GetGender (string? p0)
			{
				const string __id = "getGender.(Ljava/lang/String;)Lcom/gainsight/px/mobile/User$Gender;";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User.Gender> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User.Gender']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/User$Gender;", "")]
			public static unsafe global::Com.Gainsight.PX.Mobile.User.Gender? ValueOf (string? p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/gainsight/px/mobile/User$Gender;";
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User.Gender> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User.Gender']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/gainsight/px/mobile/User$Gender;", "")]
			public static unsafe global::Com.Gainsight.PX.Mobile.User.Gender[]? Values ()
			{
				const string __id = "values.()[Lcom/gainsight/px/mobile/User$Gender;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Gainsight.PX.Mobile.User.Gender[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Gainsight.PX.Mobile.User.Gender));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/gainsight/px/mobile/User", typeof (User));

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

		protected User (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/constructor[@name='User' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe User (string? p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate? cb_accountId;
#pragma warning disable 0169
		static Delegate GetAccountIdHandler ()
		{
			if (cb_accountId == null)
				cb_accountId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AccountId);
			return cb_accountId;
		}

		static IntPtr n_AccountId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.AccountId ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='accountId' and count(parameter)=0]"
		[Register ("accountId", "()Ljava/lang/String;", "GetAccountIdHandler")]
		public virtual unsafe string? AccountId ()
		{
			const string __id = "accountId.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.City ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='city' and count(parameter)=0]"
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

		static Delegate? cb_continentCode;
#pragma warning disable 0169
		static Delegate GetContinentCodeHandler ()
		{
			if (cb_continentCode == null)
				cb_continentCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ContinentCode);
			return cb_continentCode;
		}

		static IntPtr n_ContinentCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.ContinentCode ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='continentCode' and count(parameter)=0]"
		[Register ("continentCode", "()Ljava/lang/String;", "GetContinentCodeHandler")]
		public virtual unsafe string? ContinentCode ()
		{
			const string __id = "continentCode.()Ljava/lang/String;";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.CountryCode ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='countryCode' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.CountryName ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='countryName' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.CustomAttributes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='customAttributes' and count(parameter)=0]"
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

		static Delegate? cb_email;
#pragma warning disable 0169
		static Delegate GetEmailHandler ()
		{
			if (cb_email == null)
				cb_email = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Email);
			return cb_email;
		}

		static IntPtr n_Email (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Email ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='email' and count(parameter)=0]"
		[Register ("email", "()Ljava/lang/String;", "GetEmailHandler")]
		public virtual unsafe string? Email ()
		{
			const string __id = "email.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_firstName;
#pragma warning disable 0169
		static Delegate GetFirstNameHandler ()
		{
			if (cb_firstName == null)
				cb_firstName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_FirstName);
			return cb_firstName;
		}

		static IntPtr n_FirstName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.FirstName ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='firstName' and count(parameter)=0]"
		[Register ("firstName", "()Ljava/lang/String;", "GetFirstNameHandler")]
		public virtual unsafe string? FirstName ()
		{
			const string __id = "firstName.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_firstVisitDate;
#pragma warning disable 0169
		static Delegate GetFirstVisitDateHandler ()
		{
			if (cb_firstVisitDate == null)
				cb_firstVisitDate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_FirstVisitDate);
			return cb_firstVisitDate;
		}

		static IntPtr n_FirstVisitDate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.FirstVisitDate ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='firstVisitDate' and count(parameter)=0]"
		[Register ("firstVisitDate", "()Ljava/util/Date;", "GetFirstVisitDateHandler")]
		public virtual unsafe global::Java.Util.Date? FirstVisitDate ()
		{
			const string __id = "firstVisitDate.()Ljava/util/Date;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_gender;
#pragma warning disable 0169
		static Delegate GetInvokeGenderHandler ()
		{
			if (cb_gender == null)
				cb_gender = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_InvokeGender);
			return cb_gender;
		}

		static IntPtr n_InvokeGender (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.InvokeGender ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='gender' and count(parameter)=0]"
		[Register ("gender", "()Lcom/gainsight/px/mobile/User$Gender;", "GetInvokeGenderHandler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User.Gender? InvokeGender ()
		{
			const string __id = "gender.()Lcom/gainsight/px/mobile/User$Gender;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User.Gender> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_identifyId;
#pragma warning disable 0169
		static Delegate GetIdentifyIdHandler ()
		{
			if (cb_identifyId == null)
				cb_identifyId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_IdentifyId);
			return cb_identifyId;
		}

		static IntPtr n_IdentifyId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.IdentifyId ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='identifyId' and count(parameter)=0]"
		[Register ("identifyId", "()Ljava/lang/String;", "GetIdentifyIdHandler")]
		public virtual unsafe string? IdentifyId ()
		{
			const string __id = "identifyId.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_identifyIdHash;
#pragma warning disable 0169
		static Delegate GetIdentifyIdHashHandler ()
		{
			if (cb_identifyIdHash == null)
				cb_identifyIdHash = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_IdentifyIdHash);
			return cb_identifyIdHash;
		}

		static IntPtr n_IdentifyIdHash (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.IdentifyIdHash ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='identifyIdHash' and count(parameter)=0]"
		[Register ("identifyIdHash", "()Ljava/lang/String;", "GetIdentifyIdHashHandler")]
		public virtual unsafe string? IdentifyIdHash ()
		{
			const string __id = "identifyIdHash.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_lastName;
#pragma warning disable 0169
		static Delegate GetLastNameHandler ()
		{
			if (cb_lastName == null)
				cb_lastName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_LastName);
			return cb_lastName;
		}

		static IntPtr n_LastName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.LastName ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='lastName' and count(parameter)=0]"
		[Register ("lastName", "()Ljava/lang/String;", "GetLastNameHandler")]
		public virtual unsafe string? LastName ()
		{
			const string __id = "lastName.()Ljava/lang/String;";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Latitude ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='latitude' and count(parameter)=0]"
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

		static Delegate? cb_leadDate;
#pragma warning disable 0169
		static Delegate GetLeadDateHandler ()
		{
			if (cb_leadDate == null)
				cb_leadDate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_LeadDate);
			return cb_leadDate;
		}

		static IntPtr n_LeadDate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.LeadDate ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='leadDate' and count(parameter)=0]"
		[Register ("leadDate", "()Ljava/util/Date;", "GetLeadDateHandler")]
		public virtual unsafe global::Java.Util.Date? LeadDate ()
		{
			const string __id = "leadDate.()Ljava/util/Date;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Longitude ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='longitude' and count(parameter)=0]"
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

		static Delegate? cb_organizationDuns;
#pragma warning disable 0169
		static Delegate GetOrganizationDunsHandler ()
		{
			if (cb_organizationDuns == null)
				cb_organizationDuns = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_OrganizationDuns);
			return cb_organizationDuns;
		}

		static long n_OrganizationDuns (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.OrganizationDuns ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='organizationDuns' and count(parameter)=0]"
		[Register ("organizationDuns", "()J", "GetOrganizationDunsHandler")]
		public virtual unsafe long OrganizationDuns ()
		{
			const string __id = "organizationDuns.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate? cb_organizationEmployees;
#pragma warning disable 0169
		static Delegate GetOrganizationEmployeesHandler ()
		{
			if (cb_organizationEmployees == null)
				cb_organizationEmployees = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_OrganizationEmployees);
			return cb_organizationEmployees;
		}

		static IntPtr n_OrganizationEmployees (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.OrganizationEmployees ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='organizationEmployees' and count(parameter)=0]"
		[Register ("organizationEmployees", "()Ljava/lang/String;", "GetOrganizationEmployeesHandler")]
		public virtual unsafe string? OrganizationEmployees ()
		{
			const string __id = "organizationEmployees.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_organizationIndustry;
#pragma warning disable 0169
		static Delegate GetOrganizationIndustryHandler ()
		{
			if (cb_organizationIndustry == null)
				cb_organizationIndustry = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_OrganizationIndustry);
			return cb_organizationIndustry;
		}

		static IntPtr n_OrganizationIndustry (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.OrganizationIndustry ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='organizationIndustry' and count(parameter)=0]"
		[Register ("organizationIndustry", "()Ljava/lang/String;", "GetOrganizationIndustryHandler")]
		public virtual unsafe string? OrganizationIndustry ()
		{
			const string __id = "organizationIndustry.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_organizationName;
#pragma warning disable 0169
		static Delegate GetOrganizationNameHandler ()
		{
			if (cb_organizationName == null)
				cb_organizationName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_OrganizationName);
			return cb_organizationName;
		}

		static IntPtr n_OrganizationName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.OrganizationName ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='organizationName' and count(parameter)=0]"
		[Register ("organizationName", "()Ljava/lang/String;", "GetOrganizationNameHandler")]
		public virtual unsafe string? OrganizationName ()
		{
			const string __id = "organizationName.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_organizationRevenue;
#pragma warning disable 0169
		static Delegate GetOrganizationRevenueHandler ()
		{
			if (cb_organizationRevenue == null)
				cb_organizationRevenue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_OrganizationRevenue);
			return cb_organizationRevenue;
		}

		static IntPtr n_OrganizationRevenue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.OrganizationRevenue ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='organizationRevenue' and count(parameter)=0]"
		[Register ("organizationRevenue", "()Ljava/lang/String;", "GetOrganizationRevenueHandler")]
		public virtual unsafe string? OrganizationRevenue ()
		{
			const string __id = "organizationRevenue.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_organizationSicCode;
#pragma warning disable 0169
		static Delegate GetOrganizationSicCodeHandler ()
		{
			if (cb_organizationSicCode == null)
				cb_organizationSicCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_OrganizationSicCode);
			return cb_organizationSicCode;
		}

		static IntPtr n_OrganizationSicCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.OrganizationSicCode ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='organizationSicCode' and count(parameter)=0]"
		[Register ("organizationSicCode", "()Ljava/lang/String;", "GetOrganizationSicCodeHandler")]
		public virtual unsafe string? OrganizationSicCode ()
		{
			const string __id = "organizationSicCode.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_phone;
#pragma warning disable 0169
		static Delegate GetPhoneHandler ()
		{
			if (cb_phone == null)
				cb_phone = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Phone);
			return cb_phone;
		}

		static IntPtr n_Phone (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Phone ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='phone' and count(parameter)=0]"
		[Register ("phone", "()Ljava/lang/String;", "GetPhoneHandler")]
		public virtual unsafe string? Phone ()
		{
			const string __id = "phone.()Ljava/lang/String;";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.PostalCode ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='postalCode' and count(parameter)=0]"
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

		static Delegate? cb_putAccountId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutAccountId_Ljava_lang_String_Handler ()
		{
			if (cb_putAccountId_Ljava_lang_String_ == null)
				cb_putAccountId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutAccountId_Ljava_lang_String_);
			return cb_putAccountId_Ljava_lang_String_;
		}

		static IntPtr n_PutAccountId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutAccountId (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putAccountId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putAccountId", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;", "GetPutAccountId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutAccountId (string? p0)
		{
			const string __id = "putAccountId.(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutCity (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putCity' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putCity", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;", "GetPutCity_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutCity (string? p0)
		{
			const string __id = "putCity.(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putContinentCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutContinentCode_Ljava_lang_String_Handler ()
		{
			if (cb_putContinentCode_Ljava_lang_String_ == null)
				cb_putContinentCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutContinentCode_Ljava_lang_String_);
			return cb_putContinentCode_Ljava_lang_String_;
		}

		static IntPtr n_PutContinentCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutContinentCode (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putContinentCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putContinentCode", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;", "GetPutContinentCode_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutContinentCode (string? p0)
		{
			const string __id = "putContinentCode.(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutCountryCode (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putCountryCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putCountryCode", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;", "GetPutCountryCode_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutCountryCode (string? p0)
		{
			const string __id = "putCountryCode.(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutCountryName (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putCountryName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putCountryName", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;", "GetPutCountryName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutCountryName (string? p0)
		{
			const string __id = "putCountryName.(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutCustomAttributes (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putCustomAttributes' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("putCustomAttributes", "(Ljava/util/Map;)Lcom/gainsight/px/mobile/User;", "GetPutCustomAttributes_Ljava_util_Map_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutCustomAttributes (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>? p0)
		{
			const string __id = "putCustomAttributes.(Ljava/util/Map;)Lcom/gainsight/px/mobile/User;";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_putEmail_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutEmail_Ljava_lang_String_Handler ()
		{
			if (cb_putEmail_Ljava_lang_String_ == null)
				cb_putEmail_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutEmail_Ljava_lang_String_);
			return cb_putEmail_Ljava_lang_String_;
		}

		static IntPtr n_PutEmail_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutEmail (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putEmail' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putEmail", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;", "GetPutEmail_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutEmail (string? p0)
		{
			const string __id = "putEmail.(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putFirstName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutFirstName_Ljava_lang_String_Handler ()
		{
			if (cb_putFirstName_Ljava_lang_String_ == null)
				cb_putFirstName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutFirstName_Ljava_lang_String_);
			return cb_putFirstName_Ljava_lang_String_;
		}

		static IntPtr n_PutFirstName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutFirstName (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putFirstName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putFirstName", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;", "GetPutFirstName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutFirstName (string? p0)
		{
			const string __id = "putFirstName.(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putFirstVisitDate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutFirstVisitDate_Ljava_lang_String_Handler ()
		{
			if (cb_putFirstVisitDate_Ljava_lang_String_ == null)
				cb_putFirstVisitDate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutFirstVisitDate_Ljava_lang_String_);
			return cb_putFirstVisitDate_Ljava_lang_String_;
		}

		static IntPtr n_PutFirstVisitDate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutFirstVisitDate (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putFirstVisitDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putFirstVisitDate", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;", "GetPutFirstVisitDate_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutFirstVisitDate (string? p0)
		{
			const string __id = "putFirstVisitDate.(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putFirstVisitDate_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetPutFirstVisitDate_Ljava_util_Date_Handler ()
		{
			if (cb_putFirstVisitDate_Ljava_util_Date_ == null)
				cb_putFirstVisitDate_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutFirstVisitDate_Ljava_util_Date_);
			return cb_putFirstVisitDate_Ljava_util_Date_;
		}

		static IntPtr n_PutFirstVisitDate_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutFirstVisitDate (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putFirstVisitDate' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("putFirstVisitDate", "(Ljava/util/Date;)Lcom/gainsight/px/mobile/User;", "GetPutFirstVisitDate_Ljava_util_Date_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutFirstVisitDate (global::Java.Util.Date? p0)
		{
			const string __id = "putFirstVisitDate.(Ljava/util/Date;)Lcom/gainsight/px/mobile/User;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_putFirstVisitDate_J;
#pragma warning disable 0169
		static Delegate GetPutFirstVisitDate_JHandler ()
		{
			if (cb_putFirstVisitDate_J == null)
				cb_putFirstVisitDate_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_PutFirstVisitDate_J);
			return cb_putFirstVisitDate_J;
		}

		static IntPtr n_PutFirstVisitDate_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.PutFirstVisitDate (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putFirstVisitDate' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("putFirstVisitDate", "(J)Lcom/gainsight/px/mobile/User;", "GetPutFirstVisitDate_JHandler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutFirstVisitDate (long p0)
		{
			const string __id = "putFirstVisitDate.(J)Lcom/gainsight/px/mobile/User;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_putGender_Lcom_gainsight_px_mobile_User_Gender_;
#pragma warning disable 0169
		static Delegate GetPutGender_Lcom_gainsight_px_mobile_User_Gender_Handler ()
		{
			if (cb_putGender_Lcom_gainsight_px_mobile_User_Gender_ == null)
				cb_putGender_Lcom_gainsight_px_mobile_User_Gender_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutGender_Lcom_gainsight_px_mobile_User_Gender_);
			return cb_putGender_Lcom_gainsight_px_mobile_User_Gender_;
		}

		static IntPtr n_PutGender_Lcom_gainsight_px_mobile_User_Gender_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User.Gender> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutGender (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putGender' and count(parameter)=1 and parameter[1][@type='com.gainsight.px.mobile.User.Gender']]"
		[Register ("putGender", "(Lcom/gainsight/px/mobile/User$Gender;)Lcom/gainsight/px/mobile/User;", "GetPutGender_Lcom_gainsight_px_mobile_User_Gender_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutGender (global::Com.Gainsight.PX.Mobile.User.Gender? p0)
		{
			const string __id = "putGender.(Lcom/gainsight/px/mobile/User$Gender;)Lcom/gainsight/px/mobile/User;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_putIdentifyIdHash_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutIdentifyIdHash_Ljava_lang_String_Handler ()
		{
			if (cb_putIdentifyIdHash_Ljava_lang_String_ == null)
				cb_putIdentifyIdHash_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutIdentifyIdHash_Ljava_lang_String_);
			return cb_putIdentifyIdHash_Ljava_lang_String_;
		}

		static IntPtr n_PutIdentifyIdHash_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutIdentifyIdHash (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putIdentifyIdHash' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putIdentifyIdHash", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;", "GetPutIdentifyIdHash_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutIdentifyIdHash (string? p0)
		{
			const string __id = "putIdentifyIdHash.(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putLastName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutLastName_Ljava_lang_String_Handler ()
		{
			if (cb_putLastName_Ljava_lang_String_ == null)
				cb_putLastName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutLastName_Ljava_lang_String_);
			return cb_putLastName_Ljava_lang_String_;
		}

		static IntPtr n_PutLastName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutLastName (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putLastName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putLastName", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;", "GetPutLastName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutLastName (string? p0)
		{
			const string __id = "putLastName.(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.PutLatitude (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putLatitude' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("putLatitude", "(D)Lcom/gainsight/px/mobile/User;", "GetPutLatitude_DHandler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutLatitude (double p0)
		{
			const string __id = "putLatitude.(D)Lcom/gainsight/px/mobile/User;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_putLeadDate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutLeadDate_Ljava_lang_String_Handler ()
		{
			if (cb_putLeadDate_Ljava_lang_String_ == null)
				cb_putLeadDate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutLeadDate_Ljava_lang_String_);
			return cb_putLeadDate_Ljava_lang_String_;
		}

		static IntPtr n_PutLeadDate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutLeadDate (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putLeadDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putLeadDate", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;", "GetPutLeadDate_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutLeadDate (string? p0)
		{
			const string __id = "putLeadDate.(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putLeadDate_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetPutLeadDate_Ljava_util_Date_Handler ()
		{
			if (cb_putLeadDate_Ljava_util_Date_ == null)
				cb_putLeadDate_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutLeadDate_Ljava_util_Date_);
			return cb_putLeadDate_Ljava_util_Date_;
		}

		static IntPtr n_PutLeadDate_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutLeadDate (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putLeadDate' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("putLeadDate", "(Ljava/util/Date;)Lcom/gainsight/px/mobile/User;", "GetPutLeadDate_Ljava_util_Date_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutLeadDate (global::Java.Util.Date? p0)
		{
			const string __id = "putLeadDate.(Ljava/util/Date;)Lcom/gainsight/px/mobile/User;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_putLeadDate_J;
#pragma warning disable 0169
		static Delegate GetPutLeadDate_JHandler ()
		{
			if (cb_putLeadDate_J == null)
				cb_putLeadDate_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_PutLeadDate_J);
			return cb_putLeadDate_J;
		}

		static IntPtr n_PutLeadDate_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.PutLeadDate (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putLeadDate' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("putLeadDate", "(J)Lcom/gainsight/px/mobile/User;", "GetPutLeadDate_JHandler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutLeadDate (long p0)
		{
			const string __id = "putLeadDate.(J)Lcom/gainsight/px/mobile/User;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.PutLongitude (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putLongitude' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("putLongitude", "(D)Lcom/gainsight/px/mobile/User;", "GetPutLongitude_DHandler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutLongitude (double p0)
		{
			const string __id = "putLongitude.(D)Lcom/gainsight/px/mobile/User;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_putOrganizationDuns_J;
#pragma warning disable 0169
		static Delegate GetPutOrganizationDuns_JHandler ()
		{
			if (cb_putOrganizationDuns_J == null)
				cb_putOrganizationDuns_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_PutOrganizationDuns_J);
			return cb_putOrganizationDuns_J;
		}

		static IntPtr n_PutOrganizationDuns_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.PutOrganizationDuns (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putOrganizationDuns' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("putOrganizationDuns", "(J)Lcom/gainsight/px/mobile/User;", "GetPutOrganizationDuns_JHandler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutOrganizationDuns (long p0)
		{
			const string __id = "putOrganizationDuns.(J)Lcom/gainsight/px/mobile/User;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_putOrganizationEmployees_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutOrganizationEmployees_Ljava_lang_String_Handler ()
		{
			if (cb_putOrganizationEmployees_Ljava_lang_String_ == null)
				cb_putOrganizationEmployees_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutOrganizationEmployees_Ljava_lang_String_);
			return cb_putOrganizationEmployees_Ljava_lang_String_;
		}

		static IntPtr n_PutOrganizationEmployees_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutOrganizationEmployees (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putOrganizationEmployees' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putOrganizationEmployees", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;", "GetPutOrganizationEmployees_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutOrganizationEmployees (string? p0)
		{
			const string __id = "putOrganizationEmployees.(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putOrganizationIndustry_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutOrganizationIndustry_Ljava_lang_String_Handler ()
		{
			if (cb_putOrganizationIndustry_Ljava_lang_String_ == null)
				cb_putOrganizationIndustry_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutOrganizationIndustry_Ljava_lang_String_);
			return cb_putOrganizationIndustry_Ljava_lang_String_;
		}

		static IntPtr n_PutOrganizationIndustry_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutOrganizationIndustry (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putOrganizationIndustry' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putOrganizationIndustry", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;", "GetPutOrganizationIndustry_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutOrganizationIndustry (string? p0)
		{
			const string __id = "putOrganizationIndustry.(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putOrganizationName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutOrganizationName_Ljava_lang_String_Handler ()
		{
			if (cb_putOrganizationName_Ljava_lang_String_ == null)
				cb_putOrganizationName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutOrganizationName_Ljava_lang_String_);
			return cb_putOrganizationName_Ljava_lang_String_;
		}

		static IntPtr n_PutOrganizationName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutOrganizationName (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putOrganizationName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putOrganizationName", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;", "GetPutOrganizationName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutOrganizationName (string? p0)
		{
			const string __id = "putOrganizationName.(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putOrganizationRevenue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutOrganizationRevenue_Ljava_lang_String_Handler ()
		{
			if (cb_putOrganizationRevenue_Ljava_lang_String_ == null)
				cb_putOrganizationRevenue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutOrganizationRevenue_Ljava_lang_String_);
			return cb_putOrganizationRevenue_Ljava_lang_String_;
		}

		static IntPtr n_PutOrganizationRevenue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutOrganizationRevenue (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putOrganizationRevenue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putOrganizationRevenue", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;", "GetPutOrganizationRevenue_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutOrganizationRevenue (string? p0)
		{
			const string __id = "putOrganizationRevenue.(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putOrganizationSicCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutOrganizationSicCode_Ljava_lang_String_Handler ()
		{
			if (cb_putOrganizationSicCode_Ljava_lang_String_ == null)
				cb_putOrganizationSicCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutOrganizationSicCode_Ljava_lang_String_);
			return cb_putOrganizationSicCode_Ljava_lang_String_;
		}

		static IntPtr n_PutOrganizationSicCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutOrganizationSicCode (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putOrganizationSicCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putOrganizationSicCode", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;", "GetPutOrganizationSicCode_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutOrganizationSicCode (string? p0)
		{
			const string __id = "putOrganizationSicCode.(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putPhone_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutPhone_Ljava_lang_String_Handler ()
		{
			if (cb_putPhone_Ljava_lang_String_ == null)
				cb_putPhone_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutPhone_Ljava_lang_String_);
			return cb_putPhone_Ljava_lang_String_;
		}

		static IntPtr n_PutPhone_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutPhone (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putPhone' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putPhone", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;", "GetPutPhone_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutPhone (string? p0)
		{
			const string __id = "putPhone.(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutPostalCode (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putPostalCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putPostalCode", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;", "GetPutPostalCode_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutPostalCode (string? p0)
		{
			const string __id = "putPostalCode.(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutRegionName (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putRegionName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putRegionName", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;", "GetPutRegionName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutRegionName (string? p0)
		{
			const string __id = "putRegionName.(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putRole_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutRole_Ljava_lang_String_Handler ()
		{
			if (cb_putRole_Ljava_lang_String_ == null)
				cb_putRole_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutRole_Ljava_lang_String_);
			return cb_putRole_Ljava_lang_String_;
		}

		static IntPtr n_PutRole_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutRole (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putRole' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putRole", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;", "GetPutRole_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutRole (string? p0)
		{
			const string __id = "putRole.(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putScore_I;
#pragma warning disable 0169
		static Delegate GetPutScore_IHandler ()
		{
			if (cb_putScore_I == null)
				cb_putScore_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_PutScore_I);
			return cb_putScore_I;
		}

		static IntPtr n_PutScore_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.PutScore (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putScore' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("putScore", "(I)Lcom/gainsight/px/mobile/User;", "GetPutScore_IHandler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutScore (int p0)
		{
			const string __id = "putScore.(I)Lcom/gainsight/px/mobile/User;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutSfdcContactId (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putSfdcContactId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putSfdcContactId", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;", "GetPutSfdcContactId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutSfdcContactId (string? p0)
		{
			const string __id = "putSfdcContactId.(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putSignUpDate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutSignUpDate_Ljava_lang_String_Handler ()
		{
			if (cb_putSignUpDate_Ljava_lang_String_ == null)
				cb_putSignUpDate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutSignUpDate_Ljava_lang_String_);
			return cb_putSignUpDate_Ljava_lang_String_;
		}

		static IntPtr n_PutSignUpDate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutSignUpDate (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putSignUpDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putSignUpDate", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;", "GetPutSignUpDate_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutSignUpDate (string? p0)
		{
			const string __id = "putSignUpDate.(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putSignUpDate_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetPutSignUpDate_Ljava_util_Date_Handler ()
		{
			if (cb_putSignUpDate_Ljava_util_Date_ == null)
				cb_putSignUpDate_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutSignUpDate_Ljava_util_Date_);
			return cb_putSignUpDate_Ljava_util_Date_;
		}

		static IntPtr n_PutSignUpDate_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutSignUpDate (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putSignUpDate' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("putSignUpDate", "(Ljava/util/Date;)Lcom/gainsight/px/mobile/User;", "GetPutSignUpDate_Ljava_util_Date_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutSignUpDate (global::Java.Util.Date? p0)
		{
			const string __id = "putSignUpDate.(Ljava/util/Date;)Lcom/gainsight/px/mobile/User;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_putSignUpDate_J;
#pragma warning disable 0169
		static Delegate GetPutSignUpDate_JHandler ()
		{
			if (cb_putSignUpDate_J == null)
				cb_putSignUpDate_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_PutSignUpDate_J);
			return cb_putSignUpDate_J;
		}

		static IntPtr n_PutSignUpDate_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.PutSignUpDate (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putSignUpDate' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("putSignUpDate", "(J)Lcom/gainsight/px/mobile/User;", "GetPutSignUpDate_JHandler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutSignUpDate (long p0)
		{
			const string __id = "putSignUpDate.(J)Lcom/gainsight/px/mobile/User;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutStateCode (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putStateCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putStateCode", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;", "GetPutStateCode_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutStateCode (string? p0)
		{
			const string __id = "putStateCode.(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutStateName (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putStateName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putStateName", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;", "GetPutStateName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutStateName (string? p0)
		{
			const string __id = "putStateName.(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutStreet (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putStreet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putStreet", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;", "GetPutStreet_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutStreet (string? p0)
		{
			const string __id = "putStreet.(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutSubscriptionId (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putSubscriptionId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putSubscriptionId", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;", "GetPutSubscriptionId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutSubscriptionId (string? p0)
		{
			const string __id = "putSubscriptionId.(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutTimeZone (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putTimeZone' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putTimeZone", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;", "GetPutTimeZone_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutTimeZone (string? p0)
		{
			const string __id = "putTimeZone.(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_putTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutTitle_Ljava_lang_String_Handler ()
		{
			if (cb_putTitle_Ljava_lang_String_ == null)
				cb_putTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PutTitle_Ljava_lang_String_);
			return cb_putTitle_Ljava_lang_String_;
		}

		static IntPtr n_PutTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutTitle (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='putTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putTitle", "(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;", "GetPutTitle_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? PutTitle (string? p0)
		{
			const string __id = "putTitle.(Ljava/lang/String;)Lcom/gainsight/px/mobile/User;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.RegionName ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='regionName' and count(parameter)=0]"
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

		static Delegate? cb_role;
#pragma warning disable 0169
		static Delegate GetRoleHandler ()
		{
			if (cb_role == null)
				cb_role = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Role);
			return cb_role;
		}

		static IntPtr n_Role (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Role ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='role' and count(parameter)=0]"
		[Register ("role", "()Ljava/lang/String;", "GetRoleHandler")]
		public virtual unsafe string? Role ()
		{
			const string __id = "role.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_score;
#pragma warning disable 0169
		static Delegate GetScoreHandler ()
		{
			if (cb_score == null)
				cb_score = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_Score);
			return cb_score;
		}

		static int n_Score (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Score ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='score' and count(parameter)=0]"
		[Register ("score", "()I", "GetScoreHandler")]
		public virtual unsafe int Score ()
		{
			const string __id = "score.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.SfdcContactId ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='sfdcContactId' and count(parameter)=0]"
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

		static Delegate? cb_signUpDate;
#pragma warning disable 0169
		static Delegate GetSignUpDateHandler ()
		{
			if (cb_signUpDate == null)
				cb_signUpDate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_SignUpDate);
			return cb_signUpDate;
		}

		static IntPtr n_SignUpDate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.SignUpDate ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='signUpDate' and count(parameter)=0]"
		[Register ("signUpDate", "()Ljava/util/Date;", "GetSignUpDateHandler")]
		public virtual unsafe global::Java.Util.Date? SignUpDate ()
		{
			const string __id = "signUpDate.()Ljava/util/Date;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.StateCode ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='stateCode' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.StateName ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='stateName' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Street ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='street' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.SubscriptionId ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='subscriptionId' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.TimeZone ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='timeZone' and count(parameter)=0]"
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

		static Delegate? cb_title;
#pragma warning disable 0169
		static Delegate GetTitleHandler ()
		{
			if (cb_title == null)
				cb_title = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Title);
			return cb_title;
		}

		static IntPtr n_Title (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Title ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='title' and count(parameter)=0]"
		[Register ("title", "()Ljava/lang/String;", "GetTitleHandler")]
		public virtual unsafe string? Title ()
		{
			const string __id = "title.()Ljava/lang/String;";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.UnmodifiableCopy ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='User']/method[@name='unmodifiableCopy' and count(parameter)=0]"
		[Register ("unmodifiableCopy", "()Lcom/gainsight/px/mobile/User;", "GetUnmodifiableCopyHandler")]
		public virtual unsafe global::Com.Gainsight.PX.Mobile.User? UnmodifiableCopy ()
		{
			const string __id = "unmodifiableCopy.()Lcom/gainsight/px/mobile/User;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.User> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
