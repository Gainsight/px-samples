using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Gainsight.PX.Mobile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='EngagementMetaData']"
	[global::Android.Runtime.Register ("com/gainsight/px/mobile/EngagementMetaData", DoNotGenerateAcw=true)]
	public partial class EngagementMetaData : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='EngagementMetaData']/field[@name='actionData']"
		[Register ("actionData")]
		public string? ActionData {
			get {
				const string __id = "actionData.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "actionData.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='EngagementMetaData']/field[@name='actionText']"
		[Register ("actionText")]
		public string? ActionText {
			get {
				const string __id = "actionText.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "actionText.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='EngagementMetaData']/field[@name='actionType']"
		[Register ("actionType")]
		public string? ActionType {
			get {
				const string __id = "actionType.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "actionType.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='EngagementMetaData']/field[@name='engagementId']"
		[Register ("engagementId")]
		public string? EngagementId {
			get {
				const string __id = "engagementId.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "engagementId.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='EngagementMetaData']/field[@name='engagementName']"
		[Register ("engagementName")]
		public string? EngagementName {
			get {
				const string __id = "engagementName.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "engagementName.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='EngagementMetaData']/field[@name='params']"
		[Register ("params")]
		public global::Com.Gainsight.PX.Mobile.ValueMap? Params {
			get {
				const string __id = "params.Lcom/gainsight/px/mobile/ValueMap;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ValueMap> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "params.Lcom/gainsight/px/mobile/ValueMap;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.gainsight.px.mobile']/class[@name='EngagementMetaData']/field[@name='scope']"
		[Register ("scope")]
		public global::Com.Gainsight.PX.Mobile.ScreenEventData? Scope {
			get {
				const string __id = "scope.Lcom/gainsight/px/mobile/ScreenEventData;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Gainsight.PX.Mobile.ScreenEventData> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "scope.Lcom/gainsight/px/mobile/ScreenEventData;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/gainsight/px/mobile/EngagementMetaData", typeof (EngagementMetaData));

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

		protected EngagementMetaData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

	}
}
